/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieSceneCapture
	{
		public const int UnknownData00 = 0x0028;
		public const int CaptureType = 0x0038;
		public const int ProtocolSettings = 0x0040;
		public const int Settings = 0x0048;
		public const int bUseSeparateProcess = 0x0098;
		public const int bCloseEditorWhenCaptureStarts = 0x0099;
		public const int UnknownData01 = 0x009A;
		public const int AdditionalCommandLineArguments = 0x00A0;
		public const int InheritedCommandLineArguments = 0x00B0;
		public const int UnknownData02 = 0x00C0;
	}

	public class ULevelCapture
	{
		public const int bAutoStartCapture = 0x0200;
		public const int UnknownData00 = 0x0201;
		public const int PrerequisiteActorId = 0x020C;
		public const int UnknownData01 = 0x021C;
	}

	public class UFrameGrabberProtocolSettings
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UImageCaptureSettings
	{
		public const int CompressionQuality = 0x0030;
		public const int UnknownData00 = 0x0034;
	}

	public class UCompositionGraphCaptureSettings
	{
		public const int IncludeRenderPasses = 0x0028;
		public const int bCaptureFramesInHDR = 0x0038;
		public const int UnknownData00 = 0x0039;
		public const int HDRCompressionQuality = 0x003C;
		public const int CaptureGamut = 0x0040;
		public const int UnknownData01 = 0x0041;
		public const int PostProcessingMaterial = 0x0048;
	}

	public class UVideoCaptureSettings
	{
		public const int bUseCompression = 0x0030;
		public const int UnknownData00 = 0x0031;
		public const int CompressionQuality = 0x0034;
		public const int VideoCodec = 0x0038;
	}

}
