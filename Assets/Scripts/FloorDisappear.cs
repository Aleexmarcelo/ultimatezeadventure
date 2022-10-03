using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDisappear : MonoBehaviour
{
    public GameObject Floor1;
    public void OnTriggerEnter(Collider other)
    {
        ActivateObject();
    }


    public void ActivateObject()
    {
        Floor1.GetComponent<MeshRenderer>().enabled = true;
    }

    public void OnTriggerExit(Collider other)
    {
        DesactivateObject();
    }

    public void DesactivateObject()
    {
        Floor1.GetComponent<MeshRenderer>().enabled = false;
    }
}
