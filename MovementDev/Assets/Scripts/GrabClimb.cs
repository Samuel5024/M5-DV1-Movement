using UnityEngine;


public class GrabClimb : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;
    private ClimbController climbController;
    private bool isGrabbing;
    private Vector3 handPosition;

    private void Start()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
        climbController = GetComponentInParent<ClimbController>();
        isGrabbing = false;    
    }

    public void Grab()
    {
        isGrabbing = true;
        handPosition = InteractorPosition();
        ClimbController.Grab();
    }

    private Vector3 InteractorPosition()
    {
        List<UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor> interactors = interactable.hoveringInteractors;
        if(interactors.Count > 0)
            return interactors[0].transform.position;
        else
            return handPosition;
    }
}
