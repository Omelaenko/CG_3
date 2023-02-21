using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3 {
    public partial class Filter : Form {

        Bitmap source, res;
        int k = 3, k2 = 3;
        int[][] m = new int[3][];

        private void pictureBoxIn_Click(object sender, EventArgs e) {
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxIn.Image = image;
                    source = new Bitmap(image);
                    button_apply.Enabled = true;
                    buttonNoise.Enabled = true;
                }
            } catch {
                MessageBox.Show("Open file error\nPlease, try another file", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonMed_Click(object sender, EventArgs e) {
            textBoxM.Text = "m3";
            textBoxAdd.Text = "0";
            numerator.Text = "1";
            denominator.Text = "1";
        }

        private void buttonBox_Click(object sender, EventArgs e) {
            textBoxM.Lines = new[] { "1 1 1", "1 1 1", "1 1 1"};
            textBoxAdd.Text = "0";
            numerator.Text = "1";
            denominator.Text = "9";
        }

        private void buttonBlur_Click(object sender, EventArgs e) {
            textBoxM.Lines = new[] { "1 2 1", "2 4 2", "1 2 1" };
            textBoxAdd.Text = "0";
            numerator.Text = "1";
            denominator.Text = "16";
        }

        private void buttonSharp_Click(object sender, EventArgs e) {
            textBoxM.Lines = new[] { "-1 -2 -1", "-2 22 -2", "-1 -2 -1" };
            textBoxAdd.Text = "0";
            numerator.Text = "1";
            denominator.Text = "10";
        }

        private void buttonEdge_Click(object sender, EventArgs e) {
            //textBoxM.Lines = new[] { "0 -1 0", "-1 5 -1", "0 -1 0" };
            textBoxM.Lines = new[] { "-1 0 1", "-2 0 2", "-1 0 1" };
            textBoxAdd.Text = "0";
            numerator.Text = "1";
            denominator.Text = "1";
        }

        private void buttonEmb_Click(object sender, EventArgs e) {
            textBoxM.Lines = new[] { "0 1 0", "1 0 -1", "0 -1 0" };
            textBoxAdd.Text = "128";
            numerator.Text = "1";
            denominator.Text = "1";
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            try {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    res.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            } catch {
                MessageBox.Show("Save file error", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonLoadFilter_Click(object sender, EventArgs e) {
            try {
                if (openFileDialog2.ShowDialog() == DialogResult.OK) {
                    StreamReader sr = new StreamReader(openFileDialog2.FileName);
                    List<string> lines = new List<string>();
                    string line = sr.ReadLine();
                    while (line != null) {
                        lines.Add(line.ToString());
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    textBoxAdd.Text = lines[lines.Count - 3];
                    numerator.Text = lines[lines.Count - 2];
                    denominator.Text = lines[lines.Count - 1];
                    //lines = lines.Take(lines.Count - 1);
                    lines.RemoveAt(lines.Count - 1);
                    lines.RemoveAt(lines.Count - 1);
                    lines.RemoveAt(lines.Count - 1);
                    textBoxM.Lines = lines.ToArray();
                }
            } catch {
                MessageBox.Show("Load filter error", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonSaveFilter_Click(object sender, EventArgs e) {
            try {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK) {
                    StreamWriter sw = new StreamWriter(saveFileDialog2.FileName, true, Encoding.ASCII);

                    for (int i  = 0; i < textBoxM.Lines.Length; i++) {
                        sw.WriteLine(textBoxM.Lines[i]);
                    }
                    sw.WriteLine(textBoxAdd.Text);
                    sw.WriteLine(numerator.Text);
                    sw.WriteLine(denominator.Text);
                    sw.Close();
                }
            } catch {
                MessageBox.Show("Save filter error", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonNoise_Click(object sender, EventArgs e) {
            float noisePower = 40;
            var rnd = new Random();
            for (int i = 0; i < source.Width; i++) {
                for (int j = 0; j < source.Height; j++) {
                    Color c = source.GetPixel(i, j);
                    //int noise = Convert.ToInt32((rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() - 2) * noisePower);
                    int noise = Convert.ToInt32((rnd.NextDouble()*2-1)*noisePower);
                    source.SetPixel(i, j, Color.FromArgb(c.A, Math.Max(Math.Min(c.R + noise, 255), 0), Math.Max(Math.Min(c.G + noise, 255), 0), Math.Max(Math.Min(c.R + noise, 255), 0)));
                }
            }

            pictureBoxIn.Image = source;
            MessageBox.Show("Done!", "Message", MessageBoxButtons.OK);
        }

        private void button_apply_Click(object sender, EventArgs e) {
            if (textBoxM.Lines.Length == 0 || numerator.Text == "" || denominator.Text == "") {
                MessageBox.Show("Error\nFill the missing fields", "Error", MessageBoxButtons.OK);
                return;
            }
            string[] subs = textBoxM.Lines;
            int tk = subs.Length, tk2 = subs[0].Split(' ').Length;
            int[][] tm = new int[tk][];

            progressBar1.Value = 0;
            int median = 0;
            for (int i = 0; i < tk; i++) {
                tm[i] = new int[tk2];
                //Console.WriteLine(subs[i]);
                string[] row = subs[i].Split(' ');
                if (row.Length != tk2 && i != tk-1) {
                    MessageBox.Show("Wrong size Matrix", "Error", MessageBoxButtons.OK);
                    return;
                }
                for(int j = 0;j < tk2; j++) {
                    //Console.Write(row[j]);
                    if(row[j][0] == 'm'){
                        try {
                            median = Convert.ToInt32(row[j].Substring(1));
                        } catch {
                            MessageBox.Show("Wrong size median filter", "Error", MessageBoxButtons.OK);
                            return;
                        }
                        break;
                    }
                    try {
                        tm[i][j] = Convert.ToInt32(row[j]);
                    } catch {
                        MessageBox.Show("Wrong value", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
                if (median > 0) {
                    break;
                }
                //Console.WriteLine(' ');
            }
            k = tk;
            k2 = tk2;
            m = tm;
            int num = Convert.ToInt32(numerator.Text), den = Convert.ToInt32(denominator.Text);
            if (den == 0)
            {
                MessageBox.Show("Error\nDivision by zero", "Error", MessageBoxButtons.OK);
                return;
            }
            //int sumx = 0;
            /*
            if (median == 0) {
                for (int i = 0; i < k; i++) {
                    for (int j = 0; j < k2; j++) {
                        Console.Write(m[i][j]);
                        sumx += m[i][j];
                    }
                    Console.WriteLine(' ');
                }
            } else {
                k = median;
            }
            */
            if (median != 0) {
                k = median;
            }
            //sumx += Convert.ToInt32(sumx == 0);

            res = new Bitmap(source);
            int add = 0;
            try {
                add = Convert.ToInt32(textBoxAdd.Text);
                //Console.WriteLine("add");
                //Console.WriteLine(add);
            } catch {
                add = 0;
            }

            for (int i = k; i < source.Width; i++) {
                for (int j = k; j < source.Height; j++) {
                    Color color = source.GetPixel(i, j);
                    int[] t = new int[3];
                    if (median == 0) {
                        for (int x = 0; x < k; x++) {
                            for (int y = 0; y < k; y++) {
                                Color c2 = source.GetPixel(i - x, j - y);
                                t[0] += m[x][y] * c2.R;
                                t[1] += m[x][y] * c2.G;
                                t[2] += m[x][y] * c2.B;
                            }
                        }
                        //t[0] = Math.Max(0, Math.Min(Math.Abs(t[0] + add) / sumx, 255));
                        //t[1] = Math.Max(0, Math.Min(Math.Abs(t[1] + add) / sumx, 255));
                        //t[2] = Math.Max(0, Math.Min(Math.Abs(t[2] + add) / sumx, 255));
                        t[0] = Math.Max(0, Math.Min(Math.Abs(t[0] + add) * num / den, 255));
                        t[1] = Math.Max(0, Math.Min(Math.Abs(t[1] + add) * num / den, 255));
                        t[2] = Math.Max(0, Math.Min(Math.Abs(t[2] + add) * num / den, 255));
                    } else {
                        int[][] tt = new int[3][];
                        tt[0] = new int[k * k];
                        tt[1] = new int[k * k];
                        tt[2] = new int[k * k];
                        //tt[3] = new int[k * k];
                        for (int x = 0; x < k; x++) {
                            for (int y = 0; y < k; y++) {
                                Color c2 = source.GetPixel(i - x, j - y);
                                tt[0][x*k + y] = c2.R;
                                tt[1][x*k + y] = c2.G;
                                tt[2][x*k + y] = c2.B;
                            }
                        }
                        Array.Sort(tt[0]);
                        Array.Sort(tt[1]);
                        Array.Sort(tt[2]);
                        int size = tt[0].Length;
                        int mid = size / 2;
                        t[0] = (size % 2 != 0) ? tt[0][mid] : (tt[0][mid] + tt[0][mid - 1]) / 2;
                        t[1] = (size % 2 != 0) ? tt[1][mid] : (tt[1][mid] + tt[1][mid - 1]) / 2;
                        t[2] = (size % 2 != 0) ? tt[2][mid] : (tt[2][mid] + tt[2][mid - 1]) / 2;
                        //t[3] = (size % 2 != 0) ? tt[3][mid] : (tt[3][mid] + tt[3][mid - 1]) / 2;
                    }
                    res.SetPixel(i, j, Color.FromArgb(color.A, t[0], t[1], t[2]));
                    //res.SetPixel(i, j, Color.FromArgb(t[3], t[0], t[1], t[2]));
                }
                progressBar1.Value = (int) (Convert.ToDouble(i) / source.Width) * 100;
            }
            progressBar1.Value = 100;
            pictureBoxOut.Image = res;
            buttonSave.Enabled = true;
        }

        public Filter() {
            InitializeComponent();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg";
            openFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg";
            saveFileDialog1.FilterIndex = 2;
            
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.Filter = "txt files (*.txt)|*.txt";
            openFileDialog2.FilterIndex = 1;
            saveFileDialog2.RestoreDirectory = true;
            saveFileDialog2.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog2.FilterIndex = 1;

            return;
        }

    }
}
