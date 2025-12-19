using UnityEngine;
using TMPro;
using System.Collections;

public class TimeCounter : MonoBehaviour
{
    public static int seconds = 12;
    public TextMeshProUGUI timeText;
    public GameObject uiElement;
    void Start()
    {
        uiElement.SetActive(false);
        StartCoroutine(CountTime());
    }

    IEnumerator CountTime()
    {   
        timeText.text =  seconds.ToString() + " am";
        seconds = 0;
        while (true)
        {
            yield return new WaitForSeconds(60f);
            seconds++;
            timeText.text =  seconds.ToString() + " am";
            if (seconds == 6)
            {
                break;
            }
        }
        uiElement.SetActive(true);
        timeText.text = "6 am - You Survived!";
    }
}
