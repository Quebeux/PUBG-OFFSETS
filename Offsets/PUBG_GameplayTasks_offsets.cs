/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGameplayTask
	{
		public const int UnknownData00 = 0x0028;
		public const int InstanceName = 0x0030;
		public const int UnknownData01 = 0x0038;
		public const int ChildTask = 0x0060;
	}

	public class UGameplayTask_SpawnActor
	{
		public const int Success = 0x0068;
		public const int DidNotSpawn = 0x0078;
		public const int UnknownData00 = 0x0088;
		public const int ClassToSpawn = 0x00A0;
	}

	public class UGameplayTask_WaitDelay
	{
		public const int OnFinish = 0x0068;
		public const int UnknownData00 = 0x0078;
	}

	public class UGameplayTaskResource
	{
		public const int ManualResourceID = 0x0028;
		public const int AutoResourceID = 0x002C;
		public const int UnknownData00 = 0x002D;
		public const int bManuallySetID = 0x0030;
		public const int UnknownData01 = 0x0031;
	}

	public class UGameplayTasksComponent
	{
		public const int UnknownData00 = 0x00F8;
		public const int SimulatedTasks = 0x0100;
		public const int TaskPriorityQueue = 0x0110;
		public const int UnknownData01 = 0x0120;
		public const int TickingTasks = 0x0130;
		public const int UnknownData02 = 0x0140;
		public const int OnClaimedResourcesChange = 0x0148;
		public const int UnknownData03 = 0x0158;
	}

}
