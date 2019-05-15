using System;

namespace Seminerproga2
{
    public class Passport
    {
        public DateTime DateOfIssue { get; private set; }  // иньютабл
        public string IssuedBy { get; private set; }
        public int SerialNumber { get; private set; }

        public Passport(DateTime dateOfIssue, string issuedBy, int serialNumber)
        {
            DateOfIssue = dateOfIssue;
            IssuedBy = issuedBy;
            SerialNumber = serialNumber;
        }
        
        
        
    }
} 