using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid2 : MonoBehaviour
{
    int direction = -1;
    int counter = 0;
    int maxdistance = 100;
    float moveSpeed = 0.01f;


    void Update()
    {
        if(Mathf.Abs(counter) > maxdistance){
            direction = direction * -1;
        }

        transform.Translate(moveSpeed * direction, 0,0);

        if(direction > 0){
            counter--;
        } else {
            counter++;
        }
    }

}
