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
    private void OnEnable()   //when gameObject is to true from false state, start function
    {
        Timer();    
        Recipes.GetCustomer(this);  //Sending instance of customer to recipe scripts so they know what to display
    }
    protected virtual void Patience()  //patience meter decreases each second
    {
        
        patienceMeter.value = patience; //setting slider to patience value
            patience -= Time.deltaTime;
             

    }
    protected virtual void Timer()    //setting max patience timer band slider value
    {
        customer = true;
        float maxTime = 3;
        patience = maxTime; 
        patienceMeter.maxValue = maxTime;
        
    }
    public virtual void Ordering(bool orderer)   //setting ordering to true or false when called from other scripts 
    {
        isOrdering = orderer;       
    }
}
