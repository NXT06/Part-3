using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cawlin : Customers
{
    // Start is called before the first frame update
    private void Update()
    {
        Patience();
        if (patience <= 0)
        {


            GameManager.customerCount--;
            GameManager.score = GameManager.score - 75;
            Ingredients.Reset();
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    protected override void Timer()
    {
        customer = true;
        float maxTime = 7;
        patience = maxTime;
        patienceMeter.maxValue = maxTime;
    }
}
