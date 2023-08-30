﻿using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Taiterraria.Content.Items.Placeables
{
    internal class Blender : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 15;
            Item.useAnimation = 15;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.autoReuse = true;
            Item.useTurn = true;

            Item.maxStack = 999;
            Item.consumable = true;

            Item.createTile = ModContent.TileType<Tiles.BLender>();
            Item.placeStyle = 0;
        }
    }
}