using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedMode : MonoBehaviour
{
    public Text ModeText;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ModeText.GetComponent<Text>().text = "Slow Mode";
            Time.timeScale = 0.5f;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ModeText.GetComponent<Text>().text = "Normal Mode";
            Time.timeScale = 1f;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            ModeText.GetComponent<Text>().text = "Fast Mode";
            Time.timeScale = 2f;
        }
    }
}
