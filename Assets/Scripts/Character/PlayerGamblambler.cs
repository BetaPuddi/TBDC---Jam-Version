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
                    TakeDamage(damageOut - defenseStat);
                    break;
                case 1:
                    EnemyManager.instance.targetEnemy.TakeDamage(damageOut - EnemyManager.instance.targetEnemy.defenseStat);
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
                    Heal(healOut - attackStat);
                    break;
                case 1:
                    EnemyManager.instance.targetEnemy.Heal(healOut - EnemyManager.instance.targetEnemy.attackStat);
                    break;
            }
        }
    }
}