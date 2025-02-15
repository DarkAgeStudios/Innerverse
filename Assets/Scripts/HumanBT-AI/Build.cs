using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class Build : Node
{

    public override NodeState Evaluate()
    {
        if(GameManager.Instance.PlayerTurn)
            return NodeState.FAILURE;

        Debug.Log("Build Time!");

        int[] buildCoords = GetData("BuildCoords") as int[];
        int biomeSpecification = (int)GetData("Biome");

        SpawnManager.Instance.Spawn(buildCoords[0], buildCoords[1], "Settlement");

        return NodeState.SUCCESS;

    }
}

// make sure to end turn after we do this!