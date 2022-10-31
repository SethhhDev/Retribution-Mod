using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Darksteel
{
    internal class Darksteel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darksteel");
            Tooltip.SetDefault("'You feel the shadows pulsating from this fragment'");
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 999;
            Item.value = 1000;
            Item.rare = ItemRarityID.Purple;
        }
    }
}
