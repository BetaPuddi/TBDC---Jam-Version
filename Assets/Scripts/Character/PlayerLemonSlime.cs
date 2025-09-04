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
        }

        public override void UtilitySkill_01()
        {
            EnemyManager.instance.targetEnemy.TakeDamage(attackStat);
            EnemyManager.instance.targetEnemy.ChangeDefense(-1);
        }
    }
}