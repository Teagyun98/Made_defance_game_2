using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Action : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject image;
	public GameObject menu;
	public GameObject gameSet;
	public GameObject blue;
	public GameObject red;
	public string mod;

	public void OnClick()
	{
		StartCoroutine("GameStart"); //��ư Ŭ���� ����Ǵ� �Լ�
	}

	IEnumerator GameStart()
	{
		image.SetActive(true); //�޴� ��� �̹��� Ȱ��ȭ
		yield return new WaitForSeconds(0.5f);
		GameManager.instance.mod = mod; //���� �Ŵ����� ������ ���̵� ����
		Debug.Log(GameManager.instance.mod); //�� ���� �Ǿ����� Ȯ��
		menu.SetActive(false); //�޴� ��Ȱ��ȭ
		gameSet.SetActive(true);
		red.SetActive(true); //���� ���� Ȱ��ȭ	
		blue.SetActive(true); //��� ���� Ȱ��ȭ
	}
}
