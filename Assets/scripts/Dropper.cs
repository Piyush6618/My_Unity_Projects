using UnityEngine;

public class Dropper : MonoBehaviour
{
    public int timer =5;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update ()
    {
        //Debug.Log(Time.time);
        if (Time.time > timer)   
        {
            rb.useGravity = true;
        }
        
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
}
