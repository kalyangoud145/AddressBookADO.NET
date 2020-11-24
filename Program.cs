using System;

namespace AddressBookADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
           // addressBookRepo.GetAllContactTable();
           // addressBookRepo.GetAllDataOfContactBookName();
            //addressBookRepo.GetAllDataOfContactType();
            addressBookRepo.UpdateContactTable();
        }
    }
}
