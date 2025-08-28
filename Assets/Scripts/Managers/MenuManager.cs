using System;
using Enums;
using UnityEngine;

namespace Managers
{
    public class MenuManager : MonoBehaviour
    {
        public static MenuManager instance;

        public GameObject mainMenu;
        public GameObject gameOverMenu;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void StartGame()
        {
            ToggleMainMenu();
            GameManager.instance.UpdateGameState(0);
        }

        public void ToggleMainMenu()
        {
            mainMenu.SetActive(!mainMenu.activeSelf);
        }

        public void ToggleGameOverMenu()
        {
            gameOverMenu.SetActive(!gameOverMenu.activeSelf);
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void ResetGame()
        {
            if (GameManager.instance._gameState == EGameStates.GameOver)
            {
                ToggleGameOverMenu();
            }
            GameManager.instance.UpdateGameState(5);
            ToggleMainMenu();
        }

        public void Restart()
        {
            if (GameManager.instance._gameState == EGameStates.GameOver)
            {
                ToggleGameOverMenu();
            }
            GameManager.instance.UpdateGameState(0);
        }
    }
}