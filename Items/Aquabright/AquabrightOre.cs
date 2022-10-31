using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RetributionMod.Items.Aquabright
{
    internal class AquabrightOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
            Tooltip.SetDefault("'Formed from oceanic erosion over time'");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.rare = ItemRarityID.Green;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Aquabright.AquabrightOre>();
            Item.width = 27;
            Item.height = 27;
            Item.value = 3000;
        }
    }
}
