/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AAkAmbientSound
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>UAkComponent *</summary>
		public const int AkComponent = 0x03B0;

		///<summary>float</summary>
		public const int AutoPlayDistance = 0x03B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03BC;

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

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

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
		public const int StopWhenOwnerDestroyed = 0x0300;

		///<summary>bool</summary>
		public const int bDynamicReverb = 0x0301;

		///<summary>bool</summary>
		public const int bUseDoppler = 0x0302;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0303;

		///<summary>float</summary>
		public const int AttenuationScalingFactor = 0x0304;

		///<summary>float</summary>
		public const int OcclusionRefreshInterval = 0x0308;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x030C;

		///<summary>UAkAudioEvent *</summary>
		public const int AkAudioEvent = 0x0310;

		///<summary>FString</summary>
		public const int EventName = 0x0318;

		///<summary>unsigned char[0xC8]</summary>
		public const int UnknownData02 = 0x0328;

	}

	public class AAkReverbVolume
	{
		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03D8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03D9;

		///<summary>UAkAuxBus *</summary>
		public const int AuxBus = 0x03E0;

		///<summary>FString</summary>
		public const int AuxBusName = 0x03E8;

		///<summary>float</summary>
		public const int SendLevel = 0x03F8;

		///<summary>float</summary>
		public const int FadeRate = 0x03FC;

		///<summary>float</summary>
		public const int Priority = 0x0400;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0404;

		///<summary>AAkReverbVolume *</summary>
		public const int NextLowerPriorityAkReverbVolume = 0x0408;

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

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData01 = 0x0060;

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

}
