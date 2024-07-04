using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using PlayerRoles;
using System.Collections.Generic;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void SpawnSpectator(Player player, Item item)
        {
            List<Player> spectators = new List<Player>();
            spectators.AddRange(Player.Get(Side.None));

            int playerNum = UnityEngine.Random.Range(0, spectators.Count - 1);

            if (spectators.Count <= 0) return;

            player.RemoveItem(item, true);

            Player selectedPlayer = spectators[playerNum];

            if (selectedPlayer.Role.Type == RoleTypeId.Spectator)
            {
                selectedPlayer.Role.Set(player.Role, RoleSpawnFlags.All);
                selectedPlayer.Teleport(player.Position);
            }
            else return;
        }
    }
}
