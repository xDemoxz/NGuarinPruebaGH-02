using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuertaControlador : MonoBehaviour
{


    public Animator animator;
    private void Awake()
    {
        animator.SetBool("Abrir", false);
    }

    public void AbrirCerrarPuerta()
    {
       bool Estado_Puerta = animator.GetBool("Abrir"); //Valor actual: false

        if (Estado_Puerta)
        {
            animator.SetBool("Abrir", false);
            print("Puerta cerrada");
        }
        else
        {
            animator.SetBool("Abrir", true);
            print("Puerta abierta");
        }
    }

}
