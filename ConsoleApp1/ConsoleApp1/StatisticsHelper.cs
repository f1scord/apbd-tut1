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

    public static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];

        foreach (var number in numbers)
        {
            if (number > max)
                max = number;
        }

        return max;
    }

    public static int CalculateMin(int[] numbers)
    {
        int min = numbers[0];

        foreach (var number in numbers)
        {
            if  (number < min)
                min = number;
        }
        
        return min;
    }

}