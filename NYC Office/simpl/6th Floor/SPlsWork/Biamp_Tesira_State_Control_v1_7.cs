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

namespace UserModule_BIAMP_TESIRA_STATE_CONTROL_V1_7
{
    public class UserModuleClass_BIAMP_TESIRA_STATE_CONTROL_V1_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_STATE;
        Crestron.Logos.SplusObjects.DigitalInput STATE_ON;
        Crestron.Logos.SplusObjects.DigitalInput STATE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput STATE_TOGGLE;
        Crestron.Logos.SplusObjects.BufferInput FROM_PROCESSOR__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput STATE_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput STATE_IS_OFF;
        Crestron.Logos.SplusObjects.StringOutput TO_PROCESSOR__DOLLAR__;
        StringParameter INSTANCETAG;
        StringParameter STATETYPE;
        UShortParameter INDEX1;
        UShortParameter INDEX2;
        ushort MYID = 0;
        short MYSTATEVALUE = 0;
        ushort MYCLASSCODE = 0;
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
            
            
            __context__.SourceCodeLine = 169;
            RESPONSE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 171;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SOURCE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 173;
                STARTINDEX = (ushort) ( Functions.Find( STARTSTRING , SOURCE ) ) ; 
                __context__.SourceCodeLine = 174;
                ENDINDEX = (ushort) ( Functions.Find( ENDSTRING , SOURCE , (STARTINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 176;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( STARTINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( STARTINDEX < ENDINDEX ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 178;
                    STARTINDEX = (ushort) ( (STARTINDEX + Functions.Length( STARTSTRING )) ) ; 
                    __context__.SourceCodeLine = 180;
                    RESPONSE  .UpdateValue ( Functions.Mid ( SOURCE ,  (int) ( STARTINDEX ) ,  (int) ( (ENDINDEX - STARTINDEX) ) )  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 184;
            return ( RESPONSE ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 194;
            MSG  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 196;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INDEX1  .Value > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INDEX2  .Value > 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 197;
                MakeString ( MSG , "{0} {1} {2} {3:d} {4:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX1  .Value, (short)INDEX2  .Value) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 198;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INDEX1  .Value > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (INDEX2  .Value == 0) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 199;
                    MakeString ( MSG , "{0} {1} {2} {3:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX1  .Value) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 200;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (INDEX1  .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( INDEX2  .Value > 0 ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 201;
                        MakeString ( MSG , "{0} {1} {2} {3:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX2  .Value) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 203;
                        MakeString ( MSG , "{0} {1} {2}", INSTANCETAG , COMMAND , CONTROL ) ; 
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 205;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHSTRINGVALUE (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL , CrestronString VALUE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 212;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , COMMAND, CONTROL)  ) ; 
            __context__.SourceCodeLine = 214;
            MakeString ( MSG , "{0} {1}", MSG , VALUE ) ; 
            __context__.SourceCodeLine = 216;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHINTEGERVALUE (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL , ushort VALUE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 223;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , COMMAND, CONTROL)  ) ; 
            __context__.SourceCodeLine = 225;
            MakeString ( MSG , "{0} {1:d}", MSG , (short)VALUE) ; 
            __context__.SourceCodeLine = 227;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHSTATEVALUE (  SplusExecutionContext __context__, CrestronString COMMAND , CrestronString CONTROL , ushort STATE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 234;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , COMMAND, CONTROL)  ) ; 
            __context__.SourceCodeLine = 236;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE == 1))  ) ) 
                {
                __context__.SourceCodeLine = 237;
                MakeString ( MSG , "{0} true", MSG ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 239;
                MakeString ( MSG , "{0} false", MSG ) ; 
                }
            
            __context__.SourceCodeLine = 241;
            return ( MSG ) ; 
            
            }
            
        private void GETALIAS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString OUTGOINGMSG;
            OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 250;
            MakeString ( OUTGOINGMSG , "SESSION get alias {0}", INSTANCETAG ) ; 
            __context__.SourceCodeLine = 251;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            
            }
            
        private void GETINITIALIZED (  SplusExecutionContext __context__ ) 
            { 
            CrestronString OUTGOINGMSG;
            OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            CrestronString SUBSCRIBEOBJECT;
            SUBSCRIBEOBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 259;
            HASSUBSCRIPTIONREGISTERED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 261;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)MYCLASSCODE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1024) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 265;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "mute"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 267;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 268;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1025) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 273;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "mute"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 275;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 276;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1028) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 281;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "mute"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 283;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 284;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1031) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 289;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "mute"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 291;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 292;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1537) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 297;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "crosspoint"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 299;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 300;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 302;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "inputMute"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 304;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                __context__.SourceCodeLine = 305;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 307;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "outputMute"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 309;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                    __context__.SourceCodeLine = 310;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1538) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 315;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "crosspointLevelState"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 317;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 318;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 320;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "inputMute"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 322;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                __context__.SourceCodeLine = 323;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 325;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "outputMute"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 327;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                    __context__.SourceCodeLine = 328;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1536) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 333;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "crosspoint"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 335;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 336;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 338;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "inputMute"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 340;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                __context__.SourceCodeLine = 341;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 343;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "outputMute"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 345;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                    __context__.SourceCodeLine = 346;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7171) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 351;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "state"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 353;
                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                            __context__.SourceCodeLine = 355;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                            __context__.SourceCodeLine = 356;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 358;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 359;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 364;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "mute"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 366;
                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                            __context__.SourceCodeLine = 368;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                            __context__.SourceCodeLine = 369;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            __context__.SourceCodeLine = 371;
                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                            __context__.SourceCodeLine = 372;
                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 376;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "state"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 378;
                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                __context__.SourceCodeLine = 379;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 381;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "muteOut"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 383;
                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                    __context__.SourceCodeLine = 384;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 386;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "muteIn"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 388;
                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                        __context__.SourceCodeLine = 389;
                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 391;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "muteSource"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 393;
                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                            __context__.SourceCodeLine = 394;
                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 396;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "wallState"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 398;
                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                __context__.SourceCodeLine = 399;
                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 401;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "inputMute"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 403;
                                                    MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                    __context__.SourceCodeLine = 405;
                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                    __context__.SourceCodeLine = 406;
                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                    __context__.SourceCodeLine = 408;
                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                    __context__.SourceCodeLine = 409;
                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 411;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "outputMute"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 413;
                                                        MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                        __context__.SourceCodeLine = 415;
                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                        __context__.SourceCodeLine = 416;
                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                        __context__.SourceCodeLine = 418;
                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                        __context__.SourceCodeLine = 419;
                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 421;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "channelMute"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 423;
                                                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                            __context__.SourceCodeLine = 425;
                                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                            __context__.SourceCodeLine = 426;
                                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                            __context__.SourceCodeLine = 428;
                                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                            __context__.SourceCodeLine = 429;
                                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 431;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "crosspoint"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 433;
                                                                MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                                __context__.SourceCodeLine = 435;
                                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                                __context__.SourceCodeLine = 436;
                                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                __context__.SourceCodeLine = 438;
                                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                                __context__.SourceCodeLine = 439;
                                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 441;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "crosspointLevelState"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 443;
                                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                                    __context__.SourceCodeLine = 444;
                                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 446;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "connected"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 448;
                                                                        MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                                        __context__.SourceCodeLine = 450;
                                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                                        __context__.SourceCodeLine = 451;
                                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                        __context__.SourceCodeLine = 453;
                                                                        OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                                        __context__.SourceCodeLine = 454;
                                                                        MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 456;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "hostMasterMute"))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 458;
                                                                            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                                            __context__.SourceCodeLine = 460;
                                                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                                            __context__.SourceCodeLine = 461;
                                                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                            __context__.SourceCodeLine = 463;
                                                                            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                                            __context__.SourceCodeLine = 464;
                                                                            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 466;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "hostMute"))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 468;
                                                                                MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                                                __context__.SourceCodeLine = 470;
                                                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                                                __context__.SourceCodeLine = 471;
                                                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                                __context__.SourceCodeLine = 473;
                                                                                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                                                __context__.SourceCodeLine = 474;
                                                                                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 476;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATETYPE  == "streaming"))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 478;
                                                                                    MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, STATETYPE ) ; 
                                                                                    __context__.SourceCodeLine = 480;
                                                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , "subscribe", STATETYPE , SUBSCRIBEOBJECT)  ) ; 
                                                                                    __context__.SourceCodeLine = 481;
                                                                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                                                                                    __context__.SourceCodeLine = 483;
                                                                                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                                                                                    __context__.SourceCodeLine = 484;
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
            
            
            __context__.SourceCodeLine = 495;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSUBSCRIPTIONREGISTERED == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 497;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , "get", STATETYPE )  ) ; 
                __context__.SourceCodeLine = 498;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            
            }
            
        private ushort STARTSWITH (  SplusExecutionContext __context__, CrestronString MATCH_STRING , CrestronString SOURCE_STRING ) 
            { 
            
            __context__.SourceCodeLine = 507;
            return (ushort)( Functions.BoolToInt (Functions.Find( MATCH_STRING , SOURCE_STRING ) == 1)) ; 
            
            }
            
        private ushort CONTAINS (  SplusExecutionContext __context__, CrestronString MATCH_STRING , CrestronString SOURCE_STRING ) 
            { 
            
            __context__.SourceCodeLine = 512;
            return (ushort)( Functions.BoolToInt ( Functions.Find( MATCH_STRING , SOURCE_STRING ) > 0 )) ; 
            
            }
            
        private ushort ATOI_SIGNED (  SplusExecutionContext __context__, CrestronString VALUE ) 
            { 
            
            __context__.SourceCodeLine = 517;
            if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "-" , VALUE ))  ) ) 
                {
                __context__.SourceCodeLine = 518;
                return (ushort)( (0 - Functions.Atoi( VALUE ))) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 520;
                return (ushort)( Functions.Atoi( VALUE )) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString TRIM (  SplusExecutionContext __context__, CrestronString VALUE ) 
            { 
            
            __context__.SourceCodeLine = 525;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( VALUE , (int)( 1 ) ) == "\u0020"))  ) ) 
                {
                __context__.SourceCodeLine = 526;
                VALUE  .UpdateValue ( Functions.Right ( VALUE ,  (int) ( (Functions.Length( VALUE ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 525;
                }
            
            __context__.SourceCodeLine = 528;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( VALUE , (int)( 1 ) ) == "\u0020"))  ) ) 
                {
                __context__.SourceCodeLine = 529;
                VALUE  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( (Functions.Length( VALUE ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 528;
                }
            
            __context__.SourceCodeLine = 531;
            return ( VALUE ) ; 
            
            }
            
        private void DISPLAYSTATESTATUS (  SplusExecutionContext __context__, ushort STATE ) 
            { 
            
            __context__.SourceCodeLine = 539;
            STATE_IS_ON  .Value = (ushort) ( Functions.BoolToInt (STATE == 1) ) ; 
            __context__.SourceCodeLine = 540;
            STATE_IS_OFF  .Value = (ushort) ( Functions.BoolToInt (STATE == 0) ) ; 
            
            }
            
        object STATE_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 548;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 549;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , "set", STATETYPE , (ushort)( 1 )) ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STATE_OFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 554;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 555;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , "set", STATETYPE , (ushort)( 0 )) ) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STATE_TOGGLE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 560;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 561;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , "set", STATETYPE , (ushort)( Functions.Not( MYSTATEVALUE ) )) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_STATE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 566;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 567;
            DOPOLL (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void PROCESSPROCESSORMSG (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 575;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PARSEDMODULEMSG ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 577;
        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "REGISTER" , PARSEDMODULEMSG ))  ) ) 
            { 
            __context__.SourceCodeLine = 579;
            MYID = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , PARSEDMODULEMSG , "<" , ">" ) ) ) ; 
            __context__.SourceCodeLine = 581;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MYID > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 582;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "REGISTER<{0:d}>", (short)MYID) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 584;
            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "INIT" , PARSEDMODULEMSG ))  ) ) 
                { 
                __context__.SourceCodeLine = 586;
                IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 587;
                GETALIAS (  __context__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 589;
                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "RESPONSE_MSG" , PARSEDMODULEMSG ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 591;
                    RESPONSEREQUESTMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "<", "|")  ) ; 
                    __context__.SourceCodeLine = 592;
                    RESPONSEMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "|", ">")  ) ; 
                    __context__.SourceCodeLine = 594;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "RESPONSE_OK<{0:d}|{1}>", (short)MYID, RESPONSEREQUESTMSG ) ; 
                    __context__.SourceCodeLine = 596;
                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "get" , RESPONSEREQUESTMSG ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 598;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , STATETYPE  , RESPONSEREQUESTMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 600;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 602;
                                TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                __context__.SourceCodeLine = 604;
                                MYSTATEVALUE = (short) ( CONTAINS( __context__ , "true" , RESPONSEMSG ) ) ; 
                                __context__.SourceCodeLine = 605;
                                DISPLAYSTATESTATUS (  __context__ , (ushort)( MYSTATEVALUE )) ; 
                                } 
                            
                            __context__.SourceCodeLine = 608;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 610;
                                IS_INITIALIZED  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 611;
                                MakeString ( TO_PROCESSOR__DOLLAR__ , "INIT_DONE<{0:d}>", (short)MYID) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 614;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "alias" , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 616;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 618;
                                    TRASH  .UpdateValue ( Functions.Remove ( "+OK [" , RESPONSEMSG )  ) ; 
                                    __context__.SourceCodeLine = 620;
                                    MYCLASSCODE = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , RESPONSEMSG , " " , " " ) ) ) ; 
                                    __context__.SourceCodeLine = 622;
                                    GETINITIALIZED (  __context__  ) ; 
                                    } 
                                
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 626;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "set" , RESPONSEREQUESTMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 628;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , STATETYPE  , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 630;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 632;
                                    TRASH  .UpdateValue ( Functions.Remove ( BUILDPROTOCOLMSG (  __context__ , "set", STATETYPE ) , RESPONSEREQUESTMSG )  ) ; 
                                    __context__.SourceCodeLine = 633;
                                    MYSTATEVALUE = (short) ( CONTAINS( __context__ , "true" , RESPONSEREQUESTMSG ) ) ; 
                                    __context__.SourceCodeLine = 634;
                                    DISPLAYSTATESTATUS (  __context__ , (ushort)( MYSTATEVALUE )) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 638;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "subscribe" , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 640;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , STATETYPE  , RESPONSEREQUESTMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 642;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 644;
                                        HASSUBSCRIPTIONREGISTERED = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 649;
                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "SUBSCRIBED_MSG" , PARSEDMODULEMSG ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 651;
                        RESPONSEMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "<", ">")  ) ; 
                        __context__.SourceCodeLine = 653;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , STATETYPE  , RESPONSEMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 655;
                            TRASH  .UpdateValue ( Functions.Remove ( "]\u0022 " , RESPONSEMSG )  ) ; 
                            __context__.SourceCodeLine = 657;
                            MYSTATEVALUE = (short) ( CONTAINS( __context__ , "true" , RESPONSEMSG ) ) ; 
                            __context__.SourceCodeLine = 658;
                            DISPLAYSTATESTATUS (  __context__ , (ushort)( MYSTATEVALUE )) ; 
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
        
        __context__.SourceCodeLine = 668;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 670;
            try 
                { 
                __context__.SourceCodeLine = 672;
                PARSEDMODULEMSG  .UpdateValue ( Functions.Gather ( ">" , FROM_PROCESSOR__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 674;
                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , PARSEDMODULEMSG , FROM_PROCESSOR__DOLLAR__ ))  ) ) 
                    {
                    __context__.SourceCodeLine = 675;
                    Functions.ClearBuffer ( FROM_PROCESSOR__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 677;
                PROCESSPROCESSORMSG (  __context__  ) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 681;
                Print( "Issue with Processor message handeling\r\n") ; 
                
                }
                
                __context__.SourceCodeLine = 668;
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
        
        __context__.SourceCodeLine = 717;
        PARSINGMODULEBUSY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 719;
        IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 720;
        HASSUBSCRIPTIONREGISTERED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 722;
        MYSTATEVALUE = (short) ( 0 ) ; 
        
        
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
    
    POLL_STATE = new Crestron.Logos.SplusObjects.DigitalInput( POLL_STATE__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_STATE__DigitalInput__, POLL_STATE );
    
    STATE_ON = new Crestron.Logos.SplusObjects.DigitalInput( STATE_ON__DigitalInput__, this );
    m_DigitalInputList.Add( STATE_ON__DigitalInput__, STATE_ON );
    
    STATE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( STATE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( STATE_OFF__DigitalInput__, STATE_OFF );
    
    STATE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( STATE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( STATE_TOGGLE__DigitalInput__, STATE_TOGGLE );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    STATE_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( STATE_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( STATE_IS_ON__DigitalOutput__, STATE_IS_ON );
    
    STATE_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( STATE_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( STATE_IS_OFF__DigitalOutput__, STATE_IS_OFF );
    
    TO_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_PROCESSOR__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_PROCESSOR__DOLLAR____AnalogSerialOutput__, TO_PROCESSOR__DOLLAR__ );
    
    FROM_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, 1024, this );
    m_StringInputList.Add( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, FROM_PROCESSOR__DOLLAR__ );
    
    INDEX1 = new UShortParameter( INDEX1__Parameter__, this );
    m_ParameterList.Add( INDEX1__Parameter__, INDEX1 );
    
    INDEX2 = new UShortParameter( INDEX2__Parameter__, this );
    m_ParameterList.Add( INDEX2__Parameter__, INDEX2 );
    
    INSTANCETAG = new StringParameter( INSTANCETAG__Parameter__, this );
    m_ParameterList.Add( INSTANCETAG__Parameter__, INSTANCETAG );
    
    STATETYPE = new StringParameter( STATETYPE__Parameter__, this );
    m_ParameterList.Add( STATETYPE__Parameter__, STATETYPE );
    
    
    STATE_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( STATE_ON_OnPush_0, false ) );
    STATE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( STATE_OFF_OnPush_1, false ) );
    STATE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STATE_TOGGLE_OnPush_2, false ) );
    POLL_STATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_STATE_OnPush_3, false ) );
    FROM_PROCESSOR__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_PROCESSOR__DOLLAR___OnChange_4, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BIAMP_TESIRA_STATE_CONTROL_V1_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_STATE__DigitalInput__ = 0;
const uint STATE_ON__DigitalInput__ = 1;
const uint STATE_OFF__DigitalInput__ = 2;
const uint STATE_TOGGLE__DigitalInput__ = 3;
const uint FROM_PROCESSOR__DOLLAR____AnalogSerialInput__ = 0;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint STATE_IS_ON__DigitalOutput__ = 1;
const uint STATE_IS_OFF__DigitalOutput__ = 2;
const uint TO_PROCESSOR__DOLLAR____AnalogSerialOutput__ = 0;
const uint INSTANCETAG__Parameter__ = 10;
const uint STATETYPE__Parameter__ = 11;
const uint INDEX1__Parameter__ = 12;
const uint INDEX2__Parameter__ = 13;

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
