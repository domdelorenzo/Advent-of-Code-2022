using System.Linq;

namespace AdventOfCode.Day03;

public class Solution : BaseSolution
{
    public Solution() : base(3, "Rucksack Reorganization")
    {
    }

    public override string GetPart1Answer()
    {
        // store total
        int total = 0;
        // parse input fle
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day03\Input.txt");
        // for each line, split line in two
        foreach (string line in inputFile)
        {
            int length = line.Length;
            int half = length / 2;
            string str1 = line.Substring(0, half);
            string str2 = line.Substring(half, half);
            //Console.WriteLine(length.ToString());
            // check each member of the first line to see if it's in the second line
            foreach (char c in str1)
            {
                if (str2.Contains(c)) {
                    int val = (char.IsUpper(c) ? ((int)c % 32) + 26 : ((int)c % 32));
                    // Console.WriteLine("Duplicate value is " + c + " with a value of " + val.ToString());
                    // if duplicate is found, add value to total
                    total += val;
                    break;
                 };
            }

        }


        return total.ToString();
    }

    public override string GetPart2Answer()
    {
        // store total
        int total = 0;
        // parse input fle
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day03\Input.txt");
        // group into groups of three
        for (var i = 0; i < inputFile.Length; i += 3)
        {
            var group = new List<string>();

            foreach (string line in inputFile.Skip(i).Take(3))
            {

                group.Add(line);
                
            }

            foreach (char c in group[0])
            {
                if (group[1].Contains(c) && group[2].Contains(c))
                {
                    int val = (char.IsUpper(c) ? ((int)c % 32) + 26 : ((int)c % 32));
                    total += val;
                    break;
                }
            }
        }
        
        // for each line, split line in two
        /*
        foreach (string line in inputFile)
        {
            int length = line.Length;
            int half = length / 2;
            string str1 = line.Substring(0, half);
            string str2 = line.Substring(half, half);
            Console.WriteLine(length.ToString());
            // check each member of the first line to see if it's in the second line
            foreach (char c in str1)
            {
                if (str2.Contains(c))
                {
                    int val = (char.IsUpper(c) ? ((int)c % 32) + 26 : ((int)c % 32));
                    Console.WriteLine("Duplicate value is " + c + " with a value of " + val.ToString());
                    // if duplicate is found, add value to total
                    total += val;
                    break;
                };
            }

        }
        */

        return total.ToString();
    }
}
