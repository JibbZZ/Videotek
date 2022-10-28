
using Dapper;
using MySqlConnector;


public class Users
{

    public int id { get; set; }
    public string name { get; set; }
    public string eMail { get; set; }
    public int phoneNumber { get; set; }
    public string city { get; set; }
    public int postalCode { get; set; }

    public override string ToString()
    {
        return $"{id} {name}";
    }


}

internal class Program
{
    private static void Main(string[] args)
    {


        using (var connection = new MySqlConnection("Server=localhost;Database=Videotek;Uid=root;"))
        {
            var users = connection.Query<Users>("SELECT id, name, eMail, phoneNumber, city, postalCode FROM Users;").ToList();
            foreach (Users u in users)
            {
                Console.WriteLine(u.id + "  " + u.name + " " + u.eMail + " " + u.phoneNumber + " " + u.city + " " + u.postalCode);
            }

        }
    }
}

