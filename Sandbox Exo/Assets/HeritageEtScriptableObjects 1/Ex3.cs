using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tower BlackTower = new Tower();
        BlackTower.Movement();
        Piece WhiteTower = new Tower();
        WhiteTower.Movement();
    }
}

public abstract class Piece
{
    public abstract void Movement();

}

public class Tower : Piece
{
    public override void Movement()
    {
        Debug.Log("Tower move on lines");
    }
}
