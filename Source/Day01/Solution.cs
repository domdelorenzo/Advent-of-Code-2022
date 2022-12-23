namespace AdventOfCode.Day01;

public class Solution : BaseSolution
{
    public Solution() : base(1, "Hungry Elves")
    {


    }

    public override string GetPart1Answer()
    {
        //let previousMax = 0
        int priorMax = 0;
        //let currentTotal = 0
        int currentTotal = 0;
        //read input file - store as array?
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day01\Input.txt");
        //iterate over each line

        foreach (string line in inputFile)
        {
            //if line is not blank, add to prior amount
            //if line is blank, evaluate currentTotal > previousMax
            if (String.IsNullOrEmpty(line))
            {
                //if currentTotal is greater, replace previousMax
                if (currentTotal > priorMax)
                {
                    priorMax = currentTotal;
                    currentTotal = 0;

                }
                else
                {
                    currentTotal = 0;
                }
            }
            else
            {
                currentTotal += Int32.Parse(line);
            }
        }

        
        //at end of file, Writeline previousMax
        return priorMax.ToString();
    }

    public override string GetPart2Answer()
    {

        //let previousMax = 0
        // int priorMax = 0;
        // let currentTotal = 0
        int currentTotal = 0;

        //read input file - store as array?
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day01\Input.txt");
        //iterate over each line

        List<int> snacks = new List<int>();

        foreach (string line in inputFile)
        {
            //if line is not blank, add to prior amount
            //if line is blank, evaluate currentTotal > previousMax
            if (String.IsNullOrEmpty(line))
            {
                snacks.Add(currentTotal);
                currentTotal = 0;
            }
            else
            {
                currentTotal += Int32.Parse(line);
            }
        }

        snacks.Sort(new SortIntDescending());
        //at end of file, Writeline previousMax
        int greatestThree = 0;

        for (int i = 0; i < 3; i++)
        {
            greatestThree += snacks[i];
        }

        return greatestThree.ToString();
    }

    private class SortIntDescending : IComparer<int>
    {
        int IComparer<int>.Compare(int a, int b) //implement Compare
        {
            if (a > b)
                return -1; //normally greater than = 1
            if (a < b)
                return 1; // normally smaller than = -1
            else
                return 0; // equal
        }
    }
}