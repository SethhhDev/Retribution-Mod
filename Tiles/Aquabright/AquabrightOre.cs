using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace RetributionMod.Tiles.Aquabright
{
    public class AquabrightOre : ModTile
    {
        public override void PostSetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true; 
            Main.tileShine2[Type] = true; 
            Main.tileShine[Type] = 100; 
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Aquabright Ore");
            AddMapEntry(new Color(0, 80, 100), name);

            DustType = 84;
            ItemDrop = ModContent.ItemType<Items.Aquabright.AquabrightOre>();
            HitSound = SoundID.Tink;
            MineResist = 4f;
            MinPick = 66;
        }
    }
}
