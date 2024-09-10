using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] Flowchart flowchart;
    [SerializeField] string blockname;
    public bool cantertook = false;
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
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cantertook = false;
        }

    }

}
