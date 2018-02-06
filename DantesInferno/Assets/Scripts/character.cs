using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    public string name_;    //character name
    public int timesSpokenTo_;  //number of times player spoke to character
    public int relPercent_;    //relationship percent   
    Dictionary<int, Texture> sprites_;   //dictionary containing sprites
    Dictionary<int, AudioSource> sounds_;   //dictionary contianing sounds

    public Conversation _convo;

    public SpriteRenderer img;

    private void Awake()
    {
        img = GetComponent<SpriteRenderer>();
     
    }

    //default constructor
    public character(){
        name_ = "Joe";
        timesSpokenTo_ = 0;
        relPercent_ = 50;
    }
    //more useful constructor 
    public character(string name, int numSpeak, int relPer, Dictionary<int, string> sprites){
        name_ = name;
        timesSpokenTo_ = numSpeak;
        relPercent_ = relPer;
        sprites_ = sprites; 
    }

    //method to calculate relationship percent
    public void calcRelPercent(int arg){
        relPercent_ = ((relPercent_ * timesSpokenTo_) + arg) / (timesSpokenTo_++);
    }

    public void nextLine()
    {

        _convo.nextLine();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
