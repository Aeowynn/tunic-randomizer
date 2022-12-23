﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunicRandomizer {
    public class Hints {
        public static Dictionary<string, string> HintLocations = new Dictionary<string, string>() {
            {"Overworld Redux (-7.0, 12.0, -136.4)", "Mailbox"},
            {"Archipelagos Redux (-170.0, 11.0, 152.5)", "West Garden Relic"},
            {"Swamp Redux 2 (92.0, 7.0, 90.8)", "Swamp Relic"},
            {"Sword Access (28.5, 5.0, -190.0)", "East Forest Relic"},
            {"Library Hall (131.0, 19.0, -8.5)", "Library Relic"},
            {"Monastery (-6.0, 26.0, 180.5)", "Monastery Relic"},
            {"Fortress Reliquary (198.5, 5.0, -40.0)", "Fortress Relic"},
            {"Overworld Redux (89.0, 44.0, -107.0)", "East Forest Sign"},
            {"Overworld Redux (-5.0, 36.0, -70.0)", "Overworld Sign"},
            {"Overworld Redux (8.0, 20.0, -115.0)", "Swamp Sign"},
            {"Overworld Redux (-156.0, 12.0, -44.3)", "West Garden Sign"},
            {"Overworld Redux (73.0, 44.0, -38.0)", "Fortress Sign"},
            {"Overworld Redux (-141.0, 40.0, 34.8)", "Quarry Sign"},
            {"Temple (14.0, -0.5, 49.0)", "Temple Statue"}
        };

        public static Dictionary<string, string> HintMessages = new Dictionary<string, string>();

        public static Dictionary<string, string> SimplifiedSceneNames = new Dictionary<string, string>() {
            {"Overworld Redux", "Overworld"},
            {"Furnace", "Overworld Belltower"},
            {"CubeRoom", "Overworld Cave"},
            {"Sword Cave", "Overworld Cave"},
            {"EastFiligreeCache", "Overworld Cave"},
            {"Overworld Cave", "Overworld Cave"},
            {"Ruins Passage", "Overworld Cave"},
            {"PatrolCave", "Overworld Cave"},
            {"Waterfall", "Secret Gathering Place"},
            {"Town_FiligreeRoom", "Overworld Cave"},
            {"Town Basement", "Overworld Cave"},
            {"Maze Room", "Overworld Cave"},
            {"Ruined Shop", "Ruined Shop"},
            {"Changing Room", "Changing Room"},
            {"ShopSpecial", "Overworld Cave"},
            {"Overworld Interiors", "Old House"},
            {"Transit", "Far Shore"},
            {"Temple", "Sealed Temple"},
            {"Shop", "Shop"},
            {"Trinket Well", "Trinket Well"},
            {"Forest Belltower", "Forest Belltower"},
            {"East Forest Redux", "East Forest"},
            {"Sword Access", "East Forest"},
            {"East Forest Redux Interior", "East Forest"},
            {"East Forest Redux Laddercave", "East Forest"},
            {"Sewer", "Bottom of the Well"},
            {"Sewer_Boss", "Bottom of the Well"},
            {"Crypt Redux", "Dark Tomb"},
            {"Archipelagos Redux", "West Garden"},
            {"archipelagos_house", "West Garden"},
            {"Atoll Redux", "Ruined Atoll"},
            {"frog cave main", "Frog's Domain"},
            {"Library Hall", "Library"},
            {"Library Lab", "Library"},
            {"Library Arena", "Librarian"},
            {"Fortress Basement", "Beneath the Vault"},
            {"Fortress Main", "Eastern Vault Fortress"},
            {"Fortress East", "Eastern Vault Fortress"},
            {"Fortress Reliquary", "Fortress Grave Path"},
            {"Fortress Courtyard", "Fortress Courtyard"},
            {"Dusty", "Dusty"},
            {"Fortress Arena", "Siege Engine"},
            {"Mountain", "Mountain"},
            {"Mountaintop", "Mountaintop"},
            {"Quarry Redux", "Quarry"},
            {"Monastery", "Monastery"},
            {"ziggurat2020_1", "Rooted Ziggurat"},
            {"ziggurat2020_2", "Rooted Ziggurat"},
            {"ziggurat2020_3", "Rooted Ziggurat"},
            {"Swamp Redux 2", "Swamp"},
            {"Cathedral Redux", "Cathedral"},
            {"Cathedral Arena", "Gauntlet"},
            {"RelicVoid", "Hero's Grave"}
        };

        public static Dictionary<string, string> SceneNamesForSpoilerLog = new Dictionary<string, string>() {
            {"Overworld Redux", "Overworld"},
            {"CubeRoom", "Overworld (Cube Room)"},
            {"Sword Cave", "Overworld (Stick Cave)"},
            {"EastFiligreeCache", "Overworld (Fire Sword Cave)"},
            {"Overworld Cave", "Overworld (Caustic Light Fairy Cave)"},
            {"Ruins Passage", "Overworld (Ruins Passage)"},
            {"PatrolCave", "Overworld (Patrol Fairy Cave)"},
            {"Waterfall", "Overworld (Secret Gathering Place)"},
            {"Ruined Shop", "Overworld (Ruined Shop)"},
            {"Town_FiligreeRoom", "Overworld (Holy Cross Door Cave)"},
            {"Changing Room", "Overworld (Changing Room)"},
            {"Town Basement", "Overworld (Hourglass Room)"},
            {"Overworld Interiors", "Overworld (Old House)"},
            {"Maze Room", "Overworld (Maze Room)"},
            {"Furnace", "Overworld (West Belltower)"},
            {"ShopSpecial", "Overworld (Special Shop)"},
            {"Temple", "Sealed Temple"},
            {"Transit", "Far Shore"},            
            {"Shop", "Shop"},
            {"Trinket Well", "Trinket Well"},
            {"Forest Belltower", "East Forest (East Belltower)"},
            {"East Forest Redux", "East Forest"},
            {"Sword Access", "East Forest (Path to Hero's Grave)"},
            {"East Forest Redux Interior", "East Forest (Guardhouse 2)"},
            {"East Forest Redux Laddercave", "East Forest (Guardhouse 1)"},
            {"Sewer", "Bottom of the Well"},
            {"Sewer_Boss", "Bottom of the Well (Boss Room)"},
            {"Crypt Redux", "Dark Tomb"},
            {"Archipelagos Redux", "West Garden"},
            {"archipelagos_house", "West Garden (Ice Dagger Cave)"},
            {"Atoll Redux", "Ruined Atoll"},
            {"frog cave main", "Frog's Domain"},
            {"Library Hall", "Library (Hall)"},
            {"Library Lab", "Library (Lab)"},
            {"Library Arena", "Library (Librarian)"},
            {"Fortress Courtyard", "Eastern Vault Fortress (Fortress Courtyard)"},
            {"Fortress Basement", "Beneath the Eastern Vault"},
            {"Fortress Main", "Eastern Vault Fortress"},
            {"Fortress East", "Eastern Vault Fortress (Shortcut Path)"},
            {"Fortress Reliquary", "Eastern Vault Fortress (Path to Hero's Grave)"},
            {"Dusty", "Eastern Vault Fortress (Dusty)"},
            {"Fortress Arena", "Siege Engine"},
            {"Mountain", "Mountaintop"},
            {"Mountaintop", "Mountaintop"},
            {"Quarry Redux", "Quarry"},
            {"Monastery", "Monastery"},
            {"ziggurat2020_1", "Rooted Ziggurat Upper"},
            {"ziggurat2020_2", "Rooted Ziggurat Tower"},
            {"ziggurat2020_3", "Rooted Ziggurat Lower"},
            {"Swamp Redux 2", "Swamp"},
            {"Cathedral Redux", "Cathedral"},
            {"Cathedral Arena", "Cathedral (Gauntlet)"},
            {"RelicVoid", "Hero's Grave"}
        };

        public static Dictionary<string, string> SimplifiedItemNames = new Dictionary<string, string>() {
            {"Hyperdash", "Hyperdash (Hero Laurels)"},
            {"Lantern", "Lantern"},
            {"Wand", "Magic Orb (Grapple Wand)"},
            {"GoldenTrophy_9", "Golden Trophy 9"},
            {"CubeRoom-(321.1, 3.0, 217.0)", "Fairy (Cube)"},
            {"Stick", "Stick"},
            {"Flask Shard", "Flask Shard"},
            {"Firecracker", "Firecracker"},
            {"Fool", "Fool Trap"},
            {"GoldenTrophy_3", "Golden Trophy 3"},
            {"Key", "Key"},
            {"Pepper", "Pepper"},
            {"Piggybank L1", "Piggybank"},
            {"money", "Money"},
            {"Trinket - Glass Cannon", "Trinket Card (Fire Sword)"},
            {"Berry_MP", "MP Berry"},
            {"Overworld Cave-(-90.4, 515.0, -738.9)", "Fairy (Caustic Light)"},
            {"5", "Page 5"},
            {"GoldenTrophy_1", "Golden Trophy 1"},
            {"Overworld Redux-(90.4, 36.0, -122.1)", "Fairy (Weathervane)"},
            {"14", "Page 14"},
            {"6", "Page 6"},
            {"Berry_HP", "HP Berry"},
            {"7", "Page 7"},
            {"Flask Container", "Flask"},
            {"East Forest Redux-(104.0, 16.0, 61.0)", "Fairy (Dancer)"},
            {"Sword", "Sword"},
            {"Firebomb", "Fire Bomb"},
            {"Ice Bomb", "Ice Bomb"},
            {"Trinket Coin", "Trinket Coin"},
            {"East Forest Redux-(164.0, -25.0, -56.0)", "Fairy (Forest Monolith)"},
            {"Upgrade Offering - Health HP - Flower", "HP Upgrade Flower"},
            {"GoldenTrophy_6", "Golden Trophy 6"},
            {"Upgrade Offering - PotionEfficiency Swig - Ash", "Potion Upgrade Ash"},
            {"Overworld Redux-(64.5, 44.0, -40.0)", "Fairy (Overworld Flowers Upper)"},
            {"PatrolCave-(74.0, 46.0, 24.0)", "Fairy (Patrol)"},
            {"Techbow", "Techbow (Fire Wand)"},
            {"24", "Page 24"},
            {"Waterfall-(-47.0, 45.0, 10.0)", "Fairy (Waterfall)"},
            {"Upgrade Offering - Attack - Tooth", "Attack Upgrade Tooth"},
            {"GoldenTrophy_8", "Golden Trophy 8"},
            {"8", "Page 8"},
            {"Overworld Redux-(-132.0, 28.0, -55.5)", "Fairy (Moss)"},
            {"22", "Page 22"},
            {"21", "Page 21"},
            {"Overworld Redux-(-83.0, 20.0, -117.5)", "Fairy (Fountain)"},
            {"Trinket - Heartdrops", "Trinket Card (Lucky Cup)"},
            {"Key (House)", "Old House Key"},
            {"Ivy", "Ivy"},
            {"Overworld Redux-(-52.0, 2.0, -174.8)", "Fairy (Overworld Flowers Lower)"},
            {"GoldenTrophy_4", "Golden Trophy 4"},
            {"SlowmoItem", "SlowmoItem (Hourglass)"},
            {"Town Basement-(-202.0, 28.0, 150.0)", "Fairy (Maze Column)"},
            {"Bait", "Lure"},
            {"16", "Page 16"},
            {"1", "Page 1"},
            {"GoldenTrophy_12", "Golden Trophy 12"},
            {"Maze Room-(1.0, 0.0, -1.0)", "Fairy (Invisible Maze)"},
            {"4", "Page 4"},
            {"Trinket - Block Plus", "Trinket Card (Bracer)"},
            {"Trinket - Bloodstain MP", "Trinket Card (Magic Echo)"},
            {"Upgrade Offering - Magic MP - Mushroom", "MP Upgrade Mushroom"},
            {"Trinket - IFrames", "Trinket Card (The Bone)"},
            {"Trinket - Attack Up Defense Down", "Trinket Card (Tincture)"},
            {"GoldenTrophy_10", "Golden Trophy 10"},
            {"Upgrade Offering - DamageResist - Effigy", "Defense Upgrade Effigy"},
            {"Library Hall-(133.3, 10.0, -43.2)", "Fairy (Library Rug)"},
            {"20", "Page 20"},
            {"25", "Page 25"},
            {"19", "Page 19"},
            {"Hexagon Green", "Hexagon Green"},
            {"Overworld Interiors-(-28.0, 27.0, -50.5)", "Fairy (Old House)"},
            {"Shield", "Shield"},
            {"26", "Page 26"},
            {"27", "Page 27"},
            {"2", "Page 2"},
            {"9", "Page 9"},
            {"17", "Page 17"},
            {"Trinket - Bloodstain Plus", "Trinket Card (Louder Echo)"},
            {"15", "Page 15"},
            {"Trinket - MP Flasks", "Trinket Card (Inverted Ash)"},
            {"Trinket - RTSR", "Trinket Card (Orange Peril Ring)"},
            {"Trinket - BTSR", "Trinket Card (Cyan Peril Ring)"},
            {"13", "Page 13"},
            {"Archipelagos Redux-(-396.3, 1.4, 42.3)", "Fairy (West Garden Tree)"},
            {"Stundagger", "Stundagger (Ice Dagger)"},
            {"23", "Page 23"},
            {"Upgrade Offering - Stamina SP - Feather", "SP Upgrade Feather"},
            {"Archipelagos Redux-(-236.0, 8.0, 86.3)", "Fairy (West Garden Tiles)"},
            {"Temple-(14.0, 0.1, 42.4)", "Fairy (Temple)"},
            {"12", "Page 12"},
            {"3", "Page 3"},
            {"Trinket - Sneaky", "Trinket Card (Muffling Bell)"},
            {"18", "Page 18"},
            {"Fortress Main-(-75.0, -1.0, 17.0)", "Fairy (Fortress Candles)"},
            {"Trinket - Walk Speed Plus", "Trinket Card (Anklet)"},
            {"GoldenTrophy_11", "Golden Trophy 11"},
            {"Vault Key (Red)", "Vault Key (Red)"},
            {"Hexagon Red", "Hexagon Red"},
            {"11", "Page 11"},
            {"10", "Page 10"},
            {"0", "Page 0"},
            {"Quarry Redux-(0.7, 68.0, 84.7)", "Fairy (Quarry)"},
            {"Mask", "Trinket Card (Scavenger's Mask)"},
            {"Shotgun", "Shotgun"},
            {"Trinket - Parry Window", "Trinket Card (Aura's Gem)"},
            {"Hexagon Blue", "Hexagon Blue"},
            {"GoldenTrophy_7", "Golden Trophy 7"},
            {"Trinket - Fast Icedagger", "Trinket Card (Dagger Strap)"},
            {"Trinket - Stamina Recharge Plus", "Trinket Card (Perfume)"},
            {"GoldenTrophy_5", "Golden Trophy 5"},
            {"GoldenTrophy_2", "Golden Trophy 2"},
            {"Trinket Slot", "Trinket Card Slot"},
            {"Relic - Hero Sword", "Hero Relic (ATT)"},
            {"Relic - Hero Pendant MP", "Hero Relic (MP)"},
            {"Relic - Hero Water", "Hero Relic (POTION)"},
            {"Relic - Hero Pendant HP", "Hero Relic (HP)"},
            {"Relic - Hero Crown", "Hero Relic (DEF)"},
            {"Relic - Hero Pendant SP", "Hero Relic (SP)"}
        };
    }
}
