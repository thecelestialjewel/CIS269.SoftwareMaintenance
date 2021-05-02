using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _269HashSalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String GenerateSalt()
        {
            // using System.Security.Cryptography;
            RNGCryptoServiceProvider rng = 
                new RNGCryptoServiceProvider();
            byte[] salt = new byte[7]; // doesn't have to be big
            rng.GetBytes(salt);
            return Convert.ToBase64String(salt);

        }

        private String GetHash(string Password, string Salt)
        {
            SHA512Managed shahash = new SHA512Managed();
            byte[] input = Encoding.UTF8.GetBytes(Password 
                + Salt);

            byte[] output = shahash.ComputeHash(input);

            return Convert.ToBase64String(output);
        }

        private void btnGenSalt_Click(object sender, EventArgs e)
        {
            txtSalt.Text = GenerateSalt();

        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            txtSHPass.Text = GetHash(txtPass.Text, txtSalt.Text);

        }
    }
}
