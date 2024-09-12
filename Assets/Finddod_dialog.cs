using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finddod_dialog : MonoBehaviour
{
    [SerializeField] GameObject keyobj;
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
        if (other.CompareTag("Find"))
        {
            cantertook = true;
            keyobj.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Find"))
        {
            cantertook = false;
            keyobj.SetActive(false);
        }

    }
}


