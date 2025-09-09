using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerCreamyLisa : Player
    {
        public override void Attack()
        {
            var damageOut = currentHealth * 0.2f;
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
            LogManager.instance.InstantiateDamageLog("You", "yourself", damageOut);
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            TakeDamage(damageOut);
        }

        public override void UtilitySkill_01()
        {
            int damageOut;
            if (currentHealth < maxHealth * 0.2f)
            {
                damageOut = attackStat * 2;
            }
            else
            {
                damageOut = attackStat - EnemyManager.instance.targetEnemy.defenseStat;
            }
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
        }
    }
}