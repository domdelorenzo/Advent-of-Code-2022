namespace AdventOfCode.Day02;

public class Solution : BaseSolution
{
    public Solution() : base(2, "Rock Paper Scissors")
    {
    }

    public override string GetPart1Answer()
    {
        // parse input file to array
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day02\Input.txt");
        // create dictionary that codes letters to points, e.g. x: 1, y: 2
        int score = 0;
        var valuesKey = new Dictionary<char, int>()
        {
            {'X', 1}, 
            {'Y', 2}, 
            {'Z', 3}
        };
        // read each line and sum up the total points for the second column
        foreach (string line in inputFile)
        {
            char c = line.ToCharArray()[2];
            int value = valuesKey[c];            
            score += value;
        }
        // create an object to store winning conditions and points, e.g. AX: 3, AY: 6, AZ: 0
        var winsKey = new Dictionary<string, int>()
        {
            {"A X", 3}, {"A Y", 6}, {"A Z", 0}, 
            {"B X", 0}, {"B Y", 3}, {"B Z", 6},
            {"C X", 6}, {"C Y", 0}, {"C Z", 3}
        };
        foreach (string line in inputFile)
        {
            string play = line;
            int value = winsKey[play];
            score += value;
        }
        // reach each line and sum up the total ponts for the wins/losses
        return score.ToString();
    }

    public override string GetPart2Answer()
    {
        // parse input file to array
        string[] inputFile = System.IO.File.ReadAllLines(@"C:\Users\DLorenzoBreed\Playground\AdventOfCode-master\Source\Day02\Input.txt");
        int score = 0;

        // x = lose, y = draw, z = win
        // if x, rewrite list so that second char is 
        // loop through second char
        var translation = new Dictionary<string, string>()
        {
            {"A X", "A Z"}, {"A Y", "A X"}, {"A Z", "A Y"},
            {"B X", "B X"}, {"B Y", "B Y"}, {"B Z", "B Z"},
            {"C X", "C Y"}, {"C Y", "C Z"}, {"C Z", "C X"}
        };

        List<string> newPlays = new List<string>();
        foreach (string line in inputFile)
        {
            string newString = translation[line];
            newPlays.Add(newString);
        }
        var valuesKey = new Dictionary<char, int>()
        {
            {'X', 1 }, {'Y', 2}, {'Z', 3}
        };
        // read each line and sum up the total points for the second column
        foreach (string line in newPlays)
        {
            char c = line.ToCharArray()[2];
            int value = valuesKey[c];
            score += value;
        }


        // create an object to store winning conditions and points, e.g. AX: 3, AY: 6, AZ: 0
        var winsKey = new Dictionary<string, int>()
        {
            {"A X", 3}, {"A Y", 6}, {"A Z", 0}, 
            {"B X", 0}, {"B Y", 3}, {"B Z", 6}, 
            {"C X", 6}, {"C Y", 0}, {"C Z", 3}
        };
        foreach (string line in newPlays)
        {
            string play = line;
            int value = winsKey[play];
            score += value;
        }
        // reach each line and sum up the total ponts for the wins/losses
        return score.ToString();
    }
}
