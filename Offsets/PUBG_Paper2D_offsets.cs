/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMaterialExpressionSpriteTextureSampler
	{
		///<summary>bool</summary>
		public const int bSampleAdditionalTextures = 0x01B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x01B9;

		///<summary>int</summary>
		public const int AdditionalSlotIndex = 0x01BC;

		///<summary>FText</summary>
		public const int SlotDisplayName = 0x01C0;

	}

	public class APaperCharacter
	{
		///<summary>UPaperFlipbookComponent *</summary>
		public const int Sprite = 0x07E0;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x07E8;

	}

	public class UPaperFlipbook
	{
		///<summary>float</summary>
		public const int FramesPerSecond = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

		///<summary>TArray&lt;FPaperFlipbookKeyFrame&gt;</summary>
		public const int KeyFrames = 0x0030;

		///<summary>UMaterialInterface *</summary>
		public const int DefaultMaterial = 0x0040;

		///<summary>TEnumAsByte&lt;EFlipbookCollisionMode&gt;</summary>
		public const int CollisionSource = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0049;

	}

	public class APaperFlipbookActor
	{
		///<summary>UPaperFlipbookComponent *</summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperFlipbookComponent
	{
		///<summary>UPaperFlipbook *</summary>
		public const int SourceFlipbook = 0x0950;

		///<summary>UMaterialInterface *</summary>
		public const int Material = 0x0958;

		///<summary>float</summary>
		public const int PlayRate = 0x0960;

		///<summary>unsigned char:1</summary>
		public const int bLooping = 0x0964;

		///<summary>unsigned char:1</summary>
		public const int bReversePlayback = 0x0964;

		///<summary>unsigned char:1</summary>
		public const int bPlaying = 0x0964;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0965;

		///<summary>float</summary>
		public const int AccumulatedTime = 0x0968;

		///<summary>int</summary>
		public const int CachedFrameIndex = 0x096C;

		///<summary>FLinearColor</summary>
		public const int SpriteColor = 0x0970;

		///<summary>UBodySetup *</summary>
		public const int CachedBodySetup = 0x0980;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFinishedPlaying = 0x0988;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0998;

	}

	public class APaperGroupedSpriteActor
	{
		///<summary>UPaperGroupedSpriteComponent *</summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperGroupedSpriteComponent
	{
		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int InstanceMaterials = 0x0950;

		///<summary>TArray&lt;FSpriteInstanceData&gt;</summary>
		public const int PerInstanceSpriteData = 0x0960;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0970;

	}

	public class UPaperRuntimeSettings
	{
		///<summary>bool</summary>
		public const int bEnableSpriteAtlasGroups = 0x0028;

		///<summary>bool</summary>
		public const int bEnableTerrainSplineEditing = 0x0029;

		///<summary>bool</summary>
		public const int bResizeSpriteDataToMatchTextures = 0x002A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x002B;

	}

	public class UPaperSprite
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FVector2D</summary>
		public const int SourceUV = 0x0038;

		///<summary>FVector2D</summary>
		public const int SourceDimension = 0x0040;

		///<summary>UTexture2D *</summary>
		public const int SourceTexture = 0x0048;

		///<summary>TArray&lt;UTexture * &gt;</summary>
		public const int AdditionalSourceTextures = 0x0050;

		///<summary>FVector2D</summary>
		public const int BakedSourceUV = 0x0060;

		///<summary>FVector2D</summary>
		public const int BakedSourceDimension = 0x0068;

		///<summary>UTexture2D *</summary>
		public const int BakedSourceTexture = 0x0070;

		///<summary>UMaterialInterface *</summary>
		public const int DefaultMaterial = 0x0078;

		///<summary>UMaterialInterface *</summary>
		public const int AlternateMaterial = 0x0080;

		///<summary>TArray&lt;FPaperSpriteSocket&gt;</summary>
		public const int Sockets = 0x0088;

		///<summary>TEnumAsByte&lt;ESpriteCollisionMode&gt;</summary>
		public const int SpriteCollisionDomain = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0099;

		///<summary>float</summary>
		public const int PixelsPerUnrealUnit = 0x009C;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x00A0;

		///<summary>int</summary>
		public const int AlternateMaterialSplitIndex = 0x00A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00AC;

		///<summary>TArray&lt;FVector4&gt;</summary>
		public const int BakedRenderData = 0x00B0;

	}

	public class APaperSpriteActor
	{
		///<summary>UPaperSpriteComponent *</summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperSpriteComponent
	{
		///<summary>UPaperSprite *</summary>
		public const int SourceSprite = 0x0950;

		///<summary>UMaterialInterface *</summary>
		public const int MaterialOverride = 0x0958;

		///<summary>FLinearColor</summary>
		public const int SpriteColor = 0x0960;

	}

	public class APaperTerrainActor
	{
		///<summary>USceneComponent *</summary>
		public const int DummyRoot = 0x03B0;

		///<summary>UPaperTerrainSplineComponent *</summary>
		public const int SplineComponent = 0x03B8;

		///<summary>UPaperTerrainComponent *</summary>
		public const int RenderComponent = 0x03C0;

	}

	public class UPaperTerrainComponent
	{
		///<summary>bool</summary>
		public const int bClosedSpline = 0x0850;

		///<summary>bool</summary>
		public const int bFilledSpline = 0x0851;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x0852;

		///<summary>UPaperTerrainSplineComponent *</summary>
		public const int AssociatedSpline = 0x0858;

		///<summary>int</summary>
		public const int RandomSeed = 0x0860;

		///<summary>float</summary>
		public const int SegmentOverlapAmount = 0x0864;

		///<summary>FLinearColor</summary>
		public const int TerrainColor = 0x0868;

		///<summary>int</summary>
		public const int ReparamStepsPerSegment = 0x0878;

		///<summary>TEnumAsByte&lt;ESpriteCollisionMode&gt;</summary>
		public const int SpriteCollisionDomain = 0x087C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x087D;

		///<summary>float</summary>
		public const int CollisionThickness = 0x0880;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0884;

		///<summary>UBodySetup *</summary>
		public const int CachedBodySetup = 0x0888;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData03 = 0x0890;

	}

	public class UPaperTerrainMaterial
	{
		///<summary>TArray&lt;FPaperTerrainMaterialRule&gt;</summary>
		public const int Rules = 0x0030;

		///<summary>UPaperSprite *</summary>
		public const int InteriorFill = 0x0040;

	}

	public class UPaperTerrainSplineComponent
	{
		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData00 = 0x0930;

	}

	public class UPaperTileLayer
	{
		///<summary>FText</summary>
		public const int LayerName = 0x0028;

		///<summary>int</summary>
		public const int LayerWidth = 0x0040;

		///<summary>int</summary>
		public const int LayerHeight = 0x0044;

		///<summary>unsigned char:1</summary>
		public const int bHiddenInGame = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bLayerCollides = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bOverrideCollisionThickness = 0x0048;

		///<summary>unsigned char:1</summary>
		public const int bOverrideCollisionOffset = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>float</summary>
		public const int CollisionThicknessOverride = 0x004C;

		///<summary>float</summary>
		public const int CollisionOffsetOverride = 0x0050;

		///<summary>FLinearColor</summary>
		public const int LayerColor = 0x0054;

		///<summary>int</summary>
		public const int AllocatedWidth = 0x0064;

		///<summary>int</summary>
		public const int AllocatedHeight = 0x0068;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x006C;

		///<summary>TArray&lt;FPaperTileInfo&gt;</summary>
		public const int AllocatedCells = 0x0070;

		///<summary>UPaperTileSet *</summary>
		public const int TileSet = 0x0080;

		///<summary>TArray&lt;int&gt;</summary>
		public const int AllocatedGrid = 0x0088;

	}

	public class UPaperTileMap
	{
		///<summary>int</summary>
		public const int MapWidth = 0x0028;

		///<summary>int</summary>
		public const int MapHeight = 0x002C;

		///<summary>int</summary>
		public const int TileWidth = 0x0030;

		///<summary>int</summary>
		public const int TileHeight = 0x0034;

		///<summary>float</summary>
		public const int PixelsPerUnrealUnit = 0x0038;

		///<summary>float</summary>
		public const int SeparationPerTileX = 0x003C;

		///<summary>float</summary>
		public const int SeparationPerTileY = 0x0040;

		///<summary>float</summary>
		public const int SeparationPerLayer = 0x0044;

		///<summary>TAssetPtr&lt;UPaperTileSet&gt;</summary>
		public const int SelectedTileSet = 0x0048;

		///<summary>UMaterialInterface *</summary>
		public const int Material = 0x0068;

		///<summary>TArray&lt;UPaperTileLayer * &gt;</summary>
		public const int TileLayers = 0x0070;

		///<summary>float</summary>
		public const int CollisionThickness = 0x0080;

		///<summary>TEnumAsByte&lt;ESpriteCollisionMode&gt;</summary>
		public const int SpriteCollisionDomain = 0x0084;

		///<summary>TEnumAsByte&lt;ETileMapProjectionMode&gt;</summary>
		public const int ProjectionMode = 0x0085;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0086;

		///<summary>int</summary>
		public const int HexSideLength = 0x0088;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x008C;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x0090;

		///<summary>int</summary>
		public const int LayerNameIndex = 0x0098;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x009C;

	}

	public class APaperTileMapActor
	{
		///<summary>UPaperTileMapComponent *</summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperTileMapComponent
	{
		///<summary>int</summary>
		public const int MapWidth = 0x0950;

		///<summary>int</summary>
		public const int MapHeight = 0x0954;

		///<summary>int</summary>
		public const int TileWidth = 0x0958;

		///<summary>int</summary>
		public const int TileHeight = 0x095C;

		///<summary>UPaperTileSet *</summary>
		public const int DefaultLayerTileSet = 0x0960;

		///<summary>UMaterialInterface *</summary>
		public const int Material = 0x0968;

		///<summary>TArray&lt;UPaperTileLayer * &gt;</summary>
		public const int TileLayers = 0x0970;

		///<summary>FLinearColor</summary>
		public const int TileMapColor = 0x0980;

		///<summary>int</summary>
		public const int UseSingleLayerIndex = 0x0990;

		///<summary>bool</summary>
		public const int bUseSingleLayer = 0x0994;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0995;

		///<summary>UPaperTileMap *</summary>
		public const int TileMap = 0x0998;

	}

	public class UPaperTileSet
	{
		///<summary>FIntPoint</summary>
		public const int TileSize = 0x0028;

		///<summary>UTexture2D *</summary>
		public const int TileSheet = 0x0030;

		///<summary>FIntMargin</summary>
		public const int BorderMargin = 0x0038;

		///<summary>FIntPoint</summary>
		public const int PerTileSpacing = 0x0048;

		///<summary>FIntPoint</summary>
		public const int DrawingOffset = 0x0050;

		///<summary>int</summary>
		public const int WidthInTiles = 0x0058;

		///<summary>int</summary>
		public const int HeightInTiles = 0x005C;

		///<summary>int</summary>
		public const int AllocatedWidth = 0x0060;

		///<summary>int</summary>
		public const int AllocatedHeight = 0x0064;

		///<summary>TArray&lt;FPaperTileMetadata&gt;</summary>
		public const int PerTileData = 0x0068;

		///<summary>TArray&lt;FPaperTileSetTerrain&gt;</summary>
		public const int Terrains = 0x0078;

		///<summary>int</summary>
		public const int TileWidth = 0x0088;

		///<summary>int</summary>
		public const int TileHeight = 0x008C;

		///<summary>int</summary>
		public const int Margin = 0x0090;

		///<summary>int</summary>
		public const int Spacing = 0x0094;

	}

}
