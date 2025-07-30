using UnityEngine;

namespace Enemies
{
    public class EnemyBat : Enemy
    {
        public override void Attack()
        {
            print("Bat Attack");
        }

        public override void Skill_01()
        {
            print("Bat Skill 01");
        }

        public override void Skill_02()
        {
            print("Bat Skill 02");
        }
    }
}
