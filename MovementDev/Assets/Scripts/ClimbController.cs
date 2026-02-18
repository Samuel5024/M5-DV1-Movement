using UnityEngine;

public class ClimbController : MonoBehaviour
{
    public GameObject xrRig;
    private void Start()
    {
        if(xrRig == null)
            xrRig = GameObject.Find("XR Rig");
    }
    
    public void Grab()
    {

    }

    public void Pull(Vector3 distance)
    {
        xrRig.transform.Translate(distance);
    }

    public void Release()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
