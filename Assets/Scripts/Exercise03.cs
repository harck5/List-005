using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public int clickCounter;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))//Call funtion whit a "A" key
        {
        Counter();
        }
        else if (clickCounter > 10)//When arrive 10 debug message GAMEOVER
        {
            Debug.Log(message: "GAME OVER");
        }
    }
    private void Counter()
    {
        clickCounter++;
    }
}