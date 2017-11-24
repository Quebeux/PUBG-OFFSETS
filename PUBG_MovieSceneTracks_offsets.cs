/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene3DConstraintSection
	{
		public const int ConstraintId = 0x0040;
	}

	public class UMovieScene3DAttachSection
	{
		public const int AttachSocketName = 0x0050;
		public const int AttachComponentName = 0x0058;
		public const int bConstrainTx = 0x0060;
		public const int bConstrainTy = 0x0060;
		public const int bConstrainTz = 0x0060;
		public const int bConstrainRx = 0x0060;
		public const int bConstrainRy = 0x0060;
		public const int bConstrainRz = 0x0060;
		public const int UnknownData00 = 0x0061;
	}

	public class UMovieScene3DPathSection
	{
		public const int TimingCurve = 0x0050;
		public const int FrontAxisEnum = 0x00C8;
		public const int UpAxisEnum = 0x00C9;
		public const int UnknownData00 = 0x00CA;
		public const int bFollow = 0x00CC;
		public const int bReverse = 0x00CC;
		public const int bForceUpright = 0x00CC;
		public const int UnknownData01 = 0x00CD;
	}

	public class UMovieScene3DTransformSection
	{
		public const int UnknownData00 = 0x0040;
		public const int Translation = 0x0048;
		public const int Rotation = 0x01B0;
		public const int Scale = 0x0318;
	}

	public class UMovieSceneActorReferenceSection
	{
		public const int UnknownData00 = 0x0040;
		public const int ActorGuidIndexCurve = 0x0048;
		public const int UnknownData01 = 0x00B8;
	}

	public class UMovieSceneAudioSection
	{
		public const int Sound = 0x0040;
		public const int AudioStartTime = 0x0048;
		public const int AudioDilationFactor = 0x004C;
		public const int AudioVolume = 0x0050;
		public const int bSuppressSubtitles = 0x0054;
		public const int UnknownData00 = 0x0055;
	}

	public class UMovieSceneBoolSection
	{
		public const int UnknownData00 = 0x0040;
		public const int DefaultValue = 0x0048;
		public const int UnknownData01 = 0x0049;
		public const int BoolCurve = 0x0050;
	}

	public class UMovieSceneByteSection
	{
		public const int UnknownData00 = 0x0040;
		public const int ByteCurve = 0x0048;
	}

	public class UMovieSceneCameraAnimSection
	{
		public const int CameraAnim = 0x0040;
		public const int PlayRate = 0x0048;
		public const int PlayScale = 0x004C;
		public const int BlendInTime = 0x0050;
		public const int BlendOutTime = 0x0054;
		public const int bLooping = 0x0058;
		public const int UnknownData00 = 0x0059;
		public const int PlaySpace = 0x005A;
		public const int UnknownData01 = 0x005B;
		public const int UserDefinedPlaySpace = 0x005C;
	}

	public class UMovieSceneCameraCutSection
	{
		public const int CameraGuid = 0x0040;
	}

	public class UMovieSceneCameraShakeSection
	{
		public const int ShakeClass = 0x0040;
		public const int PlayScale = 0x0048;
		public const int PlaySpace = 0x004C;
		public const int UnknownData00 = 0x004D;
		public const int UserDefinedPlaySpace = 0x0050;
		public const int UnknownData01 = 0x005C;
	}

	public class UMovieSceneColorSection
	{
		public const int UnknownData00 = 0x0040;
		public const int RedCurve = 0x0048;
		public const int GreenCurve = 0x00C0;
		public const int BlueCurve = 0x0138;
		public const int AlphaCurve = 0x01B0;
	}

	public class UMovieSceneEventSection
	{
		public const int Events = 0x0040;
	}

	public class UMovieSceneEventTrack
	{
		public const int bFireEventsWhenForwards = 0x0028;
		public const int bFireEventsWhenBackwards = 0x0028;
		public const int UnknownData00 = 0x0029;
	}

	public class UMovieSceneFloatSection
	{
		public const int UnknownData00 = 0x0040;
		public const int FloatCurve = 0x0048;
	}

	public class UMovieSceneFadeSection
	{
		public const int FadeColor = 0x00C0;
		public const int bFadeAudio = 0x00D0;
		public const int UnknownData00 = 0x00D1;
	}

	public class UMovieSceneLevelVisibilitySection
	{
		public const int Visibility = 0x0040;
		public const int UnknownData00 = 0x0041;
	}

	public class UMovieScenePropertyTrack
	{
		public const int PropertyName = 0x0028;
		public const int PropertyPath = 0x0030;
	}

	public class UMovieSceneComponentMaterialTrack
	{
		public const int MaterialIndex = 0x0038;
		public const int UnknownData00 = 0x003C;
	}

	public class UMovieSceneParticleSection
	{
		public const int ParticleKeys = 0x0040;
	}

	public class UMovieSceneByteTrack
	{
		public const int Enum = 0x0050;
	}

	public class UMovieSceneColorTrack
	{
		public const int bIsSlateColor = 0x0050;
		public const int UnknownData00 = 0x0051;
	}

	public class UMovieSceneVectorTrack
	{
		public const int NumChannelsUsed = 0x0050;
		public const int UnknownData00 = 0x0054;
	}

	public class UMovieSceneSkeletalAnimationSection
	{
		public const int AnimSequence = 0x0040;
		public const int Animation = 0x0048;
		public const int StartOffset = 0x0050;
		public const int EndOffset = 0x0054;
		public const int PlayRate = 0x0058;
		public const int bReverse = 0x005C;
		public const int UnknownData00 = 0x005D;
		public const int SlotName = 0x0060;
	}

	public class UMovieSceneSpawnTrack
	{
		public const int ObjectGuid = 0x0038;
	}

	public class UMovieSceneStringSection
	{
		public const int UnknownData00 = 0x0040;
		public const int StringCurve = 0x0048;
	}

	public class UMovieSceneSubSection
	{
		public const int StartOffset = 0x0040;
		public const int TimeScale = 0x0044;
		public const int PrerollTime = 0x0048;
		public const int UnknownData00 = 0x004C;
		public const int SubSequence = 0x0050;
		public const int UnknownData01 = 0x0074;
		public const int TargetSequenceName = 0x0078;
		public const int TargetPathToRecordTo = 0x0088;
	}

	public class UMovieSceneCinematicShotSection
	{
		public const int DisplayName = 0x0098;
	}

	public class UMovieSceneVectorSection
	{
		public const int UnknownData00 = 0x0040;
		public const int Curves = 0x0048;
		public const int ChannelsUsed = 0x0228;
		public const int UnknownData01 = 0x022C;
	}

}
