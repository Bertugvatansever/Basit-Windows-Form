
namespace Ödev1
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
            this.ogrencibox = new System.Windows.Forms.CheckBox();
            this.kdvbox = new System.Windows.Forms.CheckBox();
            this.lbltutar = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.txtsatis = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrencibox
            // 
            this.ogrencibox.AutoSize = true;
            this.ogrencibox.Location = new System.Drawing.Point(30, 101);
            this.ogrencibox.Name = "ogrencibox";
            this.ogrencibox.Size = new System.Drawing.Size(152, 21);
            this.ogrencibox.TabIndex = 0;
            this.ogrencibox.Text = "%5 Öğrenci İndirimi";
            this.ogrencibox.UseVisualStyleBackColor = true;
            this.ogrencibox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kdvbox
            // 
            this.kdvbox.AutoSize = true;
            this.kdvbox.Location = new System.Drawing.Point(30, 64);
            this.kdvbox.Name = "kdvbox";
            this.kdvbox.Size = new System.Drawing.Size(126, 21);
            this.kdvbox.TabIndex = 1;
            this.kdvbox.Text = "%18 KDV Dahil";
            this.kdvbox.UseVisualStyleBackColor = true;
            this.kdvbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Location = new System.Drawing.Point(4, 148);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(84, 17);
            this.lbltutar.TabIndex = 2;
            this.lbltutar.Text = "Satış Tutarı:";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(27, 15);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(80, 17);
            this.lblfiyat.TabIndex = 3;
            this.lblfiyat.Text = "Ürün Fiyatı:";
            // 
            // txtsatis
            // 
            this.txtsatis.Location = new System.Drawing.Point(94, 145);
            this.txtsatis.Multiline = true;
            this.txtsatis.Name = "txtsatis";
            this.txtsatis.Size = new System.Drawing.Size(125, 29);
            this.txtsatis.TabIndex = 4;
            this.txtsatis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(113, 15);
            this.txtfiyat.Multiline = true;
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(124, 28);
            this.txtfiyat.TabIndex = 5;
            this.txtfiyat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtsatis);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.kdvbox);
            this.Controls.Add(this.ogrencibox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ogrencibox;
        private System.Windows.Forms.CheckBox kdvbox;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox txtsatis;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Button button1;
    }
}

