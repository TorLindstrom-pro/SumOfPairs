using System.Linq;

namespace SumOfPairs;

public class Kata
{
	public static bool CheckThreeAndTwo(string[] array)
	{
		if (array.Length != 5) return false;
		if (!array.All(c => new[]{"a", "b", "c"}.Contains(c))) return false;
		if (array.Distinct().Count() != 2) return false;

		return array.GroupBy(c => c).Any(g => g.Count() == 3);
	}
}