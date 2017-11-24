/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULandscapeComponent
	{
		public const int ComponentSizeQuads = 0x06D0;
		public const int SubsectionSizeQuads = 0x06D4;
		public const int NumSubsections = 0x06D8;
		public const int UnknownData00 = 0x06DC;
		public const int OverrideMaterial = 0x06E0;
		public const int OverrideHoleMaterial = 0x06E8;
		public const int XYOffsetmapTexture = 0x0720;
		public const int UnknownData01 = 0x0728;
		public const int WeightmapScaleBias = 0x0730;
		public const int WeightmapSubsectionOffset = 0x0740;
		public const int UnknownData02 = 0x0744;
		public const int HeightmapScaleBias = 0x0750;
		public const int HeightmapTexture = 0x0760;
		public const int CachedLocalBox = 0x0768;
		public const int MapBuildDataId = 0x07A0;
		public const int CollisionMipLevel = 0x07C0;
		public const int SimpleCollisionMipLevel = 0x07C4;
		public const int NegativeZBoundsExtension = 0x07C8;
		public const int PositiveZBoundsExtension = 0x07CC;
		public const int StaticLightingResolution = 0x07D0;
		public const int ForcedLOD = 0x07D4;
		public const int LODBias = 0x07D8;
		public const int StateId = 0x07DC;
		public const int BakedTextureMaterialGuid = 0x07EC;
		public const int UnknownData03 = 0x07FC;
		public const int GIBakedBaseColorTexture = 0x0800;
		public const int MobileBlendableLayerMask = 0x0808;
		public const int UnknownData04 = 0x0809;
		public const int MobileMaterialInterface = 0x0810;
		public const int MobileWeightNormalmapTexture = 0x0818;
		public const int UnknownData05 = 0x0820;
	}

	public class ALandscapeGizmoActiveActor
	{
		public const int UnknownData00 = 0x03A0;
	}

	public class ULandscapeGrassType
	{
		public const int GrassMesh = 0x0038;
		public const int GrassDensity = 0x0040;
		public const int PlacementJitter = 0x0044;
		public const int StartCullDistance = 0x0048;
		public const int EndCullDistance = 0x004C;
		public const int RandomRotation = 0x0050;
		public const int AlignToSurface = 0x0051;
		public const int UnknownData00 = 0x0052;
	}

	public class ULandscapeHeightfieldCollisionComponent
	{
		public const int UnknownData00 = 0x06D0;
		public const int SectionBaseX = 0x06D8;
		public const int SectionBaseY = 0x06DC;
		public const int CollisionSizeQuads = 0x06E0;
		public const int CollisionScale = 0x06E4;
		public const int SimpleCollisionSizeQuads = 0x06E8;
		public const int UnknownData01 = 0x06EC;
		public const int CollisionQuadFlags = 0x06F0;
		public const int HeightfieldGuid = 0x0700;
		public const int CachedLocalBox = 0x0710;
		public const int UnknownData02 = 0x0748;
		public const int UnknownData03 = 0x0768;
	}

	public class ULandscapeMeshCollisionComponent
	{
		public const int UnknownData00 = 0x07B0;
	}

	public class ULandscapeInfo
	{
		public const int LandscapeGuid = 0x0044;
		public const int ComponentSizeQuads = 0x0054;
		public const int SubsectionSizeQuads = 0x0058;
		public const int ComponentNumSubsections = 0x005C;
		public const int DrawScale = 0x0060;
		public const int UnknownData00 = 0x006C;
		public const int UnknownData01 = 0x006C;
		public const int UnknownData02 = 0x0110;
	}

	public class ULandscapeInfoMap
	{
		public const int UnknownData00 = 0x0028;
	}

	public class ULandscapeLayerInfoObject
	{
		public const int LayerName = 0x0028;
		public const int PhysMaterial = 0x0030;
		public const int Hardness = 0x0038;
		public const int LayerUsageDebugColor = 0x003C;
		public const int UnknownData00 = 0x004C;
	}

	public class ULandscapeMaterialInstanceConstant
	{
		public const int bIsLayerThumbnail = 0x01B0;
		public const int bDisableTessellation = 0x01B0;
		public const int UnknownData00 = 0x01B1;
	}

	public class ALandscapeMeshProxyActor
	{
		public const int LandscapeMeshProxyComponent = 0x03A0;
	}

	public class ULandscapeMeshProxyComponent
	{
		public const int UnknownData00 = 0x0810;
		public const int ProxyLOD = 0x0828;
		public const int UnknownData01 = 0x0829;
	}

	public class ALandscapeProxy
	{
		public const int SplineComponent = 0x03A0;
		public const int LandscapeGuid = 0x03A8;
		public const int LandscapeSectionOffset = 0x03B8;
		public const int MaxLODLevel = 0x03C0;
		public const int LODDistanceFactor = 0x03C4;
		public const int LODFalloff = 0x03C8;
		public const int UnknownData00 = 0x03C9;
		public const int StaticLightingLOD = 0x03CC;
		public const int DefaultPhysMaterial = 0x03D0;
		public const int StreamingDistanceMultiplier = 0x03D8;
		public const int UnknownData01 = 0x03DC;
		public const int LandscapeMaterial = 0x03E0;
		public const int LandscapeHoleMaterial = 0x03E8;
		public const int NegativeZBoundsExtension = 0x03F0;
		public const int PositiveZBoundsExtension = 0x03F4;
		public const int UnknownData02 = 0x0428;
		public const int bHasLandscapeGrass = 0x0488;
		public const int UnknownData03 = 0x0489;
		public const int StaticLightingResolution = 0x048C;
		public const int bCastStaticShadow = 0x0490;
		public const int bCastShadowAsTwoSided = 0x0490;
		public const int bCastFarShadow = 0x0490;
		public const int bUseMaterialPositionOffsetInStaticLighting = 0x0490;
		public const int UnknownData04 = 0x0491;
		public const int LightmassSettings = 0x0494;
		public const int CollisionMipLevel = 0x04AC;
		public const int SimpleCollisionMipLevel = 0x04B0;
		public const int CollisionThickness = 0x04B4;
		public const int UnknownData05 = 0x04B8;
		public const int BodyInstance = 0x04C0;
		public const int bGenerateOverlapEvents = 0x0680;
		public const int bBakeMaterialPositionOffsetIntoCollision = 0x0680;
		public const int UnknownData06 = 0x0681;
		public const int ComponentSizeQuads = 0x0684;
		public const int SubsectionSizeQuads = 0x0688;
		public const int NumSubsections = 0x068C;
		public const int bUsedForNavigation = 0x0690;
		public const int UnknownData07 = 0x0691;
		public const int NavigationGeometryGatheringMode = 0x0694;
		public const int bUseLandscapeForCullingInvisibleHLODVertices = 0x0695;
		public const int UnknownData08 = 0x0696;
	}

	public class ALandscapeStreamingProxy
	{
		public const int UnknownData00 = 0x0770;
	}

	public class ULandscapeSplinesComponent
	{
		public const int UnknownData00 = 0x06D0;
		public const int UnknownData01 = 0x06F8;
	}

	public class ULandscapeSplineSegment
	{
		public const int Connections = 0x0028;
		public const int SplineInfo = 0x0058;
		public const int Bounds = 0x0080;
		public const int UnknownData00 = 0x009C;
	}

	public class ULandscapeSplineControlPoint
	{
		public const int Location = 0x0028;
		public const int Rotation = 0x0034;
		public const int Width = 0x0040;
		public const int SideFalloff = 0x0044;
		public const int EndFalloff = 0x0048;
		public const int UnknownData00 = 0x004C;
		public const int Bounds = 0x0070;
		public const int UnknownData01 = 0x008C;
		public const int LocalMeshComponent = 0x0090;
	}

	public class UMaterialExpressionLandscapeLayerBlend
	{
		public const int ExpressionGUID = 0x0070;
	}

	public class UMaterialExpressionLandscapeLayerCoords
	{
		public const int MappingType = 0x0060;
		public const int CustomUVType = 0x0061;
		public const int UnknownData00 = 0x0062;
		public const int MappingScale = 0x0064;
		public const int MappingRotation = 0x0068;
		public const int MappingPanU = 0x006C;
		public const int MappingPanV = 0x0070;
		public const int UnknownData01 = 0x0074;
	}

	public class UMaterialExpressionLandscapeLayerSample
	{
		public const int ParameterName = 0x0060;
		public const int PreviewWeight = 0x0068;
		public const int ExpressionGUID = 0x006C;
		public const int UnknownData00 = 0x007C;
	}

	public class UMaterialExpressionLandscapeLayerSwitch
	{
		public const int LayerUsed = 0x0060;
		public const int LayerNotUsed = 0x0098;
		public const int ParameterName = 0x00D0;
		public const int PreviewUsed = 0x00D8;
		public const int UnknownData00 = 0x00D9;
		public const int ExpressionGUID = 0x00DC;
		public const int UnknownData01 = 0x00EC;
	}

	public class UMaterialExpressionLandscapeLayerWeight
	{
		public const int Base = 0x0060;
		public const int Layer = 0x0098;
		public const int ParameterName = 0x00D0;
		public const int PreviewWeight = 0x00D8;
		public const int ConstBase = 0x00DC;
		public const int ExpressionGUID = 0x00E8;
	}

	public class UMaterialExpressionLandscapeVisibilityMask
	{
		public const int ExpressionGUID = 0x0060;
	}

}
