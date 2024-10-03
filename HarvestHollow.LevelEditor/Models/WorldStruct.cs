namespace HarvestHollow.Entities.LevelData;

/// <summary>A UID referencing an object definition.</summary>
public struct Definitions
{
    /// <summary>An array with all entity definition UIDs associated with this world.</summary>
    public global::System.Collections.Generic.IEnumerable<int>? EntityDefUIDs { get; set; }
    /// <summary>An array with all enum definition UIDs associated with this world.</summary>
    public global::System.Collections.Generic.IEnumerable<int>? EnumDefUIDs { get; set; }
    /// <summary>Same as a regular enum, but with a reference to an external source file.</summary>
    public global::System.Collections.Generic.IEnumerable<int>? ExternalEnumDefUIDs { get; set; }
    /// <summary>An array with all layer definition UIDs associated with this world.</summary>
    public global::System.Collections.Generic.IEnumerable<int>? LayerDefUIDs { get; set; }
    /// <summary>An array with all entity definition UIDs associated with this world.</summary>
    public global::System.Collections.Generic.IEnumerable<int>? TilesetDefUIDs { get; set; }
}
/// <summary>Defines a world in Harvest Hollow.</summary>
public struct WorldSchema
{
    /// <summary>User created unique Identifier for the world.</summary>
    public string Identifier { get; set; }
    /// <summary>Unique instance Identifier for the world.</summary>
    public string IID { get; set; }
    /// <summary>Width of the world in pixels.</summary>
    public int WorldWidth { get; set; }
    /// <summary>Height of the world in pixels.</summary>
    public int WorldHeight { get; set; }
    /// <summary>References to level IIDs associated with this world.</summary>
    public global::System.Collections.Generic.IEnumerable<string>? Levels { get; set; }
    /// <summary>A record of arrays containing object definition UIDs associated with this world.</summary>
    public Definitions Definitions { get; set; }
}
