using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemySkelebob : Enemy
    {
        public override void Attack()
        {
            print("Skeleton Attack");
            var attackDamage = 2 + Mathf.Clamp((attackStat - PlayerManager.instance.player.defenseStat), 0, Mathf.Infinity);
            PlayerManager.instance.PlayerTakeDamage(attackDamage);
        }

        public override void Skill_01()
        {
            print("Skeleton Skill 01");
            var skill01Damage = attackStat / 3;
            PlayerManager.instance.PlayerTakeDamage(skill01Damage);
        }

        public override void Skill_02()
        {
            print("Skeleton Skill 02");
        }
    }
}