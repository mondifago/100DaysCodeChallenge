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

    /*public int FindLowestElement()
    {
        
    }*/
}

