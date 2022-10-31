using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Darksteel
{
    [AutoloadEquip(EquipType.Head)]
    internal class DarksteelHeadMagic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darksteel Necrohood");
            Tooltip.SetDefault("A fragment of shadows\nIncreases maximum mana by 150\n10% increased magic damage and critical strike chance");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 120000;
            Item.rare = ItemRarityID.Purple;
            Item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Magic) += 0.1f;
            player.GetCritChance(DamageClass.Magic) += 10;
            player.statManaMax2 += 150;
            Lighting.AddLight(new Vector2(player.position.X, player.position.Y), 0.6f, 0.4f, 0.4f);
        }
    }
}
