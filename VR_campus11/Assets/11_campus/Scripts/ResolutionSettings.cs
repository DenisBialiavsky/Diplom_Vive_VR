using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ResolutionSettings : MonoBehaviour {

	public Dropdown dropdown;

	// Use this for initialization
	void Start () {
		Resolution [] resolution = Screen.resolutions;
		Resolution [] res = resolution.Distinct().ToArray();
		string[] strRes = new string[res.Length];
		for (int i = 0; i < res.Length; i++){
			strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();
		}
		dropdown.ClearOptions();
		dropdown.AddOptions(strRes.ToList());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
