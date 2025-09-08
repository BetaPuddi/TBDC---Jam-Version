using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerBatface : Player
    {
        public override void Attack()
        {
            EnemyManager.instance.targetEnemy.TakeDamage(attackStat);
            LogManager.instance.InstantiateDamageLog("You", EnemyManager.instance.targetEnemy.enemyName, attackStat);
        }

        public override void UtilitySkill_01()
        {
            var damageOut = attackStat * 0.5f;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
            var skillHeal = (defenseStat * 0.2f) + (currentHealth * 0.02f);
            Heal(skillHeal);
            LogManager.instance.InstantiateHealLog("You", "yourself", skillHeal);
        }
    }
}