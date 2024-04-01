using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ingredients : MonoBehaviour
{
    public List<TextMeshProUGUI> counts; 
    public List<GameObject> Soups;
    public static float pumpkin;
    public static float onion;
    public static float salt;

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
        
    }

    public void Onion()
    {
        onion++;
        
    }

    public void Salt()
    {
        salt++;
        
    }

    public static void Reset()
    {
        pumpkin = 0;
        onion = 0;
        salt = 0;
    }

}
