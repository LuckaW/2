
try
{
    Console.WriteLine("Jaký chcete otevřít soubor? Napište název:");
    string nazev = Console.ReadLine();
    File.ReadAllText(nazev);

    StreamReader reader = new StreamReader(nazev);
    while (!reader.EndOfStream)
    {
        string line = reader.ReadLine();
        Console.WriteLine(line);
    }
}
catch
{
    Console.WriteLine("Tento soubor neexistuje.");

}

//úloha:
static string GetPathFromUser()
{
    Console.WriteLine("Enter path");
    string path = Console.ReadLine();
    return path;
}

static void PrintErrorMessage()
{
    Console.WriteLine("File does not exist");
}

static string GetFileContents(string path)
{
    return File.ReadAllText(path);
}

static void PrintFileContents(string path)
{
    try
    {
        string contents = GetFileContents(path);
        Console.WriteLine(contents);
    }
    catch (Exception e)
    {
        PrintErrorMessage();
    }
}

static void UserReadFile()
{
    string path = GetPathFromUser();

    PrintFileContents(path);
}


UserReadFile();