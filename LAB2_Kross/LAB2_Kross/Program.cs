using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

[assembly: CLSCompliant(true)]
namespace LAB2_Kross
{
    class Program
    {
        static void SearializeXML(Computers comp)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Computers));
            using (FileStream fs = new FileStream("Computers.xml", FileMode.OpenOrCreate) )
            {
                xml.Serialize(fs,comp);
            }
        }
        static void Main(string[] args)
        {
            Computers c = new Computers(new ObservableCollection<Computer>()
            {
                new Computer("Acer",16,"Nvidia GTX 1050TI","Intel Core i7"),
                new Computer("Dell",32,"Nvidia GTX 1070TI","Intel Core i5"),
                new Computer("AsusRog",64,"Nvidia GTX 1080TI","Intel Core i9")
            });
            SearializeXML(c);
            
        }
    }
}
