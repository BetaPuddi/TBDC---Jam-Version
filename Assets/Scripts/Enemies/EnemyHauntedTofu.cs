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
            LogManager.instance.InstantiateDamageLog(enemyName, PlayerManager.instance.player.playerName, damageOut);
        }

        public override void Skill_01()
        {
            var missingHealth = maxHealth - currentHealth;
            var damageOut = missingHealth - PlayerManager.instance.player.defenseStat;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(enemyName, PlayerManager.instance.player.playerName, damageOut);
            defenseStat -= 2;
            LogManager.instance.InstantiateTextLog($"{enemyName} loses 2 Defense!");
            EnemyInfoPanel.instance.UpdateEnemyInfo();
        }
    }
}