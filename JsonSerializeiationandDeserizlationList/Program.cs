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

                // Used for help https://stackoverflow.com/questions/40994534/get-relative-path-of-a-file-c-sharp
                //https:stackoverflow.com/questions/17405180/how-to-read-existing-text-files-without-defining-path

                // Static way
                string filename = "C:\\Users\\user\\Desktop\\Coding part2\\JsonSerializeiationandDeserizlationList\\JsonSerializeiationandDeserizlationList\\UserData.json";

                // Dynamic way
                var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "UserData.json");

                string jsonString = File.ReadAllText(path);
                List<User> user = JsonSerializer.Deserialize<List<User>>(jsonString);
                users = user;

                Console.WriteLine(users.Count());
            }
        }
    }
}
