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
    public partial class rot5 : Form
    {
        private const string Key = "fghijklmnopqrstuvwxyzabcde";
        private const string ABC = "abcdefghijklmnopqrstuvwxyz";

        private string encryptet = "";

        public string encrypt
        {
            get {return encryptet;}
            set {; }
        }

        public rot5()
        {
            InitializeComponent();
        }

        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < txtInput.Text.Length; i++)
            {
                encryptet += Key[ABC.IndexOf(txtInput.Text[i])];
            }

            txtEncryptet.Text = this.encrypt;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
