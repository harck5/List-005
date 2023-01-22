using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public float num1;//variable to calculator
    public float num2;
    public float num3;

    void Start()
    {
        Calculator(num1, num2, num3);
    }
    private float Calculator(float x, float y, float z)
    {
        float result = (x + y + z) / 3;//crate variable funtion for de operation
        return result;
    }
}
