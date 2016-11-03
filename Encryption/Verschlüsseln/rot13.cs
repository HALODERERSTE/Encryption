using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verschlüsseln
{
    public partial class rot13 : Form
    {
        private const string Key = "nopqrstuvwxyzabcdefghijklm";
        private const string ABC = "abcdefghijklmnopqrstuvwxyz";

        private string encryptet = "";

        public string encrypt
        {
            get { return encryptet; }
            set {; }
        }
        
        public rot13()
        {
            InitializeComponent();
        }
        
        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            txtEncryptet.Text = "";

            for (int i=0;i < txtInput.Text.Length; i++)
            {
                encryptet += Key[ABC.IndexOf(txtInput.Text[i])];
            }

            txtEncryptet.Text = this.encrypt;

            MessageBox.Show("coppyed to Clipboard!", "Info");
            Clipboard.SetText(this.encrypt);

        }

        private void rot13_Load(object sender, EventArgs e)
        {

        }
    }
}
