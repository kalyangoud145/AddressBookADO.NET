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
        public bool GetAllContactTable(string tableName)
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = "Select * from " + tableName ;
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
        public bool GetAllDataOfContactBookName(string table)
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = "Select * from " + table ;
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
                            Console.WriteLine(model.PersonId + " " + model.BookId + " " + model.BookName);
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
        public bool GetAllDataOfContactType(string tableName)
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = "Select * from "+ tableName;
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
                            Console.WriteLine(model.ContactTypeId + " " + model.contactType);
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
        /// Update data from contact table
        /// </summary>
        /// <returns></returns>
        public bool UpdateContactTable(string searchCondition)
        {
            using (this.connection)
            {
                try
                {
                    this.connection.Open();
                    SqlCommand command = this.connection.CreateCommand();
                    // Takes command type as text
                    command.CommandText = @"update Contact set City = 'Siliconvalley' where " + searchCondition;
                    // Returns number of rows effected
                    int numberOfEffectedRows = command.ExecuteNonQuery();
                    // If number of rows not equal to zero then retuns true 
                    // Else returns false
                    if (numberOfEffectedRows != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    this.connection.Close();
                }
            }
        }
        /// <summary>
        /// Update contact Book Table
        /// </summary>
        /// <returns></returns>
        public bool UpdateContactBookTable(string searchCondition)
        {
            using (this.connection)
            {
                try
                {
                    this.connection.Open();
                    SqlCommand command = this.connection.CreateCommand();
                    // Takes command type as text
                    command.CommandText = @"update Contact_BookName  set Book_name = 'Neighbours' where " +searchCondition;
                    // Returns number of rows effected
                    int numberOfEffectedRows = command.ExecuteNonQuery();
                    // If number of rows not equal to zero then retuns true 
                    // Else returns false
                    if (numberOfEffectedRows != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    this.connection.Close();
                }
            }
        }
        /// <summary>
        /// Update contact Type Table
        /// </summary>
        /// <returns></returns>
        public bool UpdateContactTypeTable(String searchCondition)
        {
            using (this.connection)
            {
                try
                {
                    this.connection.Open();
                    SqlCommand command = this.connection.CreateCommand();
                    // Takes command type as text
                    command.CommandText = @"update Contact_Type  set Contact_Type = 'Friend' where "+ searchCondition;
                    // Returns number of rows effected
                    int numberOfEffectedRows = command.ExecuteNonQuery();
                    // If number of rows not equal to zero then retuns true 
                    // Else returns false
                    if (numberOfEffectedRows != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    this.connection.Close();
                }
            }
        }
        /// <summary>
        /// Retrived contacts for given date range
        /// </summary>
        /// <returns></returns>
        public void RetriveContactInGivenDateRange()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data
                    string query = @"select * from Contact WHERE Contact.AddedDate BETWEEN CAST('01-01-2020' as date) and GETDATE()";
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
                            model.AddedDate = dataReader.GetDateTime(9);
                            // Prints the retrived values
                            Console.WriteLine(model.PersonId + " " + model.firstName + " " + model.lastName + " " + model.Address + " " + model.City + " " + model.State + " " + model.zip + " " + model.PhoneNumber + " " + model.contactType+" "+model.AddedDate); 
                            Console.WriteLine("\n");
                        }
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
        }
        /// <summary>
        /// Retrived contacts in the given city
        /// </summary>
        /// <returns></returns>
        public void RetriveContactInGivenCity()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data of particular city
                    string query = @"select * from Contact WHERE City='Chicago'";
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
                            model.AddedDate = dataReader.GetDateTime(9);
                            // Prints the retrived values
                            Console.WriteLine(model.PersonId + " " + model.firstName + " " + model.lastName + " " + model.Address + " " + model.City + " " + model.State + " " + model.zip + " " + model.PhoneNumber + " " + model.contactType + " " + model.AddedDate);
                            Console.WriteLine("\n");
                        }
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
        }
        /// <summary>
        /// Retrived contacts in the given state
        /// </summary>
        /// <returns></returns>
        public void RetriveContactInGivenState()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    // Query for retriving all the data of particular city
                    string query = @"select * from Contact WHERE State ='NY'";
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
                            model.AddedDate = dataReader.GetDateTime(9);
                            // Prints the retrived values
                            Console.WriteLine(model.PersonId + " " + model.firstName + " " + model.lastName + " " + model.Address + " " + model.City + " " + model.State + " " + model.zip + " " + model.PhoneNumber + " " + model.contactType + " " + model.AddedDate);
                            Console.WriteLine("\n");
                        }
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
        }
        /// <summary>
        /// Method adds the values to the table and return true if added or false
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public bool AddContact(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    // Created instance of the given query and connection
                    SqlCommand sqlCommand = new SqlCommand("spContact", this.connection);
                    // Command type  as text for stored procedure
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    // Adds the values to the stored procedure
                    sqlCommand.Parameters.AddWithValue("@first_name", model.firstName);
                    sqlCommand.Parameters.AddWithValue("@last_name", model.lastName);
                    sqlCommand.Parameters.AddWithValue("@Address", model.Address);
                    sqlCommand.Parameters.AddWithValue("@City", model.City);
                    sqlCommand.Parameters.AddWithValue("@State", model.State);
                    sqlCommand.Parameters.AddWithValue("@Zip", model.zip);
                    sqlCommand.Parameters.AddWithValue("@Phone_Number", model.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Contact_typeID", model.ContactTypeId);
                    sqlCommand.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                    this.connection.Open();
                    // Returns the number of rows effected
                    var result = sqlCommand.ExecuteNonQuery();
                    this.connection.Close();
                    // If number of rows not equal to zero then retuns true 
                    // Else returns false
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
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
