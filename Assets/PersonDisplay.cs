using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PersonDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Person person;

    public Image personArt;
    void Start()
    {
        personArt.sprite = person.artwork;
    }
}
