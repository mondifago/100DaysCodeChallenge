namespace _100DaysCodeChallenge.Day_4;

public class ArrayOfNumbers
{
    private int[] studentAge = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

    public int FindHighestElement()
    {
        int highest = studentAge[0];
        for (int i = 1; i < studentAge.Length; i++)
        {
            if (studentAge[i] > highest)
            {
                highest = studentAge[i];
            }
        }
        return highest;
    }

    public int FindLowestElement()
    {
        int lowest = studentAge[0];
        for (int i = 1; i < studentAge.Length; i++)
        {
            if (studentAge[i] < lowest)
            {
                lowest = studentAge[i];
            }
        }
        return lowest;
    }

    public double FindSumOfAllElements()
    {
        double sum = 0.0;
        for (int i = 0; i < studentAge.Length; i++)
        {
            sum += studentAge[i];
        }
        return sum;
    }
}

