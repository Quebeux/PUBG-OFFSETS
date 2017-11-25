/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCustomizableMeshComponent
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0300;

		///<summary>TArray<TWeakObjectPtr<UTexture2D>></summary>
		public const int CreatedTextures = 0x0358;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0368;

	}

	public class UCustomizableSkeletalComponent
	{
		///<summary>USkeletalMesh *</summary>
		public const int SkeletalMesh = 0x0370;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData00 = 0x0378;

	}

	public class UCustomizableInstancePrivateData
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray<FGeneratedMaterial></summary>
		public const int GeneratedMaterials = 0x0030;

		///<summary>TArray<FGeneratedMesh></summary>
		public const int GeneratedMeshes = 0x0040;

		///<summary>TArray<FGeneratedTexture></summary>
		public const int GeneratedTextures = 0x0050;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData01 = 0x0060;

	}

	public class UCustomizableObject
	{
		///<summary>USkeletalMesh *</summary>
		public const int ReferenceSkeletalMesh = 0x0028;

		///<summary>UStaticMesh *</summary>
		public const int ReferenceStaticMesh = 0x0030;

		///<summary>TArray<UMaterialInterface * ></summary>
		public const int ReferencedMaterials = 0x0038;

		///<summary>TArray<FMutableModelImageProperties></summary>
		public const int ImageProperties = 0x0048;

		///<summary>TMap<FString,FCustomizableObjectIdPair></summary>
		public const int GroupNodeMap = 0x0058;

		///<summary>FCompilationOptions</summary>
		public const int CompileOptions = 0x00A8;

		///<summary>FGuid</summary>
		public const int VersionId = 0x00B4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00C4;

		///<summary>TArray<FMutableModelParameterProperties></summary>
		public const int ParameterProperties = 0x00C8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x00D8;

	}

	public class UCustomizableObjectInstance
	{
		///<summary>UCustomizableObject *</summary>
		public const int CustomizableObject = 0x0028;

		///<summary>int</summary>
		public const int State = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

		///<summary>TArray<FCustomizableObjectBoolParameterValue></summary>
		public const int BoolParameters = 0x0038;

		///<summary>TArray<FCustomizableObjectIntParameterValue></summary>
		public const int IntParameters = 0x0048;

		///<summary>TArray<FCustomizableObjectFloatParameterValue></summary>
		public const int FloatParameters = 0x0058;

		///<summary>TArray<FCustomizableObjectVectorParameterValue></summary>
		public const int VectorParameters = 0x0068;

		///<summary>TArray<FCustomizableObjectProjectorParameterValue></summary>
		public const int ProjectorParameters = 0x0078;

		///<summary>bool</summary>
		public const int bBuildRawData = 0x0088;

		///<summary>bool</summary>
		public const int bBuildRenderData = 0x0089;

		///<summary>unsigned char[0x96]</summary>
		public const int UnknownData01 = 0x008A;

		///<summary>UCustomizableInstancePrivateData *</summary>
		public const int PrivateData = 0x0120;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0128;

	}

	public class UCustomizableObjectSystem
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray<FMutableSkeletalMeshTracker></summary>
		public const int SkeletalMeshTrackerArray = 0x0048;

		///<summary>TArray<FMutableTextureTracker></summary>
		public const int TextureTrackerArray = 0x0058;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0068;

		///<summary>UCustomizableSkeletalComponent *</summary>
		public const int CurrentBeginUpdateComponent = 0x0088;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData02 = 0x0090;

	}

}
