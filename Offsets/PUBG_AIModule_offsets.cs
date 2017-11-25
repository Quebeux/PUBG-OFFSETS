/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBTNode
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int NodeName = 0x0030;

		///<summary><![CDATA[UBehaviorTree *]]></summary>
		public const int TreeAsset = 0x0040;

		///<summary><![CDATA[UBTCompositeNode *]]></summary>
		public const int ParentNode = 0x0048;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0050;

	}

	public class UBTAuxiliaryNode
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0058;

	}

	public class UBTDecorator
	{
		///<summary><![CDATA[unsigned char:7]]></summary>
		public const int UnknownData00 = 0x0060;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bInverseCondition = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0061;

		///<summary><![CDATA[TEnumAsByte<EBTFlowAbortMode>]]></summary>
		public const int FlowAbortMode = 0x0064;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0065;

	}

	public class UBTTaskNode
	{
		///<summary><![CDATA[TArray<UBTService * >]]></summary>
		public const int Services = 0x0058;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreRestartSelf = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UBTTask_BlackboardBase
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKey = 0x0070;

	}

	public class AAIController
	{
		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData00 = 0x0408;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStopAILogicOnUnposses = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLOSflag = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSkipExtraLOSChecks = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowStrafe = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsPlayerState = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSetControlRotationFromPawnOrientation = 0x0440;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0441;

		///<summary><![CDATA[UPathFollowingComponent *]]></summary>
		public const int PathFollowingComponent = 0x0448;

		///<summary><![CDATA[UBrainComponent *]]></summary>
		public const int BrainComponent = 0x0450;

		///<summary><![CDATA[UAIPerceptionComponent *]]></summary>
		public const int PerceptionComponent = 0x0458;

		///<summary><![CDATA[UPawnActionsComponent *]]></summary>
		public const int ActionsComp = 0x0460;

		///<summary><![CDATA[UBlackboardComponent *]]></summary>
		public const int Blackboard = 0x0468;

		///<summary><![CDATA[UGameplayTasksComponent *]]></summary>
		public const int CachedGameplayTasksComponent = 0x0470;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultNavigationFilterClass = 0x0478;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReceiveMoveCompleted = 0x0480;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0490;

	}

	public class UPathFollowingComponent
	{
		///<summary><![CDATA[unsigned char[0x128]]]></summary>
		public const int UnknownData00 = 0x00F8;

		///<summary><![CDATA[UNavMovementComponent *]]></summary>
		public const int MovementComp = 0x0220;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0228;

		///<summary><![CDATA[ANavigationData *]]></summary>
		public const int MyNavData = 0x0230;

		///<summary><![CDATA[unsigned char[0x178]]]></summary>
		public const int UnknownData02 = 0x0238;

	}

	public class UAIAsyncTaskBlueprintProxy
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSuccess = 0x0028;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnFail = 0x0038;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UPawnActionsComponent
	{
		///<summary><![CDATA[APawn *]]></summary>
		public const int ControlledPawn = 0x00F8;

		///<summary><![CDATA[TArray<FPawnActionStack>]]></summary>
		public const int ActionStacks = 0x0100;

		///<summary><![CDATA[TArray<FPawnActionEvent>]]></summary>
		public const int ActionEvents = 0x0110;

		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int CurrentAction = 0x0120;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0128;

	}

	public class UAIDataProvider_QueryParams
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParamName = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int FloatValue = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int IntValue = 0x0034;

		///<summary><![CDATA[bool]]></summary>
		public const int BoolValue = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0039;

	}

	public class UAISystem
	{
		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int PerceptionSystemClassName = 0x0048;

		///<summary><![CDATA[FStringClassReference]]></summary>
		public const int HotSpotManagerClassName = 0x0058;

		///<summary><![CDATA[float]]></summary>
		public const int AcceptanceRadius = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int PathfollowingRegularPathPointAcceptanceRadius = 0x006C;

		///<summary><![CDATA[float]]></summary>
		public const int PathfollowingNavLinkAcceptanceRadius = 0x0070;

		///<summary><![CDATA[bool]]></summary>
		public const int bFinishMoveOnGoalOverlap = 0x0074;

		///<summary><![CDATA[bool]]></summary>
		public const int bAcceptPartialPaths = 0x0075;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowStrafing = 0x0076;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableBTAITasks = 0x0077;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowControllersAsEQSQuerier = 0x0078;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableDebuggerPlugin = 0x0079;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int DefaultSightCollisionChannel = 0x007A;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x007B;

		///<summary><![CDATA[UBehaviorTreeManager *]]></summary>
		public const int BehaviorTreeManager = 0x0080;

		///<summary><![CDATA[UEnvQueryManager *]]></summary>
		public const int EnvironmentQueryManager = 0x0088;

		///<summary><![CDATA[UAIPerceptionSystem *]]></summary>
		public const int PerceptionSystem = 0x0090;

		///<summary><![CDATA[TArray<UAIAsyncTaskBlueprintProxy * >]]></summary>
		public const int AllProxyObjects = 0x0098;

		///<summary><![CDATA[UAIHotSpotManager *]]></summary>
		public const int HotSpotManager = 0x00A8;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData01 = 0x00B0;

	}

	public class UAISense
	{
		///<summary><![CDATA[float]]></summary>
		public const int DefaultExpirationAge = 0x0028;

		///<summary><![CDATA[TEnumAsByte<EAISenseNotifyType>]]></summary>
		public const int NotifyType = 0x002C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x002D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsNewPawnNotification = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoRegisterAllPawnsAsSources = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0031;

		///<summary><![CDATA[UAIPerceptionSystem *]]></summary>
		public const int PerceptionSystemInstance = 0x0038;

		///<summary><![CDATA[unsigned char[0xE0]]]></summary>
		public const int UnknownData02 = 0x0040;

	}

	public class UAIPerceptionSystem
	{
		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<UAISense * >]]></summary>
		public const int Senses = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int PerceptionAgingRate = 0x0090;

		///<summary><![CDATA[unsigned char[0x9C]]]></summary>
		public const int UnknownData01 = 0x0094;

	}

	public class UAIPerceptionComponent
	{
		///<summary><![CDATA[TArray<UAISenseConfig * >]]></summary>
		public const int SensesConfig = 0x00F8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DominantSense = 0x0108;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0110;

		///<summary><![CDATA[AAIController *]]></summary>
		public const int AIOwner = 0x0120;

		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData01 = 0x0128;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPerceptionUpdated = 0x01A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTargetPerceptionUpdated = 0x01B8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x01C8;

	}

	public class UAIPerceptionStimuliSourceComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoRegisterAsSource = 0x00F8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00F9;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int RegisterAsSourceForSenses = 0x0100;

	}

	public class UAISense_Blueprint
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ListenerDataType = 0x0120;

		///<summary><![CDATA[TArray<UAIPerceptionComponent * >]]></summary>
		public const int ListenerContainer = 0x0128;

		///<summary><![CDATA[TArray<UAISenseEvent * >]]></summary>
		public const int UnprocessedEvents = 0x0138;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0148;

	}

	public class UAISense_Damage
	{
		///<summary><![CDATA[TArray<FAIDamageEvent>]]></summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISense_Hearing
	{
		///<summary><![CDATA[TArray<FAINoiseEvent>]]></summary>
		public const int NoiseEvents = 0x0120;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedOfSoundSq = 0x0130;

		///<summary><![CDATA[unsigned char[0x5C]]]></summary>
		public const int UnknownData00 = 0x0134;

	}

	public class UAISense_Prediction
	{
		///<summary><![CDATA[TArray<FAIPredictionEvent>]]></summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISense_Sight
	{
		///<summary><![CDATA[unsigned char[0xB0]]]></summary>
		public const int UnknownData00 = 0x0120;

		///<summary><![CDATA[int]]></summary>
		public const int MaxTracesPerTick = 0x01D0;

		///<summary><![CDATA[int]]></summary>
		public const int MinQueriesPerTimeSliceCheck = 0x01D4;

		///<summary><![CDATA[double]]></summary>
		public const int MaxTimeSlicePerTick = 0x01D8;

		///<summary><![CDATA[float]]></summary>
		public const int HighImportanceQueryDistanceThreshold = 0x01E0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01E4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxQueryImportance = 0x01E8;

		///<summary><![CDATA[float]]></summary>
		public const int SightLimitQueryImportance = 0x01EC;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x01F0;

	}

	public class UAISense_Team
	{
		///<summary><![CDATA[TArray<FAITeamStimulusEvent>]]></summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISense_Touch
	{
		///<summary><![CDATA[TArray<FAITouchEvent>]]></summary>
		public const int RegisteredEvents = 0x0120;

	}

	public class UAISenseConfig
	{
		///<summary><![CDATA[FColor]]></summary>
		public const int DebugColor = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAge = 0x002C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStartsEnabled = 0x0030;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData00 = 0x0031;

	}

	public class UAISenseConfig_Blueprint
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int Implementation = 0x0048;

	}

	public class UAISenseConfig_Damage
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int Implementation = 0x0048;

	}

	public class UAISenseConfig_Hearing
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int Implementation = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int HearingRange = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int LoSHearingRange = 0x0054;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseLoSHearing = 0x0058;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0059;

		///<summary><![CDATA[FAISenseAffiliationFilter]]></summary>
		public const int DetectionByAffiliation = 0x005C;

	}

	public class UAISenseConfig_Sight
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int Implementation = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int SightRadius = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int LoseSightRadius = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int PeripheralVisionAngleDegrees = 0x0058;

		///<summary><![CDATA[FAISenseAffiliationFilter]]></summary>
		public const int DetectionByAffiliation = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int AutoSuccessRangeFromLastSeenLocation = 0x0060;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0064;

	}

	public class UAISenseEvent_Damage
	{
		///<summary><![CDATA[FAIDamageEvent]]></summary>
		public const int Event = 0x0028;

	}

	public class UAISenseEvent_Hearing
	{
		///<summary><![CDATA[FAINoiseEvent]]></summary>
		public const int Event = 0x0028;

	}

	public class UAITask
	{
		///<summary><![CDATA[AAIController *]]></summary>
		public const int OwnerController = 0x0068;

	}

	public class UAITask_MoveTo
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnRequestFailed = 0x0070;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMoveFinished = 0x0080;

		///<summary><![CDATA[FAIMoveRequest]]></summary>
		public const int MoveRequest = 0x0090;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData00 = 0x00D0;

	}

	public class UBrainComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00F8;

		///<summary><![CDATA[UBlackboardComponent *]]></summary>
		public const int BlackboardComp = 0x0100;

		///<summary><![CDATA[AAIController *]]></summary>
		public const int AIOwner = 0x0108;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData01 = 0x0110;

	}

	public class UBehaviorTreeComponent
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0158;

		///<summary><![CDATA[TArray<UBTNode * >]]></summary>
		public const int NodeInstances = 0x0178;

		///<summary><![CDATA[unsigned char[0x108]]]></summary>
		public const int UnknownData01 = 0x0188;

	}

	public class UBTCompositeNode
	{
		///<summary><![CDATA[TArray<FBTCompositeChild>]]></summary>
		public const int Children = 0x0058;

		///<summary><![CDATA[TArray<UBTService * >]]></summary>
		public const int Services = 0x0068;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UBehaviorTree
	{
		///<summary><![CDATA[UBTCompositeNode *]]></summary>
		public const int RootNode = 0x0028;

		///<summary><![CDATA[UBlackboardData *]]></summary>
		public const int BlackboardAsset = 0x0030;

		///<summary><![CDATA[TArray<UBTDecorator * >]]></summary>
		public const int RootDecorators = 0x0038;

		///<summary><![CDATA[TArray<FBTDecoratorLogic>]]></summary>
		public const int RootDecoratorOps = 0x0048;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0058;

	}

	public class UBehaviorTreeManager
	{
		///<summary><![CDATA[int]]></summary>
		public const int MaxDebuggerSteps = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

		///<summary><![CDATA[TArray<FBehaviorTreeTemplateInfo>]]></summary>
		public const int LoadedTemplates = 0x0030;

		///<summary><![CDATA[TArray<UBehaviorTreeComponent * >]]></summary>
		public const int ActiveComponents = 0x0040;

	}

	public class UBlackboardKeyType
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UBlackboardKeyType_Enum
	{
		///<summary><![CDATA[UEnum *]]></summary>
		public const int EnumType = 0x0030;

		///<summary><![CDATA[FString]]></summary>
		public const int EnumName = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsEnumNameValid = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UBlackboardKeyType_NativeEnum
	{
		///<summary><![CDATA[FString]]></summary>
		public const int EnumName = 0x0030;

		///<summary><![CDATA[UEnum *]]></summary>
		public const int EnumType = 0x0040;

	}

	public class UBlackboardData
	{
		///<summary><![CDATA[UBlackboardData *]]></summary>
		public const int Parent = 0x0028;

		///<summary><![CDATA[TArray<FBlackboardEntry>]]></summary>
		public const int Keys = 0x0030;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasSynchronizedKeys = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0041;

	}

	public class UBlackboardComponent
	{
		///<summary><![CDATA[UBrainComponent *]]></summary>
		public const int BrainComp = 0x00F8;

		///<summary><![CDATA[UBlackboardData *]]></summary>
		public const int BlackboardAsset = 0x0100;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0108;

		///<summary><![CDATA[TArray<UBlackboardKeyType * >]]></summary>
		public const int KeyInstances = 0x0128;

		///<summary><![CDATA[unsigned char[0xB8]]]></summary>
		public const int UnknownData01 = 0x0138;

	}

	public class UBlackboardKeyType_Class
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int BaseClass = 0x0030;

	}

	public class UBlackboardKeyType_Object
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int BaseClass = 0x0030;

	}

	public class UBlackboardKeyType_String
	{
		///<summary><![CDATA[FString]]></summary>
		public const int StringValue = 0x0030;

	}

	public class UBTDecorator_BlackboardBase
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKey = 0x0068;

	}

	public class UBTDecorator_Blackboard
	{
		///<summary><![CDATA[int]]></summary>
		public const int IntValue = 0x0090;

		///<summary><![CDATA[float]]></summary>
		public const int FloatValue = 0x0094;

		///<summary><![CDATA[FString]]></summary>
		public const int StringValue = 0x0098;

		///<summary><![CDATA[FString]]></summary>
		public const int CachedDescription = 0x00A8;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int OperationType = 0x00B8;

		///<summary><![CDATA[TEnumAsByte<EBTBlackboardRestart>]]></summary>
		public const int NotifyObserver = 0x00B9;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x00BA;

	}

	public class UBTDecorator_IsAtLocation
	{
		///<summary><![CDATA[float]]></summary>
		public const int AcceptableRadius = 0x0090;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0094;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ParametrizedAcceptableRadius = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseParametrizedRadius = 0x00C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseNavAgentGoalLocation = 0x00C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00C9;

	}

	public class UBTDecorator_IsBBEntryOfClass
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int TestClass = 0x0090;

	}

	public class UBTDecorator_BlueprintBase
	{
		///<summary><![CDATA[AAIController *]]></summary>
		public const int AIOwner = 0x0068;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ActorOwner = 0x0070;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int ObservedKeyNames = 0x0078;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0088;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowPropertyDetails = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCheckConditionOnlyBlackBoardChanges = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsObservingBB = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0099;

	}

	public class UBTDecorator_CheckGameplayTagsOnActor
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int ActorToCheck = 0x0068;

		///<summary><![CDATA[TEnumAsByte<EGameplayContainerMatchType>]]></summary>
		public const int TagsToMatch = 0x0090;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0091;

		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int GameplayTags = 0x0098;

		///<summary><![CDATA[FString]]></summary>
		public const int CachedDescription = 0x00B8;

	}

	public class UBTDecorator_CompareBBEntries
	{
		///<summary><![CDATA[TEnumAsByte<EBlackBoardEntryComparison>]]></summary>
		public const int Operator = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0069;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKeyA = 0x0070;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKeyB = 0x0098;

	}

	public class UBTDecorator_ConeCheck
	{
		///<summary><![CDATA[float]]></summary>
		public const int ConeHalfAngle = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x006C;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int ConeOrigin = 0x0070;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int ConeDirection = 0x0098;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int Observed = 0x00C0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x00E8;

	}

	public class UBTDecorator_Cooldown
	{
		///<summary><![CDATA[float]]></summary>
		public const int CoolDownTime = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x006C;

	}

	public class UBTDecorator_DoesPathExist
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKeyA = 0x0068;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKeyB = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseSelf = 0x00B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00B9;

		///<summary><![CDATA[TEnumAsByte<EPathExistanceQueryType>]]></summary>
		public const int PathQueryType = 0x00BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00BD;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FilterClass = 0x00C0;

	}

	public class UBTDecorator_KeepInCone
	{
		///<summary><![CDATA[float]]></summary>
		public const int ConeHalfAngle = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x006C;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int ConeOrigin = 0x0070;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int Observed = 0x0098;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseSelfAsOrigin = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseSelfAsObserved = 0x00C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00C1;

	}

	public class UBTDecorator_Loop
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumLoops = 0x0068;

		///<summary><![CDATA[bool]]></summary>
		public const int bInfiniteLoop = 0x006C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x006D;

		///<summary><![CDATA[float]]></summary>
		public const int InfiniteLoopTimeoutTime = 0x0070;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0074;

	}

	public class UBTDecorator_SetTagCooldown
	{
		///<summary><![CDATA[FGameplayTag]]></summary>
		public const int CooldownTag = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int CooldownDuration = 0x0070;

		///<summary><![CDATA[bool]]></summary>
		public const int bAddToExistingDuration = 0x0074;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0075;

	}

	public class UBTDecorator_TagCooldown
	{
		///<summary><![CDATA[FGameplayTag]]></summary>
		public const int CooldownTag = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int CooldownDuration = 0x0070;

		///<summary><![CDATA[bool]]></summary>
		public const int bAddToExistingDuration = 0x0074;

		///<summary><![CDATA[bool]]></summary>
		public const int bActivatesCooldown = 0x0075;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0076;

	}

	public class UBTDecorator_TimeLimit
	{
		///<summary><![CDATA[float]]></summary>
		public const int TimeLimit = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x006C;

	}

	public class UBTService
	{
		///<summary><![CDATA[float]]></summary>
		public const int Interval = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int RandomDeviation = 0x0064;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCallTickOnSearchStart = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRestartTimerOnEachActivation = 0x0068;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0069;

	}

	public class UBTService_BlackboardBase
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKey = 0x0070;

	}

	public class UBTService_DefaultFocus
	{
		///<summary><![CDATA[unsigned char]]></summary>
		public const int FocusPriority = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0099;

	}

	public class UEnvQueryItemType
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UBTService_RunEQS
	{
		///<summary><![CDATA[FEQSParametrizedQueryExecutionRequest]]></summary>
		public const int EQSRequest = 0x0098;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData00 = 0x00E0;

	}

	public class UBTService_BlueprintBase
	{
		///<summary><![CDATA[AAIController *]]></summary>
		public const int AIOwner = 0x0070;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ActorOwner = 0x0078;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowPropertyDetails = 0x0090;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowEventDetails = 0x0090;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0091;

	}

	public class UBTTask_MoveTo
	{
		///<summary><![CDATA[float]]></summary>
		public const int AcceptableRadius = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FilterClass = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int ObservedBlackboardValueTolerance = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bObserveBlackboardValue = 0x00AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowStrafe = 0x00AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowPartialPath = 0x00AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTrackMovingGoal = 0x00AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProjectGoalLocation = 0x00AC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStopOnOverlap = 0x00AC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00AD;

	}

	public class UBTTask_MoveDirectlyToward
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisablePathUpdateOnGoalLocationChange = 0x00B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProjectVectorGoalToNavigation = 0x00B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdatedDeprecatedProperties = 0x00B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00B1;

	}

	public class UBTTask_RotateToFaceBBEntry
	{
		///<summary><![CDATA[float]]></summary>
		public const int Precision = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

	}

	public class UBTTask_RunEQSQuery
	{
		///<summary><![CDATA[UEnvQuery *]]></summary>
		public const int QueryTemplate = 0x0098;

		///<summary><![CDATA[TArray<FEnvNamedValue>]]></summary>
		public const int QueryParams = 0x00A0;

		///<summary><![CDATA[TArray<FAIDynamicParam>]]></summary>
		public const int QueryConfig = 0x00B0;

		///<summary><![CDATA[TEnumAsByte<EEnvQueryRunMode>]]></summary>
		public const int RunMode = 0x00C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00C1;

		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int EQSQueryBlackboardKey = 0x00C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseBBKey = 0x00F0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00F1;

		///<summary><![CDATA[FEQSParametrizedQueryExecutionRequest]]></summary>
		public const int EQSRequest = 0x00F8;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData02 = 0x0140;

	}

	public class UBTTask_BlueprintBase
	{
		///<summary><![CDATA[AAIController *]]></summary>
		public const int AIOwner = 0x0070;

		///<summary><![CDATA[AActor *]]></summary>
		public const int ActorOwner = 0x0078;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0080;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowPropertyDetails = 0x0098;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0099;

	}

	public class UBTTask_GameplayTaskBase
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWaitForGameplayTask = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0071;

	}

	public class UBTTask_MakeNoise
	{
		///<summary><![CDATA[float]]></summary>
		public const int Loudnes = 0x0070;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0074;

	}

	public class UPawnAction
	{
		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int ChildAction = 0x0028;

		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int ParentAction = 0x0030;

		///<summary><![CDATA[UPawnActionsComponent *]]></summary>
		public const int OwnerComponent = 0x0038;

		///<summary><![CDATA[UObject *]]></summary>
		public const int Instigator = 0x0040;

		///<summary><![CDATA[UBrainComponent *]]></summary>
		public const int BrainComp = 0x0048;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData00 = 0x0050;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowNewSameClassInstance = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplaceActiveSameClassInstance = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldPauseMovement = 0x00B8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAlwaysNotifyOnFinished = 0x00B8;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData01 = 0x00B9;

	}

	public class UBTTask_PushPawnAction
	{
		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int Action = 0x0070;

	}

	public class UBTTask_PlayAnimation
	{
		///<summary><![CDATA[UAnimationAsset *]]></summary>
		public const int AnimationToPlay = 0x0070;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLooping = 0x0078;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bNonBlocking = 0x0078;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0079;

		///<summary><![CDATA[UBehaviorTreeComponent *]]></summary>
		public const int MyOwnerComp = 0x0080;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int CachedSkelMesh = 0x0088;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData01 = 0x0090;

	}

	public class UBTTask_PlaySound
	{
		///<summary><![CDATA[USoundCue *]]></summary>
		public const int SoundToPlay = 0x0070;

	}

	public class UBTTask_RunBehavior
	{
		///<summary><![CDATA[UBehaviorTree *]]></summary>
		public const int BehaviorAsset = 0x0070;

	}

	public class UBTTask_RunBehaviorDynamic
	{
		///<summary><![CDATA[FGameplayTag]]></summary>
		public const int InjectionTag = 0x0070;

		///<summary><![CDATA[UBehaviorTree *]]></summary>
		public const int DefaultBehaviorAsset = 0x0078;

		///<summary><![CDATA[UBehaviorTree *]]></summary>
		public const int BehaviorAsset = 0x0080;

	}

	public class UBTTask_SetTagCooldown
	{
		///<summary><![CDATA[FGameplayTag]]></summary>
		public const int CooldownTag = 0x0070;

		///<summary><![CDATA[bool]]></summary>
		public const int bAddToExistingDuration = 0x0078;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0079;

		///<summary><![CDATA[float]]></summary>
		public const int CooldownDuration = 0x007C;

	}

	public class UBTTask_Wait
	{
		///<summary><![CDATA[float]]></summary>
		public const int WaitTime = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int RandomDeviation = 0x0074;

	}

	public class UBTTask_WaitBlackboardTime
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int BlackboardKey = 0x0078;

	}

	public class UCrowdManager
	{
		///<summary><![CDATA[ANavigationData *]]></summary>
		public const int MyNavData = 0x0028;

		///<summary><![CDATA[TArray<FCrowdAvoidanceConfig>]]></summary>
		public const int AvoidanceConfig = 0x0030;

		///<summary><![CDATA[TArray<FCrowdAvoidanceSamplingPattern>]]></summary>
		public const int SamplingPatterns = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int MaxAgents = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAgentRadius = 0x0054;

		///<summary><![CDATA[int]]></summary>
		public const int MaxAvoidedAgents = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int MaxAvoidedWalls = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int NavmeshCheckInterval = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int PathOptimizationInterval = 0x0064;

		///<summary><![CDATA[unsigned char:4]]></summary>
		public const int UnknownData00 = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bResolveCollisions = 0x0068;

		///<summary><![CDATA[unsigned char[0x7F]]]></summary>
		public const int UnknownData01 = 0x0069;

	}

	public class UEnvQuery
	{
		///<summary><![CDATA[FName]]></summary>
		public const int QueryName = 0x0028;

		///<summary><![CDATA[TArray<UEnvQueryOption * >]]></summary>
		public const int Options = 0x0030;

	}

	public class UEnvQueryContext_BlueprintBase
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UEnvQueryInstanceBlueprintWrapper
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int QueryID = 0x0030;

		///<summary><![CDATA[unsigned char[0x24]]]></summary>
		public const int UnknownData01 = 0x0034;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ItemType = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int OptionIndex = 0x0060;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0064;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnQueryFinishedEvent = 0x0068;

	}

	public class UEnvQueryManager
	{
		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FEnvQueryInstanceCache>]]></summary>
		public const int InstanceCache = 0x0098;

		///<summary><![CDATA[TArray<UEnvQueryContext * >]]></summary>
		public const int LocalContexts = 0x00A8;

		///<summary><![CDATA[TArray<UEnvQueryInstanceBlueprintWrapper * >]]></summary>
		public const int GCShieldedWrappers = 0x00B8;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData01 = 0x00C8;

		///<summary><![CDATA[double]]></summary>
		public const int MaxAllowedTestingTime = 0x0120;

		///<summary><![CDATA[bool]]></summary>
		public const int bTestQueriesUsingBreadth = 0x0128;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0129;

		///<summary><![CDATA[int]]></summary>
		public const int QueryCountWarningThreshold = 0x012C;

		///<summary><![CDATA[double]]></summary>
		public const int QueryCountWarningInterval = 0x0130;

	}

	public class UEnvQueryNode
	{
		///<summary><![CDATA[int]]></summary>
		public const int VerNum = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UEnvQueryGenerator
	{
		///<summary><![CDATA[FString]]></summary>
		public const int OptionName = 0x0030;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ItemType = 0x0040;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoSortTests = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UEnvQueryGenerator_ActorsOfClass
	{
		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int SearchRadius = 0x0050;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SearchedActorClass = 0x0080;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SearchCenter = 0x0088;

	}

	public class UEnvQueryGenerator_BlueprintBase
	{
		///<summary><![CDATA[FText]]></summary>
		public const int GeneratorsActionDescription = 0x0050;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Context = 0x0068;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GeneratedItemType = 0x0070;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UEnvQueryGenerator_Composite
	{
		///<summary><![CDATA[TArray<UEnvQueryGenerator * >]]></summary>
		public const int Generators = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int bHasMatchingItemType = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0061;

	}

	public class UEnvQueryGenerator_CurrentLocation
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int QueryContext = 0x0050;

	}

	public class UEnvQueryGenerator_ProjectedPoints
	{
		///<summary><![CDATA[FEnvTraceData]]></summary>
		public const int ProjectionData = 0x0050;

	}

	public class UEnvQueryGenerator_Donut
	{
		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int InnerRadius = 0x0080;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int OuterRadius = 0x00B0;

		///<summary><![CDATA[FAIDataProviderIntValue]]></summary>
		public const int NumberOfRings = 0x00E0;

		///<summary><![CDATA[FAIDataProviderIntValue]]></summary>
		public const int PointsPerRing = 0x0110;

		///<summary><![CDATA[FEnvDirection]]></summary>
		public const int ArcDirection = 0x0140;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ArcAngle = 0x0160;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSpiralPattern = 0x0190;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0191;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Center = 0x0198;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefineArc = 0x01A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x01A1;

	}

	public class UEnvQueryGenerator_OnCircle
	{
		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int CircleRadius = 0x0080;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int SpaceBetween = 0x00B0;

		///<summary><![CDATA[FAIDataProviderIntValue]]></summary>
		public const int NumberOfPoints = 0x00E0;

		///<summary><![CDATA[TEnumAsByte<EPointOnCircleSpacingMethod>]]></summary>
		public const int PointOnCircleSpacingMethod = 0x0110;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0111;

		///<summary><![CDATA[FEnvDirection]]></summary>
		public const int ArcDirection = 0x0118;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ArcAngle = 0x0138;

		///<summary><![CDATA[float]]></summary>
		public const int AngleRadians = 0x0168;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x016C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CircleCenter = 0x0170;

		///<summary><![CDATA[bool]]></summary>
		public const int bIgnoreAnyContextActorsWhenGeneratingCircle = 0x0178;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0179;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int CircleCenterZOffset = 0x0180;

		///<summary><![CDATA[FEnvTraceData]]></summary>
		public const int TraceData = 0x01B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDefineArc = 0x01E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x01E1;

	}

	public class UEnvQueryGenerator_SimpleGrid
	{
		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int GridSize = 0x0080;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int SpaceBetween = 0x00B0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GenerateAround = 0x00E0;

	}

	public class UEnvQueryGenerator_PathingGrid
	{
		///<summary><![CDATA[FAIDataProviderBoolValue]]></summary>
		public const int PathToItem = 0x00E8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int NavigationFilter = 0x0118;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ScanRangeMultiplier = 0x0120;

	}

	public class UEnvQueryTest
	{
		///<summary><![CDATA[int]]></summary>
		public const int TestOrder = 0x0030;

		///<summary><![CDATA[TEnumAsByte<EEnvTestPurpose>]]></summary>
		public const int TestPurpose = 0x0034;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0035;

		///<summary><![CDATA[FString]]></summary>
		public const int TestComment = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EEnvTestFilterOperator>]]></summary>
		public const int MultipleContextFilterOp = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EEnvTestScoreOperator>]]></summary>
		public const int MultipleContextScoreOp = 0x0049;

		///<summary><![CDATA[TEnumAsByte<EEnvTestFilterType>]]></summary>
		public const int FilterType = 0x004A;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData01 = 0x004B;

		///<summary><![CDATA[FAIDataProviderBoolValue]]></summary>
		public const int BoolValue = 0x0050;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int FloatValueMin = 0x0080;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int FloatValueMax = 0x00B0;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x00E0;

		///<summary><![CDATA[TEnumAsByte<EEnvTestScoreEquation>]]></summary>
		public const int ScoringEquation = 0x00E1;

		///<summary><![CDATA[TEnumAsByte<EEnvQueryTestClamping>]]></summary>
		public const int ClampMinType = 0x00E2;

		///<summary><![CDATA[TEnumAsByte<EEnvQueryTestClamping>]]></summary>
		public const int ClampMaxType = 0x00E3;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x00E4;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ScoreClampMin = 0x00E8;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ScoreClampMax = 0x0118;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ScoringFactor = 0x0148;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ReferenceValue = 0x0178;

		///<summary><![CDATA[bool]]></summary>
		public const int bDefineReferenceValue = 0x01A8;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData04 = 0x01A9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWorkOnFloatValues = 0x01B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x01B9;

	}

	public class UEnvQueryTest_Distance
	{
		///<summary><![CDATA[TEnumAsByte<EEnvTestDistance>]]></summary>
		public const int TestMode = 0x01C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01C1;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DistanceTo = 0x01C8;

	}

	public class UEnvQueryTest_Dot
	{
		///<summary><![CDATA[FEnvDirection]]></summary>
		public const int LineA = 0x01C0;

		///<summary><![CDATA[FEnvDirection]]></summary>
		public const int LineB = 0x01E0;

		///<summary><![CDATA[TEnumAsByte<EEnvTestDot>]]></summary>
		public const int TestMode = 0x0200;

		///<summary><![CDATA[bool]]></summary>
		public const int bAbsoluteValue = 0x0201;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x0202;

	}

	public class UEnvQueryTest_GameplayTags
	{
		///<summary><![CDATA[TEnumAsByte<EGameplayContainerMatchType>]]></summary>
		public const int TagsToMatch = 0x01C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01C1;

		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int GameplayTags = 0x01C8;

	}

	public class UEnvQueryTest_Overlap
	{
		///<summary><![CDATA[FEnvOverlapData]]></summary>
		public const int OverlapData = 0x01C0;

	}

	public class UEnvQueryTest_Pathfinding
	{
		///<summary><![CDATA[TEnumAsByte<EEnvTestPathfinding>]]></summary>
		public const int TestMode = 0x01C0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01C1;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Context = 0x01C8;

		///<summary><![CDATA[FAIDataProviderBoolValue]]></summary>
		public const int PathFromContext = 0x01D0;

		///<summary><![CDATA[FAIDataProviderBoolValue]]></summary>
		public const int SkipUnreachable = 0x0200;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FilterClass = 0x0230;

	}

	public class UEnvQueryTest_PathfindingBatch
	{
		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ScanRangeMultiplier = 0x0238;

	}

	public class UEnvQueryTest_Project
	{
		///<summary><![CDATA[FEnvTraceData]]></summary>
		public const int ProjectionData = 0x01C0;

	}

	public class UEnvQueryTest_Trace
	{
		///<summary><![CDATA[FEnvTraceData]]></summary>
		public const int TraceData = 0x01C0;

		///<summary><![CDATA[FAIDataProviderBoolValue]]></summary>
		public const int TraceFromContext = 0x01F0;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ItemHeightOffset = 0x0220;

		///<summary><![CDATA[FAIDataProviderFloatValue]]></summary>
		public const int ContextHeightOffset = 0x0250;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Context = 0x0280;

	}

	public class UEnvQueryOption
	{
		///<summary><![CDATA[UEnvQueryGenerator *]]></summary>
		public const int Generator = 0x0028;

		///<summary><![CDATA[TArray<UEnvQueryTest * >]]></summary>
		public const int Tests = 0x0030;

	}

	public class UEQSRenderingComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x06D0;

	}

	public class AEQSTestingPawn
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x07C0;

		///<summary><![CDATA[UEnvQuery *]]></summary>
		public const int QueryTemplate = 0x07C8;

		///<summary><![CDATA[TArray<FEnvNamedValue>]]></summary>
		public const int QueryParams = 0x07D0;

		///<summary><![CDATA[TArray<FAIDynamicParam>]]></summary>
		public const int QueryConfig = 0x07E0;

		///<summary><![CDATA[float]]></summary>
		public const int TimeLimitPerStep = 0x07F0;

		///<summary><![CDATA[int]]></summary>
		public const int StepToDebugDraw = 0x07F4;

		///<summary><![CDATA[TEnumAsByte<EEnvQueryHightlightMode>]]></summary>
		public const int HighlightMode = 0x07F8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x07F9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawLabels = 0x07FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDrawFailedItems = 0x07FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReRunQueryOnlyOnFinishedMove = 0x07FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShouldBeVisibleInGame = 0x07FC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bTickDuringGame = 0x07FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x07FD;

		///<summary><![CDATA[TEnumAsByte<EEnvQueryRunMode>]]></summary>
		public const int QueryingMode = 0x0800;

		///<summary><![CDATA[unsigned char[0x2F]]]></summary>
		public const int UnknownData03 = 0x0801;

	}

	public class UCrowdFollowingComponent
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int CrowdAgentMoveDirection = 0x03B0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03BC;

		///<summary><![CDATA[UCharacterMovementComponent *]]></summary>
		public const int CharacterMovement = 0x03C0;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int AvoidanceGroup = 0x03C8;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int GroupsToAvoid = 0x03CC;

		///<summary><![CDATA[FNavAvoidanceMask]]></summary>
		public const int GroupsToIgnore = 0x03D0;

		///<summary><![CDATA[unsigned char[0x2C]]]></summary>
		public const int UnknownData01 = 0x03D4;

	}

	public class UPawnAction_Move
	{
		///<summary><![CDATA[AActor *]]></summary>
		public const int GoalActor = 0x00D0;

		///<summary><![CDATA[FVector]]></summary>
		public const int GoalLocation = 0x00D8;

		///<summary><![CDATA[float]]></summary>
		public const int AcceptableRadius = 0x00E4;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FilterClass = 0x00E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowStrafe = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFinishOnOverlap = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsePathfinding = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowPartialPath = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bProjectGoalToNavigation = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUpdatePathToGoal = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAbortChildActionOnPathChange = 0x00F0;

		///<summary><![CDATA[unsigned char[0x2F]]]></summary>
		public const int UnknownData00 = 0x00F1;

	}

	public class UPawnAction_Repeat
	{
		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int ActionToRepeat = 0x00D0;

		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int RecentActionCopy = 0x00D8;

		///<summary><![CDATA[TEnumAsByte<EPawnActionFailHandling>]]></summary>
		public const int ChildFailureHandlingMode = 0x00E0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x00E1;

	}

	public class UPawnAction_Sequence
	{
		///<summary><![CDATA[TArray<UPawnAction * >]]></summary>
		public const int ActionSequence = 0x00D0;

		///<summary><![CDATA[TEnumAsByte<EPawnActionFailHandling>]]></summary>
		public const int ChildFailureHandlingMode = 0x00E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00E1;

		///<summary><![CDATA[UPawnAction *]]></summary>
		public const int RecentActionCopy = 0x00E8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x00F0;

	}

	public class UPawnAction_Wait
	{
		///<summary><![CDATA[float]]></summary>
		public const int TimeToWait = 0x00D0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x00D4;

	}

	public class UPawnSensingComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int HearingThreshold = 0x00F8;

		///<summary><![CDATA[float]]></summary>
		public const int LOSHearingThreshold = 0x00FC;

		///<summary><![CDATA[float]]></summary>
		public const int SightRadius = 0x0100;

		///<summary><![CDATA[float]]></summary>
		public const int SensingInterval = 0x0104;

		///<summary><![CDATA[float]]></summary>
		public const int HearingMaxSoundAge = 0x0108;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bEnableSensingUpdates = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOnlySensePlayers = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bSeePawns = 0x010C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHearNoises = 0x010C;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData00 = 0x010D;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSeePawn = 0x0118;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnHearNoise = 0x0128;

		///<summary><![CDATA[float]]></summary>
		public const int PeripheralVisionAngle = 0x0138;

		///<summary><![CDATA[float]]></summary>
		public const int PeripheralVisionCosine = 0x013C;

	}

}
