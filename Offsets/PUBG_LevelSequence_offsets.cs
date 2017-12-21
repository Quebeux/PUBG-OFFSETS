/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULevelSequence
	{
		///<summary>UMovieScene *</summary>
		public const int MovieScene = 0x0330;

		///<summary>FLevelSequenceObjectReferenceMap</summary>
		public const int ObjectReferences = 0x0338;

		///<summary>FLevelSequenceBindingReferences</summary>
		public const int BindingReferences = 0x0388;

		///<summary>TMap&lt;FString,FLevelSequenceObject&gt;</summary>
		public const int PossessedObjects = 0x03D8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0428;

	}

	public class ULevelSequencePlayer
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0700;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int AdditionalEventReceivers = 0x0720;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x0730;

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
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>bool</summary>
		public const int bAutoPlay = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03B9;

		///<summary>FMovieSceneSequencePlaybackSettings</summary>
		public const int PlaybackSettings = 0x03C0;

		///<summary>ULevelSequencePlayer *</summary>
		public const int SequencePlayer = 0x03E8;

		///<summary>FStringAssetReference</summary>
		public const int LevelSequence = 0x03F0;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int AdditionalEventReceivers = 0x0400;

		///<summary>ULevelSequenceBurnInOptions *</summary>
		public const int BurnInOptions = 0x0410;

		///<summary>UMovieSceneBindingOverrides *</summary>
		public const int BindingOverrides = 0x0418;

		///<summary>ULevelSequenceBurnIn *</summary>
		public const int BurnInInstance = 0x0420;

	}

	public class ULevelSequenceBurnIn
	{
		///<summary>FLevelSequencePlayerSnapshot</summary>
		public const int FrameInformation = 0x0240;

		///<summary>ALevelSequenceActor *</summary>
		public const int LevelSequenceActor = 0x0290;

	}

}
