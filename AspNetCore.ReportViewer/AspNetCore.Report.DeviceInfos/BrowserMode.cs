
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AspNetCore.Report.DeviceInfos
{
	[JsonConverter(typeof(StringEnumConverter))]
	internal enum BrowserMode
	{
		Unknown,
		Quirks,
		Standards
	}
}
