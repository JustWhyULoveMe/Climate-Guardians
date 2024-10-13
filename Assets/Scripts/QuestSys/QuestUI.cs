// QuestUI.cs
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text questNameText;
    public Text questDescriptionText;
    public Text objectiveText;
    public Text rewardText;

    private Quest currentQuest;
    
    private void Update()
    {
        /*AcceptQuestButton();*/
    }

    public void DisplayQuest(Quest quest)
    {
        currentQuest = quest;
        questNameText.text = quest.questName;
        questDescriptionText.text = quest.questDescription;

        string objectiveString = "";
        foreach (Objective objective in quest.objectives)
        {
            objectiveString += objective.objectiveDescription + "\n";
        }
        objectiveText.text = objectiveString;

        string rewardString = "";
        foreach (Reward reward in quest.rewards)
        {
            rewardString += reward.rewardDescription + "\n";
        }
        rewardText.text = rewardString;
    }

    public void AcceptQuestButton()
    {
        QuestManager.Instance.AcceptQuest(currentQuest);
    }

    public void CompleteQuestButton()
    {
        QuestManager.Instance.CompleteQuest(currentQuest);
    }
}