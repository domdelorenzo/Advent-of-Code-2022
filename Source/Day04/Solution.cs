namespace AdventOfCode.Day04;

public class Solution : BaseSolution
{
    public Solution() : base(4, "Camp Cleanup")
    {
    }

    public override string GetPart1Answer()
    {
        // store result
        int result = 0;
        // iterate through each line
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day04\Input.txt");
        foreach (string line in inputFile)
        {
            // split on comma
            string[] pairs = line.Split(',');
            // if item1[0] <= item2[0] && item1[1] >= item2[1] add 1 to result 
            // check reverse as well
            int[] range1 = Array.ConvertAll(pairs[0].Split('-'), int.Parse);
            int[] range2 = Array.ConvertAll(pairs[1].Split('-'), int.Parse);

            if ((range1[0] <= range2[0] && range1[1] >= range2[1]) || (range1[0] >= range2[0] && range1[1] <= range2[1]))
            {
                result++;
            }

        }

        // split each pair on hyphen


        // return number of assignment pairs that fully contain the other
        return result.ToString();
    }

    public override string GetPart2Answer()
    {
        // store result
        int result = 0;
        // iterate through each line
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day04\Input.txt");
        foreach (string line in inputFile)
        {
            // split on comma
            string[] pairs = line.Split(',');
            // if item1[0] <= item2[0] && item1[1] >= item2[1] add 1 to result 
            // check reverse as well
            int[] range1 = Array.ConvertAll(pairs[0].Split('-'), int.Parse);
            int[] range2 = Array.ConvertAll(pairs[1].Split('-'), int.Parse);

            //if ((range1[0] <= range2[0] || range1[1] >= range2[1]) || (range1[0] >= range2[0] || range1[1] <= range2[1]))
            // test if it's NOT the case that both the bottom and top of a range are less than the bottom of range 2 OR greater than the top of reange 2
            if ((
                // both range 1s are less than the bottom of range 2 OR
                ((range1[0] < range2[0]) && (range1[1] < range2[0])) || 
                // both range1 are greater than range 2
                ((range1[0] > range2[1]) && (range1[1] > range2[1]))
                ))
            {
                continue;
            }
            else
            {
                result++;
            }

        }



        // return number of assignment pairs that fully contain the other
        return result.ToString();
    }
}
