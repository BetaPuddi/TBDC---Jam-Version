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
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
        }

        public override void UtilitySkill_01()
        {
            var missingHealth = maxHealth - currentHealth;
            var damageOut = missingHealth - EnemyManager.instance.targetEnemy.defenseStat;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
            defenseStat -= 2;
            LogManager.instance.InstantiateTextLog("You lose 2 Defense!");
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }
    }
}