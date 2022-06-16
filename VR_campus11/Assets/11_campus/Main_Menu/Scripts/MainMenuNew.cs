using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.U2D;


public class MainMenuNew : MonoBehaviour {

	public Animator CameraObject;

	[Header("Load Screen")]
	public string sceneName = "Hall"; 

	[Header("Panels")]
	public GameObject PanelKeyBindings;
	public GameObject PanelareYouSure;
	public GameObject PanelGraphic;
	public bool isFullScreen;
	Resolution[] resolutions;
	public bool screenres;
    public Dropdown dropdownMenu;

	// campaign button sub menu
	[Header("Sub Menu Buttons")]
	public GameObject newGameBtn;

	public void  PlayCampaign (){
		PanelareYouSure.gameObject.SetActive(false);
		newGameBtn.gameObject.SetActive(true);
	}

	public void NewGame(){
		if(sceneName != "")
		SceneManager.LoadScene(sceneName);
	}

	public void  DisablePlayCampaign (){
		newGameBtn.gameObject.SetActive(false);
	}

	public void  Position2 (){
		DisablePlayCampaign();
		CameraObject.SetFloat("Animate",1);
	}

	public void  Position1 (){
		CameraObject.SetFloat("Animate",0);
	}

	public void  KeyBindingsPanel (){
		PanelGraphic.gameObject.SetActive(false);
		PanelKeyBindings.gameObject.SetActive(true);
	}

	public void PanelGraphics (){
			PanelKeyBindings.gameObject.SetActive(false);
			PanelGraphic.gameObject.SetActive(true);
	}
	//graphic panel

	public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

	public void Start()
     {
     /*    resolutions = Screen.resolutions;
		 dropdownMenu.onValueChanged.AddListener(delegate { Screen.SetResolution(resolutions[dropdownMenu.value].width, resolutions[dropdownMenu.value].height , true); });
         for (int i = 0; i < resolutions.Length; i++)
         {
             dropdownMenu.options[i].text = ResToString(resolutions[i]);
             dropdownMenu.value = i;
			 dropdownMenu.options.Add(new Dropdown.OptionData(dropdownMenu.options[i].text));
         }*/
     }

     string ResToString(Resolution res)
     {
         return res.width + " x " + res.height;
     }

	// Are You Sure - Quit Panel Pop Up
	public void  AreYouSure (){
		PanelareYouSure.gameObject.SetActive(true);
		DisablePlayCampaign();
	}

	public void  No (){
		PanelareYouSure.gameObject.SetActive(false);
	}

	public void  Yes (){
		Application.Quit();
	}
    public void exitmenu()
    {
        Application.Quit();
    }
}