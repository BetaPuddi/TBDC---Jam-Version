using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerLemonSlime : Player
    {
        public override void Attack()
        {
            var damageOut = attackStat - EnemyManager.instance.targetEnemy.defenseStat * 1.5f;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
        }

        public override void UtilitySkill_01()
        {
            EnemyManager.instance.targetEnemy.TakeDamage(attackStat);
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, attackStat);
            EnemyManager.instance.targetEnemy.ChangeDefense(-1);
            LogManager.instance.InstantiateTextLog($"You reduce {EnemyManager.instance.targetEnemy.enemyName}'s Defense by 1!");
        }
    }
}