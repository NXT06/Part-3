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
            GameManager.scoreColor = 1;
            GameManager.ordersFailed++;
            GameManager.customerCount--;
            GameManager.score = GameManager.score - GrooseScore;
            Ingredients.Reset();
            GrooseFactor(); 
            this.gameObject.SetActive(false);
        }
    }
    protected override void Timer()
    {
        customer = true;
        float maxTime = 8;
        patience = maxTime;
        patienceMeter.maxValue = maxTime;
    }

    protected void GrooseFactor()
    {
        if (patience <= 0)
        {
            GameManager.timer = GameManager.timer - 5; 
        }

    }
}
