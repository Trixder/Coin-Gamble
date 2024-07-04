using Exiled.API.Features;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void DropInventory(Player player)
        {
            player.DropItems();
        }
    }
}
