using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsdes : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name); // تحقق من أن التصادم يحدث

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched the coin");

            if (gameObject.CompareTag("Coins"))
            {
                Debug.Log("Coin is being deactivated");
                // إخفاء القطعة النقدية فورًا
                gameObject.SetActive(false);
            }
        }
    }
}

