using ConsoleApp1;

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine("You entered: " + number);
}
else
{
    Console.WriteLine("Error: not a correct number");
}

int[] numbers = { 5, 3, 8, 1, 9, 2 };

int resultAvg = StatisticsHelper.CalculateAverage(numbers);
Console.WriteLine("Average: " + resultAvg);

int resultMax =  StatisticsHelper.CalculateMax(numbers);
Console.WriteLine("Max: " + resultMax);

int resultMin = StatisticsHelper.CalculateMin(numbers);
Console.WriteLine("Min: " + resultMin);