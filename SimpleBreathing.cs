using UnityEngine;

public class Breathing : MonoBehaviour
{
    public float amplitude = 0.5f; // Amplitude du mouvement respiratoire
    public float frequency = 1.0f; // Fréquence du cycle respiratoire

    private Vector3 initialPosition;
    private float initialY;

    void Start()
    {
        initialPosition = transform.position; // Enregistre la position initiale de l'objet
        initialY = initialPosition.y; // Enregistre uniquement la position Y initiale
    }

    void Update()
    {
        // Calcule la nouvelle position Y en utilisant une fonction sinusoïdale
        float newY = initialY + amplitude * Mathf.Sin(Time.time * frequency * Mathf.PI * 2.0f);
        
        // Définit la nouvelle position avec la valeur Y mise à jour, tout en conservant les valeurs X et Z
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
