using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //requires player input
        //looking for left mouse click
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            //fire raycast from the main camera or mouse position
            //access the object that we hit
            Ray rayOrigin = Camera.main.ScreenPointToRay(new Vector3(Mouse.current.position.ReadValue().x, Mouse.current.position.ReadValue().y, 0));
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                Renderer renderer = hitInfo.collider.GetComponent<Renderer>();
                if(renderer != null)
                {
                    //change color
                    renderer.material.color = Random.ColorHSV();
                }
            }
            
        }


    }
}
