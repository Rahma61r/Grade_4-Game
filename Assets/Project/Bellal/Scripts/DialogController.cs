using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DialogController : MonoBehaviour
{
    [SerializeField] GameObject KeyObj;
    [SerializeField] Flowchart flowchart;
    [SerializeField] string blockname;
    bool cantertook = false;
    private void Update()
    {
        ex();
    }

    void ex()
    {
        if (cantertook && Input.GetKeyDown(KeyCode.E))
        {
            flowchart.ExecuteBlock(blockname);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cantertook = true;
            KeyObj.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cantertook = false;
            KeyObj.SetActive(false);
        }
    }
}
