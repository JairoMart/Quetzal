using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    //private Animator animator;

    //private void Start()
    //{
    //    animator = GetComponent<animator>();
    //}

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
