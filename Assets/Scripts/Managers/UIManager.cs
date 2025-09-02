using System;
using Enums;
using UnityEngine;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager instance;

        public GameObject uiCanvas;
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
                case EGameStates.MainMenu:
                    playerInfoPanel.SetActive(false);
                    npcInfoPanel.SetActive(false);
                    areaInfoPanel.SetActive(false);
                    enemyInfoPanel.SetActive(false);
                    break;
                case EGameStates.GameOver:
                    // playerInfoPanel.SetActive(false);
                    // npcInfoPanel.SetActive(false);
                    // areaInfoPanel.SetActive(false);
                    // enemyInfoPanel.SetActive(false);
                    //ToggleUI();
                    break;
                case EGameStates.Start:
                    playerInfoPanel.SetActive(true);
                    npcInfoPanel.SetActive(false);
                    areaInfoPanel.SetActive(false);
                    enemyInfoPanel.SetActive(false);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ToggleUI()
        {
            uiCanvas.SetActive(!uiCanvas.activeSelf);
        }
    }
}