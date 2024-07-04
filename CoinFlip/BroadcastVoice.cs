using Exiled.API.Features;
using Exiled.API.Features.Items;
using MEC;
using System.Collections.Generic;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private IEnumerator<float> BroadcastVoice(Player player, Item item)
        {
            Exiled.API.Features.Broadcast message = config.BroadcastCoinMessage;
            message.Content = message.Content.Replace("%CoinBroadcastTime%", config.CoinBroadcastTime.ToString());
            player.Broadcast(message);

            player.RemoveItem(item, true);

            player.VoiceChannel = VoiceChat.VoiceChatChannel.ScpChat;
            Log.Info(player.VoiceChannel);

            PlayerRoles.Voice.Intercom.TrySetOverride(player.ReferenceHub, true);
            yield return Timing.WaitForSeconds(config.CoinBroadcastTime);
            PlayerRoles.Voice.Intercom.TrySetOverride(player.ReferenceHub, false);
        }

    }
}
