using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float minX; //Минимальная координата x.
    public float maxX; //Максимальная координата x.
    void Update()
    {
        Vector3 mousePos = Input.mousePosition; //3d вектор.
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos); //Присваивание позиции мыши в разрешении к игровому миру.
        //Debug.Log($"mousePos {mousePos} / mouseWorldPos {mouseWorldPos}");

        float mouseX = mouseWorldPos.x; //Положение платформы по x.
        float clampedMouseX = Mathf.Clamp(mouseX, minX, maxX); //Функция минимум/максимум.
        float platformY = transform.position.y; //Положение платформы по y.
        transform.position = new Vector3 (clampedMouseX, platformY, 0); // Общие координаты платформы.

    }
}
