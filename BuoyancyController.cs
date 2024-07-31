using UnityEngine;
using UnityEngine.UI;

public class BuoyancyController : MonoBehaviour
{
    public GameObject diver;
    public Slider buoyancySlider;
    public float buoyancyEffect = 0.1f;
    public float weightEffect = 0.1f;

    private float currentBuoyancy;
    private float weight;

    void Start()
    {
        // Initialisation des valeurs
        currentBuoyancy = buoyancySlider.value;
    }

    void Update()
    {
        // Ajuster la position du plongeur en fonction de la flottabilité
        Vector3 position = diver.transform.position;
        position.y += (currentBuoyancy - weight) * buoyancyEffect * Time.deltaTime;
        diver.transform.position = position;
    }

    public void AdjustBuoyancy(float value)
    {
        currentBuoyancy = value;
    }

    public void AddWeight()
    {
        weight += weightEffect;
    }

    public void RemoveWeight()
    {
        if (weight > 0)
            weight -= weightEffect;
    }
}
