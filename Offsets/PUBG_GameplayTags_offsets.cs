/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UEditableGameplayTagQuery
	{
		///<summary>FString</summary>
		public const int UserDescription = 0x0028;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0038;

		///<summary>UEditableGameplayTagQueryExpression *</summary>
		public const int RootExpression = 0x0048;

		///<summary>FGameplayTagQuery</summary>
		public const int TagQueryExportText_Helper = 0x0050;

	}

	public class UEditableGameplayTagQueryExpression_AnyTagsMatch
	{
		///<summary>FGameplayTagContainer</summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AllTagsMatch
	{
		///<summary>FGameplayTagContainer</summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_NoTagsMatch
	{
		///<summary>FGameplayTagContainer</summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AnyExprMatch
	{
		///<summary>TArray&lt;UEditableGameplayTagQueryExpression * &gt;</summary>
		public const int Expressions = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AllExprMatch
	{
		///<summary>TArray&lt;UEditableGameplayTagQueryExpression * &gt;</summary>
		public const int Expressions = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_NoExprMatch
	{
		///<summary>TArray&lt;UEditableGameplayTagQueryExpression * &gt;</summary>
		public const int Expressions = 0x0028;

	}

	public class UGameplayTagsManager
	{
		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;FGameplayTagSource&gt;</summary>
		public const int TagSources = 0x00A8;

		///<summary>unsigned char[0x68]</summary>
		public const int UnknownData01 = 0x00B8;

		///<summary>TArray&lt;UDataTable * &gt;</summary>
		public const int GameplayTagTables = 0x0120;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData02 = 0x0130;

	}

	public class UGameplayTagsList
	{
		///<summary>FString</summary>
		public const int ConfigFileName = 0x0028;

		///<summary>TArray&lt;FGameplayTagTableRow&gt;</summary>
		public const int GameplayTagList = 0x0038;

	}

	public class UGameplayTagsSettings
	{
		///<summary>bool</summary>
		public const int ImportTagsFromConfig = 0x0048;

		///<summary>bool</summary>
		public const int WarnOnInvalidTags = 0x0049;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x004A;

		///<summary>TArray&lt;FGameplayTagCategoryRemap&gt;</summary>
		public const int CategoryRemapping = 0x0050;

		///<summary>bool</summary>
		public const int FastReplication = 0x0060;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0061;

		///<summary>TArray&lt;FStringAssetReference&gt;</summary>
		public const int GameplayTagTableList = 0x0068;

		///<summary>TArray&lt;FGameplayTagRedirect&gt;</summary>
		public const int GameplayTagRedirects = 0x0078;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int CommonlyReplicatedTags = 0x0088;

		///<summary>int</summary>
		public const int NumBitsForContainerSize = 0x0098;

		///<summary>int</summary>
		public const int NetIndexFirstBitSegment = 0x009C;

	}

	public class UGameplayTagsDeveloperSettings
	{
		///<summary>FString</summary>
		public const int DeveloperConfigName = 0x0028;

	}

}
