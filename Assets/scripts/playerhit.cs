using UnityEngine;

public class playerhit : MonoBehaviour
{
private int hitcount = 0;
private Rigidbody rb;
private MOVE moveScript;
private void Start()
  {
    rb = GetComponent<Rigidbody>();
    moveScript = GetComponent<MOVE>();
  }

private void OnCollisionEnter(Collision collision)
  {
    //Debug.Log("Player has collided");
    //Debug.Log("Player has collided with " + collision.gameObject.name);
    hitcount++;
    Debug.Log("player has collided" + hitcount + "times");

   if (collision.gameObject.CompareTag("obstacle"))
    {
      changeColor(collision.gameObject,Color.black);
      GameOver();
        

    
   
   }
    

  }
private void changeColor(GameObject gameObject,Color color)
  {
    MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
    Material material = meshRenderer.material;
    material.color = color;
    
  }
  private bool GameOver()
  {
    
        rb.constraints = RigidbodyConstraints.None;
        rb.useGravity = true;
        moveScript.enabled = false;
        Debug.Log("Game Over");
        return true;
    
  }
}
