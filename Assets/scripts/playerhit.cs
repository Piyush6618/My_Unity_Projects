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

    MeshRenderer meshRenderer = collision.gameObject.GetComponent<MeshRenderer>();
    Material material = meshRenderer.material;
    material.color = Color.black;
    

  }

}
