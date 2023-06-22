using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Unit : MonoBehaviour
{
    [SerializeField] private string unitName;  
   
    public string UnitName { get => unitName; set => unitName = value; }

}
