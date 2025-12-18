using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            print("right arrow key is held down");
            transform.Rotate(0, 20, 0);
        }
        if (Input.GetKeyUp("right"))
        {
            print("right arrow key is held Up");
            transform.Rotate(0, -20, 0);
        }

        if (Input.GetKeyDown("left"))
        {
            print("left arrow key is held down");
            transform.Rotate(0, -20, 0);
        }
        if (Input.GetKeyUp("left"))
        {
            print("left arrow key is held Up");
            transform.Rotate(0, 20, 0);
        }
    }
}
