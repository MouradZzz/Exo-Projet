using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public Spell CurrentSpell;

    void Start()
    {
    }

     void Update()
    {
        if (CurrentSpell && Input.GetButtonDown("Fire1"))
        {
            Debug.Log(" Your spell " + name + " inflict " + CurrentSpell.Damage + CurrentSpell.Effect + " damages ");
        }
    }
}