/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULandscapeComponent
	{
		///<summary>int</summary>
		public const int ComponentSizeQuads = 0x06D0;

		///<summary>int</summary>
		public const int SubsectionSizeQuads = 0x06D4;

		///<summary>int</summary>
		public const int NumSubsections = 0x06D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x06DC;

		///<summary>UMaterialInterface *</summary>
		public const int OverrideMaterial = 0x06E0;

		///<summary>UMaterialInterface *</summary>
		public const int OverrideHoleMaterial = 0x06E8;

		///<summary>TArray<UMaterialInstanceConstant * ></summary>
		public const int MaterialInstances = 0x06F0;

		///<summary>TArray<FWeightmapLayerAllocationInfo></summary>
		public const int WeightmapLayerAllocations = 0x0700;

		///<summary>TArray<UTexture2D * ></summary>
		public const int WeightmapTextures = 0x0710;

		///<summary>UTexture2D *</summary>
		public const int XYOffsetmapTexture = 0x0720;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0728;

		///<summary>FVector4</summary>
		public const int WeightmapScaleBias = 0x0730;

		///<summary>float</summary>
		public const int WeightmapSubsectionOffset = 0x0740;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x0744;

		///<summary>FVector4</summary>
		public const int HeightmapScaleBias = 0x0750;

		///<summary>UTexture2D *</summary>
		public const int HeightmapTexture = 0x0760;

		///<summary>FBox</summary>
		public const int CachedLocalBox = 0x0768;

		///<summary>TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent></summary>
		public const int CollisionComponent = 0x0784;

		///<summary>FGuid</summary>
		public const int MapBuildDataId = 0x07A0;

		///<summary>TArray<FGuid></summary>
		public const int IrrelevantLights = 0x07B0;

		///<summary>int</summary>
		public const int CollisionMipLevel = 0x07C0;

		///<summary>int</summary>
		public const int SimpleCollisionMipLevel = 0x07C4;

		///<summary>float</summary>
		public const int NegativeZBoundsExtension = 0x07C8;

		///<summary>float</summary>
		public const int PositiveZBoundsExtension = 0x07CC;

		///<summary>float</summary>
		public const int StaticLightingResolution = 0x07D0;

		///<summary>int</summary>
		public const int ForcedLOD = 0x07D4;

		///<summary>int</summary>
		public const int LODBias = 0x07D8;

		///<summary>FGuid</summary>
		public const int StateId = 0x07DC;

		///<summary>FGuid</summary>
		public const int BakedTextureMaterialGuid = 0x07EC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x07FC;

		///<summary>UTexture2D *</summary>
		public const int GIBakedBaseColorTexture = 0x0800;

		///<summary>unsigned char</summary>
		public const int MobileBlendableLayerMask = 0x0808;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0809;

		///<summary>UMaterialInterface *</summary>
		public const int MobileMaterialInterface = 0x0810;

		///<summary>UTexture2D *</summary>
		public const int MobileWeightNormalmapTexture = 0x0818;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData05 = 0x0820;

	}

	public class ALandscapeGizmoActiveActor
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x03A0;

	}

	public class ULandscapeGrassType
	{
		///<summary>TArray<FGrassVariety></summary>
		public const int GrassVarieties = 0x0028;

		///<summary>UStaticMesh *</summary>
		public const int GrassMesh = 0x0038;

		///<summary>float</summary>
		public const int GrassDensity = 0x0040;

		///<summary>float</summary>
		public const int PlacementJitter = 0x0044;

		///<summary>int</summary>
		public const int StartCullDistance = 0x0048;

		///<summary>int</summary>
		public const int EndCullDistance = 0x004C;

		///<summary>bool</summary>
		public const int RandomRotation = 0x0050;

		///<summary>bool</summary>
		public const int AlignToSurface = 0x0051;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData00 = 0x0052;

	}

	public class ULandscapeHeightfieldCollisionComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x06D0;

		///<summary>int</summary>
		public const int SectionBaseX = 0x06D8;

		///<summary>int</summary>
		public const int SectionBaseY = 0x06DC;

		///<summary>int</summary>
		public const int CollisionSizeQuads = 0x06E0;

		///<summary>float</summary>
		public const int CollisionScale = 0x06E4;

		///<summary>int</summary>
		public const int SimpleCollisionSizeQuads = 0x06E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x06EC;

		///<summary>TArray<unsigned char></summary>
		public const int CollisionQuadFlags = 0x06F0;

		///<summary>FGuid</summary>
		public const int HeightfieldGuid = 0x0700;

		///<summary>FBox</summary>
		public const int CachedLocalBox = 0x0710;

		///<summary>TLazyObjectPtr<ULandscapeComponent></summary>
		public const int RenderComponent = 0x072C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0748;

		///<summary>TArray<UPhysicalMaterial * ></summary>
		public const int CookedPhysicalMaterials = 0x0758;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData03 = 0x0768;

	}

	public class ULandscapeMeshCollisionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x07B0;

	}

	public class ULandscapeInfo
	{
		///<summary>TLazyObjectPtr<ALandscape></summary>
		public const int LandscapeActor = 0x0028;

		///<summary>FGuid</summary>
		public const int LandscapeGuid = 0x0044;

		///<summary>int</summary>
		public const int ComponentSizeQuads = 0x0054;

		///<summary>int</summary>
		public const int SubsectionSizeQuads = 0x0058;

		///<summary>int</summary>
		public const int ComponentNumSubsections = 0x005C;

		///<summary>FVector</summary>
		public const int DrawScale = 0x0060;

		///<summary>unsigned char[0x54]</summary>
		public const int UnknownData00 = 0x006C;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x006C;

		///<summary>unsigned char[0xF0]</summary>
		public const int UnknownData02 = 0x0110;

	}

	public class ULandscapeInfoMap
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class ULandscapeLayerInfoObject
	{
		///<summary>FName</summary>
		public const int LayerName = 0x0028;

		///<summary>UPhysicalMaterial *</summary>
		public const int PhysMaterial = 0x0030;

		///<summary>float</summary>
		public const int Hardness = 0x0038;

		///<summary>FLinearColor</summary>
		public const int LayerUsageDebugColor = 0x003C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x004C;

	}

	public class ULandscapeMaterialInstanceConstant
	{
		///<summary>unsigned char:1</summary>
		public const int bIsLayerThumbnail = 0x01B0;

		///<summary>unsigned char:1</summary>
		public const int bDisableTessellation = 0x01B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01B1;

	}

	public class ALandscapeMeshProxyActor
	{
		///<summary>ULandscapeMeshProxyComponent *</summary>
		public const int LandscapeMeshProxyComponent = 0x03A0;

	}

	public class ULandscapeMeshProxyComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0810;

		///<summary>TArray<FIntPoint></summary>
		public const int ProxyComponentBases = 0x0818;

		///<summary>int8_t</summary>
		public const int ProxyLOD = 0x0828;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0829;

	}

	public class ALandscapeProxy
	{
		///<summary>ULandscapeSplinesComponent *</summary>
		public const int SplineComponent = 0x03A0;

		///<summary>FGuid</summary>
		public const int LandscapeGuid = 0x03A8;

		///<summary>FIntPoint</summary>
		public const int LandscapeSectionOffset = 0x03B8;

		///<summary>int</summary>
		public const int MaxLODLevel = 0x03C0;

		///<summary>float</summary>
		public const int LODDistanceFactor = 0x03C4;

		///<summary>TEnumAsByte<ELandscapeLODFalloff></summary>
		public const int LODFalloff = 0x03C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03C9;

		///<summary>int</summary>
		public const int StaticLightingLOD = 0x03CC;

		///<summary>UPhysicalMaterial *</summary>
		public const int DefaultPhysMaterial = 0x03D0;

		///<summary>float</summary>
		public const int StreamingDistanceMultiplier = 0x03D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03DC;

		///<summary>UMaterialInterface *</summary>
		public const int LandscapeMaterial = 0x03E0;

		///<summary>UMaterialInterface *</summary>
		public const int LandscapeHoleMaterial = 0x03E8;

		///<summary>float</summary>
		public const int NegativeZBoundsExtension = 0x03F0;

		///<summary>float</summary>
		public const int PositiveZBoundsExtension = 0x03F4;

		///<summary>TArray<ULandscapeComponent * ></summary>
		public const int LandscapeComponents = 0x03F8;

		///<summary>TArray<ULandscapeHeightfieldCollisionComponent * ></summary>
		public const int CollisionComponents = 0x0408;

		///<summary>TArray<UHierarchicalInstancedStaticMeshComponent * ></summary>
		public const int FoliageComponents = 0x0418;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData02 = 0x0428;

		///<summary>bool</summary>
		public const int bHasLandscapeGrass = 0x0488;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0489;

		///<summary>float</summary>
		public const int StaticLightingResolution = 0x048C;

		///<summary>unsigned char:1</summary>
		public const int bCastStaticShadow = 0x0490;

		///<summary>unsigned char:1</summary>
		public const int bCastShadowAsTwoSided = 0x0490;

		///<summary>unsigned char:1</summary>
		public const int bCastFarShadow = 0x0490;

		///<summary>unsigned char:1</summary>
		public const int bUseMaterialPositionOffsetInStaticLighting = 0x0490;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0491;

		///<summary>FLightmassPrimitiveSettings</summary>
		public const int LightmassSettings = 0x0494;

		///<summary>int</summary>
		public const int CollisionMipLevel = 0x04AC;

		///<summary>int</summary>
		public const int SimpleCollisionMipLevel = 0x04B0;

		///<summary>float</summary>
		public const int CollisionThickness = 0x04B4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x04B8;

		///<summary>FBodyInstance</summary>
		public const int BodyInstance = 0x04C0;

		///<summary>unsigned char:1</summary>
		public const int bGenerateOverlapEvents = 0x0680;

		///<summary>unsigned char:1</summary>
		public const int bBakeMaterialPositionOffsetIntoCollision = 0x0680;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0681;

		///<summary>int</summary>
		public const int ComponentSizeQuads = 0x0684;

		///<summary>int</summary>
		public const int SubsectionSizeQuads = 0x0688;

		///<summary>int</summary>
		public const int NumSubsections = 0x068C;

		///<summary>unsigned char:1</summary>
		public const int bUsedForNavigation = 0x0690;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0691;

		///<summary>TEnumAsByte<ENavDataGatheringMode></summary>
		public const int NavigationGeometryGatheringMode = 0x0694;

		///<summary>bool</summary>
		public const int bUseLandscapeForCullingInvisibleHLODVertices = 0x0695;

		///<summary>unsigned char[0xDA]</summary>
		public const int UnknownData08 = 0x0696;

	}

	public class ALandscapeStreamingProxy
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0770;

	}

	public class ULandscapeSplinesComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x06D0;

		///<summary>TArray<ULandscapeSplineSegment * ></summary>
		public const int Segments = 0x06D8;

		///<summary>TArray<UMeshComponent * ></summary>
		public const int CookedForeignMeshComponents = 0x06E8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x06F8;

	}

	public class ULandscapeSplineSegment
	{
		///<summary>FLandscapeSplineSegmentConnection[0x2]</summary>
		public const int Connections = 0x0028;

		///<summary>FInterpCurveVector</summary>
		public const int SplineInfo = 0x0058;

		///<summary>TArray<FLandscapeSplineInterpPoint></summary>
		public const int Points = 0x0070;

		///<summary>FBox</summary>
		public const int Bounds = 0x0080;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

		///<summary>TArray<USplineMeshComponent * ></summary>
		public const int LocalMeshComponents = 0x00A0;

	}

	public class ULandscapeSplineControlPoint
	{
		///<summary>FVector</summary>
		public const int Location = 0x0028;

		///<summary>FRotator</summary>
		public const int Rotation = 0x0034;

		///<summary>float</summary>
		public const int Width = 0x0040;

		///<summary>float</summary>
		public const int SideFalloff = 0x0044;

		///<summary>float</summary>
		public const int EndFalloff = 0x0048;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x004C;

		///<summary>TArray<FLandscapeSplineConnection></summary>
		public const int ConnectedSegments = 0x0050;

		///<summary>TArray<FLandscapeSplineInterpPoint></summary>
		public const int Points = 0x0060;

		///<summary>FBox</summary>
		public const int Bounds = 0x0070;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x008C;

		///<summary>UControlPointMeshComponent *</summary>
		public const int LocalMeshComponent = 0x0090;

	}

	public class UMaterialExpressionLandscapeGrassOutput
	{
		///<summary>TArray<FGrassInput></summary>
		public const int GrassTypes = 0x0060;

	}

	public class UMaterialExpressionLandscapeLayerBlend
	{
		///<summary>TArray<FLayerBlendInput></summary>
		public const int Layers = 0x0060;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x0070;

	}

	public class UMaterialExpressionLandscapeLayerCoords
	{
		///<summary>TEnumAsByte<ETerrainCoordMappingType></summary>
		public const int MappingType = 0x0060;

		///<summary>TEnumAsByte<ELandscapeCustomizedCoordType></summary>
		public const int CustomUVType = 0x0061;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0062;

		///<summary>float</summary>
		public const int MappingScale = 0x0064;

		///<summary>float</summary>
		public const int MappingRotation = 0x0068;

		///<summary>float</summary>
		public const int MappingPanU = 0x006C;

		///<summary>float</summary>
		public const int MappingPanV = 0x0070;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0074;

	}

	public class UMaterialExpressionLandscapeLayerSample
	{
		///<summary>FName</summary>
		public const int ParameterName = 0x0060;

		///<summary>float</summary>
		public const int PreviewWeight = 0x0068;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x006C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x007C;

	}

	public class UMaterialExpressionLandscapeLayerSwitch
	{
		///<summary>FExpressionInput</summary>
		public const int LayerUsed = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int LayerNotUsed = 0x0098;

		///<summary>FName</summary>
		public const int ParameterName = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int PreviewUsed = 0x00D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00D9;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x00DC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x00EC;

	}

	public class UMaterialExpressionLandscapeLayerWeight
	{
		///<summary>FExpressionInput</summary>
		public const int Base = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Layer = 0x0098;

		///<summary>FName</summary>
		public const int ParameterName = 0x00D0;

		///<summary>float</summary>
		public const int PreviewWeight = 0x00D8;

		///<summary>FVector</summary>
		public const int ConstBase = 0x00DC;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x00E8;

	}

	public class UMaterialExpressionLandscapeVisibilityMask
	{
		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x0060;

	}

}
