#pragma strict

public static var flag1:boolean = true;

function Start () {
	
}

function Update () {
	if( flag1 == false ){
		PlayerPrefs.SetString("w1", "风景1");
	}
	if( flag1 ){
		this.transform.Rotate( -Time.deltaTime * 50, 0, 0);
	}
}