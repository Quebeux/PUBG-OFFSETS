/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBuildPatchManifest
	{
		///<summary><![CDATA[unsigned char]]></summary>
		public const int ManifestFileVersion = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFileData = 0x0029;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x002A;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int AppID = 0x002C;

		///<summary><![CDATA[FString]]></summary>
		public const int AppName = 0x0030;

		///<summary><![CDATA[FString]]></summary>
		public const int BuildVersion = 0x0040;

		///<summary><![CDATA[FString]]></summary>
		public const int LaunchExe = 0x0050;

		///<summary><![CDATA[FString]]></summary>
		public const int LaunchCommand = 0x0060;

		///<summary><![CDATA[FString]]></summary>
		public const int PrereqName = 0x0070;

		///<summary><![CDATA[FString]]></summary>
		public const int PrereqPath = 0x0080;

		///<summary><![CDATA[FString]]></summary>
		public const int PrereqArgs = 0x0090;

		///<summary><![CDATA[TArray<FFileManifestData>]]></summary>
		public const int FileManifestList = 0x00A0;

		///<summary><![CDATA[TArray<FChunkInfoData>]]></summary>
		public const int ChunkList = 0x00B0;

		///<summary><![CDATA[TArray<FCustomFieldData>]]></summary>
		public const int CustomFields = 0x00C0;

	}

}
