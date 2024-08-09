using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Person", menuName = "Person")]
public class Person : ScriptableObject
{
    public string unitName;
    public int unitMaxHP;
    public int unitCurrentHP;
    public int[] attackArr;
    public int[] splashArr;

    public Sprite artwork;

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

