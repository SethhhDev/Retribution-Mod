using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using RetributionMod.Items.Weapons;

namespace RetributionMod.Projectiles
{
    internal class GlobalProj : GlobalProjectile
    {
        public bool GlisteningDust = false;
        public override void AI(Projectile projectile)
        {
            if (GlisteningDust == true)
            {
                if(Main.rand.Next(1, 6) == 1)
                {
                    Dust.NewDust(projectile.position, 2, 2, DustID.BlueCrystalShard, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
                }
                if (Main.rand.Next(1, 6) == 1)
                {
                    Dust.NewDust(projectile.position, 2, 2, DustID.PurpleCrystalShard, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
                }
                Lighting.AddLight(projectile.position, 0.55f, 0.4f, 0.7f);
            }
        }

        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
            if(GlisteningDust == true)
            {
                target.AddBuff(BuffID.OnFire, 100);
            }
        }

        public override void OnHitPvp(Projectile projectile, Player target, int damage, bool crit)
        {
            if (GlisteningDust == true)
            {
                target.AddBuff(BuffID.OnFire, 100);
            }
        }

        public override bool InstancePerEntity => true;
    }
}
