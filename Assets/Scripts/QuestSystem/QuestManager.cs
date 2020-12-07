using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();


    void Start()
    {
        
    }

    void Update()
    {
        

    }

    void OnGUI()
    {
        if (quests.Count == 0) return;

        GUI.Label(new Rect(15, 15, 200, 20), "Aktywne questy: ");

        int y = 15;
        foreach(Quest quest in quests)
        {
            GUI.Label(new Rect(15, 15 + y, 400, 20), quest.GiveDescription());
            y += 15;
        }

    }
}
