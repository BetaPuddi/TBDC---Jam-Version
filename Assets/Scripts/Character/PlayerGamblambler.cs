using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerGamblambler : Player
    {
        public override void Attack()
        {
            var damageOut = attackStat + EnemyManager.instance.targetEnemy.attackStat;
            var targetRoll = Random.Range(0, 2);
            switch (targetRoll)
            {
                case 0:
                    damageOut -= defenseStat;
                    TakeDamage(damageOut);
                    LogManager.instance.InstantiateDamageLog(playerName, "itself", damageOut);
                    break;
                case 1:
                    damageOut -= EnemyManager.instance.targetEnemy.defenseStat;
                    EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
                    LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
                    break;
            }
        }

        public override void UtilitySkill_01()
        {
            var healOut = defenseStat + EnemyManager.instance.targetEnemy.defenseStat;
            var targetRoll = Random.Range(0, 2);
            switch (targetRoll)
            {
                case 0:
                    healOut -= attackStat;
                    Heal(healOut);
                    LogManager.instance.InstantiateHealLog(playerName, "itself", healOut);
                    break;
                case 1:
                    healOut -= EnemyManager.instance.targetEnemy.attackStat;
                    EnemyManager.instance.targetEnemy.Heal(healOut);
                    LogManager.instance.InstantiateHealLog(playerName, EnemyManager.instance.targetEnemy.enemyName, healOut);
                    break;
            }
        }
    }
}