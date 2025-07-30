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

        public delegate void PlayerInfoChange();
        public static event PlayerInfoChange OnPlayerInfoChange;

        private void Awake()
        {
            Reset();
        }

        public virtual void Attack()
        {
            print("Player attack");
        }

        public virtual void Skill_01()
        {
            print("Player skill 01");
        }

        public virtual void Skill_02()
        {
            print("Player skill 02");
        }

        public virtual void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                print("Player dead");
                Reset();
            }

            OnPlayerInfoChange?.Invoke();
        }

        public virtual void Heal(int heal)
        {
            currentHealth += heal;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            OnPlayerInfoChange?.Invoke();
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            OnPlayerInfoChange?.Invoke();
        }
    }
}
