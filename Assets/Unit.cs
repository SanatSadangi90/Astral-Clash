using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitMaxHP;
    public int unitCurrentHP;
    public int[] attackArr;
    public int[] splashArr;


    public bool takeDamage(int damage)
    {
        unitCurrentHP -= damage; // the unit takes damage
        if (unitCurrentHP <= 0)
        {
            return true; // returns true if the unit dies
        }
        else
        {
            return false; // returns false if the unit is alive
        }
    }
}
