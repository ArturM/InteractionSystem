using UnityEngine;

[System.Serializable]
public class Quest
{
    static int id;
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] string reward;
    [SerializeField] bool started;
    [SerializeField] bool completed;

    public Quest(string _name, string _description, string _reward)
    {
        id = id++;
        name = _name;
        description = _description;
        reward = _reward;
        started = false;
        completed = false;
    }

    public string GiveDescription()
    {
        return id + " " + name + " " + description + " " + reward;
    }

    public bool IsStarted() => started;
    public bool IsCompleted() => completed;
    
    public void OnStart()
    {
        Debug.Log("Quest " + id + " started");
        started = true;
    }

    public void OnUpdated()
    {
        Debug.Log("Quest " + id + " updated.");
    }

    public void OnFinished()
    {
        Debug.Log("Quest " + id + "finished.");
        completed = true;
    }
}
