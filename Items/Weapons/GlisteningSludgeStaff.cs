using Microsoft.Xna.Framework;
using RetributionMod.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Weapons
{
    internal class GlisteningSludgeStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glistening Sludge Staff");
            Tooltip.SetDefault("Summons a Gistening Sludge to fight for you");
        }

        public override void SetDefaults()
        {
            Item.damage = 18;
            Item.knockBack = 4f;
            Item.mana = 10;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.value = Item.buyPrice(0, 50, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item44;

            Item.noMelee = true;
            Item.buffType = ModContent.BuffType<Buffs.GlisteningSludge>();
            Item.shoot = ModContent.ProjectileType<Projectiles.Minions.GlisteningSludge>();
            Item.DamageType = DamageClass.Summon;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            player.AddBuff(Item.buffType, 2);

            position = Main.MouseWorld;
            return true;
        }
    }
}
