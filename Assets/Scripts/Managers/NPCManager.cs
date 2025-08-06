using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Managers
{
    public class NPCManager : MonoBehaviour
    {
        public static NPCManager instance;

        public GameObject[] NPCs;
        public GameObject currentNPC;

        private void Awake()
        {
            if (instance  == null)
            {
                instance = this;
            }
        }

        public void SpawnNewNPC()
        {
            currentNPC.gameObject.SetActive(false);
            currentNPC = NPCs[Random.Range(0, NPCs.Length)];
            currentNPC.gameObject.SetActive(true);
        }
    }
}