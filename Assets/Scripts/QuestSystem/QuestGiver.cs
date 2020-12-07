using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public QuestManager subscribedPlayer;
    public List<Quest> questsToGive;

    public virtual void StartQuest() { }

    public virtual void UpdateQuest() { }

    public virtual void FinishQuest() { }

    private void OnTriggerEnter(Collider other)
    {
        subscribedPlayer = other.GetComponent<QuestManager>();
        Debug.Log("mam playera");
        UpdateQuest();
    }

    private void OnTriggerExit(Collider other)
    {
        subscribedPlayer = null;
    }
}
