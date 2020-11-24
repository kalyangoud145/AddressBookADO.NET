using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookADO.NET
{
    /// <summary>
    /// POCO class
    /// </summary>
    public class AddressBookModel
    {
        public int PersonId { get; set; }
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime AddedDate { get; set; }
        public int ContactTypeId { get; set; }
        public string BookName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string bookName { get; set; }
        public string contactType { get; set; }
    }
}
