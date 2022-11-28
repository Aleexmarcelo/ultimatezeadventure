using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Animations;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Animator animatorNPC;
    public AudioClip thanksSom;

    private void Start()
    {
        //Fome.SetTrigger("Fome");
        animatorNPC.SetBool("Fome",true);
        animatorNPC.SetBool("Thanks", false);
        animatorNPC.SetBool("Idle", false);
    }

    private void OnTriggerEnter(Collider other)
    {

        animatorNPC.SetBool("Fome", false);
        animatorNPC.SetBool("Thanks", true);
        animatorNPC.SetBool("Idle", false);
        AudioSource.PlayClipAtPoint(thanksSom, transform.position, 1);
    }

    private void OnTriggerExit(Collider other)
    {
        animatorNPC.SetBool("Thanks", false);
        animatorNPC.SetBool("Fome", false);
        animatorNPC.SetBool("Idle", true);

    }
}
