using LogSystem;
using UnityEngine;

namespace Managers
{
    public class LogManager : MonoBehaviour
    {
        public static LogManager instance;
        [SerializeField] private GameObject logPrefab;
        [SerializeField] private GameObject logPanel;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void InstantiateTextLog(string logText)
        {
            var newLogPrefab = Instantiate(logPrefab, logPanel.transform);
            var newLogEntry = newLogPrefab.GetComponent<LogEntry>();
            newLogEntry.SetLogText(logText);
        }

        public void InstantiateDamageLog(string attacker, string defender, float damage)
        {
            var newLogPrefab = Instantiate(logPrefab, logPanel.transform);
            var newLogEntry = newLogPrefab.GetComponent<LogEntry>();
            var text = $"{attacker} hits {defender} for {damage} damage!";
            newLogEntry.SetLogText(text);
        }

        public void InstantiateHealLog(string user, string target, float heal)
        {
            var newLogPrefab = Instantiate(logPrefab, logPanel.transform);
            var newLogEntry = newLogPrefab.GetComponent<LogEntry>();
            var text = $"{user} heals {target} for {heal}!";
            newLogEntry.SetLogText(text);
        }
    }
}
