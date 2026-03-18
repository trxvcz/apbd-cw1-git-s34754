namespace apbd_cw1_git_s34754;

public class StatisticHelper
{
    public static double CalculateAverage(List<double> numbers)
    {
        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Count;
    }

    public static double CalculateMax(List<double> numbers)
    {
        return numbers.Max();
    }

    public static double CalculateMax(double[] numbers)
    {
        return numbers.Max();
    }

    public static double CalculateMin(List<double> numbers)
    {
        return numbers.Min();
    }

    public static double CalculateMin(double[] numbers)
    {
        return numbers.Min();
    }
    
    public static double CalculateMode(List<double> numbers)
    {
        return numbers.Max() - numbers.Min();
    }
}