using Enemies;
using Managers;
using TMPro;
using UnityEngine;

namespace UI
{
    public class EnemyInfoPanel : MonoBehaviour
    {
        public static EnemyInfoPanel instance;

        public GameObject panel;
        public TextMeshProUGUI enemyNameText;
        public TextMeshProUGUI enemyHealthText;
        public TextMeshProUGUI enemyATKText;
        public TextMeshProUGUI enemyDEFText;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void OnEnable()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void UpdateEnemyInfo()
        {
            enemyNameText.text = EnemyManager.instance.targetEnemy.enemyName;
            enemyHealthText.text = EnemyManager.instance.targetEnemy.currentHealth.ToString();
            enemyATKText.text = EnemyManager.instance.targetEnemy.attackStat.ToString();
            enemyDEFText.text = EnemyManager.instance.targetEnemy.defenseStat.ToString();
        }

        public void UpdateEnemyHealth(int newHealth)
        {
            enemyHealthText.text = newHealth.ToString();
        }

        /*
        public void SetCurrentEnemy(Enemy newEnemy)
        {
            currentEnemy = newEnemy;
            UpdateEnemyInfo();
        }
        */
    }
}
