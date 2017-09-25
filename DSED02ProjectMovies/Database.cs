using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            using (da = new SqlDataAdapter("select*from CustomerData", Connection))
            {
                SqlConnection(dt);
            }
            //pass the datatable data to the DataGridView;
            return dt;
        }
    }
}
