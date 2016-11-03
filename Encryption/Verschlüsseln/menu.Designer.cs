namespace Verschlüsseln
{
    partial class menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.clEncrypt = new System.Windows.Forms.CheckedListBox();
            this.bntChoose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clEncrypt
            // 
            this.clEncrypt.FormattingEnabled = true;
            this.clEncrypt.Items.AddRange(new object[] {
            "ROT 5",
            "ROT 13",
            "XOR",
            "MD5 HASH"});
            this.clEncrypt.Location = new System.Drawing.Point(12, 12);
            this.clEncrypt.Name = "clEncrypt";
            this.clEncrypt.Size = new System.Drawing.Size(120, 64);
            this.clEncrypt.TabIndex = 0;
            // 
            // bntChoose
            // 
            this.bntChoose.Location = new System.Drawing.Point(138, 12);
            this.bntChoose.Name = "bntChoose";
            this.bntChoose.Size = new System.Drawing.Size(80, 23);
            this.bntChoose.TabIndex = 1;
            this.bntChoose.Text = "choose";
            this.bntChoose.UseVisualStyleBackColor = true;
            this.bntChoose.Click += new System.EventHandler(this.bntChoose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(138, 53);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 89);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bntChoose);
            this.Controls.Add(this.clEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clEncrypt;
        private System.Windows.Forms.Button bntChoose;
        private System.Windows.Forms.Button btnExit;
    }
}

