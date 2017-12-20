/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBuoyancyForceComponent
	{
		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0300;

		///<summary>float</summary>
		public const int MeshDensity = 0x0308;

		///<summary>float</summary>
		public const int FluidDensity = 0x030C;

		///<summary>float</summary>
		public const int FluidLinearDamping = 0x0310;

		///<summary>float</summary>
		public const int FluidAngularDamping = 0x0314;

		///<summary>FVector</summary>
		public const int VelocityDamper = 0x0318;

		///<summary>bool</summary>
		public const int ClampMaxVelocity = 0x0324;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0325;

		///<summary>float</summary>
		public const int MaxUnderwaterVelocity = 0x0328;

		///<summary>float</summary>
		public const int TestPointRadius = 0x032C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int TestPoints = 0x0330;

		///<summary>bool</summary>
		public const int ApplyForceToBones = 0x0340;

		///<summary>bool</summary>
		public const int SnapToSurfaceIfNoPhysics = 0x0341;

		///<summary>bool</summary>
		public const int TwoGerstnerIterations = 0x0342;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData01 = 0x0343;

		///<summary>TArray&lt;float&gt;</summary>
		public const int PointDensityOverride = 0x0348;

		///<summary>TArray&lt;FStructBoneOverride&gt;</summary>
		public const int BoneOverride = 0x0358;

		///<summary>bool</summary>
		public const int DrawDebugPoints = 0x0368;

		///<summary>bool</summary>
		public const int EnableStayUprightConstraint = 0x0369;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x036A;

		///<summary>float</summary>
		public const int StayUprightStiffness = 0x036C;

		///<summary>float</summary>
		public const int StayUprightDamping = 0x0370;

		///<summary>FRotator</summary>
		public const int StayUprightDesiredRotation = 0x0374;

		///<summary>bool</summary>
		public const int EnableWaveForces = 0x0380;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0381;

		///<summary>float</summary>
		public const int WaveForceMultiplier = 0x0384;

		///<summary>TEnumAsByte&lt;ETickingGroup&gt;</summary>
		public const int TickGroup = 0x0388;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData04 = 0x0389;

	}

	public class AOceanManager
	{
		///<summary>bool</summary>
		public const int EnableGerstnerWaves = 0x03A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03A1;

		///<summary>FVector2D</summary>
		public const int GlobalWaveDirection = 0x03A4;

		///<summary>float</summary>
		public const int GlobalWaveSpeed = 0x03AC;

		///<summary>float</summary>
		public const int GlobalWaveAmplitude = 0x03B0;

		///<summary>float</summary>
		public const int DistanceCheck = 0x03B4;

		///<summary>TArray&lt;FWaveParameter&gt;</summary>
		public const int WaveClusters = 0x03B8;

		///<summary>TArray&lt;FWaveSetParameters&gt;</summary>
		public const int WaveSetOffsetsOverride = 0x03C8;

		///<summary>float</summary>
		public const int NetWorkTimeOffset = 0x03D8;

		///<summary>bool</summary>
		public const int bEnableLandscapeModulation = 0x03DC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03DD;

		///<summary>float</summary>
		public const int ModulationStartHeight = 0x03E0;

		///<summary>float</summary>
		public const int ModulationMaxHeight = 0x03E4;

		///<summary>float</summary>
		public const int ModulationPower = 0x03E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x03EC;

		///<summary>ALandscape *</summary>
		public const int Landscape = 0x03F0;

		///<summary>UTexture2D *</summary>
		public const int HeightmapTexture = 0x03F8;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData03 = 0x0400;

	}

	public class UBuoyancyComponent
	{
		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0140;

		///<summary>float</summary>
		public const int MeshDensity = 0x0148;

		///<summary>float</summary>
		public const int FluidDensity = 0x014C;

		///<summary>float</summary>
		public const int FluidLinearDamping = 0x0150;

		///<summary>float</summary>
		public const int FluidAngularDamping = 0x0154;

		///<summary>FVector</summary>
		public const int VelocityDamper = 0x0158;

		///<summary>bool</summary>
		public const int ClampMaxVelocity = 0x0164;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0165;

		///<summary>float</summary>
		public const int MaxUnderwaterVelocity = 0x0168;

		///<summary>float</summary>
		public const int TestPointRadius = 0x016C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int TestPoints = 0x0170;

		///<summary>TArray&lt;float&gt;</summary>
		public const int PointDensityOverride = 0x0180;

		///<summary>bool</summary>
		public const int DrawDebugPoints = 0x0190;

		///<summary>bool</summary>
		public const int EnableStayUprightConstraint = 0x0191;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0192;

		///<summary>float</summary>
		public const int StayUprightStiffness = 0x0194;

		///<summary>float</summary>
		public const int StayUprightDamping = 0x0198;

		///<summary>FRotator</summary>
		public const int StayUprightDesiredRotation = 0x019C;

		///<summary>bool</summary>
		public const int EnableWaveForces = 0x01A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x01A9;

		///<summary>float</summary>
		public const int WaveForceMultiplier = 0x01AC;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x01B0;

	}

	public class UBuoyantDestructibleComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x09C0;

		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x09C8;

		///<summary>float</summary>
		public const int ChunkDensity = 0x09D0;

		///<summary>float</summary>
		public const int FluidDensity = 0x09D4;

		///<summary>float</summary>
		public const int FluidLinearDamping = 0x09D8;

		///<summary>float</summary>
		public const int FluidAngularDamping = 0x09DC;

		///<summary>FVector</summary>
		public const int VelocityDamper = 0x09E0;

		///<summary>bool</summary>
		public const int ClampMaxVelocity = 0x09EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x09ED;

		///<summary>float</summary>
		public const int MaxUnderwaterVelocity = 0x09F0;

		///<summary>float</summary>
		public const int TestPointRadius = 0x09F4;

		///<summary>bool</summary>
		public const int DrawDebugPoints = 0x09F8;

		///<summary>bool</summary>
		public const int EnableWaveForces = 0x09F9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x09FA;

		///<summary>float</summary>
		public const int WaveForceMultiplier = 0x09FC;

		///<summary>float</summary>
		public const int ChunkSleepThreshold = 0x0A00;

		///<summary>float</summary>
		public const int ChunkStabilizationThreshold = 0x0A04;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0A08;

	}

	public class ABuoyantDestructible
	{
		///<summary>UBuoyantDestructibleComponent *</summary>
		public const int BuoyantDestructibleComponent = 0x03A0;

	}

	public class UBuoyantMeshComponent
	{
		///<summary>bool</summary>
		public const int bVerticalForcesOnly = 0x0810;

		///<summary>bool</summary>
		public const int bUseWaterPatch = 0x0811;

		///<summary>bool</summary>
		public const int bUseStaticForces = 0x0812;

		///<summary>bool</summary>
		public const int bUseDynamicForces = 0x0813;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0814;

		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0818;

		///<summary>bool</summary>
		public const int bDrawForceArrows = 0x0820;

		///<summary>bool</summary>
		public const int bDrawWaterline = 0x0821;

		///<summary>bool</summary>
		public const int bDrawVertices = 0x0822;

		///<summary>bool</summary>
		public const int bDrawTriangles = 0x0823;

		///<summary>bool</summary>
		public const int bDrawSubtriangles = 0x0824;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0825;

		///<summary>float</summary>
		public const int ForceArrowSize = 0x0828;

		///<summary>bool</summary>
		public const int bOverrideMeshDensity = 0x082C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x082D;

		///<summary>float</summary>
		public const int MeshDensity = 0x0830;

		///<summary>bool</summary>
		public const int bOverrideMass = 0x0834;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0835;

		///<summary>float</summary>
		public const int Mass = 0x0838;

		///<summary>float</summary>
		public const int WaterDensity = 0x083C;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData04 = 0x0840;

		///<summary>UWaterHeightmapComponent *</summary>
		public const int WaterHeightmap = 0x0868;

	}

	public class ACustomVehicleController
	{
		///<summary>APawn *</summary>
		public const int PlayerPawn = 0x06D0;

	}

	public class AFishManager
	{
		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int flockTypes = 0x03A0;

		///<summary>TArray&lt;float&gt;</summary>
		public const int numInFlock = 0x03B0;

		///<summary>float</summary>
		public const int minZ = 0x03C0;

		///<summary>float</summary>
		public const int maxZ = 0x03C4;

		///<summary>float</summary>
		public const int underwaterBoxLength = 0x03C8;

		///<summary>bool</summary>
		public const int attachToPlayer = 0x03CC;

		///<summary>bool</summary>
		public const int DebugMode = 0x03CD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03CE;

		///<summary>UClass *</summary>
		public const int playerType = 0x03D0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x03D8;

	}

	public class AFlockFish
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0400;

		///<summary>USphereComponent *</summary>
		public const int FishInteractionSphere = 0x0410;

		///<summary>bool</summary>
		public const int isLeader = 0x0418;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0419;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int enemyTypes = 0x0420;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int preyTypes = 0x0430;

		///<summary>UClass *</summary>
		public const int neighborType = 0x0440;

		///<summary>float</summary>
		public const int followDist = 0x0448;

		///<summary>float</summary>
		public const int Speed = 0x044C;

		///<summary>float</summary>
		public const int MaxSpeed = 0x0450;

		///<summary>float</summary>
		public const int turnSpeed = 0x0454;

		///<summary>float</summary>
		public const int turnFrequency = 0x0458;

		///<summary>float</summary>
		public const int hungerResetTime = 0x045C;

		///<summary>float</summary>
		public const int distBehindSpeedUpRange = 0x0460;

		///<summary>float</summary>
		public const int SeperationDistanceMultiplier = 0x0464;

		///<summary>float</summary>
		public const int FleeDistanceMultiplier = 0x0468;

		///<summary>float</summary>
		public const int FleeAccelerationMultiplier = 0x046C;

		///<summary>float</summary>
		public const int ChaseAccelerationMultiplier = 0x0470;

		///<summary>float</summary>
		public const int SeekDecelerationMultiplier = 0x0474;

		///<summary>float</summary>
		public const int AvoidForceMultiplier = 0x0478;

		///<summary>float</summary>
		public const int AvoidanceForce = 0x047C;

		///<summary>UClass *</summary>
		public const int playerType = 0x0480;

		///<summary>FVector</summary>
		public const int underwaterMin = 0x0488;

		///<summary>FVector</summary>
		public const int underwaterMax = 0x0494;

		///<summary>float</summary>
		public const int CustomZSeekMin = 0x04A0;

		///<summary>float</summary>
		public const int CustomZSeekMax = 0x04A4;

		///<summary>float</summary>
		public const int NumNeighborsToEvaluate = 0x04A8;

		///<summary>float</summary>
		public const int UpdateEveryTick = 0x04AC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x04B0;

		///<summary>bool</summary>
		public const int DebugMode = 0x04C0;

		///<summary>unsigned char[0xBF]</summary>
		public const int UnknownData03 = 0x04C1;

	}

	public class UInfiniteSystemComponent
	{
		///<summary>bool</summary>
		public const int UpdateInEditor = 0x0300;

		///<summary>TEnumAsByte&lt;EFollowMethod&gt;</summary>
		public const int FollowMethod = 0x0301;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0302;

		///<summary>float</summary>
		public const int GridSnapSize = 0x0304;

		///<summary>float</summary>
		public const int MaxLookAtDistance = 0x0308;

		///<summary>bool</summary>
		public const int ScaleByDistance = 0x030C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x030D;

		///<summary>float</summary>
		public const int ScaleDistanceFactor = 0x0310;

		///<summary>float</summary>
		public const int ScaleStartDistance = 0x0314;

		///<summary>float</summary>
		public const int ScaleMin = 0x0318;

		///<summary>float</summary>
		public const int ScaleMax = 0x031C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0320;

	}

	public class ATimeManager
	{
		///<summary>FTimeDate</summary>
		public const int CurrentLocalTime = 0x03A0;

		///<summary>float</summary>
		public const int Latitude = 0x03BC;

		///<summary>float</summary>
		public const int Longitude = 0x03C0;

		///<summary>int</summary>
		public const int OffsetUTC = 0x03C4;

		///<summary>int</summary>
		public const int OffsetDST = 0x03C8;

		///<summary>bool</summary>
		public const int bAllowDaylightSavings = 0x03CC;

		///<summary>bool</summary>
		public const int bDaylightSavingsActive = 0x03CD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03CE;

		///<summary>float</summary>
		public const int TimeScaleMultiplier = 0x03D0;

		///<summary>float</summary>
		public const int SolarTime = 0x03D4;

		///<summary>float</summary>
		public const int LocalClockTime = 0x03D8;

		///<summary>float</summary>
		public const int TimeCorrection = 0x03DC;

		///<summary>int</summary>
		public const int LSTM = 0x03E0;

		///<summary>int</summary>
		public const int DayOfYear = 0x03E4;

		///<summary>float</summary>
		public const int EoT = 0x03E8;

		///<summary>float</summary>
		public const int SolarAltAngle = 0x03EC;

		///<summary>float</summary>
		public const int SolarDeclination = 0x03F0;

		///<summary>float</summary>
		public const int SolarAzimuth = 0x03F4;

		///<summary>float</summary>
		public const int SolarHRA = 0x03F8;

		///<summary>float</summary>
		public const int SiderealTime = 0x03FC;

		///<summary>float</summary>
		public const int LunarAltAngle = 0x0400;

		///<summary>float</summary>
		public const int LunarHRA = 0x0404;

		///<summary>float</summary>
		public const int LunarDeclination = 0x0408;

		///<summary>float</summary>
		public const int LunarAzimuth = 0x040C;

		///<summary>float</summary>
		public const int LunarRightAsc = 0x0410;

		///<summary>float</summary>
		public const int LunarElapsedDays = 0x0414;

		///<summary>float</summary>
		public const int EcLongitude = 0x0418;

		///<summary>float</summary>
		public const int EcLatitude = 0x041C;

		///<summary>float</summary>
		public const int EcDistance = 0x0420;

		///<summary>float</summary>
		public const int PartL = 0x0424;

		///<summary>float</summary>
		public const int PartM = 0x0428;

		///<summary>float</summary>
		public const int PartF = 0x042C;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData01 = 0x0430;

	}

	public class UWaterHeightmapComponent
	{
		///<summary>float</summary>
		public const int DesiredCellSize = 0x00F8;

		///<summary>bool</summary>
		public const int bOnlyCollidingComponents = 0x00FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00FD;

		///<summary>float</summary>
		public const int GridSizeMultiplier = 0x0100;

		///<summary>bool</summary>
		public const int bDrawUsedTriangles = 0x0104;

		///<summary>bool</summary>
		public const int bDrawHeightmap = 0x0105;

		///<summary>unsigned char[0x62]</summary>
		public const int UnknownData01 = 0x0106;

		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0168;

	}

}
