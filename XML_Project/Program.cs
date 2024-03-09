using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Xml;

namespace XML_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

            Console.WriteLine("");
             XmlDocument xmlDoc = new XmlDocument();
                //xmlDoc.Load("C:\\Users\\91976\\Desktop\\Full Stack\\dotNet\\hand on\\Employee.xml");
                xmlDoc.Load("..\\..\\..\\Employee.xml");
                xmlDoc.SelectNodes("/Employees/Employee");
                var employeeNodes = xmlDoc.SelectNodes("/Employees/Employee");


                foreach (XmlNode node in employeeNodes)
                {
                    Console.WriteLine("Name: {0} City: {1}, {2} ", node["name"].InnerText, node["City"].InnerText, node["Salary"].InnerText );

                }
                var OneEmp = xmlDoc.SelectSingleNode("/Employees/Employee[@id=1]");
                Console.WriteLine("Name: {0} City: {1}, Salary : {2} ", OneEmp["name"].InnerText, OneEmp["City"].InnerText, OneEmp["Salary"].InnerText);

                // add new node 
                var rootNode = xmlDoc.SelectSingleNode("/Employees");
                var newEmployee = xmlDoc.CreateElement("Employee", null);
                newEmployee.SetAttribute("id", "5");

                XmlNode nameNode = xmlDoc.CreateNode(XmlNodeType.Element, "name", null);
                nameNode.InnerText = "Raj";



                XmlNode CityName = xmlDoc.CreateNode(XmlNodeType.Element, "City", null);
                CityName.InnerText = "Mumbai";

                XmlNode SalaryNode = xmlDoc.CreateNode(XmlNodeType.Element, "Salary",null);
                SalaryNode.InnerText = "1231231231";

                newEmployee.AppendChild(nameNode);
                newEmployee.AppendChild(CityName);
                newEmployee.AppendChild(SalaryNode);

                xmlDoc.DocumentElement.AppendChild(newEmployee);
                xmlDoc.Save("C:\\Users\\91976\\Desktop\\Full Stack\\dotNet\\hand on\\Employee.xml");

                foreach (XmlNode node in employeeNodes)
                {
                    Console.WriteLine("Name: {0} City: {1}, {2} ", node["name"].InnerText, node["City"].InnerText, node["Salary"].InnerText);

                }
            }

            catch { 

            }
            Console.ReadLine();
        }
    }
}
