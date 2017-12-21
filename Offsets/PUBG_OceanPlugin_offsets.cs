/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBuoyancyForceComponent
	{
		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x03F0;

		///<summary>float</summary>
		public const int MeshDensity = 0x03F8;

		///<summary>float</summary>
		public const int FluidDensity = 0x03FC;

		///<summary>float</summary>
		public const int FluidLinearDamping = 0x0400;

		///<summary>float</summary>
		public const int FluidAngularDamping = 0x0404;

		///<summary>FVector</summary>
		public const int VelocityDamper = 0x0408;

		///<summary>bool</summary>
		public const int ClampMaxVelocity = 0x0414;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0415;

		///<summary>float</summary>
		public const int MaxUnderwaterVelocity = 0x0418;

		///<summary>float</summary>
		public const int TestPointRadius = 0x041C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int TestPoints = 0x0420;

		///<summary>bool</summary>
		public const int ApplyForceToBones = 0x0430;

		///<summary>bool</summary>
		public const int SnapToSurfaceIfNoPhysics = 0x0431;

		///<summary>bool</summary>
		public const int TwoGerstnerIterations = 0x0432;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData01 = 0x0433;

		///<summary>TArray&lt;float&gt;</summary>
		public const int PointDensityOverride = 0x0438;

		///<summary>TArray&lt;FStructBoneOverride&gt;</summary>
		public const int BoneOverride = 0x0448;

		///<summary>bool</summary>
		public const int DrawDebugPoints = 0x0458;

		///<summary>bool</summary>
		public const int EnableStayUprightConstraint = 0x0459;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x045A;

		///<summary>float</summary>
		public const int StayUprightStiffness = 0x045C;

		///<summary>float</summary>
		public const int StayUprightDamping = 0x0460;

		///<summary>FRotator</summary>
		public const int StayUprightDesiredRotation = 0x0464;

		///<summary>bool</summary>
		public const int EnableWaveForces = 0x0470;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0471;

		///<summary>float</summary>
		public const int WaveForceMultiplier = 0x0474;

		///<summary>TEnumAsByte&lt;ETickingGroup&gt;</summary>
		public const int TickGroup = 0x0478;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData04 = 0x0479;

	}

	public class AOceanManager
	{
		///<summary>bool</summary>
		public const int EnableGerstnerWaves = 0x03B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03B1;

		///<summary>FVector2D</summary>
		public const int GlobalWaveDirection = 0x03B4;

		///<summary>float</summary>
		public const int GlobalWaveSpeed = 0x03BC;

		///<summary>float</summary>
		public const int GlobalWaveAmplitude = 0x03C0;

		///<summary>float</summary>
		public const int DistanceCheck = 0x03C4;

		///<summary>TArray&lt;FWaveParameter&gt;</summary>
		public const int WaveClusters = 0x03C8;

		///<summary>TArray&lt;FWaveSetParameters&gt;</summary>
		public const int WaveSetOffsetsOverride = 0x03D8;

		///<summary>float</summary>
		public const int NetWorkTimeOffset = 0x03E8;

		///<summary>bool</summary>
		public const int bEnableLandscapeModulation = 0x03EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03ED;

		///<summary>float</summary>
		public const int ModulationStartHeight = 0x03F0;

		///<summary>float</summary>
		public const int ModulationMaxHeight = 0x03F4;

		///<summary>float</summary>
		public const int ModulationPower = 0x03F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x03FC;

		///<summary>ALandscape *</summary>
		public const int Landscape = 0x0400;

		///<summary>UTexture2D *</summary>
		public const int HeightmapTexture = 0x0408;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData03 = 0x0410;

	}

	public class UAdvancedBuoyancyComponent
	{
		///<summary>bool</summary>
		public const int bUseDrag = 0x03F0;

		///<summary>bool</summary>
		public const int bDebugOn = 0x03F1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03F2;

		///<summary>AOceanManager *</summary>
		public const int TheOcean = 0x03F8;

		///<summary>float</summary>
		public const int WaterDensity = 0x0400;

		///<summary>float</summary>
		public const int Gravity = 0x0404;

		///<summary>float</summary>
		public const int MeshDensity = 0x0408;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData01 = 0x040C;

		///<summary>UStaticMeshComponent *</summary>
		public const int BuoyantMesh = 0x0420;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0428;

		///<summary>FTransform</summary>
		public const int MeshTransform = 0x0430;

		///<summary>float</summary>
		public const int FalseVolume = 0x0460;

		///<summary>float</summary>
		public const int BuoyancyReductionCoefficient = 0x0464;

		///<summary>float</summary>
		public const int BuoyancyPitchReductionCoefficient = 0x0468;

		///<summary>float</summary>
		public const int DensityCorrection = 0x046C;

		///<summary>float</summary>
		public const int DensityCorrectionModifier = 0x0470;

		///<summary>float</summary>
		public const int SubmergedVolume = 0x0474;

		///<summary>float</summary>
		public const int ImpactCoefficient = 0x0478;

		///<summary>FVector</summary>
		public const int DragCoefficient = 0x047C;

		///<summary>FVector</summary>
		public const int SuctionCoefficient = 0x0488;

		///<summary>float</summary>
		public const int ViscousDragCoefficient = 0x0494;

		///<summary>float</summary>
		public const int MaxSlamAcceleration = 0x0498;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x049C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int AdvancedGridHeight = 0x04A0;

		///<summary>TArray&lt;FForceTriangle&gt;</summary>
		public const int SubmergedTris = 0x04B0;

		///<summary>TArray&lt;float&gt;</summary>
		public const int TriSizes = 0x04C0;

		///<summary>TArray&lt;float&gt;</summary>
		public const int TriSubmergedArea = 0x04D0;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData04 = 0x04E0;

	}

	public class UBuoyancyComponent
	{
		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0220;

		///<summary>float</summary>
		public const int MeshDensity = 0x0228;

		///<summary>float</summary>
		public const int FluidDensity = 0x022C;

		///<summary>float</summary>
		public const int FluidLinearDamping = 0x0230;

		///<summary>float</summary>
		public const int FluidAngularDamping = 0x0234;

		///<summary>FVector</summary>
		public const int VelocityDamper = 0x0238;

		///<summary>bool</summary>
		public const int ClampMaxVelocity = 0x0244;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0245;

		///<summary>float</summary>
		public const int MaxUnderwaterVelocity = 0x0248;

		///<summary>float</summary>
		public const int TestPointRadius = 0x024C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int TestPoints = 0x0250;

		///<summary>TArray&lt;float&gt;</summary>
		public const int PointDensityOverride = 0x0260;

		///<summary>bool</summary>
		public const int DrawDebugPoints = 0x0270;

		///<summary>bool</summary>
		public const int EnableStayUprightConstraint = 0x0271;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0272;

		///<summary>float</summary>
		public const int StayUprightStiffness = 0x0274;

		///<summary>float</summary>
		public const int StayUprightDamping = 0x0278;

		///<summary>FRotator</summary>
		public const int StayUprightDesiredRotation = 0x027C;

		///<summary>bool</summary>
		public const int EnableWaveForces = 0x0288;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0289;

		///<summary>float</summary>
		public const int WaveForceMultiplier = 0x028C;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData03 = 0x0290;

	}

	public class UBuoyantDestructibleComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0BA0;

		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0BA8;

		///<summary>float</summary>
		public const int ChunkDensity = 0x0BB0;

		///<summary>float</summary>
		public const int FluidDensity = 0x0BB4;

		///<summary>float</summary>
		public const int FluidLinearDamping = 0x0BB8;

		///<summary>float</summary>
		public const int FluidAngularDamping = 0x0BBC;

		///<summary>FVector</summary>
		public const int VelocityDamper = 0x0BC0;

		///<summary>bool</summary>
		public const int ClampMaxVelocity = 0x0BCC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0BCD;

		///<summary>float</summary>
		public const int MaxUnderwaterVelocity = 0x0BD0;

		///<summary>float</summary>
		public const int TestPointRadius = 0x0BD4;

		///<summary>bool</summary>
		public const int DrawDebugPoints = 0x0BD8;

		///<summary>bool</summary>
		public const int EnableWaveForces = 0x0BD9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x0BDA;

		///<summary>float</summary>
		public const int WaveForceMultiplier = 0x0BDC;

		///<summary>float</summary>
		public const int ChunkSleepThreshold = 0x0BE0;

		///<summary>float</summary>
		public const int ChunkStabilizationThreshold = 0x0BE4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0BE8;

	}

	public class ABuoyantDestructible
	{
		///<summary>UBuoyantDestructibleComponent *</summary>
		public const int BuoyantDestructibleComponent = 0x03B0;

	}

	public class UBuoyantMeshComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x09E0;

		///<summary>bool</summary>
		public const int bVerticalForcesOnly = 0x09E8;

		///<summary>bool</summary>
		public const int bUseWaterPatch = 0x09E9;

		///<summary>bool</summary>
		public const int bUseStaticForces = 0x09EA;

		///<summary>bool</summary>
		public const int bUseDynamicForces = 0x09EB;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x09EC;

		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x09F0;

		///<summary>bool</summary>
		public const int bDrawForceArrows = 0x09F8;

		///<summary>bool</summary>
		public const int bDrawWaterline = 0x09F9;

		///<summary>bool</summary>
		public const int bDrawVertices = 0x09FA;

		///<summary>bool</summary>
		public const int bDrawTriangles = 0x09FB;

		///<summary>bool</summary>
		public const int bDrawSubtriangles = 0x09FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x09FD;

		///<summary>float</summary>
		public const int ForceArrowSize = 0x0A00;

		///<summary>bool</summary>
		public const int bOverrideMeshDensity = 0x0A04;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0A05;

		///<summary>float</summary>
		public const int MeshDensity = 0x0A08;

		///<summary>bool</summary>
		public const int bOverrideMass = 0x0A0C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0A0D;

		///<summary>float</summary>
		public const int Mass = 0x0A10;

		///<summary>float</summary>
		public const int WaterDensity = 0x0A14;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData05 = 0x0A18;

		///<summary>UWaterHeightmapComponent *</summary>
		public const int WaterHeightmap = 0x0A40;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData06 = 0x0A48;

	}

	public class ACustomVehicleController
	{
		///<summary>APawn *</summary>
		public const int PlayerPawn = 0x06F0;

	}

	public class AFishManager
	{
		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int flockTypes = 0x03B0;

		///<summary>TArray&lt;float&gt;</summary>
		public const int numInFlock = 0x03C0;

		///<summary>float</summary>
		public const int minZ = 0x03D0;

		///<summary>float</summary>
		public const int maxZ = 0x03D4;

		///<summary>float</summary>
		public const int underwaterBoxLength = 0x03D8;

		///<summary>bool</summary>
		public const int attachToPlayer = 0x03DC;

		///<summary>bool</summary>
		public const int DebugMode = 0x03DD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03DE;

		///<summary>UClass *</summary>
		public const int playerType = 0x03E0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x03E8;

	}

	public class AFlockFish
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>USphereComponent *</summary>
		public const int FishInteractionSphere = 0x0420;

		///<summary>bool</summary>
		public const int isLeader = 0x0428;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0429;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int enemyTypes = 0x0430;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int preyTypes = 0x0440;

		///<summary>UClass *</summary>
		public const int neighborType = 0x0450;

		///<summary>float</summary>
		public const int followDist = 0x0458;

		///<summary>float</summary>
		public const int Speed = 0x045C;

		///<summary>float</summary>
		public const int MaxSpeed = 0x0460;

		///<summary>float</summary>
		public const int turnSpeed = 0x0464;

		///<summary>float</summary>
		public const int turnFrequency = 0x0468;

		///<summary>float</summary>
		public const int hungerResetTime = 0x046C;

		///<summary>float</summary>
		public const int distBehindSpeedUpRange = 0x0470;

		///<summary>float</summary>
		public const int SeperationDistanceMultiplier = 0x0474;

		///<summary>float</summary>
		public const int FleeDistanceMultiplier = 0x0478;

		///<summary>float</summary>
		public const int FleeAccelerationMultiplier = 0x047C;

		///<summary>float</summary>
		public const int ChaseAccelerationMultiplier = 0x0480;

		///<summary>float</summary>
		public const int SeekDecelerationMultiplier = 0x0484;

		///<summary>float</summary>
		public const int AvoidForceMultiplier = 0x0488;

		///<summary>float</summary>
		public const int AvoidanceForce = 0x048C;

		///<summary>UClass *</summary>
		public const int playerType = 0x0490;

		///<summary>FVector</summary>
		public const int underwaterMin = 0x0498;

		///<summary>FVector</summary>
		public const int underwaterMax = 0x04A4;

		///<summary>float</summary>
		public const int CustomZSeekMin = 0x04B0;

		///<summary>float</summary>
		public const int CustomZSeekMax = 0x04B4;

		///<summary>float</summary>
		public const int NumNeighborsToEvaluate = 0x04B8;

		///<summary>float</summary>
		public const int UpdateEveryTick = 0x04BC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x04C0;

		///<summary>bool</summary>
		public const int DebugMode = 0x04D0;

		///<summary>unsigned char[0xBF]</summary>
		public const int UnknownData03 = 0x04D1;

	}

	public class UInfiniteSystemComponent
	{
		///<summary>bool</summary>
		public const int UpdateInEditor = 0x03F0;

		///<summary>TEnumAsByte&lt;EFollowMethod&gt;</summary>
		public const int FollowMethod = 0x03F1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03F2;

		///<summary>float</summary>
		public const int GridSnapSize = 0x03F4;

		///<summary>float</summary>
		public const int MaxLookAtDistance = 0x03F8;

		///<summary>bool</summary>
		public const int ScaleByDistance = 0x03FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03FD;

		///<summary>float</summary>
		public const int ScaleDistanceFactor = 0x0400;

		///<summary>float</summary>
		public const int ScaleStartDistance = 0x0404;

		///<summary>float</summary>
		public const int ScaleMin = 0x0408;

		///<summary>float</summary>
		public const int ScaleMax = 0x040C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0410;

	}

	public class ATimeManager
	{
		///<summary>FTimeDate</summary>
		public const int CurrentLocalTime = 0x03B0;

		///<summary>float</summary>
		public const int Latitude = 0x03CC;

		///<summary>float</summary>
		public const int Longitude = 0x03D0;

		///<summary>int</summary>
		public const int OffsetUTC = 0x03D4;

		///<summary>int</summary>
		public const int OffsetDST = 0x03D8;

		///<summary>bool</summary>
		public const int bAllowDaylightSavings = 0x03DC;

		///<summary>bool</summary>
		public const int bDaylightSavingsActive = 0x03DD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03DE;

		///<summary>float</summary>
		public const int TimeScaleMultiplier = 0x03E0;

		///<summary>float</summary>
		public const int SolarTime = 0x03E4;

		///<summary>float</summary>
		public const int LocalClockTime = 0x03E8;

		///<summary>float</summary>
		public const int TimeCorrection = 0x03EC;

		///<summary>int</summary>
		public const int LSTM = 0x03F0;

		///<summary>int</summary>
		public const int DayOfYear = 0x03F4;

		///<summary>float</summary>
		public const int EoT = 0x03F8;

		///<summary>float</summary>
		public const int SolarAltAngle = 0x03FC;

		///<summary>float</summary>
		public const int SolarDeclination = 0x0400;

		///<summary>float</summary>
		public const int SolarAzimuth = 0x0404;

		///<summary>float</summary>
		public const int SolarHRA = 0x0408;

		///<summary>float</summary>
		public const int SiderealTime = 0x040C;

		///<summary>float</summary>
		public const int LunarAltAngle = 0x0410;

		///<summary>float</summary>
		public const int LunarHRA = 0x0414;

		///<summary>float</summary>
		public const int LunarDeclination = 0x0418;

		///<summary>float</summary>
		public const int LunarAzimuth = 0x041C;

		///<summary>float</summary>
		public const int LunarRightAsc = 0x0420;

		///<summary>float</summary>
		public const int LunarElapsedDays = 0x0424;

		///<summary>float</summary>
		public const int EcLongitude = 0x0428;

		///<summary>float</summary>
		public const int EcLatitude = 0x042C;

		///<summary>float</summary>
		public const int EcDistance = 0x0430;

		///<summary>float</summary>
		public const int PartL = 0x0434;

		///<summary>float</summary>
		public const int PartM = 0x0438;

		///<summary>float</summary>
		public const int PartF = 0x043C;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData01 = 0x0440;

	}

	public class UWaterHeightmapComponent
	{
		///<summary>float</summary>
		public const int GridSizeMultiplier = 0x01E0;

		///<summary>bool</summary>
		public const int bDrawUsedTriangles = 0x01E4;

		///<summary>bool</summary>
		public const int bDrawHeightmap = 0x01E5;

		///<summary>unsigned char[0x62]</summary>
		public const int UnknownData00 = 0x01E6;

		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x0248;

	}

}
