using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondNPC : MonoBehaviour
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
        print("Здоровье: " + health);

    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z -= speed * Time.deltaTime;
        transform.position = newPosition;
        speed += 0.02f;
    }
}
