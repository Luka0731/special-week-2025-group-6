using UnityEngine;

public class doorBehaivour : MonoBehaviour
{
    public GameObject DoorLeft;
    public GameObject DoorRight;
    public animatronicBehauviour animatronicScript;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);
            
            // Debug - see what you're hitting
            if (hit.collider != null)
            {
                Debug.Log("Hit: " + hit.collider.name);
            }
            else
            {
                Debug.Log("No hit");
                return;
            }
            
            if (hit.collider.name == "DoorButtonLeft")
            {
                Debug.Log("Clicked on left button!");
                ToggleDoor(DoorLeft);
            }
            else if (hit.collider.name == "DoorButtonRight")
            {
                Debug.Log("Clicked on right button!");
                ToggleDoor(DoorRight);
            }
        }
    }
    
    void ToggleDoor(GameObject door)
    {
        door.SetActive(!door.activeSelf);
        if (door.activeSelf)
        {
            animatronicScript.increasePowerConsumption(1);
        }
        else
        {
            animatronicScript.decreasePowerConsumption(1);
        }
    }
}