using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OpenSceneScript : MonoBehaviour
{
    //Этот скрип открывает новую сцену-тест , название которой вы пишите
    //Меняет по нажатию F, когда игрок внутри коллайдера
    //Второй аргумент - папка с вопросами внутри папки assets

    //StaticDataForTestGame - вспомогательный класс для передачи сцене-тесту всей инфы

    public string nameScaeneOfLoad = "TestGameUniversall";
    public string patchToQuests = null;
    
    private bool isEnter;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnter = false;
        }
    }

    void Update()
    {
        if (isEnter && Input.GetKeyUp(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            StaticDataForTestGame.pathToQuestion = patchToQuests;
            StaticDataForTestGame.sceneNameIfExit = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(nameScaeneOfLoad);
        }
    }

}
