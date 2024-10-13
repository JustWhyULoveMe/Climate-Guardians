/*using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Quest : MonoBehaviour
{
    [System.Serializable]

    public struct Info
    {
        public string name;
        public Sprite icon;
        public string description;

    }

    [Header("Info")] public Info information;

    [System.Serializable]
    public struct Stat
    {
        public int currency;
        public int reputation;
    }


    [Header("Reward")] public Stat reward = new Stat { currency = 100, reputation = 10};

    public bool completed {  get; private set; }
    public QuestCompletedEvent questCompleted;

    public abstract class QuestGoal : ScriptableObject
    {
        protected string description;
        public int currentAmount { get; protected set; }
        public int requiredAmount = 1;

        public bool completed { get; protected set; }
        [HideInInspector] public UnityEvent goalCompleted;


        public virtual string getDescription()
        {
            return description;
        }

        public virtual void Initialize()
        {
            completed = false;
            goalCompleted = new UnityEvent();
        }

        protected void Evaluate()
        {
            if (currentAmount >= requiredAmount)
            {
                Complete();
            }
        }
        private void Complete()
        {
            completed = true;
            goalCompleted.Invoke();
            goalCompleted.RemoveAllListeners();
        }

        public void Skip()
        {
            // Добавить скрипт пропуска квеста 
            Complete();
        }



    }


    public List<QuestGoal> Goals;

    public void Initialize ()
    {
        completed = false;
        questCompleted = new QuestCompletedEvent();

        foreach (var goal in Goals)
        {
            goal.goalCompleted.AddListener(delegate { CheckGoals(); });

        }
    }
    private void CheckGoals()
    {
        completed = Goals.All(g => g.completed);
        if (completed)
        {
            // Нагродить / Reward 
            questCompleted.Invoke(this);
            questCompleted.RemoveAllListeners();

        }
    }

}


public class QuestCompletedEvent : UnityEvent<Quest> { }

[CustomEditor(typeof(Quest))]

public class QuestEditor : Editor
{

}*/