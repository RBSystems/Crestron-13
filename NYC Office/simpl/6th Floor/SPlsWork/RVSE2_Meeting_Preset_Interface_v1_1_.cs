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

namespace UserModule_RVSE2_MEETING_PRESET_INTERFACE_V1_1_
{
    public class UserModuleClass_RVSE2_MEETING_PRESET_INTERFACE_V1_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput SCHEDINTERWORK_MOD_CONNECTED;
        Crestron.Logos.SplusObjects.DigitalInput START_MEETING;
        Crestron.Logos.SplusObjects.DigitalInput END_MEETING;
        Crestron.Logos.SplusObjects.BufferInput FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_START_MEETING_BUTTON;
        Crestron.Logos.SplusObjects.AnalogOutput PRESET_SLOT;
        Crestron.Logos.SplusObjects.StringOutput TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput START_MEETING_BUTTON_LABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_IMAGE1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_IMAGE2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_WELCOME_MSG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_NAME__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PRESET_FIELD_SLOT_LABEL__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PRESET_FIELD_SLOT_VALUE__DOLLAR__;
        PRESETDATA [] PRESET;
        ushort G_BRXOK1 = 0;
        private CrestronString FORMATTIME (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            ushort IHOUR = 0;
            ushort IMINUTE = 0;
            
            CrestronString SHOUR;
            CrestronString SMINUTE;
            CrestronString SAMPM;
            SHOUR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            SMINUTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            SAMPM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 159;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 161;
                Trace( "\r\n*** FormatTime ***\r\n") ; 
                __context__.SourceCodeLine = 162;
                Trace( "  sData:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 165;
            IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 166;
            IMINUTE = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 168;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 170;
                SAMPM  .UpdateValue ( "AM"  ) ; 
                __context__.SourceCodeLine = 172;
                SHOUR  .UpdateValue ( "12"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 174;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IHOUR > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IHOUR < 12 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 176;
                    SAMPM  .UpdateValue ( "AM"  ) ; 
                    __context__.SourceCodeLine = 178;
                    SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 180;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 12))  ) ) 
                        { 
                        __context__.SourceCodeLine = 182;
                        SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                        __context__.SourceCodeLine = 183;
                        SAMPM  .UpdateValue ( "PM"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 187;
                        SAMPM  .UpdateValue ( "PM"  ) ; 
                        __context__.SourceCodeLine = 188;
                        IHOUR = (ushort) ( (IHOUR - 12) ) ; 
                        __context__.SourceCodeLine = 190;
                        SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                        } 
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 193;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMINUTE < 10 ))  ) ) 
                {
                __context__.SourceCodeLine = 194;
                SMINUTE  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IMINUTE ) )  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 196;
                SMINUTE  .UpdateValue ( Functions.ItoA (  (int) ( IMINUTE ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 198;
            STIME  .UpdateValue ( SHOUR + ":" + SMINUTE + " " + SAMPM  ) ; 
            __context__.SourceCodeLine = 200;
            return ( STIME ) ; 
            
            }
            
        private void CLEARPRESETDATA (  SplusExecutionContext __context__, ushort IPRESET ) 
            { 
            
            __context__.SourceCodeLine = 206;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 208;
                Trace( "\r\n*** ClearPresetData ***\r\n") ; 
                __context__.SourceCodeLine = 209;
                Trace( "  iPreset:{0:d}\r\n", (ushort)IPRESET) ; 
                } 
            
            __context__.SourceCodeLine = 212;
            PRESET [ IPRESET] . EVENTINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 214;
            PRESET [ IPRESET] . MEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 216;
            PRESET [ IPRESET] . STARTDATE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 217;
            PRESET [ IPRESET] . STARTTIME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 219;
            PRESET [ IPRESET] . WELCOMEMESSAGE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 221;
            PRESET [ IPRESET] . IMAGESOURCE1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 222;
            PRESET [ IPRESET] . IMAGESOURCE2  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 224;
            PRESET [ IPRESET] . SLOT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 225;
            PRESET [ IPRESET] . NAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 227;
            PRESET [ IPRESET] . FIELDSLOT1LABEL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 228;
            PRESET [ IPRESET] . FIELDSLOT1VALUE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 230;
            PRESET [ IPRESET] . FIELDSLOT2LABEL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 231;
            PRESET [ IPRESET] . FIELDSLOT2VALUE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 233;
            PRESET [ IPRESET] . FIELDSLOT3LABEL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 234;
            PRESET [ IPRESET] . FIELDSLOT3VALUE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 236;
            PRESET [ IPRESET] . FIELDSLOT4LABEL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 237;
            PRESET [ IPRESET] . FIELDSLOT4VALUE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 239;
            PRESET [ IPRESET] . FIELDSLOT5LABEL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 240;
            PRESET [ IPRESET] . FIELDSLOT5VALUE  .UpdateValue ( ""  ) ; 
            
            }
            
        private void PROCESSPRESETDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            ushort IMARKER1 = 0;
            ushort IMARKER2 = 0;
            ushort IFIELDSLOT = 0;
            
            CrestronString SREMOVED;
            CrestronString STEMP;
            CrestronString SFIELDLABEL;
            CrestronString SFIELDVALUE;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SFIELDLABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SFIELDVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 254;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 255;
                Trace( "\r\n*** ProcessPresetData ***\r\n") ; 
                }
            
            __context__.SourceCodeLine = 258;
            CLEARPRESETDATA (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 260;
            do 
                { 
                __context__.SourceCodeLine = 262;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 264;
                if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingPresets>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 268;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 270;
                        Trace( "  End of preset found.\r\n") ; 
                        __context__.SourceCodeLine = 271;
                        Trace( "   StartDate:{0}\r\n", PRESET [ 1] . STARTDATE ) ; 
                        __context__.SourceCodeLine = 272;
                        Trace( "   StartTime:{0}\r\n", PRESET [ 1] . STARTTIME ) ; 
                        __context__.SourceCodeLine = 273;
                        Trace( "   ImageSource1:{0}\r\n", PRESET [ 1] . IMAGESOURCE1 ) ; 
                        __context__.SourceCodeLine = 274;
                        Trace( "   ImageSource2:{0}\r\n", PRESET [ 1] . IMAGESOURCE2 ) ; 
                        __context__.SourceCodeLine = 275;
                        Trace( "   Slot:{0:d}\r\n", (ushort)PRESET[ 1 ].SLOT) ; 
                        __context__.SourceCodeLine = 276;
                        Trace( "   Name:{0}\r\n", PRESET [ 1] . NAME ) ; 
                        __context__.SourceCodeLine = 277;
                        Trace( "   Field1Label:{0}\r\n", PRESET [ 1] . FIELDSLOT1LABEL ) ; 
                        __context__.SourceCodeLine = 278;
                        Trace( "   Field1Value:{0}\r\n", PRESET [ 1] . FIELDSLOT1VALUE ) ; 
                        __context__.SourceCodeLine = 279;
                        Trace( "   Field2Label:{0}\r\n", PRESET [ 1] . FIELDSLOT2LABEL ) ; 
                        __context__.SourceCodeLine = 280;
                        Trace( "   Field2Value:{0}\r\n", PRESET [ 1] . FIELDSLOT2VALUE ) ; 
                        __context__.SourceCodeLine = 281;
                        Trace( "   Field3Label:{0}\r\n", PRESET [ 1] . FIELDSLOT3LABEL ) ; 
                        __context__.SourceCodeLine = 282;
                        Trace( "   Field3Value:{0}\r\n", PRESET [ 1] . FIELDSLOT3VALUE ) ; 
                        __context__.SourceCodeLine = 283;
                        Trace( "   Field4Label:{0}\r\n", PRESET [ 1] . FIELDSLOT4LABEL ) ; 
                        __context__.SourceCodeLine = 284;
                        Trace( "   Field4Value:{0}\r\n", PRESET [ 1] . FIELDSLOT4VALUE ) ; 
                        __context__.SourceCodeLine = 285;
                        Trace( "   Field5Label:{0}\r\n", PRESET [ 1] . FIELDSLOT5LABEL ) ; 
                        __context__.SourceCodeLine = 286;
                        Trace( "   Field5Value:{0}\r\n", PRESET [ 1] . FIELDSLOT5VALUE ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 290;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET[ 1 ].SLOT > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 295;
                        ENABLE_START_MEETING_BUTTON  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 298;
                        START_MEETING_BUTTON_LABEL__DOLLAR__  .UpdateValue ( "Start " + PRESET [ 1] . STARTTIME + "\r" + "Meeting"  ) ; 
                        __context__.SourceCodeLine = 301;
                        PRESET_IMAGE1__DOLLAR__  .UpdateValue ( PRESET [ 1] . IMAGESOURCE1  ) ; 
                        __context__.SourceCodeLine = 302;
                        PRESET_IMAGE2__DOLLAR__  .UpdateValue ( PRESET [ 1] . IMAGESOURCE2  ) ; 
                        __context__.SourceCodeLine = 305;
                        PRESET_WELCOME_MSG__DOLLAR__  .UpdateValue ( PRESET [ 1] . WELCOMEMESSAGE  ) ; 
                        __context__.SourceCodeLine = 308;
                        PRESET_SLOT  .Value = (ushort) ( PRESET[ 1 ].SLOT ) ; 
                        __context__.SourceCodeLine = 311;
                        PRESET_NAME__DOLLAR__  .UpdateValue ( PRESET [ 1] . NAME  ) ; 
                        __context__.SourceCodeLine = 314;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 1]  .UpdateValue ( PRESET [ 1] . FIELDSLOT1LABEL  ) ; 
                        __context__.SourceCodeLine = 315;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 2]  .UpdateValue ( PRESET [ 1] . FIELDSLOT2LABEL  ) ; 
                        __context__.SourceCodeLine = 316;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 3]  .UpdateValue ( PRESET [ 1] . FIELDSLOT3LABEL  ) ; 
                        __context__.SourceCodeLine = 317;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 4]  .UpdateValue ( PRESET [ 1] . FIELDSLOT4LABEL  ) ; 
                        __context__.SourceCodeLine = 318;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 5]  .UpdateValue ( PRESET [ 1] . FIELDSLOT5LABEL  ) ; 
                        __context__.SourceCodeLine = 321;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 1]  .UpdateValue ( PRESET [ 1] . FIELDSLOT1VALUE  ) ; 
                        __context__.SourceCodeLine = 322;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 2]  .UpdateValue ( PRESET [ 1] . FIELDSLOT2VALUE  ) ; 
                        __context__.SourceCodeLine = 323;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 3]  .UpdateValue ( PRESET [ 1] . FIELDSLOT3VALUE  ) ; 
                        __context__.SourceCodeLine = 324;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 4]  .UpdateValue ( PRESET [ 1] . FIELDSLOT4VALUE  ) ; 
                        __context__.SourceCodeLine = 325;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 5]  .UpdateValue ( PRESET [ 1] . FIELDSLOT5VALUE  ) ; 
                        __context__.SourceCodeLine = 328;
                        TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<WelcomeMsg>" + PRESET [ 1] . WELCOMEMESSAGE + "</WelcomeMsg>"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 336;
                        ENABLE_START_MEETING_BUTTON  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 339;
                        START_MEETING_BUTTON_LABEL__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 342;
                        PRESET_IMAGE1__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 343;
                        PRESET_IMAGE2__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 346;
                        PRESET_WELCOME_MSG__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 349;
                        PRESET_SLOT  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 352;
                        PRESET_NAME__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 355;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 1]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 356;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 2]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 357;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 3]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 358;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 4]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 359;
                        PRESET_FIELD_SLOT_LABEL__DOLLAR__ [ 5]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 362;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 1]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 363;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 2]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 364;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 3]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 365;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 4]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 366;
                        PRESET_FIELD_SLOT_VALUE__DOLLAR__ [ 5]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 369;
                        TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<WelcomeMsg></WelcomeMsg>"  ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 373;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</EventIndex>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 377;
                        PRESET [ 1] . EVENTINDEX = (ushort) ( Functions.Atoi( Functions.Left( SREMOVED , (int)( (Functions.Length( SREMOVED ) - 13) ) ) ) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 379;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</StartDate>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 383;
                            PRESET [ 1] . STARTDATE  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 12) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 385;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</StartTime>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 389;
                                PRESET [ 1] . STARTTIME  .UpdateValue ( FORMATTIME (  __context__ , Functions.Left( SREMOVED , (int)( (Functions.Length( SREMOVED ) - 12) ) ))  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 391;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</WelcomeMessage>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 396;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREMOVED ) > (150 + 17) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 400;
                                        SREMOVED  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (150 - 4) ) )  ) ; 
                                        __context__.SourceCodeLine = 401;
                                        SREMOVED  .UpdateValue ( SREMOVED + " ..."  ) ; 
                                        __context__.SourceCodeLine = 403;
                                        PRESET [ 1] . WELCOMEMESSAGE  .UpdateValue ( SREMOVED  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 406;
                                        PRESET [ 1] . WELCOMEMESSAGE  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 17) ) )  ) ; 
                                        }
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 408;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ImageSource1>" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 412;
                                        PRESET [ 1] . IMAGESOURCE1  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 15) ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 414;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</ImageSource2>" , SREMOVED ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 418;
                                            PRESET [ 1] . IMAGESOURCE2  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 15) ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 420;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Preset Slot" , SREMOVED ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 426;
                                                IMARKER1 = (ushort) ( (Functions.Find( "Slot=" , SREMOVED ) + 6) ) ; 
                                                __context__.SourceCodeLine = 427;
                                                IMARKER2 = (ushort) ( Functions.Find( "\u0022" , SREMOVED , IMARKER1 ) ) ; 
                                                __context__.SourceCodeLine = 429;
                                                PRESET [ 1] . SLOT = (ushort) ( Functions.Atoi( Functions.Mid( SREMOVED , (int)( IMARKER1 ) , (int)( 1 ) ) ) ) ; 
                                                __context__.SourceCodeLine = 432;
                                                IMARKER1 = (ushort) ( (Functions.Find( "Name=" , SREMOVED ) + 6) ) ; 
                                                __context__.SourceCodeLine = 433;
                                                IMARKER2 = (ushort) ( Functions.Find( "\u0022" , SREMOVED , IMARKER1 ) ) ; 
                                                __context__.SourceCodeLine = 435;
                                                PRESET [ 1] . NAME  .UpdateValue ( Functions.Mid ( SREMOVED ,  (int) ( IMARKER1 ) ,  (int) ( (IMARKER2 - IMARKER1) ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 437;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<Field Slot" , SREMOVED ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 443;
                                                    IMARKER1 = (ushort) ( (Functions.Find( "Slot=" , SREMOVED ) + 6) ) ; 
                                                    __context__.SourceCodeLine = 444;
                                                    IMARKER2 = (ushort) ( Functions.Find( "\u0022" , SREMOVED , IMARKER1 ) ) ; 
                                                    __context__.SourceCodeLine = 446;
                                                    IFIELDSLOT = (ushort) ( Functions.Atoi( Functions.Mid( SREMOVED , (int)( IMARKER1 ) , (int)( 1 ) ) ) ) ; 
                                                    __context__.SourceCodeLine = 449;
                                                    IMARKER1 = (ushort) ( (Functions.Find( "Label=" , SREMOVED ) + 7) ) ; 
                                                    __context__.SourceCodeLine = 450;
                                                    IMARKER2 = (ushort) ( Functions.Find( "\u0022" , SREMOVED , IMARKER1 ) ) ; 
                                                    __context__.SourceCodeLine = 452;
                                                    SFIELDLABEL  .UpdateValue ( Functions.Mid ( SREMOVED ,  (int) ( IMARKER1 ) ,  (int) ( (IMARKER2 - IMARKER1) ) )  ) ; 
                                                    __context__.SourceCodeLine = 455;
                                                    IMARKER1 = (ushort) ( (Functions.Find( "Value=" , SREMOVED ) + 7) ) ; 
                                                    __context__.SourceCodeLine = 456;
                                                    IMARKER2 = (ushort) ( Functions.Find( "\u0022" , SREMOVED , IMARKER1 ) ) ; 
                                                    __context__.SourceCodeLine = 458;
                                                    SFIELDVALUE  .UpdateValue ( Functions.Mid ( SREMOVED ,  (int) ( IMARKER1 ) ,  (int) ( (IMARKER2 - IMARKER1) ) )  ) ; 
                                                    __context__.SourceCodeLine = 460;
                                                    switch ((int)IFIELDSLOT)
                                                    
                                                        { 
                                                        case 1 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 464;
                                                            PRESET [ 1] . FIELDSLOT1LABEL  .UpdateValue ( SFIELDLABEL  ) ; 
                                                            __context__.SourceCodeLine = 465;
                                                            PRESET [ 1] . FIELDSLOT1VALUE  .UpdateValue ( SFIELDVALUE  ) ; 
                                                            __context__.SourceCodeLine = 467;
                                                            break ; 
                                                            } 
                                                        
                                                        goto case 2 ;
                                                        case 2 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 472;
                                                            PRESET [ 1] . FIELDSLOT2LABEL  .UpdateValue ( SFIELDLABEL  ) ; 
                                                            __context__.SourceCodeLine = 473;
                                                            PRESET [ 1] . FIELDSLOT2VALUE  .UpdateValue ( SFIELDVALUE  ) ; 
                                                            __context__.SourceCodeLine = 475;
                                                            break ; 
                                                            } 
                                                        
                                                        goto case 3 ;
                                                        case 3 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 480;
                                                            PRESET [ 1] . FIELDSLOT3LABEL  .UpdateValue ( SFIELDLABEL  ) ; 
                                                            __context__.SourceCodeLine = 481;
                                                            PRESET [ 1] . FIELDSLOT3VALUE  .UpdateValue ( SFIELDVALUE  ) ; 
                                                            __context__.SourceCodeLine = 483;
                                                            break ; 
                                                            } 
                                                        
                                                        goto case 4 ;
                                                        case 4 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 488;
                                                            PRESET [ 1] . FIELDSLOT4LABEL  .UpdateValue ( SFIELDLABEL  ) ; 
                                                            __context__.SourceCodeLine = 489;
                                                            PRESET [ 1] . FIELDSLOT4VALUE  .UpdateValue ( SFIELDVALUE  ) ; 
                                                            __context__.SourceCodeLine = 491;
                                                            break ; 
                                                            } 
                                                        
                                                        goto case 5 ;
                                                        case 5 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 496;
                                                            PRESET [ 1] . FIELDSLOT5LABEL  .UpdateValue ( SFIELDLABEL  ) ; 
                                                            __context__.SourceCodeLine = 497;
                                                            PRESET [ 1] . FIELDSLOT5VALUE  .UpdateValue ( SFIELDVALUE  ) ; 
                                                            __context__.SourceCodeLine = 499;
                                                            break ; 
                                                            } 
                                                        
                                                        break;
                                                        } 
                                                        
                                                    
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            
            }
            
        object SCHEDINTERWORK_MOD_CONNECTED_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 515;
                TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<MeetingPresetModule>Hello</MeetingPresetModule>"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object START_MEETING_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 521;
            if ( Functions.TestForTrue  ( ( ENABLE_START_MEETING_BUTTON  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 524;
                TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartedEvent>" + Functions.ItoA (  (int) ( PRESET[ 1 ].EVENTINDEX ) ) + "</StartedEvent>"  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object END_MEETING_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 532;
        TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<EndMeeting></EndMeeting>"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString SDATA;
        SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
        
        
        __context__.SourceCodeLine = 540;
        if ( Functions.TestForTrue  ( ( G_BRXOK1)  ) ) 
            { 
            __context__.SourceCodeLine = 542;
            G_BRXOK1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 544;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 546;
                SDATA  .UpdateValue ( Functions.Gather ( "</ScheduleInterfaceData>" , FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 548;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Type=\u0022PresetData\u0022 />" , SDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 550;
                    PROCESSPRESETDATA (  __context__ , SDATA) ; 
                    } 
                
                __context__.SourceCodeLine = 544;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 564;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 566;
        G_BRXOK1 = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    PRESET  = new PRESETDATA[ 3 ];
    for( uint i = 0; i < 3; i++ )
    {
        PRESET [i] = new PRESETDATA( this, true );
        PRESET [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    SCHEDINTERWORK_MOD_CONNECTED = new Crestron.Logos.SplusObjects.DigitalInput( SCHEDINTERWORK_MOD_CONNECTED__DigitalInput__, this );
    m_DigitalInputList.Add( SCHEDINTERWORK_MOD_CONNECTED__DigitalInput__, SCHEDINTERWORK_MOD_CONNECTED );
    
    START_MEETING = new Crestron.Logos.SplusObjects.DigitalInput( START_MEETING__DigitalInput__, this );
    m_DigitalInputList.Add( START_MEETING__DigitalInput__, START_MEETING );
    
    END_MEETING = new Crestron.Logos.SplusObjects.DigitalInput( END_MEETING__DigitalInput__, this );
    m_DigitalInputList.Add( END_MEETING__DigitalInput__, END_MEETING );
    
    ENABLE_START_MEETING_BUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_START_MEETING_BUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENABLE_START_MEETING_BUTTON__DigitalOutput__, ENABLE_START_MEETING_BUTTON );
    
    PRESET_SLOT = new Crestron.Logos.SplusObjects.AnalogOutput( PRESET_SLOT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PRESET_SLOT__AnalogSerialOutput__, PRESET_SLOT );
    
    TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR__ );
    
    START_MEETING_BUTTON_LABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( START_MEETING_BUTTON_LABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( START_MEETING_BUTTON_LABEL__DOLLAR____AnalogSerialOutput__, START_MEETING_BUTTON_LABEL__DOLLAR__ );
    
    PRESET_IMAGE1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_IMAGE1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRESET_IMAGE1__DOLLAR____AnalogSerialOutput__, PRESET_IMAGE1__DOLLAR__ );
    
    PRESET_IMAGE2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_IMAGE2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRESET_IMAGE2__DOLLAR____AnalogSerialOutput__, PRESET_IMAGE2__DOLLAR__ );
    
    PRESET_WELCOME_MSG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_WELCOME_MSG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRESET_WELCOME_MSG__DOLLAR____AnalogSerialOutput__, PRESET_WELCOME_MSG__DOLLAR__ );
    
    PRESET_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRESET_NAME__DOLLAR____AnalogSerialOutput__, PRESET_NAME__DOLLAR__ );
    
    PRESET_FIELD_SLOT_LABEL__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        PRESET_FIELD_SLOT_LABEL__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PRESET_FIELD_SLOT_LABEL__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PRESET_FIELD_SLOT_LABEL__DOLLAR____AnalogSerialOutput__ + i, PRESET_FIELD_SLOT_LABEL__DOLLAR__[i+1] );
    }
    
    PRESET_FIELD_SLOT_VALUE__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        PRESET_FIELD_SLOT_VALUE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PRESET_FIELD_SLOT_VALUE__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PRESET_FIELD_SLOT_VALUE__DOLLAR____AnalogSerialOutput__ + i, PRESET_FIELD_SLOT_VALUE__DOLLAR__[i+1] );
    }
    
    FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, 2000, this );
    m_StringInputList.Add( FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR__ );
    
    
    SCHEDINTERWORK_MOD_CONNECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCHEDINTERWORK_MOD_CONNECTED_OnPush_0, false ) );
    START_MEETING.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MEETING_OnPush_1, false ) );
    END_MEETING.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_MEETING_OnPush_2, false ) );
    FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_MEETING_PRESET_INTERFACE_V1_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint SCHEDINTERWORK_MOD_CONNECTED__DigitalInput__ = 1;
