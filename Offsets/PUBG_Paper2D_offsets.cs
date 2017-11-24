/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMaterialExpressionSpriteTextureSampler
	{
		public const int bSampleAdditionalTextures = 0x01B8;
		public const int UnknownData00 = 0x01B9;
		public const int AdditionalSlotIndex = 0x01BC;
		public const int SlotDisplayName = 0x01C0;
	}

	public class APaperCharacter
	{
		public const int Sprite = 0x07C0;
		public const int UnknownData00 = 0x07C8;
	}

	public class UPaperSprite
	{
		public const int UnknownData00 = 0x0028;
		public const int SourceUV = 0x0038;
		public const int SourceDimension = 0x0040;
		public const int SourceTexture = 0x0048;
		public const int AdditionalSourceTextures = 0x0050;
		public const int BakedSourceUV = 0x0060;
		public const int BakedSourceDimension = 0x0068;
		public const int BakedSourceTexture = 0x0070;
		public const int DefaultMaterial = 0x0078;
		public const int AlternateMaterial = 0x0080;
		public const int Sockets = 0x0088;
		public const int SpriteCollisionDomain = 0x0098;
		public const int UnknownData01 = 0x0099;
		public const int PixelsPerUnrealUnit = 0x009C;
		public const int BodySetup = 0x00A0;
		public const int AlternateMaterialSplitIndex = 0x00A8;
		public const int UnknownData02 = 0x00AC;
		public const int BakedRenderData = 0x00B0;
	}

	public class UPaperFlipbook
	{
		public const int FramesPerSecond = 0x0028;
		public const int UnknownData00 = 0x002C;
		public const int KeyFrames = 0x0030;
		public const int DefaultMaterial = 0x0040;
		public const int CollisionSource = 0x0048;
		public const int UnknownData01 = 0x0049;
	}

	public class UPaperFlipbookComponent
	{
		public const int SourceFlipbook = 0x0780;
		public const int Material = 0x0788;
		public const int PlayRate = 0x0790;
		public const int bLooping = 0x0794;
		public const int bReversePlayback = 0x0794;
		public const int bPlaying = 0x0794;
		public const int UnknownData00 = 0x0795;
		public const int AccumulatedTime = 0x0798;
		public const int CachedFrameIndex = 0x079C;
		public const int SpriteColor = 0x07A0;
		public const int CachedBodySetup = 0x07B0;
		public const int OnFinishedPlaying = 0x07B8;
		public const int UnknownData01 = 0x07C8;
	}

	public class APaperFlipbookActor
	{
		public const int RenderComponent = 0x03A0;
	}

	public class UPaperGroupedSpriteComponent
	{
		public const int InstanceMaterials = 0x0780;
		public const int PerInstanceSpriteData = 0x0790;
		public const int UnknownData00 = 0x07A0;
	}

	public class APaperGroupedSpriteActor
	{
		public const int RenderComponent = 0x03A0;
	}

	public class UPaperRuntimeSettings
	{
		public const int bEnableSpriteAtlasGroups = 0x0028;
		public const int bEnableTerrainSplineEditing = 0x0029;
		public const int bResizeSpriteDataToMatchTextures = 0x002A;
		public const int UnknownData00 = 0x002B;
	}

	public class UPaperSpriteComponent
	{
		public const int SourceSprite = 0x0780;
		public const int MaterialOverride = 0x0788;
		public const int SpriteColor = 0x0790;
	}

	public class APaperSpriteActor
	{
		public const int RenderComponent = 0x03A0;
	}

	public class APaperTerrainActor
	{
		public const int DummyRoot = 0x03A0;
		public const int SplineComponent = 0x03A8;
		public const int RenderComponent = 0x03B0;
	}

	public class UPaperTerrainComponent
	{
		public const int bClosedSpline = 0x06D0;
		public const int bFilledSpline = 0x06D1;
		public const int UnknownData00 = 0x06D2;
		public const int AssociatedSpline = 0x06D8;
		public const int RandomSeed = 0x06E0;
		public const int SegmentOverlapAmount = 0x06E4;
		public const int TerrainColor = 0x06E8;
		public const int ReparamStepsPerSegment = 0x06F8;
		public const int SpriteCollisionDomain = 0x06FC;
		public const int UnknownData01 = 0x06FD;
		public const int CollisionThickness = 0x0700;
		public const int UnknownData02 = 0x0704;
		public const int CachedBodySetup = 0x0708;
		public const int UnknownData03 = 0x0710;
	}

	public class UPaperTerrainMaterial
	{
		public const int Rules = 0x0028;
		public const int InteriorFill = 0x0038;
	}

	public class UPaperTerrainSplineComponent
	{
		public const int UnknownData00 = 0x07B0;
	}

	public class UPaperTileSet
	{
		public const int TileSize = 0x0028;
		public const int TileSheet = 0x0030;
		public const int BorderMargin = 0x0038;
		public const int PerTileSpacing = 0x0048;
		public const int DrawingOffset = 0x0050;
		public const int WidthInTiles = 0x0058;
		public const int HeightInTiles = 0x005C;
		public const int AllocatedWidth = 0x0060;
		public const int AllocatedHeight = 0x0064;
		public const int PerTileData = 0x0068;
		public const int Terrains = 0x0078;
		public const int TileWidth = 0x0088;
		public const int TileHeight = 0x008C;
		public const int Margin = 0x0090;
		public const int Spacing = 0x0094;
	}

	public class UPaperTileLayer
	{
		public const int LayerName = 0x0028;
		public const int LayerWidth = 0x0040;
		public const int LayerHeight = 0x0044;
		public const int bHiddenInGame = 0x0048;
		public const int bLayerCollides = 0x0048;
		public const int bOverrideCollisionThickness = 0x0048;
		public const int bOverrideCollisionOffset = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int CollisionThicknessOverride = 0x004C;
		public const int CollisionOffsetOverride = 0x0050;
		public const int LayerColor = 0x0054;
		public const int AllocatedWidth = 0x0064;
		public const int AllocatedHeight = 0x0068;
		public const int UnknownData01 = 0x006C;
		public const int AllocatedCells = 0x0070;
		public const int TileSet = 0x0080;
		public const int AllocatedGrid = 0x0088;
	}

	public class UPaperTileMap
	{
		public const int MapWidth = 0x0028;
		public const int MapHeight = 0x002C;
		public const int TileWidth = 0x0030;
		public const int TileHeight = 0x0034;
		public const int PixelsPerUnrealUnit = 0x0038;
		public const int SeparationPerTileX = 0x003C;
		public const int SeparationPerTileY = 0x0040;
		public const int SeparationPerLayer = 0x0044;
		public const int SelectedTileSet = 0x0048;
		public const int Material = 0x0068;
		public const int TileLayers = 0x0070;
		public const int CollisionThickness = 0x0080;
		public const int SpriteCollisionDomain = 0x0084;
		public const int ProjectionMode = 0x0085;
		public const int UnknownData00 = 0x0086;
		public const int HexSideLength = 0x0088;
		public const int UnknownData01 = 0x008C;
		public const int BodySetup = 0x0090;
		public const int LayerNameIndex = 0x0098;
		public const int UnknownData02 = 0x009C;
	}

	public class APaperTileMapActor
	{
		public const int RenderComponent = 0x03A0;
	}

	public class UPaperTileMapComponent
	{
		public const int MapWidth = 0x0780;
		public const int MapHeight = 0x0784;
		public const int TileWidth = 0x0788;
		public const int TileHeight = 0x078C;
		public const int DefaultLayerTileSet = 0x0790;
		public const int Material = 0x0798;
		public const int TileLayers = 0x07A0;
		public const int TileMapColor = 0x07B0;
		public const int UseSingleLayerIndex = 0x07C0;
		public const int bUseSingleLayer = 0x07C4;
		public const int UnknownData00 = 0x07C5;
		public const int TileMap = 0x07C8;
	}

}
