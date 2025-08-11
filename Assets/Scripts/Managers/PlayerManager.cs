using System;
using Character;
using UI;
using UnityEngine;

namespace Managers
{
    public class PlayerManager : MonoBehaviour
    {
        public static PlayerManager instance;

        public Player player;
        public delegate void PlayerAttack();

        public PlayerAttack playerAttack;

        public string mainName;
        public int mainCurrentHealth;
        public int mainMaxHealth;
        public int mainAttackStat;
        public int mainDefenseStat;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            UpdateMainPlayer();
        }

        public void SwapPlayer(Player newPlayer)
        {
            player = newPlayer;
            UpdateMainPlayer();
            PlayerInfoPanel.instance.UpdatePlayerInfo();
        }

        public void UpdateMainPlayer()
        {
            mainName = player.playerName;
            mainCurrentHealth = player.currentHealth;
            mainMaxHealth = player.maxHealth;
            mainAttackStat = player.attackStat;
            mainDefenseStat = player.defenseStat;
            playerAttack = player.Attack;
        }

        public void MainAttack()
        {
            playerAttack();
        }
    }
}