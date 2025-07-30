using Enemies;
using TMPro;
using UnityEngine;

namespace UI
{
    public class EnemyInfoPanel : MonoBehaviour
    {
        public Enemy currentEnemy;
        public TextMeshProUGUI enemyNameText;
        public TextMeshProUGUI enemyHealthText;
        public TextMeshProUGUI enemyATKText;
        public TextMeshProUGUI enemyDEFText;

        private void OnEnable()
        {
            Enemy.OnEnemyInfoChange += UpdateEnemyInfo;
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            if (currentEnemy != null)
            {
                UpdateEnemyInfo();
            }
        }

        public void UpdateEnemyInfo()
        {
            enemyNameText.text = currentEnemy.enemyName;
            enemyHealthText.text = currentEnemy.currentHealth.ToString();
            enemyATKText.text = currentEnemy.attackStat.ToString();
            enemyDEFText.text = currentEnemy.defenseStat.ToString();
        }

        public void SetCurrentEnemy(Enemy newEnemy)
        {
            currentEnemy = newEnemy;
            UpdateEnemyInfo();
        }
    }
}
