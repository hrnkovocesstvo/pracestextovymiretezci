using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pracestextovymiretezci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMezery_Click(object sender, EventArgs e)
        {
            textOut.Text = textIn.Text.Replace(" ", "");
        }

        private void buttonMala_Click(object sender, EventArgs e)
        {
            textOut.Text = textIn.Text.ToLower();
        }

        private void buttonDelka_Click(object sender, EventArgs e)
        {
            textOut.Text = textIn.TextLength.ToString();
        }

        private void buttonPočeta_Click(object sender, EventArgs e)
        {
            char[] chars = textIn.Text.ToCharArray();
            int count = chars.Count(c => c == 'a');
            textOut.Text = count.ToString();
        }

        private void buttonRewerse_Click(object sender, EventArgs e)
        {
            char[] chars = textIn.Text.ToCharArray();
            Array.Reverse(chars);
            string revchars = new string(chars);
            textOut.Text = revchars;
        }

        private void buttonPočetPp_Click(object sender, EventArgs e)
        {
            char[] chars = textIn.Text.ToCharArray();
            int count = chars.Count(c => c == 'p' || c == 'P');
            textOut.Text = count.ToString();
        }

        private void buttonPalindrom_Click(object sender, EventArgs e)
        {
            char[] chars = textIn.Text.ToCharArray();
            char[] chars2 = textIn.Text.ToCharArray();
            Array.Reverse(chars);
            string debout1 = new string(chars); 
            string debout2 = new string(chars2);
            if (debout1 == debout2) textOut.Text = "Pass";
            else textOut.Text = "Fail";

            Console.WriteLine(debout1);
            Console.WriteLine(debout2);
        }
    }
}
