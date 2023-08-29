using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


//!remove this test


namespace taiterraria.Content.Items.Weapons
{
    public class testgun : ModItem
    {
        

        public override void SetDefaults()
        {
    Item.width = 42;
            Item.height = 30;

            Item.useTime = 14;
            Item.useAnimation = 14;

            Item.useStyle = ItemUseStyleID.Shoot;

            Item.autoReuse = true;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 25;
            Item.knockBack = 3f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 5f;

            Item.useAmmo = AmmoID.Bullet;
    Item.SetNameOverride("Test gun");
}


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverBar, 60); // Ingredients for crafting
            // Add more ingredients if needed
            recipe.AddTile(TileID.Anvils); // Crafting station
        
            recipe.Register();
        }
    }
}
