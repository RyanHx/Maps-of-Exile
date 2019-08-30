using System.Collections.ObjectModel;
using PoEMapsModel.Maps;

namespace PoEMapsViewModel.Helper
{
    public class MapList
    {
        public static ObservableCollection<MapViewModel> MapListMain = new ObservableCollection<MapViewModel>();

        /// <summary>
        /// Populates map list.
        /// </summary>
        public static void GetMaps()
        {
            #region Add maps
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arcade", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Jungle Valley", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Wharf", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pier", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Alleyways", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cage", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Excavation", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Sulphur Vents", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Armoury", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mesa", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pen", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Desert", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Fungal Hollow", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Strand", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ivory Temple", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Spider Lair", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mausoleum", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ashen Wood", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ramparts", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Tropical Island", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Whakawairua Tuahu", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arid Lake", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Flooded Mine", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Leyline", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Burial Chambers", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Channel", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Barrows", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Fields", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Crater", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arachnid Tomb", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cursed Crypt", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Coward's Trial", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lookout", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Beach", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Marshes", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Peninsula", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "City Square", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Relic Chambers", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Grotto", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Glacier", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Haunted Mansion", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Thicket", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lighthouse", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Maze", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Residence", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Bone Crypt", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Geode", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Estuary", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vault", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Overgrown Shrine", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Racecourse", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ghetto", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arsenal", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Doryani's Machinarium", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Olmec's Sanctum", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Acton's Nightmare", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arcade", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Jungle Valley", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Wharf", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Pier", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Port", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Chateau", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Conservatory", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ancient City", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Underground Sea", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Bazaar", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Waste Pool", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Spider Forest", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Factory", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Villa", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Necropolis", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Perandus Manor", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Oba's Cursed Trove", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Death and Taxes", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Alleyways", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cage", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Excavation", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Sulphur Vents", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Armoury", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mesa", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Graveyard", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cells", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Volcano", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Phantasmagoria", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Atoll", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Underground River", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arachnid Nest", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shore", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Sepulchre", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Temple", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pit", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Maelström of Chaos", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Caer Blaidd, Wolfpack's Den", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mao Kun", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Poorjoy's Asylum", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Pen", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Desert", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Fungal Hollow", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Strand", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ivory Temple", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Spider Lair", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mausoleum", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ashen Wood", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ramparts", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Tropical Island", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dungeon", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Coral Ruins", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Laboratory", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Courtyard", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mud Geyser", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mineral Pools", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arena", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Scriptorium", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Promenade", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Waterways", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Castle Ruins", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Vinktar Square", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Hall of Grandmasters", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arid Lake", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Flooded Mine", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Leyline", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Burial Chambers", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Channel", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Barrows", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Fields", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Crater", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arachnid Tomb", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cursed Crypt", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Iceberg", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Toxic Sewer", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Academy", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lava Chamber", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dunes", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Overgrown Ruin", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Moon Temple", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Plateau", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Bog", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Primordial Pool", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pillars of Arun", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Twilight Temple", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lookout", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Beach", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Marshes", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Peninsula", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped City Square", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Relic Chambers", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Grotto", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Glacier", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Haunted Mansion", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Thicket", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Gardens", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vaal Pyramid", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Tower", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lair", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Caldera", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Park", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shrine", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Palace", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Sunken City", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Reef", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vaults of Atziri", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lighthouse", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Maze", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Residence", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Bone Crypt", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Geode", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Estuary", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Vault", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Overgrown Shrine", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Racecourse", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ghetto", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arsenal", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Courthouse", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cemetery", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shipyard", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Belfry", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Crystal Ore", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Malformation", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Desert Spring", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Plaza", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dig", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Hallowed Ground", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Port", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Chateau", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Conservatory", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ancient City", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Underground Sea", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Bazaar", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Waste Pool", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Spider Forest", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Factory", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Villa", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Necropolis", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Infested Valley", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Museum", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Wasteland", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Precinct", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Orchard", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Acid Caverns", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Crimson Temple", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Basilica", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Carcass", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Putrid Cloister", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Graveyard", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cells", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Volcano", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Phantasmagoria", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Atoll", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Underground River", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arachnid Nest", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Shore", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Sepulchre", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Temple", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Pit", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Defiled Cathedral", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Summit", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Primordial Blocks", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Terrace", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Core", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Colosseum", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lava Lake", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Dungeon", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Coral Ruins", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Laboratory", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Courtyard", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mud Geyser", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mineral Pools", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arena", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Scriptorium", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Promenade", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Waterways", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Castle Ruins", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Canyon", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Siege", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Colonnade", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Coves", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dark Forest", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Iceberg", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Toxic Sewer", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Academy", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lava Chamber", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Dunes", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Overgrown Ruin", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Moon Temple", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Plateau", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Bog", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Primordial Pool", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pit of the Chimera", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lair of the Hydra", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Maze of the Minotaur", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Forge of the Phoenix", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vaal Temple", Tier = 16 } });
            #endregion
        }


        public static bool Filter(object item, string filter)
        {
            var map = (MapViewModel)item;

            return map.Map.Name.ToLower().Contains(filter.ToLower());
        }

        /// <summary>
        /// Sets all <c>IsChecked</c> of maps in <see cref="MapListMain"/> to false.
        /// </summary>
        public static void Clear()
        {
            foreach (MapViewModel map in MapListMain)
            {
                if (map.IsChecked)
                {
                    map.IsChecked = false;
                }
            }
        }
    }
}