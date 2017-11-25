/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AVehicleBase_C
	{
		///<summary>FPointerToUberGraphFrame</summary>
		public const int UberGraphFrame = 0x06D0;

		///<summary>UPointLightComponent *</summary>
		public const int BoostLight = 0x06D8;

		///<summary>UPointLightComponent *</summary>
		public const int LowFuelLight = 0x06E0;

		///<summary>UPointLightComponent *</summary>
		public const int TailLamp_3 = 0x06E8;

		///<summary>UPointLightComponent *</summary>
		public const int TailLamp_2 = 0x06F0;

		///<summary>USpotLightComponent *</summary>
		public const int HeadLamp_3 = 0x06F8;

		///<summary>USpotLightComponent *</summary>
		public const int HeadLamp_2 = 0x0700;

		///<summary>UCameraComponent *</summary>
		public const int ThirdPersonCameraInVehicle = 0x0708;

		///<summary>USpringArmInVehicleComponent *</summary>
		public const int ThirdPersonSpringArmInVehicle = 0x0710;

		///<summary>UCameraComponent *</summary>
		public const int FirstPersonCameraInVehicle = 0x0718;

		///<summary>USpringArmInVehicleComponent *</summary>
		public const int FirstPersonSpringArmInVehicle = 0x0720;

		///<summary>URadialForceComponent *</summary>
		public const int RadialForce = 0x0728;

		///<summary>float</summary>
		public const int ImpactModifier = 0x0730;

		///<summary>float</summary>
		public const int ImpactAbsorption = 0x0734;

		///<summary>float</summary>
		public const int ImpactModifierUpsideDown = 0x0738;

		///<summary>float</summary>
		public const int ImpactAbsorptionUpsideDown = 0x073C;

		///<summary>float</summary>
		public const int FuelConsumptionModifierBoost = 0x0740;

		///<summary>float</summary>
		public const int ImpactAbsorptionPassenger = 0x0744;

		///<summary>float</summary>
		public const int ImpactAbsorptionPassengerUpsideDown = 0x0748;

		///<summary>float</summary>
		public const int LaunchVelocityFactorOnHitCharacter = 0x074C;

		///<summary>bool</summary>
		public const int IsLightsOn = 0x0750;

		///<summary>bool</summary>
		public const int IsBrakeEngaging = 0x0751;

		///<summary>bool</summary>
		public const int IsReverseEngaging = 0x0752;

		///<summary>bool</summary>
		public const int IsHandBraking = 0x0753;

		///<summary>float</summary>
		public const int BrakeLightIntensity_On = 0x0754;

		///<summary>float</summary>
		public const int BrakeLightIntensity_Off = 0x0758;

		///<summary>float</summary>
		public const int ExplosionRadius_Inner = 0x075C;

		///<summary>float</summary>
		public const int ExplosionRadius_Outer = 0x0760;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0764;

		///<summary>UCurveFloat *</summary>
		public const int DamageCurve = 0x0768;

		///<summary>float</summary>
		public const int Throttle = 0x0770;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0774;

		///<summary>UCurveFloat *</summary>
		public const int FuelConsumptionCurve = 0x0778;

		///<summary>float</summary>
		public const int FuelEfficiency = 0x0780;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0784;

		///<summary>UTslWheeledVehicleMovement *</summary>
		public const int TslWheeledVehicleMovementRef = 0x0788;

		///<summary>ATslPlayerController *</summary>
		public const int DriveControllerrRef = 0x0790;

		///<summary>TArray<float></summary>
		public const int WheelsLatSlip_1 = 0x0798;

		///<summary>TArray<float></summary>
		public const int WheelsLongSlip_1 = 0x07A8;

		///<summary>float</summary>
		public const int FuelConsumptionModifierIdle = 0x07B8;

		///<summary>float</summary>
		public const int SpeedKPH_1 = 0x07BC;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionOffset_1 = 0x07C0;

		///<summary>TArray<UPhysicalMaterial * ></summary>
		public const int WheelsContactSurface_1 = 0x07D0;

		///<summary>TArray<float></summary>
		public const int WheelsRotationSpeed = 0x07E0;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionMaxDrop_1 = 0x07F0;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionMaxRaise_1 = 0x0800;

		///<summary>float</summary>
		public const int RPM_1 = 0x0810;

		///<summary>bool</summary>
		public const int TestBoostingAKEvent = 0x0814;

		///<summary>bool</summary>
		public const int TestBoostingAKEvent_prev = 0x0815;

		///<summary>bool</summary>
		public const int TestThrottlingAKEvent = 0x0816;

		///<summary>bool</summary>
		public const int TestThrottlingAKEvent_prev = 0x0817;

		///<summary>bool</summary>
		public const int TestSteeringAKEvent = 0x0818;

		///<summary>bool</summary>
		public const int TestSteeringAKEvent_prev = 0x0819;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x081A;

		///<summary>float</summary>
		public const int Brake_1 = 0x081C;

		///<summary>bool</summary>
		public const int TestBrakingAKEvent = 0x0820;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0821;

		///<summary>TArray<UPhysicalMaterial * ></summary>
		public const int TestWheelsContactSurface_prev_1 = 0x0828;

		///<summary>bool</summary>
		public const int TestBrakingAKEvent_prev = 0x0838;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x0839;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionOffsetNorm = 0x0840;

		///<summary>TArray<float></summary>
		public const int WheelsWaterDepth_1 = 0x0850;

		///<summary>float</summary>
		public const int FlatTireCount_1 = 0x0860;

		///<summary>bool</summary>
		public const int bUseDynamicCamera = 0x0864;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0865;

		///<summary>FVector</summary>
		public const int LastVelocity = 0x0868;

		///<summary>FVector</summary>
		public const int Acceleration = 0x0874;

		///<summary>bool</summary>
		public const int bTickFuelIndicator = 0x0880;

		///<summary>bool</summary>
		public const int bTickBoostIndicator = 0x0881;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData07 = 0x0882;

		///<summary>float</summary>
		public const int LowFuelLevel = 0x0884;

		///<summary>float</summary>
		public const int LastFuelConsumptionTime = 0x0888;

	}

}
