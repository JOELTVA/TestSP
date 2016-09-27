using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labbarna.DAL;

namespace Labbarna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            DataSet ds = new DataSet();
            //ds = DAL.DBUTILs.spCarBrand(70000);
            ds = DAL.DBUTILs.spSearchVariabel("dept");

            dataGridViewTest.DataSource = ds.Tables[0];


          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
