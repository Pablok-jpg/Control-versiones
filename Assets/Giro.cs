using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private float degreesPerSecond = 5f;

    void Awake()
    {
        Debug.Log("Awake");
        _transform = transform;
    }

    private void Start()
    {
       Debug.Log("Start");
    }

    void Update()
    {
       Debug.Log("Update");
        _transform.Rotate(0f, degreesPerSecond, 0f * Time.deltaTime);
    }

    private void OnDestroy()
    {

    }
}