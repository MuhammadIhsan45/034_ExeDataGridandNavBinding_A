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
    public partial class DataGrid : Form
    {
        Image image3;
        public DataGrid(Image image1)
        {
            InitializeComponent();
            image3 = Image.FromFile(@"..\..\Pic\png-clipart-arrow-font-awesome-computer-icons-back-to-back-angle-logo.png");
            

            pictureBox1.Image = image3;
            
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 dg = new Form2();
            dg.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            Detail2 dg = new Detail2();
            dg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
