using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using RetributionMod.Tiles.Aquabright;
using Terraria.ID;
using RetributionMod.Common.System.GenPasses;
using System.Collections.Generic;

namespace RetributionMod.Common.System
{
    internal class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            /* int beachesIndex = tasks.FindIndex(t => t.Name.Equals("Create Ocean Caves"));
            if(beachesIndex != -1)
            {
                tasks.Insert(beachesIndex + 1, new AquabrightOreGenPass("Aquabright Ore Pass", 312f));
            } */
        }
    }
}
