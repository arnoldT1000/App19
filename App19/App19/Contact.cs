using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App19
{
    class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get;
            set;
        }
        public string Firstname
        {
            get;
            set;
        }
        public string Lastname
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        [MaxLength(10)]
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
