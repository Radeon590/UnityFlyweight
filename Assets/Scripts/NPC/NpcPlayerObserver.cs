using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcPlayerObserver : MonoBehaviour
{
    [SerializeField] private NpcMovementStrategyChanger npcMovementStrategyChanger;

    private void Start()
    {
        PlayerEventsManager.OnUserStartMove += HandleUserStartMove;
        PlayerEventsManager.OnUserStop += HandleUserStop;
    }

    public void HandleUserStartMove()
    {
        npcMovementStrategyChanger.SetAttack();
    }

    public void HandleUserStop()
    {
        npcMovementStrategyChanger.SetIdle();
    }

    public void OnDestroy()
    {
        PlayerEventsManager.OnUserStartMove -= HandleUserStartMove;
        PlayerEventsManager.OnUserStop -= HandleUserStop;
    }
}
