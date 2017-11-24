/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ACameraRig_Crane
	{
		public const int CranePitch = 0x03A0;
		public const int CraneYaw = 0x03A4;
		public const int CraneArmLength = 0x03A8;
		public const int bLockMountPitch = 0x03AC;
		public const int bLockMountYaw = 0x03AD;
		public const int UnknownData00 = 0x03AE;
		public const int TransformComponent = 0x03B0;
		public const int CraneYawControl = 0x03B8;
		public const int CranePitchControl = 0x03C0;
		public const int CraneCameraMount = 0x03C8;
		public const int PreviewMesh_CraneArm = 0x03D0;
		public const int PreviewMesh_CraneBase = 0x03D8;
		public const int PreviewMesh_CraneMount = 0x03E0;
		public const int PreviewMesh_CraneCounterWeight = 0x03E8;
	}

	public class ACameraRig_Rail
	{
		public const int CurrentPositionOnRail = 0x03A0;
		public const int UnknownData00 = 0x03A4;
		public const int TransformComponent = 0x03A8;
		public const int RailSplineComponent = 0x03B0;
		public const int RailCameraMount = 0x03B8;
		public const int PreviewMesh_Rail = 0x03C0;
		public const int PreviewRailStaticMesh = 0x03D8;
		public const int PreviewMesh_Mount = 0x03E0;
	}

	public class UCineCameraComponent
	{
		public const int FilmbackSettings = 0x0860;
		public const int LensSettings = 0x086C;
		public const int FocusSettings = 0x0880;
		public const int CurrentFocalLength = 0x08B0;
		public const int CurrentAperture = 0x08B4;
		public const int CurrentFocusDistance = 0x08B8;
		public const int UnknownData00 = 0x08BC;
		public const int DefaultFilmbackPresetName = 0x08E8;
		public const int DefaultLensPresetName = 0x08F8;
		public const int DefaultLensFocalLength = 0x0908;
		public const int DefaultLensFStop = 0x090C;
	}

	public class ACineCameraActor
	{
		public const int LookatTrackingSettings = 0x08B0;
		public const int UnknownData00 = 0x08E0;
	}

}
