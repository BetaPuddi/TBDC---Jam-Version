using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerSkelebob : Player
    {
        public override void Attack()
        {
            var damageOut = 2 + Mathf.Clamp((attackStat - EnemyManager.instance.targetEnemy.defenseStat), 0, Mathf.Infinity);
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
        }

        public override void UtilitySkill_01()
        {
            var damageOut = attackStat / 3;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
        }
    }
}