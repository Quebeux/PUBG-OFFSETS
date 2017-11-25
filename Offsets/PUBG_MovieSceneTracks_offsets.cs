/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene3DConstraintSection
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int ConstraintId = 0x0040;

	}

	public class UMovieScene3DAttachSection
	{
		///<summary><![CDATA[FName]]></summary>
		public const int AttachSocketName = 0x0050;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachComponentName = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainTx = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainTy = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainTz = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainRx = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainRy = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainRz = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMovieScene3DPathSection
	{
		///<summary><![CDATA[FRichCurve]]></summary>
		public const int TimingCurve = 0x0050;

		///<summary><![CDATA[TEnumAsByte<EMovieScene3DPathSection_Axis>]]></summary>
		public const int FrontAxisEnum = 0x00C8;

		///<summary><![CDATA[TEnumAsByte<EMovieScene3DPathSection_Axis>]]></summary>
		public const int UpAxisEnum = 0x00C9;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x00CA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFollow = 0x00CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReverse = 0x00CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceUpright = 0x00CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00CD;

	}

	public class UMovieScene3DConstraintTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int ConstraintSections = 0x0028;

	}

	public class UMovieScene3DTransformSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int Translation = 0x0048;

		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int Rotation = 0x01B0;

		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int Scale = 0x0318;

	}

	public class UMovieSceneActorReferenceSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int ActorGuidIndexCurve = 0x0048;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x00B8;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int ActorGuidStrings = 0x00C8;

	}

	public class UMovieSceneAudioSection
	{
		///<summary><![CDATA[USoundBase *]]></summary>
		public const int Sound = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int AudioStartTime = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int AudioDilationFactor = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int AudioVolume = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int bSuppressSubtitles = 0x0054;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0055;

	}

	public class UMovieSceneAudioTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int AudioSections = 0x0028;

	}

	public class UMovieSceneBoolSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[bool]]></summary>
		public const int DefaultValue = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0049;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int BoolCurve = 0x0050;

	}

	public class UMovieSceneByteSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int ByteCurve = 0x0048;

	}

	public class UMovieSceneCameraAnimSection
	{
		///<summary><![CDATA[UCameraAnim *]]></summary>
		public const int CameraAnim = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int PlayScale = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int BlendInTime = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int BlendOutTime = 0x0054;

		///<summary><![CDATA[bool]]></summary>
		public const int bLooping = 0x0058;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x0059;

		///<summary><![CDATA[TEnumAsByte<ECameraAnimPlaySpace>]]></summary>
		public const int PlaySpace = 0x005A;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x005B;

		///<summary><![CDATA[FRotator]]></summary>
		public const int UserDefinedPlaySpace = 0x005C;

	}

	public class UMovieSceneCameraAnimTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int CameraAnimSections = 0x0028;

	}

	public class UMovieSceneCameraCutSection
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int CameraGuid = 0x0040;

	}

	public class UMovieSceneCameraCutTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneCameraShakeSection
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ShakeClass = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int PlayScale = 0x0048;

		///<summary><![CDATA[TEnumAsByte<ECameraAnimPlaySpace>]]></summary>
		public const int PlaySpace = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x004D;

		///<summary><![CDATA[FRotator]]></summary>
		public const int UserDefinedPlaySpace = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x005C;

	}

	public class UMovieSceneCameraShakeTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int CameraShakeSections = 0x0028;

	}

	public class UMovieSceneColorSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int RedCurve = 0x0048;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int GreenCurve = 0x00C0;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int BlueCurve = 0x0138;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int AlphaCurve = 0x01B0;

	}

	public class UMovieSceneEventSection
	{
		///<summary><![CDATA[FNameCurve]]></summary>
		public const int Events = 0x0040;

	}

	public class UMovieSceneEventTrack
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenForwards = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenBackwards = 0x0028;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0030;

	}

	public class UMovieSceneFloatSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int FloatCurve = 0x0048;

	}

	public class UMovieSceneFadeSection
	{
		///<summary><![CDATA[FLinearColor]]></summary>
		public const int FadeColor = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFadeAudio = 0x00D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00D1;

	}

	public class UMovieSceneLevelVisibilitySection
	{
		///<summary><![CDATA[TEnumAsByte<ELevelVisibility>]]></summary>
		public const int Visibility = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0041;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int LevelNames = 0x0048;

	}

	public class UMovieScenePropertyTrack
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PropertyName = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int PropertyPath = 0x0030;

		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0040;

	}

	public class UMovieSceneLevelVisibilityTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneParameterSection
	{
		///<summary><![CDATA[TArray<FScalarParameterNameAndCurve>]]></summary>
		public const int ScalarParameterNamesAndCurves = 0x0040;

		///<summary><![CDATA[TArray<FVectorParameterNameAndCurves>]]></summary>
		public const int VectorParameterNamesAndCurves = 0x0050;

		///<summary><![CDATA[TArray<FColorParameterNameAndCurves>]]></summary>
		public const int ColorParameterNamesAndCurves = 0x0060;

	}

	public class UMovieSceneMaterialTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneComponentMaterialTrack
	{
		///<summary><![CDATA[int]]></summary>
		public const int MaterialIndex = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UMovieSceneParticleParameterTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneParticleSection
	{
		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int ParticleKeys = 0x0040;

	}

	public class UMovieSceneParticleTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int ParticleSections = 0x0028;

	}

	public class UMovieSceneByteTrack
	{
		///<summary><![CDATA[UEnum *]]></summary>
		public const int Enum = 0x0050;

	}

	public class UMovieSceneColorTrack
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bIsSlateColor = 0x0050;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0051;

	}

	public class UMovieSceneVectorTrack
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumChannelsUsed = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UMovieSceneSkeletalAnimationSection
	{
		///<summary><![CDATA[UAnimSequence *]]></summary>
		public const int AnimSequence = 0x0040;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int Animation = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int StartOffset = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int EndOffset = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReverse = 0x005C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x005D;

		///<summary><![CDATA[FName]]></summary>
		public const int SlotName = 0x0060;

	}

	public class UMovieSceneSkeletalAnimationTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int AnimationSections = 0x0028;

	}

	public class UMovieSceneSpawnTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0028;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ObjectGuid = 0x0038;

	}

	public class UMovieSceneStringSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FStringCurve]]></summary>
		public const int StringCurve = 0x0048;

	}

	public class UMovieSceneSubSection
	{
		///<summary><![CDATA[float]]></summary>
		public const int StartOffset = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int TimeScale = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int PrerollTime = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

		///<summary><![CDATA[UMovieSceneSequence *]]></summary>
		public const int SubSequence = 0x0050;

		///<summary><![CDATA[TLazyObjectPtr<AActor>]]></summary>
		public const int ActorToRecord = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0074;

		///<summary><![CDATA[FString]]></summary>
		public const int TargetSequenceName = 0x0078;

		///<summary><![CDATA[FDirectoryPath]]></summary>
		public const int TargetPathToRecordTo = 0x0088;

	}

	public class UMovieSceneCinematicShotSection
	{
		///<summary><![CDATA[FText]]></summary>
		public const int DisplayName = 0x0098;

	}

	public class UMovieSceneSubTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneVectorSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FRichCurve[0x4]]]></summary>
		public const int Curves = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int ChannelsUsed = 0x0228;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x022C;

	}

}
