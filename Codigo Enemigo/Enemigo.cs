using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    private Animator animator;
    //public bool atacando;

    private void Start()
    {
       animator = GetComponent<Animator>();
    }
 
    public void TomarDaño(float daño)
    {
       gameObject.GetComponent<SpriteRenderer>().color=new Color(vida/100f, vida/100f, 1, 1);
        vida -= daño;



        if(vida <= 0)
        {
         //   atacando = false; 
         //  Destroy(gameObject);
            Muerte();
            
        }
    }
    private void Muerte()
    {
        animator.SetTrigger("muriendo");
    }

}
