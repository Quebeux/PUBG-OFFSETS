/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ACameraRig_Crane
	{
		///<summary>float</summary>
		public const int CranePitch = 0x03B0;

		///<summary>float</summary>
		public const int CraneYaw = 0x03B4;

		///<summary>float</summary>
		public const int CraneArmLength = 0x03B8;

		///<summary>bool</summary>
		public const int bLockMountPitch = 0x03BC;

		///<summary>bool</summary>
		public const int bLockMountYaw = 0x03BD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03BE;

		///<summary>USceneComponent *</summary>
		public const int TransformComponent = 0x03C0;

		///<summary>USceneComponent *</summary>
		public const int CraneYawControl = 0x03C8;

		///<summary>USceneComponent *</summary>
		public const int CranePitchControl = 0x03D0;

		///<summary>USceneComponent *</summary>
		public const int CraneCameraMount = 0x03D8;

	}

	public class ACameraRig_Rail
	{
		///<summary>float</summary>
		public const int CurrentPositionOnRail = 0x03B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03B4;

		///<summary>USceneComponent *</summary>
		public const int TransformComponent = 0x03B8;

		///<summary>USplineComponent *</summary>
		public const int RailSplineComponent = 0x03C0;

		///<summary>USceneComponent *</summary>
		public const int RailCameraMount = 0x03C8;

	}

	public class ACineCameraActor
	{
		///<summary>FCameraLookatTrackingSettings</summary>
		public const int LookatTrackingSettings = 0x0910;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0940;

	}

	public class UCineCameraComponent
	{
		///<summary>FCameraFilmbackSettings</summary>
		public const int FilmbackSettings = 0x09A0;

		///<summary>FCameraLensSettings</summary>
		public const int LensSettings = 0x09AC;

		///<summary>FCameraFocusSettings</summary>
		public const int FocusSettings = 0x09C0;

		///<summary>float</summary>
		public const int CurrentFocalLength = 0x09F8;

		///<summary>float</summary>
		public const int CurrentAperture = 0x09FC;

		///<summary>float</summary>
		public const int CurrentFocusDistance = 0x0A00;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0A04;

		///<summary>TArray&lt;FNamedFilmbackPreset&gt;</summary>
		public const int FilmbackPresets = 0x0A10;

		///<summary>TArray&lt;FNamedLensPreset&gt;</summary>
		public const int LensPresets = 0x0A20;

		///<summary>FString</summary>
		public const int DefaultFilmbackPresetName = 0x0A30;

		///<summary>FString</summary>
		public const int DefaultLensPresetName = 0x0A40;

		///<summary>float</summary>
		public const int DefaultLensFocalLength = 0x0A50;

		///<summary>float</summary>
		public const int DefaultLensFStop = 0x0A54;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0A58;

	}

}
