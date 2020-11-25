using AddressBookADO.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
