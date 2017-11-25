/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UUdpMessagingSettings
	{
		///<summary><![CDATA[bool]]></summary>
		public const int EnableTransport = 0x0028;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[FString]]></summary>
		public const int UnicastEndpoint = 0x0030;

		///<summary><![CDATA[FString]]></summary>
		public const int MulticastEndpoint = 0x0040;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int MulticastTimeToLive = 0x0050;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0051;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int StaticEndpoints = 0x0058;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableTunnel = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0069;

		///<summary><![CDATA[FString]]></summary>
		public const int TunnelUnicastEndpoint = 0x0070;

		///<summary><![CDATA[FString]]></summary>
		public const int TunnelMulticastEndpoint = 0x0080;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int RemoteTunnelEndpoints = 0x0090;

	}

}
