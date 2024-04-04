using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cawlin : Customers
{
    public int CawlinScore; 

    private void Update()
    {
        Patience();
        if (patience <= 0)
        {
            GameManager.scoreColor = 1;
            GameManager.ordersFailed++; 
            GameManager.customerCount--;
            GameManager.score = GameManager.score - CawlinScore;  //subtracting score by Cawlin's score value 
            Ingredients.Reset();
            this.gameObject.SetActive(false);       //turning customer off
        }
    }

    // Update is called once per frame
    protected override void Timer()
    {
        customer = true;
        float maxTime = 5;      //setting max patience time to 5 
        patience = maxTime;
        patienceMeter.maxValue = maxTime;
    }
}
