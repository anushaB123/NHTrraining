using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"F:\c# programs\Day18Morning Assignment\Electronics.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "Name")
                    {
                        Console.WriteLine(childNode.InnerText);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
