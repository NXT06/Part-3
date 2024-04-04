using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Groose : Customers
{

    public int GrooseScore; 

    private void Update()
    {
        Patience(); 
        if (patience <= 0)
        {
            GameManager.scoreColor = 1; //setting score color to red 
            GameManager.ordersFailed++;
            GameManager.customerCount--;
            GameManager.score = GameManager.score - GrooseScore;    //subtracting score by groose's point value
            Ingredients.Reset();        //resetting ingredients to 0 
            GrooseFactor(); 
            this.gameObject.SetActive(false);    //turning off customer 
        }
    }
    protected override void Timer()
    {
        customer = true;
        float maxTime = 8;      //setting max patience time to 8 
        patience = maxTime;
        patienceMeter.maxValue = maxTime;
    }

    protected void GrooseFactor()       //if player fails a groose order, the lose points and additionally lose time 
    {
        if (patience <= 0)
        {
            GameManager.timer = GameManager.timer - 5; 
        }

    }
}
