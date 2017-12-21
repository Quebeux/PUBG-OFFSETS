/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AWheeledVehicle
	{
		///<summary>USkeletalMeshComponent *</summary>
		public const int Mesh = 0x0410;

		///<summary>UWheeledVehicleMovementComponent *</summary>
		public const int VehicleMovement = 0x0418;

	}

	public class UWheeledVehicleMovementComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0260;

		///<summary>unsigned char:1</summary>
		public const int bDeprecatedSpringOffsetMode = 0x0268;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0269;

		///<summary>TArray&lt;bool&gt;</summary>
		public const int TirePunctured = 0x0270;

		///<summary>TArray&lt;FWheelSetup&gt;</summary>
		public const int WheelSetups = 0x0280;

		///<summary>float</summary>
		public const int Mass = 0x0290;

		///<summary>float</summary>
		public const int DragCoefficient = 0x0294;

		///<summary>float</summary>
		public const int ChassisWidth = 0x0298;

		///<summary>float</summary>
		public const int ChassisHeight = 0x029C;

		///<summary>bool</summary>
		public const int bReverseAsBrake = 0x02A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x02A1;

		///<summary>float</summary>
		public const int DragArea = 0x02A4;

		///<summary>float</summary>
		public const int EstimatedMaxEngineSpeed = 0x02A8;

		///<summary>float</summary>
		public const int MaxEngineRPM = 0x02AC;

		///<summary>float</summary>
		public const int DebugDragMagnitude = 0x02B0;

		///<summary>FVector</summary>
		public const int InertiaTensorScale = 0x02B4;

		///<summary>float</summary>
		public const int MinNormalizedTireLoad = 0x02C0;

		///<summary>float</summary>
		public const int MinNormalizedTireLoadFiltered = 0x02C4;

		///<summary>float</summary>
		public const int MaxNormalizedTireLoad = 0x02C8;

		///<summary>float</summary>
		public const int MaxNormalizedTireLoadFiltered = 0x02CC;

		///<summary>float</summary>
		public const int ThresholdLongitudinalSpeed = 0x02D0;

		///<summary>int</summary>
		public const int LowForwardSpeedSubStepCount = 0x02D4;

		///<summary>int</summary>
		public const int HighForwardSpeedSubStepCount = 0x02D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x02DC;

		///<summary>TArray&lt;UVehicleWheel * &gt;</summary>
		public const int Wheels = 0x02E0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData04 = 0x02F0;

		///<summary>unsigned char:1</summary>
		public const int bUseRVOAvoidance = 0x0308;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0309;

		///<summary>float</summary>
		public const int RVOAvoidanceRadius = 0x030C;

		///<summary>float</summary>
		public const int RVOAvoidanceHeight = 0x0310;

		///<summary>float</summary>
		public const int AvoidanceConsiderationRadius = 0x0314;

		///<summary>float</summary>
		public const int RVOSteeringStep = 0x0318;

		///<summary>float</summary>
		public const int RVOThrottleStep = 0x031C;

		///<summary>int</summary>
		public const int AvoidanceUID = 0x0320;

		///<summary>FNavAvoidanceMask</summary>
		public const int AvoidanceGroup = 0x0324;

		///<summary>FNavAvoidanceMask</summary>
		public const int GroupsToAvoid = 0x0328;

		///<summary>FNavAvoidanceMask</summary>
		public const int GroupsToIgnore = 0x032C;

		///<summary>float</summary>
		public const int AvoidanceWeight = 0x0330;

		///<summary>FVector</summary>
		public const int PendingLaunchVelocity = 0x0334;

		///<summary>FReplicatedVehicleState</summary>
		public const int ReplicatedState = 0x0340;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x0354;

		///<summary>float</summary>
		public const int RawSteeringInput = 0x0358;

		///<summary>float</summary>
		public const int RawThrottleInput = 0x035C;

		///<summary>float</summary>
		public const int RawBrakeInput = 0x0360;

		///<summary>unsigned char:1</summary>
		public const int bRawHandbrakeInput = 0x0364;

		///<summary>unsigned char:1</summary>
		public const int bRawGearUpInput = 0x0364;

		///<summary>unsigned char:1</summary>
		public const int bRawGearDownInput = 0x0364;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0365;

		///<summary>float</summary>
		public const int SteeringInput = 0x0368;

		///<summary>float</summary>
		public const int ThrottleInput = 0x036C;

		///<summary>float</summary>
		public const int BrakeInput = 0x0370;

		///<summary>float</summary>
		public const int HandbrakeInput = 0x0374;

		///<summary>float</summary>
		public const int IdleBrakeInput = 0x0378;

		///<summary>float</summary>
		public const int StopThreshold = 0x037C;

		///<summary>float</summary>
		public const int WrongDirectionThreshold = 0x0380;

		///<summary>FVehicleInputRate</summary>
		public const int ThrottleInputRate = 0x0384;

		///<summary>FVehicleInputRate</summary>
		public const int BrakeInputRate = 0x038C;

		///<summary>FVehicleInputRate</summary>
		public const int HandbrakeInputRate = 0x0394;

		///<summary>FVehicleInputRate</summary>
		public const int SteeringInputRate = 0x039C;

		///<summary>unsigned char:1</summary>
		public const int bWasAvoidanceUpdated = 0x03A4;

		///<summary>unsigned char[0x2B]</summary>
		public const int UnknownData08 = 0x03A5;

	}

	public class UWheeledVehicleMovementComponent4W
	{
		///<summary>FVehicleEngineData</summary>
		public const int EngineSetup = 0x03D0;

		///<summary>FVehicleDifferential4WData</summary>
		public const int DifferentialSetup = 0x0460;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x047C;

		///<summary>FVehicleTransmissionData</summary>
		public const int TransmissionSetup = 0x0480;

		///<summary>FRuntimeFloatCurve</summary>
		public const int SteeringCurve = 0x04B0;

		///<summary>float</summary>
		public const int AckermannAccuracy = 0x0528;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x052C;

	}

	public class UVehicleWheel
	{
		///<summary>UStaticMesh *</summary>
		public const int CollisionMesh = 0x0028;

		///<summary>bool</summary>
		public const int bDontCreateShape = 0x0030;

		///<summary>bool</summary>
		public const int bAutoAdjustCollisionSize = 0x0031;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0032;

		///<summary>FVector</summary>
		public const int Offset = 0x0034;

		///<summary>float</summary>
		public const int ShapeRadius = 0x0040;

		///<summary>float</summary>
		public const int ShapeWidth = 0x0044;

		///<summary>float</summary>
		public const int Mass = 0x0048;

		///<summary>float</summary>
		public const int DampingRate = 0x004C;

		///<summary>float</summary>
		public const int SteerAngle = 0x0050;

		///<summary>bool</summary>
		public const int bAffectedByHandbrake = 0x0054;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0055;

		///<summary>UTireType *</summary>
		public const int TireType = 0x0058;

		///<summary>UTireConfig *</summary>
		public const int TireConfig = 0x0060;

		///<summary>float</summary>
		public const int LatStiffMaxLoad = 0x0068;

		///<summary>float</summary>
		public const int LatStiffValue = 0x006C;

		///<summary>float</summary>
		public const int LongStiffValue = 0x0070;

		///<summary>float</summary>
		public const int SuspensionForceOffset = 0x0074;

		///<summary>float</summary>
		public const int SuspensionForceOffsetX = 0x0078;

		///<summary>FVector</summary>
		public const int SuspensionTravelDir = 0x007C;

		///<summary>FVector</summary>
		public const int TireForceOffset = 0x0088;

		///<summary>float</summary>
		public const int SuspensionMaxRaise = 0x0094;

		///<summary>float</summary>
		public const int SuspensionMaxDrop = 0x0098;

		///<summary>float</summary>
		public const int SuspensionNaturalFrequency = 0x009C;

		///<summary>float</summary>
		public const int SuspensionDampingRatio = 0x00A0;

		///<summary>float</summary>
		public const int MaxBrakeTorque = 0x00A4;

		///<summary>float</summary>
		public const int MaxHandBrakeTorque = 0x00A8;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int QueryChannel = 0x00AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00AD;

		///<summary>UWheeledVehicleMovementComponent *</summary>
		public const int VehicleSim = 0x00B0;

		///<summary>int</summary>
		public const int WheelIndex = 0x00B8;

		///<summary>float</summary>
		public const int DebugLongSlip = 0x00BC;

		///<summary>float</summary>
		public const int DebugLatSlip = 0x00C0;

		///<summary>float</summary>
		public const int DebugNormalizedTireLoad = 0x00C4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x00C8;

		///<summary>float</summary>
		public const int DebugWheelTorque = 0x00CC;

		///<summary>float</summary>
		public const int DebugLongForce = 0x00D0;

		///<summary>float</summary>
		public const int DebugLatForce = 0x00D4;

		///<summary>FVector</summary>
		public const int Location = 0x00D8;

		///<summary>FVector</summary>
		public const int OldLocation = 0x00E4;

		///<summary>FVector</summary>
		public const int Velocity = 0x00F0;

		///<summary>float</summary>
		public const int RealWheelRotationSpeed = 0x00FC;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0100;

	}

	public class UVehicleAnimInstance
	{
		///<summary>unsigned char[0x4F8]</summary>
		public const int UnknownData00 = 0x0378;

		///<summary>UWheeledVehicleMovementComponent *</summary>
		public const int WheeledVehicleMovementComponent = 0x0870;

		///<summary>bool</summary>
		public const int bUseSupsensionInterpolation = 0x0878;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0879;

		///<summary>float</summary>
		public const int VehicleSuspensionInterpSpeed_ContactUpwards = 0x087C;

		///<summary>float</summary>
		public const int VehicleSuspensionInterpSpeed_Contact = 0x0880;

		///<summary>float</summary>
		public const int VehicleSuspensionInterpSpeed_NoContact = 0x0884;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0888;

	}

	public class UTireConfig
	{
		///<summary>float</summary>
		public const int FrictionScale = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

		///<summary>TArray&lt;FTireConfigMaterialFriction&gt;</summary>
		public const int TireFrictionScales = 0x0038;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0048;

	}

}
