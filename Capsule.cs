using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{   
    float Horizontal;
    float Vertical;
    float moveSpeed = 5f;
    float jumpStrength = 10f;
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB =  GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        transform.Translate(Horizontal * moveSpeed * Time.deltaTime, 0 , Vertical * moveSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
        {
            playerRB.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            transform.Translate(0, jumpStrength*Time.deltaTime,0);
        }
    }
}
