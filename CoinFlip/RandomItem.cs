using Exiled.API.Features;
using Exiled.API.Features.Items;
using System;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        public static void RandomItem(Player player, Item item)
        {
            player.RemoveItem(item, true);
            ItemType itemType = (ItemType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(ItemType)).Length - 1);
            player.AddItem(itemType);
        }
    }
}
