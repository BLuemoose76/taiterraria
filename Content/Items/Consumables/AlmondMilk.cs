using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Taiterraria.Content.Items.Consumables
{
	public class AlmondMilk : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 5;

			
			Main.RegisterItemAnimation(Type, new DrawAnimationVertical(int.MaxValue, 1));

			
			ItemID.Sets.FoodParticleColors[Item.type] = new Color[3] {
				new Color(225, 225, 225),
				new Color(225, 225, 225),
				new Color(129, 100, 55)
			};

			ItemID.Sets.IsFood[Type] = true; 
		}

		public override void SetDefaults() {
			

			
			Item.DefaultToFood(22, 22, BuffID.WellFed3, 100); // 57600 is 16 minutes: 16 * 60 * 60
			Item.value = Item.buyPrice(0, 3);
			Item.rare = ItemRarityID.Blue;
		}

		
		
		public override void OnConsumeItem(Player player) {
			player.AddBuff(BuffID.Sunflower, 3600);
		}

		
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(126,1)
				.AddIngredient(27, 10)
				.AddTile(18)
				.Register();
		}
	}
}