using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace OnlineBank
 {
     internal class Program
     {

         static void SaveClient(StreamWriter sw, BankClient client)
         {
              
                 sw.WriteLine($"{client.Name} {client.BirthDate:d} {client.Login} {client.Password}");
                 sw.WriteLine(client.Accounts.Count);
                foreach (var account in client.Accounts)
                 {
                     sw.WriteLine($"{account.Number} {account.Balance}");
                 }
                 
                 
             
                 
             
         }

         static BankClient ReadClient(StreamReader sr)
         {
             var line = sr.ReadLine();
             var parts = line.Split(' ');
             
             var client = new BankClient
             {
                 Name = parts[0],
                 BirthDate = DateTime.Parse(parts[1]),
                 Login = parts[2],
                 Password = parts[3],
                 Accounts = new List<BankAccount>()
                 
             };
               //
             int accountnumber = int.Parse(sr.ReadLine());
             for (int i = 0; i < accountnumber; i++)
             {
                 line = sr.ReadLine();
                 parts = line.Split(' ');
                 var account = new BankAccount
                 {
                     Number = parts[0],
                     Balance = decimal.Parse(parts[1])
                 };
                 client.Accounts.Add(account);
                 

             }
             return client;
         }


         
         
         
         public static void Main(string[] args)
         {
            List<BankClient> clientsFromFile= new List<BankClient>(); 
             using (var sr = new StreamReader("Client.txt"))
             {
                 while (!sr.EndOfStream)
                 {
                     var client = ReadClient(sr);
                    
                     clientsFromFile.Add(client);
                     
                 }
             } 
             
             List<BankClient> clients = new List<BankClient>
             {
                 new BankClient()
                 {
                     Name = "Anya",
                     BirthDate = new DateTime(1999, 12, 18),
                     Login = "Anya1999",
                     Password = "qwerty",
                     Accounts = new List<BankAccount>()
                     {
                         new BankAccount()
                         {
                             Number = "19238",
                             Balance = 124231
                         },
                         
                         new BankAccount()
                         {
                         Number = "234534",
                         Balance = 45431
                         },
                         
                         new BankAccount()
                         {
                             Number = "453415",
                             Balance = 0
                         }
                         
                     },
                     
                     
 
                 },
                 new BankClient()
                 {
                     Name = "Andrew",
                     BirthDate = new DateTime(1979, 04, 12),
                     Login = "Andrewa1eqe999",
                     Password = "sdgfsd",
                     Accounts = new List<BankAccount>()
                     {
                         new BankAccount()
                         {
                             Number = "4352",
                             Balance = 0
                         },
                         
                         new BankAccount()
                         {
                             Number = "145113",
                             Balance = 541561
                         },
                         
                         new BankAccount()
                         {
                             Number = "8764",
                             Balance = 100
                         }
                         
                     }
 
                 }
             };

             using (var sw = new StreamWriter("Client.txt"))
             {
                 foreach (var client in clients)
                 {
                     SaveClient(sw, client);
                 }
                 
             }
         }
     }
 }