// See https://aka.ms/new-console-template for more information

List<double> list = new List<double>();
Console.WriteLine("Write numbers: (write exit to exit) and count average");
while (true)
{
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }

    if (double.TryParse(input, out double result))
    {
        list.Add(result);
    }
    else
    {
        Console.WriteLine("Niepoprawny numer:");
    }
    
    
}