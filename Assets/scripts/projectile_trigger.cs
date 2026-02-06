using UnityEngine;

public class projectile_trigger : MonoBehaviour
{
    public GameObject[] projectiles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject projectile in projectiles)
            {
                projectile.SetActive(true);
            }
        }
        
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
