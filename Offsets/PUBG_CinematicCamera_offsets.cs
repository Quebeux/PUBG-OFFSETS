/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ACameraRig_Crane
	{
		///<summary>float</summary>
		public const int CranePitch = 0x03A0;

		///<summary>float</summary>
		public const int CraneYaw = 0x03A4;

		///<summary>float</summary>
		public const int CraneArmLength = 0x03A8;

		///<summary>bool</summary>
		public const int bLockMountPitch = 0x03AC;

		///<summary>bool</summary>
		public const int bLockMountYaw = 0x03AD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03AE;

		///<summary>USceneComponent *</summary>
		public const int TransformComponent = 0x03B0;

		///<summary>USceneComponent *</summary>
		public const int CraneYawControl = 0x03B8;

		///<summary>USceneComponent *</summary>
		public const int CranePitchControl = 0x03C0;

		///<summary>USceneComponent *</summary>
		public const int CraneCameraMount = 0x03C8;

		///<summary>UStaticMeshComponent *</summary>
		public const int PreviewMesh_CraneArm = 0x03D0;

		///<summary>UStaticMeshComponent *</summary>
		public const int PreviewMesh_CraneBase = 0x03D8;

		///<summary>UStaticMeshComponent *</summary>
		public const int PreviewMesh_CraneMount = 0x03E0;

		///<summary>UStaticMeshComponent *</summary>
		public const int PreviewMesh_CraneCounterWeight = 0x03E8;

	}

	public class ACameraRig_Rail
	{
		///<summary>float</summary>
		public const int CurrentPositionOnRail = 0x03A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03A4;

		///<summary>USceneComponent *</summary>
		public const int TransformComponent = 0x03A8;

		///<summary>USplineComponent *</summary>
		public const int RailSplineComponent = 0x03B0;

		///<summary>USceneComponent *</summary>
		public const int RailCameraMount = 0x03B8;

		///<summary>USplineMeshComponent *</summary>
		public const int PreviewMesh_Rail = 0x03C0;

		///<summary>TArray<USplineMeshComponent * ></summary>
		public const int PreviewRailMeshSegments = 0x03C8;

		///<summary>UStaticMesh *</summary>
		public const int PreviewRailStaticMesh = 0x03D8;

		///<summary>UStaticMeshComponent *</summary>
		public const int PreviewMesh_Mount = 0x03E0;

	}

	public class UCineCameraComponent
	{
		///<summary>FCameraFilmbackSettings</summary>
		public const int FilmbackSettings = 0x0860;

		///<summary>FCameraLensSettings</summary>
		public const int LensSettings = 0x086C;

		///<summary>FCameraFocusSettings</summary>
		public const int FocusSettings = 0x0880;

		///<summary>float</summary>
		public const int CurrentFocalLength = 0x08B0;

		///<summary>float</summary>
		public const int CurrentAperture = 0x08B4;

		///<summary>float</summary>
		public const int CurrentFocusDistance = 0x08B8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x08BC;

		///<summary>TArray<FNamedFilmbackPreset></summary>
		public const int FilmbackPresets = 0x08C8;

		///<summary>TArray<FNamedLensPreset></summary>
		public const int LensPresets = 0x08D8;

		///<summary>FString</summary>
		public const int DefaultFilmbackPresetName = 0x08E8;

		///<summary>FString</summary>
		public const int DefaultLensPresetName = 0x08F8;

		///<summary>float</summary>
		public const int DefaultLensFocalLength = 0x0908;

		///<summary>float</summary>
		public const int DefaultLensFStop = 0x090C;

	}

	public class ACineCameraActor
	{
		///<summary>FCameraLookatTrackingSettings</summary>
		public const int LookatTrackingSettings = 0x08B0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x08E0;

	}

}
