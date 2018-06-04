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

namespace UserModule_BIAMP_TESIRA_LEVEL_CONTROL_V1_7
{
    public class UserModuleClass_BIAMP_TESIRA_LEVEL_CONTROL_V1_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_LEVEL;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_UP;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEW_LEVEL;
        Crestron.Logos.SplusObjects.AnalogInput NEW_LEVEL;
        Crestron.Logos.SplusObjects.BufferInput FROM_PROCESSOR__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_GAUGE;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_LEVEL_SIGNED_UNSCALED;
        Crestron.Logos.SplusObjects.StringOutput VOLUME_LEVEL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TO_PROCESSOR__DOLLAR__;
        StringParameter INSTANCETAG;
        StringParameter LEVELTYPE;
        UShortParameter INDEX1;
        UShortParameter INDEX2;
        UShortParameter LEVEL_STEP;
        ushort MYID = 0;
        ushort MYCLASSCODE = 0;
        short MYLEVELVALUE = 0;
        short MYMAXLEVELVALUE = 0;
        short MYMINLEVELVALUE = 0;
        ushort PARSINGMODULEBUSY = 0;
        CrestronString PARSEDMODULEMSG;
        ushort RESPONSEMODULEMSGID = 0;
        CrestronString RESPONSEREQUESTMSG;
        CrestronString RESPONSEMSG;
        CrestronString PARSEVALUE;
        ushort HASSUBSCRIPTIONREGISTERED = 0;
        CrestronString TRASH;
        private CrestronString GETBOUNDSTRING (  SplusExecutionContext __context__, CrestronString SOURCE , CrestronString STARTSTRING , CrestronString ENDSTRING ) 
            { 
            ushort STARTINDEX = 0;
            
            ushort ENDINDEX = 0;
            
            CrestronString RESPONSE;
            RESPONSE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 184;
            RESPONSE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 186;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SOURCE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 188;
                STARTINDEX = (ushort) ( Functions.Find( STARTSTRING , SOURCE ) ) ; 
                __context__.SourceCodeLine = 189;
                ENDINDEX = (ushort) ( Functions.Find( ENDSTRING , SOURCE , (STARTINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 191;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( STARTINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( STARTINDEX < ENDINDEX ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 193;
                    STARTINDEX = (ushort) ( (STARTINDEX + Functions.Length( STARTSTRING )) ) ; 
                    __context__.SourceCodeLine = 195;
                    RESPONSE  .UpdateValue ( Functions.Mid ( SOURCE ,  (int) ( STARTINDEX ) ,  (int) ( (ENDINDEX - STARTINDEX) ) )  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 199;
            return ( RESPONSE ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 209;
            MSG  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 211;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INDEX1  .Value > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INDEX2  .Value > 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 212;
                MakeString ( MSG , "{0} {1} {2} {3:d} {4:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX1  .Value, (short)INDEX2  .Value) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 213;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INDEX1  .Value > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (INDEX2  .Value == 0) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 214;
                    MakeString ( MSG , "{0} {1} {2} {3:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX1  .Value) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 215;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (INDEX1  .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( INDEX2  .Value > 0 ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 216;
                        MakeString ( MSG , "{0} {1} {2} {3:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX2  .Value) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 218;
                        MakeString ( MSG , "{0} {1} {2}", INSTANCETAG , COMMAND , CONTROL ) ; 
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 220;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHSTRINGVALUE (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL , CrestronString VALUE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 227;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , COMMAND, CONTROL)  ) ; 
            __context__.SourceCodeLine = 229;
            MakeString ( MSG , "{0} {1}", MSG , VALUE ) ; 
            __context__.SourceCodeLine = 231;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHINTEGERVALUE (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL , ushort VALUE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 238;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , COMMAND, CONTROL)  ) ; 
            __context__.SourceCodeLine = 240;
            MakeString ( MSG , "{0} {1:d}", MSG , (short)VALUE) ; 
            __context__.SourceCodeLine = 242;
            return ( MSG ) ; 
            
            }
            
        private void GETALIAS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString OUTGOINGMSG;
            OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 251;
            MakeString ( OUTGOINGMSG , "SESSION get alias {0}", INSTANCETAG ) ; 
            __context__.SourceCodeLine = 252;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            
            }
            
        private void GETINITIALIZED (  SplusExecutionContext __context__ ) 
            { 
            CrestronString OUTGOINGMSG;
            OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            CrestronString SUBSCRIBEOBJECT;
            SUBSCRIBEOBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 260;
            HASSUBSCRIPTIONREGISTERED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 262;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)MYCLASSCODE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1024) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 266;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 268;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 269;
                            MYMAXLEVELVALUE = (short) ( 12 ) ; 
                            __context__.SourceCodeLine = 271;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 272;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1025) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 277;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 279;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 280;
                            MYMAXLEVELVALUE = (short) ( 12 ) ; 
                            __context__.SourceCodeLine = 282;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 283;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1027) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 288;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 290;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 291;
                            MYMAXLEVELVALUE = (short) ( 12 ) ; 
                            __context__.SourceCodeLine = 293;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 294;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1028) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 299;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 301;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 302;
                            MYMAXLEVELVALUE = (short) ( 0 ) ; 
                            __context__.SourceCodeLine = 304;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 305;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1030) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 310;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 312;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 313;
                            MYMAXLEVELVALUE = (short) ( 12 ) ; 
                            __context__.SourceCodeLine = 315;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 316;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1031) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 321;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 323;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 324;
                            MYMAXLEVELVALUE = (short) ( 0 ) ; 
                            __context__.SourceCodeLine = 326;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 327;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1537) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 332;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "inputLevel"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 334;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "inputMaxLevel")  ) ; 
                            __context__.SourceCodeLine = 335;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 337;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "inputMinLevel")  ) ; 
                            __context__.SourceCodeLine = 338;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 340;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 341;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 343;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "outputLevel"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 345;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "outputMaxLevel")  ) ; 
                                __context__.SourceCodeLine = 346;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 348;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "outputMinLevel")  ) ; 
                                __context__.SourceCodeLine = 349;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 351;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                __context__.SourceCodeLine = 352;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1538) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 357;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "inputLevel"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 359;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "inputMaxLevel")  ) ; 
                            __context__.SourceCodeLine = 360;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 362;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "inputMinLevel")  ) ; 
                            __context__.SourceCodeLine = 363;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 365;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 366;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 368;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "outputLevel"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 370;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "outputMaxLevel")  ) ; 
                                __context__.SourceCodeLine = 371;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 373;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "outputMinLevel")  ) ; 
                                __context__.SourceCodeLine = 374;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 376;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                __context__.SourceCodeLine = 377;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 379;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "crosspointLevel"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 381;
                                    MYMAXLEVELVALUE = (short) ( 0 ) ; 
                                    __context__.SourceCodeLine = 382;
                                    MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                                    __context__.SourceCodeLine = 384;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                    __context__.SourceCodeLine = 385;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1047) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 390;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "hostMasterVol"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 392;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 393;
                            MYMAXLEVELVALUE = (short) ( 12 ) ; 
                            __context__.SourceCodeLine = 395;
                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                            __context__.SourceCodeLine = 397;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                            __context__.SourceCodeLine = 398;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 400;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 401;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 403;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "hostVol"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 405;
                                MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                                __context__.SourceCodeLine = 406;
                                MYMAXLEVELVALUE = (short) ( 12 ) ; 
                                __context__.SourceCodeLine = 408;
                                MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                                __context__.SourceCodeLine = 410;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                                __context__.SourceCodeLine = 411;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 413;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                __context__.SourceCodeLine = 414;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1048) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 419;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "hostMasterVol"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 421;
                            MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                            __context__.SourceCodeLine = 422;
                            MYMAXLEVELVALUE = (short) ( 0 ) ; 
                            __context__.SourceCodeLine = 424;
                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                            __context__.SourceCodeLine = 426;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                            __context__.SourceCodeLine = 427;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 429;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 430;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 432;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "hostVol"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 434;
                                MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
                                __context__.SourceCodeLine = 435;
                                MYMAXLEVELVALUE = (short) ( 0 ) ; 
                                __context__.SourceCodeLine = 437;
                                MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                                __context__.SourceCodeLine = 439;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                                __context__.SourceCodeLine = 440;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 442;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                __context__.SourceCodeLine = 443;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 448;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "level"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 450;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "maxLevel")  ) ; 
                            __context__.SourceCodeLine = 451;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 453;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "minLevel")  ) ; 
                            __context__.SourceCodeLine = 454;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 456;
                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                            __context__.SourceCodeLine = 458;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                            __context__.SourceCodeLine = 459;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 461;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                            __context__.SourceCodeLine = 462;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 464;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "inputLevel"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 466;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "inputMaxLevel")  ) ; 
                                __context__.SourceCodeLine = 467;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 469;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "inputMinLevel")  ) ; 
                                __context__.SourceCodeLine = 470;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                __context__.SourceCodeLine = 472;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                __context__.SourceCodeLine = 473;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 475;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "outputLevel"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 477;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "outputMaxLevel")  ) ; 
                                    __context__.SourceCodeLine = 478;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    __context__.SourceCodeLine = 480;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "outputMinLevel")  ) ; 
                                    __context__.SourceCodeLine = 481;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    __context__.SourceCodeLine = 483;
                                    MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                                    __context__.SourceCodeLine = 485;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                                    __context__.SourceCodeLine = 486;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    __context__.SourceCodeLine = 488;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                    __context__.SourceCodeLine = 489;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 491;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "levelOut"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 493;
                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "levelOutMax")  ) ; 
                                        __context__.SourceCodeLine = 494;
                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                        __context__.SourceCodeLine = 496;
                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "levelOutMin")  ) ; 
                                        __context__.SourceCodeLine = 497;
                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                        __context__.SourceCodeLine = 499;
                                        MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                                        __context__.SourceCodeLine = 501;
                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                                        __context__.SourceCodeLine = 502;
                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                        __context__.SourceCodeLine = 504;
                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                        __context__.SourceCodeLine = 505;
                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 507;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "levelIn"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 509;
                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "levelInMax")  ) ; 
                                            __context__.SourceCodeLine = 510;
                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                            __context__.SourceCodeLine = 512;
                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "levelInMin")  ) ; 
                                            __context__.SourceCodeLine = 513;
                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                            __context__.SourceCodeLine = 515;
                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                            __context__.SourceCodeLine = 516;
                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 518;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "levelSource"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 520;
                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "levelSourceMax")  ) ; 
                                                __context__.SourceCodeLine = 521;
                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                __context__.SourceCodeLine = 523;
                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "levelSourceMin")  ) ; 
                                                __context__.SourceCodeLine = 524;
                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                __context__.SourceCodeLine = 526;
                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                                __context__.SourceCodeLine = 527;
                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 529;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "channelLevel"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 531;
                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "channelMaxLevel")  ) ; 
                                                    __context__.SourceCodeLine = 532;
                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                    __context__.SourceCodeLine = 534;
                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "channelMinLevel")  ) ; 
                                                    __context__.SourceCodeLine = 535;
                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                    __context__.SourceCodeLine = 537;
                                                    MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                                                    __context__.SourceCodeLine = 538;
                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "get", "channelMinLevel", SUBSCRIBEOBJECT)  ) ; 
                                                    __context__.SourceCodeLine = 539;
                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                    __context__.SourceCodeLine = 541;
                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                                    __context__.SourceCodeLine = 542;
                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 544;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVELTYPE  == "sourceLevel"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 546;
                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "sourceMaxLevel")  ) ; 
                                                        __context__.SourceCodeLine = 547;
                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                        __context__.SourceCodeLine = 549;
                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", "sourceMinLevel")  ) ; 
                                                        __context__.SourceCodeLine = 550;
                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                        __context__.SourceCodeLine = 552;
                                                        MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, LEVELTYPE ) ; 
                                                        __context__.SourceCodeLine = 554;
                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", LEVELTYPE , SUBSCRIBEOBJECT)  ) ; 
                                                        __context__.SourceCodeLine = 555;
                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                        __context__.SourceCodeLine = 557;
                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                                                        __context__.SourceCodeLine = 558;
                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
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
                
            
            
            }
            
        private void DOPOLL (  SplusExecutionContext __context__ ) 
            { 
            CrestronString OUTGOINGMSG;
            OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            CrestronString SUBSCRIBEOBJECT;
            SUBSCRIBEOBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 569;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSUBSCRIPTIONREGISTERED == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 571;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", LEVELTYPE )  ) ; 
                __context__.SourceCodeLine = 572;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            
            }
            
        private ushort STARTSWITH (  SplusExecutionContext __context__, CrestronString MATCH_STRING , CrestronString SOURCE_STRING ) 
            { 
            
            __context__.SourceCodeLine = 581;
            return (ushort)( Functions.BoolToInt (Functions.Find( MATCH_STRING , SOURCE_STRING ) == 1)) ; 
            
            }
            
        private ushort CONTAINS (  SplusExecutionContext __context__, CrestronString MATCH_STRING , CrestronString SOURCE_STRING ) 
            { 
            
            __context__.SourceCodeLine = 586;
            return (ushort)( Functions.BoolToInt ( Functions.Find( MATCH_STRING , SOURCE_STRING ) > 0 )) ; 
            
            }
            
        private ushort ATOI_SIGNED (  SplusExecutionContext __context__, CrestronString VALUE ) 
            { 
            
            __context__.SourceCodeLine = 591;
            if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "-" , VALUE ))  ) ) 
                {
                __context__.SourceCodeLine = 592;
                return (ushort)( (0 - Functions.Atoi( VALUE ))) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 594;
                return (ushort)( Functions.Atoi( VALUE )) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString TRIM (  SplusExecutionContext __context__, CrestronString VALUE ) 
            { 
            
            __context__.SourceCodeLine = 599;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( VALUE , (int)( 1 ) ) == "\u0020"))  ) ) 
                {
                __context__.SourceCodeLine = 600;
                VALUE  .UpdateValue ( Functions.Right ( VALUE ,  (int) ( (Functions.Length( VALUE ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 599;
                }
            
            __context__.SourceCodeLine = 602;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( VALUE , (int)( 1 ) ) == "\u0020"))  ) ) 
                {
                __context__.SourceCodeLine = 603;
                VALUE  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( (Functions.Length( VALUE ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 602;
                }
            
            __context__.SourceCodeLine = 605;
            return ( VALUE ) ; 
            
            }
            
        private ushort SCALELEVEL (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            ushort STAGE1 = 0;
            
            ushort STAGE2 = 0;
            
            
            __context__.SourceCodeLine = 616;
            STAGE1 = (ushort) ( (VALUE - MYMINLEVELVALUE) ) ; 
            __context__.SourceCodeLine = 618;
            STAGE2 = (ushort) ( (MYMAXLEVELVALUE - MYMINLEVELVALUE) ) ; 
            __context__.SourceCodeLine = 620;
            return (ushort)( ((STAGE1 * 65535) / STAGE2)) ; 
            
            }
            
        private void DISPLAYCURRENTLEVEL (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            
            __context__.SourceCodeLine = 625;
            VOLUME_GAUGE  .Value = (ushort) ( SCALELEVEL( __context__ , (ushort)( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 626;
            VOLUME_LEVEL_SIGNED_UNSCALED  .Value = (ushort) ( VALUE ) ; 
            __context__.SourceCodeLine = 627;
            MakeString ( VOLUME_LEVEL_TEXT , "{0:d}", (short)VALUE) ; 
            
            }
            
        private ushort GETNEXTRAISEVALUE (  SplusExecutionContext __context__ ) 
            { 
            short TEST = 0;
            
            
            __context__.SourceCodeLine = 634;
            TEST = (short) ( (MYLEVELVALUE + LEVEL_STEP  .Value) ) ; 
            __context__.SourceCodeLine = 636;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEST > MYMAXLEVELVALUE ))  ) ) 
                {
                __context__.SourceCodeLine = 637;
                return (ushort)( MYMAXLEVELVALUE) ; 
                }
            
            __context__.SourceCodeLine = 639;
            return (ushort)( TEST) ; 
            
            }
            
        private ushort GETNEXTLOWERVALUE (  SplusExecutionContext __context__ ) 
            { 
            short TEST = 0;
            
            
            __context__.SourceCodeLine = 646;
            TEST = (short) ( (MYLEVELVALUE - LEVEL_STEP  .Value) ) ; 
            __context__.SourceCodeLine = 648;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEST < MYMINLEVELVALUE ))  ) ) 
                {
                __context__.SourceCodeLine = 649;
                return (ushort)( MYMINLEVELVALUE) ; 
                }
            
            __context__.SourceCodeLine = 651;
            return (ushort)( TEST) ; 
            
            }
            
        private void RAISELEVEL (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 656;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, BUILDPROTOCOLMSG_WITHINTEGERVALUE (  __context__ , "set", LEVELTYPE , (ushort)( GETNEXTRAISEVALUE( __context__ ) )) ) ; 
            __context__.SourceCodeLine = 658;
            CreateWait ( "RAISE_LEVEL" , 50 , RAISE_LEVEL_Callback ) ;
            
            }
            
        public void RAISE_LEVEL_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 660;
            if ( Functions.TestForTrue  ( ( LEVEL_UP  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 661;
                RAISELEVEL (  __context__  ) ; 
                }
            
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void CANCELRAISELEVEL (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 667;
        CancelWait ( "RAISE_LEVEL" ) ; 
        
        }
        
    private void LOWERLEVEL (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 672;
        MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, BUILDPROTOCOLMSG_WITHINTEGERVALUE (  __context__ , "set", LEVELTYPE , (ushort)( GETNEXTLOWERVALUE( __context__ ) )) ) ; 
        __context__.SourceCodeLine = 674;
        CreateWait ( "LOWER_LEVEL" , 50 , LOWER_LEVEL_Callback ) ;
        
        }
        
    public void LOWER_LEVEL_CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 676;
            if ( Functions.TestForTrue  ( ( LEVEL_DOWN  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 677;
                LOWERLEVEL (  __context__  ) ; 
                }
            
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void CANCELLOWERLEVEL (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 683;
    CancelWait ( "LOWER_LEVEL" ) ; 
    
    }
    
object LEVEL_UP_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 692;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 694;
            CANCELLOWERLEVEL (  __context__  ) ; 
            __context__.SourceCodeLine = 695;
            RAISELEVEL (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LEVEL_DOWN_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 701;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 703;
            CANCELRAISELEVEL (  __context__  ) ; 
            __context__.SourceCodeLine = 704;
            LOWERLEVEL (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LEVEL_UP_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 710;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 712;
            CANCELRAISELEVEL (  __context__  ) ; 
            __context__.SourceCodeLine = 713;
            CANCELLOWERLEVEL (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_LEVEL_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 719;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 721;
            DOPOLL (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void PROCESSPROCESSORMSG (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 729;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PARSEDMODULEMSG ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 731;
        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "REGISTER" , PARSEDMODULEMSG ))  ) ) 
            { 
            __context__.SourceCodeLine = 733;
            MYID = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , PARSEDMODULEMSG , "<" , ">" ) ) ) ; 
            __context__.SourceCodeLine = 735;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MYID > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 736;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "REGISTER<{0:d}>", (short)MYID) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 738;
            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "INIT" , PARSEDMODULEMSG ))  ) ) 
                { 
                __context__.SourceCodeLine = 740;
                IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 741;
                GETALIAS (  __context__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 743;
                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "RESPONSE_MSG" , PARSEDMODULEMSG ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 745;
                    RESPONSEREQUESTMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "<", "|")  ) ; 
                    __context__.SourceCodeLine = 746;
                    RESPONSEMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "|", ">")  ) ; 
                    __context__.SourceCodeLine = 748;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "RESPONSE_OK<{0:d}|{1}>", (short)MYID, RESPONSEREQUESTMSG ) ; 
                    __context__.SourceCodeLine = 750;
                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "get" , RESPONSEREQUESTMSG ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 752;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "max" , Functions.Lower( RESPONSEREQUESTMSG ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 754;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 756;
                                TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                __context__.SourceCodeLine = 758;
                                MYMAXLEVELVALUE = (short) ( ATOI_SIGNED( __context__ , RESPONSEMSG ) ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 761;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "min" , Functions.Lower( RESPONSEREQUESTMSG ) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 763;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 765;
                                    TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                    __context__.SourceCodeLine = 767;
                                    MYMINLEVELVALUE = (short) ( ATOI_SIGNED( __context__ , RESPONSEMSG ) ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 770;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , LEVELTYPE  , RESPONSEREQUESTMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 772;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 774;
                                        TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                        __context__.SourceCodeLine = 776;
                                        MYLEVELVALUE = (short) ( ATOI_SIGNED( __context__ , RESPONSEMSG ) ) ; 
                                        __context__.SourceCodeLine = 777;
                                        DISPLAYCURRENTLEVEL (  __context__ , (ushort)( MYLEVELVALUE )) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 780;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 782;
                                        IS_INITIALIZED  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 784;
                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "INIT_DONE<{0:d}>", (short)MYID) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 787;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "alias" , RESPONSEREQUESTMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 789;
                                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 791;
                                            TRASH  .UpdateValue ( Functions.Remove ( "+OK [" , RESPONSEMSG )  ) ; 
                                            __context__.SourceCodeLine = 793;
                                            MYCLASSCODE = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , RESPONSEMSG , " " , " " ) ) ) ; 
                                            __context__.SourceCodeLine = 795;
                                            GETINITIALIZED (  __context__  ) ; 
                                            } 
                                        
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 799;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "set" , RESPONSEREQUESTMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 801;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , LEVELTYPE  , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 803;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 805;
                                    TRASH  .UpdateValue ( Functions.Remove ( BUILDPROTOCOLMSG (  __context__ , "set", LEVELTYPE ) , RESPONSEREQUESTMSG )  ) ; 
                                    __context__.SourceCodeLine = 806;
                                    RESPONSEREQUESTMSG  .UpdateValue ( TRIM (  __context__ , RESPONSEREQUESTMSG)  ) ; 
                                    __context__.SourceCodeLine = 807;
                                    MYLEVELVALUE = (short) ( ATOI_SIGNED( __context__ , RESPONSEREQUESTMSG ) ) ; 
                                    __context__.SourceCodeLine = 808;
                                    DISPLAYCURRENTLEVEL (  __context__ , (ushort)( MYLEVELVALUE )) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 812;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "subscribe" , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 814;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , LEVELTYPE  , RESPONSEREQUESTMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 816;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 818;
                                        HASSUBSCRIPTIONREGISTERED = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 823;
                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "SUBSCRIBED_MSG" , PARSEDMODULEMSG ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 825;
                        RESPONSEMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "<", ">")  ) ; 
                        __context__.SourceCodeLine = 827;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , LEVELTYPE  , RESPONSEMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 829;
                            TRASH  .UpdateValue ( Functions.Remove ( "]\u0022 " , RESPONSEMSG )  ) ; 
                            __context__.SourceCodeLine = 831;
                            MYLEVELVALUE = (short) ( ATOI_SIGNED( __context__ , RESPONSEMSG ) ) ; 
                            __context__.SourceCodeLine = 832;
                            DISPLAYCURRENTLEVEL (  __context__ , (ushort)( MYLEVELVALUE )) ; 
                            } 
                        
                        } 
                    
                    }
                
                }
            
            }
        
        } 
    
    
    }
    
