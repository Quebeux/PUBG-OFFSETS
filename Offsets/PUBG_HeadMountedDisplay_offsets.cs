/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMotionControllerComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableLowLatencyUpdate = 0x06D0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x06D1;

		///<summary><![CDATA[TEnumAsByte<ETrackingStatus>]]></summary>
		public const int CurrentTrackingStatus = 0x06D4;

		///<summary><![CDATA[unsigned char[0x1B]]]></summary>
		public const int UnknownData01 = 0x06D5;

	}

	public class UVRNotificationsComponent
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate = 0x00F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDTrackingInitializedDelegate = 0x0108;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDRecenteredDelegate = 0x0118;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDLostDelegate = 0x0128;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDReconnectedDelegate = 0x0138;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDConnectCanceledDelegate = 0x0148;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDPutOnHeadDelegate = 0x0158;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int HMDRemovedFromHeadDelegate = 0x0168;

	}

}
