using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerRottenChickenLeg : Player
    {
        public override void Attack()
        {
            var damageOut = attackStat - Random.Range(3, 9);
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
        }

        public override void UtilitySkill_01()
        {
            EnemyManager.instance.targetEnemy.ChangeAttack(-1);
            EnemyManager.instance.targetEnemy.ChangeMaxHealth(-1);
        }
    }
}