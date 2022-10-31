using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Darksteel
{
    [AutoloadEquip(EquipType.Head)]
    internal class DarksteelHeadMelee : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darksteel Mask");
            Tooltip.SetDefault("A fragment of shadows\n10% increased melee damage and critical strike chance");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 120000;
            Item.rare = ItemRarityID.Purple;
            Item.defense = 38;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += 0.1f;
            player.GetCritChance(DamageClass.Melee) += 10;
            Lighting.AddLight(new Vector2(player.position.X, player.position.Y), 0.6f, 0.4f, 0.4f);
        }
    }
}
