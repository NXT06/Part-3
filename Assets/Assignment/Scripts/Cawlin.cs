using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cawlin : Customers
{
    public int CawlinScore; 
    // Start is called before the first frame update
    private void Update()
    {
        Patience();
        if (patience <= 0)
        {
            GameManager.scoreColor = 1;
            GameManager.ordersFailed++; 
            GameManager.customerCount--;
            GameManager.score = GameManager.score - CawlinScore;
            Ingredients.Reset();
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    protected override void Timer()
    {
        customer = true;
        float maxTime = 5;
        patience = maxTime;
        patienceMeter.maxValue = maxTime;
    }
}
