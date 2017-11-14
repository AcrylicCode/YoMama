//uScript Generated Code - Build 1.0.3073
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class AdsForTokens : uScriptLogic
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
   public System.Int32 AddTokens = (int) 10;
   UnityEngine.GameObject local_1_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_1_UnityEngine_GameObject_previous = null;
   System.Int32 local_9_System_Int32 = (int) 30;
   System.Int32 local_AddedInt_System_Int32 = (int) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_4 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_4 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_4 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_4;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_4;
   bool logic_uScriptAct_AddInt_v2_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_ClampInt logic_uScriptAct_ClampInt_uScriptAct_ClampInt_7 = new uScriptAct_ClampInt( );
   System.Int32 logic_uScriptAct_ClampInt_Target_7 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Min_7 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Max_7 = (int) 30;
   System.Int32 logic_uScriptAct_ClampInt_IntResult_7;
   System.Single logic_uScriptAct_ClampInt_FloatResult_7;
   bool logic_uScriptAct_ClampInt_Out_7 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_8 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_8 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_8 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_LessThan_8 = true;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_11 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_11 = new UnityEngine.Color( (float)1, (float)0, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_11;
   bool logic_uScriptAct_SetColor_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_13 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_13 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_13 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_13 = true;
   bool logic_uScriptAct_Delay_AfterDelay_13 = true;
   bool logic_uScriptAct_Delay_Stopped_13 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_13 = false;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_14 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_14 = new UnityEngine.Color( (float)1, (float)0.8902429, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_14;
   bool logic_uScriptAct_SetColor_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_17 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_17 = new UnityEngine.Color( (float)1, (float)0, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_17;
   bool logic_uScriptAct_SetColor_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_18 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_18 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_18 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_18 = true;
   bool logic_uScriptAct_Delay_AfterDelay_18 = true;
   bool logic_uScriptAct_Delay_Stopped_18 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_18 = false;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_20 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_20 = new UnityEngine.Color( (float)1, (float)0.8902429, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_20;
   bool logic_uScriptAct_SetColor_Out_20 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_21 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_21 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_21 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_21 = true;
   bool logic_uScriptAct_Delay_AfterDelay_21 = true;
   bool logic_uScriptAct_Delay_Stopped_21 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_21 = false;
   //pointer to script instanced logic node
   uScriptAct_ClampInt logic_uScriptAct_ClampInt_uScriptAct_ClampInt_24 = new uScriptAct_ClampInt( );
   System.Int32 logic_uScriptAct_ClampInt_Target_24 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Min_24 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Max_24 = (int) 30;
   System.Int32 logic_uScriptAct_ClampInt_IntResult_24;
   System.Single logic_uScriptAct_ClampInt_FloatResult_24;
   bool logic_uScriptAct_ClampInt_Out_24 = true;
   
   //event nodes
   
   //property nodes
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_2 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_2 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous = null;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_5 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_5 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_12 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_12 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_12_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_15 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_15 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_15_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_16 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_16 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_16_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_19 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_19 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_19_previous = null;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_22 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_22 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous = null;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_2_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_2 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_2.GetComponent<TokenManager>();
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
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_2_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_2 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_2.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_2;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_5_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_5 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_5.GetComponent<TokenManager>();
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
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_5_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_5 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_5.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_5;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_12_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_12 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_12.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_12_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_12 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_12.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_12;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_15_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_15 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_15.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_15_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_15 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_15.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_15;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_16_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_16 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_16.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_16_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_16 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_16.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_16;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_19_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_19 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_19.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_19_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_19 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_19.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_19;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_22_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_22 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_22.GetComponent<TokenManager>();
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
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_22_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_22 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_22.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_22;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_2 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_2;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_5 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_5 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_5 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_5;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_12 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_12_previous != property_color_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_12_previous = property_color_Detox_ScriptEditor_Parameter_Instance_12;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_15 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_15_previous != property_color_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_15_previous = property_color_Detox_ScriptEditor_Parameter_Instance_15;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_16 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_16 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_16_previous != property_color_Detox_ScriptEditor_Parameter_Instance_16 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_16_previous = property_color_Detox_ScriptEditor_Parameter_Instance_16;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_19 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_19 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_19_previous != property_color_Detox_ScriptEditor_Parameter_Instance_19 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_19_previous = property_color_Detox_ScriptEditor_Parameter_Instance_19;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_22 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_22 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_22 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_22;
         
         //setup new listeners
      }
      SyncEventListeners( );
      if ( null == local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_1_UnityEngine_GameObject = GameObject.Find( "AddTokens" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_1_UnityEngine_GameObject_previous )
         {
            {
               uScript_Button component = local_1_UnityEngine_GameObject_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
               }
            }
         }
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_1_UnityEngine_GameObject )
         {
            {
               uScript_Button component = local_1_UnityEngine_GameObject.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = local_1_UnityEngine_GameObject.AddComponent<uScript_Button>();
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
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_2;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_5 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_5;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_12_previous != property_color_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_12_previous = property_color_Detox_ScriptEditor_Parameter_Instance_12;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_15_previous != property_color_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_15_previous = property_color_Detox_ScriptEditor_Parameter_Instance_15;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_16_previous != property_color_Detox_ScriptEditor_Parameter_Instance_16 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_16_previous = property_color_Detox_ScriptEditor_Parameter_Instance_16;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_19_previous != property_color_Detox_ScriptEditor_Parameter_Instance_19 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_19_previous = property_color_Detox_ScriptEditor_Parameter_Instance_19;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_22 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_22;
         
         //setup new listeners
      }
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_1_UnityEngine_GameObject_previous )
         {
            {
               uScript_Button component = local_1_UnityEngine_GameObject_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
               }
            }
         }
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_1_UnityEngine_GameObject )
         {
            {
               uScript_Button component = local_1_UnityEngine_GameObject.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = local_1_UnityEngine_GameObject.AddComponent<uScript_Button>();
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
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_2_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_2;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_5 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_5_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_5;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_12_previous != property_color_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_12_previous = property_color_Detox_ScriptEditor_Parameter_Instance_12;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_15_previous != property_color_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_15_previous = property_color_Detox_ScriptEditor_Parameter_Instance_15;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_16_previous != property_color_Detox_ScriptEditor_Parameter_Instance_16 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_16_previous = property_color_Detox_ScriptEditor_Parameter_Instance_16;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_19_previous != property_color_Detox_ScriptEditor_Parameter_Instance_19 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_19_previous = property_color_Detox_ScriptEditor_Parameter_Instance_19;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_22 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_22_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_22;
                  
                  //setup new listeners
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_1_UnityEngine_GameObject )
      {
         {
            uScript_Button component = local_1_UnityEngine_GameObject.GetComponent<uScript_Button>();
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
      
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_4.SetParent(g);
      logic_uScriptAct_ClampInt_uScriptAct_ClampInt_7.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_11.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_13.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_14.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_17.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_18.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_20.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_21.SetParent(g);
      logic_uScriptAct_ClampInt_uScriptAct_ClampInt_24.SetParent(g);
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
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_13)
      {
         Relay_DrivenDelay_13();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_18)
      {
         Relay_DrivenDelay_18();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_21)
      {
         Relay_DrivenDelay_21();
      }
   }
   
   public void OnDestroy()
   {
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
   
   void Relay_OnButtonClick_0()
   {
      if (true == CheckDebugBreak("4a951225-f3da-422a-a5e5-3116e85d6f6a", "UI_Button_Events", Relay_OnButtonClick_0)) return; 
   }
   
   void Relay_OnButtonDown_0()
   {
      if (true == CheckDebugBreak("4a951225-f3da-422a-a5e5-3116e85d6f6a", "UI_Button_Events", Relay_OnButtonDown_0)) return; 
   }
   
   void Relay_OnButtonUp_0()
   {
      if (true == CheckDebugBreak("4a951225-f3da-422a-a5e5-3116e85d6f6a", "UI_Button_Events", Relay_OnButtonUp_0)) return; 
      Relay_In_4();
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fff27257-c6be-4e49-9908-ce78457202cc", "Add_Int", Relay_In_4)) return; 
         {
            {
               logic_uScriptAct_AddInt_v2_A_4 = property_tokens_Detox_ScriptEditor_Parameter_tokens_5_Get_Refresh( );
            }
            {
               logic_uScriptAct_AddInt_v2_B_4 = AddTokens;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_4.In(logic_uScriptAct_AddInt_v2_A_4, logic_uScriptAct_AddInt_v2_B_4, out logic_uScriptAct_AddInt_v2_IntResult_4, out logic_uScriptAct_AddInt_v2_FloatResult_4);
         local_AddedInt_System_Int32 = logic_uScriptAct_AddInt_v2_IntResult_4;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_4.Out;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Add Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a72f5327-70c4-451b-9725-f9732e9f4eef", "Clamp_Int", Relay_In_7)) return; 
         {
            {
               logic_uScriptAct_ClampInt_Target_7 = local_AddedInt_System_Int32;
               
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
         logic_uScriptAct_ClampInt_uScriptAct_ClampInt_7.In(logic_uScriptAct_ClampInt_Target_7, logic_uScriptAct_ClampInt_Min_7, logic_uScriptAct_ClampInt_Max_7, out logic_uScriptAct_ClampInt_IntResult_7, out logic_uScriptAct_ClampInt_FloatResult_7);
         property_tokens_Detox_ScriptEditor_Parameter_tokens_2 = logic_uScriptAct_ClampInt_IntResult_7;
         property_tokens_Detox_ScriptEditor_Parameter_tokens_2_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Clamp Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d71be2f6-971c-4f42-97ab-deed596cdf84", "Compare_Int", Relay_In_8)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_8 = local_AddedInt_System_Int32;
               
            }
            {
               logic_uScriptCon_CompareInt_B_8 = local_9_System_Int32;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.In(logic_uScriptCon_CompareInt_A_8, logic_uScriptCon_CompareInt_B_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.GreaterThanOrEqualTo;
         bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_11();
         }
         if ( test_1 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("eaf667d9-a69f-45cf-80f3-1760897de40c", "Set_Color", Relay_In_11)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetColor_uScriptAct_SetColor_11.In(logic_uScriptAct_SetColor_Value_11, out logic_uScriptAct_SetColor_TargetColor_11);
         property_color_Detox_ScriptEditor_Parameter_color_12 = logic_uScriptAct_SetColor_TargetColor_11;
         property_color_Detox_ScriptEditor_Parameter_color_12_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_11.Out;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Set Color.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5dc40bfd-2b07-4e74-94e1-3cea30173d43", "Delay", Relay_In_13)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_13.In(logic_uScriptAct_Delay_Duration_13, logic_uScriptAct_Delay_SingleFrame_13);
         logic_uScriptAct_Delay_DrivenDelay_13 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_13.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_14();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5dc40bfd-2b07-4e74-94e1-3cea30173d43", "Delay", Relay_Stop_13)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_13.Stop(logic_uScriptAct_Delay_Duration_13, logic_uScriptAct_Delay_SingleFrame_13);
         logic_uScriptAct_Delay_DrivenDelay_13 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_13.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_14();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_13( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_13 = logic_uScriptAct_Delay_uScriptAct_Delay_13.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_13 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_13.AfterDelay == true )
            {
               Relay_In_14();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8e4a7a97-3f49-47e6-9b31-7a581547ca7b", "Set_Color", Relay_In_14)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetColor_uScriptAct_SetColor_14.In(logic_uScriptAct_SetColor_Value_14, out logic_uScriptAct_SetColor_TargetColor_14);
         property_color_Detox_ScriptEditor_Parameter_color_15 = logic_uScriptAct_SetColor_TargetColor_14;
         property_color_Detox_ScriptEditor_Parameter_color_15_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_14.Out;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Set Color.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7931ad99-d417-4a85-916a-6d5d5125fffe", "Set_Color", Relay_In_17)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetColor_uScriptAct_SetColor_17.In(logic_uScriptAct_SetColor_Value_17, out logic_uScriptAct_SetColor_TargetColor_17);
         property_color_Detox_ScriptEditor_Parameter_color_16 = logic_uScriptAct_SetColor_TargetColor_17;
         property_color_Detox_ScriptEditor_Parameter_color_16_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_17.Out;
         
         if ( test_0 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Set Color.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ad0012e1-254d-48a8-a133-dbaa2dfe3207", "Delay", Relay_In_18)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_18.In(logic_uScriptAct_Delay_Duration_18, logic_uScriptAct_Delay_SingleFrame_18);
         logic_uScriptAct_Delay_DrivenDelay_18 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_18.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ad0012e1-254d-48a8-a133-dbaa2dfe3207", "Delay", Relay_Stop_18)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_18.Stop(logic_uScriptAct_Delay_Duration_18, logic_uScriptAct_Delay_SingleFrame_18);
         logic_uScriptAct_Delay_DrivenDelay_18 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_18.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_18( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_18 = logic_uScriptAct_Delay_uScriptAct_Delay_18.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_18 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_18.AfterDelay == true )
            {
               Relay_In_17();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("50bad8b6-94b4-4882-baff-8b30c57bd147", "Set_Color", Relay_In_20)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetColor_uScriptAct_SetColor_20.In(logic_uScriptAct_SetColor_Value_20, out logic_uScriptAct_SetColor_TargetColor_20);
         property_color_Detox_ScriptEditor_Parameter_color_19 = logic_uScriptAct_SetColor_TargetColor_20;
         property_color_Detox_ScriptEditor_Parameter_color_19_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_20.Out;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Set Color.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b46565aa-32bf-4837-8ece-0185deb09514", "Delay", Relay_In_21)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_21.In(logic_uScriptAct_Delay_Duration_21, logic_uScriptAct_Delay_SingleFrame_21);
         logic_uScriptAct_Delay_DrivenDelay_21 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_21.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b46565aa-32bf-4837-8ece-0185deb09514", "Delay", Relay_Stop_21)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_21.Stop(logic_uScriptAct_Delay_Duration_21, logic_uScriptAct_Delay_SingleFrame_21);
         logic_uScriptAct_Delay_DrivenDelay_21 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_21.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_21( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_21 = logic_uScriptAct_Delay_uScriptAct_Delay_21.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_21 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_21.AfterDelay == true )
            {
               Relay_In_20();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_24()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("384d2683-5a59-46f3-8a89-b976df86b34a", "Clamp_Int", Relay_In_24)) return; 
         {
            {
               logic_uScriptAct_ClampInt_Target_24 = local_AddedInt_System_Int32;
               
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
         logic_uScriptAct_ClampInt_uScriptAct_ClampInt_24.In(logic_uScriptAct_ClampInt_Target_24, logic_uScriptAct_ClampInt_Min_24, logic_uScriptAct_ClampInt_Max_24, out logic_uScriptAct_ClampInt_IntResult_24, out logic_uScriptAct_ClampInt_FloatResult_24);
         property_tokens_Detox_ScriptEditor_Parameter_tokens_22 = logic_uScriptAct_ClampInt_IntResult_24;
         property_tokens_Detox_ScriptEditor_Parameter_tokens_22_Set_Refresh( );
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript AdsForTokens.uscript at Clamp Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "AdsForTokens.uscript:1", local_1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "80161558-f72f-421f-8275-fb6ab556c08b", local_1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "AdsForTokens.uscript:AddTokens", AddTokens);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ca5394b6-305a-4991-90ad-5969f5d9c0e4", AddTokens);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "AdsForTokens.uscript:9", local_9_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a835ec94-d764-4f3b-adc4-4d4a2e06400b", local_9_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "AdsForTokens.uscript:AddedInt", local_AddedInt_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "85108580-ee1a-459f-8b30-fb04fde4b4f6", local_AddedInt_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7543eacb-6f06-4114-b701-c1739ca2c2b6", property_tokens_Detox_ScriptEditor_Parameter_tokens_2_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "535cec07-91ad-486b-8422-0b8a0555dbed", property_tokens_Detox_ScriptEditor_Parameter_tokens_5_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f3972ad6-4897-42b2-a6b7-bc4479cf1a69", property_color_Detox_ScriptEditor_Parameter_color_12_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f8a259fb-1b99-43cd-ba0a-3fb391cc653d", property_color_Detox_ScriptEditor_Parameter_color_15_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "603eb4b6-2ded-4603-a49f-95c9ca877e93", property_color_Detox_ScriptEditor_Parameter_color_16_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b3c19966-4d15-4836-b37d-ab361d14a58f", property_color_Detox_ScriptEditor_Parameter_color_19_Get_Refresh());
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cbc95856-5366-4b79-84ed-2fb97667c3d8", property_tokens_Detox_ScriptEditor_Parameter_tokens_22_Get_Refresh());
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
