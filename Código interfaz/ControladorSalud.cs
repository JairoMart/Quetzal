using UnityEngine;

// Just a simple health manager to show how you can controll the HealthBar UI
public class ControladorSalud : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public BarraSalud barraSalud;

    void Start()
    {
        currentHealth = maxHealth;
        barraSalud.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // Damage player when we press the G key
        if (Input.GetKeyDown(KeyCode.G))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        barraSalud.SetCurrentHealth(currentHealth);
    }
}
