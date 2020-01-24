using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{
		string input = IO.GetString();

		Console.WriteLine(input);
	}

}

static class IO
{
    static public string GetString() { return Console.ReadLine(); }
    static public int GetInt() { return int.Parse(Console.ReadLine()); }
    static public long GetLong() { return long.Parse(Console.ReadLine()); }
    static public List<string> GetStringList() { return Console.ReadLine().Split(' ').ToList(); }
    static public List<int> GetIntList() { return Console.ReadLine().Split(' ').Select(int.Parse).ToList(); }
    static public List<long> GetLongList() { return Console.ReadLine().Split(' ').Select(long.Parse).ToList(); }
    static public List<double> GetDoubleList() { return Console.ReadLine().Split(' ').Select(double.Parse).ToList(); }
    static public void WriteStrings<T>(IEnumerable<T> values) { foreach (var o in values) { Console.Write(o + " "); } }
}
