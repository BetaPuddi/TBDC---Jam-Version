using System;
using UnityEngine;
using LogSystem;

public class LogManager : MonoBehaviour
{
    private static LogManager _instance;
    [SerializeField] private GameObject logPrefab;
    [SerializeField] private GameObject logPanel;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public void InstantiateLog(string logText)
    {
        var newLogPrefab = Instantiate(logPrefab, logPanel.transform);
        var newLogEntry = newLogPrefab.GetComponent<LogEntry>();
        newLogEntry.SetLogText(logText);
    }
}
