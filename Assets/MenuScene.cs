using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour {

	private CanvasGroup fadeGroup;
	private float fadeinSpeed = 0.33f;
	private Vector3 desiredMenuPosistion;


	public RectTransform menuContainer;

	// Use this for initialization
	void Start () {
		//grab the only canvas group of the scene
		fadeGroup = FindObjectOfType<CanvasGroup>();

		//start with a white screen
		fadeGroup.alpha = 1;

		//Add button on-click events to
	}
		
	// Update is called once per frame
	void Update () {
		//fade in
		fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeinSpeed;

		//menu navigation (smooth)
		menuContainer.anchoredPosition3D = Vector3.Lerp(menuContainer.anchoredPosition3D, desiredMenuPosistion, 0.1f);
	}

	private void NavigateTO(int menuIndex)
	{
		switch (menuIndex) {

		//0 = news menu
		case 0:
			desiredMenuPosistion = Vector3.zero;
			break;
		//1 = CWL menu
		case 1:
			desiredMenuPosistion = Vector3.right * 1280;
			break;
		//2 = Chat
		case 2:
			desiredMenuPosistion = Vector3.left * 1280;
			break;
		//3 = Store
		case 3:
			desiredMenuPosistion = Vector3.right * 2560;
			break;
		//4 = Profile
		case 4:
			desiredMenuPosistion = Vector3.left * 2560;
			break;
		//5 = Gift
		case 5:
			desiredMenuPosistion = new Vector3(2560, -2048);
			break;
		//6 = GiftStore
		case 6:
			desiredMenuPosistion = new Vector3(2560,0);
			break;
		default:
			desiredMenuPosistion = Vector3.zero;
			break;
		}
	}

	public void onCwlClick()
	{
		Debug.Log ("CWL Button has been clicked");
		NavigateTO (1);
	}

	public void onChatClick()
	{
		Debug.Log ("Chat button has been clicked");
		NavigateTO (2);
	}

	public void onStoreClick()
	{
		Debug.Log ("Store button has been clicked");
		NavigateTO (3);
	}

	public void onNewsClick()
	{
		Debug.Log ("News button has been clicked");
		NavigateTO (0);
	}

	public void onProfileClick()
	{
		Debug.Log ("Profile button has been clicked");
		NavigateTO (4);
	}

	public void onGiftClick()
	{
		Debug.Log ("Gift button has been clicked");
		NavigateTO (5);
	}

	public void onGiftStoreClick()
	{
		Debug.Log ("Store button has been clicked");
		NavigateTO (6);
	}

}
