/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UEditableGameplayTagQuery
	{
		public const int UserDescription = 0x0028;
		public const int UnknownData00 = 0x0038;
		public const int RootExpression = 0x0048;
		public const int TagQueryExportText_Helper = 0x0050;
	}

	public class UEditableGameplayTagQueryExpression_AnyTagsMatch
	{
		public const int Tags = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_AllTagsMatch
	{
		public const int Tags = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_NoTagsMatch
	{
		public const int Tags = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_AnyExprMatch
	{
		public const int Expressions = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_AllExprMatch
	{
		public const int Expressions = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_NoExprMatch
	{
		public const int Expressions = 0x0028;
	}

	public class UGameplayTagsSettings
	{
		public const int GameplayTags = 0x0028;
		public const int CommonlyReplicatedTags = 0x0038;
		public const int NetIndexFirstBitSegment = 0x0048;
		public const int UnknownData00 = 0x004C;
	}

	public class UGameplayTagsDeveloperSettings
	{
		public const int DeveloperConfigName = 0x0028;
	}

	public class UGameplayTagsManager
	{
		public const int UnknownData00 = 0x0028;
		public const int GameplayTagTables = 0x0160;
		public const int UnknownData01 = 0x0170;
	}

}
