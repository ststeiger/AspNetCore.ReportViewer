namespace AspNetCore.Report
{
	/// <summary>
	/// SSRS Server Settings
	/// </summary>
	public class ReportSettings
	{
		private string _server = "http://localhost/ReportServer";

		private bool _isSSL = false;

		/// <summary>
		/// SSRS Server Url
		/// </summary>
		public string ReportServer
		{
			get
			{
				return this._server;
			}
			set
			{
				this._server = value;
				this._isSSL = new System.Uri(this.ReportServer).Scheme.Equals("https");
			}
		}

		/// <summary>
		/// Credential 
		/// default is DefaultNetworkCredentials
		/// </summary>
		public System.Net.ICredentials Credential
		{
			get;
			set;
		} = System.Net.CredentialCache.DefaultNetworkCredentials;


		/// <summary>
		/// Whether the toolbar is displayed
		/// </summary>
		public bool ShowToolBar
		{
			get;
			set;
		} = true;


		/// <summary>
		/// use UserAgent to render Report
		/// </summary>
		public string UserAgent
		{
			get;
			set;
		}

		/// <summary>
		/// Whether the request is SSL
		/// </summary>
		public bool IsSSL => this._isSSL;
	}
}
