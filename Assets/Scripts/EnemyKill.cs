using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    #region Private Variables

    public GameObject thisRigidbody;

    #endregion

    void Start()
    {
        thisRigidbody = GetComponent<GameObject>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            thisRigidbody.transform.position = CheckPoint.GetActiveCheckPointPosition();
            Debug.Log("Morreste");
        }
    }
}
