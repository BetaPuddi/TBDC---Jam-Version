using Managers;
using UI;
using UnityEngine;

namespace Character
{
    public class PlayerHauntedTofu : Player
    {
        public override void Attack()
        {
            var damageOut = (currentHealth - EnemyManager.instance.targetEnemy.defenseStat) * 0.5f;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
        }

        public override void UtilitySkill_01()
        {
            var missingHealth = maxHealth - currentHealth;
            var damageOut = missingHealth - EnemyManager.instance.targetEnemy.defenseStat;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            defenseStat -= 2;
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }
    }
}