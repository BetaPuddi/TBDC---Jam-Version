using System;
using Enemies;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Managers
{
    public class EnemyManager : MonoBehaviour
    {
        public static EnemyManager instance;

        public GameObject[] enemies;
        public GameObject currentEnemy;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void SpawnNewEnemy()
        {
            if (currentEnemy != null)
            {
                currentEnemy.GetComponent<Enemy>().Reset();
                currentEnemy.gameObject.SetActive(false);
            }
            currentEnemy = enemies[Random.Range(0, enemies.Length)];
            currentEnemy.gameObject.SetActive(true);
        }
    }
}