using System;
using Enums;
using Managers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Encounters
{
    public class EncounterManager : MonoBehaviour
    {
        public static EncounterManager instance;

        [SerializeField]
        private string[] encounterType;
        public string currentEncounterType;

        private void Awake()
        {
            if (instance  == null)
            {
                instance  = this;
            }
        }

        private void Start()
        {
            encounterType = new string[encounterType.Length];
            encounterType[0] = "enemy";
            encounterType[1] = "npc";
            encounterType[2] = "advance";
        }

        public void NewEncounter(string encounterType)
        {
            currentEncounterType = encounterType;
            switch(currentEncounterType)
            {
                case "enemy":
                    EnemyManager.instance.SpawnNewEnemy();
                    break;
                case "npc":
                    NPCManager.instance.SpawnNewNPC();
                    break;
                case "advance":
                    break;
            }
        }

        public void Advance()
        {
            if (GameManager.instance._gameState == EGameStates.Advance)
            {
                GameManager.instance.UpdateGameState(Random.Range(1, 3));
            }
        }
    }
}
