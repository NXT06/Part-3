using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GrooseRecipe : Recipes
{
    protected void OnEnable()
    {
        numOfSalt = Random.Range(3, 9);
        numOfPumpkin = Random.Range(3, 9);  
        numOfOnions = Random.Range(3, 9);
        points = 100;
    }
   
}
