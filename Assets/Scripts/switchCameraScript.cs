using UnityEngine;
using UnityEngine.UI;

public class switchCameraScript : MonoBehaviour
{
    public Button cam1Button;
    public GameObject cam1UI;
    public Button cam2Button;
    public GameObject cam2UI;
    public Button cam3Button;
    public GameObject cam3UI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam1Button.onClick.AddListener(openCam1);
        cam2Button.onClick.AddListener(openCam2);
        cam3Button.onClick.AddListener(openCam3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void openCam1()
    {
        cam1UI.SetActive(true);
        cam2UI.SetActive(false);
        cam3UI.SetActive(false);
        Debug.Log("Camera 1 opened");
    }
    void openCam2()
    {
        cam1UI.SetActive(false);
        cam2UI.SetActive(true);
        cam3UI.SetActive(false);
        Debug.Log("Camera 2 opened");
    }
    void openCam3()
    {
        cam1UI.SetActive(false);
        cam2UI.SetActive(false);
        cam3UI.SetActive(true);
        Debug.Log("Camera 3 opened");
    }
}
