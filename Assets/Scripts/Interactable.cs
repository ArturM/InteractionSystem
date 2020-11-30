using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual bool CanInteract(Vector3 position) { return false; }
    public virtual void Interact() { }
}
