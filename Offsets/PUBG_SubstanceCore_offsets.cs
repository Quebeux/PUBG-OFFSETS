/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class USubstanceGraphInstance
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>USubstanceInstanceFactory *</summary>
		public const int Parent = 0x0030;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int ImageSources = 0x0038;

		///<summary>bool</summary>
		public const int bFreezed = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0049;

	}

	public class USubstanceImageInput
	{
		///<summary>unsigned char[0xF0]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>int</summary>
		public const int CompressionRGB = 0x0118;

		///<summary>int</summary>
		public const int CompressionAlpha = 0x011C;

		///<summary>int</summary>
		public const int SizeX = 0x0120;

		///<summary>int</summary>
		public const int SizeY = 0x0124;

		///<summary>int</summary>
		public const int NumComponents = 0x0128;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x012C;

		///<summary>FString</summary>
		public const int SourceFilePath = 0x0130;

		///<summary>FString</summary>
		public const int SourceFileTimestamp = 0x0140;

		///<summary>TArray&lt;USubstanceGraphInstance * &gt;</summary>
		public const int Consumers = 0x0150;

	}

	public class USubstanceInstanceFactory
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TEnumAsByte&lt;ESubstanceGenerationMode&gt;</summary>
		public const int GenerationMode = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

	}

	public class USubstanceSettings
	{
		///<summary>int</summary>
		public const int MemoryBudgetMb = 0x0028;

		///<summary>int</summary>
		public const int CPUCores = 0x002C;

		///<summary>int</summary>
		public const int AsyncLoadMipClip = 0x0030;

		///<summary>TEnumAsByte&lt;ESubstanceGenerationMode&gt;</summary>
		public const int DefaultGenerationMode = 0x0034;

		///<summary>TEnumAsByte&lt;ESubstanceEngineType&gt;</summary>
		public const int SubstanceEngine = 0x0035;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0036;

	}

	public class USubstanceTexture2D
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x00E0;

		///<summary>USubstanceGraphInstance *</summary>
		public const int ParentInstance = 0x00F8;

		///<summary>TEnumAsByte&lt;ETextureAddress&gt;</summary>
		public const int AddressX = 0x0100;

		///<summary>TEnumAsByte&lt;ETextureAddress&gt;</summary>
		public const int AddressY = 0x0101;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData01 = 0x0102;

	}

}
