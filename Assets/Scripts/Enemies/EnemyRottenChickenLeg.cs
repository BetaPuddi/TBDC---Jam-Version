using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyRottenChickenLeg : Enemy
    {
        public override void Attack()
        {
            var damageOut = attackStat - Random.Range(3, 9);
            PlayerManager.instance.PlayerTakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(enemyName, PlayerManager.instance.player.playerName, damageOut);
        }

        public override void Skill_01()
        {
            PlayerManager.instance.ChangeAttack(-1);
            LogManager.instance.InstantiateTextLog($"{enemyName} reduces your Attack by 1!");
            PlayerManager.instance.ChangeMaxHealth(-1);
            LogManager.instance.InstantiateTextLog($"{enemyName} reduces your MaxHealth by 1!");
        }
    }
}