using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class camerScript : MonoBehaviour
{
    public Button openCameraButton;
    public GameObject mainCameraUI;
    public Button closeCameraButton;

    public animatronicBehauviour animatronicScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        openCameraButton.onClick.AddListener(openCameras);
        closeCameraButton.onClick.AddListener(closeCameras);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void openCameras()
    {
        mainCameraUI.SetActive(true);
        openCameraButton.gameObject.SetActive(false);
        animatronicScript.increasePowerConsumption(1);
        Debug.Log("Camera opend");
    }
    void closeCameras()
    {
        mainCameraUI.SetActive(false);
        openCameraButton.gameObject.SetActive(true);
        animatronicScript.decreasePowerConsumption(1);
        Debug.Log("Camera closed");
    }
}
