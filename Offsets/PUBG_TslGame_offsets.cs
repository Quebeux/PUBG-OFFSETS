/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UActionInputEventHolder
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class ATslBaseHUD
	{
		///<summary>UClass *</summary>
		public const int MainUMGHudClass = 0x0488;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0490;

		///<summary>TArray<UActionInputEventHolder * ></summary>
		public const int ActionInputEventHolderArray = 0x0498;

		///<summary>TMap<FString,FTslWidgetState></summary>
		public const int WidgetStateMap = 0x04A8;

		///<summary>TArray<FString></summary>
		public const int UseMouseWidgetStack = 0x04F8;

		///<summary>UUserWidget *</summary>
		public const int MainUMGHud = 0x0508;

	}

	public class AAirborneEjectionArea
	{
		///<summary>USphereComponent *</summary>
		public const int SphereComponent = 0x03A0;

		///<summary>float</summary>
		public const int Radius = 0x03A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03AC;

	}

	public class UAnimDB
	{
		///<summary>FAnimInfo</summary>
		public const int Stand_Info = 0x0028;

		///<summary>FAnimInfo</summary>
		public const int Crouch_Info = 0x0090;

		///<summary>FAnimInfo</summary>
		public const int Prone_Info = 0x00F8;

		///<summary>float</summary>
		public const int BlendSpaceSpeed_Walk = 0x0160;

		///<summary>float</summary>
		public const int BlendSpaceSpeed_Run = 0x0164;

		///<summary>float</summary>
		public const int BlendSpaceSpeed_Sprint = 0x0168;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x016C;

	}

	public class UAnimNotify_CharacterAnimationNotify
	{
		///<summary>FName</summary>
		public const int NotifyName = 0x0038;

	}

	public class UAnimNotify_UnarmedAttack
	{
		///<summary>FName</summary>
		public const int NotifyName = 0x0038;

	}

	public class UAnimNotify_WeaponAnimationNotify
	{
		///<summary>FName</summary>
		public const int NotifyName = 0x0038;

	}

	public class UAsyncStaticMeshComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0810;

		///<summary>TAssetPtr<UStaticMesh></summary>
		public const int StaticMeshAsset = 0x0818;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0838;

		///<summary>UStaticMesh *</summary>
		public const int ErrorStaticMesh = 0x0840;

		///<summary>FName</summary>
		public const int ClientCollisionProfileNameOverride = 0x0848;

		///<summary>TAssetPtr<UStaticMesh></summary>
		public const int PendingStaticMeshAsset = 0x0850;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0870;

	}

	public class UBTDecorator_HasLoSTo
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int EnemyKey = 0x0068;

	}

	public class ATslBuff
	{
		///<summary>FName</summary>
		public const int OverlapId = 0x03A0;

		///<summary>TEnumAsByte<EBuffOverlapSolveMethod></summary>
		public const int OverlapSolveMethod = 0x03A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03A9;

		///<summary>float</summary>
		public const int BuffTickInterval = 0x03AC;

		///<summary>float</summary>
		public const int BuffTickFirstDelay = 0x03B0;

		///<summary>float</summary>
		public const int BuffDuration = 0x03B4;

		///<summary>bool</summary>
		public const int Infinite = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03B9;

		///<summary>FName</summary>
		public const int AttachSocket = 0x03C0;

		///<summary>UClass *</summary>
		public const int AttachServerPaticleClass = 0x03C8;

		///<summary>bool</summary>
		public const int IsDebuff = 0x03D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x03D1;

		///<summary>UBuffComponet *</summary>
		public const int OwnerBuffComponent = 0x03D8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x03E0;

		///<summary>ATslServerParticle *</summary>
		public const int AttachedServerPaticle = 0x03F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x03F8;

	}

	public class UBuffComponet
	{
		///<summary>TArray<ATslBuff * ></summary>
		public const int Buffs = 0x00F8;

	}

	public class UCameraSettings
	{
		///<summary>float</summary>
		public const int CameraPitchMinStand = 0x0028;

		///<summary>float</summary>
		public const int CameraPitchMaxStand = 0x002C;

		///<summary>float</summary>
		public const int CameraYawMinStand = 0x0030;

		///<summary>float</summary>
		public const int CameraYawMaxStand = 0x0034;

		///<summary>float</summary>
		public const int CameraPitchMinProne = 0x0038;

		///<summary>float</summary>
		public const int CameraPitchMaxProne = 0x003C;

		///<summary>float</summary>
		public const int CameraYawMinProne = 0x0040;

		///<summary>float</summary>
		public const int CameraYawMaxProne = 0x0044;

		///<summary>float</summary>
		public const int FPSShowOnHighScopingFOV = 0x0048;

		///<summary>float</summary>
		public const int TPSShowOnHighScopingFOV = 0x004C;

		///<summary>float</summary>
		public const int CameraPitchMinInVehicle = 0x0050;

		///<summary>float</summary>
		public const int CameraPitchMaxInVehicle = 0x0054;

		///<summary>float</summary>
		public const int CameraYawMinInVehicle = 0x0058;

		///<summary>float</summary>
		public const int CameraYawMaxInVehicle = 0x005C;

		///<summary>FName</summary>
		public const int HeadBoneName = 0x0060;

		///<summary>TArray<FString></summary>
		public const int HideMaterialsWhenCameraIsInHead = 0x0068;

		///<summary>TArray<FString></summary>
		public const int HideMaterialsOnScopeMode = 0x0078;

		///<summary>TArray<FString></summary>
		public const int HideMaterialsOnHighScopeMode = 0x0088;

	}

	public class UCastComponent
	{
		///<summary>FScriptDelegate</summary>
		public const int OnFinishCast = 0x00F8;

		///<summary>FScriptDelegate</summary>
		public const int OnCancelCast = 0x0108;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0118;

	}

	public class UCharacterBreathComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x00F8;

		///<summary>float</summary>
		public const int Breath = 0x0108;

		///<summary>float</summary>
		public const int BreathMax = 0x010C;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtStand = 0x0110;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtCrouch = 0x011C;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtProne = 0x0128;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtGroggy = 0x0134;

		///<summary>UClass *</summary>
		public const int RestorationBuff = 0x0140;

		///<summary>UClass *</summary>
		public const int ApneaDebuff = 0x0148;

		///<summary>UClass *</summary>
		public const int HoldBreathDebuff = 0x0150;

		///<summary>float</summary>
		public const int MinimumBreathStartHoldingBreath = 0x0158;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x015C;

		///<summary>UClass *</summary>
		public const int SprintDebuff = 0x0160;

		///<summary>float</summary>
		public const int MinimumBreathStartSprinting = 0x0168;

		///<summary>unsigned char[0x24]</summary>
		public const int UnknownData02 = 0x016C;

	}

	public class ACharacterStudio
	{
		///<summary>USpringArmComponent *</summary>
		public const int SpringArmComponent = 0x03A0;

		///<summary>UCameraComponent *</summary>
		public const int CameraComponent = 0x03A8;

		///<summary>USceneCaptureComponent2D *</summary>
		public const int SceneCaptureComponent = 0x03B0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int TextureTarget = 0x03B8;

		///<summary>bool</summary>
		public const int bUseDynamicResolution = 0x03C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03C1;

		///<summary>float</summary>
		public const int MaxViewDistance = 0x03C4;

		///<summary>UClass *</summary>
		public const int MaleCharacterProxyClass = 0x03C8;

		///<summary>UClass *</summary>
		public const int FemaleCharacterProxyClass = 0x03D0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03D8;

		///<summary>FTransform</summary>
		public const int CharacterInitialTransform = 0x03E0;

		///<summary>ATslCharacterProxy *</summary>
		public const int CharacterProxy = 0x0410;

		///<summary>USceneComponent *</summary>
		public const int CharacterRotationPivot = 0x0418;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int SceneCaptureMaterial = 0x0420;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0428;

	}

	public class UCoherentCommonBinder
	{
		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FString</summary>
		public const int DefaultLobbyUrl = 0x0088;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0098;

	}

	public class UCoherentWidgetBinder
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x00A0;

	}

	public class ATslPlayerController
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnShowReplayTimeline = 0x06D0;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x06E0;

		///<summary>unsigned char:1</summary>
		public const int UnknownData01 = 0x0708;

		///<summary>unsigned char:1</summary>
		public const int bIsSpectated = 0x0708;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0709;

		///<summary>FVector</summary>
		public const int CameraPeekLeftMove = 0x070C;

		///<summary>FVector</summary>
		public const int CameraPeekRightMove = 0x0718;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x0724;

		///<summary>TEnumAsByte<ECameraViewBehaviour></summary>
		public const int CameraViewBehaviour = 0x0734;

		///<summary>unsigned char[0x23]</summary>
		public const int UnknownData04 = 0x0735;

		///<summary>FVector_NetQuantizeNormal</summary>
		public const int SpectatorAccumViewRotation = 0x0758;

		///<summary>TEnumAsByte<EObserverAuthorityType></summary>
		public const int ObserverAuthorityType = 0x0764;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData05 = 0x0765;

		///<summary>UActorComponent *</summary>
		public const int InteractionTargetComponent = 0x0778;

		///<summary>ATslCharacter *</summary>
		public const int SpectatorViewCharacter = 0x0780;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData06 = 0x0788;

		///<summary>ATslAchievement *</summary>
		public const int Achievement = 0x0798;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData07 = 0x07A0;

		///<summary>UMeshComponent *</summary>
		public const int SpectatorScopeMesh = 0x07B0;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData08 = 0x07B8;

		///<summary>TArray<FNearClippingLevelOverZ></summary>
		public const int NearClippingLevelsOverZ = 0x0810;

		///<summary>float</summary>
		public const int MaxValidPing = 0x0820;

		///<summary>float</summary>
		public const int DefaultFOV = 0x0824;

		///<summary>UVivoxComponent *</summary>
		public const int VivoxComponent = 0x0828;

		///<summary>TArray<ATeam * ></summary>
		public const int Teams = 0x0830;

		///<summary>TArray<TWeakObjectPtr<ATslCharacter>></summary>
		public const int ReplicateTeamMembers = 0x0840;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData09 = 0x0850;

		///<summary>TArray<TWeakObjectPtr<ATslCharacter>></summary>
		public const int ReplicateCharacter = 0x08A0;

		///<summary>TArray<TWeakObjectPtr<ACarePackageItem>></summary>
		public const int ReplicateCarePackageItemList = 0x08B0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData10 = 0x08C0;

		///<summary>float</summary>
		public const int DeathResultDelaySeconds = 0x08E0;

		///<summary>unsigned char[0xBC]</summary>
		public const int UnknownData11 = 0x08E4;

		///<summary>FPingPongSummary</summary>
		public const int PingPongSummary = 0x09A0;

		///<summary>unsigned char[0x5C]</summary>
		public const int UnknownData12 = 0x09AC;

	}

	public class ADeployedItem
	{
		///<summary>UClass *</summary>
		public const int ItemType = 0x03A0;

		///<summary>int</summary>
		public const int StackCount = 0x03A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03AC;

		///<summary>USceneComponent *</summary>
		public const int SceneComponent = 0x03B0;

	}

	public class ASubActor
	{
		///<summary>ATslCharacter *</summary>
		public const int NetOwnerCharacter = 0x03A0;

	}

	public class AItemSlotContainer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A8;

		///<summary>FScriptDelegate</summary>
		public const int OnCreateAndShowContextMenuWidget = 0x03B0;

		///<summary>FScriptDelegate</summary>
		public const int OnDestroyContextMenuWidget = 0x03C0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03D0;

	}

	public class AItemExplorer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03D8;

		///<summary>FScriptDelegate</summary>
		public const int OnUpdateItemList = 0x03E0;

		///<summary>FScriptDelegate</summary>
		public const int OnClearItemList = 0x03F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0400;

	}

	public class UItem
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>unsigned char:1</summary>
		public const int bStackable = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bUsable = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bDisableSpawnInGame = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0039;

		///<summary>int</summary>
		public const int StackCount = 0x003C;

		///<summary>FText</summary>
		public const int ItemName = 0x0040;

		///<summary>FText</summary>
		public const int ItemCategory = 0x0058;

		///<summary>FText</summary>
		public const int ItemDetailedName = 0x0070;

		///<summary>FText</summary>
		public const int ItemDescription = 0x0088;

		///<summary>float</summary>
		public const int ItemMaxInteractableDistance = 0x00A0;

		///<summary>int</summary>
		public const int StackCountMax = 0x00A4;

		///<summary>float</summary>
		public const int SpacePerItem = 0x00A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00AC;

		///<summary>TAssetPtr<UStaticMesh></summary>
		public const int DroppedMesh = 0x00B0;

		///<summary>float</summary>
		public const int DroppedMeshScale = 0x00D0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x00D4;

		///<summary>TAssetPtr<UTexture></summary>
		public const int Icon = 0x00D8;

		///<summary>TAssetPtr<UTexture></summary>
		public const int ToolTipIcon = 0x00F8;

		///<summary>float</summary>
		public const int IconSizeRatio = 0x0118;

		///<summary>float</summary>
		public const int ToolTipIconSizeRatio = 0x011C;

		///<summary>UAkAudioEvent *</summary>
		public const int DropSoundAk = 0x0120;

		///<summary>UAkAudioEvent *</summary>
		public const int PickUpSoundAk = 0x0128;

		///<summary>UAkAudioEvent *</summary>
		public const int InventoryPutSoundAk = 0x0130;

		///<summary>int</summary>
		public const int SortPriority = 0x0138;

		///<summary>int</summary>
		public const int LobbyItemID = 0x013C;

		///<summary>FLobbyItemDesc</summary>
		public const int LobbyItemDesc = 0x0140;

		///<summary>TEnumAsByte<EItemCategory></summary>
		public const int Category = 0x0170;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0171;

		///<summary>FName</summary>
		public const int SubCategory = 0x0178;

		///<summary>bool</summary>
		public const int bIsToy = 0x0180;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x0181;

	}

	public class AItemPackage
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0408;

		///<summary>FText</summary>
		public const int PackageName = 0x0418;

		///<summary>FText</summary>
		public const int PackageCategory = 0x0430;

		///<summary>FText</summary>
		public const int PackageDetailedName = 0x0448;

		///<summary>FText</summary>
		public const int PackageDescription = 0x0460;

		///<summary>UTexture *</summary>
		public const int PackageIcon = 0x0478;

		///<summary>float</summary>
		public const int PackageIconSizeRatio = 0x0480;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0484;

		///<summary>UTexture *</summary>
		public const int PackageToolTipIcon = 0x0488;

		///<summary>float</summary>
		public const int PackageToolTipIconSizeRatio = 0x0490;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0494;

		///<summary>TAssetPtr<UStaticMesh></summary>
		public const int PackageMesh = 0x0498;

		///<summary>UBoxComponent *</summary>
		public const int BoxComponent = 0x04B8;

		///<summary>UOnceInteractionComponent *</summary>
		public const int InteractionComponent = 0x04C0;

		///<summary>bool</summary>
		public const int DestroyByEmptyItem = 0x04C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x04C9;

		///<summary>TArray<UItem * ></summary>
		public const int Items = 0x04D0;

		///<summary>FString</summary>
		public const int CreatorName = 0x04E0;

		///<summary>int</summary>
		public const int SortPriority = 0x04F0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x04F4;

	}

	public class ADeployedItemPackage
	{
		///<summary>UClass *</summary>
		public const int ItemPackageType = 0x03A0;

		///<summary>TArray<FPackagedItemInfo></summary>
		public const int ItemInfos = 0x03A8;

	}

	public class UDoorDataAsset
	{
		///<summary>float</summary>
		public const int OpenAngle = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

		///<summary>UCurveFloat *</summary>
		public const int OpenCurve = 0x0030;

		///<summary>float</summary>
		public const int OpenCurveDuration = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x003C;

		///<summary>UCurveFloat *</summary>
		public const int CloseCurve = 0x0040;

		///<summary>float</summary>
		public const int CloseCurveDuration = 0x0048;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x004C;

		///<summary>UAkAudioEvent *</summary>
		public const int OpenSound = 0x0050;

		///<summary>UAkAudioEvent *</summary>
		public const int CloseSound = 0x0058;

	}

	public class UTslReactionDoorData
	{
		///<summary>float</summary>
		public const int PointDamageImpulse = 0x0028;

		///<summary>float</summary>
		public const int PointDamageRadius = 0x002C;

		///<summary>float</summary>
		public const int BreakingRadius = 0x0030;

		///<summary>float</summary>
		public const int BreakingImpulse = 0x0034;

		///<summary>float</summary>
		public const int BreakingMinDamage = 0x0038;

		///<summary>float</summary>
		public const int DamageAccumulateTimeout = 0x003C;

		///<summary>float</summary>
		public const int ZombieDamageAccumulateTimeout = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0044;

		///<summary>FName</summary>
		public const int TopImpactSoketName = 0x0048;

		///<summary>FName</summary>
		public const int CenterImpactSoketName = 0x0050;

		///<summary>FName</summary>
		public const int BottomImpactSoketName = 0x0058;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructibleSoundAk = 0x0060;

	}

	public class UDoorFrameComponent
	{
		///<summary>FTransform</summary>
		public const int DoorTransform = 0x0810;

		///<summary>FVector</summary>
		public const int SoundOffsetFromDoor = 0x0840;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x084C;

		///<summary>UStaticMesh *</summary>
		public const int DoorStaticMesh = 0x0850;

		///<summary>UDestructibleMesh *</summary>
		public const int DoorDestructibleMesh = 0x0858;

		///<summary>UDoorDataAsset *</summary>
		public const int DoorDataAsset = 0x0860;

		///<summary>UTslReactionDoorData *</summary>
		public const int ReactionDoorData = 0x0868;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0870;

	}

	public class ADroppedItem
	{
		///<summary>UItem *</summary>
		public const int Item = 0x03A0;

	}

	public class ADroppedItemGridManager
	{
		///<summary>float</summary>
		public const int MaxGridSize = 0x03A0;

		///<summary>int</summary>
		public const int MaxGridLayerNum = 0x03A4;

		///<summary>int</summary>
		public const int MaxItemNumPerGroup = 0x03A8;

		///<summary>unsigned char[0xA4]</summary>
		public const int UnknownData00 = 0x03AC;

	}

	public class ADroppedItemGroup
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>float</summary>
		public const int RandomSpawnRadius = 0x03A4;

		///<summary>int</summary>
		public const int MaxRandomSpawnCount = 0x03A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03AC;

	}

	public class UExportableDataAsset
	{
		///<summary>FDirectoryPath</summary>
		public const int JsonSaveDirectory = 0x0028;

		///<summary>FString</summary>
		public const int JsonSaveFileName = 0x0038;

	}

	public class ULobbyCustomizableData
	{
		///<summary>TArray<FLobbyFaceElement></summary>
		public const int Faces = 0x0048;

		///<summary>TArray<FLobbyHairElement></summary>
		public const int Hairs = 0x0058;

	}

	public class AFlashBangCaptureActor
	{
		///<summary>USceneComponent *</summary>
		public const int SceneRootComponent = 0x03A0;

		///<summary>USceneCaptureComponent2D *</summary>
		public const int SceneCapture = 0x03A8;

		///<summary>APawn *</summary>
		public const int PlayerPawnReference = 0x03B0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int CaptureTexture = 0x03B8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03C0;

	}

	public class UGameEventObserver
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMatchStarted = 0x0028;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMatchEnded = 0x0038;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKillOtherPlayer = 0x0048;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDie = 0x0058;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDamage = 0x0068;

	}

	public class UGameStateListenerComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMatchStateChange = 0x00F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGameModeEvent = 0x0108;

	}

	public class UTableGeneralItemSpawner
	{
		///<summary>UDataTable *</summary>
		public const int RawItemSpawnDataTable = 0x0028;

		///<summary>UDataTable *</summary>
		public const int RawItemSpawnTogetherDataTable = 0x0030;

		///<summary>TArray<FGeneralItemSpawnProb></summary>
		public const int SpawnProbArray = 0x0038;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UHackReporterComponent
	{
		///<summary>unsigned char[0x188]</summary>
		public const int UnknownData00 = 0x00F8;

	}

	public class UHighlightSession
	{
		///<summary>FHighlightRecordConfig</summary>
		public const int Config_Kill = 0x0028;

		///<summary>FHighlightRecordConfig</summary>
		public const int Config_KillGroggy = 0x0034;

		///<summary>FHighlightRecordConfig</summary>
		public const int Config_Die = 0x0040;

		///<summary>FHighlightRecordConfig</summary>
		public const int Config_DieGroggy = 0x004C;

		///<summary>FHighlightRecordConfig</summary>
		public const int Config_EndMatch = 0x0058;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0064;

		///<summary>ATslHUD *</summary>
		public const int TslHUD = 0x0068;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData01 = 0x0070;

	}

	public class UInteractionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x00F8;

		///<summary>float</summary>
		public const int MaxInteractableDistance = 0x0108;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x010C;

		///<summary>FText</summary>
		public const int InteractionVerb = 0x0110;

		///<summary>FText</summary>
		public const int InteractiveObjectName = 0x0128;

		///<summary>FCastConfig</summary>
		public const int CastConfig = 0x0140;

		///<summary>bool</summary>
		public const int bUseTraceCheck = 0x0170;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0171;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInteractBy = 0x0178;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ClientOnInteractBy = 0x0188;

		///<summary>unsigned char[0xE8]</summary>
		public const int UnknownData03 = 0x0198;

	}

	public class UDoublePhaseInteractionComponent
	{
		///<summary>FText</summary>
		public const int FirstInteractionVerb = 0x0280;

		///<summary>FText</summary>
		public const int FirstInteractiveObjectName = 0x0298;

		///<summary>FText</summary>
		public const int SecondInteractionVerb = 0x02B0;

		///<summary>FText</summary>
		public const int SecondInteractiveObjectName = 0x02C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSecondInteractBy = 0x02E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ClientOnSecondInteractBy = 0x02F0;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0300;

	}

	public class UDroppedItemActorComponent
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0280;

	}

	public class UOnceInteractionComponent
	{
		///<summary>TArray<FName></summary>
		public const int CharacterHistory = 0x0280;

	}

	public class UAmmoItem
	{
		///<summary>UTexture *</summary>
		public const int AmmoIcon = 0x0188;

		///<summary>float</summary>
		public const int AmmoIconRatio = 0x0190;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0194;

	}

	public class UAttachableItem
	{
		///<summary>FWeaponAttachmentData</summary>
		public const int AttachmentData = 0x0188;

		///<summary>TAssetPtr<UStaticMesh></summary>
		public const int AttachmentMeshAsset = 0x0240;

		///<summary>TArray<FWeaponAttachmentWeaponTagData></summary>
		public const int AttachmentWeaponTagData = 0x0260;

		///<summary>bool</summary>
		public const int EquipOnPickUp = 0x0270;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0271;

		///<summary>UAkAudioEvent *</summary>
		public const int AttachedSoundAk = 0x0278;

	}

	public class UCastableItem
	{
		///<summary>FCastConfig</summary>
		public const int CastConfig = 0x0188;

		///<summary>bool</summary>
		public const int bCanUseInWater = 0x01B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01B9;

	}

	public class UEquipableItem
	{
		///<summary>TEnumAsByte<EEquipSlotID></summary>
		public const int EquipSlotID = 0x0188;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0189;

		///<summary>float</summary>
		public const int SpaceExtension = 0x018C;

		///<summary>float</summary>
		public const int DamageReductionRate = 0x0190;

		///<summary>float</summary>
		public const int DurabilityMax = 0x0194;

		///<summary>bool</summary>
		public const int DestroyByDurability = 0x0198;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0199;

		///<summary>float</summary>
		public const int Durability = 0x019C;

		///<summary>TEnumAsByte<EDurabilityConsumeType></summary>
		public const int DurabilityConsumeType = 0x01A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x01A1;

		///<summary>FCustomizableObjectIdentifier</summary>
		public const int CustomizableObjectIdentifierForMale = 0x01A8;

		///<summary>FCustomizableObjectIdentifier</summary>
		public const int CustomizableObjectIdentifierForFemale = 0x01D8;

		///<summary>UAkAudioEvent *</summary>
		public const int EquipedSoundAk = 0x0208;

		///<summary>TEnumAsByte<EEquipableItemSoundGroup></summary>
		public const int SoundGroup = 0x0210;

		///<summary>TEnumAsByte<EEquipableItemSoundType></summary>
		public const int SoundType = 0x0211;

		///<summary>bool</summary>
		public const int bCanZombieEquip = 0x0212;

		///<summary>bool</summary>
		public const int bIsUnequipable = 0x0213;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0214;

		///<summary>TAssetPtr<UTexture></summary>
		public const int HudDisplayEquipIcon = 0x0218;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0238;

	}

	public class UCustomEquipableItem
	{
		///<summary>int</summary>
		public const int ItemLevel = 0x0240;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0244;

		///<summary>FTransform</summary>
		public const int SlotOffset_Primary = 0x0250;

		///<summary>FTransform</summary>
		public const int SlotOffset_Secondary = 0x0280;

		///<summary>FTransform</summary>
		public const int SlotOffset_SideArm = 0x02B0;

		///<summary>FTransform</summary>
		public const int SlotOffset_Melee = 0x02E0;

		///<summary>FTransform</summary>
		public const int SlotOffset_Thrown = 0x0310;

	}

	public class UParachuteItem
	{
		///<summary>UClass *</summary>
		public const int ParachuteType = 0x0240;

	}

	public class UThrowableItem
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0240;

		///<summary>UClass *</summary>
		public const int WeaponType = 0x0248;

		///<summary>ATslWeapon *</summary>
		public const int EquippedWeapon = 0x0250;

	}

	public class ATslWeapon
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>UTexture *</summary>
		public const int WeaponIcon = 0x03A8;

		///<summary>float</summary>
		public const int WeaponIconRatio = 0x03B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03B4;

		///<summary>FCanvasIcon</summary>
		public const int PrimaryIcon = 0x03B8;

		///<summary>FCanvasIcon</summary>
		public const int SecondaryIcon = 0x03D0;

		///<summary>FCanvasIcon</summary>
		public const int PrimaryClipIcon = 0x03E8;

		///<summary>FCanvasIcon</summary>
		public const int SecondaryClipIcon = 0x0400;

		///<summary>float</summary>
		public const int AmmoIconsCount = 0x0418;

		///<summary>int</summary>
		public const int PrimaryClipIconOffset = 0x041C;

		///<summary>int</summary>
		public const int SecondaryClipIconOffset = 0x0420;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0424;

		///<summary>FCanvasIcon[0x5]</summary>
		public const int Crosshair = 0x0428;

		///<summary>FCanvasIcon[0x5]</summary>
		public const int AimingCrosshair = 0x04A0;

		///<summary>bool</summary>
		public const int UseLaserDot = 0x0518;

		///<summary>bool</summary>
		public const int UseCustomCrosshair = 0x0519;

		///<summary>bool</summary>
		public const int UseCustomAimingCrosshair = 0x051A;

		///<summary>bool</summary>
		public const int bHideCrosshairWhileNotAiming = 0x051B;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x051C;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnUpdatedAttachment = 0x0520;

		///<summary>ATslCharacter *</summary>
		public const int MyPawn = 0x0530;

		///<summary>FWeaponData</summary>
		public const int WeaponConfig = 0x0538;

		///<summary>TEnumAsByte<EWeaponHand></summary>
		public const int WeaponHand = 0x05C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x05C9;

		///<summary>USkeletalMeshComponent *</summary>
		public const int Mesh3P = 0x05D0;

		///<summary>USceneComponent *</summary>
		public const int RootScene = 0x05D8;

		///<summary>USceneComponent *</summary>
		public const int HandIK_Left = 0x05E0;

		///<summary>USceneComponent *</summary>
		public const int HandIK_Right = 0x05E8;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData05 = 0x05F0;

		///<summary>TEnumAsByte<EAttachmentCalculateType></summary>
		public const int AttachmentAniRateCalculateType = 0x05F1;

		///<summary>TEnumAsByte<EAttachmentCalculateType></summary>
		public const int AttachmentRecoilPatternScaleCalculateType = 0x05F2;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData06 = 0x05F3;

		///<summary>TArray<FWeaponAttachmentPositionData></summary>
		public const int AttachmentPositionData = 0x05F8;

		///<summary>TArray<FWeaponAttachmentAssetData></summary>
		public const int DefaultAttachedItemAssets = 0x0608;

		///<summary>TArray<UClass * ></summary>
		public const int AttachedItemClasses = 0x0618;

		///<summary>FName</summary>
		public const int WeaponTag = 0x0628;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData07 = 0x0630;

		///<summary>UAkComponent *</summary>
		public const int AkComponent = 0x0698;

		///<summary>FName</summary>
		public const int MuzzleAttachPoint = 0x06A0;

		///<summary>FName</summary>
		public const int FiringAttachPoint = 0x06A8;

		///<summary>FName</summary>
		public const int ScopingAttachPoint = 0x06B0;

		///<summary>UParticleSystem *</summary>
		public const int MuzzleFx = 0x06B8;

		///<summary>FName</summary>
		public const int ShellFxAttachPoint = 0x06C0;

		///<summary>UClass *</summary>
		public const int ShellFxClass = 0x06C8;

		///<summary>UParticleSystemComponent *</summary>
		public const int MuzzlePSC = 0x06D0;

		///<summary>UParticleSystemComponent *</summary>
		public const int MuzzlePSCSecondary = 0x06D8;

		///<summary>UClass *</summary>
		public const int FireCameraShake = 0x06E0;

		///<summary>UForceFeedbackEffect *</summary>
		public const int FireForceFeedback = 0x06E8;

		///<summary>UAkAudioEvent *</summary>
		public const int FireSoundAk = 0x06F0;

		///<summary>UAkAudioEvent *</summary>
		public const int FireLoopSoundAk = 0x06F8;

		///<summary>UAkAudioEvent *</summary>
		public const int FireFinishSoundAk = 0x0700;

		///<summary>UAkAudioEvent *</summary>
		public const int OutOfAmmoSoundAk = 0x0708;

		///<summary>UAkAudioEvent *</summary>
		public const int ReloadSoundAk = 0x0710;

		///<summary>UAkAudioEvent *</summary>
		public const int EquipSoundAk = 0x0718;

		///<summary>UAkAudioEvent *</summary>
		public const int AimingStartSoundAk = 0x0720;

		///<summary>UAkAudioEvent *</summary>
		public const int AimingFinishSoundAk = 0x0728;

		///<summary>UAkAudioEvent *</summary>
		public const int ScopingStartSoundAk = 0x0730;

		///<summary>UAkAudioEvent *</summary>
		public const int ScopingFinishSoundAk = 0x0738;

		///<summary>TEnumAsByte<EAnimWeaponType></summary>
		public const int AnimWeaponType = 0x0740;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData08 = 0x0741;

		///<summary>FWeaponBasicAnim</summary>
		public const int WeaponAnim = 0x0748;

		///<summary>FWeaponRollAnim</summary>
		public const int ProneRollAnim = 0x0760;

		///<summary>float</summary>
		public const int HipDuration = 0x0770;

		///<summary>unsigned char:1</summary>
		public const int bLoopedMuzzleFX = 0x0774;

		///<summary>unsigned char:1</summary>
		public const int bLoopedFireSound = 0x0774;

		///<summary>unsigned char[0x33]</summary>
		public const int UnknownData09 = 0x0775;

	}

	public class UWeaponItem
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0240;

		///<summary>UClass *</summary>
		public const int WeaponType = 0x0248;

		///<summary>int</summary>
		public const int AmmoCount = 0x0250;

		///<summary>int</summary>
		public const int AmmoPerClip = 0x0254;

		///<summary>TArray<FWeaponAttachmentTagData></summary>
		public const int AttachmentTagData = 0x0258;

		///<summary>FName</summary>
		public const int WeaponTag = 0x0268;

		///<summary>TArray<UAttachableItem * ></summary>
		public const int AttachedItems = 0x0270;

		///<summary>TEnumAsByte<EFiringMode></summary>
		public const int FiringMode = 0x0280;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0281;

		///<summary>ATslWeapon *</summary>
		public const int EquippedWeapon = 0x0288;

	}

	public class URandomlyGeneratableItem
	{
		///<summary>FString</summary>
		public const int RandomExpression = 0x0188;

		///<summary>unsigned char:1</summary>
		public const int bOpenByKey = 0x0198;

		///<summary>unsigned char:1</summary>
		public const int bOpenByPoint = 0x0198;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0199;

		///<summary>TAssetPtr<UClass></summary>
		public const int OpenKeyItem = 0x01A0;

		///<summary>int</summary>
		public const int OpenKeyItemCount = 0x01C0;

		///<summary>int</summary>
		public const int PointOpenPrice = 0x01C4;

		///<summary>int</summary>
		public const int ExchangeBundleId = 0x01C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01CC;

		///<summary>TArray<FLobbyItemBundle></summary>
		public const int BundleList = 0x01D0;

		///<summary>TArray<TAssetPtr<UClass>></summary>
		public const int ReferenceItems = 0x01E0;

	}

	public class UItemSpawnProcessor
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USpawnTableItemSpawnProcessor
	{
		///<summary>TArray<FItemSpotGroupTypeProperty></summary>
		public const int RawSpotGroupProperties = 0x0038;

		///<summary>UDataTable *</summary>
		public const int RawItemSpawnDataTable = 0x0048;

		///<summary>UDataTable *</summary>
		public const int RawItemSpawnTogetherDataTable = 0x0050;

		///<summary>unsigned char[0xEB8]</summary>
		public const int UnknownData00 = 0x0058;

		///<summary>bool</summary>
		public const int bUseActorSpawn = 0x0F10;

		///<summary>unsigned char[0x57]</summary>
		public const int UnknownData01 = 0x0F11;

	}

	public class AItemSpot
	{
		///<summary>UItemSpotGroupComponent *</summary>
		public const int SpotGroupComponent = 0x03A0;

	}

	public class UItemSpotComponent
	{
		///<summary>TEnumAsByte<EItemSpotType></summary>
		public const int ItemSpotType = 0x0300;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x0301;

	}

	public class UItemSpotGroupComponent
	{
		///<summary>TEnumAsByte<EItemSpotGroupType></summary>
		public const int SpotGroupType = 0x0300;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x0301;

	}

	public class AItemStudio
	{
		///<summary>FName</summary>
		public const int CameraSocketName = 0x03A0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int TextureTarget = 0x03A8;

		///<summary>float</summary>
		public const int MaxViewDistance = 0x03B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03B4;

		///<summary>UCameraComponent *</summary>
		public const int CameraComponent = 0x03B8;

		///<summary>USceneCaptureComponent2D *</summary>
		public const int SceneCaptureComponent = 0x03C0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03C8;

		///<summary>FTransform</summary>
		public const int DefaultCameraSocketTransform = 0x03D0;

	}

	public class ALevelAttribute
	{
		///<summary>int</summary>
		public const int NumMapBlock = 0x03A0;

		///<summary>FBox2D</summary>
		public const int MapRect2D = 0x03A4;

		///<summary>UMaterialInterface *</summary>
		public const int MapImageMaterial = 0x03B8;

	}

	public class ULobbyItemBundleIdPublisher
	{
		///<summary>FString</summary>
		public const int LobbyItemPath = 0x0028;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0038;

	}

	public class ULobbyLink
	{
		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UMatchPreparer
	{
		///<summary>int</summary>
		public const int WarmupTime = 0x0028;

		///<summary>int</summary>
		public const int WarmupTimeInPIE = 0x002C;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UAirborneMatchPreparer
	{
		///<summary>UClass *</summary>
		public const int AircraftClass = 0x0058;

		///<summary>TArray<ATransportAircraftVehicle * ></summary>
		public const int Aircrafts = 0x0060;

		///<summary>int</summary>
		public const int AircraftCount = 0x0070;

		///<summary>int</summary>
		public const int AircraftCapacityOverride = 0x0074;

		///<summary>float</summary>
		public const int AircraftAltitude = 0x0078;

		///<summary>float</summary>
		public const int EndThetaDegree = 0x007C;

		///<summary>float</summary>
		public const int AircraftIntervalDistance = 0x0080;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData00 = 0x0084;

	}

	public class UNormalMatchPreparer
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0058;

		///<summary>int</summary>
		public const int AvailablePlayerStartCount = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x006C;

	}

	public class UMaterialMergeSettings
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UMaterial *</summary>
		public const int MasterMaterial = 0x0080;

		///<summary>UMaterial *</summary>
		public const int MergedMaterial = 0x0088;

		///<summary>TArray<FMaterialMergerParameters></summary>
		public const int ParameterList = 0x0090;

		///<summary>bool</summary>
		public const int bUpdateParameterList = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00A1;

	}

	public class ABattleRoyaleModeController
	{
		///<summary>TArray<FBattleRoyalePoisionGasData></summary>
		public const int NormalPoisonGasDataArray = 0x0498;

		///<summary>TArray<FBattleRoyalePoisionGasData></summary>
		public const int FastPoisonGasDataArray = 0x04A8;

		///<summary>int</summary>
		public const int FastZonePlayerCount = 0x04B8;

		///<summary>float</summary>
		public const int BattleRoyaleZoneTypeCheckTime = 0x04BC;

		///<summary>TArray<float></summary>
		public const int PoisonWarningTime = 0x04C0;

		///<summary>float</summary>
		public const int WaterVolumeRayHeight = 0x04D0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x04D4;

		///<summary>TArray<ATslPhysicsVolume * ></summary>
		public const int OceanPhysicsVolume = 0x04E0;

		///<summary>TArray<ATslPassBluezoneArea * ></summary>
		public const int PassBluezoneAreas = 0x04F0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0500;

	}

	public class ACarePackageController
	{
		///<summary>UClass *</summary>
		public const int AircraftCarePackageClass = 0x0498;

		///<summary>FVector2D</summary>
		public const int StartDelay = 0x04A0;

		///<summary>FVector2D</summary>
		public const int SpawnInterval = 0x04A8;

		///<summary>float</summary>
		public const int FlyingHeight = 0x04B0;

		///<summary>float</summary>
		public const int CarePackageLifeTime = 0x04B4;

		///<summary>float</summary>
		public const int WhiteZoneSpawnInnerRate = 0x04B8;

		///<summary>float</summary>
		public const int DropAreaRate = 0x04BC;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x04C0;

	}

	public class ARedZoneController
	{
		///<summary>UClass *</summary>
		public const int BombTemplateClass = 0x0498;

		///<summary>float</summary>
		public const int StartDelay = 0x04A0;

		///<summary>FVector2D</summary>
		public const int NextCreateRedZoneInterval = 0x04A4;

		///<summary>float</summary>
		public const int BombingDelay = 0x04AC;

		///<summary>float</summary>
		public const int OuterRadius = 0x04B0;

		///<summary>FVector2D</summary>
		public const int LimitExceptExplosionRadius = 0x04B4;

		///<summary>float</summary>
		public const int ExceptExplosionRadius = 0x04BC;

		///<summary>float</summary>
		public const int RedZoneDuration = 0x04C0;

		///<summary>FVector2D</summary>
		public const int BombingInterval = 0x04C4;

		///<summary>float</summary>
		public const int RedZoneLifeTime = 0x04CC;

		///<summary>float</summary>
		public const int ReyStartHeight = 0x04D0;

		///<summary>float</summary>
		public const int RedZoneRadiusOffsetRate = 0x04D4;

		///<summary>FText</summary>
		public const int RedZoneStartText = 0x04D8;

		///<summary>int</summary>
		public const int RedZoneProjectileCount = 0x04F0;

		///<summary>float</summary>
		public const int RayCheckAroundLength = 0x04F4;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x04F8;

		///<summary>TArray<ATslPhysicsVolume * ></summary>
		public const int OceanPhysicsVolume = 0x0508;

	}

	public class AMutableCharacter
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x07C0;

		///<summary>TEnumAsByte<EGender></summary>
		public const int Gender = 0x07E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x07E1;

		///<summary>UCustomizableObjectInstance *</summary>
		public const int CustomizableObjectInstance = 0x07E8;

		///<summary>UTslCustomizableSkeletalComponent *</summary>
		public const int CustomizableSkeletalComponent = 0x07F0;

		///<summary>TArray<unsigned char></summary>
		public const int InstanceDescriptor = 0x07F8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0808;

	}

	public class ALobbyCharacter
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0810;

	}

	public class ATslVaultingHelper
	{
		///<summary>USceneComponent *</summary>
		public const int RootSceneComponent = 0x03A0;

		///<summary>USceneComponent *</summary>
		public const int ActorAttachScene = 0x03A8;

	}

	public class ATslWeapon_Gun
	{
		///<summary>bool</summary>
		public const int bSpawnBulletFromBarrel = 0x07A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x07A9;

		///<summary>int</summary>
		public const int AmmoPerClip = 0x07B0;

		///<summary>int</summary>
		public const int CurrentAmmoInClip = 0x07B4;

		///<summary>unsigned char:1</summary>
		public const int bIsHipped = 0x07B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x07B9;

		///<summary>float</summary>
		public const int TimeBetweenShots = 0x07BC;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData02 = 0x07C0;

		///<summary>int</summary>
		public const int FiringModeIndex = 0x07E0;

		///<summary>unsigned char[0x7C]</summary>
		public const int UnknownData03 = 0x07E4;

		///<summary>FWeaponGunData</summary>
		public const int WeaponGunConfig = 0x0860;

		///<summary>FWeaponDeviationData</summary>
		public const int WeaponDeviationConfig = 0x08F0;

		///<summary>FWeaponGunAnim</summary>
		public const int WeaponGunAnim = 0x0930;

	}

	public class AVehicleSeatActor
	{
		///<summary>float</summary>
		public const int ViewPitchMin = 0x03A0;

		///<summary>float</summary>
		public const int ViewPitchMax = 0x03A4;

		///<summary>float</summary>
		public const int ViewYawMin = 0x03A8;

		///<summary>float</summary>
		public const int ViewYawMax = 0x03AC;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMax = 0x03B0;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMin = 0x03B8;

		///<summary>bool</summary>
		public const int bCanOnlyFireWhileAiming = 0x03C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03C1;

		///<summary>UBlendSpaceBase *</summary>
		public const int SeatBlendspaceAiming = 0x03C8;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle = 0x03D0;

		///<summary>UAimOffsetBlendSpace *</summary>
		public const int SeatIdleAO = 0x03D8;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionOutBlendspace = 0x03E0;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionInBlendspace = 0x03E8;

		///<summary>bool</summary>
		public const int bRestricWeaponUse = 0x03F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03F1;

		///<summary>TArray<TEnumAsByte<EWeaponClass>></summary>
		public const int AllowedWeaponClasses = 0x03F8;

		///<summary>bool</summary>
		public const int bUseEntryVelocityRestriction = 0x0408;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0409;

		///<summary>float</summary>
		public const int MaxVelocityForEntry = 0x040C;

		///<summary>ATslCharacter *</summary>
		public const int Rider = 0x0410;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData03 = 0x0418;

		///<summary>TEnumAsByte<EVehicleAnimType></summary>
		public const int SeatAnimationType = 0x0424;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0425;

	}

	public class AWeaponProcessor
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnWeaponProcessorArmed = 0x03A8;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData01 = 0x03B8;

		///<summary>TArray<ATslWeapon * ></summary>
		public const int EquippedWeapons = 0x0438;

		///<summary>int</summary>
		public const int CurrentWeaponIndex = 0x0448;

		///<summary>unsigned char[0x24]</summary>
		public const int UnknownData02 = 0x044C;

	}

	public class UVaultingData
	{
		///<summary>float</summary>
		public const int LocationStartNormalScale = 0x0028;

		///<summary>float</summary>
		public const int LocationStartZOffset = 0x002C;

		///<summary>float</summary>
		public const int LocationEndNormalScale = 0x0030;

		///<summary>float</summary>
		public const int LocationEndZOffset = 0x0034;

		///<summary>bool</summary>
		public const int bIsClimb = 0x0038;

		///<summary>bool</summary>
		public const int bIsSlide = 0x0039;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x003A;

		///<summary>float</summary>
		public const int VaultInitialTimer = 0x003C;

		///<summary>float</summary>
		public const int ApexAdditiveStartTime = 0x0040;

		///<summary>float</summary>
		public const int ApexAdditiveEndTime = 0x0044;

		///<summary>float</summary>
		public const int PreApexSpeedScale = 0x0048;

		///<summary>float</summary>
		public const int PostApexSpeedScale = 0x004C;

		///<summary>float</summary>
		public const int VaultEndToFallTimerCutoff = 0x0050;

		///<summary>FVector2D</summary>
		public const int StartCutoffByDistance_InMap = 0x0054;

		///<summary>FVector2D</summary>
		public const int StartCutoffByDistance_OutMap = 0x005C;

		///<summary>FVector2D</summary>
		public const int StartCutoffBySpeed_InMap = 0x0064;

		///<summary>FVector2D</summary>
		public const int StartCutoffBySpeed_OutMap = 0x006C;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_InMap_PreApex = 0x0074;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_OutMap_PreApex = 0x007C;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_InMap_PostApex = 0x0084;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_OutMap_PostApex = 0x008C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0094;

		///<summary>UAnimSequenceBase *</summary>
		public const int AnimationSequence = 0x0098;

		///<summary>UCurveFloat *</summary>
		public const int AnimationCurve = 0x00A0;

		///<summary>FVector2D</summary>
		public const int CharLocationInterpSpeedInMap = 0x00A8;

		///<summary>FVector2D</summary>
		public const int CharLocationInterpSpeedOutMap = 0x00B0;

		///<summary>FVector2D</summary>
		public const int TimerProgressionByDistanceInMap = 0x00B8;

		///<summary>FVector2D</summary>
		public const int TimerProgressionByDistanceOutMap = 0x00C0;

		///<summary>float</summary>
		public const int TimerProgressionVTimerMax = 0x00C8;

		///<summary>float</summary>
		public const int VaultEndTimerNormal = 0x00CC;

		///<summary>float</summary>
		public const int VaultEndTimerFall = 0x00D0;

		///<summary>float</summary>
		public const int CharacterPostVaultVelocityScalar = 0x00D4;

		///<summary>float</summary>
		public const int AnimBlendInTime = 0x00D8;

		///<summary>float</summary>
		public const int AnimBlendOutTime = 0x00DC;

		///<summary>bool</summary>
		public const int bCanVaultWithWeapon = 0x00E0;

		///<summary>bool</summary>
		public const int bIsCancellable = 0x00E1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x00E2;

		///<summary>float</summary>
		public const int MinCancelVTimer = 0x00E4;

		///<summary>float</summary>
		public const int MaxCancelVTimer = 0x00E8;

		///<summary>float</summary>
		public const int TaskEndVTimer = 0x00EC;

	}

	public class ATslCharacter
	{
		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0810;

		///<summary>FTimerHandle</summary>
		public const int TimerHandle_Targeting_HoldADS = 0x0818;

		///<summary>bool</summary>
		public const int bShouldAiming = 0x0820;

		///<summary>bool</summary>
		public const int bPeekLeftToggled = 0x0821;

		///<summary>bool</summary>
		public const int bPeekRightToggled = 0x0822;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0823;

		///<summary>TWeakObjectPtr<ATslPlayerState></summary>
		public const int CurrentAttackerPlayerState = 0x0824;

		///<summary>TWeakObjectPtr<ATslPlayerState></summary>
		public const int LastAttackedPlayerState = 0x082C;

		///<summary>unsigned char[0x4C]</summary>
		public const int UnknownData01 = 0x0834;

		///<summary>FScriptMulticastDelegate</summary>
		public const int NoBagSpaceDelgate = 0x0880;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData02 = 0x0890;

		///<summary>AController *</summary>
		public const int LastPossessedController = 0x08E8;

		///<summary>TArray<UAkAudioBank * ></summary>
		public const int Banks = 0x08F0;

		///<summary>UBuffComponet *</summary>
		public const int BuffComponent = 0x0900;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData03 = 0x0908;

		///<summary>TEnumAsByte<ECastAnim></summary>
		public const int Remote_CastAnim = 0x0948;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0949;

		///<summary>ATslCharacter *</summary>
		public const int RevivingCharacter = 0x0950;

		///<summary>ATslPlayerState *</summary>
		public const int GroggyPlayerInstigator = 0x0958;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData05 = 0x0960;

		///<summary>float</summary>
		public const int BuffFinalSpreadFactor = 0x09D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x09DC;

		///<summary>AInventoryFacade *</summary>
		public const int InventoryFacade = 0x09E0;

		///<summary>AWeaponProcessor *</summary>
		public const int WeaponProcessor = 0x09E8;

		///<summary>unsigned char</summary>
		public const int CharacterState = 0x09F0;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData07 = 0x09F1;

		///<summary>UClass *</summary>
		public const int DropPackageType = 0x0A10;

		///<summary>UAkAudioEvent *</summary>
		public const int SoundClearAk = 0x0A18;

		///<summary>UAkAudioEvent *</summary>
		public const int RemoteVolumeControlOn = 0x0A20;

		///<summary>UAkAudioEvent *</summary>
		public const int RemoteVolumeControlOff = 0x0A28;

		///<summary>UCurveFloat *</summary>
		public const int CameraFovRatioCurve = 0x0A30;

		///<summary>float</summary>
		public const int HeavyFallVerticalVelocityThreshold = 0x0A38;

		///<summary>float</summary>
		public const int ExtremeFallVerticalVelocityThreshold = 0x0A3C;

		///<summary>float</summary>
		public const int ProneFallVerticalVelocityThreshold = 0x0A40;

		///<summary>float</summary>
		public const int HeavyFallMovementStopTime = 0x0A44;

		///<summary>float</summary>
		public const int ExtremeFallMovementStopTime = 0x0A48;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x0A4C;

		///<summary>float</summary>
		public const int Punch_Damage = 0x0A50;

		///<summary>float</summary>
		public const int PunchHeavy_Damage = 0x0A54;

		///<summary>UClass *</summary>
		public const int UnarmedDamageType = 0x0A58;

		///<summary>UClass *</summary>
		public const int ZombieDamageType = 0x0A60;

		///<summary>float</summary>
		public const int Punch_Distance = 0x0A68;

		///<summary>float</summary>
		public const int PunchHeavy_Distance = 0x0A6C;

		///<summary>float</summary>
		public const int Punch_Radius = 0x0A70;

		///<summary>float</summary>
		public const int PunchHeavy_Radius = 0x0A74;

		///<summary>FVector</summary>
		public const int Punch_InitialLocation = 0x0A78;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData09 = 0x0A84;

		///<summary>FVector</summary>
		public const int LeanLeftTraceOffset = 0x0A88;

		///<summary>FVector</summary>
		public const int LeanRightTraceOffset = 0x0A94;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData10 = 0x0AA0;

		///<summary>float</summary>
		public const int LeanOffset_Stand = 0x0AA8;

		///<summary>float</summary>
		public const int LeanOffset_Crouch = 0x0AAC;

		///<summary>float</summary>
		public const int LeanOffset_Prone = 0x0AB0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData11 = 0x0AB4;

		///<summary>float</summary>
		public const int Sprint_MaxSpeed = 0x0AC4;

		///<summary>float</summary>
		public const int Sprint_MinSpeed = 0x0AC8;

		///<summary>float</summary>
		public const int SprintingFOV = 0x0ACC;

		///<summary>float</summary>
		public const int MinimumBreathToHold = 0x0AD0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData12 = 0x0AD4;

		///<summary>FName</summary>
		public const int SwimPoint = 0x0AD8;

		///<summary>float</summary>
		public const int SwimableWaterDepth = 0x0AE0;

		///<summary>float</summary>
		public const int CrouchWaterDepth = 0x0AE4;

		///<summary>float</summary>
		public const int ProneWaterDepth = 0x0AE8;

		///<summary>float</summary>
		public const int WaterFloorDetectionLength = 0x0AEC;

		///<summary>float</summary>
		public const int SwimMaxControllerPitch = 0x0AF0;

		///<summary>float</summary>
		public const int UnderwaterSwimGapFromSurface = 0x0AF4;

		///<summary>UClass *</summary>
		public const int SwimTrailEffectClass = 0x0AF8;

		///<summary>ATslParticle *</summary>
		public const int SwimTrailEffect = 0x0B00;

		///<summary>FName</summary>
		public const int ParticleSocket_SwimIdleRipple = 0x0B08;

		///<summary>UClass *</summary>
		public const int SwimIdleRippleEffectClass = 0x0B10;

		///<summary>int</summary>
		public const int maxNumSwimIdleRippleEffect = 0x0B18;

		///<summary>float</summary>
		public const int SwimIdleRippleOffsetFromSurface = 0x0B1C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData13 = 0x0B20;

		///<summary>UCharacterBreathComponent *</summary>
		public const int BreathComponent = 0x0B30;

		///<summary>FName</summary>
		public const int BreathPoint = 0x0B38;

		///<summary>UClass *</summary>
		public const int UnderwaterChokeEffectClass = 0x0B40;

		///<summary>ATslParticle *</summary>
		public const int UnderwaterChokeEffect = 0x0B48;

		///<summary>float</summary>
		public const int IndoorCheckDistance = 0x0B50;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData14 = 0x0B54;

		///<summary>float</summary>
		public const int IndoorCheckHalfConeAngle = 0x0B58;

		///<summary>float</summary>
		public const int IndoorCheckSuccessRate = 0x0B5C;

		///<summary>int</summary>
		public const int IndoorCheckSamplingQueueSize = 0x0B60;

		///<summary>int</summary>
		public const int IndoorCheckAccuracyMultiplier = 0x0B64;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData15 = 0x0B68;

		///<summary>float</summary>
		public const int FootSoundObstructionCheckInterval = 0x0B78;

		///<summary>float</summary>
		public const int FootSoundObstructionCheckMaxDistance = 0x0B7C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData16 = 0x0B80;

		///<summary>FName</summary>
		public const int ParachuteAttachPoint = 0x0B88;

		///<summary>float</summary>
		public const int ReleasingParachuteAltitude = 0x0B90;

		///<summary>float</summary>
		public const int ForceReleasingParachuteAltitude = 0x0B94;

		///<summary>float</summary>
		public const int MinimumParachuteAltitude = 0x0B98;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData17 = 0x0B9C;

		///<summary>UClass *</summary>
		public const int ParachuteType = 0x0BA0;

		///<summary>bool</summary>
		public const int bParachuteLandingAssist = 0x0BA8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData18 = 0x0BA9;

		///<summary>UCastComponent *</summary>
		public const int CastComponent = 0x0BB0;

		///<summary>UStanceComponent *</summary>
		public const int StanceComponent = 0x0BB8;

		///<summary>UHackReporterComponent *</summary>
		public const int HackReporterComponent = 0x0BC0;

		///<summary>bool</summary>
		public const int bAcceptHitsWhileNotAlive = 0x0BC8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData19 = 0x0BC9;

		///<summary>float</summary>
		public const int SimulatedHit_Initial = 0x0BCC;

		///<summary>float</summary>
		public const int SimulatedHit_RecoveryPerSecond = 0x0BD0;

		///<summary>float</summary>
		public const int SimulatedHit_Value = 0x0BD4;

		///<summary>float</summary>
		public const int SimulatedHit_ImpulsePower = 0x0BD8;

		///<summary>float</summary>
		public const int SimlatedHit_PunchLightPower = 0x0BDC;

		///<summary>float</summary>
		public const int SimlatedHit_PunchHeavyPower = 0x0BE0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData20 = 0x0BE4;

		///<summary>UClass *</summary>
		public const int PunchImpactEffect = 0x0BE8;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData21 = 0x0BF0;

		///<summary>UCharacterWeaponAnimInfoComponent *</summary>
		public const int WeaponAnimInfoComponent = 0x0C18;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Primary = 0x0C20;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Secondary = 0x0C28;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Sidearm = 0x0C30;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Melee = 0x0C38;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Thrown = 0x0C40;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInDirt = 0x0C48;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInGrass = 0x0C50;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInRock = 0x0C58;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInSand = 0x0C60;

		///<summary>FName</summary>
		public const int ParticleSocketFootLeft = 0x0C68;

		///<summary>FName</summary>
		public const int ParticleSocketFootRight = 0x0C70;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInWater = 0x0C78;

		///<summary>ATslParticle *</summary>
		public const int FootStepEffect = 0x0C80;

		///<summary>ATeam *</summary>
		public const int Team = 0x0C88;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData22 = 0x0C90;

		///<summary>UTslViewTargetTempComponent *</summary>
		public const int ViewTargetTempComponent = 0x0CA8;

		///<summary>UTslCharacterValidateLocationComponent *</summary>
		public const int ValidateLocationComponent = 0x0CB0;

		///<summary>UTslThrowableTrajectoryViewComponent *</summary>
		public const int ThrowableTrajectoryViewComponent = 0x0CB8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData23 = 0x0CC0;

		///<summary>FName</summary>
		public const int HeadAttachPoint = 0x0CC8;

		///<summary>float</summary>
		public const int CameraHeadHideDistance = 0x0CD0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData24 = 0x0CD4;

		///<summary>FVector</summary>
		public const int CrouchedCameraMove = 0x0CE0;

		///<summary>FVector</summary>
		public const int PronedCameraMove = 0x0CEC;

		///<summary>FVector</summary>
		public const int GroggyCameraMove = 0x0CF8;

		///<summary>float</summary>
		public const int CrouchedCameraMoveSpeed = 0x0D04;

		///<summary>float</summary>
		public const int PronedCameraMoveSpeed = 0x0D08;

		///<summary>float</summary>
		public const int GroggyCameraMoveSpeed = 0x0D0C;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData25 = 0x0D10;

		///<summary>FTakeHitInfo</summary>
		public const int LastTakeHitInfo = 0x0D58;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData26 = 0x0D98;

		///<summary>float</summary>
		public const int TargetingSpeedModifier = 0x0D9C;

		///<summary>TEnumAsByte<ETargetingType></summary>
		public const int TargetingType = 0x0DA0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData27 = 0x0DA1;

		///<summary>float</summary>
		public const int Stand_RunningSpeedModifier = 0x0DA4;

		///<summary>float</summary>
		public const int Stand_SprintingSpeedModifier = 0x0DA8;

		///<summary>float</summary>
		public const int Stand_SprintingBigGunModifier = 0x0DAC;

		///<summary>float</summary>
		public const int Stand_SprintingRifleModifier = 0x0DB0;

		///<summary>float</summary>
		public const int Stand_SprintingSmallGunMOdifier = 0x0DB4;

		///<summary>float</summary>
		public const int Crouch_RunningSpeedModifier = 0x0DB8;

		///<summary>float</summary>
		public const int Crouch_SprintingSpeedModifier = 0x0DBC;

		///<summary>float</summary>
		public const int Prone_RunningSpeedModifier = 0x0DC0;

		///<summary>float</summary>
		public const int Prone_SprintingSpeedModifier = 0x0DC4;

		///<summary>float</summary>
		public const int ReviveCastingTime = 0x0DC8;

		///<summary>unsigned char:1</summary>
		public const int bWantsToRun = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bWantsToSprint = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bWantsToSprintingAuto = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bWantsToRollingLeft = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bWantsToRollingRight = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bIsPeekLeft = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bIsPeekRight = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int IgnoreRotation = 0x0DCC;

		///<summary>unsigned char:1</summary>
		public const int bIsGroggying = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int bIsThirdPerson = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int UnknownData28 = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int bIsReviving = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int bIsWeaponObstructed = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int bIsCoatEquipped = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int bIsZombie = 0x0DCD;

		///<summary>unsigned char:1</summary>
		public const int bIsThrowHigh = 0x0DCD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData29 = 0x0DCE;

		///<summary>bool</summary>
		public const int bOutSidePlayerArea = 0x0DD0;

		///<summary>bool</summary>
		public const int bUseRightShoulderAiming = 0x0DD1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData30 = 0x0DD2;

		///<summary>FRotator</summary>
		public const int GunDirectionSway = 0x0DD4;

		///<summary>FVector_NetQuantizeNormal</summary>
		public const int AimOffsets = 0x0DE0;

		///<summary>FVector_NetQuantizeNormal</summary>
		public const int LastAimOffsets = 0x0DEC;

		///<summary>float</summary>
		public const int AimoffsetsLastRepTime = 0x0DF8;

		///<summary>unsigned char[0x44]</summary>
		public const int UnknownData31 = 0x0DFC;

		///<summary>UCurveFloat *</summary>
		public const int Curve_JumpCamera = 0x0E40;

		///<summary>UCurveVector *</summary>
		public const int Curve_FPPCameraOffsetByFOV = 0x0E48;

		///<summary>UCurveFloat *</summary>
		public const int Curve_DBNOFadeOut = 0x0E50;

		///<summary>float</summary>
		public const int DBNOFadeOutLerpSpeed = 0x0E58;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData32 = 0x0E5C;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandWalk = 0x0E60;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandRun = 0x0E68;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandSprint = 0x0E70;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchWalk = 0x0E78;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchRun = 0x0E80;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchSprint = 0x0E88;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneWalk = 0x0E90;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneRun = 0x0E98;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneSprint = 0x0EA0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Swim = 0x0EA8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_UnderwaterSwim = 0x0EB0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandScope = 0x0EB8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchScope = 0x0EC0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneScope = 0x0EC8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandAim = 0x0ED0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchAim = 0x0ED8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneAim = 0x0EE0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_DBNO = 0x0EE8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_GroundAngle = 0x0EF0;

		///<summary>UCurveVector *</summary>
		public const int Curve_WeaponSway = 0x0EF8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_TurningLerp = 0x0F00;

		///<summary>UCurveFloat *</summary>
		public const int Curve_TurningLerpLocomotion = 0x0F08;

		///<summary>float</summary>
		public const int DirectionalSpeedModifier = 0x0F10;

		///<summary>float</summary>
		public const int PointDamageForceMultiplier = 0x0F14;

		///<summary>float</summary>
		public const int PointDamageForce_MapMin = 0x0F18;

		///<summary>float</summary>
		public const int PointDamageForce_MapMax = 0x0F1C;

		///<summary>float</summary>
		public const int RadialDamageForceMultiplier = 0x0F20;

		///<summary>TEnumAsByte<ERadialImpulseFalloff></summary>
		public const int RadialDamageFalloffType = 0x0F24;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData33 = 0x0F25;

		///<summary>UAnimMontage *</summary>
		public const int RollLeftAnim = 0x0F28;

		///<summary>UAnimMontage *</summary>
		public const int RollRightAnim = 0x0F30;

		///<summary>FCharacterAnim</summary>
		public const int CharacterAnim = 0x0F38;

		///<summary>AController *</summary>
		public const int NetOwnerController = 0x0F48;

		///<summary>float</summary>
		public const int LeanAlphaSpeed = 0x0F50;

		///<summary>float</summary>
		public const int TurnSpeedHip = 0x0F54;

		///<summary>float</summary>
		public const int TurnSpeedAimed = 0x0F58;

		///<summary>float</summary>
		public const int TurnSpeedOverLimit = 0x0F5C;

		///<summary>float</summary>
		public const int MinTurnAngleHip = 0x0F60;

		///<summary>float</summary>
		public const int MinTurnAngleAim = 0x0F64;

		///<summary>float</summary>
		public const int TurnLinearEndThreshold = 0x0F68;

		///<summary>bool</summary>
		public const int bNonLinearTurn = 0x0F6C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData34 = 0x0F6D;

		///<summary>float</summary>
		public const int TurnNonLinearEndThreshold = 0x0F70;

		///<summary>float</summary>
		public const int TurnNonLinearInterpSpeed = 0x0F74;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedLocomotion = 0x0F78;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedLocomotionSprint = 0x0F7C;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedLocomotionProne = 0x0F80;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedStationary = 0x0F84;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData35 = 0x0F88;

		///<summary>FName</summary>
		public const int FPPCameraBoneName = 0x0FA0;

		///<summary>FName</summary>
		public const int TPPCameraBoneName = 0x0FA8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData36 = 0x0FB0;

		///<summary>float</summary>
		public const int AimStateDefaultTime = 0x0FBC;

		///<summary>float</summary>
		public const int AimStateReturnTime = 0x0FC0;

		///<summary>float</summary>
		public const int AimStateDrawTime = 0x0FC4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData37 = 0x0FC8;

		///<summary>bool</summary>
		public const int bAimStateActive = 0x0FD0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData38 = 0x0FD1;

		///<summary>float</summary>
		public const int CanGroggyDamageTime = 0x0FD4;

		///<summary>FText</summary>
		public const int GroggyStartText = 0x0FD8;

		///<summary>FText</summary>
		public const int GroggyCancelText = 0x0FF0;

		///<summary>FText</summary>
		public const int GroggyFinishText = 0x1008;

		///<summary>float</summary>
		public const int GamepadRunningValue = 0x1020;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData39 = 0x1024;

		///<summary>FRotator</summary>
		public const int BlendTargetViewRotation = 0x1030;

		///<summary>FVector2D</summary>
		public const int DesiredDirection = 0x103C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData40 = 0x1044;

		///<summary>UClass *</summary>
		public const int InvulnerablilityBuff = 0x1048;

		///<summary>bool</summary>
		public const int bInvulnerablilityEffectVisible = 0x1050;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData41 = 0x1051;

		///<summary>TArray<UClass * ></summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x1058;

		///<summary>TArray<FZombieCustomizationData></summary>
		public const int ZombieCustomizationData = 0x1068;

		///<summary>bool</summary>
		public const int bIsHoldingBreath = 0x1078;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData42 = 0x1079;

		///<summary>float</summary>
		public const int Health = 0x107C;

		///<summary>float</summary>
		public const int HealthMax = 0x1080;

		///<summary>float</summary>
		public const int GroggyHealth = 0x1084;

		///<summary>float</summary>
		public const int GroggyHealthMax = 0x1088;

		///<summary>float</summary>
		public const int DecreaseGroggyHealthPerSecond = 0x108C;

		///<summary>float</summary>
		public const int GroggyDamageWeight = 0x1090;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData43 = 0x1094;

		///<summary>UClass *</summary>
		public const int GroggyDamageType = 0x1098;

		///<summary>float</summary>
		public const int HealthByRevive = 0x10A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData44 = 0x10A4;

		///<summary>UAkAudioEvent *</summary>
		public const int GroggyToDieAkEvent = 0x10A8;

		///<summary>float</summary>
		public const int BoostGauge = 0x10B0;

		///<summary>float</summary>
		public const int BoostGaugeMax = 0x10B4;

		///<summary>float</summary>
		public const int DecreaseTimerSecond = 0x10B8;

		///<summary>float</summary>
		public const int DecreaseBoostGaugeByTime = 0x10BC;

		///<summary>TArray<FBuffWithBoostGauge></summary>
		public const int BuffWithBoostGauge = 0x10C0;

		///<summary>UClass *</summary>
		public const int MedKitClass = 0x10D0;

		///<summary>UClass *</summary>
		public const int FirstAidClass = 0x10D8;

		///<summary>UClass *</summary>
		public const int BandageClass = 0x10E0;

		///<summary>UClass *</summary>
		public const int AdrenalineClass = 0x10E8;

		///<summary>UClass *</summary>
		public const int PainKillerClass = 0x10F0;

		///<summary>UClass *</summary>
		public const int EnergyDrinkClass = 0x10F8;

		///<summary>TArray<UClass * ></summary>
		public const int BoostItemClasses = 0x1100;

		///<summary>TArray<UClass * ></summary>
		public const int HealItemClasses = 0x1110;

		///<summary>UClass *</summary>
		public const int GrenadeClass = 0x1120;

		///<summary>UClass *</summary>
		public const int MolotovClass = 0x1128;

		///<summary>UClass *</summary>
		public const int SmokeBombClass = 0x1130;

		///<summary>UClass *</summary>
		public const int FlashBangClass = 0x1138;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData45 = 0x1140;

		///<summary>TWeakObjectPtr<ATslPlayerState></summary>
		public const int LaunchInstigator = 0x1144;

		///<summary>TWeakObjectPtr<AActor></summary>
		public const int LaunchCauser = 0x114C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData46 = 0x1154;

		///<summary>double</summary>
		public const int LastLaunchTime = 0x1158;

		///<summary>APlayerState *</summary>
		public const int AuthorizedPlayerState = 0x1160;

		///<summary>TEnumAsByte<EEquipableItemSoundType></summary>
		public const int ShoesSoundType = 0x1168;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData47 = 0x1169;

		///<summary>UInteractorComponent *</summary>
		public const int InteractorComponent = 0x1170;

		///<summary>UInteractionComponent *</summary>
		public const int InteractionComponent = 0x1178;

		///<summary>UVehicleRiderComponent *</summary>
		public const int VehicleRiderComponent = 0x1180;

		///<summary>UClass *</summary>
		public const int OutSidePlayerAreaEffectClass = 0x1188;

		///<summary>ATslPostProcessEffect *</summary>
		public const int OutSidePlayerAreaEffect = 0x1190;

		///<summary>UClass *</summary>
		public const int DBNOEffectClass = 0x1198;

		///<summary>ATslPostProcessEffect *</summary>
		public const int DBNOEffect = 0x11A0;

		///<summary>unsigned char[0x1E0]</summary>
		public const int UnknownData48 = 0x11A8;

		///<summary>USkeletalMeshComponent *</summary>
		public const int ShadowMesh = 0x1388;

		///<summary>float</summary>
		public const int TargetingFOV = 0x1390;

		///<summary>float</summary>
		public const int AimingDelay = 0x1394;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData49 = 0x1398;

		///<summary>float</summary>
		public const int ScopingDelay = 0x139C;

		///<summary>float</summary>
		public const int AttackStateOffDelayTime = 0x13A0;

		///<summary>float</summary>
		public const int HitStateOffDelayTime = 0x13A4;

		///<summary>float</summary>
		public const int HitMePlayerStateOffDelayTime = 0x13A8;

		///<summary>unsigned char[0x34]</summary>
		public const int UnknownData50 = 0x13AC;

		///<summary>float</summary>
		public const int DamageHeadScale = 0x13E0;

		///<summary>float</summary>
		public const int DamageArmScale = 0x13E4;

		///<summary>float</summary>
		public const int DamageStomachScale = 0x13E8;

		///<summary>float</summary>
		public const int DamageLegScale = 0x13EC;

		///<summary>TArray<FName></summary>
		public const int HeadBoneNames = 0x13F0;

		///<summary>TArray<FName></summary>
		public const int ArmBoneNames = 0x1400;

		///<summary>TArray<FName></summary>
		public const int TorsoBoneNames = 0x1410;

		///<summary>TArray<FName></summary>
		public const int StomachBoneNames = 0x1420;

		///<summary>TArray<FName></summary>
		public const int LegBoneNames = 0x1430;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData51 = 0x1440;

		///<summary>float</summary>
		public const int FallDamageFactor = 0x1444;

		///<summary>float</summary>
		public const int FallDamageVelocityMin = 0x1448;

		///<summary>bool</summary>
		public const int bIsActiveRagdollActive = 0x144C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData52 = 0x144D;

		///<summary>float</summary>
		public const int CorpseLifeSpan = 0x1450;

		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData53 = 0x1454;

		///<summary>FVector</summary>
		public const int JumpStartLocation_CP = 0x1480;

		///<summary>FVector</summary>
		public const int LandPredictedLocation_CP = 0x148C;

		///<summary>float</summary>
		public const int FallHeight_CP = 0x1498;

		///<summary>bool</summary>
		public const int bIsVaulting_CP = 0x149C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData54 = 0x149D;

		///<summary>float</summary>
		public const int VaultTimer_CP = 0x14A0;

		///<summary>FVector</summary>
		public const int VaultEndVelocity_CP = 0x14A4;

		///<summary>FVector</summary>
		public const int VaultLastLocation_CP = 0x14B0;

		///<summary>bool</summary>
		public const int bIsClimbing_CP = 0x14BC;

		///<summary>bool</summary>
		public const int bEndVaultToFall_CP = 0x14BD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData55 = 0x14BE;

		///<summary>FVector</summary>
		public const int VaultEndVelocityVectorMutliplier = 0x14C0;

		///<summary>float</summary>
		public const int VaultEndVelocityVectorClamp = 0x14CC;

		///<summary>ATslVaultingHelper *</summary>
		public const int VaultingHelperRef = 0x14D0;

		///<summary>bool</summary>
		public const int bIsVaultingSystemEnabled = 0x14D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData56 = 0x14D9;

		///<summary>float</summary>
		public const int VaultingDirection_CP = 0x14DC;

		///<summary>UVaultingData *</summary>
		public const int CurrentVaultData_CP = 0x14E0;

		///<summary>bool</summary>
		public const int bServerFinishedVault = 0x14E8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData57 = 0x14E9;

		///<summary>float</summary>
		public const int JumpDelay = 0x14EC;

		///<summary>float</summary>
		public const int JumpLastTimer = 0x14F0;

		///<summary>bool</summary>
		public const int bWantsToVault = 0x14F4;

		///<summary>bool</summary>
		public const int bWantsToCancelVault = 0x14F5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData58 = 0x14F6;

		///<summary>float</summary>
		public const int VaultProbeLoopTime = 0x14F8;

		///<summary>float</summary>
		public const int TO_CulledMovementTickrate = 0x14FC;

		///<summary>float</summary>
		public const int TO_CulledActorTickInterval = 0x1500;

		///<summary>float</summary>
		public const int TO_MinimumDistance = 0x1504;

		///<summary>bool</summary>
		public const int bRunTickOptimization = 0x1508;

		///<summary>bool</summary>
		public const int bRunTickOptimization_Anim = 0x1509;

		///<summary>bool</summary>
		public const int bRunTickOptimization_Movement = 0x150A;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData59 = 0x150B;

		///<summary>float</summary>
		public const int TO_RenderedTolerance = 0x150C;

		///<summary>bool</summary>
		public const int bTickOptimization_Move_Active = 0x1510;

		///<summary>bool</summary>
		public const int bTickOptimization_Anim_Active = 0x1511;

		///<summary>bool</summary>
		public const int bTickOptimization_Actor_Active = 0x1512;

		///<summary>unsigned char[0xD]</summary>
		public const int UnknownData60 = 0x1513;

	}

	public class UObserverTagWidget
	{
		///<summary>ATslCharacter *</summary>
		public const int Character = 0x0240;

		///<summary>float</summary>
		public const int OffsetZ = 0x0248;

		///<summary>float</summary>
		public const int Distance = 0x024C;

	}

	public class UTslDamageType
	{
		///<summary>TEnumAsByte<EDamageTypeCategory></summary>
		public const int DamageTypeCategory = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0041;

		///<summary>FCanvasIcon</summary>
		public const int KillIcon = 0x0048;

		///<summary>UForceFeedbackEffect *</summary>
		public const int HitForceFeedback = 0x0060;

		///<summary>UForceFeedbackEffect *</summary>
		public const int KilledForceFeedback = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bFallDamage = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0071;

		///<summary>TArray<FDamageRatioInfo></summary>
		public const int DamageRatioInfos = 0x0078;

		///<summary>bool</summary>
		public const int HitReaction = 0x0088;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0089;

	}

	public class ATslHUD
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPossessPawnChange = 0x0510;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDisplaySystemMessage = 0x0520;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDisplayKilledMessage = 0x0530;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKillCountChanged = 0x0540;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHit = 0x0550;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTeamPlayerJoin = 0x0560;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTeamPlayerRemove = 0x0570;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyStartBuff = 0x0580;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHealAmount = 0x0590;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyRestrictingPlayArea = 0x05A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyNextGasIn = 0x05B0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyDisplayMessage = 0x05C0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyWeaponChange = 0x05D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyWeaponUnarm = 0x05E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHeal = 0x05F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyDropSlotOnOtherContainer = 0x0600;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyBlockingWidgetOpened = 0x0610;

		///<summary>int</summary>
		public const int BluezoneState = 0x0620;

		///<summary>bool</summary>
		public const int bGpsReset = 0x0624;

		///<summary>bool</summary>
		public const int bBluezoneReset = 0x0625;

		///<summary>bool</summary>
		public const int bPlayzoneReset = 0x0626;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0627;

		///<summary>float</summary>
		public const int GpsResetTimeCheck = 0x0628;

		///<summary>bool</summary>
		public const int bUseHighlight = 0x062C;

		///<summary>unsigned char[0x33]</summary>
		public const int UnknownData01 = 0x062D;

		///<summary>FCanvasIcon</summary>
		public const int TimePlaceBg = 0x0660;

		///<summary>FCanvasIcon</summary>
		public const int PrimaryWeapBg = 0x0678;

		///<summary>FCanvasIcon</summary>
		public const int SecondaryWeapBg = 0x0690;

		///<summary>FCanvasIcon[0x5]</summary>
		public const int Crosshair = 0x06A8;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData02 = 0x0720;

		///<summary>UTexture2D *</summary>
		public const int HitNotifyTexture = 0x0798;

		///<summary>UTexture2D *</summary>
		public const int HUDMainTexture = 0x07A0;

		///<summary>UTexture2D *</summary>
		public const int HUDAssets02Texture = 0x07A8;

		///<summary>UTexture2D *</summary>
		public const int LowHealthOverlayTexture = 0x07B0;

		///<summary>UFont *</summary>
		public const int BigFont = 0x07B8;

		///<summary>UFont *</summary>
		public const int NormalFont = 0x07C0;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData03 = 0x07C8;

		///<summary>UTslSceneCaptureWorld *</summary>
		public const int SceneCaptureWorld = 0x0828;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x0830;

		///<summary>FVector</summary>
		public const int NextPlayzonePosition = 0x0840;

		///<summary>float</summary>
		public const int NextPlayzoneRadius = 0x084C;

		///<summary>FVector</summary>
		public const int CurrentPlayzonePosition = 0x0850;

		///<summary>float</summary>
		public const int CurrentPlayzoneRadius = 0x085C;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData05 = 0x0860;

		///<summary>FString</summary>
		public const int SceneCapturePackageName = 0x08A8;

		///<summary>UHighlightSession *</summary>
		public const int HighlightSession = 0x08B8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData06 = 0x08C0;

	}

	public class UTslPawnInputBindingComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnOwnerPossessed = 0x00F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnOwnerUnPossessed = 0x0108;

	}

	public class AParachuteVehicle
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0400;

		///<summary>FScriptDelegate</summary>
		public const int OnRelease = 0x0408;

		///<summary>FScriptDelegate</summary>
		public const int OnLand = 0x0418;

		///<summary>UAkAudioEvent *</summary>
		public const int ReleaseSound_Local = 0x0428;

		///<summary>UAkAudioEvent *</summary>
		public const int ReleaseSound_Remote = 0x0430;

		///<summary>UAkAudioEvent *</summary>
		public const int LandSound_Local = 0x0438;

		///<summary>UAkAudioEvent *</summary>
		public const int LandSound_Remote = 0x0440;

		///<summary>UAkAudioEvent *</summary>
		public const int FallingStartSound_Local = 0x0448;

		///<summary>UAkAudioEvent *</summary>
		public const int FallingStartSound_Remote = 0x0450;

		///<summary>UAkComponent *</summary>
		public const int AkSoundCom = 0x0458;

		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0460;

		///<summary>USkeletalMeshComponent *</summary>
		public const int MeshComponent = 0x0468;

		///<summary>UParachuteVehicleMovement *</summary>
		public const int ParachuteMovementComponent = 0x0470;

		///<summary>UFreeFallMovement *</summary>
		public const int FreeFallMovementComponent = 0x0478;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x0480;

		///<summary>UDoublePhaseInteractionComponent *</summary>
		public const int InteractionComponent = 0x0488;

		///<summary>TWeakObjectPtr<ATslCharacter></summary>
		public const int LastDriver = 0x0490;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0498;

		///<summary>FName</summary>
		public const int FreeFallFirstPersonCameraName = 0x04A0;

		///<summary>FName</summary>
		public const int FreeFallThirdPersonCameraName = 0x04A8;

		///<summary>float</summary>
		public const int FreeFallCameraPitchMin = 0x04B0;

		///<summary>float</summary>
		public const int FreeFallCameraPitchMax = 0x04B4;

		///<summary>float</summary>
		public const int ReleasingAltitude = 0x04B8;

		///<summary>float</summary>
		public const int ForceReleasingAltitude = 0x04BC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x04C0;

		///<summary>float</summary>
		public const int SweepMoveHeight = 0x04C4;

		///<summary>float</summary>
		public const int LandingHeight = 0x04C8;

		///<summary>float</summary>
		public const int LandingDuration = 0x04CC;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x04D0;

		///<summary>UClass *</summary>
		public const int LandingBuff = 0x04D8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x04E0;

		///<summary>float</summary>
		public const int StuckCheckDistance = 0x04EC;

		///<summary>float</summary>
		public const int StuckCheckDuration = 0x04F0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData05 = 0x04F4;

		///<summary>unsigned char:1</summary>
		public const int UnknownData06 = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int ForwardInputRepApplied = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int ForwardInputRepIsForward = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int RightInputRepApplied = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int RightInputRepIsRight = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bIsReleased = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bIsDriven = 0x0500;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0501;

		///<summary>FRotator</summary>
		public const int InitialRotation = 0x0504;

		///<summary>FVector</summary>
		public const int InitialVelocity = 0x0510;

		///<summary>FVector</summary>
		public const int RideSocketOffset = 0x051C;

		///<summary>FVector</summary>
		public const int LeaveSocketOffset = 0x0528;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x0534;

	}

	public class AReplicationTrigger
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>TArray<AActor * ></summary>
		public const int TargetReplicatedActors = 0x03A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03B8;

		///<summary>int</summary>
		public const int ReplicationGroupCount = 0x03BC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x03C0;

		///<summary>float</summary>
		public const int ReplicationGroupIntervalSeconds = 0x03C4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x03C8;

	}

	public class AReplicationTriggerManager
	{
		///<summary>TArray<UClass * ></summary>
		public const int TargetReplicatedActorClasses = 0x03A0;

		///<summary>float</summary>
		public const int TriggerRadius = 0x03B0;

		///<summary>float</summary>
		public const int TriggerInterval = 0x03B4;

		///<summary>TArray<AReplicationTrigger * ></summary>
		public const int Triggers = 0x03B8;

	}

	public class URewardData
	{
		///<summary>float</summary>
		public const int DefaultScoreMultiplierByDamage = 0x0028;

		///<summary>float</summary>
		public const int DefaultScoreMultiplierByKill = 0x002C;

		///<summary>TArray<float></summary>
		public const int ScoreByReverseRanking = 0x0030;

		///<summary>TArray<float></summary>
		public const int ScoreMultiplierByRanking = 0x0040;

	}

	public class USceneInteractionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0300;

		///<summary>float</summary>
		public const int MaxInteractableDistance = 0x0310;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0314;

		///<summary>FText</summary>
		public const int InteractionVerb = 0x0318;

		///<summary>FText</summary>
		public const int InteractiveObjectName = 0x0330;

		///<summary>bool</summary>
		public const int bUseTraceCheck = 0x0348;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0349;

		///<summary>FCastConfig</summary>
		public const int CastConfig = 0x0350;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0380;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInteractBy = 0x0388;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ClientOnInteractBy = 0x0398;

		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData04 = 0x03A8;

	}

	public class UDoorInteractionComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>TEnumAsByte<EDoorState></summary>
		public const int DoorState = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bReverseRotation = 0x0419;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreParentValidityCheck = 0x0419;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x041A;

		///<summary>FVector</summary>
		public const int SoundOffset = 0x041C;

		///<summary>UDoorDataAsset *</summary>
		public const int DoorDataAsset = 0x0428;

		///<summary>unsigned char[0x1C0]</summary>
		public const int UnknownData02 = 0x0430;

		///<summary>UAkComponent *</summary>
		public const int AkAudioComponent = 0x05F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x05F8;

	}

	public class UDroppedItemInteractionComponent
	{
		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>UItem *</summary>
		public const int Item = 0x0448;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0450;

		///<summary>UAsyncStaticMeshComponent *</summary>
		public const int StaticMeshComponent = 0x0458;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0460;

	}

	public class UVehicleSeatInteractionComponent
	{
		///<summary>ATslCharacter *</summary>
		public const int Rider = 0x0410;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0418;

		///<summary>int</summary>
		public const int SeatIndex = 0x0424;

		///<summary>TEnumAsByte<ERiderType></summary>
		public const int RiderType = 0x0428;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0429;

		///<summary>FName</summary>
		public const int LeaveSocketName = 0x0430;

		///<summary>float</summary>
		public const int ViewPitchMin = 0x0438;

		///<summary>float</summary>
		public const int ViewPitchMax = 0x043C;

		///<summary>float</summary>
		public const int ViewYawMin = 0x0440;

		///<summary>float</summary>
		public const int ViewYawMax = 0x0444;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMax = 0x0448;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMin = 0x0450;

		///<summary>FName</summary>
		public const int FirstPersonCameraName = 0x0458;

		///<summary>FName</summary>
		public const int ThirdPersonCameraName = 0x0460;

		///<summary>TEnumAsByte<EVehicleAnimType></summary>
		public const int SeatAnimationType = 0x0468;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0469;

		///<summary>UBlendSpaceBase *</summary>
		public const int SeatBlendspaceAiming = 0x0470;

		///<summary>UBlendSpaceBase *</summary>
		public const int SeatBlendspaceFPPAiming = 0x0478;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle = 0x0480;

		///<summary>UAimOffsetBlendSpace *</summary>
		public const int SeatIdleAO = 0x0488;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionOutBlendspace = 0x0490;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionInBlendspace = 0x0498;

		///<summary>bool</summary>
		public const int bRestricWeaponUse = 0x04A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x04A1;

		///<summary>TArray<TEnumAsByte<EWeaponClass>></summary>
		public const int AllowedWeaponClasses = 0x04A8;

		///<summary>bool</summary>
		public const int bCanOnlyFireWhileAiming = 0x04B8;

		///<summary>bool</summary>
		public const int bUseEntryVelocityRestriction = 0x04B9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x04BA;

		///<summary>float</summary>
		public const int MaxVelocityForEntry = 0x04BC;

		///<summary>float</summary>
		public const int InteractionBlockDuration = 0x04C0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData05 = 0x04C4;

	}

	public class USimpleInterpolationMovement
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0180;

		///<summary>float</summary>
		public const int LocationInterpTime = 0x0198;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData01 = 0x019C;

		///<summary>float</summary>
		public const int RotationInterpTime = 0x01D4;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData02 = 0x01D8;

		///<summary>bool</summary>
		public const int bUseOnlyYawRotation = 0x0210;

		///<summary>bool</summary>
		public const int bUseSweepMove = 0x0211;

		///<summary>bool</summary>
		public const int bUseSafeInterpolation = 0x0212;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData03 = 0x0213;

		///<summary>float</summary>
		public const int ForceMoveTime = 0x0214;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0218;

	}

	public class UFreeFallMovement
	{
		///<summary>float</summary>
		public const int MinPitch = 0x0220;

		///<summary>float</summary>
		public const int MaxPitch = 0x0224;

		///<summary>float</summary>
		public const int MaxLateralSpeed = 0x0228;

		///<summary>float</summary>
		public const int LateralAcceleration = 0x022C;

		///<summary>float</summary>
		public const int LateralDeceleration = 0x0230;

		///<summary>float</summary>
		public const int LateralBrakeDeceleration = 0x0234;

		///<summary>float</summary>
		public const int VerticalAcceleration = 0x0238;

		///<summary>float</summary>
		public const int VerticalDeceleration = 0x023C;

		///<summary>float</summary>
		public const int TerminalSpeed = 0x0240;

		///<summary>float</summary>
		public const int MinAdditiveTerminalSpeed = 0x0244;

		///<summary>float</summary>
		public const int MaxAdditiveTerminalSpeed = 0x0248;

		///<summary>float</summary>
		public const int RotationYawRate = 0x024C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0250;

		///<summary>float</summary>
		public const int InputUpdateTime = 0x0260;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0264;

	}

	public class UParachuteVehicleMovement
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0220;

		///<summary>float</summary>
		public const int MaxSpeed = 0x0224;

		///<summary>float</summary>
		public const int Acceleration = 0x0228;

		///<summary>float</summary>
		public const int Deceleration = 0x022C;

		///<summary>float</summary>
		public const int MaxRotationYawRate = 0x0230;

		///<summary>float</summary>
		public const int RotationYawAcceleration = 0x0234;

		///<summary>float</summary>
		public const int RotationYawDeceleration = 0x0238;

		///<summary>float</summary>
		public const int TerminalVelocity = 0x023C;

		///<summary>float</summary>
		public const int DecreaseTerminalVelocity = 0x0240;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0244;

		///<summary>float</summary>
		public const int RotationYawReplicated = 0x024C;

		///<summary>float</summary>
		public const int RotationPitchReplicated = 0x0250;

		///<summary>float</summary>
		public const int InputUpdateTime = 0x0254;

		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData02 = 0x0258;

		///<summary>float</summary>
		public const int ParachuteDeployCoefficient = 0x0284;

		///<summary>float</summary>
		public const int YawSpeed = 0x0288;

		///<summary>float</summary>
		public const int MaxForwardPitch = 0x028C;

		///<summary>float</summary>
		public const int MaxBackwardPitch = 0x0290;

		///<summary>float</summary>
		public const int ForceForwardScale = 0x0294;

		///<summary>float</summary>
		public const int ForceForwardStaticSpeed = 0x0298;

		///<summary>float</summary>
		public const int VelocityLERPSpeedMin = 0x029C;

		///<summary>float</summary>
		public const int VelocityLERPSpeedMax = 0x02A0;

		///<summary>float</summary>
		public const int VelocityLERPValueMin = 0x02A4;

		///<summary>float</summary>
		public const int VelocityLERPValueMax = 0x02A8;

		///<summary>float</summary>
		public const int DampingPitchMin = 0x02AC;

		///<summary>float</summary>
		public const int DampingPitchMax = 0x02B0;

		///<summary>float</summary>
		public const int DampingValueMin = 0x02B4;

		///<summary>float</summary>
		public const int DampingValueMax = 0x02B8;

		///<summary>float</summary>
		public const int ForceDownAngleMin = 0x02BC;

		///<summary>float</summary>
		public const int ForceDownAngleMax = 0x02C0;

		///<summary>float</summary>
		public const int ForceGravityMax = 0x02C4;

		///<summary>float</summary>
		public const int ForceGravitySpeedMin = 0x02C8;

		///<summary>float</summary>
		public const int ForceGravitySpeedMax = 0x02CC;

		///<summary>float</summary>
		public const int ForceGravityValueMin = 0x02D0;

		///<summary>float</summary>
		public const int ForceGravityValueMax = 0x02D4;

		///<summary>float</summary>
		public const int RollSpeedMin = 0x02D8;

		///<summary>float</summary>
		public const int RollSpeedMax = 0x02DC;

		///<summary>float</summary>
		public const int RollAngleMin = 0x02E0;

		///<summary>float</summary>
		public const int RollAngleMax = 0x02E4;

		///<summary>float</summary>
		public const int RollInterpSpeed = 0x02E8;

		///<summary>float</summary>
		public const int FinalVelocitySpeedMin = 0x02EC;

		///<summary>float</summary>
		public const int FinalVelocitySpeedMax = 0x02F0;

		///<summary>float</summary>
		public const int FinalVelocityDampingMin = 0x02F4;

		///<summary>float</summary>
		public const int FinalVelocityDampingMax = 0x02F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x02FC;

		///<summary>float</summary>
		public const int TraceSphereRadius = 0x0300;

		///<summary>FVector</summary>
		public const int TraceSphereOffset = 0x0304;

		///<summary>float</summary>
		public const int GroundTraceStart = 0x0310;

		///<summary>float</summary>
		public const int GroundTraceEnd = 0x0314;

		///<summary>float</summary>
		public const int GroundTraceDampingMin = 0x0318;

		///<summary>float</summary>
		public const int GroundTraceDampingMax = 0x031C;

	}

	public class UTslAircraftVehicleMovement
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0220;

	}

	public class UStanceComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00F8;

		///<summary>FStanceTransitionData</summary>
		public const int StanceTransitionData = 0x0100;

		///<summary>TEnumAsByte<EStanceMode></summary>
		public const int CurrentStance = 0x0160;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x0161;

	}

	public class ATslPlayerStart
	{
		///<summary>TEnumAsByte<EMatchStartType></summary>
		public const int MatchStartType = 0x03D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03D1;

		///<summary>float</summary>
		public const int StartRadius = 0x03D4;

		///<summary>bool</summary>
		public const int bRandomRotation = 0x03D8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03D9;

		///<summary>TArray<AStartActivationVolume * ></summary>
		public const int ActivationVolumes = 0x03E0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x03F0;

	}

	public class AStartActivationVolume
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03D8;

	}

	public class AInventoryFacade
	{
		///<summary>TArray<TEnumAsByte<EEquipSlotID>></summary>
		public const int AutoSwapEquipSlotID = 0x03A8;

		///<summary>AInventory *</summary>
		public const int Inventory = 0x03B8;

		///<summary>AEquipment *</summary>
		public const int Equipment = 0x03C0;

	}

	public class AEquipment
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEquipmentUpdated = 0x03D8;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x03E8;

		///<summary>TArray<UEquipableItem * ></summary>
		public const int Items = 0x0418;

	}

	public class AInventory
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInventoryUpdated = 0x03D8;

		///<summary>TArray<UItem * ></summary>
		public const int Items = 0x03E8;

		///<summary>float</summary>
		public const int MaxSpace = 0x03F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03FC;

	}

	public class AItemExplorerProxy
	{
		///<summary>FScriptDelegate</summary>
		public const int OnChangeItemExplorerProxy = 0x0408;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0418;

	}

	public class ACarePackageItem
	{
		///<summary>UClass *</summary>
		public const int ParachuteClass = 0x0500;

		///<summary>UClass *</summary>
		public const int SmokeFxClass = 0x0508;

		///<summary>UClass *</summary>
		public const int SmokeAirFxClass = 0x0510;

		///<summary>UClass *</summary>
		public const int LightFxClass = 0x0518;

		///<summary>float</summary>
		public const int SmokeTime = 0x0520;

		///<summary>float</summary>
		public const int LimitFallSpeed = 0x0524;

		///<summary>FName</summary>
		public const int SmokeSocket = 0x0528;

		///<summary>FName</summary>
		public const int SmokeAirSocket = 0x0530;

		///<summary>FName</summary>
		public const int LightSocket = 0x0538;

		///<summary>FName</summary>
		public const int ParachuteSocket = 0x0540;

		///<summary>UAkAudioEvent *</summary>
		public const int LandSoundAk = 0x0548;

		///<summary>bool</summary>
		public const int bIsFalling = 0x0550;

		///<summary>bool</summary>
		public const int bIsPickupedItem = 0x0551;

		///<summary>bool</summary>
		public const int bIsHideIconOnMap = 0x0552;

		///<summary>bool</summary>
		public const int bIsTranslucentIconOnMap = 0x0553;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0554;

		///<summary>ATslParticle *</summary>
		public const int SmokeFx = 0x0558;

		///<summary>ATslParticle *</summary>
		public const int SmokeAirFx = 0x0560;

		///<summary>ATslParticle *</summary>
		public const int LightFx = 0x0568;

		///<summary>AActor *</summary>
		public const int Parachute = 0x0570;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0578;

		///<summary>USimpleInterpolationMovement *</summary>
		public const int MovementComponent = 0x0580;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0588;

		///<summary>UAkComponent *</summary>
		public const int AkComponent = 0x0590;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x0598;

	}

	public class AFloorSnapItemPackage
	{
		///<summary>float</summary>
		public const int RayLength = 0x0500;

		///<summary>bool</summary>
		public const int bUseWaterSurface = 0x0504;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0505;

		///<summary>float</summary>
		public const int WaterSurfaceThreshold = 0x0508;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x050C;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0510;

	}

	public class ANearbyInteractiveItemExplorer
	{
		///<summary>TArray<TWeakObjectPtr<UObject>></summary>
		public const int ExplorableItems = 0x0408;

	}

	public class UThingSpawnProcessor
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCombinedThingSpawnProcessor
	{
		///<summary>TArray<UClass * ></summary>
		public const int SubProcessorClasses = 0x0038;

		///<summary>TArray<USubThingSpawnProcessor * ></summary>
		public const int SubProcessors = 0x0048;

	}

	public class UPackageSubThingSpawnProcessor
	{
		///<summary>UDataTable *</summary>
		public const int RawItemSpawnDataTable = 0x0028;

		///<summary>UDataTable *</summary>
		public const int RawItemSpawnTogetherDataTable = 0x0030;

		///<summary>TArray<FPackageSpotGroupProperty></summary>
		public const int RawSpotGroupProperties = 0x0038;

		///<summary>unsigned char[0x3B0]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UVehicleSubThingSpawnProcessor
	{
		///<summary>TArray<FVehicleSpotGroupProperty></summary>
		public const int RawSpotGroupProperties = 0x0028;

		///<summary>UDataTable *</summary>
		public const int RawVehicleSpawnDataTable = 0x0038;

		///<summary>float</summary>
		public const int SpawnZOffsetFromFloor = 0x0040;

		///<summary>unsigned char[0x3D4]</summary>
		public const int UnknownData00 = 0x0044;

	}

	public class ATeam
	{
		///<summary>FVector_NetQuantize100</summary>
		public const int PlayerLocation = 0x03A0;

		///<summary>FRotator</summary>
		public const int PlayerRotation = 0x03AC;

		///<summary>FString</summary>
		public const int PlayerName = 0x03B8;

		///<summary>unsigned char</summary>
		public const int Health = 0x03C8;

		///<summary>unsigned char</summary>
		public const int HealthMax = 0x03C9;

		///<summary>unsigned char</summary>
		public const int GroggyHealth = 0x03CA;

		///<summary>unsigned char</summary>
		public const int GroggyHealthMax = 0x03CB;

		///<summary>FVector2D</summary>
		public const int MapMarkerPosition = 0x03CC;

		///<summary>unsigned char:1</summary>
		public const int bIsDying = 0x03D4;

		///<summary>unsigned char:1</summary>
		public const int bIsGroggying = 0x03D4;

		///<summary>unsigned char:1</summary>
		public const int bQuitter = 0x03D4;

		///<summary>unsigned char:1</summary>
		public const int bShowMapMarker = 0x03D4;

		///<summary>TEnumAsByte<ETeamVehicleType></summary>
		public const int TeamVehicleType = 0x03D5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03D6;

		///<summary>float</summary>
		public const int BoostGauge = 0x03D8;

		///<summary>int8_t</summary>
		public const int MemberNumber = 0x03DC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03DD;

		///<summary>ATslCharacter *</summary>
		public const int TslCharacter = 0x03E0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x03E8;

		///<summary>FString</summary>
		public const int UniqueId = 0x03F8;

	}

	public class AThingHolder
	{
		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData00 = 0x03A0;

	}

	public class AThingSpot
	{
		///<summary>UThingSpotComponent *</summary>
		public const int SpotComponent = 0x03A0;

	}

	public class UThingSpotComponent
	{
		///<summary>TEnumAsByte<EThingSpotGroupType></summary>
		public const int SpotGroupType = 0x0300;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0301;

		///<summary>FVector2D</summary>
		public const int RandomRotatorRange = 0x0304;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x030C;

	}

	public class UTslAccessoryComponent
	{
		///<summary>FTransform</summary>
		public const int InitialTransformAttachmentScene = 0x0300;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0330;

	}

	public class ATslAchievement
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x03A0;

	}

	public class ATslAIController
	{
		///<summary>UBlackboardComponent *</summary>
		public const int BlackboardComp = 0x0498;

		///<summary>UBehaviorTreeComponent *</summary>
		public const int BehaviorComp = 0x04A0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x04A8;

	}

	public class ATslAircraftVehicle
	{
		///<summary>TArray<FAircraftParticle></summary>
		public const int AircraftParticles = 0x0400;

		///<summary>TArray<ATslParticle * ></summary>
		public const int AttachedParticles = 0x0410;

		///<summary>UStaticMeshComponent *</summary>
		public const int MeshComponent = 0x0420;

		///<summary>UTslAircraftVehicleMovement *</summary>
		public const int MovementComponent = 0x0428;

		///<summary>USplineComponent *</summary>
		public const int SplineComponent = 0x0430;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData00 = 0x0438;

		///<summary>float</summary>
		public const int TotalFlyingTime = 0x0480;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0484;

	}

	public class AAircraftCarePackage
	{
		///<summary>UClass *</summary>
		public const int CarePackageItemSpawnerClass = 0x0490;

		///<summary>UClass *</summary>
		public const int CarePackageItemClass = 0x0498;

		///<summary>TArray<FDropCarePackageTableData></summary>
		public const int DropCarePackageTableData = 0x04A0;

		///<summary>UGeneralItemSpawner *</summary>
		public const int CarePackageItemSpawner = 0x04B0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x04B8;

	}

	public class ATransportAircraftVehicle
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0490;

		///<summary>UAkAudioEvent *</summary>
		public const int RideSound = 0x04B8;

		///<summary>UAkAudioEvent *</summary>
		public const int LeaveSound = 0x04C0;

		///<summary>UAkComponent *</summary>
		public const int AkSoundCom = 0x04C8;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x04D0;

		///<summary>UClass *</summary>
		public const int ParachuteItem = 0x04D8;

		///<summary>UInteractionComponent *</summary>
		public const int InteractionComponent = 0x04E0;

		///<summary>bool</summary>
		public const int bIsEnteredAtEjectionArea = 0x04E8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x04E9;

		///<summary>float</summary>
		public const int EjectPredictionTime = 0x04EC;

		///<summary>float</summary>
		public const int MaxEjectSpeed = 0x04F0;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData02 = 0x04F4;

	}

	public class ATslWheeledVehicle
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>FTimerHandle</summary>
		public const int TimerHandle_Horn = 0x0420;

		///<summary>float</summary>
		public const int LongHornStartingTime = 0x0428;

		///<summary>float</summary>
		public const int CurrHornKeyPressedTime = 0x042C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0430;

		///<summary>FHornPlayInfo</summary>
		public const int HornPlayInfo = 0x0434;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x043C;

		///<summary>FHornSoundInfo</summary>
		public const int HornSounds_Local = 0x0440;

		///<summary>FHornSoundInfo</summary>
		public const int HornSounds_Remote = 0x0450;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x0460;

		///<summary>USphereComponent *</summary>
		public const int ActivationTrigger = 0x0470;

		///<summary>float</summary>
		public const int Health = 0x0478;

		///<summary>float</summary>
		public const int HealthMax = 0x047C;

		///<summary>float</summary>
		public const int Fuel = 0x0480;

		///<summary>float</summary>
		public const int FuelMax = 0x0484;

		///<summary>bool</summary>
		public const int bStabilizeActive = 0x0488;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0489;

		///<summary>float</summary>
		public const int AirControlPitchInput = 0x048C;

		///<summary>float</summary>
		public const int SpeedKPH = 0x0490;

		///<summary>float</summary>
		public const int ThrottleInput = 0x0494;

		///<summary>float</summary>
		public const int RPM = 0x0498;

		///<summary>float</summary>
		public const int Brake = 0x049C;

		///<summary>float</summary>
		public const int LatMax = 0x04A0;

		///<summary>float</summary>
		public const int LongSum = 0x04A4;

		///<summary>float</summary>
		public const int WaterDepthMax = 0x04A8;

		///<summary>float</summary>
		public const int SurfaceMax = 0x04AC;

		///<summary>float</summary>
		public const int SuspensionMax = 0x04B0;

		///<summary>int</summary>
		public const int FlatTireCount = 0x04B4;

		///<summary>unsigned char:1</summary>
		public const int bDirtySpeedKPH = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bDirtyThrottleInput = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bDirtyRPM = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bDirtyWaterDepthMax = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bDirtyBrake = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bDetectedStartup = 0x04B8;

		///<summary>unsigned char:1</summary>
		public const int bDetectedBraking = 0x04B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x04B9;

		///<summary>TArray<float></summary>
		public const int WheelsLatSlip = 0x04C0;

		///<summary>TArray<float></summary>
		public const int WheelsLongSlip = 0x04D0;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionOffset = 0x04E0;

		///<summary>TArray<UPhysicalMaterial * ></summary>
		public const int WheelsContactSurface = 0x04F0;

		///<summary>TArray<UPhysicalMaterial * ></summary>
		public const int TestWheelsContactSurface_prev = 0x0500;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionMaxDrop = 0x0510;

		///<summary>TArray<float></summary>
		public const int WheelsSuspensionMaxRaise = 0x0520;

		///<summary>UAkAudioEvent *</summary>
		public const int NullSound = 0x0530;

		///<summary>FTslImpactSoundInfo</summary>
		public const int ImpactSound = 0x0538;

		///<summary>FTslImpactSoundInfo</summary>
		public const int LandingSound = 0x0598;

		///<summary>UAkAudioEvent *</summary>
		public const int StartupSound = 0x05F8;

		///<summary>UAkAudioEvent *</summary>
		public const int BreakSound = 0x0600;

		///<summary>UAkAudioEvent *</summary>
		public const int StopSound = 0x0608;

		///<summary>UAkAudioEvent *</summary>
		public const int CharacterHitSound = 0x0610;

		///<summary>unsigned char:1</summary>
		public const int bWantsToBoosting = 0x0618;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0619;

		///<summary>float</summary>
		public const int TorqueMultiplierForBoosting = 0x061C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData07 = 0x0620;

		///<summary>UTslVehicleHitComponent *</summary>
		public const int VehicleHitComponent = 0x0628;

		///<summary>UTslVehicleCommonComponent *</summary>
		public const int VehicleCommonComponent = 0x0630;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x0638;

		///<summary>UTslVehicleEffectComponent *</summary>
		public const int VehicleEffectComponent = 0x0640;

		///<summary>UTslVehicleSyncComponent *</summary>
		public const int VehicleSyncComponent = 0x0648;

		///<summary>UTslVehicleTempComponent *</summary>
		public const int VehicleTempComponent = 0x0650;

		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0658;

		///<summary>UAkComponent *</summary>
		public const int AudioComEngine = 0x0660;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0668;

		///<summary>FName</summary>
		public const int SinkPoint = 0x0670;

		///<summary>UClass *</summary>
		public const int SinkBuffType = 0x0678;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData08 = 0x0680;

		///<summary>UBuffComponet *</summary>
		public const int BuffComponent = 0x0688;

		///<summary>TArray<UClass * ></summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x0690;

		///<summary>bool</summary>
		public const int bProcessAutoEject = 0x06A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x06A1;

		///<summary>float</summary>
		public const int AutoEjectGroundDistance = 0x06A4;

		///<summary>float</summary>
		public const int AutoEjectRoll = 0x06A8;

		///<summary>float</summary>
		public const int AutoEjectPitch = 0x06AC;

		///<summary>float</summary>
		public const int AutoEject_RiseRate = 0x06B0;

		///<summary>float</summary>
		public const int AutoEject_FallRate = 0x06B4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData10 = 0x06B8;

		///<summary>bool</summary>
		public const int bRunStabilizeOnEntry = 0x06BC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData11 = 0x06BD;

		///<summary>float</summary>
		public const int StabilizeInitialTimer = 0x06C0;

		///<summary>float</summary>
		public const int StablizeCurrentTimer = 0x06C4;

		///<summary>float</summary>
		public const int SteeringYawBias = 0x06C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData12 = 0x06CC;

	}

	public class ATslFloatingVehicle
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0400;

		///<summary>USkeletalMeshComponent *</summary>
		public const int MeshComponent = 0x0410;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0418;

		///<summary>UTslFloatingVehicleMovement *</summary>
		public const int MovementComponent = 0x0420;

		///<summary>UTslVehicleHitComponent *</summary>
		public const int VehicleHitComponent = 0x0428;

		///<summary>UTslVehicleCommonComponent *</summary>
		public const int VehicleCommonComponent = 0x0430;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x0438;

		///<summary>UTslVehicleEffectComponent *</summary>
		public const int VehicleEffectComponent = 0x0440;

		///<summary>UTslVehicleSyncComponent *</summary>
		public const int VehicleSyncComponent = 0x0448;

		///<summary>UTslVehicleTempComponent *</summary>
		public const int VehicleTempComponent = 0x0450;

		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0458;

		///<summary>UAkComponent *</summary>
		public const int AudioComEngine = 0x0460;

		///<summary>TArray<UClass * ></summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x0468;

		///<summary>FName</summary>
		public const int VehicleEnginePoint = 0x0478;

		///<summary>float</summary>
		public const int VehicleEngineRadius = 0x0480;

		///<summary>float</summary>
		public const int Health = 0x0484;

		///<summary>float</summary>
		public const int HealthMax = 0x0488;

		///<summary>float</summary>
		public const int Fuel = 0x048C;

		///<summary>float</summary>
		public const int FuelMax = 0x0490;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0494;

	}

	public class UTslWheeledVehicleMovement
	{
		///<summary>TArray<float></summary>
		public const int WheelHealthPercentages = 0x0420;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0430;

	}

	public class UTslFloatingVehicleMovement
	{
		///<summary>float</summary>
		public const int MaxAcceleration = 0x0180;

		///<summary>float</summary>
		public const int Acceleration = 0x0184;

		///<summary>float</summary>
		public const int StartAccelerationRate = 0x0188;

		///<summary>float</summary>
		public const int StopAccelerationRate = 0x018C;

		///<summary>float</summary>
		public const int MaxRotationYawAngle = 0x0190;

		///<summary>float</summary>
		public const int RotationYawAngle = 0x0194;

		///<summary>float</summary>
		public const int RotationYawRate = 0x0198;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x019C;

		///<summary>UCurveFloat *</summary>
		public const int DirectionalAccelerationCurve = 0x01A0;

		///<summary>float</summary>
		public const int BoostModifier = 0x01A8;

		///<summary>bool</summary>
		public const int bIsBoosting = 0x01AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x01AD;

		///<summary>float</summary>
		public const int ForwardInput = 0x01B0;

		///<summary>float</summary>
		public const int RotationInput = 0x01B4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x01B8;

		///<summary>float</summary>
		public const int HitCharacterDuration = 0x01BC;

	}

	public class UTslCharacterMovement
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0750;

		///<summary>float</summary>
		public const int MaxProneSpeed = 0x0758;

		///<summary>float</summary>
		public const int MaxGroggySpeed = 0x075C;

		///<summary>float</summary>
		public const int JumpedHalfHeight = 0x0760;

		///<summary>float</summary>
		public const int SpeedToJumpModifier = 0x0764;

		///<summary>float</summary>
		public const int MinJumpZVelocity = 0x0768;

		///<summary>float</summary>
		public const int MaxJumpZVelocity = 0x076C;

		///<summary>float</summary>
		public const int LandingJumpDecreaseModifier = 0x0770;

		///<summary>float</summary>
		public const int RecoveryWalkSpeedRatePerSec = 0x0774;

		///<summary>float</summary>
		public const int MinWalkSpeedModifier = 0x0778;

		///<summary>float</summary>
		public const int WalkSpeedModifierUnit = 0x077C;

		///<summary>float</summary>
		public const int MinStandingJumpXYSpeed = 0x0780;

		///<summary>float</summary>
		public const int SpeedInWaterModifier = 0x0784;

		///<summary>int</summary>
		public const int HeightFor200 = 0x07D8;

		///<summary>int</summary>
		public const int HeightFor160 = 0x07DC;

		///<summary>int</summary>
		public const int HeightFor120 = 0x07E0;

		///<summary>int</summary>
		public const int HeightFor90 = 0x07E4;

		///<summary>float</summary>
		public const int SizeForNarrow = 0x07E8;

		///<summary>int</summary>
		public const int SizeForSlide = 0x07EC;

		///<summary>float</summary>
		public const int VelocityForMobile = 0x07F0;

		///<summary>float</summary>
		public const int GlobalVaultScale = 0x07F4;

		///<summary>float</summary>
		public const int VaultCancelDTScalar = 0x07F8;

		///<summary>float</summary>
		public const int MinVelocityForStaticVaultCheck = 0x07FC;

		///<summary>FVaultingTask</summary>
		public const int CurrentVaultingTask = 0x0800;

		///<summary>UVaultingData *</summary>
		public const int CurrentVaultingData = 0x0840;

		///<summary>float</summary>
		public const int V_Timer_CP = 0x0848;

		///<summary>float</summary>
		public const int AnimMultiplierPreApex = 0x084C;

		///<summary>float</summary>
		public const int AnimMultiplierPostApex = 0x0850;

		///<summary>bool</summary>
		public const int bIsVaulting_CP = 0x0854;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0855;

		///<summary>FVector</summary>
		public const int CharacterRelLocation = 0x0858;

		///<summary>FVector</summary>
		public const int LastVaultLocation = 0x0864;

		///<summary>FVector</summary>
		public const int AveragedVelocity = 0x0870;

		///<summary>float</summary>
		public const int LastVaultTime = 0x087C;

		///<summary>float</summary>
		public const int VaultCancelAnimSpeed = 0x0880;

		///<summary>bool</summary>
		public const int bWantsToCancelVault = 0x0884;

		///<summary>unsigned char[0x4F]</summary>
		public const int UnknownData02 = 0x0885;

		///<summary>float</summary>
		public const int MaxSwimAcceleration = 0x08D4;

		///<summary>float</summary>
		public const int MaxZSpeedOutOfWaterModifier = 0x08D8;

		///<summary>FRotator</summary>
		public const int MaxSwimmingRotationRate = 0x08DC;

		///<summary>FRotator</summary>
		public const int SwimmingRotationAcceleration = 0x08E8;

		///<summary>float</summary>
		public const int MaxZSpeedOutOfWaterModifierForStandingSwimming = 0x08F4;

		///<summary>float</summary>
		public const int WaveRidingModifier = 0x08F8;

		///<summary>float</summary>
		public const int WaveRidingSmoothingFactor = 0x08FC;

		///<summary>float</summary>
		public const int WaveRidingModifierUnderWater = 0x0900;

		///<summary>float</summary>
		public const int StayingUnderWaterDepthBand = 0x0904;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0908;

		///<summary>float</summary>
		public const int MaxUnderwaterSwimSpeed = 0x090C;

		///<summary>float</summary>
		public const int MaxUnderwaterSwimAcceleration = 0x0910;

		///<summary>float</summary>
		public const int BrakingDecelerationUnderwaterSwimming = 0x0914;

		///<summary>FRotator</summary>
		public const int MaxUnderwaterSwimmingRotationRate = 0x0918;

		///<summary>FRotator</summary>
		public const int UnderwaterSwimmingRotationAcceleration = 0x0924;

		///<summary>float</summary>
		public const int MinimumHighAltitude = 0x0930;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x0934;

		///<summary>float</summary>
		public const int MaxFallLateralSpeedAtHighAltitude = 0x0938;

		///<summary>float</summary>
		public const int TerminalVelocityAtHighAltitude = 0x093C;

		///<summary>float</summary>
		public const int DecreaseTerminalVelocityAtHighAltitude = 0x0940;

		///<summary>float</summary>
		public const int MaxFallAccelerationAtHighAltitude = 0x0944;

		///<summary>FRotator</summary>
		public const int FallRotationRateAtHighAltitude = 0x0948;

		///<summary>float</summary>
		public const int AirControlAtHighAltitude = 0x0954;

		///<summary>float</summary>
		public const int AirControlBoostMultiplierAtHighAltitude = 0x0958;

		///<summary>float</summary>
		public const int AirControlBoostVelocityThresholdAtHighAltitude = 0x095C;

		///<summary>UClass *</summary>
		public const int FallingDamageType = 0x0960;

		///<summary>UCurveFloat *</summary>
		public const int EjectDamageCurve = 0x0968;

		///<summary>float</summary>
		public const int FallingDamageMinZCut = 0x0970;

		///<summary>float</summary>
		public const int FallingDamageVDampingZ = 0x0974;

		///<summary>float</summary>
		public const int FallingDamageFactor = 0x0978;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x097C;

	}

	public class UTslVehicleWheel
	{
		///<summary>float</summary>
		public const int Health = 0x0100;

		///<summary>float</summary>
		public const int HealthMax = 0x0104;

		///<summary>FName</summary>
		public const int TireBoneName = 0x0108;

		///<summary>float</summary>
		public const int LongSlipSkidThreshold = 0x0110;

		///<summary>float</summary>
		public const int LateralSlipSkidThreshold = 0x0114;

		///<summary>float</summary>
		public const int SpringCompressionLandingThreshold = 0x0118;

		///<summary>bool</summary>
		public const int bManualSuspensionSoundControl = 0x011C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x011D;

		///<summary>FVector</summary>
		public const int WheelEffectOffset = 0x0120;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x012C;

		///<summary>UTslWheelEffectType *</summary>
		public const int RollEffect = 0x0130;

		///<summary>UTslWheelEffectType *</summary>
		public const int SkidAccelEffect = 0x0138;

		///<summary>UTslWheelEffectType *</summary>
		public const int SkidEffect = 0x0140;

		///<summary>UClass *</summary>
		public const int PuncturedParticleClass = 0x0148;

		///<summary>UClass *</summary>
		public const int PuncturedSparkParticleClass = 0x0150;

		///<summary>float</summary>
		public const int slipThresholdForPunkSpark = 0x0158;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x015C;

		///<summary>UAkAudioEvent *</summary>
		public const int LandingSound = 0x0160;

		///<summary>bool</summary>
		public const int bApplyForceOnPuncture = 0x0168;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0169;

		///<summary>float</summary>
		public const int PunctureForce = 0x016C;

		///<summary>float</summary>
		public const int PunctureVelocityScalar = 0x0170;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x0174;

		///<summary>ATslParticle *</summary>
		public const int TslParticleRoll = 0x0180;

		///<summary>ATslParticle *</summary>
		public const int TslParticleSkid = 0x0188;

		///<summary>ATslParticle *</summary>
		public const int TslParticleAccelSkid = 0x0190;

		///<summary>ATslParticle *</summary>
		public const int TslParticlePunctureSpark = 0x0198;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x01A0;

		///<summary>UAkComponent *</summary>
		public const int AudioCom = 0x01A8;

		///<summary>float</summary>
		public const int MinZVelocityForSuspensionSound = 0x01B0;

		///<summary>unsigned char[0x3C]</summary>
		public const int UnknownData06 = 0x01B4;

		///<summary>float</summary>
		public const int TotalSpeedKmPerHour = 0x01F0;

		///<summary>float</summary>
		public const int Slip = 0x01F4;

		///<summary>bool</summary>
		public const int UseRoll = 0x01F8;

		///<summary>bool</summary>
		public const int UseSkid = 0x01F9;

		///<summary>bool</summary>
		public const int UseAccelSkid = 0x01FA;

		///<summary>bool</summary>
		public const int bHasLastStatus = 0x01FB;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x01FC;

	}

	public class UTslAnimInstance
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFire = 0x0498;

		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFireCycle = 0x04A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipPrimary = 0x04B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipSecondary = 0x04C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EqupiSidearm = 0x04D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipMelee = 0x04E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrown = 0x04F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipPrimary = 0x0508;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipSecondary = 0x0518;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEqupiSidearm = 0x0528;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipMelee = 0x0538;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipThrown = 0x0548;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ToggleFireMode = 0x0558;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadTactical = 0x0568;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadCharge = 0x0578;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneStart = 0x0588;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneStop = 0x0598;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneSingle = 0x05A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrownGrenade = 0x05B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrownMolotov = 0x05C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrownOther = 0x05D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowGrenadeReady = 0x05E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowGrenadeCooking = 0x05F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowGrenadeStart = 0x0608;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowMolotovReady = 0x0618;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowMolotovCooking = 0x0628;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowMolotovStart = 0x0638;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowLow = 0x0648;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowHigh = 0x0658;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowPrepare = 0x0668;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowCooking = 0x0678;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowStart = 0x0688;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowDrop = 0x0698;

		///<summary>FScriptMulticastDelegate</summary>
		public const int LandHeavy = 0x06A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int LandExtreme = 0x06B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadCancel = 0x06C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int CharacterPickup = 0x06D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnarmedAttack = 0x06E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int PowerupUsed = 0x06F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ChangeCharacterAppearance = 0x0708;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCastCancel = 0x0718;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCastFinish = 0x0728;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0738;

		///<summary>ATslCharacter *</summary>
		public const int CharacterReference = 0x0740;

		///<summary>TEnumAsByte<EAnimPawnState></summary>
		public const int PreEvalPawnState = 0x0748;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0749;

		///<summary>float</summary>
		public const int LocomotionSpeed_CP = 0x074C;

		///<summary>float</summary>
		public const int LocomotionSpeed2D_CP = 0x0750;

		///<summary>bool</summary>
		public const int bIsMoving_CP = 0x0754;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0755;

		///<summary>float</summary>
		public const int LocomotionDirection_CP = 0x0758;

		///<summary>float</summary>
		public const int LocomotionJumpDirection_CP = 0x075C;

		///<summary>float</summary>
		public const int LeanYaw_CP = 0x0760;

		///<summary>FRotator</summary>
		public const int LastAbsoluteDirection_CP = 0x0764;

		///<summary>FRotator</summary>
		public const int ControlRotation_CP = 0x0770;

		///<summary>FRotator</summary>
		public const int ControlRotationLastMovement_CP = 0x077C;

		///<summary>TEnumAsByte<EAnimStance></summary>
		public const int Stance_CP = 0x0788;

		///<summary>bool</summary>
		public const int bIsSprintingFast_CP = 0x0789;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x078A;

		///<summary>float</summary>
		public const int WeaponGripType_CP = 0x078C;

		///<summary>float</summary>
		public const int SprintAlpha_CP = 0x0790;

		///<summary>float</summary>
		public const int SprintValue_CP = 0x0794;

		///<summary>bool</summary>
		public const int bLocalQuickThrowHigh_CP = 0x0798;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0799;

		///<summary>float</summary>
		public const int LocalThrowModeSwitchAlpha_CP = 0x079C;

		///<summary>bool</summary>
		public const int bIsJumping_CP = 0x07A0;

		///<summary>bool</summary>
		public const int bJumpForward_CP = 0x07A1;

		///<summary>bool</summary>
		public const int bIsSwimming_CP = 0x07A2;

		///<summary>bool</summary>
		public const int bIsUnderWater_CP = 0x07A3;

		///<summary>bool</summary>
		public const int bIsDBNO_CP = 0x07A4;

		///<summary>TEnumAsByte<EAnimStance></summary>
		public const int DBNOEntryStance = 0x07A5;

		///<summary>bool</summary>
		public const int bIsReviving_CP = 0x07A6;

		///<summary>bool</summary>
		public const int bIsUpperbody_CP = 0x07A7;

		///<summary>bool</summary>
		public const int bIsTransitioning_CP = 0x07A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x07A9;

		///<summary>int</summary>
		public const int PlayerID_CP = 0x07AC;

		///<summary>int</summary>
		public const int AirCraftIDAnim_CP = 0x07B0;

		///<summary>bool</summary>
		public const int bIsEquippingPistol_CP = 0x07B4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x07B5;

		///<summary>UAnimMontage *</summary>
		public const int PistolEquipMontageRefCP = 0x07B8;

		///<summary>bool</summary>
		public const int bIsFlying_CP = 0x07C0;

		///<summary>bool</summary>
		public const int bIsLocalPlayer = 0x07C1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData07 = 0x07C2;

		///<summary>float</summary>
		public const int LocalPlayerAlpha = 0x07C4;

		///<summary>bool</summary>
		public const int bIsPunching_CP = 0x07C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x07C9;

		///<summary>float</summary>
		public const int PunchingAlpha_CP = 0x07CC;

		///<summary>TEnumAsByte<EAnimWeaponType></summary>
		public const int Weapon_CP = 0x07D0;

		///<summary>bool</summary>
		public const int bIsArmedWithGun_CP = 0x07D1;

		///<summary>bool</summary>
		public const int bIsArmedWithThrown_CP = 0x07D2;

		///<summary>bool</summary>
		public const int bIsPreparingThrow_CP = 0x07D3;

		///<summary>float</summary>
		public const int ThrowableAdditionalAimYaw_CP = 0x07D4;

		///<summary>UAnimMontage *</summary>
		public const int CurrentRecoilMontage_CP = 0x07D8;

		///<summary>UBlendSpace1D *</summary>
		public const int GripBlendSpace_CP = 0x07E0;

		///<summary>UBlendSpaceBase *</summary>
		public const int GripBlendSpaceLH_CP = 0x07E8;

		///<summary>float</summary>
		public const int LHGripIndex_CP = 0x07F0;

		///<summary>bool</summary>
		public const int bIsReloading_CP = 0x07F4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x07F5;

		///<summary>FVector</summary>
		public const int HandWeaponOffset_CP = 0x07F8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData10 = 0x0804;

		///<summary>FTransform</summary>
		public const int WeaponInertia_CP = 0x0810;

		///<summary>float</summary>
		public const int ReloadAlpha_CP = 0x0840;

		///<summary>float</summary>
		public const int HandWeaponOffsetAlpha_CP = 0x0844;

		///<summary>float</summary>
		public const int FinalRecoilAlpha_CP = 0x0848;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData11 = 0x084C;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_CP = 0x0850;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Pistol = 0x0858;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_SMG = 0x0860;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Rifle = 0x0868;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Sniper = 0x0870;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Pistol_FPP = 0x0878;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_SMG_FPP = 0x0880;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Rifle_FPP = 0x0888;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Sniper_FPP = 0x0890;

		///<summary>float</summary>
		public const int WeaponInertiaX_Scalar_CP = 0x0898;

		///<summary>float</summary>
		public const int WeaponInertiaY_Scalar_CP = 0x089C;

		///<summary>float</summary>
		public const int WeaponInertiaX_Clamp_CP = 0x08A0;

		///<summary>float</summary>
		public const int WeaponInertiaY_Clamp_CP = 0x08A4;

		///<summary>float</summary>
		public const int WeaponInertia_InerpSpeed_CP = 0x08A8;

		///<summary>float</summary>
		public const int WeaponInertiaX_Scalar_ADS_CP = 0x08AC;

		///<summary>float</summary>
		public const int WeaponInertiaY_Scalar_ADS_CP = 0x08B0;

		///<summary>float</summary>
		public const int WeaponInertiaX_Clamp_ADS_CP = 0x08B4;

		///<summary>float</summary>
		public const int WeaponInertiaY_Clamp_ADS_CP = 0x08B8;

		///<summary>float</summary>
		public const int WeaponInertia_InerpSpeed_ADS_CP = 0x08BC;

		///<summary>float</summary>
		public const int WeaponInertia_InerpSpeed_YawScalar_CP = 0x08C0;

		///<summary>float</summary>
		public const int WeaponInertia_YawToRollScalar_CP = 0x08C4;

		///<summary>float</summary>
		public const int WeaponInertia_YawToRollScalar_ADS_CP = 0x08C8;

		///<summary>float</summary>
		public const int WeaponInertiaRoll_Clamp_ADS_CP = 0x08CC;

		///<summary>float</summary>
		public const int WeaponInertiaRoll_Clamp_CP = 0x08D0;

		///<summary>float</summary>
		public const int WeaponInertia_Yaw_CP = 0x08D4;

		///<summary>float</summary>
		public const int WeaponInertia_Pitch_CP = 0x08D8;

		///<summary>float</summary>
		public const int WeaponInertia_Roll_CP = 0x08DC;

		///<summary>float</summary>
		public const int SprintWeaponLoweringAlpha_CP = 0x08E0;

		///<summary>float</summary>
		public const int RecoilRollValue_CP = 0x08E4;

		///<summary>float</summary>
		public const int RecoilTimer_CP = 0x08E8;

		///<summary>float</summary>
		public const int RecoilRollRand_CP = 0x08EC;

		///<summary>float</summary>
		public const int RecoilTimerScale_CP = 0x08F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData12 = 0x08F4;

		///<summary>UCurveFloat *</summary>
		public const int RecoilRollCurve_CP = 0x08F8;

		///<summary>float</summary>
		public const int WeaponStabilityAlpha_CP = 0x0900;

		///<summary>float</summary>
		public const int WeaponStabilityRefSpeed_CP = 0x0904;

		///<summary>bool</summary>
		public const int bIsAiming_CP = 0x0908;

		///<summary>bool</summary>
		public const int bIsScoping_CP = 0x0909;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData13 = 0x090A;

		///<summary>float</summary>
		public const int WeaponAimState_CP = 0x090C;

		///<summary>float</summary>
		public const int SprintAlphaModifier_CP = 0x0910;

		///<summary>bool</summary>
		public const int bIsAimingBackward_CP = 0x0914;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData14 = 0x0915;

		///<summary>float</summary>
		public const int Yaw_CP = 0x0918;

		///<summary>float</summary>
		public const int RotationYaw_CP = 0x091C;

		///<summary>float</summary>
		public const int Pitch_CP = 0x0920;

		///<summary>float</summary>
		public const int DesiredPitch_CP = 0x0924;

		///<summary>unsigned char</summary>
		public const int AimDirectionCardinal_CP = 0x0928;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData15 = 0x0929;

		///<summary>FRotator</summary>
		public const int AORot_CP = 0x092C;

		///<summary>FRotator</summary>
		public const int AORotBackwards_CP = 0x0938;

		///<summary>float</summary>
		public const int SwimmingPitch_CP = 0x0944;

		///<summary>float</summary>
		public const int WeaponCollisionAlpha_CP = 0x0948;

		///<summary>bool</summary>
		public const int bWeaponObstructedHigh_CP = 0x094C;

		///<summary>bool</summary>
		public const int bWasFalling_CP = 0x094D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData16 = 0x094E;

		///<summary>float</summary>
		public const int FallingAlpha_CP = 0x0950;

		///<summary>FVector2D</summary>
		public const int FallingMap2D = 0x0954;

		///<summary>FVector2D</summary>
		public const int FallingMapZ = 0x095C;

		///<summary>bool</summary>
		public const int bForceFall_CP = 0x0964;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData17 = 0x0965;

		///<summary>UAnimMontage *</summary>
		public const int MontageFallingRifle_CP = 0x0968;

		///<summary>UAnimMontage *</summary>
		public const int MontageFallingUnarmed_CP = 0x0970;

		///<summary>float</summary>
		public const int LandingAlpha_CP = 0x0978;

		///<summary>bool</summary>
		public const int bLocalForceProne_CP = 0x097C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData18 = 0x097D;

		///<summary>float</summary>
		public const int JumpHeight_CP = 0x0980;

		///<summary>float</summary>
		public const int FallHeight_CP = 0x0984;

		///<summary>FVector</summary>
		public const int JumpStartLocation_CP = 0x0988;

		///<summary>FVector</summary>
		public const int LandPredictionVector_CP = 0x0994;

		///<summary>float</summary>
		public const int LeanLeftAlpha_CP = 0x09A0;

		///<summary>float</summary>
		public const int LeanRightAlpha_CP = 0x09A4;

		///<summary>float</summary>
		public const int LeanTwoSideAlpha_CP = 0x09A8;

		///<summary>float</summary>
		public const int LeanInterpSpeed_CP = 0x09AC;

		///<summary>float</summary>
		public const int LeanInterpSpeedCollisionClamp_CP = 0x09B0;

		///<summary>bool</summary>
		public const int bUseLinearLeanInterp = 0x09B4;

		///<summary>bool</summary>
		public const int bIsFreefalling_CP = 0x09B5;

		///<summary>bool</summary>
		public const int bIsParachuting_CP = 0x09B6;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData19 = 0x09B7;

		///<summary>float</summary>
		public const int FreefallX_CP = 0x09B8;

		///<summary>float</summary>
		public const int FreefallY_CP = 0x09BC;

		///<summary>float</summary>
		public const int FreeFallAlpha_CP = 0x09C0;

		///<summary>bool</summary>
		public const int bIsParachuteLanding_CP = 0x09C4;

		///<summary>bool</summary>
		public const int bIsParachuteMoving_CP = 0x09C5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData20 = 0x09C6;

		///<summary>float</summary>
		public const int Freefall_Yaw_CP = 0x09C8;

		///<summary>float</summary>
		public const int Freefall_Pitch_CP = 0x09CC;

		///<summary>bool</summary>
		public const int bIsFreelooking_CP = 0x09D0;

		///<summary>bool</summary>
		public const int bIsMeleeAttacking_CP = 0x09D1;

		///<summary>bool</summary>
		public const int bLocalForceRotationHipLeft_CP = 0x09D2;

		///<summary>bool</summary>
		public const int bLocalForceRotationHipRight_CP = 0x09D3;

		///<summary>bool</summary>
		public const int bLocalForceRotationAimed_CP = 0x09D4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData21 = 0x09D5;

		///<summary>float</summary>
		public const int RotationPlayrateAimed_CP = 0x09D8;

		///<summary>float</summary>
		public const int RotationPlayrateAimedAdditiveSpine_CP = 0x09DC;

		///<summary>FRotator</summary>
		public const int LastRotation_CP = 0x09E0;

		///<summary>FRotator</summary>
		public const int Freelook_Body_CP = 0x09EC;

		///<summary>FRotator</summary>
		public const int Freelook_Delta_CP = 0x09F8;

		///<summary>int</summary>
		public const int IdleIndex_CP = 0x0A04;

		///<summary>int</summary>
		public const int LastIdleIndex_CP = 0x0A08;

		///<summary>float</summary>
		public const int IdleTimer_CP = 0x0A0C;

		///<summary>float</summary>
		public const int IdleTriggerRandom = 0x0A10;

		///<summary>float</summary>
		public const int IdleTriggerTimeMin_CP = 0x0A14;

		///<summary>float</summary>
		public const int IdleTriggerTimeVariation_CP = 0x0A18;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData22 = 0x0A1C;

		///<summary>FTransform</summary>
		public const int SlotPrimary_CP = 0x0A20;

		///<summary>FTransform</summary>
		public const int SlotSecondary_CP = 0x0A50;

		///<summary>FTransform</summary>
		public const int SlotMelee_CP = 0x0A80;

		///<summary>FTransform</summary>
		public const int SlotThrown_CP = 0x0AB0;

		///<summary>FVector</summary>
		public const int SlotPrimary_Offset_CP = 0x0AE0;

		///<summary>FVector</summary>
		public const int SlotSecondary_Offset_CP = 0x0AEC;

		///<summary>float</summary>
		public const int AnimDynamicsStandAlpha_CP = 0x0AF8;

		///<summary>float</summary>
		public const int AnimDynamicsStandSprintAlpha_CP = 0x0AFC;

		///<summary>float</summary>
		public const int AnimDynamicsCrouchAlpha_CP = 0x0B00;

		///<summary>float</summary>
		public const int AnimDynamicsProneAlpha_CP = 0x0B04;

		///<summary>FVector</summary>
		public const int EFCoat_CP = 0x0B08;

		///<summary>bool</summary>
		public const int bLocalFPP_CP = 0x0B14;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData23 = 0x0B15;

		///<summary>float</summary>
		public const int LocalFPPAlpha_CP = 0x0B18;

		///<summary>float</summary>
		public const int LocalFPPAlphaVehicleAimAO_CP = 0x0B1C;

		///<summary>bool</summary>
		public const int bIsInAircraft_CP = 0x0B20;

		///<summary>bool</summary>
		public const int bIsDriver_CP = 0x0B21;

		///<summary>bool</summary>
		public const int bIsSitting_CP = 0x0B22;

		///<summary>bool</summary>
		public const int bIsInVehicle_CP = 0x0B23;

		///<summary>float</summary>
		public const int LocalSteerInput_CP = 0x0B24;

		///<summary>float</summary>
		public const int LocalSteerInputMoto_CP = 0x0B28;

		///<summary>float</summary>
		public const int LocalStopMoto_CP = 0x0B2C;

		///<summary>float</summary>
		public const int LocalThrottleInput_CP = 0x0B30;

		///<summary>FRotator</summary>
		public const int GasThighRot_CP = 0x0B34;

		///<summary>FRotator</summary>
		public const int GasAnkleRot_CP = 0x0B40;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData24 = 0x0B4C;

		///<summary>FTransform</summary>
		public const int GasKneeTransformX_CP = 0x0B50;

		///<summary>float</summary>
		public const int LocalBrakeInput_CP = 0x0B80;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData25 = 0x0B84;

		///<summary>FTransform</summary>
		public const int BrakeKneeTransform_CP = 0x0B90;

		///<summary>FRotator</summary>
		public const int BrakeAnkleRot_CP = 0x0BC0;

		///<summary>float</summary>
		public const int BackwardAOAlpha_CP = 0x0BCC;

		///<summary>float</summary>
		public const int AimBlendAlpha_CP = 0x0BD0;

		///<summary>bool</summary>
		public const int bHasContact_CP = 0x0BD4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData26 = 0x0BD5;

		///<summary>float</summary>
		public const int GroundContactMoto_CP = 0x0BD8;

		///<summary>float</summary>
		public const int AirControlPitchInput_CP = 0x0BDC;

		///<summary>FTransform</summary>
		public const int DriverIK_CP = 0x0BE0;

		///<summary>float</summary>
		public const int PassengerIKAlpha_CP = 0x0C10;

		///<summary>FVector</summary>
		public const int DriverSpineLocWS_CP = 0x0C14;

		///<summary>TEnumAsByte<EVehicleAnimType></summary>
		public const int VehicleSeatType_CP = 0x0C20;

		///<summary>bool</summary>
		public const int bMotoHasDriver_CP = 0x0C21;

		///<summary>bool</summary>
		public const int bVaultCanceled = 0x0C22;

		///<summary>bool</summary>
		public const int bIsVaulting_CP = 0x0C23;

		///<summary>float</summary>
		public const int VaultTimer_CP = 0x0C24;

		///<summary>float</summary>
		public const int VaultTimerLast_CP = 0x0C28;

		///<summary>TEnumAsByte<EVaultAnimType></summary>
		public const int LocalVaultType_CP = 0x0C2C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData27 = 0x0C2D;

		///<summary>UAnimSequenceBase *</summary>
		public const int VaultAnimSequence_CP = 0x0C30;

		///<summary>float</summary>
		public const int VaultAnimLength_CP = 0x0C38;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData28 = 0x0C3C;

		///<summary>UCurveFloat *</summary>
		public const int VaultCurve_CP = 0x0C40;

		///<summary>float</summary>
		public const int VaultBlendInTime_CP = 0x0C48;

		///<summary>float</summary>
		public const int VaultBlendOutTime_CP = 0x0C4C;

		///<summary>bool</summary>
		public const int bEndVaultToFall_CP = 0x0C50;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData29 = 0x0C51;

		///<summary>float</summary>
		public const int VaultBlendOutProgressTime_CP = 0x0C54;

		///<summary>float</summary>
		public const int VaultBlendOutExactTime_CP = 0x0C58;

		///<summary>TEnumAsByte<ECastAnim></summary>
		public const int CurrentCastAnim_CP = 0x0C5C;

		///<summary>bool</summary>
		public const int bIsActiveRagdoll_CP = 0x0C5D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData30 = 0x0C5E;

		///<summary>float</summary>
		public const int WeaponIKLH_CP = 0x0C60;

		///<summary>float</summary>
		public const int WeaponIKRH_CP = 0x0C64;

		///<summary>float</summary>
		public const int MontageIKLH_CP = 0x0C68;

		///<summary>float</summary>
		public const int MontageIKRH_CP = 0x0C6C;

		///<summary>float</summary>
		public const int IgnoreWeaponTransform_CP = 0x0C70;

		///<summary>float</summary>
		public const int PickupIKAlpha_CP = 0x0C74;

		///<summary>float</summary>
		public const int TargetIKRH_CP = 0x0C78;

		///<summary>float</summary>
		public const int TargetIKLH_CP = 0x0C7C;

		///<summary>float</summary>
		public const int ForceLegsFromAnim_CP = 0x0C80;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData31 = 0x0C84;

		///<summary>ATslWeapon_Gun *</summary>
		public const int LastGunCache_CP = 0x0C88;

		///<summary>ATslWheeledVehicle *</summary>
		public const int CachedWheeledVehicle_CP = 0x0C90;

		///<summary>ATslFloatingVehicle *</summary>
		public const int CachedFloatingVehicle_CP = 0x0C98;

		///<summary>UBlendSpaceBase *</summary>
		public const int PassengerAimBS_CP = 0x0CA0;

		///<summary>UBlendSpaceBase *</summary>
		public const int PassengerTransitionOut_CP = 0x0CA8;

		///<summary>UBlendSpaceBase *</summary>
		public const int PassengerTransitionIn_CP = 0x0CB0;

		///<summary>UAnimSequenceBase *</summary>
		public const int PassengerIdle_CP = 0x0CB8;

		///<summary>UCurveFloat *</summary>
		public const int CurveAimState_CP = 0x0CC0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData32 = 0x0CC8;

		///<summary>bool</summary>
		public const int bIsLOD1 = 0x0CD0;

		///<summary>bool</summary>
		public const int bIsLOD2 = 0x0CD1;

		///<summary>bool</summary>
		public const int bIsWearingCoat = 0x0CD2;

		///<summary>unsigned char[0x9]</summary>
		public const int UnknownData33 = 0x0CD3;

		///<summary>bool</summary>
		public const int bIsParentalControl = 0x0CDC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData34 = 0x0CDD;

		///<summary>UAnimMontage *</summary>
		public const int MontageMeleeAttack1 = 0x0CE0;

		///<summary>UAnimMontage *</summary>
		public const int MontageMeleeAttack2 = 0x0CE8;

		///<summary>UAnimMontage *</summary>
		public const int MontageMeleeAttack3 = 0x0CF0;

		///<summary>UAnimMontage *</summary>
		public const int MontagePunchingAttack1 = 0x0CF8;

		///<summary>UAnimMontage *</summary>
		public const int MontagePunchingAttack2 = 0x0D00;

		///<summary>UAnimMontage *</summary>
		public const int MontagePunchingAttack3 = 0x0D08;

		///<summary>float</summary>
		public const int FPPSprintAnimScalar = 0x0D10;

		///<summary>FVector</summary>
		public const int FPP_PrimaryAndSecondaryItemOffset = 0x0D14;

		///<summary>float</summary>
		public const int PunchingAlphaOneTarget_CP = 0x0D20;

		///<summary>float</summary>
		public const int PunchingAlphaInterpSpeed = 0x0D24;

		///<summary>float</summary>
		public const int SprintWeaponLoweringScalar_CP = 0x0D28;

		///<summary>float</summary>
		public const int ThrowStateSwitchInterpSpeed = 0x0D2C;

	}

	public class ALobbyHUD
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCreateCharacter = 0x08D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDestroyCharacter = 0x08E0;

		///<summary>FString</summary>
		public const int StartURL = 0x08F0;

		///<summary>TArray<UCoherentCommonBinder * ></summary>
		public const int CommonBinders = 0x0900;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x0910;

		///<summary>ACameraActor *</summary>
		public const int Camera = 0x0918;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0920;

		///<summary>UClass *</summary>
		public const int LobbyCharacterMaleClass = 0x0940;

		///<summary>UClass *</summary>
		public const int LobbyCharacterFemaleClass = 0x0948;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x0950;

		///<summary>FViewTargetTransitionParams</summary>
		public const int ViewTargetTransitionParams = 0x09A0;

	}

	public class ATslEntryPlayerController
	{
		///<summary>UVivoxLobbyComponent *</summary>
		public const int VivoxComponent = 0x06D0;

	}

	public class APerfBotPlayerController
	{
		///<summary>int</summary>
		public const int AmmoClips = 0x0A08;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0A0C;

		///<summary>UClass *</summary>
		public const int WeaponType = 0x0A10;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x0A18;

	}

	public class ATslDemoSpectator
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0A08;

	}

	public class ATslBotAIController
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0498;

	}

	public class ACharacterBreathBuff
	{
		///<summary>float</summary>
		public const int BreathPerTick = 0x0400;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0404;

	}

	public class UTslCameraComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0860;

	}

	public class ATslCharacterProxy
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x07C0;

		///<summary>TArray<UWeaponClone * ></summary>
		public const int ArmedWeapons = 0x07C8;

		///<summary>UWeaponAnimInfoComponent *</summary>
		public const int WeaponAnimInfoComponent = 0x07D8;

		///<summary>float</summary>
		public const int WeaponUpdateIntervalSeconds = 0x07E0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x07E4;

	}

	public class UTslCharacterSpringArmComponent
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0390;

		///<summary>FVector</summary>
		public const int DefaultSocketOffset = 0x0394;

		///<summary>FVector</summary>
		public const int IndoorSocketOffset = 0x03A0;

		///<summary>FVector</summary>
		public const int LeanLeftDefaultSocketOffsetAddition = 0x03AC;

		///<summary>FVector</summary>
		public const int LeanRightDefaultSocketOffsetAddition = 0x03B8;

		///<summary>FVector</summary>
		public const int LeftShoulderAimingSocketOffset = 0x03C4;

		///<summary>FVector</summary>
		public const int RightShoulderAimingSocketOffset = 0x03D0;

		///<summary>FVector</summary>
		public const int LeanLeftAimedSocketOffsetAddition = 0x03DC;

		///<summary>FVector</summary>
		public const int LeanRightAimedSocketOffsetAddition = 0x03E8;

		///<summary>FVector</summary>
		public const int SprintSocketOffsetAddition = 0x03F4;

		///<summary>float</summary>
		public const int CrouchSocketOffsetZAddition = 0x0400;

		///<summary>float</summary>
		public const int CrouchSocketOffsetMovementZAddition = 0x0404;

		///<summary>float</summary>
		public const int ProneScoketOffsetZAddition = 0x0408;

		///<summary>float</summary>
		public const int SocketOffsetInterpSpeed = 0x040C;

		///<summary>FVector</summary>
		public const int DefaultTargetOffset = 0x0410;

		///<summary>FVector</summary>
		public const int IndoorTargetOffset = 0x041C;

		///<summary>FVector</summary>
		public const int AimingTargetOffset = 0x0428;

		///<summary>float</summary>
		public const int TargetOffsetInterpSpeed = 0x0434;

		///<summary>float</summary>
		public const int DefaultSpringArmLength = 0x0438;

		///<summary>float</summary>
		public const int IndoorSpringArmLength = 0x043C;

		///<summary>float</summary>
		public const int AimingSpringArmLength = 0x0440;

		///<summary>float</summary>
		public const int BlockingCompressOffset = 0x0444;

		///<summary>float</summary>
		public const int SpringArmLengthInterpSpeed = 0x0448;

		///<summary>float</summary>
		public const int AimingSpringArmLengthInterpSpeed = 0x044C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0450;

		///<summary>float</summary>
		public const int SpringArmRestoreInterpSpeed = 0x0454;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0458;

	}

	public class UTslCharacterValidateLocationComponent
	{
		///<summary>float</summary>
		public const int ValidLocationCacheInterval = 0x00F8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x00FC;

		///<summary>float</summary>
		public const int InvalidUndergroundCheckInterval = 0x010C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0110;

		///<summary>float</summary>
		public const int InvalidUndergroundCheckLength = 0x0114;

		///<summary>float</summary>
		public const int MaxAdjustRange = 0x0118;

		///<summary>int</summary>
		public const int MaxAdjustCount = 0x011C;

	}

	public class UTslChatWidgetStyle
	{
		///<summary>FTslChatStyle</summary>
		public const int ChatStyle = 0x0030;

	}

	public class UTslCheatManager
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UTslCoherentWidget
	{
		///<summary>UCoherentWidgetBinder *</summary>
		public const int WidgetBinder = 0x0460;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0468;

	}

	public class UTslConsole
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0130;

	}

	public class UTslConsoleSetting
	{
		///<summary>TArray<FString></summary>
		public const int AutoCompleteItemPaths = 0x0070;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteItemKinds = 0x0080;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteVehiclePaths = 0x0090;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteMaleBody = 0x00A0;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteMaleHair = 0x00B0;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteMaleFace = 0x00C0;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteFemaleBody = 0x00D0;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteFemaleHair = 0x00E0;

		///<summary>TArray<FString></summary>
		public const int AutoCompleteFemaleFace = 0x00F0;

	}

	public class ATslDamageField
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>float</summary>
		public const int DamageRadius = 0x03A4;

		///<summary>UParticleSystem *</summary>
		public const int DamageFieldFX = 0x03A8;

		///<summary>int</summary>
		public const int Damage = 0x03B0;

		///<summary>float</summary>
		public const int DamageInterval = 0x03B4;

		///<summary>UClass *</summary>
		public const int DamageType = 0x03B8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x03C0;

		///<summary>UClass *</summary>
		public const int DebuffTemplate = 0x03D0;

	}

	public class ATslDamageFieldContainer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>TArray<FDamageFieldLayout></summary>
		public const int DamageFieldLayouts = 0x03A8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03B8;

		///<summary>UClass *</summary>
		public const int DamageFieldTemplate = 0x03C0;

		///<summary>bool</summary>
		public const int FlameInWall = 0x03C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x03C9;

		///<summary>int</summary>
		public const int FlameMaxCountInWall = 0x03CC;

		///<summary>float</summary>
		public const int FlameDelayInWall = 0x03D0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData03 = 0x03D4;

	}

	public class ATslDestructibleContainer
	{
		///<summary>unsigned char:1</summary>
		public const int bFlag = 0x03A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03A1;

	}

	public class ATslDoor
	{
		///<summary>UStaticMeshComponent *</summary>
		public const int DoorMeshComponent = 0x03B0;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x03B8;

		///<summary>UInteractionComponent *</summary>
		public const int Interaction = 0x03C0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x03C8;

		///<summary>UDestructibleMesh *</summary>
		public const int DoorDestructibleMesh = 0x03E8;

		///<summary>unsigned char:1</summary>
		public const int bDoorOpened = 0x03F0;

		///<summary>unsigned char:1</summary>
		public const int bReverseRotation = 0x03F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03F1;

		///<summary>float</summary>
		public const int OpenAngle = 0x03F4;

		///<summary>UAkAudioEvent *</summary>
		public const int OpenSound = 0x03F8;

		///<summary>UAkAudioEvent *</summary>
		public const int CloseSound = 0x0400;

		///<summary>UCurveFloat *</summary>
		public const int OpenCurve = 0x0408;

		///<summary>float</summary>
		public const int OpenCurveDuration = 0x0410;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0414;

		///<summary>UCurveFloat *</summary>
		public const int CloseCurve = 0x0418;

		///<summary>float</summary>
		public const int CloseCurveDuration = 0x0420;

		///<summary>float</summary>
		public const int PointDamageImpulse = 0x0424;

		///<summary>float</summary>
		public const int PointDamageRadius = 0x0428;

		///<summary>float</summary>
		public const int BreakingRadius = 0x042C;

		///<summary>float</summary>
		public const int BreakingImpulse = 0x0430;

		///<summary>float</summary>
		public const int BreakingMinDamage = 0x0434;

		///<summary>float</summary>
		public const int DamageAccumulateTimeout = 0x0438;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x043C;

		///<summary>FName</summary>
		public const int TopImpactSoketName = 0x0440;

		///<summary>FName</summary>
		public const int CenterImpactSoketName = 0x0448;

		///<summary>FName</summary>
		public const int BottomImpactSoketName = 0x0450;

		///<summary>unsigned char[0x1C8]</summary>
		public const int UnknownData04 = 0x0458;

		///<summary>FDoorBreakingStateLegacy</summary>
		public const int DoorBreakingState = 0x0620;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData05 = 0x0621;

	}

	public class ATslExplosionEffect
	{
		///<summary>UParticleSystem *</summary>
		public const int ExplosionFX = 0x03A0;

		///<summary>UPointLightComponent *</summary>
		public const int ExplosionLight = 0x03A8;

		///<summary>float</summary>
		public const int ExplosionLightFadeOut = 0x03B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03B4;

		///<summary>UAkAudioEvent *</summary>
		public const int ExplosionSound = 0x03B8;

		///<summary>FDecalEffectDataSet</summary>
		public const int DecalEffectDataSet = 0x03C0;

		///<summary>float</summary>
		public const int DecalSpawnDelayTime = 0x0528;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x052C;

		///<summary>FHitResult</summary>
		public const int SurfaceHit = 0x0530;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x05B8;

	}

	public class ATslFence
	{
		///<summary>USplineComponent *</summary>
		public const int SplineComponent = 0x03A0;

		///<summary>TEnumAsByte<ETslFenceSelector></summary>
		public const int BeginSelector = 0x03A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03A9;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh1 = 0x03B0;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh2 = 0x03B8;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh3 = 0x03C0;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh4 = 0x03C8;

		///<summary>TEnumAsByte<ETslFenceSelector></summary>
		public const int EndSelector = 0x03D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03D1;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh1 = 0x03D8;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh2 = 0x03E0;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh3 = 0x03E8;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh4 = 0x03F0;

		///<summary>bool</summary>
		public const int bUseRandomForMiddle = 0x03F8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x03F9;

		///<summary>float</summary>
		public const int UnitLengthForMiddle = 0x03FC;

		///<summary>float</summary>
		public const int UnitSpacingForMiddle = 0x0400;

		///<summary>float</summary>
		public const int PivotOffsetForMiddle = 0x0404;

		///<summary>FRandomStream</summary>
		public const int RandomStreamForMiddle = 0x0408;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh1 = 0x0410;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh2 = 0x0418;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh3 = 0x0420;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh4 = 0x0428;

		///<summary>FCollisionProfileName</summary>
		public const int FenceCollisionProfile = 0x0430;

	}

	public class UTslReactionData
	{
		///<summary>float</summary>
		public const int DestroyDelay = 0x0028;

		///<summary>FVehicleReactionData</summary>
		public const int VehicleReactionData = 0x002C;

		///<summary>FRadialDamageReactionData</summary>
		public const int RadialDamageReactionData = 0x0038;

		///<summary>FPointDamageReactionData</summary>
		public const int PointDamageReactionData = 0x0044;

		///<summary>int</summary>
		public const int DependancyCountBySibling = 0x0054;

		///<summary>UAkAudioEvent *</summary>
		public const int PhysicsReactionSoundAk = 0x0058;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructibleReactionSoundAk = 0x0060;

	}

	public class UTslReactionComponent
	{
		///<summary>UTslReactionData *</summary>
		public const int ReactionData = 0x0810;

		///<summary>UDestructibleMesh *</summary>
		public const int ReactionDM = 0x0818;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0820;

	}

	public class ATslBreakableFence
	{
		///<summary>UTslReactionData *</summary>
		public const int ReactionData = 0x0438;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible1 = 0x0440;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible2 = 0x0448;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible3 = 0x0450;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible4 = 0x0458;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible1 = 0x0460;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible2 = 0x0468;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible3 = 0x0470;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible4 = 0x0478;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible1 = 0x0480;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible2 = 0x0488;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible3 = 0x0490;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible4 = 0x0498;

	}

	public class UTslSettings
	{
		///<summary>float</summary>
		public const int RepDistance_Item = 0x0028;

		///<summary>float</summary>
		public const int RepDistance_Character = 0x002C;

		///<summary>float</summary>
		public const int RepDistance_Weapon = 0x0030;

		///<summary>float</summary>
		public const int RepDistance_Vehicle = 0x0034;

		///<summary>float</summary>
		public const int RepDistance_Parachute = 0x0038;

		///<summary>float</summary>
		public const int RepDistance_Door = 0x003C;

		///<summary>float</summary>
		public const int RepDistance_Window = 0x0040;

		///<summary>float</summary>
		public const int RepFrequency_Character = 0x0044;

		///<summary>float</summary>
		public const int RepFrequency_WheeledVehicle = 0x0048;

		///<summary>float</summary>
		public const int RepFrequency_FloatingVehicle = 0x004C;

		///<summary>float</summary>
		public const int RepFrequency_Parachute = 0x0050;

		///<summary>float</summary>
		public const int RepFrequency_Aircraft = 0x0054;

		///<summary>float</summary>
		public const int RepFrequency_CarePackage = 0x0058;

		///<summary>float</summary>
		public const int RepVehicle_SpawnDistance = 0x005C;

		///<summary>float</summary>
		public const int RepVehicle_UnspawnDistance = 0x0060;

		///<summary>FRigidBodyErrorCorrection</summary>
		public const int RepVehicle_PhysicErrorCorrection = 0x0064;

		///<summary>float</summary>
		public const int CharacterCorrection_MaxSpeed = 0x0080;

		///<summary>float</summary>
		public const int CharacterCorrection_MaxSpeedPositionError = 0x0084;

		///<summary>float</summary>
		public const int CharacterCorrection_ZeroSpeedPositionError = 0x0088;

		///<summary>bool</summary>
		public const int bBattlEyeEnabled = 0x008C;

		///<summary>bool</summary>
		public const int bBattlEyeEnabledInPIE = 0x008D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x008E;

		///<summary>float</summary>
		public const int BattlEyeReliablePacketIntervalOnClient = 0x0090;

		///<summary>float</summary>
		public const int BattlEyeReliablePacketIntervalOnServer = 0x0094;

		///<summary>bool</summary>
		public const int bChineseLicensing = 0x0098;

		///<summary>bool</summary>
		public const int bKoreanRating = 0x0099;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x009A;

		///<summary>float</summary>
		public const int GameStateLogInterval = 0x009C;

		///<summary>float</summary>
		public const int ServerStatLogInterval = 0x00A0;

		///<summary>float</summary>
		public const int CharacterPositionLogInterval = 0x00A4;

		///<summary>float</summary>
		public const int DestructibleComponentMaxDrawDistance = 0x00A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00AC;

		///<summary>UClass *</summary>
		public const int CharacterClassToPlay = 0x00B0;

		///<summary>TArray<FBoneBinding></summary>
		public const int BoneMapping = 0x00B8;

		///<summary>TArray<UClass * ></summary>
		public const int TestVehicleClasses = 0x00C8;

		///<summary>TArray<UClass * ></summary>
		public const int TestFloatingVehicleClasses = 0x00D8;

		///<summary>float</summary>
		public const int StoppedWheeledVehicleSpeedThreshold = 0x00E8;

		///<summary>float</summary>
		public const int StoppedFloatingVehicleSpeedThreshold = 0x00EC;

		///<summary>float</summary>
		public const int LastDriverDuration = 0x00F0;

		///<summary>float</summary>
		public const int InteractableDistanceToleranceOnDedicatedServer = 0x00F4;

		///<summary>float</summary>
		public const int InteractableDistance_ItemDefault = 0x00F8;

		///<summary>float</summary>
		public const int InteractableSpeed_ItemDefault = 0x00FC;

		///<summary>FInteractionCollisionData</summary>
		public const int InteractionCollisionForFPS = 0x0100;

		///<summary>FInteractionCollisionData</summary>
		public const int InteractionCollisionForTPS = 0x0114;

		///<summary>bool</summary>
		public const int bPreventFinishMatchInPIE = 0x0128;

		///<summary>bool</summary>
		public const int bEnableInitialItemDonator = 0x0129;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x012A;

		///<summary>float</summary>
		public const int InventoryMaxSpaceDefault = 0x012C;

		///<summary>UTexture *</summary>
		public const int ErrorIconTexture = 0x0130;

		///<summary>UTexture *</summary>
		public const int LoadingIconTexture = 0x0138;

		///<summary>TArray<UObject * ></summary>
		public const int AssetsForPackageIntegrity = 0x0140;

		///<summary>float</summary>
		public const int UICrosshairDistance = 0x0150;

		///<summary>float</summary>
		public const int UICrosshairInterpSpeed = 0x0154;

		///<summary>float</summary>
		public const int UICrosshairDisableDistance = 0x0158;

		///<summary>float</summary>
		public const int GameTimeMultiplier = 0x015C;

		///<summary>bool</summary>
		public const int AimOffsetRayCast = 0x0160;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0161;

		///<summary>float</summary>
		public const int MeleeWeaponPitchMin = 0x0164;

		///<summary>float</summary>
		public const int MeleeWeaponPitchMax = 0x0168;

		///<summary>bool</summary>
		public const int EnableThrowLagCompensation = 0x016C;

		///<summary>bool</summary>
		public const int FullRecoilRecovery = 0x016D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData05 = 0x016E;

		///<summary>FLevelLoadingBoostParameters</summary>
		public const int LevelLoadingBoostParameters = 0x0170;

		///<summary>TArray<FNearClippingValue></summary>
		public const int NearClippingValues = 0x0180;

		///<summary>TArray<FTslGame_FCustomizableCategoryData></summary>
		public const int CustomizableCategoryData = 0x0190;

		///<summary>TArray<FCustomizableActionName></summary>
		public const int CustomizableActionNames = 0x01A0;

		///<summary>TArray<FTslGame_FCustomizableAxisName></summary>
		public const int CustomizableAxisNames = 0x01B0;

		///<summary>TArray<FCustomizableMouseSensitiveName></summary>
		public const int CustomizableMouseSensitiveNames = 0x01C0;

		///<summary>TArray<FSurportQualityLevel></summary>
		public const int SupportedQualityLevels = 0x01D0;

		///<summary>TArray<FScreenResolution></summary>
		public const int SupportedScreenResolutions = 0x01E0;

		///<summary>FStringAssetReference</summary>
		public const int MouseSensitivityCurve = 0x01F0;

		///<summary>FStringAssetReference</summary>
		public const int GammaCurve = 0x0200;

		///<summary>TArray<FString></summary>
		public const int CultureNames = 0x0210;

		///<summary>TArray<FColorBlindType></summary>
		public const int ColorBlindTypes = 0x0220;

		///<summary>TArray<FPresetColor></summary>
		public const int CrosshairColors = 0x0230;

		///<summary>TArray<FKeyInputModeName></summary>
		public const int KeyInputModeNames = 0x0240;

		///<summary>TArray<FUiType></summary>
		public const int MiniMapTypeList = 0x0250;

		///<summary>float</summary>
		public const int MinimumScreenResolutionRatio = 0x0260;

		///<summary>FScreenResolution</summary>
		public const int MinimumScreenResolution = 0x0264;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x026C;

		///<summary>TArray<FColorBlindColorSet></summary>
		public const int OverrideMarkerColors = 0x0270;

		///<summary>float</summary>
		public const int PunchClientHitLeeway_Attacker = 0x0280;

		///<summary>float</summary>
		public const int PunchClientHitLeeway_Victim = 0x0284;

		///<summary>float</summary>
		public const int ClientSideHitLeeway = 0x0288;

		///<summary>float</summary>
		public const int LogClientSideHitLeeway = 0x028C;

		///<summary>float</summary>
		public const int ClientSideOriginDistanceLeeway = 0x0290;

		///<summary>float</summary>
		public const int ClientSideOriginDistanceLeewayInPlace = 0x0294;

		///<summary>float</summary>
		public const int ClientSideOriginDistanceMax = 0x0298;

		///<summary>float</summary>
		public const int TravelDistanceLeeway = 0x029C;

		///<summary>float</summary>
		public const int AllowedHitLag = 0x02A0;

		///<summary>float</summary>
		public const int LogMinHitLag = 0x02A4;

		///<summary>float</summary>
		public const int HackDetectionSpeed = 0x02A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x02AC;

		///<summary>TArray<FOverrideScalability></summary>
		public const int OverrideScalabilities = 0x02B0;

		///<summary>float</summary>
		public const int FakeDoorBlockMaxY = 0x02C0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x02C4;

		///<summary>TArray<FReportCauseData></summary>
		public const int ReportCauses = 0x02C8;

		///<summary>TArray<FSubjectToReport></summary>
		public const int SubjectToReport = 0x02D8;

		///<summary>float</summary>
		public const int FreelookRecoveryInterpSpeed = 0x02E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData09 = 0x02EC;

		///<summary>TMap<FName,float></summary>
		public const int GamepadSensitiveMultiplier = 0x02F0;

		///<summary>bool</summary>
		public const int bIsESports = 0x0340;

		///<summary>unsigned char[0x57]</summary>
		public const int UnknownData10 = 0x0341;

		///<summary>UCurveFloat *</summary>
		public const int LoadedMouseSensitivityCurve = 0x0398;

		///<summary>UCurveFloat *</summary>
		public const int LoadedGammaCurve = 0x03A0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int CharacterStudioRenderTarget = 0x03A8;

	}

	public class UTslGameInstance
	{
		///<summary>FString</summary>
		public const int WelcomeScreenMap = 0x00F0;

		///<summary>bool</summary>
		public const int bUseLobbyWidget = 0x0100;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0101;

		///<summary>int</summary>
		public const int LobbyWidgetZOrder = 0x0104;

		///<summary>ULobbyLink *</summary>
		public const int LobbyLink = 0x0108;

		///<summary>UVivoxManager *</summary>
		public const int VivoxManager = 0x0110;

		///<summary>FTslStartParameter</summary>
		public const int StartParamter = 0x0118;

		///<summary>unsigned char[0x180]</summary>
		public const int UnknownData01 = 0x0198;

		///<summary>UClass *</summary>
		public const int LobbyWidgetClass = 0x0318;

		///<summary>unsigned char[0x120]</summary>
		public const int UnknownData02 = 0x0320;

		///<summary>ULobbyWidget *</summary>
		public const int LobbyWidget = 0x0440;

		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData03 = 0x0448;

		///<summary>TArray<FReplayKillEventItem></summary>
		public const int ReplayKillEventItems = 0x04F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEnumerateReplayKillEventsDone = 0x0500;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x0510;

		///<summary>TArray<FReplayItem></summary>
		public const int ReplayItemList = 0x0520;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData05 = 0x0530;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGetReplayListDone = 0x0568;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGotoTimelineDone = 0x0578;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRecordStarted = 0x0588;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData06 = 0x0598;

		///<summary>UGameEventObserver *</summary>
		public const int GameEventObserver = 0x05A0;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData07 = 0x05A8;

	}

	public class ATslGameMode
	{
		///<summary>UClass *</summary>
		public const int MalePawnClass = 0x0470;

		///<summary>UClass *</summary>
		public const int PerfBotPlayerControllerClass = 0x0478;

		///<summary>UClass *</summary>
		public const int ModeControllerClass = 0x0480;

		///<summary>TArray<UClass * ></summary>
		public const int AdditionalModeControllerClasses = 0x0488;

		///<summary>UClass *</summary>
		public const int InitialItemDonatorClass = 0x0498;

		///<summary>TArray<FMatchPreparerClass></summary>
		public const int MatchPreparerClasses = 0x04A0;

		///<summary>TEnumAsByte<EMatchStartType></summary>
		public const int MatchStartType = 0x04B0;

		///<summary>TEnumAsByte<ECameraViewBehaviour></summary>
		public const int CameraViewBehaviour = 0x04B1;

		///<summary>bool</summary>
		public const int PlayerRespawn = 0x04B2;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x04B3;

		///<summary>int</summary>
		public const int PostMatchWaitingTime = 0x04B4;

		///<summary>int</summary>
		public const int CustomGamePostMatchWaitingTime = 0x04B8;

		///<summary>int</summary>
		public const int ESportsPostMatchWaitingTime = 0x04BC;

		///<summary>int</summary>
		public const int ServerQuitAfterLeavingMapTime = 0x04C0;

		///<summary>int</summary>
		public const int MinPlayers = 0x04C4;

		///<summary>int</summary>
		public const int PlayerSpawnTryMaxCount = 0x04C8;

		///<summary>bool</summary>
		public const int bEnablePerfBotInPIE = 0x04CC;

		///<summary>bool</summary>
		public const int bEnablePerfBotLogin = 0x04CD;

		///<summary>bool</summary>
		public const int bIsPerfBotSpawnToRandomPosition = 0x04CE;

		///<summary>bool</summary>
		public const int bCanRestartPerfBot = 0x04CF;

		///<summary>bool</summary>
		public const int bEnableObserverInPIE = 0x04D0;

		///<summary>bool</summary>
		public const int IsBattleRoyale = 0x04D1;

		///<summary>bool</summary>
		public const int bStartPlayerAtMatchStart = 0x04D2;

		///<summary>bool</summary>
		public const int bShouldSpawnAtStartSpot = 0x04D3;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x04D4;

		///<summary>bool</summary>
		public const int bIsCustomGame = 0x04D5;

		///<summary>bool</summary>
		public const int bCanAllSpectate = 0x04D6;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x04D7;

		///<summary>FCustomGameUpdateCharacterInfo</summary>
		public const int CustomGameUpdateCharacterInfo = 0x04D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x04EC;

		///<summary>TArray<FLimitCustomStringParameter></summary>
		public const int LimitCustomStringParameters = 0x04F0;

		///<summary>float</summary>
		public const int MultiplierBlueZone = 0x0500;

		///<summary>float</summary>
		public const int BlueZoneCentralizationFactor = 0x0504;

		///<summary>float</summary>
		public const int MultiplierCarePackage = 0x0508;

		///<summary>FRedZoneCustomOption</summary>
		public const int RedZoneCustomOption = 0x050C;

		///<summary>TArray<FBlueZoneCustomOption></summary>
		public const int BlueZoneCustomOptions = 0x0528;

		///<summary>int</summary>
		public const int WarmupTime = 0x0538;

		///<summary>int</summary>
		public const int EditorTestTeamMemberCount = 0x053C;

		///<summary>TMap<FString,URewardData * ></summary>
		public const int RewardDataMap = 0x0540;

		///<summary>URewardData *</summary>
		public const int RewardData = 0x0590;

		///<summary>ATslPlayerState *</summary>
		public const int WinnerPlayerState = 0x0598;

		///<summary>int</summary>
		public const int WinnerTeam = 0x05A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x05A4;

		///<summary>UClass *</summary>
		public const int ItemSpawnProcessorClass = 0x05A8;

		///<summary>UClass *</summary>
		public const int ThingSpawnProcessorClass = 0x05B0;

		///<summary>UClass *</summary>
		public const int BasicBeltItemClassForNoBelt = 0x05B8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x05C0;

		///<summary>UItemSpawnProcessor *</summary>
		public const int ItemSpawnProcessor = 0x05C8;

		///<summary>UThingSpawnProcessor *</summary>
		public const int ThingSpawnProcessor = 0x05D0;

		///<summary>UGeneralItemSpawner *</summary>
		public const int InitialItemDonator = 0x05D8;

		///<summary>UMatchPreparer *</summary>
		public const int MatchPreparer = 0x05E0;

		///<summary>AModeController *</summary>
		public const int ModeController = 0x05E8;

		///<summary>ADroppedItemGridManager *</summary>
		public const int DroppedItemGridManager = 0x05F0;

		///<summary>TArray<AModeController * ></summary>
		public const int AdditinalModeControllers = 0x05F8;

		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData06 = 0x0608;

		///<summary>TMap<FString,APlayerState * ></summary>
		public const int JoinedUserPlayerStateMap = 0x06A0;

		///<summary>TArray<FTeams></summary>
		public const int Teams = 0x06F0;

		///<summary>unsigned char[0xB0]</summary>
		public const int UnknownData07 = 0x0700;

	}

	public class ATslGameSession
	{
		///<summary>unsigned char[0x318]</summary>
		public const int UnknownData00 = 0x03B8;

	}

	public class ATslGameState
	{
		///<summary>FString</summary>
		public const int MatchId = 0x0400;

		///<summary>FString</summary>
		public const int MatchShortGuid = 0x0410;

		///<summary>int</summary>
		public const int NumTeams = 0x0420;

		///<summary>int</summary>
		public const int RemainingTime = 0x0424;

		///<summary>bool</summary>
		public const int bTimerPaused = 0x0428;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0429;

		///<summary>int</summary>
		public const int NumJoinPlayers = 0x042C;

		///<summary>int</summary>
		public const int NumAlivePlayers = 0x0430;

		///<summary>int</summary>
		public const int NumAliveTeams = 0x0434;

		///<summary>int</summary>
		public const int NumStartPlayers = 0x0438;

		///<summary>int</summary>
		public const int NumStartTeams = 0x043C;

		///<summary>FVector</summary>
		public const int SafetyZonePosition = 0x0440;

		///<summary>float</summary>
		public const int SafetyZoneRadius = 0x044C;

		///<summary>FVector</summary>
		public const int PoisonGasWarningPosition = 0x0450;

		///<summary>float</summary>
		public const int PoisonGasWarningRadius = 0x045C;

		///<summary>FVector</summary>
		public const int RedZonePosition = 0x0460;

		///<summary>float</summary>
		public const int RedZoneRadius = 0x046C;

		///<summary>float</summary>
		public const int TotalReleaseDuration = 0x0470;

		///<summary>float</summary>
		public const int ElapsedReleaseDuration = 0x0474;

		///<summary>float</summary>
		public const int TotalWarningDuration = 0x0478;

		///<summary>float</summary>
		public const int ElapsedWarningDuration = 0x047C;

		///<summary>bool</summary>
		public const int bIsGasRelease = 0x0480;

		///<summary>bool</summary>
		public const int bIsTeamMatch = 0x0481;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0482;

		///<summary>float</summary>
		public const int ElapsedGasReleaseDuration = 0x0484;

		///<summary>FVector</summary>
		public const int LerpSafetyZonePosition = 0x0488;

		///<summary>float</summary>
		public const int LerpSafetyZoneRadius = 0x0494;

		///<summary>FVector</summary>
		public const int SafetyZoneBeginPosition = 0x0498;

		///<summary>float</summary>
		public const int SafetyZoneBeginRadius = 0x04A4;

		///<summary>ALevelAttribute *</summary>
		public const int LevelAttribute = 0x04A8;

	}

	public class UTslGameUserSettings
	{
		///<summary>float</summary>
		public const int ScreenScale = 0x0100;

		///<summary>float</summary>
		public const int Gamma = 0x0104;

		///<summary>bool</summary>
		public const int bIsLanMatch = 0x0108;

		///<summary>bool</summary>
		public const int bIsMasterSoundMute = 0x0109;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x010A;

		///<summary>float</summary>
		public const int MasterSoundVolume = 0x010C;

		///<summary>bool</summary>
		public const int bIsEffectSoundMute = 0x0110;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0111;

		///<summary>float</summary>
		public const int EffectSoundVolume = 0x0114;

		///<summary>bool</summary>
		public const int bIsUISoundMute = 0x0118;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0119;

		///<summary>float</summary>
		public const int UISoundVolume = 0x011C;

		///<summary>bool</summary>
		public const int bIsBGMSoundMute = 0x0120;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0121;

		///<summary>float</summary>
		public const int BGMSoundVolume = 0x0124;

		///<summary>bool</summary>
		public const int bIsVoiceInputMute = 0x0128;

		///<summary>bool</summary>
		public const int bIsVoiceOutputMute = 0x0129;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x012A;

		///<summary>int</summary>
		public const int VoiceInputVolume = 0x012C;

		///<summary>int</summary>
		public const int VoiceOutputVolume = 0x0130;

		///<summary>bool</summary>
		public const int bUsePushToTalk = 0x0134;

		///<summary>bool</summary>
		public const int bUseGlobalVoice = 0x0135;

		///<summary>bool</summary>
		public const int bUseTeamVoice = 0x0136;

		///<summary>bool</summary>
		public const int bSavedGraphicOption = 0x0137;

		///<summary>bool</summary>
		public const int bMotionBlur = 0x0138;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x0139;

		///<summary>FString</summary>
		public const int CultureName = 0x0140;

		///<summary>FCustomInputSettings</summary>
		public const int CustomInputSettins = 0x0150;

		///<summary>int</summary>
		public const int SelectMiniMapIndex = 0x0190;

		///<summary>float</summary>
		public const int FpsCamearFov = 0x0194;

		///<summary>bool</summary>
		public const int bUseForceFeedback = 0x0198;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0199;

		///<summary>int</summary>
		public const int ColorBlindType = 0x019C;

		///<summary>FString</summary>
		public const int CrosshairColorString = 0x01A0;

		///<summary>TArray<UClass * ></summary>
		public const int GearProfile1 = 0x01B0;

		///<summary>TArray<UClass * ></summary>
		public const int GearProfile2 = 0x01C0;

		///<summary>TEnumAsByte<EUiShowType></summary>
		public const int FppWeaponIconShowType = 0x01D0;

		///<summary>TEnumAsByte<EUiShowType></summary>
		public const int TpsWeaponIconShowType = 0x01D1;

		///<summary>TEnumAsByte<EUiShowType></summary>
		public const int FppEquipableItemIconShowType = 0x01D2;

		///<summary>bool</summary>
		public const int bUseCharacterCapture = 0x01D3;

		///<summary>int</summary>
		public const int WorldMapZoomSpeedLevel = 0x01D4;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeCrouch = 0x01D8;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeProne = 0x01D9;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeWalk = 0x01DA;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int bToggleSprint = 0x01DB;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeHoldRotation = 0x01DC;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeHoldBreath = 0x01DD;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModePeek = 0x01DE;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeMap = 0x01DF;

		///<summary>TEnumAsByte<ETslInputModes></summary>
		public const int InputModeADS = 0x01E0;

		///<summary>bool</summary>
		public const int bEditorApplyOverrideScalability = 0x01E1;

		///<summary>bool</summary>
		public const int bUseFreeLookInterp = 0x01E2;

		///<summary>bool</summary>
		public const int bPreloadingMap = 0x01E3;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x01E4;

		///<summary>TArray<FString></summary>
		public const int PreloadingMaps = 0x01E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGameUserSettingApplied = 0x01F8;

	}

	public class UTslGameViewportClient
	{
		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData00 = 0x0490;

	}

	public class UTslGlassWindowComponent
	{
		///<summary>float</summary>
		public const int DestroyDelayAfterDestructed = 0x0810;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0814;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructSound = 0x0818;

		///<summary>UDestructibleComponent *</summary>
		public const int DestructibleComponent = 0x0820;

		///<summary>unsigned char:1</summary>
		public const int bReplicatedOnClient = 0x0828;

		///<summary>unsigned char:1</summary>
		public const int bDestroyed = 0x0828;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x0829;

	}

	public class UTslGunAnimInstance
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFire = 0x0498;

		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFireCycle = 0x04A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int TriggerOn = 0x04B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int TriggerOff = 0x04C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int Reload1 = 0x04D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int Reload2 = 0x04E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneStart = 0x04F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneSingle = 0x0508;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneEnd = 0x0518;

		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponCharge = 0x0528;

		///<summary>FScriptMulticastDelegate</summary>
		public const int FireSelect = 0x0538;

		///<summary>FScriptMulticastDelegate</summary>
		public const int CancelReload = 0x0548;

		///<summary>FName</summary>
		public const int Name_FireMode_Semi = 0x0558;

		///<summary>FName</summary>
		public const int Name_FireMode_Burst = 0x0560;

		///<summary>FName</summary>
		public const int Name_FireMode_Fullauto = 0x0568;

	}

	public class UTslHealthGaugeData
	{
		///<summary>TArray<FHealthColorData></summary>
		public const int HealthGaugeColors = 0x0028;

		///<summary>FFloatInterval</summary>
		public const int WarningRage = 0x0038;

		///<summary>UCurveLinearColor *</summary>
		public const int GroggyColorCurve = 0x0040;

	}

	public class ATslImpactEffect
	{
		///<summary>UParticleSystem *</summary>
		public const int DefaultFX = 0x03A0;

		///<summary>UParticleSystem *</summary>
		public const int ConcreteFX = 0x03A8;

		///<summary>UParticleSystem *</summary>
		public const int DirtFX = 0x03B0;

		///<summary>UParticleSystem *</summary>
		public const int WaterFX = 0x03B8;

		///<summary>UParticleSystem *</summary>
		public const int MetalFX = 0x03C0;

		///<summary>UParticleSystem *</summary>
		public const int WoodFX = 0x03C8;

		///<summary>UParticleSystem *</summary>
		public const int GlassFX = 0x03D0;

		///<summary>UParticleSystem *</summary>
		public const int GrassFX = 0x03D8;

		///<summary>UParticleSystem *</summary>
		public const int FleshFX = 0x03E0;

		///<summary>UAkAudioEvent *</summary>
		public const int AkSound = 0x03E8;

		///<summary>FDecalEffectDataSet</summary>
		public const int DecalEffectDataSet = 0x03F0;

		///<summary>FHitResult</summary>
		public const int SurfaceHit = 0x0558;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleCom = 0x05E0;

		///<summary>UAkComponent *</summary>
		public const int AKCom = 0x05E8;

	}

	public class UTslInstancedGlassWindowComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x09E0;

		///<summary>UDestructibleMesh *</summary>
		public const int DestructibleMesh = 0x09E8;

		///<summary>float</summary>
		public const int DestroyDelayAfterDestructed = 0x09F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x09F4;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructSound = 0x09F8;

		///<summary>unsigned char:1</summary>
		public const int bReplicatedOnClient = 0x0A00;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0A01;

		///<summary>TArray<int></summary>
		public const int DestroyedInstances = 0x0A08;

		///<summary>TArray<int></summary>
		public const int PendingDestroyInstances = 0x0A18;

		///<summary>unsigned char[0xC8]</summary>
		public const int UnknownData03 = 0x0A28;

	}

	public class UTslInstancedReactionComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x09E0;

		///<summary>TArray<int></summary>
		public const int PendingDestroyInstances = 0x09E8;

		///<summary>UTslReactionData *</summary>
		public const int ReactionData = 0x09F8;

		///<summary>UDestructibleMesh *</summary>
		public const int ReactionDM = 0x0A00;

		///<summary>unsigned char[0x1B8]</summary>
		public const int UnknownData01 = 0x0A08;

	}

	public class ATslLevelScriptActor
	{
		///<summary>TArray<FWeatherLevelInfo></summary>
		public const int WeatherLevelInfos = 0x03A8;

		///<summary>UMaterialParameterCollection *</summary>
		public const int GlobalMPC = 0x03B8;

		///<summary>int</summary>
		public const int SelectedWeatherLevelIndex = 0x03C0;

		///<summary>unsigned char[0x8C]</summary>
		public const int UnknownData00 = 0x03C4;

	}

	public class UTslPersistentUser
	{
		///<summary>float</summary>
		public const int Gamma = 0x0028;

		///<summary>float</summary>
		public const int AimSensitivity = 0x002C;

		///<summary>bool</summary>
		public const int bInvertedYAxis = 0x0030;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0031;

		///<summary>float</summary>
		public const int ScreenScalePercentage = 0x0034;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0038;

	}

	public class UTslLocalPlayer
	{
		///<summary>UTslPersistentUser *</summary>
		public const int PersistentUser = 0x0190;

	}

	public class UTslMenuItemWidgetStyle
	{
		///<summary>FTslMenuItemStyle</summary>
		public const int MenuItemStyle = 0x0030;

	}

	public class UTslMenuSoundsWidgetStyle
	{
		///<summary>FTslMenuSoundsStyle</summary>
		public const int SoundsStyle = 0x0030;

	}

	public class UTslMenuWidgetStyle
	{
		///<summary>FTslMenuStyle</summary>
		public const int MenuStyle = 0x0030;

	}

	public class ATslModularBuilding
	{
		///<summary>unsigned char[0x100]</summary>
		public const int UnknownData00 = 0x03A0;

	}

	public class ATslParticle
	{
		///<summary>bool</summary>
		public const int bAutoDestroyOnParticleFinish = 0x03A0;

		///<summary>bool</summary>
		public const int bAutoPlaySound = 0x03A1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03A2;

		///<summary>TArray<FParticleParameter></summary>
		public const int DefaultParameters = 0x03A8;

		///<summary>TEnumAsByte<EAttachParent></summary>
		public const int AttachParentType = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03B9;

		///<summary>FName</summary>
		public const int AttachSocketName = 0x03C0;

		///<summary>TEnumAsByte<EAttachmentRule></summary>
		public const int AttachLocationRule = 0x03C8;

		///<summary>TEnumAsByte<EAttachmentRule></summary>
		public const int AttachRotationRule = 0x03C9;

		///<summary>TEnumAsByte<EAttachmentRule></summary>
		public const int AttachScaleRule = 0x03CA;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData02 = 0x03CB;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleSystem = 0x03D0;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x03D8;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x03E0;

	}

	public class ATslParticleEnvironment
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03F8;

		///<summary>float</summary>
		public const int AutoParticleActivateDistance = 0x0408;

		///<summary>float</summary>
		public const int AutoPlayDistance = 0x040C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0410;

	}

	public class ATslPassBluezoneArea
	{
		///<summary>USphereComponent *</summary>
		public const int SphereComponent = 0x03A0;

		///<summary>float</summary>
		public const int Radius = 0x03A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03AC;

	}

	public class ATslPhysicsVolume
	{
		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x03E8;

		///<summary>UClass *</summary>
		public const int DefaultWaterSplash = 0x03F0;

		///<summary>UClass *</summary>
		public const int VehicleWaterSplash = 0x03F8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0400;

	}

	public class ATslPlayerCameraManager
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x1A60;

	}

	public class ATslPlayerState
	{
		///<summary>int</summary>
		public const int Ranking = 0x0430;

		///<summary>unsigned char:1</summary>
		public const int bKilled = 0x0434;

		///<summary>bool</summary>
		public const int bShowMapMarker = 0x0435;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0436;

		///<summary>FVector2D</summary>
		public const int MapMarkerPosition = 0x0438;

		///<summary>TEnumAsByte<EObserverAuthorityType></summary>
		public const int ObserverAuthorityType = 0x0440;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0441;

		///<summary>int</summary>
		public const int TeamNumber = 0x0444;

		///<summary>FTslPlayerScores</summary>
		public const int PlayerScores = 0x0448;

		///<summary>FTslPlayerStatistics</summary>
		public const int PlayerStatistics = 0x0454;

		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData02 = 0x0458;

		///<summary>TArray<FReplicatedEquipableItem></summary>
		public const int ReplicatedEquipableItems = 0x0500;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData03 = 0x0510;

		///<summary>unsigned char:1</summary>
		public const int bQuitter = 0x052C;

		///<summary>unsigned char[0xFF]</summary>
		public const int UnknownData04 = 0x052D;

		///<summary>float</summary>
		public const int LastHitTime = 0x062C;

		///<summary>FVector_NetQuantize</summary>
		public const int CurrentAttackedPlayerLocation = 0x0630;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x063C;

	}

	public class ATslPostProcessEffect
	{
		///<summary>TArray<FPostProcessMaterial></summary>
		public const int PostProcessMaterials = 0x03A0;

		///<summary>TArray<FPostProcessEffectParameter></summary>
		public const int DefaultPostProcessEffectParameter = 0x03B0;

		///<summary>TArray<FPostProcessEffectDynamicMaterialState></summary>
		public const int PostProcessEffectDynamicMaterialStates = 0x03C0;

		///<summary>APostProcessVolume *</summary>
		public const int PostProcessVolume = 0x03D0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03D8;

	}

	public class ATslWeapon_Projectile
	{
		///<summary>FProjectileWeaponData</summary>
		public const int ProjectileConfig = 0x0A20;

	}

	public class ATslProjectile
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>UProjectileMovementComponent *</summary>
		public const int MovementComp = 0x03A8;

		///<summary>USphereComponent *</summary>
		public const int CollisionComp = 0x03B0;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleComp = 0x03B8;

		///<summary>UStaticMeshComponent *</summary>
		public const int MeshComp = 0x03C0;

		///<summary>UPhysicsConstraintComponent *</summary>
		public const int MeshConstraint = 0x03C8;

		///<summary>FVector</summary>
		public const int MeshInitialRotationRate = 0x03D0;

		///<summary>bool</summary>
		public const int bSyncServerAndClientRotation = 0x03DC;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData01 = 0x03DD;

		///<summary>bool</summary>
		public const int HideMeshAtExplosion = 0x03EC;

		///<summary>bool</summary>
		public const int ExplosionInWater = 0x03ED;

		///<summary>TEnumAsByte<EProjectileExplosionRotationType></summary>
		public const int ExplosionRotationType = 0x03EE;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x03EF;

		///<summary>FName</summary>
		public const int ParticleToMeshAttachPointName = 0x03F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x03F8;

		///<summary>UClass *</summary>
		public const int ExplosionTemplate = 0x0400;

		///<summary>UClass *</summary>
		public const int ExplosionTemplateInAir = 0x0408;

		///<summary>UClass *</summary>
		public const int ExplosionTemplateInWater = 0x0410;

		///<summary>UAkAudioEvent *</summary>
		public const int ImpactSound = 0x0418;

		///<summary>UAkComponent *</summary>
		public const int AkComp = 0x0420;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0428;

		///<summary>TEnumAsByte<EProjectileExplodeState></summary>
		public const int ExplodeState = 0x0430;

		///<summary>unsigned char:1</summary>
		public const int bActiveParticle = 0x0431;

		///<summary>unsigned char:1</summary>
		public const int bDoTick = 0x0431;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData05 = 0x0432;

		///<summary>FRotator</summary>
		public const int ClientMeshRotation = 0x0434;

		///<summary>FRotator</summary>
		public const int ServerMeshRotation = 0x0440;

		///<summary>float</summary>
		public const int VelocityStopStepDistance = 0x044C;

		///<summary>FVector</summary>
		public const int LastStepLocation = 0x0450;

		///<summary>int</summary>
		public const int StepBuffer = 0x045C;

		///<summary>float</summary>
		public const int FinalInterpSpeed = 0x0460;

		///<summary>bool</summary>
		public const int bConstantInterpStep = 0x0464;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0465;

		///<summary>float</summary>
		public const int VelocityCheckTimerTick = 0x0468;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x046C;

		///<summary>FProjectileData</summary>
		public const int ProjectileConfig = 0x0470;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData08 = 0x04A0;

	}

	public class ATslProjectileMolotov
	{
		///<summary>TEnumAsByte<EMolotovSimulationType></summary>
		public const int MolotovSimulation = 0x04D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x04D1;

		///<summary>UClass *</summary>
		public const int DamageFieldContainerTemplate = 0x04D8;

		///<summary>UClass *</summary>
		public const int DamageFieldContainerInWallTemplate = 0x04E0;

		///<summary>UClass *</summary>
		public const int DamageFieldTemplate = 0x04E8;

		///<summary>UClass *</summary>
		public const int DamageFieldTemplateInWall = 0x04F0;

		///<summary>UClass *</summary>
		public const int FragmentProjectileClass = 0x04F8;

		///<summary>int</summary>
		public const int ImpactMaxCount = 0x0500;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData01 = 0x0504;

	}

	public class UTslReactionDoorComponent
	{
		///<summary>UTslReactionDoorData *</summary>
		public const int ReactionDoorData = 0x0810;

		///<summary>UDestructibleMesh *</summary>
		public const int DoorDestructibleMesh = 0x0818;

		///<summary>FDoorBreakingState</summary>
		public const int DoorBreakingState = 0x0820;

		///<summary>unsigned char[0x3F]</summary>
		public const int UnknownData00 = 0x0821;

	}

	public class UTslSceneCaptureComponent2D
	{
		///<summary>UWorld *</summary>
		public const int World = 0x08D0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x08D8;

	}

	public class UTslSceneCaptureWorld
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UWorld *</summary>
		public const int World = 0x0050;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData01 = 0x0058;

	}

	public class ATslServerParticle
	{
		///<summary>bool</summary>
		public const int bAutoDestroyOnParticleFinish = 0x03A0;

		///<summary>bool</summary>
		public const int bAutoPlaySound = 0x03A1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03A2;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleSystem = 0x03A8;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x03B0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x03B8;

	}

	public class UTslSingleton
	{
		///<summary>unsigned char[0xF0]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class ATslSpectatorPawn
	{
		///<summary>UClass *</summary>
		public const int ReplayHUD = 0x0428;

		///<summary>UClass *</summary>
		public const int LevelAttribute_BattleRoyalRule = 0x0430;

		///<summary>UClass *</summary>
		public const int LevelAttribute_Erangel = 0x0438;

		///<summary>float</summary>
		public const int PlayerInfoMinDistance = 0x0440;

		///<summary>float</summary>
		public const int PlayerInfoMaxDistance = 0x0444;

		///<summary>USpringArmComponent *</summary>
		public const int FreeCameraSpringArmComponent = 0x0448;

		///<summary>UCameraComponent *</summary>
		public const int FreeCameraComponent = 0x0450;

		///<summary>USpringArmComponent *</summary>
		public const int ThirdPersonSpringArm = 0x0458;

		///<summary>UCameraComponent *</summary>
		public const int ThirdPersonCamera = 0x0460;

		///<summary>USpringArmInVehicleComponent *</summary>
		public const int ThirdPersonSpringArmInVehicle = 0x0468;

		///<summary>UCameraComponent *</summary>
		public const int ThirdPersonCameraInVehicle = 0x0470;

		///<summary>UArrowComponent *</summary>
		public const int AudioListener = 0x0478;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0480;

		///<summary>float</summary>
		public const int DeathFollowBlendTime = 0x0484;

		///<summary>TEnumAsByte<EViewTargetBlendFunction></summary>
		public const int DeathFollowBlendFunc = 0x0488;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0489;

		///<summary>float</summary>
		public const int DeathFollowBlendExp = 0x048C;

		///<summary>float</summary>
		public const int DeathFollowTime = 0x0490;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0494;

		///<summary>float</summary>
		public const int DeathFollowDistance = 0x0498;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x049C;

		///<summary>FName</summary>
		public const int DeathFollowBone = 0x04A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x04A8;

		///<summary>float</summary>
		public const int LocationUpdateIntervalSeconds = 0x04AC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x04B0;

		///<summary>float</summary>
		public const int FreeCameraBlendTime = 0x04B4;

		///<summary>TEnumAsByte<EViewTargetBlendFunction></summary>
		public const int FreeCameraBlendFunc = 0x04B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x04B9;

		///<summary>float</summary>
		public const int FreeCameraBlendExp = 0x04BC;

		///<summary>float</summary>
		public const int FreeCameraBlendPitch = 0x04C0;

		///<summary>float</summary>
		public const int LimitMinFreeCamFov = 0x04C4;

		///<summary>float</summary>
		public const int LimitMaxFreeCamFov = 0x04C8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData07 = 0x04CC;

		///<summary>float</summary>
		public const int FollowCameraZoomSpeed = 0x04D8;

		///<summary>float</summary>
		public const int ThirdPersonCameraBlendTime = 0x04DC;

		///<summary>TEnumAsByte<EViewTargetBlendFunction></summary>
		public const int ThirdPersonCameraBlendFunc = 0x04E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x04E1;

		///<summary>float</summary>
		public const int ThirdPersonCameraBlendExp = 0x04E4;

		///<summary>float</summary>
		public const int LimitTargetArmLength = 0x04E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData09 = 0x04EC;

		///<summary>FName</summary>
		public const int AttachSocket = 0x04F0;

		///<summary>ATslCharacter *</summary>
		public const int DeathCharacter = 0x04F8;

		///<summary>float</summary>
		public const int SpectatableCheckLength = 0x0500;

		///<summary>float</summary>
		public const int SpectatableCheckScreenRatio = 0x0504;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData10 = 0x0508;

		///<summary>UClass *</summary>
		public const int OutlineEffectClass = 0x0520;

		///<summary>ATslPostProcessEffect *</summary>
		public const int OutlineEffect = 0x0528;

		///<summary>TArray<FSavedObPos></summary>
		public const int ArrObPos = 0x0530;

		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData11 = 0x0540;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPlayerInfoDistanceDelegate = 0x05B0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData12 = 0x05C0;

	}

	public class UTslSpectatorPawnMovement
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x01A0;

		///<summary>float</summary>
		public const int FastMoveModifier = 0x01A4;

		///<summary>float</summary>
		public const int SlowMoveModifier = 0x01A8;

		///<summary>float</summary>
		public const int MinFreeMoveSpeed = 0x01AC;

		///<summary>float</summary>
		public const int MaxFreeMoveSpeed = 0x01B0;

		///<summary>float</summary>
		public const int MinFreeMoveSpeedHeight = 0x01B4;

		///<summary>float</summary>
		public const int MaxFreeMoveSpeedHeight = 0x01B8;

		///<summary>float</summary>
		public const int AbsoluteMinZ = 0x01BC;

		///<summary>float</summary>
		public const int AbsoluteMaxZ = 0x01C0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01C4;

	}

	public class UTslStreamer
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UFoliageCollisionStreamer
	{
		///<summary>bool</summary>
		public const int bEnabled = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>float</summary>
		public const int MinDistance = 0x004C;

		///<summary>float</summary>
		public const int MaxQueryDistance = 0x0050;

		///<summary>float</summary>
		public const int MaxSimulationDistance = 0x0054;

		///<summary>bool</summary>
		public const int bUseOnlyQueryAndPhysics = 0x0058;

		///<summary>unsigned char[0x57]</summary>
		public const int UnknownData01 = 0x0059;

	}

	public class ULODActorStreamer
	{
		///<summary>bool</summary>
		public const int bEnabled = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>float</summary>
		public const int PreLoadDistance = 0x004C;

		///<summary>int</summary>
		public const int PerFrameShowCount = 0x0050;

		///<summary>int</summary>
		public const int PerFrameShowCountLimit = 0x0054;

		///<summary>TArray<FFloatRange></summary>
		public const int MinDrawDistanceOverride = 0x0058;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0068;

	}

	public class UParticleEnvrionmentStreamer
	{
		///<summary>bool</summary>
		public const int bEnabled = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>float</summary>
		public const int ToleranceDeactiveDistance = 0x004C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0050;

	}

	public class ATslStreamerManager
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03A0;

		///<summary>TArray<UClass * ></summary>
		public const int StreamerClasses = 0x03A8;

		///<summary>TArray<UTslStreamer * ></summary>
		public const int TslStreamers = 0x03B8;

	}

	public class UTslThrowableTrajectoryViewComponent
	{
		///<summary>UStaticMesh *</summary>
		public const int SplineSegmentMesh = 0x07B0;

		///<summary>UMaterialInterface *</summary>
		public const int SplineSegmentMeshMaterial = 0x07B8;

		///<summary>FVector2D</summary>
		public const int SegmentMeshScale = 0x07C0;

		///<summary>UStaticMesh *</summary>
		public const int ImpactMesh = 0x07C8;

		///<summary>UMaterialInterface *</summary>
		public const int ImpactMeshMaterial = 0x07D0;

		///<summary>FVector</summary>
		public const int ImpactMeshScale = 0x07D8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x07E4;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x07E4;

		///<summary>float</summary>
		public const int PredictionTime = 0x0838;

		///<summary>float</summary>
		public const int DistanceScaleFactor = 0x083C;

		///<summary>FName</summary>
		public const int MaterialParam_NearDepthFadeOrigin = 0x0840;

		///<summary>FName</summary>
		public const int MaterialParam_FarDepthFadeOrigin = 0x0848;

		///<summary>float</summary>
		public const int SplineGenerationAngThresholdDeg = 0x0850;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x0854;

		///<summary>UStaticMeshComponent *</summary>
		public const int ImpactMeshComponent = 0x0860;

		///<summary>TArray<USplineMeshComponent * ></summary>
		public const int SplineMeshArray = 0x0868;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int SplineSegmentMeshMaterialDynamic = 0x0878;

	}

	public class UTslUserWidget
	{
		///<summary>UInputComponent *</summary>
		public const int InputComponentAxis = 0x0240;

		///<summary>ATslCharacter *</summary>
		public const int CachedTslCharacter = 0x0248;

		///<summary>ATslGameState *</summary>
		public const int CachedTslGameState = 0x0250;

		///<summary>ATslCharacter *</summary>
		public const int CachedViewTargetTslCharacter = 0x0258;

	}

	public class UBlockInputUserWidget
	{
		///<summary>bool</summary>
		public const int bWhiteList = 0x0260;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0261;

		///<summary>TArray<FBlockAction></summary>
		public const int BlockActions = 0x0268;

		///<summary>TArray<FName></summary>
		public const int BlockAxises = 0x0278;

		///<summary>bool</summary>
		public const int bGenerateEventOnOpen = 0x0288;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0289;

	}

	public class UUmgBaseWidget
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0260;

	}

	public class UBluezoneGpsBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BluezoneGaugeImageBinder = 0x0278;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int BluezoneTimeTextBinder = 0x02A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int PlayerIconImageBinder = 0x02C0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int MovingAnimationBinder = 0x02E8;

		///<summary>TArray<FUmgWidgetBinder_Animation></summary>
		public const int WarningAnimationList = 0x0308;

		///<summary>TArray<FUmgWidgetBinder_Animation></summary>
		public const int ReleasingTextAnimationList = 0x0318;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int EnterNextPlayzoneAnimBinder = 0x0328;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int LeaveNextPlayzoneAnimBinder = 0x0348;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WidgetEmergingAnimBinder = 0x0368;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WidgetVanishingAminBinder = 0x0388;

		///<summary>FName</summary>
		public const int PlayZoneStartParmName = 0x03A8;

		///<summary>FName</summary>
		public const int BluezoneEndParamName = 0x03B0;

		///<summary>FName</summary>
		public const int ColorMultiplyParmName = 0x03B8;

		///<summary>FLinearColor</summary>
		public const int InNextPlayzoneColorMultiply = 0x03C0;

		///<summary>FText</summary>
		public const int WarningTimeTextFormat = 0x03D0;

		///<summary>FText</summary>
		public const int ReleaseTimeText = 0x03E8;

		///<summary>FSequence_Float</summary>
		public const int BluezoneResetSequence = 0x0400;

		///<summary>FSequence_Float</summary>
		public const int PlayzoneResetSequence = 0x04A0;

		///<summary>FSequence_Float</summary>
		public const int PlayerIconResetSequence = 0x0540;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x05E0;

	}

	public class UCharacterStanceBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int StanceIconImageBinder = 0x0278;

		///<summary>FName</summary>
		public const int IconStateParamName = 0x02A0;

	}

	public class UEquipableItemIconBaseWidget
	{
		///<summary>TEnumAsByte<EEquipSlotID></summary>
		public const int EquipSlotID = 0x0278;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0279;

		///<summary>FDurabilityColorSet</summary>
		public const int DurabilityColorSet = 0x0280;

		///<summary>unsigned char:1</summary>
		public const int bUseWrning = 0x0290;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0291;

		///<summary>FFloatInterval</summary>
		public const int WarningRange = 0x0294;

		///<summary>TEnumAsByte<EEquipableItemIconVisibility></summary>
		public const int IconVisibilityType = 0x029C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x029D;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int IconImageBinder = 0x02A0;

		///<summary>FName</summary>
		public const int IconTexParamName = 0x02C8;

		///<summary>FName</summary>
		public const int IconColorParamName = 0x02D0;

		///<summary>FLinearColor</summary>
		public const int DefaultColor = 0x02D8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimBinder = 0x02E8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int NoBagSpaceAnimBinder = 0x0308;

	}

	public class UInteractionBaseWidget
	{
		///<summary>FUmgWidgetBinder_Border</summary>
		public const int MainLayer = 0x0278;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int InteractionMessageTextBinder = 0x0298;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int InteractionMessageTextBgBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int AdditionalTextBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int SuitableWeaponImageBinder = 0x02F8;

		///<summary>float</summary>
		public const int SuitableWeaponImageHeight = 0x0320;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0324;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int KeyImageBinder = 0x0328;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int InteractionKeyTextBinder = 0x0350;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AdditionalMessageBlinkingBinder = 0x0370;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AdditionalMessageNormalBinder = 0x0390;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ShowAnimationBinder = 0x03B0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int HiddenAnimationBinder = 0x03D0;

		///<summary>FUmgWidgetBinder_WidgetSwitcher</summary>
		public const int InteractionInputMethodSwitcherBinder = 0x03F0;

		///<summary>FName</summary>
		public const int InteractionKeyName = 0x0410;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0418;

	}

	public class UKillCountBaseWidget
	{
		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int KillCountTextBinder = 0x0278;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int KillCountEmergingAnimBinder = 0x0298;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int KillCountVanishingAnimBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int IncreasingAnimBinder = 0x02D8;

		///<summary>float</summary>
		public const int IncreasingKillCountDisplayTime = 0x02F8;

		///<summary>int</summary>
		public const int LastKillCount = 0x02FC;

		///<summary>bool</summary>
		public const int bLastWantShow = 0x0300;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0301;

		///<summary>float</summary>
		public const int IncreasingKillCountDisplayStartTime = 0x0304;

	}

	public class ULifeGaugeBaseWidget
	{
		///<summary>UTslHealthGaugeData *</summary>
		public const int LifeGaugeColorData = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int LifeGaugeImageBinder = 0x0280;

		///<summary>FName</summary>
		public const int LifeGaugeRatioValueParamName = 0x02A8;

		///<summary>FName</summary>
		public const int LifeGaugeColorParamName = 0x02B0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HealAmountImageBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int HitEffectLayer = 0x02E0;

		///<summary>FName</summary>
		public const int HealAmountRatioValueParamName = 0x0300;

		///<summary>FName</summary>
		public const int HealAmountRatioSartParamName = 0x0308;

		///<summary>FName</summary>
		public const int HealAmountRatioEndParamName = 0x0310;

		///<summary>FName</summary>
		public const int HealAmountColorParamName = 0x0318;

		///<summary>UCurveFloat *</summary>
		public const int HealEffectTimeCurve = 0x0320;

		///<summary>UClass *</summary>
		public const int HitEffectClass = 0x0328;

		///<summary>UClass *</summary>
		public const int Item_Heal_FirstAid = 0x0330;

		///<summary>UClass *</summary>
		public const int Item_Heal_MedKit = 0x0338;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimationBinder = 0x0340;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int GroggyAnimationBinder = 0x0360;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0380;

	}

	public class ULifeGaugeHitEffectBaseWidget
	{
		///<summary>TArray<FGaugeAlphaCurveType></summary>
		public const int AlphaCurveList = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HitEffectImage = 0x0288;

		///<summary>FName</summary>
		public const int BaseColorParamName = 0x02B0;

		///<summary>FName</summary>
		public const int ColorLerpParamName = 0x02B8;

		///<summary>FName</summary>
		public const int BrightAlphaParamName = 0x02C0;

		///<summary>FName</summary>
		public const int HitEffectAlphaParamName = 0x02C8;

		///<summary>FName</summary>
		public const int HitEffectStartParamName = 0x02D0;

		///<summary>FName</summary>
		public const int HitEffectEndParamName = 0x02D8;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x02E0;

	}

	public class ULifeGaugeTemplateBaseWidget
	{
		///<summary>UTslHealthGaugeData *</summary>
		public const int LifeGaugeColorData = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int LifeGaugeImageBinder = 0x0280;

		///<summary>FName</summary>
		public const int LifeGaugeRatioValueParamName = 0x02A8;

		///<summary>FName</summary>
		public const int LifeGaugeColorParamName = 0x02B0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimationBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BackgroundImageBinder = 0x02D8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0300;

	}

	public class UMapCarePackageItemIconBaseWidget
	{
		///<summary>FUmgWidgetBinder_Border</summary>
		public const int IconImageBorderBinder = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int IconImageBinder = 0x0298;

		///<summary>FName</summary>
		public const int IconStateParamName = 0x02C0;

		///<summary>FName</summary>
		public const int IconColorParamName = 0x02C8;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x02D0;

	}

	public class UMapCharacterIconBaseWidget
	{
		///<summary>FUmgWidgetBinder_Border</summary>
		public const int IconImageBorderBinder = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int IconImageBinder = 0x0298;

		///<summary>FName</summary>
		public const int IconStateParamName = 0x02C0;

		///<summary>FName</summary>
		public const int IconRotationParamName = 0x02C8;

		///<summary>FName</summary>
		public const int IconColorParamName = 0x02D0;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int PlayerNameBoderBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int PlayerNameBinder = 0x02F8;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int ObserverMuzzleFlashBoderBinder = 0x0318;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int ObserverMuzzleFlashWidgetBinder = 0x0338;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int LifeGaugeBorderBinder = 0x0358;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int LifeGaugeWidgetBinder = 0x0378;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AttackedAnimBinder = 0x0398;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int HittedAnimBinder = 0x03B8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int GroggyAnimBinder = 0x03D8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutAnimBinder = 0x03F8;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0418;

		///<summary>UMaterialInterface *</summary>
		public const int PendingIconMaterial = 0x0438;

	}

	public class UMapGridWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MapImageBinder = 0x0278;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int MyMarkerLayerBinder = 0x02A0;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int TeamMarkerLayerBinder = 0x02C0;

		///<summary>UClass *</summary>
		public const int MapMarkerClass = 0x02E0;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int MyMapIconLayerBinder = 0x02E8;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int OtherMapIconLayerBinder = 0x0308;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CarePackageItemIconLayerBinder = 0x0328;

		///<summary>UClass *</summary>
		public const int MapCharacterIconClass = 0x0348;

		///<summary>UClass *</summary>
		public const int MapCarePackageItemIconClass = 0x0350;

		///<summary>UClass *</summary>
		public const int ObserverPlayerIconHitEffectClass = 0x0358;

		///<summary>bool</summary>
		public const int bShowName = 0x0360;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0361;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int RedzoneImageBinder = 0x0368;

		///<summary>FName</summary>
		public const int RedzoneColorParamName = 0x0390;

		///<summary>FColorBlindColorSet</summary>
		public const int RedzoneColorSet = 0x0398;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int ImageSizeBoxBinder = 0x03A8;

		///<summary>FColorBlindColorSet</summary>
		public const int BluezoneColorSet = 0x03C8;

		///<summary>float</summary>
		public const int ZoomLevel = 0x03D8;

		///<summary>float</summary>
		public const int ShowGridZoomLevel = 0x03DC;

		///<summary>UCurveFloat *</summary>
		public const int ViewRatioCurve = 0x03E0;

		///<summary>bool</summary>
		public const int bRectangleViewMode = 0x03E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03E9;

		///<summary>UFont *</summary>
		public const int GridFont = 0x03F0;

		///<summary>FName</summary>
		public const int FontTypeFace = 0x03F8;

		///<summary>TArray<FString></summary>
		public const int GridTextHorizentalArray = 0x0400;

		///<summary>TArray<FString></summary>
		public const int GridTextVerticalArray = 0x0410;

		///<summary>FLinearColor</summary>
		public const int ColorLargeGrid = 0x0420;

		///<summary>FLinearColor</summary>
		public const int ColorSmallGrid = 0x0430;

		///<summary>FLinearColor</summary>
		public const int ColorText = 0x0440;

		///<summary>FLinearColor</summary>
		public const int ColorSafetyZone = 0x0450;

		///<summary>float</summary>
		public const int ThicknessLargeGrid = 0x0460;

		///<summary>float</summary>
		public const int ThicknessSmallGrid = 0x0464;

		///<summary>FLinearColor</summary>
		public const int ColorPoisonGasWarning = 0x0468;

		///<summary>bool</summary>
		public const int bDrawGridLine = 0x0478;

		///<summary>bool</summary>
		public const int bDrawGridText = 0x0479;

		///<summary>bool</summary>
		public const int bDrawNextPlayzoneGuideLine = 0x047A;

		///<summary>bool</summary>
		public const int bUseZOrderSort = 0x047B;

		///<summary>bool</summary>
		public const int bUseTeamMemberColor = 0x047C;

		///<summary>bool</summary>
		public const int bRemoveDeadIcon = 0x047D;

		///<summary>unsigned char[0x12]</summary>
		public const int UnknownData02 = 0x047E;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MatInst = 0x0490;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x0498;

		///<summary>UMapMarkerBaseWidget *</summary>
		public const int MyMapMarker = 0x04B0;

		///<summary>TMap<ATeam *,UMapMarkerBaseWidget * ></summary>
		public const int TeamPlayerMarkers = 0x04B8;

		///<summary>UMapCharacterIconBaseWidget *</summary>
		public const int MyCharacterMapIcon = 0x0508;

		///<summary>TMap<AActor *,UMapCharacterIconBaseWidget * ></summary>
		public const int OtherCharacterMapIcons = 0x0510;

		///<summary>TMap<ACarePackageItem *,UMapCarePackageItemIconBaseWidget * ></summary>
		public const int MapCarePackageItemIcons = 0x0560;

		///<summary>FTimerHandle</summary>
		public const int ReplicatedCharacterListUpdateTimer = 0x05B0;

		///<summary>FTimerHandle</summary>
		public const int ReplicatedCarePackageItemListUpdateTimer = 0x05B8;

		///<summary>TArray<ATslCharacter * ></summary>
		public const int ReplicatedCharacterList = 0x05C0;

		///<summary>TArray<ACarePackageItem * ></summary>
		public const int ReplicatedCarePackageItemList = 0x05D0;

		///<summary>TArray<ATeam * ></summary>
		public const int ShowMarkerOnwerList = 0x05E0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData04 = 0x05F0;

		///<summary>UMaterialInstance *</summary>
		public const int MyOrTeamIconMaterial = 0x0610;

		///<summary>UMaterialInstance *</summary>
		public const int OtherCharacterIconMaterial = 0x0618;

		///<summary>FScriptMulticastDelegate</summary>
		public const int CloseMySelf = 0x0620;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHideOwner = 0x0630;

	}

	public class UMapMarkerBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MarkerImageBinder = 0x0278;

		///<summary>FName</summary>
		public const int MarkerColorParmName = 0x02A0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int MarkerEmergingAnimBinder = 0x02A8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x02C8;

	}

	public class UMiniMapBaseWidget
	{
		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int MapWidgetBinder = 0x0278;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0298;

	}

	public class UTeamMarkWidget
	{
		///<summary>ATeam *</summary>
		public const int TeamMember = 0x0278;

		///<summary>float</summary>
		public const int OffsetZ = 0x0280;

		///<summary>float</summary>
		public const int ImageSize = 0x0284;

		///<summary>float</summary>
		public const int TopMarkGapDistance = 0x0288;

		///<summary>float</summary>
		public const int BottomMarkGapDistance = 0x028C;

		///<summary>float</summary>
		public const int LeftRightMarkGapDistance = 0x0290;

		///<summary>float</summary>
		public const int DiagonalPercent = 0x0294;

		///<summary>float</summary>
		public const int DeadMarkInvisibleTime = 0x0298;

		///<summary>float</summary>
		public const int DeadMarkInvisibleDistance = 0x029C;

		///<summary>float</summary>
		public const int DefaultImageAlpha = 0x02A0;

		///<summary>float</summary>
		public const int DefaultTextAlpha = 0x02A4;

		///<summary>float</summary>
		public const int AmingImageAlpha = 0x02A8;

		///<summary>float</summary>
		public const int ScopingImageAlpha = 0x02AC;

		///<summary>float</summary>
		public const int AmingTextAlpha = 0x02B0;

		///<summary>float</summary>
		public const int ScopingTextAlpha = 0x02B4;

		///<summary>TEnumAsByte<EMarkPosition></summary>
		public const int TeamMarkPosition = 0x02B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x02B9;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int StateSwitcherBinder = 0x02C0;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int PlayerNameTextBinder = 0x02E0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OutLineImageBinder = 0x0300;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int NormalImageBinder = 0x0328;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int DeadImageBinder = 0x0350;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int VehicleImageBinder = 0x0378;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ParachuteImageBinder = 0x03A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int QuitterImageBinder = 0x03C8;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int GroggyCircleBinder = 0x03F0;

		///<summary>UTexture *</summary>
		public const int OutScreenImage = 0x0410;

		///<summary>UTexture *</summary>
		public const int InScreenImage = 0x0418;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0420;

		///<summary>UCameraComponent *</summary>
		public const int Camera = 0x0438;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0440;

	}

	public class UTslAdaptiveCrosshairWidget
	{
		///<summary>TEnumAsByte<EWeaponClass></summary>
		public const int WeaponClass = 0x0278;

		///<summary>bool</summary>
		public const int bIsShowWidget = 0x0279;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x027A;

		///<summary>FColorBlindColorSet</summary>
		public const int ColorBlindColors = 0x0280;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int AdaptiveCrosshair_Binder = 0x0290;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CanvasBase_Binder = 0x02B8;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterCenter_Binder = 0x02D8;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterCrosshair_Binder = 0x02F8;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterD_Binder = 0x0318;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CenterDOT_Binder = 0x0338;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterL_Binder = 0x0360;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterR_Binder = 0x0380;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterU_Binder = 0x03A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_C_Binder = 0x03C0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_C_Gradient_Binder = 0x03E8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_L_Binder = 0x0410;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_R_Binder = 0x0438;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_D_Binder = 0x0460;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_D_Arrow_Binder = 0x0488;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_L_Binder = 0x04B0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_L_Arrow_Binder = 0x04D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_R_Binder = 0x0500;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_R_Arrow_Binder = 0x0528;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_U_Binder = 0x0550;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_U_Arrow_Binder = 0x0578;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_D_Binder = 0x05A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_L_Binder = 0x05C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_R_Binder = 0x05F0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_U_Binder = 0x0618;

	}

	public class UTslAlivePlayerInfoWidget
	{
		///<summary>ATslGameState *</summary>
		public const int CachedTslGS = 0x0278;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int ColorOverlay_Binder = 0x0280;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Warning_Binder = 0x02A0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Increasing_Binder = 0x02C0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Decreasing_Binder = 0x02E0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Default_Binder = 0x0300;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int AdditionalInfo_Binder = 0x0320;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int SurvivorCount_Binder = 0x0340;

		///<summary>bool</summary>
		public const int bIsReplaying = 0x0360;

		///<summary>bool</summary>
		public const int bIsHidden = 0x0361;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0362;

		///<summary>int</summary>
		public const int CurrentCount = 0x0364;

		///<summary>int</summary>
		public const int DisplayCount = 0x0368;

		///<summary>int</summary>
		public const int WhileAnimCount = 0x036C;

	}

	public class UTslKeyDisplayWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeyInputed = 0x0278;

		///<summary>TArray<UTslKeyReceiverWidget * ></summary>
		public const int KeyReceiverWidgets = 0x0288;

		///<summary>TArray<FUmgWidgetBinder_UserWidget></summary>
		public const int KeyReceiverWidgetBinders = 0x0298;

		///<summary>FName</summary>
		public const int InputName = 0x02A8;

		///<summary>FName</summary>
		public const int CategoryName = 0x02B0;

		///<summary>FText</summary>
		public const int DisplayText = 0x02B8;

		///<summary>bool</summary>
		public const int bGamepad = 0x02D0;

		///<summary>bool</summary>
		public const int bAxisInput = 0x02D1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x02D2;

		///<summary>float</summary>
		public const int AxisScale = 0x02D4;

	}

	public class UTslKeyOptionWidget
	{
		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int ScrollBox_Binder = 0x0278;

		///<summary>TArray<UTslKeySettingWidget * ></summary>
		public const int KeySettingWidgets = 0x0298;

		///<summary>UClass *</summary>
		public const int MouseSettingWidgetClass = 0x02A8;

		///<summary>UTslBaseOptionWidget *</summary>
		public const int MouseSettingWidget = 0x02B0;

		///<summary>UClass *</summary>
		public const int KeySettingWidgetClass = 0x02B8;

		///<summary>TArray<FName></summary>
		public const int CategoryOrder = 0x02C0;

	}

	public class UTslKeySettingWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeyChanged = 0x0278;

		///<summary>UClass *</summary>
		public const int KeyDisplayWidgetClass = 0x0288;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int KeyScrollBoxBinder = 0x0290;

		///<summary>TArray<UTslKeyDisplayWidget * ></summary>
		public const int KeyDisplayWidgets = 0x02B0;

		///<summary>FText</summary>
		public const int DisplayText = 0x02C0;

		///<summary>FName</summary>
		public const int CategoryName = 0x02D8;

	}

	public class UTslBoostGaugeWidget
	{
		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge0_21 = 0x0278;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge20_61 = 0x0280;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge60_91 = 0x0288;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge90_101 = 0x0290;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int VanishingAnimBinder = 0x0298;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int EmergingAnimBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost0_20ImageBinder = 0x02F8;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost20_60ImageBinder = 0x0318;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost60_90ImageBinder = 0x0338;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost90_100ImageBinder = 0x0358;

		///<summary>float</summary>
		public const int DisplayingBoost = 0x0378;

		///<summary>bool</summary>
		public const int bIsWarning = 0x037C;

		///<summary>bool</summary>
		public const int bIsVanished = 0x037D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x037E;

	}

	public class UTslBreatheBarWidget
	{
		///<summary>ATslHUD *</summary>
		public const int TslHudCached = 0x0278;

		///<summary>ATslPlayerController *</summary>
		public const int TslPlayerControllerCached = 0x0280;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int BreathGaugeLayer_Binder = 0x0288;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BreathGaugeBG_Binder = 0x02A8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Breathing_Binder = 0x02D0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Drowning_Binder = 0x02F0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Vanishing_Binder = 0x0310;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Emerging_Binder = 0x0330;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Cooldown_Binder = 0x0350;

		///<summary>float</summary>
		public const int BreathRatioDisplay = 0x0370;

		///<summary>float</summary>
		public const int BreathRatio = 0x0374;

		///<summary>float</summary>
		public const int LerpTolerance = 0x0378;

		///<summary>float</summary>
		public const int LerpTime = 0x037C;

		///<summary>FLinearColor</summary>
		public const int BreathImgColor_Less_101 = 0x0380;

		///<summary>FLinearColor</summary>
		public const int BreathImgColor_Less_51 = 0x0390;

		///<summary>FLinearColor</summary>
		public const int BreathImgColor_Less_11 = 0x03A0;

		///<summary>bool</summary>
		public const int bIsVanishing = 0x03B0;

		///<summary>bool</summary>
		public const int bEventBound = 0x03B1;

		///<summary>bool</summary>
		public const int bIsCooldown = 0x03B2;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x03B3;

	}

	public class UTslBuffIconListWidget
	{
		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int RunBuffIconBlock_Binder = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int RunBuffIcon_Binder = 0x0298;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int HealBuffIconBlock_Binder = 0x02C0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HealBuffIcon_Binder = 0x02E0;

		///<summary>UTexture *</summary>
		public const int HealBuffIconTex = 0x0308;

		///<summary>UTexture *</summary>
		public const int RunBuffIconTex = 0x0310;

		///<summary>bool</summary>
		public const int bBoostHealOverTime = 0x0318;

		///<summary>bool</summary>
		public const int bSpeedUp50 = 0x0319;

		///<summary>bool</summary>
		public const int bSpeedUp80 = 0x031A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x031B;

	}

	public class UTslCompassMarkerWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CompassMarkerImageBinder = 0x0278;

		///<summary>int</summary>
		public const int MarkerNumber = 0x02A0;

		///<summary>float</summary>
		public const int XViewSize = 0x02A4;

		///<summary>bool</summary>
		public const int bShow = 0x02A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x02A9;

	}

	public class UTslCompassWidget
	{
		///<summary>UMaterialInterface *</summary>
		public const int MI_Compass = 0x0278;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Compass = 0x0280;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CompassImageBinder = 0x0288;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MarkerImageBinder = 0x02B0;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int MyOverlayBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int TeamOverlayBinder = 0x02F8;

		///<summary>UClass *</summary>
		public const int CompassMarkerWidgetClass = 0x0318;

		///<summary>UTslCompassMarkerWidget *</summary>
		public const int MyCompassMarkerWidget = 0x0320;

		///<summary>TArray<UTslCompassMarkerWidget * ></summary>
		public const int TeamMarkerWidgetOfTeam = 0x0328;

		///<summary>float</summary>
		public const int DivisionLevel = 0x0338;

		///<summary>float</summary>
		public const int Offset = 0x033C;

		///<summary>bool</summary>
		public const int bClockwise = 0x0340;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0341;

		///<summary>float</summary>
		public const int Width = 0x0344;

		///<summary>bool</summary>
		public const int bIsInitilzed = 0x0348;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0349;

	}

	public class UTslGroggyCircleWidget
	{
		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_ProgressCircle = 0x0278;

		///<summary>UMaterialInterface *</summary>
		public const int MI_ProgressCircle = 0x0280;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CircleImageBinder = 0x0288;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CrossImageBinder = 0x02B0;

	}

	public class UTslKeyReceiverWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeyReceived = 0x0278;

		///<summary>FTslInputKey</summary>
		public const int OriginKey = 0x0288;

		///<summary>FKey</summary>
		public const int FirstDownKey = 0x02A8;

		///<summary>FTslInputKey</summary>
		public const int CurrentDownKey = 0x02C0;

		///<summary>FTslInputKey</summary>
		public const int LastDownedKey = 0x02E0;

		///<summary>bool</summary>
		public const int bFocused = 0x0300;

		///<summary>bool</summary>
		public const int bEnableInput = 0x0301;

		///<summary>bool</summary>
		public const int bIsKeyUp = 0x0302;

		///<summary>bool</summary>
		public const int bAxisInput = 0x0303;

		///<summary>float</summary>
		public const int AxisScale = 0x0304;

		///<summary>TArray<FKey></summary>
		public const int MouseButtons = 0x0308;

	}

	public class UTslTeamInfoListWidget
	{
		///<summary>TArray<UTslTeamInfoWidget * ></summary>
		public const int TeamInfoWidgetList = 0x0278;

		///<summary>UClass *</summary>
		public const int TeamInfoWidgetClass = 0x0288;

		///<summary>FUmgWidgetBinder_VerticalBox</summary>
		public const int VerticalBoxBinder = 0x0290;

	}

	public class UTslTeamInfoWidget
	{
		///<summary>bool</summary>
		public const int bBindVoiceChatEvent = 0x0278;

		///<summary>bool</summary>
		public const int bSpeaking = 0x0279;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x027A;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int InfoIconBorderBinder = 0x0280;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int InfoIconBinder = 0x02A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int SpeakingImageBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MarkerImageBinder = 0x02F0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BoostImageBinder = 0x0318;

		///<summary>bool</summary>
		public const int bUdateTeamNameColor = 0x0340;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0341;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int TeamNameBinder = 0x0348;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int OnSpeakAnimBinder = 0x0368;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int HealthGaugeWidgetBinder = 0x0388;

		///<summary>FColorBlindColorSet</summary>
		public const int ColorBlindColorSet = 0x03A8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int TeamMemberColorBinder = 0x03B8;

		///<summary>ATeam *</summary>
		public const int Team = 0x03E0;

	}

	public class UTslTeamWidget
	{
		///<summary>TArray<UTeamMarkWidget * ></summary>
		public const int TeamMarkWidgets = 0x0278;

		///<summary>UClass *</summary>
		public const int TeamMarkWidgetClass = 0x0288;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int TeamMarkerLayerBinder = 0x0290;

	}

	public class UVehicleFuelBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OilGaugeImageBinder = 0x0278;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OilGaugeBgImageBinder = 0x02A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OilArrowImageBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int GaugeBodyBinder = 0x02F0;

		///<summary>FLinearColor</summary>
		public const int NormalColor = 0x0310;

		///<summary>FLinearColor</summary>
		public const int FuelEmptyColor = 0x0320;

		///<summary>FName</summary>
		public const int GaugePramName = 0x0330;

	}

	public class UVehicleSeatInfoBaseWidget
	{
		///<summary>int</summary>
		public const int SeatIndex = 0x0278;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x027C;

		///<summary>FName</summary>
		public const int StateParamName = 0x0280;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int SeatImageBinder = 0x0288;

		///<summary>APawn *</summary>
		public const int CachedVehiclePawn = 0x02B0;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int CachedSeatComponent = 0x02B8;

	}

	public class UVehicleStanceBaseWidget
	{
		///<summary>FUmgWidgetBinder_VerticalBox</summary>
		public const int VehicleIconAreaBinder = 0x0278;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int SpeedTextBinder = 0x0298;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int LifeGaugeWidgetBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int FuelGaugeWidgetBinder = 0x02D8;

		///<summary>APawn *</summary>
		public const int CachedVehiclePawn = 0x02F8;

		///<summary>UUserWidget *</summary>
		public const int CachedVehicleIconWidget = 0x0300;

	}

	public class UVehicleWheelInfoBaseWidget
	{
		///<summary>int</summary>
		public const int WheelIndex = 0x0278;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x027C;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WheelImageBinder = 0x0280;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int PunctureImageBinder = 0x02A8;

		///<summary>ATslWheeledVehicle *</summary>
		public const int CachedVehiclePawn = 0x02D0;

		///<summary>UTslWheeledVehicleMovement *</summary>
		public const int CachedVehicleMovement = 0x02D8;

	}

	public class UVersionInfoBaseWidget
	{
		///<summary>FText</summary>
		public const int WithNickNameFormat = 0x0278;

		///<summary>FText</summary>
		public const int WithOutNickNameFormat = 0x0290;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int VersionInfoTextBinder = 0x02A8;

	}

	public class UWeaponSlotBaseWidget
	{
		///<summary>unsigned char:1</summary>
		public const int bListInSlot = 0x0278;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0279;

		///<summary>int</summary>
		public const int WeaponIndex = 0x027C;

		///<summary>TEnumAsByte<ENoReloadGuideType></summary>
		public const int ListSlotNoReloadGuideType = 0x0280;

		///<summary>unsigned char:1</summary>
		public const int bUseWeaponIcon = 0x0281;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x0282;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WeaponIconImageBinder = 0x0288;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int WeaponIconImageSizeBoxBinder = 0x02B0;

		///<summary>float</summary>
		public const int WeaponIconImageSizeBoxHeight = 0x02D0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x02D4;

		///<summary>FName</summary>
		public const int WeaponIconTextureParmName = 0x02D8;

		///<summary>FName</summary>
		public const int WeaponIconColorParmName = 0x02E0;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Normal = 0x02E8;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Unarmed = 0x02F8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ScaleUpAnimBinder = 0x0308;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ScaleDownAnimBinder = 0x0328;

		///<summary>FColorBlindColorSet</summary>
		public const int WeaponColorSet_NoReload = 0x0348;

		///<summary>unsigned char:1</summary>
		public const int bUseAmmoTextAndIcon = 0x0358;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0359;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponHandsOnLoadedAmmoCountTextBinder = 0x0360;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponListLoadedAmmoCountTextBinder = 0x0380;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AmmoIncreasingAnimBinder = 0x03A0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AmmoDecreasingAnimBinder = 0x03C0;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponHandsOnUnloadedAmmoCountTextBinder = 0x03E0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int UnloadedAmmoIncreasingAnimBinder = 0x0400;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int UnloadedAmmoDecreasingAnimBinder = 0x0420;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WeaponHandsOnAmmoIconBinder = 0x0440;

		///<summary>FName</summary>
		public const int AmmoTexParamName = 0x0468;

		///<summary>unsigned char:1</summary>
		public const int bUseWeaponFiringModeTextBinder = 0x0470;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0471;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponFiringModeTextBinder = 0x0478;

		///<summary>unsigned char:1</summary>
		public const int bZeroingDistancebUseText = 0x0498;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x0499;

		///<summary>FUmgWidgetBinder_VerticalBox</summary>
		public const int ZeroingDistanceBlockBinder = 0x04A0;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int ZeroingdistanceTextBinder = 0x04C0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ZeroDistIncreasingAnimBinder = 0x04E0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ZeroDistDecreasingAnimBinder = 0x0500;

		///<summary>FText</summary>
		public const int ZeroingTextFormat = 0x0520;

		///<summary>FText</summary>
		public const int ZeroingNA = 0x0538;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData06 = 0x0550;

	}

	public class UWeaponSlotHudBaseWidget
	{
		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int CurrentWeaponSlotWidgetBinder = 0x0278;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeInWeaponSlotAnimBinder = 0x0298;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutWeaponSlotAnimBinder = 0x02B8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeInUnarmedWeaponSlotAminBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutUnarmedWeaponSlotAminBinder = 0x02F8;

		///<summary>TArray<FUmgWidgetBinder_UserWidget></summary>
		public const int WeaponSlotWidgetBinderList = 0x0318;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int WeaponSlotListBorderBinder = 0x0328;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeInSlotListAminBinder = 0x0348;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutSlotListAminBinder = 0x0368;

		///<summary>float</summary>
		public const int SlotOffsetMultiply = 0x0388;

		///<summary>float</summary>
		public const int SlotPadding = 0x038C;

		///<summary>FSequence_Float</summary>
		public const int MovingSequence = 0x0390;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0430;

		///<summary>FTimerHandle</summary>
		public const int FinishTimer = 0x0460;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0468;

	}

	public class UTslVehicleCommonComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnBreak = 0x00F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRepair = 0x0108;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDeath = 0x0118;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHealthChange = 0x0128;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFuelChange = 0x0138;

		///<summary>FName</summary>
		public const int SimpleBodyBoneName = 0x0148;

		///<summary>TArray<FName></summary>
		public const int ComplexBodyBoneNames = 0x0150;

		///<summary>FName</summary>
		public const int MainComplexBodyBoneName = 0x0160;

		///<summary>FName</summary>
		public const int ComplexCollisionProfileName = 0x0168;

		///<summary>unsigned char:1</summary>
		public const int bIsDying = 0x0170;

		///<summary>unsigned char:1</summary>
		public const int bIsBroken = 0x0170;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0171;

		///<summary>float</summary>
		public const int Health = 0x0174;

		///<summary>float</summary>
		public const int HealthMax = 0x0178;

		///<summary>float</summary>
		public const int Fuel = 0x017C;

		///<summary>float</summary>
		public const int FuelMax = 0x0180;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0184;

		///<summary>UClass *</summary>
		public const int VehicleExplosionDamageType = 0x0188;

		///<summary>TArray<TEnumAsByte<EDamageTypeCategory>></summary>
		public const int CharacterDamageIgnores = 0x0190;

		///<summary>UClass *</summary>
		public const int VehicleUI = 0x01A0;

	}

	public class UVehicleSurfaceAudioData
	{
		///<summary>UAkAudioEvent *</summary>
		public const int EventIn = 0x0028;

		///<summary>UAkAudioEvent *</summary>
		public const int EventOut = 0x0030;

	}

	public class UTslVehicleEffectComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00F8;

		///<summary>UMeshComponent *</summary>
		public const int MeshComponent = 0x0100;

		///<summary>UAkComponent *</summary>
		public const int EngineSoundComponent = 0x0108;

		///<summary>FVehicleEffectInfo</summary>
		public const int VehicleEffectInfo = 0x0110;

		///<summary>ATslParticle *</summary>
		public const int MufflerEffect = 0x0200;

		///<summary>ATslParticle *</summary>
		public const int Muffler2Effect = 0x0208;

		///<summary>ATslParticle *</summary>
		public const int BoostEffect = 0x0210;

		///<summary>ATslParticle *</summary>
		public const int Boost2Effect = 0x0218;

		///<summary>ATslParticle *</summary>
		public const int DamagedEffect = 0x0220;

		///<summary>ATslParticle *</summary>
		public const int ExplosionEffect = 0x0228;

		///<summary>ATslParticle *</summary>
		public const int FrontTrailEffect = 0x0230;

		///<summary>ATslParticle *</summary>
		public const int RearTrailEffect = 0x0238;

		///<summary>ATslParticle *</summary>
		public const int ThrusterEffect = 0x0240;

		///<summary>ATslParticle *</summary>
		public const int Thruster2Effect = 0x0248;

		///<summary>ATslParticle *</summary>
		public const int FrontFoamLeftEffect = 0x0250;

		///<summary>ATslParticle *</summary>
		public const int FrontFoamRightEffect = 0x0258;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData01 = 0x0260;

		///<summary>float</summary>
		public const int TrailSpeedThreshold = 0x027C;

		///<summary>float</summary>
		public const int FrontFoamSpawnThreshold = 0x0280;

		///<summary>bool</summary>
		public const int bRPMOverride = 0x0284;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData02 = 0x0285;

		///<summary>bool</summary>
		public const int bUseNewSurfaceAudio = 0x02E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x02E9;

		///<summary>TArray<int></summary>
		public const int MeasuredWheelIndices = 0x02F0;

		///<summary>TArray<int></summary>
		public const int MeasuredWheelIndicesSlip = 0x0300;

		///<summary>float</summary>
		public const int SuspenionOffsetForContact = 0x0310;

		///<summary>float</summary>
		public const int SurfaceActivationValue = 0x0314;

		///<summary>float</summary>
		public const int SurfaceDeactivationValue = 0x0318;

		///<summary>float</summary>
		public const int DT_Multiplier = 0x031C;

		///<summary>float</summary>
		public const int MinVelocityForSurfaceCheck = 0x0320;

		///<summary>float</summary>
		public const int MinSlip = 0x0324;

		///<summary>float</summary>
		public const int MinSpin = 0x0328;

		///<summary>int</summary>
		public const int VelocityInterpSpeed = 0x032C;

		///<summary>int</summary>
		public const int SlipInterpSpeed = 0x0330;

		///<summary>int</summary>
		public const int SpinInterpSpeed = 0x0334;

		///<summary>bool</summary>
		public const int bDebugVisualizedMeasuredWheels = 0x0338;

		///<summary>unsigned char[0x77]</summary>
		public const int UnknownData04 = 0x0339;

		///<summary>float</summary>
		public const int ApplyDestroyedMaterialDelay = 0x0400;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x0404;

	}

	public class UTslVehicleHitComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCharacterHit = 0x00F8;

		///<summary>UMeshComponent *</summary>
		public const int MeshComponent = 0x0108;

		///<summary>float</summary>
		public const int HitCharacterDuration = 0x0110;

		///<summary>unsigned char[0x54]</summary>
		public const int UnknownData00 = 0x0114;

		///<summary>float</summary>
		public const int LeaveCharacterIgnoreDuration = 0x0168;

		///<summary>float</summary>
		public const int CharacterHitMinimumVehicleSpeed = 0x016C;

		///<summary>float</summary>
		public const int CharacterDamageVelocityUnitMultiplier = 0x0170;

		///<summary>float</summary>
		public const int CharacterDamageMassUnitMultiplier = 0x0174;

		///<summary>UCurveFloat *</summary>
		public const int CharacterDamageSpeedCurve = 0x0178;

		///<summary>UCurveFloat *</summary>
		public const int CharacterDamageMassCurve = 0x0180;

		///<summary>float</summary>
		public const int MinimumCharacterDamage = 0x0188;

		///<summary>float</summary>
		public const int CharacterLaunchSpeedMultiplier = 0x018C;

		///<summary>float</summary>
		public const int MinimumCharacterLaunchSpeed = 0x0190;

		///<summary>float</summary>
		public const int PhysicsImpulseMultiplier = 0x0194;

		///<summary>UPhysicalMaterial *</summary>
		public const int VoidPhysicalMaterial = 0x0198;

		///<summary>float</summary>
		public const int PhysicsImpactModifier = 0x01A0;

		///<summary>float</summary>
		public const int PhysicsImpactModifierUpsideDown = 0x01A4;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorption = 0x01A8;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorptionUpsideDown = 0x01AC;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorptionRider = 0x01B0;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorptionRiderUpsideDown = 0x01B4;

		///<summary>float</summary>
		public const int PhysicsImpactVehicleDamageMultiplier = 0x01B8;

		///<summary>float</summary>
		public const int PhysicsImpactRiderDamageMultiplier = 0x01BC;

		///<summary>UClass *</summary>
		public const int VehicleHitDamageType = 0x01C0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01C8;

		///<summary>float</summary>
		public const int ExplosionBaseDamage = 0x01CC;

		///<summary>float</summary>
		public const int ExplosionMinimumDamage = 0x01D0;

		///<summary>float</summary>
		public const int ExplosionRadiusInner = 0x01D4;

		///<summary>float</summary>
		public const int ExplosionRadiusOuter = 0x01D8;

		///<summary>float</summary>
		public const int ExplosionDamageFalloff = 0x01DC;

		///<summary>UClass *</summary>
		public const int ExplosionDamageType = 0x01E0;

		///<summary>TEnumAsByte<ECollisionChannel></summary>
		public const int ExplosionDamagePreventionChannel = 0x01E8;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData02 = 0x01E9;

		///<summary>float</summary>
		public const int ImpulseLimitationSpeedThreshold = 0x01F8;

		///<summary>float</summary>
		public const int CollectTime = 0x01FC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x0200;

		///<summary>TArray<FVehicleDebugHit></summary>
		public const int DebugHitHistory = 0x0210;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0220;

	}

	public class UTslVehicleSeatComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRide = 0x00F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLeave = 0x0108;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDriverRide = 0x0118;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDriverLeave = 0x0128;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPostDriverRide = 0x0138;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPostDriverLeave = 0x0148;

		///<summary>TArray<FVehicleSeatInfo></summary>
		public const int SeatInfos = 0x0158;

		///<summary>TArray<UVehicleSeatInteractionComponent * ></summary>
		public const int Seats = 0x0168;

		///<summary>bool</summary>
		public const int bUseSeatCamera = 0x0178;

		///<summary>bool</summary>
		public const int bDoFlipCheck = 0x0179;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x017A;

		///<summary>float</summary>
		public const int FlipForce = 0x017C;

		///<summary>bool</summary>
		public const int bDoEntryAngleCheck = 0x0180;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0181;

		///<summary>float</summary>
		public const int MinEntryAngle = 0x0184;

		///<summary>bool</summary>
		public const int bDampenPlayerVelocityOnLeave = 0x0188;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0189;

		///<summary>float</summary>
		public const int OnLeaveVelocityMultiplier = 0x018C;

		///<summary>bool</summary>
		public const int bUseActiveStabilize = 0x0190;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0191;

		///<summary>TWeakObjectPtr<ATslCharacter></summary>
		public const int LastDriver = 0x0194;

		///<summary>unsigned char[0x5C]</summary>
		public const int UnknownData04 = 0x019C;

	}

	public class UTslVehicleSyncComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSyncHit = 0x00F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0108;

		///<summary>float</summary>
		public const int MinCorrectionInterval = 0x010C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0110;

		///<summary>float</summary>
		public const int SendingToServerIntervalAtClient = 0x0114;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0118;

		///<summary>float</summary>
		public const int SendingReliableHitToServerIntervalAtClient = 0x0120;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0124;

		///<summary>float</summary>
		public const int AllowedMaxDistanceSqAtServer = 0x0128;

		///<summary>float</summary>
		public const int StationaryCorrectionIntervalAtClient = 0x012C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x0130;

		///<summary>float</summary>
		public const int StationaryCorrectionSpeedThresholdSq = 0x0134;

		///<summary>float</summary>
		public const int StationaryCorrectionThresholdDistanceSq = 0x0138;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData05 = 0x013C;

	}

	public class UTslVehicleTempComponent
	{
		///<summary>float</summary>
		public const int TickInterval = 0x00F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x00FC;

	}

	public class UTslViewTargetTempComponent
	{
		///<summary>TArray<FTempComponentInfo></summary>
		public const int ComponentInfos = 0x00F8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0108;

	}

	public class ATslWeapon_Trajectory
	{
		///<summary>float</summary>
		public const int TrajectoryGravityZ = 0x0A20;

		///<summary>float</summary>
		public const int RecoilSpreadScale = 0x0A24;

		///<summary>bool</summary>
		public const int FireAtViewPoint = 0x0A28;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0A29;

		///<summary>float</summary>
		public const int DefaultTimerFrequency = 0x0A2C;

		///<summary>float</summary>
		public const int CrouchSpreadModifier = 0x0A30;

		///<summary>float</summary>
		public const int ProneSpreadModifier = 0x0A34;

		///<summary>float</summary>
		public const int WalkSpread = 0x0A38;

		///<summary>float</summary>
		public const int RunSpread = 0x0A3C;

		///<summary>float</summary>
		public const int JumpSpread = 0x0A40;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0A44;

		///<summary>FTrajectoryWeaponData</summary>
		public const int TrajectoryConfig = 0x0A48;

		///<summary>FRecoilInfo</summary>
		public const int RecoilInfo = 0x0AA8;

		///<summary>UClass *</summary>
		public const int ImpactTemplate = 0x0B10;

		///<summary>UParticleSystem *</summary>
		public const int TrailFX = 0x0B18;

		///<summary>FName</summary>
		public const int TrailTargetParam = 0x0B20;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x0B28;

		///<summary>float</summary>
		public const int WeaponSpread = 0x0B40;

		///<summary>float</summary>
		public const int RecoilModifier_Stand = 0x0B44;

		///<summary>float</summary>
		public const int RecoilModifier_Crouch = 0x0B48;

		///<summary>float</summary>
		public const int RecoilModifier_Prone = 0x0B4C;

		///<summary>float</summary>
		public const int VerticalRecoilMin = 0x0B50;

		///<summary>float</summary>
		public const int VerticalRecoilMax = 0x0B54;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData03 = 0x0B58;

	}

	public class ATslWeapon_Melee
	{
		///<summary>UAkAudioEvent *</summary>
		public const int AttackSoundAk = 0x07A8;

		///<summary>TArray<FMeleeWeaponAnim></summary>
		public const int AttackAnims = 0x07B0;

		///<summary>float</summary>
		public const int Damage = 0x07C0;

		///<summary>float</summary>
		public const int WeaponImpact = 0x07C4;

		///<summary>UClass *</summary>
		public const int DamageType = 0x07C8;

		///<summary>TEnumAsByte<EHitCheckType></summary>
		public const int HitCheckType = 0x07D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x07D1;

		///<summary>float</summary>
		public const int AllowedHitRangeLeeway = 0x07D4;

		///<summary>UClass *</summary>
		public const int ImpactTemplate = 0x07D8;

		///<summary>UCapsuleComponent *</summary>
		public const int HitCapsuleComponent = 0x07E0;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData01 = 0x07E8;

	}

	public class ATslWeapon_Throwable
	{
		///<summary>FThrowableWeaponData</summary>
		public const int ThrowableConfig = 0x07A8;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0840;

		///<summary>TEnumAsByte<EThrowableState></summary>
		public const int ThrowableState = 0x0858;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0859;

		///<summary>FName</summary>
		public const int ThrowWeaponSocketName = 0x0860;

		///<summary>FVector</summary>
		public const int PawnMotionContributionMultiplier = 0x0868;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0874;

		///<summary>ATslParticle *</summary>
		public const int PinOffEffect = 0x0878;

		///<summary>AActor *</summary>
		public const int RingAttachment = 0x0880;

	}

	public class ATslMotorbikeVehicle
	{
		///<summary>bool</summary>
		public const int bUseKickstandStabilize = 0x06D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x06D1;

		///<summary>float</summary>
		public const int MinSuspensionOffsetForContact = 0x06D4;

		///<summary>bool</summary>
		public const int bStabilizeOnServer = 0x06D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x06D9;

		///<summary>float</summary>
		public const int KickstandStabilizeDamping = 0x06DC;

		///<summary>float</summary>
		public const int KickstandMaxAngVelocity = 0x06E0;

		///<summary>float</summary>
		public const int DefaultAngularDamping = 0x06E4;

		///<summary>float</summary>
		public const int KickstandStabilizeTorqueScalar = 0x06E8;

		///<summary>float</summary>
		public const int KickstandStabilizeRollScalar = 0x06EC;

		///<summary>float</summary>
		public const int KickstandStabilizeRollMinRange = 0x06F0;

		///<summary>float</summary>
		public const int MinVelocityForStabilizeOverride = 0x06F4;

		///<summary>FName</summary>
		public const int StabilizeBone_Low = 0x06F8;

		///<summary>FName</summary>
		public const int StabilizeBone_High = 0x0700;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Roll = 0x0708;

		///<summary>UCurveFloat *</summary>
		public const int Curve_RollReturn = 0x0710;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Steer = 0x0718;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Yaw = 0x0720;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Torque = 0x0728;

		///<summary>FVector</summary>
		public const int StabStaticVector = 0x0730;

		///<summary>FVector</summary>
		public const int StabStaticVectorKickstand = 0x073C;

		///<summary>FVector</summary>
		public const int StabNoDriverVector = 0x0748;

		///<summary>FVector2D</summary>
		public const int StabX_Velocity_In = 0x0754;

		///<summary>FVector2D</summary>
		public const int StabX_Velocity_Out = 0x075C;

		///<summary>FVector2D</summary>
		public const int StabX_Pitch_In = 0x0764;

		///<summary>FVector2D</summary>
		public const int StabX_Pitch_Out = 0x076C;

		///<summary>FVector2D</summary>
		public const int StabZ_Velocity_In = 0x0774;

		///<summary>FVector2D</summary>
		public const int StabZ_Velocity_Out = 0x077C;

		///<summary>FVector2D</summary>
		public const int StabZ_Roll_In = 0x0784;

		///<summary>FVector2D</summary>
		public const int StabZ_Roll_Out = 0x078C;

		///<summary>FVector2D</summary>
		public const int StabZ_Pitch_In = 0x0794;

		///<summary>FVector2D</summary>
		public const int StabZ_Pitch_Out = 0x079C;

		///<summary>FVector2D</summary>
		public const int StabTorque_In = 0x07A4;

		///<summary>FVector2D</summary>
		public const int StabTorque_Out = 0x07AC;

		///<summary>float</summary>
		public const int StabTorque_ForceScalar = 0x07B4;

		///<summary>FVector2D</summary>
		public const int StabTorque_Pitch_In = 0x07B8;

		///<summary>FVector2D</summary>
		public const int StabTorque_Pitch_Out = 0x07C0;

		///<summary>bool</summary>
		public const int bUseFlipping = 0x07C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x07C9;

		///<summary>float</summary>
		public const int FlippingForce = 0x07CC;

		///<summary>float</summary>
		public const int InitialFlipTimer = 0x07D0;

		///<summary>float</summary>
		public const int MinVelocityForFlipping = 0x07D4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x07D8;

		///<summary>float</summary>
		public const int ContactAlpha_RiseRate = 0x07DC;

		///<summary>float</summary>
		public const int ContactAlpha_FallRate = 0x07E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x07E4;

		///<summary>UCurveFloat *</summary>
		public const int Curve_EngineAudio = 0x07E8;

		///<summary>FVector2D</summary>
		public const int AirControlF_VelMap = 0x07F0;

		///<summary>FVector2D</summary>
		public const int AirControlB_VelMap = 0x07F8;

		///<summary>FVector2D</summary>
		public const int AirControlL_VelMap = 0x0800;

		///<summary>FVector2D</summary>
		public const int AirControlR_VelMap = 0x0808;

		///<summary>FVector2D</summary>
		public const int AirControlQ_VelMap = 0x0810;

		///<summary>FVector2D</summary>
		public const int AirControlE_VelMap = 0x0818;

		///<summary>float</summary>
		public const int AirControl_FB_Torque = 0x0820;

		///<summary>float</summary>
		public const int AirControl_LR_Torque = 0x0824;

		///<summary>float</summary>
		public const int AirControl_QE_Torque = 0x0828;

		///<summary>bool</summary>
		public const int bStabilizeInAir = 0x082C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x082D;

		///<summary>float</summary>
		public const int StabilizeAirPercentage = 0x0830;

		///<summary>unsigned char[0x31]</summary>
		public const int UnknownData06 = 0x0834;

		///<summary>bool</summary>
		public const int bKickstandStabilize = 0x0865;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData07 = 0x0866;

	}

	public class ATslMotorbikeVehicle_Sidecar
	{
		///<summary>float</summary>
		public const int Sidecar_COM_Y_Left = 0x0868;

		///<summary>float</summary>
		public const int Sidecar_COM_Y_Right = 0x086C;

		///<summary>FVector</summary>
		public const int Sidecar_StabilizerHigh_StaticCOM = 0x0870;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x087C;

	}

	public class UTslWheelEffectType
	{
		///<summary>UAkAudioEvent *</summary>
		public const int Sound = 0x0028;

		///<summary>UClass *</summary>
		public const int DefaultFxClass = 0x0030;

		///<summary>UClass *</summary>
		public const int ConcreteFxClass = 0x0038;

		///<summary>UClass *</summary>
		public const int DirtFxClass = 0x0040;

		///<summary>UClass *</summary>
		public const int WaterFxClass = 0x0048;

		///<summary>UClass *</summary>
		public const int MetalFxClass = 0x0050;

		///<summary>UClass *</summary>
		public const int WoodFxClass = 0x0058;

		///<summary>UClass *</summary>
		public const int GrassFxClass = 0x0060;

		///<summary>UClass *</summary>
		public const int GlassFxClass = 0x0068;

		///<summary>UClass *</summary>
		public const int RockFxClass = 0x0070;

		///<summary>UClass *</summary>
		public const int SandFxClass = 0x0078;

		///<summary>float</summary>
		public const int DefaultMinSpeed = 0x0080;

		///<summary>float</summary>
		public const int ConcreteMinSpeed = 0x0084;

		///<summary>float</summary>
		public const int DirtMinSpeed = 0x0088;

		///<summary>float</summary>
		public const int WaterMinSpeed = 0x008C;

		///<summary>float</summary>
		public const int MetalMinSpeed = 0x0090;

		///<summary>float</summary>
		public const int WoodMinSpeed = 0x0094;

		///<summary>float</summary>
		public const int GrassMinSpeed = 0x0098;

		///<summary>float</summary>
		public const int GlassMinSpeed = 0x009C;

		///<summary>float</summary>
		public const int RockMinSpeed = 0x00A0;

		///<summary>float</summary>
		public const int SandMinSpeed = 0x00A4;

	}

	public class UVehicleRiderComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00F8;

		///<summary>int</summary>
		public const int SeatIndex = 0x0100;

		///<summary>unsigned char[0x3C]</summary>
		public const int UnknownData01 = 0x0104;

		///<summary>APawn *</summary>
		public const int LastVehiclePawn = 0x0140;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0148;

	}

	public class ATslVehicleSeatActor
	{
		///<summary>TEnumAsByte<ERiderType></summary>
		public const int RiderType = 0x0428;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0429;

	}

	public class UVivoxResponse
	{
		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USignInResponse
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UChannelResponse
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UKeyRevokeResponse
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UKeyAddResponse
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UVivoxBaseComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnVoiceChatUpdated = 0x0100;

		///<summary>FVivoxConnectionInfo</summary>
		public const int ConnectionInfo = 0x0110;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0130;

		///<summary>FString</summary>
		public const int TeamChannelUrl = 0x0140;

		///<summary>FString</summary>
		public const int GlobalChannelUrl = 0x0150;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0160;

		///<summary>float</summary>
		public const int ResetFailureDelaySeconds = 0x0164;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x0168;

		///<summary>float</summary>
		public const int UpdatePositionIntervalSeconds = 0x0180;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x0184;

		///<summary>float</summary>
		public const int UserInputVolumeModifier = 0x0190;

		///<summary>float</summary>
		public const int UserOutputVolumeModifier = 0x0194;

	}

	public class UVivoxComponent
	{
		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData00 = 0x0198;

		///<summary>float</summary>
		public const int SuddenMovementDistance = 0x01C4;

		///<summary>float</summary>
		public const int SuddenMovementModifier = 0x01C8;

		///<summary>float</summary>
		public const int SuddenMovementModifierDuration = 0x01CC;

		///<summary>float</summary>
		public const int SuddenMovementModifierRestoreDuration = 0x01D0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01D4;

		///<summary>bool</summary>
		public const int bEnableObserverTeamChat = 0x01D8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x01D9;

	}

	public class UVivoxLobbyComponent
	{
		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x0198;

	}

	public class UVivoxManager
	{
		///<summary>UWorld *</summary>
		public const int World = 0x0028;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0030;

		///<summary>FVivoxConnectionInfo</summary>
		public const int ConnectionInfo = 0x0038;

		///<summary>bool</summary>
		public const int bUseEphmeralChannel = 0x0058;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0059;

		///<summary>FString</summary>
		public const int AuthId = 0x0060;

		///<summary>FString</summary>
		public const int AuthPwd = 0x0070;

		///<summary>int64_t</summary>
		public const int AccessTokenExpirationTime = 0x0080;

		///<summary>FString</summary>
		public const int Issuer = 0x0088;

		///<summary>FString</summary>
		public const int Key = 0x0098;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x00A8;

		///<summary>USignInResponse *</summary>
		public const int SignIn = 0x00B8;

		///<summary>UKeyAddResponse *</summary>
		public const int KeyAdd = 0x00C0;

		///<summary>UKeyRevokeResponse *</summary>
		public const int KeyRevoke = 0x00C8;

		///<summary>TArray<UChannelResponse * ></summary>
		public const int Channels = 0x00D0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x00E0;

		///<summary>TArray<ATslPlayerController * ></summary>
		public const int PlayerControllers = 0x00F0;

		///<summary>int</summary>
		public const int ProximalMaxRange = 0x0100;

		///<summary>int</summary>
		public const int ProximalClampingDistance = 0x0104;

		///<summary>int</summary>
		public const int ProximalDistanceModel = 0x0108;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x010C;

	}

	public class UWeaponAnimInfoComponent
	{
		///<summary>FName</summary>
		public const int WeaponAttachPointPistol = 0x00F8;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifle = 0x0100;

		///<summary>FName</summary>
		public const int WeaponAttachPointThrowable = 0x0108;

		///<summary>FName</summary>
		public const int WeaponAttachPointMelee = 0x0110;

		///<summary>USkeletalMeshComponent *</summary>
		public const int MeshComponent = 0x0118;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Primary = 0x0120;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Secondary = 0x0128;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Sidearm = 0x0130;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Melee = 0x0138;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Thrown = 0x0140;

		///<summary>FName</summary>
		public const int WeaponLeftHandIKAttachPoint = 0x0148;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0150;

	}

	public class UCharacterWeaponAnimInfoComponent
	{
		///<summary>FName</summary>
		public const int WeaponAttachPointPistolDriving = 0x0158;

		///<summary>FName</summary>
		public const int WeaponAttachPointPistolSitting = 0x0160;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifleDriving = 0x0168;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifleSitting = 0x0170;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifleAim = 0x0178;

		///<summary>FName</summary>
		public const int WeaponAttachPointThrowableDriving = 0x0180;

		///<summary>FName</summary>
		public const int WeaponAttachPointMeleeDriving = 0x0188;

	}

	public class UWeaponClone
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>ATslWeapon *</summary>
		public const int ClonedWeapon = 0x0038;

	}

}
