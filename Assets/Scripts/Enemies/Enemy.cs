using System;
using UI;
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
        public GameObject infoPanelObject;
        private EnemyInfoPanel infoPanelScript;


        private void Awake()
        {
            Reset();
        }

        private void OnEnable()
        {
            infoPanelScript = infoPanelObject.GetComponent<EnemyInfoPanel>();
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
            print("Enemy skill 02");
        }

        public virtual void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                print("Enemy dead");
                Reset();
            }

            infoPanelScript.UpdateEnemyHealth(currentHealth);
        }

        public virtual void Heal(int heal)
        {
            currentHealth += heal;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            infoPanelScript.UpdateEnemyHealth(currentHealth);
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            infoPanelScript.UpdateEnemyHealth(currentHealth);
        }
    }
}
