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
            bool actual = addressBookRepo.GetAllContactTable();
            Assert.IsTrue(actual);

        }
        /// <summary>
        /// Given query for the retriving data from contact book name table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactBookNameTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllDataOfContactBookName();
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Given query for the retriving data from contact type table when database is connected should return true.
        /// </summary>
        [TestMethod]
        public void GivenqueryforRetrivingdataFromContactTypeTable_WhenDatabaseIsConnected_ShouldReturnTrue()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool actual = addressBookRepo.GetAllDataOfContactType();
            Assert.IsTrue(actual);
        }
    }
}
