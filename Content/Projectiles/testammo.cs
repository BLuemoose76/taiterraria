using Terraria;
using Terraria.ModLoader;

namespace Taiterraria.Content.Projectiles
{
    public class testammo : ModProjectile
    {
       

        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 8;

            Projectile.aiStyle = 1;

            Projectile.friendly = true;
            Projectile.hostile = false;

            Projectile.penetrate = 5;

            Projectile.timeLeft = 600;

            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;

            Projectile.extraUpdates = 1;

            Projectile.aiStyle = 0;
        }

        
    }
}
