using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;

namespace JsonSerializeiationandDeserizlationList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            Console.WriteLine(users.Count);


            Console.WriteLine("1 - Initilize new data");
            Console.WriteLine("2 - Read current data");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

                //creating the users 
                User data1 = new User("Olafs", "123");
                User data2 = new User("PPP", "12");
                User data3 = new User("POP", "LOL");

                users.Add(data1);
                users.Add(data2);
                users.Add(data3);


                // serializing 
                string fileName = "C:\\Users\\user\\Desktop\\Coding part2\\JsonSerializeiationandDeserizlationList\\JsonSerializeiationandDeserizlationList\\UserData.json";
                string jsonString = JsonSerializer.Serialize(users);
                File.WriteAllText(fileName, jsonString);

                Console.WriteLine(File.ReadAllText(fileName));
            }

            
            else if (choice == 2)
            {
                // Deserilizing
                string filename = "C:\\Users\\user\\Desktop\\Coding part2\\JsonSerializeiationandDeserizlationList\\JsonSerializeiationandDeserizlationList\\UserData.json";
                string jsonString = File.ReadAllText(filename);
                List<User> user = JsonSerializer.Deserialize<List<User>>(jsonString);
                users = user;



                Console.WriteLine(users.Count());
            }
        }
    }
}