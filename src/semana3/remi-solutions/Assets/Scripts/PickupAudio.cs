using UnityEngine;

public class PickupAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Confirme que o jogador tem a tag "Player"
        {
            if (audioSource != null)
            {
                Debug.Log("Playing sound:" + audioSource.clip.name);
                audioSource.Play();
            }

            // Destroi o objeto após o som tocar
            // Destroy(gameObject, audioSource.clip.length);
        }
    }
}
