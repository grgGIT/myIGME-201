// See https://aka.ms/new-console-template for more information
using Q6_Gracia;


// Load or create player settings
PlayerSettings playerSettings = PlayerSettings.Instance;
playerSettings.LoadSettings("playerSettings.json");

Console.WriteLine("Here are your default settings!");


    playerSettings = PlayerSettings.DefaultSettings();
    playerSettings.SaveSettings("playerSettings.json");

Console.WriteLine($"Player Name: {playerSettings.PlayerName}");
Console.WriteLine($"Level: {playerSettings.Level}");
Console.WriteLine($"HP: {playerSettings.Hp}");
Console.WriteLine("Inventory:");
foreach (var item in playerSettings.Inventory)
{
    Console.WriteLine($"- {item}");
}
Console.WriteLine($"License Key: {playerSettings.LicenseKey}");


Console.WriteLine("------------------------------------------------------------------------------------------------");


Console.Write("Enter player name: ");
playerSettings.PlayerName = Console.ReadLine();

Console.Write("Enter player level: ");
playerSettings.Level = int.Parse(Console.ReadLine());

Console.Write("Enter player HP: ");
playerSettings.Hp = int.Parse(Console.ReadLine());

Console.Write("Enter items in inventory (comma-separated): ");
string inventoryInput = Console.ReadLine();
playerSettings.Inventory = inventoryInput.Split(',');

Console.Write("Enter license key: ");
playerSettings.LicenseKey = Console.ReadLine();

playerSettings.SaveSettings("playerSettings.json");


// Display current settings
Console.WriteLine("Current Player Settings:");
Console.WriteLine($"Player Name: {playerSettings.PlayerName}");
Console.WriteLine($"Level: {playerSettings.Level}");
Console.WriteLine($"HP: {playerSettings.Hp}");
Console.WriteLine("Inventory:");
foreach (var item in playerSettings.Inventory)
{
    Console.WriteLine($"- {item}");
}
Console.WriteLine($"License Key: {playerSettings.LicenseKey}");


Console.WriteLine( "Thanks for viewing your stats with us (Statviewer Inc.!");
// Save updated settings
playerSettings.SaveSettings("playerSettings.json");