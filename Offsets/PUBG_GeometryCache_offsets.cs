/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGeometryCacheTrack
	{
		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UGeometryCache
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int Materials = 0x0030;

		///<summary><![CDATA[TArray<UGeometryCacheTrack * >]]></summary>
		public const int Tracks = 0x0040;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0050;

	}

	public class AGeometryCacheActor
	{
		///<summary><![CDATA[UGeometryCacheComponent *]]></summary>
		public const int GeometryCacheComponent = 0x03A0;

	}

	public class UGeometryCacheComponent
	{
		///<summary><![CDATA[UGeometryCache *]]></summary>
		public const int GeometryCache = 0x0780;

		///<summary><![CDATA[bool]]></summary>
		public const int bRunning = 0x0788;

		///<summary><![CDATA[bool]]></summary>
		public const int bLooping = 0x0789;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x078A;

		///<summary><![CDATA[float]]></summary>
		public const int StartTimeOffset = 0x078C;

		///<summary><![CDATA[float]]></summary>
		public const int PlaybackSpeed = 0x0790;

		///<summary><![CDATA[int]]></summary>
		public const int NumTracks = 0x0794;

		///<summary><![CDATA[float]]></summary>
		public const int ElapsedTime = 0x0798;

		///<summary><![CDATA[unsigned char[0x64]]]></summary>
		public const int UnknownData01 = 0x079C;

	}

	public class UGeometryCacheTrack_FlipbookAnimation
	{
		///<summary><![CDATA[uint32_t]]></summary>
		public const int NumMeshSamples = 0x0050;

		///<summary><![CDATA[unsigned char[0x24]]]></summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UGeometryCacheTrack_TransformAnimation
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0050;

	}

	public class UGeometryCacheTrack_TransformGroupAnimation
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0050;

	}

}
