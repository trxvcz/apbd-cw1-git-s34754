// See https://aka.ms/new-console-template for more information

using apbd_cw1_git_s34754;

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
    
    Console.Clear();
    Console.WriteLine("Average: " +StatisticHelper.CalculateAverage(list));
    Console.WriteLine("Max: " + StatisticHelper.CalculateMax(list));
    Console.WriteLine(" ");
    Console.WriteLine("Average: " + StatisticHelper.CalculateAverage(list));
    Console.WriteLine("Max: " + StatisticHelper.CalculateMax(list));
}