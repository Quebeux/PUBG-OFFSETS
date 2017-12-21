/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ACrossActor
	{
		///<summary>FString</summary>
		public const int UniqueKey = 0x03C0;

		///<summary>TArray&lt;FCrossActorManager&gt;</summary>
		public const int SideActors = 0x03D0;

		///<summary>TArray&lt;FCrossMeshManager&gt;</summary>
		public const int SideMeshes = 0x03E0;

	}

	public class ARoadActor
	{
		///<summary>TEnumAsByte&lt;ESplineMeshAxis&gt;</summary>
		public const int SplineMeshAxis = 0x03B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03B1;

		///<summary>FVector</summary>
		public const int LocalOffset = 0x03B4;

		///<summary>ARoadActor *</summary>
		public const int Father = 0x03C0;

		///<summary>FString</summary>
		public const int UniqueKey = 0x03C8;

		///<summary>USplineComponent *</summary>
		public const int Spline = 0x03D8;

		///<summary>int</summary>
		public const int Index = 0x03E0;

		///<summary>int</summary>
		public const int Segmentation = 0x03E4;

		///<summary>int</summary>
		public const int StepGeneration = 0x03E8;

		///<summary>float</summary>
		public const int Size = 0x03EC;

		///<summary>UStaticMesh *</summary>
		public const int RoadMesh = 0x03F0;

		///<summary>TArray&lt;USplineMeshComponent * &gt;</summary>
		public const int RoadMeshesComp = 0x03F8;

		///<summary>TArray&lt;FSideActorManager&gt;</summary>
		public const int SideActors = 0x0408;

		///<summary>TArray&lt;FSideMeshManager&gt;</summary>
		public const int SideMeshes = 0x0418;

		///<summary>TArray&lt;FCurbsManager&gt;</summary>
		public const int SideCurbs = 0x0428;

	}

}
