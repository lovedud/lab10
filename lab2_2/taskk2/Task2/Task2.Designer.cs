namespace lab2
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filePathLabel = new System.Windows.Forms.Label();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barChartPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filePathLabel
            // 
            this.filePathLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathLabel.Location = new System.Drawing.Point(197, 22);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(659, 23);
            this.filePathLabel.TabIndex = 0;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFileButton.Location = new System.Drawing.Point(12, 12);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(168, 39);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Выберите файл";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 57);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(468, 373);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePictureBox.TabIndex = 2;
            this.sourcePictureBox.TabStop = false;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "",
            "R",
            "G",
            "B"});
            this.colorComboBox.Location = new System.Drawing.Point(876, 19);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(86, 27);
            this.colorComboBox.TabIndex = 3;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(494, 57);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(468, 373);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 4;
            this.resultPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Гистограмма";
            // 
            // barChartPictureBox
            // 
            this.barChartPictureBox.Location = new System.Drawing.Point(232, 471);
            this.barChartPictureBox.Name = "barChartPictureBox";
            this.barChartPictureBox.Size = new System.Drawing.Size(512, 200);
            this.barChartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barChartPictureBox.TabIndex = 6;
            this.barChartPictureBox.TabStop = false;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 689);
            this.Controls.Add(this.barChartPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.sourcePictureBox);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.filePathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button chooseFileButton;
        public System.Windows.Forms.PictureBox sourcePictureBox;
        public System.Windows.Forms.ComboBox colorComboBox;
        public System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox barChartPictureBox;
    }
}