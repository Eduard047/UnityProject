using UnityEngine;

public class GridPlacement : MonoBehaviour
{
    public float gridSize = 1.0f; // Размер клетки сетки

    void Start()
    {
        // Позиция объекта в мировых координатах
        Vector3 objectPosition = transform.position;

        // Округляем координаты до ближайшей нижней клетки
        float roundedX = Mathf.Floor(objectPosition.x / gridSize) * gridSize;
        float roundedY = Mathf.Floor(objectPosition.y / gridSize) * gridSize;
        float roundedZ = Mathf.Floor(objectPosition.z / gridSize) * gridSize;

        // Устанавливаем новую позицию объекта
        transform.position = new Vector3(roundedX, roundedY, roundedZ);
    }
}
