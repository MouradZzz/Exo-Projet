using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ex6 : MonoBehaviour
{
    public OneHandedItem RightHand;
    public OneHandedItem LeftHand;
    
    void Update()
    {
        if (RightHand && Input.GetButtonDown("Fire1"))
        {
            RightHand.Use();
        }
        if (LeftHand && Input.GetButtonDown("Fire2"))
        {
            LeftHand.Use();
        }
    }
}