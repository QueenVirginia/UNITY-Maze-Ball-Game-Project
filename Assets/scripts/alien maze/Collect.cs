using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Collect : MonoBehaviour
{
  public GameObject scoreText;
  public TextMeshProUGUI crystalUI;
  public static int score;
  public static int crystalCollected;

  void Awake()
    {
        score = 0;
        crystalCollected = 0;
        Update();
    }

  void Update()
  {
      scoreText.GetComponent<Text>().text = "SCORE: " + score;
      crystalUI.GetComponent<TextMeshProUGUI>().text = crystalCollected + " / 20";
      if(crystalCollected == 20)
        {
            SceneManager.LoadScene("FinishAlien");
        }
  }
}
