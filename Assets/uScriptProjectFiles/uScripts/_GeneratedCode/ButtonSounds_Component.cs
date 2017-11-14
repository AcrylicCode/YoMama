//uScript Generated Code - Build 1.0.3073
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/ButtonSounds")]
public class ButtonSounds_Component : uScriptCode
{
    public AudioClip[] buttonSounds = new AudioClip[0];
    private AudioSource sfxPlayer;

//   #pragma warning disable 414
//    public ButtonSounds ExposedVariables = new ButtonSounds( );
//#pragma warning restore 414

    private void Awake()
    {
        Button thisButton = this.GetComponent<Button>();
        if(thisButton != null)
        {
            thisButton.onClick.AddListener(OnClick);
        }

        GameObject sfxObj = GameObject.Find("SFXPlayer");
        if (sfxObj != null)
            sfxPlayer = sfxObj.GetComponent<AudioSource>();
    }

    void OnClick()
    {
        Debug.Log("Clicked");
        if (buttonSounds.Length == 0)
            return;

        AudioClip chosenClip = buttonSounds[Random.Range(0, buttonSounds.Length-1)];
        
        if(sfxPlayer != null)
        {
            sfxPlayer.clip = chosenClip;
            sfxPlayer.PlayOneShot(chosenClip);
        }
    }

    //public UnityEngine.AudioClip[] ButtonSFX { get { return ExposedVariables.ButtonSFX; } set { ExposedVariables.ButtonSFX = value; } } 

    //void Awake( )
    //{
    //   #if !(UNITY_FLASH)
    //   useGUILayout = false;
    //   #endif
    //   ExposedVariables.Awake( );
    //   ExposedVariables.SetParent( this.gameObject );
    //   if ( "1.CMR" != uScript_MasterComponent.Version )
    //   {
    //      uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
    //      ExposedVariables = null;
    //      UnityEngine.Debug.Break();
    //   }
    //}
    //void Start( )
    //{
    //   ExposedVariables.Start( );
    //}
    //void OnEnable( )
    //{
    //   ExposedVariables.OnEnable( );
    //}
    //void OnDisable( )
    //{
    //   ExposedVariables.OnDisable( );
    //}
    //void Update( )
    //{
    //   ExposedVariables.Update( );
    //}
    //void OnDestroy( )
    //{
    //   ExposedVariables.OnDestroy( );
    //}
    //#if UNITY_EDITOR
    //   void OnDrawGizmos( )
    //   {
    //      {
    //         GameObject gameObject;
    //         gameObject = GameObject.Find( "SFXPlayer" ); 
    //         if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
    //      }
    //   }
    //#endif
}
