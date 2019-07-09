In order to avoid recompiling the client we have introduced the invoice interface ‘IInvoice’.
Both the concrete classes ‘ClsInvoiceWithOutHeaders’ and ‘ClsInvoiceWithHeader’ inherit and implement
the ‘IInvoice’ interface

We have also introduced an extra class ‘ClsFactoryInvoice’ with a function ‘getInvoice()’ which will
generate objects of both the invoices depending on ‘intInvoiceType’ value. In short we have centralized 
the logic of object creation in the ‘ClsFactoryInvoice’. The client calls the ‘getInvoice’ function
to generate the invoice classes. One of the most important points to be noted is that client only refers
to ‘IInvoice’ type and the factory class ‘ClsFactoryInvoice’ also gives the same type of reference. 
This helps the client to be complete detached from the concrete classes, so now when we add new classes
and invoice types we do not need to recompile the client.