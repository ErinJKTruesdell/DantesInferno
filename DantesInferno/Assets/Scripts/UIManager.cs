using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public character charTalk;
    public Text charName;
    public Text chat;

    public List<Button> buttons;


    // Use this for initialization
    void Start() {
        charName.text = charTalk.name_;
    }

    public void displayLine(string line, List<string> responses)
    {
        chat.text = line;
        for (int r = 0; r < responses.Count; r++)
        {
            Button b = buttons[r];

            Text t = b.GetComponentInChildren<Text>();

            t.text = responses[r];

        }

    }

    public void nextLine()
    {

        charTalk.nextLine();

    }

	// Update is called once per frame
	void Update () {
		
	}
}
