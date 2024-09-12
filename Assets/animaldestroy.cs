using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaldestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dog; // الكائن الذي يمثل الكلب
    public GameObject coins; // الكائن الذي يمثل القطع النقدية

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name); // تحقق من أن التصادم يحدث
        if (other.CompareTag("Player") && gameObject.CompareTag("dog"))
        {
            Debug.Log("Player touched the dog");
            // إخفاء الكلب
            gameObject.SetActive(false);

            // إنشاء القطع النقدية في نفس موقع الكلب
            Instantiate(coins, transform.position, transform.rotation);

        }
    }
}



