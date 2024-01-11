using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FirstProject
{
    //Steps:
    //1. Address of sql server and database


    //2. Establish connection


    //3. Open connection


    //4.prepare query

    //5. execute query

    //6.close connection
    class DatabaseAndCRUD
    {

        static void Read() {
            //1. Address of sql server and database
            string ConnectionString = "Data Source=LAPTOP-FDJLT93A;Initial Catalog=TechShop;Integrated Security=True";

            //2. Establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3. Open connection
            con.Open();

            //4.prepare query
            string query = "Select CustomerId, LastName, FirstName from Customers";
            string output="";

            //5. execute query
            //parameter (what is the query, what is the connection)
            SqlCommand cmd = new SqlCommand(query, con);

            //because it is returning value for that we have SqlDataReader (used to read data)
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read()) {
                output = output + data.GetValue(0) + " - " + data.GetValue(1) + " " + data.GetValue(2) + "\n";
            }

            Console.Write(output);
            Console.ReadLine();
            //6.close connection
            data.Close();
            cmd.Dispose();
            con.Close();
        }
        static void Insert() {
            //1. Address of sql server and database
            string ConnectionString = "Data Source=LAPTOP-FDJLT93A;Initial Catalog=TechShop;Integrated Security=True";

            //2. Establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3. Open connection
            con.Open();

            //4.prepare query
            string query = "INSERT INTO Customers values(13,'kane', 'Smith','joe2023@gmail.com', '8901231241','St. Thomas',1)";
            
            //5.execute query
            SqlCommand cmd = new SqlCommand(query,con);

            //SqlDataAdapter used for CRUD operations
           // SqlDataAdapter adap = new SqlDataAdapter();
            //adap.InsertCommand = new SqlCommand(query, con);

            //OR Directly do this:
            cmd.ExecuteNonQuery();

          
            //7. Close
            cmd.Dispose();
            con.Close();

            Console.WriteLine("Insertion done");
            Console.ReadLine();
        }
        static void Update() {
            //1. Address of sql server and database
            string ConnectionString = "Data Source=LAPTOP-FDJLT93A;Initial Catalog=TechShop;Integrated Security=True";

            //2. Establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3. Open connection
            con.Open();

            //4.prepare query
            string query = "UPDATE  Customers SET FirstName = 'Harry' WHERE CustomerId = 19";
            int rowsUpdated ;
            //5.execute query
            SqlCommand cmd = new SqlCommand(query, con);
            rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated > 0)
                Console.WriteLine("Customers table updated");
            else
                Console.WriteLine("Not updated");


            cmd.Dispose();
            con.Close();

            Console.ReadLine();
        }
        static void Main() {

            //Read();
            Insert();
           // Update();
            
        }
    }
}
