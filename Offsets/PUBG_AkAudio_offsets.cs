/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AAkAmbientSound
	{
		public const int UnknownData00 = 0x03A0;
		public const int AkComponent = 0x03B0;
		public const int AutoPlayDistance = 0x03B8;
		public const int UnknownData01 = 0x03BC;
	}

	public class UAkAudioBank
	{
		public const int AutoLoad = 0x0028;
		public const int UnknownData00 = 0x0029;
	}

	public class UAkAudioEvent
	{
		public const int RequiredBank = 0x0028;
		public const int MaxAttenuationRadius = 0x0030;
		public const int UnknownData00 = 0x0034;
	}

	public class UAkAuxBus
	{
		public const int RequiredBank = 0x0028;
		public const int UnknownData00 = 0x0030;
	}

	public class UAkComponent
	{
		public const int StopWhenOwnerDestroyed = 0x0300;
		public const int bDynamicReverb = 0x0301;
		public const int bUseDoppler = 0x0302;
		public const int UnknownData00 = 0x0303;
		public const int AttenuationScalingFactor = 0x0304;
		public const int OcclusionRefreshInterval = 0x0308;
		public const int UnknownData01 = 0x030C;
		public const int AkAudioEvent = 0x0310;
		public const int EventName = 0x0318;
		public const int UnknownData02 = 0x0328;
	}

	public class AAkReverbVolume
	{
		public const int bEnabled = 0x03D8;
		public const int UnknownData00 = 0x03D9;
		public const int AuxBus = 0x03E0;
		public const int AuxBusName = 0x03E8;
		public const int SendLevel = 0x03F8;
		public const int FadeRate = 0x03FC;
		public const int Priority = 0x0400;
		public const int UnknownData01 = 0x0404;
		public const int NextLowerPriorityAkReverbVolume = 0x0408;
	}

	public class UAkSettings
	{
		public const int MaxSimultaneousReverbVolumes = 0x0028;
		public const int UnknownData00 = 0x0029;
		public const int WwiseProjectPath = 0x0030;
		public const int WwiseWindowsInstallationPath = 0x0040;
		public const int WwiseMacInstallationPath = 0x0050;
		public const int UnknownData01 = 0x0060;
	}

	public class UInterpTrackAkAudioEvent
	{
		public const int Events = 0x0090;
		public const int bContinueEventOnMatineeEnd = 0x00A0;
		public const int UnknownData00 = 0x00A1;
	}

	public class UInterpTrackAkAudioRTPC
	{
		public const int Param = 0x0090;
		public const int bPlayOnReverse = 0x00A0;
		public const int bContinueRTPCOnMatineeEnd = 0x00A0;
		public const int UnknownData00 = 0x00A1;
	}

	public class UInterpTrackInstAkAudioEvent
	{
		public const int LastUpdatePosition = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

	public class UInterpTrackInstAkAudioRTPC
	{
		public const int LastUpdatePosition = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

}
