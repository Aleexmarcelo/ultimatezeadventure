using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomFomeNPC : MonoBehaviour
{
    public AudioClip fomeSom;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(fomeSom, transform.position, 1);
    }
}