const uint START_MEETING__DigitalInput__ = 2;
const uint END_MEETING__DigitalInput__ = 3;
const uint FROM_SCHEDINTERWORK_MOD_DATAOUT__DOLLAR____AnalogSerialInput__ = 0;
const uint ENABLE_START_MEETING_BUTTON__DigitalOutput__ = 0;
const uint PRESET_SLOT__AnalogSerialOutput__ = 0;
const uint TO_SCHEDINTERWORK_MOD_DATAIN__DOLLAR____AnalogSerialOutput__ = 1;
const uint START_MEETING_BUTTON_LABEL__DOLLAR____AnalogSerialOutput__ = 2;
const uint PRESET_IMAGE1__DOLLAR____AnalogSerialOutput__ = 3;
const uint PRESET_IMAGE2__DOLLAR____AnalogSerialOutput__ = 4;
const uint PRESET_WELCOME_MSG__DOLLAR____AnalogSerialOutput__ = 5;
const uint PRESET_NAME__DOLLAR____AnalogSerialOutput__ = 6;
const uint PRESET_FIELD_SLOT_LABEL__DOLLAR____AnalogSerialOutput__ = 7;
const uint PRESET_FIELD_SLOT_VALUE__DOLLAR____AnalogSerialOutput__ = 12;

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

