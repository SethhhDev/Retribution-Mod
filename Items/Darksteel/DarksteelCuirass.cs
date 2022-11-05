using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Darksteel
{
    [AutoloadEquip(EquipType.Body)]
    internal class DarksteelCuirass : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darksteel Cuirass");
            Tooltip.SetDefault("A fragment of shadows\nImmunity to 'Voidstruck'\n10% increased damage and 4% increased critical strike chance");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = 100000;
            Item.rare = ItemRarityID.Purple;
            Item.defense = 43;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return legs.type == ModContent.ItemType<DarksteelGreaves>() && body.type == ModContent.ItemType<DarksteelCuirass>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Immunity to 'Voidstruck'";
        }
          public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
            player.armorEffectDrawShadowSubtle = true;
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadowLokis = true;
            player.armorEffectDrawOutlinesForbidden = true;
            player.armorEffectDrawShadowEOCShield = true;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Generic) += 0.05f;
            player.GetCritChance(DamageClass.Generic) += 4;
            Lighting.AddLight(new Vector2(player.position.X, player.position.Y), 0.6f, 0.4f, 0.4f);
        }

        public override void AddRecipes()
        {
            // Head(s)
           
            Recipe recipe = Recipe.Create(ModContent.ItemType<DarksteelHeadMelee>());
            recipe.AddIngredient(ModContent.ItemType<Darksteel>(), 6);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DarksteelHeadRanged>());
            recipe.AddIngredient(ModContent.ItemType<Darksteel>(), 6);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DarksteelHeadMagic>());
            recipe.AddIngredient(ModContent.ItemType<Darksteel>(), 6);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Body
            recipe = Recipe.Create(ModContent.ItemType<DarksteelCuirass>());
            recipe.AddIngredient(ModContent.ItemType<Darksteel>(), 16);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Legs
            recipe = Recipe.Create(ModContent.ItemType<DarksteelGreaves>());
            recipe.AddIngredient(ModContent.ItemType<Darksteel>(), 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
