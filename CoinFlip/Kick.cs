using Exiled.API.Features;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void Kick(Player player)
        {
            DropInventory(player);
            player.Kick(config.CoinKickReason);
        }

    }
}
