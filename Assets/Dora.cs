﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus; // أصلح الخطأ هنا حيث يجب أن تكون Fungus

public class Dora : MonoBehaviour
{
    public Flowchart myFlowchart;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Corrected method name and parameter type
    void OnTriggerEnter(Collider x)
    {
        if (x.gameObject.tag == "Dora")
        {
            myFlowchart.ExecuteBlock("Dora");
        }
        if (x.gameObject.tag == "Secovdpound")
        {
            myFlowchart.ExecuteBlock("takeBluebootel");
        }
        if (x.gameObject.tag == "second")
        {
            myFlowchart.ExecuteBlock("takesecond");
        }
        if (x.gameObject.tag == "third")
        {
            myFlowchart.ExecuteBlock("takethird");
        }
        if (x.gameObject.tag == "fourth")
        {
            myFlowchart.ExecuteBlock("takefourth");
        }
    }

}
