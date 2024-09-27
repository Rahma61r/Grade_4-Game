using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycoin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject C; // الكائن الذي يمثل الكلب

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name); // تحقق من أن التصادم يحدث
        if (other.CompareTag("Player") && gameObject.CompareTag("C"))
        {
            Debug.Log("Player touched the C");
            // إخفاء الكلب
            gameObject.SetActive(false);



        }
    }
}
