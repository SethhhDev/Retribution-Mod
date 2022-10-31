using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using RetributionMod.Items;

namespace RetributionMod.Content
{
    internal class RecipeGroups : ModSystem
    {
        public static RecipeGroup RecipeGroup;
        public override void Unload()
        {
            RecipeGroup = null;
        }

        public override void AddRecipeGroups()
        {
           RecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ModContent.ItemType<Items.Darksteel.Darksteel>())}",
                ModContent.ItemType<Items.Darksteel.DarksteelHeadMelee>(), ModContent.ItemType<Items.Darksteel.DarksteelHeadRanged>(), 
                ModContent.ItemType<Items.Darksteel.DarksteelHeadMagic>(), ModContent.ItemType<Items.Darksteel.DarksteelCuirass>(), 
                ModContent.ItemType<Items.Darksteel.DarksteelGreaves>());
        }
    }
}
