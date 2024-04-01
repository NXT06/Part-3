using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Customers : MonoBehaviour
{
    public Slider patienceMeter;
    protected float patience;
    public static bool customer;
    
    bool isOrdering; 
    private void OnEnable()
    {
        Timer();
        Recipes.GetCustomer(this); 
    }
    protected virtual void Patience()
    {
        
        patienceMeter.value = patience;
            patience -= Time.deltaTime;
             

    }
    protected virtual void Timer()
    {
        customer = true;
        float maxTime = 5;
        patience = maxTime; 
        patienceMeter.maxValue = maxTime;
        
    }
    public virtual void Ordering(bool orderer)
    {
        isOrdering = orderer;       
    }
}
