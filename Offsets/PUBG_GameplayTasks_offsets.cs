/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGameplayTask
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FName]]></summary>
		public const int InstanceName = 0x0030;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData01 = 0x0038;

		///<summary><![CDATA[UGameplayTask *]]></summary>
		public const int ChildTask = 0x0060;

	}

	public class UGameplayTask_SpawnActor
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int Success = 0x0068;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int DidNotSpawn = 0x0078;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0088;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ClassToSpawn = 0x00A0;

	}

	public class UGameplayTask_WaitDelay
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnFinish = 0x0068;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UGameplayTaskResource
	{
		///<summary><![CDATA[int]]></summary>
		public const int ManualResourceID = 0x0028;

		///<summary><![CDATA[int8_t]]></summary>
		public const int AutoResourceID = 0x002C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x002D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bManuallySetID = 0x0030;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0031;

	}

	public class UGameplayTasksComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00F8;

		///<summary><![CDATA[TArray<UGameplayTask * >]]></summary>
		public const int SimulatedTasks = 0x0100;

		///<summary><![CDATA[TArray<UGameplayTask * >]]></summary>
		public const int TaskPriorityQueue = 0x0110;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0120;

		///<summary><![CDATA[TArray<UGameplayTask * >]]></summary>
		public const int TickingTasks = 0x0130;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0140;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnClaimedResourcesChange = 0x0148;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0158;

	}

}
