/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCoherentUIGTWidget
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0128;

		///<summary><![CDATA[AActor *]]></summary>
		public const int Owner = 0x0140;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReadyForBindings = 0x0148;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int BindingsReleased = 0x0158;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int FinishLoad = 0x0168;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int FailLoad = 0x0178;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int StartLoading = 0x0188;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int NavigateTo = 0x0198;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int JavaScriptEvent = 0x01A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UIGTScriptingReady = 0x01B8;

		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData01 = 0x01C8;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int Texture = 0x0240;

		///<summary><![CDATA[TEnumAsByte<ETextureFilter>]]></summary>
		public const int Filter = 0x0248;

		///<summary><![CDATA[bool]]></summary>
		public const int bReceiveInput = 0x0249;

		///<summary><![CDATA[bool]]></summary>
		public const int bReceiveInputWhenTransparent = 0x024A;

		///<summary><![CDATA[bool]]></summary>
		public const int bGammaCorrectedMaterial = 0x024B;

		///<summary><![CDATA[bool]]></summary>
		public const int AllowPerformanceWarnings = 0x024C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x024D;

		///<summary><![CDATA[float]]></summary>
		public const int ExecuteJSTimersThresholdMs = 0x0250;

		///<summary><![CDATA[float]]></summary>
		public const int UpdateStylesAndLayoutThresholdMs = 0x0254;

		///<summary><![CDATA[float]]></summary>
		public const int RecordRenderingCommandsThresholdMs = 0x0258;

		///<summary><![CDATA[float]]></summary>
		public const int PaintWarningThresholdMs = 0x025C;

		///<summary><![CDATA[int]]></summary>
		public const int LayersCountThreshold = 0x0260;

		///<summary><![CDATA[int]]></summary>
		public const int LayerWidthThreshold = 0x0264;

		///<summary><![CDATA[int]]></summary>
		public const int LayerHeightThreshold = 0x0268;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableAdditionalDefaultStyles = 0x026C;

		///<summary><![CDATA[unsigned char[0x1D3]]]></summary>
		public const int UnknownData03 = 0x026D;

		///<summary><![CDATA[FString]]></summary>
		public const int URL = 0x0440;

		///<summary><![CDATA[float]]></summary>
		public const int ClickThroughAlphaThreshold = 0x0450;

		///<summary><![CDATA[bool]]></summary>
		public const int Transparent = 0x0454;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData04 = 0x0455;

	}

	public class UCoherentUIGTJSEvent
	{
		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCoherentUIGTJSPayload
	{
		///<summary><![CDATA[FString]]></summary>
		public const int EventName = 0x0028;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UCoherentUIGTSettings
	{
		///<summary><![CDATA[bool]]></summary>
		public const int EnableLiveReload = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[int]]></summary>
		public const int InspectorPort = 0x002C;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableWebSecurity = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableLocalization = 0x0031;

		///<summary><![CDATA[bool]]></summary>
		public const int RunAsynchronous = 0x0032;

		///<summary><![CDATA[bool]]></summary>
		public const int bRecursivelyBindUStructs = 0x0033;

		///<summary><![CDATA[bool]]></summary>
		public const int AllowPerformanceWarningsInEditor = 0x0034;

		///<summary><![CDATA[bool]]></summary>
		public const int ShowWarningsOnScreen = 0x0035;

		///<summary><![CDATA[TEnumAsByte<ECoherentUIGTSettingsSeverity>]]></summary>
		public const int LogSeverity = 0x0036;

		///<summary><![CDATA[bool]]></summary>
		public const int bRespectTitleSafeZone = 0x0037;

		///<summary><![CDATA[bool]]></summary>
		public const int bRespectLetterboxing = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0039;

		///<summary><![CDATA[FString]]></summary>
		public const int HUDMaterialName = 0x0040;

		///<summary><![CDATA[FString]]></summary>
		public const int CoUIResourcesRoot = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int TickWhileGameIsPaused = 0x0060;

		///<summary><![CDATA[TEnumAsByte<ECoherentUIGTMSAA>]]></summary>
		public const int MSAA = 0x0061;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData02 = 0x0062;

	}

}
