using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 240503_�ڷ����� ����ȯ�� ���� ���͵� Ŭ����
/// </summary>

public class DataTypeStudy : MonoBehaviour
{   // ��(value)�� ����
    // �ڷ��� | ������ | ��
    bool    isEnable   = false;    //1����Ʈ, true/false ����
    int     number     = 0;        //32��Ʈ = 4����Ʈ, ������ �� ���� �ִ� 0~4,294,967,295, -2,147,483,648 ~ +2,147,483,648
    uint    numberunit = 165484; //��ȣ�� ���� ���� �ڷ���
    float   number2    = 35.5f;    // 4����Ʈ, �Ǽ�/�ڷ��� ����. �Ҽ��� ǥ���� ������
    double  number3    = 35.5;     //64��Ʈ = 8����Ʈ, ���� ������ �� ǥ�� ����. �Ǽ�/�ڷ���
    char    data       = 'c';      //�ϳ��� ���ڸ� ����
    string  name       = "CSharp"; // ���ڿ�, ������ ũ�⿡ ���� ũ�Ⱑ ���ϴ� �ڷ���

    int number4;//���� �Ҵ����� �ʴ� ��� 0���� �ڵ� �ʱ�ȭ

    const int age = 5;//��� : runtime �� ���� �Ұ� / �۷ι� ���ӽ����̽����� �����

    // Start is called before the first frame update
    void Start()
    {
        print(isEnable);
        print(typeof(bool));
        print(number4);

        //age = 60; <-������

        //����ȯ(Type Cashing)
        int myInt = 10;
        double myDouble = 55.4;

        //����ȯ ��� 1 - �Ͻ���, ����� ����ȯ
        myDouble = myInt; // �Ͻ��� ����ȯ
        myInt = myDouble; // �Ͻ��� ����ȯ �Ұ�(double�� ũ�Ⱑ �� Ŀ��)

        myInt = (int)myDouble; //����� ����ȯ: ũ�Ⱑ ū ������ ���� ������ ��ȯ -> 55

        //����ȯ ��� 2 - 
    }

    // Update is called once per frame
    void Update()
    {
        myInt.ToString(); // int�� ������ string������ ��ȯ
        string age2 = 36;
        age.ToIntArray();
        int.Parse(age2); //string->int������ ��ȯ
        float.Parse(age2);//string->float������ ��ȯ
        double.Parse(age2);//string->double������ ��ȯ
        bool.Parse(age2);//string->bool������ ��ȯ
    }
}
