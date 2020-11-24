using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO.NET
{
    public class AddressBookRepo
    {
        // Connecting string for connection to database 
        public static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AddressBookServiceDB; Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        /// <summary>
        /// Retrive all data of the contact table
        /// </summary>
        public bool GetAllContactTable()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = "Select * from Contact";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    // Reads the passed data base
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            model.PersonId = dataReader.GetInt32(0);
                            model.firstName = dataReader.GetString(1);
                            model.lastName = dataReader.GetString(2);
                            model.Address = dataReader.GetString(3);
                            model.City = dataReader.GetString(4);
                            model.State = dataReader.GetString(5);
                            model.zip = dataReader.GetString(6);
                            model.PhoneNumber = dataReader.GetString(7);
                            model.ContactTypeId = dataReader.GetInt32(8);
                            // Prints the retrived values
                            Console.WriteLine(model.PersonId + " " + model.firstName + " " + model.lastName + " " + model.Address + " " + model.City + " " + model.State + " " + model.zip + " " + model.PhoneNumber + " " + model.contactType); ;
                            Console.WriteLine("\n");
                        }
                        this.connection.Close();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dataReader.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
        /// <summary>
        /// Retrive the data of contact book name table
        /// </summary>
        /// <returns></returns>
        public bool GetAllDataOfContactBookName()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = "Select * from Contact_BookName";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    // Reads the passed data base
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            model.PersonId = dataReader.GetInt32(0);
                            model.BookId = dataReader.GetInt32(1);
                            model.BookName = dataReader.GetString(2);
                            // Prints the retrived values
                            Console.WriteLine(model.PersonId+" "+model.BookId+" "+ model.BookName);
                            Console.WriteLine("\n");
                        }
                        this.connection.Close();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dataReader.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
        /// <summary>
        /// Gets all the data from contact type table
        /// </summary>
        /// <returns></returns>
        public bool GetAllDataOfContactType()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = "Select * from Contact_Type";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    // Reads the passed data base
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            model.ContactTypeId = dataReader.GetInt32(0);
                            model.contactType = dataReader.GetString(1);
                            // Prints the retrived values
                            Console.WriteLine(model.ContactTypeId + " " + model.contactType );
                            Console.WriteLine("\n");
                        }
                        this.connection.Close();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dataReader.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
    }
}
