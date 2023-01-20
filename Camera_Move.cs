using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
	public float MoveSpeed;

	private int moveCheck = 0;

	public void MoveRight()
	{
		moveCheck = 1; //������ �̵� ��ư ���� �� 1
	}
	public void MoveLeft()
	{
		moveCheck = 2; //���� �̵� ��ư ���� �� 2
	}
	public void MoveStop()
	{
		moveCheck = 0; //��ư���� ���� ���� 0
	}

	private void FixedUpdate()
	{
		Vector3 vec = GameManager.instance.Camera.transform.position;
		if (vec.x < 2 && moveCheck==1) //�̵� ���ǰ� ī�޶� �̵� ���� ������ ����
		{
			GameManager.instance.Camera.transform.position = new Vector3(vec.x + MoveSpeed, vec.y, vec.z);
		}
		if (vec.x > -2 && moveCheck == 2)
		{
			GameManager.instance.Camera.transform.position = new Vector3(vec.x - MoveSpeed, vec.y, vec.z);
		}
	}
}