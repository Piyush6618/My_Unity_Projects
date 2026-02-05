
using UnityEngine;

public class MOVE : MonoBehaviour
{[SerializeField] float playerspeed = 0.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {welcome();
        
    }

    // Update is called once per frame
    void Update()

    
    {
        MovePlayer();
        
        
            
        
    }
    void welcome()
    {
        Debug.Log("welcome to the game");
        Debug.Log("move the player with wasd");

    }
    void MovePlayer()
    {
        float valueX = Input.GetAxis("Horizontal")*playerspeed*Time.deltaTime;
     float valueY = 0;
     float valueZ = Input.GetAxis("Vertical")*playerspeed * Time.deltaTime;
        transform.Translate(valueX, valueY, valueZ);
        
    }

}

