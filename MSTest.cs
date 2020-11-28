using AddressBookADO.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AddressBookMSTest
{
    [TestClass]
    public class MSTest
    {
        /// <summary>
        /// Given query for  retriving data when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllContactTable("Contact");
            Assert.IsTrue(actual);

        }
        /// <summary>
        /// Given query for  the retriving data from contact table when database is connected should return false.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllContactTable("Contacts");
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Given query for the retriving data from contact book name table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactBookNameTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllDataOfContactBookName("Contact_BookName");
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the retriving data from contact book name table when database is connected should return false.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactBookNameTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllDataOfContactBookName("ContactBookName");
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Given query for the retriving data from contact type table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactTypeTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllDataOfContactType("Contact_Type");
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the retriving data from contact type table when database is connected should return false.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactTypeTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllDataOfContactType("ContactType");
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Given query for the updating  data from contact  table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforUpdatingdataFromContactTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.UpdateContactTable("PersonId =3");
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the updating  data from contact  table when database is connected should return false.
        /// </summary>
        [TestMethod]
        public void GivenqueryforUpdatingdataFromContactTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.UpdateContactTable("PersonId = 45");
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Given query for the updating  data from contact Book table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforUpdatingdataFromContactBookTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.UpdateContactBookTable("PersonId =5");
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the updating  data from contact Book table when database is connected should return false.
        /// </summary>
        [TestMethod]
        public void GivenqueryforUpdatingdataFromContactBookTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.UpdateContactBookTable("PersonId =10");
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Given query for the updating  data from contact type table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforUpdatingdataFromContactTypeTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.UpdateContactTypeTable("Contact_typeID =1");
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the updating  data from contact type table when database is connected should return False.
        /// </summary>
        [TestMethod]
        public void GivenqueryforUpdatingdataFromContactTypeTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.UpdateContactTypeTable("Contact_typeID =12");
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Given query for the adding new contact to table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforAddingContactToTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookModel addressBookModel = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookModel.firstName = "kalyan";
            addressBookModel.lastName = "Goud";
            addressBookModel.Address = "sriramnager";
            addressBookModel.City = "Nlg";
            addressBookModel.State = "TS";
            addressBookModel.zip = "508001";
            addressBookModel.PhoneNumber = "7732063720";
            addressBookModel.ContactTypeId = 3;
            bool actual = addressBookRepo.AddContact(addressBookModel);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the adding new contact to table when database is connected should return false.
        /// </summary>
        [TestMethod]
        public void GivenqueryforAddingContactToTable_WhenDatabaseIsConnected_ShouldReturnFalse()
        {
            AddressBookModel addressBookModel = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.AddContact(addressBookModel);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Addings the data to list.
        /// </summary>
        /// <returns></returns>
        public List<AddressBookModel> AddingDataToList()
        {
            List<AddressBookModel> addressBookList = new List<AddressBookModel>();
            addressBookList.Add(new AddressBookModel
            {
                firstName = "kalyan",
                lastName = "goud",
                Address = "sriram nagar",
                City = "nalgonda",
                State = "telangana",
                zip = "508001",
                PhoneNumber = "8897221787",
                ContactTypeId = 2
            });
            addressBookList.Add(new AddressBookModel
            {
                firstName = "anirudh",
                lastName = "repala",
                Address = "padmavathi",
                City = "hyd",
                State = "telangana",
                zip = "507001",
                PhoneNumber = "9550647660",
                ContactTypeId = 1
            });

            return addressBookList;
        }
        /// <summary>
        /// Givens the multiple person data to add without threading to database should give elapsed time.
        /// </summary>
        [TestMethod]
        public void GivenMultiplePersonDataToAddWithoutThreading_ToDatabase_ShouldGiveElapsedTime()
        {
            List<AddressBookModel> employeeList = AddingDataToList();
            ThreadingOperations multiThreading = new ThreadingOperations();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            multiThreading.AddContactListToDBWithoutThread(employeeList);
            stopwatch.Stop();
            Console.WriteLine("Time taken while adding to list with threading:{0}  ", stopwatch.ElapsedMilliseconds);
        }
        /// <summary>
        ///  Givens the multiple person data to add with threading to database should give elapsed time.
        /// </summary>
        [TestMethod]
        public void GivenMultiplePersonDataToAddWithThreading_ToDatabase_ShouldGiveElapsedTime()
        {
            List<AddressBookModel> employeeList = AddingDataToList();
            ThreadingOperations multiThreading = new ThreadingOperations();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            multiThreading.AddContactListToDBWithThread(employeeList);
            stopwatch.Stop();
            Console.WriteLine("Time taken while adding to list with threading:{0}  ", stopwatch.ElapsedMilliseconds);
        }
    }
}
