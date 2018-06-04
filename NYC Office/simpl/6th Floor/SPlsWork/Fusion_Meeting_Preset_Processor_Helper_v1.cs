using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_FUSION_MEETING_PRESET_PROCESSOR_HELPER_V1
{
    public class UserModuleClass_FUSION_MEETING_PRESET_PROCESSOR_HELPER_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SETUP_MEETING_NOW_B;
        Crestron.Logos.SplusObjects.StringInput FUSION_PRESET_NAME_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> PRESET_NAME_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> PRESET_SLOT_LABEL__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> PRESET_SLOT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput PRESENTATION_SETUP_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIO_CALL_SETUP_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput VIDEO_CALL_SETUP_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIO_VIDEO_CALL_SETUP_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput PRES_AUDIO_VIDEO_CALL_SETUP_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIO_CALL_DIAL_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput VIDEO_CALL_DIAL_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIO_VIDEO_CALL_DIAL_PULSE;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_CALL_NUMBER_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_CALL_PASSCODE_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput VIDEO_CALL_NUMBER_TXT__DOLLAR__;
        UShortParameter DEBUGMODE;
        CrestronString G_SFUSIONPRESETNAME__DOLLAR__;
        CrestronString G_SAUDIOCALLNUMBERSLOTLABEL__DOLLAR__;
        CrestronString G_SAUDIOCALLPASSCODESLOTLABEL__DOLLAR__;
        CrestronString G_SVIDEOCALLNUMBERSLOTLABEL__DOLLAR__;
        CrestronString [] G_SPRESETNAME__DOLLAR__;
        CrestronString [] G_SPRESETSLOTLABEL__DOLLAR__;
        CrestronString [] G_SPRESETSLOTVALUE__DOLLAR__;
        private CrestronString FNFINDAUDIONUMBER (  SplusExecutionContext __context__ ) 
            { 
            ushort J = 0;
            
            CrestronString SAUDIONUMBER__DOLLAR__;
            CrestronString SAUDIONUMBERTEMP__DOLLAR__;
            CrestronString STEMP__DOLLAR__;
            SAUDIONUMBER__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SAUDIONUMBERTEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            
            __context__.SourceCodeLine = 71;
            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 71;
                Print( "Inside fnFindAudioNumber\r\nciMax_Presets_Value_Slots = {0:d}\r\n", (ushort)5) ; 
                }
            
            __context__.SourceCodeLine = 73;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)5; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 75;
                if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 75;
                    Print( "Inside fnFindAudioNumber for loop\r\ng_sPresetSlotLabel$[j] = {0}\r\nAudio_Call_Number_Slot_Label_txt$ = {1}\r\n", G_SPRESETSLOTLABEL__DOLLAR__ [ J ] , AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 76;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SPRESETSLOTLABEL__DOLLAR__[ J ] == AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__))  ) ) 
                    { 
                    __context__.SourceCodeLine = 78;
                    MakeString ( SAUDIONUMBERTEMP__DOLLAR__ , "{0}", G_SPRESETSLOTVALUE__DOLLAR__ [ J ] ) ; 
                    __context__.SourceCodeLine = 79;
                    if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 79;
                        Print( "if(g_sPresetSlotLabel$[j] = Audio_Call_Number_Slot_Label_txt$) = True\r\nsAudioNumberTemp$ = {0}\r\n", SAUDIONUMBERTEMP__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 80;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 73;
                } 
            
            __context__.SourceCodeLine = 84;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "-" , SAUDIONUMBERTEMP__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.Find( "(" , SAUDIONUMBERTEMP__DOLLAR__ ) )) ) ) || Functions.TestForTrue ( Functions.Find( ")" , SAUDIONUMBERTEMP__DOLLAR__ ) )) ) ) || Functions.TestForTrue ( Functions.Find( "." , SAUDIONUMBERTEMP__DOLLAR__ ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 86;
                if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 86;
                    Print( "Audio number contains a -, (, ) or .\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 87;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SAUDIONUMBERTEMP__DOLLAR__ != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 89;
                    STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Left ( SAUDIONUMBERTEMP__DOLLAR__ ,  (int) ( 1 ) ) , SAUDIONUMBERTEMP__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 90;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SAUDIONUMBER__DOLLAR__ == ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 92;
                        MakeString ( SAUDIONUMBER__DOLLAR__ , "{0}", STEMP__DOLLAR__ ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 96;
                        MakeString ( SAUDIONUMBER__DOLLAR__ , "{0}{1}", SAUDIONUMBER__DOLLAR__ , STEMP__DOLLAR__ ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 87;
                    } 
                
                __context__.SourceCodeLine = 99;
                if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 99;
                    Print( "New audio number = {0}\r\n", SAUDIONUMBER__DOLLAR__ ) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 103;
                MakeString ( SAUDIONUMBER__DOLLAR__ , "{0}", SAUDIONUMBERTEMP__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 106;
            return ( SAUDIONUMBER__DOLLAR__ ) ; 
            
            }
            
        private CrestronString FNFINDAUDIOPASSCODE (  SplusExecutionContext __context__ ) 
            { 
            ushort J = 0;
            
            CrestronString SAUDIOPASSCODE__DOLLAR__;
            CrestronString SAUDIOPASSCODETEMP__DOLLAR__;
            CrestronString STEMP__DOLLAR__;
            SAUDIOPASSCODE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SAUDIOPASSCODETEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            
            __context__.SourceCodeLine = 114;
            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 114;
                Print( "Inside fnFindAudioPasscode\r\nciMax_Presets_Value_Slots = {0:d}\r\n", (ushort)5) ; 
                }
            
            __context__.SourceCodeLine = 116;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)5; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 118;
                if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 118;
                    Print( "Inside fnFindAudioPasscode for loop\r\ng_sPresetSlotLabel$[j] = {0}\r\nAudio_Call_Passcode_Slot_Label_txt$ = {1}\r\n", G_SPRESETSLOTLABEL__DOLLAR__ [ J ] , AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 119;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SPRESETSLOTLABEL__DOLLAR__[ J ] == AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__))  ) ) 
                    { 
                    __context__.SourceCodeLine = 121;
                    MakeString ( SAUDIOPASSCODETEMP__DOLLAR__ , "{0}", G_SPRESETSLOTVALUE__DOLLAR__ [ J ] ) ; 
                    __context__.SourceCodeLine = 122;
                    if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 122;
                        Print( "if(g_sPresetSlotLabel$[j] = Audio_Call_Passcode_Slot_Label_txt$) = True\r\nsAudioPasscodeTemp$ = {0}", SAUDIOPASSCODETEMP__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 123;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 116;
                } 
            
            __context__.SourceCodeLine = 127;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "-" , SAUDIOPASSCODETEMP__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.Find( "(" , SAUDIOPASSCODETEMP__DOLLAR__ ) )) ) ) || Functions.TestForTrue ( Functions.Find( ")" , SAUDIOPASSCODETEMP__DOLLAR__ ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 129;
                if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 129;
                    Print( "Audio passcode contains a -, (, ) or .\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 130;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SAUDIOPASSCODETEMP__DOLLAR__ != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 132;
                    STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Left ( SAUDIOPASSCODETEMP__DOLLAR__ ,  (int) ( 1 ) ) , SAUDIOPASSCODETEMP__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 133;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SAUDIOPASSCODE__DOLLAR__ == ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 135;
                        MakeString ( SAUDIOPASSCODE__DOLLAR__ , "{0}", STEMP__DOLLAR__ ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 139;
                        MakeString ( SAUDIOPASSCODE__DOLLAR__ , "{0}{1}", SAUDIOPASSCODE__DOLLAR__ , STEMP__DOLLAR__ ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 130;
                    } 
                
                __context__.SourceCodeLine = 142;
                if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 142;
                    Print( "New audio passcode = {0}\r\n", SAUDIOPASSCODE__DOLLAR__ ) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 146;
                MakeString ( SAUDIOPASSCODE__DOLLAR__ , "{0}", SAUDIOPASSCODETEMP__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 149;
            return ( SAUDIOPASSCODE__DOLLAR__ ) ; 
            
            }
            
        private CrestronString FNFINDVIDEONUMBER (  SplusExecutionContext __context__ ) 
            { 
            ushort J = 0;
            
            CrestronString SVIDEONUMBER__DOLLAR__;
            CrestronString SVIDEONUMBERTEMP__DOLLAR__;
            CrestronString STEMP__DOLLAR__;
            SVIDEONUMBER__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SVIDEONUMBERTEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            
            __context__.SourceCodeLine = 157;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)5; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 159;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SPRESETSLOTLABEL__DOLLAR__[ J ] == VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__))  ) ) 
                    { 
                    __context__.SourceCodeLine = 161;
                    MakeString ( SVIDEONUMBERTEMP__DOLLAR__ , "{0}", G_SPRESETSLOTVALUE__DOLLAR__ [ J ] ) ; 
                    __context__.SourceCodeLine = 162;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 157;
                } 
            
            __context__.SourceCodeLine = 166;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "-" , SVIDEONUMBERTEMP__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.Find( "(" , SVIDEONUMBERTEMP__DOLLAR__ ) )) ) ) || Functions.TestForTrue ( Functions.Find( ")" , SVIDEONUMBERTEMP__DOLLAR__ ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 168;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SVIDEONUMBERTEMP__DOLLAR__ != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Left ( SVIDEONUMBERTEMP__DOLLAR__ ,  (int) ( 1 ) ) , SVIDEONUMBERTEMP__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 171;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SVIDEONUMBER__DOLLAR__ == ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 173;
                        MakeString ( SVIDEONUMBER__DOLLAR__ , "{0}", STEMP__DOLLAR__ ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 177;
                        MakeString ( SVIDEONUMBER__DOLLAR__ , "{0}{1}", SVIDEONUMBER__DOLLAR__ , STEMP__DOLLAR__ ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 168;
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 183;
                MakeString ( SVIDEONUMBER__DOLLAR__ , "{0}", SVIDEONUMBERTEMP__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 186;
            return ( SVIDEONUMBER__DOLLAR__ ) ; 
            
            }
            
        object SETUP_MEETING_NOW_B_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                ushort IPRESET = 0;
                
                
                __context__.SourceCodeLine = 196;
                IPRESET = (ushort) ( 999 ) ; 
                __context__.SourceCodeLine = 198;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)5; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 200;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SFUSIONPRESETNAME__DOLLAR__ == G_SPRESETNAME__DOLLAR__[ I ]))  ) ) 
                        { 
                        __context__.SourceCodeLine = 202;
                        IPRESET = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 203;
                        if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 203;
                            Print( "if(g_sFusionPresetName$ = g_sPresetName$[i]) = True\r\niPreset = {0:d}\r\n", (ushort)IPRESET) ; 
                            }
                        
                        __context__.SourceCodeLine = 204;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 198;
                    } 
                
                __context__.SourceCodeLine = 208;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)IPRESET);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 212;
                            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 212;
                                Print( "case(ciPresentationCase)\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 213;
                            MakeString ( AUDIO_CALL_NUMBER_TXT__DOLLAR__ , "") ; 
                            __context__.SourceCodeLine = 214;
                            MakeString ( AUDIO_CALL_PASSCODE_TXT__DOLLAR__ , "") ; 
                            __context__.SourceCodeLine = 215;
                            MakeString ( VIDEO_CALL_NUMBER_TXT__DOLLAR__ , "") ; 
                            __context__.SourceCodeLine = 216;
                            Functions.Pulse ( 10, PRESENTATION_SETUP_PULSE ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 220;
                            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 220;
                                Print( "case = ciAudioCallCase\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 221;
                            MakeString ( AUDIO_CALL_NUMBER_TXT__DOLLAR__ , "{0}", FNFINDAUDIONUMBER (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 222;
                            MakeString ( AUDIO_CALL_PASSCODE_TXT__DOLLAR__ , "{0}", FNFINDAUDIOPASSCODE (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 223;
                            MakeString ( VIDEO_CALL_NUMBER_TXT__DOLLAR__ , "") ; 
                            __context__.SourceCodeLine = 224;
                            Functions.Pulse ( 10, AUDIO_CALL_SETUP_PULSE ) ; 
                            __context__.SourceCodeLine = 225;
                            Functions.Pulse ( 10, AUDIO_CALL_DIAL_PULSE ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 229;
                            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 229;
                                Print( "case = ciVideoCallCase\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 230;
                            MakeString ( AUDIO_CALL_NUMBER_TXT__DOLLAR__ , "") ; 
                            __context__.SourceCodeLine = 231;
                            MakeString ( AUDIO_CALL_PASSCODE_TXT__DOLLAR__ , "") ; 
                            __context__.SourceCodeLine = 232;
                            MakeString ( VIDEO_CALL_NUMBER_TXT__DOLLAR__ , "{0}", FNFINDVIDEONUMBER (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 233;
                            Functions.Pulse ( 10, VIDEO_CALL_SETUP_PULSE ) ; 
                            __context__.SourceCodeLine = 234;
                            Functions.Pulse ( 10, VIDEO_CALL_DIAL_PULSE ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 238;
                            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 238;
                                Print( "case = ciAudioVideoCallCase\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 239;
                            MakeString ( AUDIO_CALL_NUMBER_TXT__DOLLAR__ , "{0}", FNFINDAUDIONUMBER (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 240;
                            MakeString ( AUDIO_CALL_PASSCODE_TXT__DOLLAR__ , "{0}", FNFINDAUDIOPASSCODE (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 241;
                            MakeString ( VIDEO_CALL_NUMBER_TXT__DOLLAR__ , "{0}", FNFINDVIDEONUMBER (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 242;
                            Functions.Pulse ( 10, AUDIO_VIDEO_CALL_SETUP_PULSE ) ; 
                            __context__.SourceCodeLine = 243;
                            Functions.Pulse ( 10, AUDIO_VIDEO_CALL_DIAL_PULSE ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 247;
                            if ( Functions.TestForTrue  ( ( DEBUGMODE  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 247;
                                Print( "case = ciPresAudioVideoCallCase\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 248;
                            MakeString ( AUDIO_CALL_NUMBER_TXT__DOLLAR__ , "{0}", FNFINDAUDIONUMBER (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 249;
                            MakeString ( AUDIO_CALL_PASSCODE_TXT__DOLLAR__ , "{0}", FNFINDAUDIOPASSCODE (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 250;
                            MakeString ( VIDEO_CALL_NUMBER_TXT__DOLLAR__ , "{0}", FNFINDVIDEONUMBER (  __context__  ) ) ; 
                            __context__.SourceCodeLine = 251;
                            Functions.Pulse ( 10, PRES_AUDIO_VIDEO_CALL_SETUP_PULSE ) ; 
                            __context__.SourceCodeLine = 252;
                            Functions.Pulse ( 10, AUDIO_VIDEO_CALL_DIAL_PULSE ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FUSION_PRESET_NAME_TXT__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 259;
            MakeString ( G_SFUSIONPRESETNAME__DOLLAR__ , "{0}", FUSION_PRESET_NAME_TXT__DOLLAR__ ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 264;
        MakeString ( G_SAUDIOCALLNUMBERSLOTLABEL__DOLLAR__ , "{0}", AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 269;
        MakeString ( G_SAUDIOCALLPASSCODESLOTLABEL__DOLLAR__ , "{0}", AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 274;
        MakeString ( G_SVIDEOCALLNUMBERSLOTLABEL__DOLLAR__ , "{0}", VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_NAME_TXT__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 281;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 282;
        MakeString ( G_SPRESETNAME__DOLLAR__ [ I ] , "{0}", PRESET_NAME_TXT__DOLLAR__ [ I ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_SLOT_LABEL__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 289;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 290;
        MakeString ( G_SPRESETSLOTLABEL__DOLLAR__ [ I ] , "{0}", PRESET_SLOT_LABEL__DOLLAR__ [ I ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_SLOT_VALUE__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 297;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 298;
        MakeString ( G_SPRESETSLOTVALUE__DOLLAR__ [ I ] , "{0}", PRESET_SLOT_VALUE__DOLLAR__ [ I ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 307;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 309;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 311;
        MakeString ( G_SFUSIONPRESETNAME__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 312;
        MakeString ( G_SAUDIOCALLNUMBERSLOTLABEL__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 313;
        MakeString ( G_SAUDIOCALLPASSCODESLOTLABEL__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 314;
        MakeString ( G_SVIDEOCALLNUMBERSLOTLABEL__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 316;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I < 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 318;
            MakeString ( G_SPRESETSLOTLABEL__DOLLAR__ [ I ] , "") ; 
            __context__.SourceCodeLine = 319;
            MakeString ( G_SPRESETSLOTVALUE__DOLLAR__ [ I ] , "") ; 
            __context__.SourceCodeLine = 320;
            I = (ushort) ( (I + 1) ) ; 
            __context__.SourceCodeLine = 316;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SFUSIONPRESETNAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    G_SAUDIOCALLNUMBERSLOTLABEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    G_SAUDIOCALLPASSCODESLOTLABEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    G_SVIDEOCALLNUMBERSLOTLABEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    G_SPRESETNAME__DOLLAR__  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        G_SPRESETNAME__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    G_SPRESETSLOTLABEL__DOLLAR__  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        G_SPRESETSLOTLABEL__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    G_SPRESETSLOTVALUE__DOLLAR__  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        G_SPRESETSLOTVALUE__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    SETUP_MEETING_NOW_B = new Crestron.Logos.SplusObjects.DigitalInput( SETUP_MEETING_NOW_B__DigitalInput__, this );
    m_DigitalInputList.Add( SETUP_MEETING_NOW_B__DigitalInput__, SETUP_MEETING_NOW_B );
    
    PRESENTATION_SETUP_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( PRESENTATION_SETUP_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( PRESENTATION_SETUP_PULSE__DigitalOutput__, PRESENTATION_SETUP_PULSE );
    
    AUDIO_CALL_SETUP_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIO_CALL_SETUP_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIO_CALL_SETUP_PULSE__DigitalOutput__, AUDIO_CALL_SETUP_PULSE );
    
    VIDEO_CALL_SETUP_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( VIDEO_CALL_SETUP_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( VIDEO_CALL_SETUP_PULSE__DigitalOutput__, VIDEO_CALL_SETUP_PULSE );
    
    AUDIO_VIDEO_CALL_SETUP_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIO_VIDEO_CALL_SETUP_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIO_VIDEO_CALL_SETUP_PULSE__DigitalOutput__, AUDIO_VIDEO_CALL_SETUP_PULSE );
    
    PRES_AUDIO_VIDEO_CALL_SETUP_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( PRES_AUDIO_VIDEO_CALL_SETUP_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( PRES_AUDIO_VIDEO_CALL_SETUP_PULSE__DigitalOutput__, PRES_AUDIO_VIDEO_CALL_SETUP_PULSE );
    
    AUDIO_CALL_DIAL_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIO_CALL_DIAL_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIO_CALL_DIAL_PULSE__DigitalOutput__, AUDIO_CALL_DIAL_PULSE );
    
    VIDEO_CALL_DIAL_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( VIDEO_CALL_DIAL_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( VIDEO_CALL_DIAL_PULSE__DigitalOutput__, VIDEO_CALL_DIAL_PULSE );
    
    AUDIO_VIDEO_CALL_DIAL_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIO_VIDEO_CALL_DIAL_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIO_VIDEO_CALL_DIAL_PULSE__DigitalOutput__, AUDIO_VIDEO_CALL_DIAL_PULSE );
    
    FUSION_PRESET_NAME_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FUSION_PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FUSION_PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__, FUSION_PRESET_NAME_TXT__DOLLAR__ );
    
    AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__, AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ );
    
    AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__, AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__ );
    
    VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__, VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__ );
    
    PRESET_NAME_TXT__DOLLAR__ = new InOutArray<StringInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        PRESET_NAME_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__ + i, PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__, 100, this );
        m_StringInputList.Add( PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__ + i, PRESET_NAME_TXT__DOLLAR__[i+1] );
    }
    
    PRESET_SLOT_LABEL__DOLLAR__ = new InOutArray<StringInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        PRESET_SLOT_LABEL__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( PRESET_SLOT_LABEL__DOLLAR____AnalogSerialInput__ + i, PRESET_SLOT_LABEL__DOLLAR____AnalogSerialInput__, 100, this );
        m_StringInputList.Add( PRESET_SLOT_LABEL__DOLLAR____AnalogSerialInput__ + i, PRESET_SLOT_LABEL__DOLLAR__[i+1] );
    }
    
    PRESET_SLOT_VALUE__DOLLAR__ = new InOutArray<StringInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        PRESET_SLOT_VALUE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( PRESET_SLOT_VALUE__DOLLAR____AnalogSerialInput__ + i, PRESET_SLOT_VALUE__DOLLAR____AnalogSerialInput__, 100, this );
        m_StringInputList.Add( PRESET_SLOT_VALUE__DOLLAR____AnalogSerialInput__ + i, PRESET_SLOT_VALUE__DOLLAR__[i+1] );
    }
    
    AUDIO_CALL_NUMBER_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_CALL_NUMBER_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_CALL_NUMBER_TXT__DOLLAR____AnalogSerialOutput__, AUDIO_CALL_NUMBER_TXT__DOLLAR__ );
    
    AUDIO_CALL_PASSCODE_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_CALL_PASSCODE_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_CALL_PASSCODE_TXT__DOLLAR____AnalogSerialOutput__, AUDIO_CALL_PASSCODE_TXT__DOLLAR__ );
    
    VIDEO_CALL_NUMBER_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( VIDEO_CALL_NUMBER_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( VIDEO_CALL_NUMBER_TXT__DOLLAR____AnalogSerialOutput__, VIDEO_CALL_NUMBER_TXT__DOLLAR__ );
    
    DEBUGMODE = new UShortParameter( DEBUGMODE__Parameter__, this );
    m_ParameterList.Add( DEBUGMODE__Parameter__, DEBUGMODE );
    
    
    SETUP_MEETING_NOW_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETUP_MEETING_NOW_B_OnPush_0, false ) );
    FUSION_PRESET_NAME_TXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FUSION_PRESET_NAME_TXT__DOLLAR___OnChange_1, false ) );
    AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR___OnChange_2, false ) );
    AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR___OnChange_3, false ) );
    VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR___OnChange_4, false ) );
    for( uint i = 0; i < 5; i++ )
        PRESET_NAME_TXT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( PRESET_NAME_TXT__DOLLAR___OnChange_5, false ) );
        
    for( uint i = 0; i < 5; i++ )
        PRESET_SLOT_LABEL__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( PRESET_SLOT_LABEL__DOLLAR___OnChange_6, false ) );
        
    for( uint i = 0; i < 5; i++ )
        PRESET_SLOT_VALUE__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( PRESET_SLOT_VALUE__DOLLAR___OnChange_7, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_FUSION_MEETING_PRESET_PROCESSOR_HELPER_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SETUP_MEETING_NOW_B__DigitalInput__ = 0;
const uint FUSION_PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__ = 0;
const uint AUDIO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__ = 1;
const uint AUDIO_CALL_PASSCODE_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__ = 2;
const uint VIDEO_CALL_NUMBER_SLOT_LABEL_TXT__DOLLAR____AnalogSerialInput__ = 3;
const uint PRESET_NAME_TXT__DOLLAR____AnalogSerialInput__ = 4;
const uint PRESET_SLOT_LABEL__DOLLAR____AnalogSerialInput__ = 9;
const uint PRESET_SLOT_VALUE__DOLLAR____AnalogSerialInput__ = 14;
const uint PRESENTATION_SETUP_PULSE__DigitalOutput__ = 0;
const uint AUDIO_CALL_SETUP_PULSE__DigitalOutput__ = 1;
const uint VIDEO_CALL_SETUP_PULSE__DigitalOutput__ = 2;
const uint AUDIO_VIDEO_CALL_SETUP_PULSE__DigitalOutput__ = 3;
const uint PRES_AUDIO_VIDEO_CALL_SETUP_PULSE__DigitalOutput__ = 4;
const uint AUDIO_CALL_DIAL_PULSE__DigitalOutput__ = 5;
const uint VIDEO_CALL_DIAL_PULSE__DigitalOutput__ = 6;
const uint AUDIO_VIDEO_CALL_DIAL_PULSE__DigitalOutput__ = 7;
const uint AUDIO_CALL_NUMBER_TXT__DOLLAR____AnalogSerialOutput__ = 0;
const uint AUDIO_CALL_PASSCODE_TXT__DOLLAR____AnalogSerialOutput__ = 1;
const uint VIDEO_CALL_NUMBER_TXT__DOLLAR____AnalogSerialOutput__ = 2;
const uint DEBUGMODE__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
