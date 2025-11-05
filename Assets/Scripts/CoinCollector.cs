using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [Tooltip("Tag used for coins (make sure your coin GameObjects are tagged 'Coin')")]
    public string coinTag = "Coin";

    [Tooltip("Particle effect prefab to play when collecting a coin")]
    public ParticleSystem collectEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if we collided with a coin
        if (other.CompareTag(coinTag))
        {
            // Spawn the visual or particle effect at the coin's position
            if (collectEffect != null)
            {
                Instantiate(collectEffect, other.transform.position, Quaternion.identity);
            }

            // Destroy or disable the coin
            Destroy(other.gameObject);
        }
    }
}
