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
    // Start is called before the first frame update
    void Start()
    {
        spawn = transform.position;
        end = spawn;
        end.y = spawn.y - 10;
         
    }

    // Update is called once per frame
    void Update()
    {
        lerpTimer += Time.deltaTime;
        speed = interpolation.Evaluate(lerpTimer);
        transform.position = Vector3.Lerp(spawn, end, speed);
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);


    }
}
