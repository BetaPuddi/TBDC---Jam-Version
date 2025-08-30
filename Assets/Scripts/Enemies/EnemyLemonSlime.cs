using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyLemonSlime : Enemy
    {
        public override void Attack()
        {
            var damageOut = attackStat - PlayerManager.instance.player.defenseStat * 1.5f;
            PlayerManager.instance.PlayerTakeDamage(damageOut);
        }

        public override void Skill_01()
        {
            PlayerManager.instance.PlayerTakeDamage(attackStat);
            PlayerManager.instance.ChangeDefense(-1);
        }
    }
}