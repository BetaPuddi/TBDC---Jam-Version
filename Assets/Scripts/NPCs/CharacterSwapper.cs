using Character;
using Enums;
using Managers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace NPCs
{
    public class CharacterSwapper : NPC
    {
        public GameObject[] characterArray;

        public override void Swap()
        {
            if (GameManager.instance._gameState == EGameStates.NPC)
            {
                var player = thingToSwap.GetComponent<Player>();
                PlayerManager.instance.SwapPlayer(player);
                GameManager.instance._gameState = EGameStates.Advance;
            }

        }

        public override void Interact()
        {
            throw new System.NotImplementedException();
        }

        public override void InitialiseNPC()
        {
            NewSwapTarget();
        }

        public void NewSwapTarget()
        {
            thingToSwap = characterArray[Random.Range(0, characterArray.Length)];
        }
    }
}