using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerLemonSlime : Player
    {
        public override void Attack()
        {
            var damageOut = attackStat - EnemyManager.instance.targetEnemy.defenseStat * 1.5f;
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
        }

        public override void UtilitySkill_01()
        {
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, attackStat);
            LogManager.instance.InstantiateTextLog($"You reduce {EnemyManager.instance.targetEnemy.enemyName}'s Defense by 1!");
            EnemyManager.instance.targetEnemy.TakeDamage(attackStat);
            EnemyManager.instance.targetEnemy.ChangeDefense(-1);
        }
    }
}