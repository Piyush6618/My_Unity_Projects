using UnityEngine;

public class spinner : MonoBehaviour
{
    public Vector3 rotateAngles;
    private void Update()
    {
        transform.Rotate(rotateAngles);
        
    }
   
}
