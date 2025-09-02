using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyGamblambler : Enemy
    {
        public override void Attack()
        {
            var damageOut = attackStat + PlayerManager.instance.player.attackStat;
            var targetRoll = Random.Range(0, 2);
            switch (targetRoll)
            {
                case 0:
                    TakeDamage(damageOut - defenseStat);
                    break;
                case 1:
                    PlayerManager.instance.PlayerTakeDamage(damageOut - PlayerManager.instance.player.defenseStat);
                    break;
            }
        }

        public override void Skill_01()
        {
            var healOut = defenseStat + PlayerManager.instance.player.defenseStat;
            var targetRoll = Random.Range(0, 2);
            switch (targetRoll)
            {
                case 0:
                    Heal(healOut - attackStat);
                    break;
                case 1:
                    PlayerManager.instance.PlayerHeal(healOut - PlayerManager.instance.player.attackStat);
                    break;
            }
        }
    }
}