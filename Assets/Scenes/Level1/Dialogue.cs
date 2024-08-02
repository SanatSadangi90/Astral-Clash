using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI speechBoxComponent;
    public TextMeshProUGUI nameBoxComponent;
    public string[] speechLines;
    public string[] nameLines;
    public Image background;
    public Sprite[] backgroundSprites;
    public float speechBoxSpeed;

    private int index;

    void Start()
    {
        // Sets both text boxes to empty
        nameBoxComponent.text = string.Empty;
        speechBoxComponent.text = string.Empty;
        StartDialogue(); // Starts the Dialogue
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // If the text in the speech box is finished, the program displays the next character's name and dialogue
            if (speechBoxComponent.text == speechLines[index])
            {
                NextLine();
            }
            // Otherwise, the program stops the coroutines and completes the name and speech text
            else
            {
                StopAllCoroutines();
                nameBoxComponent.text = nameLines[index];
                background.sprite = backgroundSprites[index];
                speechBoxComponent.text = speechLines[index];
            }
        }
    }

    void StartDialogue(){
        index = 0;
        StartCoroutine(TypeInfo());
        // If the player clicks the mouse and the speechLines array is not out of speechLines, the program prints a line from the line array
        // It also sets the index to the next line in the array

    }

    IEnumerator TypeInfo(){
        // Displays the name of the character in the array
        nameBoxComponent.text = nameLines[index];
        background.sprite = backgroundSprites[index];
        // Type each character from a line one at a time
        foreach (char c in speechLines[index].ToCharArray()){
            speechBoxComponent.text += c;
            yield return new WaitForSeconds(speechBoxSpeed);
        }
    }
    void NextLine()
    {
        if (index < speechLines.Length - 1)
        {
            index++;
            nameBoxComponent.text = string.Empty;
            speechBoxComponent.text = string.Empty;
            StartCoroutine(TypeInfo());
        }
        else
        {
            // Put transition to encounter here
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
