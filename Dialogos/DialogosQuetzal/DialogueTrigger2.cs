using System.Collections.Generic;
using UnityEngine;
 

[System.Serializable]
 public class DialogueCharacter2
{
 public Sprite icon2;
}

[System.Serializable]
public class DialogueLine2
{
    public DialogueCharacter2 character2;
    [TextArea(3, 10)]
    public string line;

}
 
[System.Serializable]
public class Dialogue2
{
    
    public List<DialogueLine2> dialogueLines2 = new List<DialogueLine2>();
}
 
public class DialogueTrigger2 : MonoBehaviour
{
    public Dialogue2 dialogue2;
 
    public void TriggerDialogue2()
    {
        DialogueManager2.Instance.StartDialogue(dialogue2);
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            TriggerDialogue2();
        }
    }

    
}