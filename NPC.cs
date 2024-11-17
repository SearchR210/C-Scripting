using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    // Здоровье NPC
    public int health = 5;
    // Уровень NPC
    public int level = 1;
    // Скорость NPC
    public float speed = 1.2f;
    public Vector3 newPosition;
    void Start()
    {
        // Добавляем к здоровь NPC его уровень и выводим здоровье в консоль
        health += level;
        print("Здоровье: "+health);

    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        int symbolRand = Random.Range(0, 3);
        if (symbolRand == 1)
        {
            newPosition.x += Random.Range(0, 7) * Time.deltaTime;
            transform.position = newPosition;
            print("1");
        }
        else if (symbolRand == 2)
        {
            newPosition.x -= Random.Range(0, 7) * Time.deltaTime;
            transform.position = newPosition;
            print("2");
        }
    }
}
