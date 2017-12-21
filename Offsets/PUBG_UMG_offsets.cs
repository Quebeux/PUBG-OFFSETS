/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UWidget
	{
		///<summary>bool</summary>
		public const int bIsVariable = 0x0028;

		///<summary>bool</summary>
		public const int bCreatedByConstructionScript = 0x0029;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x002A;

		///<summary>UPanelSlot *</summary>
		public const int Slot = 0x0030;

		///<summary>bool</summary>
		public const int bIsEnabled = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0039;

		///<summary>FScriptDelegate</summary>
		public const int bIsEnabledDelegate = 0x0040;

		///<summary>FScriptDelegate</summary>
		public const int OnPrepass = 0x0050;

		///<summary>FText</summary>
		public const int ToolTipText = 0x0060;

		///<summary>FScriptDelegate</summary>
		public const int ToolTipTextDelegate = 0x0078;

		///<summary>UWidget *</summary>
		public const int ToolTipWidget = 0x0088;

		///<summary>FScriptDelegate</summary>
		public const int ToolTipWidgetDelegate = 0x0090;

		///<summary>ESlateVisibility</summary>
		public const int Visiblity = 0x00A0;

		///<summary>ESlateVisibility</summary>
		public const int Visibility = 0x00A1;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData02 = 0x00A2;

		///<summary>FScriptDelegate</summary>
		public const int VisibilityDelegate = 0x00A8;

		///<summary>unsigned char:1</summary>
		public const int bOverride_Cursor = 0x00B8;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x00B9;

		///<summary>TEnumAsByte&lt;EMouseCursor&gt;</summary>
		public const int Cursor = 0x00BC;

		///<summary>bool</summary>
		public const int bIsVolatile = 0x00BD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x00BE;

		///<summary>FWidgetTransform</summary>
		public const int RenderTransform = 0x00C0;

		///<summary>FVector2D</summary>
		public const int RenderTransformPivot = 0x00DC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData05 = 0x00E4;

		///<summary>UWidgetNavigation *</summary>
		public const int Navigation = 0x00E8;

		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData06 = 0x00F0;

		///<summary>TArray&lt;UPropertyBinding * &gt;</summary>
		public const int NativeBindings = 0x0118;

	}

	public class UUserWidget
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0128;

		///<summary>FLinearColor</summary>
		public const int ColorAndOpacity = 0x0130;

		///<summary>FScriptDelegate</summary>
		public const int ColorAndOpacityDelegate = 0x0140;

		///<summary>FSlateColor</summary>
		public const int ForegroundColor = 0x0150;

		///<summary>FScriptDelegate</summary>
		public const int ForegroundColorDelegate = 0x0178;

		///<summary>FMargin</summary>
		public const int Padding = 0x0188;

		///<summary>bool</summary>
		public const int bSupportsKeyboardFocus = 0x0198;

		///<summary>bool</summary>
		public const int bIsFocusable = 0x0199;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData01 = 0x019A;

		///<summary>TArray&lt;UUMGSequencePlayer * &gt;</summary>
		public const int ActiveSequencePlayers = 0x01A0;

		///<summary>TArray&lt;UUMGSequencePlayer * &gt;</summary>
		public const int StoppedSequencePlayers = 0x01B0;

		///<summary>bool</summary>
		public const int bStopAction = 0x01C0;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x01C1;

		///<summary>int</summary>
		public const int Priority = 0x01C4;

		///<summary>TArray&lt;FNamedSlotBinding&gt;</summary>
		public const int NamedSlotBindings = 0x01C8;

		///<summary>UWidgetTree *</summary>
		public const int WidgetTree = 0x01D8;

		///<summary>unsigned char:1</summary>
		public const int bCanEverTick = 0x01E0;

		///<summary>unsigned char:1</summary>
		public const int bCanEverPaint = 0x01E0;

		///<summary>unsigned char:1</summary>
		public const int UnknownData03 = 0x01E0;

		///<summary>unsigned char:1</summary>
		public const int bCookedWidgetTree = 0x01E0;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData04 = 0x01E1;

		///<summary>UInputComponent *</summary>
		public const int InputComponent = 0x01E8;

		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData05 = 0x01F0;

	}

	public class UAsyncTaskDownloadImage
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSuccess = 0x0028;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnFail = 0x0038;

	}

	public class UDragDropOperation
	{
		///<summary>FString</summary>
		public const int Tag = 0x0028;

		///<summary>UObject *</summary>
		public const int payload = 0x0038;

		///<summary>UWidget *</summary>
		public const int DefaultDragVisual = 0x0040;

		///<summary>EDragPivot</summary>
		public const int Pivot = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>FVector2D</summary>
		public const int Offset = 0x004C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x0054;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDrop = 0x0058;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDragCancelled = 0x0068;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnDragged = 0x0078;

	}

	public class UMovieScene2DTransformSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00D0;

		///<summary>FRichCurve[0x2]</summary>
		public const int Translation = 0x00D8;

		///<summary>FRichCurve</summary>
		public const int Rotation = 0x01B8;

		///<summary>FRichCurve[0x2]</summary>
		public const int Scale = 0x0228;

		///<summary>FRichCurve[0x2]</summary>
		public const int Shear = 0x0308;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x03E8;

	}

	public class UMovieSceneMarginSection
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00D0;

		///<summary>FRichCurve</summary>
		public const int TopCurve = 0x00D8;

		///<summary>FRichCurve</summary>
		public const int LeftCurve = 0x0148;

		///<summary>FRichCurve</summary>
		public const int RightCurve = 0x01B8;

		///<summary>FRichCurve</summary>
		public const int BottomCurve = 0x0228;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0298;

	}

	public class UMovieSceneWidgetMaterialTrack
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00D0;

		///<summary>FName</summary>
		public const int TrackName = 0x00D8;

	}

	public class UPropertyBinding
	{
		///<summary>TWeakObjectPtr&lt;UObject&gt;</summary>
		public const int SourceObject = 0x0028;

		///<summary>FDynamicPropertyPath</summary>
		public const int SourcePath = 0x0030;

		///<summary>FName</summary>
		public const int DestinationProperty = 0x0040;

	}

	public class UBrushBinding
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UCheckedStateBinding
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UColorBinding
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UTextBinding
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0048;

	}

	public class URichTextBlockDecorator
	{
		///<summary>bool</summary>
		public const int bReveal = 0x0028;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0029;

		///<summary>int</summary>
		public const int RevealedIndex = 0x002C;

	}

	public class USlateDataSheet
	{
		///<summary>UTexture2D *</summary>
		public const int DataTexture = 0x0028;

		///<summary>unsigned char[0x400]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class USlateVectorArtData
	{
		///<summary>TArray&lt;FSlateMeshVertex&gt;</summary>
		public const int VertexData = 0x0028;

		///<summary>TArray&lt;uint32_t&gt;</summary>
		public const int IndexData = 0x0038;

		///<summary>UMaterialInterface *</summary>
		public const int Material = 0x0048;

		///<summary>FVector2D</summary>
		public const int ExtentMin = 0x0050;

		///<summary>FVector2D</summary>
		public const int ExtentMax = 0x0058;

	}

	public class UWidgetBlueprintGeneratedClass
	{
		///<summary>UWidgetTree *</summary>
		public const int WidgetTree = 0x0358;

		///<summary>bool</summary>
		public const int bAllowTemplate = 0x0360;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0361;

		///<summary>TArray&lt;FDelegateRuntimeBinding&gt;</summary>
		public const int Bindings = 0x0368;

		///<summary>TArray&lt;UWidgetAnimation * &gt;</summary>
		public const int Animations = 0x0378;

		///<summary>TArray&lt;FName&gt;</summary>
		public const int NamedSlots = 0x0388;

		///<summary>bool</summary>
		public const int bValidTemplate = 0x0398;

		///<summary>bool</summary>
		public const int bTemplateInitialized = 0x0399;

		///<summary>bool</summary>
		public const int bCookedTemplate = 0x039A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData01 = 0x039B;

		///<summary>TAssetPtr&lt;UUserWidget&gt;</summary>
		public const int TemplateAsset = 0x03A0;

		///<summary>UUserWidget *</summary>
		public const int Template = 0x03C0;

	}

	public class UUMGSequencePlayer
	{
		///<summary>unsigned char[0x348]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>UWidgetAnimation *</summary>
		public const int Animation = 0x0370;

		///<summary>unsigned char[0x328]</summary>
		public const int UnknownData01 = 0x0378;

	}

	public class UPanelSlot
	{
		///<summary>UPanelWidget *</summary>
		public const int Parent = 0x0028;

		///<summary>UWidget *</summary>
		public const int Content = 0x0030;

	}

	public class UBackgroundBlurSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UBorderSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UButtonSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UCanvasPanelSlot
	{
		///<summary>FAnchorData</summary>
		public const int LayoutData = 0x0038;

		///<summary>bool</summary>
		public const int bAutoSize = 0x0060;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0061;

		///<summary>int</summary>
		public const int ZOrder = 0x0064;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0068;

	}

	public class UGridSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x004A;

		///<summary>int</summary>
		public const int Row = 0x004C;

		///<summary>int</summary>
		public const int RowSpan = 0x0050;

		///<summary>int</summary>
		public const int Column = 0x0054;

		///<summary>int</summary>
		public const int ColumnSpan = 0x0058;

		///<summary>int</summary>
		public const int Layer = 0x005C;

		///<summary>FVector2D</summary>
		public const int Nudge = 0x0060;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData01 = 0x0068;

	}

	public class UHorizontalBoxSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>FSlateChildSize</summary>
		public const int Size = 0x0048;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0050;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0051;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData00 = 0x0052;

	}

	public class UOverlaySlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class USafeZoneSlot
	{
		///<summary>bool</summary>
		public const int bIsTitleSafe = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>FMargin</summary>
		public const int SafeAreaScale = 0x003C;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HAlign = 0x004C;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VAlign = 0x004D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x004E;

		///<summary>FMargin</summary>
		public const int Padding = 0x0050;

	}

	public class UScaleBoxSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UScrollBoxSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class USizeBoxSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UUniformGridSlot
	{
		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0038;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0039;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x003A;

		///<summary>int</summary>
		public const int Row = 0x003C;

		///<summary>int</summary>
		public const int Column = 0x0040;

		///<summary>unsigned char[0xC]</summary>
		public const int UnknownData01 = 0x0044;

	}

	public class UVerticalBoxSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>FSlateChildSize</summary>
		public const int Size = 0x0048;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0050;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0051;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData00 = 0x0052;

	}

	public class UWidgetSwitcherSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UPanelWidget
	{
		///<summary>TArray&lt;UPanelSlot * &gt;</summary>
		public const int Slots = 0x0128;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0138;

	}

	public class UWindowTitleBarArea
	{
		///<summary>bool</summary>
		public const int bDoubleClickTogglesFullscreen = 0x0140;

		///<summary>unsigned char[0x1F]</summary>
		public const int UnknownData00 = 0x0141;

	}

	public class UWindowTitleBarAreaSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0048;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0049;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x004A;

	}

	public class UWrapBoxSlot
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0038;

		///<summary>bool</summary>
		public const int bFillEmptySpace = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0049;

		///<summary>float</summary>
		public const int FillSpanWhenLessThan = 0x004C;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0050;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0051;

		///<summary>unsigned char[0xE]</summary>
		public const int UnknownData01 = 0x0052;

	}

	public class UCircularThrobber
	{
		///<summary>int</summary>
		public const int NumberOfPieces = 0x0128;

		///<summary>float</summary>
		public const int Period = 0x012C;

		///<summary>float</summary>
		public const int Radius = 0x0130;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x0134;

		///<summary>USlateBrushAsset *</summary>
		public const int PieceImage = 0x0138;

		///<summary>FSlateBrush</summary>
		public const int Image = 0x0140;

		///<summary>bool</summary>
		public const int bEnableRadius = 0x01D0;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x01D1;

	}

	public class UComboBox
	{
		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int Items = 0x0128;

		///<summary>FScriptDelegate</summary>
		public const int OnGenerateWidgetEvent = 0x0138;

		///<summary>bool</summary>
		public const int bIsFocusable = 0x0148;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData00 = 0x0149;

	}

	public class UComboBoxString
	{
		///<summary>TArray&lt;FString&gt;</summary>
		public const int DefaultOptions = 0x0128;

		///<summary>FString</summary>
		public const int SelectedOption = 0x0138;

		///<summary>FComboBoxStyle</summary>
		public const int WidgetStyle = 0x0148;

		///<summary>FTableRowStyle</summary>
		public const int ItemStyle = 0x0570;

		///<summary>FMargin</summary>
		public const int ContentPadding = 0x0C88;

		///<summary>float</summary>
		public const int MaxListHeight = 0x0C98;

		///<summary>bool</summary>
		public const int HasDownArrow = 0x0C9C;

		///<summary>bool</summary>
		public const int EnableGamepadNavigationMode = 0x0C9D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0C9E;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x0CA0;

		///<summary>FSlateColor</summary>
		public const int ForegroundColor = 0x0D08;

		///<summary>bool</summary>
		public const int bIsFocusable = 0x0D30;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0D31;

		///<summary>FScriptDelegate</summary>
		public const int OnGenerateWidgetEvent = 0x0D38;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnSelectionChanged = 0x0D48;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnOpening = 0x0D58;

		///<summary>unsigned char[0x40]</summary>
		public const int UnknownData02 = 0x0D68;

	}

	public class UTextLayoutWidget
	{
		///<summary>FShapedTextOptions</summary>
		public const int ShapedTextOptions = 0x0128;

		///<summary>TEnumAsByte&lt;ETextJustify&gt;</summary>
		public const int Justification = 0x0130;

		///<summary>bool</summary>
		public const int AutoWrapText = 0x0131;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0132;

		///<summary>float</summary>
		public const int WrapTextAt = 0x0134;

		///<summary>ETextWrappingPolicy</summary>
		public const int WrappingPolicy = 0x0138;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0139;

		///<summary>FMargin</summary>
		public const int Margin = 0x013C;

		///<summary>float</summary>
		public const int LineHeightPercentage = 0x014C;

	}

	public class UEditableText
	{
		///<summary>FText</summary>
		public const int Text = 0x0128;

		///<summary>FScriptDelegate</summary>
		public const int TextDelegate = 0x0140;

		///<summary>FText</summary>
		public const int HintText = 0x0150;

		///<summary>FScriptDelegate</summary>
		public const int HintTextDelegate = 0x0168;

		///<summary>FEditableTextStyle</summary>
		public const int WidgetStyle = 0x0178;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x03C0;

		///<summary>USlateBrushAsset *</summary>
		public const int BackgroundImageSelected = 0x03C8;

		///<summary>USlateBrushAsset *</summary>
		public const int BackgroundImageComposing = 0x03D0;

		///<summary>USlateBrushAsset *</summary>
		public const int CaretImage = 0x03D8;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x03E0;

		///<summary>FSlateColor</summary>
		public const int ColorAndOpacity = 0x0448;

		///<summary>bool</summary>
		public const int IsReadOnly = 0x0470;

		///<summary>bool</summary>
		public const int IsPassword = 0x0471;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0472;

		///<summary>float</summary>
		public const int MinimumDesiredWidth = 0x0474;

		///<summary>bool</summary>
		public const int IsCaretMovedWhenGainFocus = 0x0478;

		///<summary>bool</summary>
		public const int SelectAllTextWhenFocused = 0x0479;

		///<summary>bool</summary>
		public const int RevertTextOnEscape = 0x047A;

		///<summary>bool</summary>
		public const int ClearKeyboardFocusOnCommit = 0x047B;

		///<summary>bool</summary>
		public const int SelectAllTextOnCommit = 0x047C;

		///<summary>bool</summary>
		public const int AllowContextMenu = 0x047D;

		///<summary>TEnumAsByte&lt;EVirtualKeyboardType&gt;</summary>
		public const int KeyboardType = 0x047E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x047F;

		///<summary>FShapedTextOptions</summary>
		public const int ShapedTextOptions = 0x0480;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextChanged = 0x0488;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextCommitted = 0x0498;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x04A8;

	}

	public class UEditableTextBox
	{
		///<summary>FText</summary>
		public const int Text = 0x0128;

		///<summary>FScriptDelegate</summary>
		public const int TextDelegate = 0x0140;

		///<summary>FEditableTextBoxStyle</summary>
		public const int WidgetStyle = 0x0150;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x09C0;

		///<summary>FText</summary>
		public const int HintText = 0x09C8;

		///<summary>FScriptDelegate</summary>
		public const int HintTextDelegate = 0x09E0;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x09F0;

		///<summary>FLinearColor</summary>
		public const int ForegroundColor = 0x0A58;

		///<summary>FLinearColor</summary>
		public const int BackgroundColor = 0x0A68;

		///<summary>FLinearColor</summary>
		public const int ReadOnlyForegroundColor = 0x0A78;

		///<summary>bool</summary>
		public const int IsReadOnly = 0x0A88;

		///<summary>bool</summary>
		public const int IsPassword = 0x0A89;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0A8A;

		///<summary>float</summary>
		public const int MinimumDesiredWidth = 0x0A8C;

		///<summary>FMargin</summary>
		public const int Padding = 0x0A90;

		///<summary>bool</summary>
		public const int IsCaretMovedWhenGainFocus = 0x0AA0;

		///<summary>bool</summary>
		public const int SelectAllTextWhenFocused = 0x0AA1;

		///<summary>bool</summary>
		public const int RevertTextOnEscape = 0x0AA2;

		///<summary>bool</summary>
		public const int ClearKeyboardFocusOnCommit = 0x0AA3;

		///<summary>bool</summary>
		public const int SelectAllTextOnCommit = 0x0AA4;

		///<summary>bool</summary>
		public const int AllowContextMenu = 0x0AA5;

		///<summary>TEnumAsByte&lt;EVirtualKeyboardType&gt;</summary>
		public const int KeyboardType = 0x0AA6;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData01 = 0x0AA7;

		///<summary>FShapedTextOptions</summary>
		public const int ShapedTextOptions = 0x0AA8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextChanged = 0x0AB0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextCommitted = 0x0AC0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0AD0;

	}

	public class UExpandableArea
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0128;

		///<summary>FExpandableAreaStyle</summary>
		public const int Style = 0x0130;

		///<summary>FSlateBrush</summary>
		public const int BorderBrush = 0x0260;

		///<summary>FSlateColor</summary>
		public const int BorderColor = 0x02F0;

		///<summary>bool</summary>
		public const int bIsExpanded = 0x0318;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0319;

		///<summary>float</summary>
		public const int MaxHeight = 0x031C;

		///<summary>FMargin</summary>
		public const int HeaderPadding = 0x0320;

		///<summary>FMargin</summary>
		public const int AreaPadding = 0x0330;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnExpansionChanged = 0x0340;

		///<summary>UWidget *</summary>
		public const int HeaderContent = 0x0350;

		///<summary>UWidget *</summary>
		public const int BodyContent = 0x0358;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0360;

	}

	public class UImage
	{
		///<summary>USlateBrushAsset *</summary>
		public const int Image = 0x0128;

		///<summary>FSlateBrush</summary>
		public const int Brush = 0x0130;

		///<summary>FScriptDelegate</summary>
		public const int BrushDelegate = 0x01C0;

		///<summary>FLinearColor</summary>
		public const int ColorAndOpacity = 0x01D0;

		///<summary>FScriptDelegate</summary>
		public const int ColorAndOpacityDelegate = 0x01E0;

		///<summary>FScriptDelegate</summary>
		public const int OnMouseButtonDownEvent = 0x01F0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0200;

	}

	public class UInputKeySelector
	{
		///<summary>FInputChord</summary>
		public const int SelectedKey = 0x0128;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x0148;

		///<summary>FMargin</summary>
		public const int Margin = 0x01B0;

		///<summary>FLinearColor</summary>
		public const int ColorAndOpacity = 0x01C0;

		///<summary>FText</summary>
		public const int KeySelectionText = 0x01D0;

		///<summary>bool</summary>
		public const int bAllowModifierKeys = 0x01E8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x01E9;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnKeySelected = 0x01F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnIsSelectingKeyChanged = 0x0200;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData01 = 0x0210;

	}

	public class UNativeWidgetHost
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0128;

	}

	public class UCanvasPanel
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UBackgroundBlur
	{
		///<summary>FMargin</summary>
		public const int Padding = 0x0140;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0150;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0151;

		///<summary>bool</summary>
		public const int bApplyAlphaToBlur = 0x0152;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x0153;

		///<summary>float</summary>
		public const int BlurStrength = 0x0154;

		///<summary>bool</summary>
		public const int bOverrideAutoRadiusCalculation = 0x0158;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0159;

		///<summary>int</summary>
		public const int BlurRadius = 0x015C;

		///<summary>FSlateBrush</summary>
		public const int LowQualityFallbackBrush = 0x0160;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x01F0;

	}

	public class UBorder
	{
		///<summary>FLinearColor</summary>
		public const int ContentColorAndOpacity = 0x0140;

		///<summary>FScriptDelegate</summary>
		public const int ContentColorAndOpacityDelegate = 0x0150;

		///<summary>FMargin</summary>
		public const int Padding = 0x0160;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0170;

		///<summary>TEnumAsByte&lt;EVerticalAlignment&gt;</summary>
		public const int VerticalAlignment = 0x0171;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x0172;

		///<summary>FSlateBrush</summary>
		public const int Background = 0x0178;

		///<summary>FScriptDelegate</summary>
		public const int BackgroundDelegate = 0x0208;

		///<summary>FLinearColor</summary>
		public const int BrushColor = 0x0218;

		///<summary>FScriptDelegate</summary>
		public const int BrushColorDelegate = 0x0228;

		///<summary>FVector2D</summary>
		public const int DesiredSizeScale = 0x0238;

		///<summary>bool</summary>
		public const int bShowEffectWhenDisabled = 0x0240;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0241;

		///<summary>FScriptDelegate</summary>
		public const int OnMouseButtonDownEvent = 0x0248;

		///<summary>FScriptDelegate</summary>
		public const int OnMouseButtonUpEvent = 0x0258;

		///<summary>FScriptDelegate</summary>
		public const int OnMouseMoveEvent = 0x0268;

		///<summary>FScriptDelegate</summary>
		public const int OnMouseDoubleClickEvent = 0x0278;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0288;

		///<summary>USlateBrushAsset *</summary>
		public const int Brush = 0x0298;

	}

	public class UButton
	{
		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x0140;

		///<summary>FButtonStyle</summary>
		public const int WidgetStyle = 0x0148;

		///<summary>FLinearColor</summary>
		public const int ColorAndOpacity = 0x03F0;

		///<summary>FLinearColor</summary>
		public const int BackgroundColor = 0x0400;

		///<summary>TEnumAsByte&lt;EButtonClickMethod&gt;</summary>
		public const int ClickMethod = 0x0410;

		///<summary>TEnumAsByte&lt;EButtonTouchMethod&gt;</summary>
		public const int TouchMethod = 0x0411;

		///<summary>bool</summary>
		public const int IsFocusable = 0x0412;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x0413;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnClicked = 0x0418;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPressed = 0x0428;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnReleased = 0x0438;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHovered = 0x0448;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnUnhovered = 0x0458;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0468;

	}

	public class UCheckBox
	{
		///<summary>ECheckBoxState</summary>
		public const int CheckedState = 0x0140;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0141;

		///<summary>FScriptDelegate</summary>
		public const int CheckedStateDelegate = 0x0148;

		///<summary>FCheckBoxStyle</summary>
		public const int WidgetStyle = 0x0158;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x0738;

		///<summary>USlateBrushAsset *</summary>
		public const int UncheckedImage = 0x0740;

		///<summary>USlateBrushAsset *</summary>
		public const int UncheckedHoveredImage = 0x0748;

		///<summary>USlateBrushAsset *</summary>
		public const int UncheckedPressedImage = 0x0750;

		///<summary>USlateBrushAsset *</summary>
		public const int CheckedImage = 0x0758;

		///<summary>USlateBrushAsset *</summary>
		public const int CheckedHoveredImage = 0x0760;

		///<summary>USlateBrushAsset *</summary>
		public const int CheckedPressedImage = 0x0768;

		///<summary>USlateBrushAsset *</summary>
		public const int UndeterminedImage = 0x0770;

		///<summary>USlateBrushAsset *</summary>
		public const int UndeterminedHoveredImage = 0x0778;

		///<summary>USlateBrushAsset *</summary>
		public const int UndeterminedPressedImage = 0x0780;

		///<summary>TEnumAsByte&lt;EHorizontalAlignment&gt;</summary>
		public const int HorizontalAlignment = 0x0788;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0789;

		///<summary>FMargin</summary>
		public const int Padding = 0x078C;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x079C;

		///<summary>FSlateColor</summary>
		public const int BorderBackgroundColor = 0x07A0;

		///<summary>bool</summary>
		public const int IsFocusable = 0x07C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData03 = 0x07C9;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnCheckStateChanged = 0x07D0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x07E0;

	}

	public class UInvalidationBox
	{
		///<summary>bool</summary>
		public const int bCanCache = 0x0140;

		///<summary>bool</summary>
		public const int CacheRelativeTransforms = 0x0141;

		///<summary>unsigned char[0x16]</summary>
		public const int UnknownData00 = 0x0142;

	}

	public class UMenuAnchor
	{
		///<summary>UClass *</summary>
		public const int MenuClass = 0x0140;

		///<summary>FScriptDelegate</summary>
		public const int OnGetMenuContentEvent = 0x0148;

		///<summary>TEnumAsByte&lt;EMenuPlacement&gt;</summary>
		public const int Placement = 0x0158;

		///<summary>bool</summary>
		public const int ShouldDeferPaintingAfterWindowContent = 0x0159;

		///<summary>bool</summary>
		public const int UseApplicationMenuStack = 0x015A;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData00 = 0x015B;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMenuOpenChanged = 0x0160;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0170;

	}

	public class UNamedSlot
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0140;

	}

	public class URetainerBox
	{
		///<summary>int</summary>
		public const int Phase = 0x0140;

		///<summary>int</summary>
		public const int PhaseCount = 0x0144;

		///<summary>UMaterialInterface *</summary>
		public const int EffectMaterial = 0x0148;

		///<summary>FName</summary>
		public const int TextureParameter = 0x0150;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0158;

	}

	public class USafeZone
	{
		///<summary>bool</summary>
		public const int PadLeft = 0x0140;

		///<summary>bool</summary>
		public const int PadRight = 0x0141;

		///<summary>bool</summary>
		public const int PadTop = 0x0142;

		///<summary>bool</summary>
		public const int PadBottom = 0x0143;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData00 = 0x0144;

	}

	public class UScaleBox
	{
		///<summary>TEnumAsByte&lt;EStretch&gt;</summary>
		public const int Stretch = 0x0140;

		///<summary>TEnumAsByte&lt;EStretchDirection&gt;</summary>
		public const int StretchDirection = 0x0141;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0142;

		///<summary>float</summary>
		public const int UserSpecifiedScale = 0x0144;

		///<summary>bool</summary>
		public const int IgnoreInheritedScale = 0x0148;

		///<summary>unsigned char[0x17]</summary>
		public const int UnknownData01 = 0x0149;

	}

	public class USizeBox
	{
		///<summary>unsigned char:1</summary>
		public const int bOverride_WidthOverride = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bOverride_HeightOverride = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MinDesiredWidth = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MinDesiredHeight = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MaxDesiredWidth = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MaxDesiredHeight = 0x0140;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MaxAspectRatio = 0x0140;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0141;

		///<summary>float</summary>
		public const int WidthOverride = 0x0144;

		///<summary>float</summary>
		public const int HeightOverride = 0x0148;

		///<summary>float</summary>
		public const int MinDesiredWidth = 0x014C;

		///<summary>float</summary>
		public const int MinDesiredHeight = 0x0150;

		///<summary>float</summary>
		public const int MaxDesiredWidth = 0x0154;

		///<summary>float</summary>
		public const int MaxDesiredHeight = 0x0158;

		///<summary>float</summary>
		public const int MaxAspectRatio = 0x015C;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0160;

	}

	public class UViewport
	{
		///<summary>FLinearColor</summary>
		public const int BackgroundColor = 0x0140;

		///<summary>unsigned char[0x18]</summary>
		public const int UnknownData00 = 0x0150;

	}

	public class UGridPanel
	{
		///<summary>TArray&lt;float&gt;</summary>
		public const int ColumnFill = 0x0140;

		///<summary>TArray&lt;float&gt;</summary>
		public const int RowFill = 0x0150;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0160;

	}

	public class UHorizontalBox
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UOverlay
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UScrollBox
	{
		///<summary>FScrollBoxStyle</summary>
		public const int WidgetStyle = 0x0140;

		///<summary>FScrollBarStyle</summary>
		public const int WidgetBarStyle = 0x0388;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x08A0;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int BarStyle = 0x08A8;

		///<summary>TEnumAsByte&lt;EOrientation&gt;</summary>
		public const int Orientation = 0x08B0;

		///<summary>ESlateVisibility</summary>
		public const int ScrollBarVisibility = 0x08B1;

		///<summary>EConsumeMouseWheel</summary>
		public const int ConsumeMouseWheel = 0x08B2;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x08B3;

		///<summary>FVector2D</summary>
		public const int ScrollbarThickness = 0x08B4;

		///<summary>bool</summary>
		public const int AlwaysShowScrollbar = 0x08BC;

		///<summary>unsigned char[0x1B]</summary>
		public const int UnknownData01 = 0x08BD;

	}

	public class UUniformGridPanel
	{
		///<summary>FMargin</summary>
		public const int SlotPadding = 0x0140;

		///<summary>float</summary>
		public const int MinDesiredSlotWidth = 0x0150;

		///<summary>float</summary>
		public const int MinDesiredSlotHeight = 0x0154;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0158;

	}

	public class UVerticalBox
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UWidgetSwitcher
	{
		///<summary>int</summary>
		public const int ActiveWidgetIndex = 0x0140;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData00 = 0x0144;

	}

	public class UWrapBox
	{
		///<summary>FVector2D</summary>
		public const int InnerSlotPadding = 0x0140;

		///<summary>float</summary>
		public const int WrapWidth = 0x0148;

		///<summary>bool</summary>
		public const int bExplicitWrapWidth = 0x014C;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData00 = 0x014D;

	}

	public class UProgressBar
	{
		///<summary>FProgressBarStyle</summary>
		public const int WidgetStyle = 0x0128;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x02E0;

		///<summary>USlateBrushAsset *</summary>
		public const int BackgroundImage = 0x02E8;

		///<summary>USlateBrushAsset *</summary>
		public const int FillImage = 0x02F0;

		///<summary>USlateBrushAsset *</summary>
		public const int MarqueeImage = 0x02F8;

		///<summary>float</summary>
		public const int Percent = 0x0300;

		///<summary>TEnumAsByte&lt;EProgressBarFillType&gt;</summary>
		public const int BarFillType = 0x0304;

		///<summary>bool</summary>
		public const int bIsMarquee = 0x0305;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0306;

		///<summary>FScriptDelegate</summary>
		public const int PercentDelegate = 0x0308;

		///<summary>FLinearColor</summary>
		public const int FillColorAndOpacity = 0x0318;

		///<summary>FScriptDelegate</summary>
		public const int FillColorAndOpacityDelegate = 0x0328;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0338;

	}

	public class UScrollBar
	{
		///<summary>FScrollBarStyle</summary>
		public const int WidgetStyle = 0x0128;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x0640;

		///<summary>bool</summary>
		public const int bAlwaysShowScrollbar = 0x0648;

		///<summary>TEnumAsByte&lt;EOrientation&gt;</summary>
		public const int Orientation = 0x0649;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x064A;

		///<summary>FVector2D</summary>
		public const int Thickness = 0x064C;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData01 = 0x0654;

	}

	public class USlider
	{
		///<summary>float</summary>
		public const int Value = 0x0128;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x012C;

		///<summary>FScriptDelegate</summary>
		public const int ValueDelegate = 0x0130;

		///<summary>FSliderStyle</summary>
		public const int WidgetStyle = 0x0140;

		///<summary>TEnumAsByte&lt;EOrientation&gt;</summary>
		public const int Orientation = 0x0390;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0391;

		///<summary>FLinearColor</summary>
		public const int SliderBarColor = 0x0394;

		///<summary>FLinearColor</summary>
		public const int SliderHandleColor = 0x03A4;

		///<summary>bool</summary>
		public const int IndentHandle = 0x03B4;

		///<summary>bool</summary>
		public const int Locked = 0x03B5;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData02 = 0x03B6;

		///<summary>float</summary>
		public const int StepSize = 0x03B8;

		///<summary>bool</summary>
		public const int IsFocusable = 0x03BC;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x03BD;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMouseCaptureBegin = 0x03C0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMouseCaptureEnd = 0x03D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnControllerCaptureBegin = 0x03E0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnControllerCaptureEnd = 0x03F0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnValueChanged = 0x0400;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData04 = 0x0410;

	}

	public class USpacer
	{
		///<summary>FVector2D</summary>
		public const int Size = 0x0128;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0130;

	}

	public class USpinBox
	{
		///<summary>float</summary>
		public const int Value = 0x0128;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x012C;

		///<summary>FScriptDelegate</summary>
		public const int ValueDelegate = 0x0130;

		///<summary>FSpinBoxStyle</summary>
		public const int WidgetStyle = 0x0140;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x0450;

		///<summary>float</summary>
		public const int Delta = 0x0458;

		///<summary>float</summary>
		public const int SliderExponent = 0x045C;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x0460;

		///<summary>float</summary>
		public const int MinDesiredWidth = 0x04C8;

		///<summary>bool</summary>
		public const int ClearKeyboardFocusOnCommit = 0x04CC;

		///<summary>bool</summary>
		public const int SelectAllTextOnCommit = 0x04CD;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x04CE;

		///<summary>FSlateColor</summary>
		public const int ForegroundColor = 0x04D0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnValueChanged = 0x04F8;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnValueCommitted = 0x0508;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnBeginSliderMovement = 0x0518;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEndSliderMovement = 0x0528;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MinValue = 0x0538;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MaxValue = 0x0538;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MinSliderValue = 0x0538;

		///<summary>unsigned char:1</summary>
		public const int bOverride_MaxSliderValue = 0x0538;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x0539;

		///<summary>float</summary>
		public const int MinValue = 0x053C;

		///<summary>float</summary>
		public const int MaxValue = 0x0540;

		///<summary>float</summary>
		public const int MinSliderValue = 0x0544;

		///<summary>float</summary>
		public const int MaxSliderValue = 0x0548;

		///<summary>unsigned char[0x14]</summary>
		public const int UnknownData03 = 0x054C;

	}

	public class UListView
	{
		///<summary>float</summary>
		public const int ItemHeight = 0x0128;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x012C;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int Items = 0x0130;

		///<summary>TEnumAsByte&lt;ESelectionMode&gt;</summary>
		public const int SelectionMode = 0x0140;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0141;

		///<summary>FScriptDelegate</summary>
		public const int OnGenerateRowEvent = 0x0148;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0158;

	}

	public class UTileView
	{
		///<summary>float</summary>
		public const int ItemWidth = 0x0128;

		///<summary>float</summary>
		public const int ItemHeight = 0x012C;

		///<summary>TArray&lt;UObject * &gt;</summary>
		public const int Items = 0x0130;

		///<summary>TEnumAsByte&lt;ESelectionMode&gt;</summary>
		public const int SelectionMode = 0x0140;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0141;

		///<summary>FScriptDelegate</summary>
		public const int OnGenerateTileEvent = 0x0148;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0158;

	}

	public class UMultiLineEditableText
	{
		///<summary>FText</summary>
		public const int Text = 0x0150;

		///<summary>FText</summary>
		public const int HintText = 0x0168;

		///<summary>FScriptDelegate</summary>
		public const int HintTextDelegate = 0x0180;

		///<summary>FTextBlockStyle</summary>
		public const int WidgetStyle = 0x0190;

		///<summary>bool</summary>
		public const int bIsReadOnly = 0x0398;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0399;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x03A0;

		///<summary>bool</summary>
		public const int AllowContextMenu = 0x0408;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0409;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextChanged = 0x0410;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextCommitted = 0x0420;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x0430;

	}

	public class UMultiLineEditableTextBox
	{
		///<summary>FText</summary>
		public const int Text = 0x0150;

		///<summary>FText</summary>
		public const int HintText = 0x0168;

		///<summary>FScriptDelegate</summary>
		public const int HintTextDelegate = 0x0180;

		///<summary>FEditableTextBoxStyle</summary>
		public const int WidgetStyle = 0x0190;

		///<summary>FTextBlockStyle</summary>
		public const int TextStyle = 0x0A00;

		///<summary>bool</summary>
		public const int bIsReadOnly = 0x0C08;

		///<summary>bool</summary>
		public const int AllowContextMenu = 0x0C09;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x0C0A;

		///<summary>USlateWidgetStyleAsset *</summary>
		public const int Style = 0x0C10;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x0C18;

		///<summary>FLinearColor</summary>
		public const int ForegroundColor = 0x0C80;

		///<summary>FLinearColor</summary>
		public const int BackgroundColor = 0x0C90;

		///<summary>FLinearColor</summary>
		public const int ReadOnlyForegroundColor = 0x0CA0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextChanged = 0x0CB0;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnTextCommitted = 0x0CC0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0CD0;

	}

	public class URichTextBlock
	{
		///<summary>FText</summary>
		public const int Text = 0x0150;

		///<summary>FScriptDelegate</summary>
		public const int TextDelegate = 0x0168;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x0178;

		///<summary>FLinearColor</summary>
		public const int Color = 0x01E0;

		///<summary>TArray&lt;URichTextBlockDecorator * &gt;</summary>
		public const int Decorators = 0x01F0;

		///<summary>unsigned char[0x218]</summary>
		public const int UnknownData00 = 0x0200;

	}

	public class UTextBlock
	{
		///<summary>FText</summary>
		public const int Text = 0x0150;

		///<summary>FScriptDelegate</summary>
		public const int TextDelegate = 0x0168;

		///<summary>FSlateColor</summary>
		public const int ColorAndOpacity = 0x0178;

		///<summary>FScriptDelegate</summary>
		public const int ColorAndOpacityDelegate = 0x01A0;

		///<summary>FSlateFontInfo</summary>
		public const int Font = 0x01B0;

		///<summary>FVector2D</summary>
		public const int ShadowOffset = 0x0218;

		///<summary>FLinearColor</summary>
		public const int ShadowColorAndOpacity = 0x0220;

		///<summary>FScriptDelegate</summary>
		public const int ShadowColorAndOpacityDelegate = 0x0230;

		///<summary>float</summary>
		public const int MinDesiredWidth = 0x0240;

		///<summary>bool</summary>
		public const int bWrapWithInvalidationPanel = 0x0244;

		///<summary>unsigned char[0x13]</summary>
		public const int UnknownData00 = 0x0245;

	}

	public class UThrobber
	{
		///<summary>int</summary>
		public const int NumberOfPieces = 0x0128;

		///<summary>bool</summary>
		public const int bAnimateHorizontally = 0x012C;

		///<summary>bool</summary>
		public const int bAnimateVertically = 0x012D;

		///<summary>bool</summary>
		public const int bAnimateOpacity = 0x012E;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData00 = 0x012F;

		///<summary>USlateBrushAsset *</summary>
		public const int PieceImage = 0x0130;

		///<summary>FSlateBrush</summary>
		public const int Image = 0x0138;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x01C8;

	}

	public class UWidgetAnimation
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnAnimationStarted = 0x0330;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnAnimationFinished = 0x0340;

		///<summary>UMovieScene *</summary>
		public const int MovieScene = 0x0350;

		///<summary>TArray&lt;FWidgetAnimationBinding&gt;</summary>
		public const int AnimationBindings = 0x0358;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0368;

	}

	public class UWidgetComponent
	{
		///<summary>EWidgetSpace</summary>
		public const int Space = 0x0950;

		///<summary>EWidgetTimingPolicy</summary>
		public const int TimingPolicy = 0x0951;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x0952;

		///<summary>UClass *</summary>
		public const int WidgetClass = 0x0958;

		///<summary>FIntPoint</summary>
		public const int DrawSize = 0x0960;

		///<summary>bool</summary>
		public const int bManuallyRedraw = 0x0968;

		///<summary>bool</summary>
		public const int bRedrawRequested = 0x0969;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x096A;

		///<summary>float</summary>
		public const int RedrawTime = 0x096C;

		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData02 = 0x0970;

		///<summary>FIntPoint</summary>
		public const int CurrentDrawSize = 0x0978;

		///<summary>bool</summary>
		public const int bDrawAtDesiredSize = 0x0980;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData03 = 0x0981;

		///<summary>FVector2D</summary>
		public const int Pivot = 0x0984;

		///<summary>bool</summary>
		public const int bReceiveHardwareInput = 0x098C;

		///<summary>bool</summary>
		public const int bWindowFocusable = 0x098D;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData04 = 0x098E;

		///<summary>ULocalPlayer *</summary>
		public const int OwnerPlayer = 0x0990;

		///<summary>FLinearColor</summary>
		public const int BackgroundColor = 0x0998;

		///<summary>FLinearColor</summary>
		public const int TintColorAndOpacity = 0x09A8;

		///<summary>float</summary>
		public const int OpacityFromTexture = 0x09B8;

		///<summary>EWidgetBlendMode</summary>
		public const int BlendMode = 0x09BC;

		///<summary>bool</summary>
		public const int bIsTwoSided = 0x09BD;

		///<summary>bool</summary>
		public const int TickWhenOffscreen = 0x09BE;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData05 = 0x09BF;

		///<summary>UUserWidget *</summary>
		public const int Widget = 0x09C0;

		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData06 = 0x09C8;

		///<summary>UBodySetup *</summary>
		public const int BodySetup = 0x09E8;

		///<summary>UMaterialInterface *</summary>
		public const int TranslucentMaterial = 0x09F0;

		///<summary>UMaterialInterface *</summary>
		public const int TranslucentMaterial_OneSided = 0x09F8;

		///<summary>UMaterialInterface *</summary>
		public const int OpaqueMaterial = 0x0A00;

		///<summary>UMaterialInterface *</summary>
		public const int OpaqueMaterial_OneSided = 0x0A08;

		///<summary>UMaterialInterface *</summary>
		public const int MaskedMaterial = 0x0A10;

		///<summary>UMaterialInterface *</summary>
		public const int MaskedMaterial_OneSided = 0x0A18;

		///<summary>UTextureRenderTarget2D *</summary>
		public const int RenderTarget = 0x0A20;

		///<summary>UMaterialInstanceDynamic *</summary>
		public const int MaterialInstance = 0x0A28;

		///<summary>bool</summary>
		public const int bAddedToScreen = 0x0A30;

		///<summary>bool</summary>
		public const int bEditTimeUsable = 0x0A31;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData07 = 0x0A32;

		///<summary>FName</summary>
		public const int SharedLayerName = 0x0A38;

		///<summary>int</summary>
		public const int LayerZOrder = 0x0A40;

		///<summary>EWidgetGeometryMode</summary>
		public const int GeometryMode = 0x0A44;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData08 = 0x0A45;

		///<summary>float</summary>
		public const int CylinderArcAngle = 0x0A48;

		///<summary>unsigned char[0x34]</summary>
		public const int UnknownData09 = 0x0A4C;

	}

	public class UWidgetInteractionComponent
	{
		///<summary>FScriptMulticastDelegate</summary>
		public const int OnHoveredWidgetChanged = 0x03F0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0400;

		///<summary>int</summary>
		public const int VirtualUserIndex = 0x0410;

		///<summary>float</summary>
		public const int PointerIndex = 0x0414;

		///<summary>TEnumAsByte&lt;ECollisionChannel&gt;</summary>
		public const int TraceChannel = 0x0418;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0419;

		///<summary>float</summary>
		public const int InteractionDistance = 0x041C;

		///<summary>EWidgetInteractionSource</summary>
		public const int InteractionSource = 0x0420;

		///<summary>bool</summary>
		public const int bEnableHitTesting = 0x0421;

		///<summary>bool</summary>
		public const int bShowDebug = 0x0422;

		///<summary>unsigned char[0x1]</summary>
		public const int UnknownData02 = 0x0423;

		///<summary>FLinearColor</summary>
		public const int DebugColor = 0x0424;

		///<summary>unsigned char[0x7C]</summary>
		public const int UnknownData03 = 0x0434;

		///<summary>FHitResult</summary>
		public const int CustomHitResult = 0x04B0;

		///<summary>FVector2D</summary>
		public const int LocalHitLocation = 0x0538;

		///<summary>FVector2D</summary>
		public const int LastLocalHitLocation = 0x0540;

		///<summary>UWidgetComponent *</summary>
		public const int HoveredWidgetComponent = 0x0548;

		///<summary>FHitResult</summary>
		public const int LastHitResult = 0x0550;

		///<summary>bool</summary>
		public const int bIsHoveredWidgetInteractable = 0x05D8;

		///<summary>bool</summary>
		public const int bIsHoveredWidgetFocusable = 0x05D9;

		///<summary>bool</summary>
		public const int bIsHoveredWidgetHitTestVisible = 0x05DA;

		///<summary>unsigned char[0x5]</summary>
		public const int UnknownData04 = 0x05DB;

	}

	public class UWidgetNavigation
	{
		///<summary>FWidgetNavigationData</summary>
		public const int Up = 0x0028;

		///<summary>FWidgetNavigationData</summary>
		public const int Down = 0x0040;

		///<summary>FWidgetNavigationData</summary>
		public const int Left = 0x0058;

		///<summary>FWidgetNavigationData</summary>
		public const int Right = 0x0070;

		///<summary>FWidgetNavigationData</summary>
		public const int Next = 0x0088;

		///<summary>FWidgetNavigationData</summary>
		public const int Previous = 0x00A0;

	}

	public class UWidgetTree
	{
		///<summary>UWidget *</summary>
		public const int RootWidget = 0x0028;

		///<summary>TArray&lt;UWidget * &gt;</summary>
		public const int AllWidgets = 0x0030;

	}

}
