using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoraScript : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void standup()
    {
        animator.SetBool("sit",false);
    }
    public void standdown()
    {
        animator.SetBool("sit", true);
    }
}
