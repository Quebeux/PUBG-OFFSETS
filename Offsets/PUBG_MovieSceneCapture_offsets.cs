/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieSceneCapture
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FCaptureProtocolID</summary>
		public const int CaptureType = 0x0038;

		///<summary>UMovieSceneCaptureProtocolSettings *</summary>
		public const int ProtocolSettings = 0x0040;

		///<summary>FMovieSceneCaptureSettings</summary>
		public const int Settings = 0x0048;

		///<summary>bool</summary>
		public const int bUseSeparateProcess = 0x0098;

		///<summary>bool</summary>
		public const int bCloseEditorWhenCaptureStarts = 0x0099;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x009A;

		///<summary>FString</summary>
		public const int AdditionalCommandLineArguments = 0x00A0;

		///<summary>FString</summary>
		public const int InheritedCommandLineArguments = 0x00B0;

		///<summary>unsigned char[0x180]</summary>
		public const int UnknownData02 = 0x00C0;

	}

	public class ULevelCapture
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0240;

		///<summary>FGuid</summary>
		public const int PrerequisiteActorId = 0x0244;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0254;

	}

	public class UFrameGrabberProtocolSettings
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UImageCaptureSettings
	{
		///<summary>int</summary>
		public const int CompressionQuality = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UCompositionGraphCaptureSettings
	{
		///<summary>FCompositionGraphCapturePasses</summary>
		public const int IncludeRenderPasses = 0x0028;

		///<summary>bool</summary>
		public const int bCaptureFramesInHDR = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>int</summary>
		public const int HDRCompressionQuality = 0x003C;

		///<summary>TEnumAsByte&lt;EHDRCaptureGamut&gt;</summary>
		public const int CaptureGamut = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0041;

		///<summary>FStringAssetReference</summary>
		public const int PostProcessingMaterial = 0x0048;

	}

	public class UVideoCaptureSettings
	{
		///<summary>bool</summary>
		public const int bUseCompression = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>float</summary>
		public const int CompressionQuality = 0x0034;

		///<summary>FString</summary>
		public const int VideoCodec = 0x0038;

	}

}
