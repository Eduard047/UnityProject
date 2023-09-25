using UnityEngine;

public class GridPlacement : MonoBehaviour
{
    public float gridSize = 1.0f; // ������ ������ �����

    void Start()
    {
        // ������� ������� � ������� �����������
        Vector3 objectPosition = transform.position;

        // ��������� ���������� �� ��������� ������ ������
        float roundedX = Mathf.Floor(objectPosition.x / gridSize) * gridSize;
        float roundedY = Mathf.Floor(objectPosition.y / gridSize) * gridSize;
        float roundedZ = Mathf.Floor(objectPosition.z / gridSize) * gridSize;

        // ������������� ����� ������� �������
        transform.position = new Vector3(roundedX, roundedY, roundedZ);
    }
}