object FROM_PROCESSOR__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 841;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 843;
            try 
                { 
                __context__.SourceCodeLine = 845;
                PARSEDMODULEMSG  .UpdateValue ( Functions.Gather ( ">" , FROM_PROCESSOR__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 847;
                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , PARSEDMODULEMSG , FROM_PROCESSOR__DOLLAR__ ))  ) ) 
                    {
                    __context__.SourceCodeLine = 848;
                    Functions.ClearBuffer ( FROM_PROCESSOR__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 850;
                PROCESSPROCESSORMSG (  __context__  ) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 854;
                Print( "Issue with Processor message handeling\r\n") ; 
                
                }
                
                __context__.SourceCodeLine = 841;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

object SEND_NEW_LEVEL_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString OUTGOINGMSG;
        OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        
        short VALUE = 0;
        
        
        __context__.SourceCodeLine = 888;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 890;
            VALUE = (short) ( NEW_LEVEL  .ShortValue ) ; 
            __context__.SourceCodeLine = 892;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( VALUE >= MYMINLEVELVALUE ) ) && Functions.TestForTrue ( Functions.BoolToInt ( VALUE <= MYMAXLEVELVALUE ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 894;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHINTEGERVALUE (  __context__ , "set", LEVELTYPE , (ushort)( VALUE ))  ) ; 
                __context__.SourceCodeLine = 896;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
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
        
        __context__.SourceCodeLine = 908;
        PARSINGMODULEBUSY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 910;
        IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 911;
        HASSUBSCRIPTIONREGISTERED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 913;
        MYMAXLEVELVALUE = (short) ( 0 ) ; 
        __context__.SourceCodeLine = 914;
        MYMINLEVELVALUE = (short) ( Functions.ToSignedInteger( -( 100 ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    PARSEDMODULEMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    RESPONSEREQUESTMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    RESPONSEMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    PARSEVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    
    POLL_LEVEL = new Crestron.Logos.SplusObjects.DigitalInput( POLL_LEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_LEVEL__DigitalInput__, POLL_LEVEL );
    
    LEVEL_UP = new Crestron.Logos.SplusObjects.DigitalInput( LEVEL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( LEVEL_UP__DigitalInput__, LEVEL_UP );
    
    LEVEL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( LEVEL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( LEVEL_DOWN__DigitalInput__, LEVEL_DOWN );
    
    SEND_NEW_LEVEL = new Crestron.Logos.SplusObjects.DigitalInput( SEND_NEW_LEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_NEW_LEVEL__DigitalInput__, SEND_NEW_LEVEL );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    NEW_LEVEL = new Crestron.Logos.SplusObjects.AnalogInput( NEW_LEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NEW_LEVEL__AnalogSerialInput__, NEW_LEVEL );
    
    VOLUME_GAUGE = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_GAUGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_GAUGE__AnalogSerialOutput__, VOLUME_GAUGE );
    
    VOLUME_LEVEL_SIGNED_UNSCALED = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_LEVEL_SIGNED_UNSCALED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_LEVEL_SIGNED_UNSCALED__AnalogSerialOutput__, VOLUME_LEVEL_SIGNED_UNSCALED );
    
    VOLUME_LEVEL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VOLUME_LEVEL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( VOLUME_LEVEL_TEXT__AnalogSerialOutput__, VOLUME_LEVEL_TEXT );
    
    TO_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_PROCESSOR__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_PROCESSOR__DOLLAR____AnalogSerialOutput__, TO_PROCESSOR__DOLLAR__ );
    
    FROM_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, 1024, this );
    m_StringInputList.Add( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, FROM_PROCESSOR__DOLLAR__ );
    
    INDEX1 = new UShortParameter( INDEX1__Parameter__, this );
    m_ParameterList.Add( INDEX1__Parameter__, INDEX1 );
    
    INDEX2 = new UShortParameter( INDEX2__Parameter__, this );
    m_ParameterList.Add( INDEX2__Parameter__, INDEX2 );
    
    LEVEL_STEP = new UShortParameter( LEVEL_STEP__Parameter__, this );
    m_ParameterList.Add( LEVEL_STEP__Parameter__, LEVEL_STEP );
    
    INSTANCETAG = new StringParameter( INSTANCETAG__Parameter__, this );
    m_ParameterList.Add( INSTANCETAG__Parameter__, INSTANCETAG );
    
    LEVELTYPE = new StringParameter( LEVELTYPE__Parameter__, this );
    m_ParameterList.Add( LEVELTYPE__Parameter__, LEVELTYPE );
    
    RAISE_LEVEL_Callback = new WaitFunction( RAISE_LEVEL_CallbackFn );
    LOWER_LEVEL_Callback = new WaitFunction( LOWER_LEVEL_CallbackFn );
    
    LEVEL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnPush_0, false ) );
    LEVEL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEVEL_DOWN_OnPush_1, false ) );
    LEVEL_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnRelease_2, false ) );
    LEVEL_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnRelease_2, false ) );
    POLL_LEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_LEVEL_OnPush_3, false ) );
    FROM_PROCESSOR__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_PROCESSOR__DOLLAR___OnChange_4, true ) );
    SEND_NEW_LEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_NEW_LEVEL_OnPush_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BIAMP_TESIRA_LEVEL_CONTROL_V1_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction RAISE_LEVEL_Callback;
private WaitFunction LOWER_LEVEL_Callback;


const uint POLL_LEVEL__DigitalInput__ = 0;
const uint LEVEL_UP__DigitalInput__ = 1;
const uint LEVEL_DOWN__DigitalInput__ = 2;
const uint SEND_NEW_LEVEL__DigitalInput__ = 3;
const uint NEW_LEVEL__AnalogSerialInput__ = 0;
const uint FROM_PROCESSOR__DOLLAR____AnalogSerialInput__ = 1;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint VOLUME_GAUGE__AnalogSerialOutput__ = 0;
const uint VOLUME_LEVEL_SIGNED_UNSCALED__AnalogSerialOutput__ = 1;
const uint VOLUME_LEVEL_TEXT__AnalogSerialOutput__ = 2;
const uint TO_PROCESSOR__DOLLAR____AnalogSerialOutput__ = 3;
const uint INSTANCETAG__Parameter__ = 10;
const uint LEVELTYPE__Parameter__ = 11;
const uint INDEX1__Parameter__ = 12;
const uint INDEX2__Parameter__ = 13;
const uint LEVEL_STEP__Parameter__ = 14;

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
