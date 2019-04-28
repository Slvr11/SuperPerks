using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinityScript;

namespace LotD
{
    public class LotD : BaseScript
    {
        public LotD()
        {
            PlayerConnected += LuckyPlayerConnected;
        }
        void LuckyPlayerConnected(Entity player)
        {
            player.SpawnedPlayer += () => OnPlayerSpawned(player);
            player.SetField("Tier", 0);
        }
        public void OnPlayerSpawned(Entity player)
        {
            Gamble(player);
            CheckPerks(player);
        }
        public override void OnPlayerKilled(Entity player, Entity inflictor, Entity attacker, int damage, string mod, string weapon, Vector3 dir, string hitLoc)
        {
        }
        public void Gamble(Entity player)
        {

        }
        public void CheckPerks(Entity player)
        {
            if (player.Call<bool>("hasperk", "specialty_extraammo"))
            {
                player.SetPerk("specialty_extendedmags", true, false);
            }
            if (player.Call<bool>("hasperk", "specialty_falldamage"))
            {
                //Add earthquake on damage here
            }
            if (player.Call<bool>("hasperk", "specialty_delaymine"))
            {
                //
            }
            if (player.Call<bool>("hasperk", "specialty_fastmantle"))
            {
                player.SetPerk("spacialty_automantle", true, false);
            }
            if (player.Call<bool>("hasperk", "specialty_selectivehearing"))
            {
                //
            }
        }
    }
}
