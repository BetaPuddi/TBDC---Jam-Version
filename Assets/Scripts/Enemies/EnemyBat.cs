using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyBat : Enemy
    {
        public override void Attack()
        {
            print("Bat Attack");
            PlayerManager.instance.PlayerTakeDamage(attackStat);
        }

        public override void Skill_01()
        {
            print("Bat Skill 01");
            var skillDamage = Mathf.RoundToInt(attackStat * 0.5f);
            PlayerManager.instance.PlayerTakeDamage(skillDamage);
            var skillHeal = Mathf.RoundToInt((defenseStat * 0.2f) + (currentHealth * 0.2f));
            Heal(skillHeal);
        }

        public override void Skill_02()
        {
            print("Bat Skill 02");
        }
    }
}
