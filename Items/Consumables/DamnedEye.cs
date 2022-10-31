using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RetributionMod.Items.Consumables
{
    internal class DamnedEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Damned Eye");
            Tooltip.SetDefault("Permanently increases maximum life by 25\nCan only be used once");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item4;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 32;
            Item.height = 32;
            Item.value = 3000;
        }

        public override bool CanUseItem(Player player)
        {
            return player.GetModPlayer<RetributionPlayer>().DamnedEye == false;
        }

        public override bool? UseItem(Player player)
        {
            if (!player.GetModPlayer<RetributionPlayer>().DamnedEye)
            {
                player.GetModPlayer<RetributionPlayer>().DamnedEye = true;
                player.statLife += 25;
                if (Main.myPlayer == player.whoAmI)
                {
                    player.HealEffect(15, true);
                }
                return true;
            }
            return false;
        }

    }
}
