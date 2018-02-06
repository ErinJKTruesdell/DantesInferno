using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour {

    public UIManager uiman;
    public character parentChar;
    public int index = 0;

    public List<KeyValuePair<string, List<string>>> lines;

	// Use this for initialization
	void Start () {
        index = 0;

        //we're only hard coding this for now

        lines = new List<KeyValuePair<string, List<string>>>();

        List < string > _1 = new List<string>();
        _1.Add("Chief. What do we have?");


        List<string> _2 = new List<string>();
        _2.Add("Tell me more about the victim.");

        List<string> _3 = new List<string>();
        _3.Add("Seems like our perp went a bit overkill.");

        List<string> _4 = new List<string>();
        _4.Add("End.");

        lines.Add(new KeyValuePair<string, List<string>>("Detective NAME.", _1));
        lines.Add(new KeyValuePair<string, List<string>>("Everything points to arson and attempted murder. The victim is being rushed to the hospital now, along with your partner as protection.", _2));
        lines.Add(new KeyValuePair<string, List<string>>("Her name is INSERT NAME RIP. A neighbor saw the blaze and called the fire department.They found her in bed, stabbed twice in the stomach and barely conscious.", _3));
        lines.Add(new KeyValuePair<string, List<string>>("We’re combing the scene now. You’re on your own this time. Start with the neighbor and go from there. I suggest you stop cracking wise and get to work.", _4));
        //display first line

        uiman.displayLine(lines[0].Key, lines[0].Value);
    }

    public void setRel(int rel)
    {

        parentChar.calcRelPercent(rel);

    }

    public void nextLine()
    {

        index += 1;
        
        if (index >= lines.Count)
        {
            //placeholder text for testing
            List<string> s = new List<string>();
            s.Add("SNEEP SNOP");
            uiman.displayLine("SNORK", s);

            //load next scene or quit app
            Application.Quit();
        }

        else
        {

            uiman.displayLine(lines[index].Key, lines[index].Value);

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
