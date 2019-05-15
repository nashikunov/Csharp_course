using System;
using System.Collections.Generic;

namespace OnlineBank
{
    public class BankClient
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<BankAccount> Accounts { get; set; }
        
    
    }
}