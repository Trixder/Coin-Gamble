using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using UnityEngine;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void RandomTeleport(Player player, Item item)
        {
            if (item != null) player.RemoveItem(item, true);

            Room room = Room.Random(ZoneType.Unspecified);

            if (room.RoomName.ToString() == "EzEvacShelter" | room.RoomName.ToString() == "EzCollapsedTunnel" | room.RoomName.ToString() == "Lcz173")
            {
                RandomTeleport(player, null);
                return;
            }

            if (room.RoomName.ToString() == "Pocket")
            {
                player.EnableEffect(EffectType.PocketCorroding);
            }

            player.Teleport(room.Position + new Vector3(0, player.Transform.localScale.y, 0));
        }
    }
}
