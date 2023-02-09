﻿using System.ComponentModel;

namespace LlamaLibrary.Enums
{
    public enum WorldDCGroupType : byte
    {
        Invalid = 0,
        Elemental = 1,
        Gaia = 2,
        Mana = 3,
        Aether = 4,
        Primal = 5,
        Chaos = 6,
        Light = 7,
        Crystal = 8,
        Materia = 9,
        Meteor = 10,
        Dynamis = 11,

        //Values are filler for now
        [Description("陆行鸟")]
        Chocobo = 108,

        [Description("猫小胖")]
        FatCat = 101,

        [Description("豆豆柴")]
        Mameshiba = 103,

        [Description("莫古力")]
        Moogle = 104,
    }

}