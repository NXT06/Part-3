using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameManager : MonoBehaviour
{
    
    public TextMeshProUGUI highScore;


    void Start()  //diplaying highscore in UI
    {
      
        highScore.text = ("High Score: " + PlayerPrefs.GetInt("HighScore").ToString());

    }

    public void LoadNextScene()  //loading next scene script
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
