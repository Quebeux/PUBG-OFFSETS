/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AActor
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FActorTickFunction]]></summary>
		public const int PrimaryActorTick = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int CustomTimeDilation = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHidden = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetTemporary = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetStartup = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOnlyRelevantToOwner = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysRelevant = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicateMovement = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTearOff = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bExchangedRoles = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPendingNetUpdate = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetLoadOnClient = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetUseOwnerRelevancy = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBlockInput = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData01 = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowTickBeforeBeginPlay = 0x009D;

		///<summary><![CDATA[unsigned char:2]]></summary>
		public const int UnknownData02 = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData03 = 0x009E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActorEnableCollision = 0x009E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData04 = 0x009E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicates = 0x009E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData05 = 0x009F;

		///<summary><![CDATA[FName]]></summary>
		public const int NetDriverName = 0x00A0;

		///<summary><![CDATA[TEnumAsByte<ENetRole>]]></summary>
		public const int RemoteRole = 0x00A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData06 = 0x00A9;

		///<summary><![CDATA[AActor *]]></summary>
		public const int Owner = 0x00B0;

		///<summary><![CDATA[FRepMovement]]></summary>
		public const int ReplicatedMovement = 0x00B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData07 = 0x00EC;

		///<summary><![CDATA[FRepAttachment]]></summary>
		public const int AttachmentReplication = 0x00F0;

		///<summary><![CDATA[TEnumAsByte<ENetRole>]]></summary>
		public const int Role = 0x0130;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData08 = 0x0131;

		///<summary><![CDATA[TEnumAsByte<EAutoReceiveInput>]]></summary>
		public const int AutoReceiveInput = 0x0133;

		///<summary><![CDATA[int]]></summary>
		public const int InputPriority = 0x0134;

		///<summary><![CDATA[UInputComponent *]]></summary>
		public const int InputComponent = 0x0138;

		///<summary><![CDATA[TEnumAsByte<EInputConsumeOptions>]]></summary>
		public const int InputConsumeOption = 0x0140;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0141;

		///<summary><![CDATA[float]]></summary>
		public const int NetCullDistanceSquared = 0x0144;

		///<summary><![CDATA[int]]></summary>
		public const int NetTag = 0x0148;

		///<summary><![CDATA[float]]></summary>
		public const int NetUpdateTime = 0x014C;

		///<summary><![CDATA[float]]></summary>
		public const int NetUpdateFrequency = 0x0150;

		///<summary><![CDATA[float]]></summary>
		public const int MinNetUpdateFrequency = 0x0154;

		///<summary><![CDATA[float]]></summary>
		public const int NetPriority = 0x0158;

		///<summary><![CDATA[float]]></summary>
		public const int LastNetUpdateTime = 0x015C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoDestroyWhenFinished = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanBeDamaged = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActorIsBeingDestroyed = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollideWhenPlacing = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFindCameraComponentWhenViewTarget = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRelevantForNetworkReplays = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateOverlapEventsDuringLevelStreaming = 0x0160;

		///<summary><![CDATA[TEnumAsByte<ESpawnActorCollisionHandlingMethod>]]></summary>
		public const int SpawnCollisionHandlingMethod = 0x0161;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData10 = 0x0162;

		///<summary><![CDATA[APawn *]]></summary>
		public const int Instigator = 0x0168;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int Children = 0x0170;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int RootComponent = 0x0180;

		///<summary><![CDATA[TArray<AMatineeActor * >]]></summary>
		public const int ControllingMatineeActors = 0x0188;

		///<summary><![CDATA[float]]></summary>
		public const int InitialLifeSpan = 0x0198;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData11 = 0x019C;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int Layers = 0x01A8;

		///<summary><![CDATA[TWeakObjectPtr<AActor>]]></summary>
		public const int ParentComponentActor = 0x01B8;

		///<summary><![CDATA[TWeakObjectPtr<UChildActorComponent>]]></summary>
		public const int ParentComponent = 0x01C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowReceiveTickEventOnDedicatedServer = 0x01C8;

		///<summary><![CDATA[unsigned char:3]]></summary>
		public const int UnknownData12 = 0x01C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActorSeamlessTraveled = 0x01C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoresOriginShifting = 0x01C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableAutoLODGeneration = 0x01C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData13 = 0x01C9;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int Tags = 0x01D0;

		///<summary><![CDATA[uint64_t]]></summary>
		public const int HiddenEditorViews = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTakeAnyDamage = 0x01E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTakePointDamage = 0x01F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnActorBeginOverlap = 0x0208;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnActorEndOverlap = 0x0218;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnBeginCursorOver = 0x0228;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEndCursorOver = 0x0238;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnClicked = 0x0248;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnReleased = 0x0258;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchBegin = 0x0268;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchEnd = 0x0278;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchEnter = 0x0288;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchLeave = 0x0298;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnActorHit = 0x02A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDestroyed = 0x02B8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEndPlay = 0x02C8;

		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData14 = 0x02D8;

		///<summary><![CDATA[TArray<UActorComponent * >]]></summary>
		public const int BlueprintCreatedComponents = 0x0378;

		///<summary><![CDATA[TArray<UActorComponent * >]]></summary>
		public const int InstanceComponents = 0x0388;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData15 = 0x0398;

	}

	public class AHUD
	{
		///<summary><![CDATA[APlayerController *]]></summary>
		public const int PlayerOwner = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLostFocusPaused = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowHUD = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowDebugInfo = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowHitBoxDebugInfo = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowOverlays = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableDebugTextShadow = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A9;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int PostRenderedActors = 0x03B0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03C0;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int DebugDisplay = 0x03C8;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int ToggledDebugCategories = 0x03D8;

		///<summary><![CDATA[UCanvas *]]></summary>
		public const int Canvas = 0x03E8;

		///<summary><![CDATA[UCanvas *]]></summary>
		public const int DebugCanvas = 0x03F0;

		///<summary><![CDATA[TArray<FDebugTextInfo>]]></summary>
		public const int DebugTextList = 0x03F8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ShowDebugTargetDesiredClass = 0x0408;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ShowDebugTargetActor = 0x0410;

		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData02 = 0x0418;

	}

	public class UAnimNotify
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UActorComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FActorComponentTickFunction]]></summary>
		public const int PrimaryComponentTick = 0x0030;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int ComponentTags = 0x0088;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x0098;

		///<summary><![CDATA[unsigned char:3]]></summary>
		public const int UnknownData01 = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicates = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetAddressable = 0x00A8;

		///<summary><![CDATA[unsigned char:3]]></summary>
		public const int UnknownData02 = 0x00A8;

		///<summary><![CDATA[unsigned char:7]]></summary>
		public const int UnknownData03 = 0x00A9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCreatedByConstructionScript = 0x00A9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInstanceComponent = 0x00AA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoActivate = 0x00AA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsActive = 0x00AA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEditableWhenInherited = 0x00AA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData04 = 0x00AA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanEverAffectNavigation = 0x00AA;

		///<summary><![CDATA[unsigned char:2]]></summary>
		public const int UnknownData05 = 0x00AA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsEditorOnly = 0x00AB;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x00AC;

		///<summary><![CDATA[TEnumAsByte<EComponentCreationMethod>]]></summary>
		public const int CreationMethod = 0x00B0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData07 = 0x00B1;

		///<summary><![CDATA[TArray<FSimpleMemberReference>]]></summary>
		public const int UCSModifiedProperties = 0x00C0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentActivated = 0x00D0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentDeactivated = 0x00E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData08 = 0x00F0;

	}

	public class USceneComponent
	{
		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int AttachParent = 0x00F8;

		///<summary><![CDATA[TArray<USceneComponent * >]]></summary>
		public const int AttachChildren = 0x0100;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0110;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachSocketName = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData01 = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicatesAttachmentReference = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicatesAttachment = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWorldToComponentUpdated = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsoluteLocation = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsoluteRotation = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsoluteScale = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVisible = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHiddenInGame = 0x0169;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldUpdatePhysicsVolume = 0x0169;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBoundsChangeTriggersStreamingDataRebuild = 0x0169;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAttachParentBound = 0x0169;

		///<summary><![CDATA[unsigned char:2]]></summary>
		public const int UnknownData02 = 0x0169;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsoluteTranslation = 0x0169;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData03 = 0x016A;

		///<summary><![CDATA[TWeakObjectPtr<APhysicsVolume>]]></summary>
		public const int PhysicsVolume = 0x016C;

		///<summary><![CDATA[unsigned char[0x2C]]]></summary>
		public const int UnknownData04 = 0x0174;

		///<summary><![CDATA[FVector]]></summary>
		public const int Location = 0x01A0;

		///<summary><![CDATA[unsigned char[0x34]]]></summary>
		public const int UnknownData05 = 0x01AC;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeLocation = 0x01E0;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RelativeRotation = 0x01EC;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData06 = 0x01F8;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeScale3D = 0x0220;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeTranslation = 0x022C;

		///<summary><![CDATA[TEnumAsByte<EComponentMobility>]]></summary>
		public const int Mobility = 0x0238;

		///<summary><![CDATA[TEnumAsByte<EDetailMode>]]></summary>
		public const int DetailMode = 0x0239;

		///<summary><![CDATA[unsigned char[0x1E]]]></summary>
		public const int UnknownData07 = 0x023A;

		///<summary><![CDATA[FVector]]></summary>
		public const int ComponentVelocity = 0x0258;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x0264;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int PhysicsVolumeChangedDelegate = 0x0268;

		///<summary><![CDATA[unsigned char[0x88]]]></summary>
		public const int UnknownData09 = 0x0278;

	}

	public class UPrimitiveComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int MinDrawDistance = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int LDMaxDrawDistance = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int CachedMaxDrawDistance = 0x0310;

		///<summary><![CDATA[TEnumAsByte<ESceneDepthPriorityGroup>]]></summary>
		public const int DepthPriorityGroup = 0x0314;

		///<summary><![CDATA[TEnumAsByte<ESceneDepthPriorityGroup>]]></summary>
		public const int ViewOwnerDepthPriorityGroup = 0x0315;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x0316;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysCreatePhysicsState = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateOverlapEvents = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMultiBodyOverlap = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCheckAsyncSceneOnMove = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTraceComplexOnMove = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReturnMaterialOnMove = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseViewOwnerDepthPriorityGroup = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowCullDistanceVolume = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bImportantMesh = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasMotionBlurVelocityMeshes = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVisibleInReflectionCaptures = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderInMainPass = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReceivesDecals = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReceivesSecondaryDecals = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOwnerNoSee = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOnlyOwnerSee = 0x0319;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTreatAsBackgroundForOcclusion = 0x031A;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAsOccluder = 0x031A;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSelectable = 0x031A;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceMipStreaming = 0x031A;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasPerInstanceHitProxies = 0x031A;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x031B;

		///<summary><![CDATA[TEnumAsByte<EIndoorOutdoorMask>]]></summary>
		public const int IndoorOutdoorMask = 0x031C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x031D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CastShadow = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectDynamicIndirectLighting = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectDistanceFieldLighting = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastDynamicShadow = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastStaticShadow = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastVolumetricTranslucentShadow = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSelfShadowOnly = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastFarShadow = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastInsetShadow = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastCinematicShadow = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastHiddenShadow = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastShadowAsTwoSided = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLightAsIfStatic = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLightAttachmentsAsGroup = 0x0321;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData04 = 0x0322;

		///<summary><![CDATA[TEnumAsByte<EIndirectLightingCacheQuality>]]></summary>
		public const int IndirectLightingCacheQuality = 0x0324;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0325;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReceiveCombinedCSMAndStaticShadowsFromStationaryLights = 0x0328;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSingleSampleShadowFromStationaryLights = 0x0328;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0329;

		///<summary><![CDATA[FLightingChannels]]></summary>
		public const int LightingChannels = 0x032C;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData07 = 0x032F;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreRadialImpulse = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreRadialForce = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int AlwaysLoadOnClient = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int AlwaysLoadOnServer = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseEditorCompositing = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderCustomDepth = 0x0330;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x0331;

		///<summary><![CDATA[int]]></summary>
		public const int CustomDepthStencilValue = 0x0334;

		///<summary><![CDATA[int]]></summary>
		public const int TranslucencySortPriority = 0x0338;

		///<summary><![CDATA[int]]></summary>
		public const int DepthBias = 0x033C;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int VariationIndices = 0x0340;

		///<summary><![CDATA[int]]></summary>
		public const int VisibilityId = 0x0350;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData09 = 0x0354;

		///<summary><![CDATA[float]]></summary>
		public const int LpvBiasMultiplier = 0x0358;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData10 = 0x035C;

		///<summary><![CDATA[FBodyInstance]]></summary>
		public const int BodyInstance = 0x0360;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData11 = 0x0520;

		///<summary><![CDATA[TEnumAsByte<EHasCustomNavigableGeometry>]]></summary>
		public const int bHasCustomNavigableGeometry = 0x0528;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData12 = 0x0529;

		///<summary><![CDATA[float]]></summary>
		public const int BoundsScale = 0x052C;

		///<summary><![CDATA[float]]></summary>
		public const int LastSubmitTime = 0x0530;

		///<summary><![CDATA[float]]></summary>
		public const int LastRenderTime = 0x0534;

		///<summary><![CDATA[float]]></summary>
		public const int LastRenderTimeOnScreen = 0x0538;

		///<summary><![CDATA[TEnumAsByte<ECanBeCharacterBase>]]></summary>
		public const int CanBeCharacterBase = 0x053C;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData13 = 0x053D;

		///<summary><![CDATA[TEnumAsByte<ECanBeCharacterBase>]]></summary>
		public const int CanCharacterStepUpOn = 0x053E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData14 = 0x053F;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int MoveIgnoreActors = 0x0540;

		///<summary><![CDATA[TArray<UPrimitiveComponent * >]]></summary>
		public const int MoveIgnoreComponents = 0x0550;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData15 = 0x0560;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentHit = 0x0570;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentBeginOverlap = 0x0580;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentEndOverlap = 0x0590;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentWake = 0x05A0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentSleep = 0x05B0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnBeginCursorOver = 0x05C0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEndCursorOver = 0x05D0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnClicked = 0x05E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnReleased = 0x05F0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchBegin = 0x0600;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchEnd = 0x0610;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchEnter = 0x0620;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInputTouchLeave = 0x0630;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData16 = 0x0640;

		///<summary><![CDATA[UPrimitiveComponent *]]></summary>
		public const int LODParentPrimitive = 0x0668;

		///<summary><![CDATA[FPrimitiveComponentPostPhysicsTickFunction]]></summary>
		public const int PostPhysicsComponentTick = 0x0670;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData17 = 0x06C8;

	}

	public class UMeshComponent
	{
		///<summary><![CDATA[unsigned char[0xB0]]]></summary>
		public const int UnknownData00 = 0x06D0;

	}

	public class UStaticMeshComponent
	{
		///<summary><![CDATA[int]]></summary>
		public const int ForcedLodModel = 0x0780;

		///<summary><![CDATA[int]]></summary>
		public const int PreviousLODLevel = 0x0784;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideMinLOD = 0x0788;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0789;

		///<summary><![CDATA[int]]></summary>
		public const int MinLOD = 0x078C;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int StaticMesh = 0x0790;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideWireframeColor = 0x0798;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0799;

		///<summary><![CDATA[FColor]]></summary>
		public const int WireframeColorOverride = 0x079C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideNavigationExport = 0x07A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceNavigationObstacle = 0x07A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisallowMeshPaintPerInstance = 0x07A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreInstanceForTextureStreaming = 0x07A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideLightMapRes = 0x07A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x07A1;

		///<summary><![CDATA[int]]></summary>
		public const int OverriddenLightMapRes = 0x07A4;

		///<summary><![CDATA[float]]></summary>
		public const int StreamingDistanceMultiplier = 0x07A8;

		///<summary><![CDATA[int]]></summary>
		public const int SubDivisionStepSize = 0x07AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseSubDivisions = 0x07B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x07B1;

		///<summary><![CDATA[TArray<FGuid>]]></summary>
		public const int IrrelevantLights = 0x07B8;

		///<summary><![CDATA[TArray<FStaticMeshComponentLODInfo>]]></summary>
		public const int LODData = 0x07C8;

		///<summary><![CDATA[TArray<FStreamingTextureBuildInfo>]]></summary>
		public const int StreamingTextureData = 0x07D8;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseDefaultCollision = 0x07E8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x07E9;

		///<summary><![CDATA[FLightmassPrimitiveSettings]]></summary>
		public const int LightmassSettings = 0x07EC;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData05 = 0x0804;

	}

	public class AController
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[APawn *]]></summary>
		public const int Pawn = 0x03A8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03B0;

		///<summary><![CDATA[ACharacter *]]></summary>
		public const int Character = 0x03B8;

		///<summary><![CDATA[APlayerState *]]></summary>
		public const int PlayerState = 0x03C0;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int TransformComponent = 0x03C8;

		///<summary><![CDATA[FRotator]]></summary>
		public const int ControlRotation = 0x03D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAttachToPawn = 0x03DC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPlayerController = 0x03DC;

		///<summary><![CDATA[unsigned char[0x13]]]></summary>
		public const int UnknownData02 = 0x03DD;

		///<summary><![CDATA[FName]]></summary>
		public const int StateName = 0x03F0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInstigatedAnyDamage = 0x03F8;

	}

	public class APlayerController
	{
		///<summary><![CDATA[UPlayer *]]></summary>
		public const int Player = 0x0408;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0410;

		///<summary><![CDATA[APawn *]]></summary>
		public const int AcknowledgedPawn = 0x0418;

		///<summary><![CDATA[UInterpTrackInstDirector *]]></summary>
		public const int ControllingDirTrackInst = 0x0420;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0428;

		///<summary><![CDATA[AHUD *]]></summary>
		public const int MyHUD = 0x0430;

		///<summary><![CDATA[APlayerCameraManager *]]></summary>
		public const int PlayerCameraManager = 0x0438;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PlayerCameraManagerClass = 0x0440;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoManageActiveCameraTarget = 0x0448;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0449;

		///<summary><![CDATA[FRotator]]></summary>
		public const int TargetViewRotation = 0x044C;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData03 = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int SmoothTargetViewRotationSpeed = 0x0464;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int HiddenActors = 0x0468;

		///<summary><![CDATA[float]]></summary>
		public const int LastSpectatorStateSynchTime = 0x0478;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastSpectatorSyncLocation = 0x047C;

		///<summary><![CDATA[FRotator]]></summary>
		public const int LastSpectatorSyncRotation = 0x0488;

		///<summary><![CDATA[int]]></summary>
		public const int ClientCap = 0x0494;

		///<summary><![CDATA[UCheatManager *]]></summary>
		public const int CheatManager = 0x0498;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CheatClass = 0x04A0;

		///<summary><![CDATA[UPlayerInput *]]></summary>
		public const int PlayerInput = 0x04A8;

		///<summary><![CDATA[TArray<FActiveForceFeedbackEffect>]]></summary>
		public const int ActiveForceFeedbackEffects = 0x04B0;

		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData04 = 0x04C0;

		///<summary><![CDATA[unsigned char:3]]></summary>
		public const int UnknownData05 = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPlayerIsWaiting = 0x0540;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0541;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int NetPlayerIndex = 0x0544;

		///<summary><![CDATA[unsigned char[0x3B]]]></summary>
		public const int UnknownData07 = 0x0545;

		///<summary><![CDATA[UNetConnection *]]></summary>
		public const int PendingSwapConnection = 0x0580;

		///<summary><![CDATA[UNetConnection *]]></summary>
		public const int NetConnection = 0x0588;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData08 = 0x0590;

		///<summary><![CDATA[float]]></summary>
		public const int InputYawScale = 0x059C;

		///<summary><![CDATA[float]]></summary>
		public const int InputPitchScale = 0x05A0;

		///<summary><![CDATA[float]]></summary>
		public const int InputRollScale = 0x05A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowMouseCursor = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableClickEvents = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableTouchEvents = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableMouseOverEvents = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableTouchOverEvents = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceFeedbackEnabled = 0x05A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData09 = 0x05A9;

		///<summary><![CDATA[TArray<FKey>]]></summary>
		public const int ClickEventKeys = 0x05B0;

		///<summary><![CDATA[TEnumAsByte<EMouseCursor>]]></summary>
		public const int DefaultMouseCursor = 0x05C0;

		///<summary><![CDATA[TEnumAsByte<EMouseCursor>]]></summary>
		public const int CurrentMouseCursor = 0x05C1;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int DefaultClickTraceChannel = 0x05C2;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int CurrentClickTraceChannel = 0x05C3;

		///<summary><![CDATA[float]]></summary>
		public const int HitResultTraceDistance = 0x05C4;

		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData10 = 0x05C8;

		///<summary><![CDATA[UInputComponent *]]></summary>
		public const int InactiveStateInputComponent = 0x0648;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData11 = 0x0650;

		///<summary><![CDATA[UTouchInterface *]]></summary>
		public const int CurrentTouchInterface = 0x0668;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData12 = 0x0670;

		///<summary><![CDATA[ASpectatorPawn *]]></summary>
		public const int SpectatorPawn = 0x06B0;

		///<summary><![CDATA[FVector]]></summary>
		public const int SpawnLocation = 0x06B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData13 = 0x06C4;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsLocalPlayerController = 0x06C8;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData14 = 0x06C9;

		///<summary><![CDATA[uint16_t]]></summary>
		public const int SeamlessTravelCount = 0x06CA;

		///<summary><![CDATA[uint16_t]]></summary>
		public const int LastCompletedSeamlessTravelCount = 0x06CC;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData15 = 0x06CE;

	}

	public class APawn
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseControllerRotationPitch = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseControllerRotationYaw = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseControllerRotationRoll = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanAffectNavigationGeneration = 0x03A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03A9;

		///<summary><![CDATA[float]]></summary>
		public const int BaseEyeHeight = 0x03AC;

		///<summary><![CDATA[TEnumAsByte<EAutoReceiveInput>]]></summary>
		public const int AutoPossessPlayer = 0x03B0;

		///<summary><![CDATA[TEnumAsByte<EAutoPossessAI>]]></summary>
		public const int AutoPossessAI = 0x03B1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData02 = 0x03B2;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AIControllerClass = 0x03B8;

		///<summary><![CDATA[APlayerState *]]></summary>
		public const int PlayerState = 0x03C0;

		///<summary><![CDATA[uint16_t]]></summary>
		public const int RemoteViewPitch = 0x03C8;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData03 = 0x03CA;

		///<summary><![CDATA[AController *]]></summary>
		public const int LastHitBy = 0x03D0;

		///<summary><![CDATA[AController *]]></summary>
		public const int Controller = 0x03D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x03E0;

		///<summary><![CDATA[FVector]]></summary>
		public const int ControlInputVector = 0x03E8;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastControlInputVector = 0x03F4;

	}

	public class ACharacter
	{
		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int Mesh = 0x0400;

		///<summary><![CDATA[UCharacterMovementComponent *]]></summary>
		public const int CharacterMovement = 0x0408;

		///<summary><![CDATA[UCapsuleComponent *]]></summary>
		public const int CapsuleComponent = 0x0410;

		///<summary><![CDATA[UCapsuleComponent *]]></summary>
		public const int ProneCapsuleComponent = 0x0418;

		///<summary><![CDATA[FBasedMovementInfo]]></summary>
		public const int BasedMovement = 0x0420;

		///<summary><![CDATA[FBasedMovementInfo]]></summary>
		public const int ReplicatedBasedMovement = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int AnimRootMotionTranslationScale = 0x0480;

		///<summary><![CDATA[FVector]]></summary>
		public const int BaseTranslationOffset = 0x0484;

		///<summary><![CDATA[FQuat]]></summary>
		public const int BaseRotationOffset = 0x0490;

		///<summary><![CDATA[float]]></summary>
		public const int ReplicatedServerLastTransformUpdateTimeStamp = 0x04A0;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int ReplicatedMovementMode = 0x04A4;

		///<summary><![CDATA[bool]]></summary>
		public const int bInBaseReplication = 0x04A5;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x04A6;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchedEyeHeight = 0x04A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsCrouched = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplayHasRootMotionSources = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPressedJump = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClientUpdating = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClientWasFalling = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClientResimulateRootMotion = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClientResimulateRootMotionSources = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSimGravityDisabled = 0x04AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClientCheckEncroachmentOnNetUpdate = 0x04AD;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bServerMoveIgnoreRootMotion = 0x04AD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x04AE;

		///<summary><![CDATA[float]]></summary>
		public const int JumpKeyHoldTime = 0x04B0;

		///<summary><![CDATA[float]]></summary>
		public const int JumpMaxHoldTime = 0x04B4;

		///<summary><![CDATA[int]]></summary>
		public const int JumpMaxCount = 0x04B8;

		///<summary><![CDATA[int]]></summary>
		public const int JumpCurrentCount = 0x04BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData02 = 0x04C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWasJumping = 0x04C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x04C1;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnReachedJumpApex = 0x04C8;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData04 = 0x04D8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCharacterMovementUpdated = 0x04F8;

		///<summary><![CDATA[FRootMotionSourceGroup]]></summary>
		public const int SavedRootMotion = 0x0508;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x0608;

		///<summary><![CDATA[FRootMotionMovementParams]]></summary>
		public const int ClientRootMotionParams = 0x0610;

		///<summary><![CDATA[TArray<FSimulatedRootMotionReplicatedMove>]]></summary>
		public const int RootMotionRepMoves = 0x0650;

		///<summary><![CDATA[FRepRootMotionMontage]]></summary>
		public const int RepRootMotion = 0x0660;

	}

	public class UDamageType
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCausedByWorld = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bScaleMomentumByMass = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRadialDamageVelChange = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[float]]></summary>
		public const int DamageImpulse = 0x002C;

		///<summary><![CDATA[float]]></summary>
		public const int DestructibleImpulse = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int DestructibleDamageSpreadScale = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int DamageFalloff = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x003C;

	}

	public class UMovementComponent
	{
		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int UpdatedComponent = 0x00F8;

		///<summary><![CDATA[UPrimitiveComponent *]]></summary>
		public const int UpdatedPrimitive = 0x0100;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0108;

		///<summary><![CDATA[FVector]]></summary>
		public const int Velocity = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainToPlane = 0x0118;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSnapToPlaneAtStart = 0x0118;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0119;

		///<summary><![CDATA[TEnumAsByte<EPlaneConstraintAxisSetting>]]></summary>
		public const int PlaneConstraintAxisSetting = 0x011C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x011D;

		///<summary><![CDATA[FVector]]></summary>
		public const int PlaneConstraintNormal = 0x0120;

		///<summary><![CDATA[FVector]]></summary>
		public const int PlaneConstraintOrigin = 0x012C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdateOnlyIfRendered = 0x0138;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoUpdateTickRegistration = 0x0138;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTickBeforeOwner = 0x0138;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoRegisterUpdatedComponent = 0x0138;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0139;

	}

	public class UNavMovementComponent
	{
		///<summary><![CDATA[FNavAgentProperties]]></summary>
		public const int NavAgentProps = 0x0140;

		///<summary><![CDATA[float]]></summary>
		public const int FixedPathBrakingDistance = 0x0160;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdateNavAgentWithOwnersCollision = 0x0164;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAccelerationForPaths = 0x0164;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFixedBrakingDistanceForPaths = 0x0164;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0165;

		///<summary><![CDATA[FMovementProperties]]></summary>
		public const int MovementState = 0x0168;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x016C;

	}

	public class UPawnMovementComponent
	{
		///<summary><![CDATA[APawn *]]></summary>
		public const int PawnOwner = 0x0178;

	}

	public class USpringArmComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int TargetArmLength = 0x0300;

		///<summary><![CDATA[FVector]]></summary>
		public const int SocketOffset = 0x0304;

		///<summary><![CDATA[FVector]]></summary>
		public const int TargetOffset = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int ProbeSize = 0x031C;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int ProbeChannel = 0x0320;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDoCollisionTest = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsePawnControlRotation = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritPitch = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritYaw = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritRoll = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableCameraLag = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableCameraRotationLag = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseCameraLagSubstepping = 0x0324;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawDebugLagMarkers = 0x0325;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x0326;

		///<summary><![CDATA[float]]></summary>
		public const int CameraLagSpeed = 0x0328;

		///<summary><![CDATA[float]]></summary>
		public const int CameraRotationLagSpeed = 0x032C;

		///<summary><![CDATA[float]]></summary>
		public const int CameraLagMaxTimeStep = 0x0330;

		///<summary><![CDATA[float]]></summary>
		public const int CameraLagMaxDistance = 0x0334;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData02 = 0x0338;

	}

	public class ANavigationObjectBase
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[UCapsuleComponent *]]></summary>
		public const int CapsuleComponent = 0x03A8;

		///<summary><![CDATA[UBillboardComponent *]]></summary>
		public const int GoodSprite = 0x03B0;

		///<summary><![CDATA[UBillboardComponent *]]></summary>
		public const int BadSprite = 0x03B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPIEPlayerStart = 0x03C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03C1;

	}

	public class APlayerStart
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PlayerStartTag = 0x03C8;

	}

	public class ABrush
	{
		///<summary><![CDATA[TEnumAsByte<EBrushType>]]></summary>
		public const int BrushType = 0x03A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03A1;

		///<summary><![CDATA[FColor]]></summary>
		public const int BrushColor = 0x03A4;

		///<summary><![CDATA[int]]></summary>
		public const int PolyFlags = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bColored = 0x03AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSolidWhenSelected = 0x03AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPlaceableFromClassBrowser = 0x03AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNotForClientOrServer = 0x03AC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03AD;

		///<summary><![CDATA[UModel *]]></summary>
		public const int Brush = 0x03B0;

		///<summary><![CDATA[UBrushComponent *]]></summary>
		public const int BrushComponent = 0x03B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInManipulation = 0x03C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x03C1;

		///<summary><![CDATA[TArray<FGeomSelection>]]></summary>
		public const int SavedSelections = 0x03C8;

	}

	public class AWheeledVehicle
	{
		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int Mesh = 0x0400;

		///<summary><![CDATA[UWheeledVehicleMovementComponent *]]></summary>
		public const int VehicleMovement = 0x0408;

	}

	public class UWheeledVehicleMovementComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDeprecatedSpringOffsetMode = 0x0148;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0149;

		///<summary><![CDATA[TArray<bool>]]></summary>
		public const int TirePunctured = 0x0150;

		///<summary><![CDATA[TArray<FWheelSetup>]]></summary>
		public const int WheelSetups = 0x0160;

		///<summary><![CDATA[float]]></summary>
		public const int Mass = 0x0170;

		///<summary><![CDATA[float]]></summary>
		public const int DragCoefficient = 0x0174;

		///<summary><![CDATA[float]]></summary>
		public const int ChassisWidth = 0x0178;

		///<summary><![CDATA[float]]></summary>
		public const int ChassisHeight = 0x017C;

		///<summary><![CDATA[bool]]></summary>
		public const int bReverseAsBrake = 0x0180;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0181;

		///<summary><![CDATA[float]]></summary>
		public const int DragArea = 0x0184;

		///<summary><![CDATA[float]]></summary>
		public const int EstimatedMaxEngineSpeed = 0x0188;

		///<summary><![CDATA[float]]></summary>
		public const int MaxEngineRPM = 0x018C;

		///<summary><![CDATA[float]]></summary>
		public const int DebugDragMagnitude = 0x0190;

		///<summary><![CDATA[FVector]]></summary>
		public const int InertiaTensorScale = 0x0194;

		///<summary><![CDATA[float]]></summary>
		public const int MinNormalizedTireLoad = 0x01A0;

		///<summary><![CDATA[float]]></summary>
		public const int MinNormalizedTireLoadFiltered = 0x01A4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxNormalizedTireLoad = 0x01A8;

		///<summary><![CDATA[float]]></summary>
		public const int MaxNormalizedTireLoadFiltered = 0x01AC;

		///<summary><![CDATA[float]]></summary>
		public const int ThresholdLongitudinalSpeed = 0x01B0;

		///<summary><![CDATA[int]]></summary>
		public const int LowForwardSpeedSubStepCount = 0x01B4;

		///<summary><![CDATA[int]]></summary>
		public const int HighForwardSpeedSubStepCount = 0x01B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x01BC;

		///<summary><![CDATA[TArray<UVehicleWheel * >]]></summary>
		public const int Wheels = 0x01C0;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData04 = 0x01D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseRVOAvoidance = 0x01E8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x01E9;

		///<summary><![CDATA[float]]></summary>
		public const int RVOAvoidanceRadius = 0x01EC;

		///<summary><![CDATA[float]]></summary>
		public const int RVOAvoidanceHeight = 0x01F0;

		///<summary><![CDATA[float]]></summary>
		public const int AvoidanceConsiderationRadius = 0x01F4;

		///<summary><![CDATA[float]]></summary>
		public const int RVOSteeringStep = 0x01F8;

		///<summary><![CDATA[float]]></summary>
		public const int RVOThrottleStep = 0x01FC;

		///<summary><![CDATA[int]]></summary>
		public const int AvoidanceUID = 0x0200;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int AvoidanceGroup = 0x0204;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int GroupsToAvoid = 0x0208;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int GroupsToIgnore = 0x020C;

		///<summary><![CDATA[float]]></summary>
		public const int AvoidanceWeight = 0x0210;

		///<summary><![CDATA[FVector]]></summary>
		public const int PendingLaunchVelocity = 0x0214;

		///<summary><![CDATA[FReplicatedVehicleState]]></summary>
		public const int ReplicatedState = 0x0220;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x0234;

		///<summary><![CDATA[float]]></summary>
		public const int RawSteeringInput = 0x0238;

		///<summary><![CDATA[float]]></summary>
		public const int RawThrottleInput = 0x023C;

		///<summary><![CDATA[float]]></summary>
		public const int RawBrakeInput = 0x0240;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRawHandbrakeInput = 0x0244;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRawGearUpInput = 0x0244;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRawGearDownInput = 0x0244;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x0245;

		///<summary><![CDATA[float]]></summary>
		public const int SteeringInput = 0x0248;

		///<summary><![CDATA[float]]></summary>
		public const int ThrottleInput = 0x024C;

		///<summary><![CDATA[float]]></summary>
		public const int BrakeInput = 0x0250;

		///<summary><![CDATA[float]]></summary>
		public const int HandbrakeInput = 0x0254;

		///<summary><![CDATA[float]]></summary>
		public const int IdleBrakeInput = 0x0258;

		///<summary><![CDATA[float]]></summary>
		public const int StopThreshold = 0x025C;

		///<summary><![CDATA[float]]></summary>
		public const int WrongDirectionThreshold = 0x0260;

		///<summary><![CDATA[FVehicleInputRate]]></summary>
		public const int ThrottleInputRate = 0x0264;

		///<summary><![CDATA[FVehicleInputRate]]></summary>
		public const int BrakeInputRate = 0x026C;

		///<summary><![CDATA[FVehicleInputRate]]></summary>
		public const int HandbrakeInputRate = 0x0274;

		///<summary><![CDATA[FVehicleInputRate]]></summary>
		public const int SteeringInputRate = 0x027C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWasAvoidanceUpdated = 0x0284;

		///<summary><![CDATA[unsigned char[0x2B]]]></summary>
		public const int UnknownData08 = 0x0285;

	}

	public class UWheeledVehicleMovementComponent4W
	{
		///<summary><![CDATA[FVehicleEngineData]]></summary>
		public const int EngineSetup = 0x02B0;

		///<summary><![CDATA[FVehicleDifferential4WData]]></summary>
		public const int DifferentialSetup = 0x0348;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0364;

		///<summary><![CDATA[FVehicleTransmissionData]]></summary>
		public const int TransmissionSetup = 0x0368;

		///<summary><![CDATA[FRuntimeFloatCurve]]></summary>
		public const int SteeringCurve = 0x0398;

		///<summary><![CDATA[float]]></summary>
		public const int AckermannAccuracy = 0x0418;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x041C;

	}

	public class UCharacterMovementComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0180;

		///<summary><![CDATA[ACharacter *]]></summary>
		public const int CharacterOwner = 0x0190;

		///<summary><![CDATA[float]]></summary>
		public const int GravityScale = 0x0198;

		///<summary><![CDATA[float]]></summary>
		public const int MaxStepHeight = 0x019C;

		///<summary><![CDATA[float]]></summary>
		public const int JumpZVelocity = 0x01A0;

		///<summary><![CDATA[float]]></summary>
		public const int JumpOffJumpZFactor = 0x01A4;

		///<summary><![CDATA[float]]></summary>
		public const int WalkableFloorAngle = 0x01A8;

		///<summary><![CDATA[float]]></summary>
		public const int WalkableFloorZ = 0x01AC;

		///<summary><![CDATA[float]]></summary>
		public const int ProneWalkableFloorAngle = 0x01B0;

		///<summary><![CDATA[float]]></summary>
		public const int ProneWalkableFloorZ = 0x01B4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01B8;

		///<summary><![CDATA[TEnumAsByte<EMovementMode>]]></summary>
		public const int MovementMode = 0x01BC;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int CustomMovementMode = 0x01BD;

		///<summary><![CDATA[unsigned char[0x22]]]></summary>
		public const int UnknownData02 = 0x01BE;

		///<summary><![CDATA[float]]></summary>
		public const int GroundFriction = 0x01E0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxWalkSpeed = 0x01E4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxWalkSpeedCrouched = 0x01E8;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSwimSpeed = 0x01EC;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFlySpeed = 0x01F0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxCustomMovementSpeed = 0x01F4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAcceleration = 0x01F8;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingFrictionFactor = 0x01FC;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingFriction = 0x0200;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseSeparateBrakingFriction = 0x0204;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0205;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingDecelerationWalking = 0x0208;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingDecelerationFalling = 0x020C;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingDecelerationSwimming = 0x0210;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingDecelerationFlying = 0x0214;

		///<summary><![CDATA[float]]></summary>
		public const int AirControl = 0x0218;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlBoostMultiplier = 0x021C;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlBoostVelocityThreshold = 0x0220;

		///<summary><![CDATA[float]]></summary>
		public const int FallingLateralFriction = 0x0224;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchedHalfHeight = 0x0228;

		///<summary><![CDATA[float]]></summary>
		public const int PronedHalfHeight = 0x022C;

		///<summary><![CDATA[float]]></summary>
		public const int PronedRadius = 0x0230;

		///<summary><![CDATA[float]]></summary>
		public const int Buoyancy = 0x0234;

		///<summary><![CDATA[float]]></summary>
		public const int PerchRadiusThreshold = 0x0238;

		///<summary><![CDATA[float]]></summary>
		public const int PerchAdditionalHeight = 0x023C;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RotationRate = 0x0240;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseControllerDesiredRotation = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOrientRotationToMovement = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMovementInProgress = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableScopedMovementUpdates = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceMaxAccel = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRunPhysicsWithNoController = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceNextFloorCheck = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShrinkProxyCapsule = 0x024C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanWalkOffLedges = 0x024D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanWalkOffLedgesWhenCrouching = 0x024D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData04 = 0x024D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDeferUpdateMoveComponent = 0x024D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData05 = 0x024E;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int DeferredUpdatedMoveComponent = 0x0250;

		///<summary><![CDATA[float]]></summary>
		public const int MaxOutOfWaterStepHeight = 0x0258;

		///<summary><![CDATA[float]]></summary>
		public const int OutofWaterZ = 0x025C;

		///<summary><![CDATA[float]]></summary>
		public const int Mass = 0x0260;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnablePhysicsInteraction = 0x0264;

		///<summary><![CDATA[bool]]></summary>
		public const int bTouchForceScaledToMass = 0x0265;

		///<summary><![CDATA[bool]]></summary>
		public const int bPushForceScaledToMass = 0x0266;

		///<summary><![CDATA[bool]]></summary>
		public const int bPushForceUsingZOffset = 0x0267;

		///<summary><![CDATA[bool]]></summary>
		public const int bScalePushForceToVelocity = 0x0268;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0269;

		///<summary><![CDATA[float]]></summary>
		public const int StandingDownwardForceScale = 0x026C;

		///<summary><![CDATA[float]]></summary>
		public const int InitialPushForceFactor = 0x0270;

		///<summary><![CDATA[float]]></summary>
		public const int PushForceFactor = 0x0274;

		///<summary><![CDATA[float]]></summary>
		public const int PushForcePointZOffsetFactor = 0x0278;

		///<summary><![CDATA[float]]></summary>
		public const int TouchForceFactor = 0x027C;

		///<summary><![CDATA[float]]></summary>
		public const int MinTouchForce = 0x0280;

		///<summary><![CDATA[float]]></summary>
		public const int MaxTouchForce = 0x0284;

		///<summary><![CDATA[float]]></summary>
		public const int RepulsionForce = 0x0288;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceBraking = 0x028C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x028D;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchedSpeedMultiplier = 0x0290;

		///<summary><![CDATA[float]]></summary>
		public const int UpperImpactNormalScale = 0x0294;

		///<summary><![CDATA[FVector]]></summary>
		public const int Acceleration = 0x0298;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastUpdateLocation = 0x02A4;

		///<summary><![CDATA[FQuat]]></summary>
		public const int LastUpdateRotation = 0x02B0;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastUpdateVelocity = 0x02C0;

		///<summary><![CDATA[float]]></summary>
		public const int ServerLastTransformUpdateTimeStamp = 0x02CC;

		///<summary><![CDATA[FVector]]></summary>
		public const int PendingImpulseToApply = 0x02D0;

		///<summary><![CDATA[FVector]]></summary>
		public const int PendingForceToApply = 0x02DC;

		///<summary><![CDATA[float]]></summary>
		public const int AnalogInputModifier = 0x02E8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData08 = 0x02EC;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSimulationTimeStep = 0x02F4;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSimulationIterations = 0x02F8;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDepenetrationWithGeometry = 0x02FC;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDepenetrationWithGeometryAsProxy = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDepenetrationWithPawn = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDepenetrationWithPawnAsProxy = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int NetworkSimulatedSmoothLocationTime = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int NetworkSimulatedSmoothRotationTime = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int ListenServerNetworkSimulatedSmoothLocationTime = 0x0314;

		///<summary><![CDATA[float]]></summary>
		public const int ListenServerNetworkSimulatedSmoothRotationTime = 0x0318;

		///<summary><![CDATA[float]]></summary>
		public const int NetworkMaxSmoothUpdateDistance = 0x031C;

		///<summary><![CDATA[float]]></summary>
		public const int NetworkNoSmoothUpdateDistance = 0x0320;

		///<summary><![CDATA[TEnumAsByte<ENetworkSmoothingMode>]]></summary>
		public const int NetworkSmoothingMode = 0x0324;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0325;

		///<summary><![CDATA[float]]></summary>
		public const int LedgeCheckThreshold = 0x0328;

		///<summary><![CDATA[float]]></summary>
		public const int JumpOutOfWaterPitch = 0x032C;

		///<summary><![CDATA[FFindFloorResult]]></summary>
		public const int CurrentFloor = 0x0330;

		///<summary><![CDATA[TEnumAsByte<EMovementMode>]]></summary>
		public const int DefaultLandMovementMode = 0x03C8;

		///<summary><![CDATA[TEnumAsByte<EMovementMode>]]></summary>
		public const int DefaultWaterMovementMode = 0x03C9;

		///<summary><![CDATA[TEnumAsByte<EMovementMode>]]></summary>
		public const int GroundMovementMode = 0x03CA;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData10 = 0x03CB;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMaintainHorizontalGroundVelocity = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bImpartBaseVelocityX = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bImpartBaseVelocityY = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bImpartBaseVelocityZ = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bImpartBaseAngularVelocity = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bJustTeleported = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetworkUpdateReceived = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNetworkMovementModeChanged = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreClientMovementErrorChecksAndCorrection = 0x03CD;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNotifyApex = 0x03CD;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCheatFlying = 0x03CD;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToCrouch = 0x03CD;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCrouchMaintainsBaseLocation = 0x03CD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData11 = 0x03CE;

		///<summary><![CDATA[TEnumAsByte<EStanceMode>]]></summary>
		public const int StanceMode = 0x03D0;

		///<summary><![CDATA[TEnumAsByte<EStanceMode>]]></summary>
		public const int WantsToStanceMode = 0x03D1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData12 = 0x03D2;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreBaseRotation = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFastAttachedMove = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysCheckFloor = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFlatBaseForFloorChecks = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPerformingJumpOff = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToLeaveNavWalking = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseRVOAvoidance = 0x03D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRequestedMoveUseAcceleration = 0x03D4;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData13 = 0x03D5;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasRequestedVelocity = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRequestedMoveWithMaxSpeed = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWasAvoidanceUpdated = 0x03E0;

		///<summary><![CDATA[unsigned char:2]]></summary>
		public const int UnknownData14 = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProjectNavMeshWalking = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProjectNavMeshOnBothWorldChannels = 0x03E0;

		///<summary><![CDATA[unsigned char[0x13]]]></summary>
		public const int UnknownData15 = 0x03E1;

		///<summary><![CDATA[float]]></summary>
		public const int AvoidanceConsiderationRadius = 0x03F4;

		///<summary><![CDATA[FVector]]></summary>
		public const int RequestedVelocity = 0x03F8;

		///<summary><![CDATA[int]]></summary>
		public const int AvoidanceUID = 0x0404;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int AvoidanceGroup = 0x0408;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int GroupsToAvoid = 0x040C;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int GroupsToIgnore = 0x0410;

		///<summary><![CDATA[float]]></summary>
		public const int AvoidanceWeight = 0x0414;

		///<summary><![CDATA[FVector]]></summary>
		public const int PendingLaunchVelocity = 0x0418;

		///<summary><![CDATA[unsigned char[0xA4]]]></summary>
		public const int UnknownData16 = 0x0424;

		///<summary><![CDATA[float]]></summary>
		public const int NavMeshProjectionInterval = 0x04C8;

		///<summary><![CDATA[float]]></summary>
		public const int NavMeshProjectionTimer = 0x04CC;

		///<summary><![CDATA[float]]></summary>
		public const int NavMeshProjectionInterpSpeed = 0x04D0;

		///<summary><![CDATA[float]]></summary>
		public const int NavMeshProjectionHeightScaleUp = 0x04D4;

		///<summary><![CDATA[float]]></summary>
		public const int NavMeshProjectionHeightScaleDown = 0x04D8;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData17 = 0x04DC;

		///<summary><![CDATA[FCharacterMovementComponentPostPhysicsTickFunction]]></summary>
		public const int PostPhysicsTickFunction = 0x04F8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData18 = 0x0550;

		///<summary><![CDATA[float]]></summary>
		public const int MinTimeBetweenTimeStampResets = 0x0560;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData19 = 0x0564;

		///<summary><![CDATA[FRootMotionSourceGroup]]></summary>
		public const int CurrentRootMotion = 0x0568;

		///<summary><![CDATA[unsigned char[0x98]]]></summary>
		public const int UnknownData20 = 0x0668;

		///<summary><![CDATA[FRootMotionMovementParams]]></summary>
		public const int RootMotionParams = 0x0700;

		///<summary><![CDATA[FVector]]></summary>
		public const int AnimRootMotionVelocity = 0x0740;

		///<summary><![CDATA[bool]]></summary>
		public const int bWasSimulatingRootMotion = 0x074C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData21 = 0x074D;

	}

	public class UVehicleWheel
	{
		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int CollisionMesh = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bDontCreateShape = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoAdjustCollisionSize = 0x0031;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0032;

		///<summary><![CDATA[FVector]]></summary>
		public const int Offset = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int ShapeRadius = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int ShapeWidth = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int Mass = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int DampingRate = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int SteerAngle = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int bAffectedByHandbrake = 0x0054;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0055;

		///<summary><![CDATA[UTireType *]]></summary>
		public const int TireType = 0x0058;

		///<summary><![CDATA[float]]></summary>
		public const int LatStiffMaxLoad = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int LatStiffValue = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int LongStiffValue = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionForceOffset = 0x006C;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionForceOffsetX = 0x0070;

		///<summary><![CDATA[FVector]]></summary>
		public const int SuspensionTravelDir = 0x0074;

		///<summary><![CDATA[FVector]]></summary>
		public const int TireForceOffset = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionMaxRaise = 0x008C;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionMaxDrop = 0x0090;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionNaturalFrequency = 0x0094;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionDampingRatio = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int MaxBrakeTorque = 0x009C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxHandBrakeTorque = 0x00A0;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int QueryChannel = 0x00A4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00A5;

		///<summary><![CDATA[UWheeledVehicleMovementComponent *]]></summary>
		public const int VehicleSim = 0x00A8;

		///<summary><![CDATA[int]]></summary>
		public const int WheelIndex = 0x00B0;

		///<summary><![CDATA[float]]></summary>
		public const int DebugLongSlip = 0x00B4;

		///<summary><![CDATA[float]]></summary>
		public const int DebugLatSlip = 0x00B8;

		///<summary><![CDATA[float]]></summary>
		public const int DebugNormalizedTireLoad = 0x00BC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x00C0;

		///<summary><![CDATA[float]]></summary>
		public const int DebugWheelTorque = 0x00C4;

		///<summary><![CDATA[float]]></summary>
		public const int DebugLongForce = 0x00C8;

		///<summary><![CDATA[float]]></summary>
		public const int DebugLatForce = 0x00CC;

		///<summary><![CDATA[FVector]]></summary>
		public const int Location = 0x00D0;

		///<summary><![CDATA[FVector]]></summary>
		public const int OldLocation = 0x00DC;

		///<summary><![CDATA[FVector]]></summary>
		public const int Velocity = 0x00E8;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData04 = 0x00F4;

	}

	public class UAnimInstance
	{
		///<summary><![CDATA[float]]></summary>
		public const int DeltaTime = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

		///<summary><![CDATA[USkeleton *]]></summary>
		public const int CurrentSkeleton = 0x0030;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData01 = 0x0038;

		///<summary><![CDATA[TEnumAsByte<ERootMotionMode>]]></summary>
		public const int RootMotionMode = 0x0078;

		///<summary><![CDATA[bool]]></summary>
		public const int bRunUpdatesInWorkerThreads = 0x0079;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanUseParallelUpdateAnimation = 0x007A;

		///<summary><![CDATA[bool]]></summary>
		public const int bWarnAboutBlueprintUsage = 0x007B;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x007C;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMontageBlendingOut = 0x0080;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMontageStarted = 0x0090;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMontageEnded = 0x00A0;

		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData03 = 0x00B0;

		///<summary><![CDATA[bool]]></summary>
		public const int bQueueMontageEvents = 0x0120;

		///<summary><![CDATA[unsigned char[0x18F]]]></summary>
		public const int UnknownData04 = 0x0121;

		///<summary><![CDATA[TArray<FAnimNotifyEvent>]]></summary>
		public const int ActiveAnimNotifyState = 0x02B0;

		///<summary><![CDATA[unsigned char[0x1D8]]]></summary>
		public const int UnknownData05 = 0x02C0;

	}

	public class UCameraComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int FieldOfView = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int OrthoWidth = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int OrthoNearClipPlane = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int OrthoFarClipPlane = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int AspectRatio = 0x0310;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainAspectRatio = 0x0314;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFieldOfViewForLOD = 0x0314;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockToHmd = 0x0314;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsePawnControlRotation = 0x0314;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0315;

		///<summary><![CDATA[TEnumAsByte<ECameraProjectionMode>]]></summary>
		public const int ProjectionMode = 0x0318;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0319;

		///<summary><![CDATA[float]]></summary>
		public const int PostProcessBlendWeight = 0x031C;

		///<summary><![CDATA[FPostProcessSettings]]></summary>
		public const int PostProcessSettings = 0x0320;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData02 = 0x0800;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseControllerViewRotation = 0x0858;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0859;

	}

	public class UCheatManager
	{
		///<summary><![CDATA[ADebugCameraController *]]></summary>
		public const int DebugCameraControllerRef = 0x0028;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DebugCameraControllerClass = 0x0030;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UEngine
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UFont *]]></summary>
		public const int TinyFont = 0x0030;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int TinyFontName = 0x0038;

		///<summary><![CDATA[UFont *]]></summary>
		public const int SmallFont = 0x0048;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int SmallFontName = 0x0050;

		///<summary><![CDATA[UFont *]]></summary>
		public const int MediumFont = 0x0060;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int MediumFontName = 0x0068;

		///<summary><![CDATA[UFont *]]></summary>
		public const int LargeFont = 0x0078;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int LargeFontName = 0x0080;

		///<summary><![CDATA[UFont *]]></summary>
		public const int SubtitleFont = 0x0090;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int SubtitleFontName = 0x0098;

		///<summary><![CDATA[TArray<UFont * >]]></summary>
		public const int AdditionalFonts = 0x00A8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x00B8;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AdditionalFontNames = 0x00C0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ConsoleClass = 0x00D0;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int ConsoleClassName = 0x00D8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GameViewportClientClass = 0x00E8;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GameViewportClientClassName = 0x00F0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LocalPlayerClass = 0x0100;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int LocalPlayerClassName = 0x0108;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WorldSettingsClass = 0x0118;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int WorldSettingsClassName = 0x0120;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int NavigationSystemClassName = 0x0130;

		///<summary><![CDATA[UClass *]]></summary>
		public const int NavigationSystemClass = 0x0140;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int AvoidanceManagerClassName = 0x0148;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AvoidanceManagerClass = 0x0158;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PhysicsCollisionHandlerClass = 0x0160;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int PhysicsCollisionHandlerClassName = 0x0168;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GameUserSettingsClassName = 0x0178;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GameUserSettingsClass = 0x0188;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int AIControllerClassName = 0x0190;

		///<summary><![CDATA[UGameUserSettings *]]></summary>
		public const int GameUserSettings = 0x01A0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LevelScriptActorClass = 0x01A8;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int LevelScriptActorClassName = 0x01B0;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int DefaultBlueprintBaseClassName = 0x01C0;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GameSingletonClassName = 0x01D0;

		///<summary><![CDATA[UObject *]]></summary>
		public const int GameSingleton = 0x01E0;

		///<summary><![CDATA[UTireType *]]></summary>
		public const int DefaultTireType = 0x01E8;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultTireTypeName = 0x01F0;

		///<summary><![CDATA[FString]]></summary>
		public const int PlayOnConsoleSaveDir = 0x0200;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DefaultTexture = 0x0210;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultTextureName = 0x0218;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int DefaultDiffuseTexture = 0x0228;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultDiffuseTextureName = 0x0230;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DefaultBSPVertexTexture = 0x0240;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultBSPVertexTextureName = 0x0248;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int HighFrequencyNoiseTexture = 0x0258;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int HighFrequencyNoiseTextureName = 0x0260;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DefaultBokehTexture = 0x0270;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultBokehTextureName = 0x0278;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int WireframeMaterial = 0x0288;

		///<summary><![CDATA[FString]]></summary>
		public const int WireframeMaterialName = 0x0290;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int DebugMeshMaterial = 0x02A0;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DebugMeshMaterialName = 0x02A8;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int LevelColorationLitMaterial = 0x02B8;

		///<summary><![CDATA[FString]]></summary>
		public const int LevelColorationLitMaterialName = 0x02C0;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int LevelColorationUnlitMaterial = 0x02D0;

		///<summary><![CDATA[FString]]></summary>
		public const int LevelColorationUnlitMaterialName = 0x02D8;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int LightingTexelDensityMaterial = 0x02E8;

		///<summary><![CDATA[FString]]></summary>
		public const int LightingTexelDensityName = 0x02F0;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int ShadedLevelColorationLitMaterial = 0x0300;

		///<summary><![CDATA[FString]]></summary>
		public const int ShadedLevelColorationLitMaterialName = 0x0308;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int ShadedLevelColorationUnlitMaterial = 0x0318;

		///<summary><![CDATA[FString]]></summary>
		public const int ShadedLevelColorationUnlitMaterialName = 0x0320;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int RemoveSurfaceMaterial = 0x0330;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int RemoveSurfaceMaterialName = 0x0338;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int VertexColorMaterial = 0x0348;

		///<summary><![CDATA[FString]]></summary>
		public const int VertexColorMaterialName = 0x0350;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int VertexColorViewModeMaterial_ColorOnly = 0x0360;

		///<summary><![CDATA[FString]]></summary>
		public const int VertexColorViewModeMaterialName_ColorOnly = 0x0368;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int VertexColorViewModeMaterial_AlphaAsColor = 0x0378;

		///<summary><![CDATA[FString]]></summary>
		public const int VertexColorViewModeMaterialName_AlphaAsColor = 0x0380;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int VertexColorViewModeMaterial_RedOnly = 0x0390;

		///<summary><![CDATA[FString]]></summary>
		public const int VertexColorViewModeMaterialName_RedOnly = 0x0398;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int VertexColorViewModeMaterial_GreenOnly = 0x03A8;

		///<summary><![CDATA[FString]]></summary>
		public const int VertexColorViewModeMaterialName_GreenOnly = 0x03B0;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int VertexColorViewModeMaterial_BlueOnly = 0x03C0;

		///<summary><![CDATA[FString]]></summary>
		public const int VertexColorViewModeMaterialName_BlueOnly = 0x03C8;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int ConstraintLimitMaterial = 0x03D8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialX = 0x03E0;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialXAxis = 0x03E8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialY = 0x03F0;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialYAxis = 0x03F8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialZ = 0x0400;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialZAxis = 0x0408;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int ConstraintLimitMaterialPrismatic = 0x0410;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int InvalidLightmapSettingsMaterial = 0x0418;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int InvalidLightmapSettingsMaterialName = 0x0420;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int PreviewShadowsIndicatorMaterial = 0x0430;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int PreviewShadowsIndicatorMaterialName = 0x0438;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int ArrowMaterial = 0x0448;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int ArrowMaterialName = 0x0450;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LightingOnlyBrightness = 0x0460;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int ShaderComplexityColors = 0x0470;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int QuadComplexityColors = 0x0480;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int LightComplexityColors = 0x0490;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int StationaryLightOverlapColors = 0x04A0;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int LODColorationColors = 0x04B0;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int HLODColorationColors = 0x04C0;

		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int StreamingAccuracyColors = 0x04D0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxPixelShaderAdditiveComplexityCount = 0x04E0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxES2PixelShaderAdditiveComplexityCount = 0x04E4;

		///<summary><![CDATA[float]]></summary>
		public const int MinLightMapDensity = 0x04E8;

		///<summary><![CDATA[float]]></summary>
		public const int IdealLightMapDensity = 0x04EC;

		///<summary><![CDATA[float]]></summary>
		public const int MaxLightMapDensity = 0x04F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderLightMapDensityGrayscale = 0x04F4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x04F5;

		///<summary><![CDATA[float]]></summary>
		public const int RenderLightMapDensityGrayscaleScale = 0x04F8;

		///<summary><![CDATA[float]]></summary>
		public const int RenderLightMapDensityColorScale = 0x04FC;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LightMapDensityVertexMappedColor = 0x0500;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LightMapDensitySelectedColor = 0x0510;

		///<summary><![CDATA[TArray<FStatColorMapping>]]></summary>
		public const int StatColorMappings = 0x0520;

		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int DefaultPhysMaterial = 0x0530;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultPhysMaterialName = 0x0538;

		///<summary><![CDATA[TArray<FGameNameRedirect>]]></summary>
		public const int ActiveGameNameRedirects = 0x0548;

		///<summary><![CDATA[TArray<FClassRedirect>]]></summary>
		public const int ActiveClassRedirects = 0x0558;

		///<summary><![CDATA[TArray<FPluginRedirect>]]></summary>
		public const int ActivePluginRedirects = 0x0568;

		///<summary><![CDATA[TArray<FStructRedirect>]]></summary>
		public const int ActiveStructRedirects = 0x0578;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int PreIntegratedSkinBRDFTexture = 0x0588;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int PreIntegratedSkinBRDFTextureName = 0x0590;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int MiniFontTexture = 0x05A0;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int MiniFontTextureName = 0x05A8;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int WeightMapPlaceholderTexture = 0x05B8;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int WeightMapPlaceholderTextureName = 0x05C0;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int LightMapDensityTexture = 0x05D0;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int LightMapDensityTextureName = 0x05D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x05E8;

		///<summary><![CDATA[UGameViewportClient *]]></summary>
		public const int GameViewport = 0x05F0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int DeferredCommands = 0x05F8;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData04 = 0x0608;

		///<summary><![CDATA[int]]></summary>
		public const int TickCycles = 0x0670;

		///<summary><![CDATA[int]]></summary>
		public const int GameCycles = 0x0674;

		///<summary><![CDATA[int]]></summary>
		public const int ClientCycles = 0x0678;

		///<summary><![CDATA[float]]></summary>
		public const int NearClipPlane = 0x067C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHardwareSurveyEnabled = 0x0680;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSubtitlesEnabled = 0x0680;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSubtitlesForcedOff = 0x0680;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0681;

		///<summary><![CDATA[int]]></summary>
		public const int MaximumLoopIterationCount = 0x0684;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanBlueprintsTickByDefault = 0x0688;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOptimizeAnimBlueprintMemberVariableAccess = 0x0688;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableEditorPSysRealtimeLOD = 0x0688;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData06 = 0x0688;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSmoothFrameRate = 0x0688;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFixedFrameRate = 0x0688;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x0689;

		///<summary><![CDATA[float]]></summary>
		public const int FixedFrameRate = 0x068C;

		///<summary><![CDATA[FFloatRange]]></summary>
		public const int SmoothedFrameRateRange = 0x0690;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCheckForMultiplePawnsSpawnedInAFrame = 0x06A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x06A1;

		///<summary><![CDATA[int]]></summary>
		public const int NumPawnsAllowedToBeSpawnedInAFrame = 0x06A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldGenerateLowQualityLightmaps = 0x06A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x06A9;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_WorldBox = 0x06AC;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_BrushWire = 0x06B0;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_AddWire = 0x06B4;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_SubtractWire = 0x06B8;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_SemiSolidWire = 0x06BC;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_NonSolidWire = 0x06C0;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_WireBackground = 0x06C4;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_ScaleBoxHi = 0x06C8;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_VolumeCollision = 0x06CC;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_BSPCollision = 0x06D0;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_OrthoBackground = 0x06D4;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_Volume = 0x06D8;

		///<summary><![CDATA[FColor]]></summary>
		public const int C_BrushShape = 0x06DC;

		///<summary><![CDATA[float]]></summary>
		public const int StreamingDistanceFactor = 0x06E0;

		///<summary><![CDATA[TEnumAsByte<ETransitionType>]]></summary>
		public const int TransitionType = 0x06E4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData10 = 0x06E5;

		///<summary><![CDATA[FString]]></summary>
		public const int TransitionDescription = 0x06E8;

		///<summary><![CDATA[FString]]></summary>
		public const int TransitionGameMode = 0x06F8;

		///<summary><![CDATA[float]]></summary>
		public const int MeshLODRange = 0x0708;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowMatureLanguage = 0x070C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData11 = 0x070D;

		///<summary><![CDATA[float]]></summary>
		public const int CameraRotationThreshold = 0x0710;

		///<summary><![CDATA[float]]></summary>
		public const int CameraTranslationThreshold = 0x0714;

		///<summary><![CDATA[float]]></summary>
		public const int PrimitiveProbablyVisibleTime = 0x0718;

		///<summary><![CDATA[float]]></summary>
		public const int MaxOcclusionPixelsFraction = 0x071C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPauseOnLossOfFocus = 0x0720;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData12 = 0x0721;

		///<summary><![CDATA[int]]></summary>
		public const int MaxParticleResize = 0x0724;

		///<summary><![CDATA[int]]></summary>
		public const int MaxParticleResizeWarn = 0x0728;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData13 = 0x072C;

		///<summary><![CDATA[TArray<FDropNoteInfo>]]></summary>
		public const int PendingDroppedNotes = 0x0730;

		///<summary><![CDATA[FRigidBodyErrorCorrection]]></summary>
		public const int PhysicErrorCorrection = 0x0740;

		///<summary><![CDATA[float]]></summary>
		public const int NetClientTicksPerSecond = 0x075C;

		///<summary><![CDATA[float]]></summary>
		public const int DisplayGamma = 0x0760;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredFrameRate = 0x0764;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DefaultSelectedMaterialColor = 0x0768;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SelectedMaterialColor = 0x0778;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SelectionOutlineColor = 0x0788;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SubduedSelectionOutlineColor = 0x0798;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SelectedMaterialColorOverride = 0x07A8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsOverridingSelectedColor = 0x07B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData14 = 0x07B9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableOnScreenDebugMessages = 0x07BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableOnScreenDebugMessagesDisplay = 0x07BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSuppressMapWarnings = 0x07BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableAILogging = 0x07BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData15 = 0x07BD;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int bEnableVisualLogRecordingOnStart = 0x07C0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData16 = 0x07C4;

		///<summary><![CDATA[int]]></summary>
		public const int ScreenSaverInhibitorSemaphore = 0x07C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockReadOnlyLevels = 0x07CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData17 = 0x07CD;

		///<summary><![CDATA[FString]]></summary>
		public const int ParticleEventManagerClassPath = 0x07D0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData18 = 0x07E0;

		///<summary><![CDATA[float]]></summary>
		public const int SelectionHighlightIntensity = 0x07F0;

		///<summary><![CDATA[float]]></summary>
		public const int SelectionMeshSectionHighlightIntensity = 0x07F4;

		///<summary><![CDATA[float]]></summary>
		public const int BSPSelectionHighlightIntensity = 0x07F8;

		///<summary><![CDATA[float]]></summary>
		public const int HoverHighlightIntensity = 0x07FC;

		///<summary><![CDATA[float]]></summary>
		public const int SelectionHighlightIntensityBillboards = 0x0800;

		///<summary><![CDATA[unsigned char[0x3DC]]]></summary>
		public const int UnknownData19 = 0x0804;

		///<summary><![CDATA[TArray<FNetDriverDefinition>]]></summary>
		public const int NetDriverDefinitions = 0x0BE0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int ServerActors = 0x0BF0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int RuntimeServerActors = 0x0C00;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStartedLoadMapMovie = 0x0C10;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData20 = 0x0C11;

		///<summary><![CDATA[int]]></summary>
		public const int NextWorldContextHandle = 0x0C28;

		///<summary><![CDATA[unsigned char[0xD4]]]></summary>
		public const int UnknownData21 = 0x0C2C;

	}

	public class UScriptViewportClient
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UGameViewportClient
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0030;

		///<summary><![CDATA[UConsole *]]></summary>
		public const int ViewportConsole = 0x0038;

		///<summary><![CDATA[TArray<FDebugDisplayProperty>]]></summary>
		public const int DebugProperties = 0x0040;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData01 = 0x0050;

		///<summary><![CDATA[UWorld *]]></summary>
		public const int World = 0x0080;

		///<summary><![CDATA[UGameInstance *]]></summary>
		public const int GameInstance = 0x0088;

		///<summary><![CDATA[unsigned char[0x400]]]></summary>
		public const int UnknownData02 = 0x0090;

	}

	public class UConsole
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[ULocalPlayer *]]></summary>
		public const int ConsoleTargetPlayer = 0x0038;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DefaultTexture_Black = 0x0040;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DefaultTexture_White = 0x0048;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0050;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HistoryBuffer = 0x0068;

		///<summary><![CDATA[unsigned char[0xB8]]]></summary>
		public const int UnknownData02 = 0x0078;

	}

	public class USkinnedMeshComponent
	{
		///<summary><![CDATA[USkeletalMesh *]]></summary>
		public const int SkeletalMesh = 0x0780;

		///<summary><![CDATA[TWeakObjectPtr<USkinnedMeshComponent>]]></summary>
		public const int MasterPoseComponent = 0x0788;

		///<summary><![CDATA[unsigned char[0x54]]]></summary>
		public const int UnknownData00 = 0x0790;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseBoundsFromMasterPoseComponent = 0x07E4;

		///<summary><![CDATA[unsigned char[0x23]]]></summary>
		public const int UnknownData01 = 0x07E5;

		///<summary><![CDATA[UPhysicsAsset *]]></summary>
		public const int PhysicsAssetOverride = 0x0808;

		///<summary><![CDATA[int]]></summary>
		public const int ForcedLodModel = 0x0810;

		///<summary><![CDATA[int]]></summary>
		public const int MinLodModel = 0x0814;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0818;

		///<summary><![CDATA[TArray<FSkelMeshComponentLODInfo>]]></summary>
		public const int LODInfo = 0x0828;

		///<summary><![CDATA[float]]></summary>
		public const int StreamingDistanceMultiplier = 0x0838;

		///<summary><![CDATA[FColor]]></summary>
		public const int WireframeColor = 0x083C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceWireframe = 0x0840;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisplayBones = 0x0840;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableMorphTarget = 0x0840;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHideSkin = 0x0840;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData03 = 0x0841;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPerBoneMotionBlur = 0x0858;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bComponentUseFixedSkelBounds = 0x0858;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConsiderAllBodiesForBounds = 0x0858;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0859;

		///<summary><![CDATA[TEnumAsByte<EMeshComponentUpdateFlag>]]></summary>
		public const int MeshComponentUpdateFlag = 0x085C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x085D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceMeshObjectUpdate = 0x0860;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData06 = 0x0860;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanHighlightSelectedSections = 0x0860;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRecentlyRendered = 0x0860;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x0861;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int CustomSortAlternateIndexMode = 0x0864;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x0865;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastCapsuleDirectShadow = 0x0868;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastCapsuleIndirectShadow = 0x0868;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0869;

		///<summary><![CDATA[float]]></summary>
		public const int CapsuleIndirectShadowMinVisibility = 0x086C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCPUSkinning = 0x0870;

		///<summary><![CDATA[unsigned char[0x13]]]></summary>
		public const int UnknownData10 = 0x0871;

		///<summary><![CDATA[FBoxSphereBounds]]></summary>
		public const int CachedLocalBounds = 0x0884;

		///<summary><![CDATA[bool]]></summary>
		public const int bCachedLocalBoundsUpToDate = 0x08A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableUpdateRateOptimizations = 0x08A1;

		///<summary><![CDATA[bool]]></summary>
		public const int bDisplayDebugUpdateRateOptimizations = 0x08A2;

		///<summary><![CDATA[unsigned char[0x4D]]]></summary>
		public const int UnknownData11 = 0x08A3;

	}

	public class UDestructibleComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFractureEffectOverride = 0x08F0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x08F1;

		///<summary><![CDATA[TArray<FFractureEffect>]]></summary>
		public const int FractureEffects = 0x08F8;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableHardSleeping = 0x0908;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0909;

		///<summary><![CDATA[float]]></summary>
		public const int LargeChunkThreshold = 0x090C;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0910;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnComponentFracture = 0x0920;

		///<summary><![CDATA[unsigned char[0x90]]]></summary>
		public const int UnknownData03 = 0x0930;

	}

	public class AStaticMeshActor
	{
		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int StaticMeshComponent = 0x03A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bStaticMeshReplicateMovement = 0x03A8;

		///<summary><![CDATA[TEnumAsByte<ENavDataGatheringMode>]]></summary>
		public const int NavigationGeometryGatheringMode = 0x03A9;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x03AA;

	}

	public class UGameEngine
	{
		///<summary><![CDATA[UGameInstance *]]></summary>
		public const int GameInstance = 0x0D00;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData00 = 0x0D08;

	}

	public class AGameModeBase
	{
		///<summary><![CDATA[FString]]></summary>
		public const int OptionsString = 0x03A0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GameSessionClass = 0x03B0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GameStateClass = 0x03B8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PlayerControllerClass = 0x03C0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PlayerStateClass = 0x03C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int HUDClass = 0x03D0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultPawnClass = 0x03D8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SpectatorClass = 0x03E0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ReplaySpectatorPlayerControllerClass = 0x03E8;

		///<summary><![CDATA[AGameSession *]]></summary>
		public const int GameSession = 0x03F0;

		///<summary><![CDATA[AGameStateBase *]]></summary>
		public const int GameState = 0x03F8;

		///<summary><![CDATA[FText]]></summary>
		public const int DefaultPlayerName = 0x0400;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseSeamlessTravel = 0x0418;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStartPlayersAsSpectators = 0x0418;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPauseable = 0x0418;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData00 = 0x0419;

	}

	public class AGameMode
	{
		///<summary><![CDATA[FName]]></summary>
		public const int MatchState = 0x0430;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDelayedStart = 0x0438;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0439;

		///<summary><![CDATA[int]]></summary>
		public const int NumSpectators = 0x043C;

		///<summary><![CDATA[int]]></summary>
		public const int NumPlayers = 0x0440;

		///<summary><![CDATA[int]]></summary>
		public const int NumBots = 0x0444;

		///<summary><![CDATA[float]]></summary>
		public const int MinRespawnDelay = 0x0448;

		///<summary><![CDATA[int]]></summary>
		public const int NumTravellingPlayers = 0x044C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int EngineMessageClass = 0x0450;

		///<summary><![CDATA[TArray<APlayerState * >]]></summary>
		public const int InactivePlayerArray = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int InactivePlayerStateLifeSpan = 0x0468;

		///<summary><![CDATA[bool]]></summary>
		public const int bHandleDedicatedServerReplays = 0x046C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x046D;

	}

	public class UGameInstance
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<ULocalPlayer * >]]></summary>
		public const int LocalPlayers = 0x0038;

		///<summary><![CDATA[UOnlineSession *]]></summary>
		public const int OnlineSession = 0x0048;

		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData01 = 0x0050;

	}

	public class AGameSession
	{
		///<summary><![CDATA[int]]></summary>
		public const int MaxSpectators = 0x03A0;

		///<summary><![CDATA[int]]></summary>
		public const int MaxPlayers = 0x03A4;

		///<summary><![CDATA[int]]></summary>
		public const int MaxPartySize = 0x03A8;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int MaxSplitscreensPerConnection = 0x03AC;

		///<summary><![CDATA[bool]]></summary>
		public const int bRequiresPushToTalk = 0x03AD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03AE;

		///<summary><![CDATA[FName]]></summary>
		public const int SessionName = 0x03B0;

	}

	public class AGameStateBase
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int GameModeClass = 0x03A0;

		///<summary><![CDATA[AGameModeBase *]]></summary>
		public const int AuthorityGameMode = 0x03A8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SpectatorClass = 0x03B0;

		///<summary><![CDATA[TArray<APlayerState * >]]></summary>
		public const int PlayerArray = 0x03B8;

		///<summary><![CDATA[bool]]></summary>
		public const int bReplicatedHasBegunPlay = 0x03C8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03C9;

		///<summary><![CDATA[float]]></summary>
		public const int ReplicatedWorldTimeSeconds = 0x03CC;

		///<summary><![CDATA[float]]></summary>
		public const int ServerWorldTimeSecondsDelta = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int ServerWorldTimeSecondsUpdateFrequency = 0x03D4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03D8;

	}

	public class AGameState
	{
		///<summary><![CDATA[FName]]></summary>
		public const int MatchState = 0x03E0;

		///<summary><![CDATA[FName]]></summary>
		public const int PreviousMatchState = 0x03E8;

		///<summary><![CDATA[int]]></summary>
		public const int ElapsedTime = 0x03F0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x03F4;

	}

	public class UGameUserSettings
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bUseVSync = 0x0028;

		///<summary><![CDATA[unsigned char[0x4F]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int ResolutionSizeX = 0x0078;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int ResolutionSizeY = 0x007C;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int LastUserConfirmedResolutionSizeX = 0x0080;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int LastUserConfirmedResolutionSizeY = 0x0084;

		///<summary><![CDATA[int]]></summary>
		public const int WindowPosX = 0x0088;

		///<summary><![CDATA[int]]></summary>
		public const int WindowPosY = 0x008C;

		///<summary><![CDATA[int]]></summary>
		public const int FullscreenMode = 0x0090;

		///<summary><![CDATA[int]]></summary>
		public const int LastConfirmedFullscreenMode = 0x0094;

		///<summary><![CDATA[int]]></summary>
		public const int PreferredFullscreenMode = 0x0098;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int Version = 0x009C;

		///<summary><![CDATA[int]]></summary>
		public const int AudioQualityLevel = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int FrameRateLimit = 0x00A4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x00A8;

		///<summary><![CDATA[int]]></summary>
		public const int DesiredScreenWidth = 0x00AC;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseDesiredScreenHeight = 0x00B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00B1;

		///<summary><![CDATA[int]]></summary>
		public const int DesiredScreenHeight = 0x00B4;

		///<summary><![CDATA[float]]></summary>
		public const int LastRecommendedScreenWidth = 0x00B8;

		///<summary><![CDATA[float]]></summary>
		public const int LastRecommendedScreenHeight = 0x00BC;

		///<summary><![CDATA[float]]></summary>
		public const int LastCPUBenchmarkResult = 0x00C0;

		///<summary><![CDATA[float]]></summary>
		public const int LastGPUBenchmarkResult = 0x00C4;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int LastCPUBenchmarkSteps = 0x00C8;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int LastGPUBenchmarkSteps = 0x00D8;

		///<summary><![CDATA[float]]></summary>
		public const int LastGPUBenchmarkMultiplier = 0x00E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x00EC;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnGameUserSettingsUINeedsUpdate = 0x00F0;

	}

	public class UInstancedStaticMeshComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0810;

		///<summary><![CDATA[int]]></summary>
		public const int InstancingRandomSeed = 0x0818;

		///<summary><![CDATA[int]]></summary>
		public const int InstanceStartCullDistance = 0x081C;

		///<summary><![CDATA[int]]></summary>
		public const int InstanceEndCullDistance = 0x0820;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0824;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int InstanceReorderTable = 0x0828;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int RemovedInstances = 0x0838;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData02 = 0x0848;

		///<summary><![CDATA[UPhysicsSerializer *]]></summary>
		public const int PhysicsSerializer = 0x08A0;

		///<summary><![CDATA[int]]></summary>
		public const int NumPendingLightmaps = 0x08A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x08AC;

		///<summary><![CDATA[TArray<FInstancedStaticMeshMappingInfo>]]></summary>
		public const int CachedMappings = 0x08B0;

	}

	public class UHierarchicalInstancedStaticMeshComponent
	{
		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData00 = 0x08C0;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int SortedInstances = 0x0928;

		///<summary><![CDATA[int]]></summary>
		public const int NumBuiltInstances = 0x0938;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x093C;

		///<summary><![CDATA[FBox]]></summary>
		public const int BuiltInstanceBounds = 0x0940;

		///<summary><![CDATA[FBox]]></summary>
		public const int UnbuiltInstanceBounds = 0x095C;

		///<summary><![CDATA[TArray<FBox>]]></summary>
		public const int UnbuiltInstanceBoundsList = 0x0978;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableDensityScaling = 0x0988;

		///<summary><![CDATA[unsigned char[0x27]]]></summary>
		public const int UnknownData02 = 0x0989;

		///<summary><![CDATA[int]]></summary>
		public const int OcclusionLayerNumNodes = 0x09B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x09B4;

		///<summary><![CDATA[bool]]></summary>
		public const int bDisableCollision = 0x09B7;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData04 = 0x09B8;

	}

	public class ALevelScriptActor
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInputEnabled = 0x03A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A1;

	}

	public class UPlayer
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[APlayerController *]]></summary>
		public const int PlayerController = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentNetSpeed = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int ConfiguredInternetSpeed = 0x003C;

		///<summary><![CDATA[int]]></summary>
		public const int ConfiguredLanSpeed = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0044;

	}

	public class ULocalPlayer
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0048;

		///<summary><![CDATA[UGameViewportClient *]]></summary>
		public const int ViewportClient = 0x0058;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x0060;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PendingLevelPlayerControllerClass = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSentSplitJoin = 0x0088;

		///<summary><![CDATA[unsigned char[0x107]]]></summary>
		public const int UnknownData02 = 0x0089;

	}

	public class APhysicsVolume
	{
		///<summary><![CDATA[float]]></summary>
		public const int TerminalVelocity = 0x03D8;

		///<summary><![CDATA[int]]></summary>
		public const int Priority = 0x03DC;

		///<summary><![CDATA[float]]></summary>
		public const int FluidFriction = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWaterVolume = 0x03E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPhysicsOnContact = 0x03E4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03E5;

	}

	public class APlayerCameraManager
	{
		///<summary><![CDATA[APlayerController *]]></summary>
		public const int PCOwner = 0x03A0;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int TransformComponent = 0x03A8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultFOV = 0x03B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03BC;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultOrthoWidth = 0x03C0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x03C4;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultAspectRatio = 0x03C8;

		///<summary><![CDATA[unsigned char[0x44]]]></summary>
		public const int UnknownData03 = 0x03CC;

		///<summary><![CDATA[FCameraCacheEntry]]></summary>
		public const int CameraCache = 0x0410;

		///<summary><![CDATA[FCameraCacheEntry]]></summary>
		public const int LastFrameCameraCache = 0x0950;

		///<summary><![CDATA[FTViewTarget]]></summary>
		public const int ViewTarget = 0x0E90;

		///<summary><![CDATA[FTViewTarget]]></summary>
		public const int PendingViewTarget = 0x13E0;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData04 = 0x1930;

		///<summary><![CDATA[TArray<UCameraModifier * >]]></summary>
		public const int ModifierList = 0x1948;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int DefaultModifiers = 0x1958;

		///<summary><![CDATA[float]]></summary>
		public const int FreeCamDistance = 0x1968;

		///<summary><![CDATA[FVector]]></summary>
		public const int FreeCamOffset = 0x196C;

		///<summary><![CDATA[FVector]]></summary>
		public const int ViewTargetOffset = 0x1978;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData05 = 0x1984;

		///<summary><![CDATA[TArray<AEmitterCameraLensEffectBase * >]]></summary>
		public const int CameraLensEffects = 0x1998;

		///<summary><![CDATA[UCameraModifier_CameraShake *]]></summary>
		public const int CachedCameraShakeMod = 0x19A8;

		///<summary><![CDATA[UCameraAnimInst * [0x8]]]></summary>
		public const int AnimInstPool = 0x19B0;

		///<summary><![CDATA[TArray<FPostProcessSettings>]]></summary>
		public const int PostProcessBlendCache = 0x19F0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData06 = 0x1A00;

		///<summary><![CDATA[TArray<UCameraAnimInst * >]]></summary>
		public const int ActiveAnims = 0x1A10;

		///<summary><![CDATA[TArray<UCameraAnimInst * >]]></summary>
		public const int FreeAnims = 0x1A20;

		///<summary><![CDATA[ACameraActor *]]></summary>
		public const int AnimCameraActor = 0x1A30;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsOrthographic = 0x1A38;

		///<summary><![CDATA[unsigned char:5]]></summary>
		public const int UnknownData07 = 0x1A38;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseClientSideCameraUpdates = 0x1A38;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x1A39;

		///<summary><![CDATA[float]]></summary>
		public const int ViewPitchMin = 0x1A3C;

		///<summary><![CDATA[float]]></summary>
		public const int ViewPitchMax = 0x1A40;

		///<summary><![CDATA[float]]></summary>
		public const int ViewYawMin = 0x1A44;

		///<summary><![CDATA[float]]></summary>
		public const int ViewYawMax = 0x1A48;

		///<summary><![CDATA[float]]></summary>
		public const int ViewRollMin = 0x1A4C;

		///<summary><![CDATA[float]]></summary>
		public const int ViewRollMax = 0x1A50;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData09 = 0x1A54;

	}

	public class APlayerState
	{
		///<summary><![CDATA[float]]></summary>
		public const int Score = 0x03A0;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int Ping = 0x03A4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03A5;

		///<summary><![CDATA[FString]]></summary>
		public const int PlayerName = 0x03A8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x03B8;

		///<summary><![CDATA[int]]></summary>
		public const int PlayerId = 0x03C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSpectator = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOnlySpectator = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsABot = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData02 = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsInactive = 0x03CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFromPreviousLevel = 0x03CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x03CD;

		///<summary><![CDATA[int]]></summary>
		public const int StartTime = 0x03D0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x03D4;

		///<summary><![CDATA[UClass *]]></summary>
		public const int EngineMessageClass = 0x03D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x03E0;

		///<summary><![CDATA[FString]]></summary>
		public const int SavedNetworkAddress = 0x03E8;

		///<summary><![CDATA[FUniqueNetIdRepl]]></summary>
		public const int UniqueId = 0x03F8;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData06 = 0x0410;

	}

	public class UShapeComponent
	{
		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int ShapeBodySetup = 0x06D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawOnlyIfSelected = 0x06D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldCollideWhenPlacing = 0x06D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDynamicObstacle = 0x06D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x06D9;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AreaClass = 0x06E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x06E8;

	}

	public class UBoxComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x06F0;

	}

	public class USceneCaptureComponent
	{
		///<summary><![CDATA[TArray<TWeakObjectPtr<UPrimitiveComponent>>]]></summary>
		public const int HiddenComponents = 0x0300;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int HiddenActors = 0x0310;

		///<summary><![CDATA[TArray<TWeakObjectPtr<UPrimitiveComponent>>]]></summary>
		public const int ShowOnlyComponents = 0x0320;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int ShowOnlyActors = 0x0330;

		///<summary><![CDATA[bool]]></summary>
		public const int bCaptureEveryFrame = 0x0340;

		///<summary><![CDATA[bool]]></summary>
		public const int bCaptureOnMovement = 0x0341;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0342;

		///<summary><![CDATA[float]]></summary>
		public const int MaxViewDistanceOverride = 0x0344;

		///<summary><![CDATA[TArray<FEngineShowFlagsSetting>]]></summary>
		public const int ShowFlagSettings = 0x0348;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData01 = 0x0358;

	}

	public class USceneCaptureComponent2D
	{
		///<summary><![CDATA[float]]></summary>
		public const int OrthoWidth = 0x03C0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03C4;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int TextureTarget = 0x03C8;

		///<summary><![CDATA[TEnumAsByte<ESceneCaptureSource>]]></summary>
		public const int CaptureSource = 0x03D0;

		///<summary><![CDATA[TEnumAsByte<ESceneCaptureCompositeMode>]]></summary>
		public const int CompositeMode = 0x03D1;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData01 = 0x03D2;

		///<summary><![CDATA[FPostProcessSettings]]></summary>
		public const int PostProcessSettings = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int PostProcessBlendWeight = 0x08C0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData02 = 0x08C4;

	}

	public class ADefaultPawn
	{
		///<summary><![CDATA[float]]></summary>
		public const int BaseTurnRate = 0x0400;

		///<summary><![CDATA[float]]></summary>
		public const int BaseLookUpRate = 0x0404;

		///<summary><![CDATA[UPawnMovementComponent *]]></summary>
		public const int MovementComponent = 0x0408;

		///<summary><![CDATA[USphereComponent *]]></summary>
		public const int CollisionComponent = 0x0410;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int MeshComponent = 0x0418;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAddDefaultMovementBindings = 0x0420;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0421;

	}

	public class UFloatingPawnMovement
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxSpeed = 0x0180;

		///<summary><![CDATA[float]]></summary>
		public const int Acceleration = 0x0184;

		///<summary><![CDATA[float]]></summary>
		public const int Deceleration = 0x0188;

		///<summary><![CDATA[float]]></summary>
		public const int TurningBoost = 0x018C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPositionCorrected = 0x0190;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0191;

	}

	public class USpectatorPawnMovement
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreTimeDilation = 0x0198;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0199;

	}

	public class USplineComponent
	{
		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x06D0;

		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int SplineInfo = 0x0728;

		///<summary><![CDATA[FInterpCurveQuat]]></summary>
		public const int SplineRotInfo = 0x0740;

		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int SplineScaleInfo = 0x0758;

		///<summary><![CDATA[FInterpCurveFloat]]></summary>
		public const int SplineReparamTable = 0x0770;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowSplineEditingPerInstance = 0x0788;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0789;

		///<summary><![CDATA[int]]></summary>
		public const int ReparamStepsPerSegment = 0x078C;

		///<summary><![CDATA[float]]></summary>
		public const int Duration = 0x0790;

		///<summary><![CDATA[bool]]></summary>
		public const int bStationaryEndpoints = 0x0794;

		///<summary><![CDATA[bool]]></summary>
		public const int bSplineHasBeenEdited = 0x0795;

		///<summary><![CDATA[bool]]></summary>
		public const int bModifiedByConstructionScript = 0x0796;

		///<summary><![CDATA[bool]]></summary>
		public const int bInputSplinePointsToConstructionScript = 0x0797;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawDebug = 0x0798;

		///<summary><![CDATA[bool]]></summary>
		public const int bClosedLoop = 0x0799;

		///<summary><![CDATA[bool]]></summary>
		public const int bLoopPositionOverride = 0x079A;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x079B;

		///<summary><![CDATA[float]]></summary>
		public const int LoopPosition = 0x079C;

		///<summary><![CDATA[FVector]]></summary>
		public const int DefaultUpVector = 0x07A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x07AC;

	}

	public class UMaterialInterface
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[USubsurfaceProfile *]]></summary>
		public const int SubsurfaceProfile = 0x0030;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0038;

		///<summary><![CDATA[FLightmassMaterialInterfaceSettings]]></summary>
		public const int LightmassSettings = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0054;

		///<summary><![CDATA[TArray<FMaterialTextureInfo>]]></summary>
		public const int TextureStreamingData = 0x0058;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0068;

	}

	public class UMaterialInstance
	{
		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int PhysMaterial = 0x0070;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int Parent = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasStaticPermutationResource = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData00 = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideSubsurfaceProfile = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0081;

		///<summary><![CDATA[TArray<FFontParameterValue>]]></summary>
		public const int FontParameterValues = 0x0088;

		///<summary><![CDATA[TArray<FScalarParameterValue>]]></summary>
		public const int ScalarParameterValues = 0x0098;

		///<summary><![CDATA[TArray<FTextureParameterValue>]]></summary>
		public const int TextureParameterValues = 0x00A8;

		///<summary><![CDATA[TArray<FVectorParameterValue>]]></summary>
		public const int VectorParameterValues = 0x00B8;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideBaseProperties = 0x00C8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00C9;

		///<summary><![CDATA[FMaterialInstanceBasePropertyOverrides]]></summary>
		public const int BasePropertyOverrides = 0x00CC;

		///<summary><![CDATA[unsigned char[0xD0]]]></summary>
		public const int UnknownData03 = 0x00E0;

	}

	public class UMaterialExpression
	{
		///<summary><![CDATA[UMaterial *]]></summary>
		public const int Material = 0x0028;

		///<summary><![CDATA[UMaterialFunction *]]></summary>
		public const int Function = 0x0030;

		///<summary><![CDATA[FString]]></summary>
		public const int Desc = 0x0038;

		///<summary><![CDATA[FColor]]></summary>
		public const int BorderColor = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRealtimePreview = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNeedToUpdatePreview = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsParameterExpression = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCommentBubbleVisible = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowOutputNameOnPin = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHidePreviewWindow = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollapsed = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShaderInputData = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowInputs = 0x004D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowOutputs = 0x004D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x004E;

		///<summary><![CDATA[TArray<FExpressionOutput>]]></summary>
		public const int Outputs = 0x0050;

	}

	public class UBlueprintGeneratedClass
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumReplicatedProperties = 0x0228;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x022C;

		///<summary><![CDATA[TArray<UDynamicBlueprintBinding * >]]></summary>
		public const int DynamicBindingObjects = 0x0230;

		///<summary><![CDATA[TArray<UActorComponent * >]]></summary>
		public const int ComponentTemplates = 0x0240;

		///<summary><![CDATA[TArray<UTimelineTemplate * >]]></summary>
		public const int Timelines = 0x0250;

		///<summary><![CDATA[USimpleConstructionScript *]]></summary>
		public const int SimpleConstructionScript = 0x0260;

		///<summary><![CDATA[UInheritableComponentHandler *]]></summary>
		public const int InheritableComponentHandler = 0x0268;

		///<summary><![CDATA[UStructProperty *]]></summary>
		public const int UberGraphFramePointerProperty = 0x0270;

		///<summary><![CDATA[UFunction *]]></summary>
		public const int UberGraphFunction = 0x0278;

		///<summary><![CDATA[TArray<FEventGraphFastCallPair>]]></summary>
		public const int FastCallPairs = 0x0280;

		///<summary><![CDATA[bool]]></summary>
		public const int bHasInstrumentation = 0x0290;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0291;

		///<summary><![CDATA[TMap<FName,FBlueprintCookedComponentInstancingData>]]></summary>
		public const int CookedComponentInstancingData = 0x0298;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x02E8;

	}

	public class ACameraActor
	{
		///<summary><![CDATA[TEnumAsByte<EAutoReceiveInput>]]></summary>
		public const int AutoActivateForPlayer = 0x03A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A1;

		///<summary><![CDATA[UCameraComponent *]]></summary>
		public const int CameraComponent = 0x03A8;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int SceneComponent = 0x03B0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainAspectRatio = 0x03C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x03C1;

		///<summary><![CDATA[float]]></summary>
		public const int AspectRatio = 0x03C4;

		///<summary><![CDATA[float]]></summary>
		public const int FOVAngle = 0x03C8;

		///<summary><![CDATA[float]]></summary>
		public const int PostProcessBlendWeight = 0x03CC;

		///<summary><![CDATA[FPostProcessSettings]]></summary>
		public const int PostProcessSettings = 0x03D0;

	}

	public class UAISystemBase
	{
		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int AISystemClassName = 0x0028;

		///<summary><![CDATA[FName]]></summary>
		public const int AISystemModuleName = 0x0038;

		///<summary><![CDATA[bool]]></summary>
		public const int bInstantiateAISystemOnClient = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UUserDefinedStruct
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int Guid = 0x0098;

	}

	public class UNavigationQueryFilter
	{
		///<summary><![CDATA[TArray<FNavigationFilterArea>]]></summary>
		public const int Areas = 0x0028;

		///<summary><![CDATA[FNavigationFilterFlags]]></summary>
		public const int IncludeFlags = 0x0038;

		///<summary><![CDATA[FNavigationFilterFlags]]></summary>
		public const int ExcludeFlags = 0x003C;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

	}

	public class UModel
	{
		///<summary><![CDATA[unsigned char[0x550]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UEdGraphNode
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<UEdGraphPin_Deprecated * >]]></summary>
		public const int DeprecatedPins = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int NodePosX = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int NodePosY = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int NodeWidth = 0x0050;

		///<summary><![CDATA[int]]></summary>
		public const int NodeHeight = 0x0054;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasCompilerMessage = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0059;

		///<summary><![CDATA[FString]]></summary>
		public const int NodeComment = 0x0060;

		///<summary><![CDATA[bool]]></summary>
		public const int bCommentBubblePinned = 0x0070;

		///<summary><![CDATA[bool]]></summary>
		public const int bCommentBubbleVisible = 0x0071;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x0072;

		///<summary><![CDATA[int]]></summary>
		public const int ErrorType = 0x0074;

		///<summary><![CDATA[FString]]></summary>
		public const int ErrorMsg = 0x0078;

		///<summary><![CDATA[FGuid]]></summary>
		public const int NodeGuid = 0x0088;

		///<summary><![CDATA[TEnumAsByte<ENodeAdvancedPins>]]></summary>
		public const int AdvancedPinDisplay = 0x0098;

		///<summary><![CDATA[TEnumAsByte<ENodeEnabledState>]]></summary>
		public const int EnabledState = 0x0099;

		///<summary><![CDATA[bool]]></summary>
		public const int bUserSetEnabledState = 0x009A;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsNodeEnabled = 0x009B;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x009C;

	}

	public class UEdGraphPin_Deprecated
	{
		///<summary><![CDATA[FString]]></summary>
		public const int PinName = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int PinToolTip = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EEdGraphPinDirection>]]></summary>
		public const int Direction = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[FEdGraphPinType]]></summary>
		public const int PinType = 0x0050;

		///<summary><![CDATA[FString]]></summary>
		public const int DefaultValue = 0x00D0;

		///<summary><![CDATA[FString]]></summary>
		public const int AutogeneratedDefaultValue = 0x00E0;

		///<summary><![CDATA[UObject *]]></summary>
		public const int DefaultObject = 0x00F0;

		///<summary><![CDATA[FText]]></summary>
		public const int DefaultTextValue = 0x00F8;

		///<summary><![CDATA[TArray<UEdGraphPin_Deprecated * >]]></summary>
		public const int LinkedTo = 0x0110;

		///<summary><![CDATA[TArray<UEdGraphPin_Deprecated * >]]></summary>
		public const int SubPins = 0x0120;

		///<summary><![CDATA[UEdGraphPin_Deprecated *]]></summary>
		public const int ParentPin = 0x0130;

		///<summary><![CDATA[UEdGraphPin_Deprecated *]]></summary>
		public const int ReferencePassThroughConnection = 0x0138;

	}

	public class UBlueprintCore
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int SkeletonGeneratedClass = 0x0028;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GeneratedClass = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int bLegacyNeedToPurgeSkelRefs = 0x0038;

		///<summary><![CDATA[bool]]></summary>
		public const int bLegacyGeneratedClassIsAuthoritative = 0x0039;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x003A;

		///<summary><![CDATA[FGuid]]></summary>
		public const int BlueprintGuid = 0x003C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x004C;

	}

	public class UBlueprint
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRecompileOnLoad = 0x0050;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ParentClass = 0x0058;

		///<summary><![CDATA[UObject *]]></summary>
		public const int PRIVATE_InnermostPreviousCDO = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasBeenRegenerated = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsRegeneratingOnLoad = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0069;

		///<summary><![CDATA[USimpleConstructionScript *]]></summary>
		public const int SimpleConstructionScript = 0x0070;

		///<summary><![CDATA[TArray<UActorComponent * >]]></summary>
		public const int ComponentTemplates = 0x0078;

		///<summary><![CDATA[TArray<UTimelineTemplate * >]]></summary>
		public const int Timelines = 0x0088;

		///<summary><![CDATA[UInheritableComponentHandler *]]></summary>
		public const int InheritableComponentHandler = 0x0098;

		///<summary><![CDATA[TEnumAsByte<EBlueprintType>]]></summary>
		public const int BlueprintType = 0x00A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00A1;

		///<summary><![CDATA[int]]></summary>
		public const int BlueprintSystemVersion = 0x00A4;

		///<summary><![CDATA[unsigned char[0xE8]]]></summary>
		public const int UnknownData03 = 0x00A8;

	}

	public class UMapBuildDataRegistry
	{
		///<summary><![CDATA[TEnumAsByte<ELightingBuildQuality>]]></summary>
		public const int LevelLightingQuality = 0x0028;

		///<summary><![CDATA[unsigned char[0xF7]]]></summary>
		public const int UnknownData00 = 0x0029;

	}

	public class ULevel
	{
		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int AActors = 0x00A0;

		///<summary><![CDATA[UWorld *]]></summary>
		public const int OwningWorld = 0x00B0;

		///<summary><![CDATA[UModel *]]></summary>
		public const int Model = 0x00B8;

		///<summary><![CDATA[TArray<UModelComponent * >]]></summary>
		public const int ModelComponents = 0x00C0;

		///<summary><![CDATA[int]]></summary>
		public const int NumTextureStreamingUnbuiltComponents = 0x00D0;

		///<summary><![CDATA[int]]></summary>
		public const int NumTextureStreamingDirtyResources = 0x00D4;

		///<summary><![CDATA[ALevelScriptActor *]]></summary>
		public const int LevelScriptActor = 0x00D8;

		///<summary><![CDATA[ANavigationObjectBase *]]></summary>
		public const int NavListStart = 0x00E0;

		///<summary><![CDATA[ANavigationObjectBase *]]></summary>
		public const int NavListEnd = 0x00E8;

		///<summary><![CDATA[TArray<UNavigationDataChunk * >]]></summary>
		public const int NavDataChunks = 0x00F0;

		///<summary><![CDATA[float]]></summary>
		public const int LightmapTotalSize = 0x0100;

		///<summary><![CDATA[float]]></summary>
		public const int ShadowmapTotalSize = 0x0104;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int StaticNavigableGeometry = 0x0108;

		///<summary><![CDATA[TArray<FGuid>]]></summary>
		public const int StreamingTextureGuids = 0x0118;

		///<summary><![CDATA[unsigned char[0x90]]]></summary>
		public const int UnknownData01 = 0x0128;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsLightingScenario = 0x01B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x01B9;

		///<summary><![CDATA[FGuid]]></summary>
		public const int LevelBuildDataId = 0x01BC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x01CC;

		///<summary><![CDATA[UMapBuildDataRegistry *]]></summary>
		public const int MapBuildData = 0x01D0;

		///<summary><![CDATA[FIntVector]]></summary>
		public const int LightBuildLevelOffset = 0x01D8;

		///<summary><![CDATA[unsigned char:2]]></summary>
		public const int UnknownData04 = 0x01E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTextureStreamingRotationChanged = 0x01E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsVisible = 0x01E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLocked = 0x01E4;

		///<summary><![CDATA[unsigned char[0xFB]]]></summary>
		public const int UnknownData05 = 0x01E5;

		///<summary><![CDATA[AWorldSettings *]]></summary>
		public const int WorldSettings = 0x02E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData06 = 0x02E8;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x02F0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData07 = 0x0300;

	}

	public class AAmbientSound
	{
		///<summary><![CDATA[UAudioComponent *]]></summary>
		public const int AudioComponent = 0x03A0;

	}

	public class AAudioVolume
	{
		///<summary><![CDATA[float]]></summary>
		public const int Priority = 0x03D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x03DC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03DD;

		///<summary><![CDATA[FReverbSettings]]></summary>
		public const int Settings = 0x03E0;

		///<summary><![CDATA[FInteriorSettings]]></summary>
		public const int AmbientZoneSettings = 0x03F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x041C;

	}

	public class ACullDistanceVolume
	{
		///<summary><![CDATA[TArray<FCullDistanceSizePair>]]></summary>
		public const int CullDistances = 0x03D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x03E8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03E9;

		///<summary><![CDATA[float]]></summary>
		public const int CullDistanceForLODActor = 0x03EC;

		///<summary><![CDATA[float]]></summary>
		public const int CullDistanceForLODActorTooFar = 0x03F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseActorBound = 0x03F4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03F5;

		///<summary><![CDATA[float]]></summary>
		public const int IgnoreActorBoundSize = 0x03F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x03FC;

	}

	public class ALevelStreamingVolume
	{
		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int StreamingLevelNames = 0x03D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEditorPreVisOnly = 0x03E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisabled = 0x03E8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03E9;

		///<summary><![CDATA[TEnumAsByte<EStreamingVolumeUsage>]]></summary>
		public const int StreamingUsage = 0x03EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03ED;

	}

	public class ANavMeshBoundsVolume
	{
		///<summary><![CDATA[FNavAgentSelector]]></summary>
		public const int SupportedAgents = 0x03D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03DC;

	}

	public class ANavModifierVolume
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03D8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AreaClass = 0x03E0;

	}

	public class APainCausingVolume
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPainCausing = 0x03E8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03E9;

		///<summary><![CDATA[float]]></summary>
		public const int DamagePerSec = 0x03EC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageType = 0x03F0;

		///<summary><![CDATA[float]]></summary>
		public const int PainInterval = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEntryPain = 0x03FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int BACKUP_bPainCausing = 0x03FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03FD;

		///<summary><![CDATA[AController *]]></summary>
		public const int DamageInstigator = 0x0400;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0408;

	}

	public class APostProcessVolume
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03D8;

		///<summary><![CDATA[FPostProcessSettings]]></summary>
		public const int Settings = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int Priority = 0x08C0;

		///<summary><![CDATA[float]]></summary>
		public const int BlendRadius = 0x08C4;

		///<summary><![CDATA[float]]></summary>
		public const int BlendWeight = 0x08C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x08CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUnbound = 0x08CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x08CD;

	}

	public class APrecomputedVisibilityOverrideVolume
	{
		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int OverrideVisibleActors = 0x03D8;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int OverrideInvisibleActors = 0x03E8;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int OverrideInvisibleLevels = 0x03F8;

	}

	public class UCameraShake
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSingleInstance = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[float]]></summary>
		public const int OscillationDuration = 0x002C;

		///<summary><![CDATA[float]]></summary>
		public const int OscillationBlendInTime = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int OscillationBlendOutTime = 0x0034;

		///<summary><![CDATA[FROscillator]]></summary>
		public const int RotOscillation = 0x0038;

		///<summary><![CDATA[FVOscillator]]></summary>
		public const int LocOscillation = 0x005C;

		///<summary><![CDATA[FFOscillator]]></summary>
		public const int FOVOscillation = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int AnimPlayRate = 0x008C;

		///<summary><![CDATA[float]]></summary>
		public const int AnimScale = 0x0090;

		///<summary><![CDATA[float]]></summary>
		public const int AnimBlendInTime = 0x0094;

		///<summary><![CDATA[float]]></summary>
		public const int AnimBlendOutTime = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int RandomAnimSegmentDuration = 0x009C;

		///<summary><![CDATA[UCameraAnim *]]></summary>
		public const int Anim = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRandomAnimSegment = 0x00A8;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData01 = 0x00A9;

		///<summary><![CDATA[APlayerCameraManager *]]></summary>
		public const int CameraOwner = 0x00C0;

		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData02 = 0x00C8;

		///<summary><![CDATA[float]]></summary>
		public const int ShakeScale = 0x0148;

		///<summary><![CDATA[float]]></summary>
		public const int OscillatorTimeRemaining = 0x014C;

		///<summary><![CDATA[UCameraAnimInst *]]></summary>
		public const int AnimInst = 0x0150;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0158;

	}

	public class UInputComponent
	{
		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData00 = 0x00F8;

	}

	public class UCurveBase
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCurveFloat
	{
		///<summary><![CDATA[FRichCurve]]></summary>
		public const int FloatCurve = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsEventCurve = 0x00A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00A9;

	}

	public class UForceFeedbackEffect
	{
		///<summary><![CDATA[TArray<FForceFeedbackChannelDetails>]]></summary>
		public const int ChannelDetails = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int Duration = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class ADebugCameraController
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowSelectedInfo = 0x06D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsFrozenRendering = 0x06D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x06D1;

		///<summary><![CDATA[UDrawFrustumComponent *]]></summary>
		public const int DrawFrustum = 0x06D8;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x06E0;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedScale = 0x0700;

		///<summary><![CDATA[float]]></summary>
		public const int InitialMaxSpeed = 0x0704;

		///<summary><![CDATA[float]]></summary>
		public const int InitialAccel = 0x0708;

		///<summary><![CDATA[float]]></summary>
		public const int InitialDecel = 0x070C;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0710;

	}

	public class ADecalActor
	{
		///<summary><![CDATA[UDecalComponent *]]></summary>
		public const int Decal = 0x03A0;

	}

	public class ADestructibleActor
	{
		///<summary><![CDATA[UDestructibleComponent *]]></summary>
		public const int DestructibleComponent = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectNavigation = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A9;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnActorFracture = 0x03B0;

	}

	public class ADistanceFieldCapture
	{
		///<summary><![CDATA[UDistanceFieldCaptureComponent *]]></summary>
		public const int CaptureComponent = 0x03A0;

	}

	public class ADocumentationActor
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03A0;

	}

	public class AEmitter
	{
		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int ParticleSystemComponent = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDestroyOnSystemFinish = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPostUpdateTickGroup = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCurrentlyActive = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A9;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleSpawn = 0x03B0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleBurst = 0x03C0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleDeath = 0x03D0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleCollide = 0x03E0;

	}

	public class AEmitterCameraLensEffectBase
	{
		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int PS_CameraEffect = 0x03F0;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int PS_CameraEffectNonExtremeContent = 0x03F8;

		///<summary><![CDATA[APlayerCameraManager *]]></summary>
		public const int BaseCamera = 0x0400;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0408;

		///<summary><![CDATA[FTransform]]></summary>
		public const int RelativeTransform = 0x0410;

		///<summary><![CDATA[float]]></summary>
		public const int BaseFOV = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowMultipleInstances = 0x0444;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0445;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int EmittersToTreatAsSame = 0x0448;

		///<summary><![CDATA[float]]></summary>
		public const int DistFromCamera = 0x0458;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x045C;

	}

	public class AAtmosphericFog
	{
		///<summary><![CDATA[UAtmosphericFogComponent *]]></summary>
		public const int AtmosphericFogComponent = 0x03A0;

	}

	public class AExponentialHeightFog
	{
		///<summary><![CDATA[UExponentialHeightFogComponent *]]></summary>
		public const int Component = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A9;

	}

	public class AGameNetworkManager
	{
		///<summary><![CDATA[int]]></summary>
		public const int AdjustedNetSpeed = 0x03A0;

		///<summary><![CDATA[float]]></summary>
		public const int LastNetSpeedUpdateTime = 0x03A4;

		///<summary><![CDATA[int]]></summary>
		public const int TotalNetBandwidth = 0x03A8;

		///<summary><![CDATA[int]]></summary>
		public const int MinDynamicBandwidth = 0x03AC;

		///<summary><![CDATA[int]]></summary>
		public const int MaxDynamicBandwidth = 0x03B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsStandbyCheckingEnabled = 0x03B4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasStandbyCheatTriggered = 0x03B4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03B5;

		///<summary><![CDATA[float]]></summary>
		public const int StandbyRxCheatTime = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int StandbyTxCheatTime = 0x03BC;

		///<summary><![CDATA[int]]></summary>
		public const int BadPingThreshold = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int PercentMissingForRxStandby = 0x03C4;

		///<summary><![CDATA[float]]></summary>
		public const int PercentMissingForTxStandby = 0x03C8;

		///<summary><![CDATA[float]]></summary>
		public const int PercentForBadPing = 0x03CC;

		///<summary><![CDATA[float]]></summary>
		public const int JoinInProgressStandbyWaitTime = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int MoveRepSize = 0x03D4;

		///<summary><![CDATA[float]]></summary>
		public const int MAXPOSITIONERRORSQUARED = 0x03D8;

		///<summary><![CDATA[float]]></summary>
		public const int MAXNEARZEROVELOCITYSQUARED = 0x03DC;

		///<summary><![CDATA[float]]></summary>
		public const int CLIENTADJUSTUPDATECOST = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int MAXCLIENTUPDATEINTERVAL = 0x03E4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxMoveDeltaTime = 0x03E8;

		///<summary><![CDATA[bool]]></summary>
		public const int ClientAuthorativePosition = 0x03EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03ED;

		///<summary><![CDATA[float]]></summary>
		public const int ClientErrorUpdateRateLimit = 0x03F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bMovementTimeDiscrepancyDetection = 0x03F4;

		///<summary><![CDATA[bool]]></summary>
		public const int bMovementTimeDiscrepancyResolution = 0x03F5;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x03F6;

		///<summary><![CDATA[float]]></summary>
		public const int MovementTimeDiscrepancyMaxTimeMargin = 0x03F8;

		///<summary><![CDATA[float]]></summary>
		public const int MovementTimeDiscrepancyMinTimeMargin = 0x03FC;

		///<summary><![CDATA[float]]></summary>
		public const int MovementTimeDiscrepancyResolutionRate = 0x0400;

		///<summary><![CDATA[float]]></summary>
		public const int MovementTimeDiscrepancyDriftAllowance = 0x0404;

		///<summary><![CDATA[bool]]></summary>
		public const int bMovementTimeDiscrepancyForceCorrectionsDuringResolution = 0x0408;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseDistanceBasedRelevancy = 0x0409;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData03 = 0x040A;

	}

	public class ASkyLight
	{
		///<summary><![CDATA[USkyLightComponent *]]></summary>
		public const int LightComponent = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A9;

	}

	public class AWindDirectionalSource
	{
		///<summary><![CDATA[UWindDirectionalSourceComponent *]]></summary>
		public const int Component = 0x03A0;

	}

	public class AWorldSettings
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableWorldBoundsChecks = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableNavigationSystem = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableAISystem = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableWorldComposition = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseClientSideLevelStreamingVolumes = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableWorldOriginRebasing = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWorldGravitySet = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGlobalGravitySet = 0x03A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03A9;

		///<summary><![CDATA[float]]></summary>
		public const int KillZ = 0x03AC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int KillZDamageType = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int WorldGravityZ = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalGravityZ = 0x03BC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultPhysicsVolumeClass = 0x03C0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PhysicsCollisionHandlerClass = 0x03C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultGameMode = 0x03D0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GameNetworkManagerClass = 0x03D8;

		///<summary><![CDATA[int]]></summary>
		public const int PackedLightAndShadowMapTextureSize = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMinimizeBSPSections = 0x03E4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x03E5;

		///<summary><![CDATA[FVector]]></summary>
		public const int DefaultColorScale = 0x03E8;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultMaxDistanceFieldOcclusionDistance = 0x03F4;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalDistanceFieldViewDistance = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPrecomputeVisibility = 0x03FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPlaceCellsOnlyAlongCameraTracks = 0x03FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x03FD;

		///<summary><![CDATA[int]]></summary>
		public const int VisibilityCellSize = 0x0400;

		///<summary><![CDATA[TEnumAsByte<EVisibilityAggressiveness>]]></summary>
		public const int VisibilityAggressiveness = 0x0404;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0405;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceNoPrecomputedLighting = 0x0408;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0409;

		///<summary><![CDATA[FLightmassWorldInfoSettings]]></summary>
		public const int LightmassSettings = 0x040C;

		///<summary><![CDATA[FReverbSettings]]></summary>
		public const int DefaultReverbSettings = 0x0450;

		///<summary><![CDATA[FInteriorSettings]]></summary>
		public const int DefaultAmbientZoneSettings = 0x0468;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x048C;

		///<summary><![CDATA[USoundMix *]]></summary>
		public const int DefaultBaseSoundMix = 0x0490;

		///<summary><![CDATA[float]]></summary>
		public const int WorldToMeters = 0x0498;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData07 = 0x049C;

		///<summary><![CDATA[UBookMark * [0xA]]]></summary>
		public const int BookMarks = 0x04A0;

		///<summary><![CDATA[UExtendedReflectionSettings *]]></summary>
		public const int ReflectionSettings = 0x04F0;

		///<summary><![CDATA[float]]></summary>
		public const int TimeDilation = 0x04F8;

		///<summary><![CDATA[float]]></summary>
		public const int MatineeTimeDilation = 0x04FC;

		///<summary><![CDATA[float]]></summary>
		public const int DemoPlayTimeDilation = 0x0500;

		///<summary><![CDATA[float]]></summary>
		public const int MinGlobalTimeDilation = 0x0504;

		///<summary><![CDATA[float]]></summary>
		public const int MaxGlobalTimeDilation = 0x0508;

		///<summary><![CDATA[float]]></summary>
		public const int MinUndilatedFrameTime = 0x050C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxUndilatedFrameTime = 0x0510;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x0514;

		///<summary><![CDATA[APlayerState *]]></summary>
		public const int Pauser = 0x0518;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHighPriorityLoading = 0x0520;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHighPriorityLoadingLocal = 0x0520;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData09 = 0x0521;

		///<summary><![CDATA[TArray<FNetViewer>]]></summary>
		public const int ReplicationViewers = 0x0528;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int LayerNamesToLoadInReplay = 0x0538;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x0548;

	}

	public class ALevelBounds
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bAutoUpdateBounds = 0x03A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A1;

	}

	public class ULightComponentBase
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int LightGuid = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int Brightness = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int Intensity = 0x0314;

		///<summary><![CDATA[FColor]]></summary>
		public const int LightColor = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectsWorld = 0x031C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CastShadows = 0x031C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CastStaticShadows = 0x031C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CastDynamicShadows = 0x031C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectTranslucentLighting = 0x031C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x031D;

		///<summary><![CDATA[float]]></summary>
		public const int IndirectLightingIntensity = 0x0320;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0324;

	}

	public class ULightComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxDistanceFadeRange = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseTemperature = 0x0334;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0335;

		///<summary><![CDATA[int]]></summary>
		public const int ShadowMapChannel = 0x0338;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x033C;

		///<summary><![CDATA[float]]></summary>
		public const int MinRoughness = 0x0340;

		///<summary><![CDATA[float]]></summary>
		public const int ShadowBias = 0x0344;

		///<summary><![CDATA[float]]></summary>
		public const int ShadowSharpen = 0x0348;

		///<summary><![CDATA[float]]></summary>
		public const int ContactShadowLength = 0x034C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int InverseSquaredFalloff = 0x0350;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CastTranslucentShadows = 0x0350;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastShadowsFromCinematicObjectsOnly = 0x0350;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectDynamicIndirectLighting = 0x0350;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0351;

		///<summary><![CDATA[FLightingChannels]]></summary>
		public const int LightingChannels = 0x0354;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData03 = 0x0357;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int LightFunctionMaterial = 0x0358;

		///<summary><![CDATA[FVector]]></summary>
		public const int LightFunctionScale = 0x0360;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x036C;

		///<summary><![CDATA[UTextureLightProfile *]]></summary>
		public const int IESTexture = 0x0370;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseIESBrightness = 0x0378;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0379;

		///<summary><![CDATA[float]]></summary>
		public const int IESBrightnessScale = 0x037C;

		///<summary><![CDATA[float]]></summary>
		public const int LightFunctionFadeDistance = 0x0380;

		///<summary><![CDATA[float]]></summary>
		public const int DisabledBrightness = 0x0384;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableLightShaftBloom = 0x0388;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0389;

		///<summary><![CDATA[float]]></summary>
		public const int BloomScale = 0x038C;

		///<summary><![CDATA[float]]></summary>
		public const int BloomThreshold = 0x0390;

		///<summary><![CDATA[FColor]]></summary>
		public const int BloomTint = 0x0394;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseRayTracedDistanceFieldShadows = 0x0398;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x0399;

		///<summary><![CDATA[float]]></summary>
		public const int RayStartOffsetDepthScale = 0x039C;

		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData08 = 0x03A0;

	}

	public class ALight
	{
		///<summary><![CDATA[ULightComponent *]]></summary>
		public const int LightComponent = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03A9;

	}

	public class APointLight
	{
		///<summary><![CDATA[UPointLightComponent *]]></summary>
		public const int PointLightComponent = 0x03B0;

	}

	public class ASpotLight
	{
		///<summary><![CDATA[USpotLightComponent *]]></summary>
		public const int SpotLightComponent = 0x03B0;

	}

	public class ALightmassPortal
	{
		///<summary><![CDATA[ULightmassPortalComponent *]]></summary>
		public const int PortalComponent = 0x03A0;

	}

	public class ALODActor
	{
		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int StaticMeshComponent = 0x03A0;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int SubActors = 0x03A8;

		///<summary><![CDATA[float]]></summary>
		public const int LODDrawDistance = 0x03B8;

		///<summary><![CDATA[int]]></summary>
		public const int LODLevel = 0x03BC;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int SubObjects = 0x03C0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03D0;

	}

	public class AMaterialInstanceActor
	{
		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int TargetActors = 0x03A0;

	}

	public class AMatineeActor
	{
		///<summary><![CDATA[UInterpData *]]></summary>
		public const int MatineeData = 0x03A0;

		///<summary><![CDATA[FName]]></summary>
		public const int MatineeControllerName = 0x03A8;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x03B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPlayOnLevelLoad = 0x03B4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceStartPos = 0x03B4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03B5;

		///<summary><![CDATA[float]]></summary>
		public const int ForceStartPosition = 0x03B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLooping = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRewindOnPlay = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNoResetOnRewind = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRewindIfAlreadyPlaying = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableRadioFilter = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClientSideOnly = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSkipUpdateIfNotVisible = 0x03BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSkippable = 0x03BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03BD;

		///<summary><![CDATA[int]]></summary>
		public const int PreferredSplitScreenNum = 0x03C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableMovementInput = 0x03C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableLookAtInput = 0x03C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHidePlayer = 0x03C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHideHud = 0x03C4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x03C5;

		///<summary><![CDATA[TArray<FInterpGroupActorInfo>]]></summary>
		public const int GroupActorInfos = 0x03C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldShowGore = 0x03D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x03D9;

		///<summary><![CDATA[TArray<UInterpGroupInst * >]]></summary>
		public const int GroupInst = 0x03E0;

		///<summary><![CDATA[TArray<FCameraCutInfo>]]></summary>
		public const int CameraCuts = 0x03F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPlaying = 0x0400;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReversePlayback = 0x0400;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPaused = 0x0400;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPendingStop = 0x0400;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0401;

		///<summary><![CDATA[float]]></summary>
		public const int InterpPosition = 0x0404;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData05 = 0x0408;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int ReplicationForceIsPlaying = 0x040C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x040D;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPlay = 0x0410;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnStop = 0x0420;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPause = 0x0430;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData07 = 0x0440;

	}

	public class AMatineeActorCameraAnim
	{
		///<summary><![CDATA[UCameraAnim *]]></summary>
		public const int CameraAnim = 0x0448;

	}

	public class ANavigationData
	{
		///<summary><![CDATA[UPrimitiveComponent *]]></summary>
		public const int RenderingComp = 0x03A0;

		///<summary><![CDATA[FNavDataConfig]]></summary>
		public const int NavDataConfig = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableDrawing = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceRebuildOnLoad = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanBeMainNavData = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanSpawnOnRebuild = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRebuildAtRuntime = 0x03F8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03F9;

		///<summary><![CDATA[TEnumAsByte<ERuntimeGenerationType>]]></summary>
		public const int RuntimeGeneration = 0x03FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03FD;

		///<summary><![CDATA[float]]></summary>
		public const int ObservedPathsTickInterval = 0x0400;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int DataVersion = 0x0404;

		///<summary><![CDATA[unsigned char[0xD0]]]></summary>
		public const int UnknownData02 = 0x0408;

		///<summary><![CDATA[TArray<FSupportedAreaData>]]></summary>
		public const int SupportedAreas = 0x04D8;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData03 = 0x04E8;

	}

	public class ARecastNavMesh
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawTriangleEdges = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawPolyEdges = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawFilledPolys = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawNavMeshEdges = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawTileBounds = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawPathCollidingGeometry = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawTileLabels = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawPolygonLabels = 0x0540;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawDefaultPolygonCost = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawLabelsOnPathNodes = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawNavLinks = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawFailedNavLinks = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawClusters = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawOctree = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDistinctlyDrawTilesBeingBuilt = 0x0541;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawNavMesh = 0x0541;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0542;

		///<summary><![CDATA[float]]></summary>
		public const int DrawOffset = 0x0544;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFixedTilePoolSize = 0x0548;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0549;

		///<summary><![CDATA[int]]></summary>
		public const int TilePoolSize = 0x054C;

		///<summary><![CDATA[float]]></summary>
		public const int TileSizeUU = 0x0550;

		///<summary><![CDATA[float]]></summary>
		public const int CellSize = 0x0554;

		///<summary><![CDATA[float]]></summary>
		public const int CellHeight = 0x0558;

		///<summary><![CDATA[float]]></summary>
		public const int AgentRadius = 0x055C;

		///<summary><![CDATA[float]]></summary>
		public const int AgentHeight = 0x0560;

		///<summary><![CDATA[float]]></summary>
		public const int AgentMaxHeight = 0x0564;

		///<summary><![CDATA[float]]></summary>
		public const int AgentMaxSlope = 0x0568;

		///<summary><![CDATA[float]]></summary>
		public const int AgentMaxStepHeight = 0x056C;

		///<summary><![CDATA[float]]></summary>
		public const int MinRegionArea = 0x0570;

		///<summary><![CDATA[float]]></summary>
		public const int MergeRegionSize = 0x0574;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSimplificationError = 0x0578;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSimultaneousTileGenerationJobsCount = 0x057C;

		///<summary><![CDATA[int]]></summary>
		public const int TileNumberHardLimit = 0x0580;

		///<summary><![CDATA[int]]></summary>
		public const int PolyRefTileBits = 0x0584;

		///<summary><![CDATA[int]]></summary>
		public const int PolyRefNavPolyBits = 0x0588;

		///<summary><![CDATA[int]]></summary>
		public const int PolyRefSaltBits = 0x058C;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultDrawDistance = 0x0590;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultMaxSearchNodes = 0x0594;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultMaxHierarchicalSearchNodes = 0x0598;

		///<summary><![CDATA[TEnumAsByte<ERecastPartitioning>]]></summary>
		public const int RegionPartitioning = 0x059C;

		///<summary><![CDATA[TEnumAsByte<ERecastPartitioning>]]></summary>
		public const int LayerPartitioning = 0x059D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x059E;

		///<summary><![CDATA[int]]></summary>
		public const int RegionChunkSplits = 0x05A0;

		///<summary><![CDATA[int]]></summary>
		public const int LayerChunkSplits = 0x05A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSortNavigationAreasByCost = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPerformVoxelFiltering = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMarkLowHeightAreas = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDoFullyAsyncNavDataGathering = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseBetterOffsetsFromCorners = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStoreEmptyTileLayers = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseVirtualFilters = 0x05A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseVoxelCache = 0x05A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x05A9;

		///<summary><![CDATA[float]]></summary>
		public const int TileSetUpdateInterval = 0x05AC;

		///<summary><![CDATA[float]]></summary>
		public const int HeuristicScale = 0x05B0;

		///<summary><![CDATA[float]]></summary>
		public const int VerticalDeviationFromGroundCompensation = 0x05B4;

		///<summary><![CDATA[unsigned char[0x98]]]></summary>
		public const int UnknownData04 = 0x05B8;

	}

	public class ANavigationTestingActor
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[UCapsuleComponent *]]></summary>
		public const int CapsuleComponent = 0x03B0;

		///<summary><![CDATA[UNavigationInvokerComponent *]]></summary>
		public const int InvokerComponent = 0x03B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActAsNavigationInvoker = 0x03C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03C1;

		///<summary><![CDATA[FNavAgentProperties]]></summary>
		public const int NavAgentProps = 0x03C8;

		///<summary><![CDATA[FVector]]></summary>
		public const int QueryingExtent = 0x03E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x03F4;

		///<summary><![CDATA[ANavigationData *]]></summary>
		public const int MyNavData = 0x03F8;

		///<summary><![CDATA[FVector]]></summary>
		public const int ProjectedLocation = 0x0400;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProjectedLocationValid = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSearchStart = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseHierarchicalPathfinding = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGatherDetailedInfo = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawDistanceToWall = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowNodePool = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowBestPath = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowDiffWithPreviousStep = 0x040C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBeVisibleInGame = 0x040D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData03 = 0x040E;

		///<summary><![CDATA[TEnumAsByte<ENavCostDisplay>]]></summary>
		public const int CostDisplayMode = 0x0410;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0411;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int TextCanvasOffset = 0x0414;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPathExist = 0x041C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPathIsPartial = 0x041C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPathSearchOutOfNodes = 0x041C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x041D;

		///<summary><![CDATA[float]]></summary>
		public const int PathfindingTime = 0x0420;

		///<summary><![CDATA[float]]></summary>
		public const int PathCost = 0x0424;

		///<summary><![CDATA[int]]></summary>
		public const int PathfindingSteps = 0x0428;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x042C;

		///<summary><![CDATA[ANavigationTestingActor *]]></summary>
		public const int OtherActor = 0x0430;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FilterClass = 0x0438;

		///<summary><![CDATA[int]]></summary>
		public const int ShowStepIndex = 0x0440;

		///<summary><![CDATA[float]]></summary>
		public const int OffsetFromCornersDistance = 0x0444;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData07 = 0x0448;

	}

	public class UNavArea
	{
		///<summary><![CDATA[float]]></summary>
		public const int DefaultCost = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int FixedAreaEnteringCost = 0x002C;

		///<summary><![CDATA[FColor]]></summary>
		public const int DrawColor = 0x0030;

		///<summary><![CDATA[FNavAgentSelector]]></summary>
		public const int SupportedAgents = 0x0034;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent0 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent1 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent2 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent3 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent4 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent5 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent6 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent7 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent8 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent9 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent10 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent11 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent12 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent13 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent14 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsAgent15 = 0x0039;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x003A;

	}

	public class UNavLinkDefinition
	{
		///<summary><![CDATA[TArray<FNavigationLink>]]></summary>
		public const int Links = 0x0028;

		///<summary><![CDATA[TArray<FNavigationSegmentLink>]]></summary>
		public const int SegmentLinks = 0x0038;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class ANavLinkProxy
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[TArray<FNavigationLink>]]></summary>
		public const int PointLinks = 0x03B0;

		///<summary><![CDATA[TArray<FNavigationSegmentLink>]]></summary>
		public const int SegmentLinks = 0x03C0;

		///<summary><![CDATA[UNavLinkCustomComponent *]]></summary>
		public const int SmartLinkComp = 0x03D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bSmartLinkIsRelevant = 0x03D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03D9;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSmartLinkReached = 0x03E0;

	}

	public class USkeleton
	{
		///<summary><![CDATA[TArray<FBoneNode>]]></summary>
		public const int BoneTree = 0x0028;

		///<summary><![CDATA[TArray<FTransform>]]></summary>
		public const int RefLocalPoses = 0x0038;

		///<summary><![CDATA[unsigned char[0x110]]]></summary>
		public const int UnknownData00 = 0x0048;

		///<summary><![CDATA[FGuid]]></summary>
		public const int VirtualBoneGuid = 0x0158;

		///<summary><![CDATA[TArray<FVirtualBone>]]></summary>
		public const int VirtualBones = 0x0168;

		///<summary><![CDATA[TArray<FSkeletonToMeshLinkup>]]></summary>
		public const int LinkupCache = 0x0178;

		///<summary><![CDATA[TArray<USkeletalMeshSocket * >]]></summary>
		public const int Sockets = 0x0188;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData01 = 0x0198;

		///<summary><![CDATA[FSmartNameContainer]]></summary>
		public const int SmartNames = 0x01E8;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData02 = 0x0238;

		///<summary><![CDATA[TArray<UBlendProfile * >]]></summary>
		public const int BlendProfiles = 0x0250;

		///<summary><![CDATA[TArray<FAnimSlotGroup>]]></summary>
		public const int SlotGroups = 0x0260;

		///<summary><![CDATA[unsigned char[0x110]]]></summary>
		public const int UnknownData03 = 0x0270;

	}

	public class USkeletalMesh
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[USkeleton *]]></summary>
		public const int Skeleton = 0x0048;

		///<summary><![CDATA[FBoxSphereBounds]]></summary>
		public const int ImportedBounds = 0x0050;

		///<summary><![CDATA[FBoxSphereBounds]]></summary>
		public const int ExtendedBounds = 0x006C;

		///<summary><![CDATA[FVector]]></summary>
		public const int PositiveBoundsExtension = 0x0088;

		///<summary><![CDATA[FVector]]></summary>
		public const int NegativeBoundsExtension = 0x0094;

		///<summary><![CDATA[TArray<FSkeletalMaterial>]]></summary>
		public const int Materials = 0x00A0;

		///<summary><![CDATA[TArray<FBoneMirrorInfo>]]></summary>
		public const int SkelMirrorTable = 0x00B0;

		///<summary><![CDATA[TEnumAsByte<EAxis>]]></summary>
		public const int SkelMirrorAxis = 0x00C0;

		///<summary><![CDATA[TEnumAsByte<EAxis>]]></summary>
		public const int SkelMirrorFlipAxis = 0x00C1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x00C2;

		///<summary><![CDATA[TArray<FSkeletalMeshLODInfo>]]></summary>
		public const int LODInfo = 0x00C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFullPrecisionUVs = 0x00D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasBeenSimplified = 0x00D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasVertexColors = 0x00D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnablePerPolyCollision = 0x00D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x00D9;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x00E0;

		///<summary><![CDATA[UPhysicsAsset *]]></summary>
		public const int PhysicsAsset = 0x00E8;

		///<summary><![CDATA[UPhysicsAsset *]]></summary>
		public const int ShadowPhysicsAsset = 0x00F0;

		///<summary><![CDATA[TArray<UMorphTarget * >]]></summary>
		public const int MorphTargets = 0x00F8;

		///<summary><![CDATA[unsigned char[0x168]]]></summary>
		public const int UnknownData03 = 0x0108;

		///<summary><![CDATA[TArray<FClothingAssetData>]]></summary>
		public const int ClothingAssets = 0x0270;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PostProcessAnimBlueprint = 0x0280;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x0288;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0298;

		///<summary><![CDATA[TArray<USkeletalMeshSocket * >]]></summary>
		public const int Sockets = 0x02A0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData05 = 0x02B0;

	}

	public class UAssetMappingTable
	{
		///<summary><![CDATA[TArray<FAssetMapping>]]></summary>
		public const int MappedAssets = 0x0028;

	}

	public class UAnimationAsset
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[USkeleton *]]></summary>
		public const int Skeleton = 0x0030;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x0038;

		///<summary><![CDATA[TArray<UAnimMetaData * >]]></summary>
		public const int MetaData = 0x0058;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x0068;

	}

	public class AReflectionCapture
	{
		///<summary><![CDATA[UReflectionCaptureComponent *]]></summary>
		public const int CaptureComponent = 0x03A0;

	}

	public class ASphereReflectionCapture
	{
		///<summary><![CDATA[UDrawSphereComponent *]]></summary>
		public const int DrawCaptureRadius = 0x03A8;

	}

	public class APhysicsConstraintActor
	{
		///<summary><![CDATA[UPhysicsConstraintComponent *]]></summary>
		public const int ConstraintComp = 0x03A0;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ConstraintActor1 = 0x03A8;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ConstraintActor2 = 0x03B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableCollision = 0x03B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03B9;

	}

	public class APhysicsThruster
	{
		///<summary><![CDATA[UPhysicsThrusterComponent *]]></summary>
		public const int ThrusterComponent = 0x03A0;

	}

	public class ARadialForceActor
	{
		///<summary><![CDATA[URadialForceComponent *]]></summary>
		public const int ForceComponent = 0x03A0;

	}

	public class ASceneCapture
	{
		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int MeshComp = 0x03A0;

	}

	public class APlanarReflection
	{
		///<summary><![CDATA[UPlanarReflectionComponent *]]></summary>
		public const int PlanarReflectionComponent = 0x03A8;

		///<summary><![CDATA[bool]]></summary>
		public const int bShowPreviewPlane = 0x03B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03B1;

	}

	public class ASceneCapture2D
	{
		///<summary><![CDATA[USceneCaptureComponent2D *]]></summary>
		public const int CaptureComponent2D = 0x03A8;

		///<summary><![CDATA[UDrawFrustumComponent *]]></summary>
		public const int DrawFrustum = 0x03B0;

	}

	public class ASceneCaptureCube
	{
		///<summary><![CDATA[USceneCaptureComponentCube *]]></summary>
		public const int CaptureComponentCube = 0x03A8;

		///<summary><![CDATA[UDrawFrustumComponent *]]></summary>
		public const int DrawFrustum = 0x03B0;

	}

	public class USkeletalMeshComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x08F0;

		///<summary><![CDATA[TEnumAsByte<EAnimationMode>]]></summary>
		public const int AnimationMode = 0x08F8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x08F9;

		///<summary><![CDATA[UAnimBlueprintGeneratedClass *]]></summary>
		public const int AnimBlueprintGeneratedClass = 0x0900;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AnimClass = 0x0908;

		///<summary><![CDATA[UAnimInstance *]]></summary>
		public const int AnimScriptInstance = 0x0910;

		///<summary><![CDATA[TArray<UAnimInstance * >]]></summary>
		public const int SubInstances = 0x0918;

		///<summary><![CDATA[UAnimInstance *]]></summary>
		public const int PostProcessAnimInstance = 0x0928;

		///<summary><![CDATA[FSingleAnimationPlayData]]></summary>
		public const int AnimationData = 0x0930;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0948;

		///<summary><![CDATA[TArray<FTransform>]]></summary>
		public const int CachedBoneSpaceTransforms = 0x0958;

		///<summary><![CDATA[TArray<FTransform>]]></summary>
		public const int CachedComponentSpaceTransforms = 0x0968;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData03 = 0x0978;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalAnimRateScale = 0x0998;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasValidBodies = 0x099C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x099D;

		///<summary><![CDATA[TEnumAsByte<EKinematicBonesUpdateToPhysics>]]></summary>
		public const int KinematicBonesUpdateType = 0x09A0;

		///<summary><![CDATA[TEnumAsByte<EPhysicsTransformUpdateMode>]]></summary>
		public const int PhysicsTransformUpdateMode = 0x09A1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData05 = 0x09A2;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBlendPhysics = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnablePhysicsOnDedicatedServer = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdateJointsFromAnimation = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableClothSimulation = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollideWithEnvironment = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollideWithAttachedChildren = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLocalSpaceSimulation = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClothMorphTarget = 0x09A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bResetAfterTeleport = 0x09A5;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData06 = 0x09A6;

		///<summary><![CDATA[float]]></summary>
		public const int TeleportDistanceThreshold = 0x09A8;

		///<summary><![CDATA[float]]></summary>
		public const int TeleportRotationThreshold = 0x09AC;

		///<summary><![CDATA[float]]></summary>
		public const int ClothBlendWeight = 0x09B0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData07 = 0x09B4;

		///<summary><![CDATA[FVector]]></summary>
		public const int RootBoneTranslation = 0x09B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNoSkeletonUpdate = 0x09C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPauseAnims = 0x09C4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x09C5;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseRefPoseOnInitAnim = 0x09C8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x09C9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnablePerPolyCollision = 0x09CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData10 = 0x09CD;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x09D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutonomousTickPose = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceRefpose = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOldForceRefPose = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowPrePhysBones = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRequiredBonesUpToDate = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAnimTreeInitialised = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIncludeComponentLocationIntoBounds = 0x09D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableLineCheckWithBounds = 0x09D8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData11 = 0x09D9;

		///<summary><![CDATA[uint16_t]]></summary>
		public const int CachedAnimCurveUidVersion = 0x09DC;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData12 = 0x09DE;

		///<summary><![CDATA[FVector]]></summary>
		public const int LineCheckBoundsScale = 0x09E0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData13 = 0x09EC;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnConstraintBroken = 0x09F0;

		///<summary><![CDATA[unsigned char[0x3C0]]]></summary>
		public const int UnknownData14 = 0x0A00;

		///<summary><![CDATA[UAnimSequence *]]></summary>
		public const int SequenceToPlay = 0x0DC0;

		///<summary><![CDATA[UAnimationAsset *]]></summary>
		public const int AnimToPlay = 0x0DC8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultLooping = 0x0DD0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultPlaying = 0x0DD0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData15 = 0x0DD1;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultPosition = 0x0DD4;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultPlayRate = 0x0DD8;

		///<summary><![CDATA[float]]></summary>
		public const int LastPoseTickTime = 0x0DDC;

		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData16 = 0x0DE0;

	}

	public class ASkeletalMeshActor
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldDoAnimNotifies = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWakeOnLevelStart = 0x03A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03A9;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int SkeletalMeshComponent = 0x03B0;

		///<summary><![CDATA[USkeletalMesh *]]></summary>
		public const int ReplicatedMesh = 0x03B8;

		///<summary><![CDATA[UPhysicsAsset *]]></summary>
		public const int ReplicatedPhysAsset = 0x03C0;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int ReplicatedMaterial0 = 0x03C8;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int ReplicatedMaterial1 = 0x03D0;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData02 = 0x03D8;

	}

	public class ASplineMeshActor
	{
		///<summary><![CDATA[USplineMeshComponent *]]></summary>
		public const int SplineMeshComponent = 0x03A0;

	}

	public class ASubDSurfaceActor
	{
		///<summary><![CDATA[USubDSurfaceComponent *]]></summary>
		public const int SubDSurface = 0x03A0;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int DisplayMeshComponent = 0x03A8;

	}

	public class ATextRenderActor
	{
		///<summary><![CDATA[UTextRenderComponent *]]></summary>
		public const int TextRender = 0x03A0;

	}

	public class ATriggerBase
	{
		///<summary><![CDATA[UShapeComponent *]]></summary>
		public const int CollisionComponent = 0x03A0;

		///<summary><![CDATA[UBillboardComponent *]]></summary>
		public const int SpriteComponent = 0x03A8;

	}

	public class AVectorFieldVolume
	{
		///<summary><![CDATA[UVectorFieldComponent *]]></summary>
		public const int VectorFieldComponent = 0x03A0;

	}

	public class UApplicationLifecycleComponent
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationWillDeactivateDelegate = 0x00F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationHasReactivatedDelegate = 0x0108;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationWillEnterBackgroundDelegate = 0x0118;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationHasEnteredForegroundDelegate = 0x0128;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationWillTerminateDelegate = 0x0138;

	}

	public class UInterpToMovementComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int Duration = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPauseOnImpact = 0x0144;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0145;

		///<summary><![CDATA[TEnumAsByte<EInterpToBehaviourType>]]></summary>
		public const int BehaviourType = 0x0148;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0149;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceSubStepping = 0x014C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x014D;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInterpToReverse = 0x0150;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInterpToStop = 0x0160;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnWaitBeginDelegate = 0x0170;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnWaitEndDelegate = 0x0180;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnResetDelegate = 0x0190;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSimulationTimeStep = 0x01A0;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSimulationIterations = 0x01A4;

		///<summary><![CDATA[TArray<FInterpControlPoint>]]></summary>
		public const int ControlPoints = 0x01A8;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData03 = 0x01B8;

	}

	public class UWorld
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[ULevel *]]></summary>
		public const int PersistentLevel = 0x0030;

		///<summary><![CDATA[UNetDriver *]]></summary>
		public const int NetDriver = 0x0038;

		///<summary><![CDATA[ULineBatchComponent *]]></summary>
		public const int LineBatcher = 0x0040;

		///<summary><![CDATA[ULineBatchComponent *]]></summary>
		public const int PersistentLineBatcher = 0x0048;

		///<summary><![CDATA[ULineBatchComponent *]]></summary>
		public const int ForegroundLineBatcher = 0x0050;

		///<summary><![CDATA[AGameNetworkManager *]]></summary>
		public const int NetworkManager = 0x0058;

		///<summary><![CDATA[UPhysicsCollisionHandler *]]></summary>
		public const int PhysicsCollisionHandler = 0x0060;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int ExtraReferencedObjects = 0x0068;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int PerModuleDataObjects = 0x0078;

		///<summary><![CDATA[TArray<ULevelStreaming * >]]></summary>
		public const int StreamingLevels = 0x0088;

		///<summary><![CDATA[FString]]></summary>
		public const int StreamingLevelsPrefix = 0x0098;

		///<summary><![CDATA[ULevel *]]></summary>
		public const int CurrentLevelPendingVisibility = 0x00A8;

		///<summary><![CDATA[ULevel *]]></summary>
		public const int CurrentLevelPendingInvisibility = 0x00B0;

		///<summary><![CDATA[UDemoNetDriver *]]></summary>
		public const int DemoNetDriver = 0x00B8;

		///<summary><![CDATA[AParticleEventManager *]]></summary>
		public const int MyParticleEventManager = 0x00C0;

		///<summary><![CDATA[APhysicsVolume *]]></summary>
		public const int DefaultPhysicsVolume = 0x00C8;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x00D0;

		///<summary><![CDATA[UNavigationSystem *]]></summary>
		public const int NavigationSystem = 0x00E8;

		///<summary><![CDATA[AGameModeBase *]]></summary>
		public const int AuthorityGameMode = 0x00F0;

		///<summary><![CDATA[AGameStateBase *]]></summary>
		public const int GameState = 0x00F8;

		///<summary><![CDATA[UAISystemBase *]]></summary>
		public const int AISystem = 0x0100;

		///<summary><![CDATA[UAvoidanceManager *]]></summary>
		public const int AvoidanceManager = 0x0108;

		///<summary><![CDATA[TArray<ULevel * >]]></summary>
		public const int Levels = 0x0110;

		///<summary><![CDATA[TArray<FLevelCollection>]]></summary>
		public const int LevelCollections = 0x0120;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0130;

		///<summary><![CDATA[ULevel *]]></summary>
		public const int CurrentLevel = 0x0138;

		///<summary><![CDATA[UGameInstance *]]></summary>
		public const int OwningGameInstance = 0x0140;

		///<summary><![CDATA[TArray<UMaterialParameterCollectionInstance * >]]></summary>
		public const int ParameterCollectionInstances = 0x0148;

		///<summary><![CDATA[UCanvas *]]></summary>
		public const int CanvasForRenderingToTarget = 0x0158;

		///<summary><![CDATA[UCanvas *]]></summary>
		public const int CanvasForDrawMaterialToRenderTarget = 0x0160;

		///<summary><![CDATA[unsigned char[0x7D0]]]></summary>
		public const int UnknownData03 = 0x0168;

		///<summary><![CDATA[UWorldComposition *]]></summary>
		public const int WorldComposition = 0x0938;

		///<summary><![CDATA[unsigned char[0x4A]]]></summary>
		public const int UnknownData04 = 0x0940;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAreConstraintsDirty = 0x098A;

		///<summary><![CDATA[unsigned char[0x15]]]></summary>
		public const int UnknownData05 = 0x098B;

	}

	public class UNavigationSystem
	{
		///<summary><![CDATA[ANavigationData *]]></summary>
		public const int MainNavData = 0x0028;

		///<summary><![CDATA[ANavigationData *]]></summary>
		public const int AbstractNavData = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoCreateNavigationData = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowClientSideNavigation = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportRebuilding = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInitialBuildingLocked = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSkipAgentHeightCheckWhenPickingNavData = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0039;

		///<summary><![CDATA[TEnumAsByte<ENavDataGatheringModeConfig>]]></summary>
		public const int DataGatheringMode = 0x003C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x003D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateNavigationOnlyAroundNavigationInvokers = 0x0040;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0041;

		///<summary><![CDATA[float]]></summary>
		public const int ActiveTilesUpdateInterval = 0x0044;

		///<summary><![CDATA[TArray<FNavDataConfig>]]></summary>
		public const int SupportedAgents = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int DirtyAreasUpdateFreq = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x005C;

		///<summary><![CDATA[TArray<ANavigationData * >]]></summary>
		public const int NavDataSet = 0x0060;

		///<summary><![CDATA[TArray<ANavigationData * >]]></summary>
		public const int NavDataRegistrationQueue = 0x0070;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData05 = 0x0080;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNavDataRegisteredEvent = 0x00E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNavigationGenerationFinishedDelegate = 0x00F0;

		///<summary><![CDATA[unsigned char[0x124]]]></summary>
		public const int UnknownData06 = 0x0100;

		///<summary><![CDATA[TEnumAsByte<EFNavigationSystemRunMode>]]></summary>
		public const int OperationMode = 0x0224;

		///<summary><![CDATA[unsigned char[0x23B]]]></summary>
		public const int UnknownData07 = 0x0225;

	}

	public class UProjectileMovementComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int InitialSpeed = 0x0140;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSpeed = 0x0144;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRotationFollowsVelocity = 0x0148;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBounce = 0x0148;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInitialVelocityInLocalSpace = 0x0148;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceSubStepping = 0x0148;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsHomingProjectile = 0x0148;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBounceAngleAffectsFriction = 0x0148;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSliding = 0x0148;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0149;

		///<summary><![CDATA[float]]></summary>
		public const int PreviousHitTime = 0x014C;

		///<summary><![CDATA[FVector]]></summary>
		public const int PreviousHitNormal = 0x0150;

		///<summary><![CDATA[float]]></summary>
		public const int ProjectileGravityScale = 0x015C;

		///<summary><![CDATA[float]]></summary>
		public const int Buoyancy = 0x0160;

		///<summary><![CDATA[float]]></summary>
		public const int Bounciness = 0x0164;

		///<summary><![CDATA[float]]></summary>
		public const int Friction = 0x0168;

		///<summary><![CDATA[float]]></summary>
		public const int BounceVelocityStopSimulatingThreshold = 0x016C;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnProjectileBounce = 0x0170;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnProjectileStop = 0x0180;

		///<summary><![CDATA[float]]></summary>
		public const int HomingAccelerationMagnitude = 0x0190;

		///<summary><![CDATA[TWeakObjectPtr<USceneComponent>]]></summary>
		public const int HomingTargetComponent = 0x0194;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSimulationTimeStep = 0x019C;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSimulationIterations = 0x01A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01A4;

	}

	public class URotatingMovementComponent
	{
		///<summary><![CDATA[FRotator]]></summary>
		public const int RotationRate = 0x0140;

		///<summary><![CDATA[FVector]]></summary>
		public const int PivotTranslation = 0x014C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRotationInLocalSpace = 0x0158;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0159;

	}

	public class UNavigationInvokerComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int TileGenerationRadius = 0x00F8;

		///<summary><![CDATA[float]]></summary>
		public const int TileRemovalRadius = 0x00FC;

	}

	public class UNavRelevantComponent
	{
		///<summary><![CDATA[unsigned char[0x24]]]></summary>
		public const int UnknownData00 = 0x00F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAttachToOwnersRoot = 0x011C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x011D;

		///<summary><![CDATA[UObject *]]></summary>
		public const int CachedNavParent = 0x0120;

	}

	public class UNavLinkCustomComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0128;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int NavLinkUserId = 0x0130;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0134;

		///<summary><![CDATA[UClass *]]></summary>
		public const int EnabledAreaClass = 0x0138;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DisabledAreaClass = 0x0140;

		///<summary><![CDATA[FVector]]></summary>
		public const int LinkRelativeStart = 0x0148;

		///<summary><![CDATA[FVector]]></summary>
		public const int LinkRelativeEnd = 0x0154;

		///<summary><![CDATA[TEnumAsByte<ENavLinkDirection>]]></summary>
		public const int LinkDirection = 0x0160;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0161;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLinkEnabled = 0x0164;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNotifyWhenEnabled = 0x0164;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNotifyWhenDisabled = 0x0164;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCreateBoxObstacle = 0x0164;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0165;

		///<summary><![CDATA[FVector]]></summary>
		public const int ObstacleOffset = 0x0168;

		///<summary><![CDATA[FVector]]></summary>
		public const int ObstacleExtent = 0x0174;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ObstacleAreaClass = 0x0180;

		///<summary><![CDATA[float]]></summary>
		public const int BroadcastRadius = 0x0188;

		///<summary><![CDATA[float]]></summary>
		public const int BroadcastInterval = 0x018C;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int BroadcastChannel = 0x0190;

		///<summary><![CDATA[unsigned char[0xAF]]]></summary>
		public const int UnknownData04 = 0x0191;

	}

	public class UNavModifierComponent
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int AreaClass = 0x0128;

		///<summary><![CDATA[FVector]]></summary>
		public const int FailsafeExtent = 0x0130;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData00 = 0x013C;

	}

	public class UPawnNoiseEmitterComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAIPerceptionSystemCompatibilityMode = 0x00F8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00F9;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastRemoteNoisePosition = 0x00FC;

		///<summary><![CDATA[float]]></summary>
		public const int NoiseLifetime = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int LastRemoteNoiseVolume = 0x010C;

		///<summary><![CDATA[float]]></summary>
		public const int LastRemoteNoiseTime = 0x0110;

		///<summary><![CDATA[float]]></summary>
		public const int LastLocalNoiseVolume = 0x0114;

		///<summary><![CDATA[float]]></summary>
		public const int LastLocalNoiseTime = 0x0118;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x011C;

	}

	public class UPhysicalAnimationComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int StrengthMultiplyer = 0x00F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00FC;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int SkeletalMeshComponent = 0x0100;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData01 = 0x0108;

	}

	public class UPhysicsHandleComponent
	{
		///<summary><![CDATA[UPrimitiveComponent *]]></summary>
		public const int GrabbedComponent = 0x00F8;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x0100;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData01 = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSoftAngularConstraint = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSoftLinearConstraint = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInterpolateTarget = 0x010C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x010D;

		///<summary><![CDATA[float]]></summary>
		public const int LinearDamping = 0x0110;

		///<summary><![CDATA[float]]></summary>
		public const int LinearStiffness = 0x0114;

		///<summary><![CDATA[float]]></summary>
		public const int AngularDamping = 0x0118;

		///<summary><![CDATA[float]]></summary>
		public const int AngularStiffness = 0x011C;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData03 = 0x0120;

		///<summary><![CDATA[float]]></summary>
		public const int InterpolationSpeed = 0x0180;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData04 = 0x0184;

	}

	public class UPlatformEventsComponent
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int PlatformChangedToLaptopModeDelegate = 0x00F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int PlatformChangedToTabletModeDelegate = 0x0108;

	}

	public class UAtmosphericFogComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int SunMultiplier = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int FogMultiplier = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int DensityMultiplier = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int DensityOffset = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceScale = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int AltitudeScale = 0x0314;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceOffset = 0x0318;

		///<summary><![CDATA[float]]></summary>
		public const int GroundOffset = 0x031C;

		///<summary><![CDATA[float]]></summary>
		public const int StartDistance = 0x0320;

		///<summary><![CDATA[float]]></summary>
		public const int SunDiscScale = 0x0324;

		///<summary><![CDATA[TArray<FFogHeightDensityPair>]]></summary>
		public const int HeightDensityLayers = 0x0328;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultBrightness = 0x0338;

		///<summary><![CDATA[FColor]]></summary>
		public const int DefaultLightColor = 0x033C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableSunDisk = 0x0340;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableGroundScattering = 0x0340;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0341;

		///<summary><![CDATA[FAtmospherePrecomputeParameters]]></summary>
		public const int PrecomputeParams = 0x0344;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int TransmittanceTexture = 0x0370;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int IrradianceTexture = 0x0378;

		///<summary><![CDATA[unsigned char[0x190]]]></summary>
		public const int UnknownData01 = 0x0380;

	}

	public class USoundAttenuation
	{
		///<summary><![CDATA[FAttenuationSettings]]></summary>
		public const int Attenuation = 0x0028;

	}

	public class UAudioComponent
	{
		///<summary><![CDATA[USoundBase *]]></summary>
		public const int Sound = 0x0300;

		///<summary><![CDATA[TArray<FAudioComponentParam>]]></summary>
		public const int InstanceParameters = 0x0308;

		///<summary><![CDATA[USoundClass *]]></summary>
		public const int SoundClassOverride = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoDestroy = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStopWhenOwnerDestroyed = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldRemainActiveIfDropped = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowSpatialization = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideAttenuation = 0x0320;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0321;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideSubtitlePriority = 0x0324;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0325;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsUISound = 0x0328;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableLowPassFilter = 0x0328;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverridePriority = 0x0328;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSuppressSubtitles = 0x0328;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0329;

		///<summary><![CDATA[float]]></summary>
		public const int PitchModulationMin = 0x0330;

		///<summary><![CDATA[float]]></summary>
		public const int PitchModulationMax = 0x0334;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeModulationMin = 0x0338;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeModulationMax = 0x033C;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMultiplier = 0x0340;

		///<summary><![CDATA[float]]></summary>
		public const int Priority = 0x0344;

		///<summary><![CDATA[float]]></summary>
		public const int SubtitlePriority = 0x0348;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeWeightedPriorityScale = 0x034C;

		///<summary><![CDATA[float]]></summary>
		public const int PitchMultiplier = 0x0350;

		///<summary><![CDATA[float]]></summary>
		public const int HighFrequencyGainMultiplier = 0x0354;

		///<summary><![CDATA[float]]></summary>
		public const int LowPassFilterFrequency = 0x0358;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x035C;

		///<summary><![CDATA[USoundAttenuation *]]></summary>
		public const int AttenuationSettings = 0x0360;

		///<summary><![CDATA[FAttenuationSettings]]></summary>
		public const int AttenuationOverrides = 0x0368;

		///<summary><![CDATA[USoundConcurrency *]]></summary>
		public const int ConcurrencySettings = 0x0460;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0468;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnAudioFinished = 0x0470;

		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData05 = 0x0480;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnAudioPlaybackPercent = 0x04F0;

		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData06 = 0x0500;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnQueueSubtitles = 0x0570;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData07 = 0x0580;

	}

	public class UChildActorComponent
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ChildActorClass = 0x0300;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ChildActor = 0x0308;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ChildActorTemplate = 0x0310;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0318;

	}

	public class UDecalComponent
	{
		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int DecalMaterial = 0x0300;

		///<summary><![CDATA[int]]></summary>
		public const int SortOrder = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int FadeScreenSize = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int FadeStartDelay = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int FadeDuration = 0x0314;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDestroyOwnerAfterFade = 0x0318;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEmitSecondaryDecal = 0x0318;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0319;

		///<summary><![CDATA[FVector]]></summary>
		public const int DecalSize = 0x031C;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0328;

	}

	public class UDistanceFieldCaptureComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0300;

	}

	public class UExponentialHeightFogComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int FogDensity = 0x0300;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int FogInscatteringColor = 0x0304;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0314;

		///<summary><![CDATA[TArray<FFogHeightDensityPair2>]]></summary>
		public const int HeightDensityLayers = 0x0318;

		///<summary><![CDATA[float]]></summary>
		public const int DirectionalInscatteringExponent = 0x0328;

		///<summary><![CDATA[float]]></summary>
		public const int DirectionalInscatteringStartDistance = 0x032C;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DirectionalInscatteringColor = 0x0330;

		///<summary><![CDATA[float]]></summary>
		public const int FogHeightFalloff = 0x0340;

		///<summary><![CDATA[float]]></summary>
		public const int FogMaxOpacity = 0x0344;

		///<summary><![CDATA[float]]></summary>
		public const int StartDistance = 0x0348;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseExtendedFog = 0x034C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x034D;

		///<summary><![CDATA[float]]></summary>
		public const int ExtendedFogStartDistance = 0x0350;

		///<summary><![CDATA[float]]></summary>
		public const int ExtendedFogStartFalloffDistance = 0x0354;

		///<summary><![CDATA[float]]></summary>
		public const int ExtendedHeight = 0x0358;

		///<summary><![CDATA[float]]></summary>
		public const int ExtendedFallOff = 0x035C;

		///<summary><![CDATA[float]]></summary>
		public const int ExtendedFogDensity = 0x0360;

		///<summary><![CDATA[float]]></summary>
		public const int UpDensity = 0x0364;

		///<summary><![CDATA[float]]></summary>
		public const int DownDensity = 0x0368;

		///<summary><![CDATA[float]]></summary>
		public const int Intensity = 0x036C;

	}

	public class UDirectionalLightComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableLightShaftOcclusion = 0x0420;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0421;

		///<summary><![CDATA[float]]></summary>
		public const int OcclusionMaskDarkness = 0x0424;

		///<summary><![CDATA[float]]></summary>
		public const int OcclusionDepthRange = 0x0428;

		///<summary><![CDATA[FVector]]></summary>
		public const int LightShaftOverrideDirection = 0x042C;

		///<summary><![CDATA[float]]></summary>
		public const int WholeSceneDynamicShadowRadius = 0x0438;

		///<summary><![CDATA[float]]></summary>
		public const int DynamicShadowDistanceMovableLight = 0x043C;

		///<summary><![CDATA[float]]></summary>
		public const int DynamicShadowDistanceStationaryLight = 0x0440;

		///<summary><![CDATA[int]]></summary>
		public const int DynamicShadowCascades = 0x0444;

		///<summary><![CDATA[float]]></summary>
		public const int CascadeDistributionExponent = 0x0448;

		///<summary><![CDATA[float]]></summary>
		public const int CascadeTransitionFraction = 0x044C;

		///<summary><![CDATA[float]]></summary>
		public const int ShadowDistanceFadeoutFraction = 0x0450;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseInsetShadowsForMovableObjects = 0x0454;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0455;

		///<summary><![CDATA[int]]></summary>
		public const int FarShadowCascadeCount = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int FarShadowDistance = 0x045C;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceFieldShadowDistance = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int LightSourceAngle = 0x0464;

		///<summary><![CDATA[float]]></summary>
		public const int TraceDistance = 0x0468;

		///<summary><![CDATA[FLightmassDirectionalLightSettings]]></summary>
		public const int LightmassSettings = 0x046C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastModulatedShadows = 0x047C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x047D;

		///<summary><![CDATA[FColor]]></summary>
		public const int ModulatedShadowColor = 0x0480;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedAsAtmosphereSunLight = 0x0484;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseGridShadow = 0x0484;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0485;

		///<summary><![CDATA[TArray<FGridShadowSplitSettings>]]></summary>
		public const int GridShadowSplitSettings = 0x0488;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0498;

	}

	public class UPointLightComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x0420;

		///<summary><![CDATA[float]]></summary>
		public const int AttenuationRadius = 0x0424;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseInverseSquaredFalloff = 0x0428;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0429;

		///<summary><![CDATA[float]]></summary>
		public const int LightFalloffExponent = 0x042C;

		///<summary><![CDATA[float]]></summary>
		public const int SourceRadius = 0x0430;

		///<summary><![CDATA[float]]></summary>
		public const int SourceLength = 0x0434;

		///<summary><![CDATA[FLightmassPointLightSettings]]></summary>
		public const int LightmassSettings = 0x0438;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0444;

	}

	public class USpotLightComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int LightShaftConeAngle = 0x0450;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x0454;

	}

	public class USkyLightComponent
	{
		///<summary><![CDATA[UTextureCube *]]></summary>
		public const int Cubemap = 0x0330;

		///<summary><![CDATA[float]]></summary>
		public const int SourceCubemapAngle = 0x0338;

		///<summary><![CDATA[int]]></summary>
		public const int CubemapResolution = 0x033C;

		///<summary><![CDATA[float]]></summary>
		public const int SkyDistanceThreshold = 0x0340;

		///<summary><![CDATA[bool]]></summary>
		public const int bLowerHemisphereIsBlack = 0x0344;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0345;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LowerHemisphereColor = 0x0348;

		///<summary><![CDATA[float]]></summary>
		public const int OcclusionMaxDistance = 0x0358;

		///<summary><![CDATA[float]]></summary>
		public const int Contrast = 0x035C;

		///<summary><![CDATA[float]]></summary>
		public const int MinOcclusion = 0x0360;

		///<summary><![CDATA[FColor]]></summary>
		public const int OcclusionTint = 0x0364;

		///<summary><![CDATA[unsigned char[0xB0]]]></summary>
		public const int UnknownData01 = 0x0368;

		///<summary><![CDATA[UTextureCube *]]></summary>
		public const int BlendDestinationCubemap = 0x0418;

		///<summary><![CDATA[unsigned char[0xC0]]]></summary>
		public const int UnknownData02 = 0x0420;

	}

	public class ULightmassPortalComponent
	{
		///<summary><![CDATA[UBoxComponent *]]></summary>
		public const int PreviewBox = 0x0300;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0308;

	}

	public class UNavigationGraphNodeComponent
	{
		///<summary><![CDATA[FNavGraphNode]]></summary>
		public const int Node = 0x0300;

		///<summary><![CDATA[UNavigationGraphNodeComponent *]]></summary>
		public const int NextNodeComponent = 0x0318;

		///<summary><![CDATA[UNavigationGraphNodeComponent *]]></summary>
		public const int PrevNodeComponent = 0x0320;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0328;

	}

	public class UPhysicsConstraintComponent
	{
		///<summary><![CDATA[AActor *]]></summary>
		public const int ConstraintActor1 = 0x0300;

		///<summary><![CDATA[FConstrainComponentPropName]]></summary>
		public const int ComponentName1 = 0x0308;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ConstraintActor2 = 0x0310;

		///<summary><![CDATA[FConstrainComponentPropName]]></summary>
		public const int ComponentName2 = 0x0318;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0320;

		///<summary><![CDATA[UPhysicsConstraintTemplate *]]></summary>
		public const int ConstraintSetup = 0x0330;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnConstraintBroken = 0x0338;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0348;

		///<summary><![CDATA[FConstraintInstance]]></summary>
		public const int ConstraintInstance = 0x0350;

	}

	public class UPhysicsSpringComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int SpringStiffness = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int SpringDamping = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int SpringLengthAtRest = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int SpringRadius = 0x030C;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int SpringChannel = 0x0310;

		///<summary><![CDATA[bool]]></summary>
		public const int bIgnoreSelf = 0x0311;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0312;

		///<summary><![CDATA[float]]></summary>
		public const int SpringCompression = 0x0314;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0318;

	}

	public class UPhysicsThrusterComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int ThrustStrength = 0x0300;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x0304;

	}

	public class UPostProcessComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0300;

		///<summary><![CDATA[FPostProcessSettings]]></summary>
		public const int Settings = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int Priority = 0x07F0;

		///<summary><![CDATA[float]]></summary>
		public const int BlendRadius = 0x07F4;

		///<summary><![CDATA[float]]></summary>
		public const int BlendWeight = 0x07F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x07FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUnbound = 0x07FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x07FD;

	}

	public class UArrowComponent
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bIsScreenSizeScaled = 0x06D0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x06D1;

		///<summary><![CDATA[float]]></summary>
		public const int ScreenSize = 0x06D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTreatAsASprite = 0x06D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x06D9;

	}

	public class UBillboardComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsScreenSizeScaled = 0x06D0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x06D1;

		///<summary><![CDATA[float]]></summary>
		public const int ScreenSize = 0x06D4;

		///<summary><![CDATA[float]]></summary>
		public const int U = 0x06D8;

		///<summary><![CDATA[float]]></summary>
		public const int UL = 0x06DC;

		///<summary><![CDATA[float]]></summary>
		public const int V = 0x06E0;

		///<summary><![CDATA[float]]></summary>
		public const int VL = 0x06E4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x06E8;

	}

	public class UBrushComponent
	{
		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BrushBodySetup = 0x06D0;

		///<summary><![CDATA[FVector]]></summary>
		public const int PrePivot = 0x06D8;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x06E4;

	}

	public class UDrawFrustumComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int FrustumAspectRatio = 0x06D0;

		///<summary><![CDATA[float]]></summary>
		public const int FrustumStartDist = 0x06D4;

		///<summary><![CDATA[float]]></summary>
		public const int FrustumEndDist = 0x06D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x06DC;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int Texture = 0x06E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x06E8;

	}

	public class ULineBatchComponent
	{
		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x06D0;

	}

	public class UMaterialBillboardComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x06D0;

	}

	public class UPoseableMeshComponent
	{
		///<summary><![CDATA[unsigned char[0xF0]]]></summary>
		public const int UnknownData00 = 0x08F0;

	}

	public class USplineMeshComponent
	{
		///<summary><![CDATA[FSplineMeshParams]]></summary>
		public const int SplineParams = 0x0810;

		///<summary><![CDATA[FVector]]></summary>
		public const int SplineUpDir = 0x0868;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowSplineEditingPerInstance = 0x0874;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSmoothInterpRollScale = 0x0874;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0875;

		///<summary><![CDATA[TEnumAsByte<ESplineMeshAxis>]]></summary>
		public const int ForwardAxis = 0x0878;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0879;

		///<summary><![CDATA[float]]></summary>
		public const int SplineBoundaryMin = 0x087C;

		///<summary><![CDATA[float]]></summary>
		public const int SplineBoundaryMax = 0x0880;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0884;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x0888;

		///<summary><![CDATA[FGuid]]></summary>
		public const int CachedMeshBodySetupGuid = 0x0890;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMeshDirty = 0x08A0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData03 = 0x08A1;

	}

	public class UModelComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x06D0;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int ModelBodySetup = 0x06E0;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData01 = 0x06E8;

	}

	public class UNavMeshRenderingComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x06D0;

	}

	public class UParticleSystem
	{
		///<summary><![CDATA[TEnumAsByte<EParticleSystemUpdateMode>]]></summary>
		public const int SystemUpdateMode = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[float]]></summary>
		public const int UpdateTime_FPS = 0x002C;

		///<summary><![CDATA[float]]></summary>
		public const int UpdateTime_Delta = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int WarmupTime = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int WarmupTickRate = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x003C;

		///<summary><![CDATA[TArray<UParticleEmitter * >]]></summary>
		public const int Emitters = 0x0040;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int PreviewComponent = 0x0050;

		///<summary><![CDATA[UInterpCurveEdSetup *]]></summary>
		public const int CurveEdSetup = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOrientZAxisTowardCamera = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0061;

		///<summary><![CDATA[float]]></summary>
		public const int LODDistanceCheckTime = 0x0064;

		///<summary><![CDATA[TEnumAsByte<EParticleSystemLODMethod>]]></summary>
		public const int LODMethod = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0069;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int LODDistances = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRegenerateLODDuplicate = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData04 = 0x0081;

		///<summary><![CDATA[TArray<FParticleSystemLOD>]]></summary>
		public const int LODSettings = 0x0088;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFixedRelativeBoundingBox = 0x0098;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0099;

		///<summary><![CDATA[FBox]]></summary>
		public const int FixedRelativeBoundingBox = 0x009C;

		///<summary><![CDATA[float]]></summary>
		public const int SecondsBeforeInactive = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldResetPeakCounts = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasPhysics = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseRealtimeThumbnail = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ThumbnailImageOutOfDate = 0x00BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x00BD;

		///<summary><![CDATA[float]]></summary>
		public const int Delay = 0x00C0;

		///<summary><![CDATA[float]]></summary>
		public const int DelayLow = 0x00C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseDelayRange = 0x00C8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x00C9;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoDeactivate = 0x00CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x00CD;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int MinTimeBetweenTicks = 0x00D0;

		///<summary><![CDATA[TEnumAsByte<EParticleSystemInsignificanceReaction>]]></summary>
		public const int InsignificantReaction = 0x00D4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x00D5;

		///<summary><![CDATA[float]]></summary>
		public const int InsignificanceDelay = 0x00D8;

		///<summary><![CDATA[TEnumAsByte<EParticleSignificanceLevel>]]></summary>
		public const int MaxSignificanceLevel = 0x00DC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData10 = 0x00DD;

		///<summary><![CDATA[FVector]]></summary>
		public const int MacroUVPosition = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int MacroUVRadius = 0x00EC;

		///<summary><![CDATA[TEnumAsByte<EParticleSystemOcclusionBoundsMethod>]]></summary>
		public const int OcclusionBoundsMethod = 0x00F0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData11 = 0x00F1;

		///<summary><![CDATA[FBox]]></summary>
		public const int CustomOcclusionBounds = 0x00F4;

		///<summary><![CDATA[TArray<FLODSoloTrack>]]></summary>
		public const int SoloTracking = 0x0110;

		///<summary><![CDATA[TArray<FNamedEmitterMaterial>]]></summary>
		public const int NamedMaterialSlots = 0x0120;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData12 = 0x0130;

	}

	public class UParticleEmitter
	{
		///<summary><![CDATA[FName]]></summary>
		public const int EmitterName = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int SubUVDataOffset = 0x0030;

		///<summary><![CDATA[TEnumAsByte<EEmitterRenderMode>]]></summary>
		public const int EmitterRenderMode = 0x0034;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0035;

		///<summary><![CDATA[TArray<UParticleLODLevel * >]]></summary>
		public const int LODLevels = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ConvertedModules = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0049;

		///<summary><![CDATA[int]]></summary>
		public const int PeakActiveParticles = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int InitialAllocationCount = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int MediumDetailSpawnRateScale = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int QualityLevelSpawnRateScale = 0x0058;

		///<summary><![CDATA[TEnumAsByte<EDetailMode>]]></summary>
		public const int DetailMode = 0x005C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x005D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSoloing = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCookedOut = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisabledLODsKeepEmitterAlive = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableWhenInsignficant = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0061;

		///<summary><![CDATA[TEnumAsByte<EParticleSignificanceLevel>]]></summary>
		public const int SignificanceLevel = 0x0064;

		///<summary><![CDATA[unsigned char[0x103]]]></summary>
		public const int UnknownData04 = 0x0065;

	}

	public class UParticleSystemComponent
	{
		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int EmitterMaterials = 0x06D0;

		///<summary><![CDATA[TArray<USkeletalMeshComponent * >]]></summary>
		public const int SkelMeshComponents = 0x06E0;

		///<summary><![CDATA[unsigned char:7]]></summary>
		public const int UnknownData00 = 0x06F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bResetOnDetach = 0x06F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdateOnDedicatedServer = 0x06F1;

		///<summary><![CDATA[unsigned char:2]]></summary>
		public const int UnknownData01 = 0x06F1;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowRecycling = 0x06F1;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoManageAttachment = 0x06F1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x06F2;

		///<summary><![CDATA[TEnumAsByte<EParticleSignificanceLevel>]]></summary>
		public const int RequiredSignificance = 0x06F4;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData03 = 0x06F5;

		///<summary><![CDATA[TArray<FParticleSysParam>]]></summary>
		public const int InstanceParameters = 0x0700;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleSpawn = 0x0710;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleBurst = 0x0720;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleDeath = 0x0730;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticleCollide = 0x0740;

		///<summary><![CDATA[FVector]]></summary>
		public const int OldPosition = 0x0750;

		///<summary><![CDATA[FVector]]></summary>
		public const int PartSysVelocity = 0x075C;

		///<summary><![CDATA[float]]></summary>
		public const int WarmupTime = 0x0768;

		///<summary><![CDATA[float]]></summary>
		public const int WarmupTickRate = 0x076C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWarmingUp = 0x0770;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData04 = 0x0771;

		///<summary><![CDATA[float]]></summary>
		public const int SecondsBeforeInactive = 0x077C;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x0780;

		///<summary><![CDATA[float]]></summary>
		public const int MaxTimeBeforeForceUpdateTransform = 0x0788;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x078C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideLODMethod = 0x0790;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x0791;

		///<summary><![CDATA[TEnumAsByte<EParticleSystemLODMethod>]]></summary>
		public const int LODMethod = 0x0794;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x0795;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSkipUpdateDynamicDataDuringTick = 0x0798;

		///<summary><![CDATA[unsigned char[0x1F]]]></summary>
		public const int UnknownData09 = 0x0799;

		///<summary><![CDATA[TArray<UParticleSystemReplay * >]]></summary>
		public const int ReplayClips = 0x07B8;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData10 = 0x07C8;

		///<summary><![CDATA[float]]></summary>
		public const int CustomTimeDilation = 0x0828;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData11 = 0x082C;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSystemFinished = 0x0830;

		///<summary><![CDATA[TWeakObjectPtr<USceneComponent>]]></summary>
		public const int AutoAttachParent = 0x0840;

		///<summary><![CDATA[FName]]></summary>
		public const int AutoAttachSocketName = 0x0848;

		///<summary><![CDATA[TEnumAsByte<EAttachLocation>]]></summary>
		public const int AutoAttachLocationType = 0x0850;

		///<summary><![CDATA[TEnumAsByte<EAttachmentRule>]]></summary>
		public const int AutoAttachLocationRule = 0x0851;

		///<summary><![CDATA[TEnumAsByte<EAttachmentRule>]]></summary>
		public const int AutoAttachRotationRule = 0x0852;

		///<summary><![CDATA[TEnumAsByte<EAttachmentRule>]]></summary>
		public const int AutoAttachScaleRule = 0x0853;

		///<summary><![CDATA[unsigned char[0xFC]]]></summary>
		public const int UnknownData12 = 0x0854;

	}

	public class UCapsuleComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int CapsuleHeight = 0x06F0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x06F4;

	}

	public class USubDSurfaceComponent
	{
		///<summary><![CDATA[int]]></summary>
		public const int DebugLevel = 0x06D0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x06D4;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int DisplayMeshComponent = 0x06D8;

	}

	public class UTextRenderComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x06D0;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int TextMaterial = 0x06E0;

		///<summary><![CDATA[UFont *]]></summary>
		public const int Font = 0x06E8;

		///<summary><![CDATA[TEnumAsByte<EHorizTextAligment>]]></summary>
		public const int HorizontalAlignment = 0x06F0;

		///<summary><![CDATA[TEnumAsByte<EVerticalTextAligment>]]></summary>
		public const int VerticalAlignment = 0x06F1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x06F2;

		///<summary><![CDATA[FColor]]></summary>
		public const int TextRenderColor = 0x06F4;

		///<summary><![CDATA[float]]></summary>
		public const int XScale = 0x06F8;

		///<summary><![CDATA[float]]></summary>
		public const int YScale = 0x06FC;

		///<summary><![CDATA[float]]></summary>
		public const int WorldSize = 0x0700;

		///<summary><![CDATA[float]]></summary>
		public const int InvDefaultSize = 0x0704;

		///<summary><![CDATA[float]]></summary>
		public const int HorizSpacingAdjust = 0x0708;

		///<summary><![CDATA[float]]></summary>
		public const int VertSpacingAdjust = 0x070C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysRenderAsText = 0x0710;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData02 = 0x0711;

	}

	public class UVectorFieldComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int Intensity = 0x06D0;

		///<summary><![CDATA[float]]></summary>
		public const int Tightness = 0x06D4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPreviewVectorField = 0x06D8;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData00 = 0x06D9;

	}

	public class URadialForceComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x0300;

		///<summary><![CDATA[TEnumAsByte<ERadialImpulseFalloff>]]></summary>
		public const int Falloff = 0x0304;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0305;

		///<summary><![CDATA[float]]></summary>
		public const int ImpulseStrength = 0x0308;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bImpulseVelChange = 0x030C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreOwningActor = 0x030C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x030D;

		///<summary><![CDATA[float]]></summary>
		public const int ForceStrength = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int DestructibleDamage = 0x0314;

		///<summary><![CDATA[TArray<TEnumAsByte<EObjectTypeQuery>>]]></summary>
		public const int ObjectTypesToAffect = 0x0318;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0328;

	}

	public class UReflectionCaptureComponent
	{
		///<summary><![CDATA[UBillboardComponent *]]></summary>
		public const int CaptureOffsetComponent = 0x0300;

		///<summary><![CDATA[TEnumAsByte<EReflectionSourceType>]]></summary>
		public const int ReflectionSourceType = 0x0308;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0309;

		///<summary><![CDATA[UTextureCube *]]></summary>
		public const int Cubemap = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int SourceCubemapAngle = 0x0318;

		///<summary><![CDATA[float]]></summary>
		public const int Brightness = 0x031C;

		///<summary><![CDATA[FVector]]></summary>
		public const int CaptureOffset = 0x0320;

		///<summary><![CDATA[bool]]></summary>
		public const int bSharedComponent = 0x032C;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData01 = 0x032D;

		///<summary><![CDATA[FGuid]]></summary>
		public const int StateId = 0x033C;

		///<summary><![CDATA[unsigned char[0x34]]]></summary>
		public const int UnknownData02 = 0x034C;

	}

	public class UBoxReflectionCaptureComponent
	{
		///<summary><![CDATA[UBoxComponent *]]></summary>
		public const int PreviewInfluenceBox = 0x0380;

		///<summary><![CDATA[UBoxComponent *]]></summary>
		public const int PreviewCaptureBox = 0x0388;

	}

	public class UPlaneReflectionCaptureComponent
	{
		///<summary><![CDATA[UDrawSphereComponent *]]></summary>
		public const int PreviewInfluenceRadius = 0x0380;

		///<summary><![CDATA[UBoxComponent *]]></summary>
		public const int PreviewCaptureBox = 0x0388;

	}

	public class USphereReflectionCaptureComponent
	{
		///<summary><![CDATA[UDrawSphereComponent *]]></summary>
		public const int PreviewInfluenceRadius = 0x0380;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0388;

	}

	public class UPlanarReflectionComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int NormalDistortionStrength = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int PrefilterRoughness = 0x03C4;

		///<summary><![CDATA[float]]></summary>
		public const int PrefilterRoughnessDistance = 0x03C8;

		///<summary><![CDATA[int]]></summary>
		public const int ScreenPercentage = 0x03CC;

		///<summary><![CDATA[float]]></summary>
		public const int ExtraFOV = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceFromPlaneFadeStart = 0x03D4;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceFromPlaneFadeEnd = 0x03D8;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceFromPlaneFadeoutStart = 0x03DC;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceFromPlaneFadeoutEnd = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int AngleFromPlaneFadeStart = 0x03E4;

		///<summary><![CDATA[float]]></summary>
		public const int AngleFromPlaneFadeEnd = 0x03E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bRenderSceneTwoSided = 0x03EC;

		///<summary><![CDATA[unsigned char[0xB3]]]></summary>
		public const int UnknownData00 = 0x03ED;

	}

	public class UStereoLayerComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLiveTexture = 0x0300;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsDepth = 0x0300;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNoAlphaChannel = 0x0300;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0301;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int Texture = 0x0308;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int LeftTexture = 0x0310;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bQuadPreserveTextureRatio = 0x0318;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0319;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int QuadSize = 0x031C;

		///<summary><![CDATA[FBox2D]]></summary>
		public const int UVRect = 0x0324;

		///<summary><![CDATA[float]]></summary>
		public const int CylinderRadius = 0x0338;

		///<summary><![CDATA[float]]></summary>
		public const int CylinderOverlayArc = 0x033C;

		///<summary><![CDATA[int]]></summary>
		public const int CylinderHeight = 0x0340;

		///<summary><![CDATA[TEnumAsByte<EStereoLayerType>]]></summary>
		public const int StereoLayerType = 0x0344;

		///<summary><![CDATA[TEnumAsByte<EStereoLayerShape>]]></summary>
		public const int StereoLayerShape = 0x0345;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x0346;

		///<summary><![CDATA[int]]></summary>
		public const int Priority = 0x0348;

		///<summary><![CDATA[unsigned char[0x54]]]></summary>
		public const int UnknownData03 = 0x034C;

	}

	public class UWindDirectionalSourceComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int Strength = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int Speed = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int MinGustAmount = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int MaxGustAmount = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x0310;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPointWind = 0x0314;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData00 = 0x0315;

	}

	public class UTimelineComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00F8;

		///<summary><![CDATA[FTimeline]]></summary>
		public const int TheTimeline = 0x0100;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreTimeDilation = 0x01E0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData01 = 0x01E1;

	}

	public class UAnimSequenceBase
	{
		///<summary><![CDATA[TArray<FAnimNotifyEvent>]]></summary>
		public const int Notifies = 0x0078;

		///<summary><![CDATA[float]]></summary>
		public const int SequenceLength = 0x0088;

		///<summary><![CDATA[float]]></summary>
		public const int RateScale = 0x008C;

		///<summary><![CDATA[FRawCurveTracks]]></summary>
		public const int RawCurveData = 0x0090;

	}

	public class UAnimComposite
	{
		///<summary><![CDATA[FAnimTrack]]></summary>
		public const int AnimationTrack = 0x00A0;

	}

	public class UAnimMontage
	{
		///<summary><![CDATA[FAlphaBlend]]></summary>
		public const int BlendIn = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int BlendInTime = 0x00D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00DC;

		///<summary><![CDATA[FAlphaBlend]]></summary>
		public const int BlendOut = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int BlendOutTime = 0x0118;

		///<summary><![CDATA[float]]></summary>
		public const int BlendOutTriggerTime = 0x011C;

		///<summary><![CDATA[FName]]></summary>
		public const int SyncGroup = 0x0120;

		///<summary><![CDATA[int]]></summary>
		public const int SyncSlotIndex = 0x0128;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x012C;

		///<summary><![CDATA[FMarkerSyncData]]></summary>
		public const int MarkerData = 0x0130;

		///<summary><![CDATA[TArray<FCompositeSection>]]></summary>
		public const int CompositeSections = 0x0150;

		///<summary><![CDATA[TArray<FSlotAnimationTrack>]]></summary>
		public const int SlotAnimTracks = 0x0160;

		///<summary><![CDATA[TArray<FBranchingPoint>]]></summary>
		public const int BranchingPoints = 0x0170;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableRootMotionTranslation = 0x0180;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableRootMotionRotation = 0x0181;

		///<summary><![CDATA[TEnumAsByte<ERootMotionRootLock>]]></summary>
		public const int RootMotionRootLock = 0x0182;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData02 = 0x0183;

		///<summary><![CDATA[TArray<FBranchingPointMarker>]]></summary>
		public const int BranchingPointMarkers = 0x0188;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int BranchingPointStateNotifyIndices = 0x0198;

	}

	public class UAnimSequence
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumFrames = 0x00A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00A4;

		///<summary><![CDATA[TArray<FTrackToSkeletonMap>]]></summary>
		public const int TrackToSkeletonMapTable = 0x00A8;

		///<summary><![CDATA[unsigned char[0x90]]]></summary>
		public const int UnknownData01 = 0x00B8;

		///<summary><![CDATA[TEnumAsByte<EAdditiveAnimationType>]]></summary>
		public const int AdditiveAnimType = 0x0148;

		///<summary><![CDATA[TEnumAsByte<EAdditiveBasePoseType>]]></summary>
		public const int RefPoseType = 0x0149;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData02 = 0x014A;

		///<summary><![CDATA[UAnimSequence *]]></summary>
		public const int RefPoseSeq = 0x0150;

		///<summary><![CDATA[int]]></summary>
		public const int RefFrameIndex = 0x0158;

		///<summary><![CDATA[int]]></summary>
		public const int EncodingPkgVersion = 0x015C;

		///<summary><![CDATA[FName]]></summary>
		public const int RetargetSource = 0x0160;

		///<summary><![CDATA[TEnumAsByte<EAnimInterpolationType>]]></summary>
		public const int Interpolation = 0x0168;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableRootMotion = 0x0169;

		///<summary><![CDATA[TEnumAsByte<ERootMotionRootLock>]]></summary>
		public const int RootMotionRootLock = 0x016A;

		///<summary><![CDATA[bool]]></summary>
		public const int bForceRootLock = 0x016B;

		///<summary><![CDATA[bool]]></summary>
		public const int bRootMotionSettingsCopiedFromMontage = 0x016C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x016D;

		///<summary><![CDATA[TArray<FAnimSyncMarker>]]></summary>
		public const int AuthoredSyncMarkers = 0x0170;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData04 = 0x0180;

	}

	public class UBlendSpaceBase
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0078;

		///<summary><![CDATA[FBlendParameter[0x3]]]></summary>
		public const int BlendParameters = 0x0080;

		///<summary><![CDATA[FInterpolationParameter[0x3]]]></summary>
		public const int InterpolationParam = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int TargetWeightInterpolationSpeedPerSec = 0x00F8;

		///<summary><![CDATA[TEnumAsByte<ENotifyTriggerMode>]]></summary>
		public const int NotifyTriggerMode = 0x00FC;

		///<summary><![CDATA[bool]]></summary>
		public const int bRotationBlendInMeshSpace = 0x00FD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x00FE;

		///<summary><![CDATA[int]]></summary>
		public const int NumOfDimension = 0x0100;

		///<summary><![CDATA[float]]></summary>
		public const int AnimLength = 0x0104;

		///<summary><![CDATA[TArray<FPerBoneInterpolation>]]></summary>
		public const int PerBoneBlend = 0x0108;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0118;

		///<summary><![CDATA[TArray<FBlendSample>]]></summary>
		public const int SampleData = 0x0120;

		///<summary><![CDATA[TArray<FEditorElement>]]></summary>
		public const int GridSamples = 0x0130;

	}

	public class UBlendSpace
	{
		///<summary><![CDATA[TEnumAsByte<EBlendSpaceAxis>]]></summary>
		public const int AxisToScaleAnimation = 0x0140;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0141;

	}

	public class UBlendSpace1D
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bScaleAnimation = 0x0140;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0141;

	}

	public class UPoseAsset
	{
		///<summary><![CDATA[FPoseDataContainer]]></summary>
		public const int PoseContainer = 0x0078;

		///<summary><![CDATA[bool]]></summary>
		public const int bAdditivePose = 0x0108;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0109;

		///<summary><![CDATA[int]]></summary>
		public const int BasePoseIndex = 0x010C;

		///<summary><![CDATA[FName]]></summary>
		public const int RetargetSource = 0x0110;

		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData01 = 0x0118;

	}

	public class UAnimClassData
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FBakedAnimationStateMachine>]]></summary>
		public const int BakedStateMachines = 0x0030;

		///<summary><![CDATA[USkeleton *]]></summary>
		public const int TargetSkeleton = 0x0040;

		///<summary><![CDATA[TArray<FAnimNotifyEvent>]]></summary>
		public const int AnimNotifies = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int RootAnimNodeIndex = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x005C;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int OrderedSavedPoseIndices = 0x0060;

		///<summary><![CDATA[UStructProperty *]]></summary>
		public const int RootAnimNodeProperty = 0x0070;

		///<summary><![CDATA[TArray<UStructProperty * >]]></summary>
		public const int AnimNodeProperties = 0x0078;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int SyncGroupNames = 0x0088;

	}

	public class UAnimCompress
	{
		///<summary><![CDATA[FString]]></summary>
		public const int Description = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNeedsSkeleton = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[TEnumAsByte<EAnimationCompressionFormat>]]></summary>
		public const int TranslationCompressionFormat = 0x003C;

		///<summary><![CDATA[TEnumAsByte<EAnimationCompressionFormat>]]></summary>
		public const int RotationCompressionFormat = 0x003D;

		///<summary><![CDATA[TEnumAsByte<EAnimationCompressionFormat>]]></summary>
		public const int ScaleCompressionFormat = 0x003E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x003F;

	}

	public class UAnimCompress_Automatic
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxEndEffectorError = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTryFixedBitwiseCompression = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTryPerTrackBitwiseCompression = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTryLinearKeyRemovalCompression = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTryIntervalKeyRemoval = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRunCurrentDefaultCompressor = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoReplaceIfExistingErrorTooGreat = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRaiseMaxErrorToExisting = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0045;

	}

	public class UAnimCompress_RemoveEverySecondKey
	{
		///<summary><![CDATA[int]]></summary>
		public const int MinKeys = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStartAtSecondKey = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0045;

	}

	public class UAnimCompress_RemoveLinearKeys
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxPosDiff = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAngleDiff = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int MaxScaleDiff = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int MaxEffectorDiff = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int MinEffectorDiff = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int EffectorDiffSocket = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int ParentKeyScale = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRetarget = 0x005C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActuallyFilterLinearKeys = 0x005C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x005D;

	}

	public class UAnimCompress_PerTrackCompression
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxZeroingThreshold = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int MaxPosDiffBitwise = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAngleDiffBitwise = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int MaxScaleDiffBitwise = 0x006C;

		///<summary><![CDATA[TArray<TEnumAsByte<EAnimationCompressionFormat>>]]></summary>
		public const int AllowedRotationFormats = 0x0070;

		///<summary><![CDATA[TArray<TEnumAsByte<EAnimationCompressionFormat>>]]></summary>
		public const int AllowedTranslationFormats = 0x0080;

		///<summary><![CDATA[TArray<TEnumAsByte<EAnimationCompressionFormat>>]]></summary>
		public const int AllowedScaleFormats = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bResampleAnimation = 0x00A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00A1;

		///<summary><![CDATA[float]]></summary>
		public const int ResampledFramerate = 0x00A4;

		///<summary><![CDATA[int]]></summary>
		public const int MinKeysForResampling = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAdaptiveError = 0x00AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseOverrideForEndEffectors = 0x00AC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00AD;

		///<summary><![CDATA[int]]></summary>
		public const int TrackHeightBias = 0x00B0;

		///<summary><![CDATA[float]]></summary>
		public const int ParentingDivisor = 0x00B4;

		///<summary><![CDATA[float]]></summary>
		public const int ParentingDivisorExponent = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAdaptiveError2 = 0x00BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00BD;

		///<summary><![CDATA[float]]></summary>
		public const int RotationErrorSourceRatio = 0x00C0;

		///<summary><![CDATA[float]]></summary>
		public const int TranslationErrorSourceRatio = 0x00C4;

		///<summary><![CDATA[float]]></summary>
		public const int ScaleErrorSourceRatio = 0x00C8;

		///<summary><![CDATA[float]]></summary>
		public const int MaxErrorPerTrackRatio = 0x00CC;

		///<summary><![CDATA[float]]></summary>
		public const int PerturbationProbeSize = 0x00D0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData03 = 0x00D4;

	}

	public class UAnimCompress_RemoveTrivialKeys
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxPosDiff = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAngleDiff = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int MaxScaleDiff = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

	}

	public class UAnimSingleNodeInstance
	{
		///<summary><![CDATA[UAnimationAsset *]]></summary>
		public const int CurrentAsset = 0x0498;

		///<summary><![CDATA[unsigned char[0xC8]]]></summary>
		public const int UnknownData00 = 0x04A0;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int PostEvaluateAnimEvent = 0x0568;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0578;

	}

	public class UAnimBlueprint
	{
		///<summary><![CDATA[USkeleton *]]></summary>
		public const int TargetSkeleton = 0x0190;

		///<summary><![CDATA[TArray<FAnimGroupInfo>]]></summary>
		public const int Groups = 0x0198;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01A8;

	}

	public class UPoseWatch
	{
		///<summary><![CDATA[UEdGraphNode *]]></summary>
		public const int Node = 0x0028;

		///<summary><![CDATA[FColor]]></summary>
		public const int PoseWatchColour = 0x0030;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UAnimBlueprintGeneratedClass
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x02F8;

		///<summary><![CDATA[TArray<FBakedAnimationStateMachine>]]></summary>
		public const int BakedStateMachines = 0x0300;

		///<summary><![CDATA[USkeleton *]]></summary>
		public const int TargetSkeleton = 0x0310;

		///<summary><![CDATA[TArray<FAnimNotifyEvent>]]></summary>
		public const int AnimNotifies = 0x0318;

		///<summary><![CDATA[int]]></summary>
		public const int RootAnimNodeIndex = 0x0328;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x032C;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int OrderedSavedPoseIndices = 0x0330;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData02 = 0x0340;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int SyncGroupNames = 0x0358;

	}

	public class UVehicleAnimInstance
	{
		///<summary><![CDATA[unsigned char[0x3D8]]]></summary>
		public const int UnknownData00 = 0x0498;

		///<summary><![CDATA[UWheeledVehicleMovementComponent *]]></summary>
		public const int WheeledVehicleMovementComponent = 0x0870;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0878;

	}

	public class UAnimNotify_PlayParticleEffect
	{
		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int PSTemplate = 0x0038;

		///<summary><![CDATA[FVector]]></summary>
		public const int LocationOffset = 0x0040;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RotationOffset = 0x004C;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Attached = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0071;

		///<summary><![CDATA[FName]]></summary>
		public const int SocketName = 0x0078;

	}

	public class UAnimNotify_PlaySound
	{
		///<summary><![CDATA[USoundBase *]]></summary>
		public const int Sound = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMultiplier = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int PitchMultiplier = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFollow = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachName = 0x0050;

	}

	public class UAnimNotifyState
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UAnimNotifyState_TimedParticleEffect
	{
		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int PSTemplate = 0x0030;

		///<summary><![CDATA[FName]]></summary>
		public const int SocketName = 0x0038;

		///<summary><![CDATA[FVector]]></summary>
		public const int LocationOffset = 0x0040;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RotationOffset = 0x004C;

		///<summary><![CDATA[bool]]></summary>
		public const int bDestroyAtEnd = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0059;

	}

	public class UAnimNotifyState_Trail
	{
		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int PSTemplate = 0x0030;

		///<summary><![CDATA[FName]]></summary>
		public const int FirstSocketName = 0x0038;

		///<summary><![CDATA[FName]]></summary>
		public const int SecondSocketName = 0x0040;

		///<summary><![CDATA[TEnumAsByte<ETrailWidthMode>]]></summary>
		public const int WidthScaleMode = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[FName]]></summary>
		public const int WidthScaleCurve = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRecycleSpawnedSystems = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0059;

	}

	public class UAnimSet
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAnimRotationOnly = 0x0028;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int TrackBoneNames = 0x0030;

		///<summary><![CDATA[TArray<FAnimSetMeshLinkup>]]></summary>
		public const int LinkupCache = 0x0040;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int BoneUseAnimTranslation = 0x0050;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int ForceUseMeshTranslation = 0x0060;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int UseTranslationBoneNames = 0x0070;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int ForceMeshTranslationBoneNames = 0x0080;

		///<summary><![CDATA[FName]]></summary>
		public const int PreviewSkelMeshName = 0x0090;

		///<summary><![CDATA[FName]]></summary>
		public const int BestRatioSkelMeshName = 0x0098;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData01 = 0x00A0;

	}

	public class UAutomationTestSettings
	{
		///<summary><![CDATA[FFilePath]]></summary>
		public const int AutomationTestmap = 0x0028;

		///<summary><![CDATA[TArray<FEditorMapPerformanceTestDefinition>]]></summary>
		public const int EditorPerformanceTestMaps = 0x0038;

		///<summary><![CDATA[FBuildPromotionTestSettings]]></summary>
		public const int BuildPromotionTest = 0x0048;

		///<summary><![CDATA[FMaterialEditorPromotionSettings]]></summary>
		public const int MaterialEditorPromotionTest = 0x0238;

		///<summary><![CDATA[FParticleEditorPromotionSettings]]></summary>
		public const int ParticleEditorPromotionTest = 0x0268;

		///<summary><![CDATA[FBlueprintEditorPromotionSettings]]></summary>
		public const int BlueprintEditorPromotionTest = 0x0278;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int EngineTestModules = 0x02A8;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int EditorTestModules = 0x02B8;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int TestLevelFolders = 0x02C8;

		///<summary><![CDATA[TArray<FOpenTestAsset>]]></summary>
		public const int TestAssetsToOpen = 0x02D8;

		///<summary><![CDATA[TArray<FExternalToolDefinition>]]></summary>
		public const int ExternalTools = 0x02E8;

		///<summary><![CDATA[TArray<FEditorImportExportTestDefinition>]]></summary>
		public const int ImportExportTestDefinitions = 0x02F8;

		///<summary><![CDATA[TArray<FLaunchOnTestSettings>]]></summary>
		public const int LaunchOnSettings = 0x0308;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int DefaultScreenshotResolution = 0x0318;

	}

	public class UAvoidanceManager
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultTimeToLive = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int LockTimeAfterAvoid = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int LockTimeAfterClean = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int DeltaTimeToPredict = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int ArtificialRadiusExpansion = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int TestHeightDifference = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int HeightCheckMargin = 0x0048;

		///<summary><![CDATA[unsigned char[0x94]]]></summary>
		public const int UnknownData01 = 0x004C;

	}

	public class UBlendProfile
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[USkeleton *]]></summary>
		public const int OwningSkeleton = 0x0030;

		///<summary><![CDATA[TArray<FBlendProfileBoneEntry>]]></summary>
		public const int ProfileEntries = 0x0038;

	}

	public class UPlatformGameInstance
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationWillDeactivateDelegate = 0x00F0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationHasReactivatedDelegate = 0x0100;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationWillEnterBackgroundDelegate = 0x0110;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationHasEnteredForegroundDelegate = 0x0120;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationWillTerminateDelegate = 0x0130;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationRegisteredForRemoteNotificationsDelegate = 0x0140;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationRegisteredForUserNotificationsDelegate = 0x0150;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationFailedToRegisterForRemoteNotificationsDelegate = 0x0160;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationReceivedRemoteNotificationDelegate = 0x0170;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationReceivedLocalNotificationDelegate = 0x0180;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ApplicationReceivedScreenOrientationChangedNotificationDelegate = 0x0190;

	}

	public class UDataTable
	{
		///<summary><![CDATA[UScriptStruct *]]></summary>
		public const int RowStruct = 0x0028;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UDeveloperSettings
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCollisionProfile
	{
		///<summary><![CDATA[TArray<FCollisionResponseTemplate>]]></summary>
		public const int Profiles = 0x0038;

		///<summary><![CDATA[TArray<FCustomChannelSetup>]]></summary>
		public const int DefaultChannelResponses = 0x0048;

		///<summary><![CDATA[TArray<FCustomProfile>]]></summary>
		public const int EditProfiles = 0x0058;

		///<summary><![CDATA[TArray<FRedirector>]]></summary>
		public const int ProfileRedirects = 0x0068;

		///<summary><![CDATA[TArray<FRedirector>]]></summary>
		public const int CollisionChannelRedirects = 0x0078;

		///<summary><![CDATA[unsigned char[0xD0]]]></summary>
		public const int UnknownData00 = 0x0088;

	}

	public class UPendingNetGame
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UNetDriver *]]></summary>
		public const int NetDriver = 0x0030;

		///<summary><![CDATA[UDemoNetDriver *]]></summary>
		public const int DemoNetDriver = 0x0038;

		///<summary><![CDATA[unsigned char[0x88]]]></summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UBodySetup
	{
		///<summary><![CDATA[FKAggregateGeom]]></summary>
		public const int AggGeom = 0x0028;

		///<summary><![CDATA[FName]]></summary>
		public const int BoneName = 0x0070;

		///<summary><![CDATA[TEnumAsByte<EPhysicsType>]]></summary>
		public const int PhysicsType = 0x0078;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0079;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysFullAnimWeight = 0x007C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConsiderForBounds = 0x007C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMeshCollideAll = 0x007C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDoubleSidedGeometry = 0x007C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateNonMirroredCollision = 0x007C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSharedCookedData = 0x007C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateMirroredCollision = 0x007C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x007D;

		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int PhysMaterial = 0x0080;

		///<summary><![CDATA[TEnumAsByte<EBodyCollisionResponse>]]></summary>
		public const int CollisionReponse = 0x0088;

		///<summary><![CDATA[TEnumAsByte<ECollisionTraceFlag>]]></summary>
		public const int CollisionTraceFlag = 0x0089;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData02 = 0x008A;

		///<summary><![CDATA[FBodyInstance]]></summary>
		public const int DefaultInstance = 0x0090;

		///<summary><![CDATA[FWalkableSlopeOverride]]></summary>
		public const int WalkableSlopeOverride = 0x0250;

		///<summary><![CDATA[float]]></summary>
		public const int BuildScale = 0x0258;

		///<summary><![CDATA[FVector]]></summary>
		public const int BuildScale3D = 0x025C;

		///<summary><![CDATA[unsigned char[0xB8]]]></summary>
		public const int UnknownData03 = 0x0268;

	}

	public class UBodySetup2D
	{
		///<summary><![CDATA[FAggregateGeometry2D]]></summary>
		public const int AggGeom2D = 0x0320;

	}

	public class UPhysicsAsset
	{
		///<summary><![CDATA[TArray<int>]]></summary>
		public const int BoundsBodies = 0x0028;

		///<summary><![CDATA[TArray<USkeletalBodySetup * >]]></summary>
		public const int SkeletalBodySetups = 0x0038;

		///<summary><![CDATA[TArray<UPhysicsConstraintTemplate * >]]></summary>
		public const int ConstraintSetup = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAsyncScene = 0x0058;

		///<summary><![CDATA[unsigned char[0xA7]]]></summary>
		public const int UnknownData00 = 0x0059;

		///<summary><![CDATA[TArray<UBodySetup * >]]></summary>
		public const int BodySetup = 0x0100;

	}

	public class USkeletalBodySetup
	{
		///<summary><![CDATA[TArray<FPhysicalAnimationProfile>]]></summary>
		public const int PhysicalAnimationData = 0x0320;

	}

	public class UBoneMaskFilter
	{
		///<summary><![CDATA[TArray<FInputBlendPose>]]></summary>
		public const int BlendPoses = 0x0028;

	}

	public class UBookMark
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int Location = 0x0028;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rotation = 0x0034;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HiddenLevels = 0x0040;

	}

	public class UBookMark2D
	{
		///<summary><![CDATA[float]]></summary>
		public const int Zoom2D = 0x0028;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int Location = 0x002C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UBreakpoint
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x0028;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[UEdGraphNode *]]></summary>
		public const int Node = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStepOnce = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStepOnce_WasPreviouslyDisabled = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStepOnce_RemoveAfterHit = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0039;

	}

	public class UBrushBuilder
	{
		///<summary><![CDATA[FString]]></summary>
		public const int BitmapFilename = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int ToolTip = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int NotifyBadParams = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int Vertices = 0x0050;

		///<summary><![CDATA[TArray<FBuilderPoly>]]></summary>
		public const int Polys = 0x0060;

		///<summary><![CDATA[FName]]></summary>
		public const int Layer = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int MergeCoplanars = 0x0078;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0079;

	}

	public class UButtonStyleAsset
	{
		///<summary><![CDATA[FButtonStyle]]></summary>
		public const int ButtonStyle = 0x0028;

	}

	public class UCameraAnim
	{
		///<summary><![CDATA[UInterpGroup *]]></summary>
		public const int CameraInterpGroup = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int AnimLength = 0x0030;

		///<summary><![CDATA[FBox]]></summary>
		public const int BoundingBox = 0x0034;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRelativeToInitialTransform = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRelativeToInitialFOV = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[float]]></summary>
		public const int BaseFOV = 0x0054;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0058;

		///<summary><![CDATA[FPostProcessSettings]]></summary>
		public const int BasePostProcessSettings = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int BasePostProcessBlendWeight = 0x0540;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData02 = 0x0544;

	}

	public class UCameraAnimInst
	{
		///<summary><![CDATA[UCameraAnim *]]></summary>
		public const int CamAnim = 0x0028;

		///<summary><![CDATA[UInterpGroupInst *]]></summary>
		public const int InterpGroupInst = 0x0030;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x0050;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData01 = 0x0054;

		///<summary><![CDATA[UInterpTrackMove *]]></summary>
		public const int MoveTrack = 0x0068;

		///<summary><![CDATA[UInterpTrackInstMove *]]></summary>
		public const int MoveInst = 0x0070;

		///<summary><![CDATA[TEnumAsByte<ECameraAnimPlaySpace>]]></summary>
		public const int PlaySpace = 0x0078;

		///<summary><![CDATA[unsigned char[0x97]]]></summary>
		public const int UnknownData02 = 0x0079;

	}

	public class UCameraModifier
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDebug = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bExclusive = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int Priority = 0x002C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x002D;

		///<summary><![CDATA[APlayerCameraManager *]]></summary>
		public const int CameraOwner = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int AlphaInTime = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int AlphaOutTime = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int Alpha = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0044;

	}

	public class UCameraModifier_CameraShake
	{
		///<summary><![CDATA[TArray<UCameraShake * >]]></summary>
		public const int ActiveShakes = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int SplitScreenShakeScale = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x005C;

	}

	public class UCanvas
	{
		///<summary><![CDATA[float]]></summary>
		public const int OrgX = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int OrgY = 0x002C;

		///<summary><![CDATA[float]]></summary>
		public const int ClipX = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int ClipY = 0x0034;

		///<summary><![CDATA[FColor]]></summary>
		public const int DrawColor = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCenterX = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCenterY = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNoSmooth = 0x003C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x003D;

		///<summary><![CDATA[int]]></summary>
		public const int SizeX = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int SizeY = 0x0044;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0048;

		///<summary><![CDATA[FPlane]]></summary>
		public const int ColorModulate = 0x0050;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DefaultTexture = 0x0060;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int GradientTexture0 = 0x0068;

		///<summary><![CDATA[UReporterGraph *]]></summary>
		public const int ReporterGraph = 0x0070;

		///<summary><![CDATA[unsigned char[0x258]]]></summary>
		public const int UnknownData02 = 0x0078;

	}

	public class UChannel
	{
		///<summary><![CDATA[UNetConnection *]]></summary>
		public const int Connection = 0x0028;

		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UActorChannel
	{
		///<summary><![CDATA[AActor *]]></summary>
		public const int Actor = 0x0068;

		///<summary><![CDATA[unsigned char[0x1C0]]]></summary>
		public const int UnknownData00 = 0x0070;

	}

	public class UDemoActorChannel
	{
		///<summary><![CDATA[unsigned char[0x98]]]></summary>
		public const int UnknownData00 = 0x0230;

	}

	public class UControlChannel
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0068;

	}

	public class UVoiceChannel
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0068;

	}

	public class UCheckBoxStyleAsset
	{
		///<summary><![CDATA[FCheckBoxStyle]]></summary>
		public const int CheckBoxStyle = 0x0028;

	}

	public class UCommandlet
	{
		///<summary><![CDATA[FString]]></summary>
		public const int HelpDescription = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int HelpUsage = 0x0038;

		///<summary><![CDATA[FString]]></summary>
		public const int HelpWebLink = 0x0048;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HelpParamNames = 0x0058;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HelpParamDescriptions = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int IsServer = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int IsClient = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int IsEditor = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int LogToConsole = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ShowErrorCount = 0x0078;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0079;

	}

	public class UPluginCommandlet
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0080;

	}

	public class UCurveLinearColor
	{
		///<summary><![CDATA[FRichCurve[0x4]]]></summary>
		public const int FloatCurves = 0x0030;

	}

	public class UCurveVector
	{
		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int FloatCurves = 0x0030;

	}

	public class UCurveTable
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UPreviewMeshCollection
	{
		///<summary><![CDATA[USkeleton *]]></summary>
		public const int Skeleton = 0x0028;

		///<summary><![CDATA[TArray<FPreviewMeshCollectionEntry>]]></summary>
		public const int SkeletalMeshes = 0x0030;

	}

	public class UTireType
	{
		///<summary><![CDATA[float]]></summary>
		public const int FrictionScale = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UNetDriver
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int NetConnectionClassName = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int MaxDownloadSize = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClampListenServerTickRate = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0045;

		///<summary><![CDATA[int]]></summary>
		public const int NetServerMaxTickRate = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int MaxInternetClientRate = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int MaxClientRate = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int ServerTravelPause = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int SpawnPrioritySeconds = 0x0058;

		///<summary><![CDATA[float]]></summary>
		public const int RelevantTimeout = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int KeepAliveTime = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int InitialConnectTimeout = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int ConnectionTimeout = 0x0068;

		///<summary><![CDATA[bool]]></summary>
		public const int bNoTimeouts = 0x006C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x006D;

		///<summary><![CDATA[UNetConnection *]]></summary>
		public const int ServerConnection = 0x0070;

		///<summary><![CDATA[TArray<UNetConnection * >]]></summary>
		public const int ClientConnections = 0x0078;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData03 = 0x0088;

		///<summary><![CDATA[UWorld *]]></summary>
		public const int World = 0x00A0;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData04 = 0x00A8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int NetConnectionClass = 0x00C8;

		///<summary><![CDATA[UProperty *]]></summary>
		public const int RoleProperty = 0x00D0;

		///<summary><![CDATA[UProperty *]]></summary>
		public const int RemoteRoleProperty = 0x00D8;

		///<summary><![CDATA[FName]]></summary>
		public const int NetDriverName = 0x00E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x00E8;

		///<summary><![CDATA[float]]></summary>
		public const int Time = 0x00F0;

		///<summary><![CDATA[unsigned char[0x324]]]></summary>
		public const int UnknownData06 = 0x00F4;

	}

	public class UPackageMapClient
	{
		///<summary><![CDATA[unsigned char[0x240]]]></summary>
		public const int UnknownData00 = 0x00E0;

	}

	public class UNetConnection
	{
		///<summary><![CDATA[TArray<UChildConnection * >]]></summary>
		public const int Children = 0x0048;

		///<summary><![CDATA[UNetDriver *]]></summary>
		public const int Driver = 0x0058;

		///<summary><![CDATA[UPackageMap *]]></summary>
		public const int PackageMap = 0x0060;

		///<summary><![CDATA[TArray<UChannel * >]]></summary>
		public const int OpenChannels = 0x0068;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int SentTemporaries = 0x0078;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ViewTarget = 0x0088;

		///<summary><![CDATA[AActor *]]></summary>
		public const int OwningActor = 0x0090;

		///<summary><![CDATA[int]]></summary>
		public const int MaxPacket = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int InternalAck = 0x009C;

		///<summary><![CDATA[unsigned char[0xB3]]]></summary>
		public const int UnknownData00 = 0x009D;

		///<summary><![CDATA[FUniqueNetIdRepl]]></summary>
		public const int PlayerId = 0x0150;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData01 = 0x0168;

		///<summary><![CDATA[double]]></summary>
		public const int LastReceiveTime = 0x01D0;

	}

	public class UDemoNetConnection
	{
	}

	public class UDemoNetDriver
	{
		///<summary><![CDATA[unsigned char[0x4F8]]]></summary>
		public const int UnknownData00 = 0x0418;

	}

	public class UDestructibleFractureSettings
	{
		///<summary><![CDATA[int]]></summary>
		public const int CellSiteCount = 0x0028;

		///<summary><![CDATA[FFractureMaterial]]></summary>
		public const int FractureMaterialDesc = 0x002C;

		///<summary><![CDATA[int]]></summary>
		public const int RandomSeed = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0054;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int VoronoiSites = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int OriginalSubmeshCount = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x006C;

		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int Materials = 0x0070;

		///<summary><![CDATA[TArray<FDestructibleChunkParameters>]]></summary>
		public const int ChunkParameters = 0x0080;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData02 = 0x0090;

	}

	public class UAnimationSettings
	{
		///<summary><![CDATA[int]]></summary>
		public const int CompressCommandletVersion = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int KeyEndEffectorsMatchNameArray = 0x0040;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultCompressionAlgorithm = 0x0050;

		///<summary><![CDATA[TEnumAsByte<EAnimationCompressionFormat>]]></summary>
		public const int RotationCompressionFormat = 0x0058;

		///<summary><![CDATA[TEnumAsByte<EAnimationCompressionFormat>]]></summary>
		public const int TranslationCompressionFormat = 0x0059;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x005A;

		///<summary><![CDATA[float]]></summary>
		public const int AlternativeCompressionThreshold = 0x005C;

		///<summary><![CDATA[bool]]></summary>
		public const int ForceRecompression = 0x0060;

		///<summary><![CDATA[bool]]></summary>
		public const int bOnlyCheckForMissingSkeletalMeshes = 0x0061;

		///<summary><![CDATA[bool]]></summary>
		public const int bForceBelowThreshold = 0x0062;

		///<summary><![CDATA[bool]]></summary>
		public const int bFirstRecompressUsingCurrentOrDefault = 0x0063;

		///<summary><![CDATA[bool]]></summary>
		public const int bRaiseMaxErrorToExisting = 0x0064;

		///<summary><![CDATA[bool]]></summary>
		public const int bTryFixedBitwiseCompression = 0x0065;

		///<summary><![CDATA[bool]]></summary>
		public const int bTryPerTrackBitwiseCompression = 0x0066;

		///<summary><![CDATA[bool]]></summary>
		public const int bTryLinearKeyRemovalCompression = 0x0067;

		///<summary><![CDATA[bool]]></summary>
		public const int bTryIntervalKeyRemoval = 0x0068;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnablePerformanceLog = 0x0069;

		///<summary><![CDATA[bool]]></summary>
		public const int bStripAnimationDataOnDedicatedServer = 0x006A;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData02 = 0x006B;

	}

	public class UAudioSettings
	{
		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultSoundClassName = 0x0038;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultSoundConcurrencyName = 0x0048;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultSoundSubmixName = 0x0058;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultBaseSoundMix = 0x0068;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int VoiPSoundClass = 0x0078;

		///<summary><![CDATA[float]]></summary>
		public const int LowPassFilterResonance = 0x0088;

		///<summary><![CDATA[int]]></summary>
		public const int MaximumConcurrentStreams = 0x008C;

		///<summary><![CDATA[TArray<FAudioQualitySettings>]]></summary>
		public const int QualityLevels = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowVirtualizedSounds = 0x00A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00A1;

		///<summary><![CDATA[FString]]></summary>
		public const int DialogueFilenameFormat = 0x00A8;

	}

	public class UUserInterfaceSettings
	{
		///<summary><![CDATA[TEnumAsByte<ERenderFocusRule>]]></summary>
		public const int RenderFocusRule = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int DefaultCursor = 0x0040;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int TextEditBeamCursor = 0x0050;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int CrosshairsCursor = 0x0060;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int HandCursor = 0x0070;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GrabHandCursor = 0x0080;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int GrabHandClosedCursor = 0x0090;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int SlashedCircleCursor = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int ApplicationScale = 0x00B0;

		///<summary><![CDATA[TEnumAsByte<EUIScalingRule>]]></summary>
		public const int UIScaleRule = 0x00B4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00B5;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int CustomScalingRuleClass = 0x00B8;

		///<summary><![CDATA[FRuntimeFloatCurve]]></summary>
		public const int UIScaleCurve = 0x00C8;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int CursorClasses = 0x0148;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CustomScalingRuleClassInstance = 0x0158;

		///<summary><![CDATA[UDPICustomScalingRule *]]></summary>
		public const int CustomScalingRule = 0x0160;

	}

	public class UStreamingSettings
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int AsyncLoadingThreadEnabled = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int WarnIfTimeLimitExceeded = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[float]]></summary>
		public const int TimeLimitExceededMultiplier = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int TimeLimitExceededMinTime = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int MinBulkDataSizeForAsyncLoading = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int AsyncIOBandwidthLimit = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UseBackgroundLevelStreaming = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int AsyncLoadingUseFullTimeLimit = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int LoadAllStreamingLevels = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x004D;

		///<summary><![CDATA[float]]></summary>
		public const int AsyncLoadingTimeLimit = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int PriorityAsyncLoadingExtraTime = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int LevelStreamingActorsUpdateTimeLimit = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int LevelStreamingComponentsRegistrationGranularity = 0x005C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int EventDrivenLoaderEnabled = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0061;

	}

	public class UGarbageCollectionSettings
	{
		///<summary><![CDATA[float]]></summary>
		public const int TimeBetweenPurgingPendingKillObjects = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int FlushStreamingOnGC = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int AllowParallelGC = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CreateGCClusters = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int MergeGCClusters = 0x003C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x003D;

		///<summary><![CDATA[int]]></summary>
		public const int NumRetriesBeforeForcingGC = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int MaxObjectsNotConsideredByGC = 0x0044;

		///<summary><![CDATA[int]]></summary>
		public const int SizeOfPermanentObjectPool = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int MaxObjectsInGame = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int MaxObjectsInEditor = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0054;

	}

	public class UMeshSimplificationSettings
	{
		///<summary><![CDATA[FName]]></summary>
		public const int MeshReductionModuleName = 0x0038;

	}

	public class UNetworkSettings
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVerifyPeer = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableMultiplayerWorldOriginRebasing = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

	}

	public class UPhysicsSettings
	{
		///<summary><![CDATA[float]]></summary>
		public const int DefaultGravityZ = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultTerminalVelocity = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultFluidFriction = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int SimulateScratchMemorySize = 0x0044;

		///<summary><![CDATA[int]]></summary>
		public const int RagdollAggregateThreshold = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int TriangleMeshTriangleMinAreaThreshold = 0x004C;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableAsyncScene = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableShapeSharing = 0x0051;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableAsyncSceneOnDedicatedServer = 0x0052;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableShapeSharingOnDedicatedServer = 0x0053;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnablePCM = 0x0054;

		///<summary><![CDATA[bool]]></summary>
		public const int bWarnMissingLocks = 0x0055;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnable2DPhysics = 0x0056;

		///<summary><![CDATA[TEnumAsByte<ESettingsLockedAxis>]]></summary>
		public const int LockedAxis = 0x0057;

		///<summary><![CDATA[TEnumAsByte<ESettingsDOF>]]></summary>
		public const int DefaultDegreesOfFreedom = 0x0058;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0059;

		///<summary><![CDATA[float]]></summary>
		public const int BounceThresholdVelocity = 0x005C;

		///<summary><![CDATA[TEnumAsByte<EFrictionCombineMode>]]></summary>
		public const int FrictionCombineMode = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EFrictionCombineMode>]]></summary>
		public const int RestitutionCombineMode = 0x0061;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x0062;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAngularVelocity = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDepenetrationVelocity = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int ContactOffsetMultiplier = 0x006C;

		///<summary><![CDATA[float]]></summary>
		public const int MinContactOffset = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int MaxContactOffset = 0x0074;

		///<summary><![CDATA[bool]]></summary>
		public const int bSimulateSkeletalMeshOnDedicatedServer = 0x0078;

		///<summary><![CDATA[TEnumAsByte<ECollisionTraceFlag>]]></summary>
		public const int DefaultShapeComplexity = 0x0079;

		///<summary><![CDATA[bool]]></summary>
		public const int bDefaultHasComplexCollision = 0x007A;

		///<summary><![CDATA[bool]]></summary>
		public const int bSuppressFaceRemapTable = 0x007B;

		///<summary><![CDATA[bool]]></summary>
		public const int bSupportUVFromHitResults = 0x007C;

		///<summary><![CDATA[bool]]></summary>
		public const int bDisableActiveActors = 0x007D;

		///<summary><![CDATA[bool]]></summary>
		public const int bDisableCCD = 0x007E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x007F;

		///<summary><![CDATA[float]]></summary>
		public const int MaxPhysicsDeltaTime = 0x0080;

		///<summary><![CDATA[bool]]></summary>
		public const int bSubstepping = 0x0084;

		///<summary><![CDATA[bool]]></summary>
		public const int bSubsteppingAsync = 0x0085;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData03 = 0x0086;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSubstepDeltaTime = 0x0088;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSubsteps = 0x008C;

		///<summary><![CDATA[float]]></summary>
		public const int SyncSceneSmoothingFactor = 0x0090;

		///<summary><![CDATA[float]]></summary>
		public const int AsyncSceneSmoothingFactor = 0x0094;

		///<summary><![CDATA[float]]></summary>
		public const int InitialAverageFrameRate = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int MaxPhysicsDeltaTimeOnDedicatedServer = 0x009C;

		///<summary><![CDATA[bool]]></summary>
		public const int bSubsteppingOnDedicatedServer = 0x00A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bSubsteppingAsyncOnDedicatedServer = 0x00A1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData04 = 0x00A2;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSubstepDeltaTimeOnDedicatedServer = 0x00A4;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSubstepsOnDedicatedServer = 0x00A8;

		///<summary><![CDATA[float]]></summary>
		public const int SyncSceneSmoothingFactorOnDedicatedServer = 0x00AC;

		///<summary><![CDATA[float]]></summary>
		public const int AsyncSceneSmoothingFactorOnDedicatedServer = 0x00B0;

		///<summary><![CDATA[float]]></summary>
		public const int InitialAverageFrameRateOnDedicatedServer = 0x00B4;

		///<summary><![CDATA[TArray<FPhysicalSurfaceName>]]></summary>
		public const int PhysicalSurfaces = 0x00B8;

	}

	public class URendererSettings
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMobileHDR = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int MobileNumDynamicPointLights = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMobileDynamicPointLightsUseStaticBranch = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMobileEnableStaticAndCSMShadowReceivers = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMobileDisableVertexFog = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDiscardUnusedQualityLevels = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOcclusionCulling = 0x0040;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0041;

		///<summary><![CDATA[float]]></summary>
		public const int MinScreenRadiusForLights = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int MinScreenRadiusForEarlyZPass = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int MinScreenRadiusForCSMdepth = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPrecomputedVisibilityWarning = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTextureStreaming = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseDXT5NormalMaps = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClearCoatEnableSecondNormal = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0051;

		///<summary><![CDATA[int]]></summary>
		public const int ReflectionCaptureResolution = 0x0054;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ReflectionEnvironmentLightmapMixBasedOnRoughness = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForwardShading = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVertexFoggingForOpaque = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowStaticLighting = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseNormalMapsForStaticLighting = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateMeshDistanceFields = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateLandscapeGIData = 0x0058;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0059;

		///<summary><![CDATA[float]]></summary>
		public const int TessellationAdaptivePixelsPerTriangle = 0x005C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSeparateTranslucency = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0061;

		///<summary><![CDATA[TEnumAsByte<ETranslucentSortPolicy>]]></summary>
		public const int TranslucentSortPolicy = 0x0064;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0065;

		///<summary><![CDATA[FVector]]></summary>
		public const int TranslucentSortAxis = 0x0068;

		///<summary><![CDATA[TEnumAsByte<ECustomDepthStencil>]]></summary>
		public const int CustomDepthStencil = 0x0074;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0075;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultFeatureBloom = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultFeatureAmbientOcclusion = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultFeatureAmbientOcclusionStaticFraction = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultFeatureAutoExposure = 0x0078;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x0079;

		///<summary><![CDATA[TEnumAsByte<EAutoExposureMethodUI>]]></summary>
		public const int DefaultFeatureAutoExposure = 0x007C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x007D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultFeatureMotionBlur = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultFeatureLensFlare = 0x0080;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0081;

		///<summary><![CDATA[TEnumAsByte<EAntiAliasingMethod>]]></summary>
		public const int DefaultFeatureAntiAliasing = 0x0084;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData10 = 0x0085;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStencilForLODDither = 0x0088;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData11 = 0x0089;

		///<summary><![CDATA[TEnumAsByte<EEarlyZPass>]]></summary>
		public const int EarlyZPass = 0x008C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData12 = 0x008D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEarlyZPassMovable = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDBuffer = 0x0090;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData13 = 0x0091;

		///<summary><![CDATA[TEnumAsByte<EClearSceneOptions>]]></summary>
		public const int ClearSceneMethod = 0x0094;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData14 = 0x0095;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBasePassOutputsVelocity = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSelectiveBasePassOutputs = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefaultParticleCutouts = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGlobalClipPlane = 0x0098;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData15 = 0x0099;

		///<summary><![CDATA[TEnumAsByte<EGBufferFormat>]]></summary>
		public const int GBufferFormat = 0x009C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData16 = 0x009D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseGPUMorphTargets = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInstancedStereo = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMultiView = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMobileMultiView = 0x00A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData17 = 0x00A1;

		///<summary><![CDATA[float]]></summary>
		public const int WireframeCullThreshold = 0x00A4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportStationarySkylight = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportLowQualityLightmaps = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportPointLightWholeSceneShadows = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportAtmosphericFog = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportSkinCacheShaders = 0x00A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData18 = 0x00A9;

	}

	public class URendererOverrideSettings
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportAllShaderPermutations = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

	}

	public class UTextureLODSettings
	{
		///<summary><![CDATA[TArray<FTextureLODGroup>]]></summary>
		public const int TextureLODGroups = 0x0028;

	}

	public class UDeviceProfile
	{
		///<summary><![CDATA[FString]]></summary>
		public const int DeviceType = 0x0038;

		///<summary><![CDATA[FString]]></summary>
		public const int BaseProfileName = 0x0048;

		///<summary><![CDATA[UObject *]]></summary>
		public const int Parent = 0x0058;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0060;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int CVars = 0x0068;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData01 = 0x0078;

	}

	public class UDeviceProfileManager
	{
		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int Profiles = 0x0028;

		///<summary><![CDATA[unsigned char[0xD8]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UDialogueVoice
	{
		///<summary><![CDATA[TEnumAsByte<EGrammaticalGender>]]></summary>
		public const int Gender = 0x0028;

		///<summary><![CDATA[TEnumAsByte<EGrammaticalNumber>]]></summary>
		public const int Plurality = 0x0029;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x002A;

		///<summary><![CDATA[FGuid]]></summary>
		public const int LocalizationGUID = 0x002C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x003C;

	}

	public class UDialogueWave
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMature = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_SubtitleOverride = 0x0028;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[FString]]></summary>
		public const int SpokenText = 0x0030;

		///<summary><![CDATA[FString]]></summary>
		public const int SubtitleOverride = 0x0040;

		///<summary><![CDATA[TArray<FDialogueContextMapping>]]></summary>
		public const int ContextMappings = 0x0050;

		///<summary><![CDATA[FGuid]]></summary>
		public const int LocalizationGUID = 0x0060;

	}

	public class UDistribution
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UDistributionFloat
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanBeBaked = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData00 = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBakedDataSuccesfully = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0031;

	}

	public class UDistributionFloatConstant
	{
		///<summary><![CDATA[float]]></summary>
		public const int Constant = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UDistributionFloatParameterBase
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int MinInput = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int MaxInput = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int MinOutput = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int MaxOutput = 0x0054;

		///<summary><![CDATA[TEnumAsByte<EDistributionParamMode>]]></summary>
		public const int ParamMode = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0059;

	}

	public class UDistributionFloatConstantCurve
	{
		///<summary><![CDATA[FInterpCurveFloat]]></summary>
		public const int ConstantCurve = 0x0038;

	}

	public class UDistributionFloatUniform
	{
		///<summary><![CDATA[float]]></summary>
		public const int Min = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int Max = 0x003C;

	}

	public class UDistributionFloatUniformCurve
	{
		///<summary><![CDATA[FInterpCurveVector2D]]></summary>
		public const int ConstantCurve = 0x0038;

	}

	public class UDistributionVector
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanBeBaked = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsDirty = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBakedDataSuccesfully = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UDistributionVectorConstant
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int Constant = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockAxes = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0045;

		///<summary><![CDATA[TEnumAsByte<EDistributionVectorLockFlags>]]></summary>
		public const int LockedAxes = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0049;

	}

	public class UDistributionVectorParameterBase
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0050;

		///<summary><![CDATA[FVector]]></summary>
		public const int MinInput = 0x0058;

		///<summary><![CDATA[FVector]]></summary>
		public const int MaxInput = 0x0064;

		///<summary><![CDATA[FVector]]></summary>
		public const int MinOutput = 0x0070;

		///<summary><![CDATA[FVector]]></summary>
		public const int MaxOutput = 0x007C;

		///<summary><![CDATA[TEnumAsByte<EDistributionParamMode>[0x3]]]></summary>
		public const int ParamModes = 0x0088;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x008B;

	}

	public class UDistributionVectorConstantCurve
	{
		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int ConstantCurve = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockAxes = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[TEnumAsByte<EDistributionVectorLockFlags>]]></summary>
		public const int LockedAxes = 0x0054;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0055;

	}

	public class UDistributionVectorUniform
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int Max = 0x0038;

		///<summary><![CDATA[FVector]]></summary>
		public const int Min = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockAxes = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[TEnumAsByte<EDistributionVectorLockFlags>]]></summary>
		public const int LockedAxes = 0x0054;

		///<summary><![CDATA[TEnumAsByte<EDistributionVectorMirrorFlags>[0x3]]]></summary>
		public const int MirrorFlags = 0x0055;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseExtremes = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0059;

	}

	public class UDistributionVectorUniformCurve
	{
		///<summary><![CDATA[FInterpCurveTwoVectors]]></summary>
		public const int ConstantCurve = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockAxes1 = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockAxes2 = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[TEnumAsByte<EDistributionVectorLockFlags>[0x2]]]></summary>
		public const int LockedAxes = 0x0054;

		///<summary><![CDATA[TEnumAsByte<EDistributionVectorMirrorFlags>[0x3]]]></summary>
		public const int MirrorFlags = 0x0056;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0059;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseExtremes = 0x005C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x005D;

	}

	public class UComponentDelegateBinding
	{
		///<summary><![CDATA[TArray<FBlueprintComponentDelegateBinding>]]></summary>
		public const int ComponentDelegateBindings = 0x0028;

	}

	public class UInputActionDelegateBinding
	{
		///<summary><![CDATA[TArray<FBlueprintInputActionDelegateBinding>]]></summary>
		public const int InputActionDelegateBindings = 0x0028;

	}

	public class UInputAxisDelegateBinding
	{
		///<summary><![CDATA[TArray<FBlueprintInputAxisDelegateBinding>]]></summary>
		public const int InputAxisDelegateBindings = 0x0028;

	}

	public class UInputAxisKeyDelegateBinding
	{
		///<summary><![CDATA[TArray<FBlueprintInputAxisKeyDelegateBinding>]]></summary>
		public const int InputAxisKeyDelegateBindings = 0x0028;

	}

	public class UInputKeyDelegateBinding
	{
		///<summary><![CDATA[TArray<FBlueprintInputKeyDelegateBinding>]]></summary>
		public const int InputKeyDelegateBindings = 0x0028;

	}

	public class UInputTouchDelegateBinding
	{
		///<summary><![CDATA[TArray<FBlueprintInputTouchDelegateBinding>]]></summary>
		public const int InputTouchDelegateBindings = 0x0028;

	}

	public class UEdGraph
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int Schema = 0x0028;

		///<summary><![CDATA[TArray<UEdGraphNode * >]]></summary>
		public const int Nodes = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEditable = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowDeletion = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowRenaming = 0x0040;

		///<summary><![CDATA[unsigned char[0x7F]]]></summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UEdGraphNode_Documentation
	{
		///<summary><![CDATA[FString]]></summary>
		public const int Link = 0x00A0;

		///<summary><![CDATA[FString]]></summary>
		public const int Excerpt = 0x00B0;

	}

	public class UEndUserSettings
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bSendAnonymousUsageDataToEpic = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int bSendMeanTimeBetweenFailureDataToEpic = 0x0031;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowUserIdInUsageData = 0x0032;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData01 = 0x0033;

	}

	public class UExporter
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int SupportedClass = 0x0028;

		///<summary><![CDATA[UObject *]]></summary>
		public const int ExportRootScope = 0x0030;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int FormatExtension = 0x0038;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int FormatDescription = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int PreferredFormatIndex = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int TextIndent = 0x005C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bText = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSelectedOnly = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceFileOperations = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UExtendedReflectionSettings
	{
		///<summary><![CDATA[float]]></summary>
		public const int GlobalOverrideIntensity = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int StreamingSectionSize = 0x002C;

		///<summary><![CDATA[TArray<FExtendedReflectionSharedCubemap>]]></summary>
		public const int SharedCubemaps = 0x0030;

		///<summary><![CDATA[TArray<UTextureCube * >]]></summary>
		public const int ReferencedCubemaps = 0x0040;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x0050;

	}

	public class UFontImportOptions
	{
		///<summary><![CDATA[FFontImportOptionsData]]></summary>
		public const int Data = 0x0028;

	}

	public class UFont
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TEnumAsByte<EFontCacheType>]]></summary>
		public const int FontCacheType = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0031;

		///<summary><![CDATA[TArray<FFontCharacter>]]></summary>
		public const int Characters = 0x0038;

		///<summary><![CDATA[TArray<UTexture2D * >]]></summary>
		public const int Textures = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int IsRemapped = 0x0058;

		///<summary><![CDATA[float]]></summary>
		public const int EmScale = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int Ascent = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int Descent = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int Leading = 0x0068;

		///<summary><![CDATA[int]]></summary>
		public const int Kerning = 0x006C;

		///<summary><![CDATA[FFontImportOptionsData]]></summary>
		public const int ImportOptions = 0x0070;

		///<summary><![CDATA[int]]></summary>
		public const int NumCharacters = 0x0120;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0124;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int MaxCharHeight = 0x0128;

		///<summary><![CDATA[float]]></summary>
		public const int ScalingFactor = 0x0138;

		///<summary><![CDATA[int]]></summary>
		public const int LegacyFontSize = 0x013C;

		///<summary><![CDATA[FName]]></summary>
		public const int LegacyFontName = 0x0140;

		///<summary><![CDATA[FCompositeFont]]></summary>
		public const int CompositeFont = 0x0148;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData03 = 0x0170;

	}

	public class UHapticFeedbackEffect_Buffer
	{
		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int Amplitudes = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int SampleRate = 0x0038;

		///<summary><![CDATA[unsigned char[0x2C]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UHapticFeedbackEffect_Curve
	{
		///<summary><![CDATA[FHapticFeedbackDetails_Curve]]></summary>
		public const int HapticDetails = 0x0028;

	}

	public class USoundConcurrency
	{
		///<summary><![CDATA[FSoundConcurrencySettings]]></summary>
		public const int Concurrency = 0x0028;

	}

	public class USoundEffectPreset
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USoundEffectBase
	{
		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USoundSubmix
	{
		///<summary><![CDATA[TArray<USoundSubmix * >]]></summary>
		public const int ChildSubmixes = 0x0028;

		///<summary><![CDATA[USoundSubmix *]]></summary>
		public const int ParentSubmix = 0x0038;

		///<summary><![CDATA[TArray<USoundEffectSubmixPreset * >]]></summary>
		public const int SubmixEffectChain = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int OutputWetLevel = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0054;

	}

	public class USoundBase
	{
		///<summary><![CDATA[USoundClass *]]></summary>
		public const int SoundClassObject = 0x0028;

		///<summary><![CDATA[USoundSubmix *]]></summary>
		public const int SoundSubmixObject = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDebug = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideConcurrency = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreFocus = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[USoundConcurrency *]]></summary>
		public const int SoundConcurrencySettings = 0x0040;

		///<summary><![CDATA[FSoundConcurrencySettings]]></summary>
		public const int ConcurrencyOverrides = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EMaxConcurrentResolutionRule>]]></summary>
		public const int MaxConcurrentResolutionRule = 0x0058;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0059;

		///<summary><![CDATA[int]]></summary>
		public const int MaxConcurrentPlayCount = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int Duration = 0x0060;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0064;

		///<summary><![CDATA[USoundAttenuation *]]></summary>
		public const int AttenuationSettings = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int Priority = 0x0070;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x0074;

		///<summary><![CDATA[TArray<USoundEffectSourcePreset * >]]></summary>
		public const int SourceEffectChain = 0x0078;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0088;

	}

	public class USoundGroups
	{
		///<summary><![CDATA[TArray<FSoundGroup>]]></summary>
		public const int SoundGroupProfiles = 0x0028;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class USoundWave
	{
		///<summary><![CDATA[int]]></summary>
		public const int CompressionQuality = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLooping = 0x0094;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStreaming = 0x0094;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0095;

		///<summary><![CDATA[int]]></summary>
		public const int StreamingPriority = 0x0098;

		///<summary><![CDATA[unsigned char:3]]></summary>
		public const int UnknownData01 = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bMature = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bManualWordWrap = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSingleLine = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVirtualizeWhenSilent = 0x009C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x009D;

		///<summary><![CDATA[TEnumAsByte<ESoundGroup>]]></summary>
		public const int SoundGroup = 0x00A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x00A1;

		///<summary><![CDATA[FString]]></summary>
		public const int SpokenText = 0x00A8;

		///<summary><![CDATA[float]]></summary>
		public const int SubtitlePriority = 0x00B8;

		///<summary><![CDATA[float]]></summary>
		public const int Volume = 0x00BC;

		///<summary><![CDATA[float]]></summary>
		public const int Pitch = 0x00C0;

		///<summary><![CDATA[int]]></summary>
		public const int NumChannels = 0x00C4;

		///<summary><![CDATA[int]]></summary>
		public const int SampleRate = 0x00C8;

		///<summary><![CDATA[int]]></summary>
		public const int RawPCMDataSize = 0x00CC;

		///<summary><![CDATA[TArray<FSubtitleCue>]]></summary>
		public const int Subtitles = 0x00D0;

		///<summary><![CDATA[TArray<FLocalizedSubtitle>]]></summary>
		public const int LocalizedSubtitles = 0x00E0;

		///<summary><![CDATA[unsigned char[0x170]]]></summary>
		public const int UnknownData04 = 0x00F0;

	}

	public class UHapticFeedbackEffect_SoundWave
	{
		///<summary><![CDATA[USoundWave *]]></summary>
		public const int SoundWave = 0x0028;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UInheritableComponentHandler
	{
		///<summary><![CDATA[TArray<FComponentOverrideRecord>]]></summary>
		public const int Records = 0x0028;

	}

	public class UPlayerInput
	{
		///<summary><![CDATA[unsigned char[0xF8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FKeyBind>]]></summary>
		public const int DebugExecBindings = 0x0120;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData01 = 0x0130;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int InvertedAxis = 0x0160;

		///<summary><![CDATA[unsigned char[0x228]]]></summary>
		public const int UnknownData02 = 0x0170;

	}

	public class UInputSettings
	{
		///<summary><![CDATA[TArray<FInputAxisConfigEntry>]]></summary>
		public const int AxisConfig = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAltEnterTogglesFullscreen = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bF11TogglesFullscreen = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseMouseForTouch = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableMouseSmoothing = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableFOVScaling = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[float]]></summary>
		public const int FOVScale = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int DoubleClickTime = 0x0040;

		///<summary><![CDATA[bool]]></summary>
		public const int bCaptureMouseOnLaunch = 0x0044;

		///<summary><![CDATA[TEnumAsByte<EMouseCaptureMode>]]></summary>
		public const int DefaultViewportMouseCaptureMode = 0x0045;

		///<summary><![CDATA[bool]]></summary>
		public const int bDefaultViewportMouseLock = 0x0046;

		///<summary><![CDATA[TEnumAsByte<EMouseLockMode>]]></summary>
		public const int DefaultViewportMouseLockMode = 0x0047;

		///<summary><![CDATA[TArray<FInputActionKeyMapping>]]></summary>
		public const int ActionMappings = 0x0048;

		///<summary><![CDATA[TArray<FInputAxisKeyMapping>]]></summary>
		public const int AxisMappings = 0x0058;

		///<summary><![CDATA[bool]]></summary>
		public const int bAlwaysShowTouchInterface = 0x0068;

		///<summary><![CDATA[bool]]></summary>
		public const int bShowConsoleOnFourFingerTap = 0x0069;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x006A;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int DefaultTouchInterface = 0x0070;

		///<summary><![CDATA[FKey]]></summary>
		public const int ConsoleKey = 0x0080;

		///<summary><![CDATA[TArray<FKey>]]></summary>
		public const int ConsoleKeys = 0x0098;

	}

	public class UInterpCurveEdSetup
	{
		///<summary><![CDATA[TArray<FCurveEdTab>]]></summary>
		public const int Tabs = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int ActiveTab = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UInterpData
	{
		///<summary><![CDATA[float]]></summary>
		public const int InterpLength = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int PathBuildTime = 0x002C;

		///<summary><![CDATA[TArray<UInterpGroup * >]]></summary>
		public const int InterpGroups = 0x0030;

		///<summary><![CDATA[UInterpCurveEdSetup *]]></summary>
		public const int CurveEdSetup = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int EdSectionStart = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int EdSectionEnd = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBakeAndPrune = 0x0050;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[UInterpGroupDirector *]]></summary>
		public const int CachedDirectorGroup = 0x0058;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int AllEventNames = 0x0060;

	}

	public class UInterpFilter
	{
		///<summary><![CDATA[FString]]></summary>
		public const int Caption = 0x0028;

	}

	public class UInterpGroup
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<UInterpTrack * >]]></summary>
		public const int InterpTracks = 0x0030;

		///<summary><![CDATA[FName]]></summary>
		public const int GroupName = 0x0040;

		///<summary><![CDATA[FColor]]></summary>
		public const int GroupColor = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollapsed = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVisible = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsFolder = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsParented = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSelected = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x004D;

	}

	public class UInterpGroupCamera
	{
		///<summary><![CDATA[UCameraAnim *]]></summary>
		public const int CameraAnimInst = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int CompressTolerance = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x005C;

	}

	public class UInterpGroupInst
	{
		///<summary><![CDATA[UInterpGroup *]]></summary>
		public const int Group = 0x0028;

		///<summary><![CDATA[AActor *]]></summary>
		public const int GroupActor = 0x0030;

		///<summary><![CDATA[TArray<UInterpTrackInst * >]]></summary>
		public const int TrackInst = 0x0038;

	}

	public class UInterpTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<UInterpTrack * >]]></summary>
		public const int SubTracks = 0x0038;

		///<summary><![CDATA[UClass *]]></summary>
		public const int TrackInstClass = 0x0048;

		///<summary><![CDATA[TEnumAsByte<ETrackActiveCondition>]]></summary>
		public const int ActiveCondition = 0x0050;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0051;

		///<summary><![CDATA[FString]]></summary>
		public const int TrackTitle = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOnePerGroup = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDirGroupOnly = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableTrack = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSelected = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsAnimControlTrack = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSubTrackOnly = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bVisible = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsRecording = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0069;

	}

	public class UInterpTrackBoolProp
	{
		///<summary><![CDATA[TArray<FBoolTrackKey>]]></summary>
		public const int BoolTrack = 0x0070;

		///<summary><![CDATA[FName]]></summary>
		public const int PropertyName = 0x0080;

	}

	public class UInterpTrackDirector
	{
		///<summary><![CDATA[TArray<FDirectorTrackCut>]]></summary>
		public const int CutTrack = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSimulateCameraCutsOnClients = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackEvent
	{
		///<summary><![CDATA[TArray<FEventTrackKey>]]></summary>
		public const int EventTrack = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenForwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenBackwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenJumpingForwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseCustomEventName = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackFloatBase
	{
		///<summary><![CDATA[FInterpCurveFloat]]></summary>
		public const int FloatTrack = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int CurveTension = 0x0088;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UInterpTrackAnimControl
	{
		///<summary><![CDATA[FName]]></summary>
		public const int SlotName = 0x0090;

		///<summary><![CDATA[TArray<FAnimControlTrackKey>]]></summary>
		public const int AnimSeqs = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSkipAnimNotifiers = 0x00A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00A9;

	}

	public class UInterpTrackFade
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPersistFade = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFadeAudio = 0x0090;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0091;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int FadeColor = 0x0094;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x00A4;

	}

	public class UInterpTrackFloatAnimBPParam
	{
		///<summary><![CDATA[UAnimBlueprintGeneratedClass *]]></summary>
		public const int AnimBlueprintClass = 0x0090;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AnimClass = 0x0098;

		///<summary><![CDATA[FName]]></summary>
		public const int ParamName = 0x00A0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00A8;

	}

	public class UInterpTrackFloatMaterialParam
	{
		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int TargetMaterials = 0x0090;

		///<summary><![CDATA[FName]]></summary>
		public const int ParamName = 0x00A0;

	}

	public class UInterpTrackFloatParticleParam
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParamName = 0x0090;

	}

	public class UInterpTrackFloatProp
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackMove
	{
		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int PosTrack = 0x0070;

		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int EulerTrack = 0x0088;

		///<summary><![CDATA[FInterpLookupTrack]]></summary>
		public const int LookupTrack = 0x00A0;

		///<summary><![CDATA[FName]]></summary>
		public const int LookAtGroupName = 0x00B0;

		///<summary><![CDATA[float]]></summary>
		public const int LinCurveTension = 0x00B8;

		///<summary><![CDATA[float]]></summary>
		public const int AngCurveTension = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseQuatInterpolation = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowArrowAtKeys = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableMovement = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowTranslationOnCurveEd = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowRotationOnCurveEd = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHide3DTrack = 0x00C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00C1;

		///<summary><![CDATA[TEnumAsByte<EInterpTrackMoveRotMode>]]></summary>
		public const int RotMode = 0x00C4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00C5;

	}

	public class UInterpTrackMoveAxis
	{
		///<summary><![CDATA[TEnumAsByte<EInterpMoveAxis>]]></summary>
		public const int MoveAxis = 0x0090;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0091;

		///<summary><![CDATA[FInterpLookupTrack]]></summary>
		public const int LookupTrack = 0x0098;

	}

	public class UInterpTrackLinearColorBase
	{
		///<summary><![CDATA[FInterpCurveLinearColor]]></summary>
		public const int LinearColorTrack = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int CurveTension = 0x0088;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UInterpTrackLinearColorProp
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackParticleReplay
	{
		///<summary><![CDATA[TArray<FParticleReplayTrackKey>]]></summary>
		public const int TrackKeys = 0x0070;

	}

	public class UInterpTrackToggle
	{
		///<summary><![CDATA[TArray<FToggleTrackKey>]]></summary>
		public const int ToggleTrack = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActivateSystemEachUpdate = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActivateWithJustAttachedFlag = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenForwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenBackwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenJumpingForwards = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackVectorBase
	{
		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int VectorTrack = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int CurveTension = 0x0088;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UInterpTrackColorProp
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackSound
	{
		///<summary><![CDATA[TArray<FSoundTrackKey>]]></summary>
		public const int Sounds = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPlayOnReverse = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bContinueSoundOnMatineeEnd = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSuppressSubtitles = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTreatAsDialogue = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAttach = 0x00A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00A1;

	}

	public class UInterpTrackVectorMaterialParam
	{
		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int TargetMaterials = 0x0090;

		///<summary><![CDATA[FName]]></summary>
		public const int ParamName = 0x00A0;

	}

	public class UInterpTrackVectorProp
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PropertyName = 0x0090;

	}

	public class UInterpTrackVisibility
	{
		///<summary><![CDATA[TArray<FVisibilityTrackKey>]]></summary>
		public const int VisibilityTrack = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenForwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenBackwards = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFireEventsWhenJumpingForwards = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UInterpTrackInstAnimControl
	{
		///<summary><![CDATA[float]]></summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstDirector
	{
		///<summary><![CDATA[AActor *]]></summary>
		public const int OldViewTarget = 0x0028;

	}

	public class UInterpTrackInstEvent
	{
		///<summary><![CDATA[float]]></summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstFloatAnimBPParam
	{
		///<summary><![CDATA[UAnimInstance *]]></summary>
		public const int AnimScriptInstance = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int ResetFloat = 0x0030;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x0034;

	}

	public class UInterpTrackInstFloatMaterialParam
	{
		///<summary><![CDATA[TArray<UMaterialInstanceDynamic * >]]></summary>
		public const int MaterialInstances = 0x0028;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int ResetFloats = 0x0038;

		///<summary><![CDATA[TArray<FPrimitiveMaterialRef>]]></summary>
		public const int PrimitiveMaterialRefs = 0x0048;

		///<summary><![CDATA[UInterpTrackFloatMaterialParam *]]></summary>
		public const int InstancedTrack = 0x0058;

	}

	public class UInterpTrackInstFloatParticleParam
	{
		///<summary><![CDATA[float]]></summary>
		public const int ResetFloat = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstMove
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int ResetLocation = 0x0028;

		///<summary><![CDATA[FRotator]]></summary>
		public const int ResetRotation = 0x0034;

	}

	public class UInterpTrackInstParticleReplay
	{
		///<summary><![CDATA[float]]></summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstProperty
	{
		///<summary><![CDATA[UProperty *]]></summary>
		public const int InterpProperty = 0x0028;

		///<summary><![CDATA[UObject *]]></summary>
		public const int PropertyOuterObjectInst = 0x0030;

	}

	public class UInterpTrackInstBoolProp
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[UBoolProperty *]]></summary>
		public const int BoolProperty = 0x0040;

		///<summary><![CDATA[bool]]></summary>
		public const int ResetBool = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0049;

	}

	public class UInterpTrackInstColorProp
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[FColor]]></summary>
		public const int ResetColor = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UInterpTrackInstFloatProp
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int ResetFloat = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UInterpTrackInstLinearColorProp
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ResetColor = 0x0040;

	}

	public class UInterpTrackInstVectorProp
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[FVector]]></summary>
		public const int ResetVector = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x004C;

	}

	public class UInterpTrackInstSlomo
	{
		///<summary><![CDATA[float]]></summary>
		public const int OldTimeDilation = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UInterpTrackInstSound
	{
		///<summary><![CDATA[float]]></summary>
		public const int LastUpdatePosition = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

		///<summary><![CDATA[UAudioComponent *]]></summary>
		public const int PlayAudioComp = 0x0030;

	}

	public class UInterpTrackInstToggle
	{
		///<summary><![CDATA[TEnumAsByte<ETrackToggleAction>]]></summary>
		public const int Action = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[float]]></summary>
		public const int LastUpdatePosition = 0x002C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSavedActiveState = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0031;

	}

	public class UInterpTrackInstVectorMaterialParam
	{
		///<summary><![CDATA[TArray<UMaterialInstanceDynamic * >]]></summary>
		public const int MaterialInstances = 0x0028;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int ResetVectors = 0x0038;

		///<summary><![CDATA[TArray<FPrimitiveMaterialRef>]]></summary>
		public const int PrimitiveMaterialRefs = 0x0048;

		///<summary><![CDATA[UInterpTrackVectorMaterialParam *]]></summary>
		public const int InstancedTrack = 0x0058;

	}

	public class UInterpTrackInstVisibility
	{
		///<summary><![CDATA[TEnumAsByte<EVisibilityTrackAction>]]></summary>
		public const int Action = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[float]]></summary>
		public const int LastUpdatePosition = 0x002C;

	}

	public class UIntSerialization
	{
		///<summary><![CDATA[uint16_t]]></summary>
		public const int UnsignedInt16Variable = 0x0028;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x002A;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int UnsignedInt32Variable = 0x002C;

		///<summary><![CDATA[uint64_t]]></summary>
		public const int UnsignedInt64Variable = 0x0030;

		///<summary><![CDATA[int8_t]]></summary>
		public const int SignedInt8Variable = 0x0038;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x0039;

		///<summary><![CDATA[int16_t]]></summary>
		public const int SignedInt16Variable = 0x003A;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x003C;

		///<summary><![CDATA[int64_t]]></summary>
		public const int SignedInt64Variable = 0x0040;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int UnsignedInt8Variable = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0049;

		///<summary><![CDATA[int]]></summary>
		public const int SignedInt32Variable = 0x004C;

	}

	public class ULayer
	{
		///<summary><![CDATA[FName]]></summary>
		public const int LayerName = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsVisible = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[TArray<FLayerActorStats>]]></summary>
		public const int ActorStats = 0x0038;

	}

	public class ULevelStreaming
	{
		///<summary><![CDATA[FName]]></summary>
		public const int PackageName = 0x0028;

		///<summary><![CDATA[TAssetPtr<UWorld>]]></summary>
		public const int WorldAsset = 0x0030;

		///<summary><![CDATA[FName]]></summary>
		public const int PackageNameToLoad = 0x0050;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int LODPackageNames = 0x0058;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0068;

		///<summary><![CDATA[FTransform]]></summary>
		public const int LevelTransform = 0x0080;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x00B0;

		///<summary><![CDATA[unsigned char:3]]></summary>
		public const int UnknownData02 = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBeVisibleInEditor = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLocked = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBeLoaded = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBeVisible = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsStatic = 0x00BC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBlockOnLoad = 0x00BD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData03 = 0x00BE;

		///<summary><![CDATA[int]]></summary>
		public const int LevelLODIndex = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableDistanceStreaming = 0x00C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData04 = 0x00C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawOnLevelStatusMap = 0x00C4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x00C5;

		///<summary><![CDATA[FColor]]></summary>
		public const int DrawColor = 0x00C8;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LevelColor = 0x00CC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x00DC;

		///<summary><![CDATA[TArray<ALevelStreamingVolume * >]]></summary>
		public const int EditorStreamingVolumes = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int MinTimeBetweenVolumeUnloadRequests = 0x00F0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData07 = 0x00F4;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int Keywords = 0x00F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnLevelLoaded = 0x0108;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnLevelUnloaded = 0x0118;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnLevelShown = 0x0128;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnLevelHidden = 0x0138;

		///<summary><![CDATA[ULevel *]]></summary>
		public const int LoadedLevel = 0x0148;

		///<summary><![CDATA[ULevel *]]></summary>
		public const int PendingUnloadLevel = 0x0150;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData08 = 0x0158;

	}

	public class ULightmappedSurfaceCollection
	{
		///<summary><![CDATA[UModel *]]></summary>
		public const int SourceModel = 0x0028;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int Surfaces = 0x0030;

	}

	public class ULightmassPrimitiveSettingsObject
	{
		///<summary><![CDATA[FLightmassPrimitiveSettings]]></summary>
		public const int LightmassSettings = 0x0028;

	}

	public class UEngineMessage
	{
		///<summary><![CDATA[FString]]></summary>
		public const int FailedPlaceMessage = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int MaxedOutMessage = 0x0038;

		///<summary><![CDATA[FString]]></summary>
		public const int EnteredMessage = 0x0048;

		///<summary><![CDATA[FString]]></summary>
		public const int LeftMessage = 0x0058;

		///<summary><![CDATA[FString]]></summary>
		public const int GlobalNameChange = 0x0068;

		///<summary><![CDATA[FString]]></summary>
		public const int SpecEnteredMessage = 0x0078;

		///<summary><![CDATA[FString]]></summary>
		public const int NewPlayerMessage = 0x0088;

		///<summary><![CDATA[FString]]></summary>
		public const int NewSpecMessage = 0x0098;

	}

	public class UMaterialExpressionAbs
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionAdd
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionAppendVector
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionAtmosphericFogColor
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int WorldPosition = 0x0060;

	}

	public class UMaterialExpressionBlackBody
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Temp = 0x0060;

	}

	public class UMaterialExpressionBlendMaterialAttributes
	{
		///<summary><![CDATA[FMaterialAttributesInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FMaterialAttributesInput]]></summary>
		public const int B = 0x00A0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Alpha = 0x00E0;

		///<summary><![CDATA[TEnumAsByte<EMaterialAttributeBlend>]]></summary>
		public const int PixelAttributeBlendType = 0x0118;

		///<summary><![CDATA[TEnumAsByte<EMaterialAttributeBlend>]]></summary>
		public const int VertexAttributeBlendType = 0x0119;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x011A;

	}

	public class UMaterialExpressionBreakMaterialAttributes
	{
		///<summary><![CDATA[FMaterialAttributesInput]]></summary>
		public const int MaterialAttributes = 0x0060;

	}

	public class UMaterialExpressionBumpOffset
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Coordinate = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Height = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int HeightRatioInput = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int HeightRatio = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int ReferencePlane = 0x010C;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int ConstCoordinate = 0x0110;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0114;

	}

	public class UMaterialExpressionCeil
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionClamp
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Min = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Max = 0x00D0;

		///<summary><![CDATA[TEnumAsByte<EClampMode>]]></summary>
		public const int ClampMode = 0x0108;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0109;

		///<summary><![CDATA[float]]></summary>
		public const int MinDefault = 0x010C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDefault = 0x0110;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0114;

	}

	public class UMaterialExpressionCollectionParameter
	{
		///<summary><![CDATA[UMaterialParameterCollection *]]></summary>
		public const int Collection = 0x0060;

		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0068;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ParameterId = 0x0070;

	}

	public class UMaterialExpressionComment
	{
		///<summary><![CDATA[int]]></summary>
		public const int SizeX = 0x0060;

		///<summary><![CDATA[int]]></summary>
		public const int SizeY = 0x0064;

		///<summary><![CDATA[FString]]></summary>
		public const int Text = 0x0068;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int CommentColor = 0x0078;

	}

	public class UMaterialExpressionComponentMask
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int R = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int G = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int A = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UMaterialExpressionConstant
	{
		///<summary><![CDATA[float]]></summary>
		public const int R = 0x0060;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0064;

	}

	public class UMaterialExpressionConstant2Vector
	{
		///<summary><![CDATA[float]]></summary>
		public const int R = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int G = 0x0064;

	}

	public class UMaterialExpressionConstant3Vector
	{
		///<summary><![CDATA[FLinearColor]]></summary>
		public const int Constant = 0x0060;

	}

	public class UMaterialExpressionConstant4Vector
	{
		///<summary><![CDATA[FLinearColor]]></summary>
		public const int Constant = 0x0060;

	}

	public class UMaterialExpressionConstantBiasScale
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int Bias = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int Scale = 0x009C;

	}

	public class UMaterialExpressionCosine
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int Period = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionCrossProduct
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionCustom
	{
		///<summary><![CDATA[FString]]></summary>
		public const int Code = 0x0060;

		///<summary><![CDATA[TEnumAsByte<ECustomMaterialOutputType>]]></summary>
		public const int OutputType = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0071;

		///<summary><![CDATA[FString]]></summary>
		public const int Description = 0x0078;

		///<summary><![CDATA[TArray<FCustomInput>]]></summary>
		public const int Inputs = 0x0088;

	}

	public class UMaterialExpressionClearCoatNormalCustomOutput
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionTangentOutput
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionDDX
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Value = 0x0060;

	}

	public class UMaterialExpressionDDY
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Value = 0x0060;

	}

	public class UMaterialExpressionDecalMipmapLevel
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int TextureSize = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int ConstWidth = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstHeight = 0x009C;

	}

	public class UMaterialExpressionDepthFade
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int InOpacity = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int FadeDistance = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int OpacityDefault = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int FadeDistanceDefault = 0x00D4;

	}

	public class UMaterialExpressionDepthOfFieldFunction
	{
		///<summary><![CDATA[TEnumAsByte<EDepthOfFieldFunctionValue>]]></summary>
		public const int FunctionValue = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Depth = 0x0068;

	}

	public class UMaterialExpressionDeriveNormalZ
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int InXY = 0x0060;

	}

	public class UMaterialExpressionDesaturation
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Fraction = 0x0098;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LuminanceFactors = 0x00D0;

	}

	public class UMaterialExpressionDistance
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionDistanceFieldGradient
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Position = 0x0060;

	}

	public class UMaterialExpressionDistanceToNearestSurface
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Position = 0x0060;

	}

	public class UMaterialExpressionDivide
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionDotProduct
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionDynamicParameter
	{
		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int ParamNames = 0x0060;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DefaultValue = 0x0070;

	}

	public class UMaterialExpressionFeatureLevelSwitch
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Default = 0x0060;

		///<summary><![CDATA[FExpressionInput[0x4]]]></summary>
		public const int Inputs = 0x0098;

	}

	public class UMaterialExpressionFloor
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionFmod
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

	}

	public class UMaterialExpressionFontSample
	{
		///<summary><![CDATA[UFont *]]></summary>
		public const int Font = 0x0060;

		///<summary><![CDATA[int]]></summary>
		public const int FontTexturePage = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x006C;

	}

	public class UMaterialExpressionFontSampleParameter
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0070;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x0078;

		///<summary><![CDATA[FName]]></summary>
		public const int Group = 0x0088;

	}

	public class UMaterialExpressionFrac
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionFresnel
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int ExponentIn = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int Exponent = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int BaseReflectFractionIn = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int BaseReflectFraction = 0x00D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x00DC;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Normal = 0x00E0;

	}

	public class UMaterialExpressionFunctionInput
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Preview = 0x0060;

		///<summary><![CDATA[FString]]></summary>
		public const int InputName = 0x0098;

		///<summary><![CDATA[FString]]></summary>
		public const int Description = 0x00A8;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ID = 0x00B8;

		///<summary><![CDATA[TEnumAsByte<EFunctionInputType>]]></summary>
		public const int InputType = 0x00C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00C9;

		///<summary><![CDATA[FVector4]]></summary>
		public const int PreviewValue = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsePreviewValueAsDefault = 0x00E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00E1;

		///<summary><![CDATA[int]]></summary>
		public const int SortPriority = 0x00E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCompilingFunctionPreview = 0x00E8;

		///<summary><![CDATA[unsigned char[0x47]]]></summary>
		public const int UnknownData02 = 0x00E9;

	}

	public class UMaterialExpressionFunctionOutput
	{
		///<summary><![CDATA[FString]]></summary>
		public const int OutputName = 0x0060;

		///<summary><![CDATA[FString]]></summary>
		public const int Description = 0x0070;

		///<summary><![CDATA[int]]></summary>
		public const int SortPriority = 0x0080;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0084;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0088;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLastPreviewed = 0x00C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00C1;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ID = 0x00C4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x00D4;

	}

	public class UMaterialExpressionGetMaterialAttributes
	{
		///<summary><![CDATA[FMaterialAttributesInput]]></summary>
		public const int MaterialAttributes = 0x0060;

		///<summary><![CDATA[TArray<FGuid>]]></summary>
		public const int AttributeGetTypes = 0x00A0;

	}

	public class UMaterialExpressionGIReplace
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Default = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int StaticIndirect = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int DynamicIndirect = 0x00D0;

	}

	public class UMaterialExpressionIf
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int AGreaterThanB = 0x00D0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int AEqualsB = 0x0108;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int ALessThanB = 0x0140;

		///<summary><![CDATA[float]]></summary>
		public const int EqualsThreshold = 0x0178;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x017C;

		///<summary><![CDATA[float]]></summary>
		public const int ConstAEqualsB = 0x0180;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0184;

	}

	public class UMaterialExpressionLightmassReplace
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Realtime = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Lightmass = 0x0098;

	}

	public class UMaterialExpressionLinearInterpolate
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Alpha = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x010C;

		///<summary><![CDATA[float]]></summary>
		public const int ConstAlpha = 0x0110;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0114;

	}

	public class UMaterialExpressionLogarithm2
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int X = 0x0060;

	}

	public class UMaterialExpressionMakeMaterialAttributes
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int BaseColor = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Metallic = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Specular = 0x00D0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Roughness = 0x0108;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int EmissiveColor = 0x0140;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Opacity = 0x0178;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int OpacityMask = 0x01B0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Normal = 0x01E8;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int WorldPositionOffset = 0x0220;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int WorldDisplacement = 0x0258;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int TessellationMultiplier = 0x0290;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int SubsurfaceColor = 0x02C8;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int ClearCoat = 0x0300;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int ClearCoatRoughness = 0x0338;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int AmbientOcclusion = 0x0370;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Refraction = 0x03A8;

		///<summary><![CDATA[FExpressionInput[0x8]]]></summary>
		public const int CustomizedUVs = 0x03E0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int PixelDepthOffset = 0x05A0;

	}

	public class UMaterialExpressionMaterialFunctionCall
	{
		///<summary><![CDATA[UMaterialFunction *]]></summary>
		public const int MaterialFunction = 0x0060;

		///<summary><![CDATA[TArray<FFunctionExpressionInput>]]></summary>
		public const int FunctionInputs = 0x0068;

		///<summary><![CDATA[TArray<FFunctionExpressionOutput>]]></summary>
		public const int FunctionOutputs = 0x0078;

	}

	public class UMaterialExpressionMaterialProxyReplace
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Realtime = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int MaterialProxy = 0x0098;

	}

	public class UMaterialExpressionMax
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionMin
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionMultiply
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionNoise
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Position = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int FilterWidth = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int Scale = 0x00D0;

		///<summary><![CDATA[int]]></summary>
		public const int Quality = 0x00D4;

		///<summary><![CDATA[TEnumAsByte<ENoiseFunction>]]></summary>
		public const int NoiseFunction = 0x00D8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00D9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTurbulence = 0x00DC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00DD;

		///<summary><![CDATA[int]]></summary>
		public const int Levels = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int OutputMin = 0x00E4;

		///<summary><![CDATA[float]]></summary>
		public const int OutputMax = 0x00E8;

		///<summary><![CDATA[float]]></summary>
		public const int LevelScale = 0x00EC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTiling = 0x00F0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00F1;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int RepeatSize = 0x00F4;

	}

	public class UMaterialExpressionNormalize
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int VectorInput = 0x0060;

	}

	public class UMaterialExpressionOneMinus
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionPanner
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Coordinate = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Time = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Speed = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedX = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedY = 0x010C;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int ConstCoordinate = 0x0110;

		///<summary><![CDATA[bool]]></summary>
		public const int bFractionalPart = 0x0114;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0115;

	}

	public class UMaterialExpressionParameter
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0060;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x0068;

		///<summary><![CDATA[FName]]></summary>
		public const int Group = 0x0078;

	}

	public class UMaterialExpressionScalarParameter
	{
		///<summary><![CDATA[float]]></summary>
		public const int DefaultValue = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int SliderMin = 0x0084;

		///<summary><![CDATA[float]]></summary>
		public const int SliderMax = 0x0088;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x008C;

	}

	public class UMaterialExpressionStaticBoolParameter
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DefaultValue = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UMaterialExpressionStaticSwitchParameter
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0088;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x00C0;

	}

	public class UMaterialExpressionStaticComponentMaskParameter
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DefaultR = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DefaultG = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DefaultB = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DefaultA = 0x00B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UMaterialExpressionVectorParameter
	{
		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DefaultValue = 0x0080;

	}

	public class UMaterialExpressionPower
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Base = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Exponent = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstExponent = 0x00D0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00D4;

	}

	public class UMaterialExpressionQualitySwitch
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Default = 0x0060;

		///<summary><![CDATA[FExpressionInput[0x3]]]></summary>
		public const int Inputs = 0x0098;

	}

	public class UMaterialExpressionReflectionVectorWS
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int CustomWorldNormal = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNormalizeCustomWorldNormal = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UMaterialExpressionRotateAboutAxis
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int NormalizedRotationAxis = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int RotationAngle = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int PivotPoint = 0x00D0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Position = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int Period = 0x0140;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0144;

	}

	public class UMaterialExpressionRotator
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Coordinate = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Time = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int CenterX = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int CenterY = 0x00D4;

		///<summary><![CDATA[float]]></summary>
		public const int Speed = 0x00D8;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int ConstCoordinate = 0x00DC;

	}

	public class UMaterialExpressionSceneColor
	{
		///<summary><![CDATA[TEnumAsByte<EMaterialSceneAttributeInputMode>]]></summary>
		public const int InputMode = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0068;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int OffsetFraction = 0x00A0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ConstInput = 0x00D8;

	}

	public class UMaterialExpressionSceneDepth
	{
		///<summary><![CDATA[TEnumAsByte<EMaterialSceneAttributeInputMode>]]></summary>
		public const int InputMode = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0068;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Coordinates = 0x00A0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ConstInput = 0x00D8;

	}

	public class UMaterialExpressionSceneTexture
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Coordinates = 0x0060;

		///<summary><![CDATA[TEnumAsByte<ESceneTextureId>]]></summary>
		public const int SceneTextureId = 0x0098;

		///<summary><![CDATA[bool]]></summary>
		public const int bClampUVs = 0x0099;

		///<summary><![CDATA[bool]]></summary>
		public const int bFiltered = 0x009A;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x009B;

	}

	public class UMaterialExpressionScreenPosition
	{
		///<summary><![CDATA[TEnumAsByte<EMaterialExpressionScreenPositionMapping>]]></summary>
		public const int Mapping = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialExpressionSetMaterialAttributes
	{
		///<summary><![CDATA[TArray<FExpressionInput>]]></summary>
		public const int Inputs = 0x0060;

		///<summary><![CDATA[TArray<FGuid>]]></summary>
		public const int AttributeSetTypes = 0x0070;

	}

	public class UMaterialExpressionSine
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int Period = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionSpeedTree
	{
		///<summary><![CDATA[TEnumAsByte<ESpeedTreeGeometryType>]]></summary>
		public const int GeometryType = 0x0060;

		///<summary><![CDATA[TEnumAsByte<ESpeedTreeWindType>]]></summary>
		public const int WindType = 0x0061;

		///<summary><![CDATA[TEnumAsByte<ESpeedTreeLODType>]]></summary>
		public const int LODType = 0x0062;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x0063;

		///<summary><![CDATA[float]]></summary>
		public const int BillboardThreshold = 0x0064;

		///<summary><![CDATA[bool]]></summary>
		public const int bAccurateWindVelocities = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0069;

	}

	public class UMaterialExpressionSphereMask
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Radius = 0x00D0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Hardness = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int AttenuationRadius = 0x0140;

		///<summary><![CDATA[float]]></summary>
		public const int HardnessPercent = 0x0144;

	}

	public class UMaterialExpressionSphericalParticleOpacity
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Density = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int ConstantDensity = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UMaterialExpressionSquareRoot
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

	}

	public class UMaterialExpressionStaticBool
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Value = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialExpressionStaticSwitch
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DefaultValue = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0068;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x00A0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Value = 0x00D8;

	}

	public class UMaterialExpressionSubtract
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int A = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int B = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int ConstA = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int ConstB = 0x00D4;

	}

	public class UMaterialExpressionTextureBase
	{
		///<summary><![CDATA[UTexture *]]></summary>
		public const int Texture = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EMaterialSamplerType>]]></summary>
		public const int SamplerType = 0x0068;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0069;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int IsDefaultMeshpaintTexture = 0x006C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x006D;

	}

	public class UMaterialExpressionTextureSample
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Coordinates = 0x0070;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int TextureObject = 0x00A8;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int MipValue = 0x00E0;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int CoordinatesDX = 0x0118;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int CoordinatesDY = 0x0150;

		///<summary><![CDATA[TEnumAsByte<ETextureMipValueMode>]]></summary>
		public const int MipValueMode = 0x0188;

		///<summary><![CDATA[TEnumAsByte<ESamplerSourceMode>]]></summary>
		public const int SamplerSource = 0x0189;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x018A;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int ConstCoordinate = 0x018C;

		///<summary><![CDATA[int]]></summary>
		public const int ConstMipValue = 0x0190;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0194;

	}

	public class UMaterialExpressionParticleSubUV
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBlend = 0x0198;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0199;

	}

	public class UMaterialExpressionTextureSampleParameter
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0198;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x01A0;

		///<summary><![CDATA[FName]]></summary>
		public const int Group = 0x01B0;

	}

	public class UMaterialExpressionAntialiasedTextureMask
	{
		///<summary><![CDATA[float]]></summary>
		public const int threshold = 0x01B8;

		///<summary><![CDATA[TEnumAsByte<ETextureColorChannel>]]></summary>
		public const int Channel = 0x01BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x01BD;

	}

	public class UMaterialExpressionTextureSampleParameterSubUV
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBlend = 0x01B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01B9;

	}

	public class UMaterialExpressionTextureCoordinate
	{
		///<summary><![CDATA[int]]></summary>
		public const int CoordinateIndex = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int UTiling = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int VTiling = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnMirrorU = 0x006C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnMirrorV = 0x006C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x006D;

	}

	public class UMaterialExpressionTextureProperty
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int TextureObject = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EMaterialExposedTextureProperty>]]></summary>
		public const int Property = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UMaterialExpressionTime
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnorePause = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_Period = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0061;

		///<summary><![CDATA[float]]></summary>
		public const int Period = 0x0064;

	}

	public class UMaterialExpressionTransform
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EMaterialVectorCoordTransformSource>]]></summary>
		public const int TransformSourceType = 0x0098;

		///<summary><![CDATA[TEnumAsByte<EMaterialVectorCoordTransform>]]></summary>
		public const int TransformType = 0x0099;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x009A;

	}

	public class UMaterialExpressionTransformPosition
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Input = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EMaterialPositionTransformSource>]]></summary>
		public const int TransformSourceType = 0x0098;

		///<summary><![CDATA[TEnumAsByte<EMaterialPositionTransformSource>]]></summary>
		public const int TransformType = 0x0099;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x009A;

	}

	public class UMaterialExpressionVectorNoise
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Position = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EVectorNoiseFunction>]]></summary>
		public const int NoiseFunction = 0x0098;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0099;

		///<summary><![CDATA[int]]></summary>
		public const int Quality = 0x009C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTiling = 0x00A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00A1;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int TileSize = 0x00A4;

	}

	public class UMaterialExpressionViewProperty
	{
		///<summary><![CDATA[TEnumAsByte<EMaterialExposedViewProperty>]]></summary>
		public const int Property = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialExpressionWorldPosition
	{
		///<summary><![CDATA[TEnumAsByte<EWorldPositionIncludedOffsets>]]></summary>
		public const int WorldPositionShaderOffset = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UMaterialFunction
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int StateId = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int Description = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bExposeToLibrary = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[TArray<UMaterialExpression * >]]></summary>
		public const int FunctionExpressions = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReentrantFlag = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0061;

	}

	public class UMaterial
	{
		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int PhysMaterial = 0x0070;

		///<summary><![CDATA[FColorMaterialInput]]></summary>
		public const int DiffuseColor = 0x0078;

		///<summary><![CDATA[FColorMaterialInput]]></summary>
		public const int SpecularColor = 0x00B8;

		///<summary><![CDATA[FColorMaterialInput]]></summary>
		public const int BaseColor = 0x00F8;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int Metallic = 0x0138;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int Specular = 0x0178;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int Roughness = 0x01B8;

		///<summary><![CDATA[FVectorMaterialInput]]></summary>
		public const int Normal = 0x01F8;

		///<summary><![CDATA[FColorMaterialInput]]></summary>
		public const int EmissiveColor = 0x0240;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int Opacity = 0x0280;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int OpacityMask = 0x02C0;

		///<summary><![CDATA[TEnumAsByte<EMaterialDomain>]]></summary>
		public const int MaterialDomain = 0x0300;

		///<summary><![CDATA[TEnumAsByte<EBlendMode>]]></summary>
		public const int BlendMode = 0x0301;

		///<summary><![CDATA[TEnumAsByte<EDecalBlendMode>]]></summary>
		public const int DecalBlendMode = 0x0302;

		///<summary><![CDATA[TEnumAsByte<EMaterialDecalResponse>]]></summary>
		public const int MaterialDecalResponse = 0x0303;

		///<summary><![CDATA[TEnumAsByte<EMaterialShadingModel>]]></summary>
		public const int ShadingModel = 0x0304;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0305;

		///<summary><![CDATA[float]]></summary>
		public const int OpacityMaskClipValue = 0x0308;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x030C;

		///<summary><![CDATA[FVectorMaterialInput]]></summary>
		public const int WorldPositionOffset = 0x0310;

		///<summary><![CDATA[FVectorMaterialInput]]></summary>
		public const int WorldDisplacement = 0x0358;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int TessellationMultiplier = 0x03A0;

		///<summary><![CDATA[FColorMaterialInput]]></summary>
		public const int SubsurfaceColor = 0x03E0;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int ClearCoat = 0x0420;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int ClearCoatRoughness = 0x0460;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int AmbientOcclusion = 0x04A0;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int Refraction = 0x04E0;

		///<summary><![CDATA[FVector2MaterialInput[0x8]]]></summary>
		public const int CustomizedUVs = 0x0520;

		///<summary><![CDATA[FMaterialAttributesInput]]></summary>
		public const int MaterialAttributes = 0x0760;

		///<summary><![CDATA[FScalarMaterialInput]]></summary>
		public const int PixelDepthOffset = 0x07A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableSeparateTranslucency = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableMobileSeparateTranslucency = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableResponsiveAA = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bScreenSpaceReflections = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int TwoSided = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DitheredLODTransition = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DitherOpacityMask = 0x07E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowNegativeEmissiveColor = 0x07E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x07E1;

		///<summary><![CDATA[int]]></summary>
		public const int NumCustomizedUVs = 0x07E4;

		///<summary><![CDATA[TEnumAsByte<ETranslucencyLightingMode>]]></summary>
		public const int TranslucencyLightingMode = 0x07E8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x07E9;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucencyDirectionalLightingIntensity = 0x07EC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int AllowTranslucentCustomDepthWrites = 0x07F0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x07F1;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucentShadowDensityScale = 0x07F4;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucentSelfShadowDensityScale = 0x07F8;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucentSelfShadowSecondDensityScale = 0x07FC;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucentSelfShadowSecondOpacity = 0x0800;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucentBackscatteringExponent = 0x0804;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int TranslucentMultipleScatteringExtinction = 0x0808;

		///<summary><![CDATA[float]]></summary>
		public const int TranslucentShadowStartOffset = 0x0818;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableDepthTest = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateSphericalParticleNormals = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTangentSpaceNormal = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseEmissiveForDynamicAreaLighting = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBlockGI = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedAsSpecialEngineMaterial = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithSkeletalMesh = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithEditorCompositing = 0x081C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithParticleSprites = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithBeamTrails = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithMeshParticles = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithStaticLighting = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithMorphTargets = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithSplineMeshes = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithInstancedStaticMeshes = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsesDistortion = 0x081D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithClothing = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedWithUI = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutomaticallySetUsageInEditor = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFullyRough = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFullPrecision = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseLightmapDirectionality = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseHQForwardReflections = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsePlanarForwardReflections = 0x081E;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNormalCurvatureToRoughness = 0x081F;

		///<summary><![CDATA[TEnumAsByte<EMaterialTessellationMode>]]></summary>
		public const int D3D11TessellationMode = 0x0820;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0821;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableCrackFreeDisplacement = 0x0824;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableAdaptiveTessellation = 0x0824;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0825;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDisplacement = 0x0828;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Wireframe = 0x082C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOutputVelocityOnBasePass = 0x082C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x082D;

		///<summary><![CDATA[int]]></summary>
		public const int EditorX = 0x0830;

		///<summary><![CDATA[int]]></summary>
		public const int EditorY = 0x0834;

		///<summary><![CDATA[int]]></summary>
		public const int EditorPitch = 0x0838;

		///<summary><![CDATA[int]]></summary>
		public const int EditorYaw = 0x083C;

		///<summary><![CDATA[TArray<UMaterialExpression * >]]></summary>
		public const int Expressions = 0x0840;

		///<summary><![CDATA[TArray<FMaterialFunctionInfo>]]></summary>
		public const int MaterialFunctionInfos = 0x0850;

		///<summary><![CDATA[TArray<FMaterialParameterCollectionInfo>]]></summary>
		public const int MaterialParameterCollectionInfos = 0x0860;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanMaskedBeAssumedOpaque = 0x0870;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsMasked = 0x0870;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPreviewMaterial = 0x0870;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseMaterialAttributes = 0x0870;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseTranslucencyVertexFog = 0x0870;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowDevelopmentShaderCompile = 0x0870;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsMaterialEditorStatsMaterial = 0x0870;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x0871;

		///<summary><![CDATA[uint32_t]]></summary>
		public const int UsageFlagWarnings = 0x0874;

		///<summary><![CDATA[TEnumAsByte<EBlendableLocation>]]></summary>
		public const int BlendableLocation = 0x0878;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0879;

		///<summary><![CDATA[int]]></summary>
		public const int BlendablePriority = 0x087C;

		///<summary><![CDATA[bool]]></summary>
		public const int BlendableOutputAlpha = 0x0880;

		///<summary><![CDATA[TEnumAsByte<ERefractionMode>]]></summary>
		public const int RefractionMode = 0x0881;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData10 = 0x0882;

		///<summary><![CDATA[float]]></summary>
		public const int RefractionDepthBias = 0x0884;

		///<summary><![CDATA[FGuid]]></summary>
		public const int StateId = 0x0888;

		///<summary><![CDATA[unsigned char[0xE0]]]></summary>
		public const int UnknownData11 = 0x0898;

		///<summary><![CDATA[TArray<UTexture * >]]></summary>
		public const int ExpressionTextureReferences = 0x0978;

	}

	public class UMaterialInstanceDynamic
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x01B0;

	}

	public class UMaterialParameterCollection
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int StateId = 0x0028;

		///<summary><![CDATA[TArray<FCollectionScalarParameter>]]></summary>
		public const int ScalarParameters = 0x0038;

		///<summary><![CDATA[TArray<FCollectionVectorParameter>]]></summary>
		public const int VectorParameters = 0x0048;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0058;

	}

	public class UMaterialParameterCollectionInstance
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UMaterialParameterCollection *]]></summary>
		public const int Collection = 0x0030;

		///<summary><![CDATA[UWorld *]]></summary>
		public const int World = 0x0038;

		///<summary><![CDATA[unsigned char[0xA8]]]></summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UMorphTarget
	{
		///<summary><![CDATA[USkeletalMesh *]]></summary>
		public const int BaseSkelMesh = 0x0028;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UNavAreaMeta_SwitchByAgent
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent0Area = 0x0040;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent1Area = 0x0048;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent2Area = 0x0050;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent3Area = 0x0058;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent4Area = 0x0060;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent5Area = 0x0068;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent6Area = 0x0070;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent7Area = 0x0078;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent8Area = 0x0080;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent9Area = 0x0088;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent10Area = 0x0090;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent11Area = 0x0098;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent12Area = 0x00A0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent13Area = 0x00A8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent14Area = 0x00B0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Agent15Area = 0x00B8;

	}

	public class UNavCollision
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FNavCollisionCylinder>]]></summary>
		public const int CylinderCollision = 0x0078;

		///<summary><![CDATA[TArray<FNavCollisionBox>]]></summary>
		public const int BoxCollision = 0x0088;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AreaClass = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsDynamicObstacle = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGatherConvexGeometry = 0x00A0;

		///<summary><![CDATA[unsigned char[0x6F]]]></summary>
		public const int UnknownData01 = 0x00A1;

	}

	public class UNavigationDataChunk
	{
		///<summary><![CDATA[FName]]></summary>
		public const int NavigationDataName = 0x0028;

	}

	public class URecastNavMeshDataChunk
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UNavigationPath
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int PathUpdatedNotifier = 0x0028;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int PathPoints = 0x0038;

		///<summary><![CDATA[TEnumAsByte<ENavigationOptionFlag>]]></summary>
		public const int RecalculateOnInvalidation = 0x0048;

		///<summary><![CDATA[unsigned char[0x77]]]></summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UObjectLibrary
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ObjectBaseClass = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bHasBlueprintClasses = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int Objects = 0x0038;

		///<summary><![CDATA[TArray<TWeakObjectPtr<UObject>>]]></summary>
		public const int WeakObjects = 0x0048;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseWeakReferences = 0x0058;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFullyLoaded = 0x0059;

		///<summary><![CDATA[unsigned char[0x106]]]></summary>
		public const int UnknownData01 = 0x005A;

	}

	public class UObjectReferencer
	{
		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int ReferencedObjects = 0x0028;

	}

	public class UParticleModule
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSpawnModule = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdateModule = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFinalUpdateModule = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdateForGPUEmitter = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCurvesAsColor = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int b3DDrawMode = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupported3DDrawMode = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEditable = 0x0029;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int LODDuplicate = 0x0029;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSupportsRandomSeed = 0x0029;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRequiresLoopingNotification = 0x0029;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x002A;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int LODValidity = 0x002C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x002D;

	}

	public class UParticleModuleOrientationAxisLock
	{
		///<summary><![CDATA[TEnumAsByte<EParticleAxisLock>]]></summary>
		public const int LockAxisFlags = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleLODLevel
	{
		///<summary><![CDATA[int]]></summary>
		public const int Level = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnabled = 0x002C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x002D;

		///<summary><![CDATA[UParticleModuleRequired *]]></summary>
		public const int RequiredModule = 0x0030;

		///<summary><![CDATA[TArray<UParticleModule * >]]></summary>
		public const int Modules = 0x0038;

		///<summary><![CDATA[UParticleModuleTypeDataBase *]]></summary>
		public const int TypeDataModule = 0x0048;

		///<summary><![CDATA[UParticleModuleSpawn *]]></summary>
		public const int SpawnModule = 0x0050;

		///<summary><![CDATA[UParticleModuleEventGenerator *]]></summary>
		public const int EventGenerator = 0x0058;

		///<summary><![CDATA[TArray<UParticleModuleSpawnBase * >]]></summary>
		public const int SpawningModules = 0x0060;

		///<summary><![CDATA[TArray<UParticleModule * >]]></summary>
		public const int SpawnModules = 0x0070;

		///<summary><![CDATA[TArray<UParticleModule * >]]></summary>
		public const int UpdateModules = 0x0080;

		///<summary><![CDATA[TArray<UParticleModuleOrbit * >]]></summary>
		public const int OrbitModules = 0x0090;

		///<summary><![CDATA[TArray<UParticleModuleEventReceiverBase * >]]></summary>
		public const int EventReceiverModules = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ConvertedModules = 0x00B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00B1;

		///<summary><![CDATA[int]]></summary>
		public const int PeakActiveParticles = 0x00B4;

	}

	public class UParticleModuleAccelerationBase
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysInWorldSpace = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleAcceleration
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Acceleration = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyOwnerScale = 0x0088;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0089;

	}

	public class UParticleModuleAccelerationConstant
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int Acceleration = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0044;

	}

	public class UParticleModuleAccelerationDrag
	{
		///<summary><![CDATA[UDistributionFloat *]]></summary>
		public const int DragCoefficient = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int DragCoefficientRaw = 0x0040;

	}

	public class UParticleModuleAccelerationDragScaleOverLife
	{
		///<summary><![CDATA[UDistributionFloat *]]></summary>
		public const int DragScale = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int DragScaleRaw = 0x0040;

	}

	public class UParticleModuleAccelerationOverLifetime
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int AccelOverLife = 0x0038;

	}

	public class UParticleModuleAttractorLine
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int EndPoint0 = 0x0030;

		///<summary><![CDATA[FVector]]></summary>
		public const int EndPoint1 = 0x003C;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Range = 0x0048;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Strength = 0x0080;

	}

	public class UParticleModuleAttractorParticle
	{
		///<summary><![CDATA[FName]]></summary>
		public const int EmitterName = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Range = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStrengthByDistance = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0071;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Strength = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectBaseVelocity = 0x00B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00B1;

		///<summary><![CDATA[TEnumAsByte<EAttractorParticleSelectionMethod>]]></summary>
		public const int SelectionMethod = 0x00B4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00B5;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenewSource = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritSourceVel = 0x00B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x00B9;

		///<summary><![CDATA[int]]></summary>
		public const int LastSelIndex = 0x00BC;

	}

	public class UParticleModuleAttractorPoint
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Position = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Range = 0x0080;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Strength = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int StrengthByDistance = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAffectBaseVelocity = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideVelocity = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseWorldSpacePosition = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Positive_X = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Positive_Y = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Positive_Z = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Negative_X = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Negative_Y = 0x00F1;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Negative_Z = 0x00F1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x00F2;

	}

	public class UParticleModuleAttractorPointGravity
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int Position = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x003C;

		///<summary><![CDATA[UDistributionFloat *]]></summary>
		public const int Strength = 0x0040;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StrengthRaw = 0x0048;

	}

	public class UParticleModuleBeamModifier
	{
		///<summary><![CDATA[TEnumAsByte<EBeamModifierType>]]></summary>
		public const int ModifierType = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FBeamModifierOptions]]></summary>
		public const int PositionOptions = 0x0034;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Position = 0x0038;

		///<summary><![CDATA[FBeamModifierOptions]]></summary>
		public const int TangentOptions = 0x0088;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x008C;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Tangent = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsoluteTangent = 0x00E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x00E1;

		///<summary><![CDATA[FBeamModifierOptions]]></summary>
		public const int StrengthOptions = 0x00E4;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Strength = 0x00E8;

	}

	public class UParticleModuleBeamNoise
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLowFreq_Enabled = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[int]]></summary>
		public const int Frequency = 0x0034;

		///<summary><![CDATA[int]]></summary>
		public const int Frequency_LowRange = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x003C;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int NoiseRange = 0x0040;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int NoiseRangeScale = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNRScaleEmitterTime = 0x00C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x00C9;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int NoiseSpeed = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSmooth = 0x0120;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0121;

		///<summary><![CDATA[float]]></summary>
		public const int NoiseLockRadius = 0x0124;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNoiseLock = 0x0128;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOscillate = 0x0128;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0129;

		///<summary><![CDATA[float]]></summary>
		public const int NoiseLockTime = 0x012C;

		///<summary><![CDATA[float]]></summary>
		public const int NoiseTension = 0x0130;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseNoiseTangents = 0x0134;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0135;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int NoiseTangentStrength = 0x0138;

		///<summary><![CDATA[int]]></summary>
		public const int NoiseTessellation = 0x0170;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTargetNoise = 0x0174;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0175;

		///<summary><![CDATA[float]]></summary>
		public const int FrequencyDistance = 0x0178;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyNoiseScale = 0x017C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x017D;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int NoiseScale = 0x0180;

	}

	public class UParticleModuleBeamSource
	{
		///<summary><![CDATA[TEnumAsByte<EBeam2SourceTargetMethod>]]></summary>
		public const int SourceMethod = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FName]]></summary>
		public const int SourceName = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSourceAbsolute = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0041;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Source = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockSource = 0x0098;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0099;

		///<summary><![CDATA[TEnumAsByte<EBeam2SourceTargetTangentMethod>]]></summary>
		public const int SourceTangentMethod = 0x009C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x009D;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int SourceTangent = 0x00A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockSourceTangent = 0x00F0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData04 = 0x00F1;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int SourceStrength = 0x00F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockSourceStength = 0x0130;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x0131;

	}

	public class UParticleModuleBeamTarget
	{
		///<summary><![CDATA[TEnumAsByte<EBeam2SourceTargetMethod>]]></summary>
		public const int TargetMethod = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FName]]></summary>
		public const int TargetName = 0x0038;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Target = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTargetAbsolute = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockTarget = 0x0090;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0091;

		///<summary><![CDATA[TEnumAsByte<EBeam2SourceTargetTangentMethod>]]></summary>
		public const int TargetTangentMethod = 0x0094;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0095;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int TargetTangent = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockTargetTangent = 0x00E8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x00E9;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int TargetStrength = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockTargetStength = 0x0128;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0129;

		///<summary><![CDATA[float]]></summary>
		public const int LockRadius = 0x012C;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x0130;

	}

	public class UParticleModuleCameraOffset
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int CameraOffset = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSpawnTimeOnly = 0x0068;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0069;

		///<summary><![CDATA[TEnumAsByte<EParticleCameraOffsetUpdateMethod>]]></summary>
		public const int UpdateMethod = 0x006C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x006D;

	}

	public class UParticleModuleCollision
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int DampingFactor = 0x0030;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int DampingFactorRotation = 0x0080;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int MaxCollisions = 0x00D0;

		///<summary><![CDATA[TEnumAsByte<EParticleCollisionComplete>]]></summary>
		public const int CollisionCompletionOption = 0x0108;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0109;

		///<summary><![CDATA[TArray<TEnumAsByte<EObjectTypeQuery>>]]></summary>
		public const int CollisionTypes = 0x0110;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0120;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyPhysics = 0x0128;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreTriggerVolumes = 0x0128;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0129;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int ParticleMass = 0x0130;

		///<summary><![CDATA[float]]></summary>
		public const int DirScalar = 0x0168;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPawnsDoNotDecrementCount = 0x016C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOnlyVerticalNormalsDecrementCount = 0x016C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x016D;

		///<summary><![CDATA[float]]></summary>
		public const int VerticalFudgeFactor = 0x0170;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x0174;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int DelayAmount = 0x0178;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDropDetail = 0x01B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollideOnlyIfVisible = 0x01B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreSourceActor = 0x01B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x01B1;

		///<summary><![CDATA[float]]></summary>
		public const int MaxCollisionDistance = 0x01B4;

	}

	public class UParticleModuleCollisionGPU
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Resilience = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int ResilienceScaleOverLife = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int Friction = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int RadiusScale = 0x00A4;

		///<summary><![CDATA[float]]></summary>
		public const int RadiusBias = 0x00A8;

		///<summary><![CDATA[TEnumAsByte<EParticleCollisionResponse>]]></summary>
		public const int Response = 0x00AC;

		///<summary><![CDATA[TEnumAsByte<EParticleCollisionMode>]]></summary>
		public const int CollisionMode = 0x00AD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x00AE;

	}

	public class UParticleModuleColor
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartColor = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartAlpha = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClampAlpha = 0x00B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UParticleModuleColor_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x00C0;

	}

	public class UParticleModuleColorOverLife
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int ColorOverLife = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int AlphaOverLife = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClampAlpha = 0x00B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UParticleModuleColorScaleOverLife
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int ColorScaleOverLife = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int AlphaScaleOverLife = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEmitterTime = 0x00B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00B9;

	}

	public class UParticleModuleEventGenerator
	{
		///<summary><![CDATA[TArray<FParticleEvent_GenerateInfo>]]></summary>
		public const int Events = 0x0030;

	}

	public class UParticleModuleEventReceiverBase
	{
		///<summary><![CDATA[TEnumAsByte<EParticleEventType>]]></summary>
		public const int EventGeneratorType = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FName]]></summary>
		public const int EventName = 0x0038;

	}

	public class UParticleModuleEventReceiverKillParticles
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStopSpawning = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UParticleModuleEventReceiverSpawn
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int SpawnCount = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseParticleTime = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsePSysLocation = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritVelocity = 0x0078;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0079;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int InheritVelocityScale = 0x0080;

		///<summary><![CDATA[TArray<UPhysicalMaterial * >]]></summary>
		public const int PhysicalMaterials = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBanPhysicalMaterials = 0x00E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00E1;

	}

	public class UParticleModuleKillBox
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int LowerLeftCorner = 0x0030;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int UpperRightCorner = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsolute = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bKillInside = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAxisAlignedAndFixedSize = 0x00D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00D1;

	}

	public class UParticleModuleKillHeight
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Height = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbsolute = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFloor = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyPSysScale = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UParticleModuleLifetime
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Lifetime = 0x0030;

	}

	public class UParticleModuleLifetime_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0068;

	}

	public class UParticleModuleLight
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bUseInverseSquaredFalloff = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int bAffectsTranslucency = 0x0031;

		///<summary><![CDATA[bool]]></summary>
		public const int bPreviewLightRadius = 0x0032;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x0033;

		///<summary><![CDATA[float]]></summary>
		public const int SpawnFraction = 0x0034;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int ColorScaleOverLife = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int BrightnessOverLife = 0x0088;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int RadiusScale = 0x00C0;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int LightExponent = 0x00F8;

		///<summary><![CDATA[bool]]></summary>
		public const int bHighQualityLights = 0x0130;

		///<summary><![CDATA[bool]]></summary>
		public const int bShadowCastingLights = 0x0131;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x0132;

	}

	public class UParticleModuleLight_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0138;

	}

	public class UParticleModuleLocation
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartLocation = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int DistributeOverNPoints = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int DistributeThreshold = 0x0084;

	}

	public class UParticleModuleLocation_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0088;

	}

	public class UParticleModuleLocationWorldOffset_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0088;

	}

	public class UParticleModuleLocationBoneSocket
	{
		///<summary><![CDATA[TEnumAsByte<ELocationBoneSocketSource>]]></summary>
		public const int SourceType = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FVector]]></summary>
		public const int UniversalOffset = 0x0034;

		///<summary><![CDATA[TArray<FLocationBoneSocketInfo>]]></summary>
		public const int SourceLocations = 0x0040;

		///<summary><![CDATA[TEnumAsByte<ELocationBoneSocketSelectionMethod>]]></summary>
		public const int SelectionMethod = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0051;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdatePositionEachFrame = 0x0054;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOrientMeshEmitters = 0x0054;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritBoneVelocity = 0x0054;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0055;

		///<summary><![CDATA[float]]></summary>
		public const int InheritVelocityScale = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x005C;

		///<summary><![CDATA[FName]]></summary>
		public const int SkelMeshActorParamName = 0x0060;

		///<summary><![CDATA[int]]></summary>
		public const int NumPreSelectedIndices = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x006C;

	}

	public class UParticleModuleLocationDirect
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Location = 0x0030;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int LocationOffset = 0x0080;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int ScaleFactor = 0x00D0;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Direction = 0x0120;

	}

	public class UParticleModuleLocationEmitter
	{
		///<summary><![CDATA[FName]]></summary>
		public const int EmitterName = 0x0030;

		///<summary><![CDATA[TEnumAsByte<ELocationEmitterSelectionMethod>]]></summary>
		public const int SelectionMethod = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int InheritSourceVelocity = 0x003C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x003D;

		///<summary><![CDATA[float]]></summary>
		public const int InheritSourceVelocityScale = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritSourceRotation = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0045;

		///<summary><![CDATA[float]]></summary>
		public const int InheritSourceRotationScale = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x004C;

	}

	public class UParticleModuleLocationEmitterDirect
	{
		///<summary><![CDATA[FName]]></summary>
		public const int EmitterName = 0x0030;

	}

	public class UParticleModuleLocationPrimitiveBase
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Positive_X = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Positive_Y = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Positive_Z = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Negative_X = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Negative_Y = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Negative_Z = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int SurfaceOnly = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Velocity = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int VelocityScale = 0x0038;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartLocation = 0x0070;

	}

	public class UParticleModuleLocationPrimitiveCylinder
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RadialVelocity = 0x00C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00C1;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartRadius = 0x00C8;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartHeight = 0x0100;

		///<summary><![CDATA[TEnumAsByte<ECylinderHeightAxis>]]></summary>
		public const int HeightAxis = 0x0138;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0139;

	}

	public class UParticleModuleLocationPrimitiveCylinder_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0140;

	}

	public class UParticleModuleLocationPrimitiveSphere
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartRadius = 0x00C0;

	}

	public class UParticleModuleLocationPrimitiveSphere_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x00F8;

	}

	public class UParticleModuleLocationPrimitiveTriangle
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartOffset = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Height = 0x0080;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Angle = 0x00B8;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Thickness = 0x00F0;

	}

	public class UParticleModuleLocationSkelVertSurface
	{
		///<summary><![CDATA[TEnumAsByte<ELocationSkelVertSurfaceSource>]]></summary>
		public const int SourceType = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FVector]]></summary>
		public const int UniversalOffset = 0x0034;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdatePositionEachFrame = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOrientMeshEmitters = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritBoneVelocity = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0041;

		///<summary><![CDATA[FName]]></summary>
		public const int SkelMeshActorParamName = 0x0048;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int ValidAssociatedBones = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnforceNormalCheck = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0061;

		///<summary><![CDATA[FVector]]></summary>
		public const int NormalToCompare = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int NormalCheckToleranceDegrees = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int NormalCheckTolerance = 0x0074;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int ValidMaterialIndices = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritVertexColor = 0x0088;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0089;

	}

	public class UParticleModulePivotOffset
	{
		///<summary><![CDATA[FVector2D]]></summary>
		public const int PivotOffset = 0x0030;

	}

	public class UParticleModuleSourceMovement
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int SourceMovementScale = 0x0030;

	}

	public class UParticleModuleMeshMaterial
	{
		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int MeshMaterials = 0x0030;

	}

	public class UParticleModuleOrbitBase
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseEmitterTime = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleOrbit
	{
		///<summary><![CDATA[TEnumAsByte<EOrbitChainMode>]]></summary>
		public const int ChainMode = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int OffsetAmount = 0x0040;

		///<summary><![CDATA[FOrbitOptions]]></summary>
		public const int OffsetOptions = 0x0090;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0094;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int RotationAmount = 0x0098;

		///<summary><![CDATA[FOrbitOptions]]></summary>
		public const int RotationOptions = 0x00E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x00EC;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int RotationRateAmount = 0x00F0;

		///<summary><![CDATA[FOrbitOptions]]></summary>
		public const int RotationRateOptions = 0x0140;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x0144;

	}

	public class UParticleModuleParameterDynamic
	{
		///<summary><![CDATA[TArray<FEmitterDynamicParameter>]]></summary>
		public const int DynamicParams = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int UpdateFlags = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsesVelocity = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0045;

	}

	public class UParticleModuleParameterDynamic_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0048;

	}

	public class USubUVAnimation
	{
		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int SubUVTexture = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int SubImages_Horizontal = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int SubImages_Vertical = 0x0034;

		///<summary><![CDATA[TEnumAsByte<ESubUVBoundingVertexCount>]]></summary>
		public const int BoundingMode = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EOpacitySourceMode>]]></summary>
		public const int OpacitySourceMode = 0x0039;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x003A;

		///<summary><![CDATA[float]]></summary>
		public const int AlphaThreshold = 0x003C;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UParticleModuleRequired
	{
		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int Material = 0x0030;

		///<summary><![CDATA[FVector]]></summary>
		public const int EmitterOrigin = 0x0038;

		///<summary><![CDATA[FRotator]]></summary>
		public const int EmitterRotation = 0x0044;

		///<summary><![CDATA[TEnumAsByte<EParticleScreenAlignment>]]></summary>
		public const int ScreenAlignment = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[float]]></summary>
		public const int MinFacingCameraBlendDistance = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFacingCameraBlendDistance = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseLocalSpace = 0x005C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bKillOnDeactivate = 0x005C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bKillOnCompleted = 0x005C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x005D;

		///<summary><![CDATA[TEnumAsByte<EParticleSortMode>]]></summary>
		public const int SortMode = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0061;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseLegacyEmitterTime = 0x0064;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRemoveHMDRoll = 0x0064;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0065;

		///<summary><![CDATA[float]]></summary>
		public const int EmitterDuration = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int EmitterDurationLow = 0x006C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEmitterDurationUseRange = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDurationRecalcEachLoop = 0x0070;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0071;

		///<summary><![CDATA[int]]></summary>
		public const int EmitterLoops = 0x0074;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int SpawnRate = 0x0078;

		///<summary><![CDATA[TEnumAsByte<EParticleBurstMethod>]]></summary>
		public const int ParticleBurstMethod = 0x00B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x00B1;

		///<summary><![CDATA[TArray<FParticleBurst>]]></summary>
		public const int BurstList = 0x00B8;

		///<summary><![CDATA[float]]></summary>
		public const int EmitterDelay = 0x00C8;

		///<summary><![CDATA[float]]></summary>
		public const int EmitterDelayLow = 0x00CC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEmitterDelayUseRange = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDelayFirstLoopOnly = 0x00D0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x00D1;

		///<summary><![CDATA[TEnumAsByte<EParticleSubUVInterpMethod>]]></summary>
		public const int InterpolationMethod = 0x00D4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x00D5;

		///<summary><![CDATA[int]]></summary>
		public const int SubImages_Horizontal = 0x00D8;

		///<summary><![CDATA[int]]></summary>
		public const int SubImages_Vertical = 0x00DC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bScaleUV = 0x00E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x00E1;

		///<summary><![CDATA[float]]></summary>
		public const int RandomImageTime = 0x00E4;

		///<summary><![CDATA[int]]></summary>
		public const int RandomImageChanges = 0x00E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideSystemMacroUV = 0x00EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x00ED;

		///<summary><![CDATA[FVector]]></summary>
		public const int MacroUVPosition = 0x00F0;

		///<summary><![CDATA[float]]></summary>
		public const int MacroUVRadius = 0x00FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseMaxDrawCount = 0x0100;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData10 = 0x0101;

		///<summary><![CDATA[int]]></summary>
		public const int MaxDrawCount = 0x0104;

		///<summary><![CDATA[TEnumAsByte<EParticleUVFlipMode>]]></summary>
		public const int UVFlippingMode = 0x0108;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData11 = 0x0109;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int CutoutTexture = 0x0110;

		///<summary><![CDATA[TEnumAsByte<ESubUVBoundingVertexCount>]]></summary>
		public const int BoundingMode = 0x0118;

		///<summary><![CDATA[TEnumAsByte<EOpacitySourceMode>]]></summary>
		public const int OpacitySourceMode = 0x0119;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData12 = 0x011A;

		///<summary><![CDATA[float]]></summary>
		public const int AlphaThreshold = 0x011C;

		///<summary><![CDATA[TEnumAsByte<EEmitterNormalsMode>]]></summary>
		public const int EmitterNormalsMode = 0x0120;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData13 = 0x0121;

		///<summary><![CDATA[FVector]]></summary>
		public const int NormalsSphereCenter = 0x0124;

		///<summary><![CDATA[FVector]]></summary>
		public const int NormalsCylinderDirection = 0x0130;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOrbitModuleAffectsVelocityAlignment = 0x013C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData14 = 0x013D;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int NamedMaterialOverrides = 0x0140;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData15 = 0x0150;

	}

	public class UParticleModuleMeshRotation
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartRotation = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritParent = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleMeshRotation_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0088;

	}

	public class UParticleModuleRotation
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartRotation = 0x0030;

	}

	public class UParticleModuleRotation_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0068;

	}

	public class UParticleModuleRotationOverLifetime
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int RotationOverLife = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Scale = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UParticleModuleMeshRotationRate
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartRotationRate = 0x0030;

	}

	public class UParticleModuleRotationRate
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartRotationRate = 0x0030;

	}

	public class UParticleModuleMeshRotationRate_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0080;

	}

	public class UParticleModuleMeshRotationRateMultiplyLife
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int LifeMultiplier = 0x0030;

	}

	public class UParticleModuleMeshRotationRateOverLife
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int RotRate = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bScaleRotRate = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleRotationRate_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0068;

	}

	public class UParticleModuleRotationRateMultiplyLife
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int LifeMultiplier = 0x0030;

	}

	public class UParticleModuleSize
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartSize = 0x0030;

	}

	public class UParticleModuleSize_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x0080;

	}

	public class UParticleModuleSizeMultiplyLife
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int LifeMultiplier = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int MultiplyX = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int MultiplyY = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int MultiplyZ = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleSizeScale
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int SizeScale = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int EnableX = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int EnableY = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int EnableZ = 0x0080;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0081;

	}

	public class UParticleModuleSizeScaleBySpeed
	{
		///<summary><![CDATA[FVector2D]]></summary>
		public const int SpeedScale = 0x0030;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int MaxScale = 0x0038;

	}

	public class UParticleModuleSpawnBase
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProcessSpawnRate = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProcessBurstList = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleSpawn
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Rate = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int RateScale = 0x0070;

		///<summary><![CDATA[TEnumAsByte<EParticleBurstMethod>]]></summary>
		public const int ParticleBurstMethod = 0x00A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00A9;

		///<summary><![CDATA[TArray<FParticleBurst>]]></summary>
		public const int BurstList = 0x00B0;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int BurstScale = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyGlobalSpawnRateScale = 0x00F8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00F9;

	}

	public class UParticleModuleSpawnPerUnit
	{
		///<summary><![CDATA[float]]></summary>
		public const int UnitScalar = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int SpawnPerUnit = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreSpawnRateWhenMoving = 0x0078;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0079;

		///<summary><![CDATA[float]]></summary>
		public const int MovementTolerance = 0x007C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFrameDistance = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreMovementAlongX = 0x0084;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreMovementAlongY = 0x0084;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreMovementAlongZ = 0x0084;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0085;

	}

	public class UParticleModuleSubUV
	{
		///<summary><![CDATA[USubUVAnimation *]]></summary>
		public const int Animation = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int SubImageIndex = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseRealTime = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0071;

	}

	public class UParticleModuleSubUVMovie
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseEmitterTime = 0x0078;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0079;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int FrameRate = 0x0080;

		///<summary><![CDATA[int]]></summary>
		public const int StartingFrame = 0x00B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x00BC;

	}

	public class UParticleModuleTrailSource
	{
		///<summary><![CDATA[TEnumAsByte<ETrail2SourceMethod>]]></summary>
		public const int SourceMethod = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[FName]]></summary>
		public const int SourceName = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int SourceStrength = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLockSourceStength = 0x0078;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0079;

		///<summary><![CDATA[int]]></summary>
		public const int SourceOffsetCount = 0x007C;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int SourceOffsetDefaults = 0x0080;

		///<summary><![CDATA[TEnumAsByte<EParticleSourceSelectionMethod>]]></summary>
		public const int SelectionMethod = 0x0090;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0091;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInheritRotation = 0x0094;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0095;

	}

	public class UParticleModuleTypeDataAnimTrail
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDeadTrailsOnDeactivate = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnablePreviousTangentRecalculation = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTangentRecalculationEveryFrame = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[float]]></summary>
		public const int TilingDistance = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceTessellationStepSize = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int TangentTessellationStepSize = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int WidthTessellationStepSize = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UParticleModuleTypeDataBeam2
	{
		///<summary><![CDATA[TEnumAsByte<EBeam2Method>]]></summary>
		public const int BeamMethod = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[int]]></summary>
		public const int TextureTile = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int TextureTileDistance = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int Sheets = 0x003C;

		///<summary><![CDATA[int]]></summary>
		public const int MaxBeamCount = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int Speed = 0x0044;

		///<summary><![CDATA[int]]></summary>
		public const int InterpolationPoints = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysOn = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x004D;

		///<summary><![CDATA[int]]></summary>
		public const int UpVectorStepSize = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0054;

		///<summary><![CDATA[FName]]></summary>
		public const int BranchParentName = 0x0058;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Distance = 0x0060;

		///<summary><![CDATA[TEnumAsByte<EBeamTaperMethod>]]></summary>
		public const int TaperMethod = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0099;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int TaperFactor = 0x00A0;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int TaperScale = 0x00D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RenderGeometry = 0x0110;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RenderDirectLine = 0x0110;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RenderLines = 0x0110;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RenderTessellation = 0x0110;

		///<summary><![CDATA[unsigned char[0x57]]]></summary>
		public const int UnknownData04 = 0x0111;

	}

	public class UParticleModuleTypeDataGpu
	{
		///<summary><![CDATA[FGPUSpriteEmitterInfo]]></summary>
		public const int EmitterInfo = 0x0030;

		///<summary><![CDATA[FGPUSpriteResourceData]]></summary>
		public const int ResourceData = 0x02F0;

		///<summary><![CDATA[float]]></summary>
		public const int CameraMotionBlurAmount = 0x0450;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClearExistingParticlesOnInit = 0x0454;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData00 = 0x0455;

	}

	public class UParticleModuleTypeDataMesh
	{
		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int Mesh = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int CastShadows = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int DoCollisions = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[TEnumAsByte<EMeshScreenAlignment>]]></summary>
		public const int MeshAlignment = 0x003C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x003D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideMaterial = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideDefaultMotionBlurSettings = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableMotionBlur = 0x0040;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0041;

		///<summary><![CDATA[float]]></summary>
		public const int Pitch = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int Roll = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int Yaw = 0x004C;

		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int RollPitchYawRange = 0x0050;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x00A0;

		///<summary><![CDATA[TEnumAsByte<EParticleAxisLock>]]></summary>
		public const int AxisLockOption = 0x00A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x00A9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCameraFacing = 0x00AC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x00AD;

		///<summary><![CDATA[TEnumAsByte<EMeshCameraFacingUpAxis>]]></summary>
		public const int CameraFacingUpAxisOption = 0x00B0;

		///<summary><![CDATA[TEnumAsByte<EMeshCameraFacingOptions>]]></summary>
		public const int CameraFacingOption = 0x00B1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData06 = 0x00B2;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyParticleRotationAsSpin = 0x00B4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFaceCameraDirectionRatherThanPosition = 0x00B4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCollisionsConsiderPartilceSize = 0x00B4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x00B5;

	}

	public class UParticleModuleTypeDataRibbon
	{
		///<summary><![CDATA[int]]></summary>
		public const int MaxTessellationBetweenParticles = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int SheetsPerTrail = 0x0034;

		///<summary><![CDATA[int]]></summary>
		public const int MaxTrailCount = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int MaxParticleInTrailCount = 0x003C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDeadTrailsOnDeactivate = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDeadTrailsOnSourceLoss = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bClipSourceSegement = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnablePreviousTangentRecalculation = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTangentRecalculationEveryFrame = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSpawnInitialParticle = 0x0040;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0041;

		///<summary><![CDATA[TEnumAsByte<ETrailsRenderAxisOption>]]></summary>
		public const int RenderAxis = 0x0044;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0045;

		///<summary><![CDATA[float]]></summary>
		public const int TangentSpawningScalar = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderGeometry = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderSpawnPoints = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderTangents = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderTessellation = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x004D;

		///<summary><![CDATA[float]]></summary>
		public const int TilingDistance = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceTessellationStepSize = 0x0054;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableTangentDiffInterpScale = 0x0058;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0059;

		///<summary><![CDATA[float]]></summary>
		public const int TangentTessellationScalar = 0x005C;

	}

	public class UParticleModuleVectorFieldGlobal
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideGlobalVectorFieldTightness = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalVectorFieldScale = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalVectorFieldTightness = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x003C;

	}

	public class UParticleModuleVectorFieldLocal
	{
		///<summary><![CDATA[UVectorField *]]></summary>
		public const int VectorField = 0x0030;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeTranslation = 0x0038;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RelativeRotation = 0x0044;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeScale3D = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int Intensity = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int Tightness = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreComponentTransform = 0x0064;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTileX = 0x0064;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTileY = 0x0064;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTileZ = 0x0064;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseFixDT = 0x0064;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0065;

	}

	public class UParticleModuleVectorFieldRotation
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int MinInitialRotation = 0x0030;

		///<summary><![CDATA[FVector]]></summary>
		public const int MaxInitialRotation = 0x003C;

	}

	public class UParticleModuleVectorFieldRotationRate
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int RotationRate = 0x0030;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UParticleModuleVectorFieldScale
	{
		///<summary><![CDATA[UDistributionFloat *]]></summary>
		public const int VectorFieldScale = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int VectorFieldScaleRaw = 0x0038;

	}

	public class UParticleModuleVectorFieldScaleOverLife
	{
		///<summary><![CDATA[UDistributionFloat *]]></summary>
		public const int VectorFieldScaleOverLife = 0x0030;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int VectorFieldScaleOverLifeRaw = 0x0038;

	}

	public class UParticleModuleVelocityBase
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInWorldSpace = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyOwnerScale = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UParticleModuleVelocity
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int StartVelocity = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int StartVelocityRadial = 0x0088;

	}

	public class UParticleModuleVelocity_Seeded
	{
		///<summary><![CDATA[FParticleRandomSeedInfo]]></summary>
		public const int RandomSeedInfo = 0x00C0;

	}

	public class UParticleModuleVelocityCone
	{
		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Angle = 0x0038;

		///<summary><![CDATA[FRawDistributionFloat]]></summary>
		public const int Velocity = 0x0070;

		///<summary><![CDATA[FVector]]></summary>
		public const int Direction = 0x00A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00B4;

	}

	public class UParticleModuleVelocityInheritParent
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int Scale = 0x0038;

	}

	public class UParticleModuleVelocityOverLifetime
	{
		///<summary><![CDATA[FRawDistributionVector]]></summary>
		public const int VelOverLife = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int Absolute = 0x0088;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0089;

	}

	public class UParticleSystemReplay
	{
		///<summary><![CDATA[int]]></summary>
		public const int ClipIDNumber = 0x0028;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UPhysicalMaterial
	{
		///<summary><![CDATA[float]]></summary>
		public const int Friction = 0x0028;

		///<summary><![CDATA[TEnumAsByte<EFrictionCombineMode>]]></summary>
		public const int FrictionCombineMode = 0x002C;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideFrictionCombineMode = 0x002D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x002E;

		///<summary><![CDATA[float]]></summary>
		public const int Restitution = 0x0030;

		///<summary><![CDATA[TEnumAsByte<EFrictionCombineMode>]]></summary>
		public const int RestitutionCombineMode = 0x0034;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideRestitutionCombineMode = 0x0035;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x0036;

		///<summary><![CDATA[float]]></summary>
		public const int Density = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int RaiseMassToPower = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int DestructibleDamageThresholdScale = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0044;

		///<summary><![CDATA[UPhysicalMaterialPropertyBase *]]></summary>
		public const int PhysicalMaterialProperty = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EPhysicalSurface>]]></summary>
		public const int SurfaceType = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0051;

		///<summary><![CDATA[float]]></summary>
		public const int TireFrictionScale = 0x0054;

		///<summary><![CDATA[TArray<FTireFrictionScalePair>]]></summary>
		public const int TireFrictionScales = 0x0058;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData04 = 0x0068;

	}

	public class UPhysicsCollisionHandler
	{
		///<summary><![CDATA[float]]></summary>
		public const int ImpactThreshold = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int ImpactReFireDelay = 0x002C;

		///<summary><![CDATA[USoundBase *]]></summary>
		public const int DefaultImpactSound = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int LastImpactSoundTime = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class UPhysicsConstraintTemplate
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FConstraintInstance]]></summary>
		public const int DefaultInstance = 0x0030;

		///<summary><![CDATA[TArray<FPhysicsConstraintProfileHandle>]]></summary>
		public const int ProfileHandles = 0x0220;

		///<summary><![CDATA[FConstraintProfileProperties]]></summary>
		public const int DefaultProfile = 0x0230;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0334;

	}

	public class UPhysicsSerializer
	{
		///<summary><![CDATA[unsigned char[0xA8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UPlatformInterfaceBase
	{
		///<summary><![CDATA[TArray<FDelegateArray>]]></summary>
		public const int AllDelegates = 0x0028;

	}

	public class UCloudStorageBase
	{
		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int LocalCloudFiles = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSuppressDelegateCalls = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UInGameAdManager
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldPauseWhileAdOpen = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[TArray<FScriptDelegate>]]></summary>
		public const int ClickedBannerDelegates = 0x0040;

		///<summary><![CDATA[TArray<FScriptDelegate>]]></summary>
		public const int ClosedAdDelegates = 0x0050;

	}

	public class UMicroTransactionBase
	{
		///<summary><![CDATA[TArray<FPurchaseInfo>]]></summary>
		public const int AvailableProducts = 0x0038;

		///<summary><![CDATA[FString]]></summary>
		public const int LastError = 0x0048;

		///<summary><![CDATA[FString]]></summary>
		public const int LastErrorSolution = 0x0058;

	}

	public class UPlatformInterfaceWebResponse
	{
		///<summary><![CDATA[FString]]></summary>
		public const int OriginalURL = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int ResponseCode = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int Tag = 0x003C;

		///<summary><![CDATA[FString]]></summary>
		public const int StringResponse = 0x0040;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int BinaryResponse = 0x0050;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0060;

	}

	public class UChildConnection
	{
	}

	public class UPolys
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UReporterBase
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UReporterGraph
	{
		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UReverbEffect
	{
		///<summary><![CDATA[float]]></summary>
		public const int Density = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int Diffusion = 0x002C;

		///<summary><![CDATA[float]]></summary>
		public const int Gain = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int GainHF = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int DecayTime = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int DecayHFRatio = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int ReflectionsGain = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int ReflectionsDelay = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int LateGain = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int LateDelay = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int AirAbsorptionGainHF = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int RoomRolloffFactor = 0x0054;

	}

	public class URig
	{
		///<summary><![CDATA[TArray<FTransformBase>]]></summary>
		public const int TransformBases = 0x0028;

		///<summary><![CDATA[TArray<FNode>]]></summary>
		public const int Nodes = 0x0038;

	}

	public class USimpleConstructionScript
	{
		///<summary><![CDATA[TArray<USCS_Node * >]]></summary>
		public const int RootNodes = 0x0028;

		///<summary><![CDATA[TArray<USCS_Node * >]]></summary>
		public const int AllNodes = 0x0038;

		///<summary><![CDATA[USCS_Node *]]></summary>
		public const int DefaultSceneRootNode = 0x0048;

		///<summary><![CDATA[USCS_Node *]]></summary>
		public const int RootNode = 0x0050;

		///<summary><![CDATA[TArray<USCS_Node * >]]></summary>
		public const int ActorComponentNodes = 0x0058;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0068;

	}

	public class USCS_Node
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ComponentClass = 0x0028;

		///<summary><![CDATA[UActorComponent *]]></summary>
		public const int ComponentTemplate = 0x0030;

		///<summary><![CDATA[FBlueprintCookedComponentInstancingData]]></summary>
		public const int CookedComponentInstancingData = 0x0038;

		///<summary><![CDATA[FName]]></summary>
		public const int VariableName = 0x0088;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachToName = 0x0090;

		///<summary><![CDATA[FName]]></summary>
		public const int ParentComponentOrVariableName = 0x0098;

		///<summary><![CDATA[FName]]></summary>
		public const int ParentComponentOwnerClassName = 0x00A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsParentComponentNative = 0x00A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00A9;

		///<summary><![CDATA[TArray<USCS_Node * >]]></summary>
		public const int ChildNodes = 0x00B0;

		///<summary><![CDATA[TArray<FBPVariableMetaDataEntry>]]></summary>
		public const int MetaDataArray = 0x00C0;

		///<summary><![CDATA[FGuid]]></summary>
		public const int VariableGuid = 0x00D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFalseRoot = 0x00E0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsNative = 0x00E1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x00E2;

		///<summary><![CDATA[FName]]></summary>
		public const int NativeComponentName = 0x00E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bVariableNameAutoGenerated = 0x00F0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x00F1;

		///<summary><![CDATA[FName]]></summary>
		public const int InternalVariableName = 0x00F8;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData03 = 0x0100;

	}

	public class USelection
	{
		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UDestructibleMesh
	{
		///<summary><![CDATA[FDestructibleParameters]]></summary>
		public const int DefaultDestructibleParameters = 0x02C0;

		///<summary><![CDATA[TArray<FFractureEffect>]]></summary>
		public const int FractureEffects = 0x0348;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0358;

	}

	public class USkeletalMeshReductionSettings
	{
		///<summary><![CDATA[TArray<FSkeletalMeshLODGroupSettings>]]></summary>
		public const int Settings = 0x0028;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class USkeletalMeshSocket
	{
		///<summary><![CDATA[FName]]></summary>
		public const int SocketName = 0x0028;

		///<summary><![CDATA[FName]]></summary>
		public const int BoneName = 0x0030;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeLocation = 0x0038;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RelativeRotation = 0x0044;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeScale = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int bForceAlwaysAnimated = 0x005C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x005D;

	}

	public class USlateBrushAsset
	{
		///<summary><![CDATA[FSlateBrush]]></summary>
		public const int Brush = 0x0028;

	}

	public class UTexture
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FGuid]]></summary>
		public const int LightingGuid = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int LODBias = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int NumCinematicMipLevels = 0x0044;

		///<summary><![CDATA[int]]></summary>
		public const int GlobalLODBias = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int SRGB = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int NeverStream = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNoTiling = 0x004C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseCinematicMipLevels = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x004D;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x0050;

		///<summary><![CDATA[int]]></summary>
		public const int CachedCombinedLODBias = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAsyncResourceReleaseHasBeenStarted = 0x0064;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0065;

		///<summary><![CDATA[TEnumAsByte<ETextureCompressionSettings>]]></summary>
		public const int CompressionSettings = 0x0068;

		///<summary><![CDATA[TEnumAsByte<ETextureFilter>]]></summary>
		public const int Filter = 0x0069;

		///<summary><![CDATA[TEnumAsByte<ETextureGroup>]]></summary>
		public const int LODGroup = 0x006A;

		///<summary><![CDATA[unsigned char[0x5D]]]></summary>
		public const int UnknownData03 = 0x006B;

	}

	public class UDialogueSoundWaveProxy
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0090;

	}

	public class USoundCue
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideAttenuation = 0x0090;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0091;

		///<summary><![CDATA[USoundNode *]]></summary>
		public const int FirstNode = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMultiplier = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int PitchMultiplier = 0x00A4;

		///<summary><![CDATA[FAttenuationSettings]]></summary>
		public const int AttenuationOverrides = 0x00A8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x01A0;

	}

	public class USoundWaveProcedural
	{
		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData00 = 0x0260;

	}

	public class USoundClass
	{
		///<summary><![CDATA[FSoundClassProperties]]></summary>
		public const int Properties = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

		///<summary><![CDATA[TArray<USoundClass * >]]></summary>
		public const int ChildClasses = 0x0050;

		///<summary><![CDATA[TArray<FPassiveSoundMixModifier>]]></summary>
		public const int PassiveSoundMixModifiers = 0x0060;

		///<summary><![CDATA[USoundClass *]]></summary>
		public const int ParentClass = 0x0070;

	}

	public class USoundMix
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bApplyEQ = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[float]]></summary>
		public const int EQPriority = 0x002C;

		///<summary><![CDATA[FAudioEQEffect]]></summary>
		public const int EQSettings = 0x0030;

		///<summary><![CDATA[TArray<FSoundClassAdjuster>]]></summary>
		public const int SoundClassEffects = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int InitialDelay = 0x0078;

		///<summary><![CDATA[float]]></summary>
		public const int FadeInTime = 0x007C;

		///<summary><![CDATA[float]]></summary>
		public const int Duration = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int FadeOutTime = 0x0084;

	}

	public class USoundNode
	{
		///<summary><![CDATA[TArray<USoundNode * >]]></summary>
		public const int ChildNodes = 0x0028;

	}

	public class USoundNodeWavePlayer
	{
		///<summary><![CDATA[TAssetPtr<USoundWave>]]></summary>
		public const int SoundWaveAssetPtr = 0x0038;

		///<summary><![CDATA[USoundWave *]]></summary>
		public const int SoundWave = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData00 = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLooping = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0061;

	}

	public class USoundNodeAttenuation
	{
		///<summary><![CDATA[USoundAttenuation *]]></summary>
		public const int AttenuationSettings = 0x0038;

		///<summary><![CDATA[FAttenuationSettings]]></summary>
		public const int AttenuationOverrides = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideAttenuation = 0x0138;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0139;

	}

	public class USoundNodeBranch
	{
		///<summary><![CDATA[FName]]></summary>
		public const int BoolParameterName = 0x0038;

	}

	public class USoundNodeConcatenator
	{
		///<summary><![CDATA[TArray<float>]]></summary>
		public const int InputVolume = 0x0038;

	}

	public class USoundNodeDelay
	{
		///<summary><![CDATA[float]]></summary>
		public const int DelayMin = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int DelayMax = 0x003C;

	}

	public class USoundNodeDialoguePlayer
	{
		///<summary><![CDATA[FDialogueWaveParameter]]></summary>
		public const int DialogueWaveParameter = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLooping = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0059;

	}

	public class USoundNodeDistanceCrossFade
	{
		///<summary><![CDATA[TArray<FDistanceDatum>]]></summary>
		public const int CrossFadeInput = 0x0038;

	}

	public class USoundNodeParamCrossFade
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParamName = 0x0048;

	}

	public class USoundNodeDoppler
	{
		///<summary><![CDATA[float]]></summary>
		public const int DopplerIntensity = 0x0038;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x003C;

	}

	public class USoundNodeEnveloper
	{
		///<summary><![CDATA[float]]></summary>
		public const int LoopStart = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int LoopEnd = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int DurationAfterLoop = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int LoopCount = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoopIndefinitely = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoop = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[UDistributionFloatConstantCurve *]]></summary>
		public const int VolumeInterpCurve = 0x0050;

		///<summary><![CDATA[UDistributionFloatConstantCurve *]]></summary>
		public const int PitchInterpCurve = 0x0058;

		///<summary><![CDATA[FRuntimeFloatCurve]]></summary>
		public const int VolumeCurve = 0x0060;

		///<summary><![CDATA[FRuntimeFloatCurve]]></summary>
		public const int PitchCurve = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int PitchMin = 0x0160;

		///<summary><![CDATA[float]]></summary>
		public const int PitchMax = 0x0164;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMin = 0x0168;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMax = 0x016C;

	}

	public class USoundNodeGroupControl
	{
		///<summary><![CDATA[TArray<int>]]></summary>
		public const int GroupSizes = 0x0038;

	}

	public class USoundNodeLooping
	{
		///<summary><![CDATA[int]]></summary>
		public const int LoopCount = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoopIndefinitely = 0x003C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x003D;

	}

	public class USoundNodeMixer
	{
		///<summary><![CDATA[TArray<float>]]></summary>
		public const int InputVolume = 0x0038;

	}

	public class USoundNodeModulator
	{
		///<summary><![CDATA[float]]></summary>
		public const int PitchMin = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int PitchMax = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMin = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int VolumeMax = 0x0044;

	}

	public class USoundNodeModulatorContinuous
	{
		///<summary><![CDATA[FModulatorContinuousParams]]></summary>
		public const int PitchModulationParams = 0x0038;

		///<summary><![CDATA[FModulatorContinuousParams]]></summary>
		public const int VolumeModulationParams = 0x0058;

	}

	public class USoundNodeOscillator
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bModulateVolume = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bModulatePitch = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[float]]></summary>
		public const int AmplitudeMin = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int AmplitudeMax = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int FrequencyMin = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int FrequencyMax = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int OffsetMin = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int OffsetMax = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int CenterMin = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int CenterMax = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x005C;

	}

	public class USoundNodeRandom
	{
		///<summary><![CDATA[TArray<float>]]></summary>
		public const int Weights = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int PreselectAtLevelLoad = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRandomizeWithoutReplacement = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x004D;

		///<summary><![CDATA[TArray<bool>]]></summary>
		public const int HasBeenUsed = 0x0050;

		///<summary><![CDATA[int]]></summary>
		public const int NumRandomUsed = 0x0060;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0064;

	}

	public class USoundNodeSoundClass
	{
		///<summary><![CDATA[USoundClass *]]></summary>
		public const int SoundClassOverride = 0x0038;

	}

	public class USoundNodeSwitch
	{
		///<summary><![CDATA[FName]]></summary>
		public const int IntParameterName = 0x0038;

	}

	public class USoundNodeWaveParam
	{
		///<summary><![CDATA[FName]]></summary>
		public const int WaveParameterName = 0x0038;

	}

	public class UStaticMesh
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FMeshSectionInfoExt>]]></summary>
		public const int SectionInfoExts = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int MinLOD = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0054;

		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int Materials = 0x0058;

		///<summary><![CDATA[TArray<FStaticMaterial>]]></summary>
		public const int StaticMaterials = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int LightmapUVDensity = 0x0078;

		///<summary><![CDATA[int]]></summary>
		public const int LightMapResolution = 0x007C;

		///<summary><![CDATA[int]]></summary>
		public const int LightMapCoordinateIndex = 0x0080;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0084;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x0088;

		///<summary><![CDATA[int]]></summary>
		public const int LODForCollision = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStripComplexCollisionForConsole = 0x0094;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasNavigationData = 0x0094;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0095;

		///<summary><![CDATA[float]]></summary>
		public const int LpvBiasMultiplier = 0x0098;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowCPUAccess = 0x009C;

		///<summary><![CDATA[unsigned char[0x33]]]></summary>
		public const int UnknownData04 = 0x009D;

		///<summary><![CDATA[TArray<UStaticMeshSocket * >]]></summary>
		public const int Sockets = 0x00D0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData05 = 0x00E0;

		///<summary><![CDATA[FVector]]></summary>
		public const int PositiveBoundsExtension = 0x00F0;

		///<summary><![CDATA[FVector]]></summary>
		public const int NegativeBoundsExtension = 0x00FC;

		///<summary><![CDATA[FBoxSphereBounds]]></summary>
		public const int ExtendedBounds = 0x0108;

		///<summary><![CDATA[bool]]></summary>
		public const int bIgnoreDistanceFieldData = 0x0124;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0125;

		///<summary><![CDATA[int]]></summary>
		public const int ElementToIgnoreForTexFactor = 0x0128;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData07 = 0x012C;

		///<summary><![CDATA[TArray<UAssetUserData * >]]></summary>
		public const int AssetUserData = 0x0130;

		///<summary><![CDATA[UNavCollision *]]></summary>
		public const int NavCollision = 0x0140;

	}

	public class UStaticMeshSocket
	{
		///<summary><![CDATA[FName]]></summary>
		public const int SocketName = 0x0028;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeLocation = 0x0030;

		///<summary><![CDATA[FRotator]]></summary>
		public const int RelativeRotation = 0x003C;

		///<summary><![CDATA[FVector]]></summary>
		public const int RelativeScale = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0054;

		///<summary><![CDATA[FString]]></summary>
		public const int Tag = 0x0058;

	}

	public class UVertexAttributeStream
	{
		///<summary><![CDATA[FName]]></summary>
		public const int Usage = 0x0028;

		///<summary><![CDATA[TEnumAsByte<EVertexAttributeStreamType>]]></summary>
		public const int AttributeType = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int Data = 0x0038;

	}

	public class USubDSurface
	{
		///<summary><![CDATA[TArray<uint32_t>]]></summary>
		public const int VertexCountPerFace = 0x0028;

		///<summary><![CDATA[TArray<uint32_t>]]></summary>
		public const int IndicesPerFace = 0x0038;

		///<summary><![CDATA[TArray<UVertexAttributeStream * >]]></summary>
		public const int VertexAttributeStreams = 0x0048;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0058;

		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int Materials = 0x0068;

	}

	public class USubsurfaceProfile
	{
		///<summary><![CDATA[FSubsurfaceProfileStruct]]></summary>
		public const int Settings = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

	}

	public class UTextPropertyTestObject
	{
		///<summary><![CDATA[FText]]></summary>
		public const int DefaultedText = 0x0028;

		///<summary><![CDATA[FText]]></summary>
		public const int UndefaultedText = 0x0040;

		///<summary><![CDATA[FText]]></summary>
		public const int TransientText = 0x0058;

	}

	public class UTexture2D
	{
		///<summary><![CDATA[int]]></summary>
		public const int RequestedMips = 0x00C8;

		///<summary><![CDATA[int]]></summary>
		public const int ResidentMips = 0x00CC;

		///<summary><![CDATA[int]]></summary>
		public const int StreamingIndex = 0x00D0;

		///<summary><![CDATA[int]]></summary>
		public const int LevelIndex = 0x00D4;

		///<summary><![CDATA[int]]></summary>
		public const int FirstResourceMemMip = 0x00D8;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int ImportedSize = 0x00DC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00E4;

		///<summary><![CDATA[double]]></summary>
		public const int ForceMipLevelsToBeResidentTimestamp = 0x00E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTemporarilyDisableStreaming = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsStreamable = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasStreamingUpdatePending = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasCancelationPending = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceMiplevelsToBeResident = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreStreamingMipBias = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGlobalForceMipLevelsToBeResident = 0x00F0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00F1;

		///<summary><![CDATA[TEnumAsByte<ETextureAddress>]]></summary>
		public const int AddressX = 0x00F4;

		///<summary><![CDATA[TEnumAsByte<ETextureAddress>]]></summary>
		public const int AddressY = 0x00F5;

		///<summary><![CDATA[unsigned char[0x1A]]]></summary>
		public const int UnknownData02 = 0x00F6;

	}

	public class ULightMapTexture2D
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0110;

	}

	public class UShadowMapTexture2D
	{
		///<summary><![CDATA[TEnumAsByte<EShadowMapFlags>]]></summary>
		public const int ShadowmapFlags = 0x0110;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0111;

	}

	public class UTextureLightProfile
	{
		///<summary><![CDATA[float]]></summary>
		public const int Brightness = 0x0110;

		///<summary><![CDATA[float]]></summary>
		public const int TextureMultiplier = 0x0114;

	}

	public class UTexture2DDynamic
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00C8;

		///<summary><![CDATA[TEnumAsByte<EPixelFormat>]]></summary>
		public const int Format = 0x00D0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData01 = 0x00D1;

	}

	public class UTextureCube
	{
		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x00C8;

	}

	public class UTextureRenderTarget
	{
		///<summary><![CDATA[float]]></summary>
		public const int TargetGamma = 0x00C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x00CC;

	}

	public class UTextureRenderTarget2D
	{
		///<summary><![CDATA[int]]></summary>
		public const int SizeX = 0x00D0;

		///<summary><![CDATA[int]]></summary>
		public const int SizeY = 0x00D4;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ClearColor = 0x00D8;

		///<summary><![CDATA[TEnumAsByte<ETextureAddress>]]></summary>
		public const int AddressX = 0x00E8;

		///<summary><![CDATA[TEnumAsByte<ETextureAddress>]]></summary>
		public const int AddressY = 0x00E9;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x00EA;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceLinearGamma = 0x00EC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHDR = 0x00EC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGPUSharedFlag = 0x00EC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoGenerateMips = 0x00EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00ED;

		///<summary><![CDATA[TEnumAsByte<EPixelFormat>]]></summary>
		public const int OverrideFormat = 0x00F0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x00F1;

	}

	public class UCanvasRenderTarget2D
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCanvasRenderTargetUpdate = 0x00F8;

		///<summary><![CDATA[TWeakObjectPtr<UWorld>]]></summary>
		public const int World = 0x0108;

		///<summary><![CDATA[bool]]></summary>
		public const int bShouldClearRenderTargetOnReceiveUpdate = 0x0110;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0111;

	}

	public class UTextureRenderTargetCube
	{
		///<summary><![CDATA[int]]></summary>
		public const int SizeX = 0x00D0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ClearColor = 0x00D4;

		///<summary><![CDATA[TEnumAsByte<EPixelFormat>]]></summary>
		public const int OverrideFormat = 0x00E4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00E5;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHDR = 0x00E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceLinearGamma = 0x00E8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00E9;

	}

	public class UTimelineTemplate
	{
		///<summary><![CDATA[float]]></summary>
		public const int TimelineLength = 0x0028;

		///<summary><![CDATA[TEnumAsByte<ETimelineLengthMode>]]></summary>
		public const int LengthMode = 0x002C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x002D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoPlay = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoop = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicated = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bValidatedAsWired = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreTimeDilation = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0031;

		///<summary><![CDATA[TArray<FTTEventTrack>]]></summary>
		public const int EventTracks = 0x0038;

		///<summary><![CDATA[TArray<FTTFloatTrack>]]></summary>
		public const int FloatTracks = 0x0048;

		///<summary><![CDATA[TArray<FTTVectorTrack>]]></summary>
		public const int VectorTracks = 0x0058;

		///<summary><![CDATA[TArray<FTTLinearColorTrack>]]></summary>
		public const int LinearColorTracks = 0x0068;

		///<summary><![CDATA[TArray<FBPVariableMetaDataEntry>]]></summary>
		public const int MetaDataArray = 0x0078;

		///<summary><![CDATA[FGuid]]></summary>
		public const int TimelineGuid = 0x0088;

	}

	public class UTouchInterface
	{
		///<summary><![CDATA[TArray<FTouchInputControl>]]></summary>
		public const int Controls = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int ActiveOpacity = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int InactiveOpacity = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int TimeUntilDeactive = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int TimeUntilReset = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int ActivationDelay = 0x0048;

		///<summary><![CDATA[bool]]></summary>
		public const int bPreventRecenter = 0x004C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x004D;

		///<summary><![CDATA[float]]></summary>
		public const int StartupDelay = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0054;

	}

	public class UUserDefinedEnum
	{
		///<summary><![CDATA[TArray<FText>]]></summary>
		public const int DisplayNames = 0x0058;

	}

	public class UVectorField
	{
		///<summary><![CDATA[FBox]]></summary>
		public const int Bounds = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int Intensity = 0x0044;

	}

	public class UVectorFieldAnimated
	{
		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int Texture = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVectorFieldConstructionOp>]]></summary>
		public const int ConstructionOp = 0x0050;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0051;

		///<summary><![CDATA[int]]></summary>
		public const int VolumeSizeX = 0x0054;

		///<summary><![CDATA[int]]></summary>
		public const int VolumeSizeY = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int VolumeSizeZ = 0x005C;

		///<summary><![CDATA[int]]></summary>
		public const int SubImagesX = 0x0060;

		///<summary><![CDATA[int]]></summary>
		public const int SubImagesY = 0x0064;

		///<summary><![CDATA[int]]></summary>
		public const int FrameCount = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int FramesPerSecond = 0x006C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoop = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0071;

		///<summary><![CDATA[UVectorFieldStatic *]]></summary>
		public const int NoiseField = 0x0078;

		///<summary><![CDATA[float]]></summary>
		public const int NoiseScale = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int NoiseMax = 0x0084;

	}

	public class UVectorFieldStatic
	{
		///<summary><![CDATA[int]]></summary>
		public const int SizeX = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int SizeY = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int SizeZ = 0x0050;

		///<summary><![CDATA[unsigned char[0x84]]]></summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UWorldComposition
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<ULevelStreaming * >]]></summary>
		public const int TilesStreaming = 0x0048;

		///<summary><![CDATA[double]]></summary>
		public const int TilesStreamingTimeThreshold = 0x0058;

		///<summary><![CDATA[bool]]></summary>
		public const int bLoadAllTilesDuringCinematic = 0x0060;

		///<summary><![CDATA[bool]]></summary>
		public const int bRebaseOriginIn3DSpace = 0x0061;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x0062;

		///<summary><![CDATA[float]]></summary>
		public const int RebaseOriginDistance = 0x0064;

	}

}
