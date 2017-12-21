/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCustomizableSkeletalComponent
	{
		///<summary>UCustomizableObjectInstance *</summary>
		public const int CustomizableObjectInstance = 0x03F0;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData00 = 0x03F8;

	}

	public class UCustomizableObjectInstance
	{
		///<summary>UCustomizableObject *</summary>
		public const int CustomizableObject = 0x0028;

		///<summary>USkeletalMesh *</summary>
		public const int SkeletalMesh = 0x0030;

		///<summary>int</summary>
		public const int State = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

		///<summary>TArray&lt;FCustomizableObjectBoolParameterValue&gt;</summary>
		public const int BoolParameters = 0x0040;

		///<summary>TArray&lt;FCustomizableObjectIntParameterValue&gt;</summary>
		public const int IntParameters = 0x0050;

		///<summary>TArray&lt;FCustomizableObjectFloatParameterValue&gt;</summary>
		public const int FloatParameters = 0x0060;

		///<summary>TArray&lt;FCustomizableObjectVectorParameterValue&gt;</summary>
		public const int VectorParameters = 0x0070;

		///<summary>TArray&lt;FCustomizableObjectProjectorParameterValue&gt;</summary>
		public const int ProjectorParameters = 0x0080;

		///<summary>bool</summary>
		public const int bBuildRawData = 0x0090;

		///<summary>bool</summary>
		public const int bBuildRenderData = 0x0091;

		///<summary>unsigned char[0x9E]</summary>
		public const int UnknownData01 = 0x0092;

		///<summary>UCustomizableInstancePrivateData *</summary>
		public const int PrivateData = 0x0130;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0138;

	}

	public class UCustomizableInstancePrivateData
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FGeneratedMaterial&gt;</summary>
		public const int GeneratedMaterials = 0x0030;

		///<summary>TArray&lt;FGeneratedMesh&gt;</summary>
		public const int GeneratedMeshes = 0x0040;

		///<summary>TArray&lt;FGeneratedTexture&gt;</summary>
		public const int GeneratedTextures = 0x0050;

		///<summary>unsigned char[0x138]</summary>
		public const int UnknownData01 = 0x0060;

	}

	public class UCustomizableObject
	{
		///<summary>USkeletalMesh *</summary>
		public const int ReferenceSkeletalMesh = 0x0028;

		///<summary>UStaticMesh *</summary>
		public const int ReferenceStaticMesh = 0x0030;

		///<summary>ECustomizableObjectRelevancy</summary>
		public const int Relevancy = 0x0038;

		///<summary>bool</summary>
		public const int bDisableTextureLayoutManagement = 0x0039;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x003A;

		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int ReferencedMaterials = 0x0040;

		///<summary>TArray&lt;FMutableModelImageProperties&gt;</summary>
		public const int ImageProperties = 0x0050;

		///<summary>TMap&lt;FString,FCustomizableObjectIdPair&gt;</summary>
		public const int GroupNodeMap = 0x0060;

		///<summary>FCompilationOptions</summary>
		public const int CompileOptions = 0x00B0;

		///<summary>FGuid</summary>
		public const int VersionId = 0x00C8;

		///<summary>TArray&lt;FMutableModelParameterProperties&gt;</summary>
		public const int ParameterProperties = 0x00D8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x00E8;

	}

	public class UCustomizableObjectSystem
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UTexture2D * &gt;</summary>
		public const int ProtectedCachedTextures = 0x0038;

		///<summary>TArray&lt;FPendingReleaseSkeletalMeshInfo&gt;</summary>
		public const int PendingReleaseSkeletalMesh = 0x0048;

	}

}
