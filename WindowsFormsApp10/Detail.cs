using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    public partial class Detail : Form
    {
       
        public Detail(Image image2)
        {
            InitializeComponent();
            
            
        }
        SqlConnection conn = new SqlConnection("data source = IHSAN\\MUHAMMADIHSAN; database = Login; User ID = sa; Password = 123");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet2.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet2.Mahasiswa);

        }

        private void mahasiswaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            


            this.Validate();
            this.mahasiswaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prodiTIDataSet2);

        }

        private void text1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
