/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UConsoleSettings
	{
		public const int MaxScrollbackSize = 0x0028;
		public const int UnknownData00 = 0x002C;
		public const int ManualAutoCompleteList = 0x0030;
		public const int AutoCompleteMapPaths = 0x0040;
		public const int BackgroundOpacityPercentage = 0x0050;
		public const int bOrderTopToBottom = 0x0054;
		public const int UnknownData01 = 0x0055;
		public const int InputColor = 0x0058;
		public const int HistoryColor = 0x005C;
		public const int AutoCompleteCommandColor = 0x0060;
		public const int AutoCompleteCVarColor = 0x0064;
		public const int AutoCompleteFadedColor = 0x0068;
		public const int UnknownData02 = 0x006C;
	}

	public class UGameMapsSettings
	{
		public const int EditorStartupMap = 0x0028;
		public const int LocalMapOptions = 0x0038;
		public const int TransitionMap = 0x0048;
		public const int bUseSplitscreen = 0x0058;
		public const int TwoPlayerSplitscreenLayout = 0x0059;
		public const int ThreePlayerSplitscreenLayout = 0x005A;
		public const int bOffsetPlayerGamepadIds = 0x005B;
		public const int UnknownData00 = 0x005C;
		public const int GameInstanceClass = 0x0060;
		public const int GameDefaultMap = 0x0070;
		public const int ServerDefaultMap = 0x0080;
		public const int GlobalDefaultGameMode = 0x0090;
		public const int GlobalDefaultServerGameMode = 0x00A0;
		public const int GameModeMapPrefixes = 0x00B0;
		public const int GameModeClassAliases = 0x00C0;
	}

	public class UGameNetworkManagerSettings
	{
		public const int MinDynamicBandwidth = 0x0028;
		public const int MaxDynamicBandwidth = 0x002C;
		public const int TotalNetBandwidth = 0x0030;
		public const int BadPingThreshold = 0x0034;
		public const int bIsStandbyCheckingEnabled = 0x0038;
		public const int UnknownData00 = 0x0039;
		public const int StandbyRxCheatTime = 0x003C;
		public const int StandbyTxCheatTime = 0x0040;
		public const int PercentMissingForRxStandby = 0x0044;
		public const int PercentMissingForTxStandby = 0x0048;
		public const int PercentForBadPing = 0x004C;
		public const int JoinInProgressStandbyWaitTime = 0x0050;
		public const int UnknownData01 = 0x0054;
	}

	public class UGameSessionSettings
	{
		public const int MaxSpectators = 0x0028;
		public const int MaxPlayers = 0x002C;
		public const int bRequiresPushToTalk = 0x0030;
		public const int UnknownData00 = 0x0031;
	}

	public class UGeneralProjectSettings
	{
		public const int CompanyName = 0x0028;
		public const int CompanyDistinguishedName = 0x0038;
		public const int CopyrightNotice = 0x0048;
		public const int Description = 0x0058;
		public const int Homepage = 0x0068;
		public const int LicensingTerms = 0x0078;
		public const int PrivacyPolicy = 0x0088;
		public const int ProjectID = 0x0098;
		public const int ProjectName = 0x00A8;
		public const int ProjectVersion = 0x00B8;
		public const int SupportContact = 0x00C8;
		public const int ProjectDisplayedTitle = 0x00D8;
		public const int ProjectDebugTitleInfo = 0x00F0;
		public const int bShouldWindowPreserveAspectRatio = 0x0108;
		public const int bUseBorderlessWindow = 0x0109;
		public const int bStartInVR = 0x010A;
		public const int bAllowWindowResize = 0x010B;
		public const int bAllowClose = 0x010C;
		public const int bAllowMaximize = 0x010D;
		public const int bAllowMinimize = 0x010E;
		public const int UnknownData00 = 0x010F;
	}

	public class UHudSettings
	{
		public const int bShowHUD = 0x0028;
		public const int UnknownData00 = 0x0029;
		public const int DebugDisplay = 0x0030;
	}

}
