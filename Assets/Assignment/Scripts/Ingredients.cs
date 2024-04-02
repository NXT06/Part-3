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
        pumpkin = 0;
        onion = 0;
        salt = 0;
    }
    private void Update()
    {
        if (pumpkin == 10 || onion == 10 || salt == 10)
        {
            Reset();
        }

        counts[0].text = ("x" + pumpkin.ToString());
        counts[1].text = ("x" + onion.ToString());
        counts[2].text = ("x" + salt.ToString());
    }

    
    public void Pumpkin()
    {
        pumpkin++;
        Instantiate(ingredients[1], pumpkinSpawn.position, pumpkinSpawn.rotation); 
    }

    public void Onion()
    {
        onion++;
        Instantiate(ingredients[2], onionSpawn.position, onionSpawn.rotation);
    }

    public void Salt()
    {
        salt++;
        Instantiate(ingredients[0], saltSpawn.position, saltSpawn.rotation);    
    }

    public static void Reset()
    {
        pumpkin = 0;
        onion = 0;
        salt = 0;
    }

}
