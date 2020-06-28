using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneDictionary : MonoBehaviour {

    public struct Pair {
        public string name;
        public string text;
    }

    public static List<Pair> textDictionary;

    public static int size = 0;

    public void Start() {
        textDictionary = new List<Pair>();
        
        if (LevelManager.Instance.IsInHome()) {
            AddHome();
        } else if (LevelManager.Instance.IsInAlley()) {
            AddAlley();
        }

        size = textDictionary.Count;
    }

    public void AddHome() {
        AddPair("Parents", "Hello Sweetie...");
        AddPair("Parents", "How was your Christmas party yesterday?");
        AddPair("Parents", "Remember, today is Boxing day!");
        AddPair("Bel", "Boxing... Day?");
        AddPair("Skip", "Home");
    }

    public void AddAlley() {
        AddPair("Bel", "Hey Old Man! Today is Boxing day isn't it!");
        AddPair("Drunk Santa", "...");
        AddPair("Drunk Santa", "I thought my days of Santa was over...");
        AddPair("Drunk Santa", "But I watched you from afar...");
        AddPair("Drunk Santa", "You have certainly lived up to name of Boxing day.");
        AddPair("Drunk Santa", "Now bring it on!");
        AddPair("Skip", "Alley");
    }

    private void AddPair(string name, string text) {
        Pair p;
        p.name = name;
        p.text = text;
        textDictionary.Add(p);
    }

}

