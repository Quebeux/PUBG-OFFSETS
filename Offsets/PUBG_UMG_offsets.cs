/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UWidget
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bIsVariable = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bCreatedByConstructionScript = 0x0029;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x002A;

		///<summary><![CDATA[UPanelSlot *]]></summary>
		public const int Slot = 0x0030;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsEnabled = 0x0038;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0039;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int bIsEnabledDelegate = 0x0040;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnPrepass = 0x0050;

		///<summary><![CDATA[FText]]></summary>
		public const int ToolTipText = 0x0060;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ToolTipTextDelegate = 0x0078;

		///<summary><![CDATA[UWidget *]]></summary>
		public const int ToolTipWidget = 0x0088;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ToolTipWidgetDelegate = 0x0090;

		///<summary><![CDATA[TEnumAsByte<ESlateVisibility>]]></summary>
		public const int Visiblity = 0x00A0;

		///<summary><![CDATA[TEnumAsByte<ESlateVisibility>]]></summary>
		public const int Visibility = 0x00A1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData02 = 0x00A2;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int VisibilityDelegate = 0x00A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_Cursor = 0x00B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x00B9;

		///<summary><![CDATA[TEnumAsByte<EMouseCursor>]]></summary>
		public const int Cursor = 0x00BC;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVolatile = 0x00BD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData04 = 0x00BE;

		///<summary><![CDATA[FWidgetTransform]]></summary>
		public const int RenderTransform = 0x00C0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int RenderTransformPivot = 0x00DC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData05 = 0x00E4;

		///<summary><![CDATA[UWidgetNavigation *]]></summary>
		public const int Navigation = 0x00E8;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData06 = 0x00F0;

		///<summary><![CDATA[TArray<UPropertyBinding * >]]></summary>
		public const int NativeBindings = 0x0118;

	}

	public class UUserWidget
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0128;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorAndOpacity = 0x0130;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ColorAndOpacityDelegate = 0x0140;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int ForegroundColor = 0x0150;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ForegroundColorDelegate = 0x0178;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0188;

		///<summary><![CDATA[bool]]></summary>
		public const int bSupportsKeyboardFocus = 0x0198;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFocusable = 0x0199;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x019A;

		///<summary><![CDATA[UWidgetTree *]]></summary>
		public const int WidgetTree = 0x01A0;

		///<summary><![CDATA[TArray<UUMGSequencePlayer * >]]></summary>
		public const int ActiveSequencePlayers = 0x01A8;

		///<summary><![CDATA[TArray<UUMGSequencePlayer * >]]></summary>
		public const int StoppedSequencePlayers = 0x01B8;

		///<summary><![CDATA[TArray<FNamedSlotBinding>]]></summary>
		public const int NamedSlotBindings = 0x01C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bStopAction = 0x01D8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x01D9;

		///<summary><![CDATA[int]]></summary>
		public const int Priority = 0x01DC;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x01E0;

		///<summary><![CDATA[UInputComponent *]]></summary>
		public const int InputComponent = 0x01E8;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData04 = 0x01F0;

	}

	public class UAsyncTaskDownloadImage
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSuccess = 0x0028;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnFail = 0x0038;

	}

	public class UDragDropOperation
	{
		///<summary><![CDATA[FString]]></summary>
		public const int Tag = 0x0028;

		///<summary><![CDATA[UObject *]]></summary>
		public const int payload = 0x0038;

		///<summary><![CDATA[UWidget *]]></summary>
		public const int DefaultDragVisual = 0x0040;

		///<summary><![CDATA[TEnumAsByte<EDragPivot>]]></summary>
		public const int Pivot = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int Offset = 0x004C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0054;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDrop = 0x0058;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDragCancelled = 0x0068;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDragged = 0x0078;

	}

	public class UMovieScene2DTransformSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FRichCurve[0x2]]]></summary>
		public const int Translation = 0x0048;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int Rotation = 0x0138;

		///<summary><![CDATA[FRichCurve[0x2]]]></summary>
		public const int Scale = 0x01B0;

		///<summary><![CDATA[FRichCurve[0x2]]]></summary>
		public const int Shear = 0x02A0;

	}

	public class UMovieSceneMarginSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int TopCurve = 0x0048;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int LeftCurve = 0x00C0;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int RightCurve = 0x0138;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int BottomCurve = 0x01B0;

	}

	public class UMovieSceneWidgetMaterialTrack
	{
		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int BrushPropertyNamePath = 0x0038;

		///<summary><![CDATA[FName]]></summary>
		public const int TrackName = 0x0048;

	}

	public class UPropertyBinding
	{
		///<summary><![CDATA[TWeakObjectPtr<UObject>]]></summary>
		public const int SourceObject = 0x0028;

		///<summary><![CDATA[FDynamicPropertyPath]]></summary>
		public const int SourcePath = 0x0030;

		///<summary><![CDATA[FName]]></summary>
		public const int DestinationProperty = 0x0040;

	}

	public class UBrushBinding
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UCheckedStateBinding
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UColorBinding
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UTextBinding
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class URichTextBlockDecorator
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bReveal = 0x0028;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0029;

		///<summary><![CDATA[int]]></summary>
		public const int RevealedIndex = 0x002C;

	}

	public class USlateDataSheet
	{
		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int DataTexture = 0x0028;

		///<summary><![CDATA[unsigned char[0x400]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class USlateVectorArtData
	{
		///<summary><![CDATA[TArray<FSlateMeshVertex>]]></summary>
		public const int VertexData = 0x0028;

		///<summary><![CDATA[TArray<uint32_t>]]></summary>
		public const int IndexData = 0x0038;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int Material = 0x0048;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ExtentMin = 0x0050;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ExtentMax = 0x0058;

	}

	public class UUMGSequencePlayer
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UWidgetAnimation *]]></summary>
		public const int Animation = 0x0048;

		///<summary><![CDATA[unsigned char[0x150]]]></summary>
		public const int UnknownData01 = 0x0050;

	}

	public class UPanelSlot
	{
		///<summary><![CDATA[UPanelWidget *]]></summary>
		public const int Parent = 0x0028;

		///<summary><![CDATA[UWidget *]]></summary>
		public const int Content = 0x0030;

	}

	public class UBorderSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0x16]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UButtonSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0x16]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UCanvasPanelSlot
	{
		///<summary><![CDATA[FAnchorData]]></summary>
		public const int LayoutData = 0x0038;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoSize = 0x0060;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0061;

		///<summary><![CDATA[int]]></summary>
		public const int ZOrder = 0x0064;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0068;

	}

	public class UGridSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x004A;

		///<summary><![CDATA[int]]></summary>
		public const int Row = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int RowSpan = 0x0050;

		///<summary><![CDATA[int]]></summary>
		public const int Column = 0x0054;

		///<summary><![CDATA[int]]></summary>
		public const int ColumnSpan = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int Layer = 0x005C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int Nudge = 0x0060;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0068;

	}

	public class UHorizontalBoxSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[FSlateChildSize]]></summary>
		public const int Size = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0050;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0051;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData00 = 0x0052;

	}

	public class UOverlaySlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class USafeZoneSlot
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bIsTitleSafe = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0039;

		///<summary><![CDATA[FMargin]]></summary>
		public const int SafeAreaScale = 0x003C;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HAlign = 0x004C;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VAlign = 0x004D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x004E;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0050;

	}

	public class UScaleBoxSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0x16]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UScrollBoxSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x0049;

	}

	public class USizeBoxSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0x16]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UUniformGridSlot
	{
		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0039;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x003A;

		///<summary><![CDATA[int]]></summary>
		public const int Row = 0x003C;

		///<summary><![CDATA[int]]></summary>
		public const int Column = 0x0040;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UVerticalBoxSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[FSlateChildSize]]></summary>
		public const int Size = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0050;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0051;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData00 = 0x0052;

	}

	public class UWidgetSwitcherSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UWindowTitleBarAreaSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0049;

		///<summary><![CDATA[unsigned char[0x16]]]></summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UWrapBoxSlot
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0038;

		///<summary><![CDATA[bool]]></summary>
		public const int bFillEmptySpace = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[float]]></summary>
		public const int FillSpanWhenLessThan = 0x004C;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0050;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0051;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData01 = 0x0052;

	}

	public class UCircularThrobber
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumberOfPieces = 0x0128;

		///<summary><![CDATA[float]]></summary>
		public const int Period = 0x012C;

		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x0130;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0134;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int PieceImage = 0x0138;

		///<summary><![CDATA[FSlateBrush]]></summary>
		public const int Image = 0x0140;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableRadius = 0x01D0;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData01 = 0x01D1;

	}

	public class UComboBox
	{
		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int Items = 0x0128;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnGenerateWidgetEvent = 0x0138;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0148;

	}

	public class UComboBoxString
	{
		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int DefaultOptions = 0x0128;

		///<summary><![CDATA[FString]]></summary>
		public const int SelectedOption = 0x0138;

		///<summary><![CDATA[FComboBoxStyle]]></summary>
		public const int WidgetStyle = 0x0148;

		///<summary><![CDATA[FTableRowStyle]]></summary>
		public const int ItemStyle = 0x0570;

		///<summary><![CDATA[FMargin]]></summary>
		public const int ContentPadding = 0x0C88;

		///<summary><![CDATA[float]]></summary>
		public const int MaxListHeight = 0x0C98;

		///<summary><![CDATA[bool]]></summary>
		public const int HasDownArrow = 0x0C9C;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableGamepadNavigationMode = 0x0C9D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0C9E;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x0CA0;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int ForegroundColor = 0x0D08;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnGenerateWidgetEvent = 0x0D30;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSelectionChanged = 0x0D40;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnOpening = 0x0D50;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData01 = 0x0D60;

	}

	public class UTextLayoutWidget
	{
		///<summary><![CDATA[FShapedTextOptions]]></summary>
		public const int ShapedTextOptions = 0x0128;

		///<summary><![CDATA[TEnumAsByte<ETextJustify>]]></summary>
		public const int Justification = 0x0130;

		///<summary><![CDATA[bool]]></summary>
		public const int AutoWrapText = 0x0131;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0132;

		///<summary><![CDATA[float]]></summary>
		public const int WrapTextAt = 0x0134;

		///<summary><![CDATA[TEnumAsByte<ETextWrappingPolicy>]]></summary>
		public const int WrappingPolicy = 0x0138;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0139;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Margin = 0x013C;

		///<summary><![CDATA[float]]></summary>
		public const int LineHeightPercentage = 0x014C;

	}

	public class UEditableText
	{
		///<summary><![CDATA[FText]]></summary>
		public const int Text = 0x0128;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int TextDelegate = 0x0140;

		///<summary><![CDATA[FText]]></summary>
		public const int HintText = 0x0150;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int HintTextDelegate = 0x0168;

		///<summary><![CDATA[FEditableTextStyle]]></summary>
		public const int WidgetStyle = 0x0178;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x03C0;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int BackgroundImageSelected = 0x03C8;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int BackgroundImageComposing = 0x03D0;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int CaretImage = 0x03D8;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x03E0;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int ColorAndOpacity = 0x0448;

		///<summary><![CDATA[bool]]></summary>
		public const int IsReadOnly = 0x0470;

		///<summary><![CDATA[bool]]></summary>
		public const int IsPassword = 0x0471;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0472;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumDesiredWidth = 0x0474;

		///<summary><![CDATA[bool]]></summary>
		public const int IsCaretMovedWhenGainFocus = 0x0478;

		///<summary><![CDATA[bool]]></summary>
		public const int SelectAllTextWhenFocused = 0x0479;

		///<summary><![CDATA[bool]]></summary>
		public const int RevertTextOnEscape = 0x047A;

		///<summary><![CDATA[bool]]></summary>
		public const int ClearKeyboardFocusOnCommit = 0x047B;

		///<summary><![CDATA[bool]]></summary>
		public const int SelectAllTextOnCommit = 0x047C;

		///<summary><![CDATA[bool]]></summary>
		public const int AllowContextMenu = 0x047D;

		///<summary><![CDATA[TEnumAsByte<EVirtualKeyboardType>]]></summary>
		public const int KeyboardType = 0x047E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x047F;

		///<summary><![CDATA[FShapedTextOptions]]></summary>
		public const int ShapedTextOptions = 0x0480;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextChanged = 0x0488;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextCommitted = 0x0498;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x04A8;

	}

	public class UEditableTextBox
	{
		///<summary><![CDATA[FText]]></summary>
		public const int Text = 0x0128;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int TextDelegate = 0x0140;

		///<summary><![CDATA[FEditableTextBoxStyle]]></summary>
		public const int WidgetStyle = 0x0150;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x09C0;

		///<summary><![CDATA[FText]]></summary>
		public const int HintText = 0x09C8;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int HintTextDelegate = 0x09E0;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x09F0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ForegroundColor = 0x0A58;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BackgroundColor = 0x0A68;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ReadOnlyForegroundColor = 0x0A78;

		///<summary><![CDATA[bool]]></summary>
		public const int IsReadOnly = 0x0A88;

		///<summary><![CDATA[bool]]></summary>
		public const int IsPassword = 0x0A89;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0A8A;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumDesiredWidth = 0x0A8C;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0A90;

		///<summary><![CDATA[bool]]></summary>
		public const int IsCaretMovedWhenGainFocus = 0x0AA0;

		///<summary><![CDATA[bool]]></summary>
		public const int SelectAllTextWhenFocused = 0x0AA1;

		///<summary><![CDATA[bool]]></summary>
		public const int RevertTextOnEscape = 0x0AA2;

		///<summary><![CDATA[bool]]></summary>
		public const int ClearKeyboardFocusOnCommit = 0x0AA3;

		///<summary><![CDATA[bool]]></summary>
		public const int SelectAllTextOnCommit = 0x0AA4;

		///<summary><![CDATA[bool]]></summary>
		public const int AllowContextMenu = 0x0AA5;

		///<summary><![CDATA[TEnumAsByte<EVirtualKeyboardType>]]></summary>
		public const int KeyboardType = 0x0AA6;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x0AA7;

		///<summary><![CDATA[FShapedTextOptions]]></summary>
		public const int ShapedTextOptions = 0x0AA8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextChanged = 0x0AB0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextCommitted = 0x0AC0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0AD0;

	}

	public class UExpandableArea
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0128;

		///<summary><![CDATA[FExpandableAreaStyle]]></summary>
		public const int Style = 0x0130;

		///<summary><![CDATA[FSlateBrush]]></summary>
		public const int BorderBrush = 0x0258;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int BorderColor = 0x02E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsExpanded = 0x0310;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0311;

		///<summary><![CDATA[float]]></summary>
		public const int MaxHeight = 0x0314;

		///<summary><![CDATA[FMargin]]></summary>
		public const int HeaderPadding = 0x0318;

		///<summary><![CDATA[FMargin]]></summary>
		public const int AreaPadding = 0x0328;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnExpansionChanged = 0x0338;

		///<summary><![CDATA[UWidget *]]></summary>
		public const int HeaderContent = 0x0348;

		///<summary><![CDATA[UWidget *]]></summary>
		public const int BodyContent = 0x0350;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0358;

	}

	public class UImage
	{
		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int Image = 0x0128;

		///<summary><![CDATA[FSlateBrush]]></summary>
		public const int Brush = 0x0130;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int BrushDelegate = 0x01C0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorAndOpacity = 0x01D0;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ColorAndOpacityDelegate = 0x01E0;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnMouseButtonDownEvent = 0x01F0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0200;

	}

	public class UInputKeySelector
	{
		///<summary><![CDATA[FInputChord]]></summary>
		public const int SelectedKey = 0x0128;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x0148;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Margin = 0x01B0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorAndOpacity = 0x01C0;

		///<summary><![CDATA[FText]]></summary>
		public const int KeySelectionText = 0x01D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowModifierKeys = 0x01E8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01E9;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKeySelected = 0x01F0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnIsSelectingKeyChanged = 0x0200;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0210;

	}

	public class UNativeWidgetHost
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0128;

	}

	public class UPanelWidget
	{
		///<summary><![CDATA[TArray<UPanelSlot * >]]></summary>
		public const int Slots = 0x0128;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0138;

	}

	public class UCanvasPanel
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UBorder
	{
		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ContentColorAndOpacity = 0x0140;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ContentColorAndOpacityDelegate = 0x0150;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x0160;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0170;

		///<summary><![CDATA[TEnumAsByte<EVerticalAlignment>]]></summary>
		public const int VerticalAlignment = 0x0171;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x0172;

		///<summary><![CDATA[FSlateBrush]]></summary>
		public const int Background = 0x0178;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int BackgroundDelegate = 0x0208;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BrushColor = 0x0218;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int BrushColorDelegate = 0x0228;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int DesiredSizeScale = 0x0238;

		///<summary><![CDATA[bool]]></summary>
		public const int bShowEffectWhenDisabled = 0x0240;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0241;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnMouseButtonDownEvent = 0x0248;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnMouseButtonUpEvent = 0x0258;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnMouseMoveEvent = 0x0268;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnMouseDoubleClickEvent = 0x0278;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0288;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int Brush = 0x0298;

	}

	public class UButton
	{
		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x0140;

		///<summary><![CDATA[FButtonStyle]]></summary>
		public const int WidgetStyle = 0x0148;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorAndOpacity = 0x03F0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BackgroundColor = 0x0400;

		///<summary><![CDATA[TEnumAsByte<EButtonClickMethod>]]></summary>
		public const int ClickMethod = 0x0410;

		///<summary><![CDATA[TEnumAsByte<EButtonTouchMethod>]]></summary>
		public const int TouchMethod = 0x0411;

		///<summary><![CDATA[bool]]></summary>
		public const int IsFocusable = 0x0412;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x0413;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnClicked = 0x0418;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPressed = 0x0428;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnReleased = 0x0438;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnHovered = 0x0448;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnUnhovered = 0x0458;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0468;

	}

	public class UCheckBox
	{
		///<summary><![CDATA[TEnumAsByte<ECheckBoxState>]]></summary>
		public const int CheckedState = 0x0140;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0141;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int CheckedStateDelegate = 0x0148;

		///<summary><![CDATA[FCheckBoxStyle]]></summary>
		public const int WidgetStyle = 0x0158;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x0738;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int UncheckedImage = 0x0740;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int UncheckedHoveredImage = 0x0748;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int UncheckedPressedImage = 0x0750;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int CheckedImage = 0x0758;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int CheckedHoveredImage = 0x0760;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int CheckedPressedImage = 0x0768;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int UndeterminedImage = 0x0770;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int UndeterminedHoveredImage = 0x0778;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int UndeterminedPressedImage = 0x0780;

		///<summary><![CDATA[TEnumAsByte<EHorizontalAlignment>]]></summary>
		public const int HorizontalAlignment = 0x0788;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0789;

		///<summary><![CDATA[FMargin]]></summary>
		public const int Padding = 0x078C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x079C;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int BorderBackgroundColor = 0x07A0;

		///<summary><![CDATA[bool]]></summary>
		public const int IsFocusable = 0x07C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x07C9;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCheckStateChanged = 0x07D0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData04 = 0x07E0;

	}

	public class UInvalidationBox
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bCanCache = 0x0140;

		///<summary><![CDATA[bool]]></summary>
		public const int CacheRelativeTransforms = 0x0141;

		///<summary><![CDATA[unsigned char[0x16]]]></summary>
		public const int UnknownData00 = 0x0142;

	}

	public class UMenuAnchor
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int MenuClass = 0x0140;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnGetMenuContentEvent = 0x0148;

		///<summary><![CDATA[TEnumAsByte<EMenuPlacement>]]></summary>
		public const int Placement = 0x0158;

		///<summary><![CDATA[bool]]></summary>
		public const int ShouldDeferPaintingAfterWindowContent = 0x0159;

		///<summary><![CDATA[bool]]></summary>
		public const int UseApplicationMenuStack = 0x015A;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x015B;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMenuOpenChanged = 0x0160;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0170;

	}

	public class UNamedSlot
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0140;

	}

	public class URetainerBox
	{
		///<summary><![CDATA[int]]></summary>
		public const int Phase = 0x0140;

		///<summary><![CDATA[int]]></summary>
		public const int PhaseCount = 0x0144;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int EffectMaterial = 0x0148;

		///<summary><![CDATA[FName]]></summary>
		public const int TextureParameter = 0x0150;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0158;

	}

	public class USafeZone
	{
		///<summary><![CDATA[bool]]></summary>
		public const int PadLeft = 0x0140;

		///<summary><![CDATA[bool]]></summary>
		public const int PadRight = 0x0141;

		///<summary><![CDATA[bool]]></summary>
		public const int PadTop = 0x0142;

		///<summary><![CDATA[bool]]></summary>
		public const int PadBottom = 0x0143;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData00 = 0x0144;

	}

	public class UScaleBox
	{
		///<summary><![CDATA[TEnumAsByte<EStretch>]]></summary>
		public const int Stretch = 0x0140;

		///<summary><![CDATA[TEnumAsByte<EStretchDirection>]]></summary>
		public const int StretchDirection = 0x0141;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0142;

		///<summary><![CDATA[float]]></summary>
		public const int UserSpecifiedScale = 0x0144;

		///<summary><![CDATA[bool]]></summary>
		public const int IgnoreInheritedScale = 0x0148;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData01 = 0x0149;

	}

	public class USizeBox
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_WidthOverride = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_HeightOverride = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MinDesiredWidth = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MinDesiredHeight = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MaxDesiredWidth = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MaxDesiredHeight = 0x0140;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MaxAspectRatio = 0x0140;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0141;

		///<summary><![CDATA[float]]></summary>
		public const int WidthOverride = 0x0144;

		///<summary><![CDATA[float]]></summary>
		public const int HeightOverride = 0x0148;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredWidth = 0x014C;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredHeight = 0x0150;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDesiredWidth = 0x0154;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDesiredHeight = 0x0158;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAspectRatio = 0x015C;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0160;

	}

	public class UViewport
	{
		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BackgroundColor = 0x0140;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0150;

	}

	public class UWindowTitleBarArea
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bDoubleClickTogglesFullscreen = 0x0140;

		///<summary><![CDATA[unsigned char[0x1F]]]></summary>
		public const int UnknownData00 = 0x0141;

	}

	public class UGridPanel
	{
		///<summary><![CDATA[TArray<float>]]></summary>
		public const int ColumnFill = 0x0140;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int RowFill = 0x0150;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0160;

	}

	public class UHorizontalBox
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UOverlay
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UScrollBox
	{
		///<summary><![CDATA[FScrollBoxStyle]]></summary>
		public const int WidgetStyle = 0x0140;

		///<summary><![CDATA[FScrollBarStyle]]></summary>
		public const int WidgetBarStyle = 0x0388;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x08A0;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int BarStyle = 0x08A8;

		///<summary><![CDATA[TEnumAsByte<EOrientation>]]></summary>
		public const int Orientation = 0x08B0;

		///<summary><![CDATA[TEnumAsByte<ESlateVisibility>]]></summary>
		public const int ScrollBarVisibility = 0x08B1;

		///<summary><![CDATA[TEnumAsByte<EConsumeMouseWheel>]]></summary>
		public const int ConsumeMouseWheel = 0x08B2;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x08B3;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ScrollbarThickness = 0x08B4;

		///<summary><![CDATA[bool]]></summary>
		public const int AlwaysShowScrollbar = 0x08BC;

		///<summary><![CDATA[unsigned char[0x1B]]]></summary>
		public const int UnknownData01 = 0x08BD;

	}

	public class UUniformGridPanel
	{
		///<summary><![CDATA[FMargin]]></summary>
		public const int SlotPadding = 0x0140;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredSlotWidth = 0x0150;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredSlotHeight = 0x0154;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0158;

	}

	public class UVerticalBox
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UWidgetSwitcher
	{
		///<summary><![CDATA[int]]></summary>
		public const int ActiveWidgetIndex = 0x0140;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData00 = 0x0144;

	}

	public class UWrapBox
	{
		///<summary><![CDATA[FVector2D]]></summary>
		public const int InnerSlotPadding = 0x0140;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0148;

	}

	public class UProgressBar
	{
		///<summary><![CDATA[FProgressBarStyle]]></summary>
		public const int WidgetStyle = 0x0128;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x02E0;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int BackgroundImage = 0x02E8;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int FillImage = 0x02F0;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int MarqueeImage = 0x02F8;

		///<summary><![CDATA[float]]></summary>
		public const int Percent = 0x0300;

		///<summary><![CDATA[TEnumAsByte<EProgressBarFillType>]]></summary>
		public const int BarFillType = 0x0304;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsMarquee = 0x0305;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0306;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int PercentDelegate = 0x0308;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int FillColorAndOpacity = 0x0318;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int FillColorAndOpacityDelegate = 0x0328;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0338;

	}

	public class UScrollBar
	{
		///<summary><![CDATA[FScrollBarStyle]]></summary>
		public const int WidgetStyle = 0x0128;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x0640;

		///<summary><![CDATA[bool]]></summary>
		public const int bAlwaysShowScrollbar = 0x0648;

		///<summary><![CDATA[TEnumAsByte<EOrientation>]]></summary>
		public const int Orientation = 0x0649;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x064A;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int Thickness = 0x064C;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData01 = 0x0654;

	}

	public class USlider
	{
		///<summary><![CDATA[float]]></summary>
		public const int Value = 0x0128;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x012C;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ValueDelegate = 0x0130;

		///<summary><![CDATA[FSliderStyle]]></summary>
		public const int WidgetStyle = 0x0140;

		///<summary><![CDATA[TEnumAsByte<EOrientation>]]></summary>
		public const int Orientation = 0x0390;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0391;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SliderBarColor = 0x0394;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SliderHandleColor = 0x03A4;

		///<summary><![CDATA[bool]]></summary>
		public const int IndentHandle = 0x03B4;

		///<summary><![CDATA[bool]]></summary>
		public const int Locked = 0x03B5;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x03B6;

		///<summary><![CDATA[float]]></summary>
		public const int StepSize = 0x03B8;

		///<summary><![CDATA[bool]]></summary>
		public const int IsFocusable = 0x03BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x03BD;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMouseCaptureBegin = 0x03C0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMouseCaptureEnd = 0x03D0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnControllerCaptureBegin = 0x03E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnControllerCaptureEnd = 0x03F0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnValueChanged = 0x0400;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData04 = 0x0410;

	}

	public class USpacer
	{
		///<summary><![CDATA[FVector2D]]></summary>
		public const int Size = 0x0128;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0130;

	}

	public class USpinBox
	{
		///<summary><![CDATA[float]]></summary>
		public const int Value = 0x0128;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x012C;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ValueDelegate = 0x0130;

		///<summary><![CDATA[FSpinBoxStyle]]></summary>
		public const int WidgetStyle = 0x0140;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int Delta = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int SliderExponent = 0x045C;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredWidth = 0x04C8;

		///<summary><![CDATA[bool]]></summary>
		public const int ClearKeyboardFocusOnCommit = 0x04CC;

		///<summary><![CDATA[bool]]></summary>
		public const int SelectAllTextOnCommit = 0x04CD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x04CE;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int ForegroundColor = 0x04D0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnValueChanged = 0x04F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnValueCommitted = 0x0508;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnBeginSliderMovement = 0x0518;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEndSliderMovement = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MinValue = 0x0538;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MaxValue = 0x0538;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MinSliderValue = 0x0538;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverride_MaxSliderValue = 0x0538;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0539;

		///<summary><![CDATA[float]]></summary>
		public const int MinValue = 0x053C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxValue = 0x0540;

		///<summary><![CDATA[float]]></summary>
		public const int MinSliderValue = 0x0544;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSliderValue = 0x0548;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData03 = 0x054C;

	}

	public class UListView
	{
		///<summary><![CDATA[float]]></summary>
		public const int ItemHeight = 0x0128;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x012C;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int Items = 0x0130;

		///<summary><![CDATA[TEnumAsByte<ESelectionMode>]]></summary>
		public const int SelectionMode = 0x0140;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0141;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnGenerateRowEvent = 0x0148;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0158;

	}

	public class UTileView
	{
		///<summary><![CDATA[float]]></summary>
		public const int ItemWidth = 0x0128;

		///<summary><![CDATA[float]]></summary>
		public const int ItemHeight = 0x012C;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int Items = 0x0130;

		///<summary><![CDATA[TEnumAsByte<ESelectionMode>]]></summary>
		public const int SelectionMode = 0x0140;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0141;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnGenerateTileEvent = 0x0148;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0158;

	}

	public class UMultiLineEditableText
	{
		///<summary><![CDATA[FText]]></summary>
		public const int Text = 0x0150;

		///<summary><![CDATA[FText]]></summary>
		public const int HintText = 0x0168;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int HintTextDelegate = 0x0180;

		///<summary><![CDATA[FTextBlockStyle]]></summary>
		public const int WidgetStyle = 0x0190;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x0398;

		///<summary><![CDATA[bool]]></summary>
		public const int AllowContextMenu = 0x0400;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0401;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextChanged = 0x0408;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextCommitted = 0x0418;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0428;

	}

	public class UMultiLineEditableTextBox
	{
		///<summary><![CDATA[FText]]></summary>
		public const int Text = 0x0150;

		///<summary><![CDATA[FText]]></summary>
		public const int HintText = 0x0168;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int HintTextDelegate = 0x0180;

		///<summary><![CDATA[FEditableTextBoxStyle]]></summary>
		public const int WidgetStyle = 0x0190;

		///<summary><![CDATA[FTextBlockStyle]]></summary>
		public const int TextStyle = 0x0A00;

		///<summary><![CDATA[bool]]></summary>
		public const int AllowContextMenu = 0x0C08;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0C09;

		///<summary><![CDATA[USlateWidgetStyleAsset *]]></summary>
		public const int Style = 0x0C10;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x0C18;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ForegroundColor = 0x0C80;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BackgroundColor = 0x0C90;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ReadOnlyForegroundColor = 0x0CA0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextChanged = 0x0CB0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTextCommitted = 0x0CC0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0CD0;

	}

	public class URichTextBlock
	{
		///<summary><![CDATA[FText]]></summary>
		public const int Text = 0x0150;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int TextDelegate = 0x0168;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x0178;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int Color = 0x01E0;

		///<summary><![CDATA[TArray<URichTextBlockDecorator * >]]></summary>
		public const int Decorators = 0x01F0;

		///<summary><![CDATA[unsigned char[0x218]]]></summary>
		public const int UnknownData00 = 0x0200;

	}

	public class UTextBlock
	{
		///<summary><![CDATA[FText]]></summary>
		public const int Text = 0x0150;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int TextDelegate = 0x0168;

		///<summary><![CDATA[FSlateColor]]></summary>
		public const int ColorAndOpacity = 0x0178;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ColorAndOpacityDelegate = 0x01A0;

		///<summary><![CDATA[FSlateFontInfo]]></summary>
		public const int Font = 0x01B0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ShadowOffset = 0x0218;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ShadowColorAndOpacity = 0x0220;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int ShadowColorAndOpacityDelegate = 0x0230;

		///<summary><![CDATA[float]]></summary>
		public const int MinDesiredWidth = 0x0240;

		///<summary><![CDATA[bool]]></summary>
		public const int bWrapWithInvalidationPanel = 0x0244;

		///<summary><![CDATA[unsigned char[0x13]]]></summary>
		public const int UnknownData00 = 0x0245;

	}

	public class UThrobber
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumberOfPieces = 0x0128;

		///<summary><![CDATA[bool]]></summary>
		public const int bAnimateHorizontally = 0x012C;

		///<summary><![CDATA[bool]]></summary>
		public const int bAnimateVertically = 0x012D;

		///<summary><![CDATA[bool]]></summary>
		public const int bAnimateOpacity = 0x012E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x012F;

		///<summary><![CDATA[USlateBrushAsset *]]></summary>
		public const int PieceImage = 0x0130;

		///<summary><![CDATA[FSlateBrush]]></summary>
		public const int Image = 0x0138;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x01C8;

	}

	public class UWidgetTree
	{
		///<summary><![CDATA[UWidget *]]></summary>
		public const int RootWidget = 0x0028;

		///<summary><![CDATA[TArray<UWidget * >]]></summary>
		public const int AllWidgets = 0x0030;

	}

	public class UWidgetAnimation
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnAnimationStarted = 0x0028;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnAnimationFinished = 0x0038;

		///<summary><![CDATA[UMovieScene *]]></summary>
		public const int MovieScene = 0x0048;

		///<summary><![CDATA[TArray<FWidgetAnimationBinding>]]></summary>
		public const int AnimationBindings = 0x0050;

		///<summary><![CDATA[unsigned char[0x148]]]></summary>
		public const int UnknownData00 = 0x0060;

	}

	public class UWidgetBlueprintGeneratedClass
	{
		///<summary><![CDATA[UWidgetTree *]]></summary>
		public const int WidgetTree = 0x02F8;

		///<summary><![CDATA[TArray<FDelegateRuntimeBinding>]]></summary>
		public const int Bindings = 0x0300;

		///<summary><![CDATA[TArray<UWidgetAnimation * >]]></summary>
		public const int Animations = 0x0310;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int NamedSlots = 0x0320;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanEverTick = 0x0330;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCanEverPaint = 0x0330;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0331;

	}

	public class UWidgetComponent
	{
		///<summary><![CDATA[TEnumAsByte<EWidgetSpace>]]></summary>
		public const int Space = 0x0780;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0781;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WidgetClass = 0x0788;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int DrawSize = 0x0790;

		///<summary><![CDATA[bool]]></summary>
		public const int bManuallyRedraw = 0x0798;

		///<summary><![CDATA[bool]]></summary>
		public const int bRedrawRequested = 0x0799;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x079A;

		///<summary><![CDATA[float]]></summary>
		public const int RedrawTime = 0x079C;

		///<summary><![CDATA[float]]></summary>
		public const int LastWidgetRenderTime = 0x07A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bWindowFocusable = 0x07A4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x07A5;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int CurrentDrawSize = 0x07A8;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawAtDesiredSize = 0x07B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x07B1;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int Pivot = 0x07B4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x07BC;

		///<summary><![CDATA[ULocalPlayer *]]></summary>
		public const int OwnerPlayer = 0x07C0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BackgroundColor = 0x07C8;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int TintColorAndOpacity = 0x07D8;

		///<summary><![CDATA[float]]></summary>
		public const int OpacityFromTexture = 0x07E8;

		///<summary><![CDATA[TEnumAsByte<EWidgetBlendMode>]]></summary>
		public const int BlendMode = 0x07EC;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsTwoSided = 0x07ED;

		///<summary><![CDATA[bool]]></summary>
		public const int TickWhenOffscreen = 0x07EE;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData05 = 0x07EF;

		///<summary><![CDATA[UUserWidget *]]></summary>
		public const int Widget = 0x07F0;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData06 = 0x07F8;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x0818;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int TranslucentMaterial = 0x0820;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int TranslucentMaterial_OneSided = 0x0828;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int OpaqueMaterial = 0x0830;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int OpaqueMaterial_OneSided = 0x0838;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MaskedMaterial = 0x0840;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MaskedMaterial_OneSided = 0x0848;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int RenderTarget = 0x0850;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MaterialInstance = 0x0858;

		///<summary><![CDATA[bool]]></summary>
		public const int bAddedToScreen = 0x0860;

		///<summary><![CDATA[bool]]></summary>
		public const int bEditTimeUsable = 0x0861;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData07 = 0x0862;

		///<summary><![CDATA[FName]]></summary>
		public const int SharedLayerName = 0x0868;

		///<summary><![CDATA[int]]></summary>
		public const int LayerZOrder = 0x0870;

		///<summary><![CDATA[unsigned char[0x3C]]]></summary>
		public const int UnknownData08 = 0x0874;

	}

	public class UWidgetInteractionComponent
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnHoveredWidgetChanged = 0x0300;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0310;

		///<summary><![CDATA[int]]></summary>
		public const int VirtualUserIndex = 0x0320;

		///<summary><![CDATA[float]]></summary>
		public const int PointerIndex = 0x0324;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int TraceChannel = 0x0328;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0329;

		///<summary><![CDATA[float]]></summary>
		public const int InteractionDistance = 0x032C;

		///<summary><![CDATA[TEnumAsByte<EWidgetInteractionSource>]]></summary>
		public const int InteractionSource = 0x0330;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableHitTesting = 0x0331;

		///<summary><![CDATA[bool]]></summary>
		public const int bShowDebug = 0x0332;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x0333;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DebugColor = 0x0334;

		///<summary><![CDATA[unsigned char[0x7C]]]></summary>
		public const int UnknownData03 = 0x0344;

		///<summary><![CDATA[FHitResult]]></summary>
		public const int CustomHitResult = 0x03C0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int LocalHitLocation = 0x0448;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int LastLocalHitLocation = 0x0450;

		///<summary><![CDATA[UWidgetComponent *]]></summary>
		public const int HoveredWidgetComponent = 0x0458;

		///<summary><![CDATA[FHitResult]]></summary>
		public const int LastHitResult = 0x0460;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHoveredWidgetInteractable = 0x04E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHoveredWidgetFocusable = 0x04E9;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHoveredWidgetHitTestVisible = 0x04EA;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData04 = 0x04EB;

	}

	public class UWidgetNavigation
	{
		///<summary><![CDATA[FWidgetNavigationData]]></summary>
		public const int Up = 0x0028;

		///<summary><![CDATA[FWidgetNavigationData]]></summary>
		public const int Down = 0x0040;

		///<summary><![CDATA[FWidgetNavigationData]]></summary>
		public const int Left = 0x0058;

		///<summary><![CDATA[FWidgetNavigationData]]></summary>
		public const int Right = 0x0070;

		///<summary><![CDATA[FWidgetNavigationData]]></summary>
		public const int Next = 0x0088;

		///<summary><![CDATA[FWidgetNavigationData]]></summary>
		public const int Previous = 0x00A0;

	}

}
