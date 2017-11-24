/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCustomizableMeshComponent
	{
		public const int UnknownData00 = 0x0300;
		public const int CreatedTextures = 0x0358;
		public const int UnknownData01 = 0x0368;
	}

	public class UCustomizableSkeletalComponent
	{
		public const int SkeletalMesh = 0x0370;
		public const int UnknownData00 = 0x0378;
	}

	public class UCustomizableInstancePrivateData
	{
		public const int UnknownData00 = 0x0028;
		public const int GeneratedMaterials = 0x0030;
		public const int GeneratedMeshes = 0x0040;
		public const int GeneratedTextures = 0x0050;
		public const int UnknownData01 = 0x0060;
	}

	public class UCustomizableObject
	{
		public const int ReferenceSkeletalMesh = 0x0028;
		public const int ReferenceStaticMesh = 0x0030;
		public const int ReferencedMaterials = 0x0038;
		public const int ImageProperties = 0x0048;
		public const int GroupNodeMap = 0x0058;
		public const int CompileOptions = 0x00A8;
		public const int VersionId = 0x00B4;
		public const int UnknownData00 = 0x00C4;
		public const int ParameterProperties = 0x00C8;
		public const int UnknownData01 = 0x00D8;
	}

	public class UCustomizableObjectInstance
	{
		public const int CustomizableObject = 0x0028;
		public const int State = 0x0030;
		public const int UnknownData00 = 0x0034;
		public const int BoolParameters = 0x0038;
		public const int IntParameters = 0x0048;
		public const int FloatParameters = 0x0058;
		public const int VectorParameters = 0x0068;
		public const int ProjectorParameters = 0x0078;
		public const int bBuildRawData = 0x0088;
		public const int bBuildRenderData = 0x0089;
		public const int UnknownData01 = 0x008A;
		public const int PrivateData = 0x0120;
		public const int UnknownData02 = 0x0128;
	}

	public class UCustomizableObjectSystem
	{
		public const int UnknownData00 = 0x0028;
		public const int SkeletalMeshTrackerArray = 0x0048;
		public const int TextureTrackerArray = 0x0058;
		public const int UnknownData01 = 0x0068;
		public const int CurrentBeginUpdateComponent = 0x0088;
		public const int UnknownData02 = 0x0090;
	}

}
