using Managers;
using UI;
using UnityEngine;

namespace Enemies
{
    public class EnemyHauntedTofu : Enemy
    {
        public override void Attack()
        {
            var damageOut = (currentHealth - PlayerManager.instance.player.defenseStat) * 0.5f;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
        }

        public override void Skill_01()
        {
            var missingHealth = maxHealth - currentHealth;
            var damageOut = missingHealth - PlayerManager.instance.player.defenseStat;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            defenseStat -= 2;
            EnemyInfoPanel.instance.UpdateEnemyInfo();
        }
    }
}