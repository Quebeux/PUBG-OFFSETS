/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGeometryCacheTrack
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UGeometryCache
	{
		public const int UnknownData00 = 0x0028;
		public const int Materials = 0x0030;
		public const int Tracks = 0x0040;
		public const int UnknownData01 = 0x0050;
	}

	public class AGeometryCacheActor
	{
		public const int GeometryCacheComponent = 0x03A0;
	}

	public class UGeometryCacheComponent
	{
		public const int GeometryCache = 0x0780;
		public const int bRunning = 0x0788;
		public const int bLooping = 0x0789;
		public const int UnknownData00 = 0x078A;
		public const int StartTimeOffset = 0x078C;
		public const int PlaybackSpeed = 0x0790;
		public const int NumTracks = 0x0794;
		public const int ElapsedTime = 0x0798;
		public const int UnknownData01 = 0x079C;
	}

	public class UGeometryCacheTrack_FlipbookAnimation
	{
		public const int NumMeshSamples = 0x0050;
		public const int UnknownData00 = 0x0054;
	}

	public class UGeometryCacheTrack_TransformAnimation
	{
		public const int UnknownData00 = 0x0050;
	}

	public class UGeometryCacheTrack_TransformGroupAnimation
	{
		public const int UnknownData00 = 0x0050;
	}

}
