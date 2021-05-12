
namespace MeyveSikacagi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Basla_btn = new System.Windows.Forms.Button();
            this.Bekle_btn = new System.Windows.Forms.Button();
            this.narenciye_btn = new System.Windows.Forms.Button();
            this.kati_meyve_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 259);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Basla_btn
            // 
            this.Basla_btn.Location = new System.Drawing.Point(286, 27);
            this.Basla_btn.Name = "Basla_btn";
            this.Basla_btn.Size = new System.Drawing.Size(151, 68);
            this.Basla_btn.TabIndex = 1;
            this.Basla_btn.Text = "Başla";
            this.Basla_btn.UseVisualStyleBackColor = true;
            // 
            // Bekle_btn
            // 
            this.Bekle_btn.Location = new System.Drawing.Point(475, 27);
            this.Bekle_btn.Name = "Bekle_btn";
            this.Bekle_btn.Size = new System.Drawing.Size(151, 68);
            this.Bekle_btn.TabIndex = 2;
            this.Bekle_btn.Text = "Bekle";
            this.Bekle_btn.UseVisualStyleBackColor = true;
            // 
            // narenciye_btn
            // 
            this.narenciye_btn.Location = new System.Drawing.Point(286, 117);
            this.narenciye_btn.Name = "narenciye_btn";
            this.narenciye_btn.Size = new System.Drawing.Size(151, 68);
            this.narenciye_btn.TabIndex = 3;
            this.narenciye_btn.Text = "Narenciye Sık";
            this.narenciye_btn.UseVisualStyleBackColor = true;
            // 
            // kati_meyve_btn
            // 
            this.kati_meyve_btn.Location = new System.Drawing.Point(475, 117);
            this.kati_meyve_btn.Name = "kati_meyve_btn";
            this.kati_meyve_btn.Size = new System.Drawing.Size(151, 68);
            this.kati_meyve_btn.TabIndex = 4;
            this.kati_meyve_btn.Text = "Katı Meyve Sık";
            this.kati_meyve_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(726, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Son Sıkılan Meyvenin Değerleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "A Vitamini :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "C Vitamini :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kati_meyve_btn);
            this.Controls.Add(this.narenciye_btn);
            this.Controls.Add(this.Bekle_btn);
            this.Controls.Add(this.Basla_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Basla_btn;
        private System.Windows.Forms.Button Bekle_btn;
        private System.Windows.Forms.Button narenciye_btn;
        private System.Windows.Forms.Button kati_meyve_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

