/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULandscapeComponent
	{
		///<summary>int</summary>
		public const int ComponentSizeQuads = 0x0850;

		///<summary>int</summary>
		public const int SubsectionSizeQuads = 0x0854;

		///<summary>int</summary>
		public const int NumSubsections = 0x0858;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x085C;

		///<summary>UMaterialInterface *</summary>
		public const int OverrideMaterial = 0x0860;

		///<summary>UMaterialInterface *</summary>
		public const int OverrideHoleMaterial = 0x0868;

		///<summary>TArray&lt;UMaterialInstanceConstant * &gt;</summary>
		public const int MaterialInstances = 0x0870;

		///<summary>TArray&lt;FWeightmapLayerAllocationInfo&gt;</summary>
		public const int WeightmapLayerAllocations = 0x0880;

		///<summary>TArray&lt;UTexture2D * &gt;</summary>
		public const int WeightmapTextures = 0x0890;

		///<summary>UTexture2D *</summary>
		public const int XYOffsetmapTexture = 0x08A0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x08A8;

		///<summary>FVector4</summary>
		public const int WeightmapScaleBias = 0x08B0;

		///<summary>float</summary>
		public const int WeightmapSubsectionOffset = 0x08C0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x08C4;

		///<summary>FVector4</summary>
		public const int HeightmapScaleBias = 0x08D0;

		///<summary>UTexture2D *</summary>
		public const int HeightmapTexture = 0x08E0;

		///<summary>FBox</summary>
		public const int CachedLocalBox = 0x08E8;

		///<summary>TLazyObjectPtr&lt;ULandscapeHeightfieldCollisionComponent&gt;</summary>
		public const int CollisionComponent = 0x0904;

		///<summary>FGuid</summary>
		public const int MapBuildDataId = 0x0920;

		///<summary>TArray&lt;FGuid&gt;</summary>
		public const int IrrelevantLights = 0x0930;

		///<summary>int</summary>
		public const int CollisionMipLevel = 0x0940;

		///<summary>int</summary>
		public const int SimpleCollisionMipLevel = 0x0944;

		///<summary>float</summary>
		public const int NegativeZBoundsExtension = 0x0948;

		///<summary>float</summary>
		public const int PositiveZBoundsExtension = 0x094C;

		///<summary>float</summary>
		public const int StaticLightingResolution = 0x0950;

		///<summary>int</summary>
		public const int ForcedLOD = 0x0954;

		///<summary>int</summary>
		public const int LODBias = 0x0958;

		///<summary>FGuid</summary>
		public const int StateId = 0x095C;

		///<summary>FGuid</summary>
		public const int BakedTextureMaterialGuid = 0x096C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x097C;

		///<summary>UTexture2D *</summary>
		public const int GIBakedBaseColorTexture = 0x0980;

		///<summary>bool</summary>
		public const int bRemoveGrass = 0x0988;

		///<summary>unsigned char</summary>
		public const int MobileBlendableLayerMask = 0x0989;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData04 = 0x098A;

		///<summary>UMaterialInterface *</summary>
		public const int MobileMaterialInterface = 0x0990;

		///<summary>UTexture2D *</summary>
		public const int MobileWeightNormalmapTexture = 0x0998;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData05 = 0x09A0;

	}

	public class ALandscapeGizmoActiveActor
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class ULandscapeGrassType
	{
		///<summary>TArray&lt;FGrassVariety&gt;</summary>
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
		public const int UnknownData00 = 0x0850;

		///<summary>int</summary>
		public const int SectionBaseX = 0x0858;

		///<summary>int</summary>
		public const int SectionBaseY = 0x085C;

		///<summary>int</summary>
		public const int CollisionSizeQuads = 0x0860;

		///<summary>float</summary>
		public const int CollisionScale = 0x0864;

		///<summary>int</summary>
		public const int SimpleCollisionSizeQuads = 0x0868;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x086C;

		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int CollisionQuadFlags = 0x0870;

		///<summary>FGuid</summary>
		public const int HeightfieldGuid = 0x0880;

		///<summary>FBox</summary>
		public const int CachedLocalBox = 0x0890;

		///<summary>TLazyObjectPtr&lt;ULandscapeComponent&gt;</summary>
		public const int RenderComponent = 0x08AC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x08C8;

		///<summary>TArray&lt;UPhysicalMaterial * &gt;</summary>
		public const int CookedPhysicalMaterials = 0x08D8;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData03 = 0x08E8;

	}

	public class ULandscapeMeshCollisionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0930;

	}

	public class ULandscapeInfo
	{
		///<summary>TLazyObjectPtr&lt;ALandscape&gt;</summary>
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
		public const int LandscapeMeshProxyComponent = 0x03B0;

	}

	public class ULandscapeMeshProxyComponent
	{
		///<summary>FGuid</summary>
		public const int LandscapeGuid = 0x09E0;

		///<summary>TArray&lt;FIntPoint&gt;</summary>
		public const int ProxyComponentBases = 0x09F0;

		///<summary>int8_t</summary>
		public const int ProxyLOD = 0x0A00;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x0A01;

	}

	public class ALandscapeProxy
	{
		///<summary>ULandscapeSplinesComponent *</summary>
		public const int SplineComponent = 0x03B0;

		///<summary>FGuid</summary>
		public const int LandscapeGuid = 0x03B8;

		///<summary>FIntPoint</summary>
		public const int LandscapeSectionOffset = 0x03C8;

		///<summary>int</summary>
		public const int MaxLODLevel = 0x03D0;

		///<summary>float</summary>
		public const int LODDistanceFactor = 0x03D4;

		///<summary>TEnumAsByte&lt;ELandscapeLODFalloff&gt;</summary>
		public const int LODFalloff = 0x03D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03D9;

		///<summary>int</summary>
		public const int StaticLightingLOD = 0x03DC;

		///<summary>UPhysicalMaterial *</summary>
		public const int DefaultPhysMaterial = 0x03E0;

		///<summary>float</summary>
		public const int StreamingDistanceMultiplier = 0x03E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03EC;

		///<summary>UMaterialInterface *</summary>
		public const int LandscapeMaterial = 0x03F0;

		///<summary>UMaterialInterface *</summary>
		public const int LandscapeHoleMaterial = 0x03F8;

		///<summary>float</summary>
		public const int NegativeZBoundsExtension = 0x0400;

		///<summary>float</summary>
		public const int PositiveZBoundsExtension = 0x0404;

		///<summary>TArray&lt;ULandscapeComponent * &gt;</summary>
		public const int LandscapeComponents = 0x0408;

		///<summary>TArray&lt;ULandscapeHeightfieldCollisionComponent * &gt;</summary>
		public const int CollisionComponents = 0x0418;

		///<summary>TArray&lt;UHierarchicalInstancedStaticMeshComponent * &gt;</summary>
		public const int FoliageComponents = 0x0428;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData02 = 0x0438;

		///<summary>bool</summary>
		public const int bHasLandscapeGrass = 0x0498;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0499;

		///<summary>float</summary>
		public const int StaticLightingResolution = 0x049C;

		///<summary>unsigned char:1</summary>
		public const int bCastStaticShadow = 0x04A0;

		///<summary>unsigned char:1</summary>
		public const int bCastShadowAsTwoSided = 0x04A0;

		///<summary>unsigned char:1</summary>
		public const int bCastFarShadow = 0x04A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x04A1;

		///<summary>FLightingChannels</summary>
		public const int LightingChannels = 0x04A4;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData05 = 0x04A7;

		///<summary>unsigned char:1</summary>
		public const int bUseMaterialPositionOffsetInStaticLighting = 0x04A8;

		///<summary>unsigned char:1</summary>
		public const int bRenderCustomDepth = 0x04A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x04A9;

		///<summary>int</summary>
		public const int CustomDepthStencilValue = 0x04AC;

		///<summary>FLightmassPrimitiveSettings</summary>
		public const int LightmassSettings = 0x04B0;

		///<summary>int</summary>
		public const int CollisionMipLevel = 0x04C8;

		///<summary>int</summary>
		public const int SimpleCollisionMipLevel = 0x04CC;

		///<summary>float</summary>
		public const int CollisionThickness = 0x04D0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData07 = 0x04D4;

		///<summary>FBodyInstance</summary>
		public const int BodyInstance = 0x04E0;

		///<summary>unsigned char:1</summary>
		public const int bGenerateOverlapEvents = 0x0720;

		///<summary>unsigned char:1</summary>
		public const int bBakeMaterialPositionOffsetIntoCollision = 0x0720;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0721;

		///<summary>int</summary>
		public const int ComponentSizeQuads = 0x0724;

		///<summary>int</summary>
		public const int SubsectionSizeQuads = 0x0728;

		///<summary>int</summary>
		public const int NumSubsections = 0x072C;

		///<summary>unsigned char:1</summary>
		public const int bUsedForNavigation = 0x0730;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x0731;

		///<summary>ENavDataGatheringMode</summary>
		public const int NavigationGeometryGatheringMode = 0x0734;

		///<summary>bool</summary>
		public const int bUseLandscapeForCullingInvisibleHLODVertices = 0x0735;

		///<summary>unsigned char[0xDA]</summary>
		public const int UnknownData10 = 0x0736;

	}

	public class ALandscapeStreamingProxy
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0810;

	}

	public class ULandscapeSplinesComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0850;

		///<summary>TArray&lt;ULandscapeSplineSegment * &gt;</summary>
		public const int Segments = 0x0858;

		///<summary>TArray&lt;UMeshComponent * &gt;</summary>
		public const int CookedForeignMeshComponents = 0x0868;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0878;

	}

	public class ULandscapeSplineSegment
	{
		///<summary>FLandscapeSplineSegmentConnection[0x2]</summary>
		public const int Connections = 0x0028;

		///<summary>FInterpCurveVector</summary>
		public const int SplineInfo = 0x0058;

		///<summary>TArray&lt;FLandscapeSplineInterpPoint&gt;</summary>
		public const int Points = 0x0070;

		///<summary>FBox</summary>
		public const int Bounds = 0x0080;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

		///<summary>TArray&lt;USplineMeshComponent * &gt;</summary>
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

		///<summary>TArray&lt;FLandscapeSplineConnection&gt;</summary>
		public const int ConnectedSegments = 0x0050;

		///<summary>TArray&lt;FLandscapeSplineInterpPoint&gt;</summary>
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
		///<summary>TArray&lt;FGrassInput&gt;</summary>
		public const int GrassTypes = 0x0060;

	}

	public class UMaterialExpressionLandscapeLayerBlend
	{
		///<summary>TArray&lt;FLayerBlendInput&gt;</summary>
		public const int Layers = 0x0060;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x0070;

	}

	public class UMaterialExpressionLandscapeLayerCoords
	{
		///<summary>TEnumAsByte&lt;ETerrainCoordMappingType&gt;</summary>
		public const int MappingType = 0x0060;

		///<summary>TEnumAsByte&lt;ELandscapeCustomizedCoordType&gt;</summary>
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
