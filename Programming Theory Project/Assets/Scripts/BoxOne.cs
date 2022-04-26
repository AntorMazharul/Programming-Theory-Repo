using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOne : Box // INHERITANCE
{
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        NameBox = "Box1";
        speed = 5f;
        turnSpeed = 30f;
        SetSize(2, 2, 2);
        Debug.Log("Name: " + NameBox);
    }

    // Update is called once per frame
    void Update()
    {
        Move(); // ABSTRACTION
    }

    protected override void CheckAvailability() // POLYMORPHISM
    {
        Debug.Log("This box is available only in Savar!");
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
