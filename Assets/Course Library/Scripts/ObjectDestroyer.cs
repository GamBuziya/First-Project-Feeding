using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] private float _topBorder = 30;
    [SerializeField] private float _lowerBorder = -17;

    void Update()
    {
        if(transform.position.z < _lowerBorder) Destroy(gameObject);
        else if (transform.position.z > _topBorder) Destroy(gameObject);
    }
}
 