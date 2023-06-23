using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public abstract class Unit : MonoBehaviour
{
    [SerializeField] protected TMP_Text infoText;
    [SerializeField] private string unitName;

    public string UnitName     // ENCAPSULATION
    {
        get { return unitName; }
        set
        {
            if (value == "")
            {
                Debug.Log("UnitName value cannot be empty");
            }
            else
            {
                unitName = value;
            }
        }
    }


    protected Rigidbody Rb;

    private void Start()
    {
        AddInfoText(); // ABSTRACTION

        Rb = GetComponent<Rigidbody>();
    }

    // Looks and finds the Info text object
    private void AddInfoText()
    {
        if (!infoText)
        {
            infoText = GameObject.Find("InfoText").GetComponent<TMP_Text>();
        }

        ShowInfoText(false); // ABSTRACTION
    }

    // Handles the InfoText visibility
    public void ShowInfoText(bool show)
    {
        infoText.gameObject.SetActive(show);
    }

    // Shows the Unit info
    public virtual void ShowInfo()
    {
        ShowInfoText(true);
        infoText.text = UnitName;
    }

    // Handles the custom unit salute
    public abstract void Greet();
}
