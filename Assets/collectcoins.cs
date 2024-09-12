using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collectcoins : MonoBehaviour
{
    private int Coin = 0; // تصحيح اسم المتغير
    public TextMeshProUGUI CoinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin") // تصحيح التحقق من العلامة
        {
            Coin++;
            Debug.Log(Coin);
            CoinText.text = Coin.ToString(); // تحديث النص في واجهة المستخدم
            Destroy(other.gameObject);
        }
    }
}
