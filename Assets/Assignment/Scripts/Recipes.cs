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


    void Update()
    {
        Recipe(); 
        DisplayRecipe();
        
    }


    public static void GetCustomer(Customers customer)   //recieves instance of class from customer script
    {
        if (customerSelected != null)
        {
            customerSelected.Ordering(false);
        }
        customerSelected = customer;                //sets current instance to gameObject 
        customerSelected.Ordering(true);            //sets ordering to true, displaying the current recipe 
    }
    protected virtual void Recipe()
    {
        
        if (Ingredients.salt == numOfSalt && Ingredients.pumpkin == numOfPumpkin && Ingredients.onion == numOfOnions)      //if ingredient values are equal to recipe values, complete order
        {
            if (Input.GetMouseButtonUp(1)) 
            {
                GameManager.scoreColor = 2; 
                GameManager.score += points;
                GameManager.ordersServed++;
                GameManager.customerCount--;
                Ingredients.Reset();
                
                customerSelected.gameObject.SetActive(false);       //set the current customer to false 
            }
          
        }


    }
    public void DisplayRecipe()         //displaying numbers of ingredients in recipe
    {
        numOfIngredients[2].text = numOfPumpkin.ToString();
        numOfIngredients[1].text = numOfOnions.ToString();
        numOfIngredients[0].text = numOfSalt.ToString();
    }
}
