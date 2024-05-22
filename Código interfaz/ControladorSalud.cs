using UnityEngine;

// Just a simple health manager to show how you can controll the HealthBar UI
public class ControladorSalud : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public BarraSalud barraSalud;

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

       
    }
}
