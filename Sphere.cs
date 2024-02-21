using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    // In the Sphere C# Script: (20 points total)
        // a. Move the sphere 6.5 units in the Y axis. (10 points)
        //  b. Use Time.deltaTime in your code. (5 points)
        // c. When creating your variables, call (or set) your variables in the Start method. (5 points)

    // Start is called before the first frame update
    void Start()
    {
        float moveSide = 6.5f;
        transform.Translate(0, moveSide * Time.deltaTime, 0);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
