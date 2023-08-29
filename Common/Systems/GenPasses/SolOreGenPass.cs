using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using Taiterraria.Content.Tiles;
using Terraria.ID;

namespace Taiterraria.Common.Systems.GenPasses
{
    internal class TutorialOreGenPass : GenPass
    {
        public TutorialOreGenPass(string name, float weight) : base(name, weight) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning Taite MOD Ores";

            // SOL ore
            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            for(int i = 0; i < maxToSpawn; i++)
            {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)GenVars.worldSurface, Main.maxTilesY - 300);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<SolOre>());
            }

           
        }
    }
}