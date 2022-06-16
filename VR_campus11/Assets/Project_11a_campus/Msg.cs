using UnityEngine;
using System.Collections;

public class Msg : MonoBehaviour
{


    public GameObject player;
    private bool logic;

     void OnTriggerEnter(Collider other)
     {
        if (other.tag == "Player")
        {
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
            GUI.TextArea(new Rect(500, 300, 500, 150), "ДОБРО ПОЖАЛОВАТЬ!\nВы находитесь в учебном корпусе ФИТР,на кафедре ПОВТиАС.\nДля передвижения используйте клавиши W,A,S,D.\nДля взаимодейсвтия с объектами используете клавишу E.\n" +
                "Для включения курсора мыши используеть клавишу F, для отключения - клавишу ESC.\n Пройдите в уадиторию №216 (Базы данных)");
            
        }

    }

}