using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryPatern_Basic
{
    public class FactoryInvoice
    {
        static public IInvoice GetInvoice(int intInvoiceType)
        {
            IInvoice invoice;

            if (intInvoiceType == 1)
            {
                invoice = new InvoiceWthHeaders();
            }
            else
            if (intInvoiceType == 2)
            {
                invoice = new InvoiceWithoutHeaders();
            }
            else
            {
                return null;
            }

            return invoice;
        }
    }
}
