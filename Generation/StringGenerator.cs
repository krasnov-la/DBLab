using System.Text;

namespace Generation;

public class StringGenerator
{
    static readonly Random _rand = new Random(DateTime.Now.Microsecond);
    public static string Generate(NormalDist lengthDist, bool space = false, string charset = "abcdefghijklmnopqrstuvwxyz")
    {
        return new string(Enumerable.Repeat(space ? charset + " " : charset, lengthDist.Generate())
            .Select(s => s[_rand.Next(s.Length)]).ToArray());
    }

    public static string Generate(int length, bool space = false, string charset = "abcdefghijklmnopqrstuvwxyz")
    {
        return new string(Enumerable.Repeat(space ? charset + " " : charset, length)
            .Select(s => s[_rand.Next(s.Length)]).ToArray());
    }
}