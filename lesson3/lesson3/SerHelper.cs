using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace lesson3
{
    class SerHelper
    {
        public static void serialize(List<Order> client) {
            XmlSerializer xmlSerializer =
                new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, client);
            }   
        }
        public static List<Order> deserialize()
        {
            XmlSerializer xmlSerializer =
               new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                List<Order> clients = (List<Order>)xmlSerializer.Deserialize(fs);
                return clients;
            }
        }

    }
}
