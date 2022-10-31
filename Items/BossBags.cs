using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RetributionMod.Items.Accessories;
using RetributionMod.Items.Consumables;

namespace RetributionMod.Items
{
    internal class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            // Eye of Cthulhu
            if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag)
            {
                if (Main.rand.Next(1, 5) == 1)
                {
                    player.QuickSpawnItem(player.GetSource_OpenItem(arg), ModContent.ItemType<BlindlessHeart>(), 1);
                }
            }

            // Eater of Worlds
            if (context == "bossBag" && arg == ItemID.EaterOfWorldsBossBag)
            {
                if (Main.rand.Next(1, 6) == 1)
                {
                    player.QuickSpawnItem(player.GetSource_OpenItem(arg), ModContent.ItemType<DamnedEye>(), 1);
                }
            }
        }
    }
}
