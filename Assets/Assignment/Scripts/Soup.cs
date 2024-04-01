using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Soup : MonoBehaviour
{
    float speed;
    float speed2; 
    Vector3 startPos; 
    public static Vector3 secondPos;
    public static Vector3 thirdPos;
    public AnimationCurve interpolation;
    public static bool first = true; 
    float lerpTimer;
    float lerpTimer2; 
    int order;
    int fail; 
    // Start is called before the first frame update
    void Start()
    {
        fail = GameManager.ordersFailed; 
        order = GameManager.ordersServed;
        startPos = transform.position;
        secondPos = transform.position;
        secondPos.x = transform.position.x + 10;
        thirdPos = secondPos;

        thirdPos.y = secondPos.y + 10; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (order == GameManager.ordersServed)
        {
            lerpTimer += Time.deltaTime;
            speed = interpolation.Evaluate(lerpTimer);
            transform.position = Vector3.Lerp(startPos, secondPos, speed);
            
        }
        if (order < GameManager.ordersServed || fail < GameManager.ordersFailed)
        {
            
            lerpTimer2 += Time.deltaTime;
            speed2 = interpolation.Evaluate(lerpTimer2);
            transform.position = Vector3.Lerp(secondPos, thirdPos, speed2);
            StartCoroutine(Destroy()); 
        }
    }


   IEnumerator Destroy()
    {

        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }



}
