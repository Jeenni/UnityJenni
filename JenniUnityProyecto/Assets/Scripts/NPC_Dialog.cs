using UnityEngine;
using System.Collections;

public class NPC_Dialog : MonoBehaviour {

	public string[] answerButtons;
	public string[] Questions;
	bool DisplayDailog = false;
	bool ActivateQuest = false;
	bool ActivateQuestSiesqueno = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUILayout.BeginArea (new Rect (700, 600, 400, 400));

		if (DisplayDailog && !ActivateQuest) {

			//Puedes ayudarme
			GUILayout.Label(Questions[0]);
			//GUILayout.Label(Questions[1]);

			if(GUILayout.Button(answerButtons[0])){//si
				ActivateQuest = true;

				DisplayDailog = false;
			}
			if(GUILayout.Button(answerButtons[1])){//No

				ActivateQuestSiesqueno=true;

				DisplayDailog= false;


			}
		}
		//Si es que no
		if (DisplayDailog && ActivateQuestSiesqueno) {
			GUILayout.Label(Questions[2]);
		}

		//si es que si
		if (DisplayDailog && ActivateQuest) {
			GUILayout.Label(Questions[1]);

			if(GUILayout.Button(answerButtons[2])){
				DisplayDailog = false;

			}
		}
		GUILayout.EndArea ();

	}

	void OnTriggerEnter(){
		DisplayDailog = true;

	}
	void ObnTriggerExit(){
		DisplayDailog = false;
	}
}
