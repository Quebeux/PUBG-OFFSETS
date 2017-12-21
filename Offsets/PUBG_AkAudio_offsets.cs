/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AAkAmbientSound
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>UAkComponent *</summary>
		public const int AkComponent = 0x03C0;

		///<summary>bool</summary>
		public const int AutoPost = 0x03C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03C9;

		///<summary>float</summary>
		public const int AutoPlayDistance = 0x03CC;

	}

	public class UAkAudioBank
	{
		///<summary>bool</summary>
		public const int AutoLoad = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

	}

	public class UAkAudioEvent
	{
		///<summary>UAkAudioBank *</summary>
		public const int RequiredBank = 0x0028;

		///<summary>float</summary>
		public const int MaxAttenuationRadius = 0x0030;

		///<summary>bool</summary>
		public const int IsInfinite = 0x0034;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0035;

		///<summary>float</summary>
		public const int MinimumDuration = 0x0038;

		///<summary>float</summary>
		public const int MaximumDuration = 0x003C;

	}

	public class UAkAuxBus
	{
		///<summary>UAkAudioBank *</summary>
		public const int RequiredBank = 0x0028;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UAkComponent
	{
		///<summary>bool</summary>
		public const int StopWhenOwnerDestroyed = 0x03F0;

		///<summary>bool</summary>
		public const int bDynamicReverb = 0x03F1;

		///<summary>bool</summary>
		public const int bUseDoppler = 0x03F2;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x03F3;

		///<summary>float</summary>
		public const int AttenuationScalingFactor = 0x03F4;

		///<summary>float</summary>
		public const int OcclusionRefreshInterval = 0x03F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03FC;

		///<summary>UAkAudioEvent *</summary>
		public const int AkAudioEvent = 0x0400;

		///<summary>FString</summary>
		public const int EventName = 0x0408;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData02 = 0x0418;

	}

	public class AAkReverbVolume
	{
		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03E9;

		///<summary>UAkAuxBus *</summary>
		public const int AuxBus = 0x03F0;

		///<summary>FString</summary>
		public const int AuxBusName = 0x03F8;

		///<summary>float</summary>
		public const int SendLevel = 0x0408;

		///<summary>float</summary>
		public const int FadeRate = 0x040C;

		///<summary>float</summary>
		public const int Priority = 0x0410;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0414;

		///<summary>AAkReverbVolume *</summary>
		public const int NextLowerPriorityAkReverbVolume = 0x0418;

	}

	public class UAkSettings
	{
		///<summary>unsigned char</summary>
		public const int MaxSimultaneousReverbVolumes = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>FFilePath</summary>
		public const int WwiseProjectPath = 0x0030;

		///<summary>FDirectoryPath</summary>
		public const int WwiseWindowsInstallationPath = 0x0040;

		///<summary>FFilePath</summary>
		public const int WwiseMacInstallationPath = 0x0050;

		///<summary>bool</summary>
		public const int SuppressWwiseProjectPathWarnings = 0x0060;

		///<summary>unsigned char[0x3F]</summary>
		public const int UnknownData01 = 0x0061;

	}

	public class UInterpTrackAkAudioEvent
	{
		///<summary>TArray&lt;FAkAudioEventTrackKey&gt;</summary>
		public const int Events = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bContinueEventOnMatineeEnd = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A1;

	}

	public class UInterpTrackAkAudioRTPC
	{
		///<summary>FString</summary>
		public const int Param = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bPlayOnReverse = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bContinueRTPCOnMatineeEnd = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A1;

	}

	public class UInterpTrackInstAkAudioEvent
	{
		///<summary>float</summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstAkAudioRTPC
	{
		///<summary>float</summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UMovieSceneAkAudioEventSection
	{
		///<summary>UAkAudioEvent *</summary>
		public const int Event = 0x00D0;

		///<summary>FString</summary>
		public const int EventName = 0x00D8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00E8;

	}

	public class UMovieSceneAkAudioRTPCSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00D0;

		///<summary>FString</summary>
		public const int Name = 0x00D8;

		///<summary>FRichCurve</summary>
		public const int FloatCurve = 0x00E8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0158;

	}

	public class UMovieSceneAkTrack
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bIsAMasterTrack = 0x00C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00C9;

	}

}
