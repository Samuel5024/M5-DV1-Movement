using UnityEngine;

public class GlideLocomotion : MonoBehaviour
{
    public Transform rigRoot;
    public float velocity = 2f; // meters per second
    private void Start()
    {
        if(rigRoot == null)
            rigRoot = transform;
    }

    private void Update()
    {
        float forward = Input.GetAxis("XRI_Right_Primary2DAxis_Vertical");
        if(forward != 0f)
        {
            Vector3 moveDirection = Vector3.forward;
            moveDirection *= -forward * velocity * Time.deltaTime;
            rigRoot.Translate(moveDirection);
        }
    }
}
