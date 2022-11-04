using Microsoft.Xna.Framework;
using RetributionMod.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Items.Weapons
{
    internal class GlisteningSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glistening Spear");
        }

        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.crit = 32;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useAnimation = 23;
            Item.useTime = 29;
            Item.shootSpeed = 8.3f;
            Item.knockBack = 3.8f;
            Item.width = 32;
            Item.height = 32;
            Item.scale = 1f;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(silver: 55);

            Item.noMelee = true; 
            Item.noUseGraphic = true; 
            Item.autoReuse = true; 

            Item.UseSound = SoundID.Item29;
            Item.shoot = ModContent.ProjectileType<GlisteningSpearProjectile>();

            Item.DamageType = DamageClass.Melee;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
    }
}
