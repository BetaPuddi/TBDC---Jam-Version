using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyCreamyLisa : Enemy
    {
        public override void Attack()
        {
            var damageOut = currentHealth * 0.2f;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            TakeDamage(damageOut);
        }

        public override void Skill_01()
        {
            int damageOut;
            if (currentHealth < maxHealth * 0.2f)
            {
                damageOut = attackStat * 2;
            }
            else
            {
                damageOut = attackStat - PlayerManager.instance.player.defenseStat;
            }

            PlayerManager.instance.PlayerTakeDamage(damageOut);
        }
    }
}