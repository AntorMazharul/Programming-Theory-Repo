using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour // INHERITANCE
{
    private string nameBox;
    private int scaleX, scaleY, scaleZ;
    protected float speed, turnSpeed;
    public string NameBox // ENCAPSULATION
    {
        get
        {
            return nameBox;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nameBox = value;
            }
        }
    }

    protected void SetSize(int x, int y, int z)
    {
        scaleX = x;
        scaleY = y;
        scaleZ = z;
    }

    protected virtual void CheckAvailability() // POLYMORPHISM
    {
        Debug.Log("This box is available all over Bangladesh!");
    }
}
