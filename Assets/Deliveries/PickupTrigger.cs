using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.1f;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<Driver>() == null)  
        {
            return;
        }
        

        if (gameObject.tag == "Package" && col.gameObject.GetComponent<Driver>().GetHasPackage() == false)
        {
            Debug.Log("Package acquired.");
            col.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            col.gameObject.GetComponent<Driver>().SetHasPackage(true);
            Debug.Log(col.gameObject.GetComponent<Driver>().GetHasPackage());
            Destroy(gameObject, destroyDelay);
        }
        else if (gameObject.tag == "Customer" && col.gameObject.GetComponent<Driver>().GetHasPackage() == true)
        {
            Debug.Log("Package delivered.");
            col.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            col.gameObject.GetComponent<Driver>().SetHasPackage(false);
            Debug.Log(col.gameObject.GetComponent<Driver>().GetHasPackage());
            Destroy(gameObject, destroyDelay);
        }
        else if (gameObject.tag == "Customer" && col.gameObject.GetComponent<Driver>().GetHasPackage() == false)
        {
            Debug.Log(col.gameObject.GetComponent<Driver>().GetHasPackage());
            Debug.Log("Where is my package???");
        }
        
    }
}
