using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CawlinRecipe : Recipes
{
    // Start is called before the first frame update
    protected void OnEnable()
    {
        numOfSalt = Random.Range(2, 5);         //clamping random ingredient value between 2 and 5 
        numOfPumpkin = Random.Range(2, 5);
        numOfOnions = Random.Range(2, 5);
        points = 50;        //settting cawlin's point value to 50 
    }
}
