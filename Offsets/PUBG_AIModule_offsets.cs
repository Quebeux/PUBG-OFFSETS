/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBTNode
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FString</summary>
		public const int NodeName = 0x0030;

		///<summary>UBehaviorTree *</summary>
		public const int TreeAsset = 0x0040;

		///<summary>UBTCompositeNode *</summary>
		public const int ParentNode = 0x0048;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0050;

	}

	public class UBTAuxiliaryNode
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0058;

	}

	public class UBTDecorator
	{
		///<summary>unsigned char:7</summary>
		public const int UnknownData00 = 0x0060;

		///<summary>unsigned char:1</summary>
		public const int bInverseCondition = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0061;

		///<summary>TEnumAsByte&lt;EBTFlowAbortMode&gt;</summary>
		public const int FlowAbortMode = 0x0064;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0065;

	}

	public class UBTTaskNode
	{
		///<summary>TArray&lt;UBTService * &gt;</summary>
		public const int Services = 0x0058;

		///<summary>unsigned char:1</summary>
		public const int bIgnoreRestartSelf = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UBTTask_BlackboardBase
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKey = 0x0070;

	}

	public class AAIController
	{
		///<summary>unsigned char[0x38]</summary>
		public const int UnknownData00 = 0x0418;

		///<summary>unsigned char:1</summary>
		public const int bStopAILogicOnUnposses = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bLOSflag = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bSkipExtraLOSChecks = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bAllowStrafe = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bWantsPlayerState = 0x0450;

		///<summary>unsigned char:1</summary>
		public const int bSetControlRotationFromPawnOrientation = 0x0450;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0451;

		///<summary>UPathFollowingComponent *</summary>
		public const int PathFollowingComponent = 0x0458;

		///<summary>UBrainComponent *</summary>
		public const int BrainComponent = 0x0460;

		///<summary>UAIPerceptionComponent *</summary>
		public const int PerceptionComponent = 0x0468;

		///<summary>UPawnActionsComponent *</summary>
		public const int ActionsComp = 0x0470;

		///<summary>UBlackboardComponent *</summary>
		public const int Blackboard = 0x0478;

		///<summary>UGameplayTasksComponent *</summary>
		public const int CachedGameplayTasksComponent = 0x0480;

		///<summary>UClass *</summary>
		public const int DefaultNavigationFilterClass = 0x0488;

		///<summary>FScriptMulticastDelegate</summary>
		public const int ReceiveMoveCompleted = 0x0490;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x04A0;

	}

	public class UPathFollowingComponent
	{
		///<summary>unsigned char[0x120]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>UNavMovementComponent *</summary>
		public const int MovementComp = 0x0300;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0308;

		///<summary>ANavigationData *</summary>
		public const int MyNavData = 0x0310;

		///<summary>unsigned char[0x178]</summary>
		public const int UnknownData02 = 0x0318;

	}

	public class UAIAsyncTaskBlueprintProxy
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSuccess = 0x0028;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFail = 0x0038;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UAIDataProvider_QueryParams
	{
		///<summary>FName</summary>
		public const int ParamName = 0x0028;

		///<summary>float</summary>
		public const int FloatValue = 0x0030;

		///<summary>int</summary>
		public const int IntValue = 0x0034;

		///<summary>bool</summary>
		public const int BoolValue = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

	}

	public class UAIDataProvider_Random
	{
		///<summary>float</summary>
		public const int Min = 0x0040;

		///<summary>float</summary>
		public const int Max = 0x0044;

		///<summary>unsigned char:1</summary>
		public const int bInteger = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UAISense
	{
		///<summary>float</summary>
		public const int DefaultExpirationAge = 0x0028;

		///<summary>EAISenseNotifyType</summary>
		public const int NotifyType = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x002D;

		///<summary>unsigned char:1</summary>
		public const int bWantsNewPawnNotification = 0x0030;

		///<summary>unsigned char:1</summary>
		public const int bAutoRegisterAllPawnsAsSources = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

		///<summary>UAIPerceptionSystem *</summary>
		public const int PerceptionSystemInstance = 0x0038;

		///<summary>unsigned char[0xE0]</summary>
		public const int UnknownData02 = 0x0040;

	}

	public class UAIPerceptionSystem
	{
		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UAISense * &gt;</summary>
		public const int Senses = 0x0080;

		///<summary>float</summary>
		public const int PerceptionAgingRate = 0x0090;

		///<summary>unsigned char[0x9C]</summary>
		public const int UnknownData01 = 0x0094;

	}

	public class UAIPerceptionComponent
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x01E0;

		///<summary>UClass *</summary>
		public const int DominantSense = 0x01E8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x01F0;

		///<summary>AAIController *</summary>
		public const int AIOwner = 0x0200;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData02 = 0x0208;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPerceptionUpdated = 0x0288;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTargetPerceptionUpdated = 0x0298;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData03 = 0x02A8;

	}

	public class UAIPerceptionStimuliSourceComponent
	{
		///<summary>TArray&lt;UClass * &gt;</summary>
		public const int RegisterAsSourceForSenses = 0x01E0;

	}

	public class UAISense_Blueprint
	{
		///<summary>UClass *</summary>
		public const int ListenerDataType = 0x0120;

		///<summary>TArray&lt;UAIPerceptionComponent * &gt;</summary>
		public const int ListenerContainer = 0x0128;

		///<summary>TArray&lt;UAISenseEvent * &gt;</summary>
		public const int UnprocessedEvents = 0x0138;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0148;

	}

	public class UAISense_Damage
	{
		///<summary>TArray&lt;FAIDamageEvent&gt;</summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISense_Hearing
	{
		///<summary>TArray&lt;FAINoiseEvent&gt;</summary>
		public const int NoiseEvents = 0x0120;

		///<summary>float</summary>
		public const int SpeedOfSoundSq = 0x0130;

		///<summary>unsigned char[0x5C]</summary>
		public const int UnknownData00 = 0x0134;

	}

	public class UAISense_Prediction
	{
		///<summary>TArray&lt;FAIPredictionEvent&gt;</summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISense_Sight
	{
		///<summary>unsigned char[0xB0]</summary>
		public const int UnknownData00 = 0x0120;

		///<summary>int</summary>
		public const int MaxTracesPerTick = 0x01D0;

		///<summary>int</summary>
		public const int MinQueriesPerTimeSliceCheck = 0x01D4;

		///<summary>double</summary>
		public const int MaxTimeSlicePerTick = 0x01D8;

		///<summary>float</summary>
		public const int HighImportanceQueryDistanceThreshold = 0x01E0;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x01E4;

		///<summary>float</summary>
		public const int MaxQueryImportance = 0x01E8;

		///<summary>float</summary>
		public const int SightLimitQueryImportance = 0x01EC;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x01F0;

	}

	public class UAISense_Team
	{
		///<summary>TArray&lt;FAITeamStimulusEvent&gt;</summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISense_Touch
	{
		///<summary>TArray&lt;FAITouchEvent&gt;</summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISenseConfig
	{
		///<summary>FColor</summary>
		public const int DebugColor = 0x0028;

		///<summary>float</summary>
		public const int MaxAge = 0x002C;

		///<summary>unsigned char:1</summary>
		public const int bStartsEnabled = 0x0030;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UAISenseConfig_Blueprint
	{
		///<summary>UClass *</summary>
		public const int Implementation = 0x0048;

	}

	public class UAISenseConfig_Damage
	{
		///<summary>UClass *</summary>
		public const int Implementation = 0x0048;

	}

	public class UAISenseConfig_Hearing
	{
		///<summary>UClass *</summary>
		public const int Implementation = 0x0048;

		///<summary>float</summary>
		public const int HearingRange = 0x0050;

		///<summary>float</summary>
		public const int LoSHearingRange = 0x0054;

		///<summary>unsigned char:1</summary>
		public const int bUseLoSHearing = 0x0058;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0059;

		///<summary>FAISenseAffiliationFilter</summary>
		public const int DetectionByAffiliation = 0x005C;

	}

	public class UAISenseConfig_Sight
	{
		///<summary>UClass *</summary>
		public const int Implementation = 0x0048;

		///<summary>float</summary>
		public const int SightRadius = 0x0050;

		///<summary>float</summary>
		public const int LoseSightRadius = 0x0054;

		///<summary>float</summary>
		public const int PeripheralVisionAngleDegrees = 0x0058;

		///<summary>FAISenseAffiliationFilter</summary>
		public const int DetectionByAffiliation = 0x005C;

		///<summary>float</summary>
		public const int AutoSuccessRangeFromLastSeenLocation = 0x0060;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0064;

	}

	public class UAISenseEvent_Damage
	{
		///<summary>FAIDamageEvent</summary>
		public const int Event = 0x0028;

	}

	public class UAISenseEvent_Hearing
	{
		///<summary>FAINoiseEvent</summary>
		public const int Event = 0x0028;

	}

	public class UAISystem
	{
		///<summary>FStringClassReference</summary>
		public const int PerceptionSystemClassName = 0x0048;

		///<summary>FStringClassReference</summary>
		public const int HotSpotManagerClassName = 0x0058;

		///<summary>float</summary>
		public const int AcceptanceRadius = 0x0068;

		///<summary>float</summary>
		public const int PathfollowingRegularPathPointAcceptanceRadius = 0x006C;

		///<summary>float</summary>
		public const int PathfollowingNavLinkAcceptanceRadius = 0x0070;

		///<summary>bool</summary>
		public const int bFinishMoveOnGoalOverlap = 0x0074;

		///<summary>bool</summary>
		public const int bAcceptPartialPaths = 0x0075;

		///<summary>bool</summary>
		public const int bAllowStrafing = 0x0076;

		///<summary>bool</summary>
		public const int bEnableBTAITasks = 0x0077;

		///<summary>bool</summary>
		public const int bAllowControllersAsEQSQuerier = 0x0078;

		///<summary>bool</summary>
		public const int bEnableDebuggerPlugin = 0x0079;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int DefaultSightCollisionChannel = 0x007A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x007B;

		///<summary>UBehaviorTreeManager *</summary>
		public const int BehaviorTreeManager = 0x0080;

		///<summary>UEnvQueryManager *</summary>
		public const int EnvironmentQueryManager = 0x0088;

		///<summary>UAIPerceptionSystem *</summary>
		public const int PerceptionSystem = 0x0090;

		///<summary>TArray&lt;UAIAsyncTaskBlueprintProxy * &gt;</summary>
		public const int AllProxyObjects = 0x0098;

		///<summary>UAIHotSpotManager *</summary>
		public const int HotSpotManager = 0x00A8;

		///<summary>UNavLocalGridManager *</summary>
		public const int NavLocalGrids = 0x00B0;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData01 = 0x00B8;

	}

	public class UAITask
	{
		///<summary>AAIController *</summary>
		public const int OwnerController = 0x0068;

	}

	public class UAITask_MoveTo
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnRequestFailed = 0x0070;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMoveFinished = 0x0080;

		///<summary>FAIMoveRequest</summary>
		public const int MoveRequest = 0x0090;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x00D0;

	}

	public class UEnvQueryItemType
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UAITask_RunEQS
	{
		///<summary>unsigned char[0xE0]</summary>
		public const int UnknownData00 = 0x0070;

	}

	public class UBrainComponent
	{
		///<summary>UBlackboardComponent *</summary>
		public const int BlackboardComp = 0x01E0;

		///<summary>AAIController *</summary>
		public const int AIOwner = 0x01E8;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x01F0;

	}

	public class UBehaviorTreeComponent
	{
		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0240;

		///<summary>TArray&lt;UBTNode * &gt;</summary>
		public const int NodeInstances = 0x0258;

		///<summary>unsigned char[0x108]</summary>
		public const int UnknownData01 = 0x0268;

	}

	public class UBTCompositeNode
	{
		///<summary>TArray&lt;FBTCompositeChild&gt;</summary>
		public const int Children = 0x0058;

		///<summary>TArray&lt;UBTService * &gt;</summary>
		public const int Services = 0x0068;

		///<summary>unsigned char[0x58]</summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UBehaviorTree
	{
		///<summary>UBTCompositeNode *</summary>
		public const int RootNode = 0x0028;

		///<summary>UBlackboardData *</summary>
		public const int BlackboardAsset = 0x0030;

		///<summary>TArray&lt;UBTDecorator * &gt;</summary>
		public const int RootDecorators = 0x0038;

		///<summary>TArray&lt;FBTDecoratorLogic&gt;</summary>
		public const int RootDecoratorOps = 0x0048;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0058;

	}

	public class UBehaviorTreeManager
	{
		///<summary>int</summary>
		public const int MaxDebuggerSteps = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

		///<summary>TArray&lt;FBehaviorTreeTemplateInfo&gt;</summary>
		public const int LoadedTemplates = 0x0030;

		///<summary>TArray&lt;UBehaviorTreeComponent * &gt;</summary>
		public const int ActiveComponents = 0x0040;

	}

	public class UBlackboardKeyType
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UBlackboardData
	{
		///<summary>UBlackboardData *</summary>
		public const int Parent = 0x0030;

		///<summary>TArray&lt;FBlackboardEntry&gt;</summary>
		public const int Keys = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bHasSynchronizedKeys = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UBlackboardComponent
	{
		///<summary>UBlackboardData *</summary>
		public const int BlackboardAsset = 0x01E0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x01E8;

		///<summary>TArray&lt;UBlackboardKeyType * &gt;</summary>
		public const int KeyInstances = 0x0208;

		///<summary>unsigned char[0xB8]</summary>
		public const int UnknownData01 = 0x0218;

	}

	public class UBlackboardKeyType_Class
	{
		///<summary>UClass *</summary>
		public const int BaseClass = 0x0030;

	}

	public class UBlackboardKeyType_Enum
	{
		///<summary>UEnum *</summary>
		public const int EnumType = 0x0030;

		///<summary>FString</summary>
		public const int EnumName = 0x0038;

		///<summary>unsigned char:1</summary>
		public const int bIsEnumNameValid = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UBlackboardKeyType_NativeEnum
	{
		///<summary>FString</summary>
		public const int EnumName = 0x0030;

		///<summary>UEnum *</summary>
		public const int EnumType = 0x0040;

	}

	public class UBlackboardKeyType_Object
	{
		///<summary>UClass *</summary>
		public const int BaseClass = 0x0030;

	}

	public class UBlackboardKeyType_String
	{
		///<summary>FString</summary>
		public const int StringValue = 0x0030;

	}

	public class UBTDecorator_BlackboardBase
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKey = 0x0068;

	}

	public class UBTDecorator_Blackboard
	{
		///<summary>int</summary>
		public const int IntValue = 0x0090;

		///<summary>float</summary>
		public const int FloatValue = 0x0094;

		///<summary>FString</summary>
		public const int StringValue = 0x0098;

		///<summary>FString</summary>
		public const int CachedDescription = 0x00A8;

		///<summary>unsigned char</summary>
		public const int OperationType = 0x00B8;

		///<summary>TEnumAsByte&lt;EBTBlackboardRestart&gt;</summary>
		public const int NotifyObserver = 0x00B9;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x00BA;

	}

	public class UBTDecorator_IsAtLocation
	{
		///<summary>float</summary>
		public const int AcceptableRadius = 0x0090;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0094;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ParametrizedAcceptableRadius = 0x0098;

		///<summary>EFAIDistanceType</summary>
		public const int GeometricDistanceType = 0x00C8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00C9;

		///<summary>unsigned char:1</summary>
		public const int bUseParametrizedRadius = 0x00CC;

		///<summary>unsigned char:1</summary>
		public const int bUseNavAgentGoalLocation = 0x00CC;

		///<summary>unsigned char:1</summary>
		public const int bPathFindingBasedTest = 0x00CC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x00CD;

	}

	public class UBTDecorator_IsBBEntryOfClass
	{
		///<summary>UClass *</summary>
		public const int TestClass = 0x0090;

	}

	public class UBTDecorator_BlueprintBase
	{
		///<summary>AAIController *</summary>
		public const int AIOwner = 0x0068;

		///<summary>AActor *</summary>
		public const int ActorOwner = 0x0070;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int ObservedKeyNames = 0x0078;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0088;

		///<summary>unsigned char:1</summary>
		public const int bShowPropertyDetails = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bCheckConditionOnlyBlackBoardChanges = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bIsObservingBB = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0099;

	}

	public class UBTDecorator_CheckGameplayTagsOnActor
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int ActorToCheck = 0x0068;

		///<summary>EGameplayContainerMatchType</summary>
		public const int TagsToMatch = 0x0090;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0091;

		///<summary>FGameplayTagContainer</summary>
		public const int GameplayTags = 0x0098;

		///<summary>FString</summary>
		public const int CachedDescription = 0x00B8;

	}

	public class UBTDecorator_CompareBBEntries
	{
		///<summary>TEnumAsByte&lt;EBlackBoardEntryComparison&gt;</summary>
		public const int Operator = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0069;

		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKeyA = 0x0070;

		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKeyB = 0x0098;

	}

	public class UBTDecorator_ConeCheck
	{
		///<summary>float</summary>
		public const int ConeHalfAngle = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x006C;

		///<summary>FBlackboardKeySelector</summary>
		public const int ConeOrigin = 0x0070;

		///<summary>FBlackboardKeySelector</summary>
		public const int ConeDirection = 0x0098;

		///<summary>FBlackboardKeySelector</summary>
		public const int Observed = 0x00C0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x00E8;

	}

	public class UBTDecorator_Cooldown
	{
		///<summary>float</summary>
		public const int CoolDownTime = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x006C;

	}

	public class UBTDecorator_DoesPathExist
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKeyA = 0x0068;

		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKeyB = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bUseSelf = 0x00B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x00B9;

		///<summary>TEnumAsByte&lt;EPathExistanceQueryType&gt;</summary>
		public const int PathQueryType = 0x00BC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00BD;

		///<summary>UClass *</summary>
		public const int FilterClass = 0x00C0;

	}

	public class UBTDecorator_KeepInCone
	{
		///<summary>float</summary>
		public const int ConeHalfAngle = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x006C;

		///<summary>FBlackboardKeySelector</summary>
		public const int ConeOrigin = 0x0070;

		///<summary>FBlackboardKeySelector</summary>
		public const int Observed = 0x0098;

		///<summary>unsigned char:1</summary>
		public const int bUseSelfAsOrigin = 0x00C0;

		///<summary>unsigned char:1</summary>
		public const int bUseSelfAsObserved = 0x00C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00C1;

	}

	public class UBTDecorator_Loop
	{
		///<summary>int</summary>
		public const int NumLoops = 0x0068;

		///<summary>bool</summary>
		public const int bInfiniteLoop = 0x006C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x006D;

		///<summary>float</summary>
		public const int InfiniteLoopTimeoutTime = 0x0070;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0074;

	}

	public class UBTDecorator_SetTagCooldown
	{
		///<summary>FGameplayTag</summary>
		public const int CooldownTag = 0x0068;

		///<summary>float</summary>
		public const int CooldownDuration = 0x0070;

		///<summary>bool</summary>
		public const int bAddToExistingDuration = 0x0074;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0075;

	}

	public class UBTDecorator_TagCooldown
	{
		///<summary>FGameplayTag</summary>
		public const int CooldownTag = 0x0068;

		///<summary>float</summary>
		public const int CooldownDuration = 0x0070;

		///<summary>bool</summary>
		public const int bAddToExistingDuration = 0x0074;

		///<summary>bool</summary>
		public const int bActivatesCooldown = 0x0075;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0076;

	}

	public class UBTDecorator_TimeLimit
	{
		///<summary>float</summary>
		public const int TimeLimit = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x006C;

	}

	public class UBTService
	{
		///<summary>float</summary>
		public const int Interval = 0x0060;

		///<summary>float</summary>
		public const int RandomDeviation = 0x0064;

		///<summary>unsigned char:1</summary>
		public const int bCallTickOnSearchStart = 0x0068;

		///<summary>unsigned char:1</summary>
		public const int bRestartTimerOnEachActivation = 0x0068;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UBTService_BlackboardBase
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKey = 0x0070;

	}

	public class UBTService_DefaultFocus
	{
		///<summary>unsigned char</summary>
		public const int FocusPriority = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UBTService_RunEQS
	{
		///<summary>FEQSParametrizedQueryExecutionRequest</summary>
		public const int EQSRequest = 0x0098;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x00E0;

	}

	public class UBTService_BlueprintBase
	{
		///<summary>AAIController *</summary>
		public const int AIOwner = 0x0070;

		///<summary>AActor *</summary>
		public const int ActorOwner = 0x0078;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bShowPropertyDetails = 0x0090;

		///<summary>unsigned char:1</summary>
		public const int bShowEventDetails = 0x0090;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0091;

	}

	public class UBTTask_MoveTo
	{
		///<summary>float</summary>
		public const int AcceptableRadius = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

		///<summary>UClass *</summary>
		public const int FilterClass = 0x00A0;

		///<summary>float</summary>
		public const int ObservedBlackboardValueTolerance = 0x00A8;

		///<summary>unsigned char:1</summary>
		public const int bObserveBlackboardValue = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bAllowStrafe = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bAllowPartialPath = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bTrackMovingGoal = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bProjectGoalLocation = 0x00AC;

		///<summary>unsigned char:1</summary>
		public const int bStopOnOverlap = 0x00AC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x00AD;

	}

	public class UBTTask_MoveDirectlyToward
	{
		///<summary>unsigned char:1</summary>
		public const int bDisablePathUpdateOnGoalLocationChange = 0x00B0;

		///<summary>unsigned char:1</summary>
		public const int bProjectVectorGoalToNavigation = 0x00B0;

		///<summary>unsigned char:1</summary>
		public const int bUpdatedDeprecatedProperties = 0x00B0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00B1;

	}

	public class UBTTask_RotateToFaceBBEntry
	{
		///<summary>float</summary>
		public const int Precision = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UBTTask_RunEQSQuery
	{
		///<summary>UEnvQuery *</summary>
		public const int QueryTemplate = 0x0098;

		///<summary>TArray&lt;FEnvNamedValue&gt;</summary>
		public const int QueryParams = 0x00A0;

		///<summary>TArray&lt;FAIDynamicParam&gt;</summary>
		public const int QueryConfig = 0x00B0;

		///<summary>TEnumAsByte&lt;EEnvQueryRunMode&gt;</summary>
		public const int RunMode = 0x00C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00C1;

		///<summary>FBlackboardKeySelector</summary>
		public const int EQSQueryBlackboardKey = 0x00C8;

		///<summary>bool</summary>
		public const int bUseBBKey = 0x00F0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x00F1;

		///<summary>FEQSParametrizedQueryExecutionRequest</summary>
		public const int EQSRequest = 0x00F8;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData02 = 0x0140;

	}

	public class UBTTask_BlueprintBase
	{
		///<summary>AAIController *</summary>
		public const int AIOwner = 0x0070;

		///<summary>AActor *</summary>
		public const int ActorOwner = 0x0078;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0080;

		///<summary>unsigned char:1</summary>
		public const int bShowPropertyDetails = 0x0098;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0099;

	}

	public class UBTTask_GameplayTaskBase
	{
		///<summary>unsigned char:1</summary>
		public const int bWaitForGameplayTask = 0x0070;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0071;

	}

	public class UBTTask_MakeNoise
	{
		///<summary>float</summary>
		public const int Loudnes = 0x0070;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0074;

	}

	public class UBTTask_PushPawnAction
	{
		///<summary>UPawnAction *</summary>
		public const int Action = 0x0070;

	}

	public class UBTTask_PlayAnimation
	{
		///<summary>UAnimationAsset *</summary>
		public const int AnimationToPlay = 0x0070;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x0078;

		///<summary>unsigned char:1</summary>
		public const int bNonBlocking = 0x0078;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0079;

		///<summary>UBehaviorTreeComponent *</summary>
		public const int MyOwnerComp = 0x0080;

		///<summary>USkeletalMeshComponent *</summary>
		public const int CachedSkelMesh = 0x0088;

		///<summary>unsigned char[0x60]</summary>
		public const int UnknownData01 = 0x0090;

	}

	public class UBTTask_PlaySound
	{
		///<summary>USoundCue *</summary>
		public const int SoundToPlay = 0x0070;

	}

	public class UBTTask_RunBehavior
	{
		///<summary>UBehaviorTree *</summary>
		public const int BehaviorAsset = 0x0070;

	}

	public class UBTTask_RunBehaviorDynamic
	{
		///<summary>FGameplayTag</summary>
		public const int InjectionTag = 0x0070;

		///<summary>UBehaviorTree *</summary>
		public const int DefaultBehaviorAsset = 0x0078;

		///<summary>UBehaviorTree *</summary>
		public const int BehaviorAsset = 0x0080;

	}

	public class UBTTask_SetTagCooldown
	{
		///<summary>FGameplayTag</summary>
		public const int CooldownTag = 0x0070;

		///<summary>bool</summary>
		public const int bAddToExistingDuration = 0x0078;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0079;

		///<summary>float</summary>
		public const int CooldownDuration = 0x007C;

	}

	public class UBTTask_Wait
	{
		///<summary>float</summary>
		public const int WaitTime = 0x0070;

		///<summary>float</summary>
		public const int RandomDeviation = 0x0074;

	}

	public class UBTTask_WaitBlackboardTime
	{
		///<summary>FBlackboardKeySelector</summary>
		public const int BlackboardKey = 0x0078;

	}

	public class UCrowdManager
	{
		///<summary>ANavigationData *</summary>
		public const int MyNavData = 0x0028;

		///<summary>TArray&lt;FCrowdAvoidanceConfig&gt;</summary>
		public const int AvoidanceConfig = 0x0030;

		///<summary>TArray&lt;FCrowdAvoidanceSamplingPattern&gt;</summary>
		public const int SamplingPatterns = 0x0040;

		///<summary>int</summary>
		public const int MaxAgents = 0x0050;

		///<summary>float</summary>
		public const int MaxAgentRadius = 0x0054;

		///<summary>int</summary>
		public const int MaxAvoidedAgents = 0x0058;

		///<summary>int</summary>
		public const int MaxAvoidedWalls = 0x005C;

		///<summary>float</summary>
		public const int NavmeshCheckInterval = 0x0060;

		///<summary>float</summary>
		public const int PathOptimizationInterval = 0x0064;

		///<summary>float</summary>
		public const int SeparationDirClamp = 0x0068;

		///<summary>unsigned char:4</summary>
		public const int UnknownData00 = 0x006C;

		///<summary>unsigned char:1</summary>
		public const int bResolveCollisions = 0x006C;

		///<summary>unsigned char[0x7B]</summary>
		public const int UnknownData01 = 0x006D;

	}

	public class UEnvQuery
	{
		///<summary>FName</summary>
		public const int QueryName = 0x0030;

		///<summary>TArray&lt;UEnvQueryOption * &gt;</summary>
		public const int Options = 0x0038;

	}

	public class UEnvQueryContext_BlueprintBase
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UEnvQueryInstanceBlueprintWrapper
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>int</summary>
		public const int QueryID = 0x0030;

		///<summary>unsigned char[0x24]</summary>
		public const int UnknownData01 = 0x0034;

		///<summary>UClass *</summary>
		public const int ItemType = 0x0058;

		///<summary>int</summary>
		public const int OptionIndex = 0x0060;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0064;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnQueryFinishedEvent = 0x0068;

	}

	public class UEnvQueryManager
	{
		///<summary>unsigned char[0x78]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FEnvQueryInstanceCache&gt;</summary>
		public const int InstanceCache = 0x00A0;

		///<summary>TArray&lt;UEnvQueryContext * &gt;</summary>
		public const int LocalContexts = 0x00B0;

		///<summary>TArray&lt;UEnvQueryInstanceBlueprintWrapper * &gt;</summary>
		public const int GCShieldedWrappers = 0x00C0;

		///<summary>unsigned char[0x54]</summary>
		public const int UnknownData01 = 0x00D0;

		///<summary>float</summary>
		public const int MaxAllowedTestingTime = 0x0124;

		///<summary>bool</summary>
		public const int bTestQueriesUsingBreadth = 0x0128;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0129;

		///<summary>int</summary>
		public const int QueryCountWarningThreshold = 0x012C;

		///<summary>double</summary>
		public const int QueryCountWarningInterval = 0x0130;

	}

	public class UEnvQueryNode
	{
		///<summary>int</summary>
		public const int VerNum = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UEnvQueryGenerator
	{
		///<summary>FString</summary>
		public const int OptionName = 0x0030;

		///<summary>UClass *</summary>
		public const int ItemType = 0x0040;

		///<summary>unsigned char:1</summary>
		public const int bAutoSortTests = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UEnvQueryGenerator_ActorsOfClass
	{
		///<summary>UClass *</summary>
		public const int SearchedActorClass = 0x0050;

		///<summary>FAIDataProviderBoolValue</summary>
		public const int GenerateOnlyActorsInRadius = 0x0058;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int SearchRadius = 0x0088;

		///<summary>UClass *</summary>
		public const int SearchCenter = 0x00B8;

	}

	public class UEnvQueryGenerator_BlueprintBase
	{
		///<summary>FText</summary>
		public const int GeneratorsActionDescription = 0x0050;

		///<summary>UClass *</summary>
		public const int Context = 0x0068;

		///<summary>UClass *</summary>
		public const int GeneratedItemType = 0x0070;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UEnvQueryGenerator_Composite
	{
		///<summary>TArray&lt;UEnvQueryGenerator * &gt;</summary>
		public const int Generators = 0x0050;

		///<summary>bool</summary>
		public const int bHasMatchingItemType = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UEnvQueryGenerator_CurrentLocation
	{
		///<summary>UClass *</summary>
		public const int QueryContext = 0x0050;

	}

	public class UEnvQueryGenerator_ProjectedPoints
	{
		///<summary>FEnvTraceData</summary>
		public const int ProjectionData = 0x0050;

	}

	public class UEnvQueryGenerator_Cone
	{
		///<summary>FAIDataProviderFloatValue</summary>
		public const int AlignedPointsDistance = 0x0080;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ConeDegrees = 0x00B0;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int AngleStep = 0x00E0;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int Range = 0x0110;

		///<summary>UClass *</summary>
		public const int CenterActor = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bIncludeContextLocation = 0x0148;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0149;

	}

	public class UEnvQueryGenerator_Donut
	{
		///<summary>FAIDataProviderFloatValue</summary>
		public const int InnerRadius = 0x0080;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int OuterRadius = 0x00B0;

		///<summary>FAIDataProviderIntValue</summary>
		public const int NumberOfRings = 0x00E0;

		///<summary>FAIDataProviderIntValue</summary>
		public const int PointsPerRing = 0x0110;

		///<summary>FEnvDirection</summary>
		public const int ArcDirection = 0x0140;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ArcAngle = 0x0160;

		///<summary>bool</summary>
		public const int bUseSpiralPattern = 0x0190;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0191;

		///<summary>UClass *</summary>
		public const int Center = 0x0198;

		///<summary>unsigned char:1</summary>
		public const int bDefineArc = 0x01A0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x01A1;

	}

	public class UEnvQueryGenerator_OnCircle
	{
		///<summary>FAIDataProviderFloatValue</summary>
		public const int CircleRadius = 0x0080;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int SpaceBetween = 0x00B0;

		///<summary>FAIDataProviderIntValue</summary>
		public const int NumberOfPoints = 0x00E0;

		///<summary>EPointOnCircleSpacingMethod</summary>
		public const int PointOnCircleSpacingMethod = 0x0110;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0111;

		///<summary>FEnvDirection</summary>
		public const int ArcDirection = 0x0118;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ArcAngle = 0x0138;

		///<summary>float</summary>
		public const int AngleRadians = 0x0168;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x016C;

		///<summary>UClass *</summary>
		public const int CircleCenter = 0x0170;

		///<summary>bool</summary>
		public const int bIgnoreAnyContextActorsWhenGeneratingCircle = 0x0178;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0179;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int CircleCenterZOffset = 0x0180;

		///<summary>FEnvTraceData</summary>
		public const int TraceData = 0x01B0;

		///<summary>unsigned char:1</summary>
		public const int bDefineArc = 0x01E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x01E1;

	}

	public class UEnvQueryGenerator_SimpleGrid
	{
		///<summary>FAIDataProviderFloatValue</summary>
		public const int GridSize = 0x0080;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int SpaceBetween = 0x00B0;

		///<summary>UClass *</summary>
		public const int GenerateAround = 0x00E0;

	}

	public class UEnvQueryGenerator_PathingGrid
	{
		///<summary>FAIDataProviderBoolValue</summary>
		public const int PathToItem = 0x00E8;

		///<summary>UClass *</summary>
		public const int NavigationFilter = 0x0118;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ScanRangeMultiplier = 0x0120;

	}

	public class UEnvQueryTest
	{
		///<summary>int</summary>
		public const int TestOrder = 0x0030;

		///<summary>TEnumAsByte&lt;EEnvTestPurpose&gt;</summary>
		public const int TestPurpose = 0x0034;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0035;

		///<summary>FString</summary>
		public const int TestComment = 0x0038;

		///<summary>TEnumAsByte&lt;EEnvTestFilterOperator&gt;</summary>
		public const int MultipleContextFilterOp = 0x0048;

		///<summary>TEnumAsByte&lt;EEnvTestScoreOperator&gt;</summary>
		public const int MultipleContextScoreOp = 0x0049;

		///<summary>TEnumAsByte&lt;EEnvTestFilterType&gt;</summary>
		public const int FilterType = 0x004A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData01 = 0x004B;

		///<summary>FAIDataProviderBoolValue</summary>
		public const int BoolValue = 0x0050;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int FloatValueMin = 0x0080;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int FloatValueMax = 0x00B0;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x00E0;

		///<summary>TEnumAsByte&lt;EEnvTestScoreEquation&gt;</summary>
		public const int ScoringEquation = 0x00E1;

		///<summary>TEnumAsByte&lt;EEnvQueryTestClamping&gt;</summary>
		public const int ClampMinType = 0x00E2;

		///<summary>TEnumAsByte&lt;EEnvQueryTestClamping&gt;</summary>
		public const int ClampMaxType = 0x00E3;

		///<summary>EEQSNormalizationType</summary>
		public const int NormalizationType = 0x00E4;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x00E5;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ScoreClampMin = 0x00E8;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ScoreClampMax = 0x0118;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ScoringFactor = 0x0148;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ReferenceValue = 0x0178;

		///<summary>bool</summary>
		public const int bDefineReferenceValue = 0x01A8;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData04 = 0x01A9;

		///<summary>unsigned char:1</summary>
		public const int bWorkOnFloatValues = 0x01B8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData05 = 0x01B9;

	}

	public class UEnvQueryTest_Distance
	{
		///<summary>TEnumAsByte&lt;EEnvTestDistance&gt;</summary>
		public const int TestMode = 0x01C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01C1;

		///<summary>UClass *</summary>
		public const int DistanceTo = 0x01C8;

	}

	public class UEnvQueryTest_Dot
	{
		///<summary>FEnvDirection</summary>
		public const int LineA = 0x01C0;

		///<summary>FEnvDirection</summary>
		public const int LineB = 0x01E0;

		///<summary>EEnvTestDot</summary>
		public const int TestMode = 0x0200;

		///<summary>bool</summary>
		public const int bAbsoluteValue = 0x0201;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x0202;

	}

	public class UEnvQueryTest_GameplayTags
	{
		///<summary>FGameplayTagQuery</summary>
		public const int TagQueryToMatch = 0x01C0;

		///<summary>bool</summary>
		public const int bUpdatedToUseQuery = 0x0208;

		///<summary>EGameplayContainerMatchType</summary>
		public const int TagsToMatch = 0x0209;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x020A;

		///<summary>FGameplayTagContainer</summary>
		public const int GameplayTags = 0x0210;

	}

	public class UEnvQueryTest_Overlap
	{
		///<summary>FEnvOverlapData</summary>
		public const int OverlapData = 0x01C0;

	}

	public class UEnvQueryTest_Pathfinding
	{
		///<summary>TEnumAsByte&lt;EEnvTestPathfinding&gt;</summary>
		public const int TestMode = 0x01C0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01C1;

		///<summary>UClass *</summary>
		public const int Context = 0x01C8;

		///<summary>FAIDataProviderBoolValue</summary>
		public const int PathFromContext = 0x01D0;

		///<summary>FAIDataProviderBoolValue</summary>
		public const int SkipUnreachable = 0x0200;

		///<summary>UClass *</summary>
		public const int FilterClass = 0x0230;

	}

	public class UEnvQueryTest_PathfindingBatch
	{
		///<summary>FAIDataProviderFloatValue</summary>
		public const int ScanRangeMultiplier = 0x0238;

	}

	public class UEnvQueryTest_Project
	{
		///<summary>FEnvTraceData</summary>
		public const int ProjectionData = 0x01C0;

	}

	public class UEnvQueryTest_Trace
	{
		///<summary>FEnvTraceData</summary>
		public const int TraceData = 0x01C0;

		///<summary>FAIDataProviderBoolValue</summary>
		public const int TraceFromContext = 0x01F0;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ItemHeightOffset = 0x0220;

		///<summary>FAIDataProviderFloatValue</summary>
		public const int ContextHeightOffset = 0x0250;

		///<summary>UClass *</summary>
		public const int Context = 0x0280;

	}

	public class UEnvQueryOption
	{
		///<summary>UEnvQueryGenerator *</summary>
		public const int Generator = 0x0028;

		///<summary>TArray&lt;UEnvQueryTest * &gt;</summary>
		public const int Tests = 0x0030;

	}

	public class UEQSRenderingComponent
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0850;

	}

	public class AEQSTestingPawn
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x07E0;

		///<summary>UEnvQuery *</summary>
		public const int QueryTemplate = 0x07E8;

		///<summary>TArray&lt;FEnvNamedValue&gt;</summary>
		public const int QueryParams = 0x07F0;

		///<summary>TArray&lt;FAIDynamicParam&gt;</summary>
		public const int QueryConfig = 0x0800;

		///<summary>float</summary>
		public const int TimeLimitPerStep = 0x0810;

		///<summary>int</summary>
		public const int StepToDebugDraw = 0x0814;

		///<summary>EEnvQueryHightlightMode</summary>
		public const int HighlightMode = 0x0818;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0819;

		///<summary>unsigned char:1</summary>
		public const int bDrawLabels = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bDrawFailedItems = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bReRunQueryOnlyOnFinishedMove = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bShouldBeVisibleInGame = 0x081C;

		///<summary>unsigned char:1</summary>
		public const int bTickDuringGame = 0x081C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x081D;

		///<summary>TEnumAsByte&lt;EEnvQueryRunMode&gt;</summary>
		public const int QueryingMode = 0x0820;

		///<summary>unsigned char[0x2F]</summary>
		public const int UnknownData03 = 0x0821;

	}

	public class UNavLocalGridManager
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCrowdFollowingComponent
	{
		///<summary>FVector</summary>
		public const int CrowdAgentMoveDirection = 0x0490;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x049C;

		///<summary>UCharacterMovementComponent *</summary>
		public const int CharacterMovement = 0x04A0;

		///<summary>FNavAvoidanceMask</summary>
		public const int AvoidanceGroup = 0x04A8;

		///<summary>FNavAvoidanceMask</summary>
		public const int GroupsToAvoid = 0x04AC;

		///<summary>FNavAvoidanceMask</summary>
		public const int GroupsToIgnore = 0x04B0;

		///<summary>unsigned char[0x2C]</summary>
		public const int UnknownData01 = 0x04B4;

	}

	public class UGridPathFollowingComponent
	{
		///<summary>unsigned char[0x30]</summary>
		public const int UnknownData00 = 0x0490;

	}

	public class UPawnAction
	{
		///<summary>UPawnAction *</summary>
		public const int ChildAction = 0x0028;

		///<summary>UPawnAction *</summary>
		public const int ParentAction = 0x0030;

		///<summary>UPawnActionsComponent *</summary>
		public const int OwnerComponent = 0x0038;

		///<summary>UObject *</summary>
		public const int Instigator = 0x0040;

		///<summary>UBrainComponent *</summary>
		public const int BrainComp = 0x0048;

		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData00 = 0x0050;

		///<summary>unsigned char:1</summary>
		public const int bAllowNewSameClassInstance = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int bReplaceActiveSameClassInstance = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int bShouldPauseMovement = 0x00B8;

		///<summary>unsigned char:1</summary>
		public const int bAlwaysNotifyOnFinished = 0x00B8;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x00B9;

	}

	public class UPawnAction_Move
	{
		///<summary>AActor *</summary>
		public const int GoalActor = 0x00D0;

		///<summary>FVector</summary>
		public const int GoalLocation = 0x00D8;

		///<summary>float</summary>
		public const int AcceptableRadius = 0x00E4;

		///<summary>UClass *</summary>
		public const int FilterClass = 0x00E8;

		///<summary>unsigned char:1</summary>
		public const int bAllowStrafe = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bFinishOnOverlap = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bUsePathfinding = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bAllowPartialPath = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bProjectGoalToNavigation = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bUpdatePathToGoal = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bAbortChildActionOnPathChange = 0x00F0;

		///<summary>unsigned char[0x2F]</summary>
		public const int UnknownData00 = 0x00F1;

	}

	public class UPawnAction_Repeat
	{
		///<summary>UPawnAction *</summary>
		public const int ActionToRepeat = 0x00D0;

		///<summary>UPawnAction *</summary>
		public const int RecentActionCopy = 0x00D8;

		///<summary>TEnumAsByte&lt;EPawnActionFailHandling&gt;</summary>
		public const int ChildFailureHandlingMode = 0x00E0;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x00E1;

	}

	public class UPawnAction_Sequence
	{
		///<summary>TArray&lt;UPawnAction * &gt;</summary>
		public const int ActionSequence = 0x00D0;

		///<summary>TEnumAsByte&lt;EPawnActionFailHandling&gt;</summary>
		public const int ChildFailureHandlingMode = 0x00E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00E1;

		///<summary>UPawnAction *</summary>
		public const int RecentActionCopy = 0x00E8;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x00F0;

	}

	public class UPawnAction_Wait
	{
		///<summary>float</summary>
		public const int TimeToWait = 0x00D0;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData00 = 0x00D4;

	}

	public class UPawnActionsComponent
	{
		///<summary>TArray&lt;FPawnActionStack&gt;</summary>
		public const int ActionStacks = 0x01E0;

		///<summary>TArray&lt;FPawnActionEvent&gt;</summary>
		public const int ActionEvents = 0x01F0;

		///<summary>UPawnAction *</summary>
		public const int CurrentAction = 0x0200;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0208;

	}

	public class UPawnSensingComponent
	{
		///<summary>float</summary>
		public const int SightRadius = 0x01E0;

		///<summary>float</summary>
		public const int SensingInterval = 0x01E4;

		///<summary>float</summary>
		public const int HearingMaxSoundAge = 0x01E8;

		///<summary>unsigned char:1</summary>
		public const int bEnableSensingUpdates = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bOnlySensePlayers = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bSeePawns = 0x01EC;

		///<summary>unsigned char:1</summary>
		public const int bHearNoises = 0x01EC;

		///<summary>unsigned char[0xB]</summary>
		public const int UnknownData00 = 0x01ED;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSeePawn = 0x01F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHearNoise = 0x0208;

		///<summary>float</summary>
		public const int PeripheralVisionAngle = 0x0218;

		///<summary>float</summary>
		public const int PeripheralVisionCosine = 0x021C;

	}

}
