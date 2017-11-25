/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCoherentUIGTWidget
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0128;

		///<summary>AActor *</summary>
		public const int Owner = 0x0140;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReadyForBindings = 0x0148;

		///<summary>FScriptMulticastDelegate</summary>
		public const int BindingsReleased = 0x0158;

		///<summary>FScriptMulticastDelegate</summary>
		public const int FinishLoad = 0x0168;

		///<summary>FScriptMulticastDelegate</summary>
		public const int FailLoad = 0x0178;

		///<summary>FScriptMulticastDelegate</summary>
		public const int StartLoading = 0x0188;

		///<summary>FScriptMulticastDelegate</summary>
		public const int NavigateTo = 0x0198;

		///<summary>FScriptMulticastDelegate</summary>
		public const int JavaScriptEvent = 0x01A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UIGTScriptingReady = 0x01B8;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData01 = 0x01C8;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int Texture = 0x0240;

		///<summary>TEnumAsByte&lt;ETextureFilter&gt;</summary>
		public const int Filter = 0x0248;

		///<summary>bool</summary>
		public const int bReceiveInput = 0x0249;

		///<summary>bool</summary>
		public const int bReceiveInputWhenTransparent = 0x024A;

		///<summary>bool</summary>
		public const int bGammaCorrectedMaterial = 0x024B;

		///<summary>bool</summary>
		public const int AllowPerformanceWarnings = 0x024C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x024D;

		///<summary>float</summary>
		public const int ExecuteJSTimersThresholdMs = 0x0250;

		///<summary>float</summary>
		public const int UpdateStylesAndLayoutThresholdMs = 0x0254;

		///<summary>float</summary>
		public const int RecordRenderingCommandsThresholdMs = 0x0258;

		///<summary>float</summary>
		public const int PaintWarningThresholdMs = 0x025C;

		///<summary>int</summary>
		public const int LayersCountThreshold = 0x0260;

		///<summary>int</summary>
		public const int LayerWidthThreshold = 0x0264;

		///<summary>int</summary>
		public const int LayerHeightThreshold = 0x0268;

		///<summary>bool</summary>
		public const int bEnableAdditionalDefaultStyles = 0x026C;

		///<summary>unsigned char[0x1D3]</summary>
		public const int UnknownData03 = 0x026D;

		///<summary>FString</summary>
		public const int URL = 0x0440;

		///<summary>float</summary>
		public const int ClickThroughAlphaThreshold = 0x0450;

		///<summary>bool</summary>
		public const int Transparent = 0x0454;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData04 = 0x0455;

	}

	public class UCoherentUIGTJSEvent
	{
		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCoherentUIGTJSPayload
	{
		///<summary>FString</summary>
		public const int EventName = 0x0028;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UCoherentUIGTSettings
	{
		///<summary>bool</summary>
		public const int EnableLiveReload = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>int</summary>
		public const int InspectorPort = 0x002C;

		///<summary>bool</summary>
		public const int EnableWebSecurity = 0x0030;

		///<summary>bool</summary>
		public const int EnableLocalization = 0x0031;

		///<summary>bool</summary>
		public const int RunAsynchronous = 0x0032;

		///<summary>bool</summary>
		public const int bRecursivelyBindUStructs = 0x0033;

		///<summary>bool</summary>
		public const int AllowPerformanceWarningsInEditor = 0x0034;

		///<summary>bool</summary>
		public const int ShowWarningsOnScreen = 0x0035;

		///<summary>TEnumAsByte&lt;ECoherentUIGTSettingsSeverity&gt;</summary>
		public const int LogSeverity = 0x0036;

		///<summary>bool</summary>
		public const int bRespectTitleSafeZone = 0x0037;

		///<summary>bool</summary>
		public const int bRespectLetterboxing = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0039;

		///<summary>FString</summary>
		public const int HUDMaterialName = 0x0040;

		///<summary>FString</summary>
		public const int CoUIResourcesRoot = 0x0050;

		///<summary>bool</summary>
		public const int TickWhileGameIsPaused = 0x0060;

		///<summary>TEnumAsByte&lt;ECoherentUIGTMSAA&gt;</summary>
		public const int MSAA = 0x0061;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x0062;

	}

}
