using System;
using Enums;
using Managers;
using UI;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        public string enemyName;
        public int currentHealth;
        public int maxHealth;
        public int attackStat;
        public int defenseStat;

        private void Awake()
        {

        }

        private void Start()
        {
            Reset();
        }

        public virtual void Attack()
        {
            print("Enemy attack");
            PlayerManager.instance.PlayerTakeDamage(attackStat);
        }

        public virtual void Skill_01()
        {
            print("Enemy skill 01");
        }

        public virtual void Skill_02()
        {
            print("Enemy skill 02");
        }

        public virtual void TakeDamage(int damage)
        {
            currentHealth -= (damage - defenseStat);
            if (currentHealth <= 0)
            {
                EnemyDeath();
            }

            EnemyInfoPanel.instance.UpdateEnemyHealth(currentHealth);
        }

        public virtual void Heal(int heal)
        {
            currentHealth += heal;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            EnemyInfoPanel.instance.UpdateEnemyHealth(currentHealth);
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            EnemyInfoPanel.instance.UpdateEnemyHealth(currentHealth);
        }

        public void EnemyDeath()
        {
            print("Enemy dead");
            Reset();
            GameManager.instance.UpdateGameState(3);
        }

        public virtual void EnemyTakeTurn()
        {
            var actionRoll = Random.Range(0, 3);
            switch (actionRoll)
            {
                case 0:
                    Attack();
                    break;
                case 1:
                    Skill_01();
                    break;
                case 2:
                    Skill_02();
                    break;
            }
        }
    }
}
