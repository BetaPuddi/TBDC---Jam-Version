using UnityEngine;

namespace Enemies
{
    public class EnemySkeleton : Enemy
    {
        public override void Attack()
        {
            print("Skeleton Attack");
        }

        public override void Skill_01()
        {
            print("Skeleton Skill 01");
        }

        public override void Skill_02()
        {
            print("Skeleton Skill 02");
        }
    }
}