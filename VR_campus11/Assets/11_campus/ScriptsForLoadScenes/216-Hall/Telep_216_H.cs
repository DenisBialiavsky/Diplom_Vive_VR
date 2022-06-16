using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Telep_216_H : MonoBehaviour
{
    public Transform cam1;     // Камера персонажа из которой будет выходить луч
    RaycastHit rch1;           // Собственно сам луч
    public GameObject point;   // Точка на второй сцене в которой буде появляться персонаж
    private bool visible;      // Переменная для отображения диалога
    void Update()
    {
        Vector3 Direction = cam1.TransformDirection(Vector3.forward);
        if (Physics.Raycast(cam1.position, Direction, out rch1, 3))
        {  // Луч будет выходить из камеры на расстоянии 3 метра
            if (rch1.collider.GetComponent<Bot>())
            { // Если луч попадает на коллайдер объекта на котором есть скрип Bot
                if (Input.GetKeyDown(KeyCode.E))
                { // и если нажимаем клавишу Е
                    visible = true; // то переменная visible принимает значение true
                }
            }
        }
    }   
    void OnGUI()
    {  //Создадим диалог
        if (visible)
        {  // если visible = true
            GUI.Box(new Rect((Screen.width - 300) / 2, (Screen.height - 300) / 2, 300, 300), "Диалог");  // создается окно с двумя кнопками
            GUI.Label(new Rect(new Rect((Screen.width - 300) / 2, (Screen.height - 270) / 2, 300, 300)), "?");  //текст диалога
            if (GUI.Button(new Rect((Screen.width - 250) / 2, (Screen.height - 250) / 2 + 250, 250, 25), "Отмена")) // если нажать отмена
            {
                visible = false;   // окно закроется
            }
            if (GUI.Button(new Rect((Screen.width - 250) / 2, (Screen.height - 300) / 2 + 250, 250, 25), "Я хочу войти"))
            {  // если нажать "Я хочу войти"
                visible = false; // опять же окно закрывается
                SceneManager.LoadScene("Hall"); // и загружается сцена 2 (название сцены, у вас оно может быть другое)
                transform.position = point.transform.position; // переносим персонажа в ту точку где находится наш Point
            }
        }
    }

}