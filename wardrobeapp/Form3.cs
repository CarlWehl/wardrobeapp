using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobeapp
{
    public partial class Form3 : Form
    {
        string imgpath = "C:\\Users\\spike\\source\\repos\\wardrobeapp\\wardrobeapp\\img\\";
        public Form3()
        {
            InitializeComponent();
            pb1.Image = System.Drawing.Image.FromFile(imgpath + "hanged_logo.png");
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
