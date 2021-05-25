﻿// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

using System;
using TiqSoft.ScreenAssistant.ScreenInfoRecognition;

namespace TiqSoft.ScreenAssistant.Games.ApLeg
{
    // ReSharper disable once InconsistentNaming
    [Flags]
    public enum WeaponAL
    {
        [WeaponData("", 0, " ")]
        Unknown = 1 << 0,
        [WeaponData("Havoc", 4, "HAVUC")]
        Havoc = 1 << 1,
        [WeaponData("Triple take", 1)]
        TripleTake = 1 << 2,
        [WeaponData("Devotion", 5, "DEVUTIUN")]
        Devotion = 1 << 3,
        [WeaponData("Flatline", 4)]
        Flatline = 1 << 4,
        [WeaponData("Hemlok", 4, "HEMLUH")]
        Hemlok = 1 << 5,
        [WeaponData("Prowler", 1, "DRUWLEP")]
        Prowler = 1 << 6,
        [WeaponData("Longbow", 4, "LUNGBUW")]
        Longbow = 1 << 7,
        [WeaponData("Spitfire", 4, "SDITFIRE")]
        Spitfire = 1 << 8,
        [WeaponData("Wingman", 3)]
        Wingman = 1 << 9,
        [WeaponData("RE-45", 4, "p E-z15")]
        RE45 = 1 << 10,
        [WeaponData("P2020", 2, "P2o2o")]
        P2020 = 1 << 11,
        [WeaponData("R-301", 5, "R-3 Ol", "9-501")]
        R301 = 1 << 12,
        [WeaponData("R-99", 4, "9-99", "R - SEI", "R-SEI")]
        R99 = 1 << 13,
        [WeaponData("Alternator", 4)]
        Alternator = 1 << 14,
        [WeaponData("G7 Scout", 4, "G7SCOUT")]
        G7Scout = 1 << 15,
        [WeaponData("EVA-8 AUTO", 2)]
        EVA8Auto = 1 << 16,
        [WeaponData("Peacekeeper", 2, "PEACEHEEDER")]
        Peacekeeper = 1 << 17,
        [WeaponData("Mozambique", 2)]
        Mozambique = 1 << 18,
        [WeaponData("MASTIFF", 2)]
        MASTIFF = 1 << 19,
        [WeaponData("KRABER", 0, "HRABER")]
        KRABER = 1 << 20,
        [WeaponData("L-STAR", 2, "LSTAR")]
        LStar = 1 << 21,
        [WeaponData("Charge Rifle", 2, "CHARGEDRIFLE", "CHARGERIFLE")]
        ChargedRifle = 1 << 22,
        [WeaponData("Volt", 4)]
        Volt = 1 << 23,
        [WeaponData("30-30 REPEATER", 4)]
        Repeater3030 = 1 << 24,
        [WeaponData("DOCEK", 3)]
        Docek = 1 << 25
    }
}
