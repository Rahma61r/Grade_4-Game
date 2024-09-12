using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycar : MonoBehaviour
{

    public GameObject Car; 
    public GameObject coins; 

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name); 
        if (other.CompareTag("Player") && gameObject.CompareTag("Car"))
        {
            Debug.Log("Player touched the Car");
         
            gameObject.SetActive(false);


            Instantiate(coins, transform.position, transform.rotation);

        }
    }
}

