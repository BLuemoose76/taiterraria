using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Taiterraria.Content.Pets.Solpet
{
	public class SolPetProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			Main.projFrames[Projectile.type] = 1;
			Main.projPet[Projectile.type] = true;
		}

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.Penguin); // Copy the stats of Z Penguin

			AIType = ProjectileID.Penguin; // Copy the AI of  Z Penguin
		}

		public override bool PreAI() {
			Player player = Main.player[Projectile.owner];

			player.zephyrfish = false; // Relic from aiType

			return true;
		}

		public override void AI() {
			Player player = Main.player[Projectile.owner];

			// Keep the projectile from disappearing as long as the player isn't dead and has the pet buff.
			if (!player.dead && player.HasBuff(ModContent.BuffType<SolPetBuff>())) {
				Projectile.timeLeft = 2;
			}
		}
	}
}
