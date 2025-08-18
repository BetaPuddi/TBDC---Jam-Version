using System;
using Enemies;
using UI;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Managers
{
    public class EnemyManager : MonoBehaviour
    {
        public static EnemyManager instance;

        public GameObject[] enemies;
        public Enemy targetEnemy;
        //public Enemy enemyTarget;
        public int CurrentHealth;
        public int MaxHealth;
        public int AttackStat;
        public int DefenseStat;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void SpawnNewEnemy()
        {
            // if (targetEnemy != null)
            // {
            //     targetEnemy.GetComponent<Enemy>().Reset();
            // }
            targetEnemy = enemies[Random.Range(0, enemies.Length)].gameObject.GetComponent<Enemy>();
            //enemyTarget = targetEnemy.gameObject.GetComponent<Enemy>();
            EnemyInfoPanel.instance.UpdateEnemyInfo();
        }

        public void ImportEnemyStats()
        {

        }

        public void ImportEnemyAbilities()
        {

        }
    }
}