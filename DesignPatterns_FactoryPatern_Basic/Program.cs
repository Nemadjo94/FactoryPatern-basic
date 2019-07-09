using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryPatern_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoice invoice;

            Console.WriteLine("Enter the invoice type");

            int invoiceType = Convert.ToInt32(Console.ReadLine());

            invoice = FactoryInvoice.GetInvoice(invoiceType);

            invoice.Print();
        }
    }
}
