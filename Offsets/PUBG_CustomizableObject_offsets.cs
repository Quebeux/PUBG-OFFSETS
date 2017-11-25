/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCustomizableMeshComponent
	{
		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x0300;

		///<summary><![CDATA[TArray<TWeakObjectPtr<UTexture2D>>]]></summary>
		public const int CreatedTextures = 0x0358;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0368;

	}

	public class UCustomizableSkeletalComponent
	{
		///<summary><![CDATA[USkeletalMesh *]]></summary>
		public const int SkeletalMesh = 0x0370;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData00 = 0x0378;

	}

	public class UCustomizableInstancePrivateData
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FGeneratedMaterial>]]></summary>
		public const int GeneratedMaterials = 0x0030;

		///<summary><![CDATA[TArray<FGeneratedMesh>]]></summary>
		public const int GeneratedMeshes = 0x0040;

		///<summary><![CDATA[TArray<FGeneratedTexture>]]></summary>
		public const int GeneratedTextures = 0x0050;

		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData01 = 0x0060;

	}

	public class UCustomizableObject
	{
		///<summary><![CDATA[USkeletalMesh *]]></summary>
		public const int ReferenceSkeletalMesh = 0x0028;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int ReferenceStaticMesh = 0x0030;

		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int ReferencedMaterials = 0x0038;

		///<summary><![CDATA[TArray<FMutableModelImageProperties>]]></summary>
		public const int ImageProperties = 0x0048;

		///<summary><![CDATA[TMap<FString,FCustomizableObjectIdPair>]]></summary>
		public const int GroupNodeMap = 0x0058;

		///<summary><![CDATA[FCompilationOptions]]></summary>
		public const int CompileOptions = 0x00A8;

		///<summary><![CDATA[FGuid]]></summary>
		public const int VersionId = 0x00B4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00C4;

		///<summary><![CDATA[TArray<FMutableModelParameterProperties>]]></summary>
		public const int ParameterProperties = 0x00C8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x00D8;

	}

	public class UCustomizableObjectInstance
	{
		///<summary><![CDATA[UCustomizableObject *]]></summary>
		public const int CustomizableObject = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int State = 0x0030;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0034;

		///<summary><![CDATA[TArray<FCustomizableObjectBoolParameterValue>]]></summary>
		public const int BoolParameters = 0x0038;

		///<summary><![CDATA[TArray<FCustomizableObjectIntParameterValue>]]></summary>
		public const int IntParameters = 0x0048;

		///<summary><![CDATA[TArray<FCustomizableObjectFloatParameterValue>]]></summary>
		public const int FloatParameters = 0x0058;

		///<summary><![CDATA[TArray<FCustomizableObjectVectorParameterValue>]]></summary>
		public const int VectorParameters = 0x0068;

		///<summary><![CDATA[TArray<FCustomizableObjectProjectorParameterValue>]]></summary>
		public const int ProjectorParameters = 0x0078;

		///<summary><![CDATA[bool]]></summary>
		public const int bBuildRawData = 0x0088;

		///<summary><![CDATA[bool]]></summary>
		public const int bBuildRenderData = 0x0089;

		///<summary><![CDATA[unsigned char[0x96]]]></summary>
		public const int UnknownData01 = 0x008A;

		///<summary><![CDATA[UCustomizableInstancePrivateData *]]></summary>
		public const int PrivateData = 0x0120;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0128;

	}

	public class UCustomizableObjectSystem
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FMutableSkeletalMeshTracker>]]></summary>
		public const int SkeletalMeshTrackerArray = 0x0048;

		///<summary><![CDATA[TArray<FMutableTextureTracker>]]></summary>
		public const int TextureTrackerArray = 0x0058;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x0068;

		///<summary><![CDATA[UCustomizableSkeletalComponent *]]></summary>
		public const int CurrentBeginUpdateComponent = 0x0088;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData02 = 0x0090;

	}

}
