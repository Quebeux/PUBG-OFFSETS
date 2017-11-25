/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULevelSequence
	{
		///<summary>UMovieScene *</summary>
		public const int MovieScene = 0x0028;

		///<summary>FLevelSequenceObjectReferenceMap</summary>
		public const int ObjectReferences = 0x0030;

		///<summary>TMap<FString,FLevelSequenceObject></summary>
		public const int PossessedObjects = 0x0080;

	}

	public class ULevelSequencePlayer
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>ULevelSequence *</summary>
		public const int LevelSequence = 0x0048;

		///<summary>ULevelSequencePlayer *</summary>
		public const int CurrentPlayer = 0x0050;

		///<summary>bool</summary>
		public const int bIsPlaying = 0x0058;

		///<summary>bool</summary>
		public const int bReversePlayback = 0x0059;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x005A;

		///<summary>float</summary>
		public const int TimeCursorPosition = 0x005C;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x0060;

		///<summary>FLevelSequencePlaybackSettings</summary>
		public const int PlaybackSettings = 0x006C;

		///<summary>unsigned char[0x44]</summary>
		public const int UnknownData03 = 0x0074;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPlay = 0x00B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnStop = 0x00C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPause = 0x00D8;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData04 = 0x00E8;

	}

	public class ULevelSequenceBurnInOptions
	{
		///<summary>bool</summary>
		public const int bUseBurnIn = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>FStringClassReference</summary>
		public const int BurnInClass = 0x0030;

		///<summary>ULevelSequenceBurnInInitSettings *</summary>
		public const int Settings = 0x0040;

	}

	public class ALevelSequenceActor
	{
		///<summary>bool</summary>
		public const int bAutoPlay = 0x03A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03A1;

		///<summary>FLevelSequencePlaybackSettings</summary>
		public const int PlaybackSettings = 0x03A4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03AC;

		///<summary>ULevelSequencePlayer *</summary>
		public const int SequencePlayer = 0x03B0;

		///<summary>FStringAssetReference</summary>
		public const int LevelSequence = 0x03B8;

		///<summary>ULevelSequenceBurnInOptions *</summary>
		public const int BurnInOptions = 0x03C8;

		///<summary>ULevelSequenceBurnIn *</summary>
		public const int BurnInInstance = 0x03D0;

	}

	public class ULevelSequenceBurnIn
	{
		///<summary>FLevelSequencePlayerSnapshot</summary>
		public const int FrameInformation = 0x0240;

		///<summary>ALevelSequenceActor *</summary>
		public const int LevelSequenceActor = 0x0288;

	}

}
