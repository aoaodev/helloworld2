string aFriend = "Bill";
Console.WriteLine($"Hello  {aFriend}");
aFriend = "Maira";
Console.WriteLine($"Hello  {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "      Hello world!     ";
//greeting = greeting.Trim();
Console.WriteLine($"{greeting.Trim()}");

string[] Friends = [firstFriend, secondFriend];
foreach (var f in Friends)
{
    Console.WriteLine(f);
}

Console.WriteLine("So this is it, huh?");