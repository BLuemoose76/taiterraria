using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using Taiterraria.Common.Systems.GenPasses;

namespace Taiterraria.Common.Systems
{
    internal class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(t => t.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
              //  tasks.Insert(shiniesIndex + 1, new Taiterraria.Common.Systems.GenPasses.SolOreGenPass("Sol Ore Pass", 320f));
            }
        }
    }
}