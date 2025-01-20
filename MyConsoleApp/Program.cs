// See https://aka.ms/new-console-template for more information
int daysUntilChristmas = (new DateTime(DateTime.Now.Year, 12, 25) - DateTime.Now).Days;
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
Console.WriteLine($"there are {daysUntilChristmas} days until the next Christmas");
