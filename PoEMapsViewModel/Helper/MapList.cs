using System.Collections.ObjectModel;
using PoEMapsModel.Maps;

namespace PoEMapsViewModel.Helper
{
    public class MapList
    {
        public static ObservableCollection<MapViewModel> MapListMain = new ObservableCollection<MapViewModel>();

        public static void GetMaps()
        {
            #region Add maps
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Coward's Trial", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cursed Crypt Map", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Fungal Hollow Map", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Alleyways Map", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Iceberg Map", Tier = 1 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Whakawairua Tuahu", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ramparts Map", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Strand Map", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Peninsula Map", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Excavation Map", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Haunted Mansion Map", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dungeon Map", Tier = 2 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Maelström of Chaos", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Doryani's Machinarium", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arid Lake Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ashen Wood Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Leyline Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Desert Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Jungle Valley Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Atoll Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Maze Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Barrows Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Spider Lair Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Channel Map", Tier = 3 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mausoleum Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Port Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Flooded Mine Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Beach Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Armoury Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lookout Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "City Square Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Glacier Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arcade Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Underground Sea Map", Tier = 4 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Vinktar Square", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Sulphur Vents Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Marshes Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Grotto Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Courtyard Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ancient City Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pen Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Thicket Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cage Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Crater Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Graveyard Map", Tier = 5 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Death and Taxes", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Hall of Grandmasters", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Acton's Nightmare", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lair Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Burial Chambers Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Sepulchre Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Promenade Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Geode Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Residence Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vault Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Overgrown Shrine Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Necropolis Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Primordial Pool Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pit Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cursed Crypt Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Fungal Hollow Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Alleyways Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Iceberg Map", Tier = 6 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mao Kun", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Olmec's Sanctum", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Bazaar Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Fields Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ghetto Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Spider Forest Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mineral Pools Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Estuary Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Academy Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pier Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shore Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mud Geyser Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Bone Crypt Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ramparts Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Strand Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Peninsula Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Excavation Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Haunted Mansion Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Dungeon Map", Tier = 7 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pillars of Arun", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Hallowed Ground", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Waterways Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dunes Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arachnid Tomb Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Conservatory Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Orchard Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cemetery Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Toxic Sewer Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lava Chamber Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lighthouse Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Phantasmagoria Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Volcano Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arid Lake Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ashen Wood Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Leyline Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Desert Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Jungle Valley Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Atoll Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Maze Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Barrows Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Spider Lair Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Channel Map", Tier = 8 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Poorjoy's Asylum", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vaults of Atziri", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Caer Blaidd, Wolfpack's Den", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Putrid Cloister", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Museum Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Laboratory Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Villa Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Temple Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Castle Ruins Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Canyon Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Tropical Island Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vaal Pyramid Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Underground River Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Coral Ruins Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Cells Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mausoleum Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Port Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Flooded Mine Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Beach Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Armoury Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lookout Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped City Square Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Glacier Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arcade Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Underground Sea Map", Tier = 9 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Twilight Temple", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "The Perandus Manor", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Mesa Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arachnid Nest Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Factory Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Moon Temple Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Chateau Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Relic Chambers Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Scriptorium Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Plateau Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Overgrown Ruin Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Wharf Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Sulphur Vents Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Marshes Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Grotto Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Courtyard Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ancient City Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Pen Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Thicket Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cage Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Crater Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Graveyard Map", Tier = 10 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Basilica Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Wasteland Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arena Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Palace Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Desert Spring Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dig Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Coves Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Arsenal Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Bog Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Infested Valley Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lair Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Burial Chambers Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Sepulchre Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Promenade Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Geode Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Residence Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Vault Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Overgrown Shrine Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Necropolis Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Primordial Pool Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Pit Map", Tier = 11 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Malformation Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Reef Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Precinct Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Courthouse Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Sunken City Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Crystal Ore Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Acid Caverns Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Carcass Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Terrace Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Bazaar Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Fields Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Ghetto Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Spider Forest Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mineral Pools Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Estuary Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Academy Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Pier Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Shore Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mud Geyser Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Bone Crypt Map", Tier = 12 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Summit Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Tower Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Crimson Temple Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Colosseum Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Park Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Gardens Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Siege Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shipyard Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Colonnade Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Waterways Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Dunes Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arachnid Tomb Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Conservatory Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Orchard Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cemetery Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Toxic Sewer Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lava Chamber Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Lighthouse Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Phantasmagoria Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Volcano Map", Tier = 13 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Ivory Temple Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Belfry Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shrine Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Caldera Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Plaza Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Primordial Blocks Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Racecourse Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Museum Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Laboratory Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Villa Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Temple Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Castle Ruins Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Canyon Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Tropical Island Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Vaal Pyramid Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Underground River Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Coral Ruins Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Cells Map", Tier = 14 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lava Lake Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Core Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Defiled Cathedral Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Dark Forest Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Waste Pool Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Mesa Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Arachnid Nest Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Factory Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Moon Temple Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Chateau Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Relic Chambers Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Scriptorium Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Plateau Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Overgrown Ruin Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Shaped Wharf Map", Tier = 15 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Pit of the Chimera Map", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Lair of the Hydra Map", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Maze of the Minotaur Map", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Forge of the Phoenix Map", Tier = 16 } });
            MapListMain.Add(new MapViewModel { Map = new Map { Name = "Vaal Temple Map", Tier = 16 } });
            #endregion
        }

        public static bool Filter(object item, string filter)
        {
            var map = (MapViewModel)item;

            return map.Map.Name.ToLower().Contains(filter.ToLower());
        }

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