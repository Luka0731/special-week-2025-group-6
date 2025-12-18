using UnityEngine;

public class doorBehaivour : MonoBehaviour
{
    public GameObject DoorLeft;
    public GameObject DoorRight;
    public animatronicBehauviour animatronicScript;

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Sprite clicked!");
        if (gameObject.name == "DoorButtonLeft")
        {
            ToggleDoorLeft();
        }
        else if (gameObject.name == "DoorButtonRight")
        {
            ToggleDoorRight();
        }
    }

    void ToggleDoorLeft()
    {
        DoorLeft.SetActive(!DoorLeft.activeSelf);
        if (DoorLeft.activeSelf)
        {
            animatronicScript.increasePowerConsumption(1);
        }
        else
        {
            animatronicScript.decreasePowerConsumption(1);
        }
    }
    void ToggleDoorRight()
    {
        DoorRight.SetActive(!DoorRight.activeSelf);
        if (DoorRight.activeSelf)
        {
            animatronicScript.increasePowerConsumption(1);
        }
        else
        {
            animatronicScript.decreasePowerConsumption(1);
        }
    }
}