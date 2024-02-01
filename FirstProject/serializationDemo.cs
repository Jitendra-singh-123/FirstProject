using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FirstProject
{

    class serializationDemo
    {
        static void Main()
        {
            Players players = new Players()
            {
                Name = "MSD",
                Team = "CSK",
                Average = 56
            };

            // XML Serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Players)); // Create an XML serializer for the Players class
            using (TextWriter writer = new StreamWriter("players.xml")) // Open a text writer to a file named "players.xml"
            {
                serializer.Serialize(writer, players); // Serialize the Players object to XML and write it to the file
            }

            using (TextReader reader = new StreamReader("players.xml")) // Open a text reader to the previously created XML file
            {
                Players players1 = (Players)serializer.Deserialize(reader); // Deserialize the XML into a new Players object
                Console.WriteLine("Player Name: " + players1.Name);
                Console.WriteLine("Player Team: " + players1.Team);
                Console.WriteLine("Player Average: " + players1.Average);
            }

            // Binary Serialization (commented out in the original code)
            // IFormatter formatter = new BinaryFormatter(); // Create a binary formatter
            // Stream stream = new FileStream("Players", FileMode.Create, FileAccess.Write); // Open a file stream for writing
            // formatter.Serialize(stream, players); // Serialize the Players object to binary and write it to the file
            // stream.Close(); // Close the file stream
            // stream = new FileStream("Players", FileMode.Open, FileAccess.Read); // Open a file stream for reading
            // Players players1 = (Players)formatter.Deserialize(stream); // Deserialize the binary data into a new Players object
            // Console.WriteLine("Player Name : " + players1.Name);
            // Console.WriteLine("Player Team : " + players1.Team);
            // Console.WriteLine("Player Average : " + players1.Average);
            Console.ReadKey();
        }
    }
       
      
    }
