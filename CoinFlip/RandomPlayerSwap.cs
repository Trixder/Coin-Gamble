using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using InventorySystem;
using PlayerRoles;
using System.Collections.Generic;
using UnityEngine;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void RandomPlayerSwap(Player player, Item item)
        {
            List<Player> players = new List<Player>();

            if (config.IncludeTutorial) players.AddRange(Player.Get(Side.Tutorial));
            players.AddRange(Player.Get(Side.ChaosInsurgency));
            players.AddRange(Player.Get(Side.Mtf));
            players.AddRange(Player.Get(Side.Scp));
            players.AddRange(Player.Get(Side.None));

            players.Remove(player);

            int playerNum = UnityEngine.Random.Range(0, players.Count - 1);

            if (players.Count <= 0) return;

            player.RemoveItem(item, true);

            Player selectedPlayer = players[playerNum];

            if (selectedPlayer.Role.Type != RoleTypeId.Spectator)
            {
                Vector3 selectedPlayerPos = selectedPlayer.Position;

                selectedPlayer.Teleport(player.Position);
                player.Teleport(selectedPlayerPos);
            }
            else
            {
                selectedPlayer.Role.Set(player.Role, RoleSpawnFlags.None);

                selectedPlayer.Teleport(player.Position);

                InventoryInfo inv = selectedPlayer.Inventory.UserInventory;
                selectedPlayer.Inventory.UserInventory = player.Inventory.UserInventory;
                player.Inventory.UserInventory = inv;

                player.Role.Set(RoleTypeId.Spectator, RoleSpawnFlags.All);
            }
        }
    }
}
