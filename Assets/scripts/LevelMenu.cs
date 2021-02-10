using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Easy()
    {
        SceneManager.LoadScene("Easy");
    }

     public void Medium()
    {
        SceneManager.LoadScene("Medium");
    }

     public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }

    public void VeryHard()
    {
        SceneManager.LoadScene("VeryHard");
    }
    
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
