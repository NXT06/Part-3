using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CharacterControl : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public static string villagertText; 
    public TextMeshProUGUI text; 
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }
    public void DropdownHasChanged(int value)
    {
        Debug.Log(dropdown.options[value].text);

    }
    public void DisplayType()
    {
        text.text = villagertText; 
    }

    private void Update()
    {
        DisplayType(); 
    }
}
