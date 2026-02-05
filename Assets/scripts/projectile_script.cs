using UnityEngine;

public class projectile_script : MonoBehaviour
{public Transform player;
public Vector3 playerPosition;
public float speed;
private void Start()
    {
        playerPosition = player.position;
    }
private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
        
    }

