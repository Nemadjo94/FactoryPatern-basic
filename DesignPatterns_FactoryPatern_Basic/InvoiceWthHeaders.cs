using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryPatern_Basic
{
    public class InvoiceWthHeaders : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Invoice will be printed with headers.");
        }
    }
}
