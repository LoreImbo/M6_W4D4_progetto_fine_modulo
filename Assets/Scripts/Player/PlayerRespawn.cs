using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private float deathHeight = -10f; // se scende sotto questa Y = morto

    private void Update()
    {
        if (transform.position.y < deathHeight)
        {
            Die();
        }
    }

    void Die()
    {
        // Qui puoi decidere cosa fare alla "morte":
        // - Respawn al checkpoint
        // - Perdere una vita
        // - Ricaricare la scena

        Vector3 checkpoint = GameManager.Instance.GetCheckpoint();

        if (checkpoint != Vector3.zero)
            transform.position = checkpoint;
        else
            transform.position = Vector3.zero; // punto di default

        // (Opzionale) resetti la velocità se usi rigidbody
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null) rb.velocity = Vector3.zero;
    }
}
