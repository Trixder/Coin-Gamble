using Exiled.API.Features;
using Exiled.API.Features.Items;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void Snitch(Player player, Item item)
        {
            player.RemoveItem(item, true);

            Exiled.API.Features.Broadcast message = new Exiled.API.Features.Broadcast(config.SnitchPlayer.Content, config.SnitchPlayer.Duration);
            message.Content = message.Content.Replace("%PlayerName%", player.Nickname);
            message.Content = message.Content.Replace("%PlayerZone%", player.Zone.ToString());


            Map.Broadcast(message);
        }

    }
}
