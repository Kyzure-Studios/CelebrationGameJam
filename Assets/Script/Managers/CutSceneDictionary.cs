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
        AddPair("Parents", "You gay");
        AddPair("Bel", "No you gay");
        AddPair("Drunk Santa", "I gay");
        size = textDictionary.Count;
    }

    private void AddPair(string name, string text) {
        Pair p;
        p.name = name;
        p.text = text;
        textDictionary.Add(p);
    }

}
