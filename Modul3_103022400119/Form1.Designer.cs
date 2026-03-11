namespace Modul3_103022400119
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmBxSatuanAwal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            buttonConvert = new Button();
            textBoxNilaiAwal = new TextBox();
            label3 = new Label();
            cmBxSatuanAkhir = new ComboBox();
            label4 = new Label();
            textBoxNilaiAkhir = new TextBox();
            SuspendLayout();
            // 
            // cmBxSatuanAwal
            // 
            cmBxSatuanAwal.FormattingEnabled = true;
            cmBxSatuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cmBxSatuanAwal.Location = new Point(64, 136);
            cmBxSatuanAwal.Name = "cmBxSatuanAwal";
            cmBxSatuanAwal.Size = new Size(151, 28);
            cmBxSatuanAwal.TabIndex = 0;
            cmBxSatuanAwal.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 113);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 113);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Nilai Awal";
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(553, 136);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(94, 29);
            buttonConvert.TabIndex = 4;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += button1_Click;
            // 
            // textBoxNilaiAwal
            // 
            textBoxNilaiAwal.Location = new Point(287, 136);
            textBoxNilaiAwal.Name = "textBoxNilaiAwal";
            textBoxNilaiAwal.Size = new Size(221, 27);
            textBoxNilaiAwal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 205);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 6;
            label3.Text = "Satuan Akhir";
            // 
            // cmBxSatuanAkhir
            // 
            cmBxSatuanAkhir.FormattingEnabled = true;
            cmBxSatuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cmBxSatuanAkhir.Location = new Point(64, 228);
            cmBxSatuanAkhir.Name = "cmBxSatuanAkhir";
            cmBxSatuanAkhir.Size = new Size(151, 28);
            cmBxSatuanAkhir.TabIndex = 7;
            cmBxSatuanAkhir.SelectedIndexChanged += cmBxSatuanAkhir_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 205);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 8;
            label4.Text = "Nilai Awal";
            // 
            // textBoxNilaiAkhir
            // 
            textBoxNilaiAkhir.Location = new Point(287, 228);
            textBoxNilaiAkhir.Name = "textBoxNilaiAkhir";
            textBoxNilaiAkhir.Size = new Size(221, 27);
            textBoxNilaiAkhir.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNilaiAkhir);
            Controls.Add(label4);
            Controls.Add(cmBxSatuanAkhir);
            Controls.Add(label3);
            Controls.Add(textBoxNilaiAwal);
            Controls.Add(buttonConvert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmBxSatuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmBxSatuanAwal;
        private Label label1;
        private Label label2;
        private Button buttonConvert;
        private TextBox textBoxNilaiAwal;
        private Label label3;
        private ComboBox cmBxSatuanAkhir;
        private Label label4;
        private TextBox textBoxNilaiAkhir;
    }
}
