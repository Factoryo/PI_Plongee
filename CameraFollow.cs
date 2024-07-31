using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform diver; // Référence au transform du plongeur
    public Vector3 offset = new Vector3(0, 5, -10); // Décalage par rapport au plongeur

    void LateUpdate()
    {
        // Vérifie si la référence au plongeur est définie
        if (diver != null)
        {
            // Définit la position de la caméra à la position du plongeur plus le décalage
            transform.position = diver.position + offset;

            // Facultatif, oriente la caméra vers le plongeur
            transform.LookAt(diver);
        }
    }
}
