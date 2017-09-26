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
            TransparentBackgrounds();
        }

        private void TransparentBackgrounds()
        {
            var pos1 = this.PointToScreen(panel3.Location);
            pos1 = pbBackgroundImage.PointToClient(pos1);
            panel3.Parent = pbBackgroundImage;
            panel3.Location = pos1;
            panel3.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(splitContainer1.Location);
            pos2 = pbBackgroundImage.PointToClient(pos2);
            splitContainer1.Parent = pbBackgroundImage;
            splitContainer1.Location = pos2;
            splitContainer1.BackColor = Color.Transparent;
        }

        public void loadDB()
        {
            //load the customer dgv
            DisplayDataGridViewCustomer();

            //load the movies dgv
            DisplayDataGridViewMovies();

            //load the rentals dgv
            DisplayDataGridViewRentals();

        }

        private void DisplayDataGridViewCustomer()
        {
            dgvCustomer.DataSource = null;
            try
            {
                dgvCustomer.DataSource = myDatabase.FillDGVCustomerWithCustomer();
                dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewMovies()
        {
            dgvMovies.DataSource = null;
            try
            {
                dgvMovies.DataSource = myDatabase.FillDGVMovieWithMovie();
                //dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvMovies.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvMovies.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMovies.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvMovies.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewRentals()
        {
            dgvRentals.DataSource = null;
            try
            {
                dgvRentals.DataSource = myDatabase.FillDGVRentalsWithRentals();
                //dgvRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvRentals.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvRentals.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvRentals.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvRentals.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRentals.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvRentals.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvRentals.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int CustomerID = 0;
            try
            {
                myDatabase.CustomerID = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
                lblCustID.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
