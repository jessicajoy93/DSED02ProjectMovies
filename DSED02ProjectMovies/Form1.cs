using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED02ProjectMovies
{
    public partial class Form1 : Form
    {
        //create an instance of the Database Class
        Database myDatabase = new Database();

        public Form1()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            //load the customer dgv
            DisplayDataGridViewCustomer();

        }

        private void DisplayDataGridViewCustomer()
        {
            dgvCustomer.DataSource = null;
            try
            {
                dgvCustomer.DataSource = myDatabase.FillDGVCustomerWithCustomer();
                //dgvCustomers.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
