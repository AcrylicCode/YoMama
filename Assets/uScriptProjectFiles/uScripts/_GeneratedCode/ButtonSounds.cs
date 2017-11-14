//uScript Generated Code - Build 1.0.3073
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class ButtonSounds : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.AudioClip[] ButtonSFX = new UnityEngine.AudioClip[ 0 ];
   UnityEngine.GameObject local_4_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_4_UnityEngine_GameObject_previous = null;
   System.Single local_SFX_Volume_System_Single = (float) 1;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_PlaySoundRandom logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2 = new uScriptAct_PlaySoundRandom( );
   UnityEngine.AudioClip[] logic_uScriptAct_PlaySoundRandom_audioClips_2 = new UnityEngine.AudioClip[ 0 ];
   UnityEngine.GameObject[] logic_uScriptAct_PlaySoundRandom_targets_2 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_PlaySoundRandom_volume_2 = (float) 0;
   System.Boolean logic_uScriptAct_PlaySoundRandom_loop_2 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_PlaySoundRandom_chosenTarget_2;
   UnityEngine.AudioClip logic_uScriptAct_PlaySoundRandom_chosenClip_2;
   bool logic_uScriptAct_PlaySoundRandom_Out_2 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_4_UnityEngine_GameObject = GameObject.Find( "SFXPlayer" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Button component = owner_Connection_1.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Button component = owner_Connection_1.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_1 )
      {
         {
            uScript_Button component = owner_Connection_1.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_0;
               component.OnButtonDown -= Instance_OnButtonDown_0;
               component.OnButtonUp -= Instance_OnButtonUp_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.SetParent(g);
      owner_Connection_1 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Finished += uScriptAct_PlaySoundRandom_Finished_2;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Finished -= uScriptAct_PlaySoundRandom_Finished_2;
   }
   
   void Instance_OnButtonClick_0(object o, uScript_Button.ClickEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_0( );
   }
   
   void Instance_OnButtonDown_0(object o, uScript_Button.ClickEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_0( );
   }
   
   void Instance_OnButtonUp_0(object o, uScript_Button.ClickEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_0( );
   }
   
   void uScriptAct_PlaySoundRandom_Finished_2(object o, System.EventArgs e)
   {
      //fill globals
      //links to chosenTarget = 0
      //links to chosenClip = 0
      //relay event to nodes
      Relay_Finished_2( );
   }
   
   void Relay_OnButtonClick_0()
   {
      if (true == CheckDebugBreak("a2562da4-3970-4b1a-bd46-3081ef20069f", "UI_Button_Events", Relay_OnButtonClick_0)) return; 
   }
   
   void Relay_OnButtonDown_0()
   {
      if (true == CheckDebugBreak("a2562da4-3970-4b1a-bd46-3081ef20069f", "UI_Button_Events", Relay_OnButtonDown_0)) return; 
   }
   
   void Relay_OnButtonUp_0()
   {
      if (true == CheckDebugBreak("a2562da4-3970-4b1a-bd46-3081ef20069f", "UI_Button_Events", Relay_OnButtonUp_0)) return; 
      Relay_Play_2();
   }
   
   void Relay_Finished_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0fb25a43-7712-4328-8514-02e81647966d", "Play_Sound__Random_", Relay_Finished_2)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript ButtonSounds.uscript at Play Sound (Random).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Play_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0fb25a43-7712-4328-8514-02e81647966d", "Play_Sound__Random_", Relay_Play_2)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = ButtonSFX;
               if ( logic_uScriptAct_PlaySoundRandom_audioClips_2.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_audioClips_2, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_PlaySoundRandom_audioClips_2, index, properties.Length);
               index += properties.Length;
               
            }
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_PlaySoundRandom_targets_2.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_targets_2, index + 1);
               }
               logic_uScriptAct_PlaySoundRandom_targets_2[ index++ ] = local_4_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_PlaySoundRandom_volume_2 = local_SFX_Volume_System_Single;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Play(logic_uScriptAct_PlaySoundRandom_audioClips_2, logic_uScriptAct_PlaySoundRandom_targets_2, logic_uScriptAct_PlaySoundRandom_volume_2, logic_uScriptAct_PlaySoundRandom_loop_2, out logic_uScriptAct_PlaySoundRandom_chosenTarget_2, out logic_uScriptAct_PlaySoundRandom_chosenClip_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript ButtonSounds.uscript at Play Sound (Random).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_UpdateVolume_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0fb25a43-7712-4328-8514-02e81647966d", "Play_Sound__Random_", Relay_UpdateVolume_2)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = ButtonSFX;
               if ( logic_uScriptAct_PlaySoundRandom_audioClips_2.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_audioClips_2, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_PlaySoundRandom_audioClips_2, index, properties.Length);
               index += properties.Length;
               
            }
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_PlaySoundRandom_targets_2.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_targets_2, index + 1);
               }
               logic_uScriptAct_PlaySoundRandom_targets_2[ index++ ] = local_4_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_PlaySoundRandom_volume_2 = local_SFX_Volume_System_Single;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.UpdateVolume(logic_uScriptAct_PlaySoundRandom_audioClips_2, logic_uScriptAct_PlaySoundRandom_targets_2, logic_uScriptAct_PlaySoundRandom_volume_2, logic_uScriptAct_PlaySoundRandom_loop_2, out logic_uScriptAct_PlaySoundRandom_chosenTarget_2, out logic_uScriptAct_PlaySoundRandom_chosenClip_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript ButtonSounds.uscript at Play Sound (Random).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0fb25a43-7712-4328-8514-02e81647966d", "Play_Sound__Random_", Relay_Stop_2)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = ButtonSFX;
               if ( logic_uScriptAct_PlaySoundRandom_audioClips_2.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_audioClips_2, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_PlaySoundRandom_audioClips_2, index, properties.Length);
               index += properties.Length;
               
            }
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_PlaySoundRandom_targets_2.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_targets_2, index + 1);
               }
               logic_uScriptAct_PlaySoundRandom_targets_2[ index++ ] = local_4_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_PlaySoundRandom_volume_2 = local_SFX_Volume_System_Single;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Stop(logic_uScriptAct_PlaySoundRandom_audioClips_2, logic_uScriptAct_PlaySoundRandom_targets_2, logic_uScriptAct_PlaySoundRandom_volume_2, logic_uScriptAct_PlaySoundRandom_loop_2, out logic_uScriptAct_PlaySoundRandom_chosenTarget_2, out logic_uScriptAct_PlaySoundRandom_chosenClip_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript ButtonSounds.uscript at Play Sound (Random).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ButtonSounds.uscript:SFX Volume", local_SFX_Volume_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3fbed21d-546c-4568-8d6d-ab1b42ad7d1a", local_SFX_Volume_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ButtonSounds.uscript:4", local_4_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4b103f42-67d7-4771-ad9d-2cbd608c213a", local_4_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ButtonSounds.uscript:ButtonSFX", ButtonSFX);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "896b82f5-500b-45f8-a5a9-841f6b4b4bea", ButtonSFX);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
