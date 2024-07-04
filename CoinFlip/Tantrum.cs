using Exiled.API.Features;
using Exiled.API.Features.Items;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void Tantrum(Player player, Item item)
        {
            player.RemoveItem(item, true);
            Map.PlaceTantrum(player.Position);
        }
    }
}
