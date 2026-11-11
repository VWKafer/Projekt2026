using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("interacting..");
        gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}
