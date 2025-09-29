using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam1;
    [SerializeField] private CinemachineVirtualCamera cam2;
    [SerializeField] private CinemachineVirtualCamera cam3;

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
            CycleCamera();
        }
    }

    void CycleCamera()
    {
        if (activeCam == cam1)
            SetActiveCamera(cam2);
        else if (activeCam == cam2)
            SetActiveCamera(cam3);
        else
            SetActiveCamera(cam1);
    }

    void SetActiveCamera(CinemachineVirtualCamera newCam)
    {
        // Metti tutte le camere a priorità bassa
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 0;

        // Attiva la camera scelta
        newCam.Priority = 10;
        activeCam = newCam;
    }
}


