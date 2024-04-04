using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{

    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI served; 

    // Start is called before the first frame update
    void Start()        //display previous attempt score and highscore 
    {
        score.text = ("Your Score: " + PlayerPrefs.GetInt("currentScore").ToString());
        highScore.text = ("High Score: " + PlayerPrefs.GetInt("HighScore").ToString());
        served.text = ("Orders Served: " + PlayerPrefs.GetInt("served").ToString()) ;
    }

    public void LoadNextScene()  //loading next scene script
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
