using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    /// <summary>
    /// Represents the available color types of heroes, weapons and skills.
    /// </summary>
    public enum ColorType
    {
        Red,
        Blue,
        Green,
        Neutral
    }

    /// <summary>
    /// Represents the available move type of heroes.
    /// </summary>
    public enum MoveType
    {
        Infantry,
        Flying,
        Cavalry,
        Armored
    }

    /// <summary>
    /// Represents the available weapon types of heroes and weapons.
    /// </summary>
    public enum WeaponType
    {
        Sword,
        Lance,
        Axe,
        Bow,
        Dagger,
        Tome,
        Staff,
        Breath,
        Beast
    }

    /// <summary>
    /// Represents the cost type of structures in Aether Raids.
    /// </summary>
    public enum CostType
    {
        Stones,
        Dew
    }
}
