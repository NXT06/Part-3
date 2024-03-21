using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown; 
    public SpriteRenderer sr;
    public Color start; 
    public Color end;
    float interpolation; 

    public void SliderValueHasChanged(Single value)
    {
        interpolation = value;
    }

    public void DropdownHasChanged(int value)
    {
        Debug.Log(dropdown.options[value].text); 
    }

    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpolation/60));
    }
}
