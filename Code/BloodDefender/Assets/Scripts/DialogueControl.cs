using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Seetings")]
    public float typingSpeed;
    private string[] sentences;
    public int index;

    public int cont = 0;

    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorNameText.text = actorName;

        StartCoroutine(TypeSentence());
        


    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        if(speechText.text == sentences[index])
        {
            if(index < sentences.Length - 1 )
            {
                
                index++;
                speechText.text = "";
                cont = 0;

            }
            else
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
                GameController.instance.comeca = true;
                
            }
            
       }
        

    }
}
