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
    public float dashTime = 2;
    Coroutine dashing; 
    float dashSpeed = 7;
    Vector2 dash; 
    public override ChestType CanOpen()
    {
        
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        if(dashing != null)
        {
            StopCoroutine(dashing); 
        }
        dashing = StartCoroutine(Dash()); 
        
     
        
    }
   

    IEnumerator Dash()
    {
        
        speed = dashSpeed;
        while (speed > 3)
        {
            yield return null;
        }

        base.Attack();
        yield return new WaitForSeconds(0.1f);
        SpawnKnife();
        yield return new WaitForSeconds(0.2f);
        SpawnKnife();
        
    }
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        CharacterControl.villagertText = ("Thief");
    }
    void SpawnKnife()
    {
        Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
