using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam1;
    [SerializeField] private CinemachineVirtualCamera cam2;

    private CinemachineVirtualCamera activeCam;

    void Start()
    {
        // Imposto la prima camera come attiva
        SetActiveCamera(cam1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) // premi "C" per cambiare camera
        {
            if (activeCam == cam1)
                SetActiveCamera(cam2);
            else
                SetActiveCamera(cam1);
        }
    }

    void SetActiveCamera(CinemachineVirtualCamera newCam)
    {
        cam1.Priority = 0;
        cam2.Priority = 0;

        newCam.Priority = 10; // la più alta diventa attiva
        activeCam = newCam;
    }
}

