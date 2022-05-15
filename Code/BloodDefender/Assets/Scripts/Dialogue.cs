using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    bool gamefala = true;
    
    private DialogueControl dc;
    

    private void Start()
    {
        dc = FindObjectOfType<DialogueControl>();

    }

    private void Update()
    {
        

        Interact();
        if (dc.cont ==1 && gamefala )
        {
            dc.Speech(profile, speechTxt, actorName);
        }
        
    }

    public void Interact()
    {
        if(GameController.instance.comeca == false)
        {
            gamefala = true;
            dc.cont++;
        }
        else
        {
            gamefala = false;
        }
    }
}
