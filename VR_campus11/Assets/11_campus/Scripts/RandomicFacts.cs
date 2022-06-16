using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class RandomicFacts : MonoBehaviour
{
    private bool logic;
    List<string> facts = new List<string>();
    int randindex;
    // Start is called before the first frame update
    void Start()
    {
        facts.Add("Чтобы испортировать 3D модель в Unity, достаточно просто перетащить её файл в окно Project, или скопировать модель напрямую в папку Assets проекта.");
        facts.Add("Terrain - система редактора Unity, позволяющая создавать ландшафт для игрового мира, начиная рельефом земли и заканчивая некоторыми деталями окружения.");
        facts.Add("GameObject - целый контейнер возможных компонентов. В Unity он считается базовым объектом всех сцен.");
        facts.Add("В панели Inspector отображаются все параметры выбранного объекта, начиная от положения и заканчивая закреплёнными за ним компонентами.");
        facts.Add("Mesh - класс Unity, позволяющий создавать и изменять 3D модели с помощью скриптов.");
        facts.Add("Collider определяет физическую форму объекта для взаимодействия с игровой физикой.");
        facts.Add("Любая из камер в Unity поддаётся вращению и перемещению.");
        facts.Add("После создания проекта объекты MainCamera и Directional Light добавляются автоматически.");
        facts.Add("Во вкладке Console отображаются все сообщения и ошибки.");
        facts.Add("Во вкладке Navigator создаётся поверхность передвижения агента.");
        facts.Add("Lighting отвечает за работу всего света в сцене.");
        facts.Add("Добавление компонента Rigidbody к объекту отдает его движение под контроль физического движка Unity. Даже без добавления какого либо кода, " +
            "объект с Rigidbody будет подвержен гравитации.");
        facts.Add("Если не получается создать какой-либо компонент игры, можно воспользоваться встроенный в редактор Unity магазин объектов.");
        facts.Add("Локальные координаты отсчитываются относительно родительского GameObject'а, а глобальные координаты отсчитываются относительно центра сцены. " +
            "Это довольно очевидно, если исходить из самой формулировки этих определений.");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            randindex = Random.Range(0, facts.Count - 1);
            logic = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
       if (other.tag == "Player")
        {
            logic = false;
        }
    }

   void OnGUI()
    {
            if (logic == true)
            {
                GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80), facts[randindex]);
            }
    }
}
