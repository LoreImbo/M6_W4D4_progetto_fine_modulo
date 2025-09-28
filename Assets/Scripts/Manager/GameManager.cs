using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Vector3 lastCheckpoint;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);

        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void SetCheckpoint(Vector3 checkpointPos)
    {
        lastCheckpoint = checkpointPos;
        Debug.Log("Checkpoint aggiornato: " + lastCheckpoint);
    }

    public Vector3 GetCheckpoint()
    {
        return lastCheckpoint;
    }
}