[SplusStructAttribute(-1, true, false)]
public class PRESETDATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  EVENTINDEX = 0;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  MEETINGID;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  STARTDATE;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  STARTTIME;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  IMAGESOURCE1;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  IMAGESOURCE2;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  WELCOMEMESSAGE;
    
    [SplusStructAttribute(7, false, false)]
    public CrestronString  NAME;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  SLOT = 0;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  FIELDSLOT1LABEL;
    
    [SplusStructAttribute(10, false, false)]
    public CrestronString  FIELDSLOT1VALUE;
    
    [SplusStructAttribute(11, false, false)]
    public CrestronString  FIELDSLOT2LABEL;
    
    [SplusStructAttribute(12, false, false)]
    public CrestronString  FIELDSLOT2VALUE;
    
    [SplusStructAttribute(13, false, false)]
    public CrestronString  FIELDSLOT3LABEL;
    
    [SplusStructAttribute(14, false, false)]
    public CrestronString  FIELDSLOT3VALUE;
    
    [SplusStructAttribute(15, false, false)]
    public CrestronString  FIELDSLOT4LABEL;
    
    [SplusStructAttribute(16, false, false)]
    public CrestronString  FIELDSLOT4VALUE;
    
    [SplusStructAttribute(17, false, false)]
    public CrestronString  FIELDSLOT5LABEL;
    
    [SplusStructAttribute(18, false, false)]
    public CrestronString  FIELDSLOT5VALUE;
    
    
    public PRESETDATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        MEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, Owner );
        STARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        STARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, Owner );
        IMAGESOURCE1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, Owner );
        IMAGESOURCE2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, Owner );
        WELCOMEMESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, Owner );
        NAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT1LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT1VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT2LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT2VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT3LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT3VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT4LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT4VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT5LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDSLOT5VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}

}
