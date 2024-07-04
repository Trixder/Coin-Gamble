using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups.Projectiles;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        public void SpawnProjectile(Player player, Item item)
        {
            player.RemoveItem(item, true);

            float chance = UnityEngine.Random.Range(0f, 100f);


            float probability = config.LightChance;
            if (chance < probability)
            {
                ExplosionGrenadeProjectile.CreateAndSpawn(ProjectileType.Scp2176, player.Position, player.Rotation, true, null);
                return;
            }

            probability += config.BallonChance;
            if (chance < probability)
            {
                ExplosionGrenadeProjectile.CreateAndSpawn(ProjectileType.Scp018, player.Position, player.Rotation, true, null);
                return;
            }

            probability += config.FlashChance;
            if (chance < probability)
            {
                ExplosionGrenadeProjectile.CreateAndSpawn(ProjectileType.Flashbang, player.Position, player.Rotation, true, null);
                return;
            }

            probability += config.GranadeChance;
            if (chance < probability)
            {
                ExplosionGrenadeProjectile.CreateAndSpawn(ProjectileType.FragGrenade, player.Position, player.Rotation, true, null);
                return;
            }
        }
    }
}
