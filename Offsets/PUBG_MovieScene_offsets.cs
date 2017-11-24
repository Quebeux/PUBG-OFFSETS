/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene
	{
		public const int Spawnables = 0x0028;
		public const int Possessables = 0x0038;
		public const int ObjectBindings = 0x0048;
		public const int MasterTracks = 0x0058;
		public const int CameraCutTrack = 0x0068;
		public const int SelectionRange = 0x0070;
		public const int PlaybackRange = 0x0080;
		public const int bForceFixedFrameIntervalPlayback = 0x0090;
		public const int UnknownData00 = 0x0091;
		public const int FixedFrameInterval = 0x0094;
		public const int InTime = 0x0098;
		public const int OutTime = 0x009C;
		public const int StartTime = 0x00A0;
		public const int EndTime = 0x00A4;
	}

	public class UMovieSceneFolder
	{
		public const int FolderName = 0x0028;
		public const int ChildFolders = 0x0030;
		public const int ChildMasterTracks = 0x0040;
		public const int ChildObjectBindingStrings = 0x0050;
		public const int UnknownData00 = 0x0060;
	}

	public class UMovieSceneSection
	{
		public const int StartTime = 0x0028;
		public const int EndTime = 0x002C;
		public const int RowIndex = 0x0030;
		public const int OverlapPriority = 0x0034;
		public const int bIsActive = 0x0038;
		public const int bIsLocked = 0x0038;
		public const int bIsInfinite = 0x0038;
		public const int UnknownData00 = 0x0039;
	}

}
