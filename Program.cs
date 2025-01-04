string heroName = "", magicalCreature = "", companionName = "";
int age = 0;
double treasureValue = 0.0;
bool hasCompanion = false;

// Story begins
Console.WriteLine("Welcome to the adventure story! Let's create our tale!");

Console.WriteLine("Enter the hero's name:");
heroName = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter the hero's age:");
if (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Invalid age. Defaulting to 10.");
    age = 10;
}

Console.WriteLine("Name a magical creature:");
magicalCreature = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter the value of the treasure found (e.g., 100.5):");
if (!double.TryParse(Console.ReadLine(), out treasureValue))
{
    Console.WriteLine("Invalid value. Defaulting to 100.5.");
    treasureValue = 100.5;
}

Console.WriteLine("Does the hero have a companion? (true/false):");
if (!bool.TryParse(Console.ReadLine(), out hasCompanion))
{
    Console.WriteLine("Invalid input. Defaulting to false.");
    hasCompanion = false;
}

if (hasCompanion)
{
    Console.WriteLine("Enter the companion's name:");
    companionName = Console.ReadLine() ?? string.Empty;
}

// The story unfolds
Console.WriteLine($"\nOnce upon a time, there was a brave hero named {heroName} who was {age} years old.");
Console.WriteLine($"{heroName} lived in a peaceful village but always dreamed of adventure.");
Console.WriteLine($"One day, {heroName} encountered a {magicalCreature} while exploring the nearby forest!");

if (hasCompanion)
{
    Console.WriteLine($"Luckily, {heroName} was not alone. {heroName}'s loyal companion, {companionName}, was by their side.");
}
else
{
    Console.WriteLine($"Though {heroName} was alone, their courage never wavered.");
}

Console.WriteLine($"The {magicalCreature} led {heroName} to a hidden cave filled with sparkling treasures worth {treasureValue} gold coins!");
Console.WriteLine($"With the treasure secured, {heroName} returned to the village, hailed as a hero.");
Console.WriteLine("And thus, the tale of bravery and fortune was passed down through the ages.");
Console.WriteLine("The End!");
