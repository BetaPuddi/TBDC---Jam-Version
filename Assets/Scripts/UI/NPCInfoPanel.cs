using System;
using Managers;
using UnityEngine;
using TMPro;

public class NPCInfoPanel : MonoBehaviour
{
    public static NPCInfoPanel instance;

    public TextMeshProUGUI npcName;

    private void OnEnable()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void UpdateNPCInfo()
    {
        npcName.text = NPCManager.instance.currentNpc.npcName;
    }
}
