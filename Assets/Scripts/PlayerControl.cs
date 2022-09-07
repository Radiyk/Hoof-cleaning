using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    private float _speed = -1;
    [SerializeField] private Joystick _joystick;

    [SerializeField] private Rigidbody _rb;

    
    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_joystick.Horizontal * _speed, _rb.velocity.y, _joystick.Vertical * _speed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rb.velocity);
        }
        {
            
        }
    }

    

   
}
