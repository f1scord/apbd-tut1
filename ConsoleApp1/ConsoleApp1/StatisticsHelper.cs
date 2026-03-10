namespace ConsoleApp1;

public class StatisticsHelper
{
    public static int CalculateAverage(int[] numbers)
    {
        int sum = 0;
        
        foreach (var number in numbers)
        {
            sum += number;
        }
        
        return sum / numbers.Length;
    }
}