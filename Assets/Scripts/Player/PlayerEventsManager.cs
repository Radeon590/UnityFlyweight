using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class PlayerEventsManager
{
    public static UnityAction OnUserStartMove;

    public static void InvokeUserMove()
    {
        OnUserStartMove?.Invoke();
    }
    
    public static UnityAction OnUserStop;

    public static void InvokeUserStop()
    {
        OnUserStop?.Invoke();
    }
}
