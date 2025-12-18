using System.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class animatronicBehauviour : MonoBehaviour
{
    public GameObject cam1Location;
    public GameObject cam2Location;
    public GameObject cam3Location;
    public GameObject officeLeftLocation;
    public GameObject officeRightLocation;
    public GameObject tuxJumpscare;
    public TMPro.TextMeshProUGUI powerLevelText;
    public int powerLevel = 100;
    public int powerConsumption = 1;
    public GameObject deathScreen;
    public GameObject cameraOverlay;
    public GameObject cameraButton;

    public string tuxLocation = "cam1";
    public bool isAlive = true;
    public int difficulty = 1;
    int movmentInt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(moveTux());
        StartCoroutine(powerTick());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator moveTux()
    {
        while (isAlive)
        {
            yield return new WaitForSeconds(5);

            Debug.Log(tuxLocation + " is Tux's current location");
            movmentInt = Random.Range(1, 20);
            Debug.Log("Tux rolled a " + movmentInt);
            if (movmentInt <= difficulty)
            {
                Debug.Log("Tux is Moving!");
                if (tuxLocation == "cam1")
                {
                    int randomLeftOrRight = Random.Range(1, 3);
                    if (randomLeftOrRight == 1)
                    {
                        cam1Location.SetActive(false);
                        cam2Location.SetActive(true);
                        tuxLocation = "cam2";
                    }
                    else
                    {
                        cam1Location.SetActive(false);
                        cam3Location.SetActive(true);
                        tuxLocation = "cam3";
                    }
                }
                else if (tuxLocation == "cam2")
                {
                    cam2Location.SetActive(false);
                    officeLeftLocation.SetActive(true);
                    tuxLocation = "leftOffice";
                }
                else if (tuxLocation == "cam3")
                {
                    cam3Location.SetActive(false);
                    officeRightLocation.SetActive(true);
                    tuxLocation = "rightOffice";
                }
                else if (tuxLocation == "leftOffice" || tuxLocation == "rightOffice")
                {
                    officeLeftLocation.SetActive(false);
                    officeRightLocation.SetActive(false);
                    tuxJumpscare.SetActive(true);
                    Debug.Log("Tux is in the office!");
                    cameraOverlay.SetActive(false);
                    cameraButton.SetActive(false);
                
                    yield return new WaitForSeconds(5);
                    deathScreen.SetActive(true);
                    isAlive = false;
                    yield break;
                }
            }   
        }
    }
    IEnumerator powerTick()
    {
        while (isAlive)
        {
            yield return new WaitForSeconds(10);
            
            powerLevel -= powerConsumption;
            powerLevelText.text = "Power Level: " + powerLevel + "%";
            if (powerLevel <= 0)
            {
                isAlive = false;
                Debug.Log("You ran out of power!");
                tuxJumpscare.SetActive(true);
                cameraOverlay.SetActive(false);
                cameraButton.SetActive(false);
                
                yield return new WaitForSeconds(5);
                deathScreen.SetActive(true);
                yield break;
            }
        }
    }
    public void increasePowerConsumption(int increase)
    {
        powerConsumption += increase;
        Debug.Log("Camera opend");
    }
    public void decreasePowerConsumption(int decrease)
    {
        powerConsumption -= decrease;
        Debug.Log("Camera opend");
    }
}
