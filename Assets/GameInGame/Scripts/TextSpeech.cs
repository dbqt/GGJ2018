using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSpeech : MonoBehaviour {
    public GameObject TextBox;
    public Text TheText;
    public string[] textLines;
    public GameObject Timeline;

    private int currLine, endAtLine;

	// Use this for initialization
	void Start () {
        currLine = 0;
        endAtLine = textLines.Length-1;
	}
	
	// Update is called once per frame
	void Update () {
        TheText.text = textLines[currLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currLine++;
        }

        if(currLine > endAtLine)
        {
            TextBox.SetActive(false);
            Debug.Log("END OG TEXT");
            //Timeline.SetActive(true);
        }
	}
}
