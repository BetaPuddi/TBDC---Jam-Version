using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerBatface : Player
    {
        public override void Attack()
        {
            EnemyManager.instance.targetEnemy.TakeDamage(attackStat);
        }

        public override void UtilitySkill_01()
        {
            var damageOut = attackStat * 0.5f;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            var skillHeal = (defenseStat * 0.2f) + (currentHealth * 0.02f);
            Heal(skillHeal);
        }
    }
}