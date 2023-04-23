using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public InfoHolder info;

    private float cooldown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }

        //movement
        if (Input.GetKey(KeyCode.D)) 
        {

            //move right
        } else if (Input.GetKey(KeyCode.A))
        {
            //move left
        }
        if (Input.GetKey(KeyCode.W))
        {
            //move up
        } else if (Input.GetKey(KeyCode.S))
        {
            //move down
        }
    }

    public void Shoot(Vector2 target)
    {
        if (info.ammo > 0 && cooldown == 0)
        {
            //instantiate bullet from position of gameobject towards target

            //set cooldown to 2 seconds
            cooldown = 2;
        }
    }

    
}
