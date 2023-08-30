using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Taiterraria.Content.Items.Consumables
{
	public class LifeCrystalMilk : ModItem
    {
		public static LocalizedText RestoreLifeText { get; private set; }

		public override void SetStaticDefaults() {
			RestoreLifeText = this.GetLocalization(nameof(RestoreLifeText));

			Item.ResearchUnlockCount = 30;
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.maxStack = 30;
			Item.consumable = true;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 2);

			Item.healLife = 100;
			Item.potion = true; 
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			
			TooltipLine line = tooltips.FirstOrDefault(x => x.Mod == "Terraria" && x.Name == "HealLife");

			if (line != null) {
			
				line.Text = Language.GetTextValue("CommonItemTooltip.RestoresLife", RestoreLifeText.Format(Main.LocalPlayer.statLifeMax2 / 2, Main.LocalPlayer.statLifeMax2 / 4));
			}
		}

		public override void GetHealLife(Player player, bool quickHeal, ref int healValue) {
			
			healValue = player.statLifeMax2 / (quickHeal ? 4 : 2);
		}

		
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(29)
                .AddIngredient<Content.Items.Consumables.AlmondMilk>()
				.AddTile(18) 
				.Register();
		}
	}
}