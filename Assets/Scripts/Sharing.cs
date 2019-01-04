using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    void Update()
    {
    //    if (Input.GetMouseButtonDown(0))
    //        StartCoroutine(TakeSSAndShare());
    //
    }

    public void TakeSSAndShare()
    {
        //yield return new WaitForEndOfFrame();

        //Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        //ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        //ss.Apply();

        //string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        //File.WriteAllBytes(filePath, ss.EncodeToPNG());

        // To avoid memory leaks
        //Destroy(ss);

        new NativeShare().SetSubject("On The Board Image Targets").SetText("Congratulations! The On The Board Augmented Reality application Image Targets have just been shared with you. Just tap the link below on a device and point the OTB AR app at the image for the experience to begin" + "\n" + "\n" + "Image Targets: https://s3.amazonaws.com/lwa-demo-app-targets/On+The+Board+AR+Image+Targets.zip").Share();

    //    if( NativeShare.TargetExists( "com.whatsapp" ) )
    //      new NativeShare().AddFile( filePath ).SetText( "Hello world!" ).SetTarget( "com.whatsapp" ).Share();
    //
    }
		
	}

