/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieSceneCapture
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FCaptureProtocolID]]></summary>
		public const int CaptureType = 0x0038;

		///<summary><![CDATA[UMovieSceneCaptureProtocolSettings *]]></summary>
		public const int ProtocolSettings = 0x0040;

		///<summary><![CDATA[FMovieSceneCaptureSettings]]></summary>
		public const int Settings = 0x0048;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSeparateProcess = 0x0098;

		///<summary><![CDATA[bool]]></summary>
		public const int bCloseEditorWhenCaptureStarts = 0x0099;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x009A;

		///<summary><![CDATA[FString]]></summary>
		public const int AdditionalCommandLineArguments = 0x00A0;

		///<summary><![CDATA[FString]]></summary>
		public const int InheritedCommandLineArguments = 0x00B0;

		///<summary><![CDATA[unsigned char[0x140]]]></summary>
		public const int UnknownData02 = 0x00C0;

	}

	public class ULevelCapture
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bAutoStartCapture = 0x0200;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData00 = 0x0201;

		///<summary><![CDATA[FGuid]]></summary>
		public const int PrerequisiteActorId = 0x020C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x021C;

	}

	public class UFrameGrabberProtocolSettings
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UImageCaptureSettings
	{
		///<summary><![CDATA[int]]></summary>
		public const int CompressionQuality = 0x0030;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UCompositionGraphCaptureSettings
	{
		///<summary><![CDATA[FCompositionGraphCapturePasses]]></summary>
		public const int IncludeRenderPasses = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bCaptureFramesInHDR = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[int]]></summary>
		public const int HDRCompressionQuality = 0x003C;

		///<summary><![CDATA[TEnumAsByte<EHDRCaptureGamut>]]></summary>
		public const int CaptureGamut = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0041;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int PostProcessingMaterial = 0x0048;

	}

	public class UVideoCaptureSettings
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bUseCompression = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[float]]></summary>
		public const int CompressionQuality = 0x0034;

		///<summary><![CDATA[FString]]></summary>
		public const int VideoCodec = 0x0038;

	}

}
