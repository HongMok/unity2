using UnityEngine;
using System.Collections;

public class InitGame : MonoBehaviour {

    private Object preGo;

    public Material matBall;

    public Texture ttShoot;
	
	// Use this for initialization
	void Start () {

        preGo = Resources.Load("ball");


        GameObject myBall = ( GameObject)Instantiate( preGo );

        myBall.transform.position = new Vector3(0, 5, -5);

        myBall.AddComponent<AutoDestroy>();
    
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				GameObject newCube = GameObject.CreatePrimitive (PrimitiveType.Cube);
				newCube.transform.position = new Vector3 (i, j, -1);
				newCube.AddComponent<Rigidbody> ();
				newCube.rigidbody.drag = 5;

				newCube.AddComponent<AutoDestroy> ();
			}
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
            GameObject newBall = ( GameObject)Instantiate( preGo );//GameObject.CreatePrimitive (PrimitiveType.Sphere);
			newBall.transform.position = Camera.main.transform.position;
			newBall.AddComponent<Rigidbody> ();

//			newBall.AddComponent<AutoDestroy> ();

//            newBall.renderer.material = matBall;

            Material mat = Resources.Load("Materials/MatSep") as Material;
            newBall.renderer.material = mat;

			Vector3 dir = Camera.main.ScreenToWorldPoint ( new Vector3( Input.mousePosition.x, Input.mousePosition.y, 3));
			newBall.rigidbody.AddForce ( (dir - Camera.main.transform.position ) * 10, ForceMode.Impulse);

//			GameObject[] cubes = GameObject.FindObjectsOfType<PrimitiveType.Cube> ();
//			foreach( GameObject cube in cubes ){
//				if( cube.transform.position.y < 0 ){
//					Destroy (cube);
//				}
//			}
		}
	}

    void OnGUI(){

        float left = Input.mousePosition.x - ttShoot.width / 2;

        float top = calGuiY();

        GUI.DrawTexture( new Rect( left, top, ttShoot.width, ttShoot.height), ttShoot);
    }

    float calGuiY( ){
        return Screen.height - Input.mousePosition.y - ttShoot.height / 2;
    }
}
