using System.IO;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObbExtractor : MonoBehaviour
{
    //How to use the script
    //- Attach this script to the game object in the scene that starts the build but prior to the AR initialization.
    //- The point of the script is to initialize the vuforia database when a split binary android app is created.
    //- This is due to the fact that when a build exceeds 100mb it requires a split binary application build
    //- This then seperates the content from the database

    void Start()
    {
        StartCoroutine(ExtractObbDatasets());
    }

    private IEnumerator ExtractObbDatasets()
    {
        // Specify the datasets that need to be activated
        string[] filesInOBB = { "LeapWithAliceDemo.dat", "LeapWithAliceDemo.xml" };
        foreach (var filename in filesInOBB)
        {
            string uri = Application.streamingAssetsPath + "/Vuforia/" + filename;

            string outputFilePath = Application.persistentDataPath + "/Vuforia/" + filename;
            if (!Directory.Exists(Path.GetDirectoryName(outputFilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(outputFilePath));

            var www = new WWW(uri);
            yield return www;

            Save(www, outputFilePath);
            yield return new WaitForEndOfFrame();
        }

        // When done extracting the datasets, this then starts the next scene that is set
        SceneManager.LoadScene("alice Lens");
    }

    private void Save(WWW w, string outputPath)
    {
        File.WriteAllBytes(outputPath, w.bytes);

        // Verify that the File has been actually stored
        if (File.Exists(outputPath))
        {
            Debug.Log("File successfully saved at: " + outputPath);
        }
        else
        {
            Debug.Log("Failure!! - File does not exist at: " + outputPath);
        }
    }
}