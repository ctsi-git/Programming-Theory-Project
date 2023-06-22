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
        AddInfoText(); // ABSTRACTION
    }

    // Looks and finds the Info text object
    private void AddInfoText()
    {
        if (!infoText)
        {
            infoText = GameObject.Find("InfoText").GetComponent<TMP_Text>();
        }

        ShowInfoText(false);
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

    public virtual void MoveForward()
    {

    }
}
