using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapyScare : MonoBehaviour
{
    public Animator Capy;

    public bool InReach;

    void Start()
    {
        InReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            InReach = true;
        }
    }


    private void Update()
    {
        if (InReach)
        {
            Capy.SetBool("Jump", true);
            Capy.SetBool("Nojump", false);
        }
    }
}
