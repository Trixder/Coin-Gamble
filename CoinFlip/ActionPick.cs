using Exiled.Events.EventArgs.Player;
using MEC;
using System.Collections.Generic;
using UnityEngine;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private Config config;
        public List<GameObject> spawnPrefabs = new List<GameObject>();

        public ActionPick(Config config, List<GameObject> spawnPrefabs)
        {
            this.config = config;
            this.spawnPrefabs = spawnPrefabs;
        }

        internal void OnCoinFlip(FlippingCoinEventArgs ev)
        {
            float chance = Random.Range(0, 100);

            float probability = config.CoinRandomItem;
            if (chance < probability)
            {
                RandomItem(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinRandomRole;
            if (chance < probability)
            {
                RandomRole(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinRandomEffect;
            if (chance < probability)
            {
                RandomEffect(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinDropInventory;
            if (chance < probability)
            {
                DropInventory(ev.Player);
                return;
            }

            probability += config.CoinTeleport;
            if (chance < probability)
            {
                RandomTeleport(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinPlayerSwap;
            if (chance < probability)
            {
                RandomPlayerSwap(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinSpawnProjectile;
            if (chance < probability)
            {
                SpawnProjectile(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinSpawnSpectator;
            if (chance < probability)
            {
                SpawnSpectator(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinTantrum;
            if (chance < probability)
            {
                Tantrum(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinKick;
            if (chance < probability)
            {
                Kick(ev.Player);
                return;
            }

            probability += config.CoinNuke;
            if (chance < probability)
            {
                TurnOnNuke(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinClearInv;
            if (chance < probability)
            {
                ClearInventory(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinChanceSize;
            if (chance < probability)
            {
                ChangeSize(ev.Player, ev.Item);
                return;
            }

            probability += config.CoinBroadcastVoice;
            if (chance < probability)
            {
                Timing.RunCoroutine(BroadcastVoice(ev.Player, ev.Item));
                return;
            }

            probability += config.CoinGodMode;
            if (chance < probability)
            {
                Timing.RunCoroutine(GodMode(ev.Player, ev.Item));
                return;
            }

            probability += config.CoinSnitch;
            if (chance < probability)
            {
                Snitch(ev.Player, ev.Item);
                return;
            }
        }
    }
}
