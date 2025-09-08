using Managers;
using UnityEngine;

namespace Character
{
    public class PlayerGroblin : Player
    {
        public override void Attack()
        {
            print("Groblin attack!");
            var damageOut = attackStat - Random.Range(-3, 4);
            EnemyManager.instance.targetEnemy.TakeDamage(damageOut);
            LogManager.instance.InstantiateDamageLog(playerName, EnemyManager.instance.targetEnemy.enemyName, damageOut);
        }

        public override void UtilitySkill_01()
        {
            print("Groblin utility skill");
        }

        public override void ItemSkill_01()
        {
            if (itemUses > 0)
            {
                print("Groblin item skill");
                itemUses--;

            }
            else
            {
                print("No uses remaining");
            }
        }
    }
}