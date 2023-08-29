using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace taiterraria.Content.Items.Weapons
{
    internal class silverslicer : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 70;
            Item.height = 70;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;
            Item.value = Item.sellPrice(gold: 1);
            // Damage Values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 20;
            Item.knockBack = 3;
            Item.crit = 10;

            // Misc
            Item.SetNameOverride("Silver Slicer");
            Item.rare = ItemRarityID.Blue;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverBar, 30);
            recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
    }
}