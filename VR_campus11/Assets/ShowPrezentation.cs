using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Preza
{
    public string Name;
    public string Path;
}
[System.Serializable]
public class ShowPrezentation : MonoBehaviour
{
    public GameObject ObjectWithComponentImage;
    public GameObject MyPanel;

    public Preza[] AllPrezentations;


    public Font font;
    public int FontSize;
    public Vector2 TextSize;

    public int SizeHeightButtons;
    public Sprite spriteControlLeft;
    public Sprite spriteControlStop;
    public Sprite spriteControlRight;

    private bool isEnter = false;
    private bool isShowMenu = false;
    private bool isShowPreza = false;
    private int showFrame = 0;
    private Image Screen;
    //private Panel MyPanel;
    private Sprite[] images;
    private string[] NameScreen;  

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isEnter = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //ObjectWithComponentImage.SetActive(false);    
        //MyPanel = ObjectWithComponentPanel.GetComponent<Panel>();
        NameScreen = new string[AllPrezentations.Length];
        for (int i = 0; i < AllPrezentations.Length; i++)
            NameScreen[i] = AllPrezentations[i].Name;

        deleteNameInFrame();
        showNameInFrame();
    }


    private void loadScreenByPath(string path)
    {
        var objectes = Resources.LoadAll(path, typeof(Sprite));
        images = new Sprite[objectes.Length];
        for (int i = 0; i < objectes.Length; i++) this.images[i] = (Sprite)objectes[i];
    }

    private string getPathByName(string name)
    {
        foreach (Preza p in AllPrezentations)
            if (p.Name == name)
                return p.Path;
        return null;
    }

    private void showNameInFrame()
    {
        ObjectWithComponentImage.SetActive(true);
        foreach (string name in NameScreen)
        {
            GameObject button = new GameObject(name, typeof(Image), typeof(Button), typeof(LayoutElement), typeof(VerticalLayoutGroup));
            button.transform.SetParent(MyPanel.transform);
            //button.GetComponent<LayoutElement>().minHeight = 1;
            __setDefaultTransform(button);

            GameObject text = new GameObject(name, typeof(Text), typeof(LayoutElement));
            text.transform.SetParent(button.transform);
            __setDefaultTransform(text);
            RectTransform rt = text.GetComponent<RectTransform>();
            rt.sizeDelta = TextSize;

            text.GetComponent<Text>().text = name;
            text.GetComponent<Text>().font = font;
            text.GetComponent<Text>().fontSize = FontSize;
            text.GetComponent<Text>().color = Color.black;
            text.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

            button.GetComponent<Button>().onClick.AddListener(delegate { OpenPrezentation(name); });
        }
    }

    private void deleteNameInFrame()
    {
        int i = 0;

        //Array to hold all child obj
        GameObject[] allChildren = new GameObject[MyPanel.transform.childCount];

        //Find all child obj and store to that array
        foreach (Transform child in MyPanel.transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        //Now destroy them
        foreach (GameObject child in allChildren)
        {
            DestroyImmediate(child.gameObject);
        }
    }

    public void OpenPrezentation(string name)
    {
        string path = getPathByName(name);
        if (path != null && path.Length > 2)
        {
            loadScreenByPath(path);
            closeMenu();
            EnterPreza();  
        }
    }

    private void showMenu()
    {
        deleteNameInFrame();
        showNameInFrame();
        isShowMenu = true;
    }

    private void closeMenu()
    {   
        deleteNameInFrame();
        isShowMenu = false;
    }

    private void activation() {
        //Debug.Log("activation");
        //ObjectWithComponentImage.SetActive(true);
        //MyPanel.SetActive(true);
        showMenu();
    }

    private void deactivation() {
        isShowMenu = isShowPreza = false;
        deleteNameInFrame();
        showNameInFrame();
        //MyPanel.SetActive(false);
        //ObjectWithComponentImage.SetActive(false);
    }

    private void createScreen()
    {
        GameObject screen = new GameObject("screen", typeof(Image), typeof(LayoutElement));
        screen.transform.SetParent(MyPanel.transform);
        //button.GetComponent<LayoutElement>().minHeight = 1;
        __setDefaultTransform(screen);
        Screen = screen.GetComponent<Image>();

        //create buttons
        GameObject container = new GameObject("buttons_container", typeof(LayoutElement), typeof(HorizontalLayoutGroup));
        container.GetComponent<HorizontalLayoutGroup>().childControlHeight = true;
        container.GetComponent<HorizontalLayoutGroup>().childControlWidth = true;
        container.GetComponent<HorizontalLayoutGroup>().childAlignment = TextAnchor.MiddleCenter;
        container.GetComponent<LayoutElement>().preferredHeight = SizeHeightButtons;
        container.transform.SetParent(MyPanel.transform);
        __setDefaultTransform(container);

        GameObject button_left = __getControlBatton("left", container, delegate { ShowFrame(showFrame - 1); }, spriteControlLeft);
        GameObject button_stop = __getControlBatton("stop", container, delegate { ExitPreza(); }, spriteControlStop);
        GameObject button_right= __getControlBatton("right", container,delegate { ShowFrame(showFrame + 1); }, spriteControlRight);

    }

    private void deleteScreen()
    {
        Screen = null;
        deleteNameInFrame();  
    }

    void EnterPreza()
    {
        isShowPreza = true;
        createScreen();
        showFrame = 0;
        ShowFrame(showFrame);
    }

    void ExitPreza() {
        deleteScreen();
        isShowPreza = false;
        showMenu();
    }

    void ShowFrame(int frame) { 
        if(frame >= 0 && frame < images.Length && images.Length > 0)
        {
            showFrame = frame;
            string name = "" + frame;
            foreach (Sprite a in images)
                if (a.name == name)
                {
                    Screen.sprite = a;
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnter && Input.GetKeyDown(KeyCode.F))
        {
                if (isShowPreza || isShowMenu) deactivation();
                else activation();
        }
    }

    private void __setDefaultTransform(GameObject obj)
    {
        obj.transform.localPosition = new Vector3(0, 0, 0);
        obj.transform.localRotation = Quaternion.Euler(0, 0, 0);
        obj.transform.localScale = new Vector3(1, 1, 1);
    }

    private GameObject __getControlBatton(string name, GameObject parent, UnityEngine.Events.UnityAction onClick, Sprite sprite)
    {
        GameObject button = new GameObject(name, typeof(Image), typeof(Button), typeof(LayoutElement));
        button.transform.SetParent(parent.transform);
        __setDefaultTransform(button);
        button.GetComponent<Image>().sprite = sprite;
        button.GetComponent<Image>().preserveAspect = true;
        button.GetComponent<Button>().onClick.AddListener(onClick);
        return button;
    }
}
