using Microsoft.Xna.Framework;
using RetributionMod.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Weapons
{
    internal class GlisteningBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glistening Bow");
            Tooltip.SetDefault("'You feel the glistening energy within'");
        }

        public override void SetDefaults()
        {
            Item.damage = 17;
            Item.noMelee = true;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 8;
            Item.value = 4500;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 5f;
            Item.crit = 29;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile proj = Projectile.NewProjectileDirect(source, position, velocity, type, damage, knockback, player.whoAmI);
            proj.GetGlobalProjectile<GlobalProj>().GlisteningDust = true;
            return false;
        }

    }
}
