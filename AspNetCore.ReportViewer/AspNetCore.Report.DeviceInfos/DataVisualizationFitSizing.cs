
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AspNetCore.Report.DeviceInfos
{
	[JsonConverter(typeof(StringEnumConverter))]
	internal enum DataVisualizationFitSizing
	{
		Exact,
		Approximate
	}
}
