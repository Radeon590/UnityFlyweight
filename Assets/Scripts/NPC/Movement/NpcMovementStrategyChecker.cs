using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovementStrategyChecker : MonoBehaviour
{
    [SerializeField] private Npc npc;
    
    // Start is called before the first frame update
    void Start()
    {
        npc.MovementStrategy = new IdleMovementStrategy(npc.transform, npc.MovementSpeed, npc.IdleMovementOneVectorTime);
    }
}
