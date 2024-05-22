using UnityEngine;
using UnityEngine.UI;

public class BarraSalud : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }

    public void SetCurrentHealth(int health)
    {
        slider.value = health;

    }

}
