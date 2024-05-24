using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovementStrategyChanger : MonoBehaviour
{
    [SerializeField] private Npc npc;
    [SerializeField] private float oneStrategyTime = 10;
    [SerializeField] private MovementStrategy currentStrategy = MovementStrategy.Attack;
    
    // Start is called before the first frame update
    void Start()
    {
        SetStrategy();
        StartCoroutine(ChangeMovementStrategyCoroutine());
    }

    private IEnumerator ChangeMovementStrategyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(oneStrategyTime);
            if ((int)currentStrategy == Enum.GetNames(typeof(MovementStrategy)).Length - 1)
            {
                currentStrategy = 0;
            }
            else
            {
                currentStrategy++;
            }
            SetStrategy();
        }
    }

    public void SetStrategy()
    {
        switch (currentStrategy)
        {
            case MovementStrategy.Idle:
                SetIdle();
                break;
            case MovementStrategy.Attack:
                SetAttack();
                break;
        }
    }
    
    public void SetIdle()
    {
        Debug.Log("idle");
        npc.MovementStrategy = new IdleMovementStrategy(npc.transform, npc.MovementSpeed, npc.IdleMovementOneVectorTime);
    }

    public void SetAttack()
    {
        Debug.Log("attack");
        npc.MovementStrategy = new AttackMovementStrategy(npc.transform, npc.MovementSpeed);
    }
}
