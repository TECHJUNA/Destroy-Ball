using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    int Score=0;
    public GameObject Wintext;
    public GameObject Restartbutton;

    public void scoreUp()
    {
        Score += 10;
        if (Score == 50)
        {
            Win();   
        }
    }
    void Win()
    {
        Wintext.SetActive(true);
        Restartbutton.SetActive(true); 
    }
    public void Reset()
    {
        SceneManager.LoadScene("Game");
    }

}
