using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private float _axisValue;
    private PlayerController _player;

    private void Start()
    {
        _player = GetComponent<PlayerController>();
    }

    void Update()
    {
        _axisValue = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player.FoodShots();
        }
    }

    private void FixedUpdate()
    {
        _player.Movements(_axisValue);
    }
}
