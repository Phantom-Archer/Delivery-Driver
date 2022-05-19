using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField] float speedBoostAmount = 10f;
    [SerializeField] float timeBoostLasts = 2.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Driver>() == null)
        {
            return;
        }

        StartCoroutine(collision.GetComponent<Driver>().IncreaseSpeed(speedBoostAmount, timeBoostLasts));
    }
}
