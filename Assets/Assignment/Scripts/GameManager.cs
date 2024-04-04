using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static float timer;
    public static int scoreColor; 
    public static int score;
    public Slider clock;
    public Image clockImage; 
    public Transform pos; 
    public static int customerCount;
    public GameObject Soup; 
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ordersServedText; 
    public List<GameObject> customers;
    public static int ordersServed;
    public static int ordersFailed;
    PlayerPrefs currentScore; 

    private void Start()   //setting initial values 
    {
        timer = 60; 
        clock.maxValue = timer; 
        customerCount = 0; 
        score = 0;
        ordersServed = 0;
        ordersFailed = 0;
    }
    private void Update()       
    {
        GameTimer();  //starting game timer
        score = Mathf.Clamp(score, 0, 10000);  //clamping score so it can't go into negatives
        scoreText.text = (score.ToString());            //updating score text and orders served text
        ordersServedText.text = (ordersServed.ToString());
        SpawnCustomer(); 
        if (scoreColor != 0)
        {
            StartCoroutine(ScoreIndicator()); //setting score color to green or red 
        }
    }
    public void SpawnCustomer()
    {
        if (customerCount == 0)   //spawning customer when there are no customers in game 
        {
            StartCoroutine(CustomerSpawner());
        } 
    }

    IEnumerator CustomerSpawner()       //setting next customer to true and instantiating soup gameObject 
    {
        customerCount++;
        Instantiate(Soup, pos.position, pos.rotation);  
        customers[Random.Range(0, customers.Count)].SetActive(true);
        yield return new WaitForSeconds(Random.Range(5f, 8f));
       
    }

    public void GameTimer()
    {

        timer -= Time.deltaTime;            //timer decreases ever second
        clock.value = Mathf.Round(timer);   // assigning pumpkin slider clock to game timer 
        if (timer < 10)
        {
            clockImage.color = Color.red;   //if there are only 10 seconds left, turns the pumpkin clock red 
        }
        if (timer < 1)          //if time reaches 0, loads next scene 
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()  //loading next scene script
    {
        PlayerPrefs.SetInt("served", ordersServed);         //setting player prefs (score and customer count) 
        PlayerPrefs.SetInt("currentScore", score);
        Highscore(); 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void Highscore()
    {
        PlayerPrefs.GetInt("HighScore");        //assinging highscore to current score if current score is greater
        
        if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("currentScore")); 
        }
    }

    public IEnumerator ScoreIndicator()     //changing color of score text for 1 second depending if order is served or failed and then setting it back to white 
    {
        if (scoreColor == 1)
        {
            scoreText.color = Color.red;
            yield return new WaitForSeconds(1);
            scoreText.color = Color.white;
            scoreColor = 0; 
        }
        if (scoreColor == 2)
        {
            scoreText.color = Color.green;
            yield return new WaitForSeconds(1);
            scoreText.color = Color.white;
            scoreColor = 0;

        }
    }
    }
