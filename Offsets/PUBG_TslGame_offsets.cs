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
		public const int MainUMGHudClass = 0x0498;

		///<summary>TArray&lt;UAkAudioBank * &gt;</summary>
		public const int AutoLoadAudioBanks = 0x04A0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x04B0;

		///<summary>TArray&lt;UActionInputEventHolder * &gt;</summary>
		public const int ActionInputEventHolderArray = 0x04B8;

		///<summary>TMap&lt;FString,FTslWidgetState&gt;</summary>
		public const int WidgetStateMap = 0x04C8;

		///<summary>UUserWidget *</summary>
		public const int MainUMGHud = 0x0518;

		///<summary>TArray&lt;UBlockInputUserWidget * &gt;</summary>
		public const int BlockInputWidgetList = 0x0520;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int UseMouseWidgetStack = 0x0530;

		///<summary>bool</summary>
		public const int IsTimelineMaximize = 0x0540;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0541;

	}

	public class AAirborneEjectionArea
	{
		///<summary>USphereComponent *</summary>
		public const int SphereComponent = 0x03B0;

		///<summary>float</summary>
		public const int Radius = 0x03B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03BC;

	}

	public class UAnimDB
	{
		///<summary>FAnimInfo</summary>
		public const int Stand_Info = 0x0030;

		///<summary>FAnimInfo</summary>
		public const int Crouch_Info = 0x0098;

		///<summary>FAnimInfo</summary>
		public const int Prone_Info = 0x0100;

		///<summary>float</summary>
		public const int BlendSpaceSpeed_Walk = 0x0168;

		///<summary>float</summary>
		public const int BlendSpaceSpeed_Run = 0x016C;

		///<summary>float</summary>
		public const int BlendSpaceSpeed_Sprint = 0x0170;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0174;

	}

	public class UAnimNotify_AkEvent_Advanced
	{
		///<summary>UAkAudioEvent *</summary>
		public const int AkAudioEvent = 0x0038;

		///<summary>FString</summary>
		public const int EventName = 0x0040;

		///<summary>FName</summary>
		public const int AttachName = 0x0050;

		///<summary>FVector</summary>
		public const int CustomRelativeLocation = 0x0058;

		///<summary>bool</summary>
		public const int bFollow = 0x0064;

		///<summary>bool</summary>
		public const int bUseMinActivationDistance = 0x0065;

		///<summary>bool</summary>
		public const int bUseActivationDistanceByAttenuation = 0x0066;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0067;

		///<summary>float</summary>
		public const int MinActivationDistance = 0x0068;

		///<summary>bool</summary>
		public const int bPlayCameraShake = 0x006C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x006D;

		///<summary>UClass *</summary>
		public const int CameraShake = 0x0070;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int AffectedCameras = 0x0078;

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
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnStaticMeshLoaded = 0x09E0;

		///<summary>TAssetPtr&lt;UStaticMesh&gt;</summary>
		public const int StaticMeshAsset = 0x09F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0A10;

		///<summary>UStaticMesh *</summary>
		public const int ErrorStaticMesh = 0x0A18;

		///<summary>FName</summary>
		public const int ClientCollisionProfileNameOverride = 0x0A20;

		///<summary>TAssetPtr&lt;UStaticMesh&gt;</summary>
		public const int PendingStaticMeshAsset = 0x0A28;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0A48;

	}

	public class UBluezoneInOutComponent
	{
		///<summary>unsigned char[0xE0]</summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class UBluezoneInOutSoundEffectComponent
	{
		///<summary>UAkAudioEvent *</summary>
		public const int BluezoneInSoundAk = 0x01E0;

		///<summary>UAkAudioEvent *</summary>
		public const int BluezoneOutSoundAk = 0x01E8;

	}

	public class UBTDecorator_HasLoSTo
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int EnemyKey = 0x0068;

	}

	public class ATslBuff
	{
		///<summary>FName</summary>
		public const int OverlapId = 0x03B0;

		///<summary>EBuffOverlapSolveMethod</summary>
		public const int OverlapSolveMethod = 0x03B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03B9;

		///<summary>float</summary>
		public const int BuffTickInterval = 0x03BC;

		///<summary>float</summary>
		public const int BuffTickFirstDelay = 0x03C0;

		///<summary>float</summary>
		public const int BuffDuration = 0x03C4;

		///<summary>bool</summary>
		public const int Infinite = 0x03C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03C9;

		///<summary>FName</summary>
		public const int AttachSocket = 0x03D0;

		///<summary>UClass *</summary>
		public const int AttachServerPaticleClass = 0x03D8;

		///<summary>bool</summary>
		public const int IsDebuff = 0x03E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x03E1;

		///<summary>UBuffComponet *</summary>
		public const int OwnerBuffComponent = 0x03E8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x03F0;

		///<summary>ATslServerParticle *</summary>
		public const int AttachedServerPaticle = 0x0400;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x0408;

		///<summary>bool</summary>
		public const int bClientNotifyStartBuff = 0x040C;

		///<summary>bool</summary>
		public const int bClientNotifyStopBuff = 0x040D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData05 = 0x040E;

	}

	public class UBuffComponet
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x01E0;

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

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HideMaterialsWhenCameraIsInHead = 0x0068;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HideMaterialsOnScopeMode = 0x0078;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int HideMaterialsOnHighScopeMode = 0x0088;

	}

	public class UTslWheelSuspensionAudioData
	{
		///<summary>TMap&lt;ELandingSoundSwitchState,float&gt;</summary>
		public const int LandingSoundSwitchesPerHorVelocity = 0x0030;

	}

	public class UCastComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCancelCast = 0x01E8;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x01F8;

	}

	public class UCharacterBreathComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>float</summary>
		public const int Breath = 0x01E8;

		///<summary>float</summary>
		public const int BreathMax = 0x01EC;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtStand = 0x01F0;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtCrouch = 0x01FC;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtProne = 0x0208;

		///<summary>FVector</summary>
		public const int BreathPointOffsetAtGroggy = 0x0214;

		///<summary>UClass *</summary>
		public const int RestorationBuff = 0x0220;

		///<summary>UClass *</summary>
		public const int ApneaDebuff = 0x0228;

		///<summary>UClass *</summary>
		public const int HoldBreathDebuff = 0x0230;

		///<summary>float</summary>
		public const int MinimumBreathStartHoldingBreath = 0x0238;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x023C;

		///<summary>UClass *</summary>
		public const int SprintDebuff = 0x0240;

		///<summary>float</summary>
		public const int MinimumBreathStartSprinting = 0x0248;

		///<summary>unsigned char[0x24]</summary>
		public const int UnknownData02 = 0x024C;

	}

	public class ACharacterStudio
	{
		///<summary>USpringArmComponent *</summary>
		public const int SpringArmComponent = 0x03B0;

		///<summary>UCameraComponent *</summary>
		public const int CameraComponent = 0x03B8;

		///<summary>USceneCaptureComponent2D *</summary>
		public const int SceneCaptureComponent = 0x03C0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int TextureTarget = 0x03C8;

		///<summary>bool</summary>
		public const int bUseDynamicResolution = 0x03D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03D1;

		///<summary>float</summary>
		public const int MaxViewDistance = 0x03D4;

		///<summary>UClass *</summary>
		public const int MaleCharacterProxyClass = 0x03D8;

		///<summary>UClass *</summary>
		public const int FemaleCharacterProxyClass = 0x03E0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03E8;

		///<summary>FTransform</summary>
		public const int CharacterInitialTransform = 0x03F0;

		///<summary>ATslCharacterProxy *</summary>
		public const int CharacterProxy = 0x0420;

		///<summary>USceneComponent *</summary>
		public const int CharacterRotationPivot = 0x0428;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int SceneCaptureMaterial = 0x0430;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0438;

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
		public const int OnShowReplayTimeline = 0x06F0;

		///<summary>unsigned char[0x148]</summary>
		public const int UnknownData00 = 0x0700;

		///<summary>unsigned char:1</summary>
		public const int UnknownData01 = 0x0848;

		///<summary>unsigned char:1</summary>
		public const int bIsSpectated = 0x0848;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0849;

		///<summary>FVector</summary>
		public const int CameraPeekLeftMove = 0x084C;

		///<summary>FVector</summary>
		public const int CameraPeekRightMove = 0x0858;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x0864;

		///<summary>ECameraViewBehaviour</summary>
		public const int CameraViewBehaviour = 0x0874;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData04 = 0x0875;

		///<summary>FVector_NetQuantizeNormal</summary>
		public const int SpectatorAccumViewRotation = 0x0884;

		///<summary>EObserverAuthorityType</summary>
		public const int ObserverAuthorityType = 0x0890;

		///<summary>unsigned char[0x37]</summary>
		public const int UnknownData05 = 0x0891;

		///<summary>UActorComponent *</summary>
		public const int InteractionTargetComponent = 0x08C8;

		///<summary>ATslCharacter *</summary>
		public const int SpectatorViewCharacter = 0x08D0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData06 = 0x08D8;

		///<summary>ATslAchievement *</summary>
		public const int Achievement = 0x08E8;

		///<summary>UMeshComponent *</summary>
		public const int SpectatorScopeMesh = 0x08F0;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData07 = 0x08F8;

		///<summary>TArray&lt;FNearClippingLevelOverZ&gt;</summary>
		public const int NearClippingLevelsOverZ = 0x0958;

		///<summary>float</summary>
		public const int MaxValidPing = 0x0968;

		///<summary>float</summary>
		public const int DefaultFOV = 0x096C;

		///<summary>float</summary>
		public const int InteractGamepadHoldTime = 0x0970;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x0974;

		///<summary>UVivoxComponent *</summary>
		public const int VivoxComponent = 0x0978;

		///<summary>TArray&lt;ATeam * &gt;</summary>
		public const int Teams = 0x0980;

		///<summary>TArray&lt;TWeakObjectPtr&lt;ATslCharacter&gt;&gt;</summary>
		public const int ReplicateTeamMembers = 0x0990;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData09 = 0x09A0;

		///<summary>TArray&lt;TWeakObjectPtr&lt;ATslCharacter&gt;&gt;</summary>
		public const int ReplicateCharacter = 0x09F0;

		///<summary>TArray&lt;TWeakObjectPtr&lt;ACarePackageItem&gt;&gt;</summary>
		public const int ReplicateCarePackageItemList = 0x0A00;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData10 = 0x0A10;

		///<summary>float</summary>
		public const int DeathResultDelaySeconds = 0x0A30;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData11 = 0x0A34;

		///<summary>FPingPongSummary</summary>
		public const int PingPongSummary = 0x0AC4;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData12 = 0x0AD0;

		///<summary>bool</summary>
		public const int bUseTPAntibotClient = 0x0B30;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData13 = 0x0B31;

	}

	public class ADeployedItem
	{
		///<summary>UClass *</summary>
		public const int ItemType = 0x03B0;

		///<summary>int</summary>
		public const int StackCount = 0x03B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03BC;

		///<summary>USceneComponent *</summary>
		public const int SceneComponent = 0x03C0;

	}

	public class ASubActor
	{
		///<summary>ATslCharacter *</summary>
		public const int NetOwnerCharacter = 0x03B0;

	}

	public class AItemSlotContainer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B8;

		///<summary>FScriptDelegate</summary>
		public const int OnCreateAndShowContextMenuWidget = 0x03C0;

		///<summary>FScriptDelegate</summary>
		public const int OnDestroyContextMenuWidget = 0x03D0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03E0;

	}

	public class AItemExplorer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03E8;

		///<summary>FScriptDelegate</summary>
		public const int OnUpdateItemList = 0x03F0;

		///<summary>FScriptDelegate</summary>
		public const int OnClearItemList = 0x0400;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0410;

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
		public const int bIsConsumable = 0x0038;

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

		///<summary>TAssetPtr&lt;UStaticMesh&gt;</summary>
		public const int DroppedMesh = 0x00B0;

		///<summary>float</summary>
		public const int DroppedMeshScale = 0x00D0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x00D4;

		///<summary>TAssetPtr&lt;UTexture&gt;</summary>
		public const int Icon = 0x00D8;

		///<summary>TAssetPtr&lt;UTexture&gt;</summary>
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

		///<summary>EItemCategory</summary>
		public const int Category = 0x0198;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x0199;

		///<summary>FName</summary>
		public const int SubCategory = 0x01A0;

		///<summary>bool</summary>
		public const int bIsToy = 0x01A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x01A9;

		///<summary>FString</summary>
		public const int Note = 0x01B0;

	}

	public class AItemPackage
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0418;

		///<summary>FText</summary>
		public const int PackageName = 0x0428;

		///<summary>FText</summary>
		public const int PackageCategory = 0x0440;

		///<summary>FText</summary>
		public const int PackageDetailedName = 0x0458;

		///<summary>FText</summary>
		public const int PackageDescription = 0x0470;

		///<summary>UTexture *</summary>
		public const int PackageIcon = 0x0488;

		///<summary>float</summary>
		public const int PackageIconSizeRatio = 0x0490;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0494;

		///<summary>UTexture *</summary>
		public const int PackageToolTipIcon = 0x0498;

		///<summary>float</summary>
		public const int PackageToolTipIconSizeRatio = 0x04A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x04A4;

		///<summary>TAssetPtr&lt;UStaticMesh&gt;</summary>
		public const int PackageMesh = 0x04A8;

		///<summary>UBoxComponent *</summary>
		public const int BoxComponent = 0x04C8;

		///<summary>UOnceInteractionComponent *</summary>
		public const int InteractionComponent = 0x04D0;

		///<summary>bool</summary>
		public const int DestroyByEmptyItem = 0x04D8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x04D9;

		///<summary>TArray&lt;UItem * &gt;</summary>
		public const int Items = 0x04E0;

		///<summary>FString</summary>
		public const int CreatorName = 0x04F0;

		///<summary>int</summary>
		public const int SortPriority = 0x0500;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x0504;

	}

	public class ADeployedItemPackage
	{
		///<summary>UClass *</summary>
		public const int ItemPackageType = 0x03B0;

		///<summary>TArray&lt;FPackagedItemInfo&gt;</summary>
		public const int ItemInfos = 0x03B8;

	}

	public class UDoorDataAsset
	{
		///<summary>float</summary>
		public const int OpenAngle = 0x0030;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0034;

		///<summary>UCurveFloat *</summary>
		public const int OpenCurve = 0x0038;

		///<summary>float</summary>
		public const int OpenCurveDuration = 0x0040;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0044;

		///<summary>UCurveFloat *</summary>
		public const int CloseCurve = 0x0048;

		///<summary>float</summary>
		public const int CloseCurveDuration = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0054;

		///<summary>UAkAudioEvent *</summary>
		public const int OpenSound = 0x0058;

		///<summary>UAkAudioEvent *</summary>
		public const int CloseSound = 0x0060;

	}

	public class UTslReactionDoorData
	{
		///<summary>float</summary>
		public const int PointDamageImpulse = 0x0030;

		///<summary>float</summary>
		public const int PointDamageRadius = 0x0034;

		///<summary>float</summary>
		public const int BreakingRadius = 0x0038;

		///<summary>float</summary>
		public const int BreakingImpulse = 0x003C;

		///<summary>float</summary>
		public const int BreakingMinDamage = 0x0040;

		///<summary>float</summary>
		public const int DamageAccumulateTimeout = 0x0044;

		///<summary>float</summary>
		public const int ZombieDamageAccumulateTimeout = 0x0048;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x004C;

		///<summary>FName</summary>
		public const int TopImpactSoketName = 0x0050;

		///<summary>FName</summary>
		public const int CenterImpactSoketName = 0x0058;

		///<summary>FName</summary>
		public const int BottomImpactSoketName = 0x0060;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructibleSoundAk = 0x0068;

	}

	public class UDoorFrameComponent
	{
		///<summary>FTransform</summary>
		public const int DoorTransform = 0x09E0;

		///<summary>FVector</summary>
		public const int SoundOffsetFromDoor = 0x0A10;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0A1C;

		///<summary>UStaticMesh *</summary>
		public const int DoorStaticMesh = 0x0A20;

		///<summary>UDestructibleMesh *</summary>
		public const int DoorDestructibleMesh = 0x0A28;

		///<summary>UDoorDataAsset *</summary>
		public const int DoorDataAsset = 0x0A30;

		///<summary>UTslReactionDoorData *</summary>
		public const int ReactionDoorData = 0x0A38;

		///<summary>bool</summary>
		public const int bDisableSubComponents = 0x0A40;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData01 = 0x0A41;

	}

	public class ADroppedItem
	{
		///<summary>UItem *</summary>
		public const int Item = 0x03B0;

	}

	public class ADroppedItemGridManager
	{
		///<summary>float</summary>
		public const int MaxGridSize = 0x03B0;

		///<summary>int</summary>
		public const int MaxGridLayerNum = 0x03B4;

		///<summary>int</summary>
		public const int MaxItemNumPerGroup = 0x03B8;

		///<summary>unsigned char[0xA4]</summary>
		public const int UnknownData00 = 0x03BC;

	}

	public class ADroppedItemGroup
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>float</summary>
		public const int RandomSpawnRadius = 0x03B4;

		///<summary>int</summary>
		public const int MaxRandomSpawnCount = 0x03B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03BC;

	}

	public class UExportableDataAsset
	{
		///<summary>FDirectoryPath</summary>
		public const int JsonSaveDirectory = 0x0030;

		///<summary>FString</summary>
		public const int JsonSaveFileName = 0x0040;

	}

	public class ULobbyCustomizableData
	{
		///<summary>TArray&lt;FLobbyFaceElement&gt;</summary>
		public const int Faces = 0x0050;

		///<summary>TArray&lt;FLobbyHairElement&gt;</summary>
		public const int Hairs = 0x0060;

	}

	public class ULobbyItemExporter
	{
		///<summary>FString</summary>
		public const int LocJsonSaveFileName = 0x0050;

	}

	public class AFlashBangCaptureActor
	{
		///<summary>USceneComponent *</summary>
		public const int SceneRootComponent = 0x03B0;

		///<summary>USceneCaptureComponent2D *</summary>
		public const int SceneCapture = 0x03B8;

		///<summary>APawn *</summary>
		public const int PlayerPawnReference = 0x03C0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int CaptureTexture = 0x03C8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03D0;

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

	public class UGamePadInputAixsComponent
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>float</summary>
		public const int YawAccelPct = 0x01E4;

		///<summary>float</summary>
		public const int PitchAccelPct = 0x01E8;

		///<summary>float</summary>
		public const int LastYawAccelDir = 0x01EC;

		///<summary>float</summary>
		public const int LastPitchAccelDir = 0x01F0;

		///<summary>float</summary>
		public const int LastYawInput = 0x01F4;

		///<summary>float</summary>
		public const int LastPitchInput = 0x01F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01FC;

	}

	public class UGameStateListenerComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGameModeEvent = 0x01E8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x01F8;

	}

	public class UTableGeneralItemSpawner
	{
		///<summary>UDataTable *</summary>
		public const int RawItemSpawnDataTable = 0x0028;

		///<summary>UDataTable *</summary>
		public const int RawItemSpawnTogetherDataTable = 0x0030;

		///<summary>TArray&lt;FGeneralItemSpawnProb&gt;</summary>
		public const int SpawnProbArray = 0x0038;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UHackReporterComponent
	{
		///<summary>unsigned char[0x140]</summary>
		public const int UnknownData00 = 0x01E0;

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

		///<summary>UTslGameInstance *</summary>
		public const int TslGameInstance = 0x0068;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData01 = 0x0070;

	}

	public class UInteractionComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>float</summary>
		public const int MaxInteractableDistance = 0x01E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01EC;

		///<summary>FText</summary>
		public const int InteractionVerb = 0x01F0;

		///<summary>FText</summary>
		public const int InteractiveObjectName = 0x0208;

		///<summary>FCastConfig</summary>
		public const int CastConfig = 0x0220;

		///<summary>bool</summary>
		public const int bUseTraceCheck = 0x0258;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0259;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInteractBy = 0x0260;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ClientOnInteractBy = 0x0270;

		///<summary>unsigned char[0xE0]</summary>
		public const int UnknownData03 = 0x0280;

	}

	public class UDoublePhaseInteractionComponent
	{
		///<summary>FText</summary>
		public const int FirstInteractionVerb = 0x0360;

		///<summary>FText</summary>
		public const int FirstInteractiveObjectName = 0x0378;

		///<summary>FText</summary>
		public const int SecondInteractionVerb = 0x0390;

		///<summary>FText</summary>
		public const int SecondInteractiveObjectName = 0x03A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSecondInteractBy = 0x03C0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ClientOnSecondInteractBy = 0x03D0;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x03E0;

	}

	public class UDroppedItemActorComponent
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0360;

	}

	public class UOnceInteractionComponent
	{
		///<summary>TArray&lt;FName&gt;</summary>
		public const int CharacterHistory = 0x0360;

	}

	public class UAmmoItem
	{
		///<summary>UTexture *</summary>
		public const int AmmoIcon = 0x01C0;

		///<summary>float</summary>
		public const int AmmoIconRatio = 0x01C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x01CC;

	}

	public class UAttachableItem
	{
		///<summary>FWeaponAttachmentData</summary>
		public const int AttachmentData = 0x01C0;

		///<summary>TAssetPtr&lt;UStaticMesh&gt;</summary>
		public const int AttachmentMeshAsset = 0x03B0;

		///<summary>TArray&lt;FWeaponAttachmentWeaponTagData&gt;</summary>
		public const int AttachmentWeaponTagData = 0x03D0;

		///<summary>bool</summary>
		public const int EquipOnPickUp = 0x03E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03E1;

		///<summary>UAkAudioEvent *</summary>
		public const int AttachedSoundAk = 0x03E8;

	}

	public class UCastableItem
	{
		///<summary>FCastConfig</summary>
		public const int CastConfig = 0x01C0;

		///<summary>bool</summary>
		public const int bCanUseInWater = 0x01F8;

		///<summary>ECastableItemType</summary>
		public const int CastableItemType = 0x01F9;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x01FA;

	}

	public class UHealOverTimeItem
	{
		///<summary>UClass *</summary>
		public const int HealOverTimeBuffClass = 0x0200;

	}

	public class UInstantHealItem
	{
		///<summary>float</summary>
		public const int HealLimit = 0x0200;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0204;

	}

	public class USkinItem
	{
		///<summary>FSkinData</summary>
		public const int SkinData = 0x0200;

		///<summary>bool</summary>
		public const int bAutoAction = 0x0220;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0221;

	}

	public class UEquipableItem
	{
		///<summary>EEquipSlotID</summary>
		public const int EquipSlotID = 0x01C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x01C1;

		///<summary>float</summary>
		public const int SpaceExtension = 0x01C4;

		///<summary>float</summary>
		public const int DamageReductionRate = 0x01C8;

		///<summary>float</summary>
		public const int DurabilityMax = 0x01CC;

		///<summary>bool</summary>
		public const int DestroyByDurability = 0x01D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x01D1;

		///<summary>float</summary>
		public const int Durability = 0x01D4;

		///<summary>EDurabilityConsumeType</summary>
		public const int DurabilityConsumeType = 0x01D8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x01D9;

		///<summary>FCustomizableObjectIdentifier</summary>
		public const int CustomizableObjectIdentifierForMale = 0x01E0;

		///<summary>FCustomizableObjectIdentifier</summary>
		public const int CustomizableObjectIdentifierForFemale = 0x0210;

		///<summary>UAkAudioEvent *</summary>
		public const int EquipedSoundAk = 0x0240;

		///<summary>EEquipableItemSoundGroup</summary>
		public const int SoundGroup = 0x0248;

		///<summary>EEquipableItemSoundType</summary>
		public const int SoundType = 0x0249;

		///<summary>bool</summary>
		public const int bCanZombieEquip = 0x024A;

		///<summary>ESlotOffsetType</summary>
		public const int SlotOffsetType = 0x024B;

		///<summary>bool</summary>
		public const int bIsUnequipable = 0x024C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x024D;

		///<summary>TAssetPtr&lt;UTexture&gt;</summary>
		public const int HudDisplayEquipIcon = 0x0250;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0270;

	}

	public class UCustomEquipableItem
	{
		///<summary>int</summary>
		public const int ItemLevel = 0x0278;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x027C;

		///<summary>FTransform</summary>
		public const int SlotOffset_Primary = 0x0280;

		///<summary>FTransform</summary>
		public const int SlotOffset_Secondary = 0x02B0;

		///<summary>FTransform</summary>
		public const int SlotOffset_SideArm = 0x02E0;

		///<summary>FTransform</summary>
		public const int SlotOffset_Melee = 0x0310;

		///<summary>FTransform</summary>
		public const int SlotOffset_Thrown = 0x0340;

	}

	public class UParachuteItem
	{
		///<summary>UClass *</summary>
		public const int ParachuteType = 0x0278;

	}

	public class UThrowableItem
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0278;

		///<summary>UClass *</summary>
		public const int WeaponType = 0x0280;

		///<summary>ATslWeapon *</summary>
		public const int EquippedWeapon = 0x0288;

	}

	public class ATslWeapon
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>UTexture *</summary>
		public const int WeaponIcon = 0x03C0;

		///<summary>float</summary>
		public const int WeaponIconRatio = 0x03C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03CC;

		///<summary>FCanvasIcon</summary>
		public const int PrimaryIcon = 0x03D0;

		///<summary>FCanvasIcon</summary>
		public const int SecondaryIcon = 0x03E8;

		///<summary>FCanvasIcon</summary>
		public const int PrimaryClipIcon = 0x0400;

		///<summary>FCanvasIcon</summary>
		public const int SecondaryClipIcon = 0x0418;

		///<summary>float</summary>
		public const int AmmoIconsCount = 0x0430;

		///<summary>int</summary>
		public const int PrimaryClipIconOffset = 0x0434;

		///<summary>int</summary>
		public const int SecondaryClipIconOffset = 0x0438;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x043C;

		///<summary>FCanvasIcon[0x5]</summary>
		public const int Crosshair = 0x0440;

		///<summary>FCanvasIcon[0x5]</summary>
		public const int AimingCrosshair = 0x04B8;

		///<summary>bool</summary>
		public const int UseLaserDot = 0x0530;

		///<summary>bool</summary>
		public const int UseCustomCrosshair = 0x0531;

		///<summary>bool</summary>
		public const int UseCustomAimingCrosshair = 0x0532;

		///<summary>bool</summary>
		public const int bHideCrosshairWhileNotAiming = 0x0533;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0534;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnUpdatedAttachment = 0x0538;

		///<summary>ATslCharacter *</summary>
		public const int MyPawn = 0x0548;

		///<summary>FWeaponData</summary>
		public const int WeaponConfig = 0x0550;

		///<summary>EWeaponHand</summary>
		public const int WeaponHand = 0x05E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x05E9;

		///<summary>USkeletalMeshComponent *</summary>
		public const int Mesh3P = 0x05F0;

		///<summary>USceneComponent *</summary>
		public const int RootScene = 0x05F8;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData05 = 0x0600;

		///<summary>EAttachmentCalculateType</summary>
		public const int AttachmentAniRateCalculateType = 0x0601;

		///<summary>EAttachmentCalculateType</summary>
		public const int AttachmentRecoilPatternScaleCalculateType = 0x0602;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData06 = 0x0603;

		///<summary>TArray&lt;FWeaponAttachmentPositionData&gt;</summary>
		public const int AttachmentPositionData = 0x0608;

		///<summary>TArray&lt;FWeaponAttachmentAssetData&gt;</summary>
		public const int DefaultAttachedItemAssets = 0x0618;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int AttachedItemClasses = 0x0628;

		///<summary>FName</summary>
		public const int WeaponTag = 0x0638;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData07 = 0x0640;

		///<summary>UAkComponent *</summary>
		public const int AkComponent = 0x06A8;

		///<summary>FName</summary>
		public const int MuzzleAttachPoint = 0x06B0;

		///<summary>FName</summary>
		public const int FiringAttachPoint = 0x06B8;

		///<summary>UParticleSystem *</summary>
		public const int MuzzleFx = 0x06C0;

		///<summary>FName</summary>
		public const int ShellFxAttachPoint = 0x06C8;

		///<summary>UClass *</summary>
		public const int ShellFxClass = 0x06D0;

		///<summary>UParticleSystemComponent *</summary>
		public const int MuzzlePSC = 0x06D8;

		///<summary>UParticleSystemComponent *</summary>
		public const int MuzzlePSCSecondary = 0x06E0;

		///<summary>UClass *</summary>
		public const int FireCameraShake = 0x06E8;

		///<summary>UForceFeedbackEffect *</summary>
		public const int FireForceFeedback = 0x06F0;

		///<summary>UAkAudioEvent *</summary>
		public const int FireSoundAk = 0x06F8;

		///<summary>UAkAudioEvent *</summary>
		public const int FireLoopSoundAk = 0x0700;

		///<summary>UAkAudioEvent *</summary>
		public const int FireFinishSoundAk = 0x0708;

		///<summary>UAkAudioEvent *</summary>
		public const int OutOfAmmoSoundAk = 0x0710;

		///<summary>UAkAudioEvent *</summary>
		public const int ReloadSoundAk = 0x0718;

		///<summary>UAkAudioEvent *</summary>
		public const int EquipSoundAk = 0x0720;

		///<summary>UAkAudioEvent *</summary>
		public const int UnequipSoundAk = 0x0728;

		///<summary>UAkAudioEvent *</summary>
		public const int AimingStartSoundAk = 0x0730;

		///<summary>UAkAudioEvent *</summary>
		public const int AimingFinishSoundAk = 0x0738;

		///<summary>UAkAudioEvent *</summary>
		public const int ScopingStartSoundAk = 0x0740;

		///<summary>UAkAudioEvent *</summary>
		public const int ScopingFinishSoundAk = 0x0748;

		///<summary>EAnimWeaponType</summary>
		public const int AnimWeaponType = 0x0750;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData08 = 0x0751;

		///<summary>FWeaponBasicAnim</summary>
		public const int WeaponAnim = 0x0758;

		///<summary>FWeaponRollAnim</summary>
		public const int ProneRollAnim = 0x0770;

		///<summary>float</summary>
		public const int HipDuration = 0x0780;

		///<summary>unsigned char:1</summary>
		public const int bLoopedMuzzleFX = 0x0784;

		///<summary>unsigned char:1</summary>
		public const int bLoopedFireSound = 0x0784;

		///<summary>unsigned char[0x33]</summary>
		public const int UnknownData09 = 0x0785;

		///<summary>FSkinData</summary>
		public const int SkinData = 0x07B8;

		///<summary>AWeaponProcessor *</summary>
		public const int TemporaryWeaponProcessor = 0x07D8;

	}

	public class UWeaponItem
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0278;

		///<summary>UClass *</summary>
		public const int WeaponType = 0x0280;

		///<summary>int</summary>
		public const int AmmoCount = 0x0288;

		///<summary>int</summary>
		public const int AmmoPerClip = 0x028C;

		///<summary>TArray&lt;FWeaponAttachmentTagData&gt;</summary>
		public const int AttachmentTagData = 0x0290;

		///<summary>FName</summary>
		public const int WeaponTag = 0x02A0;

		///<summary>TArray&lt;UAttachableItem * &gt;</summary>
		public const int AttachedItems = 0x02A8;

		///<summary>EFiringMode</summary>
		public const int FiringMode = 0x02B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x02B9;

		///<summary>ATslWeapon *</summary>
		public const int EquippedWeapon = 0x02C0;

	}

	public class URandomlyGeneratableItem
	{
		///<summary>FString</summary>
		public const int RandomExpression = 0x01C0;

		///<summary>unsigned char:1</summary>
		public const int bOpenByKey = 0x01D0;

		///<summary>unsigned char:1</summary>
		public const int bOpenByPoint = 0x01D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01D1;

		///<summary>TAssetPtr&lt;UClass&gt;</summary>
		public const int OpenKeyItem = 0x01D8;

		///<summary>int</summary>
		public const int OpenKeyItemCount = 0x01F8;

		///<summary>int</summary>
		public const int PointOpenPrice = 0x01FC;

		///<summary>int</summary>
		public const int ExchangeBundleId = 0x0200;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0204;

		///<summary>TArray&lt;FLobbyItemBundle&gt;</summary>
		public const int BundleList = 0x0208;

		///<summary>TArray&lt;TAssetPtr&lt;UClass&gt;&gt;</summary>
		public const int ReferenceItems = 0x0218;

	}

	public class UItemSpawnProcessor
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USpawnTableItemSpawnProcessor
	{
		///<summary>TArray&lt;FItemSpotGroupTypeProperty&gt;</summary>
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
		public const int SpotGroupComponent = 0x03B0;

	}

	public class UItemSpotComponent
	{
		///<summary>EItemSpotType</summary>
		public const int ItemSpotType = 0x03F0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x03F1;

	}

	public class UItemSpotGroupComponent
	{
		///<summary>EItemSpotGroupType</summary>
		public const int SpotGroupType = 0x03F0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x03F1;

	}

	public class AItemStudio
	{
		///<summary>FName</summary>
		public const int CameraSocketName = 0x03B0;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int TextureTarget = 0x03B8;

		///<summary>float</summary>
		public const int MaxViewDistance = 0x03C0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03C4;

		///<summary>UCameraComponent *</summary>
		public const int CameraComponent = 0x03C8;

		///<summary>USceneCaptureComponent2D *</summary>
		public const int SceneCaptureComponent = 0x03D0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03D8;

		///<summary>FTransform</summary>
		public const int DefaultCameraSocketTransform = 0x03E0;

	}

	public class ALevelAttribute
	{
		///<summary>int</summary>
		public const int NumMapBlock = 0x03B0;

		///<summary>FBox2D</summary>
		public const int MapRect2D = 0x03B4;

		///<summary>UMaterialInterface *</summary>
		public const int MapImageMaterial = 0x03C8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03D0;

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

		///<summary>TArray&lt;ATransportAircraftVehicle * &gt;</summary>
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

		///<summary>TArray&lt;FMaterialMergerParameters&gt;</summary>
		public const int ParameterList = 0x0090;

		///<summary>bool</summary>
		public const int bUpdateParameterList = 0x00A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00A1;

	}

	public class ABattleRoyaleModeController
	{
		///<summary>TArray&lt;FBattleRoyalePoisionGasData&gt;</summary>
		public const int NormalPoisonGasDataArray = 0x04A8;

		///<summary>TArray&lt;FBattleRoyalePoisionGasData&gt;</summary>
		public const int FastPoisonGasDataArray = 0x04B8;

		///<summary>int</summary>
		public const int FastZonePlayerCount = 0x04C8;

		///<summary>float</summary>
		public const int BattleRoyaleZoneTypeCheckTime = 0x04CC;

		///<summary>TArray&lt;float&gt;</summary>
		public const int PoisonWarningTime = 0x04D0;

		///<summary>float</summary>
		public const int WaterVolumeRayHeight = 0x04E0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x04E4;

		///<summary>TArray&lt;ATslPhysicsVolume * &gt;</summary>
		public const int OceanPhysicsVolume = 0x04F0;

		///<summary>TArray&lt;ATslPassBluezoneArea * &gt;</summary>
		public const int PassBluezoneAreas = 0x0500;

		///<summary>TArray&lt;ATslPassBlueZoneAreaRectangle * &gt;</summary>
		public const int PassBluezoneAreasRectangle = 0x0510;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0520;

	}

	public class ACarePackageController
	{
		///<summary>UClass *</summary>
		public const int AircraftCarePackageClass = 0x04A8;

		///<summary>FVector2D</summary>
		public const int StartDelay = 0x04B0;

		///<summary>FVector2D</summary>
		public const int SpawnInterval = 0x04B8;

		///<summary>float</summary>
		public const int FlyingHeight = 0x04C0;

		///<summary>float</summary>
		public const int CarePackageLifeTime = 0x04C4;

		///<summary>float</summary>
		public const int WhiteZoneSpawnInnerRate = 0x04C8;

		///<summary>float</summary>
		public const int DropAreaRate = 0x04CC;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x04D0;

	}

	public class ARedZoneController
	{
		///<summary>UClass *</summary>
		public const int BombTemplateClass = 0x04A8;

		///<summary>float</summary>
		public const int StartDelay = 0x04B0;

		///<summary>FVector2D</summary>
		public const int NextCreateRedZoneInterval = 0x04B4;

		///<summary>float</summary>
		public const int BombingDelay = 0x04BC;

		///<summary>float</summary>
		public const int OuterRadius = 0x04C0;

		///<summary>FVector2D</summary>
		public const int LimitExceptExplosionRadius = 0x04C4;

		///<summary>float</summary>
		public const int ExceptExplosionRadius = 0x04CC;

		///<summary>float</summary>
		public const int BombProjectileDelayTime = 0x04D0;

		///<summary>float</summary>
		public const int RedZoneDuration = 0x04D4;

		///<summary>FVector2D</summary>
		public const int BombingInterval = 0x04D8;

		///<summary>float</summary>
		public const int RedZoneLifeTime = 0x04E0;

		///<summary>float</summary>
		public const int ReyStartHeight = 0x04E4;

		///<summary>float</summary>
		public const int RedZoneRadiusOffsetRate = 0x04E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x04EC;

		///<summary>FText</summary>
		public const int RedZoneStartText = 0x04F0;

		///<summary>int</summary>
		public const int RedZoneProjectileCount = 0x0508;

		///<summary>bool</summary>
		public const int bFGSquircularMapping = 0x050C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x050D;

		///<summary>float</summary>
		public const int RayCheckAroundLength = 0x0510;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0514;

		///<summary>UClass *</summary>
		public const int BeginServerPaticleClass = 0x0518;

		///<summary>ATslServerParticle *</summary>
		public const int BeginServerPaticle = 0x0520;

		///<summary>float</summary>
		public const int BeginSoundDelay = 0x0528;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData03 = 0x052C;

		///<summary>TArray&lt;ATslPhysicsVolume * &gt;</summary>
		public const int OceanPhysicsVolume = 0x0540;

	}

	public class AMutableCharacter
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x07E0;

		///<summary>EGender</summary>
		public const int Gender = 0x0800;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0801;

		///<summary>UCustomizableObjectInstance *</summary>
		public const int CustomizableObjectInstance = 0x0808;

		///<summary>UTslCustomizableSkeletalComponent *</summary>
		public const int CustomizableSkeletalComponent = 0x0810;

		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int InstanceDescriptor = 0x0818;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0828;

	}

	public class ALobbyCharacter
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0830;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHost = 0x0838;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLobbySceneChanged = 0x0848;

		///<summary>unsigned char:1</summary>
		public const int bHasJacket = 0x0858;

		///<summary>unsigned char:1</summary>
		public const int bIsReady = 0x0858;

		///<summary>unsigned char:1</summary>
		public const int bIsHost = 0x0858;

		///<summary>unsigned char:1</summary>
		public const int bIsInCustomizationScene = 0x0858;

		///<summary>unsigned char[0x37]</summary>
		public const int UnknownData01 = 0x0859;

	}

	public class ATslVaultingHelper
	{
		///<summary>USceneComponent *</summary>
		public const int RootSceneComponent = 0x03B0;

		///<summary>USceneComponent *</summary>
		public const int ActorAttachScene = 0x03B8;

	}

	public class ATslWeapon_Gun
	{
		///<summary>bool</summary>
		public const int bSpawnBulletFromBarrel = 0x07E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x07E1;

		///<summary>UAkAudioEvent *</summary>
		public const int VariableZoomStepAk = 0x07E8;

		///<summary>UAkAudioEvent *</summary>
		public const int ZeroingStepAk = 0x07F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x07F8;

		///<summary>int</summary>
		public const int AmmoPerClip = 0x07FC;

		///<summary>int</summary>
		public const int CurrentAmmoInClip = 0x0800;

		///<summary>int</summary>
		public const int CurrentZeroLevel = 0x0804;

		///<summary>unsigned char:1</summary>
		public const int bIsHipped = 0x0808;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0809;

		///<summary>float</summary>
		public const int TimeBetweenShots = 0x080C;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData03 = 0x0810;

		///<summary>int</summary>
		public const int FiringModeIndex = 0x0838;

		///<summary>unsigned char[0x84]</summary>
		public const int UnknownData04 = 0x083C;

		///<summary>FWeaponGunData</summary>
		public const int WeaponGunConfig = 0x08C0;

		///<summary>FWeaponDeviationData</summary>
		public const int WeaponDeviationConfig = 0x0950;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x0994;

		///<summary>FWeaponGunAnim</summary>
		public const int WeaponGunAnim = 0x0998;

		///<summary>FWeaponPPSettings</summary>
		public const int WeaponGunPostprocessSettings = 0x0A88;

		///<summary>FName</summary>
		public const int ScopingAttachPoint = 0x0AD8;

		///<summary>FName</summary>
		public const int ScopingFocusPoint = 0x0AE0;

		///<summary>bool</summary>
		public const int bLoackLoadedAmmo = 0x0AE8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData06 = 0x0AE9;

	}

	public class AVehicleSeatActor
	{
		///<summary>float</summary>
		public const int ViewPitchMin = 0x03B0;

		///<summary>float</summary>
		public const int ViewPitchMax = 0x03B4;

		///<summary>float</summary>
		public const int ViewYawMin = 0x03B8;

		///<summary>float</summary>
		public const int ViewYawMax = 0x03BC;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMax = 0x03C0;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMin = 0x03C8;

		///<summary>bool</summary>
		public const int bCanOnlyFireWhileAiming = 0x03D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03D1;

		///<summary>UBlendSpaceBase *</summary>
		public const int SeatBlendspaceAiming = 0x03D8;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle = 0x03E0;

		///<summary>UAimOffsetBlendSpace *</summary>
		public const int SeatIdleAO = 0x03E8;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionOutBlendspace = 0x03F0;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionInBlendspace = 0x03F8;

		///<summary>bool</summary>
		public const int bRestricWeaponUse = 0x0400;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0401;

		///<summary>TArray&lt;EWeaponClass&gt;</summary>
		public const int AllowedWeaponClasses = 0x0408;

		///<summary>bool</summary>
		public const int bUseEntryVelocityRestriction = 0x0418;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0419;

		///<summary>float</summary>
		public const int MaxVelocityForEntry = 0x041C;

		///<summary>ATslCharacter *</summary>
		public const int Rider = 0x0420;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData03 = 0x0428;

		///<summary>EVehicleAnimType</summary>
		public const int SeatAnimationType = 0x0434;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0435;

	}

	public class AWeaponProcessor
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnWeaponProcessorArmed = 0x03B8;

		///<summary>unsigned char[0xF0]</summary>
		public const int UnknownData01 = 0x03C8;

		///<summary>TArray&lt;ATslWeapon * &gt;</summary>
		public const int EquippedWeapons = 0x04B8;

		///<summary>int</summary>
		public const int CurrentWeaponIndex = 0x04C8;

		///<summary>unsigned char[0x24]</summary>
		public const int UnknownData02 = 0x04CC;

	}

	public class UVaultingData
	{
		///<summary>float</summary>
		public const int LocationStartNormalScale = 0x0030;

		///<summary>float</summary>
		public const int LocationStartZOffset = 0x0034;

		///<summary>float</summary>
		public const int LocationEndNormalScale = 0x0038;

		///<summary>float</summary>
		public const int LocationEndZOffset = 0x003C;

		///<summary>bool</summary>
		public const int bIsClimb = 0x0040;

		///<summary>bool</summary>
		public const int bIsSlide = 0x0041;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0042;

		///<summary>float</summary>
		public const int VaultInitialTimer = 0x0044;

		///<summary>float</summary>
		public const int ApexAdditiveStartTime = 0x0048;

		///<summary>float</summary>
		public const int ApexAdditiveEndTime = 0x004C;

		///<summary>float</summary>
		public const int PreApexSpeedScale = 0x0050;

		///<summary>float</summary>
		public const int PostApexSpeedScale = 0x0054;

		///<summary>float</summary>
		public const int VaultEndToFallTimerCutoff = 0x0058;

		///<summary>FVector2D</summary>
		public const int StartCutoffByDistance_InMap = 0x005C;

		///<summary>FVector2D</summary>
		public const int StartCutoffByDistance_OutMap = 0x0064;

		///<summary>FVector2D</summary>
		public const int StartCutoffBySpeed_InMap = 0x006C;

		///<summary>FVector2D</summary>
		public const int StartCutoffBySpeed_OutMap = 0x0074;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_InMap_PreApex = 0x007C;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_OutMap_PreApex = 0x0084;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_InMap_PostApex = 0x008C;

		///<summary>FVector2D</summary>
		public const int PlayrateBySpeed_OutMap_PostApex = 0x0094;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x009C;

		///<summary>UAnimSequenceBase *</summary>
		public const int AnimationSequence = 0x00A0;

		///<summary>UAnimSequenceBase *</summary>
		public const int AnimationSequence_Rifle = 0x00A8;

		///<summary>UCurveFloat *</summary>
		public const int AnimationCurve = 0x00B0;

		///<summary>FVector2D</summary>
		public const int CharLocationInterpSpeedInMap = 0x00B8;

		///<summary>FVector2D</summary>
		public const int CharLocationInterpSpeedOutMap = 0x00C0;

		///<summary>FVector2D</summary>
		public const int TimerProgressionByDistanceInMap = 0x00C8;

		///<summary>FVector2D</summary>
		public const int TimerProgressionByDistanceOutMap = 0x00D0;

		///<summary>float</summary>
		public const int TimerProgressionVTimerMax = 0x00D8;

		///<summary>float</summary>
		public const int VaultEndTimerNormal = 0x00DC;

		///<summary>float</summary>
		public const int VaultEndTimerFall = 0x00E0;

		///<summary>float</summary>
		public const int CharacterPostVaultVelocityScalar = 0x00E4;

		///<summary>FVector</summary>
		public const int CharacterPostVaultVelocityScalarVector = 0x00E8;

		///<summary>FVector</summary>
		public const int CharacterPostVaultVelocityScalarVector_ToFall = 0x00F4;

		///<summary>float</summary>
		public const int AnimBlendInTime = 0x0100;

		///<summary>float</summary>
		public const int AnimBlendOutTime = 0x0104;

		///<summary>bool</summary>
		public const int bCanVaultWithWeapon = 0x0108;

		///<summary>bool</summary>
		public const int bIsCancellable = 0x0109;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x010A;

		///<summary>float</summary>
		public const int MinCancelVTimer = 0x010C;

		///<summary>float</summary>
		public const int MaxCancelVTimer = 0x0110;

		///<summary>float</summary>
		public const int TaskEndVTimer = 0x0114;

		///<summary>float</summary>
		public const int PostVaultTimerProgressionScale = 0x0118;

		///<summary>bool</summary>
		public const int bUseStaticVTimerDampening = 0x011C;

		///<summary>bool</summary>
		public const int bUseMappedVTimerDampening = 0x011D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x011E;

		///<summary>float</summary>
		public const int StaticDampeningScalar = 0x0120;

		///<summary>float</summary>
		public const int StaticDampeningVTimerMax = 0x0124;

		///<summary>float</summary>
		public const int MappedDampeningScalar = 0x0128;

		///<summary>float</summary>
		public const int MappedDampeningVTimerMax = 0x012C;

		///<summary>bool</summary>
		public const int bUseCustomApexForTimer = 0x0130;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0131;

		///<summary>float</summary>
		public const int CustomApex = 0x0134;

	}

	public class ATslCharacter
	{
		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0830;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0838;

		///<summary>bool</summary>
		public const int bPeekLeftToggled = 0x0839;

		///<summary>bool</summary>
		public const int bPeekRightToggled = 0x083A;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x083B;

		///<summary>TWeakObjectPtr&lt;ATslPlayerState&gt;</summary>
		public const int CurrentAttackerPlayerState = 0x083C;

		///<summary>TWeakObjectPtr&lt;ATslPlayerState&gt;</summary>
		public const int LastAttackedPlayerState = 0x0844;

		///<summary>unsigned char[0x4C]</summary>
		public const int UnknownData02 = 0x084C;

		///<summary>FScriptMulticastDelegate</summary>
		public const int NoBagSpaceDelgate = 0x0898;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x08A8;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData04 = 0x0900;

		///<summary>AController *</summary>
		public const int LastPossessedController = 0x0948;

		///<summary>TArray&lt;UAkAudioBank * &gt;</summary>
		public const int Banks = 0x0950;

		///<summary>UBuffComponet *</summary>
		public const int BuffComponent = 0x0960;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData05 = 0x0968;

		///<summary>ECastAnim</summary>
		public const int Remote_CastAnim = 0x09A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData06 = 0x09A9;

		///<summary>ATslCharacter *</summary>
		public const int RevivingCharacter = 0x09B0;

		///<summary>ATslPlayerState *</summary>
		public const int GroggyPlayerInstigator = 0x09B8;

		///<summary>TMap&lt;UCameraComponent *,float&gt;</summary>
		public const int SavedCameraFOV = 0x09C0;

		///<summary>UCameraComponent *</summary>
		public const int SavedCamera = 0x0A10;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData07 = 0x0A18;

		///<summary>int</summary>
		public const int CurrentVariableZoomLevel = 0x0A38;

		///<summary>float</summary>
		public const int BuffFinalSpreadFactor = 0x0A3C;

		///<summary>AInventoryFacade *</summary>
		public const int InventoryFacade = 0x0A40;

		///<summary>AWeaponProcessor *</summary>
		public const int WeaponProcessor = 0x0A48;

		///<summary>unsigned char</summary>
		public const int CharacterState = 0x0A50;

		///<summary>unsigned char:1</summary>
		public const int bIsScopingRemote = 0x0A51;

		///<summary>unsigned char:1</summary>
		public const int bIsAimingRemote = 0x0A51;

		///<summary>unsigned char:1</summary>
		public const int bIsFirstPersonRemote = 0x0A51;

		///<summary>unsigned char:1</summary>
		public const int bIsInVehicleRemote = 0x0A51;

		///<summary>unsigned char[0x1E]</summary>
		public const int UnknownData08 = 0x0A52;

		///<summary>UClass *</summary>
		public const int DropPackageType = 0x0A70;

		///<summary>UAkAudioEvent *</summary>
		public const int SoundClearAk = 0x0A78;

		///<summary>UAkAudioEvent *</summary>
		public const int RemoteVolumeControlOn = 0x0A80;

		///<summary>UAkAudioEvent *</summary>
		public const int RemoteVolumeControlOff = 0x0A88;

		///<summary>UCurveFloat *</summary>
		public const int CameraFovRatioCurve = 0x0A90;

		///<summary>float</summary>
		public const int HeavyFallVerticalVelocityThreshold = 0x0A98;

		///<summary>float</summary>
		public const int ExtremeFallVerticalVelocityThreshold = 0x0A9C;

		///<summary>float</summary>
		public const int ProneFallVerticalVelocityThreshold = 0x0AA0;

		///<summary>float</summary>
		public const int HeavyFallMovementStopTime = 0x0AA4;

		///<summary>float</summary>
		public const int ExtremeFallMovementStopTime = 0x0AA8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData09 = 0x0AAC;

		///<summary>float</summary>
		public const int Punch_Damage = 0x0AB0;

		///<summary>float</summary>
		public const int PunchHeavy_Damage = 0x0AB4;

		///<summary>UClass *</summary>
		public const int UnarmedDamageType = 0x0AB8;

		///<summary>UClass *</summary>
		public const int ZombieDamageType = 0x0AC0;

		///<summary>float</summary>
		public const int Punch_Distance = 0x0AC8;

		///<summary>float</summary>
		public const int PunchHeavy_Distance = 0x0ACC;

		///<summary>float</summary>
		public const int Punch_Radius = 0x0AD0;

		///<summary>float</summary>
		public const int PunchHeavy_Radius = 0x0AD4;

		///<summary>FVector</summary>
		public const int Punch_InitialLocation = 0x0AD8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData10 = 0x0AE4;

		///<summary>FVector</summary>
		public const int LeanLeftTraceOffset = 0x0AE8;

		///<summary>FVector</summary>
		public const int LeanRightTraceOffset = 0x0AF4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData11 = 0x0B00;

		///<summary>float</summary>
		public const int LeanOffset_Stand = 0x0B08;

		///<summary>float</summary>
		public const int LeanOffset_Crouch = 0x0B0C;

		///<summary>float</summary>
		public const int LeanOffset_Prone = 0x0B10;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData12 = 0x0B14;

		///<summary>float</summary>
		public const int Sprint_MaxSpeed = 0x0B24;

		///<summary>float</summary>
		public const int Sprint_MinSpeed = 0x0B28;

		///<summary>float</summary>
		public const int SprintingFOV = 0x0B2C;

		///<summary>float</summary>
		public const int MinimumBreathToHold = 0x0B30;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData13 = 0x0B34;

		///<summary>FName</summary>
		public const int SwimPoint = 0x0B38;

		///<summary>float</summary>
		public const int SwimableWaterDepth = 0x0B40;

		///<summary>float</summary>
		public const int CrouchWaterDepth = 0x0B44;

		///<summary>float</summary>
		public const int ProneWaterDepth = 0x0B48;

		///<summary>float</summary>
		public const int WaterFloorDetectionLength = 0x0B4C;

		///<summary>float</summary>
		public const int SwimMaxControllerPitch = 0x0B50;

		///<summary>float</summary>
		public const int UnderwaterSwimGapFromSurface = 0x0B54;

		///<summary>UClass *</summary>
		public const int SwimTrailEffectClass = 0x0B58;

		///<summary>ATslParticle *</summary>
		public const int SwimTrailEffect = 0x0B60;

		///<summary>FName</summary>
		public const int ParticleSocket_SwimIdleRipple = 0x0B68;

		///<summary>UClass *</summary>
		public const int SwimIdleRippleEffectClass = 0x0B70;

		///<summary>int</summary>
		public const int maxNumSwimIdleRippleEffect = 0x0B78;

		///<summary>float</summary>
		public const int SwimIdleRippleOffsetFromSurface = 0x0B7C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData14 = 0x0B80;

		///<summary>UCharacterBreathComponent *</summary>
		public const int BreathComponent = 0x0B90;

		///<summary>FName</summary>
		public const int BreathPoint = 0x0B98;

		///<summary>UClass *</summary>
		public const int UnderwaterChokeEffectClass = 0x0BA0;

		///<summary>ATslParticle *</summary>
		public const int UnderwaterChokeEffect = 0x0BA8;

		///<summary>float</summary>
		public const int IndoorCheckDistance = 0x0BB0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData15 = 0x0BB4;

		///<summary>float</summary>
		public const int IndoorCheckHalfConeAngle = 0x0BB8;

		///<summary>float</summary>
		public const int IndoorCheckSuccessRate = 0x0BBC;

		///<summary>int</summary>
		public const int IndoorCheckSamplingQueueSize = 0x0BC0;

		///<summary>int</summary>
		public const int IndoorCheckAccuracyMultiplier = 0x0BC4;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData16 = 0x0BC8;

		///<summary>float</summary>
		public const int FootSoundObstructionCheckInterval = 0x0BE8;

		///<summary>float</summary>
		public const int FootSoundObstructionCheckMaxDistance = 0x0BEC;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData17 = 0x0BF0;

		///<summary>FName</summary>
		public const int ParachuteAttachPoint = 0x0BF8;

		///<summary>float</summary>
		public const int ReleasingParachuteAltitude = 0x0C00;

		///<summary>float</summary>
		public const int ForceReleasingParachuteAltitude = 0x0C04;

		///<summary>float</summary>
		public const int MinimumParachuteAltitude = 0x0C08;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData18 = 0x0C0C;

		///<summary>UClass *</summary>
		public const int ParachuteType = 0x0C10;

		///<summary>bool</summary>
		public const int bParachuteLandingAssist = 0x0C18;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData19 = 0x0C19;

		///<summary>UCastComponent *</summary>
		public const int CastComponent = 0x0C20;

		///<summary>UStanceComponent *</summary>
		public const int StanceComponent = 0x0C28;

		///<summary>UHackReporterComponent *</summary>
		public const int HackReporterComponent = 0x0C30;

		///<summary>bool</summary>
		public const int bAcceptHitsWhileNotAlive = 0x0C38;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData20 = 0x0C39;

		///<summary>float</summary>
		public const int SimulatedHit_Initial = 0x0C3C;

		///<summary>float</summary>
		public const int SimulatedHit_RecoveryPerSecond = 0x0C40;

		///<summary>float</summary>
		public const int SimulatedHit_Value = 0x0C44;

		///<summary>float</summary>
		public const int SimulatedHit_ImpulsePower = 0x0C48;

		///<summary>float</summary>
		public const int SimlatedHit_PunchLightPower = 0x0C4C;

		///<summary>float</summary>
		public const int SimlatedHit_PunchHeavyPower = 0x0C50;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData21 = 0x0C54;

		///<summary>UClass *</summary>
		public const int PunchImpactEffect = 0x0C58;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData22 = 0x0C60;

		///<summary>UCharacterWeaponAnimInfoComponent *</summary>
		public const int WeaponAnimInfoComponent = 0x0C88;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Primary = 0x0C90;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Secondary = 0x0C98;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Sidearm = 0x0CA0;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Melee = 0x0CA8;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Thrown = 0x0CB0;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInDirt = 0x0CB8;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInGrass = 0x0CC0;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInRock = 0x0CC8;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInSand = 0x0CD0;

		///<summary>FName</summary>
		public const int ParticleSocketFootLeft = 0x0CD8;

		///<summary>FName</summary>
		public const int ParticleSocketFootRight = 0x0CE0;

		///<summary>UClass *</summary>
		public const int FootStepEffectClassInWater = 0x0CE8;

		///<summary>ATslParticle *</summary>
		public const int FootStepEffect = 0x0CF0;

		///<summary>ATeam *</summary>
		public const int Team = 0x0CF8;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData23 = 0x0D00;

		///<summary>UTslViewTargetTempComponent *</summary>
		public const int ViewTargetTempComponent = 0x0D20;

		///<summary>UTslCharacterValidateLocationComponent *</summary>
		public const int ValidateLocationComponent = 0x0D28;

		///<summary>UTslThrowableTrajectoryViewComponent *</summary>
		public const int ThrowableTrajectoryViewComponent = 0x0D30;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData24 = 0x0D38;

		///<summary>FString</summary>
		public const int CharacterNetId = 0x0D58;

		///<summary>FString</summary>
		public const int CharacterName = 0x0D68;

		///<summary>FName</summary>
		public const int HeadAttachPoint = 0x0D78;

		///<summary>float</summary>
		public const int CameraHeadHideDistance = 0x0D80;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData25 = 0x0D84;

		///<summary>FVector</summary>
		public const int CrouchedCameraMove = 0x0D90;

		///<summary>FVector</summary>
		public const int PronedCameraMove = 0x0D9C;

		///<summary>FVector</summary>
		public const int GroggyCameraMove = 0x0DA8;

		///<summary>float</summary>
		public const int CrouchedCameraMoveSpeed = 0x0DB4;

		///<summary>float</summary>
		public const int PronedCameraMoveSpeed = 0x0DB8;

		///<summary>float</summary>
		public const int GroggyCameraMoveSpeed = 0x0DBC;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData26 = 0x0DC0;

		///<summary>FTakeHitInfo</summary>
		public const int LastTakeHitInfo = 0x0E08;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData27 = 0x0E48;

		///<summary>float</summary>
		public const int TargetingSpeedModifier = 0x0E4C;

		///<summary>ETargetingType</summary>
		public const int TargetingType = 0x0E50;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData28 = 0x0E51;

		///<summary>float</summary>
		public const int Stand_RunningSpeedModifier = 0x0E54;

		///<summary>float</summary>
		public const int Stand_SprintingSpeedModifier = 0x0E58;

		///<summary>float</summary>
		public const int Stand_SprintingBigGunModifier = 0x0E5C;

		///<summary>float</summary>
		public const int Stand_SprintingRifleModifier = 0x0E60;

		///<summary>float</summary>
		public const int Stand_SprintingSmallGunMOdifier = 0x0E64;

		///<summary>float</summary>
		public const int Crouch_RunningSpeedModifier = 0x0E68;

		///<summary>float</summary>
		public const int Crouch_SprintingSpeedModifier = 0x0E6C;

		///<summary>float</summary>
		public const int Prone_RunningSpeedModifier = 0x0E70;

		///<summary>float</summary>
		public const int Prone_SprintingSpeedModifier = 0x0E74;

		///<summary>float</summary>
		public const int ReviveCastingTime = 0x0E78;

		///<summary>unsigned char:1</summary>
		public const int bWantsToRun = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bWantsToSprint = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bWantsToSprintingAuto = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bWantsToRollingLeft = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bWantsToRollingRight = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bIsPeekLeft = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bIsPeekRight = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int IgnoreRotation = 0x0E7C;

		///<summary>unsigned char:1</summary>
		public const int bIsGroggying = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int bIsThirdPerson = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int UnknownData29 = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int bIsReviving = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int bIsWeaponObstructed = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int bIsCoatEquipped = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int bIsZombie = 0x0E7D;

		///<summary>unsigned char:1</summary>
		public const int bIsThrowHigh = 0x0E7D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData30 = 0x0E7E;

		///<summary>bool</summary>
		public const int bUseRightShoulderAiming = 0x0E80;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData31 = 0x0E81;

		///<summary>FRotator</summary>
		public const int GunDirectionSway = 0x0E84;

		///<summary>FVector_NetQuantizeNormal</summary>
		public const int AimOffsets = 0x0E90;

		///<summary>FVector_NetQuantizeNormal</summary>
		public const int LastAimOffsets = 0x0E9C;

		///<summary>float</summary>
		public const int AimoffsetsLastRepTime = 0x0EA8;

		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData32 = 0x0EAC;

		///<summary>FRotator</summary>
		public const int CurrentAutoRotator = 0x0ED8;

		///<summary>float</summary>
		public const int AutoPitchValueMax = 0x0EE4;

		///<summary>float</summary>
		public const int AutoPitchBlendSpeed = 0x0EE8;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData33 = 0x0EEC;

		///<summary>UCurveFloat *</summary>
		public const int Curve_JumpCamera = 0x0EF8;

		///<summary>UCurveVector *</summary>
		public const int Curve_FPPCameraOffsetByFOV = 0x0F00;

		///<summary>UCurveFloat *</summary>
		public const int Curve_DBNOFadeOut = 0x0F08;

		///<summary>float</summary>
		public const int DBNOFadeOutLerpSpeed = 0x0F10;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData34 = 0x0F14;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandWalk = 0x0F18;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandRun = 0x0F20;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandSprint = 0x0F28;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchWalk = 0x0F30;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchRun = 0x0F38;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchSprint = 0x0F40;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneWalk = 0x0F48;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneRun = 0x0F50;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneSprint = 0x0F58;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Swim = 0x0F60;

		///<summary>UCurveFloat *</summary>
		public const int Curve_UnderwaterSwim = 0x0F68;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandScope = 0x0F70;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchScope = 0x0F78;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneScope = 0x0F80;

		///<summary>UCurveFloat *</summary>
		public const int Curve_StandAim = 0x0F88;

		///<summary>UCurveFloat *</summary>
		public const int Curve_CrouchAim = 0x0F90;

		///<summary>UCurveFloat *</summary>
		public const int Curve_ProneAim = 0x0F98;

		///<summary>UCurveFloat *</summary>
		public const int Curve_DBNO = 0x0FA0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_GroundAngle = 0x0FA8;

		///<summary>UCurveVector *</summary>
		public const int Curve_WeaponSway = 0x0FB0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_TurningLerp = 0x0FB8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_TurningLerpLocomotion = 0x0FC0;

		///<summary>float</summary>
		public const int DirectionalSpeedModifier = 0x0FC8;

		///<summary>float</summary>
		public const int PointDamageForceMultiplier = 0x0FCC;

		///<summary>float</summary>
		public const int PointDamageForce_MapMin = 0x0FD0;

		///<summary>float</summary>
		public const int PointDamageForce_MapMax = 0x0FD4;

		///<summary>float</summary>
		public const int RadialDamageForceMultiplier = 0x0FD8;

		///<summary>TEnumAsByte&lt;ERadialImpulseFalloff&gt;</summary>
		public const int RadialDamageFalloffType = 0x0FDC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData35 = 0x0FDD;

		///<summary>UAnimMontage *</summary>
		public const int RollLeftAnim = 0x0FE0;

		///<summary>UAnimMontage *</summary>
		public const int RollRightAnim = 0x0FE8;

		///<summary>FCharacterAnim</summary>
		public const int CharacterAnim = 0x0FF0;

		///<summary>AController *</summary>
		public const int NetOwnerController = 0x1000;

		///<summary>float</summary>
		public const int LeanAlphaSpeed = 0x1008;

		///<summary>float</summary>
		public const int TurnSpeedHip = 0x100C;

		///<summary>float</summary>
		public const int TurnSpeedAimed = 0x1010;

		///<summary>float</summary>
		public const int TurnSpeedOverLimit = 0x1014;

		///<summary>float</summary>
		public const int MinTurnAngleHip = 0x1018;

		///<summary>float</summary>
		public const int MinTurnAngleAim = 0x101C;

		///<summary>float</summary>
		public const int TurnLinearEndThreshold = 0x1020;

		///<summary>bool</summary>
		public const int bNonLinearTurn = 0x1024;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData36 = 0x1025;

		///<summary>float</summary>
		public const int TurnNonLinearEndThreshold = 0x1028;

		///<summary>float</summary>
		public const int TurnNonLinearInterpSpeed = 0x102C;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedLocomotion = 0x1030;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedLocomotionSprint = 0x1034;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedLocomotionProne = 0x1038;

		///<summary>float</summary>
		public const int CapsuleTurnInterpSpeedStationary = 0x103C;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData37 = 0x1040;

		///<summary>FName</summary>
		public const int FPPCameraBoneName = 0x1058;

		///<summary>FName</summary>
		public const int TPPCameraBoneName = 0x1060;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData38 = 0x1068;

		///<summary>float</summary>
		public const int AimStateDefaultTime = 0x1074;

		///<summary>float</summary>
		public const int AimStateReturnTime = 0x1078;

		///<summary>float</summary>
		public const int AimStateDrawTime = 0x107C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData39 = 0x1080;

		///<summary>bool</summary>
		public const int bAimStateActive = 0x1088;

		///<summary>bool</summary>
		public const int bFreeMode = 0x1089;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData40 = 0x108A;

		///<summary>float</summary>
		public const int CanGroggyDamageTime = 0x1090;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData41 = 0x1094;

		///<summary>FText</summary>
		public const int GroggyStartText = 0x1098;

		///<summary>FText</summary>
		public const int GroggyCancelText = 0x10B0;

		///<summary>FText</summary>
		public const int GroggyFinishText = 0x10C8;

		///<summary>float</summary>
		public const int GamepadRunningValue = 0x10E0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData42 = 0x10E4;

		///<summary>FRotator</summary>
		public const int BlendTargetViewRotation = 0x10F0;

		///<summary>FVector2D</summary>
		public const int DesiredDirection = 0x10FC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData43 = 0x1104;

		///<summary>UClass *</summary>
		public const int InvulnerablilityBuff = 0x1108;

		///<summary>bool</summary>
		public const int bInvulnerablilityEffectVisible = 0x1110;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData44 = 0x1111;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x1118;

		///<summary>TArray&lt;FZombieCustomizationData&gt;</summary>
		public const int ZombieCustomizationData = 0x1128;

		///<summary>bool</summary>
		public const int bIsHoldingBreath = 0x1138;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData45 = 0x1139;

		///<summary>float</summary>
		public const int Health = 0x113C;

		///<summary>float</summary>
		public const int HealthMax = 0x1140;

		///<summary>float</summary>
		public const int GroggyHealth = 0x1144;

		///<summary>float</summary>
		public const int GroggyHealthMax = 0x1148;

		///<summary>float</summary>
		public const int DecreaseGroggyHealthPerSecond = 0x114C;

		///<summary>float</summary>
		public const int GroggyDamageWeight = 0x1150;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData46 = 0x1154;

		///<summary>UClass *</summary>
		public const int GroggyDamageType = 0x1158;

		///<summary>float</summary>
		public const int HealthByRevive = 0x1160;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData47 = 0x1164;

		///<summary>UAkAudioEvent *</summary>
		public const int GroggyToDieAkEvent = 0x1168;

		///<summary>float</summary>
		public const int BoostGauge = 0x1170;

		///<summary>float</summary>
		public const int BoostGaugeMax = 0x1174;

		///<summary>float</summary>
		public const int DecreaseTimerSecond = 0x1178;

		///<summary>float</summary>
		public const int DecreaseBoostGaugeByTime = 0x117C;

		///<summary>TArray&lt;FBuffWithBoostGauge&gt;</summary>
		public const int BuffWithBoostGauge = 0x1180;

		///<summary>UClass *</summary>
		public const int MedKitClass = 0x1190;

		///<summary>UClass *</summary>
		public const int FirstAidClass = 0x1198;

		///<summary>UClass *</summary>
		public const int BandageClass = 0x11A0;

		///<summary>UClass *</summary>
		public const int AdrenalineClass = 0x11A8;

		///<summary>UClass *</summary>
		public const int PainKillerClass = 0x11B0;

		///<summary>UClass *</summary>
		public const int EnergyDrinkClass = 0x11B8;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int BoostItemClasses = 0x11C0;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int HealItemClasses = 0x11D0;

		///<summary>UClass *</summary>
		public const int GrenadeClass = 0x11E0;

		///<summary>UClass *</summary>
		public const int MolotovClass = 0x11E8;

		///<summary>UClass *</summary>
		public const int SmokeBombClass = 0x11F0;

		///<summary>UClass *</summary>
		public const int FlashBangClass = 0x11F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData48 = 0x1200;

		///<summary>TWeakObjectPtr&lt;ATslPlayerState&gt;</summary>
		public const int LaunchInstigator = 0x1204;

		///<summary>TWeakObjectPtr&lt;AActor&gt;</summary>
		public const int LaunchCauser = 0x120C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData49 = 0x1214;

		///<summary>UClass *</summary>
		public const int LaunchDamageTypeClass = 0x1218;

		///<summary>double</summary>
		public const int LastLaunchTime = 0x1220;

		///<summary>APlayerState *</summary>
		public const int AuthorizedPlayerState = 0x1228;

		///<summary>EEquipableItemSoundType</summary>
		public const int ShoesSoundType = 0x1230;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData50 = 0x1231;

		///<summary>UInteractorComponent *</summary>
		public const int InteractorComponent = 0x1238;

		///<summary>UInteractionComponent *</summary>
		public const int InteractionComponent = 0x1240;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData51 = 0x1248;

		///<summary>UVehicleRiderComponent *</summary>
		public const int VehicleRiderComponent = 0x1260;

		///<summary>UClass *</summary>
		public const int OutSidePlayerAreaEffectClass = 0x1268;

		///<summary>ATslPostProcessEffect *</summary>
		public const int OutSidePlayerAreaEffect = 0x1270;

		///<summary>UClass *</summary>
		public const int DBNOEffectClass = 0x1278;

		///<summary>ATslPostProcessEffect *</summary>
		public const int DBNOEffect = 0x1280;

		///<summary>unsigned char[0x1E0]</summary>
		public const int UnknownData52 = 0x1288;

		///<summary>USkeletalMeshComponent *</summary>
		public const int ShadowMesh = 0x1468;

		///<summary>float</summary>
		public const int TargetingFOV = 0x1470;

		///<summary>float</summary>
		public const int AimingDelay = 0x1474;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData53 = 0x1478;

		///<summary>float</summary>
		public const int AttackStateOffDelayTime = 0x1480;

		///<summary>float</summary>
		public const int HitStateOffDelayTime = 0x1484;

		///<summary>float</summary>
		public const int HitMePlayerStateOffDelayTime = 0x1488;

		///<summary>unsigned char[0x34]</summary>
		public const int UnknownData54 = 0x148C;

		///<summary>UTslPlayerDamageConfig *</summary>
		public const int DamageConfig = 0x14C0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData55 = 0x14C8;

		///<summary>float</summary>
		public const int FallDamageFactor = 0x14CC;

		///<summary>float</summary>
		public const int FallDamageVelocityMin = 0x14D0;

		///<summary>bool</summary>
		public const int bIsActiveRagdollActive = 0x14D4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData56 = 0x14D5;

		///<summary>float</summary>
		public const int CorpseLifeSpan = 0x14D8;

		///<summary>unsigned char[0xB4]</summary>
		public const int UnknownData57 = 0x14DC;

		///<summary>TEnumAsByte&lt;EStanceMode&gt;</summary>
		public const int PreReplicatedStanceMode = 0x1590;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData58 = 0x1591;

		///<summary>FVector</summary>
		public const int JumpStartLocation_CP = 0x1594;

		///<summary>FVector</summary>
		public const int LandPredictedLocation_CP = 0x15A0;

		///<summary>float</summary>
		public const int FallHeight_CP = 0x15AC;

		///<summary>bool</summary>
		public const int bIsVaulting_CP = 0x15B0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData59 = 0x15B1;

		///<summary>float</summary>
		public const int VaultTimer_CP = 0x15B4;

		///<summary>FVector</summary>
		public const int VaultEndVelocity_CP = 0x15B8;

		///<summary>FVector</summary>
		public const int VaultLastLocation_CP = 0x15C4;

		///<summary>bool</summary>
		public const int bIsClimbing_CP = 0x15D0;

		///<summary>bool</summary>
		public const int bEndVaultToFall_CP = 0x15D1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData60 = 0x15D2;

		///<summary>FVector</summary>
		public const int VaultEndVelocityVectorMutliplier = 0x15D4;

		///<summary>float</summary>
		public const int VaultEndVelocityVectorClamp = 0x15E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData61 = 0x15E4;

		///<summary>ATslVaultingHelper *</summary>
		public const int VaultingHelperRef = 0x15E8;

		///<summary>bool</summary>
		public const int bIsVaultingSystemEnabled = 0x15F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData62 = 0x15F1;

		///<summary>float</summary>
		public const int VaultingDirection_CP = 0x15F4;

		///<summary>UVaultingData *</summary>
		public const int CurrentVaultData_CP = 0x15F8;

		///<summary>bool</summary>
		public const int bServerFinishedVault = 0x1600;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData63 = 0x1601;

		///<summary>float</summary>
		public const int JumpDelay = 0x1604;

		///<summary>float</summary>
		public const int JumpLastTimer = 0x1608;

		///<summary>bool</summary>
		public const int bWantsToVault = 0x160C;

		///<summary>bool</summary>
		public const int bWantsToCancelVault = 0x160D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData64 = 0x160E;

		///<summary>float</summary>
		public const int VaultProbeLoopTime = 0x1610;

		///<summary>float</summary>
		public const int GamepadReloadHoldTime = 0x1614;

		///<summary>FTimerHandle</summary>
		public const int TimerHandle_GamepadReloadHold = 0x1618;

		///<summary>FAnimUpdateRateSettings</summary>
		public const int AnimationUpdateRateSettings = 0x1620;

		///<summary>float</summary>
		public const int TO_CulledMovementTickrate = 0x1698;

		///<summary>float</summary>
		public const int TO_CulledActorTickInterval = 0x169C;

		///<summary>float</summary>
		public const int TO_MinimumDistance = 0x16A0;

		///<summary>bool</summary>
		public const int bRunTickOptimization = 0x16A4;

		///<summary>bool</summary>
		public const int bRunTickOptimization_Anim = 0x16A5;

		///<summary>bool</summary>
		public const int bRunTickOptimization_Movement = 0x16A6;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData65 = 0x16A7;

		///<summary>float</summary>
		public const int TO_RenderedTolerance = 0x16A8;

		///<summary>bool</summary>
		public const int bTickOptimization_Move_Active = 0x16AC;

		///<summary>bool</summary>
		public const int bTickOptimization_Anim_Active = 0x16AD;

		///<summary>bool</summary>
		public const int bTickOptimization_Actor_Active = 0x16AE;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData66 = 0x16AF;

		///<summary>float</summary>
		public const int GamepadUnarmHoldTime = 0x16B4;

		///<summary>float</summary>
		public const int GamepadNextGunWeaponTabMaxTime = 0x16B8;

		///<summary>unsigned char[0x49]</summary>
		public const int UnknownData67 = 0x16BC;

		///<summary>bool</summary>
		public const int bIsDemoVaulting_CP = 0x1705;

		///<summary>unsigned char[0xA]</summary>
		public const int UnknownData68 = 0x1706;

		///<summary>UBluezoneInOutComponent *</summary>
		public const int BluezoneInOut = 0x1710;

		///<summary>UBluezoneInOutSoundEffectComponent *</summary>
		public const int BluezoneInOutSoundEffect = 0x1718;

		///<summary>UGamePadInputAixsComponent *</summary>
		public const int GamePadInputAixsComponent = 0x1720;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData69 = 0x1728;

	}

	public class UObserverTagWidget
	{
		///<summary>float</summary>
		public const int OffsetZ = 0x0240;

		///<summary>float</summary>
		public const int DeadOffsetZ = 0x0244;

		///<summary>float</summary>
		public const int Distance = 0x0248;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x024C;

		///<summary>UCurveFloat *</summary>
		public const int WidgetCurve = 0x0250;

		///<summary>UCurveFloat *</summary>
		public const int AnchorCurve = 0x0258;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0260;

		///<summary>ATslCharacter *</summary>
		public const int Character = 0x0268;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0270;

	}

	public class UObserverTagManagerBaseWidget
	{
		///<summary>unsigned char[0x70]</summary>
		public const int UnknownData00 = 0x0240;

		///<summary>UClass *</summary>
		public const int WidgetTemplate = 0x02B0;

	}

	public class AParachuteVehicle
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>FScriptDelegate</summary>
		public const int OnRelease = 0x0420;

		///<summary>FScriptDelegate</summary>
		public const int OnLand = 0x0430;

		///<summary>UAkAudioEvent *</summary>
		public const int ReleaseSound_Local = 0x0440;

		///<summary>UAkAudioEvent *</summary>
		public const int ReleaseSound_Remote = 0x0448;

		///<summary>UAkAudioEvent *</summary>
		public const int LandSound_Local = 0x0450;

		///<summary>UAkAudioEvent *</summary>
		public const int LandSound_Remote = 0x0458;

		///<summary>UAkAudioEvent *</summary>
		public const int FallingStartSound_Local = 0x0460;

		///<summary>UAkAudioEvent *</summary>
		public const int FallingStartSound_Remote = 0x0468;

		///<summary>UAkComponent *</summary>
		public const int AkSoundCom = 0x0470;

		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0478;

		///<summary>USkeletalMeshComponent *</summary>
		public const int MeshComponent = 0x0480;

		///<summary>UParachuteVehicleMovement *</summary>
		public const int ParachuteMovementComponent = 0x0488;

		///<summary>UFreeFallMovement *</summary>
		public const int FreeFallMovementComponent = 0x0490;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x0498;

		///<summary>UDoublePhaseInteractionComponent *</summary>
		public const int InteractionComponent = 0x04A0;

		///<summary>TWeakObjectPtr&lt;ATslCharacter&gt;</summary>
		public const int LastDriver = 0x04A8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x04B0;

		///<summary>FName</summary>
		public const int FreeFallFirstPersonCameraName = 0x04B8;

		///<summary>FName</summary>
		public const int FreeFallThirdPersonCameraName = 0x04C0;

		///<summary>float</summary>
		public const int FreeFallCameraPitchMin = 0x04C8;

		///<summary>float</summary>
		public const int FreeFallCameraPitchMax = 0x04CC;

		///<summary>float</summary>
		public const int ReleasingAltitude = 0x04D0;

		///<summary>float</summary>
		public const int ForceReleasingAltitude = 0x04D4;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x04D8;

		///<summary>float</summary>
		public const int SweepMoveHeight = 0x04F0;

		///<summary>float</summary>
		public const int LandingHeight = 0x04F4;

		///<summary>float</summary>
		public const int LandingDuration = 0x04F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x04FC;

		///<summary>UClass *</summary>
		public const int LandingBuff = 0x0500;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData04 = 0x0508;

		///<summary>float</summary>
		public const int StuckCheckDistance = 0x0514;

		///<summary>float</summary>
		public const int StuckCheckDuration = 0x0518;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData05 = 0x051C;

		///<summary>unsigned char:1</summary>
		public const int UnknownData06 = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int ForwardInputRepApplied = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int ForwardInputRepIsForward = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int RightInputRepApplied = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int RightInputRepIsRight = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int bIsReleased = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int bIsDriven = 0x0528;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData07 = 0x0529;

		///<summary>FSkinData</summary>
		public const int SkinData = 0x0530;

		///<summary>FRotator</summary>
		public const int InitialRotation = 0x0550;

		///<summary>FVector</summary>
		public const int InitialVelocity = 0x055C;

		///<summary>FVector</summary>
		public const int RideSocketOffset = 0x0568;

		///<summary>FVector</summary>
		public const int LeaveSocketOffset = 0x0574;

	}

	public class AReplicationTrigger
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>TArray&lt;AActor * &gt;</summary>
		public const int TargetReplicatedActors = 0x03B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03C8;

		///<summary>int</summary>
		public const int ReplicationGroupCount = 0x03CC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x03D0;

		///<summary>float</summary>
		public const int ReplicationGroupIntervalSeconds = 0x03D4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x03D8;

	}

	public class AReplicationTriggerManager
	{
		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int TargetReplicatedActorClasses = 0x03B0;

		///<summary>float</summary>
		public const int TriggerRadius = 0x03C0;

		///<summary>float</summary>
		public const int TriggerInterval = 0x03C4;

		///<summary>TArray&lt;AReplicationTrigger * &gt;</summary>
		public const int Triggers = 0x03C8;

	}

	public class UReporterManager
	{
		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class URewardData
	{
		///<summary>float</summary>
		public const int DefaultScoreMultiplierByDamage = 0x0030;

		///<summary>float</summary>
		public const int DefaultScoreMultiplierByKill = 0x0034;

		///<summary>TArray&lt;float&gt;</summary>
		public const int ScoreByReverseRanking = 0x0038;

		///<summary>TArray&lt;float&gt;</summary>
		public const int ScoreMultiplierByRanking = 0x0048;

	}

	public class USceneInteractionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03F0;

		///<summary>float</summary>
		public const int MaxInteractableDistance = 0x0400;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0404;

		///<summary>FText</summary>
		public const int InteractionVerb = 0x0408;

		///<summary>FText</summary>
		public const int InteractiveObjectName = 0x0420;

		///<summary>bool</summary>
		public const int bUseTraceCheck = 0x0438;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0439;

		///<summary>FCastConfig</summary>
		public const int CastConfig = 0x0440;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0478;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInteractBy = 0x0480;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ClientOnInteractBy = 0x0490;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData04 = 0x04A0;

	}

	public class UDoorInteractionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0500;

		///<summary>EDoorState</summary>
		public const int DoorState = 0x0510;

		///<summary>unsigned char:1</summary>
		public const int bReverseRotation = 0x0511;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreParentValidityCheck = 0x0511;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0512;

		///<summary>FVector</summary>
		public const int SoundOffset = 0x0514;

		///<summary>UDoorDataAsset *</summary>
		public const int DoorDataAsset = 0x0520;

		///<summary>unsigned char[0x1C8]</summary>
		public const int UnknownData02 = 0x0528;

		///<summary>UAkComponent *</summary>
		public const int AkAudioComponent = 0x06F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x06F8;

	}

	public class UDroppedItemInteractionComponent
	{
		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x0500;

		///<summary>UItem *</summary>
		public const int Item = 0x0538;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0540;

		///<summary>UAsyncStaticMeshComponent *</summary>
		public const int StaticMeshComponent = 0x0548;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0550;

	}

	public class UVehicleSeatInteractionComponent
	{
		///<summary>ATslCharacter *</summary>
		public const int Rider = 0x0500;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x0508;

		///<summary>int</summary>
		public const int SeatIndex = 0x0514;

		///<summary>ERiderType</summary>
		public const int RiderType = 0x0518;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0519;

		///<summary>FName</summary>
		public const int LeaveSocketName = 0x0520;

		///<summary>float</summary>
		public const int ViewPitchMin = 0x0528;

		///<summary>float</summary>
		public const int ViewPitchMax = 0x052C;

		///<summary>float</summary>
		public const int ViewYawMin = 0x0530;

		///<summary>float</summary>
		public const int ViewYawMax = 0x0534;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMax = 0x0538;

		///<summary>UCurveFloat *</summary>
		public const int CurvePitchMin = 0x0540;

		///<summary>FName</summary>
		public const int FirstPersonCameraName = 0x0548;

		///<summary>FName</summary>
		public const int ThirdPersonCameraName = 0x0550;

		///<summary>EVehicleAnimType</summary>
		public const int SeatAnimationType = 0x0558;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0559;

		///<summary>UBlendSpaceBase *</summary>
		public const int SeatBlendspaceAiming = 0x0560;

		///<summary>UBlendSpaceBase *</summary>
		public const int SeatBlendspaceFPPAiming = 0x0568;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle_Rifle = 0x0570;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle_Melee = 0x0578;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle_Unarmed = 0x0580;

		///<summary>UAnimSequenceBase *</summary>
		public const int SeatAnimationIdle_Grenade = 0x0588;

		///<summary>UAimOffsetBlendSpace *</summary>
		public const int SeatIdleAO = 0x0590;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionOutBlendspace = 0x0598;

		///<summary>UBlendSpaceBase *</summary>
		public const int TransitionInBlendspace = 0x05A0;

		///<summary>bool</summary>
		public const int bRestricWeaponUse = 0x05A8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x05A9;

		///<summary>TArray&lt;EWeaponClass&gt;</summary>
		public const int AllowedWeaponClasses = 0x05B0;

		///<summary>bool</summary>
		public const int bCanOnlyFireWhileAiming = 0x05C0;

		///<summary>bool</summary>
		public const int bUseEntryVelocityRestriction = 0x05C1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x05C2;

		///<summary>float</summary>
		public const int MaxVelocityForEntry = 0x05C4;

		///<summary>float</summary>
		public const int InteractionBlockDuration = 0x05C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x05CC;

	}

	public class USimpleInterpolationMovement
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0260;

		///<summary>float</summary>
		public const int LocationInterpTime = 0x0278;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData01 = 0x027C;

		///<summary>float</summary>
		public const int RotationInterpTime = 0x02B4;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData02 = 0x02B8;

		///<summary>bool</summary>
		public const int bUseOnlyYawRotation = 0x02F0;

		///<summary>bool</summary>
		public const int bUseSweepMove = 0x02F1;

		///<summary>bool</summary>
		public const int bUseSafeInterpolation = 0x02F2;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData03 = 0x02F3;

		///<summary>float</summary>
		public const int ForceMoveTime = 0x02F4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x02F8;

	}

	public class UFreeFallMovement
	{
		///<summary>float</summary>
		public const int MinPitch = 0x0300;

		///<summary>float</summary>
		public const int MaxPitch = 0x0304;

		///<summary>float</summary>
		public const int MaxLateralSpeed = 0x0308;

		///<summary>float</summary>
		public const int LateralAcceleration = 0x030C;

		///<summary>float</summary>
		public const int LateralDeceleration = 0x0310;

		///<summary>float</summary>
		public const int LateralBrakeDeceleration = 0x0314;

		///<summary>float</summary>
		public const int VerticalAcceleration = 0x0318;

		///<summary>float</summary>
		public const int VerticalDeceleration = 0x031C;

		///<summary>float</summary>
		public const int TerminalSpeed = 0x0320;

		///<summary>float</summary>
		public const int MinAdditiveTerminalSpeed = 0x0324;

		///<summary>float</summary>
		public const int MaxAdditiveTerminalSpeed = 0x0328;

		///<summary>float</summary>
		public const int RotationYawRate = 0x032C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0330;

		///<summary>float</summary>
		public const int InputUpdateTime = 0x0340;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0344;

	}

	public class UParachuteVehicleMovement
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0300;

		///<summary>float</summary>
		public const int MaxSpeed = 0x0304;

		///<summary>float</summary>
		public const int Acceleration = 0x0308;

		///<summary>float</summary>
		public const int Deceleration = 0x030C;

		///<summary>float</summary>
		public const int MaxRotationYawRate = 0x0310;

		///<summary>float</summary>
		public const int RotationYawAcceleration = 0x0314;

		///<summary>float</summary>
		public const int RotationYawDeceleration = 0x0318;

		///<summary>float</summary>
		public const int TerminalVelocity = 0x031C;

		///<summary>float</summary>
		public const int DecreaseTerminalVelocity = 0x0320;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0324;

		///<summary>float</summary>
		public const int RotationYawReplicated = 0x032C;

		///<summary>float</summary>
		public const int RotationPitchReplicated = 0x0330;

		///<summary>float</summary>
		public const int InputUpdateTime = 0x0334;

		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData02 = 0x0338;

		///<summary>float</summary>
		public const int ParachuteForwardVelocityTransferTimeout = 0x0364;

		///<summary>float</summary>
		public const int ParachuteForwardVelocityTransferTimeoutDTScalar = 0x0368;

		///<summary>float</summary>
		public const int ParachuteDeployCoefficient = 0x036C;

		///<summary>float</summary>
		public const int YawSpeed = 0x0370;

		///<summary>float</summary>
		public const int MaxForwardPitch = 0x0374;

		///<summary>float</summary>
		public const int MaxBackwardPitch = 0x0378;

		///<summary>float</summary>
		public const int ForceForwardScale = 0x037C;

		///<summary>float</summary>
		public const int ForceForwardStaticSpeed = 0x0380;

		///<summary>float</summary>
		public const int VelocityLERPSpeedMin = 0x0384;

		///<summary>float</summary>
		public const int VelocityLERPSpeedMax = 0x0388;

		///<summary>float</summary>
		public const int VelocityLERPValueMin = 0x038C;

		///<summary>float</summary>
		public const int VelocityLERPValueMax = 0x0390;

		///<summary>float</summary>
		public const int DampingPitchMin = 0x0394;

		///<summary>float</summary>
		public const int DampingPitchMax = 0x0398;

		///<summary>float</summary>
		public const int DampingValueMin = 0x039C;

		///<summary>float</summary>
		public const int DampingValueMax = 0x03A0;

		///<summary>float</summary>
		public const int ForceDownAngleMin = 0x03A4;

		///<summary>float</summary>
		public const int ForceDownAngleMax = 0x03A8;

		///<summary>float</summary>
		public const int ForceGravityMax = 0x03AC;

		///<summary>float</summary>
		public const int ForceGravitySpeedMin = 0x03B0;

		///<summary>float</summary>
		public const int ForceGravitySpeedMax = 0x03B4;

		///<summary>float</summary>
		public const int ForceGravityValueMin = 0x03B8;

		///<summary>float</summary>
		public const int ForceGravityValueMax = 0x03BC;

		///<summary>float</summary>
		public const int RollSpeedMin = 0x03C0;

		///<summary>float</summary>
		public const int RollSpeedMax = 0x03C4;

		///<summary>float</summary>
		public const int RollAngleMin = 0x03C8;

		///<summary>float</summary>
		public const int RollAngleMax = 0x03CC;

		///<summary>float</summary>
		public const int RollInterpSpeed = 0x03D0;

		///<summary>float</summary>
		public const int FinalVelocitySpeedMin = 0x03D4;

		///<summary>float</summary>
		public const int FinalVelocitySpeedMax = 0x03D8;

		///<summary>float</summary>
		public const int FinalVelocityDampingMin = 0x03DC;

		///<summary>float</summary>
		public const int FinalVelocityDampingMax = 0x03E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x03E4;

		///<summary>float</summary>
		public const int TraceSphereRadius = 0x03E8;

		///<summary>FVector</summary>
		public const int TraceSphereOffset = 0x03EC;

		///<summary>float</summary>
		public const int GroundTraceStart = 0x03F8;

		///<summary>float</summary>
		public const int GroundTraceEnd = 0x03FC;

		///<summary>float</summary>
		public const int GroundTraceDampingMin = 0x0400;

		///<summary>float</summary>
		public const int GroundTraceDampingMax = 0x0404;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0408;

	}

	public class UTslAircraftVehicleMovement
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0300;

	}

	public class UStanceComponent
	{
		///<summary>FStanceTransitionData</summary>
		public const int StanceTransitionData = 0x01E0;

		///<summary>TEnumAsByte&lt;EStanceMode&gt;</summary>
		public const int CurrentStance = 0x0240;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData00 = 0x0241;

	}

	public class ATslPlayerStart
	{
		///<summary>EMatchStartType</summary>
		public const int MatchStartType = 0x03E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03E1;

		///<summary>float</summary>
		public const int StartRadius = 0x03E4;

		///<summary>bool</summary>
		public const int bRandomRotation = 0x03E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03E9;

		///<summary>TArray&lt;AStartActivationVolume * &gt;</summary>
		public const int ActivationVolumes = 0x03F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0400;

	}

	public class AStartActivationVolume
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03E8;

	}

	public class AInventoryFacade
	{
		///<summary>TArray&lt;EEquipSlotID&gt;</summary>
		public const int AutoSwapEquipSlotID = 0x03B8;

		///<summary>AInventory *</summary>
		public const int Inventory = 0x03C8;

		///<summary>AEquipment *</summary>
		public const int Equipment = 0x03D0;

	}

	public class AEquipment
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEquipmentUpdated = 0x03E8;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x03F8;

		///<summary>TArray&lt;UEquipableItem * &gt;</summary>
		public const int Items = 0x0428;

	}

	public class AInventory
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnInventoryUpdated = 0x03E8;

		///<summary>TArray&lt;UItem * &gt;</summary>
		public const int Items = 0x03F8;

		///<summary>float</summary>
		public const int MaxSpace = 0x0408;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x040C;

	}

	public class AItemExplorerProxy
	{
		///<summary>FScriptDelegate</summary>
		public const int OnChangeItemExplorerProxy = 0x0418;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0428;

	}

	public class ACarePackageItem
	{
		///<summary>UClass *</summary>
		public const int ParachuteClass = 0x0510;

		///<summary>UClass *</summary>
		public const int SmokeFxClass = 0x0518;

		///<summary>UClass *</summary>
		public const int SmokeAirFxClass = 0x0520;

		///<summary>UClass *</summary>
		public const int LightFxClass = 0x0528;

		///<summary>float</summary>
		public const int SmokeTime = 0x0530;

		///<summary>float</summary>
		public const int LimitFallSpeed = 0x0534;

		///<summary>FName</summary>
		public const int SmokeSocket = 0x0538;

		///<summary>FName</summary>
		public const int SmokeAirSocket = 0x0540;

		///<summary>FName</summary>
		public const int LightSocket = 0x0548;

		///<summary>FName</summary>
		public const int ParachuteSocket = 0x0550;

		///<summary>UAkAudioEvent *</summary>
		public const int LandSoundAk = 0x0558;

		///<summary>bool</summary>
		public const int bIsFalling = 0x0560;

		///<summary>bool</summary>
		public const int bIsPickupedItem = 0x0561;

		///<summary>bool</summary>
		public const int bIsHideIconOnMap = 0x0562;

		///<summary>bool</summary>
		public const int bIsTranslucentIconOnMap = 0x0563;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0564;

		///<summary>ATslParticle *</summary>
		public const int SmokeFx = 0x0568;

		///<summary>ATslParticle *</summary>
		public const int SmokeAirFx = 0x0570;

		///<summary>ATslParticle *</summary>
		public const int LightFx = 0x0578;

		///<summary>AActor *</summary>
		public const int Parachute = 0x0580;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0588;

		///<summary>USimpleInterpolationMovement *</summary>
		public const int MovementComponent = 0x0590;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0598;

		///<summary>UAkComponent *</summary>
		public const int AkComponent = 0x05A0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x05A8;

	}

	public class AFloorSnapItemPackage
	{
		///<summary>float</summary>
		public const int RayLength = 0x0510;

		///<summary>bool</summary>
		public const int bUseWaterSurface = 0x0514;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0515;

		///<summary>float</summary>
		public const int WaterSurfaceThreshold = 0x0518;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x051C;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0520;

	}

	public class ANearbyInteractiveItemExplorer
	{
		///<summary>TArray&lt;TWeakObjectPtr&lt;UObject&gt;&gt;</summary>
		public const int ExplorableItems = 0x0418;

	}

	public class UThingSpawnProcessor
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCombinedThingSpawnProcessor
	{
		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int SubProcessorClasses = 0x0038;

		///<summary>TArray&lt;USubThingSpawnProcessor * &gt;</summary>
		public const int SubProcessors = 0x0048;

	}

	public class UPackageSubThingSpawnProcessor
	{
		///<summary>UDataTable *</summary>
		public const int RawItemSpawnDataTable = 0x0028;

		///<summary>UDataTable *</summary>
		public const int RawItemSpawnTogetherDataTable = 0x0030;

		///<summary>TArray&lt;FPackageSpotGroupProperty&gt;</summary>
		public const int RawSpotGroupProperties = 0x0038;

		///<summary>unsigned char[0x3B0]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UVehicleSubThingSpawnProcessor
	{
		///<summary>TArray&lt;FVehicleSpotGroupProperty&gt;</summary>
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
		public const int PlayerLocation = 0x03B0;

		///<summary>FRotator</summary>
		public const int PlayerRotation = 0x03BC;

		///<summary>FString</summary>
		public const int PlayerName = 0x03C8;

		///<summary>unsigned char</summary>
		public const int Health = 0x03D8;

		///<summary>unsigned char</summary>
		public const int HealthMax = 0x03D9;

		///<summary>unsigned char</summary>
		public const int GroggyHealth = 0x03DA;

		///<summary>unsigned char</summary>
		public const int GroggyHealthMax = 0x03DB;

		///<summary>FVector2D</summary>
		public const int MapMarkerPosition = 0x03DC;

		///<summary>unsigned char:1</summary>
		public const int bIsDying = 0x03E4;

		///<summary>unsigned char:1</summary>
		public const int bIsGroggying = 0x03E4;

		///<summary>unsigned char:1</summary>
		public const int bQuitter = 0x03E4;

		///<summary>unsigned char:1</summary>
		public const int bShowMapMarker = 0x03E4;

		///<summary>ETeamVehicleType</summary>
		public const int TeamVehicleType = 0x03E5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03E6;

		///<summary>float</summary>
		public const int BoostGauge = 0x03E8;

		///<summary>int8_t</summary>
		public const int MemberNumber = 0x03EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x03ED;

		///<summary>ATslCharacter *</summary>
		public const int TslCharacter = 0x03F0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x03F8;

		///<summary>FString</summary>
		public const int UniqueId = 0x0408;

	}

	public class AThingHolder
	{
		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class AThingSpot
	{
		///<summary>UThingSpotComponent *</summary>
		public const int SpotComponent = 0x03B0;

	}

	public class UThingSpotComponent
	{
		///<summary>EThingSpotGroupType</summary>
		public const int SpotGroupType = 0x03F0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x03F1;

		///<summary>FVector2D</summary>
		public const int RandomRotatorRange = 0x03F4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x03FC;

	}

	public class UTslAccessoryComponent
	{
		///<summary>FTransform</summary>
		public const int InitialTransformAttachmentScene = 0x03F0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0420;

	}

	public class ATslAchievement
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class ATslAIController
	{
		///<summary>UBlackboardComponent *</summary>
		public const int BlackboardComp = 0x04A8;

		///<summary>UBehaviorTreeComponent *</summary>
		public const int BehaviorComp = 0x04B0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x04B8;

	}

	public class ATslAircraftVehicle
	{
		///<summary>TArray&lt;FAircraftParticle&gt;</summary>
		public const int AircraftParticles = 0x0410;

		///<summary>TArray&lt;ATslParticle * &gt;</summary>
		public const int AttachedParticles = 0x0420;

		///<summary>UStaticMeshComponent *</summary>
		public const int MeshComponent = 0x0430;

		///<summary>UTslAircraftVehicleMovement *</summary>
		public const int MovementComponent = 0x0438;

		///<summary>USplineComponent *</summary>
		public const int SplineComponent = 0x0440;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData00 = 0x0448;

		///<summary>float</summary>
		public const int TotalFlyingTime = 0x0490;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0494;

	}

	public class AAircraftCarePackage
	{
		///<summary>UClass *</summary>
		public const int CarePackageItemSpawnerClass = 0x04A0;

		///<summary>UClass *</summary>
		public const int CarePackageItemClass = 0x04A8;

		///<summary>TArray&lt;FDropCarePackageTableData&gt;</summary>
		public const int DropCarePackageTableData = 0x04B0;

		///<summary>UGeneralItemSpawner *</summary>
		public const int CarePackageItemSpawner = 0x04C0;

		///<summary>TArray&lt;ATslPassCarePackageArea * &gt;</summary>
		public const int PassCarePackageAreas = 0x04C8;

		///<summary>TArray&lt;ATslPassCarePackageAreaRectangle * &gt;</summary>
		public const int PassCarePackageAreasRectangle = 0x04D8;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x04E8;

	}

	public class ATransportAircraftVehicle
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x04A0;

		///<summary>UAkAudioEvent *</summary>
		public const int RideSound = 0x04C8;

		///<summary>UAkAudioEvent *</summary>
		public const int LeaveSound = 0x04D0;

		///<summary>UAkComponent *</summary>
		public const int AkSoundCom = 0x04D8;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x04E0;

		///<summary>UClass *</summary>
		public const int ParachuteItem = 0x04E8;

		///<summary>UInteractionComponent *</summary>
		public const int InteractionComponent = 0x04F0;

		///<summary>bool</summary>
		public const int bIsEnteredAtEjectionArea = 0x04F8;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x04F9;

		///<summary>bool</summary>
		public const int bIsVisible = 0x04FA;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x04FB;

		///<summary>float</summary>
		public const int EjectPredictionTime = 0x04FC;

		///<summary>float</summary>
		public const int MaxEjectSpeed = 0x0500;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData03 = 0x0504;

	}

	public class ATslAnchorActor
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class ATslWheeledVehicle
	{
		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData00 = 0x0420;

		///<summary>USphereComponent *</summary>
		public const int ActivationTrigger = 0x04B0;

		///<summary>UGamePadInputAixsComponent *</summary>
		public const int GamePadInputAixsComponent = 0x04B8;

		///<summary>float</summary>
		public const int Health = 0x04C0;

		///<summary>float</summary>
		public const int HealthMax = 0x04C4;

		///<summary>float</summary>
		public const int Fuel = 0x04C8;

		///<summary>float</summary>
		public const int FuelMax = 0x04CC;

		///<summary>bool</summary>
		public const int bStabilizeActive = 0x04D0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x04D1;

		///<summary>float</summary>
		public const int AirControlPitchInput = 0x04D4;

		///<summary>float</summary>
		public const int SpeedKPH = 0x04D8;

		///<summary>float</summary>
		public const int ThrottleInput = 0x04DC;

		///<summary>float</summary>
		public const int RPM = 0x04E0;

		///<summary>float</summary>
		public const int Brake = 0x04E4;

		///<summary>float</summary>
		public const int LatMax = 0x04E8;

		///<summary>float</summary>
		public const int LongSum = 0x04EC;

		///<summary>float</summary>
		public const int WaterDepthMax = 0x04F0;

		///<summary>float</summary>
		public const int SurfaceMax = 0x04F4;

		///<summary>float</summary>
		public const int SuspensionMax = 0x04F8;

		///<summary>int</summary>
		public const int FlatTireCount = 0x04FC;

		///<summary>unsigned char:1</summary>
		public const int bDirtySpeedKPH = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bDirtyThrottleInput = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bDirtyRPM = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bDirtyWaterDepthMax = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bDirtyBrake = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bDetectedStartup = 0x0500;

		///<summary>unsigned char:1</summary>
		public const int bDetectedBraking = 0x0500;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0501;

		///<summary>TArray&lt;float&gt;</summary>
		public const int WheelsLatSlip = 0x0508;

		///<summary>TArray&lt;float&gt;</summary>
		public const int WheelsLongSlip = 0x0518;

		///<summary>TArray&lt;float&gt;</summary>
		public const int WheelsSuspensionOffset = 0x0528;

		///<summary>TArray&lt;UPhysicalMaterial * &gt;</summary>
		public const int WheelsContactSurface = 0x0538;

		///<summary>TArray&lt;UPhysicalMaterial * &gt;</summary>
		public const int TestWheelsContactSurface_prev = 0x0548;

		///<summary>TArray&lt;float&gt;</summary>
		public const int WheelsSuspensionMaxDrop = 0x0558;

		///<summary>TArray&lt;float&gt;</summary>
		public const int WheelsSuspensionMaxRaise = 0x0568;

		///<summary>UAkAudioEvent *</summary>
		public const int NullSound = 0x0578;

		///<summary>FTslImpactSoundInfo</summary>
		public const int ImpactSound = 0x0580;

		///<summary>FTslImpactSoundInfo</summary>
		public const int LandingSound = 0x05E0;

		///<summary>UAkAudioEvent *</summary>
		public const int StartupSound = 0x0640;

		///<summary>UAkAudioEvent *</summary>
		public const int BreakSound = 0x0648;

		///<summary>UAkAudioEvent *</summary>
		public const int StopSound = 0x0650;

		///<summary>UAkAudioEvent *</summary>
		public const int CharacterHitSound = 0x0658;

		///<summary>float</summary>
		public const int MaxClampThrottleInClutch = 0x0660;

		///<summary>bool</summary>
		public const int bApplyCustomAnimUpdaterateSettings = 0x0664;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0665;

		///<summary>FAnimUpdateRateSettings</summary>
		public const int AnimUpdateRateSettings = 0x0668;

		///<summary>unsigned char:1</summary>
		public const int bWantsToBoosting = 0x06E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x06E1;

		///<summary>float</summary>
		public const int TorqueMultiplierForBoosting = 0x06E4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x06E8;

		///<summary>UTslVehicleHitComponent *</summary>
		public const int VehicleHitComponent = 0x06F0;

		///<summary>UTslVehicleCommonComponent *</summary>
		public const int VehicleCommonComponent = 0x06F8;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x0700;

		///<summary>UTslVehicleEffectComponent *</summary>
		public const int VehicleEffectComponent = 0x0708;

		///<summary>UTslVehicleSyncComponent *</summary>
		public const int VehicleSyncComponent = 0x0710;

		///<summary>UTslVehicleTempComponent *</summary>
		public const int VehicleTempComponent = 0x0718;

		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0720;

		///<summary>UTslHornComponent *</summary>
		public const int TslHornComponent = 0x0728;

		///<summary>UAkComponent *</summary>
		public const int AudioComEngine = 0x0730;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0738;

		///<summary>FName</summary>
		public const int SinkPoint = 0x0740;

		///<summary>UClass *</summary>
		public const int SinkBuffType = 0x0748;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData06 = 0x0750;

		///<summary>UBuffComponet *</summary>
		public const int BuffComponent = 0x0758;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x0760;

		///<summary>bool</summary>
		public const int bProcessAutoEject = 0x0770;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x0771;

		///<summary>float</summary>
		public const int AutoEjectGroundDistance = 0x0774;

		///<summary>float</summary>
		public const int AutoEjectRoll = 0x0778;

		///<summary>float</summary>
		public const int AutoEjectPitch = 0x077C;

		///<summary>float</summary>
		public const int AutoEject_RiseRate = 0x0780;

		///<summary>float</summary>
		public const int AutoEject_FallRate = 0x0784;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x0788;

		///<summary>bool</summary>
		public const int bRunStabilizeOnEntry = 0x078C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x078D;

		///<summary>float</summary>
		public const int StabilizeInitialTimer = 0x0790;

		///<summary>float</summary>
		public const int StablizeCurrentTimer = 0x0794;

		///<summary>float</summary>
		public const int SteeringYawBias = 0x0798;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData10 = 0x079C;

	}

	public class ATslFloatingVehicle
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0410;

		///<summary>UGamePadInputAixsComponent *</summary>
		public const int GamePadInputAixsComponent = 0x0420;

		///<summary>USkeletalMeshComponent *</summary>
		public const int MeshComponent = 0x0428;

		///<summary>UBuoyancyForceComponent *</summary>
		public const int BuoyancyForceComponent = 0x0430;

		///<summary>UTslFloatingVehicleMovement *</summary>
		public const int MovementComponent = 0x0438;

		///<summary>UTslVehicleHitComponent *</summary>
		public const int VehicleHitComponent = 0x0440;

		///<summary>UTslVehicleCommonComponent *</summary>
		public const int VehicleCommonComponent = 0x0448;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int VehicleSeatComponent = 0x0450;

		///<summary>UTslVehicleEffectComponent *</summary>
		public const int VehicleEffectComponent = 0x0458;

		///<summary>UTslVehicleSyncComponent *</summary>
		public const int VehicleSyncComponent = 0x0460;

		///<summary>UTslVehicleTempComponent *</summary>
		public const int VehicleTempComponent = 0x0468;

		///<summary>UTslHornComponent *</summary>
		public const int TslHornComponent = 0x0470;

		///<summary>UTslPawnInputBindingComponent *</summary>
		public const int TslPawnInputBindingComponent = 0x0478;

		///<summary>UAkComponent *</summary>
		public const int AudioComEngine = 0x0480;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x0488;

		///<summary>FName</summary>
		public const int VehicleEnginePoint = 0x0498;

		///<summary>float</summary>
		public const int VehicleEngineRadius = 0x04A0;

		///<summary>float</summary>
		public const int Health = 0x04A4;

		///<summary>float</summary>
		public const int HealthMax = 0x04A8;

		///<summary>float</summary>
		public const int Fuel = 0x04AC;

		///<summary>float</summary>
		public const int FuelMax = 0x04B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x04B4;

	}

	public class UTslWheeledVehicleMovement
	{
		///<summary>TArray&lt;float&gt;</summary>
		public const int WheelHealthPercentages = 0x0530;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0540;

		///<summary>FCustomTransmissionData</summary>
		public const int CustomTransmission = 0x0548;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0568;

		///<summary>bool</summary>
		public const int bAlwaysUseDirectInput = 0x056C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x056D;

		///<summary>float</summary>
		public const int Anim_SteeringInputInterpSpeed = 0x0570;

		///<summary>float</summary>
		public const int Anim_InterpOfInterpSpeedScale = 0x0574;

		///<summary>float</summary>
		public const int Anim_InterpOfInterpSpeedAbs = 0x0578;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x057C;

		///<summary>float</summary>
		public const int Anim_SpeedForInputTypeSwitch = 0x0584;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0588;

	}

	public class UTslFloatingVehicleMovement
	{
		///<summary>float</summary>
		public const int MaxAcceleration = 0x0260;

		///<summary>float</summary>
		public const int Acceleration = 0x0264;

		///<summary>float</summary>
		public const int StartAccelerationRate = 0x0268;

		///<summary>float</summary>
		public const int StopAccelerationRate = 0x026C;

		///<summary>float</summary>
		public const int MaxRotationYawAngle = 0x0270;

		///<summary>float</summary>
		public const int RotationYawAngle = 0x0274;

		///<summary>float</summary>
		public const int RotationYawRate = 0x0278;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x027C;

		///<summary>UCurveFloat *</summary>
		public const int DirectionalAccelerationCurve = 0x0280;

		///<summary>UCurveFloat *</summary>
		public const int SlideCompensationCurve = 0x0288;

		///<summary>float</summary>
		public const int BoostModifier = 0x0290;

		///<summary>bool</summary>
		public const int bIsBoosting = 0x0294;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0295;

		///<summary>float</summary>
		public const int ForwardInput = 0x0298;

		///<summary>float</summary>
		public const int RotationInput = 0x029C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x02A0;

		///<summary>float</summary>
		public const int HitCharacterDuration = 0x02A4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x02A8;

	}

	public class UTslCharacterMovement
	{
		///<summary>int</summary>
		public const int BroSimulateMovement = 0x0840;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0844;

		///<summary>float</summary>
		public const int NetCorrectServerDeltaTime = 0x0848;

		///<summary>FVector</summary>
		public const int NetComputedPosition = 0x084C;

		///<summary>unsigned char[0xB0]</summary>
		public const int UnknownData01 = 0x0858;

		///<summary>float</summary>
		public const int MaxProneSpeed = 0x0908;

		///<summary>float</summary>
		public const int MaxGroggySpeed = 0x090C;

		///<summary>float</summary>
		public const int JumpedHalfHeight = 0x0910;

		///<summary>float</summary>
		public const int JumpVelocityLossScale = 0x0914;

		///<summary>float</summary>
		public const int ToFallVelocityDTScale = 0x0918;

		///<summary>float</summary>
		public const int ToFallVelocityClamp = 0x091C;

		///<summary>float</summary>
		public const int SpeedToJumpModifier = 0x0920;

		///<summary>float</summary>
		public const int MinJumpZVelocity = 0x0924;

		///<summary>float</summary>
		public const int MaxJumpZVelocity = 0x0928;

		///<summary>float</summary>
		public const int LandingJumpDecreaseModifier = 0x092C;

		///<summary>float</summary>
		public const int RecoveryWalkSpeedRatePerSec = 0x0930;

		///<summary>float</summary>
		public const int MinWalkSpeedModifier = 0x0934;

		///<summary>float</summary>
		public const int WalkSpeedModifierUnit = 0x0938;

		///<summary>float</summary>
		public const int MinStandingJumpXYSpeed = 0x093C;

		///<summary>float</summary>
		public const int SpeedInWaterModifier = 0x0940;

		///<summary>bool</summary>
		public const int bUseCPVault = 0x0944;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0945;

		///<summary>int</summary>
		public const int HeightFor200 = 0x0998;

		///<summary>int</summary>
		public const int HeightFor160 = 0x099C;

		///<summary>int</summary>
		public const int HeightFor120 = 0x09A0;

		///<summary>int</summary>
		public const int HeightFor90 = 0x09A4;

		///<summary>int</summary>
		public const int HeightFor60 = 0x09A8;

		///<summary>float</summary>
		public const int SizeForNarrow = 0x09AC;

		///<summary>int</summary>
		public const int SizeForSlide = 0x09B0;

		///<summary>float</summary>
		public const int VelocityForMobile = 0x09B4;

		///<summary>float</summary>
		public const int GlobalVaultScale = 0x09B8;

		///<summary>float</summary>
		public const int VaultCancelDTScalar = 0x09BC;

		///<summary>float</summary>
		public const int MinVelocityForStaticVaultCheck = 0x09C0;

		///<summary>FVector2D</summary>
		public const int MaxVaultDistanceByVelocityInMap = 0x09C4;

		///<summary>FVector2D</summary>
		public const int MaxVaultDistanceByVelocityOutMap = 0x09CC;

		///<summary>FVaultingTask</summary>
		public const int CurrentVaultingTask = 0x09D4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0A14;

		///<summary>UVaultingData *</summary>
		public const int CurrentVaultingData = 0x0A18;

		///<summary>float</summary>
		public const int V_Timer_CP = 0x0A20;

		///<summary>float</summary>
		public const int AnimMultiplierPreApex = 0x0A24;

		///<summary>float</summary>
		public const int AnimMultiplierPostApex = 0x0A28;

		///<summary>bool</summary>
		public const int bIsVaulting_CP = 0x0A2C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0A2D;

		///<summary>FVector</summary>
		public const int CharacterRelLocation = 0x0A30;

		///<summary>FVector</summary>
		public const int LastVaultLocation = 0x0A3C;

		///<summary>FVector</summary>
		public const int AveragedVelocity = 0x0A48;

		///<summary>float</summary>
		public const int LastVaultTime = 0x0A54;

		///<summary>float</summary>
		public const int VaultCancelAnimSpeed = 0x0A58;

		///<summary>bool</summary>
		public const int bWantsToCancelVault = 0x0A5C;

		///<summary>unsigned char[0x77]</summary>
		public const int UnknownData05 = 0x0A5D;

		///<summary>float</summary>
		public const int MaxSwimAcceleration = 0x0AD4;

		///<summary>float</summary>
		public const int MaxZSpeedOutOfWaterModifier = 0x0AD8;

		///<summary>FRotator</summary>
		public const int MaxSwimmingRotationRate = 0x0ADC;

		///<summary>FRotator</summary>
		public const int SwimmingRotationAcceleration = 0x0AE8;

		///<summary>float</summary>
		public const int MaxZSpeedOutOfWaterModifierForStandingSwimming = 0x0AF4;

		///<summary>float</summary>
		public const int WaveRidingModifier = 0x0AF8;

		///<summary>float</summary>
		public const int WaveRidingSmoothingFactor = 0x0AFC;

		///<summary>float</summary>
		public const int WaveRidingModifierUnderWater = 0x0B00;

		///<summary>float</summary>
		public const int StayingUnderWaterDepthBand = 0x0B04;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x0B08;

		///<summary>float</summary>
		public const int MaxUnderwaterSwimSpeed = 0x0B0C;

		///<summary>float</summary>
		public const int MaxUnderwaterSwimAcceleration = 0x0B10;

		///<summary>float</summary>
		public const int BrakingDecelerationUnderwaterSwimming = 0x0B14;

		///<summary>FRotator</summary>
		public const int MaxUnderwaterSwimmingRotationRate = 0x0B18;

		///<summary>FRotator</summary>
		public const int UnderwaterSwimmingRotationAcceleration = 0x0B24;

		///<summary>float</summary>
		public const int MinimumHighAltitude = 0x0B30;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x0B34;

		///<summary>float</summary>
		public const int MaxFallLateralSpeedAtHighAltitude = 0x0B38;

		///<summary>float</summary>
		public const int TerminalVelocityAtHighAltitude = 0x0B3C;

		///<summary>float</summary>
		public const int DecreaseTerminalVelocityAtHighAltitude = 0x0B40;

		///<summary>float</summary>
		public const int MaxFallAccelerationAtHighAltitude = 0x0B44;

		///<summary>FRotator</summary>
		public const int FallRotationRateAtHighAltitude = 0x0B48;

		///<summary>float</summary>
		public const int AirControlAtHighAltitude = 0x0B54;

		///<summary>float</summary>
		public const int AirControlBoostMultiplierAtHighAltitude = 0x0B58;

		///<summary>float</summary>
		public const int AirControlBoostVelocityThresholdAtHighAltitude = 0x0B5C;

		///<summary>UClass *</summary>
		public const int FallingDamageType = 0x0B60;

		///<summary>UCurveFloat *</summary>
		public const int EjectDamageCurve = 0x0B68;

		///<summary>float</summary>
		public const int FallingDamageMinZCut = 0x0B70;

		///<summary>float</summary>
		public const int FallingDamageVDampingZ = 0x0B74;

		///<summary>float</summary>
		public const int FallingDamageFactor = 0x0B78;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData08 = 0x0B7C;

		///<summary>bool</summary>
		public const int UseBlockedHitDamage = 0x0B88;

		///<summary>unsigned char[0x47]</summary>
		public const int UnknownData09 = 0x0B89;

	}

	public class UTslVehicleWheel
	{
		///<summary>float</summary>
		public const int Health = 0x0108;

		///<summary>float</summary>
		public const int HealthMax = 0x010C;

		///<summary>FName</summary>
		public const int TireBoneName = 0x0110;

		///<summary>bool</summary>
		public const int bUseTireLink = 0x0118;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0119;

		///<summary>int</summary>
		public const int TireLinkIndex = 0x011C;

		///<summary>float</summary>
		public const int LongSlipSkidThreshold = 0x0120;

		///<summary>float</summary>
		public const int LateralSlipSkidThreshold = 0x0124;

		///<summary>float</summary>
		public const int SpringCompressionLandingThreshold = 0x0128;

		///<summary>bool</summary>
		public const int bManualSuspensionSoundControl = 0x012C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x012D;

		///<summary>UTslWheelSuspensionAudioData *</summary>
		public const int SuspensionAudioData = 0x0130;

		///<summary>FVector</summary>
		public const int WheelEffectOffset = 0x0138;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0144;

		///<summary>UTslWheelEffectType *</summary>
		public const int RollEffect = 0x0148;

		///<summary>UTslWheelEffectType *</summary>
		public const int SkidAccelEffect = 0x0150;

		///<summary>UTslWheelEffectType *</summary>
		public const int SkidEffect = 0x0158;

		///<summary>UClass *</summary>
		public const int PuncturedParticleClass = 0x0160;

		///<summary>UClass *</summary>
		public const int PuncturedSparkParticleClass = 0x0168;

		///<summary>float</summary>
		public const int slipThresholdForPunkSpark = 0x0170;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0174;

		///<summary>UAkAudioEvent *</summary>
		public const int LandingSound = 0x0178;

		///<summary>bool</summary>
		public const int bApplyForceOnPuncture = 0x0180;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0181;

		///<summary>float</summary>
		public const int PunctureForce = 0x0184;

		///<summary>float</summary>
		public const int PunctureVelocityScalar = 0x0188;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData05 = 0x018C;

		///<summary>ATslParticle *</summary>
		public const int TslParticleRoll = 0x0198;

		///<summary>ATslParticle *</summary>
		public const int TslParticleSkid = 0x01A0;

		///<summary>ATslParticle *</summary>
		public const int TslParticleAccelSkid = 0x01A8;

		///<summary>ATslParticle *</summary>
		public const int TslParticlePunctureSpark = 0x01B0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData06 = 0x01B8;

		///<summary>UAkComponent *</summary>
		public const int AudioCom = 0x01C0;

		///<summary>float</summary>
		public const int MinZVelocityForSuspensionSound = 0x01C8;

		///<summary>unsigned char[0x3C]</summary>
		public const int UnknownData07 = 0x01CC;

		///<summary>float</summary>
		public const int TotalSpeedKmPerHour = 0x0208;

		///<summary>float</summary>
		public const int Slip = 0x020C;

		///<summary>bool</summary>
		public const int UseRoll = 0x0210;

		///<summary>bool</summary>
		public const int UseSkid = 0x0211;

		///<summary>bool</summary>
		public const int UseAccelSkid = 0x0212;

		///<summary>bool</summary>
		public const int bHasLastStatus = 0x0213;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x0214;

	}

	public class UTslAnimInstance
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFire = 0x0378;

		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFireCycle = 0x0388;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipPrimary = 0x0398;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipSecondary = 0x03A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EqupiSidearm = 0x03B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipMelee = 0x03C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrown = 0x03D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipPrimary = 0x03E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipSecondary = 0x03F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEqupiSidearm = 0x0408;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipMelee = 0x0418;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnEquipThrown = 0x0428;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ToggleFireMode = 0x0438;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadTactical = 0x0448;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadCharge = 0x0458;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneStart = 0x0468;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneStop = 0x0478;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneSingle = 0x0488;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrownGrenade = 0x0498;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrownMolotov = 0x04A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int EquipThrownOther = 0x04B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowPrepare = 0x04C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowCooking = 0x04D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowStart = 0x04E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ThrowDrop = 0x04F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int LandHeavy = 0x0508;

		///<summary>FScriptMulticastDelegate</summary>
		public const int LandExtreme = 0x0518;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadCancel = 0x0528;

		///<summary>FScriptMulticastDelegate</summary>
		public const int CharacterPickup = 0x0538;

		///<summary>FScriptMulticastDelegate</summary>
		public const int UnarmedAttack = 0x0548;

		///<summary>FScriptMulticastDelegate</summary>
		public const int PowerupUsed = 0x0558;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ChangeCharacterAppearance = 0x0568;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCastStart = 0x0578;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCastCancel = 0x0588;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCastFinish = 0x0598;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x05A8;

		///<summary>ATslCharacter *</summary>
		public const int CharacterReference = 0x05B0;

		///<summary>USkeletalMeshComponent *</summary>
		public const int CharacterMesh_CP = 0x05B8;

		///<summary>EAnimPawnState</summary>
		public const int PreEvalPawnState = 0x05C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x05C1;

		///<summary>float</summary>
		public const int LocomotionSpeed_CP = 0x05C4;

		///<summary>float</summary>
		public const int LocomotionSpeed2D_CP = 0x05C8;

		///<summary>bool</summary>
		public const int bIsMoving_CP = 0x05CC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x05CD;

		///<summary>float</summary>
		public const int LocomotionDirection_CP = 0x05D0;

		///<summary>float</summary>
		public const int LocomotionDirectionClamped_CP = 0x05D4;

		///<summary>float</summary>
		public const int LocomotionJumpDirection_CP = 0x05D8;

		///<summary>float</summary>
		public const int LeanYaw_CP = 0x05DC;

		///<summary>FRotator</summary>
		public const int LastAbsoluteDirection_CP = 0x05E0;

		///<summary>FRotator</summary>
		public const int ControlRotation_CP = 0x05EC;

		///<summary>FRotator</summary>
		public const int ControlRotationLastMovement_CP = 0x05F8;

		///<summary>FRotator</summary>
		public const int CharacterRotation_CP = 0x0604;

		///<summary>EAnimStance</summary>
		public const int Stance_CP = 0x0610;

		///<summary>bool</summary>
		public const int bIsSprintingFast_CP = 0x0611;

		///<summary>bool</summary>
		public const int bIsSprinting_CP = 0x0612;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData03 = 0x0613;

		///<summary>float</summary>
		public const int WeaponGripType_CP = 0x0614;

		///<summary>float</summary>
		public const int SprintAlpha_CP = 0x0618;

		///<summary>float</summary>
		public const int SprintLocoAlpha_CP = 0x061C;

		///<summary>float</summary>
		public const int SprintAlphaPitchComponent_CP = 0x0620;

		///<summary>float</summary>
		public const int SprintAlphaSprintLimit_High = 0x0624;

		///<summary>float</summary>
		public const int SprintAlphaSprintLimit_Low = 0x0628;

		///<summary>float</summary>
		public const int SprintValue_CP = 0x062C;

		///<summary>bool</summary>
		public const int bLocalQuickThrowHigh_CP = 0x0630;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0631;

		///<summary>float</summary>
		public const int LocalThrowModeSwitchAlpha_CP = 0x0634;

		///<summary>bool</summary>
		public const int bIsJumping_CP = 0x0638;

		///<summary>bool</summary>
		public const int bJumpForward_CP = 0x0639;

		///<summary>bool</summary>
		public const int bIsSwimming_CP = 0x063A;

		///<summary>bool</summary>
		public const int bIsUnderWater_CP = 0x063B;

		///<summary>bool</summary>
		public const int bIsDBNO_CP = 0x063C;

		///<summary>EAnimStance</summary>
		public const int DBNOEntryStance = 0x063D;

		///<summary>bool</summary>
		public const int bIsReviving_CP = 0x063E;

		///<summary>bool</summary>
		public const int bIsUpperbody_CP = 0x063F;

		///<summary>bool</summary>
		public const int bIsTransitioning_CP = 0x0640;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0641;

		///<summary>int</summary>
		public const int PlayerID_CP = 0x0644;

		///<summary>int</summary>
		public const int AirCraftIDAnim_CP = 0x0648;

		///<summary>bool</summary>
		public const int bIsEquippingPistol_CP = 0x064C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x064D;

		///<summary>UAnimMontage *</summary>
		public const int PistolEquipMontageRefCP = 0x0650;

		///<summary>bool</summary>
		public const int bIsFlying_CP = 0x0658;

		///<summary>bool</summary>
		public const int bIsLocalPlayer = 0x0659;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData07 = 0x065A;

		///<summary>float</summary>
		public const int LocalPlayerAlpha = 0x065C;

		///<summary>bool</summary>
		public const int bIsPunching_CP = 0x0660;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0661;

		///<summary>float</summary>
		public const int PunchingAlpha_CP = 0x0664;

		///<summary>EAnimWeaponType</summary>
		public const int Weapon_CP = 0x0668;

		///<summary>bool</summary>
		public const int bIsArmedWithGun_CP = 0x0669;

		///<summary>bool</summary>
		public const int bIsArmedWithThrown_CP = 0x066A;

		///<summary>bool</summary>
		public const int bIsPreparingThrow_CP = 0x066B;

		///<summary>float</summary>
		public const int ThrowableAdditionalAimYaw_CP = 0x066C;

		///<summary>UAnimMontage *</summary>
		public const int CurrentRecoilMontage_CP = 0x0670;

		///<summary>UBlendSpace1D *</summary>
		public const int GripBlendSpace_CP = 0x0678;

		///<summary>UBlendSpaceBase *</summary>
		public const int GripBlendSpaceLH_CP = 0x0680;

		///<summary>float</summary>
		public const int LHGripIndex_CP = 0x0688;

		///<summary>bool</summary>
		public const int bIsReloading_CP = 0x068C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData09 = 0x068D;

		///<summary>FVector</summary>
		public const int HandWeaponOffset_CP = 0x0690;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData10 = 0x069C;

		///<summary>FTransform</summary>
		public const int WeaponInertia_CP = 0x06A0;

		///<summary>float</summary>
		public const int ReloadAlpha_CP = 0x06D0;

		///<summary>float</summary>
		public const int HandWeaponOffsetAlpha_CP = 0x06D4;

		///<summary>FRotator</summary>
		public const int RightClavicleRotation_CP = 0x06D8;

		///<summary>float</summary>
		public const int FinalRecoilAlpha_CP = 0x06E4;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_CP = 0x06E8;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Pistol = 0x06F0;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_SMG = 0x06F8;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Rifle = 0x0700;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Sniper = 0x0708;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Pistol_FPP = 0x0710;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_SMG_FPP = 0x0718;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Rifle_FPP = 0x0720;

		///<summary>UBlendSpaceBase *</summary>
		public const int WeaponLocomotionBlendspace_Sniper_FPP = 0x0728;

		///<summary>float</summary>
		public const int WeaponInertiaX_Scalar_CP = 0x0730;

		///<summary>float</summary>
		public const int WeaponInertiaY_Scalar_CP = 0x0734;

		///<summary>float</summary>
		public const int WeaponInertiaX_Clamp_CP = 0x0738;

		///<summary>float</summary>
		public const int WeaponInertiaY_Clamp_CP = 0x073C;

		///<summary>float</summary>
		public const int WeaponInertia_InerpSpeed_CP = 0x0740;

		///<summary>float</summary>
		public const int WeaponInertiaX_Scalar_ADS_CP = 0x0744;

		///<summary>float</summary>
		public const int WeaponInertiaY_Scalar_ADS_CP = 0x0748;

		///<summary>float</summary>
		public const int WeaponInertiaX_Clamp_ADS_CP = 0x074C;

		///<summary>float</summary>
		public const int WeaponInertiaY_Clamp_ADS_CP = 0x0750;

		///<summary>float</summary>
		public const int WeaponInertia_InerpSpeed_ADS_CP = 0x0754;

		///<summary>float</summary>
		public const int WeaponInertia_InerpSpeed_YawScalar_CP = 0x0758;

		///<summary>float</summary>
		public const int WeaponInertia_YawToRollScalar_CP = 0x075C;

		///<summary>float</summary>
		public const int WeaponInertia_YawToRollScalar_ADS_CP = 0x0760;

		///<summary>float</summary>
		public const int WeaponInertiaRoll_Clamp_ADS_CP = 0x0764;

		///<summary>float</summary>
		public const int WeaponInertiaRoll_Clamp_CP = 0x0768;

		///<summary>float</summary>
		public const int WeaponInertia_Yaw_CP = 0x076C;

		///<summary>float</summary>
		public const int WeaponInertia_Pitch_CP = 0x0770;

		///<summary>float</summary>
		public const int WeaponInertia_Roll_CP = 0x0774;

		///<summary>float</summary>
		public const int SprintWeaponLoweringAlpha_CP = 0x0778;

		///<summary>float</summary>
		public const int RecoilRollValue_CP = 0x077C;

		///<summary>float</summary>
		public const int RecoilTimer_CP = 0x0780;

		///<summary>float</summary>
		public const int RecoilRollRand_CP = 0x0784;

		///<summary>float</summary>
		public const int RecoilTimerScale_CP = 0x0788;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData11 = 0x078C;

		///<summary>UCurveFloat *</summary>
		public const int RecoilRollCurve_CP = 0x0790;

		///<summary>float</summary>
		public const int WeaponStabilityAlpha_CP = 0x0798;

		///<summary>float</summary>
		public const int WeaponStabilityRefSpeed_CP = 0x079C;

		///<summary>FVector2D</summary>
		public const int WeaponStabilityRefMapIn_CP = 0x07A0;

		///<summary>FVector2D</summary>
		public const int WeaponStabilityRefMapOut_CP = 0x07A8;

		///<summary>float</summary>
		public const int WeaponStabilityInterpSpeed_CP = 0x07B0;

		///<summary>bool</summary>
		public const int bIsAiming_CP = 0x07B4;

		///<summary>bool</summary>
		public const int bIsScoping_CP = 0x07B5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData12 = 0x07B6;

		///<summary>float</summary>
		public const int WeaponAimState_CP = 0x07B8;

		///<summary>float</summary>
		public const int SprintAlphaModifier_CP = 0x07BC;

		///<summary>bool</summary>
		public const int bIsAimingBackward_CP = 0x07C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData13 = 0x07C1;

		///<summary>float</summary>
		public const int Yaw_CP = 0x07C4;

		///<summary>float</summary>
		public const int RotationYaw_CP = 0x07C8;

		///<summary>float</summary>
		public const int Pitch_CP = 0x07CC;

		///<summary>float</summary>
		public const int YawNormalized_CP = 0x07D0;

		///<summary>float</summary>
		public const int DesiredPitch_CP = 0x07D4;

		///<summary>unsigned char</summary>
		public const int AimDirectionCardinal_CP = 0x07D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData14 = 0x07D9;

		///<summary>FRotator</summary>
		public const int AORot_CP = 0x07DC;

		///<summary>FRotator</summary>
		public const int AORotBackwards_CP = 0x07E8;

		///<summary>float</summary>
		public const int SwimmingPitch_CP = 0x07F4;

		///<summary>float</summary>
		public const int ForceAddAimOffset_CP = 0x07F8;

		///<summary>float</summary>
		public const int WeaponCollisionAlpha_CP = 0x07FC;

		///<summary>bool</summary>
		public const int bWeaponObstructedHigh_CP = 0x0800;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData15 = 0x0801;

		///<summary>float</summary>
		public const int WeaponCollisionReloadAlpha_CP = 0x0804;

		///<summary>bool</summary>
		public const int bIsFalling_CP = 0x0808;

		///<summary>bool</summary>
		public const int bWasFalling_CP = 0x0809;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData16 = 0x080A;

		///<summary>float</summary>
		public const int FallingAlpha_CP = 0x080C;

		///<summary>FVector2D</summary>
		public const int FallingMap2D = 0x0810;

		///<summary>FVector2D</summary>
		public const int FallingMapZ = 0x0818;

		///<summary>bool</summary>
		public const int bForceFall_CP = 0x0820;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData17 = 0x0821;

		///<summary>UAnimMontage *</summary>
		public const int MontageFallingRifle_CP = 0x0828;

		///<summary>UAnimMontage *</summary>
		public const int MontageFallingUnarmed_CP = 0x0830;

		///<summary>float</summary>
		public const int LandingAlpha_CP = 0x0838;

		///<summary>bool</summary>
		public const int bLocalForceProne_CP = 0x083C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData18 = 0x083D;

		///<summary>float</summary>
		public const int JumpHeight_CP = 0x0840;

		///<summary>float</summary>
		public const int FallHeight_CP = 0x0844;

		///<summary>FVector</summary>
		public const int JumpStartLocation_CP = 0x0848;

		///<summary>FVector</summary>
		public const int LandPredictionVector_CP = 0x0854;

		///<summary>float</summary>
		public const int LeanLeftAlpha_CP = 0x0860;

		///<summary>float</summary>
		public const int LeanRightAlpha_CP = 0x0864;

		///<summary>float</summary>
		public const int LeanTwoSideAlpha_CP = 0x0868;

		///<summary>float</summary>
		public const int LeanLeftApplyTranslation_CP = 0x086C;

		///<summary>float</summary>
		public const int LeanInterpSpeed_CP = 0x0870;

		///<summary>float</summary>
		public const int LeanInterpSpeedCollisionClamp_CP = 0x0874;

		///<summary>bool</summary>
		public const int bUseLinearLeanInterp = 0x0878;

		///<summary>bool</summary>
		public const int bIsFreefalling_CP = 0x0879;

		///<summary>bool</summary>
		public const int bIsParachuting_CP = 0x087A;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData19 = 0x087B;

		///<summary>float</summary>
		public const int FreefallX_CP = 0x087C;

		///<summary>float</summary>
		public const int FreefallY_CP = 0x0880;

		///<summary>float</summary>
		public const int FreeFallAlpha_CP = 0x0884;

		///<summary>bool</summary>
		public const int bIsParachuteLanding_CP = 0x0888;

		///<summary>bool</summary>
		public const int bIsParachuteMoving_CP = 0x0889;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData20 = 0x088A;

		///<summary>float</summary>
		public const int Freefall_Yaw_CP = 0x088C;

		///<summary>float</summary>
		public const int Freefall_Pitch_CP = 0x0890;

		///<summary>bool</summary>
		public const int bIsFreelooking_CP = 0x0894;

		///<summary>bool</summary>
		public const int bIsMeleeAttacking_CP = 0x0895;

		///<summary>bool</summary>
		public const int bLocalForceRotationHipLeft_CP = 0x0896;

		///<summary>bool</summary>
		public const int bLocalForceRotationHipRight_CP = 0x0897;

		///<summary>bool</summary>
		public const int bLocalForceRotationAimed_CP = 0x0898;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData21 = 0x0899;

		///<summary>float</summary>
		public const int RotationPlayrateAimed_CP = 0x089C;

		///<summary>float</summary>
		public const int RotationPlayrateAimedAdditiveSpine_CP = 0x08A0;

		///<summary>FRotator</summary>
		public const int LastRotation_CP = 0x08A4;

		///<summary>FRotator</summary>
		public const int Freelook_Body_CP = 0x08B0;

		///<summary>FRotator</summary>
		public const int Freelook_Delta_CP = 0x08BC;

		///<summary>int</summary>
		public const int IdleIndex_CP = 0x08C8;

		///<summary>int</summary>
		public const int LastIdleIndex_CP = 0x08CC;

		///<summary>float</summary>
		public const int IdleTimer_CP = 0x08D0;

		///<summary>float</summary>
		public const int IdleTriggerRandom = 0x08D4;

		///<summary>float</summary>
		public const int IdleTriggerTimeMin_CP = 0x08D8;

		///<summary>float</summary>
		public const int IdleTriggerTimeVariation_CP = 0x08DC;

		///<summary>FTransform</summary>
		public const int SlotPrimary_CP = 0x08E0;

		///<summary>FTransform</summary>
		public const int SlotSecondary_CP = 0x0910;

		///<summary>FTransform</summary>
		public const int SlotMelee_CP = 0x0940;

		///<summary>FTransform</summary>
		public const int SlotThrown_CP = 0x0970;

		///<summary>FVector</summary>
		public const int SlotPrimary_Offset_CP = 0x09A0;

		///<summary>FVector</summary>
		public const int SlotSecondary_Offset_CP = 0x09AC;

		///<summary>FVector</summary>
		public const int SlotPrimary_Location_CP = 0x09B8;

		///<summary>FVector</summary>
		public const int SlotSecondary_Location_CP = 0x09C4;

		///<summary>FVector</summary>
		public const int SlotMelee_Location_CP = 0x09D0;

		///<summary>FVector</summary>
		public const int SlotThrown_Location_CP = 0x09DC;

		///<summary>FRotator</summary>
		public const int SlotPrimary_Rotation_CP = 0x09E8;

		///<summary>FRotator</summary>
		public const int SlotSecondary_Rotation_CP = 0x09F4;

		///<summary>FRotator</summary>
		public const int SlotMelee_Rotation_CP = 0x0A00;

		///<summary>FRotator</summary>
		public const int SlotThrown_Rotation_CP = 0x0A0C;

		///<summary>TMap&lt;UClass *,FTransform&gt;</summary>
		public const int SlotPrimaryOffsetsPerWeapon = 0x0A18;

		///<summary>TMap&lt;UClass *,FTransform&gt;</summary>
		public const int SlotSecondaryOffsetsPerWeapon = 0x0A68;

		///<summary>float</summary>
		public const int AnimDynamicsStandAlpha_CP = 0x0AB8;

		///<summary>float</summary>
		public const int AnimDynamicsStandSprintAlpha_CP = 0x0ABC;

		///<summary>float</summary>
		public const int AnimDynamicsCrouchAlpha_CP = 0x0AC0;

		///<summary>float</summary>
		public const int AnimDynamicsProneAlpha_CP = 0x0AC4;

		///<summary>FVector</summary>
		public const int EFCoat_CP = 0x0AC8;

		///<summary>bool</summary>
		public const int bLocalFPP_CP = 0x0AD4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData22 = 0x0AD5;

		///<summary>float</summary>
		public const int LocalFPPAlpha_CP = 0x0AD8;

		///<summary>float</summary>
		public const int LocalFPPAlphaVehicleAimAO_CP = 0x0ADC;

		///<summary>bool</summary>
		public const int bIsInAircraft_CP = 0x0AE0;

		///<summary>bool</summary>
		public const int bIsDriver_CP = 0x0AE1;

		///<summary>bool</summary>
		public const int bIsSitting_CP = 0x0AE2;

		///<summary>bool</summary>
		public const int bIsInVehicle_CP = 0x0AE3;

		///<summary>float</summary>
		public const int LocalSteerInput_CP = 0x0AE4;

		///<summary>float</summary>
		public const int LocalSteerInputMoto_CP = 0x0AE8;

		///<summary>float</summary>
		public const int LocalStopMoto_CP = 0x0AEC;

		///<summary>float</summary>
		public const int LocalThrottleInput_CP = 0x0AF0;

		///<summary>FRotator</summary>
		public const int GasThighRot_CP = 0x0AF4;

		///<summary>FRotator</summary>
		public const int GasAnkleRot_CP = 0x0B00;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData23 = 0x0B0C;

		///<summary>FTransform</summary>
		public const int GasKneeTransformX_CP = 0x0B10;

		///<summary>float</summary>
		public const int LocalBrakeInput_CP = 0x0B40;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData24 = 0x0B44;

		///<summary>FTransform</summary>
		public const int BrakeKneeTransform_CP = 0x0B50;

		///<summary>FRotator</summary>
		public const int BrakeAnkleRot_CP = 0x0B80;

		///<summary>float</summary>
		public const int BackwardAOAlpha_CP = 0x0B8C;

		///<summary>float</summary>
		public const int AimBlendAlpha_CP = 0x0B90;

		///<summary>bool</summary>
		public const int bHasContact_CP = 0x0B94;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData25 = 0x0B95;

		///<summary>float</summary>
		public const int GroundContactMoto_CP = 0x0B98;

		///<summary>float</summary>
		public const int AirControlPitchInput_CP = 0x0B9C;

		///<summary>FTransform</summary>
		public const int DriverIK_CP = 0x0BA0;

		///<summary>float</summary>
		public const int PassengerIKAlpha_CP = 0x0BD0;

		///<summary>FVector</summary>
		public const int DriverSpineLocWS_CP = 0x0BD4;

		///<summary>EVehicleAnimType</summary>
		public const int VehicleSeatType_CP = 0x0BE0;

		///<summary>bool</summary>
		public const int bMotoHasDriver_CP = 0x0BE1;

		///<summary>bool</summary>
		public const int bVaultCanceled = 0x0BE2;

		///<summary>bool</summary>
		public const int bIsVaulting_CP = 0x0BE3;

		///<summary>float</summary>
		public const int AnimHairAlpha = 0x0BE4;

		///<summary>float</summary>
		public const int VaultTimer_CP = 0x0BE8;

		///<summary>float</summary>
		public const int VaultTimerLast_CP = 0x0BEC;

		///<summary>EVaultAnimType</summary>
		public const int LocalVaultType_CP = 0x0BF0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData26 = 0x0BF1;

		///<summary>UAnimSequenceBase *</summary>
		public const int VaultAnimSequence_CP = 0x0BF8;

		///<summary>float</summary>
		public const int VaultAnimLength_CP = 0x0C00;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData27 = 0x0C04;

		///<summary>UCurveFloat *</summary>
		public const int VaultCurve_CP = 0x0C08;

		///<summary>float</summary>
		public const int VaultBlendInTime_CP = 0x0C10;

		///<summary>float</summary>
		public const int VaultBlendOutTime_CP = 0x0C14;

		///<summary>bool</summary>
		public const int bEndVaultToFall_CP = 0x0C18;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData28 = 0x0C19;

		///<summary>float</summary>
		public const int VaultBlendOutProgressTime_CP = 0x0C1C;

		///<summary>float</summary>
		public const int VaultBlendOutExactTime_CP = 0x0C20;

		///<summary>float</summary>
		public const int VaultLastActionTimer_CP = 0x0C24;

		///<summary>float</summary>
		public const int VaultAnimTime_CP = 0x0C28;

		///<summary>float</summary>
		public const int VaultBlendOutTimeBuffer = 0x0C2C;

		///<summary>ECastAnim</summary>
		public const int CurrentCastAnim_CP = 0x0C30;

		///<summary>bool</summary>
		public const int bIsActiveRagdoll_CP = 0x0C31;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData29 = 0x0C32;

		///<summary>float</summary>
		public const int WeaponIKLH_CP = 0x0C34;

		///<summary>float</summary>
		public const int WeaponIKRH_CP = 0x0C38;

		///<summary>float</summary>
		public const int MontageIKLH_CP = 0x0C3C;

		///<summary>float</summary>
		public const int MontageIKRH_CP = 0x0C40;

		///<summary>float</summary>
		public const int IgnoreWeaponTransform_CP = 0x0C44;

		///<summary>float</summary>
		public const int PickupIKAlpha_CP = 0x0C48;

		///<summary>float</summary>
		public const int TargetIKRH_CP = 0x0C4C;

		///<summary>float</summary>
		public const int TargetIKLH_CP = 0x0C50;

		///<summary>float</summary>
		public const int ForceLegsFromAnim_CP = 0x0C54;

		///<summary>ATslWeapon_Gun *</summary>
		public const int LastGunCache_CP = 0x0C58;

		///<summary>ATslWheeledVehicle *</summary>
		public const int CachedWheeledVehicle_CP = 0x0C60;

		///<summary>ATslFloatingVehicle *</summary>
		public const int CachedFloatingVehicle_CP = 0x0C68;

		///<summary>UBlendSpaceBase *</summary>
		public const int PassengerAimBS_CP = 0x0C70;

		///<summary>UBlendSpaceBase *</summary>
		public const int PassengerTransitionOut_CP = 0x0C78;

		///<summary>UBlendSpaceBase *</summary>
		public const int PassengerTransitionIn_CP = 0x0C80;

		///<summary>UAnimSequenceBase *</summary>
		public const int PassengerIdle_Rifle_CP = 0x0C88;

		///<summary>UAnimSequenceBase *</summary>
		public const int PassengerIdle_Unarmed_CP = 0x0C90;

		///<summary>UAnimSequenceBase *</summary>
		public const int PassengerIdle_Grenade_CP = 0x0C98;

		///<summary>UAnimSequenceBase *</summary>
		public const int PassengerIdle_Melee_CP = 0x0CA0;

		///<summary>UCurveFloat *</summary>
		public const int CurveAimState_CP = 0x0CA8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData30 = 0x0CB0;

		///<summary>bool</summary>
		public const int bIsLOD1 = 0x0CB8;

		///<summary>bool</summary>
		public const int bIsLOD2 = 0x0CB9;

		///<summary>bool</summary>
		public const int bIsWearingCoat = 0x0CBA;

		///<summary>unsigned char[0x9]</summary>
		public const int UnknownData31 = 0x0CBB;

		///<summary>float</summary>
		public const int AnimatedHairsAlpha = 0x0CC4;

		///<summary>bool</summary>
		public const int bIsParentalControl = 0x0CC8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData32 = 0x0CC9;

		///<summary>UAnimMontage *</summary>
		public const int MontageMeleeAttack1 = 0x0CD0;

		///<summary>UAnimMontage *</summary>
		public const int MontageMeleeAttack2 = 0x0CD8;

		///<summary>UAnimMontage *</summary>
		public const int MontageMeleeAttack3 = 0x0CE0;

		///<summary>UAnimMontage *</summary>
		public const int MontagePunchingAttack1 = 0x0CE8;

		///<summary>UAnimMontage *</summary>
		public const int MontagePunchingAttack2 = 0x0CF0;

		///<summary>UAnimMontage *</summary>
		public const int MontagePunchingAttack3 = 0x0CF8;

		///<summary>float</summary>
		public const int FPPSprintAnimScalar = 0x0D00;

		///<summary>FVector</summary>
		public const int FPP_PrimaryAndSecondaryItemOffset = 0x0D04;

		///<summary>float</summary>
		public const int PunchingAlphaOneTarget_CP = 0x0D10;

		///<summary>float</summary>
		public const int PunchingAlphaInterpSpeed = 0x0D14;

		///<summary>float</summary>
		public const int SprintWeaponLoweringScalar_CP = 0x0D18;

		///<summary>float</summary>
		public const int ThrowStateSwitchInterpSpeed = 0x0D1C;

		///<summary>float</summary>
		public const int VaultingEvalTimeout = 0x0D20;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData33 = 0x0D24;

		///<summary>UAnimDB *</summary>
		public const int UnarmedAnimDB_CP = 0x0D28;

		///<summary>UAnimDB *</summary>
		public const int RifleAnimDB_CP = 0x0D30;

		///<summary>UAnimDB *</summary>
		public const int MeleeAnimDB_CP = 0x0D38;

		///<summary>UAnimDB *</summary>
		public const int GrenadeAnimDB_CP = 0x0D40;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData34 = 0x0D48;

		///<summary>FTransform</summary>
		public const int DefaultSlotPrimary_Male_CP = 0x0D50;

		///<summary>FTransform</summary>
		public const int DefaultSlotSecondary_Male_CP = 0x0D80;

		///<summary>FTransform</summary>
		public const int DefaultSlotMelee_Male_CP = 0x0DB0;

		///<summary>FTransform</summary>
		public const int DefaultSlotThrown_Male_CP = 0x0DE0;

		///<summary>FTransform</summary>
		public const int DefaultSlotPrimary_Female_CP = 0x0E10;

		///<summary>FTransform</summary>
		public const int DefaultSlotSecondary_Female_CP = 0x0E40;

		///<summary>FTransform</summary>
		public const int DefaultSlotThrown_Female_CP = 0x0E70;

		///<summary>FTransform</summary>
		public const int DefaultSlotMelee_Female_CP = 0x0EA0;

		///<summary>float</summary>
		public const int SprintLocoTimeMultiplier = 0x0ED0;

		///<summary>float</summary>
		public const int SprintLocoTimeMultiplier_FPP = 0x0ED4;

		///<summary>float</summary>
		public const int SprintLocoTimeAlphaScalar = 0x0ED8;

		///<summary>float</summary>
		public const int SprintLocoTimeAlphaScalar_FPP = 0x0EDC;

		///<summary>float</summary>
		public const int SprintLocoInstantScalar = 0x0EE0;

		///<summary>float</summary>
		public const int LocomotionDirectionInterp = 0x0EE4;

		///<summary>float</summary>
		public const int LeanYawInterpSpeedMin = 0x0EE8;

		///<summary>float</summary>
		public const int LeanYawInterpSpeedMax = 0x0EEC;

		///<summary>float</summary>
		public const int LeanYawGlobalMultiplier = 0x0EF0;

		///<summary>float</summary>
		public const int LeanYawClamp = 0x0EF4;

		///<summary>float</summary>
		public const int SprintLocoStandLimit_High = 0x0EF8;

		///<summary>float</summary>
		public const int SprintLocoCrouchLimit_High = 0x0EFC;

		///<summary>float</summary>
		public const int SprintLocoProneLimit_High = 0x0F00;

		///<summary>float</summary>
		public const int SprintLocoStandLimit_Low = 0x0F04;

		///<summary>float</summary>
		public const int SprintLocoCrouchLimit_Low = 0x0F08;

		///<summary>float</summary>
		public const int SprintLocoProneLimit_Low = 0x0F0C;

		///<summary>float</summary>
		public const int SprintLocoLimitInterpSpeed = 0x0F10;

		///<summary>FRotator</summary>
		public const int RightClavicleCompensation = 0x0F14;

	}

	public class UTslDamageType
	{
		///<summary>EDamageTypeCategory</summary>
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

		///<summary>TArray&lt;FDamageRatioInfo&gt;</summary>
		public const int DamageRatioInfos = 0x0078;

		///<summary>bool</summary>
		public const int HitReaction = 0x0088;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0089;

	}

	public class ATslHUD
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPossessPawnChange = 0x0548;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDisplaySystemMessage = 0x0558;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDisplayKilledMessage = 0x0568;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKillCountChanged = 0x0578;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHit = 0x0588;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTeamPlayerJoin = 0x0598;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTeamPlayerRemove = 0x05A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyStartBuff = 0x05B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHealAmount = 0x05C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyRestrictingPlayArea = 0x05D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyNextGasIn = 0x05E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyDisplayMessage = 0x05F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyWeaponChange = 0x0608;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyWeaponUnarm = 0x0618;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHeal = 0x0628;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyDropSlotOnOtherContainer = 0x0638;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyBlockingWidgetOpened = 0x0648;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyHealItemSelector_Gamepad = 0x0658;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyReloadingNeed = 0x0668;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyReloaded = 0x0678;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyVehicleRide = 0x0688;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnNotifyVehicleLeave = 0x0698;

		///<summary>int</summary>
		public const int BluezoneState = 0x06A8;

		///<summary>bool</summary>
		public const int bGpsReset = 0x06AC;

		///<summary>bool</summary>
		public const int bBluezoneReset = 0x06AD;

		///<summary>bool</summary>
		public const int bPlayzoneReset = 0x06AE;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x06AF;

		///<summary>float</summary>
		public const int GpsResetTimeCheck = 0x06B0;

		///<summary>unsigned char[0x34]</summary>
		public const int UnknownData01 = 0x06B4;

		///<summary>FCanvasIcon</summary>
		public const int TimePlaceBg = 0x06E8;

		///<summary>FCanvasIcon</summary>
		public const int PrimaryWeapBg = 0x0700;

		///<summary>FCanvasIcon</summary>
		public const int SecondaryWeapBg = 0x0718;

		///<summary>FCanvasIcon[0x5]</summary>
		public const int Crosshair = 0x0730;

		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData02 = 0x07A8;

		///<summary>UTexture2D *</summary>
		public const int HitNotifyTexture = 0x0820;

		///<summary>UTexture2D *</summary>
		public const int HUDMainTexture = 0x0828;

		///<summary>UTexture2D *</summary>
		public const int HUDAssets02Texture = 0x0830;

		///<summary>UTexture2D *</summary>
		public const int LowHealthOverlayTexture = 0x0838;

		///<summary>UFont *</summary>
		public const int BigFont = 0x0840;

		///<summary>UFont *</summary>
		public const int NormalFont = 0x0848;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData03 = 0x0850;

		///<summary>UTslSceneCaptureWorld *</summary>
		public const int SceneCaptureWorld = 0x08B0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x08B8;

		///<summary>FVector</summary>
		public const int NextPlayzonePosition = 0x08C8;

		///<summary>float</summary>
		public const int NextPlayzoneRadius = 0x08D4;

		///<summary>FVector</summary>
		public const int CurrentPlayzonePosition = 0x08D8;

		///<summary>float</summary>
		public const int CurrentPlayzoneRadius = 0x08E4;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData05 = 0x08E8;

		///<summary>FString</summary>
		public const int SceneCapturePackageName = 0x0938;

		///<summary>unsigned char[0xB8]</summary>
		public const int UnknownData06 = 0x0948;

	}

	public class UTslSettings
	{
		///<summary>bool</summary>
		public const int SupportedClientReplay = 0x0028;

		///<summary>bool</summary>
		public const int SupportedKillcam = 0x0029;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x002A;

		///<summary>int</summary>
		public const int MaxReplaysForNullStreamer = 0x002C;

		///<summary>float</summary>
		public const int RepDistance_Item = 0x0030;

		///<summary>float</summary>
		public const int RepDistance_Character = 0x0034;

		///<summary>float</summary>
		public const int RepDistance_Weapon = 0x0038;

		///<summary>float</summary>
		public const int RepDistance_Vehicle = 0x003C;

		///<summary>float</summary>
		public const int RepDistance_Parachute = 0x0040;

		///<summary>float</summary>
		public const int RepDistance_Door = 0x0044;

		///<summary>float</summary>
		public const int RepDistance_Window = 0x0048;

		///<summary>float</summary>
		public const int RepFrequency_Character = 0x004C;

		///<summary>float</summary>
		public const int RepFrequency_WheeledVehicle = 0x0050;

		///<summary>float</summary>
		public const int RepFrequency_FloatingVehicle = 0x0054;

		///<summary>float</summary>
		public const int RepFrequency_Parachute = 0x0058;

		///<summary>float</summary>
		public const int RepFrequency_Aircraft = 0x005C;

		///<summary>float</summary>
		public const int RepFrequency_CarePackage = 0x0060;

		///<summary>float</summary>
		public const int RepVehicle_SpawnDistance = 0x0064;

		///<summary>float</summary>
		public const int RepVehicle_UnspawnDistance = 0x0068;

		///<summary>FRigidBodyErrorCorrection</summary>
		public const int RepVehicle_PhysicErrorCorrection = 0x006C;

		///<summary>float</summary>
		public const int CharacterCorrection_MaxSpeed = 0x0088;

		///<summary>float</summary>
		public const int CharacterCorrection_MaxSpeedPositionError = 0x008C;

		///<summary>float</summary>
		public const int CharacterCorrection_ZeroSpeedPositionError = 0x0090;

		///<summary>bool</summary>
		public const int bBattlEyeEnabled = 0x0094;

		///<summary>bool</summary>
		public const int bBattlEyeEnabledInPIE = 0x0095;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0096;

		///<summary>float</summary>
		public const int BattlEyeReliablePacketIntervalOnClient = 0x0098;

		///<summary>float</summary>
		public const int BattlEyeReliablePacketIntervalOnServer = 0x009C;

		///<summary>bool</summary>
		public const int bTPEnabled = 0x00A0;

		///<summary>bool</summary>
		public const int bTPEnabledInPIE = 0x00A1;

		///<summary>bool</summary>
		public const int bChineseLicensing = 0x00A2;

		///<summary>bool</summary>
		public const int bKoreanRating = 0x00A3;

		///<summary>float</summary>
		public const int GameStateLogInterval = 0x00A4;

		///<summary>float</summary>
		public const int ServerStatLogInterval = 0x00A8;

		///<summary>float</summary>
		public const int CharacterPositionLogInterval = 0x00AC;

		///<summary>float</summary>
		public const int DestructibleComponentMaxDrawDistance = 0x00B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00B4;

		///<summary>UClass *</summary>
		public const int CharacterClassToPlay = 0x00B8;

		///<summary>TArray&lt;FBoneBinding&gt;</summary>
		public const int BoneMapping = 0x00C0;

		///<summary>TArray&lt;FStringAssetReference&gt;</summary>
		public const int TestVehicleClasses = 0x00D0;

		///<summary>TArray&lt;FStringAssetReference&gt;</summary>
		public const int TestFloatingVehicleClasses = 0x00E0;

		///<summary>TArray&lt;FChineseLicensingDefaultCustomizeData&gt;</summary>
		public const int ChineseLicensingDefaultCustomizeData = 0x00F0;

		///<summary>float</summary>
		public const int StoppedWheeledVehicleSpeedThreshold = 0x0100;

		///<summary>float</summary>
		public const int StoppedFloatingVehicleSpeedThreshold = 0x0104;

		///<summary>float</summary>
		public const int LastDriverDuration = 0x0108;

		///<summary>float</summary>
		public const int InteractableDistanceToleranceOnDedicatedServer = 0x010C;

		///<summary>float</summary>
		public const int InteractableDistance_ItemDefault = 0x0110;

		///<summary>float</summary>
		public const int InteractableSpeed_ItemDefault = 0x0114;

		///<summary>FInteractionCollisionData</summary>
		public const int InteractionCollisionForFPS = 0x0118;

		///<summary>FInteractionCollisionData</summary>
		public const int InteractionCollisionForTPS = 0x012C;

		///<summary>bool</summary>
		public const int bPreventFinishMatchInPIE = 0x0140;

		///<summary>bool</summary>
		public const int bEnableInitialItemDonator = 0x0141;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x0142;

		///<summary>float</summary>
		public const int InventoryMaxSpaceDefault = 0x0144;

		///<summary>UTexture *</summary>
		public const int ErrorIconTexture = 0x0148;

		///<summary>UTexture *</summary>
		public const int LoadingIconTexture = 0x0150;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int AssetsForPackageIntegrity = 0x0158;

		///<summary>float</summary>
		public const int UICrosshairDistance = 0x0168;

		///<summary>float</summary>
		public const int UICrosshairInterpSpeed = 0x016C;

		///<summary>float</summary>
		public const int UICrosshairDisableDistance = 0x0170;

		///<summary>float</summary>
		public const int BallisticDragScale = 0x0174;

		///<summary>float</summary>
		public const int BallisticDropScale = 0x0178;

		///<summary>float</summary>
		public const int BallisticMOAScale = 0x017C;

		///<summary>float</summary>
		public const int RecoilControlScale = 0x0180;

		///<summary>float</summary>
		public const int RecoilAnimScale = 0x0184;

		///<summary>float</summary>
		public const int GameTimeMultiplier = 0x0188;

		///<summary>bool</summary>
		public const int AimOffsetRayCast = 0x018C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x018D;

		///<summary>float</summary>
		public const int MeleeWeaponPitchMin = 0x0190;

		///<summary>float</summary>
		public const int MeleeWeaponPitchMax = 0x0194;

		///<summary>bool</summary>
		public const int EnableThrowLagCompensation = 0x0198;

		///<summary>bool</summary>
		public const int FullRecoilRecovery = 0x0199;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData05 = 0x019A;

		///<summary>FLevelLoadingBoostParameters</summary>
		public const int LevelLoadingBoostParameters = 0x019C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x01AC;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int ErangelIgnoreWeatherIds = 0x01B0;

		///<summary>TArray&lt;FNearClippingValue&gt;</summary>
		public const int NearClippingValues = 0x01C0;

		///<summary>TArray&lt;FTslGame_FCustomizableCategoryData&gt;</summary>
		public const int CustomizableCategoryData = 0x01D0;

		///<summary>TArray&lt;FCustomizableActionName&gt;</summary>
		public const int CustomizableActionNames = 0x01E0;

		///<summary>TArray&lt;FTslGame_FCustomizableAxisName&gt;</summary>
		public const int CustomizableAxisNames = 0x01F0;

		///<summary>TArray&lt;FCustomizableMouseSensitiveName&gt;</summary>
		public const int CustomizableMouseSensitiveNames = 0x0200;

		///<summary>TArray&lt;FCustomizableGamePadSensitiveName&gt;</summary>
		public const int CustomizableGamePadSensitiveNames = 0x0210;

		///<summary>TArray&lt;FSurportQualityLevel&gt;</summary>
		public const int SupportedQualityLevels = 0x0220;

		///<summary>TArray&lt;FScreenResolution&gt;</summary>
		public const int SupportedScreenResolutions = 0x0230;

		///<summary>FStringAssetReference</summary>
		public const int MouseSensitivityCurve = 0x0240;

		///<summary>FStringAssetReference</summary>
		public const int GammaCurve = 0x0250;

		///<summary>TArray&lt;FColorBlindType&gt;</summary>
		public const int ColorBlindTypes = 0x0260;

		///<summary>TArray&lt;FPresetColor&gt;</summary>
		public const int CrosshairColors = 0x0270;

		///<summary>TArray&lt;FKeyInputModeName&gt;</summary>
		public const int KeyInputModeNames = 0x0280;

		///<summary>TArray&lt;FUiType&gt;</summary>
		public const int MiniMapTypeList = 0x0290;

		///<summary>float</summary>
		public const int MinimumScreenResolutionRatio = 0x02A0;

		///<summary>FScreenResolution</summary>
		public const int MinimumScreenResolution = 0x02A4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData07 = 0x02AC;

		///<summary>TArray&lt;FTeamColorAndIcon&gt;</summary>
		public const int OverrideMarkerColorAndIcons = 0x02B0;

		///<summary>float</summary>
		public const int PunchClientHitLeeway_Attacker = 0x02C0;

		///<summary>float</summary>
		public const int PunchClientHitLeeway_Victim = 0x02C4;

		///<summary>float</summary>
		public const int PunchClientHitLeeway_VictimInPlace = 0x02C8;

		///<summary>float</summary>
		public const int ClientSideHitLeeway = 0x02CC;

		///<summary>float</summary>
		public const int ClientSideHitLeewayInPlace = 0x02D0;

		///<summary>float</summary>
		public const int LogClientSideHitLeeway = 0x02D4;

		///<summary>float</summary>
		public const int ClientSideOriginDistanceLeeway = 0x02D8;

		///<summary>float</summary>
		public const int ClientSideOriginDistanceLeewayInPlace = 0x02DC;

		///<summary>float</summary>
		public const int ClientSideOriginDistanceMax = 0x02E0;

		///<summary>float</summary>
		public const int TravelDistanceLeeway = 0x02E4;

		///<summary>float</summary>
		public const int AllowedHitLag = 0x02E8;

		///<summary>float</summary>
		public const int LogMinHitLag = 0x02EC;

		///<summary>float</summary>
		public const int HackDetectionSpeed = 0x02F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x02F4;

		///<summary>TArray&lt;FOverrideScalability&gt;</summary>
		public const int OverrideScalabilities = 0x02F8;

		///<summary>float</summary>
		public const int FakeDoorBlockMaxY = 0x0308;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData09 = 0x030C;

		///<summary>TArray&lt;FReportCauseData&gt;</summary>
		public const int ReportCauses = 0x0310;

		///<summary>TArray&lt;FSubjectToReport&gt;</summary>
		public const int SubjectToReport = 0x0320;

		///<summary>float</summary>
		public const int FreelookRecoveryInterpSpeed = 0x0330;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData10 = 0x0334;

		///<summary>TMap&lt;FName,float&gt;</summary>
		public const int GamepadSensitiveMultiplier = 0x0338;

		///<summary>float</summary>
		public const int GamePadInnerDeadZone = 0x0388;

		///<summary>float</summary>
		public const int GamePadOutDeadZoneAcceleration = 0x038C;

		///<summary>float</summary>
		public const int GamePadOutMaxAxisValue = 0x0390;

		///<summary>float</summary>
		public const int GamePadAccelerationStandardFps = 0x0394;

		///<summary>float</summary>
		public const int AimAssistDecisionRadius = 0x0398;

		///<summary>bool</summary>
		public const int bApplyInputValue = 0x039C;

		///<summary>bool</summary>
		public const int bIgnorePadSensitive = 0x039D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData11 = 0x039E;

		///<summary>float</summary>
		public const int InsensitiveZone = 0x03A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData12 = 0x03A4;

		///<summary>TArray&lt;FAimAssistData&gt;</summary>
		public const int AimCameraAssists = 0x03A8;

		///<summary>TArray&lt;FAimAssistData&gt;</summary>
		public const int ADSCameraAssists = 0x03B8;

		///<summary>TArray&lt;FAimAssistData&gt;</summary>
		public const int Scope2XCameraAssists = 0x03C8;

		///<summary>TArray&lt;FAimAssistData&gt;</summary>
		public const int Scope4XCameraAssists = 0x03D8;

		///<summary>TArray&lt;FAimAssistData&gt;</summary>
		public const int Scope8XCameraAssists = 0x03E8;

		///<summary>TArray&lt;FAimAssistData&gt;</summary>
		public const int Scope15XCameraAssists = 0x03F8;

		///<summary>bool</summary>
		public const int bIsESports = 0x0408;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData13 = 0x0409;

		///<summary>FStringAssetReference</summary>
		public const int DialogUMGWidgetClassStringAssetReference = 0x0410;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData14 = 0x0420;

		///<summary>UCurveFloat *</summary>
		public const int LoadedMouseSensitivityCurve = 0x0470;

		///<summary>UCurveFloat *</summary>
		public const int LoadedGammaCurve = 0x0478;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int CharacterStudioRenderTarget = 0x0480;

		///<summary>TArray&lt;FAnimatableCustomizableObjectData&gt;</summary>
		public const int AnimatableCustomizableDatas = 0x0488;

		///<summary>TMap&lt;FName,float&gt;</summary>
		public const int NotifyDistanceLimitMap = 0x0498;

	}

	public class UTslGameInstance
	{
		///<summary>TArray&lt;FString&gt;</summary>
		public const int PersistentUClassPaths = 0x00F0;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int PersistentUClasses = 0x0100;

		///<summary>FString</summary>
		public const int WelcomeScreenMap = 0x0110;

		///<summary>bool</summary>
		public const int bUseLobbyWidget = 0x0120;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0121;

		///<summary>int</summary>
		public const int LobbyWidgetZOrder = 0x0124;

		///<summary>ULobbyLink *</summary>
		public const int LobbyLink = 0x0128;

		///<summary>UVivoxManager *</summary>
		public const int VivoxManager = 0x0130;

		///<summary>UReporterManager *</summary>
		public const int ReporterManager = 0x0138;

		///<summary>FTslStartParameter</summary>
		public const int StartParamter = 0x0140;

		///<summary>unsigned char[0xC8]</summary>
		public const int UnknownData01 = 0x01C0;

		///<summary>UClass *</summary>
		public const int LobbyWidgetClass = 0x0288;

		///<summary>unsigned char[0x150]</summary>
		public const int UnknownData02 = 0x0290;

		///<summary>ULobbyWidget *</summary>
		public const int LobbyWidget = 0x03E0;

		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData03 = 0x03E8;

		///<summary>TArray&lt;FReplayKillEventItem&gt;</summary>
		public const int ReplayKillEventItems = 0x0490;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEnumerateReplayKillEventsDone = 0x04A0;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData04 = 0x04B0;

		///<summary>TArray&lt;FReplayGroggyEventItem&gt;</summary>
		public const int ReplayGroggyEventItems = 0x0550;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEnumerateReplayGroggyEventsDone = 0x0560;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData05 = 0x0570;

		///<summary>TArray&lt;FReplayItem&gt;</summary>
		public const int ReplayItemList = 0x0580;

		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData06 = 0x0590;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGetReplayListDone = 0x05C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGotoTimelineDone = 0x05D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRecordStarted = 0x05E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDownloadZippedReplayProgressDelegate = 0x05F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDownloadZippedReplayCompleteDelegate = 0x0608;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData07 = 0x0618;

		///<summary>int</summary>
		public const int MaxReplaysForNullStreamer = 0x0640;

		///<summary>int</summary>
		public const int NumReplaysForNullStreamer = 0x0644;

		///<summary>int</summary>
		public const int NumReplaysToKeepForNullStreamer = 0x0648;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData08 = 0x064C;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeepAndDeleteOldestReplaysDoneDelegate = 0x0650;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData09 = 0x0660;

		///<summary>UGameEventObserver *</summary>
		public const int GameEventObserver = 0x0670;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData10 = 0x0678;

		///<summary>FTslReplaySummary</summary>
		public const int ReplaySummaryForPlayback = 0x06A0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGetReplaySummaryDone = 0x0720;

		///<summary>bool</summary>
		public const int bIsStartedFromReplayListMap = 0x0730;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData11 = 0x0731;

		///<summary>ATslPlayerState *</summary>
		public const int CachedDemoPlayerState = 0x0738;

		///<summary>unsigned char[0x140]</summary>
		public const int UnknownData12 = 0x0740;

		///<summary>UHighlightSession *</summary>
		public const int HighlightSession = 0x0880;

		///<summary>unsigned char[0xE8]</summary>
		public const int UnknownData13 = 0x0888;

	}

	public class ALobbyHUD
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRequestSystemMenu = 0x0A00;

		///<summary>UCurveFloat *</summary>
		public const int CameraTransitionCurve = 0x0A10;

		///<summary>float</summary>
		public const int CameraTransitionElapsedTime = 0x0A18;

		///<summary>bool</summary>
		public const int bIsCameraTransitionPlaying = 0x0A1C;

		///<summary>ELobbyCameraStates</summary>
		public const int LastCameraState = 0x0A1D;

		///<summary>ELobbyCameraStates</summary>
		public const int FromCameraState = 0x0A1E;

		///<summary>ELobbyCameraStates</summary>
		public const int ToCameraState = 0x0A1F;

		///<summary>FName</summary>
		public const int MainMenuStreamingLevelName = 0x0A70;

		///<summary>FName</summary>
		public const int CustomizationStreamingLevelName = 0x0A78;

		///<summary>TArray&lt;FTransform&gt;</summary>
		public const int CachedLobbyCharacterTransforms = 0x0A80;

		///<summary>UCurveFloat *</summary>
		public const int FadeInOutCurve = 0x0A90;

		///<summary>ATslPostProcessEffect *</summary>
		public const int LobbyPPE = 0x0A98;

		///<summary>float</summary>
		public const int FadeInOutEffectElapsedTime = 0x0AA0;

		///<summary>bool</summary>
		public const int bIsFadeInOutEffectPlaying = 0x0AA4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0AA5;

		///<summary>FTimerHandle</summary>
		public const int TimerHandle_FadeInOut = 0x0AA8;

		///<summary>ATslPostProcessEffect *</summary>
		public const int MainMenuPPE = 0x0AB0;

		///<summary>float</summary>
		public const int CachedDOFFarBlueSize = 0x0AB8;

		///<summary>ELobbyBlurChangingStates</summary>
		public const int BlurChangingState = 0x0ABC;

		///<summary>bool</summary>
		public const int bInitCameraTransition = 0x0ABD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0ABE;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCreateCharacter = 0x0AC0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDestroyCharacter = 0x0AD0;

		///<summary>FString</summary>
		public const int StartURL = 0x0AE0;

		///<summary>TArray&lt;UCoherentCommonBinder * &gt;</summary>
		public const int CommonBinders = 0x0AF0;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x0B00;

		///<summary>ACameraActor *</summary>
		public const int MainCamera = 0x0B08;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData02 = 0x0B10;

		///<summary>UClass *</summary>
		public const int LobbyCharacterMaleClass = 0x0B30;

		///<summary>UClass *</summary>
		public const int LobbyCharacterFemaleClass = 0x0B38;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData03 = 0x0B40;

		///<summary>FViewTargetTransitionParams</summary>
		public const int ViewTargetTransitionParams = 0x0B90;

	}

	public class ATslWelcomeBaseHUD
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0548;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnStateChanged = 0x0558;

		///<summary>EWelcomeState</summary>
		public const int WelcomeState = 0x0568;

		///<summary>unsigned char[0x27]</summary>
		public const int UnknownData01 = 0x0569;

	}

	public class ATslEntryPlayerController
	{
		///<summary>UVivoxLobbyComponent *</summary>
		public const int VivoxComponent = 0x06F0;

	}

	public class APerfBotPlayerController
	{
		///<summary>UClass *</summary>
		public const int WeaponType = 0x0B40;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0B48;

	}

	public class ATslDemoSpectator
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0B40;

	}

	public class ATslBotAIController
	{
		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x04A8;

	}

	public class ACharacterBreathBuff
	{
		///<summary>float</summary>
		public const int BreathPerTick = 0x0410;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0414;

	}

	public class AHealOverTimeBuff
	{
		///<summary>float</summary>
		public const int HealPerTick = 0x0410;

		///<summary>float</summary>
		public const int HealLimit = 0x0414;

		///<summary>int</summary>
		public const int BuffCount = 0x0418;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x041C;

	}

	public class UTslCameraComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x09A0;

	}

	public class ATslCharacterProxy
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x07E0;

		///<summary>TArray&lt;UWeaponClone * &gt;</summary>
		public const int ArmedWeapons = 0x07E8;

		///<summary>UWeaponAnimInfoComponent *</summary>
		public const int WeaponAnimInfoComponent = 0x07F8;

		///<summary>float</summary>
		public const int WeaponUpdateIntervalSeconds = 0x0800;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0804;

	}

	public class UTslCharacterSpringArmComponent
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0480;

		///<summary>FVector</summary>
		public const int DefaultSocketOffset = 0x0484;

		///<summary>FVector</summary>
		public const int IndoorSocketOffset = 0x0490;

		///<summary>FVector</summary>
		public const int LeanLeftDefaultSocketOffsetAddition = 0x049C;

		///<summary>FVector</summary>
		public const int LeanRightDefaultSocketOffsetAddition = 0x04A8;

		///<summary>FVector</summary>
		public const int LeftShoulderAimingSocketOffset = 0x04B4;

		///<summary>FVector</summary>
		public const int RightShoulderAimingSocketOffset = 0x04C0;

		///<summary>FVector</summary>
		public const int LeanLeftAimedSocketOffsetAddition = 0x04CC;

		///<summary>FVector</summary>
		public const int LeanRightAimedSocketOffsetAddition = 0x04D8;

		///<summary>FVector</summary>
		public const int SprintSocketOffsetAddition = 0x04E4;

		///<summary>float</summary>
		public const int CrouchSocketOffsetZAddition = 0x04F0;

		///<summary>float</summary>
		public const int CrouchSocketOffsetMovementZAddition = 0x04F4;

		///<summary>float</summary>
		public const int ProneScoketOffsetZAddition = 0x04F8;

		///<summary>float</summary>
		public const int SocketOffsetInterpSpeed = 0x04FC;

		///<summary>FVector</summary>
		public const int DefaultTargetOffset = 0x0500;

		///<summary>FVector</summary>
		public const int IndoorTargetOffset = 0x050C;

		///<summary>FVector</summary>
		public const int AimingTargetOffset = 0x0518;

		///<summary>float</summary>
		public const int TargetOffsetInterpSpeed = 0x0524;

		///<summary>float</summary>
		public const int TargetOffsetInterpSpeed_Vaulting = 0x0528;

		///<summary>float</summary>
		public const int DefaultSpringArmLength = 0x052C;

		///<summary>float</summary>
		public const int IndoorSpringArmLength = 0x0530;

		///<summary>float</summary>
		public const int AimingSpringArmLength = 0x0534;

		///<summary>float</summary>
		public const int BlockingCompressOffset = 0x0538;

		///<summary>float</summary>
		public const int BlockingCompressCrouchOffset = 0x053C;

		///<summary>float</summary>
		public const int SpringArmLengthInterpSpeed = 0x0540;

		///<summary>float</summary>
		public const int AimingSpringArmLengthInterpSpeed = 0x0544;

		///<summary>float</summary>
		public const int VaultingSpringArmLengthInterpSpeed = 0x0548;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x054C;

		///<summary>float</summary>
		public const int SpringArmRestoreInterpSpeed = 0x0550;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x0554;

	}

	public class UTslCharacterValidateLocationComponent
	{
		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>float</summary>
		public const int InvalidUndergroundCheckInterval = 0x01EC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01F0;

		///<summary>float</summary>
		public const int InvalidUndergroundCheckLength = 0x01F4;

		///<summary>float</summary>
		public const int MaxAdjustRange = 0x01F8;

		///<summary>int</summary>
		public const int MaxAdjustCount = 0x01FC;

	}

	public class UTslChatWidgetStyle
	{
		///<summary>FTslChatStyle</summary>
		public const int ChatStyle = 0x0030;

	}

	public class UTslCheatManager
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UTslCoherentWidget
	{
		///<summary>UClass *</summary>
		public const int WidgetBinderClass = 0x0490;

		///<summary>UCoherentWidgetBinder *</summary>
		public const int WidgetBinder = 0x0498;

	}

	public class UTslConsole
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0130;

	}

	public class UTslConsoleSetting
	{
		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteItemPaths = 0x0070;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteItemKinds = 0x0080;

		///<summary>TArray&lt;FAutoCompleteVehiclePaths&gt;</summary>
		public const int AutoCompleteVehiclePaths = 0x0090;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteMaleBody = 0x00A0;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteMaleHair = 0x00B0;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteMaleFace = 0x00C0;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteFemaleBody = 0x00D0;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteFemaleHair = 0x00E0;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int AutoCompleteFemaleFace = 0x00F0;

	}

	public class ATslDamageField
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>float</summary>
		public const int DamageRadius = 0x03B4;

		///<summary>UParticleSystem *</summary>
		public const int DamageFieldFX = 0x03B8;

		///<summary>int</summary>
		public const int Damage = 0x03C0;

		///<summary>float</summary>
		public const int DamageInterval = 0x03C4;

		///<summary>UClass *</summary>
		public const int DamageType = 0x03C8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x03D0;

		///<summary>UClass *</summary>
		public const int DebuffTemplate = 0x03E0;

	}

	public class ATslDamageFieldContainer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>TArray&lt;FDamageFieldLayout&gt;</summary>
		public const int DamageFieldLayouts = 0x03B8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03C8;

		///<summary>UClass *</summary>
		public const int DamageFieldTemplate = 0x03D0;

		///<summary>bool</summary>
		public const int FlameInWall = 0x03D8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x03D9;

		///<summary>int</summary>
		public const int FlameMaxCountInWall = 0x03DC;

		///<summary>float</summary>
		public const int FlameDelayInWall = 0x03E0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData03 = 0x03E4;

	}

	public class UTslDeathCameraComponent
	{
		///<summary>float</summary>
		public const int MaxCameraDistance = 0x01E0;

		///<summary>float</summary>
		public const int CollisionDistanceFactor = 0x01E4;

		///<summary>float</summary>
		public const int DeathFollowBlendTime = 0x01E8;

		///<summary>TEnumAsByte&lt;EViewTargetBlendFunction&gt;</summary>
		public const int DeathFollowBlendFunc = 0x01EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x01ED;

		///<summary>float</summary>
		public const int DeathFollowBlendExp = 0x01F0;

		///<summary>float</summary>
		public const int DeathFollowTime = 0x01F4;

		///<summary>float</summary>
		public const int DefaultFreeCameraArmLength = 0x01F8;

		///<summary>FVector</summary>
		public const int DeathLocationOffset = 0x01FC;

		///<summary>ATslCharacter *</summary>
		public const int DeathCharacter = 0x0208;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0210;

	}

	public class ATslDestructibleContainer
	{
		///<summary>unsigned char:1</summary>
		public const int bFlag = 0x03B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B1;

	}

	public class ATslDoor
	{
		///<summary>UStaticMeshComponent *</summary>
		public const int DoorMeshComponent = 0x03C0;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x03C8;

		///<summary>UInteractionComponent *</summary>
		public const int Interaction = 0x03D0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x03D8;

		///<summary>UDestructibleMesh *</summary>
		public const int DoorDestructibleMesh = 0x03F8;

		///<summary>unsigned char:1</summary>
		public const int bDoorOpened = 0x0400;

		///<summary>unsigned char:1</summary>
		public const int bReverseRotation = 0x0400;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0401;

		///<summary>float</summary>
		public const int OpenAngle = 0x0404;

		///<summary>UAkAudioEvent *</summary>
		public const int OpenSound = 0x0408;

		///<summary>UAkAudioEvent *</summary>
		public const int CloseSound = 0x0410;

		///<summary>UCurveFloat *</summary>
		public const int OpenCurve = 0x0418;

		///<summary>float</summary>
		public const int OpenCurveDuration = 0x0420;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0424;

		///<summary>UCurveFloat *</summary>
		public const int CloseCurve = 0x0428;

		///<summary>float</summary>
		public const int CloseCurveDuration = 0x0430;

		///<summary>float</summary>
		public const int PointDamageImpulse = 0x0434;

		///<summary>float</summary>
		public const int PointDamageRadius = 0x0438;

		///<summary>float</summary>
		public const int BreakingRadius = 0x043C;

		///<summary>float</summary>
		public const int BreakingImpulse = 0x0440;

		///<summary>float</summary>
		public const int BreakingMinDamage = 0x0444;

		///<summary>float</summary>
		public const int DamageAccumulateTimeout = 0x0448;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x044C;

		///<summary>FName</summary>
		public const int TopImpactSoketName = 0x0450;

		///<summary>FName</summary>
		public const int CenterImpactSoketName = 0x0458;

		///<summary>FName</summary>
		public const int BottomImpactSoketName = 0x0460;

		///<summary>unsigned char[0x1C8]</summary>
		public const int UnknownData04 = 0x0468;

		///<summary>FDoorBreakingStateLegacy</summary>
		public const int DoorBreakingState = 0x0630;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData05 = 0x0631;

	}

	public class ATslExplosionEffect
	{
		///<summary>UParticleSystem *</summary>
		public const int ExplosionFX = 0x03B0;

		///<summary>UPointLightComponent *</summary>
		public const int ExplosionLight = 0x03B8;

		///<summary>float</summary>
		public const int ExplosionLightFadeOut = 0x03C0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03C4;

		///<summary>UAkAudioEvent *</summary>
		public const int ExplosionSound = 0x03C8;

		///<summary>FDecalEffectDataSet</summary>
		public const int DecalEffectDataSet = 0x03D0;

		///<summary>float</summary>
		public const int DecalSpawnDelayTime = 0x0538;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x053C;

		///<summary>FHitResult</summary>
		public const int SurfaceHit = 0x0540;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x05C8;

	}

	public class ATslFence
	{
		///<summary>USplineComponent *</summary>
		public const int SplineComponent = 0x03B0;

		///<summary>ETslFenceSelector</summary>
		public const int BeginSelector = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B9;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh1 = 0x03C0;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh2 = 0x03C8;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh3 = 0x03D0;

		///<summary>UStaticMesh *</summary>
		public const int BeginMesh4 = 0x03D8;

		///<summary>ETslFenceSelector</summary>
		public const int EndSelector = 0x03E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03E1;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh1 = 0x03E8;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh2 = 0x03F0;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh3 = 0x03F8;

		///<summary>UStaticMesh *</summary>
		public const int EndMesh4 = 0x0400;

		///<summary>bool</summary>
		public const int bUseRandomForMiddle = 0x0408;

		///<summary>bool</summary>
		public const int bUseMiddleSegmentsInOrder = 0x0409;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x040A;

		///<summary>float</summary>
		public const int UnitLengthForMiddle = 0x040C;

		///<summary>float</summary>
		public const int UnitSpacingForMiddle = 0x0410;

		///<summary>float</summary>
		public const int PivotOffsetForMiddle = 0x0414;

		///<summary>FRandomStream</summary>
		public const int RandomStreamForMiddle = 0x0418;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh1 = 0x0420;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh2 = 0x0428;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh3 = 0x0430;

		///<summary>UStaticMesh *</summary>
		public const int MiddleMesh4 = 0x0438;

		///<summary>FCollisionProfileName</summary>
		public const int FenceCollisionProfile = 0x0440;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0448;

	}

	public class UTslReactionData
	{
		///<summary>float</summary>
		public const int DestroyDelay = 0x0030;

		///<summary>FVehicleReactionData</summary>
		public const int VehicleReactionData = 0x0034;

		///<summary>FRadialDamageReactionData</summary>
		public const int RadialDamageReactionData = 0x0040;

		///<summary>FPointDamageReactionData</summary>
		public const int PointDamageReactionData = 0x004C;

		///<summary>int</summary>
		public const int DependancyCountBySibling = 0x005C;

		///<summary>UAkAudioEvent *</summary>
		public const int PhysicsReactionSoundAk = 0x0060;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructibleReactionSoundAk = 0x0068;

	}

	public class UTslReactionComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x09E0;

		///<summary>unsigned char:1</summary>
		public const int bPendingDestroy = 0x09F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x09F1;

		///<summary>UTslReactionData *</summary>
		public const int ReactionData = 0x09F8;

		///<summary>UDestructibleMesh *</summary>
		public const int ReactionDM = 0x0A00;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0A08;

		///<summary>UDestructibleComponent *</summary>
		public const int ReactionDestructible = 0x0A10;

		///<summary>UStaticMeshComponent *</summary>
		public const int ReactionStaticMeshComponent = 0x0A18;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData03 = 0x0A20;

	}

	public class ATslBreakableFence
	{
		///<summary>UTslReactionData *</summary>
		public const int ReactionData = 0x0450;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible1 = 0x0458;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible2 = 0x0460;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible3 = 0x0468;

		///<summary>UDestructibleMesh *</summary>
		public const int BeginDestuctible4 = 0x0470;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible1 = 0x0478;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible2 = 0x0480;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible3 = 0x0488;

		///<summary>UDestructibleMesh *</summary>
		public const int EndDestuctible4 = 0x0490;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible1 = 0x0498;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible2 = 0x04A0;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible3 = 0x04A8;

		///<summary>UDestructibleMesh *</summary>
		public const int MiddleDestuctible4 = 0x04B0;

	}

	public class UTslPerformanceTestComponent
	{
		///<summary>unsigned char[0x140]</summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class ATslGameMode
	{
		///<summary>UClass *</summary>
		public const int MalePawnClass = 0x0480;

		///<summary>UClass *</summary>
		public const int PerfBotPlayerControllerClass = 0x0488;

		///<summary>UClass *</summary>
		public const int ModeControllerClass = 0x0490;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int AdditionalModeControllerClasses = 0x0498;

		///<summary>UClass *</summary>
		public const int InitialItemDonatorClass = 0x04A8;

		///<summary>TArray&lt;FMatchPreparerClass&gt;</summary>
		public const int MatchPreparerClasses = 0x04B0;

		///<summary>EMatchStartType</summary>
		public const int MatchStartType = 0x04C0;

		///<summary>ECameraViewBehaviour</summary>
		public const int CameraViewBehaviour = 0x04C1;

		///<summary>bool</summary>
		public const int PlayerRespawn = 0x04C2;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x04C3;

		///<summary>int</summary>
		public const int PostMatchWaitingTime = 0x04C4;

		///<summary>int</summary>
		public const int CustomGamePostMatchWaitingTime = 0x04C8;

		///<summary>int</summary>
		public const int ESportsPostMatchWaitingTime = 0x04CC;

		///<summary>int</summary>
		public const int ServerQuitAfterLeavingMapTime = 0x04D0;

		///<summary>int</summary>
		public const int MinPlayers = 0x04D4;

		///<summary>int</summary>
		public const int PlayerSpawnTryMaxCount = 0x04D8;

		///<summary>bool</summary>
		public const int bEnablePerfBotInPIE = 0x04DC;

		///<summary>bool</summary>
		public const int bEnablePerfBotLogin = 0x04DD;

		///<summary>bool</summary>
		public const int bIsPerfBotSpawnToRandomPosition = 0x04DE;

		///<summary>bool</summary>
		public const int bCanRestartPerfBot = 0x04DF;

		///<summary>bool</summary>
		public const int bEnableObserverInPIE = 0x04E0;

		///<summary>bool</summary>
		public const int IsBattleRoyale = 0x04E1;

		///<summary>bool</summary>
		public const int bStartPlayerAtMatchStart = 0x04E2;

		///<summary>bool</summary>
		public const int bShouldSpawnAtStartSpot = 0x04E3;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x04E4;

		///<summary>bool</summary>
		public const int bIsEditorTestZombieMode = 0x04E5;

		///<summary>bool</summary>
		public const int bIsCustomGame = 0x04E6;

		///<summary>bool</summary>
		public const int bCanAllSpectate = 0x04E7;

		///<summary>FCustomGameUpdateCharacterInfo</summary>
		public const int CustomGameUpdateCharacterInfo = 0x04E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x04FC;

		///<summary>TArray&lt;FLimitCustomStringParameter&gt;</summary>
		public const int LimitCustomStringParameters = 0x0500;

		///<summary>float</summary>
		public const int MultiplierBlueZone = 0x0510;

		///<summary>float</summary>
		public const int BlueZoneCentralizationFactor = 0x0514;

		///<summary>float</summary>
		public const int MultiplierCarePackage = 0x0518;

		///<summary>FRedZoneCustomOption</summary>
		public const int RedZoneCustomOption = 0x051C;

		///<summary>TArray&lt;FBlueZoneCustomOption&gt;</summary>
		public const int BlueZoneCustomOptions = 0x0538;

		///<summary>int</summary>
		public const int WarmupTime = 0x0548;

		///<summary>int</summary>
		public const int EditorTestTeamMemberCount = 0x054C;

		///<summary>TMap&lt;FString,URewardData * &gt;</summary>
		public const int RewardDataMap = 0x0550;

		///<summary>URewardData *</summary>
		public const int RewardData = 0x05A0;

		///<summary>ATslPlayerState *</summary>
		public const int WinnerPlayerState = 0x05A8;

		///<summary>int</summary>
		public const int WinnerTeam = 0x05B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x05B4;

		///<summary>UClass *</summary>
		public const int ItemSpawnProcessorClass = 0x05B8;

		///<summary>UClass *</summary>
		public const int ThingSpawnProcessorClass = 0x05C0;

		///<summary>UClass *</summary>
		public const int BasicBeltItemClassForNoBelt = 0x05C8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x05D0;

		///<summary>UItemSpawnProcessor *</summary>
		public const int ItemSpawnProcessor = 0x05D8;

		///<summary>UThingSpawnProcessor *</summary>
		public const int ThingSpawnProcessor = 0x05E0;

		///<summary>UGeneralItemSpawner *</summary>
		public const int InitialItemDonator = 0x05E8;

		///<summary>UMatchPreparer *</summary>
		public const int MatchPreparer = 0x05F0;

		///<summary>AModeController *</summary>
		public const int ModeController = 0x05F8;

		///<summary>ADroppedItemGridManager *</summary>
		public const int DroppedItemGridManager = 0x0600;

		///<summary>TArray&lt;AModeController * &gt;</summary>
		public const int AdditinalModeControllers = 0x0608;

		///<summary>unsigned char[0x98]</summary>
		public const int UnknownData05 = 0x0618;

		///<summary>TMap&lt;FString,APlayerState * &gt;</summary>
		public const int JoinedUserPlayerStateMap = 0x06B0;

		///<summary>TArray&lt;FTeams&gt;</summary>
		public const int Teams = 0x0700;

		///<summary>unsigned char[0xB0]</summary>
		public const int UnknownData06 = 0x0710;

	}

	public class UTslGameUserSettings
	{
		///<summary>float</summary>
		public const int ScreenScale = 0x0108;

		///<summary>float</summary>
		public const int Gamma = 0x010C;

		///<summary>bool</summary>
		public const int bIsLanMatch = 0x0110;

		///<summary>bool</summary>
		public const int bIsMasterSoundMute = 0x0111;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0112;

		///<summary>float</summary>
		public const int MasterSoundVolume = 0x0114;

		///<summary>bool</summary>
		public const int bIsEffectSoundMute = 0x0118;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0119;

		///<summary>float</summary>
		public const int EffectSoundVolume = 0x011C;

		///<summary>bool</summary>
		public const int bIsUISoundMute = 0x0120;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0121;

		///<summary>float</summary>
		public const int UISoundVolume = 0x0124;

		///<summary>bool</summary>
		public const int bIsBGMSoundMute = 0x0128;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0129;

		///<summary>float</summary>
		public const int BGMSoundVolume = 0x012C;

		///<summary>bool</summary>
		public const int bIsVoiceInputMute = 0x0130;

		///<summary>bool</summary>
		public const int bIsVoiceOutputMute = 0x0131;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x0132;

		///<summary>int</summary>
		public const int VoiceInputVolume = 0x0134;

		///<summary>int</summary>
		public const int VoiceOutputVolume = 0x0138;

		///<summary>bool</summary>
		public const int bUsePushToTalk = 0x013C;

		///<summary>bool</summary>
		public const int bUseGlobalVoice = 0x013D;

		///<summary>bool</summary>
		public const int bUseTeamVoice = 0x013E;

		///<summary>bool</summary>
		public const int bSavedGraphicOption = 0x013F;

		///<summary>bool</summary>
		public const int bMotionBlur = 0x0140;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x0141;

		///<summary>FString</summary>
		public const int CultureName = 0x0148;

		///<summary>FString</summary>
		public const int LastCultureName = 0x0158;

		///<summary>FCustomInputSettings</summary>
		public const int CustomInputSettins = 0x0168;

		///<summary>int</summary>
		public const int SelectMiniMapIndex = 0x01C0;

		///<summary>float</summary>
		public const int FpsCameraFov = 0x01C4;

		///<summary>bool</summary>
		public const int bUseForceFeedback = 0x01C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x01C9;

		///<summary>int</summary>
		public const int ColorBlindType = 0x01CC;

		///<summary>FString</summary>
		public const int CrosshairColorString = 0x01D0;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int GearProfile1 = 0x01E0;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int GearProfile2 = 0x01F0;

		///<summary>EUiShowType</summary>
		public const int FppWeaponIconShowType = 0x0200;

		///<summary>EUiShowType</summary>
		public const int TpsWeaponIconShowType = 0x0201;

		///<summary>EUiShowType</summary>
		public const int FppEquipableItemIconShowType = 0x0202;

		///<summary>bool</summary>
		public const int bUseCharacterCapture = 0x0203;

		///<summary>int</summary>
		public const int WorldMapZoomSpeedLevel = 0x0204;

		///<summary>bool</summary>
		public const int bIconKillfeedEnabled = 0x0208;

		///<summary>ETslInputModes</summary>
		public const int InputModeCrouch = 0x0209;

		///<summary>ETslInputModes</summary>
		public const int InputModeProne = 0x020A;

		///<summary>ETslInputModes</summary>
		public const int InputModeWalk = 0x020B;

		///<summary>ETslInputModes</summary>
		public const int bToggleSprint = 0x020C;

		///<summary>ETslInputModes</summary>
		public const int InputModeHoldRotation = 0x020D;

		///<summary>ETslInputModes</summary>
		public const int InputModeHoldBreath = 0x020E;

		///<summary>ETslInputModes</summary>
		public const int InputModePeek = 0x020F;

		///<summary>ETslInputModes</summary>
		public const int InputModeMap = 0x0210;

		///<summary>ETslInputModes</summary>
		public const int InputModeADS = 0x0211;

		///<summary>ETslInputModes</summary>
		public const int InputModeAim = 0x0212;

		///<summary>bool</summary>
		public const int bEditorApplyOverrideScalability = 0x0213;

		///<summary>bool</summary>
		public const int bUseFreeLookInterp = 0x0214;

		///<summary>bool</summary>
		public const int bUseClientReplay = 0x0215;

		///<summary>bool</summary>
		public const int bUseKillcam = 0x0216;

		///<summary>bool</summary>
		public const int bPreloadingMap = 0x0217;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int PreloadingMaps = 0x0218;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnGameUserSettingApplied = 0x0228;

	}

	public class ATslGameSession
	{
		///<summary>unsigned char[0x318]</summary>
		public const int UnknownData00 = 0x03C8;

	}

	public class ATslGameState
	{
		///<summary>FString</summary>
		public const int MatchId = 0x0410;

		///<summary>FString</summary>
		public const int MatchShortGuid = 0x0420;

		///<summary>bool</summary>
		public const int bIsCustomGame = 0x0430;

		///<summary>bool</summary>
		public const int bIsWinnerZombieTeam = 0x0431;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0432;

		///<summary>int</summary>
		public const int NumTeams = 0x0434;

		///<summary>int</summary>
		public const int RemainingTime = 0x0438;

		///<summary>int</summary>
		public const int MatchElapsedMinutes = 0x043C;

		///<summary>bool</summary>
		public const int bTimerPaused = 0x0440;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0441;

		///<summary>int</summary>
		public const int NumJoinPlayers = 0x0444;

		///<summary>int</summary>
		public const int NumAlivePlayers = 0x0448;

		///<summary>int</summary>
		public const int NumAliveZombiePlayers = 0x044C;

		///<summary>int</summary>
		public const int NumAliveTeams = 0x0450;

		///<summary>int</summary>
		public const int NumStartPlayers = 0x0454;

		///<summary>int</summary>
		public const int NumStartTeams = 0x0458;

		///<summary>FVector</summary>
		public const int SafetyZonePosition = 0x045C;

		///<summary>float</summary>
		public const int SafetyZoneRadius = 0x0468;

		///<summary>FVector</summary>
		public const int PoisonGasWarningPosition = 0x046C;

		///<summary>float</summary>
		public const int PoisonGasWarningRadius = 0x0478;

		///<summary>FVector</summary>
		public const int RedZonePosition = 0x047C;

		///<summary>float</summary>
		public const int RedZoneRadius = 0x0488;

		///<summary>float</summary>
		public const int TotalReleaseDuration = 0x048C;

		///<summary>float</summary>
		public const int ElapsedReleaseDuration = 0x0490;

		///<summary>float</summary>
		public const int TotalWarningDuration = 0x0494;

		///<summary>float</summary>
		public const int ElapsedWarningDuration = 0x0498;

		///<summary>bool</summary>
		public const int bIsGasRelease = 0x049C;

		///<summary>bool</summary>
		public const int bIsTeamMatch = 0x049D;

		///<summary>bool</summary>
		public const int bIsZombieMode = 0x049E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x049F;

		///<summary>float</summary>
		public const int ElapsedGasReleaseDuration = 0x04A0;

		///<summary>FVector</summary>
		public const int LerpSafetyZonePosition = 0x04A4;

		///<summary>float</summary>
		public const int LerpSafetyZoneRadius = 0x04B0;

		///<summary>FVector</summary>
		public const int SafetyZoneBeginPosition = 0x04B4;

		///<summary>float</summary>
		public const int SafetyZoneBeginRadius = 0x04C0;

		///<summary>EMatchStartType</summary>
		public const int MatchStartType = 0x04C4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x04C5;

		///<summary>ALevelAttribute *</summary>
		public const int LevelAttribute = 0x04C8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x04D0;

	}

	public class UTslGameViewportClient
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0610;

		///<summary>UTslConfirmationDialogWidget *</summary>
		public const int DialogUMGWidget = 0x0640;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0648;

	}

	public class UTslGlassWindowComponent
	{
		///<summary>UDestructibleMesh *</summary>
		public const int DestructibleMesh = 0x09E0;

		///<summary>float</summary>
		public const int DestroyDelayAfterDestructed = 0x09E8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x09EC;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructSound = 0x09F0;

		///<summary>float</summary>
		public const int DestructSoundOcclusionRefreshInterval = 0x09F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x09FC;

		///<summary>UDestructibleComponent *</summary>
		public const int DestructibleComponent = 0x0A00;

		///<summary>unsigned char:1</summary>
		public const int bReplicatedOnClient = 0x0A08;

		///<summary>unsigned char:1</summary>
		public const int bDestroyed = 0x0A08;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData02 = 0x0A09;

	}

	public class UTslGunAnimInstance
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFire = 0x0378;

		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponFireCycle = 0x0388;

		///<summary>FScriptMulticastDelegate</summary>
		public const int TriggerOn = 0x0398;

		///<summary>FScriptMulticastDelegate</summary>
		public const int TriggerOff = 0x03A8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int Reload1 = 0x03B8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int Reload2 = 0x03C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneStart = 0x03D8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneSingle = 0x03E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReloadByOneEnd = 0x03F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int WeaponCharge = 0x0408;

		///<summary>FScriptMulticastDelegate</summary>
		public const int FireSelect = 0x0418;

		///<summary>FScriptMulticastDelegate</summary>
		public const int CancelReload = 0x0428;

		///<summary>FName</summary>
		public const int Name_FireMode_Semi = 0x0438;

		///<summary>FName</summary>
		public const int Name_FireMode_Burst = 0x0440;

		///<summary>FName</summary>
		public const int Name_FireMode_Fullauto = 0x0448;

	}

	public class UTslHealthGaugeData
	{
		///<summary>TArray&lt;FHealthColorData&gt;</summary>
		public const int HealthGaugeColors = 0x0030;

		///<summary>FFloatInterval</summary>
		public const int WarningRage = 0x0040;

		///<summary>UCurveLinearColor *</summary>
		public const int GroggyColorCurve = 0x0048;

	}

	public class UTslHornComponent
	{
		///<summary>float</summary>
		public const int LongHornStartingTime = 0x01E0;

		///<summary>float</summary>
		public const int CurrHornKeyPressedTime = 0x01E4;

		///<summary>bool</summary>
		public const int bHornKeyDown = 0x01E8;

		///<summary>bool</summary>
		public const int bPlayingLongHorn = 0x01E9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x01EA;

		///<summary>FHornPlayInfo</summary>
		public const int HornPlayInfo = 0x01EC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01F4;

		///<summary>FHornSoundInfo</summary>
		public const int HornSounds_Local = 0x01F8;

		///<summary>FHornSoundInfo</summary>
		public const int HornSounds_Remote = 0x0208;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0218;

	}

	public class ATslImpactEffect
	{
		///<summary>UParticleSystem *</summary>
		public const int DefaultFX = 0x03B0;

		///<summary>UParticleSystem *</summary>
		public const int ConcreteFX = 0x03B8;

		///<summary>UParticleSystem *</summary>
		public const int DirtFX = 0x03C0;

		///<summary>UParticleSystem *</summary>
		public const int WaterFX = 0x03C8;

		///<summary>UParticleSystem *</summary>
		public const int MetalFX = 0x03D0;

		///<summary>UParticleSystem *</summary>
		public const int WoodFX = 0x03D8;

		///<summary>UParticleSystem *</summary>
		public const int GlassFX = 0x03E0;

		///<summary>UParticleSystem *</summary>
		public const int GrassFX = 0x03E8;

		///<summary>UParticleSystem *</summary>
		public const int FleshFX = 0x03F0;

		///<summary>UAkAudioEvent *</summary>
		public const int AkSound = 0x03F8;

		///<summary>FDecalEffectDataSet</summary>
		public const int DecalEffectDataSet = 0x0400;

		///<summary>FHitResult</summary>
		public const int SurfaceHit = 0x0568;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleCom = 0x05F0;

		///<summary>UAkComponent *</summary>
		public const int AKCom = 0x05F8;

	}

	public class UTslInstancedGlassWindowComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0BE0;

		///<summary>UDestructibleMesh *</summary>
		public const int DestructibleMesh = 0x0BE8;

		///<summary>float</summary>
		public const int DestroyDelayAfterDestructed = 0x0BF0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0BF4;

		///<summary>UAkAudioEvent *</summary>
		public const int DestructSound = 0x0BF8;

		///<summary>float</summary>
		public const int DestructSoundOcclusionRefreshInterval = 0x0C00;

		///<summary>unsigned char:1</summary>
		public const int bReplicatedOnClient = 0x0C04;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData02 = 0x0C05;

		///<summary>TArray&lt;int&gt;</summary>
		public const int DestroyedInstances = 0x0C18;

		///<summary>TArray&lt;int&gt;</summary>
		public const int PendingDestroyInstances = 0x0C28;

		///<summary>unsigned char[0xD8]</summary>
		public const int UnknownData03 = 0x0C38;

	}

	public class UTslInstancedReactionComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0BE0;

		///<summary>TArray&lt;int&gt;</summary>
		public const int PendingDestroyInstances = 0x0BE8;

		///<summary>UTslReactionData *</summary>
		public const int ReactionData = 0x0BF8;

		///<summary>UDestructibleMesh *</summary>
		public const int ReactionDM = 0x0C00;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData01 = 0x0C08;

		///<summary>unsigned char[0xA8]</summary>
		public const int UnknownData02 = 0x0D28;

	}

	public class ATslLevelScriptActor
	{
		///<summary>TArray&lt;FWeatherLevelInfo&gt;</summary>
		public const int WeatherLevelInfos = 0x03B8;

		///<summary>UMaterialParameterCollection *</summary>
		public const int GlobalMPC = 0x03C8;

		///<summary>int</summary>
		public const int SelectedWeatherLevelIndex = 0x03D0;

		///<summary>unsigned char[0x8C]</summary>
		public const int UnknownData00 = 0x03D4;

	}

	public class ATslLobbyLevelScriptActor
	{
		///<summary>FName</summary>
		public const int MainMenuStreamingLevelName = 0x03B8;

		///<summary>FName</summary>
		public const int CustomizationStreamingLevelName = 0x03C0;

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
		public const int PersistentUser = 0x01C8;

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
		public const int UnknownData00 = 0x03B0;

	}

	public class ATslParticle
	{
		///<summary>bool</summary>
		public const int bAutoDestroyOnParticleFinish = 0x03B0;

		///<summary>bool</summary>
		public const int bAutoPlaySound = 0x03B1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03B2;

		///<summary>TArray&lt;FParticleParameter&gt;</summary>
		public const int DefaultParameters = 0x03B8;

		///<summary>EAttachParent</summary>
		public const int AttachParentType = 0x03C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03C9;

		///<summary>FName</summary>
		public const int AttachSocketName = 0x03D0;

		///<summary>EAttachmentRule</summary>
		public const int AttachLocationRule = 0x03D8;

		///<summary>EAttachmentRule</summary>
		public const int AttachRotationRule = 0x03D9;

		///<summary>EAttachmentRule</summary>
		public const int AttachScaleRule = 0x03DA;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData02 = 0x03DB;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleSystem = 0x03E0;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x03E8;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x03F0;

	}

	public class ATslParticleBulletTrail
	{
		///<summary>FVector</summary>
		public const int TargetDestanation = 0x0408;

		///<summary>float</summary>
		public const int BulletSpeed = 0x0414;

		///<summary>UMaterialInterface *</summary>
		public const int UnderWaterMaterialOverride = 0x0418;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0420;

	}

	public class ATslParticleEnvironment
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0408;

		///<summary>float</summary>
		public const int AutoParticleActivateDistance = 0x0418;

		///<summary>float</summary>
		public const int AutoPlayDistance = 0x041C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0420;

	}

	public class ATslPassArea
	{
		///<summary>USphereComponent *</summary>
		public const int SphereComponent = 0x03B0;

		///<summary>float</summary>
		public const int Radius = 0x03B8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03BC;

	}

	public class ATslPassAreaRectangle
	{
		///<summary>UBoxComponent *</summary>
		public const int BoxComponent = 0x03B0;

		///<summary>float</summary>
		public const int Width = 0x03B8;

		///<summary>float</summary>
		public const int Height = 0x03BC;

	}

	public class UTslPawnInputBindingComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnOwnerPossessed = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnOwnerUnPossessed = 0x01F0;

	}

	public class ATslPhysicsVolume
	{
		///<summary>AOceanManager *</summary>
		public const int OceanManager = 0x03F8;

		///<summary>UClass *</summary>
		public const int DefaultWaterSplash = 0x0400;

		///<summary>UClass *</summary>
		public const int VehicleWaterSplash = 0x0408;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int WaterSplashMuteTypes = 0x0410;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0420;

	}

	public class ATslPlayerCameraManager
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x1BB0;

	}

	public class ATslPlayerState
	{
		///<summary>int</summary>
		public const int Ranking = 0x0448;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x044C;

		///<summary>FString</summary>
		public const int AccountId = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bKilled = 0x0460;

		///<summary>bool</summary>
		public const int bShowMapMarker = 0x0461;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0462;

		///<summary>FVector2D</summary>
		public const int MapMarkerPosition = 0x0464;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x046C;

		///<summary>TArray&lt;FReplicatedCastableItem&gt;</summary>
		public const int ReplicatedCastableItems = 0x0470;

		///<summary>bool</summary>
		public const int bEmptyReplicatedCastableItems = 0x0480;

		///<summary>EObserverAuthorityType</summary>
		public const int ObserverAuthorityType = 0x0481;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x0482;

		///<summary>int</summary>
		public const int TeamNumber = 0x0484;

		///<summary>unsigned char:1</summary>
		public const int bIsZombie = 0x0488;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0489;

		///<summary>FTslPlayerScores</summary>
		public const int PlayerScores = 0x048C;

		///<summary>FTslPlayerStatistics</summary>
		public const int PlayerStatistics = 0x0498;

		///<summary>FTslPlayerStatisticsForOwner</summary>
		public const int PlayerStatisticsForOwner = 0x049C;

		///<summary>unsigned char[0xAC]</summary>
		public const int UnknownData05 = 0x04AC;

		///<summary>TArray&lt;FReplicatedEquipableItem&gt;</summary>
		public const int ReplicatedEquipableItems = 0x0558;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData06 = 0x0568;

		///<summary>unsigned char:1</summary>
		public const int bQuitter = 0x0584;

		///<summary>unsigned char[0xFF]</summary>
		public const int UnknownData07 = 0x0585;

		///<summary>float</summary>
		public const int LastHitTime = 0x0684;

		///<summary>FString</summary>
		public const int CurrentAttackerPlayerNetId = 0x0688;

	}

	public class ATslPostProcessEffect
	{
		///<summary>FName</summary>
		public const int TargetPostProcessVolumeName = 0x03B0;

		///<summary>TArray&lt;FPostProcessMaterial&gt;</summary>
		public const int PostProcessMaterials = 0x03B8;

		///<summary>TArray&lt;FPostProcessEffectParameter&gt;</summary>
		public const int DefaultPostProcessEffectParameter = 0x03C8;

		///<summary>TArray&lt;FPostProcessEffectDynamicMaterialState&gt;</summary>
		public const int PostProcessEffectDynamicMaterialStates = 0x03D8;

		///<summary>APostProcessVolume *</summary>
		public const int PostProcessVolume = 0x03E8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x03F0;

	}

	public class ATslWeapon_Projectile
	{
		///<summary>FProjectileWeaponData</summary>
		public const int ProjectileConfig = 0x0AF0;

	}

	public class ATslWeapon_Throwable
	{
		///<summary>FThrowableWeaponData</summary>
		public const int ThrowableConfig = 0x07E0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0880;

		///<summary>EThrowableState</summary>
		public const int ThrowableState = 0x0898;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0899;

		///<summary>FName</summary>
		public const int ThrowWeaponSocketName = 0x08A0;

		///<summary>FVector</summary>
		public const int PawnMotionContributionMultiplier = 0x08A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x08B4;

		///<summary>ATslParticle *</summary>
		public const int CookingEffect = 0x08B8;

		///<summary>AActor *</summary>
		public const int RingAttachment = 0x08C0;

	}

	public class ATslProjectile
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03B0;

		///<summary>UProjectileMovementComponent *</summary>
		public const int MovementComp = 0x03B8;

		///<summary>USphereComponent *</summary>
		public const int CollisionComp = 0x03C0;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleComp = 0x03C8;

		///<summary>UStaticMeshComponent *</summary>
		public const int MeshComp = 0x03D0;

		///<summary>UPhysicsConstraintComponent *</summary>
		public const int MeshConstraint = 0x03D8;

		///<summary>FVector</summary>
		public const int MeshInitialRotationRate = 0x03E0;

		///<summary>bool</summary>
		public const int bSyncServerAndClientRotation = 0x03EC;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData01 = 0x03ED;

		///<summary>bool</summary>
		public const int HideMeshAtExplosion = 0x03F8;

		///<summary>bool</summary>
		public const int ExplosionInWater = 0x03F9;

		///<summary>EProjectileExplosionRotationType</summary>
		public const int ExplosionRotationType = 0x03FA;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData02 = 0x03FB;

		///<summary>FName</summary>
		public const int ParticleToMeshAttachPointName = 0x0400;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0408;

		///<summary>UClass *</summary>
		public const int ExplosionTemplate = 0x0410;

		///<summary>UClass *</summary>
		public const int ExplosionTemplateInAir = 0x0418;

		///<summary>UClass *</summary>
		public const int ExplosionTemplateInWater = 0x0420;

		///<summary>UAkAudioEvent *</summary>
		public const int ImpactSound = 0x0428;

		///<summary>UAkComponent *</summary>
		public const int AkComp = 0x0430;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x0438;

		///<summary>EProjectileExplodeState</summary>
		public const int ExplodeState = 0x0440;

		///<summary>unsigned char:1</summary>
		public const int bActiveParticle = 0x0441;

		///<summary>unsigned char:1</summary>
		public const int bDoTick = 0x0441;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData05 = 0x0442;

		///<summary>FRotator</summary>
		public const int ClientMeshRotation = 0x0444;

		///<summary>FRotator</summary>
		public const int ServerMeshRotation = 0x0450;

		///<summary>float</summary>
		public const int VelocityStopStepDistance = 0x045C;

		///<summary>FVector</summary>
		public const int LastStepLocation = 0x0460;

		///<summary>int</summary>
		public const int StepBuffer = 0x046C;

		///<summary>float</summary>
		public const int FinalInterpSpeed = 0x0470;

		///<summary>bool</summary>
		public const int bConstantInterpStep = 0x0474;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData06 = 0x0475;

		///<summary>float</summary>
		public const int VelocityCheckTimerTick = 0x0478;

		///<summary>bool</summary>
		public const int bPropagateEffectActor = 0x047C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData07 = 0x047D;

		///<summary>FProjectileData</summary>
		public const int ProjectileConfig = 0x0480;

		///<summary>UClass *</summary>
		public const int ReplicatedEffectActor = 0x04B0;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData08 = 0x04B8;

	}

	public class ATslProjectileMolotov
	{
		///<summary>EMolotovSimulationType</summary>
		public const int MolotovSimulation = 0x04E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x04E9;

		///<summary>UClass *</summary>
		public const int DamageFieldContainerTemplate = 0x04F0;

		///<summary>UClass *</summary>
		public const int DamageFieldContainerInWallTemplate = 0x04F8;

		///<summary>UClass *</summary>
		public const int DamageFieldTemplate = 0x0500;

		///<summary>UClass *</summary>
		public const int DamageFieldTemplateInWall = 0x0508;

		///<summary>UClass *</summary>
		public const int FragmentProjectileClass = 0x0510;

		///<summary>int</summary>
		public const int ImpactMaxCount = 0x0518;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData01 = 0x051C;

	}

	public class ATslProjectileRedZone
	{
		///<summary>UAkAudioEvent *</summary>
		public const int CreateSound = 0x04E8;

		///<summary>FText</summary>
		public const int DisplayName = 0x04F0;

	}

	public class ATslProjectile_Flare
	{
		///<summary>float</summary>
		public const int DamageRadius = 0x03B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x03B4;

		///<summary>UClass *</summary>
		public const int DebuffTemplate = 0x03B8;

	}

	public class UTslReactionDoorComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x09E0;

		///<summary>UTslReactionDoorData *</summary>
		public const int ReactionDoorData = 0x09E8;

		///<summary>UDestructibleMesh *</summary>
		public const int DoorDestructibleMesh = 0x09F0;

		///<summary>int</summary>
		public const int HLODChildIndex = 0x09F8;

		///<summary>FDoorBreakingState</summary>
		public const int DoorBreakingState = 0x09FC;

		///<summary>unsigned char[0x43]</summary>
		public const int UnknownData01 = 0x09FD;

	}

	public class UTslSceneCaptureComponent2D
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0A30;

		///<summary>UWorld *</summary>
		public const int World = 0x0A38;

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
		public const int bAutoDestroyOnParticleFinish = 0x03B0;

		///<summary>bool</summary>
		public const int bAutoPlaySound = 0x03B1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03B2;

		///<summary>UParticleSystemComponent *</summary>
		public const int ParticleSystem = 0x03B8;

		///<summary>UAkComponent *</summary>
		public const int AkSound = 0x03C0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x03C8;

	}

	public class UTslSingleton
	{
		///<summary>unsigned char[0x110]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UWeaponsPenetrationConfig *</summary>
		public const int WeaponsPenetrationConfig = 0x0138;

	}

	public class UTslSmokePropagationComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x03F0;

		///<summary>UTslSmokeParticleSystemComponent *</summary>
		public const int SmokeParticle = 0x03F8;

		///<summary>unsigned char[0x19]</summary>
		public const int UnknownData01 = 0x0400;

		///<summary>bool</summary>
		public const int bSystemActivated = 0x0419;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x041A;

		///<summary>UClass *</summary>
		public const int BlockingActorTemplate = 0x0420;

		///<summary>float</summary>
		public const int HalfHeightGlobal = 0x0428;

		///<summary>float</summary>
		public const int HalfHeightLocalScalar = 0x042C;

		///<summary>float</summary>
		public const int GlobalRadius = 0x0430;

		///<summary>float</summary>
		public const int GlobalAngle = 0x0434;

		///<summary>int</summary>
		public const int RadialTryCount = 0x0438;

		///<summary>int</summary>
		public const int LoopCount = 0x043C;

		///<summary>int</summary>
		public const int LastWorkerIndex = 0x0440;

		///<summary>float</summary>
		public const int MaxDistanceFromHost = 0x0444;

		///<summary>float</summary>
		public const int CeilingTraceDistance = 0x0448;

		///<summary>FVector</summary>
		public const int MainParticleVelocityScale_First = 0x044C;

		///<summary>FVector</summary>
		public const int MainParticleVelocityScale_Second = 0x0458;

		///<summary>FVector</summary>
		public const int MainParticleVelocityScale_Third = 0x0464;

		///<summary>float</summary>
		public const int HorizontalRayTraceOffset = 0x0470;

		///<summary>float</summary>
		public const int HorizontalRayRadiusScalar = 0x0474;

		///<summary>float</summary>
		public const int HorizontalRayPropagateOffset = 0x0478;

		///<summary>float</summary>
		public const int BlockerGroundTraceOffset = 0x047C;

		///<summary>FVector</summary>
		public const int LowChildVelocityStaticVector = 0x0480;

		///<summary>FVector</summary>
		public const int HighChildVelocityStaticVector = 0x048C;

		///<summary>FVector2D</summary>
		public const int LowChildVelocityInMap = 0x0498;

		///<summary>FVector2D</summary>
		public const int LowChildVelocityOutMap = 0x04A0;

		///<summary>FVector2D</summary>
		public const int HighChildVelocityInMap = 0x04A8;

		///<summary>FVector2D</summary>
		public const int HighChildVelocityOutMap = 0x04B0;

		///<summary>int</summary>
		public const int CurrentRadialRay = 0x04B8;

		///<summary>int</summary>
		public const int CurrentSpawnedChildCount = 0x04BC;

		///<summary>int</summary>
		public const int MaxTicksAllowed = 0x04C0;

		///<summary>int</summary>
		public const int MaxChildrenAllowed = 0x04C4;

		///<summary>float</summary>
		public const int CustomTickInterval = 0x04C8;

		///<summary>float</summary>
		public const int StartDelay = 0x04CC;

		///<summary>bool</summary>
		public const int bDebugPropagation = 0x04D0;

		///<summary>bool</summary>
		public const int bDebugTick = 0x04D1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData03 = 0x04D2;

		///<summary>float</summary>
		public const int ParticleLifetime = 0x04D4;

		///<summary>FVector2D</summary>
		public const int ParticleLifetimeRandomOffset = 0x04D8;

		///<summary>float</summary>
		public const int ParticleToObjectLifeScale = 0x04E0;

		///<summary>int</summary>
		public const int ParticleAllocationCount = 0x04E4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData04 = 0x04E8;

	}

	public class ATslSpectatorPawn
	{
		///<summary>UClass *</summary>
		public const int ReplayHUD = 0x0438;

		///<summary>UClass *</summary>
		public const int LevelAttribute_BattleRoyalRule = 0x0440;

		///<summary>UClass *</summary>
		public const int LevelAttribute_Erangel = 0x0448;

		///<summary>UClass *</summary>
		public const int LevelAttribute_Desert = 0x0450;

		///<summary>float</summary>
		public const int PlayerInfoMinDistance = 0x0458;

		///<summary>float</summary>
		public const int PlayerInfoMaxDistance = 0x045C;

		///<summary>USpringArmComponent *</summary>
		public const int FreeCameraSpringArmComponent = 0x0460;

		///<summary>UCameraComponent *</summary>
		public const int FreeCameraComponent = 0x0468;

		///<summary>USpringArmComponent *</summary>
		public const int FollowCameraSpringArmComponent = 0x0470;

		///<summary>UCameraComponent *</summary>
		public const int FollowCameraComponent = 0x0478;

		///<summary>UArrowComponent *</summary>
		public const int AudioListener = 0x0480;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0488;

		///<summary>UTslDeathCameraComponent *</summary>
		public const int DeathCameraComponent = 0x0490;

		///<summary>float</summary>
		public const int LocationUpdateIntervalSeconds = 0x0498;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x049C;

		///<summary>float</summary>
		public const int LimitMinFreeCamFov = 0x04A0;

		///<summary>float</summary>
		public const int LimitMaxFreeCamFov = 0x04A4;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x04A8;

		///<summary>float</summary>
		public const int FollowCameraZoomSpeed = 0x04B8;

		///<summary>float</summary>
		public const int LimitTargetArmLength = 0x04BC;

		///<summary>float</summary>
		public const int SpectatableCheckLength = 0x04C0;

		///<summary>float</summary>
		public const int SpectatableCheckScreenRatio = 0x04C4;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x04C8;

		///<summary>UClass *</summary>
		public const int OutlineEffectClass = 0x04E0;

		///<summary>ATslPostProcessEffect *</summary>
		public const int OutlineEffect = 0x04E8;

		///<summary>TArray&lt;FSavedObPos&gt;</summary>
		public const int ArrObPos_Erangel = 0x04F0;

		///<summary>TArray&lt;FSavedObPos&gt;</summary>
		public const int ArrObPos_Desert = 0x0500;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData04 = 0x0510;

		///<summary>UClass *</summary>
		public const int ReplayZoneEffectClass = 0x0558;

		///<summary>UClass *</summary>
		public const int ReplayZoneAreaClass = 0x0560;

		///<summary>ATslPostProcessEffect *</summary>
		public const int ReplayZoneEffect = 0x0568;

		///<summary>AActor *</summary>
		public const int ReplayZoneArea = 0x0570;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPlayerInfoDistanceDelegate = 0x0578;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData05 = 0x0588;

	}

	public class UTslSpectatorPawnMovement
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0280;

		///<summary>float</summary>
		public const int FastMoveModifier = 0x0284;

		///<summary>float</summary>
		public const int SlowMoveModifier = 0x0288;

		///<summary>float</summary>
		public const int MinFreeMoveSpeed = 0x028C;

		///<summary>float</summary>
		public const int MaxFreeMoveSpeed = 0x0290;

		///<summary>float</summary>
		public const int MinFreeMoveSpeedHeight = 0x0294;

		///<summary>float</summary>
		public const int MaxFreeMoveSpeedHeight = 0x0298;

		///<summary>float</summary>
		public const int AbsoluteMinZ = 0x029C;

		///<summary>float</summary>
		public const int AbsoluteMaxZ = 0x02A0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x02A4;

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

		///<summary>TArray&lt;FFloatRange&gt;</summary>
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
		public const int UnknownData00 = 0x03B0;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int StreamerClasses = 0x03B8;

		///<summary>TArray&lt;UTslStreamer * &gt;</summary>
		public const int TslStreamers = 0x03C8;

	}

	public class UTslThrowableTrajectoryViewComponent
	{
		///<summary>UStaticMesh *</summary>
		public const int SplineSegmentMesh = 0x0930;

		///<summary>UMaterialInterface *</summary>
		public const int SplineSegmentMeshMaterial = 0x0938;

		///<summary>FVector2D</summary>
		public const int SegmentMeshScale = 0x0940;

		///<summary>UStaticMesh *</summary>
		public const int ImpactMesh = 0x0948;

		///<summary>UMaterialInterface *</summary>
		public const int ImpactMeshMaterial = 0x0950;

		///<summary>FVector</summary>
		public const int ImpactMeshScale = 0x0958;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0964;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData01 = 0x0964;

		///<summary>float</summary>
		public const int PredictionTime = 0x09B8;

		///<summary>float</summary>
		public const int DistanceScaleFactor = 0x09BC;

		///<summary>FName</summary>
		public const int MaterialParam_NearDepthFadeOrigin = 0x09C0;

		///<summary>FName</summary>
		public const int MaterialParam_FarDepthFadeOrigin = 0x09C8;

		///<summary>float</summary>
		public const int SplineGenerationAngThresholdDeg = 0x09D0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData02 = 0x09D4;

		///<summary>UStaticMeshComponent *</summary>
		public const int ImpactMeshComponent = 0x09E0;

		///<summary>TArray&lt;USplineMeshComponent * &gt;</summary>
		public const int SplineMeshArray = 0x09E8;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int SplineSegmentMeshMaterialDynamic = 0x09F8;

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

		///<summary>TArray&lt;FBlockAction&gt;</summary>
		public const int BlockActions = 0x0268;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int BlockAxises = 0x0278;

		///<summary>bool</summary>
		public const int bGenerateEventOnOpen = 0x0288;

		///<summary>bool</summary>
		public const int bLockMouseCursorInViewport = 0x0289;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x028A;

	}

	public class UUmgBaseWidget
	{
		///<summary>unsigned char:1</summary>
		public const int bUseEmergingAnimation = 0x0260;

		///<summary>unsigned char:1</summary>
		public const int bUseVanishingAnimation = 0x0260;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0261;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int EmergingAnimationBinder = 0x0268;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int VanishingAnimationBinder = 0x0288;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x02A8;

		///<summary>ESlateVisibility</summary>
		public const int PendingVisibility = 0x02C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x02C1;

		///<summary>float</summary>
		public const int VanishingStartTime = 0x02C4;

	}

	public class UTslXboxTeamManageWidget
	{
		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int TeamMemberVerticalBox_Binder = 0x0290;

	}

	public class UBluezoneGpsBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BluezoneGaugeImageBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int BluezoneTimeTextBinder = 0x02F0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int PlayerIconImageBinder = 0x0310;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int MovingAnimationBinder = 0x0338;

		///<summary>TArray&lt;FUmgWidgetBinder_Animation&gt;</summary>
		public const int WarningAnimationList = 0x0358;

		///<summary>TArray&lt;FUmgWidgetBinder_Animation&gt;</summary>
		public const int ReleasingTextAnimationList = 0x0368;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int EnterNextPlayzoneAnimBinder = 0x0378;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int LeaveNextPlayzoneAnimBinder = 0x0398;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WidgetEmergingAnimBinder = 0x03B8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WidgetVanishingAminBinder = 0x03D8;

		///<summary>FName</summary>
		public const int PlayZoneStartParmName = 0x03F8;

		///<summary>FName</summary>
		public const int BluezoneEndParamName = 0x0400;

		///<summary>FName</summary>
		public const int ColorMultiplyParmName = 0x0408;

		///<summary>FLinearColor</summary>
		public const int InNextPlayzoneColorMultiply = 0x0410;

		///<summary>FText</summary>
		public const int WarningTimeTextFormat = 0x0420;

		///<summary>FText</summary>
		public const int ReleaseTimeText = 0x0438;

		///<summary>FSequence_Float</summary>
		public const int BluezoneResetSequence = 0x0450;

		///<summary>FSequence_Float</summary>
		public const int PlayzoneResetSequence = 0x04F0;

		///<summary>FSequence_Float</summary>
		public const int PlayerIconResetSequence = 0x0590;

		///<summary>float</summary>
		public const int PlayerIconPositionX_Start = 0x0630;

		///<summary>float</summary>
		public const int PlayerIconPositionX_End = 0x0634;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0638;

	}

	public class UCharacterStanceBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int StanceIconImageBinder = 0x02C8;

		///<summary>FName</summary>
		public const int IconStateParamName = 0x02F0;

	}

	public class UEquipableItemIconBaseWidget
	{
		///<summary>EEquipSlotID</summary>
		public const int EquipSlotID = 0x02C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x02C9;

		///<summary>FDurabilityColorSet</summary>
		public const int DurabilityColorSet = 0x02D0;

		///<summary>unsigned char:1</summary>
		public const int bUseWrning = 0x02E0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x02E1;

		///<summary>FFloatInterval</summary>
		public const int WarningRange = 0x02E4;

		///<summary>EEquipableItemIconVisibility</summary>
		public const int IconVisibilityType = 0x02EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x02ED;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int IconImageBinder = 0x02F0;

		///<summary>FName</summary>
		public const int IconTexParamName = 0x0318;

		///<summary>FName</summary>
		public const int IconColorParamName = 0x0320;

		///<summary>FLinearColor</summary>
		public const int DefaultColor = 0x0328;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimBinder = 0x0338;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int NoBagSpaceAnimBinder = 0x0358;

	}

	public class UHudMainBaseWidget
	{
		///<summary>TArray&lt;FHudUiConfig&gt;</summary>
		public const int GeneralUiConfigs = 0x02C8;

	}

	public class UInteractionBaseWidget
	{
		///<summary>FUmgWidgetBinder_Border</summary>
		public const int MainLayer = 0x02C8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int InteractionMessageTextBinder = 0x02E8;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int InteractionMessageTextBgBinder = 0x0308;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int AdditionalTextBinder = 0x0328;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int SuitableWeaponImageBinder = 0x0348;

		///<summary>float</summary>
		public const int SuitableWeaponImageHeight = 0x0370;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0374;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int KeyImageBinder = 0x0378;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int InteractionKeyTextBinder = 0x03A0;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int InteractionKeyTextBorder_Binder = 0x03C0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AdditionalMessageBlinkingBinder = 0x03E0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AdditionalMessageNormalBinder = 0x0400;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ShowAnimationBinder = 0x0420;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int HiddenAnimationBinder = 0x0440;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int SwitchAnimationBinder = 0x0460;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int SwitchAnimationResetBinder = 0x0480;

		///<summary>FUmgWidgetBinder_WidgetSwitcher</summary>
		public const int InteractionInputMethodSwitcherBinder = 0x04A0;

		///<summary>FName</summary>
		public const int InteractionKeyName = 0x04C0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ProgressCircle_Binder = 0x04C8;

		///<summary>FLinearColor</summary>
		public const int InteractionTextColor_Interactable = 0x04F0;

		///<summary>FLinearColor</summary>
		public const int InteractionTextShadowColor_Interactable = 0x0500;

		///<summary>FLinearColor</summary>
		public const int InteractionTextColor_NotInteractable = 0x0510;

		///<summary>FLinearColor</summary>
		public const int InteractionTextShadowColor_NotInteractable = 0x0520;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0530;

	}

	public class UKillCountBaseWidget
	{
		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int KillCountTextBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int IncreasingAnimBinder = 0x02E8;

		///<summary>float</summary>
		public const int IncreasingKillCountDisplayTime = 0x0308;

		///<summary>int</summary>
		public const int LastKillCount = 0x030C;

		///<summary>bool</summary>
		public const int bLastWantShow = 0x0310;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0311;

		///<summary>float</summary>
		public const int IncreasingKillCountDisplayStartTime = 0x0314;

	}

	public class ULifeGaugeBaseWidget
	{
		///<summary>UTslHealthGaugeData *</summary>
		public const int LifeGaugeColorData = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int LifeGaugeImageBinder = 0x02D0;

		///<summary>FName</summary>
		public const int LifeGaugeRatioValueParamName = 0x02F8;

		///<summary>FName</summary>
		public const int LifeGaugeColorParamName = 0x0300;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HealAmountImageBinder = 0x0308;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int HitEffectLayer = 0x0330;

		///<summary>FName</summary>
		public const int HealAmountRatioValueParamName = 0x0350;

		///<summary>FName</summary>
		public const int HealAmountRatioSartParamName = 0x0358;

		///<summary>FName</summary>
		public const int HealAmountRatioEndParamName = 0x0360;

		///<summary>FName</summary>
		public const int HealAmountColorParamName = 0x0368;

		///<summary>UCurveFloat *</summary>
		public const int HealEffectTimeCurve = 0x0370;

		///<summary>UClass *</summary>
		public const int HitEffectClass = 0x0378;

		///<summary>UClass *</summary>
		public const int Item_Heal_FirstAid = 0x0380;

		///<summary>UClass *</summary>
		public const int Item_Heal_MedKit = 0x0388;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimationBinder = 0x0390;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int GroggyAnimationBinder = 0x03B0;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x03D0;

	}

	public class ULifeGaugeEffectBaseWidget
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x02C8;

		///<summary>FName</summary>
		public const int OldLifeRatioParamName = 0x02D8;

		///<summary>FName</summary>
		public const int CurrentLifeRatioParamName = 0x02E0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int LifeEffectBinder = 0x02E8;

		///<summary>TArray&lt;FUiEffectAnimation_FloatCurve&gt;</summary>
		public const int LifeEffectAnimationFloatCurveList = 0x0310;

		///<summary>TArray&lt;FUiEffectAnimation_VectorCurve&gt;</summary>
		public const int LifeEffectAnimationVectorCurveList = 0x0320;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int LifeEffectBackgroundBinder = 0x0330;

		///<summary>TArray&lt;FUiEffectAnimation_FloatCurve&gt;</summary>
		public const int LifeEffectBgAnimationFloatCurveList = 0x0358;

		///<summary>TArray&lt;FUiEffectAnimation_VectorCurve&gt;</summary>
		public const int LifeEffectBgAnimationVectorCurveList = 0x0368;

		///<summary>bool</summary>
		public const int bAutoDestroyOnEffectPlayFinish = 0x0378;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0379;

	}

	public class ULifeGaugeHitEffectBaseWidget
	{
		///<summary>TArray&lt;FGaugeAlphaCurveType&gt;</summary>
		public const int AlphaCurveList = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HitEffectImage = 0x02D8;

		///<summary>FName</summary>
		public const int BaseColorParamName = 0x0300;

		///<summary>FName</summary>
		public const int ColorLerpParamName = 0x0308;

		///<summary>FName</summary>
		public const int BrightAlphaParamName = 0x0310;

		///<summary>FName</summary>
		public const int HitEffectAlphaParamName = 0x0318;

		///<summary>FName</summary>
		public const int HitEffectStartParamName = 0x0320;

		///<summary>FName</summary>
		public const int HitEffectEndParamName = 0x0328;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0330;

	}

	public class ULifeGaugeTemplateBaseWidget
	{
		///<summary>UTslHealthGaugeData *</summary>
		public const int LifeGaugeColorData = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int LifeGaugeImageBinder = 0x02D0;

		///<summary>FName</summary>
		public const int LifeGaugeRatioValueParamName = 0x02F8;

		///<summary>FName</summary>
		public const int LifeGaugeColorParamName = 0x0300;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimationBinder = 0x0308;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BackgroundImageBinder = 0x0328;

		///<summary>bool</summary>
		public const int bOverrideLifeGaugeMaterial = 0x0350;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0351;

		///<summary>UMaterialInterface *</summary>
		public const int OverrideLifeGaugeMaterial = 0x0358;

		///<summary>bool</summary>
		public const int bOverrideBackgroundMaterial = 0x0360;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0361;

		///<summary>UMaterialInterface *</summary>
		public const int OverrideBackgroundMaterial = 0x0368;

		///<summary>bool</summary>
		public const int bUseEffect = 0x0370;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0371;

		///<summary>UClass *</summary>
		public const int DamageEffectClass = 0x0378;

		///<summary>UClass *</summary>
		public const int HealEffectClass = 0x0380;

		///<summary>UClass *</summary>
		public const int HealAmountEffectClass = 0x0388;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int EffectLayerBinder = 0x0390;

		///<summary>int</summary>
		public const int DamageEffectMax = 0x03B0;

		///<summary>int</summary>
		public const int HealEffectMax = 0x03B4;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData03 = 0x03B8;

		///<summary>TArray&lt;ULifeGaugeEffectBaseWidget * &gt;</summary>
		public const int DamageEffects = 0x03D0;

		///<summary>TArray&lt;ULifeGaugeEffectBaseWidget * &gt;</summary>
		public const int HealEffects = 0x03E0;

		///<summary>ULifeGaugeEffectBaseWidget *</summary>
		public const int HealAmountEffect = 0x03F0;

	}

	public class UMapCarePackageItemIconBaseWidget
	{
		///<summary>FUmgWidgetBinder_Border</summary>
		public const int IconImageBorderBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int IconImageBinder = 0x02E8;

		///<summary>FName</summary>
		public const int IconStateParamName = 0x0310;

		///<summary>FName</summary>
		public const int IconColorParamName = 0x0318;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0320;

	}

	public class UMapCharacterIconBaseWidget
	{
		///<summary>FUmgWidgetBinder_Border</summary>
		public const int IconImageBorderBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int IconImageBinder = 0x02E8;

		///<summary>FName</summary>
		public const int IconStateParamName = 0x0310;

		///<summary>FName</summary>
		public const int IconRotationParamName = 0x0318;

		///<summary>FName</summary>
		public const int IconColorParamName = 0x0320;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int PlayerNameBoderBinder = 0x0328;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int PlayerNameBinder = 0x0348;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int ObserverMuzzleFlashBoderBinder = 0x0368;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int ObserverMuzzleFlashWidgetBinder = 0x0388;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int LifeGaugeBorderBinder = 0x03A8;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int LifeGaugeWidgetBinder = 0x03C8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AttackedAnimBinder = 0x03E8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int HittedAnimBinder = 0x0408;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int GroggyAnimBinder = 0x0428;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutAnimBinder = 0x0448;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int ButtonBInder = 0x0468;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0488;

		///<summary>bool</summary>
		public const int bTeamNumber = 0x0498;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0499;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int TeamNumberText = 0x04A0;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int RiderLayerBinder = 0x04C0;

		///<summary>UClass *</summary>
		public const int RiderIconClass = 0x04E0;

		///<summary>FText</summary>
		public const int DisplayNameFormatWithOtherPlayer = 0x04E8;

		///<summary>UTexture *</summary>
		public const int MyDirectionIcon = 0x0500;

		///<summary>UTexture *</summary>
		public const int TeamDirectionIcon = 0x0508;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int SpectatedIconBorder = 0x0510;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int NameTagColorImageBinder = 0x0530;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x0558;

		///<summary>UMaterialInterface *</summary>
		public const int PendingIconMaterial = 0x0570;

		///<summary>TArray&lt;URiderIconWidget * &gt;</summary>
		public const int RiderIconList = 0x0578;

	}

	public class UMapGridWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MapImageBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int MyMarkerLayerBinder = 0x02F0;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int TeamMarkerLayerBinder = 0x0310;

		///<summary>UClass *</summary>
		public const int MapMarkerClass = 0x0330;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int MyMapIconLayerBinder = 0x0338;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int OtherMapIconLayerBinder = 0x0358;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CarePackageItemIconLayerBinder = 0x0378;

		///<summary>UClass *</summary>
		public const int MapCharacterIconClass = 0x0398;

		///<summary>UClass *</summary>
		public const int MapCarePackageItemIconClass = 0x03A0;

		///<summary>UClass *</summary>
		public const int ObserverPlayerIconHitEffectClass = 0x03A8;

		///<summary>bool</summary>
		public const int bShowName = 0x03B0;

		///<summary>bool</summary>
		public const int bIsMinimap = 0x03B1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x03B2;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int RedzoneImageBinder = 0x03B8;

		///<summary>FName</summary>
		public const int RedzoneColorParamName = 0x03E0;

		///<summary>FColorBlindColorSet</summary>
		public const int RedzoneColorSet = 0x03E8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ReplayzoneImageBinder = 0x03F8;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int ImageSizeBoxBinder = 0x0420;

		///<summary>FColorBlindColorSet</summary>
		public const int BluezoneColorSet = 0x0440;

		///<summary>float</summary>
		public const int Desaturation = 0x0450;

		///<summary>float</summary>
		public const int Contrast = 0x0454;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData01 = 0x0458;

		///<summary>float</summary>
		public const int ZoomLevel = 0x046C;

		///<summary>float</summary>
		public const int ShowGridZoomLevel = 0x0470;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0474;

		///<summary>UCurveFloat *</summary>
		public const int ViewRatioCurve = 0x0478;

		///<summary>bool</summary>
		public const int bRectangleViewMode = 0x0480;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0481;

		///<summary>UFont *</summary>
		public const int GridFont = 0x0488;

		///<summary>FName</summary>
		public const int FontTypeFace = 0x0490;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int GridTextHorizentalArray = 0x0498;

		///<summary>TArray&lt;FString&gt;</summary>
		public const int GridTextVerticalArray = 0x04A8;

		///<summary>FLinearColor</summary>
		public const int ColorLargeGrid = 0x04B8;

		///<summary>FLinearColor</summary>
		public const int ColorSmallGrid = 0x04C8;

		///<summary>FLinearColor</summary>
		public const int ColorText = 0x04D8;

		///<summary>FLinearColor</summary>
		public const int ColorSafetyZone = 0x04E8;

		///<summary>float</summary>
		public const int ThicknessLargeGrid = 0x04F8;

		///<summary>float</summary>
		public const int ThicknessSmallGrid = 0x04FC;

		///<summary>FLinearColor</summary>
		public const int ColorPoisonGasWarning = 0x0500;

		///<summary>bool</summary>
		public const int bDrawGridLine = 0x0510;

		///<summary>bool</summary>
		public const int bDrawGridText = 0x0511;

		///<summary>bool</summary>
		public const int bDrawNextPlayzoneGuideLine = 0x0512;

		///<summary>bool</summary>
		public const int bUseZOrderSort = 0x0513;

		///<summary>bool</summary>
		public const int bUseTeamMemberColor = 0x0514;

		///<summary>bool</summary>
		public const int bRemoveDeadIcon = 0x0515;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x0516;

		///<summary>FLinearColor</summary>
		public const int DefaultIconNameTagColor = 0x0518;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData05 = 0x0528;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MatInst = 0x0538;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData06 = 0x0540;

		///<summary>UMapMarkerBaseWidget *</summary>
		public const int MyMapMarker = 0x0558;

		///<summary>TMap&lt;ATeam *,UMapMarkerBaseWidget * &gt;</summary>
		public const int TeamPlayerMarkers = 0x0560;

		///<summary>UMapCharacterIconBaseWidget *</summary>
		public const int MyCharacterMapIcon = 0x05B0;

		///<summary>TMap&lt;AActor *,UMapCharacterIconBaseWidget * &gt;</summary>
		public const int OtherCharacterMapIcons = 0x05B8;

		///<summary>TMap&lt;ACarePackageItem *,UMapCarePackageItemIconBaseWidget * &gt;</summary>
		public const int MapCarePackageItemIcons = 0x0608;

		///<summary>FTimerHandle</summary>
		public const int ReplicatedCharacterListUpdateTimer = 0x0658;

		///<summary>FTimerHandle</summary>
		public const int ReplicatedCarePackageItemListUpdateTimer = 0x0660;

		///<summary>TArray&lt;ATslCharacter * &gt;</summary>
		public const int ReplicatedCharacterList = 0x0668;

		///<summary>TArray&lt;ACarePackageItem * &gt;</summary>
		public const int ReplicatedCarePackageItemList = 0x0678;

		///<summary>TArray&lt;ATeam * &gt;</summary>
		public const int ShowMarkerOnwerList = 0x0688;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData07 = 0x0698;

		///<summary>UMaterialInstance *</summary>
		public const int MyOrTeamIconMaterial = 0x06C0;

		///<summary>UMaterialInstance *</summary>
		public const int OtherCharacterIconMaterial = 0x06C8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int CloseMySelf = 0x06D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHideOwner = 0x06E0;

	}

	public class UMapMarkerBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MarkerImageBinder = 0x02C8;

		///<summary>FName</summary>
		public const int MarkerColorParmName = 0x02F0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int MarkerEmergingAnimBinder = 0x02F8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0318;

	}

	public class UMiniMapBaseWidget
	{
		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int MapWidgetBinder = 0x02C8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x02E8;

	}

	public class UNetworkProblemBaseWidget
	{
		///<summary>int</summary>
		public const int CheckElapsedTime = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02CC;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int IconBlinkingAnimBinder = 0x02D0;

	}

	public class UReplayProblemBaseWidget
	{
		///<summary>int</summary>
		public const int CheckElapsedTime = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02CC;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int IconBlinkingAnimBinder = 0x02D0;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int DisplayTextBlock = 0x02F0;

		///<summary>FText</summary>
		public const int DefaultFailureText = 0x0310;

		///<summary>FText</summary>
		public const int KillcamUnusualMovementText = 0x0328;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0340;

	}

	public class URiderIconWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int RiderIcon = 0x02C8;

	}

	public class UTeamMarkWidget
	{
		///<summary>ATeam *</summary>
		public const int TeamMember = 0x02C8;

		///<summary>float</summary>
		public const int OffsetZ = 0x02D0;

		///<summary>float</summary>
		public const int DeadMarkInvisibleTime = 0x02D4;

		///<summary>float</summary>
		public const int DeadMarkInvisibleDistance = 0x02D8;

		///<summary>FVector2D</summary>
		public const int OffScreenEdgeSize = 0x02DC;

		///<summary>FVector2D</summary>
		public const int OffScreenImageEdgeSize = 0x02E4;

		///<summary>float</summary>
		public const int AnimationMaxPercent = 0x02EC;

		///<summary>float</summary>
		public const int AnimationMaxDistance = 0x02F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02F4;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int StateSwitcherBinder = 0x02F8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int PlayerNameTextBinder = 0x0318;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OutLineImageBinder = 0x0338;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int DirectionImageBinder = 0x0360;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int NormalImageBinder = 0x0388;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int GroggyImageBinder = 0x03B0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int DeadImageBinder = 0x03D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int VehicleImageBinder = 0x0400;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ParachuteImageBinder = 0x0428;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int QuitterImageBinder = 0x0450;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int OpacityByRadiusPercentAnim = 0x0478;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ScaleByDistanceAnim = 0x0498;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int ImageMarkBorderBinder = 0x04B8;

		///<summary>float</summary>
		public const int AmingImageAlpha = 0x04D8;

		///<summary>float</summary>
		public const int ScopingImageAlpha = 0x04DC;

		///<summary>float</summary>
		public const int AmingTextAlpha = 0x04E0;

		///<summary>float</summary>
		public const int ScopingTextAlpha = 0x04E4;

		///<summary>UTexture *</summary>
		public const int OutScreenImage = 0x04E8;

		///<summary>UTexture *</summary>
		public const int GroggyImage = 0x04F0;

		///<summary>UTexture *</summary>
		public const int VehicleImage = 0x04F8;

		///<summary>UTexture *</summary>
		public const int ParachuteImage = 0x0500;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData01 = 0x0508;

	}

	public class UTeamOverallKillCountBaseWidget
	{
		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int TeamOverallKillCountTextBinder = 0x02C8;

		///<summary>int</summary>
		public const int LastTeamOverallKillCount = 0x02E8;

		///<summary>bool</summary>
		public const int bLastWantShow = 0x02EC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x02ED;

	}

	public class UTslAdaptiveCrosshairWidget
	{
		///<summary>EWeaponClass</summary>
		public const int WeaponClass = 0x02C8;

		///<summary>bool</summary>
		public const int bIsShowWidget = 0x02C9;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x02CA;

		///<summary>FColorBlindColorSet</summary>
		public const int ColorBlindColors = 0x02D0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int AdaptiveCrosshair_Binder = 0x02E0;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CanvasBase_Binder = 0x0308;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterCenter_Binder = 0x0328;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterCrosshair_Binder = 0x0348;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterD_Binder = 0x0368;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CenterDOT_Binder = 0x0388;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterL_Binder = 0x03B0;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterR_Binder = 0x03D0;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int CenterU_Binder = 0x03F0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_C_Binder = 0x0410;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_C_Gradient_Binder = 0x0438;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_L_Binder = 0x0460;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Pistol_R_Binder = 0x0488;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_D_Binder = 0x04B0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_D_Arrow_Binder = 0x04D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_L_Binder = 0x0500;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_L_Arrow_Binder = 0x0528;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_R_Binder = 0x0550;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_R_Arrow_Binder = 0x0578;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_U_Binder = 0x05A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Rifle_U_Arrow_Binder = 0x05C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_D_Binder = 0x05F0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_L_Binder = 0x0618;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_R_Binder = 0x0640;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int Shotgun_U_Binder = 0x0668;

	}

	public class UTslAlivePlayerInfoWidget
	{
		///<summary>ATslGameState *</summary>
		public const int CachedTslGS = 0x02C8;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int ColorOverlay_Binder = 0x02D0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Warning_Binder = 0x02F0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Increasing_Binder = 0x0310;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Decreasing_Binder = 0x0330;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Default_Binder = 0x0350;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int AdditionalInfo_Binder = 0x0370;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int SurvivorCount_Binder = 0x0390;

		///<summary>bool</summary>
		public const int bIsReplaying = 0x03B0;

		///<summary>bool</summary>
		public const int bIsHidden = 0x03B1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03B2;

		///<summary>int</summary>
		public const int CurrentCount = 0x03B4;

		///<summary>int</summary>
		public const int DisplayCount = 0x03B8;

		///<summary>int</summary>
		public const int WhileAnimCount = 0x03BC;

	}

	public class UTslKeyDisplayWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeyInputed = 0x02C8;

		///<summary>TArray&lt;UTslKeyReceiverWidget * &gt;</summary>
		public const int KeyReceiverWidgets = 0x02D8;

		///<summary>TArray&lt;FUmgWidgetBinder_UserWidget&gt;</summary>
		public const int KeyReceiverWidgetBinders = 0x02E8;

		///<summary>FName</summary>
		public const int InputName = 0x02F8;

		///<summary>FName</summary>
		public const int CategoryName = 0x0300;

		///<summary>FText</summary>
		public const int DisplayText = 0x0308;

		///<summary>bool</summary>
		public const int bGamepad = 0x0320;

		///<summary>bool</summary>
		public const int bAxisInput = 0x0321;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0322;

		///<summary>float</summary>
		public const int AxisScale = 0x0324;

	}

	public class UTslKeyOptionWidget
	{
		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int ScrollBox_Binder = 0x02C8;

		///<summary>TArray&lt;UTslKeySettingWidget * &gt;</summary>
		public const int KeySettingWidgets = 0x02E8;

		///<summary>UClass *</summary>
		public const int MouseSettingWidgetClass = 0x02F8;

		///<summary>UTslBaseOptionWidget *</summary>
		public const int MouseSettingWidget = 0x0300;

		///<summary>UClass *</summary>
		public const int KeySettingWidgetClass = 0x0308;

		///<summary>UClass *</summary>
		public const int GamePadSettingWidgetClass = 0x0310;

		///<summary>UTslBaseOptionWidget *</summary>
		public const int GamePadSettingWidget = 0x0318;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int CategoryOrder = 0x0320;

	}

	public class UTslKeySettingWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeyChanged = 0x02C8;

		///<summary>UClass *</summary>
		public const int KeyDisplayWidgetClass = 0x02D8;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int KeyScrollBoxBinder = 0x02E0;

		///<summary>TArray&lt;UTslKeyDisplayWidget * &gt;</summary>
		public const int KeyDisplayWidgets = 0x0300;

		///<summary>FText</summary>
		public const int DisplayText = 0x0310;

		///<summary>FName</summary>
		public const int CategoryName = 0x0328;

	}

	public class UTslBoostGaugeWidget
	{
		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge0_21 = 0x02C8;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge20_61 = 0x02D0;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge60_91 = 0x02D8;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Gauge90_101 = 0x02E0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int VanishingAnimBinder = 0x02E8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int WarningAnimBinder = 0x0308;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int EmergingAnimBinder = 0x0328;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost0_20ImageBinder = 0x0348;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost20_60ImageBinder = 0x0368;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost60_90ImageBinder = 0x0388;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Boost90_100ImageBinder = 0x03A8;

		///<summary>float</summary>
		public const int DisplayingBoost = 0x03C8;

		///<summary>bool</summary>
		public const int bIsWarning = 0x03CC;

		///<summary>bool</summary>
		public const int bIsVanished = 0x03CD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x03CE;

	}

	public class UTslBreatheBarWidget
	{
		///<summary>ATslHUD *</summary>
		public const int TslHudCached = 0x02C8;

		///<summary>ATslPlayerController *</summary>
		public const int TslPlayerControllerCached = 0x02D0;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int BreathGaugeLayer_Binder = 0x02D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BreathGaugeBG_Binder = 0x02F8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Breathing_Binder = 0x0320;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Drowning_Binder = 0x0340;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Vanishing_Binder = 0x0360;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Emerging_Binder = 0x0380;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Cooldown_Binder = 0x03A0;

		///<summary>float</summary>
		public const int BreathRatioDisplay = 0x03C0;

		///<summary>float</summary>
		public const int BreathRatio = 0x03C4;

		///<summary>float</summary>
		public const int LerpTolerance = 0x03C8;

		///<summary>float</summary>
		public const int LerpTime = 0x03CC;

		///<summary>FLinearColor</summary>
		public const int BreathImgColor_Less_101 = 0x03D0;

		///<summary>FLinearColor</summary>
		public const int BreathImgColor_Less_51 = 0x03E0;

		///<summary>FLinearColor</summary>
		public const int BreathImgColor_Less_11 = 0x03F0;

		///<summary>bool</summary>
		public const int bIsVanishing = 0x0400;

		///<summary>bool</summary>
		public const int bEventBound = 0x0401;

		///<summary>bool</summary>
		public const int bIsCooldown = 0x0402;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x0403;

	}

	public class UTslBuffIconListWidget
	{
		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int RunBuffIconBlock_Binder = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int RunBuffIcon_Binder = 0x02E8;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int HealBuffIconBlock_Binder = 0x0310;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HealBuffIcon_Binder = 0x0330;

		///<summary>UTexture *</summary>
		public const int HealBuffIconTex = 0x0358;

		///<summary>UTexture *</summary>
		public const int RunBuffIconTex = 0x0360;

	}

	public class UTslCastableItemIconWidget
	{
		///<summary>ECastableItemType</summary>
		public const int CastableItemType = 0x02C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x02C9;

		///<summary>UTexture *</summary>
		public const int ItemIcon = 0x02D0;

		///<summary>float</summary>
		public const int ItemIconRatio = 0x02D8;

		///<summary>FLinearColor</summary>
		public const int NormalColor = 0x02DC;

		///<summary>FLinearColor</summary>
		public const int NoItemColor = 0x02EC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x02FC;

		///<summary>FUmgWidgetBinder_Gerneral</summary>
		public const int Icon_Binder = 0x0300;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int ItemCountText_Binder = 0x0320;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int WidgetBorder_Binder = 0x0340;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int IconSizeBox_Binder = 0x0360;

	}

	public class UTslCompassMarkerWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CompassMarkerImageBinder = 0x02C8;

		///<summary>int</summary>
		public const int MarkerNumber = 0x02F0;

		///<summary>float</summary>
		public const int XViewSize = 0x02F4;

		///<summary>bool</summary>
		public const int bShow = 0x02F8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x02F9;

	}

	public class UTslCompassWidget
	{
		///<summary>UMaterialInterface *</summary>
		public const int MI_Compass = 0x02C8;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_Compass = 0x02D0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CompassImageBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MarkerImageBinder = 0x0300;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int MyOverlayBinder = 0x0328;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int TeamOverlayBinder = 0x0348;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int DirectionTextBlockBinder = 0x0368;

		///<summary>UClass *</summary>
		public const int CompassMarkerWidgetClass = 0x0388;

		///<summary>UTslCompassMarkerWidget *</summary>
		public const int MyCompassMarkerWidget = 0x0390;

		///<summary>TArray&lt;UTslCompassMarkerWidget * &gt;</summary>
		public const int TeamMarkerWidgetOfTeam = 0x0398;

		///<summary>float</summary>
		public const int DivisionLevel = 0x03A8;

		///<summary>float</summary>
		public const int Offset = 0x03AC;

		///<summary>bool</summary>
		public const int bClockwise = 0x03B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x03B1;

		///<summary>FLinearColor</summary>
		public const int DefaultDirectionTextColor = 0x0408;

		///<summary>int</summary>
		public const int BearingUnit = 0x0418;

		///<summary>float</summary>
		public const int Width = 0x041C;

		///<summary>bool</summary>
		public const int bIsInitilzed = 0x0420;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0421;

		///<summary>float</summary>
		public const int CompassYaw = 0x0424;

	}

	public class UTslConfirmationDialogWidget
	{
		///<summary>unsigned char[0xE8]</summary>
		public const int UnknownData00 = 0x02C8;

	}

	public class UTslGroggyCircleWidget
	{
		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MID_ProgressCircle = 0x02C8;

		///<summary>UMaterialInterface *</summary>
		public const int MI_ProgressCircle = 0x02D0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CircleImageBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int CrossImageBinder = 0x0300;

	}

	public class UTslHealItemSelectorWidget
	{
		///<summary>AInventory *</summary>
		public const int InventoryCached = 0x02C8;

		///<summary>FTimerHandle</summary>
		public const int HealItemSelectorTimer = 0x02D0;

		///<summary>FTimerHandle</summary>
		public const int WidgetHideTimer = 0x02D8;

		///<summary>ECastableItemType</summary>
		public const int LastSelectedHealItemType = 0x02E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x02E1;

		///<summary>TArray&lt;FHealItemSelectorData&gt;</summary>
		public const int HealItemDatas = 0x02E8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ItemIcon_Binder = 0x02F8;

		///<summary>FVector2D</summary>
		public const int InitialPosition = 0x0320;

		///<summary>FVector2D</summary>
		public const int OffsetWhenTpsWeaponIconEnabled = 0x0328;

	}

	public class UTslInventoryCapacityWidget
	{
		///<summary>float</summary>
		public const int GameMaxSpace = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02CC;

		///<summary>AInventory *</summary>
		public const int InventoryCached = 0x02D0;

	}

	public class UTslKeyGuideWidget
	{
		///<summary>FTimerHandle</summary>
		public const int TimerHandle_HideWidget = 0x02C8;

		///<summary>int</summary>
		public const int XButtonImageIndex = 0x02D0;

		///<summary>int</summary>
		public const int BButtonImageIndex = 0x02D4;

		///<summary>FUmgWidgetBinder_WidgetSwitcher</summary>
		public const int ButtonImageSwitcher_Binder = 0x02D8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ProgressBarImage_Binder = 0x02F8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int KeyGuideText_Binder = 0x0320;

	}

	public class UTslKeyReceiverWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeyReceived = 0x02C8;

		///<summary>FTslInputKey</summary>
		public const int OriginKey = 0x02D8;

		///<summary>FKey</summary>
		public const int FirstDownKey = 0x02F8;

		///<summary>FTslInputKey</summary>
		public const int CurrentDownKey = 0x0310;

		///<summary>FTslInputKey</summary>
		public const int LastDownedKey = 0x0330;

		///<summary>bool</summary>
		public const int bFocused = 0x0350;

		///<summary>bool</summary>
		public const int bEnableInput = 0x0351;

		///<summary>bool</summary>
		public const int bIsKeyUp = 0x0352;

		///<summary>bool</summary>
		public const int bAxisInput = 0x0353;

		///<summary>float</summary>
		public const int AxisScale = 0x0354;

		///<summary>TArray&lt;FKey&gt;</summary>
		public const int MouseButtons = 0x0358;

	}

	public class UTslKillMessageListWidget
	{
		///<summary>UClass *</summary>
		public const int KillMessageWidgetClass = 0x02C8;

		///<summary>TArray&lt;UTslKillMessageWidget * &gt;</summary>
		public const int KillMessageWidgetArray = 0x02D0;

		///<summary>float</summary>
		public const int FadeoutStartTime = 0x02E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02E4;

	}

	public class UTslKillMessageWidget
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnVanishAnimationFinished = 0x02C8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int Vanish_Binder = 0x02D8;

		///<summary>TArray&lt;FCauseOfDeathData&gt;</summary>
		public const int CauseOfDeathDatas = 0x02F8;

		///<summary>TArray&lt;FConditionOfDeathData&gt;</summary>
		public const int ConditionOfDeathDatas = 0x0308;

	}

	public class UTslLobbyNameTagWidget
	{
		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int NickName_Binder = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int HostImage_Binder = 0x02E8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int ReadyImage_Binder = 0x0310;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int VoiceImage_Binder = 0x0338;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int BackgroundBorder_Binder = 0x0360;

		///<summary>bool</summary>
		public const int bTestAlwaysShowIcons = 0x0380;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0381;

		///<summary>int</summary>
		public const int SlotIndex = 0x0384;

		///<summary>FVector</summary>
		public const int NameTagOffsetTranslation = 0x0388;

		///<summary>bool</summary>
		public const int bIsHost = 0x0394;

		///<summary>bool</summary>
		public const int bIsReady = 0x0395;

		///<summary>bool</summary>
		public const int bIsSpeaking = 0x0396;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x0397;

	}

	public class UTslObserverPlayerInfoWidget
	{
		///<summary>TArray&lt;FLinearColor&gt;</summary>
		public const int TeamColorsCached = 0x02C8;

		///<summary>UTexture *</summary>
		public const int UnArmedIcon = 0x02D8;

		///<summary>float</summary>
		public const int UnArmedIconRatio = 0x02E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02E4;

		///<summary>ATslCharacter *</summary>
		public const int CachedCharacter = 0x02E8;

		///<summary>int</summary>
		public const int OldAmmoCount = 0x02F0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x02F4;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AmmoIncreasingAnimBinder = 0x02F8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AmmoDecreasingAnimBinder = 0x0318;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int UserNameText_Binder = 0x0338;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int TeamNumberText_Binder = 0x0358;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int AmmoCountText_Binder = 0x0378;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int KillCountText_Binder = 0x0398;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int LifeGaugeTemplateWidget_Binder = 0x03B8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WeaponIconImageBinder = 0x03D8;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int WeaponIconImageSizeBoxBinder = 0x0400;

		///<summary>FName</summary>
		public const int WeaponIconTextureParmName = 0x0420;

		///<summary>FName</summary>
		public const int WeaponIconColorParmName = 0x0428;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Armed = 0x0430;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Normal = 0x0440;

		///<summary>FColorBlindColorSet</summary>
		public const int WeaponColorSet_NoReload = 0x0450;

	}

	public class UTslTeamInfoListWidget
	{
		///<summary>TArray&lt;UTslTeamInfoWidget * &gt;</summary>
		public const int TeamInfoWidgetList = 0x02C8;

		///<summary>UClass *</summary>
		public const int TeamInfoWidgetClass = 0x02D8;

		///<summary>FUmgWidgetBinder_VerticalBox</summary>
		public const int VerticalBoxBinder = 0x02E0;

	}

	public class UTslTeamInfoWidget
	{
		///<summary>bool</summary>
		public const int bBindVoiceChatEvent = 0x02C8;

		///<summary>bool</summary>
		public const int bSpeaking = 0x02C9;

		///<summary>unsigned char:1</summary>
		public const int bMute = 0x02CA;

		///<summary>unsigned char:1</summary>
		public const int bIsRestricted = 0x02CA;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x02CB;

		///<summary>FUmgWidgetBinder_HorizontalBox</summary>
		public const int TeamHpAreaBinder = 0x02D0;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int TeamInfoAreaBinder = 0x02F0;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int InfoIconBorderBinder = 0x0310;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int InfoIconBinder = 0x0330;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int SpeakingImageBinder = 0x0358;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int MarkerIconBorderBinder = 0x0380;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int MarkerImageBinder = 0x03A0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int BoostImageBinder = 0x03C8;

		///<summary>bool</summary>
		public const int bUdateTeamNameColor = 0x03F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x03F1;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int TeamNameBinder = 0x03F8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int OnSpeakAnimBinder = 0x0418;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int HealthGaugeWidgetBinder = 0x0438;

		///<summary>FColorBlindColorSet</summary>
		public const int ColorBlindColorSet = 0x0458;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int TeamMemberColorBinder = 0x0468;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int PlayerIconImageBinder = 0x0490;

		///<summary>ATeam *</summary>
		public const int Team = 0x04B8;

		///<summary>FLinearColor</summary>
		public const int QuitColor = 0x04C0;

	}

	public class UTslTeamWidget
	{
		///<summary>TArray&lt;UTeamMarkWidget * &gt;</summary>
		public const int TeamMarkWidgets = 0x02C8;

		///<summary>UClass *</summary>
		public const int TeamMarkWidgetClass = 0x02D8;

		///<summary>FUmgWidgetBinder_CanvasPanel</summary>
		public const int TeamMarkerLayerBinder = 0x02E0;

	}

	public class UTslXboxTeamManageInfoWidget
	{
		///<summary>int</summary>
		public const int MemberNumber = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02CC;

		///<summary>FName</summary>
		public const int UserName = 0x02D0;

		///<summary>bool</summary>
		public const int bIsVoiceMute = 0x02D8;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x02D9;

	}

	public class UVehicleFuelBaseWidget
	{
		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OilGaugeImageBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OilGaugeBgImageBinder = 0x02F0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int OilArrowImageBinder = 0x0318;

		///<summary>FUmgWidgetBinder_Overlay</summary>
		public const int GaugeBodyBinder = 0x0340;

		///<summary>FLinearColor</summary>
		public const int NormalColor = 0x0360;

		///<summary>FLinearColor</summary>
		public const int FuelEmptyColor = 0x0370;

		///<summary>FName</summary>
		public const int GaugePramName = 0x0380;

	}

	public class UVehicleSeatInfoBaseWidget
	{
		///<summary>int</summary>
		public const int SeatIndex = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02CC;

		///<summary>FName</summary>
		public const int StateParamName = 0x02D0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int SeatImageBinder = 0x02D8;

		///<summary>APawn *</summary>
		public const int CachedVehiclePawn = 0x0300;

		///<summary>UTslVehicleSeatComponent *</summary>
		public const int CachedSeatComponent = 0x0308;

	}

	public class UVehicleStanceBaseWidget
	{
		///<summary>FUmgWidgetBinder_VerticalBox</summary>
		public const int VehicleIconAreaBinder = 0x02C8;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int SpeedTextBinder = 0x02E8;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int LifeGaugeWidgetBinder = 0x0308;

		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int FuelGaugeWidgetBinder = 0x0328;

		///<summary>APawn *</summary>
		public const int CachedVehiclePawn = 0x0348;

		///<summary>UUserWidget *</summary>
		public const int CachedVehicleIconWidget = 0x0350;

	}

	public class UVehicleWheelInfoBaseWidget
	{
		///<summary>int</summary>
		public const int WheelIndex = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x02CC;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WheelImageBinder = 0x02D0;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int PunctureImageBinder = 0x02F8;

		///<summary>ATslWheeledVehicle *</summary>
		public const int CachedVehiclePawn = 0x0320;

		///<summary>UTslWheeledVehicleMovement *</summary>
		public const int CachedVehicleMovement = 0x0328;

	}

	public class UVersionInfoBaseWidget
	{
		///<summary>FText</summary>
		public const int WithNickNameFormat = 0x02C8;

		///<summary>FText</summary>
		public const int WithOutNickNameFormat = 0x02E0;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int VersionInfoTextBinder = 0x02F8;

	}

	public class UWeaponSlotBaseWidget
	{
		///<summary>unsigned char:1</summary>
		public const int bListInSlot = 0x02C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x02C9;

		///<summary>int</summary>
		public const int WeaponIndex = 0x02CC;

		///<summary>ENoReloadGuideType</summary>
		public const int ListSlotNoReloadGuideType = 0x02D0;

		///<summary>unsigned char:1</summary>
		public const int bUseWeaponIcon = 0x02D1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x02D2;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WeaponIconImageBinder = 0x02D8;

		///<summary>FUmgWidgetBinder_SizeBox</summary>
		public const int WeaponIconImageSizeBoxBinder = 0x0300;

		///<summary>float</summary>
		public const int WeaponIconImageSizeBoxHeight = 0x0320;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0324;

		///<summary>FName</summary>
		public const int WeaponIconTextureParmName = 0x0328;

		///<summary>FName</summary>
		public const int WeaponIconColorParmName = 0x0330;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Armed = 0x0338;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Normal = 0x0348;

		///<summary>FLinearColor</summary>
		public const int WeaponColor_Unarmed = 0x0358;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ScaleUpAnimBinder = 0x0368;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ScaleDownAnimBinder = 0x0388;

		///<summary>FColorBlindColorSet</summary>
		public const int WeaponColorSet_NoReload = 0x03A8;

		///<summary>unsigned char:1</summary>
		public const int bUseAmmoTextAndIcon = 0x03B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x03B9;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponHandsOnLoadedAmmoCountTextBinder = 0x03C0;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponListLoadedAmmoCountTextBinder = 0x03E0;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AmmoIncreasingAnimBinder = 0x0400;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int AmmoDecreasingAnimBinder = 0x0420;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponHandsOnUnloadedAmmoCountTextBinder = 0x0440;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int UnloadedAmmoIncreasingAnimBinder = 0x0460;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int UnloadedAmmoDecreasingAnimBinder = 0x0480;

		///<summary>FUmgWidgetBinder_Image</summary>
		public const int WeaponHandsOnAmmoIconBinder = 0x04A0;

		///<summary>FName</summary>
		public const int AmmoTexParamName = 0x04C8;

		///<summary>unsigned char:1</summary>
		public const int bUseWeaponFiringModeTextBinder = 0x04D0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x04D1;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int WeaponFiringModeTextBinder = 0x04D8;

		///<summary>unsigned char:1</summary>
		public const int bZeroingDistancebUseText = 0x04F8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x04F9;

		///<summary>FUmgWidgetBinder_VerticalBox</summary>
		public const int ZeroingDistanceBlockBinder = 0x0500;

		///<summary>FUmgWidgetBinder_TextBlock</summary>
		public const int ZeroingdistanceTextBinder = 0x0520;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ZeroDistIncreasingAnimBinder = 0x0540;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int ZeroDistDecreasingAnimBinder = 0x0560;

		///<summary>FText</summary>
		public const int ZeroingTextFormat = 0x0580;

		///<summary>FText</summary>
		public const int ZeroingNA = 0x0598;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int WeaponIconBackground = 0x05B0;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int AmmoAndFringModeBackground = 0x05D0;

		///<summary>float</summary>
		public const int SlotBackgroundAlpha_Armed = 0x05F0;

		///<summary>float</summary>
		public const int SlotBackgroundAlpha_Unarmed = 0x05F4;

		///<summary>float</summary>
		public const int SlotBackgroundAlpha_Normal = 0x05F8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData06 = 0x05FC;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeInWeaponSlotAnimBinder = 0x0600;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutWeaponSlotAnimBinder = 0x0620;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeInUnarmedWeaponSlotAminBinder = 0x0640;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutUnarmedWeaponSlotAminBinder = 0x0660;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData07 = 0x0680;

	}

	public class UWeaponSlotHudBaseWidget
	{
		///<summary>FUmgWidgetBinder_UserWidget</summary>
		public const int CurrentWeaponSlotWidgetBinder = 0x02C8;

		///<summary>TArray&lt;FUmgWidgetBinder_UserWidget&gt;</summary>
		public const int WeaponSlotWidgetBinderList = 0x02E8;

		///<summary>FUmgWidgetBinder_Border</summary>
		public const int WeaponSlotListBorderBinder = 0x02F8;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeInSlotListAminBinder = 0x0318;

		///<summary>FUmgWidgetBinder_Animation</summary>
		public const int FadeOutSlotListAminBinder = 0x0338;

		///<summary>float</summary>
		public const int SlotOffsetMultiply = 0x0358;

		///<summary>float</summary>
		public const int SlotPadding = 0x035C;

		///<summary>FSequence_Float</summary>
		public const int MovingSequence = 0x0360;

		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0400;

		///<summary>FTimerHandle</summary>
		public const int FinishTimer = 0x0430;

		///<summary>AWeaponProcessor *</summary>
		public const int CachedWeaponProcessor = 0x0438;

	}

	public class UTslVehicleAnimInstance
	{
		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0890;

		///<summary>FRotator</summary>
		public const int Rot_Steering_Right = 0x0894;

		///<summary>FRotator</summary>
		public const int Rot_Steering_Final = 0x08A0;

		///<summary>FRotator</summary>
		public const int Rot_Speed_Left = 0x08AC;

		///<summary>FRotator</summary>
		public const int Rot_Speed_Right = 0x08B8;

		///<summary>float</summary>
		public const int SpeedMax = 0x08C4;

		///<summary>FRotator</summary>
		public const int Rot_Speed_Final = 0x08C8;

		///<summary>FRotator</summary>
		public const int Rot_RPM_Left = 0x08D4;

		///<summary>FRotator</summary>
		public const int Rot_RPM_Right = 0x08E0;

		///<summary>float</summary>
		public const int RPMMax = 0x08EC;

		///<summary>bool</summary>
		public const int bTickIndicators = 0x08F0;

		///<summary>bool</summary>
		public const int bUseAbsoluteSteeringRotation = 0x08F1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x08F2;

		///<summary>FRotator</summary>
		public const int Rot_RPM_Final = 0x08F4;

		///<summary>ATslWheeledVehicle *</summary>
		public const int VehicleRef = 0x0900;

		///<summary>UTslWheeledVehicleMovement *</summary>
		public const int VehicleMovementRef = 0x0908;

	}

	public class UTslVehicleCommonComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRepair = 0x01E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDeath = 0x01F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHealthChange = 0x0208;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFuelChange = 0x0218;

		///<summary>FName</summary>
		public const int SimpleBodyBoneName = 0x0228;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int ComplexBodyBoneNames = 0x0230;

		///<summary>FName</summary>
		public const int MainComplexBodyBoneName = 0x0240;

		///<summary>FName</summary>
		public const int ComplexCollisionProfileName = 0x0248;

		///<summary>unsigned char:1</summary>
		public const int bIsDying = 0x0250;

		///<summary>unsigned char:1</summary>
		public const int bIsBroken = 0x0250;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0251;

		///<summary>float</summary>
		public const int Health = 0x0254;

		///<summary>float</summary>
		public const int HealthMax = 0x0258;

		///<summary>float</summary>
		public const int Fuel = 0x025C;

		///<summary>float</summary>
		public const int FuelMax = 0x0260;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0264;

		///<summary>UClass *</summary>
		public const int VehicleExplosionDamageType = 0x0268;

		///<summary>TArray&lt;EDamageTypeCategory&gt;</summary>
		public const int CharacterDamageIgnores = 0x0270;

		///<summary>UClass *</summary>
		public const int VehicleUI = 0x0280;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x0288;

	}

	public class UVehicleSurfaceAudioData
	{
		///<summary>UAkAudioEvent *</summary>
		public const int EventIn = 0x0030;

		///<summary>UAkAudioEvent *</summary>
		public const int EventOut = 0x0038;

	}

	public class UTslVehicleEffectComponent
	{
		///<summary>UMeshComponent *</summary>
		public const int MeshComponent = 0x01E0;

		///<summary>UAkComponent *</summary>
		public const int EngineSoundComponent = 0x01E8;

		///<summary>FVehicleEffectInfo</summary>
		public const int VehicleEffectInfo = 0x01F0;

		///<summary>ATslParticle *</summary>
		public const int MufflerEffect = 0x02E0;

		///<summary>ATslParticle *</summary>
		public const int Muffler2Effect = 0x02E8;

		///<summary>ATslParticle *</summary>
		public const int BoostEffect = 0x02F0;

		///<summary>ATslParticle *</summary>
		public const int Boost2Effect = 0x02F8;

		///<summary>ATslParticle *</summary>
		public const int DamagedEffect = 0x0300;

		///<summary>ATslParticle *</summary>
		public const int ExplosionEffect = 0x0308;

		///<summary>ATslParticle *</summary>
		public const int FrontTrailEffect = 0x0310;

		///<summary>ATslParticle *</summary>
		public const int RearTrailEffect = 0x0318;

		///<summary>ATslParticle *</summary>
		public const int ThrusterEffect = 0x0320;

		///<summary>ATslParticle *</summary>
		public const int Thruster2Effect = 0x0328;

		///<summary>ATslParticle *</summary>
		public const int FrontFoamLeftEffect = 0x0330;

		///<summary>ATslParticle *</summary>
		public const int FrontFoamRightEffect = 0x0338;

		///<summary>unsigned char[0x1C]</summary>
		public const int UnknownData00 = 0x0340;

		///<summary>float</summary>
		public const int TrailSpeedThreshold = 0x035C;

		///<summary>float</summary>
		public const int FrontFoamSpawnThreshold = 0x0360;

		///<summary>bool</summary>
		public const int bRPMOverride = 0x0364;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData01 = 0x0365;

		///<summary>bool</summary>
		public const int bUseNewChassisAudio = 0x0378;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0379;

		///<summary>UCurveFloat *</summary>
		public const int Curve_EngineAudio = 0x0380;

		///<summary>bool</summary>
		public const int bUseDopplerEffect = 0x0388;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x0389;

		///<summary>bool</summary>
		public const int bUseNewSurfaceAudio = 0x03E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x03E1;

		///<summary>TArray&lt;int&gt;</summary>
		public const int MeasuredWheelIndices = 0x03E8;

		///<summary>TArray&lt;int&gt;</summary>
		public const int MeasuredWheelIndicesSlip = 0x03F8;

		///<summary>TArray&lt;int&gt;</summary>
		public const int MeasuredWheelIndicesSpin = 0x0408;

		///<summary>TArray&lt;int&gt;</summary>
		public const int MeasuredWheelIndicesBrake = 0x0418;

		///<summary>float</summary>
		public const int SuspenionOffsetForContact = 0x0428;

		///<summary>float</summary>
		public const int SurfaceActivationValue = 0x042C;

		///<summary>float</summary>
		public const int SurfaceDeactivationValue = 0x0430;

		///<summary>float</summary>
		public const int DT_Multiplier = 0x0434;

		///<summary>float</summary>
		public const int MinVelocityForSurfaceCheck = 0x0438;

		///<summary>float</summary>
		public const int MinRotationSpeedForSurfaceCheck = 0x043C;

		///<summary>float</summary>
		public const int MinSlip = 0x0440;

		///<summary>float</summary>
		public const int MinSpin = 0x0444;

		///<summary>float</summary>
		public const int MinVelocityForBreak = 0x0448;

		///<summary>float</summary>
		public const int BrakeNoDriverMultiplier = 0x044C;

		///<summary>int</summary>
		public const int VelocityInterpSpeed = 0x0450;

		///<summary>int</summary>
		public const int SlipInterpSpeed = 0x0454;

		///<summary>int</summary>
		public const int SpinInterpSpeed = 0x0458;

		///<summary>int</summary>
		public const int BreakInterpSpeed = 0x045C;

		///<summary>bool</summary>
		public const int bDebugVisualizedMeasuredWheels = 0x0460;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0461;

		///<summary>float</summary>
		public const int AngularVelocityCoefficient = 0x0464;

		///<summary>float</summary>
		public const int LateralVelocityCoeffictient = 0x0468;

		///<summary>float</summary>
		public const int LateralVelocityClamp = 0x046C;

		///<summary>bool</summary>
		public const int bProcessShiftStart = 0x0470;

		///<summary>bool</summary>
		public const int bProcessShiftEnd = 0x0471;

		///<summary>bool</summary>
		public const int bProcessReverse = 0x0472;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData06 = 0x0473;

		///<summary>UAkAudioEvent *</summary>
		public const int GearUpSound_Start = 0x0478;

		///<summary>UAkAudioEvent *</summary>
		public const int GearDownSound_Start = 0x0480;

		///<summary>UAkAudioEvent *</summary>
		public const int GearUpSound_End = 0x0488;

		///<summary>UAkAudioEvent *</summary>
		public const int GearDownSound_End = 0x0490;

		///<summary>UAkAudioEvent *</summary>
		public const int GearReverseSound = 0x0498;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData07 = 0x04A0;

		///<summary>float</summary>
		public const int ApplyDestroyedMaterialDelay = 0x0580;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData08 = 0x0584;

	}

	public class UTslVehicleHitComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>UMeshComponent *</summary>
		public const int MeshComponent = 0x01E8;

		///<summary>float</summary>
		public const int HitCharacterDuration = 0x01F0;

		///<summary>unsigned char[0x54]</summary>
		public const int UnknownData01 = 0x01F4;

		///<summary>float</summary>
		public const int LeaveCharacterIgnoreDuration = 0x0248;

		///<summary>float</summary>
		public const int CharacterHitMinimumVehicleSpeed = 0x024C;

		///<summary>float</summary>
		public const int CharacterDamageVelocityUnitMultiplier = 0x0250;

		///<summary>float</summary>
		public const int CharacterDamageMassUnitMultiplier = 0x0254;

		///<summary>UCurveFloat *</summary>
		public const int CharacterDamageSpeedCurve = 0x0258;

		///<summary>UCurveFloat *</summary>
		public const int CharacterDamageMassCurve = 0x0260;

		///<summary>float</summary>
		public const int MinimumCharacterDamage = 0x0268;

		///<summary>float</summary>
		public const int CharacterLaunchSpeedMultiplier = 0x026C;

		///<summary>float</summary>
		public const int MinimumCharacterLaunchSpeed = 0x0270;

		///<summary>float</summary>
		public const int PhysicsImpulseMultiplier = 0x0274;

		///<summary>UPhysicalMaterial *</summary>
		public const int VoidPhysicalMaterial = 0x0278;

		///<summary>float</summary>
		public const int PhysicsImpactModifier = 0x0280;

		///<summary>float</summary>
		public const int PhysicsImpactModifierUpsideDown = 0x0284;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorption = 0x0288;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorptionUpsideDown = 0x028C;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorptionRider = 0x0290;

		///<summary>float</summary>
		public const int PhysicsImpactAbsorptionRiderUpsideDown = 0x0294;

		///<summary>float</summary>
		public const int PhysicsImpactVehicleDamageMultiplier = 0x0298;

		///<summary>float</summary>
		public const int PhysicsImpactRiderDamageMultiplier = 0x029C;

		///<summary>UClass *</summary>
		public const int VehicleHitDamageType = 0x02A0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x02A8;

		///<summary>float</summary>
		public const int ExplosionBaseDamage = 0x02AC;

		///<summary>float</summary>
		public const int ExplosionMinimumDamage = 0x02B0;

		///<summary>float</summary>
		public const int ExplosionRadiusInner = 0x02B4;

		///<summary>float</summary>
		public const int ExplosionRadiusOuter = 0x02B8;

		///<summary>float</summary>
		public const int ExplosionDamageFalloff = 0x02BC;

		///<summary>UClass *</summary>
		public const int ExplosionDamageType = 0x02C0;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int ExplosionDamagePreventionChannel = 0x02C8;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData03 = 0x02C9;

		///<summary>float</summary>
		public const int ImpulseLimitationSpeedThreshold = 0x02D8;

		///<summary>float</summary>
		public const int CollectTime = 0x02DC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x02E0;

		///<summary>TArray&lt;FVehicleDebugHit&gt;</summary>
		public const int DebugHitHistory = 0x02F0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData05 = 0x0300;

		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int HitAbsorberTypes = 0x0308;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData06 = 0x0318;

	}

	public class UTslVehicleSeatComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnLeave = 0x01E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDriverRide = 0x01F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDriverLeave = 0x0208;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPostDriverRide = 0x0218;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPostDriverLeave = 0x0228;

		///<summary>TArray&lt;FVehicleSeatInfo&gt;</summary>
		public const int SeatInfos = 0x0238;

		///<summary>TArray&lt;UVehicleSeatInteractionComponent * &gt;</summary>
		public const int Seats = 0x0248;

		///<summary>bool</summary>
		public const int bUseSeatCamera = 0x0258;

		///<summary>bool</summary>
		public const int bDoFlipCheck = 0x0259;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x025A;

		///<summary>float</summary>
		public const int FlipForce = 0x025C;

		///<summary>bool</summary>
		public const int bDoEntryAngleCheck = 0x0260;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0261;

		///<summary>float</summary>
		public const int MinEntryAngle = 0x0264;

		///<summary>bool</summary>
		public const int bDampenPlayerVelocityOnLeave = 0x0268;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0269;

		///<summary>float</summary>
		public const int OnLeaveVelocityMultiplier = 0x026C;

		///<summary>bool</summary>
		public const int bUseActiveStabilize = 0x0270;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0271;

		///<summary>TWeakObjectPtr&lt;ATslCharacter&gt;</summary>
		public const int LastDriver = 0x0274;

		///<summary>unsigned char[0x64]</summary>
		public const int UnknownData05 = 0x027C;

	}

	public class UTslVehicleSyncComponent
	{
		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>float</summary>
		public const int MinCorrectionInterval = 0x01EC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01F0;

		///<summary>float</summary>
		public const int SendingToServerIntervalAtClient = 0x01F4;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x01F8;

		///<summary>float</summary>
		public const int SendingReliableHitToServerIntervalAtClient = 0x0200;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0204;

		///<summary>float</summary>
		public const int AllowedMaxDistanceSqAtServer = 0x0208;

		///<summary>float</summary>
		public const int StationaryCorrectionIntervalAtClient = 0x020C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData04 = 0x0210;

		///<summary>float</summary>
		public const int StationaryCorrectionSpeedThresholdSq = 0x0214;

		///<summary>float</summary>
		public const int StationaryCorrectionThresholdDistanceSq = 0x0218;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData05 = 0x021C;

	}

	public class UTslViewTargetTempComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class ATslWeapon_Trajectory
	{
		///<summary>float</summary>
		public const int TrajectoryGravityZ = 0x0AF0;

		///<summary>float</summary>
		public const int RecoilSpreadScale = 0x0AF4;

		///<summary>bool</summary>
		public const int FireAtViewPoint = 0x0AF8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0AF9;

		///<summary>float</summary>
		public const int DefaultTimerFrequency = 0x0AFC;

		///<summary>float</summary>
		public const int CrouchSpreadModifier = 0x0B00;

		///<summary>float</summary>
		public const int ProneSpreadModifier = 0x0B04;

		///<summary>float</summary>
		public const int WalkSpread = 0x0B08;

		///<summary>float</summary>
		public const int RunSpread = 0x0B0C;

		///<summary>float</summary>
		public const int JumpSpread = 0x0B10;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0B14;

		///<summary>FTrajectoryWeaponData</summary>
		public const int TrajectoryConfig = 0x0B18;

		///<summary>FRecoilInfo</summary>
		public const int RecoilInfo = 0x0B98;

		///<summary>UClass *</summary>
		public const int ImpactTemplate = 0x0C00;

		///<summary>UParticleSystem *</summary>
		public const int TrailFX = 0x0C08;

		///<summary>FName</summary>
		public const int TrailTargetParam = 0x0C60;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData02 = 0x0C68;

		///<summary>float</summary>
		public const int WeaponSpread = 0x0C80;

		///<summary>float</summary>
		public const int RecoilModifier_Stand = 0x0C84;

		///<summary>float</summary>
		public const int RecoilModifier_Crouch = 0x0C88;

		///<summary>float</summary>
		public const int RecoilModifier_Prone = 0x0C8C;

		///<summary>float</summary>
		public const int VerticalRecoilMin = 0x0C90;

		///<summary>float</summary>
		public const int VerticalRecoilMax = 0x0C94;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData03 = 0x0C98;

	}

	public class ATslWeapon_Melee
	{
		///<summary>UAkAudioEvent *</summary>
		public const int AttackSoundAk = 0x07E0;

		///<summary>TArray&lt;FMeleeWeaponAnim&gt;</summary>
		public const int AttackAnims = 0x07E8;

		///<summary>float</summary>
		public const int Damage = 0x07F8;

		///<summary>float</summary>
		public const int WeaponImpact = 0x07FC;

		///<summary>UClass *</summary>
		public const int DamageType = 0x0800;

		///<summary>EHitCheckType</summary>
		public const int HitCheckType = 0x0808;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0809;

		///<summary>float</summary>
		public const int AllowedHitRangeLeeway = 0x080C;

		///<summary>UClass *</summary>
		public const int ImpactTemplate = 0x0810;

		///<summary>UCapsuleComponent *</summary>
		public const int HitCapsuleComponent = 0x0818;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData01 = 0x0820;

	}

	public class ATslMotorbikeVehicle
	{
		///<summary>bool</summary>
		public const int bUseKickstandStabilize = 0x07A0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x07A1;

		///<summary>float</summary>
		public const int MinSuspensionOffsetForContact = 0x07A4;

		///<summary>bool</summary>
		public const int bStabilizeOnServer = 0x07A8;

		///<summary>bool</summary>
		public const int bStabilizeOnRemoteClient = 0x07A9;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x07AA;

		///<summary>float</summary>
		public const int KickstandStabAngularDamp = 0x07AC;

		///<summary>float</summary>
		public const int KickstandMAV = 0x07B0;

		///<summary>float</summary>
		public const int DefaultAngularDamping_Client = 0x07B4;

		///<summary>float</summary>
		public const int DefaultAngularDamping_Server = 0x07B8;

		///<summary>float</summary>
		public const int NoDriverAngularDamping_Client = 0x07BC;

		///<summary>float</summary>
		public const int NoDriverAngularDamping_Server = 0x07C0;

		///<summary>float</summary>
		public const int KickstandStabilizeTorqueScalar = 0x07C4;

		///<summary>float</summary>
		public const int KickstandStabilizeRollScalar = 0x07C8;

		///<summary>float</summary>
		public const int KickstandStabilizeRollMinRange = 0x07CC;

		///<summary>float</summary>
		public const int MinVelocityForStabilizeOverride = 0x07D0;

		///<summary>float</summary>
		public const int KickstandStabLinearDamp = 0x07D4;

		///<summary>FName</summary>
		public const int StabilizeBone_Low = 0x07D8;

		///<summary>FName</summary>
		public const int StabilizeBone_High = 0x07E0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Roll = 0x07E8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_RollReturn = 0x07F0;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Steer = 0x07F8;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Yaw = 0x0800;

		///<summary>UCurveFloat *</summary>
		public const int Curve_Torque = 0x0808;

		///<summary>FVector</summary>
		public const int StabStaticVector = 0x0810;

		///<summary>FVector</summary>
		public const int StabStaticVectorKickstand = 0x081C;

		///<summary>FVector</summary>
		public const int StabNoDriverVector = 0x0828;

		///<summary>FVector2D</summary>
		public const int StabX_Velocity_In = 0x0834;

		///<summary>FVector2D</summary>
		public const int StabX_Velocity_Out = 0x083C;

		///<summary>FVector2D</summary>
		public const int StabX_Pitch_In = 0x0844;

		///<summary>FVector2D</summary>
		public const int StabX_Pitch_Out = 0x084C;

		///<summary>FVector2D</summary>
		public const int StabZ_Velocity_In = 0x0854;

		///<summary>FVector2D</summary>
		public const int StabZ_Velocity_Out = 0x085C;

		///<summary>FVector2D</summary>
		public const int StabZ_Roll_In = 0x0864;

		///<summary>FVector2D</summary>
		public const int StabZ_Roll_Out = 0x086C;

		///<summary>FVector2D</summary>
		public const int StabZ_Pitch_In = 0x0874;

		///<summary>FVector2D</summary>
		public const int StabZ_Pitch_Out = 0x087C;

		///<summary>FVector2D</summary>
		public const int StabTorque_In = 0x0884;

		///<summary>FVector2D</summary>
		public const int StabTorque_Out = 0x088C;

		///<summary>float</summary>
		public const int StabTorque_ForceScalar = 0x0894;

		///<summary>FVector2D</summary>
		public const int StabTorque_Pitch_In = 0x0898;

		///<summary>FVector2D</summary>
		public const int StabTorque_Pitch_Out = 0x08A0;

		///<summary>bool</summary>
		public const int bUseFlipping = 0x08A8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x08A9;

		///<summary>float</summary>
		public const int FlippingForce = 0x08AC;

		///<summary>float</summary>
		public const int InitialFlipTimer = 0x08B0;

		///<summary>float</summary>
		public const int MinVelocityForFlipping = 0x08B4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x08B8;

		///<summary>float</summary>
		public const int DefaultLinearDamp = 0x08BC;

		///<summary>float</summary>
		public const int DefaultAngularDamp = 0x08C0;

		///<summary>float</summary>
		public const int DefaultMAV = 0x08C4;

		///<summary>float</summary>
		public const int ContactAlpha_RiseRate = 0x08C8;

		///<summary>float</summary>
		public const int ContactAlpha_FallRate = 0x08CC;

		///<summary>float</summary>
		public const int ContactAlpha_LowerClamp = 0x08D0;

		///<summary>FVector2D</summary>
		public const int ContactAlpha_MapPitchIn = 0x08D4;

		///<summary>FVector2D</summary>
		public const int ContactAlpha_MapRollIn = 0x08DC;

		///<summary>float</summary>
		public const int ContactAlphaRemoteMultiplier = 0x08E4;

		///<summary>FVector2D</summary>
		public const int AirControlF_VelMap = 0x08E8;

		///<summary>FVector2D</summary>
		public const int AirControlB_VelMap = 0x08F0;

		///<summary>FVector2D</summary>
		public const int AirControlL_VelMap = 0x08F8;

		///<summary>FVector2D</summary>
		public const int AirControlR_VelMap = 0x0900;

		///<summary>FVector2D</summary>
		public const int AirControlQ_VelMap = 0x0908;

		///<summary>FVector2D</summary>
		public const int AirControlE_VelMap = 0x0910;

		///<summary>float</summary>
		public const int AirControl_FB_Torque = 0x0918;

		///<summary>float</summary>
		public const int AirControl_LR_Torque = 0x091C;

		///<summary>float</summary>
		public const int AirControl_QE_Torque = 0x0920;

		///<summary>bool</summary>
		public const int bStabilizeInAir = 0x0924;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData04 = 0x0925;

		///<summary>float</summary>
		public const int StabilizeAirPercentage = 0x0928;

		///<summary>float</summary>
		public const int FC_PitchUp = 0x092C;

		///<summary>float</summary>
		public const int FC_PitchDown = 0x0930;

		///<summary>bool</summary>
		public const int bUseAnchoring = 0x0934;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData05 = 0x0935;

		///<summary>float</summary>
		public const int MinImpulseForAnchorRelease = 0x0938;

		///<summary>FVector2D</summary>
		public const int DriverVelocityAngularDampingInMap = 0x093C;

		///<summary>FVector2D</summary>
		public const int DriverVelocityAngularDampingOutMap = 0x0944;

		///<summary>bool</summary>
		public const int bProcessCounterSteering = 0x094C;

		///<summary>bool</summary>
		public const int bProcessCounterSteerOnRemote = 0x094D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData06 = 0x094E;

		///<summary>float</summary>
		public const int CounterSteerAngularSpeedScalar = 0x0950;

		///<summary>float</summary>
		public const int CounterSteerScalar_Default = 0x0954;

		///<summary>float</summary>
		public const int CounterSteerScalar_NoThrottle = 0x0958;

		///<summary>float</summary>
		public const int CounterSteerScalar_Brake = 0x095C;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData07 = 0x0960;

		///<summary>bool</summary>
		public const int bKickstandStabilizeActive = 0x09A0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData08 = 0x09A1;

	}

	public class ATslMotorbikeVehicle_Sidecar
	{
		///<summary>FVector</summary>
		public const int Sidecar_StabilizerHigh_StaticCOM = 0x09B0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x09BC;

	}

	public class UTslWheelEffectType
	{
		///<summary>UAkAudioEvent *</summary>
		public const int Sound = 0x0030;

		///<summary>UClass *</summary>
		public const int DefaultFxClass = 0x0038;

		///<summary>UClass *</summary>
		public const int ConcreteFxClass = 0x0040;

		///<summary>UClass *</summary>
		public const int DirtFxClass = 0x0048;

		///<summary>UClass *</summary>
		public const int WaterFxClass = 0x0050;

		///<summary>UClass *</summary>
		public const int MetalFxClass = 0x0058;

		///<summary>UClass *</summary>
		public const int WoodFxClass = 0x0060;

		///<summary>UClass *</summary>
		public const int GrassFxClass = 0x0068;

		///<summary>UClass *</summary>
		public const int GlassFxClass = 0x0070;

		///<summary>UClass *</summary>
		public const int RockFxClass = 0x0078;

		///<summary>UClass *</summary>
		public const int SandFxClass = 0x0080;

		///<summary>float</summary>
		public const int DefaultMinSpeed = 0x0088;

		///<summary>float</summary>
		public const int ConcreteMinSpeed = 0x008C;

		///<summary>float</summary>
		public const int DirtMinSpeed = 0x0090;

		///<summary>float</summary>
		public const int WaterMinSpeed = 0x0094;

		///<summary>float</summary>
		public const int MetalMinSpeed = 0x0098;

		///<summary>float</summary>
		public const int WoodMinSpeed = 0x009C;

		///<summary>float</summary>
		public const int GrassMinSpeed = 0x00A0;

		///<summary>float</summary>
		public const int GlassMinSpeed = 0x00A4;

		///<summary>float</summary>
		public const int RockMinSpeed = 0x00A8;

		///<summary>float</summary>
		public const int SandMinSpeed = 0x00AC;

	}

	public class UVehicleRiderComponent
	{
		///<summary>int</summary>
		public const int SeatIndex = 0x01E0;

		///<summary>unsigned char[0x3C]</summary>
		public const int UnknownData00 = 0x01E4;

		///<summary>APawn *</summary>
		public const int LastVehiclePawn = 0x0220;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0228;

	}

	public class ATslVehicleSeatActor
	{
		///<summary>ERiderType</summary>
		public const int RiderType = 0x0438;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0439;

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
		public const int UnknownData00 = 0x01E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticipantMuteChanged = 0x01E8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnParticipantRestrictionChanged = 0x01F8;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0208;

		///<summary>FVivoxConnectionInfo</summary>
		public const int ConnectionInfo = 0x0210;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0230;

		///<summary>FString</summary>
		public const int TeamChannelUrl = 0x0238;

		///<summary>FString</summary>
		public const int GlobalChannelUrl = 0x0248;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0258;

		///<summary>float</summary>
		public const int ResetFailureDelaySeconds = 0x025C;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData04 = 0x0260;

		///<summary>float</summary>
		public const int UpdatePositionIntervalSeconds = 0x0278;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData05 = 0x027C;

		///<summary>float</summary>
		public const int UserInputVolumeModifier = 0x0288;

		///<summary>float</summary>
		public const int UserOutputVolumeModifier = 0x028C;

	}

	public class UVivoxComponent
	{
		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData00 = 0x0290;

		///<summary>float</summary>
		public const int SuddenMovementDistance = 0x02BC;

		///<summary>float</summary>
		public const int SuddenMovementModifier = 0x02C0;

		///<summary>float</summary>
		public const int SuddenMovementModifierDuration = 0x02C4;

		///<summary>float</summary>
		public const int SuddenMovementModifierRestoreDuration = 0x02C8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x02CC;

		///<summary>bool</summary>
		public const int bEnableObserverTeamChat = 0x02D0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData02 = 0x02D1;

	}

	public class UVivoxLobbyComponent
	{
		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x0290;

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

		///<summary>TArray&lt;UChannelResponse * &gt;</summary>
		public const int Channels = 0x00D0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x00E0;

		///<summary>TArray&lt;ATslPlayerController * &gt;</summary>
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
		public const int WeaponAttachPointRifle = 0x01E0;

		///<summary>FName</summary>
		public const int WeaponAttachPointThrowable = 0x01E8;

		///<summary>FName</summary>
		public const int WeaponAttachPointMelee = 0x01F0;

		///<summary>USkeletalMeshComponent *</summary>
		public const int MeshComponent = 0x01F8;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Primary = 0x0200;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Secondary = 0x0208;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Sidearm = 0x0210;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Melee = 0x0218;

		///<summary>UTslAccessoryComponent *</summary>
		public const int CharacterAccessory_Thrown = 0x0220;

		///<summary>FName</summary>
		public const int WeaponLeftHandIKAttachPoint = 0x0228;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0230;

	}

	public class UCharacterWeaponAnimInfoComponent
	{
		///<summary>FName</summary>
		public const int WeaponAttachPointPistolSitting = 0x0240;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifleDriving = 0x0248;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifleSitting = 0x0250;

		///<summary>FName</summary>
		public const int WeaponAttachPointRifleAim = 0x0258;

		///<summary>FName</summary>
		public const int WeaponAttachPointThrowableDriving = 0x0260;

		///<summary>FName</summary>
		public const int WeaponAttachPointMeleeDriving = 0x0268;

	}

	public class UWeaponClone
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>ATslWeapon *</summary>
		public const int ClonedWeapon = 0x0038;

	}

	public class UWeaponsPenetrationConfig
	{
		///<summary>TMap&lt;UPhysicalMaterial *,FPhysicalMaterialPenetrationConfig&gt;</summary>
		public const int MaterialConfigOverrides = 0x0080;

		///<summary>TMap&lt;UClass *,FWeaponPenetrationConfig&gt;</summary>
		public const int WeaponConfigOverrides = 0x0120;

		///<summary>float</summary>
		public const int DeflectionRange = 0x01C0;

		///<summary>int</summary>
		public const int MaxSurfacesNum = 0x01C4;

		///<summary>float</summary>
		public const int MinImpactAngleDeg = 0x01C8;

		///<summary>float</summary>
		public const int MinDetectableHollowSize = 0x01CC;

		///<summary>float</summary>
		public const int MinOutSpeed = 0x01D0;

		///<summary>float</summary>
		public const int MinWaterSpeed = 0x01D4;

	}

}
