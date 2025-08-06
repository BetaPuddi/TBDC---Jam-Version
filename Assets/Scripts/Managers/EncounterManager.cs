using System;
using Managers;
using UnityEngine;

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
    }
}
