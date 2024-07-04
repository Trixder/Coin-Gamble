using Exiled.API.Features;
using Exiled.API.Features.Items;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void TurnOnNuke(Player player, Item item)
        {
            if (Warhead.IsInProgress | Warhead.IsLocked | Warhead.IsDetonated) return;
            player.RemoveItem(item, true);
            Warhead.Start();
        }

    }
}
