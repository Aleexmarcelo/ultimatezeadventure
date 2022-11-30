using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveKinemact : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.isKinematic = false;
        }
    }
}
