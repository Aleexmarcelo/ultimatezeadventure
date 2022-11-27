using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Animations;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Animator animatorNPC;
    //public Animator Thanks;
   // public Animator Idle;
   // public Animator Fome;

    private void Start()
    {
        //Fome.SetTrigger("Fome");
        animatorNPC.SetTrigger("Fome");
        Debug.Log("Fome");
    }

    private void OnTriggerEnter(Collider other)
    {
        Thanks();
        
        //  Thanks.SetTrigger("Thanks");
        //Idle.SetTrigger("Idle");
    }

    void Thanks()
    {
        animatorNPC.SetBool("Thanks", true);
        //animatorNPC.SetTrigger("Thanks");
        Debug.Log("Obrigado");
    }
}
