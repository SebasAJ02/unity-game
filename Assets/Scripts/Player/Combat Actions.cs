using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatActions : MonoBehaviour
{
    public void Activate_Shield(InputAction.CallbackContext callback)
    {
        if(callback.performed)
        {
            Debug.Log("Se activo Escudo")
        }
    }
}
