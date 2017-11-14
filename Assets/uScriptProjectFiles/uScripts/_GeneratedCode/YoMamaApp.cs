//uScript Generated Code - Build 1.0.3073
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class YoMamaApp : uScriptLogic
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
   System.String local_2_System_String = "";
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_IntToString logic_uScriptAct_IntToString_uScriptAct_IntToString_1 = new uScriptAct_IntToString( );
   System.Int32 logic_uScriptAct_IntToString_Target_1 = (int) 0;
   uScriptAct_IntToString.FormatType logic_uScriptAct_IntToString_StandardFormat_1 = uScriptAct_IntToString.FormatType.General;
   System.String logic_uScriptAct_IntToString_CustomFormat_1 = "";
   System.String logic_uScriptAct_IntToString_CustomCulture_1 = "";
   System.String logic_uScriptAct_IntToString_Result_1;
   bool logic_uScriptAct_IntToString_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_3 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_3 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_3 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_3 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_3 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_3;
   bool logic_uScriptAct_SetString_Out_3 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_5 = default(UnityEngine.GameObject);
   
   //property nodes
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_0 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous = null;
   System.String property_text_Detox_ScriptEditor_Parameter_text_4 = "";
   UnityEngine.GameObject property_text_Detox_ScriptEditor_Parameter_Instance_4 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_text_Detox_ScriptEditor_Parameter_Instance_4_previous = null;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_0_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_0 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_0.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         return component.tokens;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_0_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_0 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_0.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_0;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_4_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_text_Detox_ScriptEditor_Parameter_Instance_4 != null)
      {
         component = property_text_Detox_ScriptEditor_Parameter_Instance_4.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_4_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_text_Detox_ScriptEditor_Parameter_Instance_4 != null)
      {
         component = property_text_Detox_ScriptEditor_Parameter_Instance_4.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_4;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_0 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_0 = GameObject.Find( "/TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_0 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_0;
         
         //setup new listeners
      }
      if ( null == property_text_Detox_ScriptEditor_Parameter_Instance_4 || false == m_RegisteredForEvents )
      {
         property_text_Detox_ScriptEditor_Parameter_Instance_4 = GameObject.Find( "Token Current" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_text_Detox_ScriptEditor_Parameter_Instance_4_previous != property_text_Detox_ScriptEditor_Parameter_Instance_4 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_text_Detox_ScriptEditor_Parameter_Instance_4_previous = property_text_Detox_ScriptEditor_Parameter_Instance_4;
         
         //setup new listeners
      }
      SyncEventListeners( );
   }
   
   void RegisterForUnityHooks( )
   {
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_0 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_0;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_text_Detox_ScriptEditor_Parameter_Instance_4_previous != property_text_Detox_ScriptEditor_Parameter_Instance_4 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_text_Detox_ScriptEditor_Parameter_Instance_4_previous = property_text_Detox_ScriptEditor_Parameter_Instance_4;
         
         //setup new listeners
      }
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_0 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_0_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_0;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_text_Detox_ScriptEditor_Parameter_Instance_4_previous != property_text_Detox_ScriptEditor_Parameter_Instance_4 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_text_Detox_ScriptEditor_Parameter_Instance_4_previous = property_text_Detox_ScriptEditor_Parameter_Instance_4;
                  
                  //setup new listeners
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_5 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_5 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_5 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_5.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_5;
                  component.OnLateUpdate += Instance_OnLateUpdate_5;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_5;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_5 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_5;
               component.OnLateUpdate -= Instance_OnLateUpdate_5;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_5;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_IntToString_uScriptAct_IntToString_1.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_3.SetParent(g);
   }
   public void Awake()
   {
      
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
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_5(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_5( );
   }
   
   void Instance_OnLateUpdate_5(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_5( );
   }
   
   void Instance_OnFixedUpdate_5(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_5( );
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("21990fc5-29c3-4a13-acc9-5043a8eeb244", "Int_To_String", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_IntToString_Target_1 = property_tokens_Detox_ScriptEditor_Parameter_tokens_0_Get_Refresh( );
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_IntToString_uScriptAct_IntToString_1.In(logic_uScriptAct_IntToString_Target_1, logic_uScriptAct_IntToString_StandardFormat_1, logic_uScriptAct_IntToString_CustomFormat_1, logic_uScriptAct_IntToString_CustomCulture_1, out logic_uScriptAct_IntToString_Result_1);
         local_2_System_String = logic_uScriptAct_IntToString_Result_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_IntToString_uScriptAct_IntToString_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript YoMamaApp.uscript at Int To String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ea8b7f02-1d7d-48d5-85e8-8aa914158822", "Set_String", Relay_In_3)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_3 = local_2_System_String;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetString_uScriptAct_SetString_3.In(logic_uScriptAct_SetString_Value_3, logic_uScriptAct_SetString_ToUpperCase_3, logic_uScriptAct_SetString_ToLowerCase_3, logic_uScriptAct_SetString_TrimWhitespace_3, out logic_uScriptAct_SetString_Target_3);
         property_text_Detox_ScriptEditor_Parameter_text_4 = logic_uScriptAct_SetString_Target_3;
         property_text_Detox_ScriptEditor_Parameter_text_4_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript YoMamaApp.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_5()
   {
      if (true == CheckDebugBreak("6968e785-bcb3-49f9-888f-108310a7f54b", "Global_Update", Relay_OnUpdate_5)) return; 
   }
   
   void Relay_OnLateUpdate_5()
   {
      if (true == CheckDebugBreak("6968e785-bcb3-49f9-888f-108310a7f54b", "Global_Update", Relay_OnLateUpdate_5)) return; 
      Relay_In_1();
   }
   
   void Relay_OnFixedUpdate_5()
   {
      if (true == CheckDebugBreak("6968e785-bcb3-49f9-888f-108310a7f54b", "Global_Update", Relay_OnFixedUpdate_5)) return; 
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "YoMamaApp.uscript:2", local_2_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "0785cae1-98e3-479e-aff8-df8c7ee1bacc", local_2_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9d14a751-d741-4050-9e05-822a3f92bdac", property_tokens_Detox_ScriptEditor_Parameter_tokens_0_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "0eb12403-00c3-462e-8528-926c752c142a", property_text_Detox_ScriptEditor_Parameter_text_4_Get_Refresh());
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
