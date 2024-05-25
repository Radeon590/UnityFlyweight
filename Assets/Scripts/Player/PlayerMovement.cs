using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 7;
    //
    private bool _isMoveEventInvoked = false;
    private Vector3 _currentMovementVector = Vector3.zero;
    
    public void Move(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<Vector3>();
        _currentMovementVector = value;
        if (value == Vector3.zero)
        {
            if (_isMoveEventInvoked)
            {
                PlayerEventsManager.InvokeUserStop();
                _isMoveEventInvoked = false;
            }
        }
        else
        {
            if (!_isMoveEventInvoked)
            {
                PlayerEventsManager.InvokeUserMove();
                _isMoveEventInvoked = true;
            }
        }
    }

    private void Update()
    {
        transform.Translate(_currentMovementVector * Time.deltaTime * movementSpeed);
    }
}
