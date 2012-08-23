using System;
using Microsoft.Data.OData;

namespace Castle.MonoRail.Extension.OData3.Tests
{
	public abstract class ODataTestCommon
	{
		protected ODataMessageWriterSettings CreateMessageWriterSettings(Uri serviceUri, ODataFormat format)
		{
			var messageWriterSettings = new ODataMessageWriterSettings()
				                            {
					                            BaseUri = serviceUri,
					                            Version = ODataVersion.V3,
					                            Indent = true,
					                            CheckCharacters = false,
					                            DisableMessageStreamDisposal = false
				                            };
			// messageWriterSettings.EnableWcfDataServicesServerBehavior(provider.IsV1Provider);
			// messageWriterSettings.SetContentType(acceptHeaderValue, acceptCharSetHeaderValue);
			return messageWriterSettings;
		}
	}
}