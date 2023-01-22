using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public int[] num;

    void Start()//debug concret elements to array
    {
        Debug.Log(message: $"First {num[0]}");
        Debug.Log(message: $"Thirt {num[2]}");
        Debug.Log(message: $"Fift {num[4]}");
    }
}
