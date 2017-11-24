/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UFoliageInstancedStaticMeshComponent
	{
		public const int UnknownData00 = 0x09E0;
		public const int OnInstanceTakeRadialDamage = 0x09E8;
		public const int UnknownData01 = 0x09F8;
	}

	public class UFoliageType
	{
		public const int UpdateGuid = 0x0028;
		public const int Density = 0x0038;
		public const int DensityAdjustmentFactor = 0x003C;
		public const int Radius = 0x0040;
		public const int Scaling = 0x0044;
		public const int UnknownData00 = 0x0045;
		public const int ScaleX = 0x0048;
		public const int ScaleY = 0x0050;
		public const int ScaleZ = 0x0058;
		public const int VertexColorMaskByChannel = 0x0060;
		public const int VertexColorMask = 0x0090;
		public const int UnknownData01 = 0x0091;
		public const int VertexColorMaskThreshold = 0x0094;
		public const int VertexColorMaskInvert = 0x0098;
		public const int UnknownData02 = 0x0099;
		public const int ZOffset = 0x009C;
		public const int AlignToNormal = 0x00A4;
		public const int UnknownData03 = 0x00A5;
		public const int AlignMaxAngle = 0x00A8;
		public const int RandomYaw = 0x00AC;
		public const int UnknownData04 = 0x00AD;
		public const int RandomPitchAngle = 0x00B0;
		public const int GroundSlopeAngle = 0x00B4;
		public const int Height = 0x00BC;
		public const int UnknownData05 = 0x00C4;
		public const int LandscapeLayers = 0x00C8;
		public const int LandscapeLayer = 0x00D8;
		public const int CollisionWithWorld = 0x00E0;
		public const int UnknownData06 = 0x00E1;
		public const int CollisionScale = 0x00E4;
		public const int MinimumLayerWeight = 0x00F0;
		public const int MeshBounds = 0x00F4;
		public const int LowBoundOriginRadius = 0x0110;
		public const int Mobility = 0x011C;
		public const int UnknownData07 = 0x011D;
		public const int CullDistance = 0x0120;
		public const int bEnableStaticLighting = 0x0128;
		public const int CastShadow = 0x0128;
		public const int bAffectDynamicIndirectLighting = 0x0128;
		public const int bAffectDistanceFieldLighting = 0x0128;
		public const int bCastDynamicShadow = 0x0128;
		public const int bCastStaticShadow = 0x0128;
		public const int bCastShadowAsTwoSided = 0x0128;
		public const int bReceivesDecals = 0x0128;
		public const int bOverrideLightMapRes = 0x0129;
		public const int UnknownData08 = 0x012A;
		public const int OverriddenLightMapRes = 0x012C;
		public const int bUseAsOccluder = 0x0130;
		public const int UnknownData09 = 0x0131;
		public const int BodyInstance = 0x0140;
		public const int CustomNavigableGeometry = 0x0300;
		public const int LightingChannels = 0x0301;
		public const int CollisionRadius = 0x0304;
		public const int ShadeRadius = 0x0308;
		public const int NumSteps = 0x030C;
		public const int InitialSeedDensity = 0x0310;
		public const int AverageSpreadDistance = 0x0314;
		public const int SpreadVariance = 0x0318;
		public const int SeedsPerStep = 0x031C;
		public const int DistributionSeed = 0x0320;
		public const int MaxInitialSeedOffset = 0x0324;
		public const int bCanGrowInShade = 0x0328;
		public const int bSpawnsInShade = 0x0329;
		public const int UnknownData10 = 0x032A;
		public const int MaxInitialAge = 0x032C;
		public const int MaxAge = 0x0330;
		public const int OverlapPriority = 0x0334;
		public const int ProceduralScale = 0x0338;
		public const int ScaleCurve = 0x0340;
		public const int ChangeCount = 0x03C0;
		public const int ReapplyDensity = 0x03C4;
		public const int ReapplyRadius = 0x03C4;
		public const int ReapplyAlignToNormal = 0x03C4;
		public const int ReapplyRandomYaw = 0x03C4;
		public const int ReapplyScaling = 0x03C4;
		public const int ReapplyScaleX = 0x03C4;
		public const int ReapplyScaleY = 0x03C4;
		public const int ReapplyScaleZ = 0x03C4;
		public const int ReapplyRandomPitchAngle = 0x03C5;
		public const int ReapplyGroundSlope = 0x03C5;
		public const int ReapplyHeight = 0x03C5;
		public const int ReapplyLandscapeLayers = 0x03C5;
		public const int ReapplyZOffset = 0x03C5;
		public const int ReapplyCollisionWithWorld = 0x03C5;
		public const int ReapplyVertexColorMask = 0x03C5;
		public const int bEnableDensityScaling = 0x03C5;
		public const int UnknownData11 = 0x03C6;
	}

	public class UFoliageType_InstancedStaticMesh
	{
		public const int OverrideMaterials = 0x03D0;
		public const int ComponentClass = 0x03E0;
		public const int UnknownData00 = 0x03E8;
	}

	public class AInstancedFoliageActor
	{
		public const int UnknownData00 = 0x03A0;
	}

	public class AInteractiveFoliageActor
	{
		public const int CapsuleComponent = 0x03B0;
		public const int TouchingActorEntryPosition = 0x03B8;
		public const int FoliageVelocity = 0x03C4;
		public const int FoliageForce = 0x03D0;
		public const int FoliagePosition = 0x03DC;
		public const int FoliageDamageImpulseScale = 0x03E8;
		public const int FoliageTouchImpulseScale = 0x03EC;
		public const int FoliageStiffness = 0x03F0;
		public const int FoliageStiffnessQuadratic = 0x03F4;
		public const int FoliageDamping = 0x03F8;
		public const int MaxDamageImpulse = 0x03FC;
		public const int MaxTouchImpulse = 0x0400;
		public const int MaxForce = 0x0404;
		public const int Mass = 0x0408;
		public const int UnknownData00 = 0x040C;
	}

	public class AProceduralFoliageBlockingVolume
	{
		public const int ProceduralFoliageVolume = 0x03D8;
	}

	public class UProceduralFoliageComponent
	{
		public const int FoliageSpawner = 0x00F8;
		public const int TileOverlap = 0x0100;
		public const int UnknownData00 = 0x0104;
		public const int SpawningVolume = 0x0108;
		public const int ProceduralGuid = 0x0110;
	}

	public class UProceduralFoliageSpawner
	{
		public const int RandomSeed = 0x0028;
		public const int TileSize = 0x002C;
		public const int NumUniqueTiles = 0x0030;
		public const int MinimumQuadTreeSize = 0x0034;
		public const int UnknownData00 = 0x0038;
		public const int FoliageTypes = 0x0040;
		public const int bNeedsSimulation = 0x0050;
		public const int UnknownData01 = 0x0051;
	}

	public class UProceduralFoliageTile
	{
		public const int FoliageSpawner = 0x0028;
		public const int UnknownData00 = 0x0030;
		public const int InstancesArray = 0x00D0;
		public const int UnknownData01 = 0x00E0;
	}

	public class AProceduralFoliageVolume
	{
		public const int ProceduralComponent = 0x03D8;
	}

}
