/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene
	{
		///<summary>TArray&lt;FMovieSceneSpawnable&gt;</summary>
		public const int Spawnables = 0x0028;

		///<summary>TArray&lt;FMovieScenePossessable&gt;</summary>
		public const int Possessables = 0x0038;

		///<summary>TArray&lt;FMovieSceneBinding&gt;</summary>
		public const int ObjectBindings = 0x0048;

		///<summary>TArray&lt;UMovieSceneTrack * &gt;</summary>
		public const int MasterTracks = 0x0058;

		///<summary>UMovieSceneTrack *</summary>
		public const int CameraCutTrack = 0x0068;

		///<summary>FFloatRange</summary>
		public const int SelectionRange = 0x0070;

		///<summary>FFloatRange</summary>
		public const int PlaybackRange = 0x0080;

		///<summary>bool</summary>
		public const int bForceFixedFrameIntervalPlayback = 0x0090;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0091;

		///<summary>float</summary>
		public const int FixedFrameInterval = 0x0094;

		///<summary>float</summary>
		public const int InTime = 0x0098;

		///<summary>float</summary>
		public const int OutTime = 0x009C;

		///<summary>float</summary>
		public const int StartTime = 0x00A0;

		///<summary>float</summary>
		public const int EndTime = 0x00A4;

	}

	public class UMovieSceneFolder
	{
		///<summary>FName</summary>
		public const int FolderName = 0x0028;

		///<summary>TArray&lt;UMovieSceneFolder * &gt;</summary>
		public const int ChildFolders = 0x0030;

		///<summary>TArray&lt;UMovieSceneTrack * &gt;</summary>
		public const int ChildMasterTracks = 0x0040;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int ChildObjectBindingStrings = 0x0050;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0060;

	}

	public class UMovieSceneSection
	{
		///<summary>float</summary>
		public const int StartTime = 0x0028;

		///<summary>float</summary>
		public const int EndTime = 0x002C;

		///<summary>int</summary>
		public const int RowIndex = 0x0030;

		///<summary>int</summary>
		public const int OverlapPriority = 0x0034;

		///<summary>unsigned char:1</summary>
		public const int bIsActive = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bIsLocked = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bIsInfinite = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

	}

}
