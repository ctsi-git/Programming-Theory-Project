using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderUnit : Unit
{
    [SerializeField] private string greet = "Hello, I'm a Cylinder, the only carrier you will need";

    [SerializeField] private int capacity = 15;
    public int Capacity   // ENCAPSULATION
    {
        get { return capacity; }
        set
        {
            if (value < 0)
            {
                Debug.Log("Weight value cannot be negative");
            }
            else
            {
                capacity = value;
            }
        }
    }

    // Custom Unit Salute
    public override void Greet()// POLYMORPHISM
    {
        Debug.Log(greet);
    }


    // Shows the info of the unit
    public override void ShowInfo() // POLYMORPHISM
    {
        base.ShowInfo();

        string info = $"{infoText.text}\n Load: {capacity} Kg";

        infoText.text = info;

    }
}
