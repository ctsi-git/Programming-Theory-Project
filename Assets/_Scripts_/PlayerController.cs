using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera cam;
    private Unit selectedUnit = null;


    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        // Left Mouse Button Click
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection(); // ABSTRACTION
        }

    }

    // Manages the player selection options
    private void HandleSelection()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (selectedUnit != null)
            {
                selectedUnit.ShowInfoText(false);
            }

            // If the object is a Unit
            if (hit.collider.gameObject.GetComponent<Unit>() != null)
            {

                selectedUnit = hit.collider.gameObject.GetComponent<Unit>();

                selectedUnit.ShowInfo();
                selectedUnit.Greet();

            }
        }
    }


}
