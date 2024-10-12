// Objective.cs (Scriptable Object)
using UnityEngine;

[CreateAssetMenu(fileName = "New Objective", menuName = "Quests/Objective")]
public class Objective : ScriptableObject
{
    public string objectiveID;
    public string objectiveDescription;
    public int targetValue;
    public int currentValue;

    public enum ObjectiveType { ReducePollution, IncreaseReputation, EarnMoney }

    public ObjectiveType objectiveType;

    public bool IsCompleted()
    {
        return currentValue >= targetValue;
    }
}