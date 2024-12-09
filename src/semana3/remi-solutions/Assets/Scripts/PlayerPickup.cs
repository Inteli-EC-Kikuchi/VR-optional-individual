using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public AudioSource audioSource; // Referência ao componente AudioSource

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Debug.Log("Picked up: " + other.name);

            // Toca o som
            if (audioSource != null)
            {
                // Printa o nome do som
                Debug.Log("Playing sound: " + audioSource.clip.name);
                audioSource.Play();
                Destroy(other.gameObject, 1f);
            }

            // Remove o objeto
        }
    }
}
