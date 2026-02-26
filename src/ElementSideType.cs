using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An enumeration for Quark, representing CSS element sides.
/// This enum contains all valid CSS side property values that can be used for spacing properties
/// like margin, padding, border, etc. in HTML/CSS styling.
/// </summary>
[EnumValue<string>]
public sealed partial class ElementSideType
{
    /// <summary>
    /// Sets the property on the top side of the element.
    /// This controls the space or styling on the element's top edge.
    /// </summary>
    public static readonly ElementSideType Top = new("top");

    /// <summary>
    /// Sets the property on the right side of the element.
    /// This controls the space or styling on the element's right edge.
    /// </summary> 
    public static readonly ElementSideType Right = new("right");

    /// <summary>
    /// Sets the property on the bottom side of the element.
    /// This controls the space or styling on the element's bottom edge.
    /// </summary>
    public static readonly ElementSideType Bottom = new("bottom");

    /// <summary>
    /// Sets the property on the left side of the element.
    /// This controls the space or styling on the element's left edge.
    /// </summary>
    public static readonly ElementSideType Left = new("left");

    /// <summary>
    /// Sets the property on both the top and bottom sides of the element.
    /// This is equivalent to setting both top and bottom properties to the same value.
    /// </summary>
    public static readonly ElementSideType TopBottom = new("top-bottom");

    /// <summary>
    /// Sets the property on both the left and right sides of the element.
    /// This is equivalent to setting both left and right properties to the same value.
    /// </summary>
    public static readonly ElementSideType LeftRight = new("left-right");

    /// <summary>
    /// Sets the property on all sides of the element.
    /// This is equivalent to setting top, right, bottom, and left properties to the same value.
    /// </summary>
    public static readonly ElementSideType All = new("all");

    /// <summary>
    /// Sets the property on the horizontal sides (left and right) of the element.
    /// This is equivalent to setting both left and right properties to the same value.
    /// </summary>
    public static readonly ElementSideType Horizontal = new("horizontal");

    /// <summary>
    /// Sets the property on the vertical sides (top and bottom) of the element.
    /// This is equivalent to setting both top and bottom properties to the same value.
    /// </summary>
    public static readonly ElementSideType Vertical = new("vertical");

    /// <summary>
    /// Sets the property on the inline start side of the element.
    /// In left-to-right languages, this corresponds to the left side; in right-to-left languages, this corresponds to the right side.
    /// </summary>
    public static readonly ElementSideType InlineStart = new("inline-start");

    /// <summary>
    /// Sets the property on the inline end side of the element.
    /// In left-to-right languages, this corresponds to the right side; in right-to-left languages, this corresponds to the left side.
    /// </summary>
    public static readonly ElementSideType InlineEnd = new("inline-end");

    /// <summary>
    /// Sets the property on the block start side of the element.
    /// In top-to-bottom writing modes, this corresponds to the top side; in bottom-to-top writing modes, this corresponds to the bottom side.
    /// </summary>
    public static readonly ElementSideType BlockStart = new("block-start");

    /// <summary>
    /// Sets the property on the block end side of the element.
    /// In top-to-bottom writing modes, this corresponds to the bottom side; in bottom-to-top writing modes, this corresponds to the top side.
    /// </summary>
    public static readonly ElementSideType BlockEnd = new("block-end");
}
