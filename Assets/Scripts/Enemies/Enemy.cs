using System;
using UnityEngine;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        public string enemyName;
        public int currentHealth;
        public int maxHealth;
        public int attackStat;
        public int defenseStat;

        public delegate void EnemyInfoChange();
        public static event EnemyInfoChange OnEnemyInfoChange;

        private void Awake()
        {
            Reset();
        }

        public virtual void Attack()
        {
            print("Enemy attack");
        }

        public virtual void Skill_01()
        {
            print("Enemy skill 01");
        }

        public virtual void Skill_02()
        {
            print("Enemy  skill 02");
        }

        public virtual void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                print("Enemy dead");
                Reset();
            }

            OnEnemyInfoChange();
        }

        public virtual void Heal(int heal)
        {
            currentHealth += heal;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            OnEnemyInfoChange();
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            OnEnemyInfoChange();
        }
    }
}
