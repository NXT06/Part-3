using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrichRecipe : Recipes
{
    // Start is called before the first frame update
    protected void OnEnable()
    {
        numOfSalt = Random.Range(0, 3);
        numOfPumpkin = Random.Range(0, 3);
        numOfOnions = Random.Range(0, 2);
        points = 25;
    }
}
