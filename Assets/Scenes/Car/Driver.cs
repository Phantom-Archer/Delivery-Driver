using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateFactor;
    void Start()
    {
        Debug.Log("I am a car lol");
    }

    
    void Update()
    {
        transform.Rotate(0, 0, rotateFactor * Time.deltaTime);    
    }
}
