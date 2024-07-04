using Exiled.API.Features;
using Exiled.API.Features.Items;
using MEC;
using System.Collections.Generic;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private IEnumerator<float> GodMode(Player player, Item item)
        {
            Exiled.API.Features.Broadcast message = config.GodModeCoinMessage;
            message.Content = message.Content.Replace("%CoinGodModeTime%", config.CoinGodModeTime.ToString());
            player.Broadcast(message);

            player.RemoveItem(item, true);

            player.IsGodModeEnabled = true;
            yield return Timing.WaitForSeconds(config.CoinGodModeTime);
            player.IsGodModeEnabled = false;
        }

    }
}
