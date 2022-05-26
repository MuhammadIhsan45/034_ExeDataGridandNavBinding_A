using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {
        Image image1;
        Image image2;
        
        public Form2()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\Pic\1005153.png");
            image2 = Image.FromFile(@"..\..\Pic\bracket-icon-13-1771447653");
            

            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            DataGrid dg = new DataGrid(image1);
            dg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Detail dt = new Detail(image2);
            dt.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
