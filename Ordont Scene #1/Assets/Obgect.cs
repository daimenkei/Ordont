using UnityEngine;

public class HeadAndArmsRotation : MonoBehaviour
{
    public Transform head; // Ссылка на объект головы
    public Transform leftArm; // Ссылка на объект левой руки
    public Transform rightArm; // Ссылка на объект правой руки

    public float rotationSpeed = 1f; // Скорость вращения рук

    void Update()
    {
        // Получаем вращение головы
        Vector3 headRotation = head.eulerAngles;

        // Изменяем только ось x (вверх-вниз)
        float newArmRotationX = headRotation.x;

        // Применяем вращение к рукам
        leftArm.localEulerAngles = new Vector3(newArmRotationX, leftArm.localEulerAngles.y, leftArm.localEulerAngles.z);
        rightArm.localEulerAngles = new Vector3(newArmRotationX, rightArm.localEulerAngles.y, rightArm.localEulerAngles.z);
    }
}