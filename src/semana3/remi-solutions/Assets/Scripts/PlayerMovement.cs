using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidade do movimento

    void Update()
    {
        // Captura os inputs de movimento
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcula a direção do movimento
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Move o personagem
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
