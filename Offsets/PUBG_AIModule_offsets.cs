/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBTNode
	{
		public const int UnknownData00 = 0x0028;
		public const int NodeName = 0x0030;
		public const int TreeAsset = 0x0040;
		public const int ParentNode = 0x0048;
		public const int UnknownData01 = 0x0050;
	}

	public class UBTAuxiliaryNode
	{
		public const int UnknownData00 = 0x0058;
	}

	public class UBTDecorator
	{
		public const int UnknownData00 = 0x0060;
		public const int bInverseCondition = 0x0060;
		public const int UnknownData01 = 0x0061;
		public const int FlowAbortMode = 0x0064;
		public const int UnknownData02 = 0x0065;
	}

	public class UBTTaskNode
	{
		public const int Services = 0x0058;
		public const int bIgnoreRestartSelf = 0x0068;
		public const int UnknownData00 = 0x0069;
	}

	public class UBTTask_BlackboardBase
	{
		public const int BlackboardKey = 0x0070;
	}

	public class AAIController
	{
		public const int UnknownData00 = 0x0408;
		public const int bStopAILogicOnUnposses = 0x0440;
		public const int bLOSflag = 0x0440;
		public const int bSkipExtraLOSChecks = 0x0440;
		public const int bAllowStrafe = 0x0440;
		public const int bWantsPlayerState = 0x0440;
		public const int bSetControlRotationFromPawnOrientation = 0x0440;
		public const int UnknownData01 = 0x0441;
		public const int PathFollowingComponent = 0x0448;
		public const int BrainComponent = 0x0450;
		public const int PerceptionComponent = 0x0458;
		public const int ActionsComp = 0x0460;
		public const int Blackboard = 0x0468;
		public const int CachedGameplayTasksComponent = 0x0470;
		public const int DefaultNavigationFilterClass = 0x0478;
		public const int ReceiveMoveCompleted = 0x0480;
		public const int UnknownData02 = 0x0490;
	}

	public class UPathFollowingComponent
	{
		public const int UnknownData00 = 0x00F8;
		public const int MovementComp = 0x0220;
		public const int UnknownData01 = 0x0228;
		public const int MyNavData = 0x0230;
		public const int UnknownData02 = 0x0238;
	}

	public class UAIAsyncTaskBlueprintProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFail = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UPawnActionsComponent
	{
		public const int ControlledPawn = 0x00F8;
		public const int ActionStacks = 0x0100;
		public const int ActionEvents = 0x0110;
		public const int CurrentAction = 0x0120;
		public const int UnknownData00 = 0x0128;
	}

	public class UAIDataProvider_QueryParams
	{
		public const int ParamName = 0x0028;
		public const int FloatValue = 0x0030;
		public const int IntValue = 0x0034;
		public const int BoolValue = 0x0038;
		public const int UnknownData00 = 0x0039;
	}

	public class UAISystem
	{
		public const int PerceptionSystemClassName = 0x0048;
		public const int HotSpotManagerClassName = 0x0058;
		public const int AcceptanceRadius = 0x0068;
		public const int PathfollowingRegularPathPointAcceptanceRadius = 0x006C;
		public const int PathfollowingNavLinkAcceptanceRadius = 0x0070;
		public const int bFinishMoveOnGoalOverlap = 0x0074;
		public const int bAcceptPartialPaths = 0x0075;
		public const int bAllowStrafing = 0x0076;
		public const int bEnableBTAITasks = 0x0077;
		public const int bAllowControllersAsEQSQuerier = 0x0078;
		public const int bEnableDebuggerPlugin = 0x0079;
		public const int DefaultSightCollisionChannel = 0x007A;
		public const int UnknownData00 = 0x007B;
		public const int BehaviorTreeManager = 0x0080;
		public const int EnvironmentQueryManager = 0x0088;
		public const int PerceptionSystem = 0x0090;
		public const int AllProxyObjects = 0x0098;
		public const int HotSpotManager = 0x00A8;
		public const int UnknownData01 = 0x00B0;
	}

	public class UAISense
	{
		public const int DefaultExpirationAge = 0x0028;
		public const int NotifyType = 0x002C;
		public const int UnknownData00 = 0x002D;
		public const int bWantsNewPawnNotification = 0x0030;
		public const int bAutoRegisterAllPawnsAsSources = 0x0030;
		public const int UnknownData01 = 0x0031;
		public const int PerceptionSystemInstance = 0x0038;
		public const int UnknownData02 = 0x0040;
	}

	public class UAIPerceptionSystem
	{
		public const int UnknownData00 = 0x0028;
		public const int Senses = 0x0080;
		public const int PerceptionAgingRate = 0x0090;
		public const int UnknownData01 = 0x0094;
	}

	public class UAIPerceptionComponent
	{
		public const int SensesConfig = 0x00F8;
		public const int DominantSense = 0x0108;
		public const int UnknownData00 = 0x0110;
		public const int AIOwner = 0x0120;
		public const int UnknownData01 = 0x0128;
		public const int OnPerceptionUpdated = 0x01A8;
		public const int OnTargetPerceptionUpdated = 0x01B8;
		public const int UnknownData02 = 0x01C8;
	}

	public class UAIPerceptionStimuliSourceComponent
	{
		public const int bAutoRegisterAsSource = 0x00F8;
		public const int UnknownData00 = 0x00F9;
		public const int RegisterAsSourceForSenses = 0x0100;
	}

	public class UAISense_Blueprint
	{
		public const int ListenerDataType = 0x0120;
		public const int ListenerContainer = 0x0128;
		public const int UnprocessedEvents = 0x0138;
		public const int UnknownData00 = 0x0148;
	}

	public class UAISense_Damage
	{
		public const int RegisteredEvents = 0x0120;
	}

	public class UAISense_Hearing
	{
		public const int NoiseEvents = 0x0120;
		public const int SpeedOfSoundSq = 0x0130;
		public const int UnknownData00 = 0x0134;
	}

	public class UAISense_Prediction
	{
		public const int RegisteredEvents = 0x0120;
	}

	public class UAISense_Sight
	{
		public const int UnknownData00 = 0x0120;
		public const int MaxTracesPerTick = 0x01D0;
		public const int MinQueriesPerTimeSliceCheck = 0x01D4;
		public const int MaxTimeSlicePerTick = 0x01D8;
		public const int HighImportanceQueryDistanceThreshold = 0x01E0;
		public const int UnknownData01 = 0x01E4;
		public const int MaxQueryImportance = 0x01E8;
		public const int SightLimitQueryImportance = 0x01EC;
		public const int UnknownData02 = 0x01F0;
	}

	public class UAISense_Team
	{
		public const int RegisteredEvents = 0x0120;
	}

	public class UAISense_Touch
	{
		public const int RegisteredEvents = 0x0120;
	}

	public class UAISenseConfig
	{
		public const int DebugColor = 0x0028;
		public const int MaxAge = 0x002C;
		public const int bStartsEnabled = 0x0030;
		public const int UnknownData00 = 0x0031;
	}

	public class UAISenseConfig_Blueprint
	{
		public const int Implementation = 0x0048;
	}

	public class UAISenseConfig_Damage
	{
		public const int Implementation = 0x0048;
	}

	public class UAISenseConfig_Hearing
	{
		public const int Implementation = 0x0048;
		public const int HearingRange = 0x0050;
		public const int LoSHearingRange = 0x0054;
		public const int bUseLoSHearing = 0x0058;
		public const int UnknownData00 = 0x0059;
		public const int DetectionByAffiliation = 0x005C;
	}

	public class UAISenseConfig_Sight
	{
		public const int Implementation = 0x0048;
		public const int SightRadius = 0x0050;
		public const int LoseSightRadius = 0x0054;
		public const int PeripheralVisionAngleDegrees = 0x0058;
		public const int DetectionByAffiliation = 0x005C;
		public const int AutoSuccessRangeFromLastSeenLocation = 0x0060;
		public const int UnknownData00 = 0x0064;
	}

	public class UAISenseEvent_Damage
	{
		public const int Event = 0x0028;
	}

	public class UAISenseEvent_Hearing
	{
		public const int Event = 0x0028;
	}

	public class UAITask
	{
		public const int OwnerController = 0x0068;
	}

	public class UAITask_MoveTo
	{
		public const int OnRequestFailed = 0x0070;
		public const int OnMoveFinished = 0x0080;
		public const int MoveRequest = 0x0090;
		public const int UnknownData00 = 0x00D0;
	}

	public class UBrainComponent
	{
		public const int UnknownData00 = 0x00F8;
		public const int BlackboardComp = 0x0100;
		public const int AIOwner = 0x0108;
		public const int UnknownData01 = 0x0110;
	}

	public class UBehaviorTreeComponent
	{
		public const int UnknownData00 = 0x0158;
		public const int NodeInstances = 0x0178;
		public const int UnknownData01 = 0x0188;
	}

	public class UBTCompositeNode
	{
		public const int Children = 0x0058;
		public const int Services = 0x0068;
		public const int UnknownData00 = 0x0078;
	}

	public class UBehaviorTree
	{
		public const int RootNode = 0x0028;
		public const int BlackboardAsset = 0x0030;
		public const int RootDecorators = 0x0038;
		public const int RootDecoratorOps = 0x0048;
		public const int UnknownData00 = 0x0058;
	}

	public class UBehaviorTreeManager
	{
		public const int MaxDebuggerSteps = 0x0028;
		public const int UnknownData00 = 0x002C;
		public const int LoadedTemplates = 0x0030;
		public const int ActiveComponents = 0x0040;
	}

	public class UBlackboardKeyType
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UBlackboardKeyType_Enum
	{
		public const int EnumType = 0x0030;
		public const int EnumName = 0x0038;
		public const int bIsEnumNameValid = 0x0048;
		public const int UnknownData00 = 0x0049;
	}

	public class UBlackboardKeyType_NativeEnum
	{
		public const int EnumName = 0x0030;
		public const int EnumType = 0x0040;
	}

	public class UBlackboardData
	{
		public const int Parent = 0x0028;
		public const int Keys = 0x0030;
		public const int bHasSynchronizedKeys = 0x0040;
		public const int UnknownData00 = 0x0041;
	}

	public class UBlackboardComponent
	{
		public const int BrainComp = 0x00F8;
		public const int BlackboardAsset = 0x0100;
		public const int UnknownData00 = 0x0108;
		public const int KeyInstances = 0x0128;
		public const int UnknownData01 = 0x0138;
	}

	public class UBlackboardKeyType_Class
	{
		public const int BaseClass = 0x0030;
	}

	public class UBlackboardKeyType_Object
	{
		public const int BaseClass = 0x0030;
	}

	public class UBlackboardKeyType_String
	{
		public const int StringValue = 0x0030;
	}

	public class UBTDecorator_BlackboardBase
	{
		public const int BlackboardKey = 0x0068;
	}

	public class UBTDecorator_Blackboard
	{
		public const int IntValue = 0x0090;
		public const int FloatValue = 0x0094;
		public const int StringValue = 0x0098;
		public const int CachedDescription = 0x00A8;
		public const int OperationType = 0x00B8;
		public const int NotifyObserver = 0x00B9;
		public const int UnknownData00 = 0x00BA;
	}

	public class UBTDecorator_IsAtLocation
	{
		public const int AcceptableRadius = 0x0090;
		public const int UnknownData00 = 0x0094;
		public const int ParametrizedAcceptableRadius = 0x0098;
		public const int bUseParametrizedRadius = 0x00C8;
		public const int bUseNavAgentGoalLocation = 0x00C8;
		public const int UnknownData01 = 0x00C9;
	}

	public class UBTDecorator_IsBBEntryOfClass
	{
		public const int TestClass = 0x0090;
	}

	public class UBTDecorator_BlueprintBase
	{
		public const int AIOwner = 0x0068;
		public const int ActorOwner = 0x0070;
		public const int ObservedKeyNames = 0x0078;
		public const int UnknownData00 = 0x0088;
		public const int bShowPropertyDetails = 0x0098;
		public const int bCheckConditionOnlyBlackBoardChanges = 0x0098;
		public const int bIsObservingBB = 0x0098;
		public const int UnknownData01 = 0x0099;
	}

	public class UBTDecorator_CheckGameplayTagsOnActor
	{
		public const int ActorToCheck = 0x0068;
		public const int TagsToMatch = 0x0090;
		public const int UnknownData00 = 0x0091;
		public const int GameplayTags = 0x0098;
		public const int CachedDescription = 0x00B8;
	}

	public class UBTDecorator_CompareBBEntries
	{
		public const int Operator = 0x0068;
		public const int UnknownData00 = 0x0069;
		public const int BlackboardKeyA = 0x0070;
		public const int BlackboardKeyB = 0x0098;
	}

	public class UBTDecorator_ConeCheck
	{
		public const int ConeHalfAngle = 0x0068;
		public const int UnknownData00 = 0x006C;
		public const int ConeOrigin = 0x0070;
		public const int ConeDirection = 0x0098;
		public const int Observed = 0x00C0;
		public const int UnknownData01 = 0x00E8;
	}

	public class UBTDecorator_Cooldown
	{
		public const int CoolDownTime = 0x0068;
		public const int UnknownData00 = 0x006C;
	}

	public class UBTDecorator_DoesPathExist
	{
		public const int BlackboardKeyA = 0x0068;
		public const int BlackboardKeyB = 0x0090;
		public const int bUseSelf = 0x00B8;
		public const int UnknownData00 = 0x00B9;
		public const int PathQueryType = 0x00BC;
		public const int UnknownData01 = 0x00BD;
		public const int FilterClass = 0x00C0;
	}

	public class UBTDecorator_KeepInCone
	{
		public const int ConeHalfAngle = 0x0068;
		public const int UnknownData00 = 0x006C;
		public const int ConeOrigin = 0x0070;
		public const int Observed = 0x0098;
		public const int bUseSelfAsOrigin = 0x00C0;
		public const int bUseSelfAsObserved = 0x00C0;
		public const int UnknownData01 = 0x00C1;
	}

	public class UBTDecorator_Loop
	{
		public const int NumLoops = 0x0068;
		public const int bInfiniteLoop = 0x006C;
		public const int UnknownData00 = 0x006D;
		public const int InfiniteLoopTimeoutTime = 0x0070;
		public const int UnknownData01 = 0x0074;
	}

	public class UBTDecorator_SetTagCooldown
	{
		public const int CooldownTag = 0x0068;
		public const int CooldownDuration = 0x0070;
		public const int bAddToExistingDuration = 0x0074;
		public const int UnknownData00 = 0x0075;
	}

	public class UBTDecorator_TagCooldown
	{
		public const int CooldownTag = 0x0068;
		public const int CooldownDuration = 0x0070;
		public const int bAddToExistingDuration = 0x0074;
		public const int bActivatesCooldown = 0x0075;
		public const int UnknownData00 = 0x0076;
	}

	public class UBTDecorator_TimeLimit
	{
		public const int TimeLimit = 0x0068;
		public const int UnknownData00 = 0x006C;
	}

	public class UBTService
	{
		public const int Interval = 0x0060;
		public const int RandomDeviation = 0x0064;
		public const int bCallTickOnSearchStart = 0x0068;
		public const int bRestartTimerOnEachActivation = 0x0068;
		public const int UnknownData00 = 0x0069;
	}

	public class UBTService_BlackboardBase
	{
		public const int BlackboardKey = 0x0070;
	}

	public class UBTService_DefaultFocus
	{
		public const int FocusPriority = 0x0098;
		public const int UnknownData00 = 0x0099;
	}

	public class UEnvQueryItemType
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UBTService_RunEQS
	{
		public const int EQSRequest = 0x0098;
		public const int UnknownData00 = 0x00E0;
	}

	public class UBTService_BlueprintBase
	{
		public const int AIOwner = 0x0070;
		public const int ActorOwner = 0x0078;
		public const int UnknownData00 = 0x0080;
		public const int bShowPropertyDetails = 0x0090;
		public const int bShowEventDetails = 0x0090;
		public const int UnknownData01 = 0x0091;
	}

	public class UBTTask_MoveTo
	{
		public const int AcceptableRadius = 0x0098;
		public const int UnknownData00 = 0x009C;
		public const int FilterClass = 0x00A0;
		public const int ObservedBlackboardValueTolerance = 0x00A8;
		public const int bObserveBlackboardValue = 0x00AC;
		public const int bAllowStrafe = 0x00AC;
		public const int bAllowPartialPath = 0x00AC;
		public const int bTrackMovingGoal = 0x00AC;
		public const int bProjectGoalLocation = 0x00AC;
		public const int bStopOnOverlap = 0x00AC;
		public const int UnknownData01 = 0x00AD;
	}

	public class UBTTask_MoveDirectlyToward
	{
		public const int bDisablePathUpdateOnGoalLocationChange = 0x00B0;
		public const int bProjectVectorGoalToNavigation = 0x00B0;
		public const int bUpdatedDeprecatedProperties = 0x00B0;
		public const int UnknownData00 = 0x00B1;
	}

	public class UBTTask_RotateToFaceBBEntry
	{
		public const int Precision = 0x0098;
		public const int UnknownData00 = 0x009C;
	}

	public class UBTTask_RunEQSQuery
	{
		public const int QueryTemplate = 0x0098;
		public const int QueryParams = 0x00A0;
		public const int QueryConfig = 0x00B0;
		public const int RunMode = 0x00C0;
		public const int UnknownData00 = 0x00C1;
		public const int EQSQueryBlackboardKey = 0x00C8;
		public const int bUseBBKey = 0x00F0;
		public const int UnknownData01 = 0x00F1;
		public const int EQSRequest = 0x00F8;
		public const int UnknownData02 = 0x0140;
	}

	public class UBTTask_BlueprintBase
	{
		public const int AIOwner = 0x0070;
		public const int ActorOwner = 0x0078;
		public const int UnknownData00 = 0x0080;
		public const int bShowPropertyDetails = 0x0098;
		public const int UnknownData01 = 0x0099;
	}

	public class UBTTask_GameplayTaskBase
	{
		public const int bWaitForGameplayTask = 0x0070;
		public const int UnknownData00 = 0x0071;
	}

	public class UBTTask_MakeNoise
	{
		public const int Loudnes = 0x0070;
		public const int UnknownData00 = 0x0074;
	}

	public class UPawnAction
	{
		public const int ChildAction = 0x0028;
		public const int ParentAction = 0x0030;
		public const int OwnerComponent = 0x0038;
		public const int Instigator = 0x0040;
		public const int BrainComp = 0x0048;
		public const int UnknownData00 = 0x0050;
		public const int bAllowNewSameClassInstance = 0x00B8;
		public const int bReplaceActiveSameClassInstance = 0x00B8;
		public const int bShouldPauseMovement = 0x00B8;
		public const int bAlwaysNotifyOnFinished = 0x00B8;
		public const int UnknownData01 = 0x00B9;
	}

	public class UBTTask_PushPawnAction
	{
		public const int Action = 0x0070;
	}

	public class UBTTask_PlayAnimation
	{
		public const int AnimationToPlay = 0x0070;
		public const int bLooping = 0x0078;
		public const int bNonBlocking = 0x0078;
		public const int UnknownData00 = 0x0079;
		public const int MyOwnerComp = 0x0080;
		public const int CachedSkelMesh = 0x0088;
		public const int UnknownData01 = 0x0090;
	}

	public class UBTTask_PlaySound
	{
		public const int SoundToPlay = 0x0070;
	}

	public class UBTTask_RunBehavior
	{
		public const int BehaviorAsset = 0x0070;
	}

	public class UBTTask_RunBehaviorDynamic
	{
		public const int InjectionTag = 0x0070;
		public const int DefaultBehaviorAsset = 0x0078;
		public const int BehaviorAsset = 0x0080;
	}

	public class UBTTask_SetTagCooldown
	{
		public const int CooldownTag = 0x0070;
		public const int bAddToExistingDuration = 0x0078;
		public const int UnknownData00 = 0x0079;
		public const int CooldownDuration = 0x007C;
	}

	public class UBTTask_Wait
	{
		public const int WaitTime = 0x0070;
		public const int RandomDeviation = 0x0074;
	}

	public class UBTTask_WaitBlackboardTime
	{
		public const int BlackboardKey = 0x0078;
	}

	public class UCrowdManager
	{
		public const int MyNavData = 0x0028;
		public const int AvoidanceConfig = 0x0030;
		public const int SamplingPatterns = 0x0040;
		public const int MaxAgents = 0x0050;
		public const int MaxAgentRadius = 0x0054;
		public const int MaxAvoidedAgents = 0x0058;
		public const int MaxAvoidedWalls = 0x005C;
		public const int NavmeshCheckInterval = 0x0060;
		public const int PathOptimizationInterval = 0x0064;
		public const int UnknownData00 = 0x0068;
		public const int bResolveCollisions = 0x0068;
		public const int UnknownData01 = 0x0069;
	}

	public class UEnvQuery
	{
		public const int QueryName = 0x0028;
		public const int Options = 0x0030;
	}

	public class UEnvQueryContext_BlueprintBase
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UEnvQueryInstanceBlueprintWrapper
	{
		public const int UnknownData00 = 0x0028;
		public const int QueryID = 0x0030;
		public const int UnknownData01 = 0x0034;
		public const int ItemType = 0x0058;
		public const int OptionIndex = 0x0060;
		public const int UnknownData02 = 0x0064;
		public const int OnQueryFinishedEvent = 0x0068;
	}

	public class UEnvQueryManager
	{
		public const int UnknownData00 = 0x0028;
		public const int InstanceCache = 0x0098;
		public const int LocalContexts = 0x00A8;
		public const int GCShieldedWrappers = 0x00B8;
		public const int UnknownData01 = 0x00C8;
		public const int MaxAllowedTestingTime = 0x0120;
		public const int bTestQueriesUsingBreadth = 0x0128;
		public const int UnknownData02 = 0x0129;
		public const int QueryCountWarningThreshold = 0x012C;
		public const int QueryCountWarningInterval = 0x0130;
	}

	public class UEnvQueryNode
	{
		public const int VerNum = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

	public class UEnvQueryGenerator
	{
		public const int OptionName = 0x0030;
		public const int ItemType = 0x0040;
		public const int bAutoSortTests = 0x0048;
		public const int UnknownData00 = 0x0049;
	}

	public class UEnvQueryGenerator_ActorsOfClass
	{
		public const int SearchRadius = 0x0050;
		public const int SearchedActorClass = 0x0080;
		public const int SearchCenter = 0x0088;
	}

	public class UEnvQueryGenerator_BlueprintBase
	{
		public const int GeneratorsActionDescription = 0x0050;
		public const int Context = 0x0068;
		public const int GeneratedItemType = 0x0070;
		public const int UnknownData00 = 0x0078;
	}

	public class UEnvQueryGenerator_Composite
	{
		public const int Generators = 0x0050;
		public const int bHasMatchingItemType = 0x0060;
		public const int UnknownData00 = 0x0061;
	}

	public class UEnvQueryGenerator_CurrentLocation
	{
		public const int QueryContext = 0x0050;
	}

	public class UEnvQueryGenerator_ProjectedPoints
	{
		public const int ProjectionData = 0x0050;
	}

	public class UEnvQueryGenerator_Donut
	{
		public const int InnerRadius = 0x0080;
		public const int OuterRadius = 0x00B0;
		public const int NumberOfRings = 0x00E0;
		public const int PointsPerRing = 0x0110;
		public const int ArcDirection = 0x0140;
		public const int ArcAngle = 0x0160;
		public const int bUseSpiralPattern = 0x0190;
		public const int UnknownData00 = 0x0191;
		public const int Center = 0x0198;
		public const int bDefineArc = 0x01A0;
		public const int UnknownData01 = 0x01A1;
	}

	public class UEnvQueryGenerator_OnCircle
	{
		public const int CircleRadius = 0x0080;
		public const int SpaceBetween = 0x00B0;
		public const int NumberOfPoints = 0x00E0;
		public const int PointOnCircleSpacingMethod = 0x0110;
		public const int UnknownData00 = 0x0111;
		public const int ArcDirection = 0x0118;
		public const int ArcAngle = 0x0138;
		public const int AngleRadians = 0x0168;
		public const int UnknownData01 = 0x016C;
		public const int CircleCenter = 0x0170;
		public const int bIgnoreAnyContextActorsWhenGeneratingCircle = 0x0178;
		public const int UnknownData02 = 0x0179;
		public const int CircleCenterZOffset = 0x0180;
		public const int TraceData = 0x01B0;
		public const int bDefineArc = 0x01E0;
		public const int UnknownData03 = 0x01E1;
	}

	public class UEnvQueryGenerator_SimpleGrid
	{
		public const int GridSize = 0x0080;
		public const int SpaceBetween = 0x00B0;
		public const int GenerateAround = 0x00E0;
	}

	public class UEnvQueryGenerator_PathingGrid
	{
		public const int PathToItem = 0x00E8;
		public const int NavigationFilter = 0x0118;
		public const int ScanRangeMultiplier = 0x0120;
	}

	public class UEnvQueryTest
	{
		public const int TestOrder = 0x0030;
		public const int TestPurpose = 0x0034;
		public const int UnknownData00 = 0x0035;
		public const int TestComment = 0x0038;
		public const int MultipleContextFilterOp = 0x0048;
		public const int MultipleContextScoreOp = 0x0049;
		public const int FilterType = 0x004A;
		public const int UnknownData01 = 0x004B;
		public const int BoolValue = 0x0050;
		public const int FloatValueMin = 0x0080;
		public const int FloatValueMax = 0x00B0;
		public const int UnknownData02 = 0x00E0;
		public const int ScoringEquation = 0x00E1;
		public const int ClampMinType = 0x00E2;
		public const int ClampMaxType = 0x00E3;
		public const int UnknownData03 = 0x00E4;
		public const int ScoreClampMin = 0x00E8;
		public const int ScoreClampMax = 0x0118;
		public const int ScoringFactor = 0x0148;
		public const int ReferenceValue = 0x0178;
		public const int bDefineReferenceValue = 0x01A8;
		public const int UnknownData04 = 0x01A9;
		public const int bWorkOnFloatValues = 0x01B8;
		public const int UnknownData05 = 0x01B9;
	}

	public class UEnvQueryTest_Distance
	{
		public const int TestMode = 0x01C0;
		public const int UnknownData00 = 0x01C1;
		public const int DistanceTo = 0x01C8;
	}

	public class UEnvQueryTest_Dot
	{
		public const int LineA = 0x01C0;
		public const int LineB = 0x01E0;
		public const int TestMode = 0x0200;
		public const int bAbsoluteValue = 0x0201;
		public const int UnknownData00 = 0x0202;
	}

	public class UEnvQueryTest_GameplayTags
	{
		public const int TagsToMatch = 0x01C0;
		public const int UnknownData00 = 0x01C1;
		public const int GameplayTags = 0x01C8;
	}

	public class UEnvQueryTest_Overlap
	{
		public const int OverlapData = 0x01C0;
	}

	public class UEnvQueryTest_Pathfinding
	{
		public const int TestMode = 0x01C0;
		public const int UnknownData00 = 0x01C1;
		public const int Context = 0x01C8;
		public const int PathFromContext = 0x01D0;
		public const int SkipUnreachable = 0x0200;
		public const int FilterClass = 0x0230;
	}

	public class UEnvQueryTest_PathfindingBatch
	{
		public const int ScanRangeMultiplier = 0x0238;
	}

	public class UEnvQueryTest_Project
	{
		public const int ProjectionData = 0x01C0;
	}

	public class UEnvQueryTest_Trace
	{
		public const int TraceData = 0x01C0;
		public const int TraceFromContext = 0x01F0;
		public const int ItemHeightOffset = 0x0220;
		public const int ContextHeightOffset = 0x0250;
		public const int Context = 0x0280;
	}

	public class UEnvQueryOption
	{
		public const int Generator = 0x0028;
		public const int Tests = 0x0030;
	}

	public class UEQSRenderingComponent
	{
		public const int UnknownData00 = 0x06D0;
	}

	public class AEQSTestingPawn
	{
		public const int UnknownData00 = 0x07C0;
		public const int QueryTemplate = 0x07C8;
		public const int QueryParams = 0x07D0;
		public const int QueryConfig = 0x07E0;
		public const int TimeLimitPerStep = 0x07F0;
		public const int StepToDebugDraw = 0x07F4;
		public const int HighlightMode = 0x07F8;
		public const int UnknownData01 = 0x07F9;
		public const int bDrawLabels = 0x07FC;
		public const int bDrawFailedItems = 0x07FC;
		public const int bReRunQueryOnlyOnFinishedMove = 0x07FC;
		public const int bShouldBeVisibleInGame = 0x07FC;
		public const int bTickDuringGame = 0x07FC;
		public const int UnknownData02 = 0x07FD;
		public const int QueryingMode = 0x0800;
		public const int UnknownData03 = 0x0801;
	}

	public class UCrowdFollowingComponent
	{
		public const int CrowdAgentMoveDirection = 0x03B0;
		public const int UnknownData00 = 0x03BC;
		public const int CharacterMovement = 0x03C0;
		public const int AvoidanceGroup = 0x03C8;
		public const int GroupsToAvoid = 0x03CC;
		public const int GroupsToIgnore = 0x03D0;
		public const int UnknownData01 = 0x03D4;
	}

	public class UPawnAction_Move
	{
		public const int GoalActor = 0x00D0;
		public const int GoalLocation = 0x00D8;
		public const int AcceptableRadius = 0x00E4;
		public const int FilterClass = 0x00E8;
		public const int bAllowStrafe = 0x00F0;
		public const int bFinishOnOverlap = 0x00F0;
		public const int bUsePathfinding = 0x00F0;
		public const int bAllowPartialPath = 0x00F0;
		public const int bProjectGoalToNavigation = 0x00F0;
		public const int bUpdatePathToGoal = 0x00F0;
		public const int bAbortChildActionOnPathChange = 0x00F0;
		public const int UnknownData00 = 0x00F1;
	}

	public class UPawnAction_Repeat
	{
		public const int ActionToRepeat = 0x00D0;
		public const int RecentActionCopy = 0x00D8;
		public const int ChildFailureHandlingMode = 0x00E0;
		public const int UnknownData00 = 0x00E1;
	}

	public class UPawnAction_Sequence
	{
		public const int ActionSequence = 0x00D0;
		public const int ChildFailureHandlingMode = 0x00E0;
		public const int UnknownData00 = 0x00E1;
		public const int RecentActionCopy = 0x00E8;
		public const int UnknownData01 = 0x00F0;
	}

	public class UPawnAction_Wait
	{
		public const int TimeToWait = 0x00D0;
		public const int UnknownData00 = 0x00D4;
	}

	public class UPawnSensingComponent
	{
		public const int HearingThreshold = 0x00F8;
		public const int LOSHearingThreshold = 0x00FC;
		public const int SightRadius = 0x0100;
		public const int SensingInterval = 0x0104;
		public const int HearingMaxSoundAge = 0x0108;
		public const int bEnableSensingUpdates = 0x010C;
		public const int bOnlySensePlayers = 0x010C;
		public const int bSeePawns = 0x010C;
		public const int bHearNoises = 0x010C;
		public const int UnknownData00 = 0x010D;
		public const int OnSeePawn = 0x0118;
		public const int OnHearNoise = 0x0128;
		public const int PeripheralVisionAngle = 0x0138;
		public const int PeripheralVisionCosine = 0x013C;
	}

}
