using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticDataForTestGame : object
{
    //StaticDataForTestGame - вспомогательный класс для передачи сцене-тесту всей инфы
    //Класс статик! его не надо никуда прикреплять или удалять
    //Его использует OpenSceneScript для передачи инфы!
    public static string pathToQuestion = "TestQuestionsBy221";
    public static string sceneNameIfExit = "221";
}
