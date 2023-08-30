using Taiterraria.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace Taiterraria.Content.Pets.Solpet
{
	public class ExamplePetItem : ModItem
	{
		public override void SetStaticDefaults() {
			// Names and descriptions of all ExamplePetX classes are defined using .hjson files in the Localization folder
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.Penguin); // Copy the Defaults of the Zephyr Fish Item.

			Item.shoot = ModContent.ProjectileType<ExamplePetProjectile>(); // "Shoot" your pet projectile.
			Item.buffType = ModContent.BuffType<ExamplePetBuff>(); // Apply buff upon usage of the Item.
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(Item.buffType, 3600);
			}
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Content.Items.Consumables.LifeCrystalMilk>(1)
				.AddIngredient<Content.Items.Placeables.SolBar>(10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
