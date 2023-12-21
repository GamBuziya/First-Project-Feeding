using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
