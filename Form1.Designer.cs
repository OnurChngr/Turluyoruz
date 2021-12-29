
namespace arabaaClass
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHizlan = new System.Windows.Forms.Button();
            this.btnYavas = new System.Windows.Forms.Button();
            this.lstAraba = new System.Windows.Forms.ListBox();
            this.timeYil = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeYil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "plaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "yıl:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(92, 30);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(92, 76);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(92, 119);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 196);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHizlan
            // 
            this.btnHizlan.Location = new System.Drawing.Point(337, 43);
            this.btnHizlan.Name = "btnHizlan";
            this.btnHizlan.Size = new System.Drawing.Size(75, 62);
            this.btnHizlan.TabIndex = 1;
            this.btnHizlan.Text = "Hızlan";
            this.btnHizlan.UseVisualStyleBackColor = true;
            this.btnHizlan.Click += new System.EventHandler(this.btnHizlan_Click);
            // 
            // btnYavas
            // 
            this.btnYavas.Location = new System.Drawing.Point(337, 135);
            this.btnYavas.Name = "btnYavas";
            this.btnYavas.Size = new System.Drawing.Size(75, 58);
            this.btnYavas.TabIndex = 2;
            this.btnYavas.Text = "Yavaşla";
            this.btnYavas.UseVisualStyleBackColor = true;
            this.btnYavas.Click += new System.EventHandler(this.btnYavas_Click);
            // 
            // lstAraba
            // 
            this.lstAraba.FormattingEnabled = true;
            this.lstAraba.Location = new System.Drawing.Point(450, 43);
            this.lstAraba.Name = "lstAraba";
            this.lstAraba.Size = new System.Drawing.Size(161, 186);
            this.lstAraba.TabIndex = 3;
            // 
            // timeYil
            // 
            this.timeYil.Location = new System.Drawing.Point(92, 159);
            this.timeYil.Name = "timeYil";
            this.timeYil.Size = new System.Drawing.Size(200, 20);
            this.timeYil.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAraba);
            this.Controls.Add(this.btnYavas);
            this.Controls.Add(this.btnHizlan);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHizlan;
        private System.Windows.Forms.Button btnYavas;
        private System.Windows.Forms.ListBox lstAraba;
        private System.Windows.Forms.DateTimePicker timeYil;
    }
}

