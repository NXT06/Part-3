using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{

    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore; 

    // Start is called before the first frame update
    void Start()
    {
        score.text = ("Your Score: " + PlayerPrefs.GetInt("currentScore").ToString());
        highScore.text = ("High Score: " + PlayerPrefs.GetInt("HighScore").ToString());

    }

    public void LoadNextScene()  //loading next scene script
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
        Debug.Log("load");
    }
}
