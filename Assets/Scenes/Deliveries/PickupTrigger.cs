using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<Driver>() == null)  
        {
            return;
        }
        var playerSpriteRendererColor = col.gameObject.GetComponent<SpriteRenderer>().color;

        if (gameObject.tag == "Package" && col.gameObject.GetComponent<Driver>().GetHasPackage() == false)
        {
            Debug.Log("Package acquired.");
            playerSpriteRendererColor = Color.green;
            col.gameObject.GetComponent<Driver>().SetHasPackage(true);
            Debug.Log(col.gameObject.GetComponent<Driver>().GetHasPackage());
            Destroy(gameObject, 0.1f);
        }
        else if (gameObject.tag == "Customer" && col.gameObject.GetComponent<Driver>().GetHasPackage() == true)
        {
            Debug.Log("Package delivered.");
            playerSpriteRendererColor = Color.white;
            col.gameObject.GetComponent<Driver>().SetHasPackage(false);
            Debug.Log(col.gameObject.GetComponent<Driver>().GetHasPackage());
            Destroy(gameObject, 0.1f);
        }
        else if (gameObject.tag == "Customer" && col.gameObject.GetComponent<Driver>().GetHasPackage() == false)
        {
            Debug.Log(col.gameObject.GetComponent<Driver>().GetHasPackage());
            Debug.Log("Where is my package???");
        }
        
    }
}
