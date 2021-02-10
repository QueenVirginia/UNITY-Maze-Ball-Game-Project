using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public GameObject ScoreText;
    public TextMeshProUGUI crystalUI;
    public static int theScore;
    public static int crystalCollected;

    void Awake()
    {
        theScore = 0;
        crystalCollected = 0;
        Update();
    }

    // Start is called before the first frame update
    void Update()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + theScore;
        crystalUI.GetComponent<TextMeshProUGUI>().text = crystalCollected + " / 29";

        if(crystalCollected == 29)
        {
            SceneManager.LoadScene("FinishChristmas");
        }
    }
}
