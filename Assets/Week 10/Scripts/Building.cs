using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Building : MonoBehaviour
{
    
    public List<GameObject> gameObjects;
    Vector3 start = new Vector3(0f, 0f, 0f);
    Vector3 end = new Vector3(1f,1f,1f);
    int num = 0;
    Coroutine building; 
    bool isBuilding;
    float increase = 0.1f;
    void Start()
    {
        isBuilding = true;
        if (isBuilding == false)
        {
            StopCoroutine(BuildTime());
        }
        StartCoroutine(BuildTime());
    }

    IEnumerator BuildTime()
    {
        

        
        Constructing();

        yield return new WaitForSeconds(2f);
        num++;
        Constructing();

        yield return new WaitForSeconds(2f);
        num++;
        Constructing();

        yield return new WaitForSeconds(2f);
        num++;
        Constructing();

        yield return new WaitForSeconds(2f);
        num++;
        Constructing();


        
        if (num > 4)
        {
            isBuilding = false;
        }



    }
    void Constructing()
    {
      
        while (gameObjects[num].transform.localScale.x < 1)
        {
         
            
            //gameObjects[num].transform.localScale += increase; 
            
            gameObjects[num].transform.localScale = Vector3.Lerp(start, end, increase);
            
        }
        
        
    }
}
