using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    public class ThreadingOperations
    {
        // Gives connection string to database
        public static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AddressBookServiceDB; Integrated Security = True";

        /// <summary>
        /// Method adds the values to the table and return true if added or false
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public bool AddContact(AddressBookModel model)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (connection)
                {
                    
                    // Created instance of the given query and connection
                    SqlCommand sqlCommand = new SqlCommand("spContact", connection);
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
                    connection.Open();

                    // Returns the number of rows effected
                    var result = sqlCommand.ExecuteNonQuery();
                    connection.Close();
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
                connection.Close();
            }
            return false;
        }
        /// <summary>
        /// Adds the contact list to database without threading.
        /// </summary>
        /// <param name="contactList">The contact list.</param>
        public void AddContactListToDBWithoutThread(List<AddressBookModel> contactList)
        {

            contactList.ForEach(contact =>
            {
                Console.WriteLine("Contact being added: " + contact.firstName);
                this.AddContact(contact);
                Console.WriteLine("Contact added: " + contact.firstName);
            });
        }
      
    }
}
