using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _xRange = -24.3f;
    [SerializeField] private GameObject _prefabFood;


    public void Movements(float axisValue)
    {
        if (transform.position.x <= _xRange)
            StopMoving(_xRange);
        else if (transform.position.x >= -_xRange)
            StopMoving(-_xRange);

        transform.Translate(Vector3.right * Time.deltaTime * axisValue * _speed);
    }

    private void StopMoving(float border)
    {
        transform.position = new Vector3(border, transform.position.y, transform.position.z);
    }

    public void FoodShots()
    {
        Instantiate(_prefabFood, transform.position, _prefabFood.transform.rotation);
    }
}
