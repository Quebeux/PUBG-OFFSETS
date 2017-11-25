/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UEditableGameplayTagQuery
	{
		///<summary><![CDATA[FString]]></summary>
		public const int UserDescription = 0x0028;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[UEditableGameplayTagQueryExpression *]]></summary>
		public const int RootExpression = 0x0048;

		///<summary><![CDATA[FGameplayTagQuery]]></summary>
		public const int TagQueryExportText_Helper = 0x0050;

	}

	public class UEditableGameplayTagQueryExpression_AnyTagsMatch
	{
		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AllTagsMatch
	{
		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_NoTagsMatch
	{
		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AnyExprMatch
	{
		///<summary><![CDATA[TArray<UEditableGameplayTagQueryExpression * >]]></summary>
		public const int Expressions = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AllExprMatch
	{
		///<summary><![CDATA[TArray<UEditableGameplayTagQueryExpression * >]]></summary>
		public const int Expressions = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_NoExprMatch
	{
		///<summary><![CDATA[TArray<UEditableGameplayTagQueryExpression * >]]></summary>
		public const int Expressions = 0x0028;

	}

	public class UGameplayTagsSettings
	{
		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int GameplayTags = 0x0028;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int CommonlyReplicatedTags = 0x0038;

		///<summary><![CDATA[int]]></summary>
		public const int NetIndexFirstBitSegment = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

	}

	public class UGameplayTagsDeveloperSettings
	{
		///<summary><![CDATA[FString]]></summary>
		public const int DeveloperConfigName = 0x0028;

	}

	public class UGameplayTagsManager
	{
		///<summary><![CDATA[unsigned char[0x138]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<UDataTable * >]]></summary>
		public const int GameplayTagTables = 0x0160;

		///<summary><![CDATA[unsigned char[0xC0]]]></summary>
		public const int UnknownData01 = 0x0170;

	}

}
