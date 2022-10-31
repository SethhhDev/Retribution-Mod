using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using RetributionMod.Tiles.Aquabright;
using System.Diagnostics;
using Terraria.ID;
using System;

namespace RetributionMod.Common.System.GenPasses
{
    internal class AquabrightOreGenPass : GenPass
    {
        public AquabrightOreGenPass(string name, float weight) : base(name, weight) { }


        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
           progress.Message = "Eroding the ocean";

            // Aquabright Ore Ocean Gen
            int MaxVeins = (int)(Main.maxTilesX * Main.maxTilesY * 0.00012);
            for(int i = 0; i < MaxVeins; i++)
            {
                // Start Vein
            int x = WorldGen.genRand.Next(-200, (int)(Main.maxTilesX * Main.maxTilesY * 0.00005));
            int y = WorldGen.genRand.Next((int)WorldGen.worldSurface - 100, (int)WorldGen.worldSurface - 5);
            if (x < 150)
                {
                    y = WorldGen.genRand.Next((int)WorldGen.worldSurface - 100, (int)WorldGen.worldSurface + 50);
                }
            if (Framing.GetTileSafely(x, y).TileType == TileID.Sand)
                {
                    WorldGen.PlaceTile(x, y, ModContent.TileType<AquabrightOre>(), false, true);
                    int NextGen = WorldGen.genRand.Next(1, 4);
                    if (NextGen == 1)
                    {
                        WorldGen.PlaceTile(x - 1, y, ModContent.TileType<AquabrightOre>(), false, true);
                        NextGen = WorldGen.genRand.Next(1, 2);
                        
                        if (NextGen == 1)
                        {
                            WorldGen.PlaceTile(x - 2, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                        else if (NextGen == 2)
                        {
                            WorldGen.PlaceTile(x + 2, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }

                    } 
                    else if (NextGen == 2)
                    {
                        WorldGen.PlaceTile(x + 1, y, ModContent.TileType<AquabrightOre>(), false, true);
                        NextGen = WorldGen.genRand.Next(1, 2);

                        if (NextGen == 1)
                        {
                            WorldGen.PlaceTile(x - 2, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                        else if (NextGen == 2)
                        {
                            WorldGen.PlaceTile(x + 2, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                    }
                    else if (NextGen == 3)
                    {
                        WorldGen.PlaceTile(x, y - 1, ModContent.TileType<AquabrightOre>(), false, true);
                        NextGen = WorldGen.genRand.Next(1, 2);

                        if (NextGen == 1)
                        {
                            WorldGen.PlaceTile(x - 1, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                        else if (NextGen == 2)
                        {
                            WorldGen.PlaceTile(x + 1, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                    }
                    else if (NextGen == 4)
                    {
                        WorldGen.PlaceTile(x, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        NextGen = WorldGen.genRand.Next(1, 2);

                        if (NextGen == 1)
                        {
                            WorldGen.PlaceTile(x - 1, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                        else if (NextGen == 2)
                        {
                            WorldGen.PlaceTile(x + 1, y + 1, ModContent.TileType<AquabrightOre>(), false, true);
                        }
                    }
                }
            }
        }
    }
}
