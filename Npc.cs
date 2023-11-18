using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc: MonoBehaviour
{   //во первых я абоба
    //пишем создание переменной жизьни
    public int health = 5;
    //иииии создаём переменной уровня
    public int level = 2;
    //создаём переменной скорости
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        //обнавляем данные о количестве жизней
        health += level;
        //вывод данных о количестве жизней
        print("количество жизней:" + health);

    }

    // Update is called once per frame
    void Update()
    {
        //структура данных которая получает позицию игрока
        Vector3 newPosition = transform.position;
        //находим координаты объекта спустя 1 кадр
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
