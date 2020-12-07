using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestowyCube : QuestGiver
{
    private void Start()
    {

    }

    override public void StartQuest()
    {
        Debug.Log("I oto daję ci quest");
        subscribedPlayer.quests.Add(questsToGive[0]);
        questsToGive[0].OnStart();
    }

    override public void UpdateQuest()
    {
        foreach (Quest quest in questsToGive)
        {
            if (quest.IsCompleted()) continue;

            if(quest.IsStarted())
            {
                quest.OnUpdated();
                // tu sprawdzanie warunków questa i po spełnieniu wywołanie
                // FinishQuest();
            } else
            {
                StartQuest();
            }
        }
    }

    override public void FinishQuest()
    {
        Debug.Log("Quest wykonany. Naści dukata!");
    }
}
