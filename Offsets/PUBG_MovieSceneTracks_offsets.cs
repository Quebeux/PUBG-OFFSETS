/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene3DConstraintSection
	{
		///<summary>FGuid</summary>
		public const int ConstraintId = 0x0040;

	}

	public class UMovieScene3DAttachSection
	{
		///<summary>FName</summary>
		public const int AttachSocketName = 0x0050;

		///<summary>FName</summary>
		public const int AttachComponentName = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int bConstrainTx = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bConstrainTy = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bConstrainTz = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bConstrainRx = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bConstrainRy = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bConstrainRz = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMovieScene3DPathSection
	{
		///<summary>FRichCurve</summary>
		public const int TimingCurve = 0x0050;

		///<summary>TEnumAsByte&lt;EMovieScene3DPathSection_Axis&gt;</summary>
		public const int FrontAxisEnum = 0x00C8;

		///<summary>TEnumAsByte&lt;EMovieScene3DPathSection_Axis&gt;</summary>
		public const int UpAxisEnum = 0x00C9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x00CA;

		///<summary>unsigned char:1</summary>
		public const int bFollow = 0x00CC;

		///<summary>unsigned char:1</summary>
		public const int bReverse = 0x00CC;

		///<summary>unsigned char:1</summary>
		public const int bForceUpright = 0x00CC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00CD;

	}

	public class UMovieScene3DConstraintTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int ConstraintSections = 0x0028;

	}

	public class UMovieScene3DTransformSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FRichCurve[0x3]</summary>
		public const int Translation = 0x0048;

		///<summary>FRichCurve[0x3]</summary>
		public const int Rotation = 0x01B0;

		///<summary>FRichCurve[0x3]</summary>
		public const int Scale = 0x0318;

	}

	public class UMovieSceneActorReferenceSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FIntegralCurve</summary>
		public const int ActorGuidIndexCurve = 0x0048;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x00B8;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int ActorGuidStrings = 0x00C8;

	}

	public class UMovieSceneAudioSection
	{
		///<summary>USoundBase *</summary>
		public const int Sound = 0x0040;

		///<summary>float</summary>
		public const int AudioStartTime = 0x0048;

		///<summary>float</summary>
		public const int AudioDilationFactor = 0x004C;

		///<summary>float</summary>
		public const int AudioVolume = 0x0050;

		///<summary>bool</summary>
		public const int bSuppressSubtitles = 0x0054;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0055;

	}

	public class UMovieSceneAudioTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int AudioSections = 0x0028;

	}

	public class UMovieSceneBoolSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>bool</summary>
		public const int DefaultValue = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0049;

		///<summary>FIntegralCurve</summary>
		public const int BoolCurve = 0x0050;

	}

	public class UMovieSceneByteSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FIntegralCurve</summary>
		public const int ByteCurve = 0x0048;

	}

	public class UMovieSceneCameraAnimSection
	{
		///<summary>UCameraAnim *</summary>
		public const int CameraAnim = 0x0040;

		///<summary>float</summary>
		public const int PlayRate = 0x0048;

		///<summary>float</summary>
		public const int PlayScale = 0x004C;

		///<summary>float</summary>
		public const int BlendInTime = 0x0050;

		///<summary>float</summary>
		public const int BlendOutTime = 0x0054;

		///<summary>bool</summary>
		public const int bLooping = 0x0058;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0059;

		///<summary>TEnumAsByte&lt;ECameraAnimPlaySpace&gt;</summary>
		public const int PlaySpace = 0x005A;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x005B;

		///<summary>FRotator</summary>
		public const int UserDefinedPlaySpace = 0x005C;

	}

	public class UMovieSceneCameraAnimTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int CameraAnimSections = 0x0028;

	}

	public class UMovieSceneCameraCutSection
	{
		///<summary>FGuid</summary>
		public const int CameraGuid = 0x0040;

	}

	public class UMovieSceneCameraCutTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneCameraShakeSection
	{
		///<summary>UClass *</summary>
		public const int ShakeClass = 0x0040;

		///<summary>float</summary>
		public const int PlayScale = 0x0048;

		///<summary>TEnumAsByte&lt;ECameraAnimPlaySpace&gt;</summary>
		public const int PlaySpace = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x004D;

		///<summary>FRotator</summary>
		public const int UserDefinedPlaySpace = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x005C;

	}

	public class UMovieSceneCameraShakeTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int CameraShakeSections = 0x0028;

	}

	public class UMovieSceneColorSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FRichCurve</summary>
		public const int RedCurve = 0x0048;

		///<summary>FRichCurve</summary>
		public const int GreenCurve = 0x00C0;

		///<summary>FRichCurve</summary>
		public const int BlueCurve = 0x0138;

		///<summary>FRichCurve</summary>
		public const int AlphaCurve = 0x01B0;

	}

	public class UMovieSceneEventSection
	{
		///<summary>FNameCurve</summary>
		public const int Events = 0x0040;

	}

	public class UMovieSceneEventTrack
	{
		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenForwards = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenBackwards = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0030;

	}

	public class UMovieSceneFloatSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FRichCurve</summary>
		public const int FloatCurve = 0x0048;

	}

	public class UMovieSceneFadeSection
	{
		///<summary>FLinearColor</summary>
		public const int FadeColor = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bFadeAudio = 0x00D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00D1;

	}

	public class UMovieSceneLevelVisibilitySection
	{
		///<summary>TEnumAsByte&lt;ELevelVisibility&gt;</summary>
		public const int Visibility = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0041;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int LevelNames = 0x0048;

	}

	public class UMovieScenePropertyTrack
	{
		///<summary>FName</summary>
		public const int PropertyName = 0x0028;

		///<summary>FString</summary>
		public const int PropertyPath = 0x0030;

		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0040;

	}

	public class UMovieSceneLevelVisibilityTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneParameterSection
	{
		///<summary>TArray&lt;FScalarParameterNameAndCurve&gt;</summary>
		public const int ScalarParameterNamesAndCurves = 0x0040;

		///<summary>TArray&lt;FVectorParameterNameAndCurves&gt;</summary>
		public const int VectorParameterNamesAndCurves = 0x0050;

		///<summary>TArray&lt;FColorParameterNameAndCurves&gt;</summary>
		public const int ColorParameterNamesAndCurves = 0x0060;

	}

	public class UMovieSceneMaterialTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneComponentMaterialTrack
	{
		///<summary>int</summary>
		public const int MaterialIndex = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UMovieSceneParticleParameterTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneParticleSection
	{
		///<summary>FIntegralCurve</summary>
		public const int ParticleKeys = 0x0040;

	}

	public class UMovieSceneParticleTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int ParticleSections = 0x0028;

	}

	public class UMovieSceneByteTrack
	{
		///<summary>UEnum *</summary>
		public const int Enum = 0x0050;

	}

	public class UMovieSceneColorTrack
	{
		///<summary>bool</summary>
		public const int bIsSlateColor = 0x0050;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0051;

	}

	public class UMovieSceneVectorTrack
	{
		///<summary>int</summary>
		public const int NumChannelsUsed = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UMovieSceneSkeletalAnimationSection
	{
		///<summary>UAnimSequence *</summary>
		public const int AnimSequence = 0x0040;

		///<summary>UAnimSequenceBase *</summary>
		public const int Animation = 0x0048;

		///<summary>float</summary>
		public const int StartOffset = 0x0050;

		///<summary>float</summary>
		public const int EndOffset = 0x0054;

		///<summary>float</summary>
		public const int PlayRate = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int bReverse = 0x005C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x005D;

		///<summary>FName</summary>
		public const int SlotName = 0x0060;

	}

	public class UMovieSceneSkeletalAnimationTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int AnimationSections = 0x0028;

	}

	public class UMovieSceneSpawnTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0028;

		///<summary>FGuid</summary>
		public const int ObjectGuid = 0x0038;

	}

	public class UMovieSceneStringSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FStringCurve</summary>
		public const int StringCurve = 0x0048;

	}

	public class UMovieSceneSubSection
	{
		///<summary>float</summary>
		public const int StartOffset = 0x0040;

		///<summary>float</summary>
		public const int TimeScale = 0x0044;

		///<summary>float</summary>
		public const int PrerollTime = 0x0048;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x004C;

		///<summary>UMovieSceneSequence *</summary>
		public const int SubSequence = 0x0050;

		///<summary>TLazyObjectPtr&lt;AActor&gt;</summary>
		public const int ActorToRecord = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0074;

		///<summary>FString</summary>
		public const int TargetSequenceName = 0x0078;

		///<summary>FDirectoryPath</summary>
		public const int TargetPathToRecordTo = 0x0088;

	}

	public class UMovieSceneCinematicShotSection
	{
		///<summary>FText</summary>
		public const int DisplayName = 0x0098;

	}

	public class UMovieSceneSubTrack
	{
		///<summary>TArray&lt;UMovieSceneSection * &gt;</summary>
		public const int Sections = 0x0028;

	}

	public class UMovieSceneVectorSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

		///<summary>FRichCurve[0x4]</summary>
		public const int Curves = 0x0048;

		///<summary>int</summary>
		public const int ChannelsUsed = 0x0228;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x022C;

	}

}
