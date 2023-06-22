using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUnit : Unit
{
    [SerializeField] private string greet = "Hello, I'm a box, also a very good fighter";

    [SerializeField] private int health = 10;
    public int Health   // ENCAPSULATION
    {
        get { return health; }
        set
        {
            if (value < 0)
            {
                Debug.Log("Health value cannot be negative");
            }
            else
            {
                health = value;
            }
        }
    }

    // Custom Unit Salute
    public override void Greet() // POLYMORPHISM
    {
        Debug.Log(greet);
    }


    // Shows the info of the unit
    public override void ShowInfo() // POLYMORPHISM
    {
        base.ShowInfo();

        string info = $"{infoText.text}\n {health} HP";

        infoText.text = info;

    }
}
