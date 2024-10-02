// 4 players
List<Player> players = new List<Player>()
{
    new Player("Joe", 32),
    new Player("Jack", 40),
    new Player("William", 37),
    new Player("Averell", 25)
};

// Initialize search
Player elder = players.First();
int biggestAge = elder.Age;

// search
//
/*
foreach (Player p in players)
{
    if (p.Age > biggestAge) // memorize new elder
    {

        biggestAge = p.Age; // for future loops
    }
}*/
Player elder1 = players.Aggregate((playe, player) => playe.Age >= player.Age ? playe : player);


Console.WriteLine($"Le plus agé est {elder1.Name} qui a {elder1.Age} ans");

Console.ReadKey();

public class Player
{
    private readonly string _name;
    private readonly int _age;

    public Player(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string Name => _name;

    public int Age => _age;
}