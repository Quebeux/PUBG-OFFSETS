/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class USubmixEffectDynamicsProcessorPreset
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FSubmixEffectDynamicsProcessorSettings</summary>
		public const int Settings = 0x0090;

	}

	public class USubmixEffectReverbPreset
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FSubmixEffectReverbSettings</summary>
		public const int Settings = 0x0098;

	}

	public class USubmixEffectSubmixEQPreset
	{
		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FSubmixEffectSubmixEQSettings</summary>
		public const int Settings = 0x0078;

	}

	public class USynthSound
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0300;

	}

	public class USynthComponent
	{
		///<summary>unsigned char:1</summary>
		public const int bAutoDestroy = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bStopWhenOwnerDestroyed = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bAllowSpatialization = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bOverrideAttenuation = 0x03F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03F1;

		///<summary>USoundAttenuation *</summary>
		public const int AttenuationSettings = 0x03F8;

		///<summary>FSoundAttenuationSettings</summary>
		public const int AttenuationOverrides = 0x0400;

		///<summary>USoundConcurrency *</summary>
		public const int ConcurrencySettings = 0x0530;

		///<summary>USoundClass *</summary>
		public const int SoundClass = 0x0538;

		///<summary>USoundEffectSourcePresetChain *</summary>
		public const int SourceEffectChain = 0x0540;

		///<summary>float</summary>
		public const int DefaultMasterReverbSendAmount = 0x0548;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x054C;

		///<summary>USoundSubmix *</summary>
		public const int SoundSubmix = 0x0550;

		///<summary>TArray&lt;FSoundSubmixSendInfo&gt;</summary>
		public const int SoundSubmixSends = 0x0558;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0568;

		///<summary>USynthSound *</summary>
		public const int Synth = 0x0570;

		///<summary>UAudioComponent *</summary>
		public const int AudioComponent = 0x0578;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData03 = 0x0580;

	}

}
