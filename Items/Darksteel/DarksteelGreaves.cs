using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Darksteel
{
    [AutoloadEquip(EquipType.Legs)]
    internal class DarksteelGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darksteel Greaves");
            Tooltip.SetDefault("A fragment of shadows\n10% increased movement speed\n8% increased damage and critical strike chance");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = 80000;
            Item.rare = ItemRarityID.Purple;
            Item.defense = 39;
        }


        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.1f;
            player.GetDamage(DamageClass.Generic) += 0.08f;
            player.GetCritChance(DamageClass.Generic) += 8;
            Lighting.AddLight(new Vector2(player.position.X, player.position.Y), 0.6f, 0.4f, 0.4f);
        }

    }
}
