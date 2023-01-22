using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public int[] num;

    void Start()
    {
        if (num.Length >= 5)//when the condition is correct debug concret elements to array
        {
            Debug.Log(message: $"First {num[0]}");
            Debug.Log(message: $"Thirt {num[2]}");
            Debug.Log(message: $"Fift {num[4]}");
        }
        else//else no
        {
            Debug.Log(message: $"Missing elements");
        }
    }
}
