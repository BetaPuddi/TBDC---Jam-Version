using UnityEngine;

namespace NPCs
{
    public abstract class NPC : MonoBehaviour
    {
        public GameObject thingToSwap;
        public string npcName;

        public abstract void Swap();

        public abstract void Interact();

        public abstract void InitialiseNPC();
    }
}