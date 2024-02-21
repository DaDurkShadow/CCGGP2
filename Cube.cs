using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // 5. In the Cube C# Script: (20 points total)
    // a. Rotate the cube 75 degrees on the Z axis. (10 points)
    // b. Use Time.deltaTime in your code. (5 points)
    // c. When creating your variables, call (or set) your variables in the Start method. (5 points)
    
    // Start is called before the first frame update
    void Start()
    {
        int rotation = 75;

        transform.Rotate(0, 1 * Time.deltaTime, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
