using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animals;
    [SerializeField] private float _xRange = 23;


    private void Start()
    {
        InvokeRepeating("CreateAnimals", 2, 2);
        
    }

    private void CreateAnimals()
    {
        int animalIndex = Random.Range(0, _animals.Length);
        float xPosition = Random.Range(-_xRange, _xRange);
        Instantiate(_animals[animalIndex], new Vector3(xPosition, 0f, 13), _animals[animalIndex].transform.rotation);
    }
}
