using Managers;
using UI;
using UnityEngine;

namespace Enemies
{
    public class EnemyImpCat : Enemy
    {
        public override void Attack()
        {
            var damageOut = attackStat + Random.Range(-3, 3) - PlayerManager.instance.player.defenseStat;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            var atkStat = attackStat;
            var defStat = defenseStat;
            attackStat = defStat;
            defenseStat = atkStat;
            EnemyInfoPanel.instance.UpdateEnemyInfo();
        }

        public override void Skill_01()
        {
            var damageOut = defenseStat + Random.Range(-3, 3) - PlayerManager.instance.player.attackStat;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            var atkStat = attackStat;
            var defStat = defenseStat;
            defenseStat = atkStat;
            attackStat = defStat;
            EnemyInfoPanel.instance.UpdateEnemyInfo();
        }
    }
}