/// <summary>
/// Auto-generated offsets targetting PUBG v2.6.44.2
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UWidget
	{
		public const int bIsVariable = 0x0028;
		public const int bCreatedByConstructionScript = 0x0029;
		public const int UnknownData00 = 0x002A;
		public const int Slot = 0x0030;
		public const int bIsEnabled = 0x0038;
		public const int UnknownData01 = 0x0039;
		public const int bIsEnabledDelegate = 0x0040;
		public const int OnPrepass = 0x0050;
		public const int ToolTipText = 0x0060;
		public const int ToolTipTextDelegate = 0x0078;
		public const int ToolTipWidget = 0x0088;
		public const int ToolTipWidgetDelegate = 0x0090;
		public const int Visiblity = 0x00A0;
		public const int Visibility = 0x00A1;
		public const int UnknownData02 = 0x00A2;
		public const int VisibilityDelegate = 0x00A8;
		public const int bOverride_Cursor = 0x00B8;
		public const int UnknownData03 = 0x00B9;
		public const int Cursor = 0x00BC;
		public const int bIsVolatile = 0x00BD;
		public const int UnknownData04 = 0x00BE;
		public const int RenderTransform = 0x00C0;
		public const int RenderTransformPivot = 0x00DC;
		public const int UnknownData05 = 0x00E4;
		public const int Navigation = 0x00E8;
		public const int UnknownData06 = 0x00F0;
		public const int NativeBindings = 0x0118;
	}

	public class UUserWidget
	{
		public const int UnknownData00 = 0x0128;
		public const int ColorAndOpacity = 0x0130;
		public const int ColorAndOpacityDelegate = 0x0140;
		public const int ForegroundColor = 0x0150;
		public const int ForegroundColorDelegate = 0x0178;
		public const int Padding = 0x0188;
		public const int bSupportsKeyboardFocus = 0x0198;
		public const int bIsFocusable = 0x0199;
		public const int UnknownData01 = 0x019A;
		public const int WidgetTree = 0x01A0;
		public const int ActiveSequencePlayers = 0x01A8;
		public const int StoppedSequencePlayers = 0x01B8;
		public const int NamedSlotBindings = 0x01C8;
		public const int bStopAction = 0x01D8;
		public const int UnknownData02 = 0x01D9;
		public const int Priority = 0x01DC;
		public const int UnknownData03 = 0x01E0;
		public const int InputComponent = 0x01E8;
		public const int UnknownData04 = 0x01F0;
	}

	public class UAsyncTaskDownloadImage
	{
		public const int OnSuccess = 0x0028;
		public const int OnFail = 0x0038;
	}

	public class UDragDropOperation
	{
		public const int Tag = 0x0028;
		public const int payload = 0x0038;
		public const int DefaultDragVisual = 0x0040;
		public const int Pivot = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int Offset = 0x004C;
		public const int UnknownData01 = 0x0054;
		public const int OnDrop = 0x0058;
		public const int OnDragCancelled = 0x0068;
		public const int OnDragged = 0x0078;
	}

	public class UMovieScene2DTransformSection
	{
		public const int UnknownData00 = 0x0040;
		public const int Translation = 0x0048;
		public const int Rotation = 0x0138;
		public const int Scale = 0x01B0;
		public const int Shear = 0x02A0;
	}

	public class UMovieSceneMarginSection
	{
		public const int UnknownData00 = 0x0040;
		public const int TopCurve = 0x0048;
		public const int LeftCurve = 0x00C0;
		public const int RightCurve = 0x0138;
		public const int BottomCurve = 0x01B0;
	}

	public class UMovieSceneWidgetMaterialTrack
	{
		public const int BrushPropertyNamePath = 0x0038;
		public const int TrackName = 0x0048;
	}

	public class UPropertyBinding
	{
		public const int SourceObject = 0x0028;
		public const int SourcePath = 0x0030;
		public const int DestinationProperty = 0x0040;
	}

	public class UBrushBinding
	{
		public const int UnknownData00 = 0x0048;
	}

	public class UCheckedStateBinding
	{
		public const int UnknownData00 = 0x0048;
	}

	public class UColorBinding
	{
		public const int UnknownData00 = 0x0048;
	}

	public class UTextBinding
	{
		public const int UnknownData00 = 0x0048;
	}

	public class URichTextBlockDecorator
	{
		public const int bReveal = 0x0028;
		public const int UnknownData00 = 0x0029;
		public const int RevealedIndex = 0x002C;
	}

	public class USlateDataSheet
	{
		public const int DataTexture = 0x0028;
		public const int UnknownData00 = 0x0030;
	}

	public class USlateVectorArtData
	{
		public const int VertexData = 0x0028;
		public const int IndexData = 0x0038;
		public const int Material = 0x0048;
		public const int ExtentMin = 0x0050;
		public const int ExtentMax = 0x0058;
	}

	public class UUMGSequencePlayer
	{
		public const int UnknownData00 = 0x0028;
		public const int Animation = 0x0048;
		public const int UnknownData01 = 0x0050;
	}

	public class UPanelSlot
	{
		public const int Parent = 0x0028;
		public const int Content = 0x0030;
	}

	public class UBorderSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class UButtonSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class UCanvasPanelSlot
	{
		public const int LayoutData = 0x0038;
		public const int bAutoSize = 0x0060;
		public const int UnknownData00 = 0x0061;
		public const int ZOrder = 0x0064;
		public const int UnknownData01 = 0x0068;
	}

	public class UGridSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
		public const int Row = 0x004C;
		public const int RowSpan = 0x0050;
		public const int Column = 0x0054;
		public const int ColumnSpan = 0x0058;
		public const int Layer = 0x005C;
		public const int Nudge = 0x0060;
		public const int UnknownData01 = 0x0068;
	}

	public class UHorizontalBoxSlot
	{
		public const int Padding = 0x0038;
		public const int Size = 0x0048;
		public const int HorizontalAlignment = 0x0050;
		public const int VerticalAlignment = 0x0051;
		public const int UnknownData00 = 0x0052;
	}

	public class UOverlaySlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class USafeZoneSlot
	{
		public const int bIsTitleSafe = 0x0038;
		public const int UnknownData00 = 0x0039;
		public const int SafeAreaScale = 0x003C;
		public const int HAlign = 0x004C;
		public const int VAlign = 0x004D;
		public const int UnknownData01 = 0x004E;
		public const int Padding = 0x0050;
	}

	public class UScaleBoxSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class UScrollBoxSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int UnknownData00 = 0x0049;
	}

	public class USizeBoxSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class UUniformGridSlot
	{
		public const int HorizontalAlignment = 0x0038;
		public const int VerticalAlignment = 0x0039;
		public const int UnknownData00 = 0x003A;
		public const int Row = 0x003C;
		public const int Column = 0x0040;
		public const int UnknownData01 = 0x0044;
	}

	public class UVerticalBoxSlot
	{
		public const int Padding = 0x0038;
		public const int Size = 0x0048;
		public const int HorizontalAlignment = 0x0050;
		public const int VerticalAlignment = 0x0051;
		public const int UnknownData00 = 0x0052;
	}

	public class UWidgetSwitcherSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class UWindowTitleBarAreaSlot
	{
		public const int Padding = 0x0038;
		public const int HorizontalAlignment = 0x0048;
		public const int VerticalAlignment = 0x0049;
		public const int UnknownData00 = 0x004A;
	}

	public class UWrapBoxSlot
	{
		public const int Padding = 0x0038;
		public const int bFillEmptySpace = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int FillSpanWhenLessThan = 0x004C;
		public const int HorizontalAlignment = 0x0050;
		public const int VerticalAlignment = 0x0051;
		public const int UnknownData01 = 0x0052;
	}

	public class UCircularThrobber
	{
		public const int NumberOfPieces = 0x0128;
		public const int Period = 0x012C;
		public const int Radius = 0x0130;
		public const int UnknownData00 = 0x0134;
		public const int PieceImage = 0x0138;
		public const int Image = 0x0140;
		public const int bEnableRadius = 0x01D0;
		public const int UnknownData01 = 0x01D1;
	}

	public class UComboBox
	{
		public const int Items = 0x0128;
		public const int OnGenerateWidgetEvent = 0x0138;
		public const int UnknownData00 = 0x0148;
	}

	public class UComboBoxString
	{
		public const int DefaultOptions = 0x0128;
		public const int SelectedOption = 0x0138;
		public const int WidgetStyle = 0x0148;
		public const int ItemStyle = 0x0570;
		public const int ContentPadding = 0x0C88;
		public const int MaxListHeight = 0x0C98;
		public const int HasDownArrow = 0x0C9C;
		public const int EnableGamepadNavigationMode = 0x0C9D;
		public const int UnknownData00 = 0x0C9E;
		public const int Font = 0x0CA0;
		public const int ForegroundColor = 0x0D08;
		public const int OnGenerateWidgetEvent = 0x0D30;
		public const int OnSelectionChanged = 0x0D40;
		public const int OnOpening = 0x0D50;
		public const int UnknownData01 = 0x0D60;
	}

	public class UTextLayoutWidget
	{
		public const int ShapedTextOptions = 0x0128;
		public const int Justification = 0x0130;
		public const int AutoWrapText = 0x0131;
		public const int UnknownData00 = 0x0132;
		public const int WrapTextAt = 0x0134;
		public const int WrappingPolicy = 0x0138;
		public const int UnknownData01 = 0x0139;
		public const int Margin = 0x013C;
		public const int LineHeightPercentage = 0x014C;
	}

	public class UEditableText
	{
		public const int Text = 0x0128;
		public const int TextDelegate = 0x0140;
		public const int HintText = 0x0150;
		public const int HintTextDelegate = 0x0168;
		public const int WidgetStyle = 0x0178;
		public const int Style = 0x03C0;
		public const int BackgroundImageSelected = 0x03C8;
		public const int BackgroundImageComposing = 0x03D0;
		public const int CaretImage = 0x03D8;
		public const int Font = 0x03E0;
		public const int ColorAndOpacity = 0x0448;
		public const int IsReadOnly = 0x0470;
		public const int IsPassword = 0x0471;
		public const int UnknownData00 = 0x0472;
		public const int MinimumDesiredWidth = 0x0474;
		public const int IsCaretMovedWhenGainFocus = 0x0478;
		public const int SelectAllTextWhenFocused = 0x0479;
		public const int RevertTextOnEscape = 0x047A;
		public const int ClearKeyboardFocusOnCommit = 0x047B;
		public const int SelectAllTextOnCommit = 0x047C;
		public const int AllowContextMenu = 0x047D;
		public const int KeyboardType = 0x047E;
		public const int UnknownData01 = 0x047F;
		public const int ShapedTextOptions = 0x0480;
		public const int OnTextChanged = 0x0488;
		public const int OnTextCommitted = 0x0498;
		public const int UnknownData02 = 0x04A8;
	}

	public class UEditableTextBox
	{
		public const int Text = 0x0128;
		public const int TextDelegate = 0x0140;
		public const int WidgetStyle = 0x0150;
		public const int Style = 0x09C0;
		public const int HintText = 0x09C8;
		public const int HintTextDelegate = 0x09E0;
		public const int Font = 0x09F0;
		public const int ForegroundColor = 0x0A58;
		public const int BackgroundColor = 0x0A68;
		public const int ReadOnlyForegroundColor = 0x0A78;
		public const int IsReadOnly = 0x0A88;
		public const int IsPassword = 0x0A89;
		public const int UnknownData00 = 0x0A8A;
		public const int MinimumDesiredWidth = 0x0A8C;
		public const int Padding = 0x0A90;
		public const int IsCaretMovedWhenGainFocus = 0x0AA0;
		public const int SelectAllTextWhenFocused = 0x0AA1;
		public const int RevertTextOnEscape = 0x0AA2;
		public const int ClearKeyboardFocusOnCommit = 0x0AA3;
		public const int SelectAllTextOnCommit = 0x0AA4;
		public const int AllowContextMenu = 0x0AA5;
		public const int KeyboardType = 0x0AA6;
		public const int UnknownData01 = 0x0AA7;
		public const int ShapedTextOptions = 0x0AA8;
		public const int OnTextChanged = 0x0AB0;
		public const int OnTextCommitted = 0x0AC0;
		public const int UnknownData02 = 0x0AD0;
	}

	public class UExpandableArea
	{
		public const int UnknownData00 = 0x0128;
		public const int Style = 0x0130;
		public const int BorderBrush = 0x0258;
		public const int BorderColor = 0x02E8;
		public const int bIsExpanded = 0x0310;
		public const int UnknownData01 = 0x0311;
		public const int MaxHeight = 0x0314;
		public const int HeaderPadding = 0x0318;
		public const int AreaPadding = 0x0328;
		public const int OnExpansionChanged = 0x0338;
		public const int HeaderContent = 0x0348;
		public const int BodyContent = 0x0350;
		public const int UnknownData02 = 0x0358;
	}

	public class UImage
	{
		public const int Image = 0x0128;
		public const int Brush = 0x0130;
		public const int BrushDelegate = 0x01C0;
		public const int ColorAndOpacity = 0x01D0;
		public const int ColorAndOpacityDelegate = 0x01E0;
		public const int OnMouseButtonDownEvent = 0x01F0;
		public const int UnknownData00 = 0x0200;
	}

	public class UInputKeySelector
	{
		public const int SelectedKey = 0x0128;
		public const int Font = 0x0148;
		public const int Margin = 0x01B0;
		public const int ColorAndOpacity = 0x01C0;
		public const int KeySelectionText = 0x01D0;
		public const int bAllowModifierKeys = 0x01E8;
		public const int UnknownData00 = 0x01E9;
		public const int OnKeySelected = 0x01F0;
		public const int OnIsSelectingKeyChanged = 0x0200;
		public const int UnknownData01 = 0x0210;
	}

	public class UNativeWidgetHost
	{
		public const int UnknownData00 = 0x0128;
	}

	public class UPanelWidget
	{
		public const int Slots = 0x0128;
		public const int UnknownData00 = 0x0138;
	}

	public class UCanvasPanel
	{
		public const int UnknownData00 = 0x0140;
	}

	public class UBorder
	{
		public const int ContentColorAndOpacity = 0x0140;
		public const int ContentColorAndOpacityDelegate = 0x0150;
		public const int Padding = 0x0160;
		public const int HorizontalAlignment = 0x0170;
		public const int VerticalAlignment = 0x0171;
		public const int UnknownData00 = 0x0172;
		public const int Background = 0x0178;
		public const int BackgroundDelegate = 0x0208;
		public const int BrushColor = 0x0218;
		public const int BrushColorDelegate = 0x0228;
		public const int DesiredSizeScale = 0x0238;
		public const int bShowEffectWhenDisabled = 0x0240;
		public const int UnknownData01 = 0x0241;
		public const int OnMouseButtonDownEvent = 0x0248;
		public const int OnMouseButtonUpEvent = 0x0258;
		public const int OnMouseMoveEvent = 0x0268;
		public const int OnMouseDoubleClickEvent = 0x0278;
		public const int UnknownData02 = 0x0288;
		public const int Brush = 0x0298;
	}

	public class UButton
	{
		public const int Style = 0x0140;
		public const int WidgetStyle = 0x0148;
		public const int ColorAndOpacity = 0x03F0;
		public const int BackgroundColor = 0x0400;
		public const int ClickMethod = 0x0410;
		public const int TouchMethod = 0x0411;
		public const int IsFocusable = 0x0412;
		public const int UnknownData00 = 0x0413;
		public const int OnClicked = 0x0418;
		public const int OnPressed = 0x0428;
		public const int OnReleased = 0x0438;
		public const int OnHovered = 0x0448;
		public const int OnUnhovered = 0x0458;
		public const int UnknownData01 = 0x0468;
	}

	public class UCheckBox
	{
		public const int CheckedState = 0x0140;
		public const int UnknownData00 = 0x0141;
		public const int CheckedStateDelegate = 0x0148;
		public const int WidgetStyle = 0x0158;
		public const int Style = 0x0738;
		public const int UncheckedImage = 0x0740;
		public const int UncheckedHoveredImage = 0x0748;
		public const int UncheckedPressedImage = 0x0750;
		public const int CheckedImage = 0x0758;
		public const int CheckedHoveredImage = 0x0760;
		public const int CheckedPressedImage = 0x0768;
		public const int UndeterminedImage = 0x0770;
		public const int UndeterminedHoveredImage = 0x0778;
		public const int UndeterminedPressedImage = 0x0780;
		public const int HorizontalAlignment = 0x0788;
		public const int UnknownData01 = 0x0789;
		public const int Padding = 0x078C;
		public const int UnknownData02 = 0x079C;
		public const int BorderBackgroundColor = 0x07A0;
		public const int IsFocusable = 0x07C8;
		public const int UnknownData03 = 0x07C9;
		public const int OnCheckStateChanged = 0x07D0;
		public const int UnknownData04 = 0x07E0;
	}

	public class UInvalidationBox
	{
		public const int bCanCache = 0x0140;
		public const int CacheRelativeTransforms = 0x0141;
		public const int UnknownData00 = 0x0142;
	}

	public class UMenuAnchor
	{
		public const int MenuClass = 0x0140;
		public const int OnGetMenuContentEvent = 0x0148;
		public const int Placement = 0x0158;
		public const int ShouldDeferPaintingAfterWindowContent = 0x0159;
		public const int UseApplicationMenuStack = 0x015A;
		public const int UnknownData00 = 0x015B;
		public const int OnMenuOpenChanged = 0x0160;
		public const int UnknownData01 = 0x0170;
	}

	public class UNamedSlot
	{
		public const int UnknownData00 = 0x0140;
	}

	public class URetainerBox
	{
		public const int Phase = 0x0140;
		public const int PhaseCount = 0x0144;
		public const int EffectMaterial = 0x0148;
		public const int TextureParameter = 0x0150;
		public const int UnknownData00 = 0x0158;
	}

	public class USafeZone
	{
		public const int PadLeft = 0x0140;
		public const int PadRight = 0x0141;
		public const int PadTop = 0x0142;
		public const int PadBottom = 0x0143;
		public const int UnknownData00 = 0x0144;
	}

	public class UScaleBox
	{
		public const int Stretch = 0x0140;
		public const int StretchDirection = 0x0141;
		public const int UnknownData00 = 0x0142;
		public const int UserSpecifiedScale = 0x0144;
		public const int IgnoreInheritedScale = 0x0148;
		public const int UnknownData01 = 0x0149;
	}

	public class USizeBox
	{
		public const int bOverride_WidthOverride = 0x0140;
		public const int bOverride_HeightOverride = 0x0140;
		public const int bOverride_MinDesiredWidth = 0x0140;
		public const int bOverride_MinDesiredHeight = 0x0140;
		public const int bOverride_MaxDesiredWidth = 0x0140;
		public const int bOverride_MaxDesiredHeight = 0x0140;
		public const int bOverride_MaxAspectRatio = 0x0140;
		public const int UnknownData00 = 0x0141;
		public const int WidthOverride = 0x0144;
		public const int HeightOverride = 0x0148;
		public const int MinDesiredWidth = 0x014C;
		public const int MinDesiredHeight = 0x0150;
		public const int MaxDesiredWidth = 0x0154;
		public const int MaxDesiredHeight = 0x0158;
		public const int MaxAspectRatio = 0x015C;
		public const int UnknownData01 = 0x0160;
	}

	public class UViewport
	{
		public const int BackgroundColor = 0x0140;
		public const int UnknownData00 = 0x0150;
	}

	public class UWindowTitleBarArea
	{
		public const int bDoubleClickTogglesFullscreen = 0x0140;
		public const int UnknownData00 = 0x0141;
	}

	public class UGridPanel
	{
		public const int ColumnFill = 0x0140;
		public const int RowFill = 0x0150;
		public const int UnknownData00 = 0x0160;
	}

	public class UHorizontalBox
	{
		public const int UnknownData00 = 0x0140;
	}

	public class UOverlay
	{
		public const int UnknownData00 = 0x0140;
	}

	public class UScrollBox
	{
		public const int WidgetStyle = 0x0140;
		public const int WidgetBarStyle = 0x0388;
		public const int Style = 0x08A0;
		public const int BarStyle = 0x08A8;
		public const int Orientation = 0x08B0;
		public const int ScrollBarVisibility = 0x08B1;
		public const int ConsumeMouseWheel = 0x08B2;
		public const int UnknownData00 = 0x08B3;
		public const int ScrollbarThickness = 0x08B4;
		public const int AlwaysShowScrollbar = 0x08BC;
		public const int UnknownData01 = 0x08BD;
	}

	public class UUniformGridPanel
	{
		public const int SlotPadding = 0x0140;
		public const int MinDesiredSlotWidth = 0x0150;
		public const int MinDesiredSlotHeight = 0x0154;
		public const int UnknownData00 = 0x0158;
	}

	public class UVerticalBox
	{
		public const int UnknownData00 = 0x0140;
	}

	public class UWidgetSwitcher
	{
		public const int ActiveWidgetIndex = 0x0140;
		public const int UnknownData00 = 0x0144;
	}

	public class UWrapBox
	{
		public const int InnerSlotPadding = 0x0140;
		public const int UnknownData00 = 0x0148;
	}

	public class UProgressBar
	{
		public const int WidgetStyle = 0x0128;
		public const int Style = 0x02E0;
		public const int BackgroundImage = 0x02E8;
		public const int FillImage = 0x02F0;
		public const int MarqueeImage = 0x02F8;
		public const int Percent = 0x0300;
		public const int BarFillType = 0x0304;
		public const int bIsMarquee = 0x0305;
		public const int UnknownData00 = 0x0306;
		public const int PercentDelegate = 0x0308;
		public const int FillColorAndOpacity = 0x0318;
		public const int FillColorAndOpacityDelegate = 0x0328;
		public const int UnknownData01 = 0x0338;
	}

	public class UScrollBar
	{
		public const int WidgetStyle = 0x0128;
		public const int Style = 0x0640;
		public const int bAlwaysShowScrollbar = 0x0648;
		public const int Orientation = 0x0649;
		public const int UnknownData00 = 0x064A;
		public const int Thickness = 0x064C;
		public const int UnknownData01 = 0x0654;
	}

	public class USlider
	{
		public const int Value = 0x0128;
		public const int UnknownData00 = 0x012C;
		public const int ValueDelegate = 0x0130;
		public const int WidgetStyle = 0x0140;
		public const int Orientation = 0x0390;
		public const int UnknownData01 = 0x0391;
		public const int SliderBarColor = 0x0394;
		public const int SliderHandleColor = 0x03A4;
		public const int IndentHandle = 0x03B4;
		public const int Locked = 0x03B5;
		public const int UnknownData02 = 0x03B6;
		public const int StepSize = 0x03B8;
		public const int IsFocusable = 0x03BC;
		public const int UnknownData03 = 0x03BD;
		public const int OnMouseCaptureBegin = 0x03C0;
		public const int OnMouseCaptureEnd = 0x03D0;
		public const int OnControllerCaptureBegin = 0x03E0;
		public const int OnControllerCaptureEnd = 0x03F0;
		public const int OnValueChanged = 0x0400;
		public const int UnknownData04 = 0x0410;
	}

	public class USpacer
	{
		public const int Size = 0x0128;
		public const int UnknownData00 = 0x0130;
	}

	public class USpinBox
	{
		public const int Value = 0x0128;
		public const int UnknownData00 = 0x012C;
		public const int ValueDelegate = 0x0130;
		public const int WidgetStyle = 0x0140;
		public const int Style = 0x0450;
		public const int Delta = 0x0458;
		public const int SliderExponent = 0x045C;
		public const int Font = 0x0460;
		public const int MinDesiredWidth = 0x04C8;
		public const int ClearKeyboardFocusOnCommit = 0x04CC;
		public const int SelectAllTextOnCommit = 0x04CD;
		public const int UnknownData01 = 0x04CE;
		public const int ForegroundColor = 0x04D0;
		public const int OnValueChanged = 0x04F8;
		public const int OnValueCommitted = 0x0508;
		public const int OnBeginSliderMovement = 0x0518;
		public const int OnEndSliderMovement = 0x0528;
		public const int bOverride_MinValue = 0x0538;
		public const int bOverride_MaxValue = 0x0538;
		public const int bOverride_MinSliderValue = 0x0538;
		public const int bOverride_MaxSliderValue = 0x0538;
		public const int UnknownData02 = 0x0539;
		public const int MinValue = 0x053C;
		public const int MaxValue = 0x0540;
		public const int MinSliderValue = 0x0544;
		public const int MaxSliderValue = 0x0548;
		public const int UnknownData03 = 0x054C;
	}

	public class UListView
	{
		public const int ItemHeight = 0x0128;
		public const int UnknownData00 = 0x012C;
		public const int Items = 0x0130;
		public const int SelectionMode = 0x0140;
		public const int UnknownData01 = 0x0141;
		public const int OnGenerateRowEvent = 0x0148;
		public const int UnknownData02 = 0x0158;
	}

	public class UTileView
	{
		public const int ItemWidth = 0x0128;
		public const int ItemHeight = 0x012C;
		public const int Items = 0x0130;
		public const int SelectionMode = 0x0140;
		public const int UnknownData00 = 0x0141;
		public const int OnGenerateTileEvent = 0x0148;
		public const int UnknownData01 = 0x0158;
	}

	public class UMultiLineEditableText
	{
		public const int Text = 0x0150;
		public const int HintText = 0x0168;
		public const int HintTextDelegate = 0x0180;
		public const int WidgetStyle = 0x0190;
		public const int Font = 0x0398;
		public const int AllowContextMenu = 0x0400;
		public const int UnknownData00 = 0x0401;
		public const int OnTextChanged = 0x0408;
		public const int OnTextCommitted = 0x0418;
		public const int UnknownData01 = 0x0428;
	}

	public class UMultiLineEditableTextBox
	{
		public const int Text = 0x0150;
		public const int HintText = 0x0168;
		public const int HintTextDelegate = 0x0180;
		public const int WidgetStyle = 0x0190;
		public const int TextStyle = 0x0A00;
		public const int AllowContextMenu = 0x0C08;
		public const int UnknownData00 = 0x0C09;
		public const int Style = 0x0C10;
		public const int Font = 0x0C18;
		public const int ForegroundColor = 0x0C80;
		public const int BackgroundColor = 0x0C90;
		public const int ReadOnlyForegroundColor = 0x0CA0;
		public const int OnTextChanged = 0x0CB0;
		public const int OnTextCommitted = 0x0CC0;
		public const int UnknownData01 = 0x0CD0;
	}

	public class URichTextBlock
	{
		public const int Text = 0x0150;
		public const int TextDelegate = 0x0168;
		public const int Font = 0x0178;
		public const int Color = 0x01E0;
		public const int Decorators = 0x01F0;
		public const int UnknownData00 = 0x0200;
	}

	public class UTextBlock
	{
		public const int Text = 0x0150;
		public const int TextDelegate = 0x0168;
		public const int ColorAndOpacity = 0x0178;
		public const int ColorAndOpacityDelegate = 0x01A0;
		public const int Font = 0x01B0;
		public const int ShadowOffset = 0x0218;
		public const int ShadowColorAndOpacity = 0x0220;
		public const int ShadowColorAndOpacityDelegate = 0x0230;
		public const int MinDesiredWidth = 0x0240;
		public const int bWrapWithInvalidationPanel = 0x0244;
		public const int UnknownData00 = 0x0245;
	}

	public class UThrobber
	{
		public const int NumberOfPieces = 0x0128;
		public const int bAnimateHorizontally = 0x012C;
		public const int bAnimateVertically = 0x012D;
		public const int bAnimateOpacity = 0x012E;
		public const int UnknownData00 = 0x012F;
		public const int PieceImage = 0x0130;
		public const int Image = 0x0138;
		public const int UnknownData01 = 0x01C8;
	}

	public class UWidgetTree
	{
		public const int RootWidget = 0x0028;
		public const int AllWidgets = 0x0030;
	}

	public class UWidgetAnimation
	{
		public const int OnAnimationStarted = 0x0028;
		public const int OnAnimationFinished = 0x0038;
		public const int MovieScene = 0x0048;
		public const int AnimationBindings = 0x0050;
		public const int UnknownData00 = 0x0060;
	}

	public class UWidgetBlueprintGeneratedClass
	{
		public const int WidgetTree = 0x02F8;
		public const int Bindings = 0x0300;
		public const int Animations = 0x0310;
		public const int NamedSlots = 0x0320;
		public const int bCanEverTick = 0x0330;
		public const int bCanEverPaint = 0x0330;
		public const int UnknownData00 = 0x0331;
	}

	public class UWidgetComponent
	{
		public const int Space = 0x0780;
		public const int UnknownData00 = 0x0781;
		public const int WidgetClass = 0x0788;
		public const int DrawSize = 0x0790;
		public const int bManuallyRedraw = 0x0798;
		public const int bRedrawRequested = 0x0799;
		public const int UnknownData01 = 0x079A;
		public const int RedrawTime = 0x079C;
		public const int LastWidgetRenderTime = 0x07A0;
		public const int bWindowFocusable = 0x07A4;
		public const int UnknownData02 = 0x07A5;
		public const int CurrentDrawSize = 0x07A8;
		public const int bDrawAtDesiredSize = 0x07B0;
		public const int UnknownData03 = 0x07B1;
		public const int Pivot = 0x07B4;
		public const int UnknownData04 = 0x07BC;
		public const int OwnerPlayer = 0x07C0;
		public const int BackgroundColor = 0x07C8;
		public const int TintColorAndOpacity = 0x07D8;
		public const int OpacityFromTexture = 0x07E8;
		public const int BlendMode = 0x07EC;
		public const int bIsTwoSided = 0x07ED;
		public const int TickWhenOffscreen = 0x07EE;
		public const int UnknownData05 = 0x07EF;
		public const int Widget = 0x07F0;
		public const int UnknownData06 = 0x07F8;
		public const int BodySetup = 0x0818;
		public const int TranslucentMaterial = 0x0820;
		public const int TranslucentMaterial_OneSided = 0x0828;
		public const int OpaqueMaterial = 0x0830;
		public const int OpaqueMaterial_OneSided = 0x0838;
		public const int MaskedMaterial = 0x0840;
		public const int MaskedMaterial_OneSided = 0x0848;
		public const int RenderTarget = 0x0850;
		public const int MaterialInstance = 0x0858;
		public const int bAddedToScreen = 0x0860;
		public const int bEditTimeUsable = 0x0861;
		public const int UnknownData07 = 0x0862;
		public const int SharedLayerName = 0x0868;
		public const int LayerZOrder = 0x0870;
		public const int UnknownData08 = 0x0874;
	}

	public class UWidgetInteractionComponent
	{
		public const int OnHoveredWidgetChanged = 0x0300;
		public const int UnknownData00 = 0x0310;
		public const int VirtualUserIndex = 0x0320;
		public const int PointerIndex = 0x0324;
		public const int TraceChannel = 0x0328;
		public const int UnknownData01 = 0x0329;
		public const int InteractionDistance = 0x032C;
		public const int InteractionSource = 0x0330;
		public const int bEnableHitTesting = 0x0331;
		public const int bShowDebug = 0x0332;
		public const int UnknownData02 = 0x0333;
		public const int DebugColor = 0x0334;
		public const int UnknownData03 = 0x0344;
		public const int CustomHitResult = 0x03C0;
		public const int LocalHitLocation = 0x0448;
		public const int LastLocalHitLocation = 0x0450;
		public const int HoveredWidgetComponent = 0x0458;
		public const int LastHitResult = 0x0460;
		public const int bIsHoveredWidgetInteractable = 0x04E8;
		public const int bIsHoveredWidgetFocusable = 0x04E9;
		public const int bIsHoveredWidgetHitTestVisible = 0x04EA;
		public const int UnknownData04 = 0x04EB;
	}

	public class UWidgetNavigation
	{
		public const int Up = 0x0028;
		public const int Down = 0x0040;
		public const int Left = 0x0058;
		public const int Right = 0x0070;
		public const int Next = 0x0088;
		public const int Previous = 0x00A0;
	}

}
