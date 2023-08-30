using Terraria;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.ID;
using Terraria.ModLoader;

namespace Taiterraria.Content.Tiles
{
    internal class Blender : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true; 
            Main.tileNoAttach[Type] = true; 
            Main.tileLavaDeath[Type] = false; 
            Main.tileTable[Type] = false; 

            TileID.Sets.DisableSmartCursor[Type] = true; 
            TileID.Sets.IgnoredByNpcStepUp[Type] = true; 

             

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2); // Copying the existing style of 2x1
            //TileObjectData.newTile.CoordinateHeights = new[] { 32 }; // Telling Terraria that each "cell" is 18 pixels
            TileObjectData.addTile(Type); // Adding the tile type to this style

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);

            AddMapEntry(new Microsoft.Xna.Framework.Color(0, 0, 0), CreateMapEntryName());
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int itemType = ModContent.ItemType<Content.Items.Placeables.Blender>();

            Item.NewItem(
                new EntitySource_TileBreak(i, j),
                i * 16,
                j * 16,
                32,
                16,
                itemType
            );
        }
    }
}   