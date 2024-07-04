# Introduction
This is my first plugin for SCP: Secret Laboratory, designed as a learning project. I chose to implement Coin Gambling because I've encountered similar plugins during my years of playing. This allowed me to concentrate on coding without the need to create something entirely new.
# Description
This project is an SCP: Secret Laboratory plugin that utilizes the Exiled framework.
The plugin is unbalanced.
# Default Config
```yaml
CoinGamble:
# Whether or not this plugin is enabled.
  is_enabled: true
  # Whether or not debug messages should be shown in the console.
  debug: false
  # Chance to die. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#
  death_chance: 15
  # Chance to become zombie.
  zombie_chance: 15
  # Chance to become other role. #SHOULD ADD UP TO 100 HERE#
  other_role_chance: 70
  # Chance to become lesser role. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#
  lesser_role_chance: 75
  # Chance to become normal role.
  normal_role_chance: 20
  # Chance to become supreme role. #SHOULD ADD UP TO 100 HERE#
  supreme_role_chance: 5
  # Chance to spawn flash. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#
  flash_chance: 50
  # Chance to spawn granade.
  granade_chance: 35
  # Chance to spawn SCP-018.
  ballon_chance: 10
  # Chance to spawn SCP-2176. #SHOULD ADD UP TO 100 HERE#
  light_chance: 5
  # Random item chance. #THE FOLLOWING VALUES SHOULD ADD UP TO 100 IT CAN BE SMALLER BUT WHEN IT'S LARGER IT BREAKS#
  coin_random_item: 5.80000019
  # Random Role chance.
  coin_random_role: 5.80000019
  # Random Teleport chance.
  coin_teleport: 5.80000019
  # Random Player Swap chance.
  coin_player_swap: 5.80000019
  # Random Effect chance.
  coin_random_effect: 5.80000019
  # Drop Inventory chance.
  coin_drop_inventory: 5.80000019
  # Chance to spawn projectile.
  coin_spawn_projectile: 5.80000019
  # Chance to spawn spectator.
  coin_spawn_spectator: 5.80000019
  # Chance to spawn tantrum.
  coin_tantrum: 5.80000019
  # Chance to kick the player.
  coin_kick: 5.80000019
  # Chance to start the nuke.
  coin_nuke: 5.80000019
  # Chance to clear player's inventory.
  coin_clear_inv: 5.80000019
  # Chance to change player's size.
  coin_chance_size: 5.80000019
  # Chance to globaly broadcast player's voice.
  coin_broadcast_voice: 5.80000019
  # Chance to give player godmode.
  coin_god_mode: 5.80000019
  # Chance to broadcast player's location.
  coin_snitch: 5.80000019
  # Chance to do nothing. #SHOULD ADD UP TO 100 HERE#
  nothing: 7.19999981
  # Include tutorial in coin swap.
  include_tutorial: false
  # Include tutorial in coin swap.
  coin_kick_reason: 'Get coined!'
  # Text that will show up for player when he flipped for broadcast.
  broadcast_coin_message:
  # The broadcast content
    content: 'Your voice will be broadcasted for %CoinBroadcastTime% seconds.'
    # The broadcast duration
    duration: 5
    # The broadcast type
    type: Normal
    # Indicates whether the broadcast should be shown or not
    show: true
  # For how long the player will have the broadcast.
  coin_broadcast_time: 10
  # Text that will show up for player when he flipped for broadcast.
  god_mode_coin_message:
  # The broadcast content
    content: 'You have became a god for %CoinGodModeTime% seconds.'
    # The broadcast duration
    duration: 5
    # The broadcast type
    type: Normal
    # Indicates whether the broadcast should be shown or not
    show: true
  # For how long the player will have the broadcast.
  coin_god_mode_time: 15
  # Scale after coin flip.
  player_size_after_flip:
    x: 0.5
    y: 0.5
    z: 0.5
  # Broadcasts the player's location.
  snitch_player:
  # The broadcast content
    content: '%PlayerName% is located in %PlayerZone%.'
    # The broadcast duration
    duration: 5
    # The broadcast type
    type: Normal
    # Indicates whether the broadcast should be shown or not
    show: true
exiled_events:
  is_enabled: true
  debug: false
```
## Contact
For questions or support, contact me on discord Trixder.
