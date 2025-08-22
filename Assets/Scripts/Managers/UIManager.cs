using System;
using Enums;
using UnityEngine;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager instance;

        public GameObject enemyInfoPanel;
        public GameObject playerInfoPanel;
        public GameObject npcInfoPanel;
        public GameObject areaInfoPanel;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void ToggleInfoUI()
        {
            switch (GameManager.instance._gameState)
            {
                case EGameStates.Combat:
                    enemyInfoPanel.SetActive(true);
                    npcInfoPanel.SetActive(false);
                    areaInfoPanel.SetActive(false);
                    break;
                case EGameStates.Advance:
                    areaInfoPanel.SetActive(true);
                    npcInfoPanel.SetActive(false);
                    enemyInfoPanel.SetActive(false);
                    break;
                case EGameStates.NPC:
                    npcInfoPanel.SetActive(true);
                    areaInfoPanel.SetActive(false);
                    enemyInfoPanel.SetActive(false);
                    break;
                case EGameStates.Start:
                    playerInfoPanel.SetActive(false);
                    npcInfoPanel.SetActive(false);
                    areaInfoPanel.SetActive(false);
                    enemyInfoPanel.SetActive(false);
                    break;
                case EGameStates.GameOver:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}