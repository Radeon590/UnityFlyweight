using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public float MovementSpeed = 5;

    public float IdleMovementOneVectorTime = 3;
    //
    public IMovementStrategy MovementStrategy;

    // Update is called once per frame
    void Update()
    {
        MovementStrategy.Move();
    }
}
