string aFriend = "Gerson";
string LastName = "Roberto da Silva";
int Age = 44;
Console.WriteLine($"Hello, My name is {aFriend} and may last name is {LastName} and my age is {Age} ");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");