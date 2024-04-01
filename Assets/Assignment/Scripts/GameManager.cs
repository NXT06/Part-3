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
    public Transform pos; 
    public static int customerCount;
    public GameObject Soup; 
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ordersServedText; 
    public List<GameObject> customers;
    public static int ordersServed;
    public static int ordersFailed; 
    private void Start()
    {
        customerCount = 0; 
        score = 200; 
    }
    private void Update()
    {
        score = Mathf.Clamp(score, 0, 10000); 
        scoreText.text = ("$" + score.ToString());
        ordersServedText.text = (ordersServed.ToString());
        SpawnCustomer(); 
        Debug.Log(customerCount);
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

    
    

    

}
