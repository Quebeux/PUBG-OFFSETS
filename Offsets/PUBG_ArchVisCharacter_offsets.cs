/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AArchVisCharacter
	{
		///<summary>FString</summary>
		public const int LookUpAxisName = 0x07E0;

		///<summary>FString</summary>
		public const int LookUpAtRateAxisName = 0x07F0;

		///<summary>FString</summary>
		public const int TurnAxisName = 0x0800;

		///<summary>FString</summary>
		public const int TurnAtRateAxisName = 0x0810;

		///<summary>FString</summary>
		public const int MoveForwardAxisName = 0x0820;

		///<summary>FString</summary>
		public const int MoveRightAxisName = 0x0830;

		///<summary>float</summary>
		public const int MouseSensitivityScale_Pitch = 0x0840;

		///<summary>float</summary>
		public const int MouseSensitivityScale_Yaw = 0x0844;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0848;

	}

	public class UArchVisCharMovementComponent
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0840;

		///<summary>FRotator</summary>
		public const int RotationalDeceleration = 0x0844;

		///<summary>FRotator</summary>
		public const int MaxRotationalVelocity = 0x0850;

		///<summary>float</summary>
		public const int MinPitch = 0x085C;

		///<summary>float</summary>
		public const int MaxPitch = 0x0860;

		///<summary>float</summary>
		public const int WalkingFriction = 0x0864;

		///<summary>float</summary>
		public const int WalkingSpeed = 0x0868;

		///<summary>float</summary>
		public const int WalkingAcceleration = 0x086C;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0870;

	}

}
