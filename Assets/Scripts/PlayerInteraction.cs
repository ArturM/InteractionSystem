using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    private Interactable activeInteractable;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithInteractable();    
        }
    }

    void InteractWithInteractable()
    {
        if (!activeInteractable) return;

        if (activeInteractable.CanInteract(transform.position))
        {
            activeInteractable.Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        activeInteractable = other.GetComponent<Interactable>();
    }

    private void OnTriggerExit(Collider other)
    {
        activeInteractable = null;
    }
}
