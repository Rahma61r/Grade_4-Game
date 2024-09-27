using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindZombie : MonoBehaviour
{

    public GameObject Car;
    public GameObject Zombie;
    public GameObject Zombie2;
    public GameObject Zombie3;
    public GameObject Zombie5;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.CompareTag("Player") && gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Player touched the Zombie");
            Debug.Log("Player touched the Zombie2");
            Debug.Log("Player touched the Zombie3");
            Debug.Log("Player touched the Zombie5");






            gameObject.SetActive(false);


            Instantiate(Zombie, transform.position, transform.rotation);
            Instantiate(Zombie2, transform.position, transform.rotation);
            Instantiate(Zombie3, transform.position, transform.rotation);
            Instantiate(Zombie5, transform.position, transform.rotation);

        }
    
}
}
