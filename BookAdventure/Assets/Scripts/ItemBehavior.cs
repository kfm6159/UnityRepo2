using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "Player")
        {

            Destroy(this.transform.gameObject);

            Debug.Log("Item collected!");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
