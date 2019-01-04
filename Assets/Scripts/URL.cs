using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour {



    // Open the facebook app in IOS/Android Example. All you have to do is replicate and change the links.

            //public void openLWAFacebookPage()
            //{
            //    float startTime;
            //    startTime = Time.timeSinceLevelLoad;

            //    // open the facebook app in IOS
            //    Application.OpenURL("fb://page/?id=350989365287405");
            //    // open the facebook app in Andorid
            //    Application.OpenURL("fb://page/350989365287405");

            //    if (Time.timeSinceLevelLoad - startTime <= 1f)
            //    {
            //        //fail. Open safari.
            //        Application.OpenURL("https://www.facebook.com/leapwithalice/");
            //    }
            //}


    // Open the webpage URL Example, all you have to do is replicate and change the link.

            //public void openOkojiPage()
            //{
            //    Application.OpenURL("http://okoji.com/");
            //}

    // Send a custom email Example, all you have to do is replicate and change the content of the email.
            //public void SendEmail()
            //{
            //    string email = "info@leapwithalice.io";
            //    string subject = MyEscapeURL("Leap With Alice ");
            //    string body = MyEscapeURL(" ");
            //    Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
            //}
            //string MyEscapeURL(string url)
            //{
            //    return WWW.EscapeURL(url).Replace("+", "%20");
            //}





	public void openLWAFacebookPage ()
	{
		float startTime;
		startTime = Time.timeSinceLevelLoad;

		// open the facebook app in IOS
		Application.OpenURL("fb://page/?id=350989365287405");
		// open the facebook app in Andorid
		Application.OpenURL ("fb://page/350989365287405");

		if (Time.timeSinceLevelLoad - startTime <= 1f)
		{
			//fail. Open safari.
			Application.OpenURL("https://www.facebook.com/leapwithalice/");
		}
	}

	public void openLeapWithAliceSite ()
	{
		float startTime;
		startTime = Time.timeSinceLevelLoad;

		Application.OpenURL("https://leapwithalice.io/");

	}

	public void openLWATelegram ()
	{
		Application.OpenURL ("https://t.me/LeapWithAlice");
	}

	public void openOTBPage ()
	{
        Application.OpenURL ("https://ontheboard.com");
	}

	public void openSchoolSite1 ()
	{
		Application.OpenURL ("https://solarsystem.nasa.gov/planets/neptune");
	}




    public void openOTBInApp()
    {
        InAppBrowser.OpenURL("https://ontheboard.com");
    }






	public void openSchoolSite2 ()
	{
		Application.OpenURL ("https://www.youtube.com/watch?v=VM22MyLaRSs");
	}

    public void openSharkVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=tfWMwG6aYzQ");
    }

    public void openOTBinstagram()
    {
        Application.OpenURL("https://www.instagram.com/getotb/?hl=en");
    }

    public void openOTBprofile()
    {
        Application.OpenURL("https://app.ontheboard.com/profile/a8110349-462a-433d-77db-08d5b9bd7422/news/list");
    }

    public void openOTBtwitter()
    {
        Application.OpenURL("https://twitter.com/GetOTB");
    }


    public void openBortlesFoundation()
    {
        Application.OpenURL("https://blakebortlesfoundation.com/");
    }








	public void SendEmail ()

    {

    string email = "info@leapwithalice.io";

    string subject = MyEscapeURL("Leap With Alice ");

    string body = MyEscapeURL(" ");
     

    Application.OpenURL ("mailto:" + email + "?subject=" + subject + "&body=" + body);

    }  

    string MyEscapeURL (string url)

    {

    return WWW.EscapeURL(url).Replace("+","%20");

    }

    public void HillelSite()
    {
        Application.OpenURL("https://www.hillelhebrew.org");
    }

    public void DonateSaltofHeaven()
    {
        Application.OpenURL("https://www.paypal.com/donate/?token=wy1po-aV1FWY4-1WybfklZ745HhSC5nHTrp1e5l3hWIg8qGWZXglBMIHTzHPyJiJOO47bG&country.x=US&locale.x=US");
    }

    public void UCFSite()
    {
        Application.OpenURL("https://www.ucf.edu");
    }

    public void PavingtheWaySite()
    {
        Application.OpenURL("https://www.stoptraffickingtoday.com");
    }

    public void MontessoriSite()
    {
        Application.OpenURL("https://amshq.org");
    }

    public void SlatofHeavenSite()
    {
        Application.OpenURL("http://saltofheaven.org");
    }

    public void DanielsSite()
    {
        Application.OpenURL("http://saltofheaven.org");
    }



    public void neptuneVideo()
    {
        Application.OpenURL("https://youtu.be/VM22MyLaRSs");
    }
    public void neptuneWebsite()
    {
        Application.OpenURL("https://solarsystem.nasa.gov/planets/neptune");   
    }

}