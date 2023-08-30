using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace taiterraria.Content.Items.Weapons
{
    internal class BigStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            
            Item.width = 36;
            Item.height = 118;

        
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 27;
            Item.autoReuse = true;
            Item.value = Item.sellPrice(silver: 10);
           
            Item.DamageType = DamageClass.Melee;
            Item.damage = 3;
            Item.knockBack = 3;
            Item.crit = 20;

            
            Item.SetNameOverride("Big Stick");
            Item.rare = ItemRarityID.Green;

            
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 30);
			
			recipe.Register();
		}
    }
}