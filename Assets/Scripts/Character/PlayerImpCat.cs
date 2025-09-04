using Managers;
using UI;
using UnityEngine;

namespace Character
{
    public class PlayerImpCat : Player
    {
        public override void Attack()
        {
            var damageOut = attackStat + Random.Range(-3, 3) - EnemyManager.instance.targetEnemy.defenseStat;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            var atkStat = attackStat;
            var defStat = defenseStat;
            attackStat = defStat;
            defenseStat = atkStat;
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }

        public override void UtilitySkill_01()
        {
            var damageOut = defenseStat + Random.Range(-3, 3) - EnemyManager.instance.targetEnemy.attackStat;
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            var atkStat = attackStat;
            var defStat = defenseStat;
            defenseStat = atkStat;
            attackStat = defStat;
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }
    }
}