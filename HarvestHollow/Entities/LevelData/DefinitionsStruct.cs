// Ignore Spelling: Defs

using System.Collections.Generic;

namespace HarvestHollow.Entities.LevelData;

/// <summary>Defines an auto layer.</summary>
public struct AutoLayerDef
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>User created Documentation.</summary>
    public string? Documentation { get; set; }
    /// <summary>User defined Tags to organize the Tileset.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Tags { get; set; }
    /// <summary>Width of tiles.</summary>
    public int TileSizeX { get; set; }
    /// <summary>Height of tiles.</summary>
    public int TileSizeY { get; set; }
    /// <summary>Reference to the enum used for selecting the AutoLayer Tileset.</summary>
    public IEnumerable<AutoLayerTilesetSelect> TilesetEnumDefUID { get; set; }
    /// <summary>Rules for the AutoLayer.</summary>
    public global::System.Collections.Generic.IEnumerable<Rules>? Rules { get; set; }
}
/// <summary>Auto tiles layers created using IntGrid data.</summary>
public struct AutoLayerTilesetSelect
{
    /// <summary>Reference to the enum used for selecting the AutoLayer Tileset.</summary>
    public int? EnumDefUID { get; set; }
    /// <summary>Reference to the default Tileset used for the AutoLayer.</summary>
    public int? DefaultTilesetDefUID { get; set; }
    /// <summary>List of enum Values with their associated tilesets.</summary>
    public IEnumerable<EnumBasedTilesetDefUID> EnumBasedTilesetDefUIDs { get; set; }
}
public enum CountScopeOptions
{
    PER_lAYER,
    PER_LEVEL,
    PER_WORLD,
    HARVEST_HOLLOW
}
/// <summary>Definitions for all entities, layers and Values in Harvest Hollow.</summary>
public struct DefinitionsSchema
{
    /// <summary>All enum definitions.</summary>
    public global::System.Collections.Generic.IEnumerable<EnumDefinition>? EnumDefinitions { get; set; }
    /// <summary>All entity definitions.</summary>
    public global::System.Collections.Generic.IEnumerable<EntityDefinition>? EntityDefinitions { get; set; }
    /// <summary>All layer definitions.</summary>
    public global::System.Collections.Generic.IEnumerable<LayerDefinitions>? LayerDefinitions { get; set; }
    /// <summary>All Tileset definitions.</summary>
    public global::System.Collections.Generic.IEnumerable<TilesetDefinition>? TilesetDefinitions { get; set; }
}
public enum EditorVisualizerFit
{
    COVER_BOUNDS,
    FIT_BOOUNDS,
    REPEAT,
    DIRTY_STRETCH_TO_BOUNDS,
    FULL_SIZE_CROPPED,
    FULL_SIZE
}
/// <summary>Option for how to handle entity count enforcement.</summary>
public enum EnforceCountOptions
{
    DISCARD_OLD,
    PREVENT_ADDING,
    MOVE_OLD_TO_NEW
}
/// <summary>Defines an entity.</summary>
public struct EntityDefinition
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>User created Documentation.</summary>
    public string? Documentation { get; set; }
    /// <summary>User defined Tags to organize the Tileset.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Tags { get; set; }
    /// <summary>Size  of the entity. [sizeX, sizeY]</summary>
    public IEnumerable<int> PxSize { get; set; }
    /// <summary>Reference to Tileset used for editor visual.</summary>
    public int? TilesetDefUID { get; set; }
    /// <summary>Editor options for entity visualizer fit.</summary>
    public EditorVisualizerFit EditorVisualizerFit { get; set; }
    /// <summary>Editor entity Tileset visualizer Opacity.</summary>
    public float VisualizerOpacity { get; set; }
    /// <summary>Editor entity fill Color visualizer Opacity.</summary>
    public float FillOpacity { get; set; }
    /// <summary>Editor entity outline visualizer Opacity.</summary>
    public float OutlineOpacity { get; set; }
    /// <summary>Array of floats from 0-1 for entities Pivot. [pivotX, pivotY]</summary>
    public IEnumerable<float> Pivot { get; set; }
    /// <summary>Maximum number of entities allowed in A given scope.</summary>
    public int? MaxCount { get; set; }
    /// <summary>Option for scope at which entity count is enforced.</summary>
    public CountScopeOptions CountScopeOptions { get; set; }
    /// <summary>Option for how to handle entity count enforcement.</summary>
    public EnforceCountOptions EnforceCountOptions { get; set; }
    /// <summary>All enum Values for this entity.</summary>
    public IEnumerable<EnumValue> EnumValues { get; set; }
}
/// <summary>Enum Value and Tileset UID pair.</summary>
#pragma warning disable S101 // Types should be named in PascalCase
public struct EnumBasedTilesetDefUID
#pragma warning restore S101 // Types should be named in PascalCase
{
    /// <summary>The enum Value used to select the Tileset.</summary>
    public string? EnumValue { get; set; }
    /// <summary>Reference to the Tileset used for the AutoLayer.</summary>
    public int? TilesetDefUID { get; set; }
}
/// <summary>Defines an enum definition.</summary>
public struct EnumDefinition
{
    /// <summary>User created unique Identifier for the enum definition.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier for the enum definition.</summary>
    public int UID { get; set; }
    /// <summary>Internal enums are defined in the schema, external enums are defined in A separate file.</summary>
    public EnumType Type { get; set; }
    /// <summary>Path to external file providing this enum.</summary>
    public string? ExternalRelPath { get; set; }
    /// <summary>User created Documentation.</summary>
    public string? Documentation { get; set; }
    /// <summary>User defined Tags to organize the Tileset.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Tags { get; set; }
    /// <summary>All possible Values for the enum.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Values { get; set; }
    /// <summary>Reference to Tileset used for editor visual.</summary>
    public int? TilesetDefUID { get; set; }
}
public enum EnumType
{
    INTERNAL,
    EXTERNAL
}
/// <summary>Defines an enum Value.</summary>
public struct EnumValue
{
    /// <summary>The Type of enum Value associated with this entity.</summary>
    public EnumValueType Type { get; set; }
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>User created Documentation.</summary>
    public string? Documentation { get; set; }
    /// <summary>Reference to enum used for assigning entities enum Values.</summary>
    public int? EnumDefUID { get; set; }
    /// <summary>The custom enum Value assigned to the entity.</summary>
    public string? DefaultValue { get; set; }
    /// <summary>Whether or not this enum Value should be visible in the editor</summary>
    public bool DisplayInEditor { get; set; }
}
public enum EnumValueType
{
    STRING,
    INT,
    FLOAT,
    BOOL,
    MULTI_LINE,
    Color,
    ENUM,
    FILE,
    TILE,
    ENTITY,
    POINT
}
/// <summary>Defines an int grid def.</summary>
public struct IntGridDef
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>User created Documentation.</summary>
    public string? Documentation { get; set; }
    /// <summary>User defined Tags to organize the Tileset.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Tags { get; set; }
    /// <summary>Width of Values.</summary>
    public int GridSizeX { get; set; }
    /// <summary>Height of Values.</summary>
    public int GridSizeY { get; set; }
    /// <summary>Values for int grid layer def.</summary>
    public global::System.Collections.Generic.IEnumerable<IntGridValue>? IntGridValues { get; set; }
    /// <summary>All IntGrid Value groups.</summary>
    public global::System.Collections.Generic.IEnumerable<IntGridValueGroup>? IntGridValueGroups { get; set; }
}
/// <summary>IntGrid Value rule.</summary>
public struct IntGridRule
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Reference to an integer grid layer definition.</summary>
    public int DefUID { get; set; }
    /// <summary>Value of the grid cell.</summary>
    public int V { get; set; }
    /// <summary>Pixel position of the grid cell in the layer. [x, y]</summary>
    public IEnumerable<int> PX { get; set; }
}
/// <summary>Defines an int grid Value.</summary>
public struct IntGridValue
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Group Identifier.</summary>
    public int GroupUID { get; set; }
    /// <summary>The IntGrid Value itself.</summary>
    public int Value { get; set; }
    /// <summary>Hex Color.</summary>
    public string Color { get; set; }
}
/// <summary>Defines an int grid Value group.</summary>
public struct IntGridValueGroup
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>Hex Color.</summary>
    public string Color { get; set; }
}
/// <summary>Defines A layer definition.</summary>
public struct LayerDefinitions
{
    /// <summary>All IntGrid definitions.</summary>
    public global::System.Collections.Generic.IEnumerable<IntGridDef>? IntGridDefs { get; set; }
    /// <summary>All Tileset definitions.</summary>
    public global::System.Collections.Generic.IEnumerable<TilesetLayerDef>? TilesetLayerDefs { get; set; }
    /// <summary>All AutoLayer definitions.</summary>
    public IEnumerable<AutoLayerDef> AutoLayerDefs { get; set; }
}
/// <summary>Rules for the AutoLayer. Rules are made up of arrays of int grid data Value combinations corresponding to tile placements in the layer from A Tileset dependent on certain level enum Values.</summary>
public struct Rules
{
    /// <summary>The int grid Value combination making up A rule.</summary>
    public global::System.Collections.Generic.IEnumerable<IntGridRule>? intGridRules { get; set; }
    /// <summary>Tile placement Values selected using corresponding IntGrid Rules and level enum Values.</summary>
    public global::System.Collections.Generic.IEnumerable<TileRule>? TileRules { get; set; }
}
/// <summary>Tile data for current layer.</summary>
public struct TileRule
{
    /// <summary>Opacity of the tile.</summary>
    public float A { get; set; }
    /// <summary>Flip flag. F=0 (no flip), F=1 (x flip only), F=2(Y flip only), F=3 (both flips)</summary>
    public int F { get; set; }
    /// <summary>Position of the tile in the layer. [x, y]</summary>
    public IEnumerable<int> PxPos { get; set; }
    /// <summary>Position of tile in the source Tileset. [x, y]</summary>
    public string Src { get; set; }
    /// <summary>Tile ID in Tileset. (y * GridWidth + x)</summary>
    public int T { get; set; }
}
/// <summary>All Tileset definitions.</summary>
public struct TilesetDefinition
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>The name of the Tileset image.</summary>
    public string Tileset { get; set; }
    /// <summary>Size of the image in pixels.</summary>
    public global::System.Collections.Generic.IEnumerable<int>? PxSize { get; set; }
    /// <summary>User defined Tags to organize the Tileset.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Tags { get; set; }
    /// <summary>Width of tiles.</summary>
    public int TileSizeX { get; set; }
    /// <summary>Height of tiles.</summary>
    public int TileSizeY { get; set; }
    /// <summary>Spacing between tiles.</summary>
    public int Spacing { get; set; }
    /// <summary>Distance around image borders.</summary>
    public int Padding { get; set; }
    /// <summary>Grid based width.</summary>
    public int? GridWidth { get; set; }
    /// <summary>Grid based height.</summary>
    public int? GridHeight { get; set; }
    /// <summary>All Tileset enums.</summary>
    public IEnumerable<TilesetEnum> TilesetEnums { get; set; }
}
/// <summary>Describes A tile layer enum.</summary>
public struct TilesetEnum
{
    /// <summary>Reference to enum used for assigning tiles enum Values.</summary>
    public int? EnumDefUID { get; set; }
    /// <summary>A list with A tile enum marks.</summary>
    public global::System.Collections.Generic.IEnumerable<TilesetEnumMark>? TilesetEnumMarks { get; set; }
}
/// <summary>Describes A tile enum mark.</summary>
public struct TilesetEnumMark
{
    /// <summary>Position of the tile in the Tileset.</summary>
    public IEnumerable<int> PxPos { get; set; }
    /// <summary>The custom enum Value assigned to the tile.</summary>
    public string Value { get; set; }
}
/// <summary>Defines A Tileset layer.</summary>
public struct TilesetLayerDef
{
    /// <summary>User created unique Identifier.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique Identifier.</summary>
    public int UID { get; set; }
    /// <summary>Reference to the tilesheet used by this layer.</summary>
    public int? TilesetDefUID { get; set; }
    /// <summary>User created Documentation.</summary>
    public string? Documentation { get; set; }
    /// <summary>User defined Tags to organize the Tileset.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Tags { get; set; }
    /// <summary>Width of tiles.</summary>
    public int TileSizeX { get; set; }
    /// <summary>Height of tiles.</summary>
    public int TileSizeY { get; set; }
    /// <summary>X offset in pixels.</summary>
    public int PxOffsetX { get; set; }
    /// <summary>Y offset in pixels.</summary>
    public int PxOffsetY { get; set; }
    /// <summary>Opacity of the layer.</summary>
    public float Opacity { get; set; }
    /// <summary>Hide in list.</summary>
    public bool HideInList { get; set; }
    /// <summary>Show in world view.</summary>
    public bool ShowInWorldView { get; set; }
    /// <summary>Array of floats from 0-1 for entities Pivot. [pivotX, pivotY]</summary>
    public IEnumerable<float> Pivot { get; set; }
}
