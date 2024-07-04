using Exiled.API.Features;
using Exiled.API.Features.Items;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void ChangeSize(Player player, Item item)
        {
            player.RemoveItem(item, true);
            player.Scale = config.PlayerSizeAfterFlip;
        }

    }
}
