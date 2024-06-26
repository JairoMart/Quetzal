using UnityEngine;

// Just a simple health manager to show how you can controll the HealthBar UI
public class ControladorSalud : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public BarraSalud barraSalud;

    public Animator ani;
 


    private void Start()
    {
        currentHealth = maxHealth;
        barraSalud.SetMaxHealth(maxHealth);
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        barraSalud.SetCurrentHealth(currentHealth);
       
    }

 void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemigo"))
        {
           ani.SetBool("sufre", true);
           TakeDamage(5);
        }
        
        
    }
    
}
