using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collectcoins : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI CoinText;

    private void Start()
    {
        // تعيين النص الافتراضي عند بدء اللعبة
        CoinText.text = ": " + Coin.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // التحقق من العلامة باستخدام CompareTag
        {
            Coin++; // زيادة عدد العملات
            CoinText.text = ": " + Coin.ToString(); // تحديث النص بعد زيادة العملات
            Destroy(other.gameObject); // تدمير كائن العملة
        }
    }
}
