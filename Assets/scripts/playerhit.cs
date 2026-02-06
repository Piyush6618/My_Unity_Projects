using UnityEngine;

public class playerhit : MonoBehaviour
{
private int hitcount = 0;

private void OnCollisionEnter(Collision collision)
  {
    //Debug.Log("Player has collided");
    //Debug.Log("Player has collided with " + collision.gameObject.name);
    hitcount++;
    Debug.Log("player has collided" + hitcount + "times");

   if (collision.gameObject.CompareTag("obstacle"))
    {
        changeColor(collision.gameObject,Color.black);

    
   
   }
    

  }
private void changeColor(GameObject gameObject,Color color)
  {
    MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
    Material material = meshRenderer.material;
    material.color = color;
    
  }
}
