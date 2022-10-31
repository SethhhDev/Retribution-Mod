using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RetributionMod.Items.Accessories
{
    internal class BlindlessHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blindless Heart");
            Tooltip.SetDefault("15% increased damage and critical strike chance\n'The heart of thou who see'");
        }
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 1;
            Item.width = 32;
            Item.height = 32;
            Item.value = 3000;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.15f;
            player.GetCritChance(DamageClass.Generic) += 0.15f;
            player.GetModPlayer<RetributionPlayer>().BlindlessHeart = true;
        }
    }
}
