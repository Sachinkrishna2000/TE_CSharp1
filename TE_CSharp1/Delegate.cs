using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public delegate void BankDelegate(string bankname, double interest_rate);
    internal class Delegate
    {
        public void GetBankDetails(string bankname, double interest_rate)
        {
            Console.WriteLine($"Bank Name: {bankname} | Interest Rate:{interest_rate}%");
        }
        public void CalculateInterest(string bankname, double interest_rate)
        {
            Console.WriteLine($"Bank Name: {bankname} | Interest :{(1000 * 2 *interest_rate)/100}");//Default Principal Amount-1000 and Time-2years Simple Interest=P*T*R/100
        }
        public static void Main()
        {
            Delegate del = new Delegate();
            BankDelegate bank = del.GetBankDetails;
            bank += del.CalculateInterest;
            bank("SBI", 2.70);
            Console.WriteLine();
            bank("HDFC", 3.00);
            bank("HDFC", 3.50);
            Console.WriteLine();
            bank("Kotak Mahindra", 3.50);
            Console.WriteLine();
            bank("Axis Bank", 3.00);
            bank("Axis Bank", 3.50);
            Console.WriteLine();
            bank("ICICI Bank", 3.00);
            bank("ICICI Bank", 3.50);
 
        }
    }
}
