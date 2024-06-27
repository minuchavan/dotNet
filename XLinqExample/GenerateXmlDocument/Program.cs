using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenerateXmlDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var CustomerOrdersDocument = new XElement("Customers");       //OUTPUT :    <Customers />

            //   var CustomerOrdersDocument = new XElement("Customers",new XElement("Customer"));     //OUTPUT :- <Customers>
            //                   < Customer />
            //           </ Customers >

            // var CustomerOrdersDocument = new XElement("Customers", new XElement("Customer", new XAttribute("CustomerId", 1001), new XAttribute("Customername", "Minal Chavan"), new XAttribute("CustomerCity", "Nandurbar")));
            /* OutPut :-
             < Customers >
                    < Customer CustomerId = "1001" Customername = "Minal Chavan" CustomerCity = "Nandurbar" />
             </ Customers >*/

            /* var CustomerOrdersDocument = new XElement("Customers", new XElement("Customer",
                 new XAttribute("CustomerId", 1001), new XAttribute("Customername", "Minal Chavan"), 
                 new XAttribute("CustomerCity", "Nandurbar"),new XElement("Order")));
                 Output
                 <Customers>
                      < Customer CustomerId = "1001" Customername = "Minal Chavan" CustomerCity = "Nandurbar" >
                            < Order />
                     </ Customer >
              </ Customers >*/

            var CustomerOrdersDocument = new XElement("Customers", 
                new XElement("Customer",
                                       new XAttribute("CustomerId", 1001), new XAttribute("Customername", "Minal Chavan"),
                                       new XAttribute("CustomerCity", "Nandurbar"),
                 new XElement("Orders", new XElement("Order",
                                       new XAttribute("OrderId",100),new XAttribute("orderDate",DateTime.Now),
                                       new XAttribute("Quantity",12)))));
            Console.WriteLine(CustomerOrdersDocument);
            Console.ReadKey(); 
        }
    }
}

/*
 * QUESTION : XLINQ TO GENERATE THE XML DOCUMENT 
 
 Final Output

<Customers>
  <Customer CustomerId="1001" Customername="Minal Chavan" CustomerCity="Nandurbar">
    <Orders>
      <Order OrderId="100" orderDate="2024-06-27T14:19:34.2187878+05:30" Quantity="12" />
    </Orders>
  </Customer>
</Customers>
 
 */