/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULevelSequence
	{
		public const int MovieScene = 0x0028;
		public const int ObjectReferences = 0x0030;
		public const int PossessedObjects = 0x0080;
	}

	public class ULevelSequencePlayer
	{
		public const int UnknownData00 = 0x0028;
		public const int LevelSequence = 0x0048;
		public const int CurrentPlayer = 0x0050;
		public const int bIsPlaying = 0x0058;
		public const int bReversePlayback = 0x0059;
		public const int UnknownData01 = 0x005A;
		public const int TimeCursorPosition = 0x005C;
		public const int UnknownData02 = 0x0060;
		public const int PlaybackSettings = 0x006C;
		public const int UnknownData03 = 0x0074;
		public const int OnPlay = 0x00B8;
		public const int OnStop = 0x00C8;
		public const int OnPause = 0x00D8;
		public const int UnknownData04 = 0x00E8;
	}

	public class ULevelSequenceBurnInOptions
	{
		public const int bUseBurnIn = 0x0028;
		public const int UnknownData00 = 0x0029;
		public const int BurnInClass = 0x0030;
		public const int Settings = 0x0040;
	}

	public class ALevelSequenceActor
	{
		public const int bAutoPlay = 0x03A0;
		public const int UnknownData00 = 0x03A1;
		public const int PlaybackSettings = 0x03A4;
		public const int UnknownData01 = 0x03AC;
		public const int SequencePlayer = 0x03B0;
		public const int LevelSequence = 0x03B8;
		public const int BurnInOptions = 0x03C8;
		public const int BurnInInstance = 0x03D0;
	}

	public class ULevelSequenceBurnIn
	{
		public const int FrameInformation = 0x0240;
		public const int LevelSequenceActor = 0x0288;
	}

}
