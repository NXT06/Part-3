using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Groose : Customers
{



    private void Update()
    {
        Patience(); 
        if (patience <= 0)
        {

            GameManager.ordersFailed++;
            GameManager.customerCount--;
            GameManager.score = GameManager.score - 100;
            Ingredients.Reset();
            this.gameObject.SetActive(false);
        }
    }
    protected override void Timer()
    {
        customer = true;
        float maxTime = 10;
        patience = maxTime;
        patienceMeter.maxValue = maxTime;
    }
}
