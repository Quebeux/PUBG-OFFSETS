/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AActor
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FActorTickFunction</summary>
		public const int PrimaryActorTick = 0x0040;

		///<summary>float</summary>
		public const int CustomTimeDilation = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bHidden = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bNetTemporary = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bNetStartup = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bOnlyRelevantToOwner = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysRelevant = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bReplicateMovement = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bTearOff = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bExchangedRoles = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int UnknownData01 = 0x009D;

		///<summary>unsigned char:1</summary>
		public const int bNetLoadOnClient = 0x009D;

		///<summary>unsigned char:1</summary>
		public const int bNetUseOwnerRelevancy = 0x009D;

		///<summary>unsigned char:1</summary>
		public const int bBlockInput = 0x009D;

		///<summary>unsigned char:1</summary>
		public const int UnknownData02 = 0x009D;

		///<summary>unsigned char:1</summary>
		public const int bAllowTickBeforeBeginPlay = 0x009D;

		///<summary>unsigned char:2</summary>
		public const int UnknownData03 = 0x009D;

		///<summary>unsigned char:1</summary>
		public const int UnknownData04 = 0x009E;

		///<summary>unsigned char:1</summary>
		public const int bActorEnableCollision = 0x009E;

		///<summary>unsigned char:1</summary>
		public const int UnknownData05 = 0x009E;

		///<summary>unsigned char:1</summary>
		public const int bReplicates = 0x009E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData06 = 0x009F;

		///<summary>FName</summary>
		public const int NetDriverName = 0x00A0;

		///<summary>TEnumAsByte&lt;ENetRole&gt;</summary>
		public const int RemoteRole = 0x00A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData07 = 0x00A9;

		///<summary>AActor *</summary>
		public const int Owner = 0x00B0;

		///<summary>FRepMovement</summary>
		public const int ReplicatedMovement = 0x00B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x00EC;

		///<summary>FRepAttachment</summary>
		public const int AttachmentReplication = 0x00F0;

		///<summary>TEnumAsByte&lt;ENetRole&gt;</summary>
		public const int Role = 0x0130;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData09 = 0x0131;

		///<summary>TEnumAsByte&lt;EAutoReceiveInput&gt;</summary>
		public const int AutoReceiveInput = 0x0133;

		///<summary>int</summary>
		public const int InputPriority = 0x0134;

		///<summary>UInputComponent *</summary>
		public const int InputComponent = 0x0138;

		///<summary>TEnumAsByte&lt;EInputConsumeOptions&gt;</summary>
		public const int InputConsumeOption = 0x0140;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x0141;

		///<summary>float</summary>
		public const int NetCullDistanceSquared = 0x0144;

		///<summary>int</summary>
		public const int NetTag = 0x0148;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData11 = 0x014C;

		///<summary>float</summary>
		public const int NetUpdateFrequency = 0x0150;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData12 = 0x0154;

		///<summary>float</summary>
		public const int MinNetUpdateFrequency = 0x0158;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData13 = 0x015C;

		///<summary>float</summary>
		public const int NetPriority = 0x0160;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData14 = 0x0164;

		///<summary>unsigned char:1</summary>
		public const int bAutoDestroyWhenFinished = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bCanBeDamaged = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bActorIsBeingDestroyed = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bCollideWhenPlacing = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bFindCameraComponentWhenViewTarget = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bRelevantForNetworkReplays = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bGenerateOverlapEventsDuringLevelStreaming = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bCanBeInCluster = 0x0168;

		///<summary>ESpawnActorCollisionHandlingMethod</summary>
		public const int SpawnCollisionHandlingMethod = 0x0169;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData15 = 0x016A;

		///<summary>APawn *</summary>
		public const int Instigator = 0x0170;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int Children = 0x0178;

		///<summary>USceneComponent *</summary>
		public const int RootComponent = 0x0188;

		///<summary>TArray&lt;AMatineeActor * &gt;</summary>
		public const int ControllingMatineeActors = 0x0190;

		///<summary>float</summary>
		public const int InitialLifeSpan = 0x01A0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData16 = 0x01A4;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int Layers = 0x01B0;

		///<summary>TWeakObjectPtr&lt;AActor&gt;</summary>
		public const int ParentComponentActor = 0x01C0;

		///<summary>TWeakObjectPtr&lt;UChildActorComponent&gt;</summary>
		public const int ParentComponent = 0x01C8;

		///<summary>unsigned char:1</summary>
		public const int bAllowReceiveTickEventOnDedicatedServer = 0x01D0;

		///<summary>unsigned char:3</summary>
		public const int UnknownData17 = 0x01D0;

		///<summary>unsigned char:1</summary>
		public const int bActorSeamlessTraveled = 0x01D0;

		///<summary>unsigned char:1</summary>
		public const int bIgnoresOriginShifting = 0x01D0;

		///<summary>unsigned char:1</summary>
		public const int bEnableAutoLODGeneration = 0x01D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData18 = 0x01D1;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int Tags = 0x01D8;

		///<summary>uint64_t</summary>
		public const int HiddenEditorViews = 0x01E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTakeAnyDamage = 0x01F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTakePointDamage = 0x0200;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnActorBeginOverlap = 0x0210;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnActorEndOverlap = 0x0220;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnBeginCursorOver = 0x0230;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEndCursorOver = 0x0240;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnClicked = 0x0250;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnReleased = 0x0260;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchBegin = 0x0270;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchEnd = 0x0280;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchEnter = 0x0290;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchLeave = 0x02A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnActorHit = 0x02B0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDestroyed = 0x02C0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEndPlay = 0x02D0;

		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData19 = 0x02E0;

		///<summary>TArray&lt;UActorComponent * &gt;</summary>
		public const int BlueprintCreatedComponents = 0x0388;

		///<summary>TArray&lt;UActorComponent * &gt;</summary>
		public const int InstanceComponents = 0x0398;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData20 = 0x03A8;

	}

	public class AHUD
	{
		///<summary>APlayerController *</summary>
		public const int PlayerOwner = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bLostFocusPaused = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bShowHUD = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bShowDebugInfo = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bShowHitBoxDebugInfo = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bShowOverlays = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bEnableDebugTextShadow = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int PostRenderedActors = 0x03C0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03D0;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int DebugDisplay = 0x03D8;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int ToggledDebugCategories = 0x03E8;

		///<summary>UCanvas *</summary>
		public const int Canvas = 0x03F8;

		///<summary>UCanvas *</summary>
		public const int DebugCanvas = 0x0400;

		///<summary>TArray&lt;FDebugTextInfo&gt;</summary>
		public const int DebugTextList = 0x0408;

		///<summary>UClass *</summary>
		public const int ShowDebugTargetDesiredClass = 0x0418;

		///<summary>AActor *</summary>
		public const int ShowDebugTargetActor = 0x0420;

		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData02 = 0x0428;

	}

	public class UDataAsset
	{
		///<summary>UClass *</summary>
		public const int NativeClass = 0x0028;

	}

	public class UAnimNotify
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UActorComponent
	{
		///<summary>unsigned char[0xE8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FActorComponentTickFunction</summary>
		public const int PrimaryComponentTick = 0x0110;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int ComponentTags = 0x0168;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0178;

		///<summary>unsigned char:3</summary>
		public const int UnknownData01 = 0x0188;

		///<summary>unsigned char:1</summary>
		public const int bReplicates = 0x0188;

		///<summary>unsigned char:1</summary>
		public const int bNetAddressable = 0x0188;

		///<summary>unsigned char:3</summary>
		public const int UnknownData02 = 0x0188;

		///<summary>unsigned char:7</summary>
		public const int UnknownData03 = 0x0189;

		///<summary>unsigned char:1</summary>
		public const int bCreatedByConstructionScript = 0x0189;

		///<summary>unsigned char:1</summary>
		public const int bInstanceComponent = 0x018A;

		///<summary>unsigned char:1</summary>
		public const int bAutoActivate = 0x018A;

		///<summary>unsigned char:1</summary>
		public const int bIsActive = 0x018A;

		///<summary>unsigned char:1</summary>
		public const int bEditableWhenInherited = 0x018A;

		///<summary>unsigned char:1</summary>
		public const int UnknownData04 = 0x018A;

		///<summary>unsigned char:1</summary>
		public const int bCanEverAffectNavigation = 0x018A;

		///<summary>unsigned char:2</summary>
		public const int UnknownData05 = 0x018A;

		///<summary>unsigned char:1</summary>
		public const int bIsEditorOnly = 0x018B;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData06 = 0x018C;

		///<summary>EComponentCreationMethod</summary>
		public const int CreationMethod = 0x0191;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData07 = 0x0192;

		///<summary>TArray&lt;FSimpleMemberReference&gt;</summary>
		public const int UCSModifiedProperties = 0x01A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentActivated = 0x01B0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentDeactivated = 0x01C0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData08 = 0x01D0;

	}

	public class USceneComponent
	{
		///<summary>TArray&lt;USceneComponent * &gt;</summary>
		public const int AttachChildren = 0x01E0;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x01F0;

		///<summary>FName</summary>
		public const int AttachSocketName = 0x0240;

		///<summary>unsigned char:1</summary>
		public const int UnknownData01 = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bReplicatesAttachmentReference = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bReplicatesAttachment = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bWorldToComponentUpdated = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bAbsoluteLocation = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bAbsoluteRotation = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bAbsoluteScale = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bVisible = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bHiddenInGame = 0x0249;

		///<summary>unsigned char:1</summary>
		public const int bShouldUpdatePhysicsVolume = 0x0249;

		///<summary>unsigned char:1</summary>
		public const int bBoundsChangeTriggersStreamingDataRebuild = 0x0249;

		///<summary>unsigned char:1</summary>
		public const int bUseAttachParentBound = 0x0249;

		///<summary>unsigned char:4</summary>
		public const int UnknownData02 = 0x0249;

		///<summary>unsigned char:1</summary>
		public const int bAbsoluteTranslation = 0x024A;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData03 = 0x024B;

		///<summary>TWeakObjectPtr&lt;APhysicsVolume&gt;</summary>
		public const int PhysicsVolume = 0x024C;

		///<summary>unsigned char[0x7C]</summary>
		public const int UnknownData04 = 0x0254;

		///<summary>FVector</summary>
		public const int RelativeLocation = 0x02D0;

		///<summary>FRotator</summary>
		public const int RelativeRotation = 0x02DC;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData05 = 0x02E8;

		///<summary>FVector</summary>
		public const int RelativeScale3D = 0x0310;

		///<summary>FVector</summary>
		public const int RelativeTranslation = 0x031C;

		///<summary>TEnumAsByte&lt;EComponentMobility&gt;</summary>
		public const int Mobility = 0x0328;

		///<summary>TEnumAsByte&lt;EDetailMode&gt;</summary>
		public const int DetailMode = 0x0329;

		///<summary>unsigned char[0x1E]</summary>
		public const int UnknownData06 = 0x032A;

		///<summary>FVector</summary>
		public const int ComponentVelocity = 0x0348;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x0354;

		///<summary>FScriptMulticastDelegate</summary>
		public const int PhysicsVolumeChangedDelegate = 0x0358;

		///<summary>unsigned char[0x88]</summary>
		public const int UnknownData08 = 0x0368;

	}

	public class UPrimitiveComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03F0;

		///<summary>float</summary>
		public const int MinDrawDistance = 0x03F8;

		///<summary>float</summary>
		public const int LDMaxDrawDistance = 0x03FC;

		///<summary>float</summary>
		public const int CachedMaxDrawDistance = 0x0400;

		///<summary>TEnumAsByte&lt;ESceneDepthPriorityGroup&gt;</summary>
		public const int DepthPriorityGroup = 0x0404;

		///<summary>TEnumAsByte&lt;ESceneDepthPriorityGroup&gt;</summary>
		public const int ViewOwnerDepthPriorityGroup = 0x0405;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0406;

		///<summary>unsigned char:3</summary>
		public const int UnknownData02 = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysCreatePhysicsState = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bGenerateOverlapEvents = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bMultiBodyOverlap = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bCheckAsyncSceneOnMove = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bTraceComplexOnMove = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bReturnMaterialOnMove = 0x0409;

		///<summary>unsigned char:1</summary>
		public const int bUseViewOwnerDepthPriorityGroup = 0x0409;

		///<summary>unsigned char:1</summary>
		public const int bAllowCullDistanceVolume = 0x0409;

		///<summary>unsigned char:1</summary>
		public const int bImportantMesh = 0x0409;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x040A;

		///<summary>float</summary>
		public const int HLODScreenSize = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int bHasMotionBlurVelocityMeshes = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bVisibleInReflectionCaptures = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bRenderInMainPass = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bRenderInMono = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bReceivesDecals = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bOwnerNoSee = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bOnlyOwnerSee = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bTreatAsBackgroundForOcclusion = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bUseAsOccluder = 0x0411;

		///<summary>unsigned char:1</summary>
		public const int bSelectable = 0x0411;

		///<summary>unsigned char:1</summary>
		public const int bForceMipStreaming = 0x0411;

		///<summary>unsigned char:1</summary>
		public const int bHasPerInstanceHitProxies = 0x0411;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x0412;

		///<summary>TEnumAsByte&lt;EIndoorOutdoorMask&gt;</summary>
		public const int IndoorOutdoorMask = 0x0414;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0415;

		///<summary>unsigned char:1</summary>
		public const int CastShadow = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bAffectDynamicIndirectLighting = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bAffectDistanceFieldLighting = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bCastDynamicShadow = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bCastStaticShadow = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bCastVolumetricTranslucentShadow = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bSelfShadowOnly = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bCastFarShadow = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bCastInsetShadow = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bCastCinematicShadow = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bCastHiddenShadow = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bCastShadowAsTwoSided = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bLightAsIfStatic = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bLightAttachmentsAsGroup = 0x0419;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData06 = 0x041A;

		///<summary>TEnumAsByte&lt;EIndirectLightingCacheQuality&gt;</summary>
		public const int IndirectLightingCacheQuality = 0x041C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x041D;

		///<summary>unsigned char:1</summary>
		public const int bReceiveCombinedCSMAndStaticShadowsFromStationaryLights = 0x0420;

		///<summary>unsigned char:1</summary>
		public const int bSingleSampleShadowFromStationaryLights = 0x0420;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0421;

		///<summary>FLightingChannels</summary>
		public const int LightingChannels = 0x0424;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData09 = 0x0427;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreRadialImpulse = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreRadialForce = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bApplyImpulseOnDamage = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int AlwaysLoadOnClient = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int AlwaysLoadOnServer = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bUseEditorCompositing = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bRenderCustomDepth = 0x0428;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x0429;

		///<summary>int</summary>
		public const int CustomDepthStencilValue = 0x042C;

		///<summary>ERendererStencilMask</summary>
		public const int CustomDepthStencilWriteMask = 0x0430;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData11 = 0x0431;

		///<summary>int</summary>
		public const int TranslucencySortPriority = 0x0434;

		///<summary>int</summary>
		public const int VisibilityId = 0x0438;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData12 = 0x043C;

		///<summary>float</summary>
		public const int LpvBiasMultiplier = 0x0440;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData13 = 0x0444;

		///<summary>FBodyInstance</summary>
		public const int BodyInstance = 0x0450;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData14 = 0x0690;

		///<summary>TEnumAsByte&lt;EHasCustomNavigableGeometry&gt;</summary>
		public const int bHasCustomNavigableGeometry = 0x0698;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData15 = 0x0699;

		///<summary>float</summary>
		public const int BoundsScale = 0x069C;

		///<summary>float</summary>
		public const int LastSubmitTime = 0x06A0;

		///<summary>float</summary>
		public const int LastRenderTime = 0x06A4;

		///<summary>float</summary>
		public const int LastRenderTimeOnScreen = 0x06A8;

		///<summary>TEnumAsByte&lt;ECanBeCharacterBase&gt;</summary>
		public const int CanBeCharacterBase = 0x06AC;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData16 = 0x06AD;

		///<summary>TEnumAsByte&lt;ECanBeCharacterBase&gt;</summary>
		public const int CanCharacterStepUpOn = 0x06AE;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData17 = 0x06AF;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int MoveIgnoreActors = 0x06B0;

		///<summary>TArray&lt;UPrimitiveComponent * &gt;</summary>
		public const int MoveIgnoreComponents = 0x06C0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData18 = 0x06D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentHit = 0x06E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentBeginOverlap = 0x06F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentEndOverlap = 0x0700;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentWake = 0x0710;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentSleep = 0x0720;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData19 = 0x0730;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnBeginCursorOver = 0x0740;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEndCursorOver = 0x0750;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnClicked = 0x0760;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnReleased = 0x0770;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchBegin = 0x0780;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchEnd = 0x0790;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchEnter = 0x07A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInputTouchLeave = 0x07B0;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData20 = 0x07C0;

		///<summary>UPrimitiveComponent *</summary>
		public const int LODParentPrimitive = 0x07E8;

		///<summary>FPrimitiveComponentPostPhysicsTickFunction</summary>
		public const int PostPhysicsComponentTick = 0x07F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData21 = 0x0848;

	}

	public class UMeshComponent
	{
		///<summary>unsigned char[0x100]</summary>
		public const int UnknownData00 = 0x0850;

	}

	public class UStaticMeshComponent
	{
		///<summary>int</summary>
		public const int ForcedLodModel = 0x0950;

		///<summary>int</summary>
		public const int PreviousLODLevel = 0x0954;

		///<summary>bool</summary>
		public const int bOverrideMinLOD = 0x0958;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0959;

		///<summary>int</summary>
		public const int MinLOD = 0x095C;

		///<summary>UStaticMesh *</summary>
		public const int StaticMesh = 0x0960;

		///<summary>bool</summary>
		public const int bOverrideWireframeColor = 0x0968;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0969;

		///<summary>FColor</summary>
		public const int WireframeColorOverride = 0x096C;

		///<summary>unsigned char:1</summary>
		public const int bOverrideNavigationExport = 0x0970;

		///<summary>unsigned char:1</summary>
		public const int bForceNavigationObstacle = 0x0970;

		///<summary>unsigned char:1</summary>
		public const int bDisallowMeshPaintPerInstance = 0x0970;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreInstanceForTextureStreaming = 0x0970;

		///<summary>unsigned char:1</summary>
		public const int bOverrideLightMapRes = 0x0970;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0971;

		///<summary>int</summary>
		public const int OverriddenLightMapRes = 0x0974;

		///<summary>unsigned char:1</summary>
		public const int bCastDistanceFieldIndirectShadow = 0x0978;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0979;

		///<summary>float</summary>
		public const int DistanceFieldIndirectShadowMinVisibility = 0x097C;

		///<summary>float</summary>
		public const int StreamingDistanceMultiplier = 0x0980;

		///<summary>int</summary>
		public const int SubDivisionStepSize = 0x0984;

		///<summary>unsigned char:1</summary>
		public const int bUseSubDivisions = 0x0988;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0989;

		///<summary>TArray&lt;FGuid&gt;</summary>
		public const int IrrelevantLights = 0x0990;

		///<summary>TArray&lt;FStaticMeshComponentLODInfo&gt;</summary>
		public const int LODData = 0x09A0;

		///<summary>TArray&lt;FStreamingTextureBuildInfo&gt;</summary>
		public const int StreamingTextureData = 0x09B0;

		///<summary>bool</summary>
		public const int bUseDefaultCollision = 0x09C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x09C1;

		///<summary>FLightmassPrimitiveSettings</summary>
		public const int LightmassSettings = 0x09C4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x09DC;

	}

	public class AController
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>APawn *</summary>
		public const int Pawn = 0x03B8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03C0;

		///<summary>ACharacter *</summary>
		public const int Character = 0x03C8;

		///<summary>APlayerState *</summary>
		public const int PlayerState = 0x03D0;

		///<summary>USceneComponent *</summary>
		public const int TransformComponent = 0x03D8;

		///<summary>FRotator</summary>
		public const int ControlRotation = 0x03E0;

		///<summary>unsigned char:1</summary>
		public const int bAttachToPawn = 0x03EC;

		///<summary>unsigned char:1</summary>
		public const int bIsPlayerController = 0x03EC;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData02 = 0x03ED;

		///<summary>FName</summary>
		public const int StateName = 0x0400;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInstigatedAnyDamage = 0x0408;

	}

	public class APlayerController
	{
		///<summary>UPlayer *</summary>
		public const int Player = 0x0418;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0420;

		///<summary>APawn *</summary>
		public const int AcknowledgedPawn = 0x0428;

		///<summary>UInterpTrackInstDirector *</summary>
		public const int ControllingDirTrackInst = 0x0430;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0438;

		///<summary>AHUD *</summary>
		public const int MyHUD = 0x0440;

		///<summary>APlayerCameraManager *</summary>
		public const int PlayerCameraManager = 0x0448;

		///<summary>UClass *</summary>
		public const int PlayerCameraManagerClass = 0x0450;

		///<summary>bool</summary>
		public const int bAutoManageActiveCameraTarget = 0x0458;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0459;

		///<summary>FRotator</summary>
		public const int TargetViewRotation = 0x045C;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData03 = 0x0468;

		///<summary>float</summary>
		public const int SmoothTargetViewRotationSpeed = 0x0474;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int HiddenActors = 0x0478;

		///<summary>float</summary>
		public const int LastSpectatorStateSynchTime = 0x0488;

		///<summary>FVector</summary>
		public const int LastSpectatorSyncLocation = 0x048C;

		///<summary>FRotator</summary>
		public const int LastSpectatorSyncRotation = 0x0498;

		///<summary>int</summary>
		public const int ClientCap = 0x04A4;

		///<summary>UCheatManager *</summary>
		public const int CheatManager = 0x04A8;

		///<summary>UClass *</summary>
		public const int CheatClass = 0x04B0;

		///<summary>UPlayerInput *</summary>
		public const int PlayerInput = 0x04B8;

		///<summary>TArray&lt;FActiveForceFeedbackEffect&gt;</summary>
		public const int ActiveForceFeedbackEffects = 0x04C0;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData04 = 0x04D0;

		///<summary>unsigned char:3</summary>
		public const int UnknownData05 = 0x0560;

		///<summary>unsigned char:1</summary>
		public const int bPlayerIsWaiting = 0x0560;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0561;

		///<summary>unsigned char</summary>
		public const int NetPlayerIndex = 0x0564;

		///<summary>unsigned char[0x3B]</summary>
		public const int UnknownData07 = 0x0565;

		///<summary>UNetConnection *</summary>
		public const int PendingSwapConnection = 0x05A0;

		///<summary>UNetConnection *</summary>
		public const int NetConnection = 0x05A8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData08 = 0x05B0;

		///<summary>float</summary>
		public const int InputYawScale = 0x05BC;

		///<summary>float</summary>
		public const int InputPitchScale = 0x05C0;

		///<summary>float</summary>
		public const int InputRollScale = 0x05C4;

		///<summary>unsigned char:1</summary>
		public const int bShowMouseCursor = 0x05C8;

		///<summary>unsigned char:1</summary>
		public const int bEnableClickEvents = 0x05C8;

		///<summary>unsigned char:1</summary>
		public const int bEnableTouchEvents = 0x05C8;

		///<summary>unsigned char:1</summary>
		public const int bEnableMouseOverEvents = 0x05C8;

		///<summary>unsigned char:1</summary>
		public const int bEnableTouchOverEvents = 0x05C8;

		///<summary>unsigned char:1</summary>
		public const int bForceFeedbackEnabled = 0x05C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData09 = 0x05C9;

		///<summary>TArray&lt;FKey&gt;</summary>
		public const int ClickEventKeys = 0x05D0;

		///<summary>TEnumAsByte&lt;EMouseCursor&gt;</summary>
		public const int DefaultMouseCursor = 0x05E0;

		///<summary>TEnumAsByte&lt;EMouseCursor&gt;</summary>
		public const int CurrentMouseCursor = 0x05E1;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int DefaultClickTraceChannel = 0x05E2;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int CurrentClickTraceChannel = 0x05E3;

		///<summary>float</summary>
		public const int HitResultTraceDistance = 0x05E4;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData10 = 0x05E8;

		///<summary>UInputComponent *</summary>
		public const int InactiveStateInputComponent = 0x0668;

		///<summary>unsigned char:3</summary>
		public const int UnknownData11 = 0x0670;

		///<summary>unsigned char:1</summary>
		public const int bShouldPerformFullTickWhenPaused = 0x0670;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData12 = 0x0671;

		///<summary>UTouchInterface *</summary>
		public const int CurrentTouchInterface = 0x0688;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData13 = 0x0690;

		///<summary>ASpectatorPawn *</summary>
		public const int SpectatorPawn = 0x06D0;

		///<summary>FVector</summary>
		public const int SpawnLocation = 0x06D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData14 = 0x06E4;

		///<summary>bool</summary>
		public const int bIsLocalPlayerController = 0x06E8;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData15 = 0x06E9;

		///<summary>uint16_t</summary>
		public const int SeamlessTravelCount = 0x06EA;

		///<summary>uint16_t</summary>
		public const int LastCompletedSeamlessTravelCount = 0x06EC;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData16 = 0x06EE;

	}

	public class APawn
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bUseControllerRotationPitch = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bUseControllerRotationYaw = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bUseControllerRotationRoll = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bCanAffectNavigationGeneration = 0x03B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03B9;

		///<summary>float</summary>
		public const int BaseEyeHeight = 0x03BC;

		///<summary>TEnumAsByte&lt;EAutoReceiveInput&gt;</summary>
		public const int AutoPossessPlayer = 0x03C0;

		///<summary>EAutoPossessAI</summary>
		public const int AutoPossessAI = 0x03C1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x03C2;

		///<summary>UClass *</summary>
		public const int AIControllerClass = 0x03C8;

		///<summary>APlayerState *</summary>
		public const int PlayerState = 0x03D0;

		///<summary>uint16_t</summary>
		public const int RemoteViewPitch = 0x03D8;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData03 = 0x03DA;

		///<summary>AController *</summary>
		public const int LastHitBy = 0x03E0;

		///<summary>AController *</summary>
		public const int Controller = 0x03E8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x03F0;

		///<summary>FVector</summary>
		public const int ControlInputVector = 0x03F8;

		///<summary>FVector</summary>
		public const int LastControlInputVector = 0x0404;

	}

	public class ACharacter
	{
		///<summary>USkeletalMeshComponent *</summary>
		public const int Mesh = 0x0410;

		///<summary>UCharacterMovementComponent *</summary>
		public const int CharacterMovement = 0x0418;

		///<summary>UCapsuleComponent *</summary>
		public const int CapsuleComponent = 0x0420;

		///<summary>UCapsuleComponent *</summary>
		public const int ProneCapsuleComponent = 0x0428;

		///<summary>FBasedMovementInfo</summary>
		public const int BasedMovement = 0x0430;

		///<summary>FBasedMovementInfo</summary>
		public const int ReplicatedBasedMovement = 0x0460;

		///<summary>float</summary>
		public const int AnimRootMotionTranslationScale = 0x0490;

		///<summary>FVector</summary>
		public const int BaseTranslationOffset = 0x0494;

		///<summary>FQuat</summary>
		public const int BaseRotationOffset = 0x04A0;

		///<summary>float</summary>
		public const int ReplicatedServerLastTransformUpdateTimeStamp = 0x04B0;

		///<summary>unsigned char</summary>
		public const int ReplicatedMovementMode = 0x04B4;

		///<summary>bool</summary>
		public const int bInBaseReplication = 0x04B5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x04B6;

		///<summary>float</summary>
		public const int CrouchedEyeHeight = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bIsCrouched = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bPressedJump = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bClientUpdating = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bClientWasFalling = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bClientResimulateRootMotion = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bClientResimulateRootMotionSources = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bSimGravityDisabled = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bClientCheckEncroachmentOnNetUpdate = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bServerMoveIgnoreRootMotion = 0x04BD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x04BE;

		///<summary>float</summary>
		public const int JumpKeyHoldTime = 0x04C0;

		///<summary>float</summary>
		public const int JumpMaxHoldTime = 0x04C4;

		///<summary>int</summary>
		public const int JumpMaxCount = 0x04C8;

		///<summary>int</summary>
		public const int JumpCurrentCount = 0x04CC;

		///<summary>unsigned char:1</summary>
		public const int UnknownData02 = 0x04D0;

		///<summary>unsigned char:1</summary>
		public const int bWasJumping = 0x04D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x04D1;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnReachedJumpApex = 0x04D8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x04E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int MovementModeChangedDelegate = 0x04F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCharacterMovementUpdated = 0x0508;

		///<summary>FRootMotionSourceGroup</summary>
		public const int SavedRootMotion = 0x0518;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x0618;

		///<summary>FRootMotionMovementParams</summary>
		public const int ClientRootMotionParams = 0x0620;

		///<summary>TArray&lt;FSimulatedRootMotionReplicatedMove&gt;</summary>
		public const int RootMotionRepMoves = 0x0660;

		///<summary>FRepRootMotionMontage</summary>
		public const int RepRootMotion = 0x0670;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData06 = 0x07D0;

	}

	public class UMovementComponent
	{
		///<summary>UPrimitiveComponent *</summary>
		public const int UpdatedPrimitive = 0x01E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x01E8;

		///<summary>FVector</summary>
		public const int Velocity = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bConstrainToPlane = 0x01F8;

		///<summary>unsigned char:1</summary>
		public const int bSnapToPlaneAtStart = 0x01F8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x01F9;

		///<summary>EPlaneConstraintAxisSetting</summary>
		public const int PlaneConstraintAxisSetting = 0x01FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x01FD;

		///<summary>FVector</summary>
		public const int PlaneConstraintNormal = 0x0200;

		///<summary>FVector</summary>
		public const int PlaneConstraintOrigin = 0x020C;

		///<summary>unsigned char:1</summary>
		public const int bUpdateOnlyIfRendered = 0x0218;

		///<summary>unsigned char:1</summary>
		public const int bAutoUpdateTickRegistration = 0x0218;

		///<summary>unsigned char:1</summary>
		public const int bTickBeforeOwner = 0x0218;

		///<summary>unsigned char:1</summary>
		public const int bAutoRegisterUpdatedComponent = 0x0218;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0219;

	}

	public class UNavMovementComponent
	{
		///<summary>FNavAgentProperties</summary>
		public const int NavAgentProps = 0x0220;

		///<summary>float</summary>
		public const int FixedPathBrakingDistance = 0x0240;

		///<summary>unsigned char:1</summary>
		public const int bUpdateNavAgentWithOwnersCollision = 0x0244;

		///<summary>unsigned char:1</summary>
		public const int bUseAccelerationForPaths = 0x0244;

		///<summary>unsigned char:1</summary>
		public const int bUseFixedBrakingDistanceForPaths = 0x0244;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0245;

		///<summary>FMovementProperties</summary>
		public const int MovementState = 0x0248;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData01 = 0x024C;

	}

	public class USpringArmComponent
	{
		///<summary>float</summary>
		public const int TargetArmLength = 0x03F0;

		///<summary>FVector</summary>
		public const int SocketOffset = 0x03F4;

		///<summary>FVector</summary>
		public const int TargetOffset = 0x0400;

		///<summary>float</summary>
		public const int ProbeSize = 0x040C;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int ProbeChannel = 0x0410;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0411;

		///<summary>unsigned char:1</summary>
		public const int bDoCollisionTest = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bUsePawnControlRotation = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bInheritPitch = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bInheritYaw = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bInheritRoll = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bEnableCameraLag = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bEnableCameraRotationLag = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bUseCameraLagSubstepping = 0x0414;

		///<summary>unsigned char:1</summary>
		public const int bDrawDebugLagMarkers = 0x0415;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0416;

		///<summary>float</summary>
		public const int CameraLagSpeed = 0x0418;

		///<summary>float</summary>
		public const int CameraRotationLagSpeed = 0x041C;

		///<summary>float</summary>
		public const int CameraLagMaxTimeStep = 0x0420;

		///<summary>float</summary>
		public const int CameraLagMaxDistance = 0x0424;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData02 = 0x0428;

	}

	public class ANavigationObjectBase
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>UCapsuleComponent *</summary>
		public const int CapsuleComponent = 0x03B8;

		///<summary>UBillboardComponent *</summary>
		public const int GoodSprite = 0x03C0;

		///<summary>UBillboardComponent *</summary>
		public const int BadSprite = 0x03C8;

		///<summary>unsigned char:1</summary>
		public const int bIsPIEPlayerStart = 0x03D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03D1;

	}

	public class APlayerStart
	{
		///<summary>FName</summary>
		public const int PlayerStartTag = 0x03D8;

	}

	public class ABrush
	{
		///<summary>TEnumAsByte&lt;EBrushType&gt;</summary>
		public const int BrushType = 0x03B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03B1;

		///<summary>FColor</summary>
		public const int BrushColor = 0x03B4;

		///<summary>int</summary>
		public const int PolyFlags = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bColored = 0x03BC;

		///<summary>unsigned char:1</summary>
		public const int bSolidWhenSelected = 0x03BC;

		///<summary>unsigned char:1</summary>
		public const int bPlaceableFromClassBrowser = 0x03BC;

		///<summary>unsigned char:1</summary>
		public const int bNotForClientOrServer = 0x03BC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03BD;

		///<summary>UModel *</summary>
		public const int Brush = 0x03C0;

		///<summary>UBrushComponent *</summary>
		public const int BrushComponent = 0x03C8;

		///<summary>unsigned char:1</summary>
		public const int bInManipulation = 0x03D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x03D1;

		///<summary>TArray&lt;FGeomSelection&gt;</summary>
		public const int SavedSelections = 0x03D8;

	}

	public class UCharacterMovementComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0260;

		///<summary>ACharacter *</summary>
		public const int CharacterOwner = 0x0270;

		///<summary>unsigned char:1</summary>
		public const int bApplyGravityWhileJumping = 0x0278;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0279;

		///<summary>float</summary>
		public const int GravityScale = 0x027C;

		///<summary>float</summary>
		public const int MaxStepHeight = 0x0280;

		///<summary>float</summary>
		public const int JumpZVelocity = 0x0284;

		///<summary>float</summary>
		public const int JumpOffJumpZFactor = 0x0288;

		///<summary>float</summary>
		public const int WalkableFloorAngle = 0x028C;

		///<summary>float</summary>
		public const int WalkableFloorZ = 0x0290;

		///<summary>float</summary>
		public const int ProneWalkableFloorAngle = 0x0294;

		///<summary>float</summary>
		public const int ProneWalkableFloorZ = 0x0298;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x029C;

		///<summary>TEnumAsByte&lt;EMovementMode&gt;</summary>
		public const int MovementMode = 0x02A0;

		///<summary>unsigned char</summary>
		public const int CustomMovementMode = 0x02A1;

		///<summary>unsigned char[0x1E]</summary>
		public const int UnknownData03 = 0x02A2;

		///<summary>float</summary>
		public const int GroundFriction = 0x02C0;

		///<summary>float</summary>
		public const int MaxWalkSpeed = 0x02C4;

		///<summary>float</summary>
		public const int MaxWalkSpeedCrouched = 0x02C8;

		///<summary>float</summary>
		public const int MaxSwimSpeed = 0x02CC;

		///<summary>float</summary>
		public const int MaxFlySpeed = 0x02D0;

		///<summary>float</summary>
		public const int MaxCustomMovementSpeed = 0x02D4;

		///<summary>float</summary>
		public const int MaxAcceleration = 0x02D8;

		///<summary>float</summary>
		public const int BrakingFrictionFactor = 0x02DC;

		///<summary>float</summary>
		public const int BrakingFriction = 0x02E0;

		///<summary>unsigned char:1</summary>
		public const int bUseSeparateBrakingFriction = 0x02E4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x02E5;

		///<summary>float</summary>
		public const int BrakingDecelerationWalking = 0x02E8;

		///<summary>float</summary>
		public const int BrakingDecelerationFalling = 0x02EC;

		///<summary>float</summary>
		public const int BrakingDecelerationSwimming = 0x02F0;

		///<summary>float</summary>
		public const int BrakingDecelerationFlying = 0x02F4;

		///<summary>float</summary>
		public const int AirControl = 0x02F8;

		///<summary>float</summary>
		public const int AirControlBoostMultiplier = 0x02FC;

		///<summary>float</summary>
		public const int AirControlBoostVelocityThreshold = 0x0300;

		///<summary>float</summary>
		public const int FallingLateralFriction = 0x0304;

		///<summary>float</summary>
		public const int CrouchedHalfHeight = 0x0308;

		///<summary>float</summary>
		public const int PronedHalfHeight = 0x030C;

		///<summary>float</summary>
		public const int PronedRadius = 0x0310;

		///<summary>float</summary>
		public const int Buoyancy = 0x0314;

		///<summary>float</summary>
		public const int PerchRadiusThreshold = 0x0318;

		///<summary>float</summary>
		public const int PerchAdditionalHeight = 0x031C;

		///<summary>FRotator</summary>
		public const int RotationRate = 0x0320;

		///<summary>unsigned char:1</summary>
		public const int bUseControllerDesiredRotation = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bOrientRotationToMovement = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bSweepWhileNavWalking = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int UnknownData05 = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bMovementInProgress = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bEnableScopedMovementUpdates = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bForceMaxAccel = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bRunPhysicsWithNoController = 0x032C;

		///<summary>unsigned char:1</summary>
		public const int bForceNextFloorCheck = 0x032D;

		///<summary>unsigned char:1</summary>
		public const int bShrinkProxyCapsule = 0x032D;

		///<summary>unsigned char:1</summary>
		public const int bCanWalkOffLedges = 0x032D;

		///<summary>unsigned char:1</summary>
		public const int bCanWalkOffLedgesWhenCrouching = 0x032D;

		///<summary>unsigned char:1</summary>
		public const int UnknownData06 = 0x032D;

		///<summary>unsigned char:1</summary>
		public const int bDeferUpdateMoveComponent = 0x032D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData07 = 0x032E;

		///<summary>USceneComponent *</summary>
		public const int DeferredUpdatedMoveComponent = 0x0330;

		///<summary>float</summary>
		public const int MaxOutOfWaterStepHeight = 0x0338;

		///<summary>float</summary>
		public const int OutofWaterZ = 0x033C;

		///<summary>float</summary>
		public const int Mass = 0x0340;

		///<summary>bool</summary>
		public const int bEnablePhysicsInteraction = 0x0344;

		///<summary>bool</summary>
		public const int bTouchForceScaledToMass = 0x0345;

		///<summary>bool</summary>
		public const int bPushForceScaledToMass = 0x0346;

		///<summary>bool</summary>
		public const int bPushForceUsingZOffset = 0x0347;

		///<summary>bool</summary>
		public const int bScalePushForceToVelocity = 0x0348;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0349;

		///<summary>float</summary>
		public const int StandingDownwardForceScale = 0x034C;

		///<summary>float</summary>
		public const int InitialPushForceFactor = 0x0350;

		///<summary>float</summary>
		public const int PushForceFactor = 0x0354;

		///<summary>float</summary>
		public const int PushForcePointZOffsetFactor = 0x0358;

		///<summary>float</summary>
		public const int TouchForceFactor = 0x035C;

		///<summary>float</summary>
		public const int MinTouchForce = 0x0360;

		///<summary>float</summary>
		public const int MaxTouchForce = 0x0364;

		///<summary>float</summary>
		public const int RepulsionForce = 0x0368;

		///<summary>unsigned char:1</summary>
		public const int bForceBraking = 0x036C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x036D;

		///<summary>float</summary>
		public const int CrouchedSpeedMultiplier = 0x0370;

		///<summary>float</summary>
		public const int UpperImpactNormalScale = 0x0374;

		///<summary>FVector</summary>
		public const int Acceleration = 0x0378;

		///<summary>FVector</summary>
		public const int LastUpdateLocation = 0x0384;

		///<summary>FQuat</summary>
		public const int LastUpdateRotation = 0x0390;

		///<summary>FVector</summary>
		public const int LastUpdateVelocity = 0x03A0;

		///<summary>float</summary>
		public const int ServerLastTransformUpdateTimeStamp = 0x03AC;

		///<summary>FVector</summary>
		public const int PendingImpulseToApply = 0x03B0;

		///<summary>FVector</summary>
		public const int PendingForceToApply = 0x03BC;

		///<summary>float</summary>
		public const int AnalogInputModifier = 0x03C8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData10 = 0x03CC;

		///<summary>float</summary>
		public const int MaxSimulationTimeStep = 0x03D4;

		///<summary>int</summary>
		public const int MaxSimulationIterations = 0x03D8;

		///<summary>float</summary>
		public const int MaxDepenetrationWithGeometry = 0x03DC;

		///<summary>float</summary>
		public const int MaxDepenetrationWithGeometryAsProxy = 0x03E0;

		///<summary>float</summary>
		public const int MaxDepenetrationWithPawn = 0x03E4;

		///<summary>float</summary>
		public const int MaxDepenetrationWithPawnAsProxy = 0x03E8;

		///<summary>float</summary>
		public const int NetworkSimulatedSmoothLocationTime = 0x03EC;

		///<summary>float</summary>
		public const int NetworkSimulatedSmoothRotationTime = 0x03F0;

		///<summary>float</summary>
		public const int ListenServerNetworkSimulatedSmoothLocationTime = 0x03F4;

		///<summary>float</summary>
		public const int ListenServerNetworkSimulatedSmoothRotationTime = 0x03F8;

		///<summary>float</summary>
		public const int NetProxyShrinkRadius = 0x03FC;

		///<summary>float</summary>
		public const int NetProxyShrinkHalfHeight = 0x0400;

		///<summary>float</summary>
		public const int NetworkMaxSmoothUpdateDistance = 0x0404;

		///<summary>float</summary>
		public const int NetworkNoSmoothUpdateDistance = 0x0408;

		///<summary>ENetworkSmoothingMode</summary>
		public const int NetworkSmoothingMode = 0x040C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData11 = 0x040D;

		///<summary>float</summary>
		public const int LedgeCheckThreshold = 0x0410;

		///<summary>float</summary>
		public const int JumpOutOfWaterPitch = 0x0414;

		///<summary>FFindFloorResult</summary>
		public const int CurrentFloor = 0x0418;

		///<summary>TEnumAsByte&lt;EMovementMode&gt;</summary>
		public const int DefaultLandMovementMode = 0x04B0;

		///<summary>TEnumAsByte&lt;EMovementMode&gt;</summary>
		public const int DefaultWaterMovementMode = 0x04B1;

		///<summary>TEnumAsByte&lt;EMovementMode&gt;</summary>
		public const int GroundMovementMode = 0x04B2;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData12 = 0x04B3;

		///<summary>unsigned char:1</summary>
		public const int bMaintainHorizontalGroundVelocity = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bImpartBaseVelocityX = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bImpartBaseVelocityY = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bImpartBaseVelocityZ = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bImpartBaseAngularVelocity = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bJustTeleported = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bNetworkUpdateReceived = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bNetworkMovementModeChanged = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreClientMovementErrorChecksAndCorrection = 0x04B5;

		///<summary>unsigned char:1</summary>
		public const int bNotifyApex = 0x04B5;

		///<summary>unsigned char:1</summary>
		public const int bCheatFlying = 0x04B5;

		///<summary>unsigned char:1</summary>
		public const int bWantsToCrouch = 0x04B5;

		///<summary>unsigned char:1</summary>
		public const int bCrouchMaintainsBaseLocation = 0x04B5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData13 = 0x04B6;

		///<summary>TEnumAsByte&lt;EStanceMode&gt;</summary>
		public const int StanceMode = 0x04B8;

		///<summary>TEnumAsByte&lt;EStanceMode&gt;</summary>
		public const int WantsToStanceMode = 0x04B9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData14 = 0x04BA;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreBaseRotation = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bFastAttachedMove = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysCheckFloor = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bUseFlatBaseForFloorChecks = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bPerformingJumpOff = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bWantsToLeaveNavWalking = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bUseRVOAvoidance = 0x04BC;

		///<summary>unsigned char:1</summary>
		public const int bRequestedMoveUseAcceleration = 0x04BC;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData15 = 0x04BD;

		///<summary>unsigned char:1</summary>
		public const int bHasRequestedVelocity = 0x04CC;

		///<summary>unsigned char:1</summary>
		public const int bRequestedMoveWithMaxSpeed = 0x04CC;

		///<summary>unsigned char:1</summary>
		public const int bWasAvoidanceUpdated = 0x04CC;

		///<summary>unsigned char:2</summary>
		public const int UnknownData16 = 0x04CC;

		///<summary>unsigned char:1</summary>
		public const int bProjectNavMeshWalking = 0x04CC;

		///<summary>unsigned char:1</summary>
		public const int bProjectNavMeshOnBothWorldChannels = 0x04CC;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData17 = 0x04CD;

		///<summary>float</summary>
		public const int AvoidanceConsiderationRadius = 0x04E0;

		///<summary>FVector</summary>
		public const int RequestedVelocity = 0x04E4;

		///<summary>int</summary>
		public const int AvoidanceUID = 0x04F0;

		///<summary>FNavAvoidanceMask</summary>
		public const int AvoidanceGroup = 0x04F4;

		///<summary>FNavAvoidanceMask</summary>
		public const int GroupsToAvoid = 0x04F8;

		///<summary>FNavAvoidanceMask</summary>
		public const int GroupsToIgnore = 0x04FC;

		///<summary>float</summary>
		public const int AvoidanceWeight = 0x0500;

		///<summary>FVector</summary>
		public const int PendingLaunchVelocity = 0x0504;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData18 = 0x0510;

		///<summary>float</summary>
		public const int NavMeshProjectionInterval = 0x05B0;

		///<summary>float</summary>
		public const int NavMeshProjectionTimer = 0x05B4;

		///<summary>float</summary>
		public const int NavMeshProjectionInterpSpeed = 0x05B8;

		///<summary>float</summary>
		public const int NavMeshProjectionHeightScaleUp = 0x05BC;

		///<summary>float</summary>
		public const int NavMeshProjectionHeightScaleDown = 0x05C0;

		///<summary>float</summary>
		public const int NavWalkingFloorDistTolerance = 0x05C4;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData19 = 0x05C8;

		///<summary>FCharacterMovementComponentPostPhysicsTickFunction</summary>
		public const int PostPhysicsTickFunction = 0x05E0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData20 = 0x0638;

		///<summary>float</summary>
		public const int MinTimeBetweenTimeStampResets = 0x0648;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData21 = 0x064C;

		///<summary>FRootMotionSourceGroup</summary>
		public const int CurrentRootMotion = 0x0650;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData22 = 0x0750;

		///<summary>FRootMotionMovementParams</summary>
		public const int RootMotionParams = 0x07E0;

		///<summary>FVector</summary>
		public const int AnimRootMotionVelocity = 0x0820;

		///<summary>bool</summary>
		public const int bWasSimulatingRootMotion = 0x082C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData23 = 0x082D;

		///<summary>unsigned char:1</summary>
		public const int bAllowPhysicsRotationDuringAnimRootMotion = 0x0830;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData24 = 0x0831;

	}

	public class UAnimInstance
	{
		///<summary>float</summary>
		public const int DeltaTime = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

		///<summary>USkeleton *</summary>
		public const int CurrentSkeleton = 0x0030;

		///<summary>TEnumAsByte&lt;ERootMotionMode&gt;</summary>
		public const int RootMotionMode = 0x0038;

		///<summary>bool</summary>
		public const int bRunUpdatesInWorkerThreads = 0x0039;

		///<summary>bool</summary>
		public const int bCanUseParallelUpdateAnimation = 0x003A;

		///<summary>bool</summary>
		public const int bUseMultiThreadedAnimationUpdate = 0x003B;

		///<summary>bool</summary>
		public const int bWarnAboutBlueprintUsage = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x003D;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMontageBlendingOut = 0x0040;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMontageStarted = 0x0050;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMontageEnded = 0x0060;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnAllMontageInstancesEnded = 0x0070;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData02 = 0x0080;

		///<summary>bool</summary>
		public const int bQueueMontageEvents = 0x00E0;

		///<summary>unsigned char[0x9F]</summary>
		public const int UnknownData03 = 0x00E1;

		///<summary>TArray&lt;FAnimNotifyEvent&gt;</summary>
		public const int ActiveAnimNotifyState = 0x0180;

		///<summary>unsigned char[0x1E8]</summary>
		public const int UnknownData04 = 0x0190;

	}

	public class UDamageType
	{
		///<summary>unsigned char:1</summary>
		public const int bCausedByWorld = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bScaleMomentumByMass = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bRadialDamageVelChange = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>float</summary>
		public const int DamageImpulse = 0x002C;

		///<summary>float</summary>
		public const int DestructibleImpulse = 0x0030;

		///<summary>float</summary>
		public const int DestructibleDamageSpreadScale = 0x0034;

		///<summary>float</summary>
		public const int DamageFalloff = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x003C;

	}

	public class UGameInstance
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;ULocalPlayer * &gt;</summary>
		public const int LocalPlayers = 0x0038;

		///<summary>UOnlineSession *</summary>
		public const int OnlineSession = 0x0048;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData01 = 0x0050;

	}

	public class AStaticMeshActor
	{
		///<summary>UStaticMeshComponent *</summary>
		public const int StaticMeshComponent = 0x03B0;

		///<summary>bool</summary>
		public const int bStaticMeshReplicateMovement = 0x03B8;

		///<summary>ENavDataGatheringMode</summary>
		public const int NavigationGeometryGatheringMode = 0x03B9;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03BA;

	}

	public class UCameraComponent
	{
		///<summary>float</summary>
		public const int FieldOfView = 0x03F0;

		///<summary>float</summary>
		public const int OrthoWidth = 0x03F4;

		///<summary>float</summary>
		public const int OrthoNearClipPlane = 0x03F8;

		///<summary>float</summary>
		public const int OrthoFarClipPlane = 0x03FC;

		///<summary>float</summary>
		public const int AspectRatio = 0x0400;

		///<summary>unsigned char:1</summary>
		public const int bConstrainAspectRatio = 0x0404;

		///<summary>unsigned char:1</summary>
		public const int bUseFieldOfViewForLOD = 0x0404;

		///<summary>unsigned char:1</summary>
		public const int bLockToHmd = 0x0404;

		///<summary>unsigned char:1</summary>
		public const int bUsePawnControlRotation = 0x0404;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0405;

		///<summary>TEnumAsByte&lt;ECameraProjectionMode&gt;</summary>
		public const int ProjectionMode = 0x0408;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0409;

		///<summary>float</summary>
		public const int PostProcessBlendWeight = 0x040C;

		///<summary>FPostProcessSettings</summary>
		public const int PostProcessSettings = 0x0410;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData02 = 0x0940;

		///<summary>unsigned char:1</summary>
		public const int bUseControllerViewRotation = 0x0998;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0999;

	}

	public class UCheatManager
	{
		///<summary>ADebugCameraController *</summary>
		public const int DebugCameraControllerRef = 0x0028;

		///<summary>UClass *</summary>
		public const int DebugCameraControllerClass = 0x0030;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UEngine
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UFont *</summary>
		public const int TinyFont = 0x0030;

		///<summary>FStringAssetReference</summary>
		public const int TinyFontName = 0x0038;

		///<summary>UFont *</summary>
		public const int SmallFont = 0x0048;

		///<summary>FStringAssetReference</summary>
		public const int SmallFontName = 0x0050;

		///<summary>UFont *</summary>
		public const int MediumFont = 0x0060;

		///<summary>FStringAssetReference</summary>
		public const int MediumFontName = 0x0068;

		///<summary>UFont *</summary>
		public const int LargeFont = 0x0078;

		///<summary>FStringAssetReference</summary>
		public const int LargeFontName = 0x0080;

		///<summary>UFont *</summary>
		public const int SubtitleFont = 0x0090;

		///<summary>FStringAssetReference</summary>
		public const int SubtitleFontName = 0x0098;

		///<summary>TArray&lt;UFont * &gt;</summary>
		public const int AdditionalFonts = 0x00A8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x00B8;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AdditionalFontNames = 0x00C0;

		///<summary>UClass *</summary>
		public const int ConsoleClass = 0x00D0;

		///<summary>FStringClassReference</summary>
		public const int ConsoleClassName = 0x00D8;

		///<summary>UClass *</summary>
		public const int GameViewportClientClass = 0x00E8;

		///<summary>FStringClassReference</summary>
		public const int GameViewportClientClassName = 0x00F0;

		///<summary>UClass *</summary>
		public const int LocalPlayerClass = 0x0100;

		///<summary>FStringClassReference</summary>
		public const int LocalPlayerClassName = 0x0108;

		///<summary>UClass *</summary>
		public const int WorldSettingsClass = 0x0118;

		///<summary>FStringClassReference</summary>
		public const int WorldSettingsClassName = 0x0120;

		///<summary>FStringClassReference</summary>
		public const int NavigationSystemClassName = 0x0130;

		///<summary>UClass *</summary>
		public const int NavigationSystemClass = 0x0140;

		///<summary>FStringClassReference</summary>
		public const int AvoidanceManagerClassName = 0x0148;

		///<summary>UClass *</summary>
		public const int AvoidanceManagerClass = 0x0158;

		///<summary>UClass *</summary>
		public const int PhysicsCollisionHandlerClass = 0x0160;

		///<summary>FStringClassReference</summary>
		public const int PhysicsCollisionHandlerClassName = 0x0168;

		///<summary>FStringClassReference</summary>
		public const int GameUserSettingsClassName = 0x0178;

		///<summary>UClass *</summary>
		public const int GameUserSettingsClass = 0x0188;

		///<summary>FStringClassReference</summary>
		public const int AIControllerClassName = 0x0190;

		///<summary>UGameUserSettings *</summary>
		public const int GameUserSettings = 0x01A0;

		///<summary>UClass *</summary>
		public const int LevelScriptActorClass = 0x01A8;

		///<summary>FStringClassReference</summary>
		public const int LevelScriptActorClassName = 0x01B0;

		///<summary>FStringClassReference</summary>
		public const int DefaultBlueprintBaseClassName = 0x01C0;

		///<summary>FStringClassReference</summary>
		public const int GameSingletonClassName = 0x01D0;

		///<summary>UObject *</summary>
		public const int GameSingleton = 0x01E0;

		///<summary>FStringClassReference</summary>
		public const int AssetManagerClassName = 0x01E8;

		///<summary>UAssetManager *</summary>
		public const int AssetManager = 0x01F8;

		///<summary>FString</summary>
		public const int PlayOnConsoleSaveDir = 0x0200;

		///<summary>UTexture2D *</summary>
		public const int DefaultTexture = 0x0210;

		///<summary>FStringAssetReference</summary>
		public const int DefaultTextureName = 0x0218;

		///<summary>UTexture *</summary>
		public const int DefaultDiffuseTexture = 0x0228;

		///<summary>FStringAssetReference</summary>
		public const int DefaultDiffuseTextureName = 0x0230;

		///<summary>UTexture2D *</summary>
		public const int DefaultBSPVertexTexture = 0x0240;

		///<summary>FStringAssetReference</summary>
		public const int DefaultBSPVertexTextureName = 0x0248;

		///<summary>UTexture2D *</summary>
		public const int HighFrequencyNoiseTexture = 0x0258;

		///<summary>FStringAssetReference</summary>
		public const int HighFrequencyNoiseTextureName = 0x0260;

		///<summary>UTexture2D *</summary>
		public const int DefaultBokehTexture = 0x0270;

		///<summary>FStringAssetReference</summary>
		public const int DefaultBokehTextureName = 0x0278;

		///<summary>UTexture2D *</summary>
		public const int DefaultBloomKernelTexture = 0x0288;

		///<summary>FStringAssetReference</summary>
		public const int DefaultBloomKernelTextureName = 0x0290;

		///<summary>UMaterial *</summary>
		public const int WireframeMaterial = 0x02A0;

		///<summary>FString</summary>
		public const int WireframeMaterialName = 0x02A8;

		///<summary>UMaterial *</summary>
		public const int DebugMeshMaterial = 0x02B8;

		///<summary>FStringAssetReference</summary>
		public const int DebugMeshMaterialName = 0x02C0;

		///<summary>UMaterial *</summary>
		public const int LevelColorationLitMaterial = 0x02D0;

		///<summary>FString</summary>
		public const int LevelColorationLitMaterialName = 0x02D8;

		///<summary>UMaterial *</summary>
		public const int LevelColorationUnlitMaterial = 0x02E8;

		///<summary>FString</summary>
		public const int LevelColorationUnlitMaterialName = 0x02F0;

		///<summary>UMaterial *</summary>
		public const int LightingTexelDensityMaterial = 0x0300;

		///<summary>FString</summary>
		public const int LightingTexelDensityName = 0x0308;

		///<summary>UMaterial *</summary>
		public const int ShadedLevelColorationLitMaterial = 0x0318;

		///<summary>FString</summary>
		public const int ShadedLevelColorationLitMaterialName = 0x0320;

		///<summary>UMaterial *</summary>
		public const int ShadedLevelColorationUnlitMaterial = 0x0330;

		///<summary>FString</summary>
		public const int ShadedLevelColorationUnlitMaterialName = 0x0338;

		///<summary>UMaterial *</summary>
		public const int RemoveSurfaceMaterial = 0x0348;

		///<summary>FStringAssetReference</summary>
		public const int RemoveSurfaceMaterialName = 0x0350;

		///<summary>UMaterial *</summary>
		public const int VertexColorMaterial = 0x0360;

		///<summary>FString</summary>
		public const int VertexColorMaterialName = 0x0368;

		///<summary>UMaterial *</summary>
		public const int VertexColorViewModeMaterial_ColorOnly = 0x0378;

		///<summary>FString</summary>
		public const int VertexColorViewModeMaterialName_ColorOnly = 0x0380;

		///<summary>UMaterial *</summary>
		public const int VertexColorViewModeMaterial_AlphaAsColor = 0x0390;

		///<summary>FString</summary>
		public const int VertexColorViewModeMaterialName_AlphaAsColor = 0x0398;

		///<summary>UMaterial *</summary>
		public const int VertexColorViewModeMaterial_RedOnly = 0x03A8;

		///<summary>FString</summary>
		public const int VertexColorViewModeMaterialName_RedOnly = 0x03B0;

		///<summary>UMaterial *</summary>
		public const int VertexColorViewModeMaterial_GreenOnly = 0x03C0;

		///<summary>FString</summary>
		public const int VertexColorViewModeMaterialName_GreenOnly = 0x03C8;

		///<summary>UMaterial *</summary>
		public const int VertexColorViewModeMaterial_BlueOnly = 0x03D8;

		///<summary>FString</summary>
		public const int VertexColorViewModeMaterialName_BlueOnly = 0x03E0;

		///<summary>UMaterial *</summary>
		public const int ConstraintLimitMaterial = 0x03F0;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialX = 0x03F8;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialXAxis = 0x0400;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialY = 0x0408;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialYAxis = 0x0410;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialZ = 0x0418;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialZAxis = 0x0420;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int ConstraintLimitMaterialPrismatic = 0x0428;

		///<summary>UMaterial *</summary>
		public const int InvalidLightmapSettingsMaterial = 0x0430;

		///<summary>FStringAssetReference</summary>
		public const int InvalidLightmapSettingsMaterialName = 0x0438;

		///<summary>UMaterial *</summary>
		public const int PreviewShadowsIndicatorMaterial = 0x0448;

		///<summary>FStringAssetReference</summary>
		public const int PreviewShadowsIndicatorMaterialName = 0x0450;

		///<summary>UMaterial *</summary>
		public const int ArrowMaterial = 0x0460;

		///<summary>FStringAssetReference</summary>
		public const int ArrowMaterialName = 0x0468;

		///<summary>FLinearColor</summary>
		public const int LightingOnlyBrightness = 0x0478;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int ShaderComplexityColors = 0x0488;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int QuadComplexityColors = 0x0498;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int LightComplexityColors = 0x04A8;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int StationaryLightOverlapColors = 0x04B8;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int LODColorationColors = 0x04C8;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int HLODColorationColors = 0x04D8;

		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int StreamingAccuracyColors = 0x04E8;

		///<summary>float</summary>
		public const int MaxPixelShaderAdditiveComplexityCount = 0x04F8;

		///<summary>float</summary>
		public const int MaxES2PixelShaderAdditiveComplexityCount = 0x04FC;

		///<summary>float</summary>
		public const int MinLightMapDensity = 0x0500;

		///<summary>float</summary>
		public const int IdealLightMapDensity = 0x0504;

		///<summary>float</summary>
		public const int MaxLightMapDensity = 0x0508;

		///<summary>unsigned char:1</summary>
		public const int bRenderLightMapDensityGrayscale = 0x050C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x050D;

		///<summary>float</summary>
		public const int RenderLightMapDensityGrayscaleScale = 0x0510;

		///<summary>float</summary>
		public const int RenderLightMapDensityColorScale = 0x0514;

		///<summary>FLinearColor</summary>
		public const int LightMapDensityVertexMappedColor = 0x0518;

		///<summary>FLinearColor</summary>
		public const int LightMapDensitySelectedColor = 0x0528;

		///<summary>TArray&lt;FStatColorMapping&gt;</summary>
		public const int StatColorMappings = 0x0538;

		///<summary>UPhysicalMaterial *</summary>
		public const int DefaultPhysMaterial = 0x0548;

		///<summary>FStringAssetReference</summary>
		public const int DefaultPhysMaterialName = 0x0550;

		///<summary>TArray&lt;FGameNameRedirect&gt;</summary>
		public const int ActiveGameNameRedirects = 0x0560;

		///<summary>TArray&lt;FClassRedirect&gt;</summary>
		public const int ActiveClassRedirects = 0x0570;

		///<summary>TArray&lt;FPluginRedirect&gt;</summary>
		public const int ActivePluginRedirects = 0x0580;

		///<summary>TArray&lt;FStructRedirect&gt;</summary>
		public const int ActiveStructRedirects = 0x0590;

		///<summary>UTexture2D *</summary>
		public const int PreIntegratedSkinBRDFTexture = 0x05A0;

		///<summary>FStringAssetReference</summary>
		public const int PreIntegratedSkinBRDFTextureName = 0x05A8;

		///<summary>UTexture2D *</summary>
		public const int MiniFontTexture = 0x05B8;

		///<summary>FStringAssetReference</summary>
		public const int MiniFontTextureName = 0x05C0;

		///<summary>UTexture *</summary>
		public const int WeightMapPlaceholderTexture = 0x05D0;

		///<summary>FStringAssetReference</summary>
		public const int WeightMapPlaceholderTextureName = 0x05D8;

		///<summary>UTexture2D *</summary>
		public const int LightMapDensityTexture = 0x05E8;

		///<summary>FStringAssetReference</summary>
		public const int LightMapDensityTextureName = 0x05F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0600;

		///<summary>UGameViewportClient *</summary>
		public const int GameViewport = 0x0608;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int DeferredCommands = 0x0610;

		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData04 = 0x0620;

		///<summary>int</summary>
		public const int TickCycles = 0x0688;

		///<summary>int</summary>
		public const int GameCycles = 0x068C;

		///<summary>int</summary>
		public const int ClientCycles = 0x0690;

		///<summary>float</summary>
		public const int NearClipPlane = 0x0694;

		///<summary>unsigned char:1</summary>
		public const int bHardwareSurveyEnabled = 0x0698;

		///<summary>unsigned char:1</summary>
		public const int bSubtitlesEnabled = 0x0698;

		///<summary>unsigned char:1</summary>
		public const int bSubtitlesForcedOff = 0x0698;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0699;

		///<summary>int</summary>
		public const int MaximumLoopIterationCount = 0x069C;

		///<summary>unsigned char:1</summary>
		public const int bCanBlueprintsTickByDefault = 0x06A0;

		///<summary>unsigned char:1</summary>
		public const int bOptimizeAnimBlueprintMemberVariableAccess = 0x06A0;

		///<summary>unsigned char:1</summary>
		public const int bAllowMultiThreadedAnimationUpdate = 0x06A0;

		///<summary>unsigned char:1</summary>
		public const int bEnableEditorPSysRealtimeLOD = 0x06A0;

		///<summary>unsigned char:1</summary>
		public const int UnknownData06 = 0x06A0;

		///<summary>unsigned char:1</summary>
		public const int bSmoothFrameRate = 0x06A0;

		///<summary>unsigned char:1</summary>
		public const int bUseFixedFrameRate = 0x06A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x06A1;

		///<summary>float</summary>
		public const int FixedFrameRate = 0x06A4;

		///<summary>FFloatRange</summary>
		public const int SmoothedFrameRateRange = 0x06A8;

		///<summary>unsigned char:1</summary>
		public const int bCheckForMultiplePawnsSpawnedInAFrame = 0x06B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x06B9;

		///<summary>int</summary>
		public const int NumPawnsAllowedToBeSpawnedInAFrame = 0x06BC;

		///<summary>unsigned char:1</summary>
		public const int bShouldGenerateLowQualityLightmaps = 0x06C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x06C1;

		///<summary>FColor</summary>
		public const int C_WorldBox = 0x06C4;

		///<summary>FColor</summary>
		public const int C_BrushWire = 0x06C8;

		///<summary>FColor</summary>
		public const int C_AddWire = 0x06CC;

		///<summary>FColor</summary>
		public const int C_SubtractWire = 0x06D0;

		///<summary>FColor</summary>
		public const int C_SemiSolidWire = 0x06D4;

		///<summary>FColor</summary>
		public const int C_NonSolidWire = 0x06D8;

		///<summary>FColor</summary>
		public const int C_WireBackground = 0x06DC;

		///<summary>FColor</summary>
		public const int C_ScaleBoxHi = 0x06E0;

		///<summary>FColor</summary>
		public const int C_VolumeCollision = 0x06E4;

		///<summary>FColor</summary>
		public const int C_BSPCollision = 0x06E8;

		///<summary>FColor</summary>
		public const int C_OrthoBackground = 0x06EC;

		///<summary>FColor</summary>
		public const int C_Volume = 0x06F0;

		///<summary>FColor</summary>
		public const int C_BrushShape = 0x06F4;

		///<summary>float</summary>
		public const int StreamingDistanceFactor = 0x06F8;

		///<summary>TEnumAsByte&lt;ETransitionType&gt;</summary>
		public const int TransitionType = 0x06FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x06FD;

		///<summary>FString</summary>
		public const int TransitionDescription = 0x0700;

		///<summary>FString</summary>
		public const int TransitionGameMode = 0x0710;

		///<summary>float</summary>
		public const int MeshLODRange = 0x0720;

		///<summary>unsigned char:1</summary>
		public const int bAllowMatureLanguage = 0x0724;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData11 = 0x0725;

		///<summary>float</summary>
		public const int CameraRotationThreshold = 0x0728;

		///<summary>float</summary>
		public const int CameraTranslationThreshold = 0x072C;

		///<summary>float</summary>
		public const int PrimitiveProbablyVisibleTime = 0x0730;

		///<summary>float</summary>
		public const int MaxOcclusionPixelsFraction = 0x0734;

		///<summary>unsigned char:1</summary>
		public const int bPauseOnLossOfFocus = 0x0738;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData12 = 0x0739;

		///<summary>int</summary>
		public const int MaxParticleResize = 0x073C;

		///<summary>int</summary>
		public const int MaxParticleResizeWarn = 0x0740;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData13 = 0x0744;

		///<summary>TArray&lt;FDropNoteInfo&gt;</summary>
		public const int PendingDroppedNotes = 0x0748;

		///<summary>FRigidBodyErrorCorrection</summary>
		public const int PhysicErrorCorrection = 0x0758;

		///<summary>float</summary>
		public const int NetClientTicksPerSecond = 0x0774;

		///<summary>float</summary>
		public const int DisplayGamma = 0x0778;

		///<summary>float</summary>
		public const int MinDesiredFrameRate = 0x077C;

		///<summary>FLinearColor</summary>
		public const int DefaultSelectedMaterialColor = 0x0780;

		///<summary>FLinearColor</summary>
		public const int SelectedMaterialColor = 0x0790;

		///<summary>FLinearColor</summary>
		public const int SelectionOutlineColor = 0x07A0;

		///<summary>FLinearColor</summary>
		public const int SubduedSelectionOutlineColor = 0x07B0;

		///<summary>FLinearColor</summary>
		public const int SelectedMaterialColorOverride = 0x07C0;

		///<summary>bool</summary>
		public const int bIsOverridingSelectedColor = 0x07D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData14 = 0x07D1;

		///<summary>unsigned char:1</summary>
		public const int bEnableOnScreenDebugMessages = 0x07D4;

		///<summary>unsigned char:1</summary>
		public const int bEnableOnScreenDebugMessagesDisplay = 0x07D4;

		///<summary>unsigned char:1</summary>
		public const int bSuppressMapWarnings = 0x07D4;

		///<summary>unsigned char:1</summary>
		public const int bDisableAILogging = 0x07D4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData15 = 0x07D5;

		///<summary>uint32_t</summary>
		public const int bEnableVisualLogRecordingOnStart = 0x07D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData16 = 0x07DC;

		///<summary>int</summary>
		public const int ScreenSaverInhibitorSemaphore = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int bLockReadOnlyLevels = 0x07E4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData17 = 0x07E5;

		///<summary>FString</summary>
		public const int ParticleEventManagerClassPath = 0x07E8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData18 = 0x07F8;

		///<summary>float</summary>
		public const int SelectionHighlightIntensity = 0x0808;

		///<summary>float</summary>
		public const int SelectionMeshSectionHighlightIntensity = 0x080C;

		///<summary>float</summary>
		public const int BSPSelectionHighlightIntensity = 0x0810;

		///<summary>float</summary>
		public const int HoverHighlightIntensity = 0x0814;

		///<summary>float</summary>
		public const int SelectionHighlightIntensityBillboards = 0x0818;

		///<summary>unsigned char[0x3D4]</summary>
		public const int UnknownData19 = 0x081C;

		///<summary>TArray&lt;FNetDriverDefinition&gt;</summary>
		public const int NetDriverDefinitions = 0x0BF0;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int ServerActors = 0x0C00;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int RuntimeServerActors = 0x0C10;

		///<summary>unsigned char:1</summary>
		public const int bStartedLoadMapMovie = 0x0C20;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData20 = 0x0C21;

		///<summary>int</summary>
		public const int NextWorldContextHandle = 0x0C38;

		///<summary>unsigned char[0xD4]</summary>
		public const int UnknownData21 = 0x0C3C;

	}

	public class UScriptViewportClient
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UGameViewportClient
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0030;

		///<summary>UConsole *</summary>
		public const int ViewportConsole = 0x0038;

		///<summary>TArray&lt;FDebugDisplayProperty&gt;</summary>
		public const int DebugProperties = 0x0040;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData01 = 0x0050;

		///<summary>UWorld *</summary>
		public const int World = 0x0080;

		///<summary>UGameInstance *</summary>
		public const int GameInstance = 0x0088;

		///<summary>unsigned char[0x580]</summary>
		public const int UnknownData02 = 0x0090;

	}

	public class UConsole
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>ULocalPlayer *</summary>
		public const int ConsoleTargetPlayer = 0x0038;

		///<summary>UTexture2D *</summary>
		public const int DefaultTexture_Black = 0x0040;

		///<summary>UTexture2D *</summary>
		public const int DefaultTexture_White = 0x0048;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0050;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HistoryBuffer = 0x0068;

		///<summary>unsigned char[0xB8]</summary>
		public const int UnknownData02 = 0x0078;

	}

	public class USkinnedMeshComponent
	{
		///<summary>USkeletalMesh *</summary>
		public const int SkeletalMesh = 0x0950;

		///<summary>TWeakObjectPtr&lt;USkinnedMeshComponent&gt;</summary>
		public const int MasterPoseComponent = 0x0958;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData00 = 0x0960;

		///<summary>unsigned char:1</summary>
		public const int bUseBoundsFromMasterPoseComponent = 0x09C0;

		///<summary>unsigned char[0x27]</summary>
		public const int UnknownData01 = 0x09C1;

		///<summary>UPhysicsAsset *</summary>
		public const int PhysicsAssetOverride = 0x09E8;

		///<summary>int</summary>
		public const int ForcedLodModel = 0x09F0;

		///<summary>int</summary>
		public const int MinLodModel = 0x09F4;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x09F8;

		///<summary>TArray&lt;FSkelMeshComponentLODInfo&gt;</summary>
		public const int LODInfo = 0x0A08;

		///<summary>float</summary>
		public const int StreamingDistanceMultiplier = 0x0A18;

		///<summary>FColor</summary>
		public const int WireframeColor = 0x0A1C;

		///<summary>unsigned char:1</summary>
		public const int bForceWireframe = 0x0A20;

		///<summary>unsigned char:1</summary>
		public const int bDisplayBones = 0x0A20;

		///<summary>unsigned char:1</summary>
		public const int bDisableMorphTarget = 0x0A20;

		///<summary>unsigned char:1</summary>
		public const int bHideSkin = 0x0A20;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData03 = 0x0A21;

		///<summary>unsigned char:1</summary>
		public const int bPerBoneMotionBlur = 0x0A38;

		///<summary>unsigned char:1</summary>
		public const int bComponentUseFixedSkelBounds = 0x0A38;

		///<summary>unsigned char:1</summary>
		public const int bConsiderAllBodiesForBounds = 0x0A38;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0A39;

		///<summary>TEnumAsByte&lt;EMeshComponentUpdateFlag&gt;</summary>
		public const int MeshComponentUpdateFlag = 0x0A3C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0A3D;

		///<summary>unsigned char:1</summary>
		public const int bForceMeshObjectUpdate = 0x0A40;

		///<summary>unsigned char:1</summary>
		public const int bCanHighlightSelectedSections = 0x0A40;

		///<summary>unsigned char:1</summary>
		public const int bRecentlyRendered = 0x0A40;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0A41;

		///<summary>unsigned char</summary>
		public const int CustomSortAlternateIndexMode = 0x0A44;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0A45;

		///<summary>unsigned char:1</summary>
		public const int bCastCapsuleDirectShadow = 0x0A48;

		///<summary>unsigned char:1</summary>
		public const int bCastCapsuleIndirectShadow = 0x0A48;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0A49;

		///<summary>float</summary>
		public const int CapsuleIndirectShadowMinVisibility = 0x0A4C;

		///<summary>unsigned char:1</summary>
		public const int bCPUSkinning = 0x0A50;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData09 = 0x0A51;

		///<summary>FBoxSphereBounds</summary>
		public const int CachedLocalBounds = 0x0A64;

		///<summary>bool</summary>
		public const int bCachedLocalBoundsUpToDate = 0x0A80;

		///<summary>bool</summary>
		public const int bEnableUpdateRateOptimizations = 0x0A81;

		///<summary>bool</summary>
		public const int bDisplayDebugUpdateRateOptimizations = 0x0A82;

		///<summary>unsigned char[0x4D]</summary>
		public const int UnknownData10 = 0x0A83;

	}

	public class UDestructibleComponent
	{
		///<summary>unsigned char:1</summary>
		public const int bFractureEffectOverride = 0x0AD0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0AD1;

		///<summary>TArray&lt;FFractureEffect&gt;</summary>
		public const int FractureEffects = 0x0AD8;

		///<summary>bool</summary>
		public const int bEnableHardSleeping = 0x0AE8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0AE9;

		///<summary>float</summary>
		public const int LargeChunkThreshold = 0x0AEC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0AF0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnComponentFracture = 0x0B00;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData03 = 0x0B10;

	}

	public class UGameEngine
	{
		///<summary>UGameInstance *</summary>
		public const int GameInstance = 0x0D10;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x0D18;

		///<summary>TArray&lt;UWorld * &gt;</summary>
		public const int PendingDestroyWorldList = 0x0D58;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0D68;

	}

	public class AGameModeBase
	{
		///<summary>FString</summary>
		public const int OptionsString = 0x03B0;

		///<summary>UClass *</summary>
		public const int GameSessionClass = 0x03C0;

		///<summary>UClass *</summary>
		public const int GameStateClass = 0x03C8;

		///<summary>UClass *</summary>
		public const int PlayerControllerClass = 0x03D0;

		///<summary>UClass *</summary>
		public const int PlayerStateClass = 0x03D8;

		///<summary>UClass *</summary>
		public const int HUDClass = 0x03E0;

		///<summary>UClass *</summary>
		public const int DefaultPawnClass = 0x03E8;

		///<summary>UClass *</summary>
		public const int SpectatorClass = 0x03F0;

		///<summary>UClass *</summary>
		public const int ReplaySpectatorPlayerControllerClass = 0x03F8;

		///<summary>AGameSession *</summary>
		public const int GameSession = 0x0400;

		///<summary>AGameStateBase *</summary>
		public const int GameState = 0x0408;

		///<summary>FText</summary>
		public const int DefaultPlayerName = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bUseSeamlessTravel = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bStartPlayersAsSpectators = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bPauseable = 0x0428;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData00 = 0x0429;

	}

	public class AGameMode
	{
		///<summary>FName</summary>
		public const int MatchState = 0x0440;

		///<summary>unsigned char:1</summary>
		public const int bDelayedStart = 0x0448;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0449;

		///<summary>int</summary>
		public const int NumSpectators = 0x044C;

		///<summary>int</summary>
		public const int NumPlayers = 0x0450;

		///<summary>int</summary>
		public const int NumBots = 0x0454;

		///<summary>float</summary>
		public const int MinRespawnDelay = 0x0458;

		///<summary>int</summary>
		public const int NumTravellingPlayers = 0x045C;

		///<summary>UClass *</summary>
		public const int EngineMessageClass = 0x0460;

		///<summary>TArray&lt;APlayerState * &gt;</summary>
		public const int InactivePlayerArray = 0x0468;

		///<summary>float</summary>
		public const int InactivePlayerStateLifeSpan = 0x0478;

		///<summary>bool</summary>
		public const int bHandleDedicatedServerReplays = 0x047C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x047D;

	}

	public class UGameUserSettings
	{
		///<summary>bool</summary>
		public const int bUseVSync = 0x0028;

		///<summary>unsigned char[0x4F]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>uint32_t</summary>
		public const int ResolutionSizeX = 0x0078;

		///<summary>uint32_t</summary>
		public const int ResolutionSizeY = 0x007C;

		///<summary>uint32_t</summary>
		public const int LastUserConfirmedResolutionSizeX = 0x0080;

		///<summary>uint32_t</summary>
		public const int LastUserConfirmedResolutionSizeY = 0x0084;

		///<summary>int</summary>
		public const int WindowPosX = 0x0088;

		///<summary>int</summary>
		public const int WindowPosY = 0x008C;

		///<summary>int</summary>
		public const int FullscreenMode = 0x0090;

		///<summary>int</summary>
		public const int LastConfirmedFullscreenMode = 0x0094;

		///<summary>int</summary>
		public const int PreferredFullscreenMode = 0x0098;

		///<summary>uint32_t</summary>
		public const int Version = 0x009C;

		///<summary>int</summary>
		public const int AudioQualityLevel = 0x00A0;

		///<summary>float</summary>
		public const int FrameRateLimit = 0x00A4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x00A8;

		///<summary>int</summary>
		public const int DesiredScreenWidth = 0x00AC;

		///<summary>bool</summary>
		public const int bUseDesiredScreenHeight = 0x00B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00B1;

		///<summary>int</summary>
		public const int DesiredScreenHeight = 0x00B4;

		///<summary>float</summary>
		public const int LastRecommendedScreenWidth = 0x00B8;

		///<summary>float</summary>
		public const int LastRecommendedScreenHeight = 0x00BC;

		///<summary>float</summary>
		public const int LastCPUBenchmarkResult = 0x00C0;

		///<summary>float</summary>
		public const int LastGPUBenchmarkResult = 0x00C4;

		///<summary>TArray&lt;float&gt;</summary>
		public const int LastCPUBenchmarkSteps = 0x00C8;

		///<summary>TArray&lt;float&gt;</summary>
		public const int LastGPUBenchmarkSteps = 0x00D8;

		///<summary>float</summary>
		public const int LastGPUBenchmarkMultiplier = 0x00E8;

		///<summary>bool</summary>
		public const int bUseHDRDisplayOutput = 0x00EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x00ED;

		///<summary>int</summary>
		public const int HDRDisplayOutputNits = 0x00F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x00F4;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGameUserSettingsUINeedsUpdate = 0x00F8;

	}

	public class AGameSession
	{
		///<summary>int</summary>
		public const int MaxSpectators = 0x03B0;

		///<summary>int</summary>
		public const int MaxPlayers = 0x03B4;

		///<summary>int</summary>
		public const int MaxPartySize = 0x03B8;

		///<summary>unsigned char</summary>
		public const int MaxSplitscreensPerConnection = 0x03BC;

		///<summary>bool</summary>
		public const int bRequiresPushToTalk = 0x03BD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03BE;

		///<summary>FName</summary>
		public const int SessionName = 0x03C0;

	}

	public class AGameStateBase
	{
		///<summary>UClass *</summary>
		public const int GameModeClass = 0x03B0;

		///<summary>AGameModeBase *</summary>
		public const int AuthorityGameMode = 0x03B8;

		///<summary>UClass *</summary>
		public const int SpectatorClass = 0x03C0;

		///<summary>TArray&lt;APlayerState * &gt;</summary>
		public const int PlayerArray = 0x03C8;

		///<summary>bool</summary>
		public const int bReplicatedHasBegunPlay = 0x03D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03D9;

		///<summary>float</summary>
		public const int ReplicatedWorldTimeSeconds = 0x03DC;

		///<summary>float</summary>
		public const int ServerWorldTimeSecondsDelta = 0x03E0;

		///<summary>float</summary>
		public const int ServerWorldTimeSecondsUpdateFrequency = 0x03E4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03E8;

	}

	public class AGameState
	{
		///<summary>FName</summary>
		public const int MatchState = 0x03F0;

		///<summary>FName</summary>
		public const int PreviousMatchState = 0x03F8;

		///<summary>int</summary>
		public const int ElapsedTime = 0x0400;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0404;

	}

	public class UInstancedStaticMeshComponent
	{
		///<summary>TArray&lt;FInstancedStaticMeshInstanceData&gt;</summary>
		public const int PerInstanceSMData = 0x09E0;

		///<summary>int</summary>
		public const int InstancingRandomSeed = 0x09F0;

		///<summary>int</summary>
		public const int InstanceStartCullDistance = 0x09F4;

		///<summary>int</summary>
		public const int InstanceEndCullDistance = 0x09F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x09FC;

		///<summary>TArray&lt;int&gt;</summary>
		public const int InstanceReorderTable = 0x0A00;

		///<summary>TArray&lt;int&gt;</summary>
		public const int RemovedInstances = 0x0A10;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData01 = 0x0A20;

		///<summary>UPhysicsSerializer *</summary>
		public const int PhysicsSerializer = 0x0A78;

		///<summary>int</summary>
		public const int NumPendingLightmaps = 0x0A80;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0A84;

		///<summary>TArray&lt;FInstancedStaticMeshMappingInfo&gt;</summary>
		public const int CachedMappings = 0x0A88;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0A98;

	}

	public class UHierarchicalInstancedStaticMeshComponent
	{
		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData00 = 0x0AA0;

		///<summary>TArray&lt;int&gt;</summary>
		public const int SortedInstances = 0x0B00;

		///<summary>int</summary>
		public const int NumBuiltInstances = 0x0B10;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0B14;

		///<summary>FBox</summary>
		public const int BuiltInstanceBounds = 0x0B18;

		///<summary>FBox</summary>
		public const int UnbuiltInstanceBounds = 0x0B34;

		///<summary>TArray&lt;FBox&gt;</summary>
		public const int UnbuiltInstanceBoundsList = 0x0B50;

		///<summary>unsigned char:1</summary>
		public const int bEnableDensityScaling = 0x0B60;

		///<summary>unsigned char[0x27]</summary>
		public const int UnknownData02 = 0x0B61;

		///<summary>int</summary>
		public const int OcclusionLayerNumNodes = 0x0B88;

		///<summary>FBoxSphereBounds</summary>
		public const int CacheMeshExtendedBounds = 0x0B8C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0BA8;

		///<summary>bool</summary>
		public const int bDisableCollision = 0x0BAC;

		///<summary>unsigned char[0x23]</summary>
		public const int UnknownData04 = 0x0BAD;

	}

	public class UGridInstancedStaticMeshComponent
	{
		///<summary>int</summary>
		public const int MinVertsToSplitNodeForGrid = 0x0BD0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0BD4;

	}

	public class ALevelScriptActor
	{
		///<summary>unsigned char:1</summary>
		public const int bInputEnabled = 0x03B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B1;

	}

	public class UPlayer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>APlayerController *</summary>
		public const int PlayerController = 0x0030;

		///<summary>int</summary>
		public const int CurrentNetSpeed = 0x0038;

		///<summary>int</summary>
		public const int ConfiguredInternetSpeed = 0x003C;

		///<summary>int</summary>
		public const int ConfiguredLanSpeed = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0044;

	}

	public class ULocalPlayer
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0048;

		///<summary>UGameViewportClient *</summary>
		public const int ViewportClient = 0x0058;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0060;

		///<summary>UClass *</summary>
		public const int PendingLevelPlayerControllerClass = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bSentSplitJoin = 0x0088;

		///<summary>unsigned char[0x13F]</summary>
		public const int UnknownData02 = 0x0089;

	}

	public class APhysicsVolume
	{
		///<summary>float</summary>
		public const int TerminalVelocity = 0x03E8;

		///<summary>int</summary>
		public const int Priority = 0x03EC;

		///<summary>float</summary>
		public const int FluidFriction = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bWaterVolume = 0x03F4;

		///<summary>unsigned char:1</summary>
		public const int bPhysicsOnContact = 0x03F4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F5;

	}

	public class APlayerCameraManager
	{
		///<summary>APlayerController *</summary>
		public const int PCOwner = 0x03B0;

		///<summary>USceneComponent *</summary>
		public const int TransformComponent = 0x03B8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03C0;

		///<summary>float</summary>
		public const int DefaultFOV = 0x03C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03CC;

		///<summary>float</summary>
		public const int DefaultOrthoWidth = 0x03D0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x03D4;

		///<summary>float</summary>
		public const int DefaultAspectRatio = 0x03D8;

		///<summary>unsigned char[0x44]</summary>
		public const int UnknownData03 = 0x03DC;

		///<summary>FCameraCacheEntry</summary>
		public const int CameraCache = 0x0420;

		///<summary>FCameraCacheEntry</summary>
		public const int LastFrameCameraCache = 0x09B0;

		///<summary>FTViewTarget</summary>
		public const int ViewTarget = 0x0F40;

		///<summary>FTViewTarget</summary>
		public const int PendingViewTarget = 0x14E0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData04 = 0x1A80;

		///<summary>TArray&lt;UCameraModifier * &gt;</summary>
		public const int ModifierList = 0x1A98;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int DefaultModifiers = 0x1AA8;

		///<summary>float</summary>
		public const int FreeCamDistance = 0x1AB8;

		///<summary>FVector</summary>
		public const int FreeCamOffset = 0x1ABC;

		///<summary>FVector</summary>
		public const int ViewTargetOffset = 0x1AC8;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData05 = 0x1AD4;

		///<summary>TArray&lt;AEmitterCameraLensEffectBase * &gt;</summary>
		public const int CameraLensEffects = 0x1AE8;

		///<summary>UCameraModifier_CameraShake *</summary>
		public const int CachedCameraShakeMod = 0x1AF8;

		///<summary>UCameraAnimInst * [0x8]</summary>
		public const int AnimInstPool = 0x1B00;

		///<summary>TArray&lt;FPostProcessSettings&gt;</summary>
		public const int PostProcessBlendCache = 0x1B40;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData06 = 0x1B50;

		///<summary>TArray&lt;UCameraAnimInst * &gt;</summary>
		public const int ActiveAnims = 0x1B60;

		///<summary>TArray&lt;UCameraAnimInst * &gt;</summary>
		public const int FreeAnims = 0x1B70;

		///<summary>ACameraActor *</summary>
		public const int AnimCameraActor = 0x1B80;

		///<summary>unsigned char:1</summary>
		public const int bIsOrthographic = 0x1B88;

		///<summary>unsigned char:1</summary>
		public const int bDefaultConstrainAspectRatio = 0x1B88;

		///<summary>unsigned char:5</summary>
		public const int UnknownData07 = 0x1B88;

		///<summary>unsigned char:1</summary>
		public const int bUseClientSideCameraUpdates = 0x1B88;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x1B89;

		///<summary>float</summary>
		public const int ViewPitchMin = 0x1B8C;

		///<summary>float</summary>
		public const int ViewPitchMax = 0x1B90;

		///<summary>float</summary>
		public const int ViewYawMin = 0x1B94;

		///<summary>float</summary>
		public const int ViewYawMax = 0x1B98;

		///<summary>float</summary>
		public const int ViewRollMin = 0x1B9C;

		///<summary>float</summary>
		public const int ViewRollMax = 0x1BA0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData09 = 0x1BA4;

	}

	public class APlayerState
	{
		///<summary>float</summary>
		public const int Score = 0x03B0;

		///<summary>unsigned char</summary>
		public const int Ping = 0x03B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03B5;

		///<summary>FString</summary>
		public const int PlayerName = 0x03B8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x03C8;

		///<summary>int</summary>
		public const int PlayerId = 0x03D8;

		///<summary>unsigned char:1</summary>
		public const int bIsSpectator = 0x03DC;

		///<summary>unsigned char:1</summary>
		public const int bOnlySpectator = 0x03DC;

		///<summary>unsigned char:1</summary>
		public const int bIsABot = 0x03DC;

		///<summary>unsigned char:1</summary>
		public const int UnknownData02 = 0x03DC;

		///<summary>unsigned char:1</summary>
		public const int bIsInactive = 0x03DC;

		///<summary>unsigned char:1</summary>
		public const int bFromPreviousLevel = 0x03DC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x03DD;

		///<summary>int</summary>
		public const int StartTime = 0x03E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x03E4;

		///<summary>UClass *</summary>
		public const int EngineMessageClass = 0x03E8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x03F0;

		///<summary>FString</summary>
		public const int SavedNetworkAddress = 0x03F8;

		///<summary>FUniqueNetIdRepl</summary>
		public const int UniqueId = 0x0408;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData06 = 0x0420;

		///<summary>bool</summary>
		public const int bShouldUpdateReplicatedPing = 0x0440;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData07 = 0x0441;

	}

	public class UShapeComponent
	{
		///<summary>UBodySetup *</summary>
		public const int ShapeBodySetup = 0x0850;

		///<summary>unsigned char:1</summary>
		public const int bDrawOnlyIfSelected = 0x0858;

		///<summary>unsigned char:1</summary>
		public const int bShouldCollideWhenPlacing = 0x0858;

		///<summary>unsigned char:1</summary>
		public const int bDynamicObstacle = 0x0858;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0859;

		///<summary>UClass *</summary>
		public const int AreaClass = 0x0860;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0868;

	}

	public class UBoxComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0870;

	}

	public class USceneCaptureComponent
	{
		///<summary>TArray&lt;TWeakObjectPtr&lt;UPrimitiveComponent&gt;&gt;</summary>
		public const int HiddenComponents = 0x03F0;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int HiddenActors = 0x0400;

		///<summary>TArray&lt;TWeakObjectPtr&lt;UPrimitiveComponent&gt;&gt;</summary>
		public const int ShowOnlyComponents = 0x0410;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int ShowOnlyActors = 0x0420;

		///<summary>bool</summary>
		public const int bCaptureEveryFrame = 0x0430;

		///<summary>bool</summary>
		public const int bCaptureOnMovement = 0x0431;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0432;

		///<summary>float</summary>
		public const int LODDistanceFactor = 0x0434;

		///<summary>float</summary>
		public const int MaxViewDistanceOverride = 0x0438;

		///<summary>int</summary>
		public const int CaptureSortPriority = 0x043C;

		///<summary>TArray&lt;FEngineShowFlagsSetting&gt;</summary>
		public const int ShowFlagSettings = 0x0440;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0450;

	}

	public class USceneCaptureComponent2D
	{
		///<summary>TEnumAsByte&lt;ECameraProjectionMode&gt;</summary>
		public const int ProjectionType = 0x0470;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0471;

		///<summary>float</summary>
		public const int FOVAngle = 0x0474;

		///<summary>float</summary>
		public const int OrthoWidth = 0x0478;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x047C;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int TextureTarget = 0x0480;

		///<summary>TEnumAsByte&lt;ESceneCaptureSource&gt;</summary>
		public const int CaptureSource = 0x0488;

		///<summary>TEnumAsByte&lt;ESceneCaptureCompositeMode&gt;</summary>
		public const int CompositeMode = 0x0489;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x048A;

		///<summary>FPostProcessSettings</summary>
		public const int PostProcessSettings = 0x0490;

		///<summary>float</summary>
		public const int PostProcessBlendWeight = 0x09C0;

		///<summary>bool</summary>
		public const int bUseCustomProjectionMatrix = 0x09C4;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData03 = 0x09C5;

		///<summary>FMatrix</summary>
		public const int CustomProjectionMatrix = 0x09D0;

		///<summary>bool</summary>
		public const int bEnableClipPlane = 0x0A10;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0A11;

		///<summary>FVector</summary>
		public const int ClipPlaneBase = 0x0A14;

		///<summary>FVector</summary>
		public const int ClipPlaneNormal = 0x0A20;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x0A2C;

	}

	public class UParticleSystemComponent
	{
		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int EmitterMaterials = 0x0850;

		///<summary>TArray&lt;USkeletalMeshComponent * &gt;</summary>
		public const int SkelMeshComponents = 0x0860;

		///<summary>unsigned char:7</summary>
		public const int UnknownData00 = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bResetOnDetach = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bUpdateOnDedicatedServer = 0x0871;

		///<summary>unsigned char:2</summary>
		public const int UnknownData01 = 0x0871;

		///<summary>unsigned char:1</summary>
		public const int bAllowRecycling = 0x0871;

		///<summary>unsigned char:1</summary>
		public const int bAutoManageAttachment = 0x0871;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x0872;

		///<summary>EParticleSignificanceLevel</summary>
		public const int RequiredSignificance = 0x0874;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData03 = 0x0875;

		///<summary>TArray&lt;FParticleSysParam&gt;</summary>
		public const int InstanceParameters = 0x0880;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleSpawn = 0x0890;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleBurst = 0x08A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleDeath = 0x08B0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleCollide = 0x08C0;

		///<summary>FVector</summary>
		public const int OldPosition = 0x08D0;

		///<summary>FVector</summary>
		public const int PartSysVelocity = 0x08DC;

		///<summary>float</summary>
		public const int WarmupTime = 0x08E8;

		///<summary>float</summary>
		public const int WarmupTickRate = 0x08EC;

		///<summary>unsigned char:1</summary>
		public const int bWarmingUp = 0x08F0;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData04 = 0x08F1;

		///<summary>float</summary>
		public const int SecondsBeforeInactive = 0x08FC;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x0900;

		///<summary>float</summary>
		public const int MaxTimeBeforeForceUpdateTransform = 0x0908;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x090C;

		///<summary>unsigned char:1</summary>
		public const int bOverrideLODMethod = 0x0910;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0911;

		///<summary>TEnumAsByte&lt;EParticleSystemLODMethod&gt;</summary>
		public const int LODMethod = 0x0914;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0915;

		///<summary>unsigned char:1</summary>
		public const int bSkipUpdateDynamicDataDuringTick = 0x0918;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData09 = 0x0919;

		///<summary>TArray&lt;UParticleSystemReplay * &gt;</summary>
		public const int ReplayClips = 0x0938;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData10 = 0x0948;

		///<summary>float</summary>
		public const int CustomTimeDilation = 0x09A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData11 = 0x09AC;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSystemFinished = 0x09B0;

		///<summary>TWeakObjectPtr&lt;USceneComponent&gt;</summary>
		public const int AutoAttachParent = 0x09C0;

		///<summary>FName</summary>
		public const int AutoAttachSocketName = 0x09C8;

		///<summary>TEnumAsByte&lt;EAttachLocation&gt;</summary>
		public const int AutoAttachLocationType = 0x09D0;

		///<summary>EAttachmentRule</summary>
		public const int AutoAttachLocationRule = 0x09D1;

		///<summary>EAttachmentRule</summary>
		public const int AutoAttachRotationRule = 0x09D2;

		///<summary>EAttachmentRule</summary>
		public const int AutoAttachScaleRule = 0x09D3;

		///<summary>unsigned char[0xFC]</summary>
		public const int UnknownData12 = 0x09D4;

	}

	public class ADefaultPawn
	{
		///<summary>float</summary>
		public const int BaseTurnRate = 0x0410;

		///<summary>float</summary>
		public const int BaseLookUpRate = 0x0414;

		///<summary>UPawnMovementComponent *</summary>
		public const int MovementComponent = 0x0418;

		///<summary>USphereComponent *</summary>
		public const int CollisionComponent = 0x0420;

		///<summary>UStaticMeshComponent *</summary>
		public const int MeshComponent = 0x0428;

		///<summary>unsigned char:1</summary>
		public const int bAddDefaultMovementBindings = 0x0430;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0431;

	}

	public class UFloatingPawnMovement
	{
		///<summary>float</summary>
		public const int MaxSpeed = 0x0260;

		///<summary>float</summary>
		public const int Acceleration = 0x0264;

		///<summary>float</summary>
		public const int Deceleration = 0x0268;

		///<summary>float</summary>
		public const int TurningBoost = 0x026C;

		///<summary>unsigned char:1</summary>
		public const int bPositionCorrected = 0x0270;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x0271;

	}

	public class USplineComponent
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0850;

		///<summary>FInterpCurveVector</summary>
		public const int SplineInfo = 0x08A8;

		///<summary>FInterpCurveQuat</summary>
		public const int SplineRotInfo = 0x08C0;

		///<summary>FInterpCurveVector</summary>
		public const int SplineScaleInfo = 0x08D8;

		///<summary>FInterpCurveFloat</summary>
		public const int SplineReparamTable = 0x08F0;

		///<summary>bool</summary>
		public const int bAllowSplineEditingPerInstance = 0x0908;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0909;

		///<summary>int</summary>
		public const int ReparamStepsPerSegment = 0x090C;

		///<summary>float</summary>
		public const int Duration = 0x0910;

		///<summary>bool</summary>
		public const int bStationaryEndpoints = 0x0914;

		///<summary>bool</summary>
		public const int bSplineHasBeenEdited = 0x0915;

		///<summary>bool</summary>
		public const int bModifiedByConstructionScript = 0x0916;

		///<summary>bool</summary>
		public const int bInputSplinePointsToConstructionScript = 0x0917;

		///<summary>bool</summary>
		public const int bDrawDebug = 0x0918;

		///<summary>bool</summary>
		public const int bClosedLoop = 0x0919;

		///<summary>bool</summary>
		public const int bLoopPositionOverride = 0x091A;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x091B;

		///<summary>float</summary>
		public const int LoopPosition = 0x091C;

		///<summary>FVector</summary>
		public const int DefaultUpVector = 0x0920;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x092C;

	}

	public class UMaterialInterface
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>USubsurfaceProfile *</summary>
		public const int SubsurfaceProfile = 0x0030;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0038;

		///<summary>FLightmassMaterialInterfaceSettings</summary>
		public const int LightmassSettings = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0054;

		///<summary>TArray&lt;FMaterialTextureInfo&gt;</summary>
		public const int TextureStreamingData = 0x0058;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0068;

	}

	public class UMaterialInstance
	{
		///<summary>UPhysicalMaterial *</summary>
		public const int PhysMaterial = 0x0070;

		///<summary>UMaterialInterface *</summary>
		public const int Parent = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int bHasStaticPermutationResource = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int UnknownData00 = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bOverrideSubsurfaceProfile = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0081;

		///<summary>TArray&lt;FFontParameterValue&gt;</summary>
		public const int FontParameterValues = 0x0088;

		///<summary>TArray&lt;FScalarParameterValue&gt;</summary>
		public const int ScalarParameterValues = 0x0098;

		///<summary>TArray&lt;FTextureParameterValue&gt;</summary>
		public const int TextureParameterValues = 0x00A8;

		///<summary>TArray&lt;FVectorParameterValue&gt;</summary>
		public const int VectorParameterValues = 0x00B8;

		///<summary>bool</summary>
		public const int bOverrideBaseProperties = 0x00C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00C9;

		///<summary>FMaterialInstanceBasePropertyOverrides</summary>
		public const int BasePropertyOverrides = 0x00CC;

		///<summary>unsigned char[0xD0]</summary>
		public const int UnknownData03 = 0x00E0;

	}

	public class UMaterialExpression
	{
		///<summary>UMaterial *</summary>
		public const int Material = 0x0028;

		///<summary>UMaterialFunction *</summary>
		public const int Function = 0x0030;

		///<summary>FString</summary>
		public const int Desc = 0x0038;

		///<summary>FColor</summary>
		public const int BorderColor = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bRealtimePreview = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bNeedToUpdatePreview = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bIsParameterExpression = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bCommentBubbleVisible = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bShowOutputNameOnPin = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bShowMaskColorsOnPin = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bHidePreviewWindow = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bCollapsed = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bShaderInputData = 0x004D;

		///<summary>unsigned char:1</summary>
		public const int bShowInputs = 0x004D;

		///<summary>unsigned char:1</summary>
		public const int bShowOutputs = 0x004D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x004E;

		///<summary>TArray&lt;FExpressionOutput&gt;</summary>
		public const int Outputs = 0x0050;

	}

	public class UAnimNotifyState
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UBlueprintGeneratedClass
	{
		///<summary>int</summary>
		public const int NumReplicatedProperties = 0x0258;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x025C;

		///<summary>TArray&lt;UDynamicBlueprintBinding * &gt;</summary>
		public const int DynamicBindingObjects = 0x0260;

		///<summary>TArray&lt;UActorComponent * &gt;</summary>
		public const int ComponentTemplates = 0x0270;

		///<summary>TArray&lt;UTimelineTemplate * &gt;</summary>
		public const int Timelines = 0x0280;

		///<summary>USimpleConstructionScript *</summary>
		public const int SimpleConstructionScript = 0x0290;

		///<summary>UInheritableComponentHandler *</summary>
		public const int InheritableComponentHandler = 0x0298;

		///<summary>UStructProperty *</summary>
		public const int UberGraphFramePointerProperty = 0x02A0;

		///<summary>UFunction *</summary>
		public const int UberGraphFunction = 0x02A8;

		///<summary>TArray&lt;FEventGraphFastCallPair&gt;</summary>
		public const int FastCallPairs = 0x02B0;

		///<summary>bool</summary>
		public const int bHasInstrumentation = 0x02C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x02C1;

		///<summary>TMap&lt;FName,FBlueprintCookedComponentInstancingData&gt;</summary>
		public const int CookedComponentInstancingData = 0x02C8;

		///<summary>bool</summary>
		public const int bHasNativizedParent = 0x0318;

		///<summary>unsigned char[0x3F]</summary>
		public const int UnknownData02 = 0x0319;

	}

	public class ACameraActor
	{
		///<summary>TEnumAsByte&lt;EAutoReceiveInput&gt;</summary>
		public const int AutoActivateForPlayer = 0x03B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B1;

		///<summary>UCameraComponent *</summary>
		public const int CameraComponent = 0x03B8;

		///<summary>USceneComponent *</summary>
		public const int SceneComponent = 0x03C0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03C8;

		///<summary>unsigned char:1</summary>
		public const int bConstrainAspectRatio = 0x03D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x03D1;

		///<summary>float</summary>
		public const int AspectRatio = 0x03D4;

		///<summary>float</summary>
		public const int FOVAngle = 0x03D8;

		///<summary>float</summary>
		public const int PostProcessBlendWeight = 0x03DC;

		///<summary>FPostProcessSettings</summary>
		public const int PostProcessSettings = 0x03E0;

	}

	public class UUserDefinedStruct
	{
		///<summary>FGuid</summary>
		public const int Guid = 0x0098;

	}

	public class UAISystemBase
	{
		///<summary>FStringClassReference</summary>
		public const int AISystemClassName = 0x0028;

		///<summary>FName</summary>
		public const int AISystemModuleName = 0x0038;

		///<summary>bool</summary>
		public const int bInstantiateAISystemOnClient = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UNavigationQueryFilter
	{
		///<summary>TArray&lt;FNavigationFilterArea&gt;</summary>
		public const int Areas = 0x0028;

		///<summary>FNavigationFilterFlags</summary>
		public const int IncludeFlags = 0x0038;

		///<summary>FNavigationFilterFlags</summary>
		public const int ExcludeFlags = 0x003C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0040;

	}

	public class UDeveloperSettings
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UModel
	{
		///<summary>unsigned char[0x550]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UEdGraphNode
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UEdGraphPin_Deprecated * &gt;</summary>
		public const int DeprecatedPins = 0x0038;

		///<summary>int</summary>
		public const int NodePosX = 0x0048;

		///<summary>int</summary>
		public const int NodePosY = 0x004C;

		///<summary>int</summary>
		public const int NodeWidth = 0x0050;

		///<summary>int</summary>
		public const int NodeHeight = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bHasCompilerMessage = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0059;

		///<summary>FString</summary>
		public const int NodeComment = 0x0060;

		///<summary>bool</summary>
		public const int bCommentBubblePinned = 0x0070;

		///<summary>bool</summary>
		public const int bCommentBubbleVisible = 0x0071;

		///<summary>bool</summary>
		public const int bCommentBubbleMakeVisible = 0x0072;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x0073;

		///<summary>int</summary>
		public const int ErrorType = 0x0074;

		///<summary>FString</summary>
		public const int ErrorMsg = 0x0078;

		///<summary>FGuid</summary>
		public const int NodeGuid = 0x0088;

		///<summary>TEnumAsByte&lt;ENodeAdvancedPins&gt;</summary>
		public const int AdvancedPinDisplay = 0x0098;

		///<summary>ENodeEnabledState</summary>
		public const int EnabledState = 0x0099;

		///<summary>bool</summary>
		public const int bUserSetEnabledState = 0x009A;

		///<summary>bool</summary>
		public const int bIsNodeEnabled = 0x009B;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x009C;

	}

	public class UEdGraphPin_Deprecated
	{
		///<summary>FString</summary>
		public const int PinName = 0x0028;

		///<summary>FString</summary>
		public const int PinToolTip = 0x0038;

		///<summary>TEnumAsByte&lt;EEdGraphPinDirection&gt;</summary>
		public const int Direction = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>FEdGraphPinType</summary>
		public const int PinType = 0x0050;

		///<summary>FString</summary>
		public const int DefaultValue = 0x00D0;

		///<summary>FString</summary>
		public const int AutogeneratedDefaultValue = 0x00E0;

		///<summary>UObject *</summary>
		public const int DefaultObject = 0x00F0;

		///<summary>FText</summary>
		public const int DefaultTextValue = 0x00F8;

		///<summary>TArray&lt;UEdGraphPin_Deprecated * &gt;</summary>
		public const int LinkedTo = 0x0110;

		///<summary>TArray&lt;UEdGraphPin_Deprecated * &gt;</summary>
		public const int SubPins = 0x0120;

		///<summary>UEdGraphPin_Deprecated *</summary>
		public const int ParentPin = 0x0130;

		///<summary>UEdGraphPin_Deprecated *</summary>
		public const int ReferencePassThroughConnection = 0x0138;

	}

	public class UChildActorComponent
	{
		///<summary>UClass *</summary>
		public const int ChildActorClass = 0x03F0;

		///<summary>AActor *</summary>
		public const int ChildActor = 0x03F8;

		///<summary>AActor *</summary>
		public const int ChildActorTemplate = 0x0400;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0408;

	}

	public class ULevel
	{
		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UWorld *</summary>
		public const int OwningWorld = 0x00C0;

		///<summary>UModel *</summary>
		public const int Model = 0x00C8;

		///<summary>TArray&lt;UModelComponent * &gt;</summary>
		public const int ModelComponents = 0x00D0;

		///<summary>ULevelActorContainer *</summary>
		public const int ActorCluster = 0x00E0;

		///<summary>int</summary>
		public const int NumTextureStreamingUnbuiltComponents = 0x00E8;

		///<summary>int</summary>
		public const int NumTextureStreamingDirtyResources = 0x00EC;

		///<summary>ALevelScriptActor *</summary>
		public const int LevelScriptActor = 0x00F0;

		///<summary>ANavigationObjectBase *</summary>
		public const int NavListStart = 0x00F8;

		///<summary>ANavigationObjectBase *</summary>
		public const int NavListEnd = 0x0100;

		///<summary>TArray&lt;UNavigationDataChunk * &gt;</summary>
		public const int NavDataChunks = 0x0108;

		///<summary>float</summary>
		public const int LightmapTotalSize = 0x0118;

		///<summary>float</summary>
		public const int ShadowmapTotalSize = 0x011C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int StaticNavigableGeometry = 0x0120;

		///<summary>TArray&lt;FGuid&gt;</summary>
		public const int StreamingTextureGuids = 0x0130;

		///<summary>unsigned char[0x88]</summary>
		public const int UnknownData01 = 0x0140;

		///<summary>bool</summary>
		public const int bIsLightingScenario = 0x01C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x01C9;

		///<summary>FGuid</summary>
		public const int LevelBuildDataId = 0x01CC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x01DC;

		///<summary>UMapBuildDataRegistry *</summary>
		public const int MapBuildData = 0x01E0;

		///<summary>FIntVector</summary>
		public const int LightBuildLevelOffset = 0x01E8;

		///<summary>unsigned char:2</summary>
		public const int UnknownData04 = 0x01F4;

		///<summary>unsigned char:1</summary>
		public const int bTextureStreamingRotationChanged = 0x01F4;

		///<summary>unsigned char:1</summary>
		public const int bIsVisible = 0x01F4;

		///<summary>unsigned char:1</summary>
		public const int bLocked = 0x01F4;

		///<summary>unsigned char[0xFB]</summary>
		public const int UnknownData05 = 0x01F5;

		///<summary>AWorldSettings *</summary>
		public const int WorldSettings = 0x02F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData06 = 0x02F8;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0300;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData07 = 0x0310;

	}

	public class AAmbientSound
	{
		///<summary>UAudioComponent *</summary>
		public const int AudioComponent = 0x03B0;

	}

	public class AAudioVolume
	{
		///<summary>float</summary>
		public const int Priority = 0x03E8;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03ED;

		///<summary>FReverbSettings</summary>
		public const int Settings = 0x03F0;

		///<summary>FInteriorSettings</summary>
		public const int AmbientZoneSettings = 0x0408;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x042C;

	}

	public class ACullDistanceVolume
	{
		///<summary>TArray&lt;FCullDistanceSizePair&gt;</summary>
		public const int CullDistances = 0x03E8;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03F8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F9;

		///<summary>float</summary>
		public const int CullDistanceForLODActor = 0x03FC;

		///<summary>float</summary>
		public const int CullDistanceForLODActorTooFar = 0x0400;

		///<summary>bool</summary>
		public const int bUseActorBound = 0x0404;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0405;

		///<summary>float</summary>
		public const int IgnoreActorBoundSize = 0x0408;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x040C;

	}

	public class ALevelStreamingVolume
	{
		///<summary>TArray&lt;FName&gt;</summary>
		public const int StreamingLevelNames = 0x03E8;

		///<summary>unsigned char:1</summary>
		public const int bEditorPreVisOnly = 0x03F8;

		///<summary>unsigned char:1</summary>
		public const int bDisabled = 0x03F8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F9;

		///<summary>TEnumAsByte&lt;EStreamingVolumeUsage&gt;</summary>
		public const int StreamingUsage = 0x03FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03FD;

	}

	public class ANavMeshBoundsVolume
	{
		///<summary>FNavAgentSelector</summary>
		public const int SupportedAgents = 0x03E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03EC;

	}

	public class UNavArea
	{
		///<summary>float</summary>
		public const int DefaultCost = 0x0028;

		///<summary>float</summary>
		public const int FixedAreaEnteringCost = 0x002C;

		///<summary>FColor</summary>
		public const int DrawColor = 0x0030;

		///<summary>FNavAgentSelector</summary>
		public const int SupportedAgents = 0x0034;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent0 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent1 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent2 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent3 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent4 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent5 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent6 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent7 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent8 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent9 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent10 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent11 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent12 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent13 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent14 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int bSupportsAgent15 = 0x0039;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x003A;

	}

	public class ANavModifierVolume
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03E8;

		///<summary>UClass *</summary>
		public const int AreaClass = 0x03F0;

	}

	public class APainCausingVolume
	{
		///<summary>unsigned char:1</summary>
		public const int bPainCausing = 0x03F8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F9;

		///<summary>float</summary>
		public const int DamagePerSec = 0x03FC;

		///<summary>UClass *</summary>
		public const int DamageType = 0x0400;

		///<summary>float</summary>
		public const int PainInterval = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bEntryPain = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int BACKUP_bPainCausing = 0x040C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x040D;

		///<summary>AController *</summary>
		public const int DamageInstigator = 0x0410;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0418;

	}

	public class APostProcessVolume
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03E8;

		///<summary>FPostProcessSettings</summary>
		public const int Settings = 0x03F0;

		///<summary>float</summary>
		public const int Priority = 0x0920;

		///<summary>float</summary>
		public const int BlendRadius = 0x0924;

		///<summary>float</summary>
		public const int BlendWeight = 0x0928;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x092C;

		///<summary>unsigned char:1</summary>
		public const int bUnbound = 0x092C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x092D;

	}

	public class APrecomputedVisibilityOverrideVolume
	{
		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int OverrideVisibleActors = 0x03E8;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int OverrideInvisibleActors = 0x03F8;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int OverrideInvisibleLevels = 0x0408;

	}

	public class UCameraShake
	{
		///<summary>unsigned char:1</summary>
		public const int bSingleInstance = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>float</summary>
		public const int OscillationDuration = 0x002C;

		///<summary>float</summary>
		public const int OscillationBlendInTime = 0x0030;

		///<summary>float</summary>
		public const int OscillationBlendOutTime = 0x0034;

		///<summary>FROscillator</summary>
		public const int RotOscillation = 0x0038;

		///<summary>FVOscillator</summary>
		public const int LocOscillation = 0x005C;

		///<summary>FFOscillator</summary>
		public const int FOVOscillation = 0x0080;

		///<summary>float</summary>
		public const int AnimPlayRate = 0x008C;

		///<summary>float</summary>
		public const int AnimScale = 0x0090;

		///<summary>float</summary>
		public const int AnimBlendInTime = 0x0094;

		///<summary>float</summary>
		public const int AnimBlendOutTime = 0x0098;

		///<summary>float</summary>
		public const int RandomAnimSegmentDuration = 0x009C;

		///<summary>UCameraAnim *</summary>
		public const int Anim = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bRandomAnimSegment = 0x00A8;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x00A9;

		///<summary>APlayerCameraManager *</summary>
		public const int CameraOwner = 0x00C0;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData02 = 0x00C8;

		///<summary>float</summary>
		public const int ShakeScale = 0x0148;

		///<summary>float</summary>
		public const int OscillatorTimeRemaining = 0x014C;

		///<summary>UCameraAnimInst *</summary>
		public const int AnimInst = 0x0150;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0158;

	}

	public class UInputComponent
	{
		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class UCurveBase
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCurveFloat
	{
		///<summary>FRichCurve</summary>
		public const int FloatCurve = 0x0030;

		///<summary>bool</summary>
		public const int bIsEventCurve = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A1;

	}

	public class UForceFeedbackEffect
	{
		///<summary>TArray&lt;FForceFeedbackChannelDetails&gt;</summary>
		public const int ChannelDetails = 0x0028;

		///<summary>float</summary>
		public const int Duration = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class ADebugCameraController
	{
		///<summary>unsigned char:1</summary>
		public const int bShowSelectedInfo = 0x06F0;

		///<summary>unsigned char:1</summary>
		public const int bIsFrozenRendering = 0x06F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x06F1;

		///<summary>UDrawFrustumComponent *</summary>
		public const int DrawFrustum = 0x06F8;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0700;

		///<summary>float</summary>
		public const int SpeedScale = 0x0720;

		///<summary>float</summary>
		public const int InitialMaxSpeed = 0x0724;

		///<summary>float</summary>
		public const int InitialAccel = 0x0728;

		///<summary>float</summary>
		public const int InitialDecel = 0x072C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0730;

	}

	public class ADecalActor
	{
		///<summary>UDecalComponent *</summary>
		public const int Decal = 0x03B0;

	}

	public class ADestructibleActor
	{
		///<summary>UDestructibleComponent *</summary>
		public const int DestructibleComponent = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bAffectNavigation = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnActorFracture = 0x03C0;

	}

	public class ADistanceFieldCapture
	{
		///<summary>UDistanceFieldCaptureComponent *</summary>
		public const int CaptureComponent = 0x03B0;

	}

	public class ADocumentationActor
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class AEmitter
	{
		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleSystemComponent = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bDestroyOnSystemFinish = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bPostUpdateTickGroup = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bCurrentlyActive = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleSpawn = 0x03C0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleBurst = 0x03D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleDeath = 0x03E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticleCollide = 0x03F0;

	}

	public class AEmitterCameraLensEffectBase
	{
		///<summary>UParticleSystem *</summary>
		public const int PS_CameraEffect = 0x0400;

		///<summary>UParticleSystem *</summary>
		public const int PS_CameraEffectNonExtremeContent = 0x0408;

		///<summary>APlayerCameraManager *</summary>
		public const int BaseCamera = 0x0410;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0418;

		///<summary>FTransform</summary>
		public const int RelativeTransform = 0x0420;

		///<summary>float</summary>
		public const int BaseFOV = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bAllowMultipleInstances = 0x0454;

		///<summary>unsigned char:1</summary>
		public const int bResetWhenRetriggered = 0x0454;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0455;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int EmittersToTreatAsSame = 0x0458;

		///<summary>float</summary>
		public const int DistFromCamera = 0x0468;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x046C;

	}

	public class AAtmosphericFog
	{
		///<summary>UAtmosphericFogComponent *</summary>
		public const int AtmosphericFogComponent = 0x03B0;

	}

	public class AExponentialHeightFog
	{
		///<summary>UExponentialHeightFogComponent *</summary>
		public const int Component = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

	}

	public class AGameNetworkManager
	{
		///<summary>int</summary>
		public const int AdjustedNetSpeed = 0x03B0;

		///<summary>float</summary>
		public const int LastNetSpeedUpdateTime = 0x03B4;

		///<summary>int</summary>
		public const int TotalNetBandwidth = 0x03B8;

		///<summary>int</summary>
		public const int MinDynamicBandwidth = 0x03BC;

		///<summary>int</summary>
		public const int MaxDynamicBandwidth = 0x03C0;

		///<summary>unsigned char:1</summary>
		public const int bIsStandbyCheckingEnabled = 0x03C4;

		///<summary>unsigned char:1</summary>
		public const int bHasStandbyCheatTriggered = 0x03C4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03C5;

		///<summary>float</summary>
		public const int StandbyRxCheatTime = 0x03C8;

		///<summary>float</summary>
		public const int StandbyTxCheatTime = 0x03CC;

		///<summary>int</summary>
		public const int BadPingThreshold = 0x03D0;

		///<summary>float</summary>
		public const int PercentMissingForRxStandby = 0x03D4;

		///<summary>float</summary>
		public const int PercentMissingForTxStandby = 0x03D8;

		///<summary>float</summary>
		public const int PercentForBadPing = 0x03DC;

		///<summary>float</summary>
		public const int JoinInProgressStandbyWaitTime = 0x03E0;

		///<summary>float</summary>
		public const int MoveRepSize = 0x03E4;

		///<summary>float</summary>
		public const int MAXPOSITIONERRORSQUARED = 0x03E8;

		///<summary>float</summary>
		public const int MAXNEARZEROVELOCITYSQUARED = 0x03EC;

		///<summary>float</summary>
		public const int CLIENTADJUSTUPDATECOST = 0x03F0;

		///<summary>float</summary>
		public const int MAXCLIENTUPDATEINTERVAL = 0x03F4;

		///<summary>float</summary>
		public const int MaxMoveDeltaTime = 0x03F8;

		///<summary>float</summary>
		public const int ClientNetSendMoveDeltaTime = 0x03FC;

		///<summary>float</summary>
		public const int ClientNetSendMoveDeltaTimeThrottled = 0x0400;

		///<summary>int</summary>
		public const int ClientNetSendMoveThrottleAtNetSpeed = 0x0404;

		///<summary>int</summary>
		public const int ClientNetSendMoveThrottleOverPlayerCount = 0x0408;

		///<summary>bool</summary>
		public const int ClientAuthorativePosition = 0x040C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x040D;

		///<summary>float</summary>
		public const int ClientErrorUpdateRateLimit = 0x0410;

		///<summary>bool</summary>
		public const int bMovementTimeDiscrepancyDetection = 0x0414;

		///<summary>bool</summary>
		public const int bMovementTimeDiscrepancyResolution = 0x0415;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x0416;

		///<summary>float</summary>
		public const int MovementTimeDiscrepancyMaxTimeMargin = 0x0418;

		///<summary>float</summary>
		public const int MovementTimeDiscrepancyMinTimeMargin = 0x041C;

		///<summary>float</summary>
		public const int MovementTimeDiscrepancyResolutionRate = 0x0420;

		///<summary>float</summary>
		public const int MovementTimeDiscrepancyDriftAllowance = 0x0424;

		///<summary>bool</summary>
		public const int bMovementTimeDiscrepancyForceCorrectionsDuringResolution = 0x0428;

		///<summary>bool</summary>
		public const int bUseDistanceBasedRelevancy = 0x0429;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData03 = 0x042A;

	}

	public class ASkyLight
	{
		///<summary>USkyLightComponent *</summary>
		public const int LightComponent = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

	}

	public class AWindDirectionalSource
	{
		///<summary>UWindDirectionalSourceComponent *</summary>
		public const int Component = 0x03B0;

	}

	public class AWorldSettings
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bEnableWorldBoundsChecks = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bEnableNavigationSystem = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bEnableAISystem = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bEnableWorldComposition = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bUseClientSideLevelStreamingVolumes = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bEnableWorldOriginRebasing = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bWorldGravitySet = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bGlobalGravitySet = 0x03B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03B9;

		///<summary>float</summary>
		public const int KillZ = 0x03BC;

		///<summary>UClass *</summary>
		public const int KillZDamageType = 0x03C0;

		///<summary>float</summary>
		public const int WorldGravityZ = 0x03C8;

		///<summary>float</summary>
		public const int GlobalGravityZ = 0x03CC;

		///<summary>UClass *</summary>
		public const int DefaultPhysicsVolumeClass = 0x03D0;

		///<summary>UClass *</summary>
		public const int PhysicsCollisionHandlerClass = 0x03D8;

		///<summary>UClass *</summary>
		public const int DefaultGameMode = 0x03E0;

		///<summary>UClass *</summary>
		public const int GameNetworkManagerClass = 0x03E8;

		///<summary>int</summary>
		public const int PackedLightAndShadowMapTextureSize = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bMinimizeBSPSections = 0x03F4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x03F5;

		///<summary>FVector</summary>
		public const int DefaultColorScale = 0x03F8;

		///<summary>float</summary>
		public const int DefaultMaxDistanceFieldOcclusionDistance = 0x0404;

		///<summary>float</summary>
		public const int GlobalDistanceFieldViewDistance = 0x0408;

		///<summary>float</summary>
		public const int DynamicIndirectShadowsSelfShadowingIntensity = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int bPrecomputeVisibility = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bPlaceCellsOnlyAlongCameraTracks = 0x0410;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0411;

		///<summary>int</summary>
		public const int VisibilityCellSize = 0x0414;

		///<summary>TEnumAsByte&lt;EVisibilityAggressiveness&gt;</summary>
		public const int VisibilityAggressiveness = 0x0418;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bForceNoPrecomputedLighting = 0x041C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x041D;

		///<summary>FLightmassWorldInfoSettings</summary>
		public const int LightmassSettings = 0x0420;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x0464;

		///<summary>FReverbSettings</summary>
		public const int DefaultReverbSettings = 0x0468;

		///<summary>FInteriorSettings</summary>
		public const int DefaultAmbientZoneSettings = 0x0480;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x04A4;

		///<summary>USoundMix *</summary>
		public const int DefaultBaseSoundMix = 0x04A8;

		///<summary>float</summary>
		public const int WorldToMeters = 0x04B0;

		///<summary>float</summary>
		public const int MonoCullingDistance = 0x04B4;

		///<summary>UBookMark * [0xA]</summary>
		public const int BookMarks = 0x04B8;

		///<summary>UExtendedReflectionSettings *</summary>
		public const int ReflectionSettings = 0x0508;

		///<summary>float</summary>
		public const int TimeDilation = 0x0510;

		///<summary>float</summary>
		public const int MatineeTimeDilation = 0x0514;

		///<summary>float</summary>
		public const int DemoPlayTimeDilation = 0x0518;

		///<summary>float</summary>
		public const int MinGlobalTimeDilation = 0x051C;

		///<summary>float</summary>
		public const int MaxGlobalTimeDilation = 0x0520;

		///<summary>float</summary>
		public const int MinUndilatedFrameTime = 0x0524;

		///<summary>float</summary>
		public const int MaxUndilatedFrameTime = 0x0528;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x052C;

		///<summary>APlayerState *</summary>
		public const int Pauser = 0x0530;

		///<summary>unsigned char:1</summary>
		public const int bHighPriorityLoading = 0x0538;

		///<summary>unsigned char:1</summary>
		public const int bHighPriorityLoadingLocal = 0x0538;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData09 = 0x0539;

		///<summary>TArray&lt;FNetViewer&gt;</summary>
		public const int ReplicationViewers = 0x0540;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0550;

	}

	public class ALevelBounds
	{
		///<summary>bool</summary>
		public const int bAutoUpdateBounds = 0x03B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B1;

	}

	public class ALight
	{
		///<summary>ULightComponent *</summary>
		public const int LightComponent = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

	}

	public class APointLight
	{
		///<summary>UPointLightComponent *</summary>
		public const int PointLightComponent = 0x03C0;

	}

	public class ASpotLight
	{
		///<summary>USpotLightComponent *</summary>
		public const int SpotLightComponent = 0x03C0;

	}

	public class ALightmassPortal
	{
		///<summary>ULightmassPortalComponent *</summary>
		public const int PortalComponent = 0x03B0;

	}

	public class ALODActor
	{
		///<summary>UStaticMeshComponent *</summary>
		public const int StaticMeshComponent = 0x03B0;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int SubActors = 0x03B8;

		///<summary>float</summary>
		public const int LODDrawDistance = 0x03C8;

		///<summary>int</summary>
		public const int LODLevel = 0x03CC;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int SubObjects = 0x03D0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03E0;

	}

	public class AMaterialInstanceActor
	{
		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int TargetActors = 0x03B0;

	}

	public class AMatineeActor
	{
		///<summary>UInterpData *</summary>
		public const int MatineeData = 0x03B0;

		///<summary>FName</summary>
		public const int MatineeControllerName = 0x03B8;

		///<summary>float</summary>
		public const int PlayRate = 0x03C0;

		///<summary>unsigned char:1</summary>
		public const int bPlayOnLevelLoad = 0x03C4;

		///<summary>unsigned char:1</summary>
		public const int bForceStartPos = 0x03C4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03C5;

		///<summary>float</summary>
		public const int ForceStartPosition = 0x03C8;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bRewindOnPlay = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bNoResetOnRewind = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bRewindIfAlreadyPlaying = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bDisableRadioFilter = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bClientSideOnly = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bSkipUpdateIfNotVisible = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bIsSkippable = 0x03CC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03CD;

		///<summary>int</summary>
		public const int PreferredSplitScreenNum = 0x03D0;

		///<summary>unsigned char:1</summary>
		public const int bDisableMovementInput = 0x03D4;

		///<summary>unsigned char:1</summary>
		public const int bDisableLookAtInput = 0x03D4;

		///<summary>unsigned char:1</summary>
		public const int bHidePlayer = 0x03D4;

		///<summary>unsigned char:1</summary>
		public const int bHideHud = 0x03D4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x03D5;

		///<summary>TArray&lt;FInterpGroupActorInfo&gt;</summary>
		public const int GroupActorInfos = 0x03D8;

		///<summary>unsigned char:1</summary>
		public const int bShouldShowGore = 0x03E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x03E9;

		///<summary>TArray&lt;UInterpGroupInst * &gt;</summary>
		public const int GroupInst = 0x03F0;

		///<summary>TArray&lt;FCameraCutInfo&gt;</summary>
		public const int CameraCuts = 0x0400;

		///<summary>unsigned char:1</summary>
		public const int bIsPlaying = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bReversePlayback = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bPaused = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bPendingStop = 0x0410;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0411;

		///<summary>float</summary>
		public const int InterpPosition = 0x0414;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x0418;

		///<summary>unsigned char</summary>
		public const int ReplicationForceIsPlaying = 0x041C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x041D;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPlay = 0x0420;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnStop = 0x0430;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPause = 0x0440;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData07 = 0x0450;

	}

	public class AMatineeActorCameraAnim
	{
		///<summary>UCameraAnim *</summary>
		public const int CameraAnim = 0x0458;

	}

	public class ANavigationData
	{
		///<summary>UPrimitiveComponent *</summary>
		public const int RenderingComp = 0x03B0;

		///<summary>FNavDataConfig</summary>
		public const int NavDataConfig = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bEnableDrawing = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bForceRebuildOnLoad = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bCanBeMainNavData = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bCanSpawnOnRebuild = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bRebuildAtRuntime = 0x0408;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0409;

		///<summary>ERuntimeGenerationType</summary>
		public const int RuntimeGeneration = 0x040C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x040D;

		///<summary>float</summary>
		public const int ObservedPathsTickInterval = 0x0410;

		///<summary>uint32_t</summary>
		public const int DataVersion = 0x0414;

		///<summary>unsigned char[0xD0]</summary>
		public const int UnknownData02 = 0x0418;

		///<summary>TArray&lt;FSupportedAreaData&gt;</summary>
		public const int SupportedAreas = 0x04E8;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData03 = 0x04F8;

	}

	public class ARecastNavMesh
	{
		///<summary>unsigned char:1</summary>
		public const int bDrawTriangleEdges = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawPolyEdges = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawFilledPolys = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawNavMeshEdges = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawTileBounds = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawPathCollidingGeometry = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawTileLabels = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawPolygonLabels = 0x0550;

		///<summary>unsigned char:1</summary>
		public const int bDrawDefaultPolygonCost = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDrawLabelsOnPathNodes = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDrawNavLinks = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDrawFailedNavLinks = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDrawClusters = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDrawOctree = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDistinctlyDrawTilesBeingBuilt = 0x0551;

		///<summary>unsigned char:1</summary>
		public const int bDrawNavMesh = 0x0551;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0552;

		///<summary>float</summary>
		public const int DrawOffset = 0x0554;

		///<summary>unsigned char:1</summary>
		public const int bFixedTilePoolSize = 0x0558;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0559;

		///<summary>int</summary>
		public const int TilePoolSize = 0x055C;

		///<summary>float</summary>
		public const int TileSizeUU = 0x0560;

		///<summary>float</summary>
		public const int CellSize = 0x0564;

		///<summary>float</summary>
		public const int CellHeight = 0x0568;

		///<summary>float</summary>
		public const int AgentRadius = 0x056C;

		///<summary>float</summary>
		public const int AgentHeight = 0x0570;

		///<summary>float</summary>
		public const int AgentMaxHeight = 0x0574;

		///<summary>float</summary>
		public const int AgentMaxSlope = 0x0578;

		///<summary>float</summary>
		public const int AgentMaxStepHeight = 0x057C;

		///<summary>float</summary>
		public const int MinRegionArea = 0x0580;

		///<summary>float</summary>
		public const int MergeRegionSize = 0x0584;

		///<summary>float</summary>
		public const int MaxSimplificationError = 0x0588;

		///<summary>int</summary>
		public const int MaxSimultaneousTileGenerationJobsCount = 0x058C;

		///<summary>int</summary>
		public const int TileNumberHardLimit = 0x0590;

		///<summary>int</summary>
		public const int PolyRefTileBits = 0x0594;

		///<summary>int</summary>
		public const int PolyRefNavPolyBits = 0x0598;

		///<summary>int</summary>
		public const int PolyRefSaltBits = 0x059C;

		///<summary>float</summary>
		public const int DefaultDrawDistance = 0x05A0;

		///<summary>float</summary>
		public const int DefaultMaxSearchNodes = 0x05A4;

		///<summary>float</summary>
		public const int DefaultMaxHierarchicalSearchNodes = 0x05A8;

		///<summary>TEnumAsByte&lt;ERecastPartitioning&gt;</summary>
		public const int RegionPartitioning = 0x05AC;

		///<summary>TEnumAsByte&lt;ERecastPartitioning&gt;</summary>
		public const int LayerPartitioning = 0x05AD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x05AE;

		///<summary>int</summary>
		public const int RegionChunkSplits = 0x05B0;

		///<summary>int</summary>
		public const int LayerChunkSplits = 0x05B4;

		///<summary>unsigned char:1</summary>
		public const int bSortNavigationAreasByCost = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bPerformVoxelFiltering = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bMarkLowHeightAreas = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bDoFullyAsyncNavDataGathering = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bUseBetterOffsetsFromCorners = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bStoreEmptyTileLayers = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bUseVirtualFilters = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bAllowNavLinkAsPathEnd = 0x05B8;

		///<summary>unsigned char:1</summary>
		public const int bUseVoxelCache = 0x05B9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x05BA;

		///<summary>float</summary>
		public const int TileSetUpdateInterval = 0x05BC;

		///<summary>float</summary>
		public const int HeuristicScale = 0x05C0;

		///<summary>float</summary>
		public const int VerticalDeviationFromGroundCompensation = 0x05C4;

		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData04 = 0x05C8;

	}

	public class ANavigationTestingActor
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>UCapsuleComponent *</summary>
		public const int CapsuleComponent = 0x03C0;

		///<summary>UNavigationInvokerComponent *</summary>
		public const int InvokerComponent = 0x03C8;

		///<summary>unsigned char:1</summary>
		public const int bActAsNavigationInvoker = 0x03D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03D1;

		///<summary>FNavAgentProperties</summary>
		public const int NavAgentProps = 0x03D8;

		///<summary>FVector</summary>
		public const int QueryingExtent = 0x03F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0404;

		///<summary>ANavigationData *</summary>
		public const int MyNavData = 0x0408;

		///<summary>FVector</summary>
		public const int ProjectedLocation = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bProjectedLocationValid = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bSearchStart = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bUseHierarchicalPathfinding = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bGatherDetailedInfo = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bDrawDistanceToWall = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bShowNodePool = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bShowBestPath = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bShowDiffWithPreviousStep = 0x041C;

		///<summary>unsigned char:1</summary>
		public const int bShouldBeVisibleInGame = 0x041D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x041E;

		///<summary>TEnumAsByte&lt;ENavCostDisplay&gt;</summary>
		public const int CostDisplayMode = 0x0420;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0421;

		///<summary>FVector2D</summary>
		public const int TextCanvasOffset = 0x0424;

		///<summary>unsigned char:1</summary>
		public const int bPathExist = 0x042C;

		///<summary>unsigned char:1</summary>
		public const int bPathIsPartial = 0x042C;

		///<summary>unsigned char:1</summary>
		public const int bPathSearchOutOfNodes = 0x042C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x042D;

		///<summary>float</summary>
		public const int PathfindingTime = 0x0430;

		///<summary>float</summary>
		public const int PathCost = 0x0434;

		///<summary>int</summary>
		public const int PathfindingSteps = 0x0438;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x043C;

		///<summary>ANavigationTestingActor *</summary>
		public const int OtherActor = 0x0440;

		///<summary>UClass *</summary>
		public const int FilterClass = 0x0448;

		///<summary>int</summary>
		public const int ShowStepIndex = 0x0450;

		///<summary>float</summary>
		public const int OffsetFromCornersDistance = 0x0454;

		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData07 = 0x0458;

	}

	public class UNavLinkDefinition
	{
		///<summary>TArray&lt;FNavigationLink&gt;</summary>
		public const int Links = 0x0028;

		///<summary>TArray&lt;FNavigationSegmentLink&gt;</summary>
		public const int SegmentLinks = 0x0038;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class ANavLinkProxy
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>TArray&lt;FNavigationLink&gt;</summary>
		public const int PointLinks = 0x03C0;

		///<summary>TArray&lt;FNavigationSegmentLink&gt;</summary>
		public const int SegmentLinks = 0x03D0;

		///<summary>UNavLinkCustomComponent *</summary>
		public const int SmartLinkComp = 0x03E0;

		///<summary>bool</summary>
		public const int bSmartLinkIsRelevant = 0x03E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03E9;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSmartLinkReached = 0x03F0;

	}

	public class UParticleSystem
	{
		///<summary>TEnumAsByte&lt;EParticleSystemUpdateMode&gt;</summary>
		public const int SystemUpdateMode = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>float</summary>
		public const int UpdateTime_FPS = 0x002C;

		///<summary>float</summary>
		public const int UpdateTime_Delta = 0x0030;

		///<summary>float</summary>
		public const int WarmupTime = 0x0034;

		///<summary>float</summary>
		public const int WarmupTickRate = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x003C;

		///<summary>TArray&lt;UParticleEmitter * &gt;</summary>
		public const int Emitters = 0x0040;

		///<summary>UParticleSystemComponent *</summary>
		public const int PreviewComponent = 0x0050;

		///<summary>UInterpCurveEdSetup *</summary>
		public const int CurveEdSetup = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int bOrientZAxisTowardCamera = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0061;

		///<summary>float</summary>
		public const int LODDistanceCheckTime = 0x0064;

		///<summary>TEnumAsByte&lt;EParticleSystemLODMethod&gt;</summary>
		public const int LODMethod = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0069;

		///<summary>TArray&lt;float&gt;</summary>
		public const int LODDistances = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bRegenerateLODDuplicate = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0081;

		///<summary>TArray&lt;FParticleSystemLOD&gt;</summary>
		public const int LODSettings = 0x0088;

		///<summary>unsigned char:1</summary>
		public const int bUseFixedRelativeBoundingBox = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0099;

		///<summary>FBox</summary>
		public const int FixedRelativeBoundingBox = 0x009C;

		///<summary>float</summary>
		public const int SecondsBeforeInactive = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int bShouldResetPeakCounts = 0x00BC;

		///<summary>unsigned char:1</summary>
		public const int bHasPhysics = 0x00BC;

		///<summary>unsigned char:1</summary>
		public const int bUseRealtimeThumbnail = 0x00BC;

		///<summary>unsigned char:1</summary>
		public const int ThumbnailImageOutOfDate = 0x00BC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x00BD;

		///<summary>float</summary>
		public const int Delay = 0x00C0;

		///<summary>float</summary>
		public const int DelayLow = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bUseDelayRange = 0x00C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x00C9;

		///<summary>bool</summary>
		public const int bAutoDeactivate = 0x00CC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x00CD;

		///<summary>uint32_t</summary>
		public const int MinTimeBetweenTicks = 0x00D0;

		///<summary>EParticleSystemInsignificanceReaction</summary>
		public const int InsignificantReaction = 0x00D4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x00D5;

		///<summary>float</summary>
		public const int InsignificanceDelay = 0x00D8;

		///<summary>EParticleSignificanceLevel</summary>
		public const int MaxSignificanceLevel = 0x00DC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x00DD;

		///<summary>FVector</summary>
		public const int MacroUVPosition = 0x00E0;

		///<summary>float</summary>
		public const int MacroUVRadius = 0x00EC;

		///<summary>TEnumAsByte&lt;EParticleSystemOcclusionBoundsMethod&gt;</summary>
		public const int OcclusionBoundsMethod = 0x00F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData11 = 0x00F1;

		///<summary>FBox</summary>
		public const int CustomOcclusionBounds = 0x00F4;

		///<summary>TArray&lt;FLODSoloTrack&gt;</summary>
		public const int SoloTracking = 0x0110;

		///<summary>TArray&lt;FNamedEmitterMaterial&gt;</summary>
		public const int NamedMaterialSlots = 0x0120;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData12 = 0x0130;

	}

	public class USkeletalMesh
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>USkeleton *</summary>
		public const int Skeleton = 0x0048;

		///<summary>FBoxSphereBounds</summary>
		public const int ImportedBounds = 0x0050;

		///<summary>FBoxSphereBounds</summary>
		public const int ExtendedBounds = 0x006C;

		///<summary>FVector</summary>
		public const int PositiveBoundsExtension = 0x0088;

		///<summary>FVector</summary>
		public const int NegativeBoundsExtension = 0x0094;

		///<summary>TArray&lt;FSkeletalMaterial&gt;</summary>
		public const int Materials = 0x00A0;

		///<summary>TArray&lt;FBoneMirrorInfo&gt;</summary>
		public const int SkelMirrorTable = 0x00B0;

		///<summary>TEnumAsByte&lt;EAxis&gt;</summary>
		public const int SkelMirrorAxis = 0x00C0;

		///<summary>TEnumAsByte&lt;EAxis&gt;</summary>
		public const int SkelMirrorFlipAxis = 0x00C1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x00C2;

		///<summary>TArray&lt;FSkeletalMeshLODInfo&gt;</summary>
		public const int LODInfo = 0x00C8;

		///<summary>unsigned char:1</summary>
		public const int bUseFullPrecisionUVs = 0x00D8;

		///<summary>unsigned char:1</summary>
		public const int bHasBeenSimplified = 0x00D8;

		///<summary>unsigned char:1</summary>
		public const int bHasVertexColors = 0x00D8;

		///<summary>unsigned char:1</summary>
		public const int bEnablePerPolyCollision = 0x00D8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x00D9;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x00E0;

		///<summary>UPhysicsAsset *</summary>
		public const int PhysicsAsset = 0x00E8;

		///<summary>UPhysicsAsset *</summary>
		public const int ShadowPhysicsAsset = 0x00F0;

		///<summary>TArray&lt;UNodeMappingContainer * &gt;</summary>
		public const int NodeMappingData = 0x00F8;

		///<summary>TArray&lt;UMorphTarget * &gt;</summary>
		public const int MorphTargets = 0x0108;

		///<summary>unsigned char[0x168]</summary>
		public const int UnknownData03 = 0x0118;

		///<summary>TArray&lt;FClothingAssetData_Legacy&gt;</summary>
		public const int ClothingAssets = 0x0280;

		///<summary>UClass *</summary>
		public const int PostProcessAnimBlueprint = 0x0290;

		///<summary>TArray&lt;UClothingAssetBase * &gt;</summary>
		public const int MeshClothingAssets = 0x0298;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x02A8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x02B8;

		///<summary>TArray&lt;USkeletalMeshSocket * &gt;</summary>
		public const int Sockets = 0x02C0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData05 = 0x02D0;

	}

	public class UAnimationAsset
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>USkeleton *</summary>
		public const int Skeleton = 0x0030;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0038;

		///<summary>TArray&lt;UAnimMetaData * &gt;</summary>
		public const int MetaData = 0x0058;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0068;

	}

	public class AReflectionCapture
	{
		///<summary>UReflectionCaptureComponent *</summary>
		public const int CaptureComponent = 0x03B0;

	}

	public class ASphereReflectionCapture
	{
		///<summary>UDrawSphereComponent *</summary>
		public const int DrawCaptureRadius = 0x03B8;

	}

	public class APhysicsConstraintActor
	{
		///<summary>UPhysicsConstraintComponent *</summary>
		public const int ConstraintComp = 0x03B0;

		///<summary>AActor *</summary>
		public const int ConstraintActor1 = 0x03B8;

		///<summary>AActor *</summary>
		public const int ConstraintActor2 = 0x03C0;

		///<summary>unsigned char:1</summary>
		public const int bDisableCollision = 0x03C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03C9;

	}

	public class APhysicsThruster
	{
		///<summary>UPhysicsThrusterComponent *</summary>
		public const int ThrusterComponent = 0x03B0;

	}

	public class ARadialForceActor
	{
		///<summary>URadialForceComponent *</summary>
		public const int ForceComponent = 0x03B0;

	}

	public class ASceneCapture
	{
		///<summary>UStaticMeshComponent *</summary>
		public const int MeshComp = 0x03B0;

	}

	public class APlanarReflection
	{
		///<summary>UPlanarReflectionComponent *</summary>
		public const int PlanarReflectionComponent = 0x03B8;

		///<summary>bool</summary>
		public const int bShowPreviewPlane = 0x03C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03C1;

	}

	public class ASceneCapture2D
	{
		///<summary>USceneCaptureComponent2D *</summary>
		public const int CaptureComponent2D = 0x03B8;

		///<summary>UDrawFrustumComponent *</summary>
		public const int DrawFrustum = 0x03C0;

	}

	public class ASceneCaptureCube
	{
		///<summary>USceneCaptureComponentCube *</summary>
		public const int CaptureComponentCube = 0x03B8;

		///<summary>UDrawFrustumComponent *</summary>
		public const int DrawFrustum = 0x03C0;

	}

	public class ASkeletalMeshActor
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>unsigned char:1</summary>
		public const int bShouldDoAnimNotifies = 0x03B8;

		///<summary>unsigned char:1</summary>
		public const int bWakeOnLevelStart = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03B9;

		///<summary>USkeletalMeshComponent *</summary>
		public const int SkeletalMeshComponent = 0x03C0;

		///<summary>USkeletalMesh *</summary>
		public const int ReplicatedMesh = 0x03C8;

		///<summary>UPhysicsAsset *</summary>
		public const int ReplicatedPhysAsset = 0x03D0;

		///<summary>UMaterialInterface *</summary>
		public const int ReplicatedMaterial0 = 0x03D8;

		///<summary>UMaterialInterface *</summary>
		public const int ReplicatedMaterial1 = 0x03E0;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData02 = 0x03E8;

	}

	public class ASplineMeshActor
	{
		///<summary>USplineMeshComponent *</summary>
		public const int SplineMeshComponent = 0x03B0;

	}

	public class ATextRenderActor
	{
		///<summary>UTextRenderComponent *</summary>
		public const int TextRender = 0x03B0;

	}

	public class ATriggerBase
	{
		///<summary>UShapeComponent *</summary>
		public const int CollisionComponent = 0x03B0;

	}

	public class AVectorFieldVolume
	{
		///<summary>UVectorFieldComponent *</summary>
		public const int VectorFieldComponent = 0x03B0;

	}

	public class UApplicationLifecycleComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationHasReactivatedDelegate = 0x01E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationWillEnterBackgroundDelegate = 0x01F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationHasEnteredForegroundDelegate = 0x0208;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationWillTerminateDelegate = 0x0218;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0228;

	}

	public class UInterpToMovementComponent
	{
		///<summary>float</summary>
		public const int Duration = 0x0220;

		///<summary>unsigned char:1</summary>
		public const int bPauseOnImpact = 0x0224;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0225;

		///<summary>EInterpToBehaviourType</summary>
		public const int BehaviourType = 0x0228;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0229;

		///<summary>unsigned char:1</summary>
		public const int bForceSubStepping = 0x022C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x022D;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInterpToReverse = 0x0230;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInterpToStop = 0x0240;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnWaitBeginDelegate = 0x0250;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnWaitEndDelegate = 0x0260;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnResetDelegate = 0x0270;

		///<summary>float</summary>
		public const int MaxSimulationTimeStep = 0x0280;

		///<summary>int</summary>
		public const int MaxSimulationIterations = 0x0284;

		///<summary>TArray&lt;FInterpControlPoint&gt;</summary>
		public const int ControlPoints = 0x0288;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData03 = 0x0298;

	}

	public class USkeleton
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FBoneNode&gt;</summary>
		public const int BoneTree = 0x0030;

		///<summary>TArray&lt;FTransform&gt;</summary>
		public const int RefLocalPoses = 0x0040;

		///<summary>unsigned char[0x110]</summary>
		public const int UnknownData01 = 0x0050;

		///<summary>FGuid</summary>
		public const int VirtualBoneGuid = 0x0160;

		///<summary>TArray&lt;FVirtualBone&gt;</summary>
		public const int VirtualBones = 0x0170;

		///<summary>TArray&lt;FSkeletonToMeshLinkup&gt;</summary>
		public const int LinkupCache = 0x0180;

		///<summary>TArray&lt;USkeletalMeshSocket * &gt;</summary>
		public const int Sockets = 0x0190;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData02 = 0x01A0;

		///<summary>FSmartNameContainer</summary>
		public const int SmartNames = 0x01F0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x0240;

		///<summary>TArray&lt;UBlendProfile * &gt;</summary>
		public const int BlendProfiles = 0x0258;

		///<summary>TArray&lt;FAnimSlotGroup&gt;</summary>
		public const int SlotGroups = 0x0268;

		///<summary>unsigned char[0x118]</summary>
		public const int UnknownData04 = 0x0278;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0390;

	}

	public class UAnimSequenceBase
	{
		///<summary>TArray&lt;FAnimNotifyEvent&gt;</summary>
		public const int Notifies = 0x0078;

		///<summary>float</summary>
		public const int SequenceLength = 0x0088;

		///<summary>float</summary>
		public const int RateScale = 0x008C;

		///<summary>FRawCurveTracks</summary>
		public const int RawCurveData = 0x0090;

	}

	public class UAnimMontage
	{
		///<summary>FAlphaBlend</summary>
		public const int BlendIn = 0x00A0;

		///<summary>float</summary>
		public const int BlendInTime = 0x00D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00DC;

		///<summary>FAlphaBlend</summary>
		public const int BlendOut = 0x00E0;

		///<summary>float</summary>
		public const int BlendOutTime = 0x0118;

		///<summary>float</summary>
		public const int BlendOutTriggerTime = 0x011C;

		///<summary>FName</summary>
		public const int SyncGroup = 0x0120;

		///<summary>int</summary>
		public const int SyncSlotIndex = 0x0128;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x012C;

		///<summary>FMarkerSyncData</summary>
		public const int MarkerData = 0x0130;

		///<summary>TArray&lt;FCompositeSection&gt;</summary>
		public const int CompositeSections = 0x0150;

		///<summary>TArray&lt;FSlotAnimationTrack&gt;</summary>
		public const int SlotAnimTracks = 0x0160;

		///<summary>TArray&lt;FBranchingPoint&gt;</summary>
		public const int BranchingPoints = 0x0170;

		///<summary>bool</summary>
		public const int bEnableRootMotionTranslation = 0x0180;

		///<summary>bool</summary>
		public const int bEnableRootMotionRotation = 0x0181;

		///<summary>TEnumAsByte&lt;ERootMotionRootLock&gt;</summary>
		public const int RootMotionRootLock = 0x0182;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData02 = 0x0183;

		///<summary>TArray&lt;FBranchingPointMarker&gt;</summary>
		public const int BranchingPointMarkers = 0x0188;

		///<summary>TArray&lt;int&gt;</summary>
		public const int BranchingPointStateNotifyIndices = 0x0198;

	}

	public class UProjectileMovementComponent
	{
		///<summary>float</summary>
		public const int InitialSpeed = 0x0220;

		///<summary>float</summary>
		public const int MaxSpeed = 0x0224;

		///<summary>unsigned char:1</summary>
		public const int bRotationFollowsVelocity = 0x0228;

		///<summary>unsigned char:1</summary>
		public const int bShouldBounce = 0x0228;

		///<summary>unsigned char:1</summary>
		public const int bInitialVelocityInLocalSpace = 0x0228;

		///<summary>unsigned char:1</summary>
		public const int bForceSubStepping = 0x0228;

		///<summary>unsigned char:1</summary>
		public const int bIsHomingProjectile = 0x0228;

		///<summary>unsigned char:1</summary>
		public const int bBounceAngleAffectsFriction = 0x0228;

		///<summary>unsigned char:1</summary>
		public const int bIsSliding = 0x0228;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0229;

		///<summary>float</summary>
		public const int PreviousHitTime = 0x022C;

		///<summary>FVector</summary>
		public const int PreviousHitNormal = 0x0230;

		///<summary>float</summary>
		public const int ProjectileGravityScale = 0x023C;

		///<summary>float</summary>
		public const int Buoyancy = 0x0240;

		///<summary>float</summary>
		public const int Bounciness = 0x0244;

		///<summary>float</summary>
		public const int Friction = 0x0248;

		///<summary>float</summary>
		public const int BounceVelocityStopSimulatingThreshold = 0x024C;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnProjectileBounce = 0x0250;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnProjectileStop = 0x0260;

		///<summary>float</summary>
		public const int HomingAccelerationMagnitude = 0x0270;

		///<summary>TWeakObjectPtr&lt;USceneComponent&gt;</summary>
		public const int HomingTargetComponent = 0x0274;

		///<summary>float</summary>
		public const int MaxSimulationTimeStep = 0x027C;

		///<summary>int</summary>
		public const int MaxSimulationIterations = 0x0280;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0284;

	}

	public class URotatingMovementComponent
	{
		///<summary>FRotator</summary>
		public const int RotationRate = 0x0220;

		///<summary>FVector</summary>
		public const int PivotTranslation = 0x022C;

		///<summary>unsigned char:1</summary>
		public const int bRotationInLocalSpace = 0x0238;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0239;

	}

	public class UNavRelevantComponent
	{
		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>unsigned char:1</summary>
		public const int bAttachToOwnersRoot = 0x01FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x01FD;

		///<summary>UObject *</summary>
		public const int CachedNavParent = 0x0200;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0208;

	}

	public class UNavLinkCustomComponent
	{
		///<summary>uint32_t</summary>
		public const int NavLinkUserId = 0x0210;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0214;

		///<summary>UClass *</summary>
		public const int EnabledAreaClass = 0x0218;

		///<summary>UClass *</summary>
		public const int DisabledAreaClass = 0x0220;

		///<summary>FVector</summary>
		public const int LinkRelativeStart = 0x0228;

		///<summary>FVector</summary>
		public const int LinkRelativeEnd = 0x0234;

		///<summary>TEnumAsByte&lt;ENavLinkDirection&gt;</summary>
		public const int LinkDirection = 0x0240;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0241;

		///<summary>unsigned char:1</summary>
		public const int bLinkEnabled = 0x0244;

		///<summary>unsigned char:1</summary>
		public const int bNotifyWhenEnabled = 0x0244;

		///<summary>unsigned char:1</summary>
		public const int bNotifyWhenDisabled = 0x0244;

		///<summary>unsigned char:1</summary>
		public const int bCreateBoxObstacle = 0x0244;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0245;

		///<summary>FVector</summary>
		public const int ObstacleOffset = 0x0248;

		///<summary>FVector</summary>
		public const int ObstacleExtent = 0x0254;

		///<summary>UClass *</summary>
		public const int ObstacleAreaClass = 0x0260;

		///<summary>float</summary>
		public const int BroadcastRadius = 0x0268;

		///<summary>float</summary>
		public const int BroadcastInterval = 0x026C;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int BroadcastChannel = 0x0270;

		///<summary>unsigned char[0xAF]</summary>
		public const int UnknownData03 = 0x0271;

	}

	public class UNavModifierComponent
	{
		///<summary>FVector</summary>
		public const int FailsafeExtent = 0x0210;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData00 = 0x021C;

	}

	public class UPawnNoiseEmitterComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>float</summary>
		public const int NoiseLifetime = 0x01E8;

		///<summary>float</summary>
		public const int LastRemoteNoiseVolume = 0x01EC;

		///<summary>float</summary>
		public const int LastRemoteNoiseTime = 0x01F0;

		///<summary>float</summary>
		public const int LastLocalNoiseVolume = 0x01F4;

		///<summary>float</summary>
		public const int LastLocalNoiseTime = 0x01F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01FC;

	}

	public class UPhysicalAnimationComponent
	{
		///<summary>USkeletalMeshComponent *</summary>
		public const int SkeletalMeshComponent = 0x01E0;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x01E8;

	}

	public class UPhysicsHandleComponent
	{
		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>unsigned char:1</summary>
		public const int UnknownData01 = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bSoftAngularConstraint = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bSoftLinearConstraint = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bInterpolateTarget = 0x01EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x01ED;

		///<summary>float</summary>
		public const int LinearDamping = 0x01F0;

		///<summary>float</summary>
		public const int LinearStiffness = 0x01F4;

		///<summary>float</summary>
		public const int AngularDamping = 0x01F8;

		///<summary>float</summary>
		public const int AngularStiffness = 0x01FC;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData03 = 0x0200;

		///<summary>float</summary>
		public const int InterpolationSpeed = 0x0260;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData04 = 0x0264;

	}

	public class UPlatformEventsComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int PlatformChangedToTabletModeDelegate = 0x01E8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x01F8;

	}

	public class UAtmosphericFogComponent
	{
		///<summary>float</summary>
		public const int SunMultiplier = 0x03F0;

		///<summary>float</summary>
		public const int FogMultiplier = 0x03F4;

		///<summary>float</summary>
		public const int DensityMultiplier = 0x03F8;

		///<summary>float</summary>
		public const int DensityOffset = 0x03FC;

		///<summary>float</summary>
		public const int DistanceScale = 0x0400;

		///<summary>float</summary>
		public const int AltitudeScale = 0x0404;

		///<summary>float</summary>
		public const int DistanceOffset = 0x0408;

		///<summary>float</summary>
		public const int GroundOffset = 0x040C;

		///<summary>float</summary>
		public const int StartDistance = 0x0410;

		///<summary>float</summary>
		public const int SunDiscScale = 0x0414;

		///<summary>TArray&lt;FFogHeightDensityPair&gt;</summary>
		public const int HeightDensityLayers = 0x0418;

		///<summary>float</summary>
		public const int DefaultBrightness = 0x0428;

		///<summary>FColor</summary>
		public const int DefaultLightColor = 0x042C;

		///<summary>unsigned char:1</summary>
		public const int bDisableSunDisk = 0x0430;

		///<summary>unsigned char:1</summary>
		public const int bDisableGroundScattering = 0x0430;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0431;

		///<summary>FAtmospherePrecomputeParameters</summary>
		public const int PrecomputeParams = 0x0434;

		///<summary>UTexture2D *</summary>
		public const int TransmittanceTexture = 0x0460;

		///<summary>UTexture2D *</summary>
		public const int IrradianceTexture = 0x0468;

		///<summary>unsigned char[0x190]</summary>
		public const int UnknownData01 = 0x0470;

	}

	public class USoundAttenuation
	{
		///<summary>FSoundAttenuationSettings</summary>
		public const int Attenuation = 0x0028;

	}

	public class UAudioComponent
	{
		///<summary>USoundBase *</summary>
		public const int Sound = 0x03F0;

		///<summary>TArray&lt;FAudioComponentParam&gt;</summary>
		public const int InstanceParameters = 0x03F8;

		///<summary>USoundClass *</summary>
		public const int SoundClassOverride = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bAutoDestroy = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bStopWhenOwnerDestroyed = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bShouldRemainActiveIfDropped = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bAllowSpatialization = 0x0410;

		///<summary>unsigned char:1</summary>
		public const int bOverrideAttenuation = 0x0410;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0411;

		///<summary>unsigned char:1</summary>
		public const int bOverrideSubtitlePriority = 0x0414;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0415;

		///<summary>unsigned char:1</summary>
		public const int bIsUISound = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bEnableLowPassFilter = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bOverridePriority = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bSuppressSubtitles = 0x0418;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0419;

		///<summary>FName</summary>
		public const int AudioComponentUserID = 0x0420;

		///<summary>float</summary>
		public const int PitchModulationMin = 0x0428;

		///<summary>float</summary>
		public const int PitchModulationMax = 0x042C;

		///<summary>float</summary>
		public const int VolumeModulationMin = 0x0430;

		///<summary>float</summary>
		public const int VolumeModulationMax = 0x0434;

		///<summary>float</summary>
		public const int VolumeMultiplier = 0x0438;

		///<summary>float</summary>
		public const int Priority = 0x043C;

		///<summary>float</summary>
		public const int SubtitlePriority = 0x0440;

		///<summary>float</summary>
		public const int VolumeWeightedPriorityScale = 0x0444;

		///<summary>float</summary>
		public const int PitchMultiplier = 0x0448;

		///<summary>float</summary>
		public const int HighFrequencyGainMultiplier = 0x044C;

		///<summary>float</summary>
		public const int LowPassFilterFrequency = 0x0450;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0454;

		///<summary>USoundAttenuation *</summary>
		public const int AttenuationSettings = 0x0458;

		///<summary>FSoundAttenuationSettings</summary>
		public const int AttenuationOverrides = 0x0460;

		///<summary>USoundConcurrency *</summary>
		public const int ConcurrencySettings = 0x0590;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0598;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnAudioFinished = 0x05A0;

		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData05 = 0x05B0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnAudioPlaybackPercent = 0x0620;

		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData06 = 0x0630;

		///<summary>FScriptDelegate</summary>
		public const int OnQueueSubtitles = 0x06A0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData07 = 0x06B0;

	}

	public class UDecalComponent
	{
		///<summary>UMaterialInterface *</summary>
		public const int DecalMaterial = 0x03F0;

		///<summary>int</summary>
		public const int SortOrder = 0x03F8;

		///<summary>float</summary>
		public const int FadeScreenSize = 0x03FC;

		///<summary>float</summary>
		public const int FadeStartDelay = 0x0400;

		///<summary>float</summary>
		public const int FadeDuration = 0x0404;

		///<summary>unsigned char:1</summary>
		public const int bDestroyOwnerAfterFade = 0x0408;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0409;

		///<summary>FVector</summary>
		public const int DecalSize = 0x040C;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0418;

	}

	public class UDistanceFieldCaptureComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03F0;

	}

	public class UExponentialHeightFogComponent
	{
		///<summary>float</summary>
		public const int FogDensity = 0x03F0;

		///<summary>FLinearColor</summary>
		public const int FogInscatteringColor = 0x03F4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0404;

		///<summary>TArray&lt;FFogHeightDensityPair2&gt;</summary>
		public const int HeightDensityLayers = 0x0408;

		///<summary>UTextureCube *</summary>
		public const int InscatteringColorCubemap = 0x0418;

		///<summary>float</summary>
		public const int InscatteringColorCubemapAngle = 0x0420;

		///<summary>FLinearColor</summary>
		public const int InscatteringTextureTint = 0x0424;

		///<summary>float</summary>
		public const int FullyDirectionalInscatteringColorDistance = 0x0434;

		///<summary>float</summary>
		public const int NonDirectionalInscatteringColorDistance = 0x0438;

		///<summary>float</summary>
		public const int DirectionalInscatteringExponent = 0x043C;

		///<summary>float</summary>
		public const int DirectionalInscatteringStartDistance = 0x0440;

		///<summary>FLinearColor</summary>
		public const int DirectionalInscatteringColor = 0x0444;

		///<summary>float</summary>
		public const int FogHeightFalloff = 0x0454;

		///<summary>float</summary>
		public const int FogMaxOpacity = 0x0458;

		///<summary>float</summary>
		public const int StartDistance = 0x045C;

		///<summary>float</summary>
		public const int FogCutoffDistance = 0x0460;

		///<summary>bool</summary>
		public const int bEnableVolumetricFog = 0x0464;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0465;

		///<summary>float</summary>
		public const int VolumetricFogScatteringDistribution = 0x0468;

		///<summary>FColor</summary>
		public const int VolumetricFogAlbedo = 0x046C;

		///<summary>FLinearColor</summary>
		public const int VolumetricFogEmissive = 0x0470;

		///<summary>float</summary>
		public const int VolumetricFogExtinctionScale = 0x0480;

		///<summary>float</summary>
		public const int VolumetricFogDistance = 0x0484;

		///<summary>bool</summary>
		public const int bOverrideLightColorsWithFogInscatteringColors = 0x0488;

		///<summary>bool</summary>
		public const int bUseExtendedFog = 0x0489;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x048A;

		///<summary>float</summary>
		public const int ExtendedFogStartDistance = 0x048C;

		///<summary>float</summary>
		public const int ExtendedFogStartFalloffDistance = 0x0490;

		///<summary>float</summary>
		public const int ExtendedHeight = 0x0494;

		///<summary>float</summary>
		public const int ExtendedFallOff = 0x0498;

		///<summary>float</summary>
		public const int ExtendedFogDensity = 0x049C;

		///<summary>float</summary>
		public const int UpDensity = 0x04A0;

		///<summary>float</summary>
		public const int DownDensity = 0x04A4;

		///<summary>float</summary>
		public const int Intensity = 0x04A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x04AC;

	}

	public class UForceFeedbackAttenuation
	{
		///<summary>FForceFeedbackAttenuationSettings</summary>
		public const int Attenuation = 0x0028;

	}

	public class UForceFeedbackComponent
	{
		///<summary>UForceFeedbackEffect *</summary>
		public const int ForceFeedbackEffect = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bAutoDestroy = 0x03F8;

		///<summary>unsigned char:1</summary>
		public const int bStopWhenOwnerDestroyed = 0x03F8;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x03F8;

		///<summary>unsigned char:1</summary>
		public const int bOverrideAttenuation = 0x03F8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F9;

		///<summary>float</summary>
		public const int IntensityMultiplier = 0x03FC;

		///<summary>UForceFeedbackAttenuation *</summary>
		public const int AttenuationSettings = 0x0400;

		///<summary>FForceFeedbackAttenuationSettings</summary>
		public const int AttenuationOverrides = 0x0408;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnForceFeedbackFinished = 0x04B0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x04C0;

	}

	public class ULightComponentBase
	{
		///<summary>FGuid</summary>
		public const int LightGuid = 0x03F0;

		///<summary>float</summary>
		public const int Brightness = 0x0400;

		///<summary>float</summary>
		public const int Intensity = 0x0404;

		///<summary>FColor</summary>
		public const int LightColor = 0x0408;

		///<summary>unsigned char:1</summary>
		public const int bAffectsWorld = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int CastShadows = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int CastStaticShadows = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int CastDynamicShadows = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int bAffectTranslucentLighting = 0x040C;

		///<summary>unsigned char:1</summary>
		public const int bCastVolumetricShadow = 0x040C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x040D;

		///<summary>float</summary>
		public const int IndirectLightingIntensity = 0x0410;

		///<summary>float</summary>
		public const int VolumetricScatteringIntensity = 0x0414;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0418;

	}

	public class ULightComponent
	{
		///<summary>float</summary>
		public const int MaxDistanceFadeRange = 0x0420;

		///<summary>unsigned char:1</summary>
		public const int bUseTemperature = 0x0424;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0425;

		///<summary>int</summary>
		public const int ShadowMapChannel = 0x0428;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x042C;

		///<summary>float</summary>
		public const int MinRoughness = 0x0430;

		///<summary>float</summary>
		public const int ShadowResolutionScale = 0x0434;

		///<summary>float</summary>
		public const int ShadowBias = 0x0438;

		///<summary>float</summary>
		public const int ShadowSharpen = 0x043C;

		///<summary>float</summary>
		public const int ContactShadowLength = 0x0440;

		///<summary>unsigned char:1</summary>
		public const int InverseSquaredFalloff = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int CastTranslucentShadows = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int bCastShadowsFromCinematicObjectsOnly = 0x0444;

		///<summary>unsigned char:1</summary>
		public const int bAffectDynamicIndirectLighting = 0x0444;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0445;

		///<summary>FLightingChannels</summary>
		public const int LightingChannels = 0x0448;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData03 = 0x044B;

		///<summary>UMaterialInterface *</summary>
		public const int LightFunctionMaterial = 0x0450;

		///<summary>FVector</summary>
		public const int LightFunctionScale = 0x0458;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x0464;

		///<summary>UTextureLightProfile *</summary>
		public const int IESTexture = 0x0468;

		///<summary>unsigned char:1</summary>
		public const int bUseIESBrightness = 0x0470;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0471;

		///<summary>float</summary>
		public const int IESBrightnessScale = 0x0474;

		///<summary>float</summary>
		public const int LightFunctionFadeDistance = 0x0478;

		///<summary>float</summary>
		public const int DisabledBrightness = 0x047C;

		///<summary>unsigned char:1</summary>
		public const int bEnableLightShaftBloom = 0x0480;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0481;

		///<summary>float</summary>
		public const int BloomScale = 0x0484;

		///<summary>float</summary>
		public const int BloomThreshold = 0x0488;

		///<summary>FColor</summary>
		public const int BloomTint = 0x048C;

		///<summary>bool</summary>
		public const int bUseRayTracedDistanceFieldShadows = 0x0490;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0491;

		///<summary>float</summary>
		public const int RayStartOffsetDepthScale = 0x0494;

		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData08 = 0x0498;

	}

	public class UDirectionalLightComponent
	{
		///<summary>float</summary>
		public const int OcclusionDepthRange = 0x0530;

		///<summary>FVector</summary>
		public const int LightShaftOverrideDirection = 0x0534;

		///<summary>float</summary>
		public const int WholeSceneDynamicShadowRadius = 0x0540;

		///<summary>float</summary>
		public const int DynamicShadowDistanceMovableLight = 0x0544;

		///<summary>float</summary>
		public const int DynamicShadowDistanceStationaryLight = 0x0548;

		///<summary>int</summary>
		public const int DynamicShadowCascades = 0x054C;

		///<summary>float</summary>
		public const int CascadeDistributionExponent = 0x0550;

		///<summary>float</summary>
		public const int CascadeTransitionFraction = 0x0554;

		///<summary>float</summary>
		public const int ShadowDistanceFadeoutFraction = 0x0558;

		///<summary>unsigned char:1</summary>
		public const int bUseInsetShadowsForMovableObjects = 0x055C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x055D;

		///<summary>int</summary>
		public const int FarShadowCascadeCount = 0x0560;

		///<summary>float</summary>
		public const int FarShadowDistance = 0x0564;

		///<summary>float</summary>
		public const int DistanceFieldShadowDistance = 0x0568;

		///<summary>float</summary>
		public const int LightSourceAngle = 0x056C;

		///<summary>float</summary>
		public const int TraceDistance = 0x0570;

		///<summary>FLightmassDirectionalLightSettings</summary>
		public const int LightmassSettings = 0x0574;

		///<summary>unsigned char:1</summary>
		public const int bCastModulatedShadows = 0x0584;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0585;

		///<summary>FColor</summary>
		public const int ModulatedShadowColor = 0x0588;

		///<summary>unsigned char:1</summary>
		public const int bUsedAsAtmosphereSunLight = 0x058C;

		///<summary>unsigned char:1</summary>
		public const int bUseGridShadow = 0x058C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x058D;

		///<summary>TArray&lt;FGridShadowSplitSettings&gt;</summary>
		public const int GridShadowSplitSettings = 0x0590;

	}

	public class UPointLightComponent
	{
		///<summary>unsigned char:1</summary>
		public const int bUseInverseSquaredFalloff = 0x0530;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0531;

		///<summary>float</summary>
		public const int LightFalloffExponent = 0x0534;

		///<summary>float</summary>
		public const int SourceRadius = 0x0538;

		///<summary>float</summary>
		public const int SourceLength = 0x053C;

		///<summary>FLightmassPointLightSettings</summary>
		public const int LightmassSettings = 0x0540;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x054C;

	}

	public class USpotLightComponent
	{
		///<summary>float</summary>
		public const int InnerConeAngle = 0x0550;

		///<summary>float</summary>
		public const int OuterConeAngle = 0x0554;

		///<summary>float</summary>
		public const int LightShaftConeAngle = 0x0558;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x055C;

	}

	public class USkyLightComponent
	{
		///<summary>UTextureCube *</summary>
		public const int Cubemap = 0x0420;

		///<summary>float</summary>
		public const int SourceCubemapAngle = 0x0428;

		///<summary>int</summary>
		public const int CubemapResolution = 0x042C;

		///<summary>float</summary>
		public const int SkyDistanceThreshold = 0x0430;

		///<summary>bool</summary>
		public const int bCaptureEmissiveOnly = 0x0434;

		///<summary>bool</summary>
		public const int bLowerHemisphereIsBlack = 0x0435;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0436;

		///<summary>FLinearColor</summary>
		public const int LowerHemisphereColor = 0x0438;

		///<summary>float</summary>
		public const int OcclusionMaxDistance = 0x0448;

		///<summary>float</summary>
		public const int Contrast = 0x044C;

		///<summary>float</summary>
		public const int OcclusionExponent = 0x0450;

		///<summary>float</summary>
		public const int MinOcclusion = 0x0454;

		///<summary>FColor</summary>
		public const int OcclusionTint = 0x0458;

		///<summary>TEnumAsByte&lt;EOcclusionCombineMode&gt;</summary>
		public const int OcclusionCombineMode = 0x045C;

		///<summary>unsigned char[0xAB]</summary>
		public const int UnknownData01 = 0x045D;

		///<summary>UTextureCube *</summary>
		public const int BlendDestinationCubemap = 0x0508;

		///<summary>unsigned char[0xC0]</summary>
		public const int UnknownData02 = 0x0510;

	}

	public class ULightmassPortalComponent
	{
		///<summary>UBoxComponent *</summary>
		public const int PreviewBox = 0x03F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03F8;

	}

	public class UNavigationGraphNodeComponent
	{
		///<summary>FNavGraphNode</summary>
		public const int Node = 0x03F0;

		///<summary>UNavigationGraphNodeComponent *</summary>
		public const int NextNodeComponent = 0x0408;

		///<summary>UNavigationGraphNodeComponent *</summary>
		public const int PrevNodeComponent = 0x0410;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0418;

	}

	public class UPhysicsConstraintComponent
	{
		///<summary>AActor *</summary>
		public const int ConstraintActor1 = 0x03F0;

		///<summary>FConstrainComponentPropName</summary>
		public const int ComponentName1 = 0x03F8;

		///<summary>AActor *</summary>
		public const int ConstraintActor2 = 0x0400;

		///<summary>FConstrainComponentPropName</summary>
		public const int ComponentName2 = 0x0408;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>UPhysicsConstraintTemplate *</summary>
		public const int ConstraintSetup = 0x0420;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnConstraintBroken = 0x0428;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0438;

		///<summary>FConstraintInstance</summary>
		public const int ConstraintInstance = 0x0440;

	}

	public class UPhysicsSpringComponent
	{
		///<summary>float</summary>
		public const int SpringStiffness = 0x03F0;

		///<summary>float</summary>
		public const int SpringDamping = 0x03F4;

		///<summary>float</summary>
		public const int SpringLengthAtRest = 0x03F8;

		///<summary>float</summary>
		public const int SpringRadius = 0x03FC;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int SpringChannel = 0x0400;

		///<summary>bool</summary>
		public const int bIgnoreSelf = 0x0401;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0402;

		///<summary>float</summary>
		public const int SpringCompression = 0x0404;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0408;

	}

	public class UPhysicsThrusterComponent
	{
		///<summary>float</summary>
		public const int ThrustStrength = 0x03F0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x03F4;

	}

	public class UPostProcessComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03F0;

		///<summary>FPostProcessSettings</summary>
		public const int Settings = 0x0400;

		///<summary>float</summary>
		public const int Priority = 0x0930;

		///<summary>float</summary>
		public const int BlendRadius = 0x0934;

		///<summary>float</summary>
		public const int BlendWeight = 0x0938;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x093C;

		///<summary>unsigned char:1</summary>
		public const int bUnbound = 0x093C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x093D;

	}

	public class UArrowComponent
	{
		///<summary>bool</summary>
		public const int bIsScreenSizeScaled = 0x0850;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0851;

		///<summary>float</summary>
		public const int ScreenSize = 0x0854;

		///<summary>unsigned char:1</summary>
		public const int bTreatAsASprite = 0x0858;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0859;

	}

	public class UBillboardComponent
	{
		///<summary>unsigned char:1</summary>
		public const int bIsScreenSizeScaled = 0x0850;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0851;

		///<summary>float</summary>
		public const int ScreenSize = 0x0854;

		///<summary>float</summary>
		public const int U = 0x0858;

		///<summary>float</summary>
		public const int UL = 0x085C;

		///<summary>float</summary>
		public const int V = 0x0860;

		///<summary>float</summary>
		public const int VL = 0x0864;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0868;

	}

	public class UBrushComponent
	{
		///<summary>UBodySetup *</summary>
		public const int BrushBodySetup = 0x0850;

		///<summary>FVector</summary>
		public const int PrePivot = 0x0858;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0864;

	}

	public class UDrawFrustumComponent
	{
		///<summary>float</summary>
		public const int FrustumAspectRatio = 0x0850;

		///<summary>float</summary>
		public const int FrustumStartDist = 0x0854;

		///<summary>float</summary>
		public const int FrustumEndDist = 0x0858;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x085C;

		///<summary>UTexture *</summary>
		public const int Texture = 0x0860;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0868;

	}

	public class ULineBatchComponent
	{
		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x0850;

	}

	public class UMaterialBillboardComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0850;

	}

	public class UPoseableMeshComponent
	{
		///<summary>unsigned char[0xF0]</summary>
		public const int UnknownData00 = 0x0AD0;

	}

	public class USkeletalMeshComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0AD0;

		///<summary>TEnumAsByte&lt;EAnimationMode&gt;</summary>
		public const int AnimationMode = 0x0AD8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0AD9;

		///<summary>UAnimBlueprintGeneratedClass *</summary>
		public const int AnimBlueprintGeneratedClass = 0x0AE0;

		///<summary>UClass *</summary>
		public const int AnimClass = 0x0AE8;

		///<summary>UAnimInstance *</summary>
		public const int AnimScriptInstance = 0x0AF0;

		///<summary>TArray&lt;UAnimInstance * &gt;</summary>
		public const int SubInstances = 0x0AF8;

		///<summary>UAnimInstance *</summary>
		public const int PostProcessAnimInstance = 0x0B08;

		///<summary>FSingleAnimationPlayData</summary>
		public const int AnimationData = 0x0B10;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData02 = 0x0B28;

		///<summary>TArray&lt;FTransform&gt;</summary>
		public const int CachedBoneSpaceTransforms = 0x0B60;

		///<summary>TArray&lt;FTransform&gt;</summary>
		public const int CachedComponentSpaceTransforms = 0x0B70;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData03 = 0x0B80;

		///<summary>float</summary>
		public const int GlobalAnimRateScale = 0x0BA0;

		///<summary>EDynamicActorScene</summary>
		public const int UseAsyncScene = 0x0BA4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0BA5;

		///<summary>unsigned char:1</summary>
		public const int bHasValidBodies = 0x0BA8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0BA9;

		///<summary>TEnumAsByte&lt;EKinematicBonesUpdateToPhysics&gt;</summary>
		public const int KinematicBonesUpdateType = 0x0BAC;

		///<summary>TEnumAsByte&lt;EPhysicsTransformUpdateMode&gt;</summary>
		public const int PhysicsTransformUpdateMode = 0x0BAD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData06 = 0x0BAE;

		///<summary>unsigned char:1</summary>
		public const int bBlendPhysics = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bEnablePhysicsOnDedicatedServer = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bUpdateJointsFromAnimation = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bDisableClothSimulation = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bCollideWithEnvironment = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bCollideWithAttachedChildren = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bLocalSpaceSimulation = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bClothMorphTarget = 0x0BB0;

		///<summary>unsigned char:1</summary>
		public const int bResetAfterTeleport = 0x0BB1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData07 = 0x0BB2;

		///<summary>float</summary>
		public const int TeleportDistanceThreshold = 0x0BB4;

		///<summary>float</summary>
		public const int TeleportRotationThreshold = 0x0BB8;

		///<summary>float</summary>
		public const int ClothBlendWeight = 0x0BBC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x0BC0;

		///<summary>FVector</summary>
		public const int RootBoneTranslation = 0x0BC4;

		///<summary>unsigned char:1</summary>
		public const int bNoSkeletonUpdate = 0x0BD0;

		///<summary>unsigned char:1</summary>
		public const int bPauseAnims = 0x0BD0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x0BD1;

		///<summary>bool</summary>
		public const int bUseRefPoseOnInitAnim = 0x0BD4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x0BD5;

		///<summary>unsigned char:1</summary>
		public const int bEnablePerPolyCollision = 0x0BD8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData11 = 0x0BD9;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x0BE0;

		///<summary>unsigned char:1</summary>
		public const int bOnlyAllowAutonomousTickPose = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bIsAutonomousTickPose = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bForceRefpose = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bOldForceRefPose = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bShowPrePhysBones = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bRequiredBonesUpToDate = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bAnimTreeInitialised = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bIncludeComponentLocationIntoBounds = 0x0BE8;

		///<summary>unsigned char:1</summary>
		public const int bEnableLineCheckWithBounds = 0x0BE9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData12 = 0x0BEA;

		///<summary>uint16_t</summary>
		public const int CachedAnimCurveUidVersion = 0x0BEC;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData13 = 0x0BEE;

		///<summary>FVector</summary>
		public const int LineCheckBoundsScale = 0x0BF0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData14 = 0x0BFC;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnConstraintBroken = 0x0C00;

		///<summary>unsigned char[0xF0]</summary>
		public const int UnknownData15 = 0x0C10;

		///<summary>UClass *</summary>
		public const int ClothingSimulationFactory = 0x0D00;

		///<summary>unsigned char[0x200]</summary>
		public const int UnknownData16 = 0x0D08;

		///<summary>UAnimSequence *</summary>
		public const int SequenceToPlay = 0x0F08;

		///<summary>UAnimationAsset *</summary>
		public const int AnimToPlay = 0x0F10;

		///<summary>unsigned char:1</summary>
		public const int bDefaultLooping = 0x0F18;

		///<summary>unsigned char:1</summary>
		public const int bDefaultPlaying = 0x0F18;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData17 = 0x0F19;

		///<summary>float</summary>
		public const int DefaultPosition = 0x0F1C;

		///<summary>float</summary>
		public const int DefaultPlayRate = 0x0F20;

		///<summary>uint32_t</summary>
		public const int LastPoseTickFrame = 0x0F24;

		///<summary>float</summary>
		public const int LastPoseTickTime = 0x0F28;

		///<summary>unsigned char[0xE4]</summary>
		public const int UnknownData18 = 0x0F2C;

	}

	public class USplineMeshComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x09E0;

		///<summary>FSplineMeshParams</summary>
		public const int SplineParams = 0x09E8;

		///<summary>FVector</summary>
		public const int SplineUpDir = 0x0A40;

		///<summary>unsigned char:1</summary>
		public const int bAllowSplineEditingPerInstance = 0x0A4C;

		///<summary>unsigned char:1</summary>
		public const int bSmoothInterpRollScale = 0x0A4C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0A4D;

		///<summary>TEnumAsByte&lt;ESplineMeshAxis&gt;</summary>
		public const int ForwardAxis = 0x0A50;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0A51;

		///<summary>float</summary>
		public const int SplineBoundaryMin = 0x0A54;

		///<summary>float</summary>
		public const int SplineBoundaryMax = 0x0A58;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0A5C;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x0A60;

		///<summary>FGuid</summary>
		public const int CachedMeshBodySetupGuid = 0x0A68;

		///<summary>unsigned char:1</summary>
		public const int bMeshDirty = 0x0A78;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0A79;

	}

	public class UModelComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0850;

		///<summary>UBodySetup *</summary>
		public const int ModelBodySetup = 0x0860;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData01 = 0x0868;

	}

	public class UNavLinkComponent
	{
		///<summary>TArray&lt;FNavigationLink&gt;</summary>
		public const int Links = 0x0850;

	}

	public class UNavMeshRenderingComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0850;

	}

	public class UCapsuleComponent
	{
		///<summary>float</summary>
		public const int CapsuleHeight = 0x0870;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0874;

	}

	public class UTextRenderComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0850;

		///<summary>UMaterialInterface *</summary>
		public const int TextMaterial = 0x0860;

		///<summary>UFont *</summary>
		public const int Font = 0x0868;

		///<summary>TEnumAsByte&lt;EHorizTextAligment&gt;</summary>
		public const int HorizontalAlignment = 0x0870;

		///<summary>TEnumAsByte&lt;EVerticalTextAligment&gt;</summary>
		public const int VerticalAlignment = 0x0871;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0872;

		///<summary>FColor</summary>
		public const int TextRenderColor = 0x0874;

		///<summary>float</summary>
		public const int XScale = 0x0878;

		///<summary>float</summary>
		public const int YScale = 0x087C;

		///<summary>float</summary>
		public const int WorldSize = 0x0880;

		///<summary>float</summary>
		public const int InvDefaultSize = 0x0884;

		///<summary>float</summary>
		public const int HorizSpacingAdjust = 0x0888;

		///<summary>float</summary>
		public const int VertSpacingAdjust = 0x088C;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysRenderAsText = 0x0890;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData02 = 0x0891;

	}

	public class UVectorFieldComponent
	{
		///<summary>float</summary>
		public const int Intensity = 0x0850;

		///<summary>float</summary>
		public const int Tightness = 0x0854;

		///<summary>unsigned char:1</summary>
		public const int bPreviewVectorField = 0x0858;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData00 = 0x0859;

	}

	public class URadialForceComponent
	{
		///<summary>float</summary>
		public const int Radius = 0x03F0;

		///<summary>TEnumAsByte&lt;ERadialImpulseFalloff&gt;</summary>
		public const int Falloff = 0x03F4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F5;

		///<summary>float</summary>
		public const int ImpulseStrength = 0x03F8;

		///<summary>unsigned char:1</summary>
		public const int bImpulseVelChange = 0x03FC;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreOwningActor = 0x03FC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03FD;

		///<summary>float</summary>
		public const int ForceStrength = 0x0400;

		///<summary>float</summary>
		public const int DestructibleDamage = 0x0404;

		///<summary>TArray&lt;TEnumAsByte&lt;EObjectTypeQuery&gt;&gt;</summary>
		public const int ObjectTypesToAffect = 0x0408;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0418;

	}

	public class UReflectionCaptureComponent
	{
		///<summary>UBillboardComponent *</summary>
		public const int CaptureOffsetComponent = 0x03F0;

		///<summary>EReflectionSourceType</summary>
		public const int ReflectionSourceType = 0x03F8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03F9;

		///<summary>UTextureCube *</summary>
		public const int Cubemap = 0x0400;

		///<summary>float</summary>
		public const int SourceCubemapAngle = 0x0408;

		///<summary>float</summary>
		public const int Brightness = 0x040C;

		///<summary>FVector</summary>
		public const int CaptureOffset = 0x0410;

		///<summary>bool</summary>
		public const int bSharedComponent = 0x041C;

		///<summary>unsigned char[0x23]</summary>
		public const int UnknownData01 = 0x041D;

		///<summary>FGuid</summary>
		public const int StateId = 0x0440;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData02 = 0x0450;

	}

	public class UBoxReflectionCaptureComponent
	{
		///<summary>float</summary>
		public const int BoxTransitionDistance = 0x0480;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0484;

		///<summary>UBoxComponent *</summary>
		public const int PreviewInfluenceBox = 0x0488;

		///<summary>UBoxComponent *</summary>
		public const int PreviewCaptureBox = 0x0490;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0498;

	}

	public class UPlaneReflectionCaptureComponent
	{
		///<summary>float</summary>
		public const int InfluenceRadiusScale = 0x0480;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0484;

		///<summary>UDrawSphereComponent *</summary>
		public const int PreviewInfluenceRadius = 0x0488;

		///<summary>UBoxComponent *</summary>
		public const int PreviewCaptureBox = 0x0490;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0498;

	}

	public class USphereReflectionCaptureComponent
	{
		///<summary>float</summary>
		public const int InfluenceRadius = 0x0480;

		///<summary>float</summary>
		public const int CaptureDistanceScale = 0x0484;

		///<summary>UDrawSphereComponent *</summary>
		public const int PreviewInfluenceRadius = 0x0488;

	}

	public class UPlanarReflectionComponent
	{
		///<summary>UBoxComponent *</summary>
		public const int PreviewBox = 0x0470;

		///<summary>float</summary>
		public const int NormalDistortionStrength = 0x0478;

		///<summary>float</summary>
		public const int PrefilterRoughness = 0x047C;

		///<summary>float</summary>
		public const int PrefilterRoughnessDistance = 0x0480;

		///<summary>int</summary>
		public const int ScreenPercentage = 0x0484;

		///<summary>float</summary>
		public const int ExtraFOV = 0x0488;

		///<summary>float</summary>
		public const int DistanceFromPlaneFadeStart = 0x048C;

		///<summary>float</summary>
		public const int DistanceFromPlaneFadeEnd = 0x0490;

		///<summary>float</summary>
		public const int DistanceFromPlaneFadeoutStart = 0x0494;

		///<summary>float</summary>
		public const int DistanceFromPlaneFadeoutEnd = 0x0498;

		///<summary>float</summary>
		public const int AngleFromPlaneFadeStart = 0x049C;

		///<summary>float</summary>
		public const int AngleFromPlaneFadeEnd = 0x04A0;

		///<summary>bool</summary>
		public const int bRenderSceneTwoSided = 0x04A4;

		///<summary>unsigned char[0xCB]</summary>
		public const int UnknownData00 = 0x04A5;

	}

	public class USceneCaptureComponentCube
	{
		///<summary>UTextureRenderTargetCube *</summary>
		public const int TextureTarget = 0x0470;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0478;

	}

	public class UStereoLayerComponent
	{
		///<summary>unsigned char:1</summary>
		public const int bLiveTexture = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bSupportsDepth = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bNoAlphaChannel = 0x03F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03F1;

		///<summary>UTexture *</summary>
		public const int Texture = 0x03F8;

		///<summary>UTexture *</summary>
		public const int LeftTexture = 0x0400;

		///<summary>unsigned char:1</summary>
		public const int bQuadPreserveTextureRatio = 0x0408;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0409;

		///<summary>FVector2D</summary>
		public const int QuadSize = 0x040C;

		///<summary>FBox2D</summary>
		public const int UVRect = 0x0414;

		///<summary>float</summary>
		public const int CylinderRadius = 0x0428;

		///<summary>float</summary>
		public const int CylinderOverlayArc = 0x042C;

		///<summary>int</summary>
		public const int CylinderHeight = 0x0430;

		///<summary>TEnumAsByte&lt;EStereoLayerType&gt;</summary>
		public const int StereoLayerType = 0x0434;

		///<summary>TEnumAsByte&lt;EStereoLayerShape&gt;</summary>
		public const int StereoLayerShape = 0x0435;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x0436;

		///<summary>int</summary>
		public const int Priority = 0x0438;

		///<summary>unsigned char[0x54]</summary>
		public const int UnknownData03 = 0x043C;

	}

	public class UWindDirectionalSourceComponent
	{
		///<summary>float</summary>
		public const int Strength = 0x03F0;

		///<summary>float</summary>
		public const int Speed = 0x03F4;

		///<summary>float</summary>
		public const int MinGustAmount = 0x03F8;

		///<summary>float</summary>
		public const int MaxGustAmount = 0x03FC;

		///<summary>float</summary>
		public const int Radius = 0x0400;

		///<summary>unsigned char:1</summary>
		public const int bPointWind = 0x0404;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData00 = 0x0405;

	}

	public class UTimelineComponent
	{
		///<summary>FTimeline</summary>
		public const int TheTimeline = 0x01E0;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreTimeDilation = 0x02C0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x02C1;

	}

	public class UAnimComposite
	{
		///<summary>FAnimTrack</summary>
		public const int AnimationTrack = 0x00A0;

	}

	public class UAnimSequence
	{
		///<summary>int</summary>
		public const int NumFrames = 0x00A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00A4;

		///<summary>TArray&lt;FTrackToSkeletonMap&gt;</summary>
		public const int TrackToSkeletonMapTable = 0x00A8;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData01 = 0x00B8;

		///<summary>TEnumAsByte&lt;EAdditiveAnimationType&gt;</summary>
		public const int AdditiveAnimType = 0x0148;

		///<summary>TEnumAsByte&lt;EAdditiveBasePoseType&gt;</summary>
		public const int RefPoseType = 0x0149;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x014A;

		///<summary>UAnimSequence *</summary>
		public const int RefPoseSeq = 0x0150;

		///<summary>int</summary>
		public const int RefFrameIndex = 0x0158;

		///<summary>int</summary>
		public const int EncodingPkgVersion = 0x015C;

		///<summary>FName</summary>
		public const int RetargetSource = 0x0160;

		///<summary>EAnimInterpolationType</summary>
		public const int Interpolation = 0x0168;

		///<summary>bool</summary>
		public const int bEnableRootMotion = 0x0169;

		///<summary>TEnumAsByte&lt;ERootMotionRootLock&gt;</summary>
		public const int RootMotionRootLock = 0x016A;

		///<summary>bool</summary>
		public const int bForceRootLock = 0x016B;

		///<summary>bool</summary>
		public const int bRootMotionSettingsCopiedFromMontage = 0x016C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x016D;

		///<summary>TArray&lt;FAnimSyncMarker&gt;</summary>
		public const int AuthoredSyncMarkers = 0x0170;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData04 = 0x0180;

	}

	public class UBlendSpaceBase
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0078;

		///<summary>bool</summary>
		public const int bRotationBlendInMeshSpace = 0x0080;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0081;

		///<summary>float</summary>
		public const int AnimLength = 0x0084;

		///<summary>TArray&lt;FPerBoneInterpolation&gt;</summary>
		public const int PerBoneBlend = 0x0088;

		///<summary>FInterpolationParameter[0x3]</summary>
		public const int InterpolationParam = 0x0098;

		///<summary>float</summary>
		public const int TargetWeightInterpolationSpeedPerSec = 0x00B0;

		///<summary>TEnumAsByte&lt;ENotifyTriggerMode&gt;</summary>
		public const int NotifyTriggerMode = 0x00B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00B5;

		///<summary>int</summary>
		public const int SampleIndexWithMarkers = 0x00B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x00BC;

		///<summary>TArray&lt;FBlendSample&gt;</summary>
		public const int SampleData = 0x00C0;

		///<summary>TArray&lt;FEditorElement&gt;</summary>
		public const int GridSamples = 0x00D0;

		///<summary>FBlendParameter[0x3]</summary>
		public const int BlendParameters = 0x00E0;

	}

	public class UBlendSpace
	{
		///<summary>TEnumAsByte&lt;EBlendSpaceAxis&gt;</summary>
		public const int AxisToScaleAnimation = 0x0140;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0141;

	}

	public class UBlendSpace1D
	{
		///<summary>bool</summary>
		public const int bScaleAnimation = 0x0140;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0141;

	}

	public class UPoseAsset
	{
		///<summary>FPoseDataContainer</summary>
		public const int PoseContainer = 0x0078;

		///<summary>bool</summary>
		public const int bAdditivePose = 0x0108;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0109;

		///<summary>int</summary>
		public const int BasePoseIndex = 0x010C;

		///<summary>FName</summary>
		public const int RetargetSource = 0x0110;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData01 = 0x0118;

	}

	public class UAnimClassData
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FBakedAnimationStateMachine&gt;</summary>
		public const int BakedStateMachines = 0x0030;

		///<summary>USkeleton *</summary>
		public const int TargetSkeleton = 0x0040;

		///<summary>TArray&lt;FAnimNotifyEvent&gt;</summary>
		public const int AnimNotifies = 0x0048;

		///<summary>int</summary>
		public const int RootAnimNodeIndex = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x005C;

		///<summary>TArray&lt;int&gt;</summary>
		public const int OrderedSavedPoseIndices = 0x0060;

		///<summary>UStructProperty *</summary>
		public const int RootAnimNodeProperty = 0x0070;

		///<summary>TArray&lt;UStructProperty * &gt;</summary>
		public const int AnimNodeProperties = 0x0078;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int SyncGroupNames = 0x0088;

	}

	public class UAnimCompress
	{
		///<summary>FString</summary>
		public const int Description = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bNeedsSkeleton = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>TEnumAsByte&lt;EAnimationCompressionFormat&gt;</summary>
		public const int TranslationCompressionFormat = 0x003C;

		///<summary>TEnumAsByte&lt;EAnimationCompressionFormat&gt;</summary>
		public const int RotationCompressionFormat = 0x003D;

		///<summary>TEnumAsByte&lt;EAnimationCompressionFormat&gt;</summary>
		public const int ScaleCompressionFormat = 0x003E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x003F;

		///<summary>float</summary>
		public const int MaxCurveError = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0044;

	}

	public class UAnimCompress_Automatic
	{
		///<summary>float</summary>
		public const int MaxEndEffectorError = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bTryFixedBitwiseCompression = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bTryPerTrackBitwiseCompression = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bTryLinearKeyRemovalCompression = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bTryIntervalKeyRemoval = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bRunCurrentDefaultCompressor = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bAutoReplaceIfExistingErrorTooGreat = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bRaiseMaxErrorToExisting = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x004D;

	}

	public class UAnimCompress_RemoveEverySecondKey
	{
		///<summary>int</summary>
		public const int MinKeys = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bStartAtSecondKey = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x004D;

	}

	public class UAnimCompress_RemoveLinearKeys
	{
		///<summary>float</summary>
		public const int MaxPosDiff = 0x0048;

		///<summary>float</summary>
		public const int MaxAngleDiff = 0x004C;

		///<summary>float</summary>
		public const int MaxScaleDiff = 0x0050;

		///<summary>float</summary>
		public const int MaxEffectorDiff = 0x0054;

		///<summary>float</summary>
		public const int MinEffectorDiff = 0x0058;

		///<summary>float</summary>
		public const int EffectorDiffSocket = 0x005C;

		///<summary>float</summary>
		public const int ParentKeyScale = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bRetarget = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bActuallyFilterLinearKeys = 0x0064;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0065;

	}

	public class UAnimCompress_PerTrackCompression
	{
		///<summary>float</summary>
		public const int MaxZeroingThreshold = 0x0068;

		///<summary>float</summary>
		public const int MaxPosDiffBitwise = 0x006C;

		///<summary>float</summary>
		public const int MaxAngleDiffBitwise = 0x0070;

		///<summary>float</summary>
		public const int MaxScaleDiffBitwise = 0x0074;

		///<summary>TArray&lt;TEnumAsByte&lt;EAnimationCompressionFormat&gt;&gt;</summary>
		public const int AllowedRotationFormats = 0x0078;

		///<summary>TArray&lt;TEnumAsByte&lt;EAnimationCompressionFormat&gt;&gt;</summary>
		public const int AllowedTranslationFormats = 0x0088;

		///<summary>TArray&lt;TEnumAsByte&lt;EAnimationCompressionFormat&gt;&gt;</summary>
		public const int AllowedScaleFormats = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bResampleAnimation = 0x00A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00A9;

		///<summary>float</summary>
		public const int ResampledFramerate = 0x00AC;

		///<summary>int</summary>
		public const int MinKeysForResampling = 0x00B0;

		///<summary>unsigned char:1</summary>
		public const int bUseAdaptiveError = 0x00B4;

		///<summary>unsigned char:1</summary>
		public const int bUseOverrideForEndEffectors = 0x00B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00B5;

		///<summary>int</summary>
		public const int TrackHeightBias = 0x00B8;

		///<summary>float</summary>
		public const int ParentingDivisor = 0x00BC;

		///<summary>float</summary>
		public const int ParentingDivisorExponent = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bUseAdaptiveError2 = 0x00C4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00C5;

		///<summary>float</summary>
		public const int RotationErrorSourceRatio = 0x00C8;

		///<summary>float</summary>
		public const int TranslationErrorSourceRatio = 0x00CC;

		///<summary>float</summary>
		public const int ScaleErrorSourceRatio = 0x00D0;

		///<summary>float</summary>
		public const int MaxErrorPerTrackRatio = 0x00D4;

		///<summary>float</summary>
		public const int PerturbationProbeSize = 0x00D8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData03 = 0x00DC;

	}

	public class UAnimCompress_RemoveTrivialKeys
	{
		///<summary>float</summary>
		public const int MaxPosDiff = 0x0048;

		///<summary>float</summary>
		public const int MaxAngleDiff = 0x004C;

		///<summary>float</summary>
		public const int MaxScaleDiff = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UAnimSingleNodeInstance
	{
		///<summary>UAnimationAsset *</summary>
		public const int CurrentAsset = 0x0378;

		///<summary>FScriptDelegate</summary>
		public const int PostEvaluateAnimEvent = 0x0380;

	}

	public class UAnimNotify_PlayParticleEffect
	{
		///<summary>UParticleSystem *</summary>
		public const int PSTemplate = 0x0038;

		///<summary>FVector</summary>
		public const int LocationOffset = 0x0040;

		///<summary>FRotator</summary>
		public const int RotationOffset = 0x004C;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int Attached = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0071;

		///<summary>FName</summary>
		public const int SocketName = 0x0078;

	}

	public class UAnimNotify_PlaySound
	{
		///<summary>USoundBase *</summary>
		public const int Sound = 0x0038;

		///<summary>float</summary>
		public const int VolumeMultiplier = 0x0040;

		///<summary>float</summary>
		public const int PitchMultiplier = 0x0044;

		///<summary>unsigned char:1</summary>
		public const int bFollow = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>FName</summary>
		public const int AttachName = 0x0050;

	}

	public class UAnimNotifyState_TimedParticleEffect
	{
		///<summary>UParticleSystem *</summary>
		public const int PSTemplate = 0x0030;

		///<summary>FName</summary>
		public const int SocketName = 0x0038;

		///<summary>FVector</summary>
		public const int LocationOffset = 0x0040;

		///<summary>FRotator</summary>
		public const int RotationOffset = 0x004C;

		///<summary>bool</summary>
		public const int bDestroyAtEnd = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0059;

	}

	public class UAnimNotifyState_Trail
	{
		///<summary>UParticleSystem *</summary>
		public const int PSTemplate = 0x0030;

		///<summary>FName</summary>
		public const int FirstSocketName = 0x0038;

		///<summary>FName</summary>
		public const int SecondSocketName = 0x0040;

		///<summary>TEnumAsByte&lt;ETrailWidthMode&gt;</summary>
		public const int WidthScaleMode = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>FName</summary>
		public const int WidthScaleCurve = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bRecycleSpawnedSystems = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0059;

	}

	public class UAnimSet
	{
		///<summary>unsigned char:1</summary>
		public const int bAnimRotationOnly = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int TrackBoneNames = 0x0030;

		///<summary>TArray&lt;FAnimSetMeshLinkup&gt;</summary>
		public const int LinkupCache = 0x0040;

		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int BoneUseAnimTranslation = 0x0050;

		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int ForceUseMeshTranslation = 0x0060;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int UseTranslationBoneNames = 0x0070;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int ForceMeshTranslationBoneNames = 0x0080;

		///<summary>FName</summary>
		public const int PreviewSkelMeshName = 0x0090;

		///<summary>FName</summary>
		public const int BestRatioSkelMeshName = 0x0098;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x00A0;

	}

	public class UAssetManager
	{
		///<summary>unsigned char[0x260]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int ObjectReferenceList = 0x0288;

		///<summary>bool</summary>
		public const int bIsGlobalAsyncScanEnvironment = 0x0298;

		///<summary>bool</summary>
		public const int bShouldKeepHardRefs = 0x0299;

		///<summary>bool</summary>
		public const int bShouldGuessTypeAndName = 0x029A;

		///<summary>bool</summary>
		public const int bShouldUseSynchronousLoad = 0x029B;

		///<summary>bool</summary>
		public const int bIsBulkScanning = 0x029C;

		///<summary>bool</summary>
		public const int bIsManagementDatabaseCurrent = 0x029D;

		///<summary>bool</summary>
		public const int bUpdateManagementDatabaseAfterScan = 0x029E;

		///<summary>unsigned char[0x101]</summary>
		public const int UnknownData01 = 0x029F;

	}

	public class UAssetMappingTable
	{
		///<summary>TArray&lt;FAssetMapping&gt;</summary>
		public const int MappedAssets = 0x0028;

	}

	public class UAutomationTestSettings
	{
		///<summary>TArray&lt;FString&gt;</summary>
		public const int EngineTestModules = 0x0028;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int EditorTestModules = 0x0038;

		///<summary>FStringAssetReference</summary>
		public const int AutomationTestmap = 0x0048;

		///<summary>TArray&lt;FEditorMapPerformanceTestDefinition&gt;</summary>
		public const int EditorPerformanceTestMaps = 0x0058;

		///<summary>TArray&lt;FStringAssetReference&gt;</summary>
		public const int AssetsToOpen = 0x0068;

		///<summary>FBuildPromotionTestSettings</summary>
		public const int BuildPromotionTest = 0x0078;

		///<summary>FMaterialEditorPromotionSettings</summary>
		public const int MaterialEditorPromotionTest = 0x0268;

		///<summary>FParticleEditorPromotionSettings</summary>
		public const int ParticleEditorPromotionTest = 0x0298;

		///<summary>FBlueprintEditorPromotionSettings</summary>
		public const int BlueprintEditorPromotionTest = 0x02A8;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int TestLevelFolders = 0x02D8;

		///<summary>TArray&lt;FExternalToolDefinition&gt;</summary>
		public const int ExternalTools = 0x02E8;

		///<summary>TArray&lt;FEditorImportExportTestDefinition&gt;</summary>
		public const int ImportExportTestDefinitions = 0x02F8;

		///<summary>TArray&lt;FLaunchOnTestSettings&gt;</summary>
		public const int LaunchOnSettings = 0x0308;

		///<summary>FIntPoint</summary>
		public const int DefaultScreenshotResolution = 0x0318;

	}

	public class UAvoidanceManager
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>float</summary>
		public const int DefaultTimeToLive = 0x0030;

		///<summary>float</summary>
		public const int LockTimeAfterAvoid = 0x0034;

		///<summary>float</summary>
		public const int LockTimeAfterClean = 0x0038;

		///<summary>float</summary>
		public const int DeltaTimeToPredict = 0x003C;

		///<summary>float</summary>
		public const int ArtificialRadiusExpansion = 0x0040;

		///<summary>float</summary>
		public const int TestHeightDifference = 0x0044;

		///<summary>float</summary>
		public const int HeightCheckMargin = 0x0048;

		///<summary>unsigned char[0x94]</summary>
		public const int UnknownData01 = 0x004C;

	}

	public class UBlendProfile
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>USkeleton *</summary>
		public const int OwningSkeleton = 0x0030;

		///<summary>TArray&lt;FBlendProfileBoneEntry&gt;</summary>
		public const int ProfileEntries = 0x0038;

	}

	public class UBlueprintCore
	{
		///<summary>UClass *</summary>
		public const int SkeletonGeneratedClass = 0x0028;

		///<summary>UClass *</summary>
		public const int GeneratedClass = 0x0030;

		///<summary>bool</summary>
		public const int bLegacyNeedToPurgeSkelRefs = 0x0038;

		///<summary>bool</summary>
		public const int bLegacyGeneratedClassIsAuthoritative = 0x0039;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x003A;

		///<summary>FGuid</summary>
		public const int BlueprintGuid = 0x003C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x004C;

	}

	public class UBlueprint
	{
		///<summary>unsigned char:1</summary>
		public const int bRecompileOnLoad = 0x0050;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>UClass *</summary>
		public const int ParentClass = 0x0058;

		///<summary>UObject *</summary>
		public const int PRIVATE_InnermostPreviousCDO = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bHasBeenRegenerated = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bIsRegeneratingOnLoad = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0069;

		///<summary>USimpleConstructionScript *</summary>
		public const int SimpleConstructionScript = 0x0070;

		///<summary>TArray&lt;UActorComponent * &gt;</summary>
		public const int ComponentTemplates = 0x0078;

		///<summary>TArray&lt;UTimelineTemplate * &gt;</summary>
		public const int Timelines = 0x0088;

		///<summary>UInheritableComponentHandler *</summary>
		public const int InheritableComponentHandler = 0x0098;

		///<summary>TEnumAsByte&lt;EBlueprintType&gt;</summary>
		public const int BlueprintType = 0x00A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00A1;

		///<summary>int</summary>
		public const int BlueprintSystemVersion = 0x00A4;

		///<summary>unsigned char[0xE8]</summary>
		public const int UnknownData03 = 0x00A8;

		///<summary>bool</summary>
		public const int bNativize = 0x0190;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData04 = 0x0191;

	}

	public class UAnimBlueprint
	{
		///<summary>TArray&lt;FAnimGroupInfo&gt;</summary>
		public const int Groups = 0x01A0;

		///<summary>bool</summary>
		public const int bUseMultiThreadedAnimationUpdate = 0x01B0;

		///<summary>bool</summary>
		public const int bWarnAboutBlueprintUsage = 0x01B1;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData00 = 0x01B2;

	}

	public class UPlatformGameInstance
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationWillDeactivateDelegate = 0x00F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationHasReactivatedDelegate = 0x0100;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationWillEnterBackgroundDelegate = 0x0110;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationHasEnteredForegroundDelegate = 0x0120;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationWillTerminateDelegate = 0x0130;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationRegisteredForRemoteNotificationsDelegate = 0x0140;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationRegisteredForUserNotificationsDelegate = 0x0150;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationFailedToRegisterForRemoteNotificationsDelegate = 0x0160;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationReceivedRemoteNotificationDelegate = 0x0170;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationReceivedLocalNotificationDelegate = 0x0180;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ApplicationReceivedScreenOrientationChangedNotificationDelegate = 0x0190;

	}

	public class UDataTable
	{
		///<summary>UScriptStruct *</summary>
		public const int RowStruct = 0x0028;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UCollisionProfile
	{
		///<summary>TArray&lt;FCollisionResponseTemplate&gt;</summary>
		public const int Profiles = 0x0038;

		///<summary>TArray&lt;FCustomChannelSetup&gt;</summary>
		public const int DefaultChannelResponses = 0x0048;

		///<summary>TArray&lt;FCustomProfile&gt;</summary>
		public const int EditProfiles = 0x0058;

		///<summary>TArray&lt;FRedirector&gt;</summary>
		public const int ProfileRedirects = 0x0068;

		///<summary>TArray&lt;FRedirector&gt;</summary>
		public const int CollisionChannelRedirects = 0x0078;

		///<summary>unsigned char[0xD0]</summary>
		public const int UnknownData00 = 0x0088;

	}

	public class UWorld
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>ULevel *</summary>
		public const int PersistentLevel = 0x0030;

		///<summary>UNetDriver *</summary>
		public const int NetDriver = 0x0038;

		///<summary>ULineBatchComponent *</summary>
		public const int LineBatcher = 0x0040;

		///<summary>ULineBatchComponent *</summary>
		public const int PersistentLineBatcher = 0x0048;

		///<summary>ULineBatchComponent *</summary>
		public const int ForegroundLineBatcher = 0x0050;

		///<summary>AGameNetworkManager *</summary>
		public const int NetworkManager = 0x0058;

		///<summary>UPhysicsCollisionHandler *</summary>
		public const int PhysicsCollisionHandler = 0x0060;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int ExtraReferencedObjects = 0x0068;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int PerModuleDataObjects = 0x0078;

		///<summary>TArray&lt;ULevelStreaming * &gt;</summary>
		public const int StreamingLevels = 0x0088;

		///<summary>FString</summary>
		public const int StreamingLevelsPrefix = 0x0098;

		///<summary>ULevel *</summary>
		public const int CurrentLevelPendingVisibility = 0x00A8;

		///<summary>ULevel *</summary>
		public const int CurrentLevelPendingInvisibility = 0x00B0;

		///<summary>UDemoNetDriver *</summary>
		public const int DemoNetDriver = 0x00B8;

		///<summary>AParticleEventManager *</summary>
		public const int MyParticleEventManager = 0x00C0;

		///<summary>APhysicsVolume *</summary>
		public const int DefaultPhysicsVolume = 0x00C8;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x00D0;

		///<summary>UNavigationSystem *</summary>
		public const int NavigationSystem = 0x00E8;

		///<summary>AGameModeBase *</summary>
		public const int AuthorityGameMode = 0x00F0;

		///<summary>AGameStateBase *</summary>
		public const int GameState = 0x00F8;

		///<summary>UAISystemBase *</summary>
		public const int AISystem = 0x0100;

		///<summary>UAvoidanceManager *</summary>
		public const int AvoidanceManager = 0x0108;

		///<summary>TArray&lt;ULevel * &gt;</summary>
		public const int Levels = 0x0110;

		///<summary>TArray&lt;FLevelCollection&gt;</summary>
		public const int LevelCollections = 0x0120;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0130;

		///<summary>ULevel *</summary>
		public const int CurrentLevel = 0x0138;

		///<summary>UGameInstance *</summary>
		public const int OwningGameInstance = 0x0140;

		///<summary>TArray&lt;UMaterialParameterCollectionInstance * &gt;</summary>
		public const int ParameterCollectionInstances = 0x0148;

		///<summary>UCanvas *</summary>
		public const int CanvasForRenderingToTarget = 0x0158;

		///<summary>UCanvas *</summary>
		public const int CanvasForDrawMaterialToRenderTarget = 0x0160;

		///<summary>UDirectionalLightComponent *</summary>
		public const int HeightBufferFakeLight = 0x0168;

		///<summary>unsigned char[0x7E0]</summary>
		public const int UnknownData03 = 0x0170;

		///<summary>UWorldComposition *</summary>
		public const int WorldComposition = 0x0950;

		///<summary>unsigned char[0x4A]</summary>
		public const int UnknownData04 = 0x0958;

		///<summary>unsigned char:1</summary>
		public const int bAreConstraintsDirty = 0x09A2;

		///<summary>unsigned char[0xD]</summary>
		public const int UnknownData05 = 0x09A3;

	}

	public class UNavigationSystem
	{
		///<summary>ANavigationData *</summary>
		public const int MainNavData = 0x0028;

		///<summary>ANavigationData *</summary>
		public const int AbstractNavData = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bAutoCreateNavigationData = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bAllowClientSideNavigation = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSupportRebuilding = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bInitialBuildingLocked = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSkipAgentHeightCheckWhenPickingNavData = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0039;

		///<summary>ENavDataGatheringModeConfig</summary>
		public const int DataGatheringMode = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x003D;

		///<summary>unsigned char:1</summary>
		public const int bGenerateNavigationOnlyAroundNavigationInvokers = 0x0040;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0041;

		///<summary>float</summary>
		public const int ActiveTilesUpdateInterval = 0x0044;

		///<summary>TArray&lt;FNavDataConfig&gt;</summary>
		public const int SupportedAgents = 0x0048;

		///<summary>float</summary>
		public const int DirtyAreasUpdateFreq = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x005C;

		///<summary>TArray&lt;ANavigationData * &gt;</summary>
		public const int NavDataSet = 0x0060;

		///<summary>TArray&lt;ANavigationData * &gt;</summary>
		public const int NavDataRegistrationQueue = 0x0070;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData05 = 0x0080;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNavDataRegisteredEvent = 0x00E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNavigationGenerationFinishedDelegate = 0x00F0;

		///<summary>unsigned char[0x124]</summary>
		public const int UnknownData06 = 0x0100;

		///<summary>EFNavigationSystemRunMode</summary>
		public const int OperationMode = 0x0224;

		///<summary>unsigned char[0x23B]</summary>
		public const int UnknownData07 = 0x0225;

	}

	public class UPoseWatch
	{
		///<summary>UEdGraphNode *</summary>
		public const int Node = 0x0028;

		///<summary>FColor</summary>
		public const int PoseWatchColour = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UAnimBlueprintGeneratedClass
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0358;

		///<summary>TArray&lt;FBakedAnimationStateMachine&gt;</summary>
		public const int BakedStateMachines = 0x0360;

		///<summary>USkeleton *</summary>
		public const int TargetSkeleton = 0x0370;

		///<summary>TArray&lt;FAnimNotifyEvent&gt;</summary>
		public const int AnimNotifies = 0x0378;

		///<summary>int</summary>
		public const int RootAnimNodeIndex = 0x0388;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x038C;

		///<summary>TArray&lt;int&gt;</summary>
		public const int OrderedSavedPoseIndices = 0x0390;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x03A0;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int SyncGroupNames = 0x03B8;

	}

	public class UBodySetup
	{
		///<summary>FKAggregateGeom</summary>
		public const int AggGeom = 0x0028;

		///<summary>FName</summary>
		public const int BoneName = 0x0070;

		///<summary>TEnumAsByte&lt;EPhysicsType&gt;</summary>
		public const int PhysicsType = 0x0078;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0079;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysFullAnimWeight = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bConsiderForBounds = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bMeshCollideAll = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bDoubleSidedGeometry = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bGenerateNonMirroredCollision = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bSharedCookedData = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bGenerateMirroredCollision = 0x007C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x007D;

		///<summary>UPhysicalMaterial *</summary>
		public const int PhysMaterial = 0x0080;

		///<summary>TEnumAsByte&lt;EBodyCollisionResponse&gt;</summary>
		public const int CollisionReponse = 0x0088;

		///<summary>TEnumAsByte&lt;ECollisionTraceFlag&gt;</summary>
		public const int CollisionTraceFlag = 0x0089;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x008A;

		///<summary>FBodyInstance</summary>
		public const int DefaultInstance = 0x0090;

		///<summary>FWalkableSlopeOverride</summary>
		public const int WalkableSlopeOverride = 0x02D0;

		///<summary>float</summary>
		public const int BuildScale = 0x02E0;

		///<summary>FVector</summary>
		public const int BuildScale3D = 0x02E4;

		///<summary>unsigned char[0xC0]</summary>
		public const int UnknownData03 = 0x02F0;

	}

	public class UBodySetup2D
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class UPhysicsAsset
	{
		///<summary>TArray&lt;int&gt;</summary>
		public const int BoundsBodies = 0x0028;

		///<summary>TArray&lt;USkeletalBodySetup * &gt;</summary>
		public const int SkeletalBodySetups = 0x0038;

		///<summary>TArray&lt;UPhysicsConstraintTemplate * &gt;</summary>
		public const int ConstraintSetup = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bUseAsyncScene = 0x0058;

		///<summary>unsigned char[0xA7]</summary>
		public const int UnknownData00 = 0x0059;

		///<summary>TArray&lt;UBodySetup * &gt;</summary>
		public const int BodySetup = 0x0100;

	}

	public class USkeletalBodySetup
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class UBoneMaskFilter
	{
		///<summary>TArray&lt;FInputBlendPose&gt;</summary>
		public const int BlendPoses = 0x0028;

	}

	public class UBookMark
	{
		///<summary>FVector</summary>
		public const int Location = 0x0028;

		///<summary>FRotator</summary>
		public const int Rotation = 0x0034;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HiddenLevels = 0x0040;

	}

	public class UBookMark2D
	{
		///<summary>float</summary>
		public const int Zoom2D = 0x0028;

		///<summary>FIntPoint</summary>
		public const int Location = 0x002C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UBreakpoint
	{
		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>UEdGraphNode *</summary>
		public const int Node = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bStepOnce = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bStepOnce_WasPreviouslyDisabled = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bStepOnce_RemoveAfterHit = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0039;

	}

	public class UBrushBuilder
	{
		///<summary>FString</summary>
		public const int BitmapFilename = 0x0028;

		///<summary>FString</summary>
		public const int Tooltip = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int NotifyBadParams = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int Vertices = 0x0050;

		///<summary>TArray&lt;FBuilderPoly&gt;</summary>
		public const int Polys = 0x0060;

		///<summary>FName</summary>
		public const int Layer = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int MergeCoplanars = 0x0078;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0079;

	}

	public class UButtonStyleAsset
	{
		///<summary>FButtonStyle</summary>
		public const int ButtonStyle = 0x0028;

	}

	public class UCameraAnim
	{
		///<summary>UInterpGroup *</summary>
		public const int CameraInterpGroup = 0x0028;

		///<summary>float</summary>
		public const int AnimLength = 0x0030;

		///<summary>FBox</summary>
		public const int BoundingBox = 0x0034;

		///<summary>unsigned char:1</summary>
		public const int bRelativeToInitialTransform = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bRelativeToInitialFOV = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>float</summary>
		public const int BaseFOV = 0x0054;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0058;

		///<summary>FPostProcessSettings</summary>
		public const int BasePostProcessSettings = 0x0060;

		///<summary>float</summary>
		public const int BasePostProcessBlendWeight = 0x0590;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x0594;

	}

	public class UCameraAnimInst
	{
		///<summary>UCameraAnim *</summary>
		public const int CamAnim = 0x0028;

		///<summary>UInterpGroupInst *</summary>
		public const int InterpGroupInst = 0x0030;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>float</summary>
		public const int PlayRate = 0x0050;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData01 = 0x0054;

		///<summary>UInterpTrackMove *</summary>
		public const int MoveTrack = 0x0068;

		///<summary>UInterpTrackInstMove *</summary>
		public const int MoveInst = 0x0070;

		///<summary>TEnumAsByte&lt;ECameraAnimPlaySpace&gt;</summary>
		public const int PlaySpace = 0x0078;

		///<summary>unsigned char[0x97]</summary>
		public const int UnknownData02 = 0x0079;

	}

	public class UCameraModifier
	{
		///<summary>unsigned char:1</summary>
		public const int bDebug = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bExclusive = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>unsigned char</summary>
		public const int Priority = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x002D;

		///<summary>APlayerCameraManager *</summary>
		public const int CameraOwner = 0x0030;

		///<summary>float</summary>
		public const int AlphaInTime = 0x0038;

		///<summary>float</summary>
		public const int AlphaOutTime = 0x003C;

		///<summary>float</summary>
		public const int Alpha = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0044;

	}

	public class UCameraModifier_CameraShake
	{
		///<summary>TArray&lt;UCameraShake * &gt;</summary>
		public const int ActiveShakes = 0x0048;

		///<summary>float</summary>
		public const int SplitScreenShakeScale = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x005C;

	}

	public class UCanvas
	{
		///<summary>float</summary>
		public const int OrgX = 0x0028;

		///<summary>float</summary>
		public const int OrgY = 0x002C;

		///<summary>float</summary>
		public const int ClipX = 0x0030;

		///<summary>float</summary>
		public const int ClipY = 0x0034;

		///<summary>FColor</summary>
		public const int DrawColor = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bCenterX = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int bCenterY = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int bNoSmooth = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x003D;

		///<summary>int</summary>
		public const int SizeX = 0x0040;

		///<summary>int</summary>
		public const int SizeY = 0x0044;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0048;

		///<summary>FPlane</summary>
		public const int ColorModulate = 0x0050;

		///<summary>UTexture2D *</summary>
		public const int DefaultTexture = 0x0060;

		///<summary>UTexture2D *</summary>
		public const int GradientTexture0 = 0x0068;

		///<summary>UReporterGraph *</summary>
		public const int ReporterGraph = 0x0070;

		///<summary>unsigned char[0x258]</summary>
		public const int UnknownData02 = 0x0078;

	}

	public class UChannel
	{
		///<summary>UNetConnection *</summary>
		public const int Connection = 0x0028;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UActorChannel
	{
		///<summary>AActor *</summary>
		public const int Actor = 0x0068;

		///<summary>unsigned char[0x1C0]</summary>
		public const int UnknownData00 = 0x0070;

	}

	public class UDemoActorChannel
	{
		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData00 = 0x0230;

	}

	public class UControlChannel
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0068;

	}

	public class UVoiceChannel
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0068;

	}

	public class UCheckBoxStyleAsset
	{
		///<summary>FCheckBoxStyle</summary>
		public const int CheckBoxStyle = 0x0028;

	}

	public class UCommandlet
	{
		///<summary>FString</summary>
		public const int HelpDescription = 0x0028;

		///<summary>FString</summary>
		public const int HelpUsage = 0x0038;

		///<summary>FString</summary>
		public const int HelpWebLink = 0x0048;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HelpParamNames = 0x0058;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HelpParamDescriptions = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int IsServer = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int IsClient = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int IsEditor = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int LogToConsole = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int ShowErrorCount = 0x0078;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0079;

	}

	public class UPluginCommandlet
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0080;

	}

	public class UCurveLinearColor
	{
		///<summary>FRichCurve[0x4]</summary>
		public const int FloatCurves = 0x0030;

	}

	public class UCurveVector
	{
		///<summary>FRichCurve[0x3]</summary>
		public const int FloatCurves = 0x0030;

	}

	public class UCurveTable
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UPreviewMeshCollection
	{
		///<summary>USkeleton *</summary>
		public const int Skeleton = 0x0030;

		///<summary>TArray&lt;FPreviewMeshCollectionEntry&gt;</summary>
		public const int SkeletalMeshes = 0x0038;

	}

	public class UPrimaryAssetLabel
	{
		///<summary>FPrimaryAssetRules</summary>
		public const int Rules = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bLabelAssetsInMyDirectory = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0041;

		///<summary>TArray&lt;TAssetPtr&lt;UObject&gt;&gt;</summary>
		public const int ExplicitAssets = 0x0048;

		///<summary>TArray&lt;TAssetPtr&lt;UClass&gt;&gt;</summary>
		public const int ExplicitBlueprints = 0x0058;

	}

	public class UTireType
	{
		///<summary>float</summary>
		public const int FrictionScale = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UNetDriver
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FString</summary>
		public const int NetConnectionClassName = 0x0030;

		///<summary>int</summary>
		public const int MaxDownloadSize = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bClampListenServerTickRate = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0045;

		///<summary>int</summary>
		public const int NetServerMaxTickRate = 0x0048;

		///<summary>int</summary>
		public const int MaxInternetClientRate = 0x004C;

		///<summary>int</summary>
		public const int MaxClientRate = 0x0050;

		///<summary>float</summary>
		public const int ServerTravelPause = 0x0054;

		///<summary>float</summary>
		public const int SpawnPrioritySeconds = 0x0058;

		///<summary>float</summary>
		public const int RelevantTimeout = 0x005C;

		///<summary>float</summary>
		public const int KeepAliveTime = 0x0060;

		///<summary>float</summary>
		public const int InitialConnectTimeout = 0x0064;

		///<summary>float</summary>
		public const int ConnectionTimeout = 0x0068;

		///<summary>float</summary>
		public const int TimeoutMultiplierForUnoptimizedBuilds = 0x006C;

		///<summary>bool</summary>
		public const int bNoTimeouts = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0071;

		///<summary>UNetConnection *</summary>
		public const int ServerConnection = 0x0078;

		///<summary>TArray&lt;UNetConnection * &gt;</summary>
		public const int ClientConnections = 0x0080;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData03 = 0x0090;

		///<summary>UWorld *</summary>
		public const int World = 0x00B8;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData04 = 0x00C0;

		///<summary>UClass *</summary>
		public const int NetConnectionClass = 0x00E0;

		///<summary>UProperty *</summary>
		public const int RoleProperty = 0x00E8;

		///<summary>UProperty *</summary>
		public const int RemoteRoleProperty = 0x00F0;

		///<summary>FName</summary>
		public const int NetDriverName = 0x00F8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x0100;

		///<summary>float</summary>
		public const int Time = 0x0108;

		///<summary>unsigned char[0x32C]</summary>
		public const int UnknownData06 = 0x010C;

	}

	public class UPackageMapClient
	{
		///<summary>unsigned char[0x290]</summary>
		public const int UnknownData00 = 0x00E0;

	}

	public class UNetConnection
	{
		///<summary>TArray&lt;UChildConnection * &gt;</summary>
		public const int Children = 0x0048;

		///<summary>UNetDriver *</summary>
		public const int Driver = 0x0058;

		///<summary>UClass *</summary>
		public const int PackageMapClass = 0x0060;

		///<summary>UPackageMap *</summary>
		public const int PackageMap = 0x0068;

		///<summary>TArray&lt;UChannel * &gt;</summary>
		public const int OpenChannels = 0x0070;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int SentTemporaries = 0x0080;

		///<summary>AActor *</summary>
		public const int ViewTarget = 0x0090;

		///<summary>AActor *</summary>
		public const int OwningActor = 0x0098;

		///<summary>int</summary>
		public const int MaxPacket = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int InternalAck = 0x00A4;

		///<summary>unsigned char[0xB3]</summary>
		public const int UnknownData00 = 0x00A5;

		///<summary>FUniqueNetIdRepl</summary>
		public const int PlayerId = 0x0158;

		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData01 = 0x0170;

		///<summary>double</summary>
		public const int LastReceiveTime = 0x01D8;

	}

	public class UDemoNetConnection
	{
	}

	public class UDemoNetDriver
	{
		///<summary>unsigned char[0xF8]</summary>
		public const int UnknownData00 = 0x0438;

		///<summary>TMap&lt;FString,FRollbackNetStartupActorInfo&gt;</summary>
		public const int RollbackNetStartupActors = 0x0530;

		///<summary>unsigned char[0x3C8]</summary>
		public const int UnknownData01 = 0x0580;

		///<summary>bool</summary>
		public const int bIsLocalReplay = 0x0948;

		///<summary>unsigned char[0x77]</summary>
		public const int UnknownData02 = 0x0949;

	}

	public class UDestructibleFractureSettings
	{
		///<summary>int</summary>
		public const int CellSiteCount = 0x0028;

		///<summary>FFractureMaterial</summary>
		public const int FractureMaterialDesc = 0x002C;

		///<summary>int</summary>
		public const int RandomSeed = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0054;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int VoronoiSites = 0x0058;

		///<summary>int</summary>
		public const int OriginalSubmeshCount = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x006C;

		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int Materials = 0x0070;

		///<summary>TArray&lt;FDestructibleChunkParameters&gt;</summary>
		public const int ChunkParameters = 0x0080;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData02 = 0x0090;

	}

	public class UAnimationSettings
	{
		///<summary>int</summary>
		public const int CompressCommandletVersion = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int KeyEndEffectorsMatchNameArray = 0x0040;

		///<summary>UClass *</summary>
		public const int DefaultCompressionAlgorithm = 0x0050;

		///<summary>TEnumAsByte&lt;EAnimationCompressionFormat&gt;</summary>
		public const int RotationCompressionFormat = 0x0058;

		///<summary>TEnumAsByte&lt;EAnimationCompressionFormat&gt;</summary>
		public const int TranslationCompressionFormat = 0x0059;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x005A;

		///<summary>float</summary>
		public const int MaxCurveError = 0x005C;

		///<summary>float</summary>
		public const int AlternativeCompressionThreshold = 0x0060;

		///<summary>bool</summary>
		public const int ForceRecompression = 0x0064;

		///<summary>bool</summary>
		public const int bOnlyCheckForMissingSkeletalMeshes = 0x0065;

		///<summary>bool</summary>
		public const int bForceBelowThreshold = 0x0066;

		///<summary>bool</summary>
		public const int bFirstRecompressUsingCurrentOrDefault = 0x0067;

		///<summary>bool</summary>
		public const int bRaiseMaxErrorToExisting = 0x0068;

		///<summary>bool</summary>
		public const int bTryFixedBitwiseCompression = 0x0069;

		///<summary>bool</summary>
		public const int bTryPerTrackBitwiseCompression = 0x006A;

		///<summary>bool</summary>
		public const int bTryLinearKeyRemovalCompression = 0x006B;

		///<summary>bool</summary>
		public const int bTryIntervalKeyRemoval = 0x006C;

		///<summary>bool</summary>
		public const int bEnablePerformanceLog = 0x006D;

		///<summary>bool</summary>
		public const int bStripAnimationDataOnDedicatedServer = 0x006E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x006F;

	}

	public class UAssetManagerSettings
	{
		///<summary>TArray&lt;FPrimaryAssetTypeInfo&gt;</summary>
		public const int PrimaryAssetTypesToScan = 0x0038;

		///<summary>TArray&lt;FDirectoryPath&gt;</summary>
		public const int DirectoriesToExclude = 0x0048;

		///<summary>TArray&lt;FPrimaryAssetRulesOverride&gt;</summary>
		public const int PrimaryAssetRules = 0x0058;

		///<summary>bool</summary>
		public const int bOnlyCookProductionAssets = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0069;

		///<summary>TArray&lt;FAssetManagerRedirect&gt;</summary>
		public const int PrimaryAssetIdRedirects = 0x0070;

		///<summary>TArray&lt;FAssetManagerRedirect&gt;</summary>
		public const int PrimaryAssetTypeRedirects = 0x0080;

		///<summary>TArray&lt;FAssetManagerRedirect&gt;</summary>
		public const int AssetPathRedirects = 0x0090;

	}

	public class UAudioSettings
	{
		///<summary>FStringAssetReference</summary>
		public const int DefaultSoundClassName = 0x0038;

		///<summary>FStringAssetReference</summary>
		public const int DefaultSoundConcurrencyName = 0x0048;

		///<summary>FStringAssetReference</summary>
		public const int DefaultBaseSoundMix = 0x0058;

		///<summary>FStringAssetReference</summary>
		public const int VoiPSoundClass = 0x0068;

		///<summary>float</summary>
		public const int LowPassFilterResonance = 0x0078;

		///<summary>int</summary>
		public const int MaximumConcurrentStreams = 0x007C;

		///<summary>TArray&lt;FAudioQualitySettings&gt;</summary>
		public const int QualityLevels = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bAllowVirtualizedSounds = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bDisableMasterEQ = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bDisableMasterReverb = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bAllowCenterChannel3DPanning = 0x0090;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0091;

		///<summary>FString</summary>
		public const int DialogueFilenameFormat = 0x0098;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x00A8;

	}

	public class UStreamingSettings
	{
		///<summary>unsigned char:1</summary>
		public const int AsyncLoadingThreadEnabled = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int WarnIfTimeLimitExceeded = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>float</summary>
		public const int TimeLimitExceededMultiplier = 0x003C;

		///<summary>float</summary>
		public const int TimeLimitExceededMinTime = 0x0040;

		///<summary>int</summary>
		public const int MinBulkDataSizeForAsyncLoading = 0x0044;

		///<summary>float</summary>
		public const int AsyncIOBandwidthLimit = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int UseBackgroundLevelStreaming = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int AsyncLoadingUseFullTimeLimit = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int LoadAllStreamingLevels = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x004D;

		///<summary>float</summary>
		public const int AsyncLoadingTimeLimit = 0x0050;

		///<summary>float</summary>
		public const int PriorityAsyncLoadingExtraTime = 0x0054;

		///<summary>float</summary>
		public const int LevelStreamingActorsUpdateTimeLimit = 0x0058;

		///<summary>int</summary>
		public const int LevelStreamingComponentsRegistrationGranularity = 0x005C;

		///<summary>float</summary>
		public const int LevelStreamingUnregisterComponentsTimeLimit = 0x0060;

		///<summary>int</summary>
		public const int LevelStreamingComponentsUnregistrationGranularity = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int EventDrivenLoaderEnabled = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0069;

	}

	public class UGarbageCollectionSettings
	{
		///<summary>float</summary>
		public const int TimeBetweenPurgingPendingKillObjects = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int FlushStreamingOnGC = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int AllowParallelGC = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int CreateGCClusters = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int MergeGCClusters = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int ActorClusteringEnabled = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int BlueprintClusteringEnabled = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x003D;

		///<summary>int</summary>
		public const int NumRetriesBeforeForcingGC = 0x0040;

		///<summary>int</summary>
		public const int MaxObjectsNotConsideredByGC = 0x0044;

		///<summary>int</summary>
		public const int SizeOfPermanentObjectPool = 0x0048;

		///<summary>int</summary>
		public const int MaxObjectsInGame = 0x004C;

		///<summary>int</summary>
		public const int MaxObjectsInEditor = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0054;

	}

	public class UMeshSimplificationSettings
	{
		///<summary>FName</summary>
		public const int MeshReductionModuleName = 0x0038;

	}

	public class UNetworkSettings
	{
		///<summary>unsigned char:1</summary>
		public const int bVerifyPeer = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bEnableMultiplayerWorldOriginRebasing = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>int</summary>
		public const int MaxRepArraySize = 0x003C;

		///<summary>int</summary>
		public const int MaxRepArrayMemory = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UPhysicsSettings
	{
		///<summary>float</summary>
		public const int DefaultGravityZ = 0x0038;

		///<summary>float</summary>
		public const int DefaultTerminalVelocity = 0x003C;

		///<summary>float</summary>
		public const int DefaultFluidFriction = 0x0040;

		///<summary>int</summary>
		public const int SimulateScratchMemorySize = 0x0044;

		///<summary>int</summary>
		public const int RagdollAggregateThreshold = 0x0048;

		///<summary>float</summary>
		public const int TriangleMeshTriangleMinAreaThreshold = 0x004C;

		///<summary>bool</summary>
		public const int bEnableAsyncScene = 0x0050;

		///<summary>bool</summary>
		public const int bEnableShapeSharing = 0x0051;

		///<summary>bool</summary>
		public const int bEnableAsyncSceneOnDedicatedServer = 0x0052;

		///<summary>bool</summary>
		public const int bEnableShapeSharingOnDedicatedServer = 0x0053;

		///<summary>bool</summary>
		public const int bEnablePCM = 0x0054;

		///<summary>bool</summary>
		public const int bEnableStabilization = 0x0055;

		///<summary>bool</summary>
		public const int bWarnMissingLocks = 0x0056;

		///<summary>bool</summary>
		public const int bEnable2DPhysics = 0x0057;

		///<summary>TEnumAsByte&lt;ESettingsLockedAxis&gt;</summary>
		public const int LockedAxis = 0x0058;

		///<summary>TEnumAsByte&lt;ESettingsDOF&gt;</summary>
		public const int DefaultDegreesOfFreedom = 0x0059;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x005A;

		///<summary>float</summary>
		public const int BounceThresholdVelocity = 0x005C;

		///<summary>TEnumAsByte&lt;EFrictionCombineMode&gt;</summary>
		public const int FrictionCombineMode = 0x0060;

		///<summary>TEnumAsByte&lt;EFrictionCombineMode&gt;</summary>
		public const int RestitutionCombineMode = 0x0061;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0062;

		///<summary>float</summary>
		public const int MaxAngularVelocity = 0x0064;

		///<summary>float</summary>
		public const int MaxDepenetrationVelocity = 0x0068;

		///<summary>float</summary>
		public const int ContactOffsetMultiplier = 0x006C;

		///<summary>float</summary>
		public const int MinContactOffset = 0x0070;

		///<summary>float</summary>
		public const int MaxContactOffset = 0x0074;

		///<summary>bool</summary>
		public const int bSimulateSkeletalMeshOnDedicatedServer = 0x0078;

		///<summary>TEnumAsByte&lt;ECollisionTraceFlag&gt;</summary>
		public const int DefaultShapeComplexity = 0x0079;

		///<summary>bool</summary>
		public const int bDefaultHasComplexCollision = 0x007A;

		///<summary>bool</summary>
		public const int bSuppressFaceRemapTable = 0x007B;

		///<summary>bool</summary>
		public const int bSupportUVFromHitResults = 0x007C;

		///<summary>bool</summary>
		public const int bDisableActiveActors = 0x007D;

		///<summary>bool</summary>
		public const int bDisableCCD = 0x007E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x007F;

		///<summary>float</summary>
		public const int MaxPhysicsDeltaTime = 0x0080;

		///<summary>bool</summary>
		public const int bSubstepping = 0x0084;

		///<summary>bool</summary>
		public const int bSubsteppingAsync = 0x0085;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x0086;

		///<summary>float</summary>
		public const int MaxSubstepDeltaTime = 0x0088;

		///<summary>int</summary>
		public const int MaxSubsteps = 0x008C;

		///<summary>float</summary>
		public const int SyncSceneSmoothingFactor = 0x0090;

		///<summary>float</summary>
		public const int AsyncSceneSmoothingFactor = 0x0094;

		///<summary>float</summary>
		public const int InitialAverageFrameRate = 0x0098;

		///<summary>float</summary>
		public const int MaxPhysicsDeltaTimeOnDedicatedServer = 0x009C;

		///<summary>bool</summary>
		public const int bSubsteppingOnDedicatedServer = 0x00A0;

		///<summary>bool</summary>
		public const int bSubsteppingAsyncOnDedicatedServer = 0x00A1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x00A2;

		///<summary>float</summary>
		public const int MaxSubstepDeltaTimeOnDedicatedServer = 0x00A4;

		///<summary>int</summary>
		public const int MaxSubstepsOnDedicatedServer = 0x00A8;

		///<summary>float</summary>
		public const int SyncSceneSmoothingFactorOnDedicatedServer = 0x00AC;

		///<summary>float</summary>
		public const int AsyncSceneSmoothingFactorOnDedicatedServer = 0x00B0;

		///<summary>float</summary>
		public const int InitialAverageFrameRateOnDedicatedServer = 0x00B4;

		///<summary>TArray&lt;FPhysicalSurfaceName&gt;</summary>
		public const int PhysicalSurfaces = 0x00B8;

	}

	public class URendererSettings
	{
		///<summary>unsigned char:1</summary>
		public const int bMobileHDR = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bMobileDisableVertexFog = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>int</summary>
		public const int MaxMobileCascades = 0x003C;

		///<summary>TEnumAsByte&lt;EMobileMSAASampleCount&gt;</summary>
		public const int MobileMSAASampleCount = 0x0040;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0041;

		///<summary>unsigned char:1</summary>
		public const int bDiscardUnusedQualityLevels = 0x0044;

		///<summary>unsigned char:1</summary>
		public const int bOcclusionCulling = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0045;

		///<summary>float</summary>
		public const int MinScreenRadiusForLights = 0x0048;

		///<summary>float</summary>
		public const int MinScreenRadiusForEarlyZPass = 0x004C;

		///<summary>float</summary>
		public const int MinScreenRadiusForCSMdepth = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bPrecomputedVisibilityWarning = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bTextureStreaming = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bUseDXT5NormalMaps = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bClearCoatEnableSecondNormal = 0x0054;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0055;

		///<summary>int</summary>
		public const int ReflectionCaptureResolution = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int ReflectionEnvironmentLightmapMixBasedOnRoughness = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bForwardShading = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bVertexFoggingForOpaque = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bAllowStaticLighting = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bUseNormalMapsForStaticLighting = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bGenerateMeshDistanceFields = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bEightBitMeshDistanceFields = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bGenerateLandscapeGIData = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bCompressMeshDistanceFields = 0x005D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x005E;

		///<summary>float</summary>
		public const int TessellationAdaptivePixelsPerTriangle = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bSeparateTranslucency = 0x0064;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0065;

		///<summary>TEnumAsByte&lt;ETranslucentSortPolicy&gt;</summary>
		public const int TranslucentSortPolicy = 0x0068;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0069;

		///<summary>FVector</summary>
		public const int TranslucentSortAxis = 0x006C;

		///<summary>TEnumAsByte&lt;ECustomDepthStencil&gt;</summary>
		public const int CustomDepthStencil = 0x0078;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0079;

		///<summary>unsigned char:1</summary>
		public const int bCustomDepthTaaJitter = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bDefaultFeatureBloom = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bDefaultFeatureAmbientOcclusion = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bDefaultFeatureAmbientOcclusionStaticFraction = 0x007C;

		///<summary>unsigned char:1</summary>
		public const int bDefaultFeatureAutoExposure = 0x007C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x007D;

		///<summary>TEnumAsByte&lt;EAutoExposureMethodUI&gt;</summary>
		public const int DefaultFeatureAutoExposure = 0x0080;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x0081;

		///<summary>unsigned char:1</summary>
		public const int bDefaultFeatureMotionBlur = 0x0084;

		///<summary>unsigned char:1</summary>
		public const int bDefaultFeatureLensFlare = 0x0084;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x0085;

		///<summary>TEnumAsByte&lt;EAntiAliasingMethod&gt;</summary>
		public const int DefaultFeatureAntiAliasing = 0x0088;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData11 = 0x0089;

		///<summary>unsigned char:1</summary>
		public const int bStencilForLODDither = 0x008C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData12 = 0x008D;

		///<summary>TEnumAsByte&lt;EEarlyZPass&gt;</summary>
		public const int EarlyZPass = 0x0090;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData13 = 0x0091;

		///<summary>unsigned char:1</summary>
		public const int bEarlyZPassMovable = 0x0094;

		///<summary>unsigned char:1</summary>
		public const int bEarlyZPassOnlyMaterialMasking = 0x0094;

		///<summary>unsigned char:1</summary>
		public const int bEarlyZPassForceFull = 0x0094;

		///<summary>unsigned char:1</summary>
		public const int bDBuffer = 0x0094;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData14 = 0x0095;

		///<summary>TEnumAsByte&lt;EClearSceneOptions&gt;</summary>
		public const int ClearSceneMethod = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData15 = 0x0099;

		///<summary>unsigned char:1</summary>
		public const int bBasePassOutputsVelocity = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bSelectiveBasePassOutputs = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bDefaultParticleCutouts = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bGlobalClipPlane = 0x009C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData16 = 0x009D;

		///<summary>TEnumAsByte&lt;EGBufferFormat&gt;</summary>
		public const int GBufferFormat = 0x00A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData17 = 0x00A1;

		///<summary>unsigned char:1</summary>
		public const int bUseGPUMorphTargets = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bNvidiaAftermathEnabled = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bInstancedStereo = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bMultiView = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bMobileMultiView = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bMobileMultiViewDirect = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bMonoscopicFarField = 0x00A4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData18 = 0x00A5;

		///<summary>float</summary>
		public const int WireframeCullThreshold = 0x00A8;

		///<summary>unsigned char:1</summary>
		public const int bSupportStationarySkylight = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bSupportLowQualityLightmaps = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bSupportPointLightWholeSceneShadows = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bSupportAtmosphericFog = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bSupportSkinCacheShaders = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bMobileEnableStaticAndCSMShadowReceivers = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bMobileAllowDistanceFieldShadows = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bMobileAllowMovableDirectionalLights = 0x00AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData19 = 0x00AD;

		///<summary>uint32_t</summary>
		public const int MobileNumDynamicPointLights = 0x00B0;

		///<summary>unsigned char:1</summary>
		public const int bMobileDynamicPointLightsUseStaticBranch = 0x00B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData20 = 0x00B5;

		///<summary>float</summary>
		public const int SkinCacheSceneMemoryLimitInMB = 0x00B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData21 = 0x00BC;

	}

	public class URendererOverrideSettings
	{
		///<summary>unsigned char:1</summary>
		public const int bSupportAllShaderPermutations = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bForceRecomputeTangents = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

	}

	public class UUserInterfaceSettings
	{
		///<summary>ERenderFocusRule</summary>
		public const int RenderFocusRule = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>FStringClassReference</summary>
		public const int DefaultCursor = 0x00E0;

		///<summary>FStringClassReference</summary>
		public const int TextEditBeamCursor = 0x00F0;

		///<summary>FStringClassReference</summary>
		public const int CrosshairsCursor = 0x0100;

		///<summary>FStringClassReference</summary>
		public const int HandCursor = 0x0110;

		///<summary>FStringClassReference</summary>
		public const int GrabHandCursor = 0x0120;

		///<summary>FStringClassReference</summary>
		public const int GrabHandClosedCursor = 0x0130;

		///<summary>FStringClassReference</summary>
		public const int SlashedCircleCursor = 0x0140;

		///<summary>float</summary>
		public const int ApplicationScale = 0x0150;

		///<summary>EUIScalingRule</summary>
		public const int UIScaleRule = 0x0154;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0155;

		///<summary>FStringClassReference</summary>
		public const int CustomScalingRuleClass = 0x0158;

		///<summary>FRuntimeFloatCurve</summary>
		public const int UIScaleCurve = 0x0168;

		///<summary>bool</summary>
		public const int bLoadWidgetsOnDedicatedServer = 0x01E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x01E1;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int CursorClasses = 0x01E8;

		///<summary>UClass *</summary>
		public const int CustomScalingRuleClassInstance = 0x01F8;

		///<summary>UDPICustomScalingRule *</summary>
		public const int CustomScalingRule = 0x0200;

	}

	public class UDeviceProfileManager
	{
		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int Profiles = 0x0028;

		///<summary>unsigned char[0xD8]</summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UDialogueVoice
	{
		///<summary>TEnumAsByte&lt;EGrammaticalGender&gt;</summary>
		public const int Gender = 0x0028;

		///<summary>TEnumAsByte&lt;EGrammaticalNumber&gt;</summary>
		public const int Plurality = 0x0029;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x002A;

		///<summary>FGuid</summary>
		public const int LocalizationGUID = 0x002C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x003C;

	}

	public class UDialogueWave
	{
		///<summary>unsigned char:1</summary>
		public const int bMature = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bOverride_SubtitleOverride = 0x0028;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>FString</summary>
		public const int SpokenText = 0x0030;

		///<summary>FString</summary>
		public const int SubtitleOverride = 0x0040;

		///<summary>TArray&lt;FDialogueContextMapping&gt;</summary>
		public const int ContextMappings = 0x0050;

		///<summary>FGuid</summary>
		public const int LocalizationGUID = 0x0060;

	}

	public class UDistribution
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UDistributionFloat
	{
		///<summary>unsigned char:1</summary>
		public const int bCanBeBaked = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int UnknownData00 = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bBakedDataSuccesfully = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

	}

	public class UDistributionFloatConstant
	{
		///<summary>float</summary>
		public const int Constant = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UDistributionFloatParameterBase
	{
		///<summary>FName</summary>
		public const int ParameterName = 0x0040;

		///<summary>float</summary>
		public const int MinInput = 0x0048;

		///<summary>float</summary>
		public const int MaxInput = 0x004C;

		///<summary>float</summary>
		public const int MinOutput = 0x0050;

		///<summary>float</summary>
		public const int MaxOutput = 0x0054;

		///<summary>TEnumAsByte&lt;EDistributionParamMode&gt;</summary>
		public const int ParamMode = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0059;

	}

	public class UDistributionFloatConstantCurve
	{
		///<summary>FInterpCurveFloat</summary>
		public const int ConstantCurve = 0x0038;

	}

	public class UDistributionFloatUniform
	{
		///<summary>float</summary>
		public const int Min = 0x0038;

		///<summary>float</summary>
		public const int Max = 0x003C;

	}

	public class UDistributionFloatUniformCurve
	{
		///<summary>FInterpCurveVector2D</summary>
		public const int ConstantCurve = 0x0038;

	}

	public class UDistributionVector
	{
		///<summary>unsigned char:1</summary>
		public const int bCanBeBaked = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bIsDirty = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bBakedDataSuccesfully = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UDistributionVectorConstant
	{
		///<summary>FVector</summary>
		public const int Constant = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bLockAxes = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0045;

		///<summary>TEnumAsByte&lt;EDistributionVectorLockFlags&gt;</summary>
		public const int LockedAxes = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0049;

	}

	public class UDistributionVectorParameterBase
	{
		///<summary>FName</summary>
		public const int ParameterName = 0x0050;

		///<summary>FVector</summary>
		public const int MinInput = 0x0058;

		///<summary>FVector</summary>
		public const int MaxInput = 0x0064;

		///<summary>FVector</summary>
		public const int MinOutput = 0x0070;

		///<summary>FVector</summary>
		public const int MaxOutput = 0x007C;

		///<summary>TEnumAsByte&lt;EDistributionParamMode&gt;[0x3]</summary>
		public const int ParamModes = 0x0088;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x008B;

	}

	public class UDistributionVectorConstantCurve
	{
		///<summary>FInterpCurveVector</summary>
		public const int ConstantCurve = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bLockAxes = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>TEnumAsByte&lt;EDistributionVectorLockFlags&gt;</summary>
		public const int LockedAxes = 0x0054;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0055;

	}

	public class UDistributionVectorUniform
	{
		///<summary>FVector</summary>
		public const int Max = 0x0038;

		///<summary>FVector</summary>
		public const int Min = 0x0044;

		///<summary>unsigned char:1</summary>
		public const int bLockAxes = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>TEnumAsByte&lt;EDistributionVectorLockFlags&gt;</summary>
		public const int LockedAxes = 0x0054;

		///<summary>TEnumAsByte&lt;EDistributionVectorMirrorFlags&gt;[0x3]</summary>
		public const int MirrorFlags = 0x0055;

		///<summary>unsigned char:1</summary>
		public const int bUseExtremes = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0059;

	}

	public class UDistributionVectorUniformCurve
	{
		///<summary>FInterpCurveTwoVectors</summary>
		public const int ConstantCurve = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bLockAxes1 = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bLockAxes2 = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>TEnumAsByte&lt;EDistributionVectorLockFlags&gt;[0x2]</summary>
		public const int LockedAxes = 0x0054;

		///<summary>TEnumAsByte&lt;EDistributionVectorMirrorFlags&gt;[0x3]</summary>
		public const int MirrorFlags = 0x0056;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0059;

		///<summary>unsigned char:1</summary>
		public const int bUseExtremes = 0x005C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x005D;

	}

	public class UComponentDelegateBinding
	{
		///<summary>TArray&lt;FBlueprintComponentDelegateBinding&gt;</summary>
		public const int ComponentDelegateBindings = 0x0028;

	}

	public class UInputActionDelegateBinding
	{
		///<summary>TArray&lt;FBlueprintInputActionDelegateBinding&gt;</summary>
		public const int InputActionDelegateBindings = 0x0028;

	}

	public class UInputAxisDelegateBinding
	{
		///<summary>TArray&lt;FBlueprintInputAxisDelegateBinding&gt;</summary>
		public const int InputAxisDelegateBindings = 0x0028;

	}

	public class UInputAxisKeyDelegateBinding
	{
		///<summary>TArray&lt;FBlueprintInputAxisKeyDelegateBinding&gt;</summary>
		public const int InputAxisKeyDelegateBindings = 0x0028;

	}

	public class UInputKeyDelegateBinding
	{
		///<summary>TArray&lt;FBlueprintInputKeyDelegateBinding&gt;</summary>
		public const int InputKeyDelegateBindings = 0x0028;

	}

	public class UInputTouchDelegateBinding
	{
		///<summary>TArray&lt;FBlueprintInputTouchDelegateBinding&gt;</summary>
		public const int InputTouchDelegateBindings = 0x0028;

	}

	public class UEdGraph
	{
		///<summary>UClass *</summary>
		public const int Schema = 0x0028;

		///<summary>TArray&lt;UEdGraphNode * &gt;</summary>
		public const int Nodes = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bEditable = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bAllowDeletion = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bAllowRenaming = 0x0040;

		///<summary>unsigned char[0x7F]</summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UEdGraphNode_Documentation
	{
		///<summary>FString</summary>
		public const int Link = 0x00A0;

		///<summary>FString</summary>
		public const int Excerpt = 0x00B0;

	}

	public class UEndUserSettings
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>bool</summary>
		public const int bSendAnonymousUsageDataToEpic = 0x0030;

		///<summary>bool</summary>
		public const int bSendMeanTimeBetweenFailureDataToEpic = 0x0031;

		///<summary>bool</summary>
		public const int bAllowUserIdInUsageData = 0x0032;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData01 = 0x0033;

	}

	public class UPendingNetGame
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UNetDriver *</summary>
		public const int NetDriver = 0x0030;

		///<summary>UDemoNetDriver *</summary>
		public const int DemoNetDriver = 0x0038;

		///<summary>unsigned char[0x88]</summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UExporter
	{
		///<summary>UClass *</summary>
		public const int SupportedClass = 0x0028;

		///<summary>UObject *</summary>
		public const int ExportRootScope = 0x0030;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int FormatExtension = 0x0038;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int FormatDescription = 0x0048;

		///<summary>int</summary>
		public const int PreferredFormatIndex = 0x0058;

		///<summary>int</summary>
		public const int TextIndent = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bText = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bSelectedOnly = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bForceFileOperations = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UExtendedReflectionSettings
	{
		///<summary>float</summary>
		public const int GlobalOverrideIntensity = 0x0028;

		///<summary>int</summary>
		public const int StreamingSectionSize = 0x002C;

		///<summary>TArray&lt;FExtendedReflectionSharedCubemap&gt;</summary>
		public const int SharedCubemaps = 0x0030;

		///<summary>TArray&lt;UTextureCube * &gt;</summary>
		public const int ReferencedCubemaps = 0x0040;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0050;

	}

	public class UFontImportOptions
	{
		///<summary>FFontImportOptionsData</summary>
		public const int Data = 0x0028;

	}

	public class UFont
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>EFontCacheType</summary>
		public const int FontCacheType = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

		///<summary>TArray&lt;FFontCharacter&gt;</summary>
		public const int Characters = 0x0038;

		///<summary>TArray&lt;UTexture2D * &gt;</summary>
		public const int Textures = 0x0048;

		///<summary>int</summary>
		public const int IsRemapped = 0x0058;

		///<summary>float</summary>
		public const int EmScale = 0x005C;

		///<summary>float</summary>
		public const int Ascent = 0x0060;

		///<summary>float</summary>
		public const int Descent = 0x0064;

		///<summary>float</summary>
		public const int Leading = 0x0068;

		///<summary>int</summary>
		public const int Kerning = 0x006C;

		///<summary>FFontImportOptionsData</summary>
		public const int ImportOptions = 0x0070;

		///<summary>int</summary>
		public const int NumCharacters = 0x0120;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0124;

		///<summary>TArray&lt;int&gt;</summary>
		public const int MaxCharHeight = 0x0128;

		///<summary>float</summary>
		public const int ScalingFactor = 0x0138;

		///<summary>int</summary>
		public const int LegacyFontSize = 0x013C;

		///<summary>FName</summary>
		public const int LegacyFontName = 0x0140;

		///<summary>FCompositeFont</summary>
		public const int CompositeFont = 0x0148;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData03 = 0x0170;

	}

	public class UFontFace
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FString</summary>
		public const int SourceFilename = 0x0030;

		///<summary>EFontHinting</summary>
		public const int Hinting = 0x0040;

		///<summary>EFontLoadingPolicy</summary>
		public const int LoadingPolicy = 0x0041;

		///<summary>EFontLayoutMethod</summary>
		public const int LayoutMethod = 0x0042;

		///<summary>unsigned char[0x15]</summary>
		public const int UnknownData01 = 0x0043;

	}

	public class UHapticFeedbackEffect_Buffer
	{
		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int Amplitudes = 0x0028;

		///<summary>int</summary>
		public const int SampleRate = 0x0038;

		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UHapticFeedbackEffect_Curve
	{
		///<summary>FHapticFeedbackDetails_Curve</summary>
		public const int HapticDetails = 0x0028;

	}

	public class UHapticFeedbackEffect_SoundWave
	{
		///<summary>USoundWave *</summary>
		public const int SoundWave = 0x0028;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UInheritableComponentHandler
	{
		///<summary>TArray&lt;FComponentOverrideRecord&gt;</summary>
		public const int Records = 0x0028;

		///<summary>TArray&lt;UActorComponent * &gt;</summary>
		public const int UnnecessaryComponents = 0x0038;

	}

	public class UPlayerInput
	{
		///<summary>unsigned char[0xF8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FKeyBind&gt;</summary>
		public const int DebugExecBindings = 0x0120;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData01 = 0x0130;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int InvertedAxis = 0x0160;

		///<summary>unsigned char[0x248]</summary>
		public const int UnknownData02 = 0x0170;

	}

	public class UInputSettings
	{
		///<summary>TArray&lt;FInputAxisConfigEntry&gt;</summary>
		public const int AxisConfig = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bAltEnterTogglesFullscreen = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bF11TogglesFullscreen = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bUseMouseForTouch = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bEnableMouseSmoothing = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bEnableFOVScaling = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>float</summary>
		public const int FOVScale = 0x003C;

		///<summary>float</summary>
		public const int DoubleClickTime = 0x0040;

		///<summary>bool</summary>
		public const int bCaptureMouseOnLaunch = 0x0044;

		///<summary>EMouseCaptureMode</summary>
		public const int DefaultViewportMouseCaptureMode = 0x0045;

		///<summary>bool</summary>
		public const int bDefaultViewportMouseLock = 0x0046;

		///<summary>EMouseLockMode</summary>
		public const int DefaultViewportMouseLockMode = 0x0047;

		///<summary>TArray&lt;FInputActionKeyMapping&gt;</summary>
		public const int ActionMappings = 0x0048;

		///<summary>TArray&lt;FInputAxisKeyMapping&gt;</summary>
		public const int AxisMappings = 0x0058;

		///<summary>bool</summary>
		public const int bAlwaysShowTouchInterface = 0x0068;

		///<summary>bool</summary>
		public const int bShowConsoleOnFourFingerTap = 0x0069;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x006A;

		///<summary>FStringAssetReference</summary>
		public const int DefaultTouchInterface = 0x0070;

		///<summary>FKey</summary>
		public const int ConsoleKey = 0x0080;

		///<summary>TArray&lt;FKey&gt;</summary>
		public const int ConsoleKeys = 0x0098;

	}

	public class UInterpCurveEdSetup
	{
		///<summary>TArray&lt;FCurveEdTab&gt;</summary>
		public const int Tabs = 0x0028;

		///<summary>int</summary>
		public const int ActiveTab = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UInterpData
	{
		///<summary>float</summary>
		public const int InterpLength = 0x0028;

		///<summary>float</summary>
		public const int PathBuildTime = 0x002C;

		///<summary>TArray&lt;UInterpGroup * &gt;</summary>
		public const int InterpGroups = 0x0030;

		///<summary>UInterpCurveEdSetup *</summary>
		public const int CurveEdSetup = 0x0040;

		///<summary>float</summary>
		public const int EdSectionStart = 0x0048;

		///<summary>float</summary>
		public const int EdSectionEnd = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bShouldBakeAndPrune = 0x0050;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>UInterpGroupDirector *</summary>
		public const int CachedDirectorGroup = 0x0058;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int AllEventNames = 0x0060;

	}

	public class UInterpFilter
	{
		///<summary>FString</summary>
		public const int Caption = 0x0028;

	}

	public class UInterpGroup
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UInterpTrack * &gt;</summary>
		public const int InterpTracks = 0x0030;

		///<summary>FName</summary>
		public const int GroupName = 0x0040;

		///<summary>FColor</summary>
		public const int GroupColor = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bCollapsed = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bVisible = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bIsFolder = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bIsParented = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bIsSelected = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x004D;

	}

	public class UInterpGroupCamera
	{
		///<summary>UCameraAnim *</summary>
		public const int CameraAnimInst = 0x0050;

		///<summary>float</summary>
		public const int CompressTolerance = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x005C;

	}

	public class UInterpGroupInst
	{
		///<summary>UInterpGroup *</summary>
		public const int Group = 0x0028;

		///<summary>AActor *</summary>
		public const int GroupActor = 0x0030;

		///<summary>TArray&lt;UInterpTrackInst * &gt;</summary>
		public const int TrackInst = 0x0038;

	}

	public class UInterpTrack
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UInterpTrack * &gt;</summary>
		public const int SubTracks = 0x0038;

		///<summary>UClass *</summary>
		public const int TrackInstClass = 0x0048;

		///<summary>TEnumAsByte&lt;ETrackActiveCondition&gt;</summary>
		public const int ActiveCondition = 0x0050;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0051;

		///<summary>FString</summary>
		public const int TrackTitle = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int bOnePerGroup = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bDirGroupOnly = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bDisableTrack = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bIsSelected = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bIsAnimControlTrack = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bSubTrackOnly = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bVisible = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bIsRecording = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0069;

	}

	public class UInterpTrackBoolProp
	{
		///<summary>TArray&lt;FBoolTrackKey&gt;</summary>
		public const int BoolTrack = 0x0070;

		///<summary>FName</summary>
		public const int PropertyName = 0x0080;

	}

	public class UInterpTrackDirector
	{
		///<summary>TArray&lt;FDirectorTrackCut&gt;</summary>
		public const int CutTrack = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bSimulateCameraCutsOnClients = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackEvent
	{
		///<summary>TArray&lt;FEventTrackKey&gt;</summary>
		public const int EventTrack = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenForwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenBackwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenJumpingForwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bUseCustomEventName = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackFloatBase
	{
		///<summary>FInterpCurveFloat</summary>
		public const int FloatTrack = 0x0070;

		///<summary>float</summary>
		public const int CurveTension = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UInterpTrackAnimControl
	{
		///<summary>FName</summary>
		public const int SlotName = 0x0090;

		///<summary>TArray&lt;FAnimControlTrackKey&gt;</summary>
		public const int AnimSeqs = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bSkipAnimNotifiers = 0x00A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A9;

	}

	public class UInterpTrackFade
	{
		///<summary>unsigned char:1</summary>
		public const int bPersistFade = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bFadeAudio = 0x0090;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0091;

		///<summary>FLinearColor</summary>
		public const int FadeColor = 0x0094;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x00A4;

	}

	public class UInterpTrackFloatAnimBPParam
	{
		///<summary>UAnimBlueprintGeneratedClass *</summary>
		public const int AnimBlueprintClass = 0x0090;

		///<summary>UClass *</summary>
		public const int AnimClass = 0x0098;

		///<summary>FName</summary>
		public const int ParamName = 0x00A0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00A8;

	}

	public class UInterpTrackFloatMaterialParam
	{
		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int TargetMaterials = 0x0090;

		///<summary>FName</summary>
		public const int ParamName = 0x00A0;

	}

	public class UInterpTrackFloatParticleParam
	{
		///<summary>FName</summary>
		public const int ParamName = 0x0090;

	}

	public class UInterpTrackFloatProp
	{
		///<summary>FName</summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackMove
	{
		///<summary>FInterpCurveVector</summary>
		public const int PosTrack = 0x0070;

		///<summary>FInterpCurveVector</summary>
		public const int EulerTrack = 0x0088;

		///<summary>FInterpLookupTrack</summary>
		public const int LookupTrack = 0x00A0;

		///<summary>FName</summary>
		public const int LookAtGroupName = 0x00B0;

		///<summary>float</summary>
		public const int LinCurveTension = 0x00B8;

		///<summary>float</summary>
		public const int AngCurveTension = 0x00BC;

		///<summary>unsigned char:1</summary>
		public const int bUseQuatInterpolation = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bShowArrowAtKeys = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bDisableMovement = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bShowTranslationOnCurveEd = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bShowRotationOnCurveEd = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bHide3DTrack = 0x00C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00C1;

		///<summary>TEnumAsByte&lt;EInterpTrackMoveRotMode&gt;</summary>
		public const int RotMode = 0x00C4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00C5;

	}

	public class UInterpTrackMoveAxis
	{
		///<summary>TEnumAsByte&lt;EInterpMoveAxis&gt;</summary>
		public const int MoveAxis = 0x0090;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0091;

		///<summary>FInterpLookupTrack</summary>
		public const int LookupTrack = 0x0098;

	}

	public class UInterpTrackLinearColorBase
	{
		///<summary>FInterpCurveLinearColor</summary>
		public const int LinearColorTrack = 0x0070;

		///<summary>float</summary>
		public const int CurveTension = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UInterpTrackLinearColorProp
	{
		///<summary>FName</summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackParticleReplay
	{
		///<summary>TArray&lt;FParticleReplayTrackKey&gt;</summary>
		public const int TrackKeys = 0x0070;

	}

	public class UInterpTrackToggle
	{
		///<summary>TArray&lt;FToggleTrackKey&gt;</summary>
		public const int ToggleTrack = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bActivateSystemEachUpdate = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bActivateWithJustAttachedFlag = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenForwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenBackwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenJumpingForwards = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackVectorBase
	{
		///<summary>FInterpCurveVector</summary>
		public const int VectorTrack = 0x0070;

		///<summary>float</summary>
		public const int CurveTension = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UInterpTrackColorProp
	{
		///<summary>FName</summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackSound
	{
		///<summary>TArray&lt;FSoundTrackKey&gt;</summary>
		public const int Sounds = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bPlayOnReverse = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bContinueSoundOnMatineeEnd = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bSuppressSubtitles = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bTreatAsDialogue = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bAttach = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A1;

	}

	public class UInterpTrackVectorMaterialParam
	{
		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int TargetMaterials = 0x0090;

		///<summary>FName</summary>
		public const int ParamName = 0x00A0;

	}

	public class UInterpTrackVectorProp
	{
		///<summary>FName</summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackVisibility
	{
		///<summary>TArray&lt;FVisibilityTrackKey&gt;</summary>
		public const int VisibilityTrack = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenForwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenBackwards = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bFireEventsWhenJumpingForwards = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackInstAnimControl
	{
		///<summary>float</summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstDirector
	{
		///<summary>AActor *</summary>
		public const int OldViewTarget = 0x0028;

	}

	public class UInterpTrackInstEvent
	{
		///<summary>float</summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstFloatAnimBPParam
	{
		///<summary>UAnimInstance *</summary>
		public const int AnimScriptInstance = 0x0028;

		///<summary>float</summary>
		public const int ResetFloat = 0x0030;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UInterpTrackInstFloatMaterialParam
	{
		///<summary>TArray&lt;UMaterialInstanceDynamic * &gt;</summary>
		public const int MaterialInstances = 0x0028;

		///<summary>TArray&lt;float&gt;</summary>
		public const int ResetFloats = 0x0038;

		///<summary>TArray&lt;FPrimitiveMaterialRef&gt;</summary>
		public const int PrimitiveMaterialRefs = 0x0048;

		///<summary>UInterpTrackFloatMaterialParam *</summary>
		public const int InstancedTrack = 0x0058;

	}

	public class UInterpTrackInstFloatParticleParam
	{
		///<summary>float</summary>
		public const int ResetFloat = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstMove
	{
		///<summary>FVector</summary>
		public const int ResetLocation = 0x0028;

		///<summary>FRotator</summary>
		public const int ResetRotation = 0x0034;

	}

	public class UInterpTrackInstParticleReplay
	{
		///<summary>float</summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstProperty
	{
		///<summary>UProperty *</summary>
		public const int InterpProperty = 0x0028;

		///<summary>UObject *</summary>
		public const int PropertyOuterObjectInst = 0x0030;

	}

	public class UInterpTrackInstBoolProp
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>UBoolProperty *</summary>
		public const int BoolProperty = 0x0040;

		///<summary>bool</summary>
		public const int ResetBool = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0049;

	}

	public class UInterpTrackInstColorProp
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>FColor</summary>
		public const int ResetColor = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UInterpTrackInstFloatProp
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>float</summary>
		public const int ResetFloat = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UInterpTrackInstLinearColorProp
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>FLinearColor</summary>
		public const int ResetColor = 0x0040;

	}

	public class UInterpTrackInstVectorProp
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>FVector</summary>
		public const int ResetVector = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x004C;

	}

	public class UInterpTrackInstSlomo
	{
		///<summary>float</summary>
		public const int OldTimeDilation = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstSound
	{
		///<summary>float</summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

		///<summary>UAudioComponent *</summary>
		public const int PlayAudioComp = 0x0030;

	}

	public class UInterpTrackInstToggle
	{
		///<summary>TEnumAsByte&lt;ETrackToggleAction&gt;</summary>
		public const int Action = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>float</summary>
		public const int LastUpdatePosition = 0x002C;

		///<summary>unsigned char:1</summary>
		public const int bSavedActiveState = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

	}

	public class UInterpTrackInstVectorMaterialParam
	{
		///<summary>TArray&lt;UMaterialInstanceDynamic * &gt;</summary>
		public const int MaterialInstances = 0x0028;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int ResetVectors = 0x0038;

		///<summary>TArray&lt;FPrimitiveMaterialRef&gt;</summary>
		public const int PrimitiveMaterialRefs = 0x0048;

		///<summary>UInterpTrackVectorMaterialParam *</summary>
		public const int InstancedTrack = 0x0058;

	}

	public class UInterpTrackInstVisibility
	{
		///<summary>TEnumAsByte&lt;EVisibilityTrackAction&gt;</summary>
		public const int Action = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>float</summary>
		public const int LastUpdatePosition = 0x002C;

	}

	public class UIntSerialization
	{
		///<summary>uint16_t</summary>
		public const int UnsignedInt16Variable = 0x0028;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x002A;

		///<summary>uint32_t</summary>
		public const int UnsignedInt32Variable = 0x002C;

		///<summary>uint64_t</summary>
		public const int UnsignedInt64Variable = 0x0030;

		///<summary>int8_t</summary>
		public const int SignedInt8Variable = 0x0038;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x0039;

		///<summary>int16_t</summary>
		public const int SignedInt16Variable = 0x003A;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x003C;

		///<summary>int64_t</summary>
		public const int SignedInt64Variable = 0x0040;

		///<summary>unsigned char</summary>
		public const int UnsignedInt8Variable = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0049;

		///<summary>int</summary>
		public const int SignedInt32Variable = 0x004C;

	}

	public class ULayer
	{
		///<summary>FName</summary>
		public const int LayerName = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bIsVisible = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>TArray&lt;FLayerActorStats&gt;</summary>
		public const int ActorStats = 0x0038;

	}

	public class ULevelActorContainer
	{
		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int Actors = 0x0028;

	}

	public class ULevelStreaming
	{
		///<summary>FName</summary>
		public const int PackageName = 0x0028;

		///<summary>TAssetPtr&lt;UWorld&gt;</summary>
		public const int WorldAsset = 0x0030;

		///<summary>FName</summary>
		public const int PackageNameToLoad = 0x0050;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int LODPackageNames = 0x0058;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0068;

		///<summary>FTransform</summary>
		public const int LevelTransform = 0x0080;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData01 = 0x00B0;

		///<summary>unsigned char:3</summary>
		public const int UnknownData02 = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bShouldBeVisibleInEditor = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bLocked = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bShouldBeLoaded = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bShouldBeVisible = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bIsStatic = 0x00C4;

		///<summary>unsigned char:1</summary>
		public const int bShouldBlockOnLoad = 0x00C5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x00C6;

		///<summary>int</summary>
		public const int LevelLODIndex = 0x00C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x00CC;

		///<summary>unsigned char:1</summary>
		public const int bDisableDistanceStreaming = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int UnknownData05 = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bDrawOnLevelStatusMap = 0x00D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x00D1;

		///<summary>FColor</summary>
		public const int DrawColor = 0x00D4;

		///<summary>FLinearColor</summary>
		public const int LevelColor = 0x00D8;

		///<summary>TArray&lt;ALevelStreamingVolume * &gt;</summary>
		public const int EditorStreamingVolumes = 0x00E8;

		///<summary>float</summary>
		public const int MinTimeBetweenVolumeUnloadRequests = 0x00F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x00FC;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int Keywords = 0x0100;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLevelLoaded = 0x0110;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLevelUnloaded = 0x0120;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLevelShown = 0x0130;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLevelHidden = 0x0140;

		///<summary>ULevel *</summary>
		public const int LoadedLevel = 0x0150;

		///<summary>ULevel *</summary>
		public const int PendingUnloadLevel = 0x0158;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData08 = 0x0160;

	}

	public class ULevelStreamingKismet
	{
		///<summary>unsigned char:1</summary>
		public const int bInitiallyLoaded = 0x0170;

		///<summary>unsigned char:1</summary>
		public const int bInitiallyVisible = 0x0170;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x0171;

	}

	public class ULightmappedSurfaceCollection
	{
		///<summary>UModel *</summary>
		public const int SourceModel = 0x0028;

		///<summary>TArray&lt;int&gt;</summary>
		public const int Surfaces = 0x0030;

	}

	public class ULightmassPrimitiveSettingsObject
	{
		///<summary>FLightmassPrimitiveSettings</summary>
		public const int LightmassSettings = 0x0028;

	}

	public class UEngineMessage
	{
		///<summary>FString</summary>
		public const int FailedPlaceMessage = 0x0028;

		///<summary>FString</summary>
		public const int MaxedOutMessage = 0x0038;

		///<summary>FString</summary>
		public const int EnteredMessage = 0x0048;

		///<summary>FString</summary>
		public const int LeftMessage = 0x0058;

		///<summary>FString</summary>
		public const int GlobalNameChange = 0x0068;

		///<summary>FString</summary>
		public const int SpecEnteredMessage = 0x0078;

		///<summary>FString</summary>
		public const int NewPlayerMessage = 0x0088;

		///<summary>FString</summary>
		public const int NewSpecMessage = 0x0098;

	}

	public class UMapBuildDataRegistry
	{
		///<summary>TEnumAsByte&lt;ELightingBuildQuality&gt;</summary>
		public const int LevelLightingQuality = 0x0028;

		///<summary>unsigned char[0xF7]</summary>
		public const int UnknownData00 = 0x0029;

	}

	public class UMaterialExpressionAbs
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionAdd
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>float</summary>
		public const int ConstA = 0x00D0;

		///<summary>float</summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionAppendVector
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionArccosine
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionArccosineFast
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionArcsine
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionArcsineFast
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionArctangent
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionArctangent2
	{
		///<summary>FExpressionInput</summary>
		public const int Y = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int X = 0x0098;

	}

	public class UMaterialExpressionArctangent2Fast
	{
		///<summary>FExpressionInput</summary>
		public const int Y = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int X = 0x0098;

	}

	public class UMaterialExpressionArctangentFast
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionAtmosphericFogColor
	{
		///<summary>FExpressionInput</summary>
		public const int WorldPosition = 0x0060;

	}

	public class UMaterialExpressionBlackBody
	{
		///<summary>FExpressionInput</summary>
		public const int Temp = 0x0060;

	}

	public class UMaterialExpressionBlendMaterialAttributes
	{
		///<summary>FMaterialAttributesInput</summary>
		public const int A = 0x0060;

		///<summary>FMaterialAttributesInput</summary>
		public const int B = 0x00A0;

		///<summary>FExpressionInput</summary>
		public const int Alpha = 0x00E0;

		///<summary>TEnumAsByte&lt;EMaterialAttributeBlend&gt;</summary>
		public const int PixelAttributeBlendType = 0x0118;

		///<summary>TEnumAsByte&lt;EMaterialAttributeBlend&gt;</summary>
		public const int VertexAttributeBlendType = 0x0119;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x011A;

	}

	public class UMaterialExpressionBreakMaterialAttributes
	{
		///<summary>FMaterialAttributesInput</summary>
		public const int MaterialAttributes = 0x0060;

	}

	public class UMaterialExpressionBumpOffset
	{
		///<summary>FExpressionInput</summary>
		public const int Coordinate = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Height = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int HeightRatioInput = 0x00D0;

		///<summary>float</summary>
		public const int HeightRatio = 0x0108;

		///<summary>float</summary>
		public const int ReferencePlane = 0x010C;

		///<summary>uint32_t</summary>
		public const int ConstCoordinate = 0x0110;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0114;

	}

	public class UMaterialExpressionCeil
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionClamp
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Min = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int Max = 0x00D0;

		///<summary>TEnumAsByte&lt;EClampMode&gt;</summary>
		public const int ClampMode = 0x0108;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0109;

		///<summary>float</summary>
		public const int MinDefault = 0x010C;

		///<summary>float</summary>
		public const int MaxDefault = 0x0110;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0114;

	}

	public class UMaterialExpressionCollectionParameter
	{
		///<summary>UMaterialParameterCollection *</summary>
		public const int Collection = 0x0060;

		///<summary>FName</summary>
		public const int ParameterName = 0x0068;

		///<summary>FGuid</summary>
		public const int ParameterId = 0x0070;

	}

	public class UMaterialExpressionComment
	{
		///<summary>int</summary>
		public const int SizeX = 0x0060;

		///<summary>int</summary>
		public const int SizeY = 0x0064;

		///<summary>FString</summary>
		public const int Text = 0x0068;

		///<summary>FLinearColor</summary>
		public const int CommentColor = 0x0078;

	}

	public class UMaterialExpressionComponentMask
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int R = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int G = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int B = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int A = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UMaterialExpressionConstant
	{
		///<summary>float</summary>
		public const int R = 0x0060;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0064;

	}

	public class UMaterialExpressionConstant2Vector
	{
		///<summary>float</summary>
		public const int R = 0x0060;

		///<summary>float</summary>
		public const int G = 0x0064;

	}

	public class UMaterialExpressionConstant3Vector
	{
		///<summary>FLinearColor</summary>
		public const int Constant = 0x0060;

	}

	public class UMaterialExpressionConstant4Vector
	{
		///<summary>FLinearColor</summary>
		public const int Constant = 0x0060;

	}

	public class UMaterialExpressionConstantBiasScale
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>float</summary>
		public const int Bias = 0x0098;

		///<summary>float</summary>
		public const int Scale = 0x009C;

	}

	public class UMaterialExpressionCosine
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>float</summary>
		public const int Period = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionCrossProduct
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionCustom
	{
		///<summary>FString</summary>
		public const int Code = 0x0060;

		///<summary>TEnumAsByte&lt;ECustomMaterialOutputType&gt;</summary>
		public const int OutputType = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0071;

		///<summary>FString</summary>
		public const int Description = 0x0078;

		///<summary>TArray&lt;FCustomInput&gt;</summary>
		public const int Inputs = 0x0088;

	}

	public class UMaterialExpressionClearCoatNormalCustomOutput
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionTangentOutput
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionVertexInterpolator
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UMaterialExpressionDDX
	{
		///<summary>FExpressionInput</summary>
		public const int Value = 0x0060;

	}

	public class UMaterialExpressionDDY
	{
		///<summary>FExpressionInput</summary>
		public const int Value = 0x0060;

	}

	public class UMaterialExpressionDecalMipmapLevel
	{
		///<summary>FExpressionInput</summary>
		public const int TextureSize = 0x0060;

		///<summary>float</summary>
		public const int ConstWidth = 0x0098;

		///<summary>float</summary>
		public const int ConstHeight = 0x009C;

	}

	public class UMaterialExpressionDepthFade
	{
		///<summary>FExpressionInput</summary>
		public const int InOpacity = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int FadeDistance = 0x0098;

		///<summary>float</summary>
		public const int OpacityDefault = 0x00D0;

		///<summary>float</summary>
		public const int FadeDistanceDefault = 0x00D4;

	}

	public class UMaterialExpressionDepthOfFieldFunction
	{
		///<summary>TEnumAsByte&lt;EDepthOfFieldFunctionValue&gt;</summary>
		public const int FunctionValue = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

		///<summary>FExpressionInput</summary>
		public const int Depth = 0x0068;

	}

	public class UMaterialExpressionDeriveNormalZ
	{
		///<summary>FExpressionInput</summary>
		public const int InXY = 0x0060;

	}

	public class UMaterialExpressionDesaturation
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Fraction = 0x0098;

		///<summary>FLinearColor</summary>
		public const int LuminanceFactors = 0x00D0;

	}

	public class UMaterialExpressionDistance
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionDistanceFieldGradient
	{
		///<summary>FExpressionInput</summary>
		public const int Position = 0x0060;

	}

	public class UMaterialExpressionDistanceToNearestSurface
	{
		///<summary>FExpressionInput</summary>
		public const int Position = 0x0060;

	}

	public class UMaterialExpressionDivide
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>float</summary>
		public const int ConstA = 0x00D0;

		///<summary>float</summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionDotProduct
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionDynamicParameter
	{
		///<summary>TArray&lt;FString&gt;</summary>
		public const int ParamNames = 0x0060;

		///<summary>FLinearColor</summary>
		public const int DefaultValue = 0x0070;

	}

	public class UMaterialExpressionFeatureLevelSwitch
	{
		///<summary>FExpressionInput</summary>
		public const int Default = 0x0060;

		///<summary>FExpressionInput[0x4]</summary>
		public const int Inputs = 0x0098;

	}

	public class UMaterialExpressionFloor
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionFmod
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionFontSample
	{
		///<summary>UFont *</summary>
		public const int Font = 0x0060;

		///<summary>int</summary>
		public const int FontTexturePage = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x006C;

	}

	public class UMaterialExpressionFontSampleParameter
	{
		///<summary>FName</summary>
		public const int ParameterName = 0x0070;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x0078;

		///<summary>FName</summary>
		public const int Group = 0x0088;

	}

	public class UMaterialExpressionFrac
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionFresnel
	{
		///<summary>FExpressionInput</summary>
		public const int ExponentIn = 0x0060;

		///<summary>float</summary>
		public const int Exponent = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

		///<summary>FExpressionInput</summary>
		public const int BaseReflectFractionIn = 0x00A0;

		///<summary>float</summary>
		public const int BaseReflectFraction = 0x00D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x00DC;

		///<summary>FExpressionInput</summary>
		public const int Normal = 0x00E0;

	}

	public class UMaterialExpressionFunctionInput
	{
		///<summary>FExpressionInput</summary>
		public const int Preview = 0x0060;

		///<summary>FString</summary>
		public const int InputName = 0x0098;

		///<summary>FString</summary>
		public const int Description = 0x00A8;

		///<summary>FGuid</summary>
		public const int ID = 0x00B8;

		///<summary>TEnumAsByte&lt;EFunctionInputType&gt;</summary>
		public const int InputType = 0x00C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00C9;

		///<summary>FVector4</summary>
		public const int PreviewValue = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bUsePreviewValueAsDefault = 0x00E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00E1;

		///<summary>int</summary>
		public const int SortPriority = 0x00E4;

		///<summary>unsigned char:1</summary>
		public const int bCompilingFunctionPreview = 0x00E8;

		///<summary>unsigned char[0x47]</summary>
		public const int UnknownData02 = 0x00E9;

	}

	public class UMaterialExpressionFunctionOutput
	{
		///<summary>FString</summary>
		public const int OutputName = 0x0060;

		///<summary>FString</summary>
		public const int Description = 0x0070;

		///<summary>int</summary>
		public const int SortPriority = 0x0080;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0084;

		///<summary>FExpressionInput</summary>
		public const int A = 0x0088;

		///<summary>unsigned char:1</summary>
		public const int bLastPreviewed = 0x00C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00C1;

		///<summary>FGuid</summary>
		public const int ID = 0x00C4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00D4;

	}

	public class UMaterialExpressionGetMaterialAttributes
	{
		///<summary>FMaterialAttributesInput</summary>
		public const int MaterialAttributes = 0x0060;

		///<summary>TArray&lt;FGuid&gt;</summary>
		public const int AttributeGetTypes = 0x00A0;

	}

	public class UMaterialExpressionGIReplace
	{
		///<summary>FExpressionInput</summary>
		public const int Default = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int StaticIndirect = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int DynamicIndirect = 0x00D0;

	}

	public class UMaterialExpressionIf
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int AGreaterThanB = 0x00D0;

		///<summary>FExpressionInput</summary>
		public const int AEqualsB = 0x0108;

		///<summary>FExpressionInput</summary>
		public const int ALessThanB = 0x0140;

		///<summary>float</summary>
		public const int EqualsThreshold = 0x0178;

		///<summary>float</summary>
		public const int ConstB = 0x017C;

		///<summary>float</summary>
		public const int ConstAEqualsB = 0x0180;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0184;

	}

	public class UMaterialExpressionLightmassReplace
	{
		///<summary>FExpressionInput</summary>
		public const int Realtime = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Lightmass = 0x0098;

	}

	public class UMaterialExpressionLinearInterpolate
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int Alpha = 0x00D0;

		///<summary>float</summary>
		public const int ConstA = 0x0108;

		///<summary>float</summary>
		public const int ConstB = 0x010C;

		///<summary>float</summary>
		public const int ConstAlpha = 0x0110;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0114;

	}

	public class UMaterialExpressionLogarithm2
	{
		///<summary>FExpressionInput</summary>
		public const int X = 0x0060;

	}

	public class UMaterialExpressionMakeMaterialAttributes
	{
		///<summary>FExpressionInput</summary>
		public const int BaseColor = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Metallic = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int Specular = 0x00D0;

		///<summary>FExpressionInput</summary>
		public const int Roughness = 0x0108;

		///<summary>FExpressionInput</summary>
		public const int EmissiveColor = 0x0140;

		///<summary>FExpressionInput</summary>
		public const int Opacity = 0x0178;

		///<summary>FExpressionInput</summary>
		public const int OpacityMask = 0x01B0;

		///<summary>FExpressionInput</summary>
		public const int Normal = 0x01E8;

		///<summary>FExpressionInput</summary>
		public const int WorldPositionOffset = 0x0220;

		///<summary>FExpressionInput</summary>
		public const int WorldDisplacement = 0x0258;

		///<summary>FExpressionInput</summary>
		public const int TessellationMultiplier = 0x0290;

		///<summary>FExpressionInput</summary>
		public const int SubsurfaceColor = 0x02C8;

		///<summary>FExpressionInput</summary>
		public const int ClearCoat = 0x0300;

		///<summary>FExpressionInput</summary>
		public const int ClearCoatRoughness = 0x0338;

		///<summary>FExpressionInput</summary>
		public const int AmbientOcclusion = 0x0370;

		///<summary>FExpressionInput</summary>
		public const int Refraction = 0x03A8;

		///<summary>FExpressionInput[0x8]</summary>
		public const int CustomizedUVs = 0x03E0;

		///<summary>FExpressionInput</summary>
		public const int PixelDepthOffset = 0x05A0;

	}

	public class UMaterialExpressionMaterialFunctionCall
	{
		///<summary>UMaterialFunction *</summary>
		public const int MaterialFunction = 0x0060;

		///<summary>TArray&lt;FFunctionExpressionInput&gt;</summary>
		public const int FunctionInputs = 0x0068;

		///<summary>TArray&lt;FFunctionExpressionOutput&gt;</summary>
		public const int FunctionOutputs = 0x0078;

	}

	public class UMaterialExpressionMaterialProxyReplace
	{
		///<summary>FExpressionInput</summary>
		public const int Realtime = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int MaterialProxy = 0x0098;

	}

	public class UMaterialExpressionMax
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>float</summary>
		public const int ConstA = 0x00D0;

		///<summary>float</summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionMin
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>float</summary>
		public const int ConstA = 0x00D0;

		///<summary>float</summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionMultiply
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>float</summary>
		public const int ConstA = 0x00D0;

		///<summary>float</summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionNoise
	{
		///<summary>FExpressionInput</summary>
		public const int Position = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int FilterWidth = 0x0098;

		///<summary>float</summary>
		public const int Scale = 0x00D0;

		///<summary>int</summary>
		public const int Quality = 0x00D4;

		///<summary>TEnumAsByte&lt;ENoiseFunction&gt;</summary>
		public const int NoiseFunction = 0x00D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00D9;

		///<summary>unsigned char:1</summary>
		public const int bTurbulence = 0x00DC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00DD;

		///<summary>int</summary>
		public const int Levels = 0x00E0;

		///<summary>float</summary>
		public const int OutputMin = 0x00E4;

		///<summary>float</summary>
		public const int OutputMax = 0x00E8;

		///<summary>float</summary>
		public const int LevelScale = 0x00EC;

		///<summary>unsigned char:1</summary>
		public const int bTiling = 0x00F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00F1;

		///<summary>uint32_t</summary>
		public const int RepeatSize = 0x00F4;

	}

	public class UMaterialExpressionNormalize
	{
		///<summary>FExpressionInput</summary>
		public const int VectorInput = 0x0060;

	}

	public class UMaterialExpressionOneMinus
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionPanner
	{
		///<summary>FExpressionInput</summary>
		public const int Coordinate = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Time = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int Speed = 0x00D0;

		///<summary>float</summary>
		public const int SpeedX = 0x0108;

		///<summary>float</summary>
		public const int SpeedY = 0x010C;

		///<summary>uint32_t</summary>
		public const int ConstCoordinate = 0x0110;

		///<summary>bool</summary>
		public const int bFractionalPart = 0x0114;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0115;

	}

	public class UMaterialExpressionParameter
	{
		///<summary>FName</summary>
		public const int ParameterName = 0x0060;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x0068;

		///<summary>FName</summary>
		public const int Group = 0x0078;

	}

	public class UMaterialExpressionScalarParameter
	{
		///<summary>float</summary>
		public const int DefaultValue = 0x0080;

		///<summary>float</summary>
		public const int SliderMin = 0x0084;

		///<summary>float</summary>
		public const int SliderMax = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UMaterialExpressionStaticBoolParameter
	{
		///<summary>unsigned char:1</summary>
		public const int DefaultValue = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UMaterialExpressionStaticSwitchParameter
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0088;

		///<summary>FExpressionInput</summary>
		public const int B = 0x00C0;

	}

	public class UMaterialExpressionStaticComponentMaskParameter
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int DefaultR = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int DefaultG = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int DefaultB = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int DefaultA = 0x00B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UMaterialExpressionVectorParameter
	{
		///<summary>FLinearColor</summary>
		public const int DefaultValue = 0x0080;

	}

	public class UMaterialExpressionPower
	{
		///<summary>FExpressionInput</summary>
		public const int Base = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Exponent = 0x0098;

		///<summary>float</summary>
		public const int ConstExponent = 0x00D0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00D4;

	}

	public class UMaterialExpressionPreviousFrameSwitch
	{
		///<summary>FExpressionInput</summary>
		public const int CurrentFrame = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int PreviousFrame = 0x0098;

	}

	public class UMaterialExpressionQualitySwitch
	{
		///<summary>FExpressionInput</summary>
		public const int Default = 0x0060;

		///<summary>FExpressionInput[0x3]</summary>
		public const int Inputs = 0x0098;

	}

	public class UMaterialExpressionReflectionVectorWS
	{
		///<summary>FExpressionInput</summary>
		public const int CustomWorldNormal = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bNormalizeCustomWorldNormal = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UMaterialExpressionReroute
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionRotateAboutAxis
	{
		///<summary>FExpressionInput</summary>
		public const int NormalizedRotationAxis = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int RotationAngle = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int PivotPoint = 0x00D0;

		///<summary>FExpressionInput</summary>
		public const int Position = 0x0108;

		///<summary>float</summary>
		public const int Period = 0x0140;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0144;

	}

	public class UMaterialExpressionRotator
	{
		///<summary>FExpressionInput</summary>
		public const int Coordinate = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int Time = 0x0098;

		///<summary>float</summary>
		public const int CenterX = 0x00D0;

		///<summary>float</summary>
		public const int CenterY = 0x00D4;

		///<summary>float</summary>
		public const int Speed = 0x00D8;

		///<summary>uint32_t</summary>
		public const int ConstCoordinate = 0x00DC;

	}

	public class UMaterialExpressionRound
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionSaturate
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionSceneColor
	{
		///<summary>TEnumAsByte&lt;EMaterialSceneAttributeInputMode&gt;</summary>
		public const int InputMode = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

		///<summary>FExpressionInput</summary>
		public const int Input = 0x0068;

		///<summary>FExpressionInput</summary>
		public const int OffsetFraction = 0x00A0;

		///<summary>FVector2D</summary>
		public const int ConstInput = 0x00D8;

	}

	public class UMaterialExpressionSceneDepth
	{
		///<summary>TEnumAsByte&lt;EMaterialSceneAttributeInputMode&gt;</summary>
		public const int InputMode = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

		///<summary>FExpressionInput</summary>
		public const int Input = 0x0068;

		///<summary>FExpressionInput</summary>
		public const int Coordinates = 0x00A0;

		///<summary>FVector2D</summary>
		public const int ConstInput = 0x00D8;

	}

	public class UMaterialExpressionSceneTexture
	{
		///<summary>FExpressionInput</summary>
		public const int Coordinates = 0x0060;

		///<summary>TEnumAsByte&lt;ESceneTextureId&gt;</summary>
		public const int SceneTextureId = 0x0098;

		///<summary>bool</summary>
		public const int bClampUVs = 0x0099;

		///<summary>bool</summary>
		public const int bFiltered = 0x009A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x009B;

	}

	public class UMaterialExpressionScreenPosition
	{
		///<summary>TEnumAsByte&lt;EMaterialExpressionScreenPositionMapping&gt;</summary>
		public const int Mapping = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialExpressionSetMaterialAttributes
	{
		///<summary>TArray&lt;FExpressionInput&gt;</summary>
		public const int Inputs = 0x0060;

		///<summary>TArray&lt;FGuid&gt;</summary>
		public const int AttributeSetTypes = 0x0070;

	}

	public class UMaterialExpressionSign
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionSine
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>float</summary>
		public const int Period = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionSpeedTree
	{
		///<summary>TEnumAsByte&lt;ESpeedTreeGeometryType&gt;</summary>
		public const int GeometryType = 0x0060;

		///<summary>TEnumAsByte&lt;ESpeedTreeWindType&gt;</summary>
		public const int WindType = 0x0061;

		///<summary>TEnumAsByte&lt;ESpeedTreeLODType&gt;</summary>
		public const int LODType = 0x0062;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0063;

		///<summary>float</summary>
		public const int BillboardThreshold = 0x0064;

		///<summary>bool</summary>
		public const int bAccurateWindVelocities = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0069;

	}

	public class UMaterialExpressionSphereMask
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>FExpressionInput</summary>
		public const int Radius = 0x00D0;

		///<summary>FExpressionInput</summary>
		public const int Hardness = 0x0108;

		///<summary>float</summary>
		public const int AttenuationRadius = 0x0140;

		///<summary>float</summary>
		public const int HardnessPercent = 0x0144;

	}

	public class UMaterialExpressionSphericalParticleOpacity
	{
		///<summary>FExpressionInput</summary>
		public const int Density = 0x0060;

		///<summary>float</summary>
		public const int ConstantDensity = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionSquareRoot
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionStaticBool
	{
		///<summary>unsigned char:1</summary>
		public const int Value = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialExpressionStaticSwitch
	{
		///<summary>unsigned char:1</summary>
		public const int DefaultValue = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

		///<summary>FExpressionInput</summary>
		public const int A = 0x0068;

		///<summary>FExpressionInput</summary>
		public const int B = 0x00A0;

		///<summary>FExpressionInput</summary>
		public const int Value = 0x00D8;

	}

	public class UMaterialExpressionSubtract
	{
		///<summary>FExpressionInput</summary>
		public const int A = 0x0060;

		///<summary>FExpressionInput</summary>
		public const int B = 0x0098;

		///<summary>float</summary>
		public const int ConstA = 0x00D0;

		///<summary>float</summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionTangent
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>float</summary>
		public const int Period = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionTerrainBlend
	{
		///<summary>TArray&lt;FTerrainLayer&gt;</summary>
		public const int Inputs = 0x0060;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0070;

	}

	public class UMaterialExpressionTextureBase
	{
		///<summary>UTexture *</summary>
		public const int Texture = 0x0060;

		///<summary>TEnumAsByte&lt;EMaterialSamplerType&gt;</summary>
		public const int SamplerType = 0x0068;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0069;

		///<summary>unsigned char:1</summary>
		public const int IsDefaultMeshpaintTexture = 0x006C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x006D;

	}

	public class UMaterialExpressionTextureSample
	{
		///<summary>FExpressionInput</summary>
		public const int Coordinates = 0x0070;

		///<summary>FExpressionInput</summary>
		public const int TextureObject = 0x00A8;

		///<summary>FExpressionInput</summary>
		public const int MipValue = 0x00E0;

		///<summary>FExpressionInput</summary>
		public const int CoordinatesDX = 0x0118;

		///<summary>FExpressionInput</summary>
		public const int CoordinatesDY = 0x0150;

		///<summary>TEnumAsByte&lt;ETextureMipValueMode&gt;</summary>
		public const int MipValueMode = 0x0188;

		///<summary>TEnumAsByte&lt;ESamplerSourceMode&gt;</summary>
		public const int SamplerSource = 0x0189;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x018A;

		///<summary>uint32_t</summary>
		public const int ConstCoordinate = 0x018C;

		///<summary>int</summary>
		public const int ConstMipValue = 0x0190;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0194;

	}

	public class UMaterialExpressionParticleSubUV
	{
		///<summary>unsigned char:1</summary>
		public const int bBlend = 0x0198;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0199;

	}

	public class UMaterialExpressionTextureSampleParameter
	{
		///<summary>FName</summary>
		public const int ParameterName = 0x0198;

		///<summary>FGuid</summary>
		public const int ExpressionGUID = 0x01A0;

		///<summary>FName</summary>
		public const int Group = 0x01B0;

	}

	public class UMaterialExpressionAntialiasedTextureMask
	{
		///<summary>float</summary>
		public const int threshold = 0x01B8;

		///<summary>TEnumAsByte&lt;ETextureColorChannel&gt;</summary>
		public const int Channel = 0x01BC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x01BD;

	}

	public class UMaterialExpressionTextureSampleParameterSubUV
	{
		///<summary>unsigned char:1</summary>
		public const int bBlend = 0x01B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01B9;

	}

	public class UMaterialExpressionTextureCoordinate
	{
		///<summary>int</summary>
		public const int CoordinateIndex = 0x0060;

		///<summary>float</summary>
		public const int UTiling = 0x0064;

		///<summary>float</summary>
		public const int VTiling = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int UnMirrorU = 0x006C;

		///<summary>unsigned char:1</summary>
		public const int UnMirrorV = 0x006C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x006D;

	}

	public class UMaterialExpressionTextureProperty
	{
		///<summary>FExpressionInput</summary>
		public const int TextureObject = 0x0060;

		///<summary>TEnumAsByte&lt;EMaterialExposedTextureProperty&gt;</summary>
		public const int Property = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UMaterialExpressionTime
	{
		///<summary>unsigned char:1</summary>
		public const int bIgnorePause = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bOverride_Period = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0061;

		///<summary>float</summary>
		public const int Period = 0x0064;

	}

	public class UMaterialExpressionTransform
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>TEnumAsByte&lt;EMaterialVectorCoordTransformSource&gt;</summary>
		public const int TransformSourceType = 0x0098;

		///<summary>TEnumAsByte&lt;EMaterialVectorCoordTransform&gt;</summary>
		public const int TransformType = 0x0099;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x009A;

	}

	public class UMaterialExpressionTransformPosition
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

		///<summary>TEnumAsByte&lt;EMaterialPositionTransformSource&gt;</summary>
		public const int TransformSourceType = 0x0098;

		///<summary>TEnumAsByte&lt;EMaterialPositionTransformSource&gt;</summary>
		public const int TransformType = 0x0099;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x009A;

	}

	public class UMaterialExpressionTruncate
	{
		///<summary>FExpressionInput</summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionVectorNoise
	{
		///<summary>FExpressionInput</summary>
		public const int Position = 0x0060;

		///<summary>TEnumAsByte&lt;EVectorNoiseFunction&gt;</summary>
		public const int NoiseFunction = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0099;

		///<summary>int</summary>
		public const int Quality = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bTiling = 0x00A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00A1;

		///<summary>uint32_t</summary>
		public const int TileSize = 0x00A4;

	}

	public class UMaterialExpressionViewProperty
	{
		///<summary>TEnumAsByte&lt;EMaterialExposedViewProperty&gt;</summary>
		public const int Property = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialExpressionWorldPosition
	{
		///<summary>TEnumAsByte&lt;EWorldPositionIncludedOffsets&gt;</summary>
		public const int WorldPositionShaderOffset = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialFunction
	{
		///<summary>FGuid</summary>
		public const int StateId = 0x0028;

		///<summary>FString</summary>
		public const int Description = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bExposeToLibrary = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>TArray&lt;UMaterialExpression * &gt;</summary>
		public const int FunctionExpressions = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bReentrantFlag = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0061;

	}

	public class UMaterial
	{
		///<summary>UPhysicalMaterial *</summary>
		public const int PhysMaterial = 0x0070;

		///<summary>FColorMaterialInput</summary>
		public const int DiffuseColor = 0x0078;

		///<summary>FColorMaterialInput</summary>
		public const int SpecularColor = 0x00B8;

		///<summary>FColorMaterialInput</summary>
		public const int BaseColor = 0x00F8;

		///<summary>FScalarMaterialInput</summary>
		public const int Metallic = 0x0138;

		///<summary>FScalarMaterialInput</summary>
		public const int Specular = 0x0178;

		///<summary>FScalarMaterialInput</summary>
		public const int Roughness = 0x01B8;

		///<summary>FVectorMaterialInput</summary>
		public const int Normal = 0x01F8;

		///<summary>FColorMaterialInput</summary>
		public const int EmissiveColor = 0x0240;

		///<summary>FScalarMaterialInput</summary>
		public const int Opacity = 0x0280;

		///<summary>FScalarMaterialInput</summary>
		public const int OpacityMask = 0x02C0;

		///<summary>TEnumAsByte&lt;EMaterialDomain&gt;</summary>
		public const int MaterialDomain = 0x0300;

		///<summary>TEnumAsByte&lt;EBlendMode&gt;</summary>
		public const int BlendMode = 0x0301;

		///<summary>TEnumAsByte&lt;EDecalBlendMode&gt;</summary>
		public const int DecalBlendMode = 0x0302;

		///<summary>TEnumAsByte&lt;EMaterialDecalResponse&gt;</summary>
		public const int MaterialDecalResponse = 0x0303;

		///<summary>TEnumAsByte&lt;EMaterialShadingModel&gt;</summary>
		public const int ShadingModel = 0x0304;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0305;

		///<summary>float</summary>
		public const int OpacityMaskClipValue = 0x0308;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x030C;

		///<summary>FVectorMaterialInput</summary>
		public const int WorldPositionOffset = 0x0310;

		///<summary>FVectorMaterialInput</summary>
		public const int WorldDisplacement = 0x0358;

		///<summary>FScalarMaterialInput</summary>
		public const int TessellationMultiplier = 0x03A0;

		///<summary>FColorMaterialInput</summary>
		public const int SubsurfaceColor = 0x03E0;

		///<summary>FScalarMaterialInput</summary>
		public const int ClearCoat = 0x0420;

		///<summary>FScalarMaterialInput</summary>
		public const int ClearCoatRoughness = 0x0460;

		///<summary>FScalarMaterialInput</summary>
		public const int AmbientOcclusion = 0x04A0;

		///<summary>FScalarMaterialInput</summary>
		public const int Refraction = 0x04E0;

		///<summary>FVector2MaterialInput[0x8]</summary>
		public const int CustomizedUVs = 0x0520;

		///<summary>FMaterialAttributesInput</summary>
		public const int MaterialAttributes = 0x0760;

		///<summary>FScalarMaterialInput</summary>
		public const int PixelDepthOffset = 0x07A0;

		///<summary>unsigned char:1</summary>
		public const int bPrepassMasked = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int bEnableSeparateTranslucency = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int bEnableMobileSeparateTranslucency = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int bEnableResponsiveAA = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int bScreenSpaceReflections = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int TwoSided = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int DitheredLODTransition = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int DitherOpacityMask = 0x07E0;

		///<summary>unsigned char:1</summary>
		public const int bAllowNegativeEmissiveColor = 0x07E1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x07E2;

		///<summary>int</summary>
		public const int NumCustomizedUVs = 0x07E4;

		///<summary>TEnumAsByte&lt;ETranslucencyLightingMode&gt;</summary>
		public const int TranslucencyLightingMode = 0x07E8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x07E9;

		///<summary>float</summary>
		public const int TranslucencyDirectionalLightingIntensity = 0x07EC;

		///<summary>unsigned char:1</summary>
		public const int AllowTranslucentCustomDepthWrites = 0x07F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x07F1;

		///<summary>float</summary>
		public const int TranslucentShadowDensityScale = 0x07F4;

		///<summary>float</summary>
		public const int TranslucentSelfShadowDensityScale = 0x07F8;

		///<summary>float</summary>
		public const int TranslucentSelfShadowSecondDensityScale = 0x07FC;

		///<summary>float</summary>
		public const int TranslucentSelfShadowSecondOpacity = 0x0800;

		///<summary>float</summary>
		public const int TranslucentBackscatteringExponent = 0x0804;

		///<summary>FLinearColor</summary>
		public const int TranslucentMultipleScatteringExtinction = 0x0808;

		///<summary>float</summary>
		public const int TranslucentShadowStartOffset = 0x0818;

		///<summary>unsigned char:1</summary>
		public const int bDisableDepthTest = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bGenerateSphericalParticleNormals = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bTangentSpaceNormal = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bUseEmissiveForDynamicAreaLighting = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bBlockGI = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bUsedAsSpecialEngineMaterial = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithSkeletalMesh = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithEditorCompositing = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithParticleSprites = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithBeamTrails = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithMeshParticles = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithNiagaraSprites = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithNiagaraRibbons = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithNiagaraMeshParticles = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithStaticLighting = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithMorphTargets = 0x081D;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithSplineMeshes = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithInstancedStaticMeshes = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bUsesDistortion = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithClothing = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bUsedWithUI = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bAutomaticallySetUsageInEditor = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bFullyRough = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bUseFullPrecision = 0x081E;

		///<summary>unsigned char:1</summary>
		public const int bUseLightmapDirectionality = 0x081F;

		///<summary>unsigned char:1</summary>
		public const int bUseHQForwardReflections = 0x081F;

		///<summary>unsigned char:1</summary>
		public const int bUsePlanarForwardReflections = 0x081F;

		///<summary>unsigned char:1</summary>
		public const int bNormalCurvatureToRoughness = 0x081F;

		///<summary>TEnumAsByte&lt;EMaterialTessellationMode&gt;</summary>
		public const int D3D11TessellationMode = 0x0820;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0821;

		///<summary>unsigned char:1</summary>
		public const int bEnableCrackFreeDisplacement = 0x0824;

		///<summary>unsigned char:1</summary>
		public const int bEnableAdaptiveTessellation = 0x0824;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0825;

		///<summary>float</summary>
		public const int MaxDisplacement = 0x0828;

		///<summary>unsigned char:1</summary>
		public const int Wireframe = 0x082C;

		///<summary>unsigned char:1</summary>
		public const int bOutputVelocityOnBasePass = 0x082C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x082D;

		///<summary>int</summary>
		public const int EditorX = 0x0830;

		///<summary>int</summary>
		public const int EditorY = 0x0834;

		///<summary>int</summary>
		public const int EditorPitch = 0x0838;

		///<summary>int</summary>
		public const int EditorYaw = 0x083C;

		///<summary>TArray&lt;UMaterialExpression * &gt;</summary>
		public const int Expressions = 0x0840;

		///<summary>TArray&lt;FMaterialFunctionInfo&gt;</summary>
		public const int MaterialFunctionInfos = 0x0850;

		///<summary>TArray&lt;FMaterialParameterCollectionInfo&gt;</summary>
		public const int MaterialParameterCollectionInfos = 0x0860;

		///<summary>unsigned char:1</summary>
		public const int bCanMaskedBeAssumedOpaque = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bIsMasked = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bIsPreviewMaterial = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bUseMaterialAttributes = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bUseTranslucencyVertexFog = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bComputeFogPerPixel = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bAllowDevelopmentShaderCompile = 0x0870;

		///<summary>unsigned char:1</summary>
		public const int bIsMaterialEditorStatsMaterial = 0x0870;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0871;

		///<summary>uint32_t</summary>
		public const int UsageFlagWarnings = 0x0874;

		///<summary>TEnumAsByte&lt;EBlendableLocation&gt;</summary>
		public const int BlendableLocation = 0x0878;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x0879;

		///<summary>int</summary>
		public const int BlendablePriority = 0x087C;

		///<summary>bool</summary>
		public const int BlendableOutputAlpha = 0x0880;

		///<summary>TEnumAsByte&lt;ERefractionMode&gt;</summary>
		public const int RefractionMode = 0x0881;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData10 = 0x0882;

		///<summary>float</summary>
		public const int RefractionDepthBias = 0x0884;

		///<summary>FGuid</summary>
		public const int StateId = 0x0888;

		///<summary>unsigned char[0xE0]</summary>
		public const int UnknownData11 = 0x0898;

		///<summary>TArray&lt;UTexture * &gt;</summary>
		public const int ExpressionTextureReferences = 0x0978;

	}

	public class UMaterialInstanceDynamic
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x01B0;

	}

	public class UMaterialParameterCollection
	{
		///<summary>FGuid</summary>
		public const int StateId = 0x0028;

		///<summary>TArray&lt;FCollectionScalarParameter&gt;</summary>
		public const int ScalarParameters = 0x0038;

		///<summary>TArray&lt;FCollectionVectorParameter&gt;</summary>
		public const int VectorParameters = 0x0048;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0058;

	}

	public class UMaterialParameterCollectionInstance
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UMaterialParameterCollection *</summary>
		public const int Collection = 0x0030;

		///<summary>UWorld *</summary>
		public const int World = 0x0038;

		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UMorphTarget
	{
		///<summary>USkeletalMesh *</summary>
		public const int BaseSkelMesh = 0x0028;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UNavAreaMeta_SwitchByAgent
	{
		///<summary>UClass *</summary>
		public const int Agent0Area = 0x0040;

		///<summary>UClass *</summary>
		public const int Agent1Area = 0x0048;

		///<summary>UClass *</summary>
		public const int Agent2Area = 0x0050;

		///<summary>UClass *</summary>
		public const int Agent3Area = 0x0058;

		///<summary>UClass *</summary>
		public const int Agent4Area = 0x0060;

		///<summary>UClass *</summary>
		public const int Agent5Area = 0x0068;

		///<summary>UClass *</summary>
		public const int Agent6Area = 0x0070;

		///<summary>UClass *</summary>
		public const int Agent7Area = 0x0078;

		///<summary>UClass *</summary>
		public const int Agent8Area = 0x0080;

		///<summary>UClass *</summary>
		public const int Agent9Area = 0x0088;

		///<summary>UClass *</summary>
		public const int Agent10Area = 0x0090;

		///<summary>UClass *</summary>
		public const int Agent11Area = 0x0098;

		///<summary>UClass *</summary>
		public const int Agent12Area = 0x00A0;

		///<summary>UClass *</summary>
		public const int Agent13Area = 0x00A8;

		///<summary>UClass *</summary>
		public const int Agent14Area = 0x00B0;

		///<summary>UClass *</summary>
		public const int Agent15Area = 0x00B8;

	}

	public class UNavCollision
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FNavCollisionCylinder&gt;</summary>
		public const int CylinderCollision = 0x0078;

		///<summary>TArray&lt;FNavCollisionBox&gt;</summary>
		public const int BoxCollision = 0x0088;

		///<summary>UClass *</summary>
		public const int AreaClass = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bIsDynamicObstacle = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bGatherConvexGeometry = 0x00A0;

		///<summary>unsigned char[0x6F]</summary>
		public const int UnknownData01 = 0x00A1;

	}

	public class UNavigationDataChunk
	{
		///<summary>FName</summary>
		public const int NavigationDataName = 0x0028;

	}

	public class URecastNavMeshDataChunk
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UNavigationPath
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int PathUpdatedNotifier = 0x0028;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int PathPoints = 0x0038;

		///<summary>TEnumAsByte&lt;ENavigationOptionFlag&gt;</summary>
		public const int RecalculateOnInvalidation = 0x0048;

		///<summary>unsigned char[0x77]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UNodeMappingContainer
	{
		///<summary>TMap&lt;FName,FNodeMap&gt;</summary>
		public const int NodeMapping = 0x0028;

		///<summary>TAssetPtr&lt;UBlueprint&gt;</summary>
		public const int SourceAsset = 0x0078;

	}

	public class UObjectLibrary
	{
		///<summary>UClass *</summary>
		public const int ObjectBaseClass = 0x0028;

		///<summary>bool</summary>
		public const int bHasBlueprintClasses = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int Objects = 0x0038;

		///<summary>TArray&lt;TWeakObjectPtr&lt;UObject&gt;&gt;</summary>
		public const int WeakObjects = 0x0048;

		///<summary>bool</summary>
		public const int bUseWeakReferences = 0x0058;

		///<summary>bool</summary>
		public const int bIsFullyLoaded = 0x0059;

		///<summary>unsigned char[0x106]</summary>
		public const int UnknownData01 = 0x005A;

	}

	public class UObjectReferencer
	{
		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int ReferencedObjects = 0x0028;

	}

	public class UParticleEmitter
	{
		///<summary>FName</summary>
		public const int EmitterName = 0x0028;

		///<summary>int</summary>
		public const int SubUVDataOffset = 0x0030;

		///<summary>TEnumAsByte&lt;EEmitterRenderMode&gt;</summary>
		public const int EmitterRenderMode = 0x0034;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0035;

		///<summary>TArray&lt;UParticleLODLevel * &gt;</summary>
		public const int LODLevels = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int ConvertedModules = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0049;

		///<summary>int</summary>
		public const int PeakActiveParticles = 0x004C;

		///<summary>int</summary>
		public const int InitialAllocationCount = 0x0050;

		///<summary>float</summary>
		public const int MediumDetailSpawnRateScale = 0x0054;

		///<summary>float</summary>
		public const int QualityLevelSpawnRateScale = 0x0058;

		///<summary>TEnumAsByte&lt;EDetailMode&gt;</summary>
		public const int DetailMode = 0x005C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x005D;

		///<summary>unsigned char:1</summary>
		public const int bIsSoloing = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bCookedOut = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bDisabledLODsKeepEmitterAlive = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bDisableWhenInsignficant = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0061;

		///<summary>EParticleSignificanceLevel</summary>
		public const int SignificanceLevel = 0x0064;

		///<summary>unsigned char[0x10B]</summary>
		public const int UnknownData04 = 0x0065;

	}

	public class UParticleLODLevel
	{
		///<summary>int</summary>
		public const int Level = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x002D;

		///<summary>UParticleModuleRequired *</summary>
		public const int RequiredModule = 0x0030;

		///<summary>TArray&lt;UParticleModule * &gt;</summary>
		public const int Modules = 0x0038;

		///<summary>UParticleModuleTypeDataBase *</summary>
		public const int TypeDataModule = 0x0048;

		///<summary>UParticleModuleSpawn *</summary>
		public const int SpawnModule = 0x0050;

		///<summary>UParticleModuleEventGenerator *</summary>
		public const int EventGenerator = 0x0058;

		///<summary>TArray&lt;UParticleModuleSpawnBase * &gt;</summary>
		public const int SpawningModules = 0x0060;

		///<summary>TArray&lt;UParticleModule * &gt;</summary>
		public const int SpawnModules = 0x0070;

		///<summary>TArray&lt;UParticleModule * &gt;</summary>
		public const int UpdateModules = 0x0080;

		///<summary>TArray&lt;UParticleModuleOrbit * &gt;</summary>
		public const int OrbitModules = 0x0090;

		///<summary>TArray&lt;UParticleModuleEventReceiverBase * &gt;</summary>
		public const int EventReceiverModules = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int ConvertedModules = 0x00B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00B1;

		///<summary>int</summary>
		public const int PeakActiveParticles = 0x00B4;

	}

	public class UParticleModule
	{
		///<summary>unsigned char:1</summary>
		public const int bSpawnModule = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bUpdateModule = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bFinalUpdateModule = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bUpdateForGPUEmitter = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bCurvesAsColor = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int b3DDrawMode = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bSupported3DDrawMode = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bEnabled = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bEditable = 0x0029;

		///<summary>unsigned char:1</summary>
		public const int LODDuplicate = 0x0029;

		///<summary>unsigned char:1</summary>
		public const int bSupportsRandomSeed = 0x0029;

		///<summary>unsigned char:1</summary>
		public const int bRequiresLoopingNotification = 0x0029;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x002A;

		///<summary>unsigned char</summary>
		public const int LODValidity = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x002D;

	}

	public class UParticleModuleAccelerationBase
	{
		///<summary>unsigned char:1</summary>
		public const int bAlwaysInWorldSpace = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleAcceleration
	{
		///<summary>FRawDistributionVector</summary>
		public const int Acceleration = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bApplyOwnerScale = 0x0088;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0089;

	}

	public class UParticleModuleAccelerationConstant
	{
		///<summary>FVector</summary>
		public const int Acceleration = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0044;

	}

	public class UParticleModuleAccelerationDrag
	{
		///<summary>UDistributionFloat *</summary>
		public const int DragCoefficient = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int DragCoefficientRaw = 0x0040;

	}

	public class UParticleModuleAccelerationDragScaleOverLife
	{
		///<summary>UDistributionFloat *</summary>
		public const int DragScale = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int DragScaleRaw = 0x0040;

	}

	public class UParticleModuleAccelerationOverLifetime
	{
		///<summary>FRawDistributionVector</summary>
		public const int AccelOverLife = 0x0038;

	}

	public class UParticleModuleAttractorLine
	{
		///<summary>FVector</summary>
		public const int EndPoint0 = 0x0030;

		///<summary>FVector</summary>
		public const int EndPoint1 = 0x003C;

		///<summary>FRawDistributionFloat</summary>
		public const int Range = 0x0048;

		///<summary>FRawDistributionFloat</summary>
		public const int Strength = 0x0080;

	}

	public class UParticleModuleAttractorParticle
	{
		///<summary>FName</summary>
		public const int EmitterName = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int Range = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bStrengthByDistance = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0071;

		///<summary>FRawDistributionFloat</summary>
		public const int Strength = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int bAffectBaseVelocity = 0x00B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00B1;

		///<summary>TEnumAsByte&lt;EAttractorParticleSelectionMethod&gt;</summary>
		public const int SelectionMethod = 0x00B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00B5;

		///<summary>unsigned char:1</summary>
		public const int bRenewSource = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int bInheritSourceVel = 0x00B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x00B9;

		///<summary>int</summary>
		public const int LastSelIndex = 0x00BC;

	}

	public class UParticleModuleAttractorPoint
	{
		///<summary>FRawDistributionVector</summary>
		public const int Position = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int Range = 0x0080;

		///<summary>FRawDistributionFloat</summary>
		public const int Strength = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int StrengthByDistance = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bAffectBaseVelocity = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bOverrideVelocity = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bUseWorldSpacePosition = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int Positive_X = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int Positive_Y = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int Positive_Z = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int Negative_X = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int Negative_Y = 0x00F1;

		///<summary>unsigned char:1</summary>
		public const int Negative_Z = 0x00F1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x00F2;

	}

	public class UParticleModuleAttractorPointGravity
	{
		///<summary>FVector</summary>
		public const int Position = 0x0030;

		///<summary>float</summary>
		public const int Radius = 0x003C;

		///<summary>UDistributionFloat *</summary>
		public const int Strength = 0x0040;

		///<summary>FRawDistributionFloat</summary>
		public const int StrengthRaw = 0x0048;

	}

	public class UParticleModuleBeamModifier
	{
		///<summary>TEnumAsByte&lt;EBeamModifierType&gt;</summary>
		public const int ModifierType = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FBeamModifierOptions</summary>
		public const int PositionOptions = 0x0034;

		///<summary>FRawDistributionVector</summary>
		public const int Position = 0x0038;

		///<summary>FBeamModifierOptions</summary>
		public const int TangentOptions = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x008C;

		///<summary>FRawDistributionVector</summary>
		public const int Tangent = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bAbsoluteTangent = 0x00E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00E1;

		///<summary>FBeamModifierOptions</summary>
		public const int StrengthOptions = 0x00E4;

		///<summary>FRawDistributionFloat</summary>
		public const int Strength = 0x00E8;

	}

	public class UParticleModuleBeamNoise
	{
		///<summary>unsigned char:1</summary>
		public const int bLowFreq_Enabled = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>int</summary>
		public const int Frequency = 0x0034;

		///<summary>int</summary>
		public const int Frequency_LowRange = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x003C;

		///<summary>FRawDistributionVector</summary>
		public const int NoiseRange = 0x0040;

		///<summary>FRawDistributionFloat</summary>
		public const int NoiseRangeScale = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bNRScaleEmitterTime = 0x00C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x00C9;

		///<summary>FRawDistributionVector</summary>
		public const int NoiseSpeed = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bSmooth = 0x0120;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0121;

		///<summary>float</summary>
		public const int NoiseLockRadius = 0x0124;

		///<summary>unsigned char:1</summary>
		public const int bNoiseLock = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bOscillate = 0x0128;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0129;

		///<summary>float</summary>
		public const int NoiseLockTime = 0x012C;

		///<summary>float</summary>
		public const int NoiseTension = 0x0130;

		///<summary>unsigned char:1</summary>
		public const int bUseNoiseTangents = 0x0134;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0135;

		///<summary>FRawDistributionFloat</summary>
		public const int NoiseTangentStrength = 0x0138;

		///<summary>int</summary>
		public const int NoiseTessellation = 0x0170;

		///<summary>unsigned char:1</summary>
		public const int bTargetNoise = 0x0174;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0175;

		///<summary>float</summary>
		public const int FrequencyDistance = 0x0178;

		///<summary>unsigned char:1</summary>
		public const int bApplyNoiseScale = 0x017C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x017D;

		///<summary>FRawDistributionFloat</summary>
		public const int NoiseScale = 0x0180;

	}

	public class UParticleModuleBeamSource
	{
		///<summary>TEnumAsByte&lt;EBeam2SourceTargetMethod&gt;</summary>
		public const int SourceMethod = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FName</summary>
		public const int SourceName = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSourceAbsolute = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0041;

		///<summary>FRawDistributionVector</summary>
		public const int Source = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bLockSource = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0099;

		///<summary>TEnumAsByte&lt;EBeam2SourceTargetTangentMethod&gt;</summary>
		public const int SourceTangentMethod = 0x009C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x009D;

		///<summary>FRawDistributionVector</summary>
		public const int SourceTangent = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bLockSourceTangent = 0x00F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x00F1;

		///<summary>FRawDistributionFloat</summary>
		public const int SourceStrength = 0x00F8;

		///<summary>unsigned char:1</summary>
		public const int bLockSourceStength = 0x0130;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x0131;

	}

	public class UParticleModuleBeamTarget
	{
		///<summary>TEnumAsByte&lt;EBeam2SourceTargetMethod&gt;</summary>
		public const int TargetMethod = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FName</summary>
		public const int TargetName = 0x0038;

		///<summary>FRawDistributionVector</summary>
		public const int Target = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bTargetAbsolute = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bLockTarget = 0x0090;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0091;

		///<summary>TEnumAsByte&lt;EBeam2SourceTargetTangentMethod&gt;</summary>
		public const int TargetTangentMethod = 0x0094;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0095;

		///<summary>FRawDistributionVector</summary>
		public const int TargetTangent = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bLockTargetTangent = 0x00E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x00E9;

		///<summary>FRawDistributionFloat</summary>
		public const int TargetStrength = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bLockTargetStength = 0x0128;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0129;

		///<summary>float</summary>
		public const int LockRadius = 0x012C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x0130;

	}

	public class UParticleModuleCameraOffset
	{
		///<summary>FRawDistributionFloat</summary>
		public const int CameraOffset = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bSpawnTimeOnly = 0x0068;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0069;

		///<summary>TEnumAsByte&lt;EParticleCameraOffsetUpdateMethod&gt;</summary>
		public const int UpdateMethod = 0x006C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x006D;

	}

	public class UParticleModuleCollision
	{
		///<summary>FRawDistributionVector</summary>
		public const int DampingFactor = 0x0030;

		///<summary>FRawDistributionVector</summary>
		public const int DampingFactorRotation = 0x0080;

		///<summary>FRawDistributionFloat</summary>
		public const int MaxCollisions = 0x00D0;

		///<summary>TEnumAsByte&lt;EParticleCollisionComplete&gt;</summary>
		public const int CollisionCompletionOption = 0x0108;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0109;

		///<summary>TArray&lt;TEnumAsByte&lt;EObjectTypeQuery&gt;&gt;</summary>
		public const int CollisionTypes = 0x0110;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0120;

		///<summary>unsigned char:1</summary>
		public const int bApplyPhysics = 0x0128;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreTriggerVolumes = 0x0128;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0129;

		///<summary>FRawDistributionFloat</summary>
		public const int ParticleMass = 0x0130;

		///<summary>float</summary>
		public const int DirScalar = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bPawnsDoNotDecrementCount = 0x016C;

		///<summary>unsigned char:1</summary>
		public const int bOnlyVerticalNormalsDecrementCount = 0x016C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x016D;

		///<summary>float</summary>
		public const int VerticalFudgeFactor = 0x0170;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x0174;

		///<summary>FRawDistributionFloat</summary>
		public const int DelayAmount = 0x0178;

		///<summary>unsigned char:1</summary>
		public const int bDropDetail = 0x01B0;

		///<summary>unsigned char:1</summary>
		public const int bCollideOnlyIfVisible = 0x01B0;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreSourceActor = 0x01B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x01B1;

		///<summary>float</summary>
		public const int MaxCollisionDistance = 0x01B4;

	}

	public class UParticleModuleCollisionGPU
	{
		///<summary>FRawDistributionFloat</summary>
		public const int Resilience = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int ResilienceScaleOverLife = 0x0068;

		///<summary>float</summary>
		public const int Friction = 0x00A0;

		///<summary>float</summary>
		public const int RandomSpread = 0x00A4;

		///<summary>float</summary>
		public const int RandomDistribution = 0x00A8;

		///<summary>float</summary>
		public const int RadiusScale = 0x00AC;

		///<summary>float</summary>
		public const int RadiusBias = 0x00B0;

		///<summary>TEnumAsByte&lt;EParticleCollisionResponse&gt;</summary>
		public const int Response = 0x00B4;

		///<summary>TEnumAsByte&lt;EParticleCollisionMode&gt;</summary>
		public const int CollisionMode = 0x00B5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x00B6;

	}

	public class UParticleModuleColor
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartColor = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int StartAlpha = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bClampAlpha = 0x00B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UParticleModuleColor_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x00C0;

	}

	public class UParticleModuleColorOverLife
	{
		///<summary>FRawDistributionVector</summary>
		public const int ColorOverLife = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int AlphaOverLife = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bClampAlpha = 0x00B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UParticleModuleColorScaleOverLife
	{
		///<summary>FRawDistributionVector</summary>
		public const int ColorScaleOverLife = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int AlphaScaleOverLife = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bEmitterTime = 0x00B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UParticleModuleEventGenerator
	{
		///<summary>TArray&lt;FParticleEvent_GenerateInfo&gt;</summary>
		public const int Events = 0x0030;

	}

	public class UParticleModuleEventReceiverBase
	{
		///<summary>TEnumAsByte&lt;EParticleEventType&gt;</summary>
		public const int EventGeneratorType = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FName</summary>
		public const int EventName = 0x0038;

	}

	public class UParticleModuleEventReceiverKillParticles
	{
		///<summary>unsigned char:1</summary>
		public const int bStopSpawning = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UParticleModuleEventReceiverSpawn
	{
		///<summary>FRawDistributionFloat</summary>
		public const int SpawnCount = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bUseParticleTime = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int bUsePSysLocation = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int bInheritVelocity = 0x0078;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0079;

		///<summary>FRawDistributionVector</summary>
		public const int InheritVelocityScale = 0x0080;

		///<summary>TArray&lt;UPhysicalMaterial * &gt;</summary>
		public const int PhysicalMaterials = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bBanPhysicalMaterials = 0x00E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00E1;

	}

	public class UParticleModuleKillBox
	{
		///<summary>FRawDistributionVector</summary>
		public const int LowerLeftCorner = 0x0030;

		///<summary>FRawDistributionVector</summary>
		public const int UpperRightCorner = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bAbsolute = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bKillInside = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bAxisAlignedAndFixedSize = 0x00D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00D1;

	}

	public class UParticleModuleKillHeight
	{
		///<summary>FRawDistributionFloat</summary>
		public const int Height = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bAbsolute = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bFloor = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bApplyPSysScale = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UParticleModuleLifetime
	{
		///<summary>FRawDistributionFloat</summary>
		public const int LifeTime = 0x0030;

	}

	public class UParticleModuleLifetime_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0068;

	}

	public class UParticleModuleLight
	{
		///<summary>bool</summary>
		public const int bUseInverseSquaredFalloff = 0x0030;

		///<summary>bool</summary>
		public const int bAffectsTranslucency = 0x0031;

		///<summary>bool</summary>
		public const int bPreviewLightRadius = 0x0032;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0033;

		///<summary>float</summary>
		public const int SpawnFraction = 0x0034;

		///<summary>FRawDistributionVector</summary>
		public const int ColorScaleOverLife = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int BrightnessOverLife = 0x0088;

		///<summary>FRawDistributionFloat</summary>
		public const int RadiusScale = 0x00C0;

		///<summary>FRawDistributionFloat</summary>
		public const int LightExponent = 0x00F8;

		///<summary>FLightingChannels</summary>
		public const int LightingChannels = 0x0130;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x0133;

		///<summary>float</summary>
		public const int VolumetricScatteringIntensity = 0x0134;

		///<summary>bool</summary>
		public const int bHighQualityLights = 0x0138;

		///<summary>bool</summary>
		public const int bShadowCastingLights = 0x0139;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x013A;

	}

	public class UParticleModuleLight_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0140;

	}

	public class UParticleModuleLocation
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartLocation = 0x0030;

		///<summary>float</summary>
		public const int DistributeOverNPoints = 0x0080;

		///<summary>float</summary>
		public const int DistributeThreshold = 0x0084;

	}

	public class UParticleModuleLocation_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0088;

	}

	public class UParticleModuleLocationWorldOffset_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0088;

	}

	public class UParticleModuleLocationBoneSocket
	{
		///<summary>TEnumAsByte&lt;ELocationBoneSocketSource&gt;</summary>
		public const int SourceType = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FVector</summary>
		public const int UniversalOffset = 0x0034;

		///<summary>TArray&lt;FLocationBoneSocketInfo&gt;</summary>
		public const int SourceLocations = 0x0040;

		///<summary>TEnumAsByte&lt;ELocationBoneSocketSelectionMethod&gt;</summary>
		public const int SelectionMethod = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0051;

		///<summary>unsigned char:1</summary>
		public const int bUpdatePositionEachFrame = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bOrientMeshEmitters = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bInheritBoneVelocity = 0x0054;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0055;

		///<summary>float</summary>
		public const int InheritVelocityScale = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x005C;

		///<summary>FName</summary>
		public const int SkelMeshActorParamName = 0x0060;

		///<summary>int</summary>
		public const int NumPreSelectedIndices = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x006C;

	}

	public class UParticleModuleLocationDirect
	{
		///<summary>FRawDistributionVector</summary>
		public const int Location = 0x0030;

		///<summary>FRawDistributionVector</summary>
		public const int LocationOffset = 0x0080;

		///<summary>FRawDistributionVector</summary>
		public const int ScaleFactor = 0x00D0;

		///<summary>FRawDistributionVector</summary>
		public const int Direction = 0x0120;

	}

	public class UParticleModuleLocationEmitter
	{
		///<summary>FName</summary>
		public const int EmitterName = 0x0030;

		///<summary>TEnumAsByte&lt;ELocationEmitterSelectionMethod&gt;</summary>
		public const int SelectionMethod = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>unsigned char:1</summary>
		public const int InheritSourceVelocity = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x003D;

		///<summary>float</summary>
		public const int InheritSourceVelocityScale = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bInheritSourceRotation = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0045;

		///<summary>float</summary>
		public const int InheritSourceRotationScale = 0x0048;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x004C;

	}

	public class UParticleModuleLocationEmitterDirect
	{
		///<summary>FName</summary>
		public const int EmitterName = 0x0030;

	}

	public class UParticleModuleLocationPrimitiveBase
	{
		///<summary>unsigned char:1</summary>
		public const int Positive_X = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Positive_Y = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Positive_Z = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Negative_X = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Negative_Y = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Negative_Z = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int SurfaceOnly = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Velocity = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FRawDistributionFloat</summary>
		public const int VelocityScale = 0x0038;

		///<summary>FRawDistributionVector</summary>
		public const int StartLocation = 0x0070;

	}

	public class UParticleModuleLocationPrimitiveCylinder
	{
		///<summary>unsigned char:1</summary>
		public const int RadialVelocity = 0x00C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00C1;

		///<summary>FRawDistributionFloat</summary>
		public const int StartRadius = 0x00C8;

		///<summary>FRawDistributionFloat</summary>
		public const int StartHeight = 0x0100;

		///<summary>TEnumAsByte&lt;ECylinderHeightAxis&gt;</summary>
		public const int HeightAxis = 0x0138;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0139;

	}

	public class UParticleModuleLocationPrimitiveCylinder_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0140;

	}

	public class UParticleModuleLocationPrimitiveSphere
	{
		///<summary>FRawDistributionFloat</summary>
		public const int StartRadius = 0x00C0;

	}

	public class UParticleModuleLocationPrimitiveSphere_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x00F8;

	}

	public class UParticleModuleLocationPrimitiveTriangle
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartOffset = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int Height = 0x0080;

		///<summary>FRawDistributionFloat</summary>
		public const int Angle = 0x00B8;

		///<summary>FRawDistributionFloat</summary>
		public const int Thickness = 0x00F0;

	}

	public class UParticleModuleLocationSkelVertSurface
	{
		///<summary>TEnumAsByte&lt;ELocationSkelVertSurfaceSource&gt;</summary>
		public const int SourceType = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FVector</summary>
		public const int UniversalOffset = 0x0034;

		///<summary>unsigned char:1</summary>
		public const int bUpdatePositionEachFrame = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bOrientMeshEmitters = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bInheritBoneVelocity = 0x0040;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0041;

		///<summary>float</summary>
		public const int InheritVelocityScale = 0x0044;

		///<summary>FName</summary>
		public const int SkelMeshActorParamName = 0x0048;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int ValidAssociatedBones = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bEnforceNormalCheck = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0061;

		///<summary>FVector</summary>
		public const int NormalToCompare = 0x0064;

		///<summary>float</summary>
		public const int NormalCheckToleranceDegrees = 0x0070;

		///<summary>float</summary>
		public const int NormalCheckTolerance = 0x0074;

		///<summary>TArray&lt;int&gt;</summary>
		public const int ValidMaterialIndices = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int bInheritVertexColor = 0x0088;

		///<summary>unsigned char:1</summary>
		public const int bInheritUV = 0x0088;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0089;

		///<summary>uint32_t</summary>
		public const int InheritUVChannel = 0x008C;

	}

	public class UParticleModulePivotOffset
	{
		///<summary>FVector2D</summary>
		public const int PivotOffset = 0x0030;

	}

	public class UParticleModuleSourceMovement
	{
		///<summary>FRawDistributionVector</summary>
		public const int SourceMovementScale = 0x0030;

	}

	public class UParticleModuleMeshMaterial
	{
		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int MeshMaterials = 0x0030;

	}

	public class UParticleModuleOrbitBase
	{
		///<summary>unsigned char:1</summary>
		public const int bUseEmitterTime = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleOrbit
	{
		///<summary>TEnumAsByte&lt;EOrbitChainMode&gt;</summary>
		public const int ChainMode = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>FRawDistributionVector</summary>
		public const int OffsetAmount = 0x0040;

		///<summary>FOrbitOptions</summary>
		public const int OffsetOptions = 0x0090;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0094;

		///<summary>FRawDistributionVector</summary>
		public const int RotationAmount = 0x0098;

		///<summary>FOrbitOptions</summary>
		public const int RotationOptions = 0x00E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00EC;

		///<summary>FRawDistributionVector</summary>
		public const int RotationRateAmount = 0x00F0;

		///<summary>FOrbitOptions</summary>
		public const int RotationRateOptions = 0x0140;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0144;

	}

	public class UParticleModuleOrientationAxisLock
	{
		///<summary>TEnumAsByte&lt;EParticleAxisLock&gt;</summary>
		public const int LockAxisFlags = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleParameterDynamic
	{
		///<summary>TArray&lt;FEmitterDynamicParameter&gt;</summary>
		public const int DynamicParams = 0x0030;

		///<summary>int</summary>
		public const int UpdateFlags = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bUsesVelocity = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0045;

	}

	public class UParticleModuleParameterDynamic_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0048;

	}

	public class USubUVAnimation
	{
		///<summary>UTexture2D *</summary>
		public const int SubUVTexture = 0x0028;

		///<summary>int</summary>
		public const int SubImages_Horizontal = 0x0030;

		///<summary>int</summary>
		public const int SubImages_Vertical = 0x0034;

		///<summary>TEnumAsByte&lt;ESubUVBoundingVertexCount&gt;</summary>
		public const int BoundingMode = 0x0038;

		///<summary>TEnumAsByte&lt;EOpacitySourceMode&gt;</summary>
		public const int OpacitySourceMode = 0x0039;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x003A;

		///<summary>float</summary>
		public const int AlphaThreshold = 0x003C;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UParticleModuleRequired
	{
		///<summary>UMaterialInterface *</summary>
		public const int Material = 0x0030;

		///<summary>FVector</summary>
		public const int EmitterOrigin = 0x0038;

		///<summary>FRotator</summary>
		public const int EmitterRotation = 0x0044;

		///<summary>TEnumAsByte&lt;EParticleScreenAlignment&gt;</summary>
		public const int ScreenAlignment = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>float</summary>
		public const int MinFacingCameraBlendDistance = 0x0054;

		///<summary>float</summary>
		public const int MaxFacingCameraBlendDistance = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int bUseLocalSpace = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bKillOnDeactivate = 0x005C;

		///<summary>unsigned char:1</summary>
		public const int bKillOnCompleted = 0x005C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x005D;

		///<summary>TEnumAsByte&lt;EParticleSortMode&gt;</summary>
		public const int SortMode = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0061;

		///<summary>unsigned char:1</summary>
		public const int bUseLegacyEmitterTime = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bRemoveHMDRoll = 0x0064;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0065;

		///<summary>float</summary>
		public const int EmitterDuration = 0x0068;

		///<summary>float</summary>
		public const int EmitterDurationLow = 0x006C;

		///<summary>unsigned char:1</summary>
		public const int bEmitterDurationUseRange = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bDurationRecalcEachLoop = 0x0070;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0071;

		///<summary>int</summary>
		public const int EmitterLoops = 0x0074;

		///<summary>FRawDistributionFloat</summary>
		public const int SpawnRate = 0x0078;

		///<summary>TEnumAsByte&lt;EParticleBurstMethod&gt;</summary>
		public const int ParticleBurstMethod = 0x00B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x00B1;

		///<summary>TArray&lt;FParticleBurst&gt;</summary>
		public const int BurstList = 0x00B8;

		///<summary>float</summary>
		public const int EmitterDelay = 0x00C8;

		///<summary>float</summary>
		public const int EmitterDelayLow = 0x00CC;

		///<summary>unsigned char:1</summary>
		public const int bEmitterDelayUseRange = 0x00D0;

		///<summary>unsigned char:1</summary>
		public const int bDelayFirstLoopOnly = 0x00D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x00D1;

		///<summary>TEnumAsByte&lt;EParticleSubUVInterpMethod&gt;</summary>
		public const int InterpolationMethod = 0x00D4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x00D5;

		///<summary>int</summary>
		public const int SubImages_Horizontal = 0x00D8;

		///<summary>int</summary>
		public const int SubImages_Vertical = 0x00DC;

		///<summary>unsigned char:1</summary>
		public const int bScaleUV = 0x00E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x00E1;

		///<summary>float</summary>
		public const int RandomImageTime = 0x00E4;

		///<summary>int</summary>
		public const int RandomImageChanges = 0x00E8;

		///<summary>unsigned char:1</summary>
		public const int bOverrideSystemMacroUV = 0x00EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x00ED;

		///<summary>FVector</summary>
		public const int MacroUVPosition = 0x00F0;

		///<summary>float</summary>
		public const int MacroUVRadius = 0x00FC;

		///<summary>unsigned char:1</summary>
		public const int bUseMaxDrawCount = 0x0100;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData10 = 0x0101;

		///<summary>int</summary>
		public const int MaxDrawCount = 0x0104;

		///<summary>EParticleUVFlipMode</summary>
		public const int UVFlippingMode = 0x0108;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData11 = 0x0109;

		///<summary>UTexture2D *</summary>
		public const int CutoutTexture = 0x0110;

		///<summary>TEnumAsByte&lt;ESubUVBoundingVertexCount&gt;</summary>
		public const int BoundingMode = 0x0118;

		///<summary>TEnumAsByte&lt;EOpacitySourceMode&gt;</summary>
		public const int OpacitySourceMode = 0x0119;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData12 = 0x011A;

		///<summary>float</summary>
		public const int AlphaThreshold = 0x011C;

		///<summary>TEnumAsByte&lt;EEmitterNormalsMode&gt;</summary>
		public const int EmitterNormalsMode = 0x0120;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData13 = 0x0121;

		///<summary>FVector</summary>
		public const int NormalsSphereCenter = 0x0124;

		///<summary>FVector</summary>
		public const int NormalsCylinderDirection = 0x0130;

		///<summary>unsigned char:1</summary>
		public const int bOrbitModuleAffectsVelocityAlignment = 0x013C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData14 = 0x013D;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int NamedMaterialOverrides = 0x0140;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData15 = 0x0150;

	}

	public class UParticleModuleMeshRotation
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartRotation = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bInheritParent = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleMeshRotation_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0088;

	}

	public class UParticleModuleRotation
	{
		///<summary>FRawDistributionFloat</summary>
		public const int StartRotation = 0x0030;

	}

	public class UParticleModuleRotation_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0068;

	}

	public class UParticleModuleRotationOverLifetime
	{
		///<summary>FRawDistributionFloat</summary>
		public const int RotationOverLife = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int Scale = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UParticleModuleMeshRotationRate
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartRotationRate = 0x0030;

	}

	public class UParticleModuleMeshRotationRate_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0080;

	}

	public class UParticleModuleMeshRotationRateMultiplyLife
	{
		///<summary>FRawDistributionVector</summary>
		public const int LifeMultiplier = 0x0030;

	}

	public class UParticleModuleMeshRotationRateOverLife
	{
		///<summary>FRawDistributionVector</summary>
		public const int RotRate = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bScaleRotRate = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleRotationRate
	{
		///<summary>FRawDistributionFloat</summary>
		public const int StartRotationRate = 0x0030;

	}

	public class UParticleModuleRotationRate_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0068;

	}

	public class UParticleModuleRotationRateMultiplyLife
	{
		///<summary>FRawDistributionFloat</summary>
		public const int LifeMultiplier = 0x0030;

	}

	public class UParticleModuleSize
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartSize = 0x0030;

	}

	public class UParticleModuleSize_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x0080;

	}

	public class UParticleModuleSizeMultiplyLife
	{
		///<summary>FRawDistributionVector</summary>
		public const int LifeMultiplier = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int MultiplyX = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int MultiplyY = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int MultiplyZ = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleSizeScale
	{
		///<summary>FRawDistributionVector</summary>
		public const int SizeScale = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int EnableX = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int EnableY = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int EnableZ = 0x0080;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleSizeScaleBySpeed
	{
		///<summary>FVector2D</summary>
		public const int SpeedScale = 0x0030;

		///<summary>FVector2D</summary>
		public const int MaxScale = 0x0038;

	}

	public class UParticleModuleSpawnBase
	{
		///<summary>unsigned char:1</summary>
		public const int bProcessSpawnRate = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bProcessBurstList = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleSpawn
	{
		///<summary>FRawDistributionFloat</summary>
		public const int Rate = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int RateScale = 0x0070;

		///<summary>TEnumAsByte&lt;EParticleBurstMethod&gt;</summary>
		public const int ParticleBurstMethod = 0x00A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A9;

		///<summary>TArray&lt;FParticleBurst&gt;</summary>
		public const int BurstList = 0x00B0;

		///<summary>FRawDistributionFloat</summary>
		public const int BurstScale = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bApplyGlobalSpawnRateScale = 0x00F8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00F9;

	}

	public class UParticleModuleSpawnPerUnit
	{
		///<summary>float</summary>
		public const int UnitScalar = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

		///<summary>FRawDistributionFloat</summary>
		public const int SpawnPerUnit = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreSpawnRateWhenMoving = 0x0078;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0079;

		///<summary>float</summary>
		public const int MovementTolerance = 0x007C;

		///<summary>float</summary>
		public const int MaxFrameDistance = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreMovementAlongX = 0x0084;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreMovementAlongY = 0x0084;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreMovementAlongZ = 0x0084;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0085;

	}

	public class UParticleModuleSubUV
	{
		///<summary>USubUVAnimation *</summary>
		public const int Animation = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int SubImageIndex = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bUseRealTime = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0071;

	}

	public class UParticleModuleSubUVMovie
	{
		///<summary>unsigned char:1</summary>
		public const int bUseEmitterTime = 0x0078;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0079;

		///<summary>FRawDistributionFloat</summary>
		public const int FrameRate = 0x0080;

		///<summary>int</summary>
		public const int StartingFrame = 0x00B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x00BC;

	}

	public class UParticleModuleTrailSource
	{
		///<summary>TEnumAsByte&lt;ETrail2SourceMethod&gt;</summary>
		public const int SourceMethod = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>FName</summary>
		public const int SourceName = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int SourceStrength = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bLockSourceStength = 0x0078;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0079;

		///<summary>int</summary>
		public const int SourceOffsetCount = 0x007C;

		///<summary>TArray&lt;FVector&gt;</summary>
		public const int SourceOffsetDefaults = 0x0080;

		///<summary>TEnumAsByte&lt;EParticleSourceSelectionMethod&gt;</summary>
		public const int SelectionMethod = 0x0090;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0091;

		///<summary>unsigned char:1</summary>
		public const int bInheritRotation = 0x0094;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0095;

	}

	public class UParticleModuleTypeDataAnimTrail
	{
		///<summary>unsigned char:1</summary>
		public const int bDeadTrailsOnDeactivate = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bEnablePreviousTangentRecalculation = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bTangentRecalculationEveryFrame = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>float</summary>
		public const int TilingDistance = 0x0034;

		///<summary>float</summary>
		public const int DistanceTessellationStepSize = 0x0038;

		///<summary>float</summary>
		public const int TangentTessellationStepSize = 0x003C;

		///<summary>float</summary>
		public const int WidthTessellationStepSize = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UParticleModuleTypeDataBeam2
	{
		///<summary>TEnumAsByte&lt;EBeam2Method&gt;</summary>
		public const int BeamMethod = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>int</summary>
		public const int TextureTile = 0x0034;

		///<summary>float</summary>
		public const int TextureTileDistance = 0x0038;

		///<summary>int</summary>
		public const int Sheets = 0x003C;

		///<summary>int</summary>
		public const int MaxBeamCount = 0x0040;

		///<summary>float</summary>
		public const int Speed = 0x0044;

		///<summary>int</summary>
		public const int InterpolationPoints = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysOn = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x004D;

		///<summary>int</summary>
		public const int UpVectorStepSize = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0054;

		///<summary>FName</summary>
		public const int BranchParentName = 0x0058;

		///<summary>FRawDistributionFloat</summary>
		public const int Distance = 0x0060;

		///<summary>TEnumAsByte&lt;EBeamTaperMethod&gt;</summary>
		public const int TaperMethod = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0099;

		///<summary>FRawDistributionFloat</summary>
		public const int TaperFactor = 0x00A0;

		///<summary>FRawDistributionFloat</summary>
		public const int TaperScale = 0x00D8;

		///<summary>unsigned char:1</summary>
		public const int RenderGeometry = 0x0110;

		///<summary>unsigned char:1</summary>
		public const int RenderDirectLine = 0x0110;

		///<summary>unsigned char:1</summary>
		public const int RenderLines = 0x0110;

		///<summary>unsigned char:1</summary>
		public const int RenderTessellation = 0x0110;

		///<summary>unsigned char[0x57]</summary>
		public const int UnknownData04 = 0x0111;

	}

	public class UParticleModuleTypeDataGpu
	{
		///<summary>FGPUSpriteEmitterInfo</summary>
		public const int EmitterInfo = 0x0030;

		///<summary>FGPUSpriteResourceData</summary>
		public const int ResourceData = 0x02F0;

		///<summary>float</summary>
		public const int CameraMotionBlurAmount = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bClearExistingParticlesOnInit = 0x0454;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData00 = 0x0455;

	}

	public class UParticleModuleTypeDataMesh
	{
		///<summary>UStaticMesh *</summary>
		public const int Mesh = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int CastShadows = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int DoCollisions = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>TEnumAsByte&lt;EMeshScreenAlignment&gt;</summary>
		public const int MeshAlignment = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x003D;

		///<summary>unsigned char:1</summary>
		public const int bOverrideMaterial = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bOverrideDefaultMotionBlurSettings = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bEnableMotionBlur = 0x0040;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0041;

		///<summary>float</summary>
		public const int Pitch = 0x0044;

		///<summary>float</summary>
		public const int Roll = 0x0048;

		///<summary>float</summary>
		public const int Yaw = 0x004C;

		///<summary>FRawDistributionVector</summary>
		public const int RollPitchYawRange = 0x0050;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x00A0;

		///<summary>TEnumAsByte&lt;EParticleAxisLock&gt;</summary>
		public const int AxisLockOption = 0x00A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x00A9;

		///<summary>unsigned char:1</summary>
		public const int bCameraFacing = 0x00AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x00AD;

		///<summary>TEnumAsByte&lt;EMeshCameraFacingUpAxis&gt;</summary>
		public const int CameraFacingUpAxisOption = 0x00B0;

		///<summary>TEnumAsByte&lt;EMeshCameraFacingOptions&gt;</summary>
		public const int CameraFacingOption = 0x00B1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData06 = 0x00B2;

		///<summary>unsigned char:1</summary>
		public const int bApplyParticleRotationAsSpin = 0x00B4;

		///<summary>unsigned char:1</summary>
		public const int bFaceCameraDirectionRatherThanPosition = 0x00B4;

		///<summary>unsigned char:1</summary>
		public const int bCollisionsConsiderPartilceSize = 0x00B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x00B5;

	}

	public class UParticleModuleTypeDataRibbon
	{
		///<summary>int</summary>
		public const int MaxTessellationBetweenParticles = 0x0030;

		///<summary>int</summary>
		public const int SheetsPerTrail = 0x0034;

		///<summary>int</summary>
		public const int MaxTrailCount = 0x0038;

		///<summary>int</summary>
		public const int MaxParticleInTrailCount = 0x003C;

		///<summary>unsigned char:1</summary>
		public const int bDeadTrailsOnDeactivate = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bDeadTrailsOnSourceLoss = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bClipSourceSegement = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bEnablePreviousTangentRecalculation = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bTangentRecalculationEveryFrame = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bSpawnInitialParticle = 0x0040;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0041;

		///<summary>TEnumAsByte&lt;ETrailsRenderAxisOption&gt;</summary>
		public const int RenderAxis = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0045;

		///<summary>float</summary>
		public const int TangentSpawningScalar = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bRenderGeometry = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bRenderSpawnPoints = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bRenderTangents = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bRenderTessellation = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x004D;

		///<summary>float</summary>
		public const int TilingDistance = 0x0050;

		///<summary>float</summary>
		public const int DistanceTessellationStepSize = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bEnableTangentDiffInterpScale = 0x0058;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0059;

		///<summary>float</summary>
		public const int TangentTessellationScalar = 0x005C;

	}

	public class UParticleModuleVectorFieldGlobal
	{
		///<summary>unsigned char:1</summary>
		public const int bOverrideGlobalVectorFieldTightness = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>float</summary>
		public const int GlobalVectorFieldScale = 0x0034;

		///<summary>float</summary>
		public const int GlobalVectorFieldTightness = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x003C;

	}

	public class UParticleModuleVectorFieldLocal
	{
		///<summary>UVectorField *</summary>
		public const int VectorField = 0x0030;

		///<summary>FVector</summary>
		public const int RelativeTranslation = 0x0038;

		///<summary>FRotator</summary>
		public const int RelativeRotation = 0x0044;

		///<summary>FVector</summary>
		public const int RelativeScale3D = 0x0050;

		///<summary>float</summary>
		public const int Intensity = 0x005C;

		///<summary>float</summary>
		public const int Tightness = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreComponentTransform = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bTileX = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bTileY = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bTileZ = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bUseFixDT = 0x0064;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0065;

	}

	public class UParticleModuleVectorFieldRotation
	{
		///<summary>FVector</summary>
		public const int MinInitialRotation = 0x0030;

		///<summary>FVector</summary>
		public const int MaxInitialRotation = 0x003C;

	}

	public class UParticleModuleVectorFieldRotationRate
	{
		///<summary>FVector</summary>
		public const int RotationRate = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UParticleModuleVectorFieldScale
	{
		///<summary>UDistributionFloat *</summary>
		public const int VectorFieldScale = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int VectorFieldScaleRaw = 0x0038;

	}

	public class UParticleModuleVectorFieldScaleOverLife
	{
		///<summary>UDistributionFloat *</summary>
		public const int VectorFieldScaleOverLife = 0x0030;

		///<summary>FRawDistributionFloat</summary>
		public const int VectorFieldScaleOverLifeRaw = 0x0038;

	}

	public class UParticleModuleVelocityBase
	{
		///<summary>unsigned char:1</summary>
		public const int bInWorldSpace = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bApplyOwnerScale = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleVelocity
	{
		///<summary>FRawDistributionVector</summary>
		public const int StartVelocity = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int StartVelocityRadial = 0x0088;

	}

	public class UParticleModuleVelocity_Seeded
	{
		///<summary>FParticleRandomSeedInfo</summary>
		public const int RandomSeedInfo = 0x00C0;

	}

	public class UParticleModuleVelocityCone
	{
		///<summary>FRawDistributionFloat</summary>
		public const int Angle = 0x0038;

		///<summary>FRawDistributionFloat</summary>
		public const int Velocity = 0x0070;

		///<summary>FVector</summary>
		public const int Direction = 0x00A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00B4;

	}

	public class UParticleModuleVelocityInheritParent
	{
		///<summary>FRawDistributionVector</summary>
		public const int Scale = 0x0038;

	}

	public class UParticleModuleVelocityOverLifetime
	{
		///<summary>FRawDistributionVector</summary>
		public const int VelOverLife = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int Absolute = 0x0088;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0089;

	}

	public class UParticleSystemReplay
	{
		///<summary>int</summary>
		public const int ClipIDNumber = 0x0028;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UPhysicalMaterial
	{
		///<summary>float</summary>
		public const int Friction = 0x0028;

		///<summary>TEnumAsByte&lt;EFrictionCombineMode&gt;</summary>
		public const int FrictionCombineMode = 0x002C;

		///<summary>bool</summary>
		public const int bOverrideFrictionCombineMode = 0x002D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x002E;

		///<summary>float</summary>
		public const int Restitution = 0x0030;

		///<summary>TEnumAsByte&lt;EFrictionCombineMode&gt;</summary>
		public const int RestitutionCombineMode = 0x0034;

		///<summary>bool</summary>
		public const int bOverrideRestitutionCombineMode = 0x0035;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0036;

		///<summary>float</summary>
		public const int Density = 0x0038;

		///<summary>float</summary>
		public const int RaiseMassToPower = 0x003C;

		///<summary>float</summary>
		public const int DestructibleDamageThresholdScale = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0044;

		///<summary>UPhysicalMaterialPropertyBase *</summary>
		public const int PhysicalMaterialProperty = 0x0048;

		///<summary>TEnumAsByte&lt;EPhysicalSurface&gt;</summary>
		public const int SurfaceType = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0051;

		///<summary>float</summary>
		public const int TireFrictionScale = 0x0054;

		///<summary>TArray&lt;FTireFrictionScalePair&gt;</summary>
		public const int TireFrictionScales = 0x0058;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData04 = 0x0068;

	}

	public class UPhysicsCollisionHandler
	{
		///<summary>float</summary>
		public const int ImpactThreshold = 0x0028;

		///<summary>float</summary>
		public const int ImpactReFireDelay = 0x002C;

		///<summary>USoundBase *</summary>
		public const int DefaultImpactSound = 0x0030;

		///<summary>float</summary>
		public const int LastImpactSoundTime = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UPhysicsConstraintTemplate
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FConstraintInstance</summary>
		public const int DefaultInstance = 0x0030;

		///<summary>TArray&lt;FPhysicsConstraintProfileHandle&gt;</summary>
		public const int ProfileHandles = 0x0220;

		///<summary>FConstraintProfileProperties</summary>
		public const int DefaultProfile = 0x0230;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0334;

	}

	public class UPhysicsSerializer
	{
		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UPlatformInterfaceBase
	{
		///<summary>TArray&lt;FDelegateArray&gt;</summary>
		public const int AllDelegates = 0x0028;

	}

	public class UCloudStorageBase
	{
		///<summary>TArray&lt;FString&gt;</summary>
		public const int LocalCloudFiles = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bSuppressDelegateCalls = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UInGameAdManager
	{
		///<summary>unsigned char:1</summary>
		public const int bShouldPauseWhileAdOpen = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>TArray&lt;FScriptDelegate&gt;</summary>
		public const int ClickedBannerDelegates = 0x0040;

		///<summary>TArray&lt;FScriptDelegate&gt;</summary>
		public const int ClosedAdDelegates = 0x0050;

	}

	public class UMicroTransactionBase
	{
		///<summary>TArray&lt;FPurchaseInfo&gt;</summary>
		public const int AvailableProducts = 0x0038;

		///<summary>FString</summary>
		public const int LastError = 0x0048;

		///<summary>FString</summary>
		public const int LastErrorSolution = 0x0058;

	}

	public class UPlatformInterfaceWebResponse
	{
		///<summary>FString</summary>
		public const int OriginalURL = 0x0028;

		///<summary>int</summary>
		public const int ResponseCode = 0x0038;

		///<summary>int</summary>
		public const int Tag = 0x003C;

		///<summary>FString</summary>
		public const int StringResponse = 0x0040;

		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int BinaryResponse = 0x0050;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0060;

	}

	public class UChildConnection
	{
	}

	public class UPolys
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UReporterBase
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UReporterGraph
	{
		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UReverbEffect
	{
		///<summary>float</summary>
		public const int Density = 0x0028;

		///<summary>float</summary>
		public const int Diffusion = 0x002C;

		///<summary>float</summary>
		public const int Gain = 0x0030;

		///<summary>float</summary>
		public const int GainHF = 0x0034;

		///<summary>float</summary>
		public const int DecayTime = 0x0038;

		///<summary>float</summary>
		public const int DecayHFRatio = 0x003C;

		///<summary>float</summary>
		public const int ReflectionsGain = 0x0040;

		///<summary>float</summary>
		public const int ReflectionsDelay = 0x0044;

		///<summary>float</summary>
		public const int LateGain = 0x0048;

		///<summary>float</summary>
		public const int LateDelay = 0x004C;

		///<summary>float</summary>
		public const int AirAbsorptionGainHF = 0x0050;

		///<summary>float</summary>
		public const int RoomRolloffFactor = 0x0054;

	}

	public class URig
	{
		///<summary>TArray&lt;FTransformBase&gt;</summary>
		public const int TransformBases = 0x0028;

		///<summary>TArray&lt;FNode&gt;</summary>
		public const int Nodes = 0x0038;

	}

	public class USimpleConstructionScript
	{
		///<summary>TArray&lt;USCS_Node * &gt;</summary>
		public const int RootNodes = 0x0028;

		///<summary>TArray&lt;USCS_Node * &gt;</summary>
		public const int AllNodes = 0x0038;

		///<summary>USCS_Node *</summary>
		public const int DefaultSceneRootNode = 0x0048;

		///<summary>USCS_Node *</summary>
		public const int RootNode = 0x0050;

		///<summary>TArray&lt;USCS_Node * &gt;</summary>
		public const int ActorComponentNodes = 0x0058;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0068;

	}

	public class USCS_Node
	{
		///<summary>UClass *</summary>
		public const int ComponentClass = 0x0028;

		///<summary>UActorComponent *</summary>
		public const int ComponentTemplate = 0x0030;

		///<summary>FBlueprintCookedComponentInstancingData</summary>
		public const int CookedComponentInstancingData = 0x0038;

		///<summary>FName</summary>
		public const int VariableName = 0x0088;

		///<summary>FName</summary>
		public const int AttachToName = 0x0090;

		///<summary>FName</summary>
		public const int ParentComponentOrVariableName = 0x0098;

		///<summary>FName</summary>
		public const int ParentComponentOwnerClassName = 0x00A0;

		///<summary>bool</summary>
		public const int bIsParentComponentNative = 0x00A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A9;

		///<summary>TArray&lt;USCS_Node * &gt;</summary>
		public const int ChildNodes = 0x00B0;

		///<summary>USCS_Node *</summary>
		public const int LODParentNode = 0x00C0;

		///<summary>TArray&lt;FBPVariableMetaDataEntry&gt;</summary>
		public const int MetaDataArray = 0x00C8;

		///<summary>FGuid</summary>
		public const int VariableGuid = 0x00D8;

		///<summary>bool</summary>
		public const int bIsFalseRoot = 0x00E8;

		///<summary>bool</summary>
		public const int bIsNative = 0x00E9;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x00EA;

		///<summary>FName</summary>
		public const int NativeComponentName = 0x00F0;

		///<summary>bool</summary>
		public const int bVariableNameAutoGenerated = 0x00F8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x00F9;

		///<summary>FName</summary>
		public const int InternalVariableName = 0x0100;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData03 = 0x0108;

	}

	public class USelection
	{
		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UDestructibleMesh
	{
		///<summary>FDestructibleParameters</summary>
		public const int DefaultDestructibleParameters = 0x02E0;

		///<summary>TArray&lt;FFractureEffect&gt;</summary>
		public const int FractureEffects = 0x0368;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0378;

	}

	public class USkeletalMeshReductionSettings
	{
		///<summary>TArray&lt;FSkeletalMeshLODGroupSettings&gt;</summary>
		public const int Settings = 0x0028;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0038;

	}

	public class USkeletalMeshSocket
	{
		///<summary>FName</summary>
		public const int SocketName = 0x0028;

		///<summary>FName</summary>
		public const int BoneName = 0x0030;

		///<summary>FVector</summary>
		public const int RelativeLocation = 0x0038;

		///<summary>FRotator</summary>
		public const int RelativeRotation = 0x0044;

		///<summary>FVector</summary>
		public const int RelativeScale = 0x0050;

		///<summary>bool</summary>
		public const int bForceAlwaysAnimated = 0x005C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x005D;

	}

	public class USlateBrushAsset
	{
		///<summary>FSlateBrush</summary>
		public const int Brush = 0x0028;

	}

	public class UTexture
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FGuid</summary>
		public const int LightingGuid = 0x0030;

		///<summary>int</summary>
		public const int LODBias = 0x0040;

		///<summary>int</summary>
		public const int NumCinematicMipLevels = 0x0044;

		///<summary>int</summary>
		public const int GlobalLODBias = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int SRGB = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int NeverStream = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bNoTiling = 0x004C;

		///<summary>unsigned char:1</summary>
		public const int bUseCinematicMipLevels = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x004D;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0050;

		///<summary>int</summary>
		public const int CachedCombinedLODBias = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bAsyncResourceReleaseHasBeenStarted = 0x0064;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0065;

		///<summary>TEnumAsByte&lt;ETextureCompressionSettings&gt;</summary>
		public const int CompressionSettings = 0x0068;

		///<summary>TEnumAsByte&lt;ETextureFilter&gt;</summary>
		public const int Filter = 0x0069;

		///<summary>TEnumAsByte&lt;ETextureGroup&gt;</summary>
		public const int LODGroup = 0x006A;

		///<summary>unsigned char[0x5D]</summary>
		public const int UnknownData03 = 0x006B;

	}

	public class USoundConcurrency
	{
		///<summary>FSoundConcurrencySettings</summary>
		public const int Concurrency = 0x0028;

	}

	public class USoundEffectPreset
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USoundSubmix
	{
		///<summary>TArray&lt;USoundSubmix * &gt;</summary>
		public const int ChildSubmixes = 0x0028;

		///<summary>USoundSubmix *</summary>
		public const int ParentSubmix = 0x0038;

		///<summary>TArray&lt;USoundEffectSubmixPreset * &gt;</summary>
		public const int SubmixEffectChain = 0x0040;

	}

	public class USoundBase
	{
		///<summary>USoundClass *</summary>
		public const int SoundClassObject = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bDebug = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bOverrideConcurrency = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreFocus = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>USoundConcurrency *</summary>
		public const int SoundConcurrencySettings = 0x0038;

		///<summary>FSoundConcurrencySettings</summary>
		public const int ConcurrencyOverrides = 0x0040;

		///<summary>TEnumAsByte&lt;EMaxConcurrentResolutionRule&gt;</summary>
		public const int MaxConcurrentResolutionRule = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0051;

		///<summary>int</summary>
		public const int MaxConcurrentPlayCount = 0x0054;

		///<summary>float</summary>
		public const int Duration = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x005C;

		///<summary>USoundAttenuation *</summary>
		public const int AttenuationSettings = 0x0060;

		///<summary>float</summary>
		public const int Priority = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x006C;

		///<summary>USoundSubmix *</summary>
		public const int SoundSubmixObject = 0x0070;

		///<summary>TArray&lt;FSoundSubmixSendInfo&gt;</summary>
		public const int SoundSubmixSends = 0x0078;

		///<summary>float</summary>
		public const int DefaultMasterReverbSendAmount = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x008C;

		///<summary>USoundEffectSourcePresetChain *</summary>
		public const int SourceEffectChain = 0x0090;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x0098;

	}

	public class UDialogueSoundWaveProxy
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x00A0;

	}

	public class USoundNode
	{
		///<summary>TArray&lt;USoundNode * &gt;</summary>
		public const int ChildNodes = 0x0028;

	}

	public class USoundCue
	{
		///<summary>unsigned char:1</summary>
		public const int bOverrideAttenuation = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00A1;

		///<summary>USoundNode *</summary>
		public const int FirstNode = 0x00A8;

		///<summary>float</summary>
		public const int VolumeMultiplier = 0x00B0;

		///<summary>float</summary>
		public const int PitchMultiplier = 0x00B4;

		///<summary>FSoundAttenuationSettings</summary>
		public const int AttenuationOverrides = 0x00B8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x01E8;

	}

	public class USoundGroups
	{
		///<summary>TArray&lt;FSoundGroup&gt;</summary>
		public const int SoundGroupProfiles = 0x0028;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0038;

	}

	public class USoundWave
	{
		///<summary>int</summary>
		public const int CompressionQuality = 0x00A0;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x00A4;

		///<summary>unsigned char:1</summary>
		public const int bStreaming = 0x00A4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00A5;

		///<summary>int</summary>
		public const int StreamingPriority = 0x00A8;

		///<summary>unsigned char:3</summary>
		public const int UnknownData01 = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bMature = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bManualWordWrap = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bSingleLine = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bVirtualizeWhenSilent = 0x00AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00AD;

		///<summary>TEnumAsByte&lt;ESoundGroup&gt;</summary>
		public const int SoundGroup = 0x00B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x00B1;

		///<summary>FString</summary>
		public const int SpokenText = 0x00B8;

		///<summary>float</summary>
		public const int SubtitlePriority = 0x00C8;

		///<summary>float</summary>
		public const int Volume = 0x00CC;

		///<summary>float</summary>
		public const int Pitch = 0x00D0;

		///<summary>int</summary>
		public const int NumChannels = 0x00D4;

		///<summary>int</summary>
		public const int SampleRate = 0x00D8;

		///<summary>int</summary>
		public const int RawPCMDataSize = 0x00DC;

		///<summary>TArray&lt;FSubtitleCue&gt;</summary>
		public const int Subtitles = 0x00E0;

		///<summary>TArray&lt;FLocalizedSubtitle&gt;</summary>
		public const int LocalizedSubtitles = 0x00F0;

		///<summary>UCurveTable *</summary>
		public const int Curves = 0x0100;

		///<summary>UCurveTable *</summary>
		public const int InternalCurves = 0x0108;

		///<summary>unsigned char[0x170]</summary>
		public const int UnknownData04 = 0x0110;

	}

	public class USoundWaveProcedural
	{
		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData00 = 0x0280;

	}

	public class USoundClass
	{
		///<summary>FSoundClassProperties</summary>
		public const int Properties = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0054;

		///<summary>TArray&lt;USoundClass * &gt;</summary>
		public const int ChildClasses = 0x0058;

		///<summary>TArray&lt;FPassiveSoundMixModifier&gt;</summary>
		public const int PassiveSoundMixModifiers = 0x0068;

		///<summary>USoundClass *</summary>
		public const int ParentClass = 0x0078;

	}

	public class USoundEffectSourcePresetChain
	{
		///<summary>TArray&lt;FSourceEffectChainEntry&gt;</summary>
		public const int Chain = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bPlayEffectChainTails = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

	}

	public class USoundMix
	{
		///<summary>unsigned char:1</summary>
		public const int bApplyEQ = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>float</summary>
		public const int EQPriority = 0x002C;

		///<summary>FAudioEQEffect</summary>
		public const int EQSettings = 0x0030;

		///<summary>TArray&lt;FSoundClassAdjuster&gt;</summary>
		public const int SoundClassEffects = 0x0068;

		///<summary>float</summary>
		public const int InitialDelay = 0x0078;

		///<summary>float</summary>
		public const int FadeInTime = 0x007C;

		///<summary>float</summary>
		public const int Duration = 0x0080;

		///<summary>float</summary>
		public const int FadeOutTime = 0x0084;

	}

	public class USoundNodeWavePlayer
	{
		///<summary>TAssetPtr&lt;USoundWave&gt;</summary>
		public const int SoundWaveAssetPtr = 0x0038;

		///<summary>USoundWave *</summary>
		public const int SoundWave = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int UnknownData00 = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0061;

	}

	public class USoundNodeAttenuation
	{
		///<summary>USoundAttenuation *</summary>
		public const int AttenuationSettings = 0x0038;

		///<summary>FSoundAttenuationSettings</summary>
		public const int AttenuationOverrides = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bOverrideAttenuation = 0x0170;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0171;

	}

	public class USoundNodeBranch
	{
		///<summary>FName</summary>
		public const int BoolParameterName = 0x0038;

	}

	public class USoundNodeConcatenator
	{
		///<summary>TArray&lt;float&gt;</summary>
		public const int InputVolume = 0x0038;

	}

	public class USoundNodeDelay
	{
		///<summary>float</summary>
		public const int DelayMin = 0x0038;

		///<summary>float</summary>
		public const int DelayMax = 0x003C;

	}

	public class USoundNodeDialoguePlayer
	{
		///<summary>FDialogueWaveParameter</summary>
		public const int DialogueWaveParameter = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0059;

	}

	public class USoundNodeDistanceCrossFade
	{
		///<summary>TArray&lt;FDistanceDatum&gt;</summary>
		public const int CrossFadeInput = 0x0038;

	}

	public class USoundNodeParamCrossFade
	{
		///<summary>FName</summary>
		public const int ParamName = 0x0048;

	}

	public class USoundNodeDoppler
	{
		///<summary>float</summary>
		public const int DopplerIntensity = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

	}

	public class USoundNodeEnveloper
	{
		///<summary>float</summary>
		public const int LoopStart = 0x0038;

		///<summary>float</summary>
		public const int LoopEnd = 0x003C;

		///<summary>float</summary>
		public const int DurationAfterLoop = 0x0040;

		///<summary>int</summary>
		public const int LoopCount = 0x0044;

		///<summary>unsigned char:1</summary>
		public const int bLoopIndefinitely = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bLoop = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>UDistributionFloatConstantCurve *</summary>
		public const int VolumeInterpCurve = 0x0050;

		///<summary>UDistributionFloatConstantCurve *</summary>
		public const int PitchInterpCurve = 0x0058;

		///<summary>FRuntimeFloatCurve</summary>
		public const int VolumeCurve = 0x0060;

		///<summary>FRuntimeFloatCurve</summary>
		public const int PitchCurve = 0x00D8;

		///<summary>float</summary>
		public const int PitchMin = 0x0150;

		///<summary>float</summary>
		public const int PitchMax = 0x0154;

		///<summary>float</summary>
		public const int VolumeMin = 0x0158;

		///<summary>float</summary>
		public const int VolumeMax = 0x015C;

	}

	public class USoundNodeGroupControl
	{
		///<summary>TArray&lt;int&gt;</summary>
		public const int GroupSizes = 0x0038;

	}

	public class USoundNodeLooping
	{
		///<summary>int</summary>
		public const int LoopCount = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bLoopIndefinitely = 0x003C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x003D;

	}

	public class USoundNodeMixer
	{
		///<summary>TArray&lt;float&gt;</summary>
		public const int InputVolume = 0x0038;

	}

	public class USoundNodeModulator
	{
		///<summary>float</summary>
		public const int PitchMin = 0x0038;

		///<summary>float</summary>
		public const int PitchMax = 0x003C;

		///<summary>float</summary>
		public const int VolumeMin = 0x0040;

		///<summary>float</summary>
		public const int VolumeMax = 0x0044;

	}

	public class USoundNodeModulatorContinuous
	{
		///<summary>FModulatorContinuousParams</summary>
		public const int PitchModulationParams = 0x0038;

		///<summary>FModulatorContinuousParams</summary>
		public const int VolumeModulationParams = 0x0058;

	}

	public class USoundNodeOscillator
	{
		///<summary>unsigned char:1</summary>
		public const int bModulateVolume = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bModulatePitch = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>float</summary>
		public const int AmplitudeMin = 0x003C;

		///<summary>float</summary>
		public const int AmplitudeMax = 0x0040;

		///<summary>float</summary>
		public const int FrequencyMin = 0x0044;

		///<summary>float</summary>
		public const int FrequencyMax = 0x0048;

		///<summary>float</summary>
		public const int OffsetMin = 0x004C;

		///<summary>float</summary>
		public const int OffsetMax = 0x0050;

		///<summary>float</summary>
		public const int CenterMin = 0x0054;

		///<summary>float</summary>
		public const int CenterMax = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x005C;

	}

	public class USoundNodeRandom
	{
		///<summary>TArray&lt;float&gt;</summary>
		public const int Weights = 0x0038;

		///<summary>int</summary>
		public const int PreselectAtLevelLoad = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bRandomizeWithoutReplacement = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x004D;

		///<summary>TArray&lt;bool&gt;</summary>
		public const int HasBeenUsed = 0x0050;

		///<summary>int</summary>
		public const int NumRandomUsed = 0x0060;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0064;

	}

	public class USoundNodeSoundClass
	{
		///<summary>USoundClass *</summary>
		public const int SoundClassOverride = 0x0038;

	}

	public class USoundNodeSwitch
	{
		///<summary>FName</summary>
		public const int IntParameterName = 0x0038;

	}

	public class USoundNodeWaveParam
	{
		///<summary>FName</summary>
		public const int WaveParameterName = 0x0038;

	}

	public class UStaticMesh
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FMeshSectionInfoExt&gt;</summary>
		public const int SectionInfoExts = 0x0040;

		///<summary>int</summary>
		public const int MinLOD = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0054;

		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int Materials = 0x0058;

		///<summary>TArray&lt;FStaticMaterial&gt;</summary>
		public const int StaticMaterials = 0x0068;

		///<summary>float</summary>
		public const int LightmapUVDensity = 0x0078;

		///<summary>int</summary>
		public const int LightMapResolution = 0x007C;

		///<summary>int</summary>
		public const int LightMapCoordinateIndex = 0x0080;

		///<summary>float</summary>
		public const int DistanceFieldSelfShadowBias = 0x0084;

		///<summary>unsigned char:1</summary>
		public const int bGenerateMeshDistanceField = 0x0088;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0089;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x0090;

		///<summary>int</summary>
		public const int LODForCollision = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bStripComplexCollisionForConsole = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bHasNavigationData = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int bRequiresAreaWeightedSampling = 0x009C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x009D;

		///<summary>float</summary>
		public const int LpvBiasMultiplier = 0x00A0;

		///<summary>bool</summary>
		public const int bAllowCPUAccess = 0x00A4;

		///<summary>unsigned char[0x33]</summary>
		public const int UnknownData04 = 0x00A5;

		///<summary>TArray&lt;UStaticMeshSocket * &gt;</summary>
		public const int Sockets = 0x00D8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData05 = 0x00E8;

		///<summary>FVector</summary>
		public const int PositiveBoundsExtension = 0x00F8;

		///<summary>FVector</summary>
		public const int NegativeBoundsExtension = 0x0104;

		///<summary>FBoxSphereBounds</summary>
		public const int ExtendedBounds = 0x0110;

		///<summary>bool</summary>
		public const int bIgnoreDistanceFieldData = 0x012C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x012D;

		///<summary>int</summary>
		public const int ElementToIgnoreForTexFactor = 0x0130;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x0134;

		///<summary>TArray&lt;UAssetUserData * &gt;</summary>
		public const int AssetUserData = 0x0138;

		///<summary>UNavCollision *</summary>
		public const int NavCollision = 0x0148;

	}

	public class UStaticMeshSocket
	{
		///<summary>FName</summary>
		public const int SocketName = 0x0028;

		///<summary>FVector</summary>
		public const int RelativeLocation = 0x0030;

		///<summary>FRotator</summary>
		public const int RelativeRotation = 0x003C;

		///<summary>FVector</summary>
		public const int RelativeScale = 0x0048;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0054;

		///<summary>FString</summary>
		public const int Tag = 0x0058;

	}

	public class UStringTable
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USubsurfaceProfile
	{
		///<summary>FSubsurfaceProfileStruct</summary>
		public const int Settings = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x004C;

	}

	public class UTextPropertyTestObject
	{
		///<summary>FText</summary>
		public const int DefaultedText = 0x0028;

		///<summary>FText</summary>
		public const int UndefaultedText = 0x0040;

		///<summary>FText</summary>
		public const int TransientText = 0x0058;

	}

	public class UTexture2D
	{
		///<summary>int</summary>
		public const int RequestedMips = 0x00C8;

		///<summary>int</summary>
		public const int ResidentMips = 0x00CC;

		///<summary>int</summary>
		public const int StreamingIndex = 0x00D0;

		///<summary>int</summary>
		public const int LevelIndex = 0x00D4;

		///<summary>int</summary>
		public const int FirstResourceMemMip = 0x00D8;

		///<summary>FIntPoint</summary>
		public const int ImportedSize = 0x00DC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00E4;

		///<summary>double</summary>
		public const int ForceMipLevelsToBeResidentTimestamp = 0x00E8;

		///<summary>unsigned char:1</summary>
		public const int bTemporarilyDisableStreaming = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bIsStreamable = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bHasStreamingUpdatePending = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bHasCancelationPending = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bForceMiplevelsToBeResident = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreStreamingMipBias = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bGlobalForceMipLevelsToBeResident = 0x00F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00F1;

		///<summary>TEnumAsByte&lt;ETextureAddress&gt;</summary>
		public const int AddressX = 0x00F4;

		///<summary>TEnumAsByte&lt;ETextureAddress&gt;</summary>
		public const int AddressY = 0x00F5;

		///<summary>unsigned char[0x1A]</summary>
		public const int UnknownData02 = 0x00F6;

	}

	public class ULightMapTexture2D
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0110;

	}

	public class UShadowMapTexture2D
	{
		///<summary>TEnumAsByte&lt;EShadowMapFlags&gt;</summary>
		public const int ShadowmapFlags = 0x0110;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0111;

	}

	public class UTextureLightProfile
	{
		///<summary>float</summary>
		public const int Brightness = 0x0110;

		///<summary>float</summary>
		public const int TextureMultiplier = 0x0114;

	}

	public class UTexture2DDynamic
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00C8;

		///<summary>TEnumAsByte&lt;EPixelFormat&gt;</summary>
		public const int Format = 0x00D0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData01 = 0x00D1;

	}

	public class UTextureCube
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x00C8;

	}

	public class UTextureRenderTarget
	{
		///<summary>float</summary>
		public const int TargetGamma = 0x00C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00CC;

	}

	public class UTextureRenderTarget2D
	{
		///<summary>int</summary>
		public const int SizeX = 0x00D0;

		///<summary>int</summary>
		public const int SizeY = 0x00D4;

		///<summary>FLinearColor</summary>
		public const int ClearColor = 0x00D8;

		///<summary>TEnumAsByte&lt;ETextureAddress&gt;</summary>
		public const int AddressX = 0x00E8;

		///<summary>TEnumAsByte&lt;ETextureAddress&gt;</summary>
		public const int AddressY = 0x00E9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x00EA;

		///<summary>unsigned char:1</summary>
		public const int bForceLinearGamma = 0x00EC;

		///<summary>unsigned char:1</summary>
		public const int bHDR = 0x00EC;

		///<summary>unsigned char:1</summary>
		public const int bGPUSharedFlag = 0x00EC;

		///<summary>unsigned char:1</summary>
		public const int bAutoGenerateMips = 0x00EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00ED;

		///<summary>TEnumAsByte&lt;EPixelFormat&gt;</summary>
		public const int OverrideFormat = 0x00F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x00F1;

	}

	public class UCanvasRenderTarget2D
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCanvasRenderTargetUpdate = 0x00F8;

		///<summary>TWeakObjectPtr&lt;UWorld&gt;</summary>
		public const int World = 0x0108;

		///<summary>bool</summary>
		public const int bShouldClearRenderTargetOnReceiveUpdate = 0x0110;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0111;

	}

	public class UTextureRenderTargetCube
	{
		///<summary>int</summary>
		public const int SizeX = 0x00D0;

		///<summary>FLinearColor</summary>
		public const int ClearColor = 0x00D4;

		///<summary>TEnumAsByte&lt;EPixelFormat&gt;</summary>
		public const int OverrideFormat = 0x00E4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00E5;

		///<summary>unsigned char:1</summary>
		public const int bHDR = 0x00E8;

		///<summary>unsigned char:1</summary>
		public const int bForceLinearGamma = 0x00E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00E9;

	}

	public class UTextureLODSettings
	{
		///<summary>TArray&lt;FTextureLODGroup&gt;</summary>
		public const int TextureLODGroups = 0x0028;

	}

	public class UDeviceProfile
	{
		///<summary>FString</summary>
		public const int DeviceType = 0x0038;

		///<summary>FString</summary>
		public const int BaseProfileName = 0x0048;

		///<summary>UObject *</summary>
		public const int Parent = 0x0058;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0060;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int CVars = 0x0078;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData01 = 0x0088;

	}

	public class UTimelineTemplate
	{
		///<summary>float</summary>
		public const int TimelineLength = 0x0028;

		///<summary>TEnumAsByte&lt;ETimelineLengthMode&gt;</summary>
		public const int LengthMode = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x002D;

		///<summary>unsigned char:1</summary>
		public const int bAutoPlay = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bLoop = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bReplicated = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bValidatedAsWired = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreTimeDilation = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

		///<summary>TArray&lt;FTTEventTrack&gt;</summary>
		public const int EventTracks = 0x0038;

		///<summary>TArray&lt;FTTFloatTrack&gt;</summary>
		public const int FloatTracks = 0x0048;

		///<summary>TArray&lt;FTTVectorTrack&gt;</summary>
		public const int VectorTracks = 0x0058;

		///<summary>TArray&lt;FTTLinearColorTrack&gt;</summary>
		public const int LinearColorTracks = 0x0068;

		///<summary>TArray&lt;FBPVariableMetaDataEntry&gt;</summary>
		public const int MetaDataArray = 0x0078;

		///<summary>FGuid</summary>
		public const int TimelineGuid = 0x0088;

	}

	public class UTouchInterface
	{
		///<summary>TArray&lt;FTouchInputControl&gt;</summary>
		public const int Controls = 0x0028;

		///<summary>float</summary>
		public const int ActiveOpacity = 0x0038;

		///<summary>float</summary>
		public const int InactiveOpacity = 0x003C;

		///<summary>float</summary>
		public const int TimeUntilDeactive = 0x0040;

		///<summary>float</summary>
		public const int TimeUntilReset = 0x0044;

		///<summary>float</summary>
		public const int ActivationDelay = 0x0048;

		///<summary>bool</summary>
		public const int bPreventRecenter = 0x004C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x004D;

		///<summary>float</summary>
		public const int StartupDelay = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0054;

	}

	public class UUserDefinedEnum
	{
		///<summary>TMap&lt;FName,FText&gt;</summary>
		public const int DisplayNameMap = 0x0060;

	}

	public class UVectorField
	{
		///<summary>FBox</summary>
		public const int Bounds = 0x0028;

		///<summary>float</summary>
		public const int Intensity = 0x0044;

	}

	public class UVectorFieldAnimated
	{
		///<summary>UTexture2D *</summary>
		public const int Texture = 0x0048;

		///<summary>TEnumAsByte&lt;EVectorFieldConstructionOp&gt;</summary>
		public const int ConstructionOp = 0x0050;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0051;

		///<summary>int</summary>
		public const int VolumeSizeX = 0x0054;

		///<summary>int</summary>
		public const int VolumeSizeY = 0x0058;

		///<summary>int</summary>
		public const int VolumeSizeZ = 0x005C;

		///<summary>int</summary>
		public const int SubImagesX = 0x0060;

		///<summary>int</summary>
		public const int SubImagesY = 0x0064;

		///<summary>int</summary>
		public const int FrameCount = 0x0068;

		///<summary>float</summary>
		public const int FramesPerSecond = 0x006C;

		///<summary>unsigned char:1</summary>
		public const int bLoop = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0071;

		///<summary>UVectorFieldStatic *</summary>
		public const int NoiseField = 0x0078;

		///<summary>float</summary>
		public const int NoiseScale = 0x0080;

		///<summary>float</summary>
		public const int NoiseMax = 0x0084;

	}

	public class UVectorFieldStatic
	{
		///<summary>int</summary>
		public const int SizeX = 0x0048;

		///<summary>int</summary>
		public const int SizeY = 0x004C;

		///<summary>int</summary>
		public const int SizeZ = 0x0050;

		///<summary>unsigned char[0x84]</summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UWorldComposition
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;ULevelStreaming * &gt;</summary>
		public const int TilesStreaming = 0x0048;

		///<summary>double</summary>
		public const int TilesStreamingTimeThreshold = 0x0058;

		///<summary>bool</summary>
		public const int bLoadAllTilesDuringCinematic = 0x0060;

		///<summary>bool</summary>
		public const int bRebaseOriginIn3DSpace = 0x0061;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0062;

		///<summary>float</summary>
		public const int RebaseOriginDistance = 0x0064;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int IgnoreStreamingPrefix = 0x0068;

	}

}
