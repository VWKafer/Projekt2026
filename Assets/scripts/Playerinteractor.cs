using UnityEngine;
using UnityEngine.InputSystem;

public class Playerinteractor : MonoBehaviour
{
    [SerializeField] private Transform playerCamera; 
    [SerializeField] private float interactionDistance; 

    [SerializeField] private InputActionReference interactionReference; 
    [SerializeField] private Playercontroller playerController;
    [SerializeField] private GameObject Text;


    [SerializeField] private bool isInteracting = false;
    void Start()
    {
        if (playerController == null)
        {
            playerController = GetComponent<Playercontroller>();
        }
    }

    private void OnEnable(){

        interactionReference.action.Enable();
        interactionReference.action.started += PlayerInteracted;
    }


    private void OnDisable(){
        interactionReference.action.started -= PlayerInteracted;
        interactionReference.action.Disable();
    }

    private void PlayerInteracted(InputAction.CallbackContext context)
    {
        Debug.Log("trying interaction");
       
        
        if (context.started){

            Ray ray = new Ray( playerCamera.position, playerCamera.forward);

            if (!Physics.Raycast(ray, out RaycastHit hitInfo, interactionDistance)) return;

            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactable0bject)){
                interactable0bject.Interact();
                
                if (isInteracting == true){
                    playerController.SetCanMove(true);
                    isInteracting = false;
                    Text.GetComponent<TextController>().setText("move");
                }else
                {
                    playerController.SetCanMove(false);
                    isInteracting = true;
                    Text.GetComponent<TextController>().setText("read");
                }
            }
               

              
            
        }
    }
}