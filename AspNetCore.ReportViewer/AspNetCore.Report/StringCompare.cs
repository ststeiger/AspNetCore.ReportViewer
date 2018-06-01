namespace AspNetCore.Report
{
	internal class StringCompare : System.Collections.Generic.IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			return x.Equals(y, System.StringComparison.OrdinalIgnoreCase);
		}

		public int GetHashCode(string obj)
		{
			return obj.ToLower().GetHashCode();
		}
	}
}
