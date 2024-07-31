using UnityEngine;

public class DiverMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement
    public float rotationSpeed = 100f; // Vitesse de rotation

    void Update()
    {
        // Mouvement avant-arrière basé sur l'entrée de l'utilisateur
        float moveDirection = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveDirection);

        // Rotation gauche-droite basée sur l'entrée de l'utilisateur
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);
    }
}
