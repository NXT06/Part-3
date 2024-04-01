using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strich : Customers
{
    private void Update()
    {
        Patience();
        if (patience <= 0)
        {

            GameManager.ordersFailed++;
            GameManager.customerCount--;
            GameManager.score = GameManager.score - 50;
            Ingredients.Reset();
            this.gameObject.SetActive(false);
        }
    }

}
