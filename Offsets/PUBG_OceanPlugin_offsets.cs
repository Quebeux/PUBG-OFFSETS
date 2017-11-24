/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBuoyancyForceComponent
	{
		public const int OceanManager = 0x0300;
		public const int MeshDensity = 0x0308;
		public const int FluidDensity = 0x030C;
		public const int FluidLinearDamping = 0x0310;
		public const int FluidAngularDamping = 0x0314;
		public const int VelocityDamper = 0x0318;
		public const int ClampMaxVelocity = 0x0324;
		public const int UnknownData00 = 0x0325;
		public const int MaxUnderwaterVelocity = 0x0328;
		public const int TestPointRadius = 0x032C;
		public const int TestPoints = 0x0330;
		public const int ApplyForceToBones = 0x0340;
		public const int SnapToSurfaceIfNoPhysics = 0x0341;
		public const int TwoGerstnerIterations = 0x0342;
		public const int UnknownData01 = 0x0343;
		public const int PointDensityOverride = 0x0348;
		public const int BoneOverride = 0x0358;
		public const int DrawDebugPoints = 0x0368;
		public const int EnableStayUprightConstraint = 0x0369;
		public const int UnknownData02 = 0x036A;
		public const int StayUprightStiffness = 0x036C;
		public const int StayUprightDamping = 0x0370;
		public const int StayUprightDesiredRotation = 0x0374;
		public const int EnableWaveForces = 0x0380;
		public const int UnknownData03 = 0x0381;
		public const int WaveForceMultiplier = 0x0384;
		public const int TickGroup = 0x0388;
		public const int UnknownData04 = 0x0389;
	}

	public class AOceanManager
	{
		public const int EnableGerstnerWaves = 0x03A0;
		public const int UnknownData00 = 0x03A1;
		public const int GlobalWaveDirection = 0x03A4;
		public const int GlobalWaveSpeed = 0x03AC;
		public const int GlobalWaveAmplitude = 0x03B0;
		public const int DistanceCheck = 0x03B4;
		public const int WaveClusters = 0x03B8;
		public const int WaveSetOffsetsOverride = 0x03C8;
		public const int NetWorkTimeOffset = 0x03D8;
		public const int bEnableLandscapeModulation = 0x03DC;
		public const int UnknownData01 = 0x03DD;
		public const int ModulationStartHeight = 0x03E0;
		public const int ModulationMaxHeight = 0x03E4;
		public const int ModulationPower = 0x03E8;
		public const int UnknownData02 = 0x03EC;
		public const int Landscape = 0x03F0;
		public const int HeightmapTexture = 0x03F8;
		public const int UnknownData03 = 0x0400;
	}

	public class UBuoyancyComponent
	{
		public const int OceanManager = 0x0140;
		public const int MeshDensity = 0x0148;
		public const int FluidDensity = 0x014C;
		public const int FluidLinearDamping = 0x0150;
		public const int FluidAngularDamping = 0x0154;
		public const int VelocityDamper = 0x0158;
		public const int ClampMaxVelocity = 0x0164;
		public const int UnknownData00 = 0x0165;
		public const int MaxUnderwaterVelocity = 0x0168;
		public const int TestPointRadius = 0x016C;
		public const int TestPoints = 0x0170;
		public const int PointDensityOverride = 0x0180;
		public const int DrawDebugPoints = 0x0190;
		public const int EnableStayUprightConstraint = 0x0191;
		public const int UnknownData01 = 0x0192;
		public const int StayUprightStiffness = 0x0194;
		public const int StayUprightDamping = 0x0198;
		public const int StayUprightDesiredRotation = 0x019C;
		public const int EnableWaveForces = 0x01A8;
		public const int UnknownData02 = 0x01A9;
		public const int WaveForceMultiplier = 0x01AC;
		public const int UnknownData03 = 0x01B0;
	}

	public class UBuoyantDestructibleComponent
	{
		public const int UnknownData00 = 0x09C0;
		public const int OceanManager = 0x09C8;
		public const int ChunkDensity = 0x09D0;
		public const int FluidDensity = 0x09D4;
		public const int FluidLinearDamping = 0x09D8;
		public const int FluidAngularDamping = 0x09DC;
		public const int VelocityDamper = 0x09E0;
		public const int ClampMaxVelocity = 0x09EC;
		public const int UnknownData01 = 0x09ED;
		public const int MaxUnderwaterVelocity = 0x09F0;
		public const int TestPointRadius = 0x09F4;
		public const int DrawDebugPoints = 0x09F8;
		public const int EnableWaveForces = 0x09F9;
		public const int UnknownData02 = 0x09FA;
		public const int WaveForceMultiplier = 0x09FC;
		public const int ChunkSleepThreshold = 0x0A00;
		public const int ChunkStabilizationThreshold = 0x0A04;
		public const int UnknownData03 = 0x0A08;
	}

	public class ABuoyantDestructible
	{
		public const int BuoyantDestructibleComponent = 0x03A0;
	}

	public class UBuoyantMeshComponent
	{
		public const int bVerticalForcesOnly = 0x0810;
		public const int bUseWaterPatch = 0x0811;
		public const int bUseStaticForces = 0x0812;
		public const int bUseDynamicForces = 0x0813;
		public const int UnknownData00 = 0x0814;
		public const int OceanManager = 0x0818;
		public const int bDrawForceArrows = 0x0820;
		public const int bDrawWaterline = 0x0821;
		public const int bDrawVertices = 0x0822;
		public const int bDrawTriangles = 0x0823;
		public const int bDrawSubtriangles = 0x0824;
		public const int UnknownData01 = 0x0825;
		public const int ForceArrowSize = 0x0828;
		public const int bOverrideMeshDensity = 0x082C;
		public const int UnknownData02 = 0x082D;
		public const int MeshDensity = 0x0830;
		public const int bOverrideMass = 0x0834;
		public const int UnknownData03 = 0x0835;
		public const int Mass = 0x0838;
		public const int WaterDensity = 0x083C;
		public const int UnknownData04 = 0x0840;
		public const int WaterHeightmap = 0x0868;
	}

	public class ACustomVehicleController
	{
		public const int PlayerPawn = 0x06D0;
	}

	public class AFishManager
	{
		public const int flockTypes = 0x03A0;
		public const int numInFlock = 0x03B0;
		public const int minZ = 0x03C0;
		public const int maxZ = 0x03C4;
		public const int underwaterBoxLength = 0x03C8;
		public const int attachToPlayer = 0x03CC;
		public const int DebugMode = 0x03CD;
		public const int UnknownData00 = 0x03CE;
		public const int playerType = 0x03D0;
		public const int UnknownData01 = 0x03D8;
	}

	public class AFlockFish
	{
		public const int UnknownData00 = 0x0400;
		public const int FishInteractionSphere = 0x0410;
		public const int isLeader = 0x0418;
		public const int UnknownData01 = 0x0419;
		public const int enemyTypes = 0x0420;
		public const int preyTypes = 0x0430;
		public const int neighborType = 0x0440;
		public const int followDist = 0x0448;
		public const int Speed = 0x044C;
		public const int MaxSpeed = 0x0450;
		public const int turnSpeed = 0x0454;
		public const int turnFrequency = 0x0458;
		public const int hungerResetTime = 0x045C;
		public const int distBehindSpeedUpRange = 0x0460;
		public const int SeperationDistanceMultiplier = 0x0464;
		public const int FleeDistanceMultiplier = 0x0468;
		public const int FleeAccelerationMultiplier = 0x046C;
		public const int ChaseAccelerationMultiplier = 0x0470;
		public const int SeekDecelerationMultiplier = 0x0474;
		public const int AvoidForceMultiplier = 0x0478;
		public const int AvoidanceForce = 0x047C;
		public const int playerType = 0x0480;
		public const int underwaterMin = 0x0488;
		public const int underwaterMax = 0x0494;
		public const int CustomZSeekMin = 0x04A0;
		public const int CustomZSeekMax = 0x04A4;
		public const int NumNeighborsToEvaluate = 0x04A8;
		public const int UpdateEveryTick = 0x04AC;
		public const int UnknownData02 = 0x04B0;
		public const int DebugMode = 0x04C0;
		public const int UnknownData03 = 0x04C1;
	}

	public class UInfiniteSystemComponent
	{
		public const int UpdateInEditor = 0x0300;
		public const int FollowMethod = 0x0301;
		public const int UnknownData00 = 0x0302;
		public const int GridSnapSize = 0x0304;
		public const int MaxLookAtDistance = 0x0308;
		public const int ScaleByDistance = 0x030C;
		public const int UnknownData01 = 0x030D;
		public const int ScaleDistanceFactor = 0x0310;
		public const int ScaleStartDistance = 0x0314;
		public const int ScaleMin = 0x0318;
		public const int ScaleMax = 0x031C;
		public const int UnknownData02 = 0x0320;
	}

	public class ATimeManager
	{
		public const int CurrentLocalTime = 0x03A0;
		public const int Latitude = 0x03BC;
		public const int Longitude = 0x03C0;
		public const int OffsetUTC = 0x03C4;
		public const int OffsetDST = 0x03C8;
		public const int bAllowDaylightSavings = 0x03CC;
		public const int bDaylightSavingsActive = 0x03CD;
		public const int UnknownData00 = 0x03CE;
		public const int TimeScaleMultiplier = 0x03D0;
		public const int SolarTime = 0x03D4;
		public const int LocalClockTime = 0x03D8;
		public const int TimeCorrection = 0x03DC;
		public const int LSTM = 0x03E0;
		public const int DayOfYear = 0x03E4;
		public const int EoT = 0x03E8;
		public const int SolarAltAngle = 0x03EC;
		public const int SolarDeclination = 0x03F0;
		public const int SolarAzimuth = 0x03F4;
		public const int SolarHRA = 0x03F8;
		public const int SiderealTime = 0x03FC;
		public const int LunarAltAngle = 0x0400;
		public const int LunarHRA = 0x0404;
		public const int LunarDeclination = 0x0408;
		public const int LunarAzimuth = 0x040C;
		public const int LunarRightAsc = 0x0410;
		public const int LunarElapsedDays = 0x0414;
		public const int EcLongitude = 0x0418;
		public const int EcLatitude = 0x041C;
		public const int EcDistance = 0x0420;
		public const int PartL = 0x0424;
		public const int PartM = 0x0428;
		public const int PartF = 0x042C;
		public const int UnknownData01 = 0x0430;
	}

	public class UWaterHeightmapComponent
	{
		public const int DesiredCellSize = 0x00F8;
		public const int bOnlyCollidingComponents = 0x00FC;
		public const int UnknownData00 = 0x00FD;
		public const int GridSizeMultiplier = 0x0100;
		public const int bDrawUsedTriangles = 0x0104;
		public const int bDrawHeightmap = 0x0105;
		public const int UnknownData01 = 0x0106;
		public const int OceanManager = 0x0168;
	}

}
