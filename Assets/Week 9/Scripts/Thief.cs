using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public Transform spawnPoint;
    public GameObject knifePrefab; 
    public float delay1 = 0.5f;
    public float delay2 = 1.0f;
    bool dashing; 
    Vector2 dash; 
    public override ChestType CanOpen()
    {
        
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        if (dashing)
        {
            speed = speed * 3;
            dashing = false;
        }

        
        base.Attack();
     
        
        Invoke("SpawnKnife", delay1);
        Invoke("SpawnKnife", delay2);
        Invoke("DashEnd", 0.5f); 
        
    }

    void SpawnKnife()
    {
        Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation); 
    }
    void DashEnd()
    {
        speed = 3;
        dashing = true;
    }
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        CharacterControl.villagertText = ("Thief");
    }
}
