using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondNPC : MonoBehaviour
{
    // Start is called before the first frame update
    // �������� NPC
    public int health = 5;
    // ������� NPC
    public int level = 1;
    // �������� NPC
    public float speed = 1.2f;
    public Vector3 newPosition;
    void Start()
    {
        // ��������� � ������� NPC ��� ������� � ������� �������� � �������
        health += level;
        print("��������: " + health);

    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z -= speed * Time.deltaTime;
        transform.position = newPosition;
        speed += 0.02f;
    }
}
