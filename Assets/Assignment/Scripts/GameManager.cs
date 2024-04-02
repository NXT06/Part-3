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

    private void Start()
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
        GameTimer(); 
        score = Mathf.Clamp(score, 0, 10000); 
        scoreText.text = (score.ToString());
        ordersServedText.text = (ordersServed.ToString());
        SpawnCustomer(); 
        Debug.Log(customerCount);
        if (scoreColor != 0)
        {
            StartCoroutine(ScoreIndicator()); 
        }
    }
    public void SpawnCustomer()
    {
        if (customerCount == 0)
        {
            StartCoroutine(CustomerSpawner());
        } 
    }

    IEnumerator CustomerSpawner()
    {
        customerCount++;
        Instantiate(Soup, pos.position, pos.rotation); 
        customers[Random.Range(0, customers.Count)].SetActive(true);
        yield return new WaitForSeconds(Random.Range(5f, 8f));
       
    }

    public void GameTimer()
    {

        timer -= Time.deltaTime;
        clock.value = Mathf.Round(timer); 
        if (timer < 10)
        {
            clockImage.color = Color.red; 
        }
        if (timer < 1)
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()  //loading next scene script
    {
        PlayerPrefs.SetInt("served", ordersServed); 
        PlayerPrefs.SetInt("currentScore", score);
        Highscore(); 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
        Debug.Log("load"); 
    }

    public void Highscore()
    {
        PlayerPrefs.GetInt("HighScore");
        
        if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("currentScore")); 
        }
    }

    public IEnumerator ScoreIndicator()
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
