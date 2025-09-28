using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Dice al GameManager che questo è il nuovo checkpoint
            GameManager.Instance.SetCheckpoint(transform.position);
        }
    }
}
