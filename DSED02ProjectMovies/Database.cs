using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int MovieID { get; set; }

        public string Result { get; set; }
        public string InputID { get; set; }
        public Button fakebutton { get; set; }

        #region SQL Connection
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
        #endregion

        #region Fill DGV's - Customers, Movies, Rentals
        #region Fill DGV Customers
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
        #endregion

        #region Fill DGV Movies
        public DataTable FillDGVMovieWithMovie()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from MoviesInfoData Order by Year DESC, Title ASC", Connection))
            {
                SqlConnection(dt);
            }
            //pass the datatable data to the DataGridView;
            return dt;
        }
        #endregion

        #region Fill DGV Rentals
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

        public DataTable FillDGVRentalsWithRentalsNotReturned()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select*from CustomerAndMoviesNotReturned Order by 'Last Name', Title", Connection))
            {
                SqlConnection(dt);
            }
            //pass the datatable data to the DataGridView;
            return dt;
        }
        #endregion
        #endregion

        #region UNSURE IF NEEDING THIS
        //public DataTable FillDGVCustomerWithCustomerClick(string Customervalue)
        //{
        //    string SQL = "select 'First Name', 'Last Name', Address, Phone from CustomerData where CustID='" +
        //                 Customervalue + "'";
        //    using (da = new SqlDataAdapter(SQL, Connection))
        //    {
        //        //connect in to the DB and get the SQL
        //        DataTable dt = new DataTable();
        //        //create a datatable as we only have one table, customer
        //        SqlConnection(dt);
        //        return dt;
        //    }
        //}

        //public DataTable FillDGVMovieWithMovieClick(string Movievalue)
        //{
        //    string SQL = "select Rating, Title, Year, 'Rental Cost', Copies, Plot, Genre from MoviesData where MovieID='" +
        //                 Movievalue + "'";
        //    using (da = new SqlDataAdapter(SQL, Connection))
        //    {
        //        //connect in to the DB and get the SQL
        //        DataTable dt = new DataTable();
        //        //create a datatable as we only have one table, customer
        //        SqlConnection(dt);
        //        return dt;
        //    }
        //}

        //public DataTable FillLBLPlot(string Movievalue)
        //{
        //    string SQL = "select Plot from MoviesData where MovieID='" +
        //                 Movievalue + "'";
        //    using (da = new SqlDataAdapter(SQL, Connection))
        //    {
        //        //connect in to the DB and get the SQL
        //        DataTable dt = new DataTable();
        //        //create a datatable as we only have one table, customer
        //        SqlConnection(dt);
        //        return dt;
        //    }
        //} 
        #endregion


        #region Buttons - Insert or Update
        #region Insert or Update Customer
        public string InsertOrUpdateCustomer(string firstname, string lastname, string address, string phone, string id,
            string addOrUpdate)
        {
            try
            {
                if (addOrUpdate == "Add")
                {
                    // Create a Command Object  //Create a Query
                    var myCommand = new SqlCommand("INSERT INTO Customer (FirstName, LastName, Address, Phone)" + "VALUES(@firstname, @lastname, @address, @phone)", Connection);

                    // create params
                    myCommand.Parameters.AddWithValue("firstname", firstname);
                    myCommand.Parameters.AddWithValue("lastname", lastname);
                    myCommand.Parameters.AddWithValue("address", address);
                    myCommand.Parameters.AddWithValue("phone", phone);

                    //Create and open a connection to SQL Server
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                else if (addOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Customer SET FirstName=@firstname, LastName=@lastname, Address=@address, Phone=@phone WHERE CustID=@id", Connection);

                    // create params
                    myCommand.Parameters.AddWithValue("firstname", firstname);
                    myCommand.Parameters.AddWithValue("lastname", lastname);
                    myCommand.Parameters.AddWithValue("address", address);
                    myCommand.Parameters.AddWithValue("phone", phone);
                    myCommand.Parameters.AddWithValue("id", id);

                    //Create and open a connection to SQL Server
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return " is Successful";
            }
            catch (Exception ex)
            {
                // need to get it to close a second time as it jumps the first connection.close when ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + ex;
            }


        }
        #endregion

        #region Insert or Update Movie
        public string InsertOrUpdateMovie(string rating, string title, string year, string copies, string plot, string genre, string id, string addOrUpdate)
        {
            try
            {
                if (addOrUpdate == "Add")
                {
                    // Create a Command Object  //Create a Query
                    var myCommand = new SqlCommand("INSERT INTO Movies (Rating, Title, Year, Copies, Plot, Genre)" + "VALUES(@rating, @title, @year, @copies, @plot, @genre)", Connection);

                    // create params
                    myCommand.Parameters.AddWithValue("rating", rating);
                    myCommand.Parameters.AddWithValue("title", title);
                    myCommand.Parameters.AddWithValue("year", year);
                    myCommand.Parameters.AddWithValue("copies", copies);
                    myCommand.Parameters.AddWithValue("plot", plot);
                    myCommand.Parameters.AddWithValue("genre", genre);

                    //Create and open a connection to SQL Server
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                else if (addOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies SET Rating=@rating, Title=@title, Year=@year, Copies=@copies,Plot=@plot,Genre=@genre WHERE MovieID=@id", Connection);

                    // create params
                    myCommand.Parameters.AddWithValue("rating", rating);
                    myCommand.Parameters.AddWithValue("title", title);
                    myCommand.Parameters.AddWithValue("year", year);
                    myCommand.Parameters.AddWithValue("copies", copies);
                    myCommand.Parameters.AddWithValue("plot", plot);
                    myCommand.Parameters.AddWithValue("genre", genre);
                    myCommand.Parameters.AddWithValue("id", id);

                    //Create and open a connection to SQL Server
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return " is Successful";
            }
            catch (Exception ex)
            {
                // need to get it to close a second time as it jumps the first connection.close when ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + ex;
            }


        }
        #endregion
        #endregion

        #region Delete Customer or Movie
        public string DeleteCustomerOrMovie(string id, string table)
        {
            if (!object.ReferenceEquals(id, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (table)
                {
                    case "Customer":
                        myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID=@id");
                        break;
                    case "Movie":
                        myCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID=@id");
                        break;
                }

                myCommand.Connection = Connection;

                // use parameters to prevent SQL injections
                myCommand.Parameters.AddWithValue("id", id);

                // open connection add in the SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "Success";
            }
            else
            {
                Connection.Close();
                return "Failed";
            }

        }
        #endregion



    }
}
