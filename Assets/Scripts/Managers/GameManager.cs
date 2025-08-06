using System;
using Encounters;
using Enums;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        private EGameStates _gameState;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void UpdateGameState(int newGameState)
        {
            _gameState = (EGameStates)newGameState;
            switch (_gameState)
            {
                case EGameStates.Combat:
                    EncounterManager.instance.NewEncounter("enemy");
                    break;
                case EGameStates.NPC:
                    EncounterManager.instance.NewEncounter("npc");
                    break;
                case EGameStates.Advance:
                    EncounterManager.instance.NewEncounter("advance");
                    break;
                case EGameStates.Start:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
