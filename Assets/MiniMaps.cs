using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMaps : MonoBehaviour
{
    public GameObject Player;
    private void LateUpdate()
    {
        transform.position = new Vector3 (Player.transform.position.x, 40 , Player.transform.position.z);
    }
}
