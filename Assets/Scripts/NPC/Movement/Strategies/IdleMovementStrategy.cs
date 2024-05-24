using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMovementStrategy : IMovementStrategy
{
    private Transform _transform;
    private float _oneVectorMovementTimer;
    private Vector3 _currentVector;
    public float OneVectorTime { get; set; }
    public float MovementSpeed { get; set; }

    public IdleMovementStrategy(Transform transform, float movementSpeed, float oneVectorTime)
    {
        _transform = transform;
        _oneVectorMovementTimer = 0;
        CheckOneVectorTimer();
        MovementSpeed = movementSpeed;
        OneVectorTime = oneVectorTime;
    }
    
    public void Move()
    {
        _transform.Translate(_currentVector * Time.deltaTime * MovementSpeed);
        CheckOneVectorTimer();
    }

    private void CheckOneVectorTimer()
    {
        if (_oneVectorMovementTimer <= 0)
        {
            RandomizeCurrentVector();
            _oneVectorMovementTimer = OneVectorTime;
        }
        else
        {
            _oneVectorMovementTimer -= Time.deltaTime;
        }
    }

    private void RandomizeCurrentVector()
    {
        int currentVector = Random.Range(0, 4);
        switch (currentVector)
        {
            case 0:
                _currentVector = Vector3.forward;
                break;
            case 1:
                _currentVector = Vector3.back;
                break;
            case 2:
                _currentVector = Vector3.left;
                break;
            case 3:
                _currentVector = Vector3.right;
                break;
        }
    }
}
