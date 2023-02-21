namespace Lab3 {
    partial class Filter {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSharp = new System.Windows.Forms.Button();
            this.buttonEdge = new System.Windows.Forms.Button();
            this.buttonEmb = new System.Windows.Forms.Button();
            this.buttonMed = new System.Windows.Forms.Button();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonBox = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveFilter = new System.Windows.Forms.Button();
            this.buttonLoadFilter = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.numerator = new System.Windows.Forms.TextBox();
            this.denominator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxM
            // 
            this.textBoxM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxM.Location = new System.Drawing.Point(335, 858);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxM.MaximumSize = new System.Drawing.Size(265, 245);
            this.textBoxM.MinimumSize = new System.Drawing.Size(132, 122);
            this.textBoxM.Multiline = true;
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxM.Size = new System.Drawing.Size(132, 122);
            this.textBoxM.TabIndex = 0;
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(476, 858);
            this.button_apply.Margin = new System.Windows.Forms.Padding(4);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(100, 28);
            this.button_apply.TabIndex = 1;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIn.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxIn.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(934, 825);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIn.TabIndex = 2;
            this.pictureBoxIn.TabStop = false;
            this.pictureBoxIn.Click += new System.EventHandler(this.pictureBoxIn_Click);
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOut.Location = new System.Drawing.Point(955, 13);
            this.pictureBoxOut.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(934, 825);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOut.TabIndex = 3;
            this.pictureBoxOut.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(692, 858);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1197, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // buttonSharp
            // 
            this.buttonSharp.Location = new System.Drawing.Point(121, 858);
            this.buttonSharp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSharp.Name = "buttonSharp";
            this.buttonSharp.Size = new System.Drawing.Size(100, 28);
            this.buttonSharp.TabIndex = 5;
            this.buttonSharp.Text = "Sharp";
            this.buttonSharp.UseVisualStyleBackColor = true;
            this.buttonSharp.Click += new System.EventHandler(this.buttonSharp_Click);
            // 
            // buttonEdge
            // 
            this.buttonEdge.Location = new System.Drawing.Point(121, 905);
            this.buttonEdge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdge.Name = "buttonEdge";
            this.buttonEdge.Size = new System.Drawing.Size(100, 28);
            this.buttonEdge.TabIndex = 6;
            this.buttonEdge.Text = "Edge";
            this.buttonEdge.UseVisualStyleBackColor = true;
            this.buttonEdge.Click += new System.EventHandler(this.buttonEdge_Click);
            // 
            // buttonEmb
            // 
            this.buttonEmb.Location = new System.Drawing.Point(121, 949);
            this.buttonEmb.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmb.Name = "buttonEmb";
            this.buttonEmb.Size = new System.Drawing.Size(100, 28);
            this.buttonEmb.TabIndex = 7;
            this.buttonEmb.Text = "Embossing";
            this.buttonEmb.UseVisualStyleBackColor = true;
            this.buttonEmb.Click += new System.EventHandler(this.buttonEmb_Click);
            // 
            // buttonMed
            // 
            this.buttonMed.Location = new System.Drawing.Point(13, 949);
            this.buttonMed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMed.Name = "buttonMed";
            this.buttonMed.Size = new System.Drawing.Size(100, 28);
            this.buttonMed.TabIndex = 10;
            this.buttonMed.Text = "Median";
            this.buttonMed.UseVisualStyleBackColor = true;
            this.buttonMed.Click += new System.EventHandler(this.buttonMed_Click);
            // 
            // buttonBlur
            // 
            this.buttonBlur.Location = new System.Drawing.Point(13, 858);
            this.buttonBlur.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(100, 28);
            this.buttonBlur.TabIndex = 9;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.Location = new System.Drawing.Point(13, 905);
            this.buttonBox.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(100, 28);
            this.buttonBox.TabIndex = 8;
            this.buttonBox.Text = "Box";
            this.buttonBox.UseVisualStyleBackColor = true;
            this.buttonBox.Click += new System.EventHandler(this.buttonBox_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(476, 952);
            this.textBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdd.TabIndex = 11;
            this.textBoxAdd.Text = "0";
            this.textBoxAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(476, 905);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveFilter
            // 
            this.buttonSaveFilter.Location = new System.Drawing.Point(584, 905);
            this.buttonSaveFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveFilter.Name = "buttonSaveFilter";
            this.buttonSaveFilter.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveFilter.TabIndex = 14;
            this.buttonSaveFilter.Text = "Save Filter";
            this.buttonSaveFilter.UseVisualStyleBackColor = true;
            this.buttonSaveFilter.Click += new System.EventHandler(this.buttonSaveFilter_Click);
            // 
            // buttonLoadFilter
            // 
            this.buttonLoadFilter.Location = new System.Drawing.Point(584, 858);
            this.buttonLoadFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadFilter.Name = "buttonLoadFilter";
            this.buttonLoadFilter.Size = new System.Drawing.Size(100, 28);
            this.buttonLoadFilter.TabIndex = 13;
            this.buttonLoadFilter.Text = "Load Filter";
            this.buttonLoadFilter.UseVisualStyleBackColor = true;
            this.buttonLoadFilter.Click += new System.EventHandler(this.buttonLoadFilter_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // buttonNoise
            // 
            this.buttonNoise.Enabled = false;
            this.buttonNoise.Location = new System.Drawing.Point(584, 949);
            this.buttonNoise.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(100, 28);
            this.buttonNoise.TabIndex = 15;
            this.buttonNoise.Text = "Add Noise";
            this.buttonNoise.UseVisualStyleBackColor = true;
            this.buttonNoise.Click += new System.EventHandler(this.buttonNoise_Click);
            // 
            // numerator
            // 
            this.numerator.Location = new System.Drawing.Point(228, 893);
            this.numerator.Name = "numerator";
            this.numerator.Size = new System.Drawing.Size(100, 22);
            this.numerator.TabIndex = 16;
            this.numerator.Text = "1";
            this.numerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // denominator
            // 
            this.denominator.Location = new System.Drawing.Point(228, 921);
            this.denominator.Name = "denominator";
            this.denominator.Size = new System.Drawing.Size(100, 22);
            this.denominator.TabIndex = 17;
            this.denominator.Text = "1";
            this.denominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.denominator);
            this.Controls.Add(this.numerator);
            this.Controls.Add(this.buttonNoise);
            this.Controls.Add(this.buttonSaveFilter);
            this.Controls.Add(this.buttonLoadFilter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonMed);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.buttonEmb);
            this.Controls.Add(this.buttonEdge);
            this.Controls.Add(this.buttonSharp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBoxOut);
            this.Controls.Add(this.pictureBoxIn);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.textBoxM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Filter";
            this.Text = "Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSharp;
        private System.Windows.Forms.Button buttonEdge;
        private System.Windows.Forms.Button buttonEmb;
        private System.Windows.Forms.Button buttonMed;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.Button buttonBox;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSaveFilter;
        private System.Windows.Forms.Button buttonLoadFilter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.TextBox numerator;
        private System.Windows.Forms.TextBox denominator;
    }
}

