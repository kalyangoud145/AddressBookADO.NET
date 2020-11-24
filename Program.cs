using System;

namespace AddressBookADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addressBookModel = new AddressBookModel();
            addressBookRepo.GetAllContactTable();
            addressBookRepo.GetAllContactTable();
            addressBookRepo.GetAllDataOfContactBookName();
            addressBookRepo.GetAllDataOfContactType();
            addressBookRepo.UpdateContactTable();
            addressBookRepo.RetriveContactInGivenDateRange();
            addressBookRepo.RetriveContactInGivenCity();
            addressBookRepo.RetriveContactInGivenState();
            addressBookModel.firstName = "kalyan";
            addressBookModel.lastName = "Goud";
            addressBookModel.Address = "sriramnager";
            addressBookModel.City = "Nlg";
            addressBookModel.State = "TS";
            addressBookModel.zip = "508001";
            addressBookModel.PhoneNumber = "7732063720";
            addressBookModel.ContactTypeId = 3;
            addressBookRepo.AddContact(addressBookModel);
        

        }
    }
}
