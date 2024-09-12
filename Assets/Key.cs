using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool isFollowing;
    private float followspeed;
    public Transform followTarget;


    // Start is called before the first frame update
    void Start()
    {
        isFollowing=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followspeed *Time.deltaTime);
        }

    }
}
