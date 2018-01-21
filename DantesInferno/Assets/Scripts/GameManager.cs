using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //public UIManager uiman;
    
    //public List<String> charNames;
    //public Dictionary<Character, int> allCharRels;

	// Use this for initialization
	void Start () {
        //charNames=
    }

    public void loadCommand()
    {

        //allCharRels = new Dictionary<Character, int>();
        //foreach(String s in charNames)
        //{
        //Character c = new Character(s);
        //
        //c.rel = playerprefs.GetInt(s);
        //c.relCount = playerprefs.GetInt(s + "Num");
        //c.setSprite(s + "Sprite");
        //}
    }

    public void saveCommand()
    {
        //foreach(KeyValuePair<Character, int> kvp in allCharRels)
        {
            //PlayerPrefs.SetInt(kvp.Key.Name, kvp.value);

            //PlayerPrefs.SetInt(kvp.Key.Name + "Rel",  kvp.key.relationship);
            //PlayerPrefs.SetInt(kvp.Key.Name + "Sprite",  kvp.key.spriteNun);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
