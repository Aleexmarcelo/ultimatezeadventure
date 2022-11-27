using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public AudioClip coletouSom;

    private void OnTriggerEnter(Collider other)
    {
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(coletouSom, transform.position, 1);
        }
    }
}
