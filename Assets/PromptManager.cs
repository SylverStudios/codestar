using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I think this should manage prompts, but maybe the prompt it self should handle the display
public class PromptManager : MonoBehaviour
{


    public StyledPromptSpawner styledPromptSpawner;


    private Queue<Prompt> tasks = new Queue<Prompt>();
    private Queue<Prompt> history = new Queue<Prompt>();
    private bool hasActiveText;

    private Prompt activePrompt;

    void Start()
    {
        NextPrompt();
    }

    public void AddText()
    {

        Prompt prompt = new Prompt(TextGenerator.GetRandomText(), styledPromptSpawner.Spawn());
        Debug.Log(prompt.text);

        tasks.Enqueue(prompt);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveText)
        {
            if (activePrompt.GetNextLetter() == letter)
            {
                activePrompt.TypeLetter();

            }
        }
        else
        {
            NextPrompt();
        }


        if (activePrompt.TextTyped())
        {
            NextPrompt();
        }
    }

    public void NextPrompt()
    {
        if (hasActiveText)
        {
            history.Enqueue(activePrompt);
            TrimHistory();
        }

        if (tasks.Count == 0)
        {
            AddText();
        }

        activePrompt = tasks.Dequeue();
        hasActiveText = true;
    }

    public void TrimHistory()
    {
        if (history.Count >= 2)
        {
            Prompt ancient = history.Dequeue();
            Debug.Log("About to delete this history message.");
            ancient.Remove();
        }
    }
}
