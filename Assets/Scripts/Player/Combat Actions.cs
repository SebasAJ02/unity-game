using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CombatActions : MonoBehaviour
{
    [Header("Sistema de Disparo")]
    [SerializeField] private float fireRange;

    [Header("Escudo")]

    [SerializeField] private float shieldTime;
    [SerializeField] private float shieldCoolDown;
    private bool shieldReady = true;
    [SerializeField] private GameObject shield;

    //Mecanismo de Escudo...

    public void Activate_Shield(InputAction.CallbackContext callback)
    {
        //Debug.Log("Antes if");
        if(callback.performed)
        {
            //Debug.Log("Entro");
            StartCoroutine(ShieldAction());
        }
    }

    public IEnumerator ShieldAction()
    {
        shield.SetActive(true);
        shieldReady = false;
        //Debug.Log("Se Activo Escudo");
        yield return new WaitForSeconds(shieldTime);
        //Debug.Log("Se desactivo Escudo");
        shield.SetActive(false);
        StartCoroutine(ShieldAction());
    }

    public IEnumerator ShieldRe()
    {
        yield return new WaitForSeconds(shieldCoolDown);
        shieldReady = true;
    }
}
