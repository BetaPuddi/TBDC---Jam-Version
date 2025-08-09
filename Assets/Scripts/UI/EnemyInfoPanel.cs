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

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            /*if (currentEnemy != null)
            {
                UpdateEnemyInfo();
            }*/
        }

        public void UpdateEnemyInfo(string currentEnemyName, int currentEnemyHealth, int currentEnemyAtk, int currentEnemyDef)
        {
            enemyNameText.text = currentEnemyName;
            enemyHealthText.text = currentEnemyHealth.ToString();
            enemyATKText.text = currentEnemyAtk.ToString();
            enemyDEFText.text = currentEnemyDef.ToString();
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
