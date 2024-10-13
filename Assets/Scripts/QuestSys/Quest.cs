// Quest.cs (Scriptable Object)
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quests/Quest")]
public class Quest : ScriptableObject
{
    public string questID;
    public string questName;
    public string questDescription;
    public Objective[] objectives;
    public Reward[] rewards;
    public QuestState questState;

    public enum QuestState { Available, InProgress, Completed }

    public void Initialize()
    {
        questState = QuestState.Available;
    }

    public void StartQuest()
    {
        questState = QuestState.InProgress;
    }

    public void CompleteQuest()
    {
        questState = QuestState.Completed;
    }
}