/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGameplayTask
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FName</summary>
		public const int InstanceName = 0x0030;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x0038;

		///<summary>ETaskResourceOverlapPolicy</summary>
		public const int ResourceOverlapPolicy = 0x003A;

		///<summary>unsigned char[0x25]</summary>
		public const int UnknownData02 = 0x003B;

		///<summary>UGameplayTask *</summary>
		public const int ChildTask = 0x0060;

	}

	public class UGameplayTaskResource
	{
		///<summary>int</summary>
		public const int ManualResourceID = 0x0028;

		///<summary>int8_t</summary>
		public const int AutoResourceID = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x002D;

		///<summary>unsigned char:1</summary>
		public const int bManuallySetID = 0x0030;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0031;

	}

	public class UGameplayTask_SpawnActor
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int SUCCESS = 0x0068;

		///<summary>FScriptMulticastDelegate</summary>
		public const int DidNotSpawn = 0x0078;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0088;

		///<summary>UClass *</summary>
		public const int ClassToSpawn = 0x00A0;

	}

	public class UGameplayTask_TimeLimitedExecution
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFinished = 0x0068;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTimeExpired = 0x0078;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0088;

	}

	public class UGameplayTask_WaitDelay
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFinish = 0x0068;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UGameplayTasksComponent
	{
		///<summary>TArray&lt;UGameplayTask * &gt;</summary>
		public const int SimulatedTasks = 0x01E0;

		///<summary>TArray&lt;UGameplayTask * &gt;</summary>
		public const int TaskPriorityQueue = 0x01F0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0200;

		///<summary>TArray&lt;UGameplayTask * &gt;</summary>
		public const int TickingTasks = 0x0210;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0220;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnClaimedResourcesChange = 0x0228;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0238;

	}

}
