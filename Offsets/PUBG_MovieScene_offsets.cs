/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene
	{
		///<summary><![CDATA[TArray<FMovieSceneSpawnable>]]></summary>
		public const int Spawnables = 0x0028;

		///<summary><![CDATA[TArray<FMovieScenePossessable>]]></summary>
		public const int Possessables = 0x0038;

		///<summary><![CDATA[TArray<FMovieSceneBinding>]]></summary>
		public const int ObjectBindings = 0x0048;

		///<summary><![CDATA[TArray<UMovieSceneTrack * >]]></summary>
		public const int MasterTracks = 0x0058;

		///<summary><![CDATA[UMovieSceneTrack *]]></summary>
		public const int CameraCutTrack = 0x0068;

		///<summary><![CDATA[FFloatRange]]></summary>
		public const int SelectionRange = 0x0070;

		///<summary><![CDATA[FFloatRange]]></summary>
		public const int PlaybackRange = 0x0080;

		///<summary><![CDATA[bool]]></summary>
		public const int bForceFixedFrameIntervalPlayback = 0x0090;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0091;

		///<summary><![CDATA[float]]></summary>
		public const int FixedFrameInterval = 0x0094;

		///<summary><![CDATA[float]]></summary>
		public const int InTime = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int OutTime = 0x009C;

		///<summary><![CDATA[float]]></summary>
		public const int StartTime = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int EndTime = 0x00A4;

	}

	public class UMovieSceneFolder
	{
		///<summary><![CDATA[FName]]></summary>
		public const int FolderName = 0x0028;

		///<summary><![CDATA[TArray<UMovieSceneFolder * >]]></summary>
		public const int ChildFolders = 0x0030;

		///<summary><![CDATA[TArray<UMovieSceneTrack * >]]></summary>
		public const int ChildMasterTracks = 0x0040;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int ChildObjectBindingStrings = 0x0050;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0060;

	}

	public class UMovieSceneSection
	{
		///<summary><![CDATA[float]]></summary>
		public const int StartTime = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int EndTime = 0x002C;

		///<summary><![CDATA[int]]></summary>
		public const int RowIndex = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int OverlapPriority = 0x0034;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsActive = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsLocked = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsInfinite = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

	}

}
