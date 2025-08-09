using UnityEngine;

namespace NPCs
{
    public abstract class NPC : MonoBehaviour
    {
        public abstract void Swap();

        public abstract void Interact();
    }
}