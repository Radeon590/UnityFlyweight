using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMovementStrategy : IMovementStrategy
{
    private Transform _transform;
    private float _movementSpeed;
    private float _startTime;
    private Vector3 _startPosition;
    private Transform _playerTransform;
    
    public AttackMovementStrategy(Transform transform, float movementSpeed)
    {
        _transform = transform;
        _movementSpeed = movementSpeed;
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        _startPosition = _transform.position;
        _startTime = Time.time;
    }

    public void Move()
    {
        float journeyLength = Vector3.Distance(_startPosition, _playerTransform.position);
        
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - _startTime) * _movementSpeed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;
        
        _transform.position = Vector3.Lerp(_startPosition, _playerTransform.position, fractionOfJourney);
    }
}
