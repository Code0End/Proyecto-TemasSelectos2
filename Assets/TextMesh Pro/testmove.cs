using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class testmove : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        Controls playerInputActions = new Controls();

        playerInputActions.am1.Enable();

        playerInputActions.am1.movement.performed += Movement_performed;

    }

    private void Movement_performed(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        Vector2 inputVector = context.ReadValue<Vector2>();
        float speed = 5f;

       

    }
}
