using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    void Start()
    {
        Dog woofgang = new Dog(true);
        woofgang.Bark();
        woofgang.die();
        woofgang.Bark();
    }
    
}

public abstract class Animal : Ex2
{
    protected bool Isalive;

    public void die()
    {
        Isalive = false;
    }
}

public abstract class Mammal : Animal
{
    protected int PawNumber;
}

public class Dog : Mammal
{
    public Dog(bool isAlive, int PawNumber = 4)
    {
        
    }

    public void Bark()
    {
        if (Isalive = true)
        {
            Debug.Log(" Woof !");
        }
    }
}
