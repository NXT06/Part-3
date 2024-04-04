using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ingredients : MonoBehaviour
{
    public List<TextMeshProUGUI> counts; 
    public List<GameObject> ingredients;
    public static float pumpkin;
    public static float onion;
    public static float salt;
    public Transform saltSpawn;
    public Transform onionSpawn;
    public Transform pumpkinSpawn; 
    private void Start()
    {
        pumpkin = 0;        //setting all values to 0
        onion = 0;
        salt = 0;
    }
    private void Update()
    {
        if (pumpkin == 10 || onion == 10 || salt == 10) //if player reaches 10 of any ingredient, resets them all to 0 
        {
            Reset();
        }

        counts[0].text = ("x" + pumpkin.ToString());        //displaying ingredients needed for recipe
        counts[1].text = ("x" + onion.ToString());
        counts[2].text = ("x" + salt.ToString());
    }

    
    public void Pumpkin()  //increasing pumpkin count and instantiating pumpkin ingredient above soup when button pressed
    {
        pumpkin++;              
        Instantiate(ingredients[1], pumpkinSpawn.position, pumpkinSpawn.rotation); 
    }

    public void Onion()//increasing onion count and instantiating onion ingredient above soup when button pressed
    {
        onion++;
        Instantiate(ingredients[2], onionSpawn.position, onionSpawn.rotation);
    }

    public void Salt()//increasing salt count and instantiating salt ingredient above soup when button pressed
    {
        salt++;
        Instantiate(ingredients[0], saltSpawn.position, saltSpawn.rotation);    
    }

    public static void Reset()      //creating a reset button that assigns all ingredients to 0 when pressed
    {
        pumpkin = 0;
        onion = 0;
        salt = 0;
    }

}
