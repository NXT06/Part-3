using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSpawner : MonoBehaviour
{
    float speed;
    float lerpTimer;
    Vector3 spawn;
    Vector3 end;
    public AnimationCurve interpolation;

    void Start()
    {
        spawn = transform.position;     //assigning spawn point to whereever the ingredient was instatiated 
        end = spawn;
        end.y = spawn.y - 10;       //assigning end position to where soup is (going into the soup)
         
    }


    void Update()
    {
        lerpTimer += Time.deltaTime;
        speed = interpolation.Evaluate(lerpTimer);              //using animation curve 
        transform.position = Vector3.Lerp(spawn, end, speed);       //using lerp to create velocity as it falls into the soup 
        StartCoroutine(Destroy());              
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.6f);  //destroying ingredients when the reach the pot of soup 
        Destroy(gameObject);


    }
}
