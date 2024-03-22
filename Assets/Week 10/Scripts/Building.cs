using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Building : MonoBehaviour
{
    
    public List<GameObject> gameObjects;
    Vector3 start = new Vector3(0f, 0f, 0f);
    Vector3 end = new Vector3(1f,1f,1f);
    float increase; 
    int num = 0;
    Coroutine building; 
    bool isBuilding = true;
    float timer = 0; 
    void Start()
    {
        StartCoroutine(BuildTime());
    }

    IEnumerator BuildTime()
    {

        yield return new WaitForSeconds(2f);
        increase = 0f;
        num++;
  


        yield return new WaitForSeconds(2f);
        increase = 0f;
        num++;
    


        yield return new WaitForSeconds(2f);
        increase = 0f;
        num++;
  


        yield return new WaitForSeconds(2f);
        increase = 0f;
        num++;



        
        if (num > 4)
        {
            isBuilding = false;
        }



    }


    private void Update()
    {
        if (isBuilding)
        {
            gameObjects[num].transform.localScale = Vector3.Lerp(start, end, increase);

            if (gameObjects[num].transform.localScale.x < 1)
            {
                increase += Time.deltaTime; 
                Debug.Log(increase);
            }
           
        }
    }
}
