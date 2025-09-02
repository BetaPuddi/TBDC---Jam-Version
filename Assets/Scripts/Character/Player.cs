using System;
using Enums;
using Managers;
using UI;
using UnityEngine;

namespace Character
{
    public class Player : MonoBehaviour
    {
        public string playerName;
        public int currentHealth;
        public int maxHealth;
        public int attackStat;
        public int defenseStat;
        public int itemUses;

        private void Awake()
        {
            currentHealth = maxHealth;
        }

        private void Start()
        {
                Reset();
        }

        public virtual void Attack()
        {
            print("Player attack");
        }

        public virtual void UtilitySkill_01()
        {
            print("Player skill 01");
        }

        public virtual void ItemSkill_01()
        {
            if (itemUses > 0)
            {
                print("Player skill 02");
                itemUses--;
            }
            else
            {
                print("No uses remaining");
            }
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }

        public virtual void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                GameOver();
            }

            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }

        public virtual void Heal(int heal)
        {
            currentHealth += heal;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }

        public void GameOver()
        {
            print("Player dead");
            GameManager.instance.UpdateGameState(4);
            Reset();
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }
    }
}
