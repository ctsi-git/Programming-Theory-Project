using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Unit : MonoBehaviour
{
    [SerializeField] private string unitName;
   
    public string UnitName => unitName;  // ENCAPSULATION

    private TMP_Text infoText;

    private void Start()
    {
        CheckInfoText(); // ABSTRACTION
    }

    // Looks and finds the Info text object
    private void CheckInfoText()
    {
        if (!infoText)
        {
            infoText = GameObject.Find("InfoText").GetComponent<TMP_Text>();
        }

        infoText.gameObject.SetActive(false);
    }

    // Shows the Unit info
    public virtual void ShowInfo()
    {
        infoText.gameObject.SetActive(true);
        infoText.text = UnitName;
    }

    public virtual void MoveForward()
    {

    }
}
