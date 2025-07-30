using UnityEngine;
using TMPro;
using Character;

namespace UI
{
    public class PlayerInfoPanel : MonoBehaviour
    {
        public Player playerRef;
        public TextMeshProUGUI playerNameText;
        public TextMeshProUGUI playerHealthText;
        public TextMeshProUGUI playerATKText;
        public TextMeshProUGUI playerDEFText;

        private void OnEnable()
        {
            playerRef = GameObject.Find("Player").GetComponent<Player>();
            Player.OnPlayerInfoChange += UpdatePlayerInfo;
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            UpdatePlayerInfo();
        }

        public void UpdatePlayerInfo()
        {
            playerNameText.text = playerRef.playerName;
            playerHealthText.text = playerRef.currentHealth.ToString();
            playerATKText.text = playerRef.attackStat.ToString();
            playerDEFText.text = playerRef.defenseStat.ToString();
        }

        public void SetPlayerStats()
        {

        }
    }
}
