using Exiled.API.Features;
using Mirror;
using System;

namespace CoinGamble
{
    public class CoinGamble : Plugin<Config>
    {
        internal CoinFlip.ActionPick GenHandler { get; private set; }
        public override string Name => "Coin Gambling Plugin";
        public override string Prefix => "CoinGamble";
        public override string Author => "Trixder";
        public override Version Version => new Version(1, 0, 0);

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
