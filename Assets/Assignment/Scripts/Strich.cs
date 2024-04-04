using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strich : Customers
{
    public int StrichScore; 
    private void Update()
    {
        Patience();
        if (patience <= 0)
        {
            GameManager.scoreColor = 1;
            GameManager.ordersFailed++;
            GameManager.customerCount--;
            GameManager.score = GameManager.score - StrichScore;  //subtracting score by Strich's point value 
            Ingredients.Reset();
            this.gameObject.SetActive(false);   //turning customer off 
        }
    }

}
