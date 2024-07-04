using Exiled.API.Features;
using Exiled.API.Features.Items;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        public static void RandomEffect(Player player, Item item)
        {
            player.RemoveItem(item, true);
            player.ApplyRandomEffect();
        }
    }
}
