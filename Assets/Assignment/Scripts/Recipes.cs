using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; 

public class Recipes : MonoBehaviour
{
    // Start is called before the first frame updat
    public int numOfOnions;
    public int numOfSalt;
    public int numOfPumpkin;
    public List<TextMeshProUGUI> numOfIngredients;
    public int points; 

    public static Customers customerSelected { get; private set; }


    // Update is called once per frame
    void Update()
    {
        Recipe(); 
        DisplayRecipe();
        
    }


    public static void GetCustomer(Customers customer)
    {
        if (customerSelected != null)
        {
            customerSelected.Ordering(false);
        }
        customerSelected = customer;
        customerSelected.Ordering(true);    
    }
    protected virtual void Recipe()
    {
        
        if (Ingredients.salt == numOfSalt && Ingredients.pumpkin == numOfPumpkin && Ingredients.onion == numOfOnions)
        {
            if (Input.GetMouseButtonUp(1)) 
            {
                GameManager.scoreColor = 2; 
                GameManager.score += points;
                GameManager.ordersServed++;
                GameManager.customerCount--;
                Ingredients.Reset();
                
                customerSelected.gameObject.SetActive(false);
            }
          
        }


    }
    public void DisplayRecipe()
    {
        numOfIngredients[2].text = numOfPumpkin.ToString();
        numOfIngredients[1].text = numOfOnions.ToString();
        numOfIngredients[0].text = numOfSalt.ToString();
    }
}
