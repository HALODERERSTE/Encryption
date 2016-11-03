namespace Verschlüsseln
{
    partial class rot13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rot13));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEcrypt = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtEncryptet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 78);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "encryptet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "To encrypt:";
            // 
            // btnEcrypt
            // 
            this.btnEcrypt.Location = new System.Drawing.Point(228, 78);
            this.btnEcrypt.Name = "btnEcrypt";
            this.btnEcrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEcrypt.TabIndex = 9;
            this.btnEcrypt.Text = "encrypt";
            this.btnEcrypt.UseVisualStyleBackColor = true;
            this.btnEcrypt.Click += new System.EventHandler(this.btnEcrypt_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(79, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(224, 20);
            this.txtInput.TabIndex = 8;
            // 
            // txtEncryptet
            // 
            this.txtEncryptet.Location = new System.Drawing.Point(79, 52);
            this.txtEncryptet.Name = "txtEncryptet";
            this.txtEncryptet.ReadOnly = true;
            this.txtEncryptet.Size = new System.Drawing.Size(224, 20);
            this.txtEncryptet.TabIndex = 7;
            // 
            // rot13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 143);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEcrypt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtEncryptet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rot13";
            this.Text = "ROT 13";
            this.Load += new System.EventHandler(this.rot13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEcrypt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtEncryptet;
    }
}