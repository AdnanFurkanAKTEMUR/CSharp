namespace b191210307_odev3
{
    partial class Alert
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
            this.alertLabel = new System.Windows.Forms.Label();
            this.alertbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alertLabel.Location = new System.Drawing.Point(0, 0);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(142, 29);
            this.alertLabel.TabIndex = 0;
            this.alertLabel.Text = "Stokta yok";
            this.alertLabel.Click += new System.EventHandler(this.alertLabel_Click);
            // 
            // alertbtn
            // 
            this.alertbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alertbtn.Location = new System.Drawing.Point(0, 63);
            this.alertbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alertbtn.Name = "alertbtn";
            this.alertbtn.Size = new System.Drawing.Size(445, 48);
            this.alertbtn.TabIndex = 1;
            this.alertbtn.Text = "KAPAT";
            this.alertbtn.UseVisualStyleBackColor = true;
            this.alertbtn.Click += new System.EventHandler(this.alertbtn_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 111);
            this.Controls.Add(this.alertbtn);
            this.Controls.Add(this.alertLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Alert";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button alertbtn;
        public System.Windows.Forms.Label alertLabel;
    }
}