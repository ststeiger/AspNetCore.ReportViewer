
using Newtonsoft.Json;

namespace AspNetCore.Report.DeviceInfos
{
	internal class DeviceInfo
	{
		public bool? Toolbar
		{
			get;
			set;
		}

		public new string ToString()
		{
			return this.ToString(false);
		}

		public string ToString(bool format)
		{
			JsonSerializerSettings val = new JsonSerializerSettings();

            val.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            val.DateFormatString = "MM/dd/yyyy HH:mm";

			string str = JsonConvert.SerializeObject((object)this, val);
			System.Xml.Linq.XDocument doc = JsonConvert.DeserializeXNode(str, "DeviceInfo");
			System.Xml.Linq.SaveOptions options = System.Xml.Linq.SaveOptions.DisableFormatting;
			if (format)
			{
				options = System.Xml.Linq.SaveOptions.None;
			}
			return doc.ToString(options);
		}
	}
}
