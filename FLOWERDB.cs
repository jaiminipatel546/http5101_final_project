using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Final_Project
{
    public class FLOWERDB
    {
        //reference is taken from the in class example
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "flowers"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //connectionString is used to connect to the database 
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);


            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            //A try block is used to encapsulate a region of code. 
            //If any code throws an exception within that try block, the exception will be handled by the corresponding catch.
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();


                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }
                resultset.Close();


            }
            //When an exception occurs, the Catch block of code is executed.
            //This is where you are able to handle the exception, log it, or ignore it.
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }

        //Find the particular flower
        public Flower FindFlower(int id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Flower result_flower = new Flower();

            try
            {
                string query = "select * from flowers_table where flower_id = " + id;
                Debug.WriteLine("Connection Initialized...");
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                //Create a list of flowers
                List<Flower> flowers = new List<Flower>();

                while (resultset.Read())
                {
                    Flower currentflower = new Flower();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        switch (key)
                        {
                            case "flower_name":
                                currentflower.SetFlowerName(value);
                                break;
                            case "flower_description":
                                currentflower.SetFlowerDescription(value);
                                break;
                        }

                    }
                    //Add the flower to the list of flowers
                    flowers.Add(currentflower);
                }

                result_flower = flowers[0]; //get the first flower

            }
            catch (Exception ex)
            {
                //This block will execute if there is any error
                Debug.WriteLine("Something went wrong in the find flower method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_flower;
        }

        //Add a flower
        public void AddFlower(Flower add_flower)
        {

            string query = "insert into flowers_table (flower_name, flower_description) values ('{0}','{1}')";
            query = String.Format(query, add_flower.GetFlowerName(), add_flower.GetFlowerDescription());

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddFLower Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


        //Update the flower
        public void UpdateFlower(int flower_id, Flower new_flower)
        {

            string query = "update flowers_table set flower_name='{0}', flower_description='{1}' where flower_id={2}";
            query = String.Format(query, new_flower.GetFlowerName(), new_flower.GetFlowerDescription(), flower_id);


            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the UpdateFlower Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


        //Delete a particular flower
        public void DeleteFlower(int flower_id)
        {
            Debug.WriteLine("Delete query method started......");
            string query = "delete from flowers_table where flower_id = {0}";
            query = String.Format(query, flower_id);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the DeleteSeason Method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
        }
    }
}



