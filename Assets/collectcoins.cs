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
        CoinText.text = "Coins: " + Coin.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // التحقق من العلامة باستخدام CompareTag
        {
            CoinText.text = "Coins: " + Coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
