/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UConsoleSettings
	{
		///<summary><![CDATA[int]]></summary>
		public const int MaxScrollbackSize = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

		///<summary><![CDATA[TArray<FAutoCompleteCommand>]]></summary>
		public const int ManualAutoCompleteList = 0x0030;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteMapPaths = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int BackgroundOpacityPercentage = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int bOrderTopToBottom = 0x0054;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0055;

		///<summary><![CDATA[FColor]]></summary>
		public const int InputColor = 0x0058;

		///<summary><![CDATA[FColor]]></summary>
		public const int HistoryColor = 0x005C;

		///<summary><![CDATA[FColor]]></summary>
		public const int AutoCompleteCommandColor = 0x0060;

		///<summary><![CDATA[FColor]]></summary>
		public const int AutoCompleteCVarColor = 0x0064;

		///<summary><![CDATA[FColor]]></summary>
		public const int AutoCompleteFadedColor = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x006C;

	}

	public class UGameMapsSettings
	{
		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int EditorStartupMap = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int LocalMapOptions = 0x0038;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int TransitionMap = 0x0048;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSplitscreen = 0x0058;

		///<summary><![CDATA[TEnumAsByte<ETwoPlayerSplitScreenType>]]></summary>
		public const int TwoPlayerSplitscreenLayout = 0x0059;

		///<summary><![CDATA[TEnumAsByte<EThreePlayerSplitScreenType>]]></summary>
		public const int ThreePlayerSplitscreenLayout = 0x005A;

		///<summary><![CDATA[bool]]></summary>
		public const int bOffsetPlayerGamepadIds = 0x005B;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x005C;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GameInstanceClass = 0x0060;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int GameDefaultMap = 0x0070;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int ServerDefaultMap = 0x0080;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GlobalDefaultGameMode = 0x0090;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GlobalDefaultServerGameMode = 0x00A0;

		///<summary><![CDATA[TArray<FGameModeName>]]></summary>
		public const int GameModeMapPrefixes = 0x00B0;

		///<summary><![CDATA[TArray<FGameModeName>]]></summary>
		public const int GameModeClassAliases = 0x00C0;

	}

	public class UGameNetworkManagerSettings
	{
		///<summary><![CDATA[int]]></summary>
		public const int MinDynamicBandwidth = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int MaxDynamicBandwidth = 0x002C;

		///<summary><![CDATA[int]]></summary>
		public const int TotalNetBandwidth = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int BadPingThreshold = 0x0034;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsStandbyCheckingEnabled = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[float]]></summary>
		public const int StandbyRxCheatTime = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int StandbyTxCheatTime = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int PercentMissingForRxStandby = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int PercentMissingForTxStandby = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int PercentForBadPing = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int JoinInProgressStandbyWaitTime = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0054;

	}

	public class UGameSessionSettings
	{
		///<summary><![CDATA[int]]></summary>
		public const int MaxSpectators = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int MaxPlayers = 0x002C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRequiresPushToTalk = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UGeneralProjectSettings
	{
		///<summary><![CDATA[FString]]></summary>
		public const int CompanyName = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int CompanyDistinguishedName = 0x0038;

		///<summary><![CDATA[FString]]></summary>
		public const int CopyrightNotice = 0x0048;

		///<summary><![CDATA[FString]]></summary>
		public const int Description = 0x0058;

		///<summary><![CDATA[FString]]></summary>
		public const int Homepage = 0x0068;

		///<summary><![CDATA[FString]]></summary>
		public const int LicensingTerms = 0x0078;

		///<summary><![CDATA[FString]]></summary>
		public const int PrivacyPolicy = 0x0088;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ProjectID = 0x0098;

		///<summary><![CDATA[FString]]></summary>
		public const int ProjectName = 0x00A8;

		///<summary><![CDATA[FString]]></summary>
		public const int ProjectVersion = 0x00B8;

		///<summary><![CDATA[FString]]></summary>
		public const int SupportContact = 0x00C8;

		///<summary><![CDATA[FText]]></summary>
		public const int ProjectDisplayedTitle = 0x00D8;

		///<summary><![CDATA[FText]]></summary>
		public const int ProjectDebugTitleInfo = 0x00F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bShouldWindowPreserveAspectRatio = 0x0108;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseBorderlessWindow = 0x0109;

		///<summary><![CDATA[bool]]></summary>
		public const int bStartInVR = 0x010A;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowWindowResize = 0x010B;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowClose = 0x010C;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowMaximize = 0x010D;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowMinimize = 0x010E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x010F;

	}

	public class UHudSettings
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowHUD = 0x0028;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int DebugDisplay = 0x0030;

	}

}
