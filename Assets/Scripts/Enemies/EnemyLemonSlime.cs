using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyLemonSlime : Enemy
    {
        public override void Attack()
        {
            var damageOut = attackStat - PlayerManager.instance.player.defenseStat * 1.5f;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(enemyName, PlayerManager.instance.player.playerName, damageOut);
        }

        public override void Skill_01()
        {
            PlayerManager.instance.PlayerTakeDamage(attackStat);
            LogManager.instance.InstantiateDamageLog(enemyName, PlayerManager.instance.player.playerName, attackStat);
            PlayerManager.instance.ChangeDefense(-1);
            LogManager.instance.InstantiateTextLog($"{enemyName} reduces your Defense by 1!");
        }
    }
}