using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Debug.Log("I dieded");
        Destroy(gameObject);
    }
}
