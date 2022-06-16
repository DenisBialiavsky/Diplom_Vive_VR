using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graphic : MonoBehaviour {

	public Canvas Graph;
	public Button Low;
	public Button Medium;
	public Button High;
	
	// Use this for initialization
	void Start () {
		Graph = Graph.GetComponent<Canvas>();
		Low = Low.GetComponent<Button>();
		Medium = Medium.GetComponent<Button>();
		High = High.GetComponent<Button>();
		Graph.enabled = false;
	}
	
	public void lowset(){
		QualitySettings.SetQualityLevel(0);
	}
	public void medset(){
		QualitySettings.SetQualityLevel(1);
	}
	public void highset(){
		QualitySettings.SetQualityLevel(2);
	}
}
