using System;
using System.Xml.Linq;

namespace XMLDocument2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var HTMLdocument = new XElement("HTML" ,
                new XElement("Head",
                new XElement("Title", new XText("DotNet Xlinq Lecture Practice ")), 
                new XElement("Body",
                new XElement("h1",new XText("This is heading Tag ")),
                new XElement("p", new XText("This is Paragraph Tag ")))));
            Console.WriteLine( HTMLdocument);
            Console.ReadKey();
        }
    }
}

/*
 FINAL OUTPUT 
<HTML>
  <Head>
    <Title>DotNet Xlinq Lecture Practice </Title>
    <Body>
      <h1>This is heading Tag </h1>
      <p>This is Paragraph Tag </p>
    </Body>
  </Head>
</HTML>
 */
