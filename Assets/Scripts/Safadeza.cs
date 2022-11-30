using UnityEngine;
using UnityEngine.InputSystem;

public class Safadeza : MonoBehaviour
{
    private PlayerInput Input;

    private void Start()
    {
        Input = GetComponent<PlayerInput>();
    }

    private void OnDisable()
    {
        Input.actions = null;
    }
}
