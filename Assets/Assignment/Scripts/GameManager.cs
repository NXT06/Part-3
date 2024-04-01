using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    float ingredients;
    public static float score;
    public static int customerCount;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ordersServedText; 
    public List<GameObject> customers;
    public static int ordersServed;
    private void Start()
    {
        customerCount = 0; 
        score = 200; 
    }
    private void Update()
    {
        score = Mathf.Clamp(score, 0, 1000); 
        scoreText.text = ("$" + score.ToString());
        ordersServedText.text = (ordersServed.ToString());
        SpawnCustomer(); 
        Debug.Log(customerCount);
    }
    public void SpawnCustomer()
    {
        if (customerCount != 1)
        {
            StartCoroutine(CustomerSpawner());
 
        } 
    }

    IEnumerator CustomerSpawner()
    {
        customerCount++;
        customers[Random.Range(0, customers.Count)].SetActive(true);
        yield return new WaitForSeconds(Random.Range(5f, 8f));
       
    }
    

    

}
