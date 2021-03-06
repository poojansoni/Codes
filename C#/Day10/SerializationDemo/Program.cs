using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

 
    private static void SerializeData()

    {​​​​​​

        //Steam

        FileStream fileStream = new FileStream(@"D:\\TestFile.txt", FileMode.Create);

        //Formatter

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        SerializeDeSerialze serializeDeSerialze = new SerializeDeSerialze();

        //Serilize object

        binaryFormatter.Serialize(fileStream, DateTime.Now); fileStream.Close();

    }​​​​​​         private static void DeserializeData()

    {​​​​​​

            FileStream fileStream = new FileStream("E:\\TestDir\\TestFile.txt", FileMode.Open);

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        DateTime dt = (DateTime)binaryFormatter.Deserialize(fileStream);

        fileStream.Close();

        Console.WriteLine(dt.ToString());

    }​​​​​​

[11:14 AM]
    Karthikeyan(Guest)
//Soap Serialization

[11:14 AM]
    Karthikeyan(Guest)

private static void SerializeDataSoap()

    {​​​​​​

            //Steam

            FileStream fileStream = new FileStream("E:\\TestDir\\TestFile.txt", FileMode.Create);

        //Formatter

        SoapFormatter soapFormatter = new SoapFormatter();

        SerializeDeSerialze serializeDeSerialze = new SerializeDeSerialze();

        //Serilize object

        soapFormatter.Serialize(fileStream, DateTime.Now); fileStream.Close();

    }​​​​​​         private static void DeserializeDataSoap()

    {​​​​​​

            FileStream fileStream = new FileStream("E:\\TestDir\\TestFile.txt", FileMode.Open);

        SoapFormatter soapFormatter = new SoapFormatter();

        DateTime dt = (DateTime)soapFormatter.Deserialize(fileStream);

        fileStream.Close();

        Console.WriteLine(dt.ToString());

        [11:15 AM] Karthikeyan(Guest)
        //Xml Serialization

        [11:15 AM] Karthikeyan(Guest)

 private static void SerialzeXML()

        {​​​​​​

            Stream s = new FileStream("*.xml", FileMode.Create, FileAccess.Write); Employee emp = new Employee() {​​​​​​ EmpID = 101, EmpName = "Robert" }​​​​​​; XmlSerializer ser = new XmlSerializer(typeof(Employee));

            ser.Serialize(s, emp);

            s.Close();

        }​​​​​​         private static void DeSerialzeXML()

    {​​​​​​

            Stream s = new FileStream("*.xml", FileMode.Create, FileAccess.Read); Employee emp = new Employee(); XmlSerializer ser = new XmlSerializer(typeof(Employee));

        emp = (Employee)ser.Deserialize(s);

        s.Close();

    }​​​​​​

private static void SerializeJson()

    {​​​​

            Employee emp = new Employee() {​​​​ EmpID = 101, EmpName = "Robert" }​​​​; string empString = JsonConvert.SerializeObject(emp); Console.WriteLine($"JSON Serialized Employee Object is : {​​​​empString}​​​​");

    }​​​​         private static void DeSerializeJson()

    {​​​​

            string empString = null;

        Employee deserializedEmp = JsonConvert.DeserializeObject<Employee>(empString); Console.WriteLine("JSON Deserialized Employee Object is : ");

        Console.WriteLine($"Employee ID : {​​​​deserializedEmp.EmpID}​​​​");

        Console.WriteLine($"Employee Name : {​​​​deserializedEmp.EmpName}​​​​");

    }​​​​

[11:16 AM]
    Sakshi Shukla joined the meeting.


}
