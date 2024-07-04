using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Roles;
using PlayerRoles;
using System.Collections.Generic;

namespace CoinGamble.CoinFlip
{
    internal partial class ActionPick
    {
        private void RandomRole(Player player, Item item)
        {
            player.RemoveItem(item, true);

            Role role = player.Role;
            float chance = UnityEngine.Random.Range(0f, 100f);

            float probability = config.OtherRoleChance;
            if (chance < probability)
            {
                chance = UnityEngine.Random.Range(0f, 100f);

                probability = config.SupremeRoleChance;
                if (chance < probability)
                {
                    player.DropItems();
                    if (role.Type == RoleTypeId.NtfCaptain) role.Set(RoleTypeId.ChaosRifleman, RoleSpawnFlags.AssignInventory);
                    else role.Set(RoleTypeId.NtfCaptain, RoleSpawnFlags.AssignInventory);
                    return;
                }

                probability += config.NormalRoleChance;
                if (chance < probability)
                {
                    List<RoleTypeId> roleTypeIds = new List<RoleTypeId> { RoleTypeId.NtfPrivate, RoleTypeId.NtfSergeant, RoleTypeId.NtfSpecialist, RoleTypeId.ChaosConscript, RoleTypeId.ChaosMarauder, RoleTypeId.ChaosRepressor };
                    roleTypeIds.Remove(role.Type);
                    int roleChance = UnityEngine.Random.Range(0, roleTypeIds.Count - 1);

                    role.Set(roleTypeIds[roleChance], RoleSpawnFlags.None);
                    return;
                }

                probability += config.LesserRoleChance;
                if (chance < probability)
                {
                    if (role.Type == RoleTypeId.Scientist) role.Set(RoleTypeId.ClassD, RoleSpawnFlags.None);
                    else role.Set(RoleTypeId.Scientist, RoleSpawnFlags.None);
                    return;
                }
            }

            probability += config.ZombieChance;
            if (chance < probability)
            {
                role.Set(RoleTypeId.Scp0492, RoleSpawnFlags.None);
                return;
            }

            probability += config.DeathChance;
            if (chance < probability)
            {
                role.Set(RoleTypeId.Spectator, RoleSpawnFlags.None);
                return;
            }
        }
    }
}
