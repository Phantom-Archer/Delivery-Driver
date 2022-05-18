using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;

    void Update()
    {
        Drive();
    }

    void Drive()
    {
        var steerFactor = steerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        var moveFactor = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        
        transform.Translate(0f, moveFactor, 0f);
        transform.Rotate(0f, 0f, -steerFactor);
    }
}
