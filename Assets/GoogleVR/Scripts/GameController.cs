using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text _text;
	public Text text2;
    private int CollectablesLeft;

	// Use this for initialization
	void Start () {
		DoRecountCollectables();
	    CollectablesLeft++;
        UpdateCollectablesText();
	}
	
    public void CollectObject(GameObject collected)
    {
        Destroy(collected);
        DoRecountCollectables();
        UpdateCollectablesText();
    }

    public void DoRecountCollectables()
    {
        CollectablesLeft = GameObject.FindGameObjectsWithTag("Collectable").Length - 1;
    }

    public void UpdateCollectablesText()
    {
        if (CollectablesLeft == 0)
        {
            _text.text = "ALL CUBES COLLECTED! CONGRATULATIONS!";
			text2.text = "ALL CUBES COLLECTED! CONGRATULATIONS!";
        }
        else
        {
            _text.text = "CUBES LEFT: " + CollectablesLeft;
			text2.text = "CUBES LEFT: " + CollectablesLeft;
        }
    }
}
