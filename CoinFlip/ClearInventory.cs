using Exiled.API.Features;
using Exiled.API.Features.Items;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void ClearInventory(Player player, Item item)
        {
            player.ClearInventory();
        }

    }
}
