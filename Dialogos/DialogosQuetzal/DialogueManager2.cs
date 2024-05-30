using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
 
public class DialogueManager2 : MonoBehaviour
{
    public static DialogueManager2 Instance;
    
    public Image characterIcon2;
  
    public TextMeshProUGUI dialogueArea2;
 
    private Queue<DialogueLine2> lines;
    
    public bool isDialogueActive = false;
 
    public float typingSpeed = 0.2f;
 
    public Animator animator;
 
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
 
        lines = new Queue<DialogueLine2>();
    }
 
    public void StartDialogue(Dialogue2 dialogue2)
    {
        isDialogueActive = true;
 
        animator.Play("Entrada");
 
        lines.Clear();
 
        foreach (DialogueLine2 dialogueLine2 in dialogue2.dialogueLines2)
        {
            lines.Enqueue(dialogueLine2);
        }
 

 DisplayNextDialogueLine2();
 
      
    }
 
    public void DisplayNextDialogueLine2()
    {
        if (lines.Count == 0)
        {
            EndDialogue();
            return;
        }
 
        DialogueLine2 currentLine = lines.Dequeue();
 
   characterIcon2.sprite = currentLine.character2.icon2;
   
        StopAllCoroutines();
 
        StartCoroutine(TypeSentence(currentLine));
    }
 
    IEnumerator TypeSentence(DialogueLine2 dialogueLine2)
    {
        dialogueArea2.text = "";
        foreach (char letter in dialogueLine2.line.ToCharArray())
        {
            dialogueArea2.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
 
    void EndDialogue()
    {
        isDialogueActive = false;
        animator.Play("Salida");
    }

void Update(){
      if(Input.GetKeyDown(KeyCode.Space)){
DisplayNextDialogueLine2();
 }
}

}