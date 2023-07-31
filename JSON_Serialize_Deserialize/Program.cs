using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSON_Serialize_Deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Coustumer> listCoustumers = new List <Coustumer>();
            listCoustumers.Add(new Coustumer() {CustumerId = 1, FullName = "Armen Mkhoyan", Address = "Lori province, Sarchapet"});
            listCoustumers.Add(new Coustumer() {CustumerId = 2, FullName = "Erik Egnatosyan", Address = "Yerevan, Qanaqer"});
            listCoustumers.Add(new Coustumer() {CustumerId = 3, FullName = "Razmik Markosyan", Address = "Yerevan, Malatia"});

            Restoran restoran = new Restoran();
            restoran.Coustumers = listCoustumers;
            restoran.RestoranName = "Nor Dvin";

            string jsonString = JsonConvert.SerializeObject(restoran, Formatting.Indented);
            Console.WriteLine(jsonString);

            Restoran restoran2 = new Restoran();
            restoran2 = JsonConvert.DeserializeObject<Restoran>(jsonString);
            Console.WriteLine(restoran2.Coustumers[0].CustumerId + " : "+ 
                          restoran2.Coustumers[0].FullName + " || " + 
                          restoran2.Coustumers[0].Address);
        }
    }
}
