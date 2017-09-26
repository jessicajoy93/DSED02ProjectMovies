using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DSED02ProjectMovies
{
    class Database
    {
        //create connection and command and an adapter
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public Database()
        {
            // add the connection string to run db
            string connectionString = @"Data Source=LAPTOP-HBQLSRM5;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        public int CustomerID { get; set; }

        private void SqlConnection(DataTable dt)
        {
            // connect in to the DB and get the SQL

            // open a connection to the DB
            Connection.Open();
            // fill the datatable from the SQL
            da.Fill(dt);
            // close the connection
            Connection.Close();
        }

        public DataTable FillDGVCustomerWithCustomer()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from CustomerData ORDER by 'Last Name'", Connection))
            {
                SqlConnection(dt);
            }
            //pass the datatable data to the DataGridView;
            return dt;
        }

        public DataTable FillDGVMovieWithMovie()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from MoviesInfoData Order by Year DESC, Title ASC", Connection))
            {
                SqlConnection(dt);
            }
            //pass the datatable data to the DataGridView;
            return dt;
        }

        public DataTable FillDGVRentalsWithRentals()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from CustomerAndMoviesRented Order by 'Last Name', Title", Connection))
            {
                SqlConnection(dt);
            }
            //pass the datatable data to the DataGridView;
            return dt;
        }

        public DataTable FillDGVCustomerWithCustomerClick(string Customervalue)
        {
            string SQL = "select 'First Name', 'Last Name', Address, Phone from CustomerData where CustID='" +
                         Customervalue + "'";
            using (da = new SqlDataAdapter(SQL, Connection))
            {
                //connect in to the DB and get the SQL
                DataTable dt = new DataTable();
                //create a datatable as we only have one table, customer
                SqlConnection(dt);
                return dt;
            }
        }
    }
}
