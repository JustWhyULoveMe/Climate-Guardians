using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGoal : Quest.QuestGoal
{
    public string Building;

    public override string getDescription()
    {
        return $"Build a {Building}";
    }
}
