using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lambo : Car
{

    public override void MoveForward()
    {
         speed = 30;
        base.MoveForward();
    }
    void Update(){
        MoveForward();
        Turn();
    }


}
