using Exiled.API.Features;
using Mirror;

namespace CoinGamble
{
    public class TestPlugin : Plugin<Config>
    {
        internal CoinFlip.ActionPick GenHandler { get; private set; }
        public override string Name => "Coin Gamble Plugin";
        public override string Prefix => "FirstPlugin";
        public override string Author => "Trixder";

        public override void OnEnabled()
        {
            Log.Info($"{Name} has been enabled!");

            SubscribeEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnsubscribeEvents();
            base.OnDisabled();

            Log.Info($"{Name} has been disabled!");
        }

        protected void SubscribeEvents()
        {
            GenHandler = new(Config, NetworkManager.singleton.spawnPrefabs);

            Exiled.Events.Handlers.Player.FlippingCoin += GenHandler.OnCoinFlip;
        }   

        protected void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.FlippingCoin -= GenHandler.OnCoinFlip;

            GenHandler = null;
        }
    }
}
