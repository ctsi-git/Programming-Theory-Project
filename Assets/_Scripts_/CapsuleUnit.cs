using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleUnit : Unit // INHERITANCE
{
    [SerializeField] private string greet = "Hello, I'm a Capsule, the most powerful mage around...";

    [SerializeField] private int mana = 50;
    public int Mana     // ENCAPSULATION
    {
        get { return mana; }
        set 
        {
            if(mana < 0)
            {
                Debug.Log("Mana value cannot be negative");
            }
            else
            {
                mana = value;
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

        string info = $"{infoText.text}\n Mana: {mana} ";

        infoText.text = info;

    }
}
