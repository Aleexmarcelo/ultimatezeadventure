using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTestes : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Teste");
    }
}
