using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currHealth;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
        
    }

    void takeDamage(int amount)
    {
        currHealth =- amount;
        //add if statement for when currHealth reaches 0
    }

    //add 
    // Update is called once per frame
    void Update()
    {
        
    }
}
