using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    private void Start()
    {
        Son John = new Son();
        Debug.Log(John.Nom);
    }
}

public class Dad : Ex1
{
    public string Nom = "Mac Couille";
}

public class Son : Dad
{
    
}