// Reward.cs (Scriptable Object)
using UnityEngine;

[CreateAssetMenu(fileName = "New Reward", menuName = "Quests/Reward")]
public class Reward : ScriptableObject
{
    public string rewardID;
    public string rewardDescription;
    public int reputationPoints;
    public int money;
    public float pollutionReduction;
}