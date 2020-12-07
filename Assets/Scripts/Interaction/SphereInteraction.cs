using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInteraction : Interactable
{
    override public bool CanInteract(Vector3 player_pos)
    {
        float distance = Vector3.Distance(transform.position, player_pos);

        if (distance < 3)
        {
            return true;
        }
        else
        {
            Debug.Log("za daleko...");
            return false;
        }
    }

    override public void Interact()
    {
        Debug.Log("Pykłeś sferę i jest green");
        GetComponent<Renderer>().material.color = Color.green;
    }
}
