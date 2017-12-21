/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UFoliageInstancedStaticMeshComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInstanceTakePointDamage = 0x0BD0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInstanceTakeRadialDamage = 0x0BE0;

	}

	public class UFoliageType
	{
		///<summary>FGuid</summary>
		public const int UpdateGuid = 0x0028;

		///<summary>float</summary>
		public const int Density = 0x0038;

		///<summary>float</summary>
		public const int DensityAdjustmentFactor = 0x003C;

		///<summary>float</summary>
		public const int Radius = 0x0040;

		///<summary>EFoliageScaling</summary>
		public const int Scaling = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0045;

		///<summary>FFloatInterval</summary>
		public const int ScaleX = 0x0048;

		///<summary>FFloatInterval</summary>
		public const int ScaleY = 0x0050;

		///<summary>FFloatInterval</summary>
		public const int ScaleZ = 0x0058;

		///<summary>FFoliageVertexColorChannelMask[0x4]</summary>
		public const int VertexColorMaskByChannel = 0x0060;

		///<summary>TEnumAsByte&lt;EFoliageVertexColorMask&gt;</summary>
		public const int VertexColorMask = 0x0090;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0091;

		///<summary>float</summary>
		public const int VertexColorMaskThreshold = 0x0094;

		///<summary>unsigned char:1</summary>
		public const int VertexColorMaskInvert = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0099;

		///<summary>FFloatInterval</summary>
		public const int ZOffset = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int AlignToNormal = 0x00A4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x00A5;

		///<summary>float</summary>
		public const int AlignMaxAngle = 0x00A8;

		///<summary>unsigned char:1</summary>
		public const int RandomYaw = 0x00AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x00AD;

		///<summary>float</summary>
		public const int RandomPitchAngle = 0x00B0;

		///<summary>FFloatInterval</summary>
		public const int GroundSlopeAngle = 0x00B4;

		///<summary>FFloatInterval</summary>
		public const int Height = 0x00BC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x00C4;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int LandscapeLayers = 0x00C8;

		///<summary>FName</summary>
		public const int LandscapeLayer = 0x00D8;

		///<summary>unsigned char:1</summary>
		public const int CollisionWithWorld = 0x00E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x00E1;

		///<summary>FVector</summary>
		public const int CollisionScale = 0x00E4;

		///<summary>float</summary>
		public const int MinimumLayerWeight = 0x00F0;

		///<summary>FBoxSphereBounds</summary>
		public const int MeshBounds = 0x00F4;

		///<summary>FVector</summary>
		public const int LowBoundOriginRadius = 0x0110;

		///<summary>TEnumAsByte&lt;EComponentMobility&gt;</summary>
		public const int Mobility = 0x011C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x011D;

		///<summary>FInt32Interval</summary>
		public const int CullDistance = 0x0120;

		///<summary>unsigned char:1</summary>
		public const int bEnableStaticLighting = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int CastShadow = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bAffectDynamicIndirectLighting = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bAffectDistanceFieldLighting = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bCastDynamicShadow = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bCastStaticShadow = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bCastShadowAsTwoSided = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bReceivesDecals = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bOverrideLightMapRes = 0x0129;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData08 = 0x012A;

		///<summary>int</summary>
		public const int OverriddenLightMapRes = 0x012C;

		///<summary>unsigned char:1</summary>
		public const int bUseAsOccluder = 0x0130;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData09 = 0x0131;

		///<summary>FBodyInstance</summary>
		public const int BodyInstance = 0x0140;

		///<summary>TEnumAsByte&lt;EHasCustomNavigableGeometry&gt;</summary>
		public const int CustomNavigableGeometry = 0x0380;

		///<summary>FLightingChannels</summary>
		public const int LightingChannels = 0x0381;

		///<summary>unsigned char:1</summary>
		public const int bRenderCustomDepth = 0x0384;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x0385;

		///<summary>int</summary>
		public const int CustomDepthStencilValue = 0x0388;

		///<summary>float</summary>
		public const int CollisionRadius = 0x038C;

		///<summary>float</summary>
		public const int ShadeRadius = 0x0390;

		///<summary>int</summary>
		public const int NumSteps = 0x0394;

		///<summary>float</summary>
		public const int InitialSeedDensity = 0x0398;

		///<summary>float</summary>
		public const int AverageSpreadDistance = 0x039C;

		///<summary>float</summary>
		public const int SpreadVariance = 0x03A0;

		///<summary>int</summary>
		public const int SeedsPerStep = 0x03A4;

		///<summary>int</summary>
		public const int DistributionSeed = 0x03A8;

		///<summary>float</summary>
		public const int MaxInitialSeedOffset = 0x03AC;

		///<summary>bool</summary>
		public const int bCanGrowInShade = 0x03B0;

		///<summary>bool</summary>
		public const int bSpawnsInShade = 0x03B1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData11 = 0x03B2;

		///<summary>float</summary>
		public const int MaxInitialAge = 0x03B4;

		///<summary>float</summary>
		public const int MaxAge = 0x03B8;

		///<summary>float</summary>
		public const int OverlapPriority = 0x03BC;

		///<summary>FFloatInterval</summary>
		public const int ProceduralScale = 0x03C0;

		///<summary>FRuntimeFloatCurve</summary>
		public const int ScaleCurve = 0x03C8;

		///<summary>int</summary>
		public const int ChangeCount = 0x0440;

		///<summary>unsigned char:1</summary>
		public const int ReapplyDensity = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyRadius = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyAlignToNormal = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyRandomYaw = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyScaling = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyScaleX = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyScaleY = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyScaleZ = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int ReapplyRandomPitchAngle = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int ReapplyGroundSlope = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int ReapplyHeight = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int ReapplyLandscapeLayers = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int ReapplyZOffset = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int ReapplyCollisionWithWorld = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int ReapplyVertexColorMask = 0x0445;

		///<summary>unsigned char:1</summary>
		public const int bEnableDensityScaling = 0x0445;

		///<summary>unsigned char[0xA]</summary>
		public const int UnknownData12 = 0x0446;

	}

	public class UFoliageType_InstancedStaticMesh
	{
		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int OverrideMaterials = 0x0450;

		///<summary>UClass *</summary>
		public const int ComponentClass = 0x0460;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0468;

	}

	public class AInstancedFoliageActor
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class AInteractiveFoliageActor
	{
		///<summary>UCapsuleComponent *</summary>
		public const int CapsuleComponent = 0x03C0;

		///<summary>FVector</summary>
		public const int TouchingActorEntryPosition = 0x03C8;

		///<summary>FVector</summary>
		public const int FoliageVelocity = 0x03D4;

		///<summary>FVector</summary>
		public const int FoliageForce = 0x03E0;

		///<summary>FVector</summary>
		public const int FoliagePosition = 0x03EC;

		///<summary>float</summary>
		public const int FoliageDamageImpulseScale = 0x03F8;

		///<summary>float</summary>
		public const int FoliageTouchImpulseScale = 0x03FC;

		///<summary>float</summary>
		public const int FoliageStiffness = 0x0400;

		///<summary>float</summary>
		public const int FoliageStiffnessQuadratic = 0x0404;

		///<summary>float</summary>
		public const int FoliageDamping = 0x0408;

		///<summary>float</summary>
		public const int MaxDamageImpulse = 0x040C;

		///<summary>float</summary>
		public const int MaxTouchImpulse = 0x0410;

		///<summary>float</summary>
		public const int MaxForce = 0x0414;

		///<summary>float</summary>
		public const int Mass = 0x0418;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x041C;

	}

	public class UInteractiveFoliageComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x09E0;

	}

	public class AProceduralFoliageBlockingVolume
	{
		///<summary>AProceduralFoliageVolume *</summary>
		public const int ProceduralFoliageVolume = 0x03E8;

	}

	public class UProceduralFoliageComponent
	{
		///<summary>float</summary>
		public const int TileOverlap = 0x01E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x01E4;

		///<summary>AVolume *</summary>
		public const int SpawningVolume = 0x01E8;

		///<summary>FGuid</summary>
		public const int ProceduralGuid = 0x01F0;

	}

	public class UProceduralFoliageSpawner
	{
		///<summary>int</summary>
		public const int RandomSeed = 0x0028;

		///<summary>float</summary>
		public const int TileSize = 0x002C;

		///<summary>int</summary>
		public const int NumUniqueTiles = 0x0030;

		///<summary>float</summary>
		public const int MinimumQuadTreeSize = 0x0034;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>TArray&lt;FFoliageTypeObject&gt;</summary>
		public const int FoliageTypes = 0x0040;

		///<summary>bool</summary>
		public const int bNeedsSimulation = 0x0050;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData01 = 0x0051;

	}

	public class UProceduralFoliageTile
	{
		///<summary>UProceduralFoliageSpawner *</summary>
		public const int FoliageSpawner = 0x0028;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData00 = 0x0030;

		///<summary>TArray&lt;FProceduralFoliageInstance&gt;</summary>
		public const int InstancesArray = 0x00D0;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData01 = 0x00E0;

	}

	public class AProceduralFoliageVolume
	{
		///<summary>UProceduralFoliageComponent *</summary>
		public const int ProceduralComponent = 0x03E8;

	}

}
