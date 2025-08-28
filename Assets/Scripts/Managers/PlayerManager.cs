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
        public Player defaultPlayer;
        public delegate void PlayerAttack();
        public delegate void PlayerUtility();
        public delegate void PlayerItem();
        public delegate void TakeDamage(int damage);
        public delegate void Heal(int heal);

        private PlayerAttack _playerAttack;
        private PlayerUtility _playerUtility;
        private PlayerItem _playerItem;
        private TakeDamage _takeDamage;
        private Heal _heal;

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
            _playerAttack = player.Attack;
            _playerUtility = player.UtilitySkill_01;
            _playerItem = player.ItemSkill_01;
            _takeDamage = player.TakeDamage;
            _heal = player.Heal;
        }

        public void MainAttack()
        {
            _playerAttack();
        }

        public void MainUtility()
        {
            _playerUtility();
        }

        public void MainItem()
        {
            _playerItem();
        }

        public void PlayerTakeDamage(int damage)
        {
            _takeDamage(damage);
        }

        public void PlayerHeal(int heal)
        {
            _heal(heal);
        }

        public void InitialisePlayer()
        {
            player = defaultPlayer;
        }
    }
}