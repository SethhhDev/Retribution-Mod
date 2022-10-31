using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader.IO;

namespace RetributionMod
{
    internal class RetributionPlayer : ModPlayer
    {
        public bool BlindlessHeart = false;
        public bool DamnedEye = false;

        public override void ResetEffects()
        {
            BlindlessHeart = false;
        }

        public override void SaveData(TagCompound tag)
        {
            tag["damnedEye"] = DamnedEye;
        }

        public override void LoadData(TagCompound tag)
        {
            DamnedEye = tag.GetBool("damnedEye");
        }

        public override void UpdateEquips()
        {
            if (DamnedEye)
            {
                Player.statLifeMax2 += 25;
            }
        }
    }
}
