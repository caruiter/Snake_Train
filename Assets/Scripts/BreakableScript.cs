using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableScript : MonoBehaviour
{
    public int goldHeld;
    public int ammoHeld;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "playerBullet")
        {
            GameObject info = GameObject.FindGameObjectWithTag("InfoHolder");
            GameObject goldDrop = info.GetComponent<InfoHolder>().goldDropPrefab;
            GameObject ammoDrop = info.GetComponent<InfoHolder>().ammoDropPrefab;

            for (int g = 0; g < goldHeld; g++)
            {
                //instantiate gold pickup
                //maybe use unit circle?
            }
            for (int a = 0; a < ammoHeld; a++)
            {
                //instantiate ammo pickup
            }
        }
    }


}
