using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    public string user;
    public string password;
    void Start()
    {
        Login(user, password);
    }
    private bool Login(string us, string pa)//Funtion for the correct name user a password
    {
        if(us == "admin" && pa == "abccba")
        {
            return true;
        }
        else//For not correct credentials
        {
            return false;
        }
    }
}
