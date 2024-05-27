using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class NpcMovementStrategyChanger : MonoBehaviour
{
    [SerializeField] private Npc npc;
    [SerializeField] private float oneStrategyTime = 10;
    public MovementStrategy currentStrategy = MovementStrategy.Idle;
    
    // Start is called before the first frame update
    void Awake()
    {
        SwitchStrategy();
    }

    public void SwitchStrategy()
    {
        switch (currentStrategy)
        {
            case MovementStrategy.Idle:
                SetUpIdle();
                break;
            case MovementStrategy.Attack:
                SetUpAttack();
                break;
        }
    }

    public void SetIdle()
    {
        currentStrategy = MovementStrategy.Idle;
        SetUpIdle();
    }
    
    private void SetUpIdle()
    {
        Debug.Log("idle");
        npc.MovementStrategy = new IdleMovementStrategy(npc.transform, npc.MovementSpeed, npc.IdleMovementOneVectorTime);
    }
    
    public void SetAttack()
    {
        currentStrategy = MovementStrategy.Attack;
        SetUpAttack();
    }

    private void SetUpAttack()
    {
        Debug.Log("attack");
        npc.MovementStrategy = new AttackMovementStrategy(npc.transform, npc.MovementSpeed);
    }
}
