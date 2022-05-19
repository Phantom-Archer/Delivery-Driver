using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour
{
    [SerializeField] float speedDecreaseAmount;
    [SerializeField] float timeToDecreaseSpeed;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Driver>() == null)
        {
            return;
        }    

        StartCoroutine(collision.GetComponent<Driver>().DecreaseSpeed(speedDecreaseAmount, timeToDecreaseSpeed));
    }
}
