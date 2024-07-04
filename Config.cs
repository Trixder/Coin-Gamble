using Exiled.API.Interfaces;
using System.ComponentModel;
using UnityEngine;

namespace CoinGamble
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages should be shown in the console.")]
        public bool Debug { get; set; } = false;


        [Description("Chance to die. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#")]
        public float DeathChance { get; set; } = 15;

        [Description("Chance to become zombie.")]
        public float ZombieChance { get; set; } = 15;

        [Description("Chance to become other role. #SHOULD ADD UP TO 100 HERE#")]
        public float OtherRoleChance { get; set; } = 70;


        [Description("Chance to become lesser role. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#")]
        public float LesserRoleChance { get; set; } = 75;

        [Description("Chance to become normal role.")]
        public float NormalRoleChance { get; set; } = 20;

        [Description("Chance to become supreme role. #SHOULD ADD UP TO 100 HERE#")]
        public float SupremeRoleChance { get; set; } = 5;


        [Description("Chance to spawn flash. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#")]
        public float FlashChance { get; set; } = 50;

        [Description("Chance to spawn granade.")]
        public float GranadeChance { get; set; } = 35;

        [Description("Chance to spawn SCP-018.")]
        public float BallonChance { get; set; } = 10;

        [Description("Chance to spawn SCP-2176. #SHOULD ADD UP TO 100 HERE#")]
        public float LightChance { get; set; } = 5;


        [Description("Random item chance. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#")]
        public float CoinRandomItem { get; set; } = 5.8f;

        [Description("Random Role chance.")]
        public float CoinRandomRole { get; set; } = 5.8f;

        [Description("Random Teleport chance.")]
        public float CoinTeleport { get; set; } = 5.8f;

        [Description("Random Player Swap chance.")]
        public float CoinPlayerSwap { get; set; } = 5.8f;

        [Description("Random Effect chance.")]
        public float CoinRandomEffect { get; set; } = 5.8f;

        [Description("Drop Inventory chance.")]
        public float CoinDropInventory { get; set; } = 5.8f;

        [Description("Chance to spawn projectile.")]
        public float CoinSpawnProjectile { get; set; } = 5.8f;

        [Description("Chance to spawn spectator.")]
        public float CoinSpawnSpectator { get; set; } = 5.8f;

        [Description("Chance to spawn tantrum.")]
        public float CoinTantrum { get; set; } = 5.8f;

        [Description("Chance to kick the player.")]
        public float CoinKick { get; set; } = 5.8f;

        [Description("Chance to start the nuke.")]
        public float CoinNuke { get; set; } = 5.8f;

        [Description("Chance to clear player's inventory.")]
        public float CoinClearInv { get; set; } = 5.8f;

        [Description("Chance to change player's size.")]
        public float CoinChanceSize { get; set; } = 5.8f;

        [Description("Chance to globaly broadcast player's voice.")]
        public float CoinBroadcastVoice { get; set; } = 5.8f;

        [Description("Chance to give player godmode.")]
        public float CoinGodMode { get; set; } = 5.8f;

        [Description("Chance to broadcast player's location.")]
        public float CoinSnitch { get; set; } = 5.8f;

        [Description("Chance to do nothing. #SHOULD ADD UP TO 100 HERE#")]
        public float Nothing { get; set; } = 7.2f;


        [Description("Include tutorial in coin swap.")]
        public bool IncludeTutorial { get; set; } = false;


        [Description("Include tutorial in coin swap.")]
        public string CoinKickReason { get; set; } = "Get coined!";

        [Description("Text that will show up for player when he flipped for broadcast.")]
        public Exiled.API.Features.Broadcast BroadcastCoinMessage { get; set; } = new("Your voice will be broadcasted for %CoinBroadcastTime% seconds.", 5);

        [Description("For how long the player will have the broadcast.")]
        public float CoinBroadcastTime { get; set; } = 10f;

        [Description("Text that will show up for player when he flipped for broadcast.")]
        public Exiled.API.Features.Broadcast GodModeCoinMessage { get; set; } = new("You have became a god for %CoinGodModeTime% seconds.", 5);

        [Description("For how long the player will have the broadcast.")]
        public float CoinGodModeTime { get; set; } = 15f;

        [Description("Scale after coin flip.")]
        public Vector3 PlayerSizeAfterFlip { get; set; } = new Vector3(0.5f, 0.5f, 0.5f);

        [Description("Broadcasts the player's location.")]
        public Exiled.API.Features.Broadcast SnitchPlayer { get; set; } = new ("%PlayerName% is located in %PlayerZone%.", 5);
    }
}
