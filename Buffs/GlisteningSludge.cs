using Terraria;
using Terraria.ModLoader;

namespace RetributionMod.Buffs
{
    internal class GlisteningSludge : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glistening Sludge");
            Description.SetDefault("A glistening sludge follows the player around, engulfing enemies and dealing contact damage to them.");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            RetributionPlayer modPlayer = player.GetModPlayer<RetributionPlayer>();
            if (player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Minions.GlisteningSludge>()] > 0)
            {
                modPlayer.glisteningSludge = true;
            }
            if (!modPlayer.glisteningSludge)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}
