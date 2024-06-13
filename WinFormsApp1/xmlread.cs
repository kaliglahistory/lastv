using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
    
namespace WinFormsApp1
{

    internal class xmlread
    {
        string path = "";
        public int xmlreads(string ip)
        {
            string dok = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\ConsoleApp2\\bin\\Debug\\net8.0\\users.xml";

            XmlDocument xml = new XmlDocument();
            int count = 0;

            xml.Load(dok);
            XmlElement elem = xml.DocumentElement;
            Console.WriteLine(elem);
            List<string> people = new List<string>();
           
            foreach (XmlElement xname in elem)
            {
                XmlNode? attr = xname.Attributes.GetNamedItem("name");
                foreach (XmlNode childnode in xname.ChildNodes)
                {
                    people.Add(childnode.Name);
                    for (int i = 0; i < people.Count; i++)
                    {
                        count = people.Count(word => word.Contains(ip));
                       
                    }

                   
                }
            }

            return count;
            Console.WriteLine(count);

        }
        }
}   
