using UnityEngine;
using TMPro;

namespace LogSystem
{
    public class LogEntry : MonoBehaviour
    {
        public TextMeshProUGUI logText;

        public void SetLogText(string newLogText)
        {
            logText.text = newLogText;
        }
    }
}