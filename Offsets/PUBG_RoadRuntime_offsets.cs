/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ACrossActor
	{
		///<summary><![CDATA[FString]]></summary>
		public const int UniqueKey = 0x03B0;

		///<summary><![CDATA[TArray<FCrossActorManager>]]></summary>
		public const int SideActors = 0x03C0;

		///<summary><![CDATA[TArray<FCrossMeshManager>]]></summary>
		public const int SideMeshes = 0x03D0;

	}

	public class ARoadActor
	{
		///<summary><![CDATA[TEnumAsByte<ESplineMeshAxis>]]></summary>
		public const int SplineMeshAxis = 0x03A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03A1;

		///<summary><![CDATA[FVector]]></summary>
		public const int LocalOffset = 0x03A4;

		///<summary><![CDATA[ARoadActor *]]></summary>
		public const int Father = 0x03B0;

		///<summary><![CDATA[FString]]></summary>
		public const int UniqueKey = 0x03B8;

		///<summary><![CDATA[USplineComponent *]]></summary>
		public const int Spline = 0x03C8;

		///<summary><![CDATA[int]]></summary>
		public const int Index = 0x03D0;

		///<summary><![CDATA[int]]></summary>
		public const int Segmentation = 0x03D4;

		///<summary><![CDATA[int]]></summary>
		public const int StepGeneration = 0x03D8;

		///<summary><![CDATA[float]]></summary>
		public const int Size = 0x03DC;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int RoadMesh = 0x03E0;

		///<summary><![CDATA[TArray<USplineMeshComponent * >]]></summary>
		public const int RoadMeshesComp = 0x03E8;

		///<summary><![CDATA[TArray<FSideActorManager>]]></summary>
		public const int SideActors = 0x03F8;

		///<summary><![CDATA[TArray<FSideMeshManager>]]></summary>
		public const int SideMeshes = 0x0408;

	}

}
