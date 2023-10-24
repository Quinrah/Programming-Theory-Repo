using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaro : Car
{
    // Start is called before the first frame update


    public override void MoveForward()
    {
        speed = 20;
        base.MoveForward();
    }
    // Update is called once per frame
    void Update()
    {
        MoveForward();
        Turn();
    }
}
