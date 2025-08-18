using Managers;

namespace Character
{
    public class PlayerGroblin : Player
    {
        public override void Attack()
        {
            print("Groblin attack!");
            EnemyManager.instance.targetEnemy.TakeDamage(attackStat);
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