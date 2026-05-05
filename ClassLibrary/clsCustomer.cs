using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsActiveAccount { get; set; }
    }
}