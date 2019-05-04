using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mט1EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ReservationManagerDBEntities ResEntities = new ReservationManagerDBEntities())
            {
                var clients = (from c in ResEntities.Clients
                               select c).ToList();

                clients.ForEach(e => Console.WriteLine($"id {e.ID}, "+
                    $"Password {e.Password} , PrivateName {e.PrivateName}, +" +
                    $"SurName {e.SurName} , UserName {e.UserName} " +
                    $", CreditCardNumber {e.CreditCardNumber}"));

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
