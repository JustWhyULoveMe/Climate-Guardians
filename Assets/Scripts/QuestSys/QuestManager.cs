// QuestManager.cs
using UnityEngine;
using System.Collections.Generic;

public class QuestManager : Singleton<QuestManager>
{
    private List<Quest> quests = new List<Quest>();
    private Dictionary<string, Quest> questDictionary = new Dictionary<string, Quest>();

    public void LoadQuests()

    {
        // Load all Quest Scriptable Objects
        Quest[] questAssets = Resources.LoadAll<Quest>("Quests");

        // Iterate through the loaded quests and add them to the lists
        foreach (Quest quest in questAssets)
        {
            quests.Add(quest);
            questDictionary.Add(quest.questID, quest);
        }
    }

    public Quest GetQuest(string questID)
    {
        return questDictionary[questID];
    }

    public void AcceptQuest(Quest quest)
    {
        quest.StartQuest();
        // Notify UI
    }

    public void CompleteQuest(Quest quest)
    {
        quest.CompleteQuest();
        // Reward player
        foreach (Reward reward in quest.rewards)
        {
            // Grant reputation points
            CityReputationManager.Instance.IncreaseReputation(reward.reputationPoints);

            // Grant money
            CityEconomyManager.Instance.AddMoney(reward.money);

            // Reduce pollution
            CityPollutionManager.Instance.ReducePollution(reward.pollutionReduction);
        }
        // Notify UI
    }

    public void UpdateQuestProgress(Quest quest)
    {
        foreach (Objective objective in quest.objectives)
        {
            if (objective.IsCompleted())
            {
                // Update quest state
                quest.CompleteQuest();
                break;
            }
        }
    }
}