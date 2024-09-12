using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Findpistol : MonoBehaviour
{

    public GameObject Car;
    public GameObject Pistol;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.CompareTag("Player") && gameObject.CompareTag("Pistol"))
        {
            Debug.Log("Player touched the Pistol");
       




            gameObject.SetActive(false);


            Instantiate(Pistol, transform.position, transform.rotation);


        }

    }
}
