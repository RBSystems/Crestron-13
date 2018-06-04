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

namespace UserModule_BIAMP_TESIRA_VOIP_CONTROL_V1_7
{
    public class UserModuleClass_BIAMP_TESIRA_VOIP_CONTROL_V1_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_DIALER;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.AnalogInput CALL_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput CONFERENCE;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER;
        Crestron.Logos.SplusObjects.DigitalInput FLASH;
        Crestron.Logos.SplusObjects.DigitalInput REDIAL;
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        Crestron.Logos.SplusObjects.DigitalInput END;
        Crestron.Logos.SplusObjects.DigitalInput RESUME;
        Crestron.Logos.SplusObjects.DigitalInput HOLD;
        Crestron.Logos.SplusObjects.DigitalInput ON_HOOK;
        Crestron.Logos.SplusObjects.DigitalInput OFF_HOOK;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTED_CALL;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_1_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_2_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_3_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_4_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_5_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_6_STATE;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_0;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_1;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_2;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_3;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_4;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_5;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_6;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_7;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_8;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_9;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_STAR;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_POUND;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_BACKSPACE;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_DIAL;
        Crestron.Logos.SplusObjects.StringOutput KEYPAD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LAST_NUMBER_DIALED__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput AUTOANSWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput AUTOANSWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput AUTOANSWER_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput AUTOANSWER_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput AUTOANSWER_IS_OFF;
        Crestron.Logos.SplusObjects.DigitalInput DIRECTORY_TOP_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput DIRECTORY_NEXT_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput DIRECTORY_PREVIOUS_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput DIRECTORY_BOTTOM_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_01;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_02;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_03;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_04;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_05;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_06;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_07;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_08;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_09;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_10;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_11;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_12;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_13;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_14;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_15;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_16;
        Crestron.Logos.SplusObjects.DigitalInput DIAL_SELECTED_DIRECTORY_ITEM;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_DIRECTORY_ENTRY;
        Crestron.Logos.SplusObjects.AnalogInput SELECT_DIRECTORY_SAVE_LOCATION;
        Crestron.Logos.SplusObjects.StringInput DIRECTORY_SAVE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DIRECTORY_SAVE_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_01__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_02__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_03__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_04__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_05__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_06__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_07__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_08__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_09__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_10__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_11__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_12__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_13__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_14__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_15__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_ITEM_16__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput DND_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput DND_DISABLED;
        Crestron.Logos.SplusObjects.DigitalInput DND_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput DND_RESPONSE_DND;
        Crestron.Logos.SplusObjects.DigitalInput DND_RESPONSE_BUSY;
        Crestron.Logos.SplusObjects.DigitalInput DND_RESPONSE_DECLINE;
        Crestron.Logos.SplusObjects.DigitalOutput DND_IS_ENABLED;
        Crestron.Logos.SplusObjects.DigitalOutput DND_RESPONSE_IS_DND;
        Crestron.Logos.SplusObjects.DigitalOutput DND_RESPONSE_IS_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput DND_RESPONSE_IS_DECLINE;
        Crestron.Logos.SplusObjects.DigitalInput ALPHANUMERIC_ENTRY_DIAL;
        Crestron.Logos.SplusObjects.StringInput ALPHANUMERIC_ENTRY__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_PROCESSOR__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_PROCESSOR__DOLLAR__;
        StringParameter DIALER_INSTANCETAG;
        StringParameter CONTROLSTATUS_INSTANCETAG;
        UShortParameter LINE_NUMBER;
        UShortParameter SPEEDDIALLIST_PAGESIZE;
        SPEEDDIALENTRY [] SPEEDDIALLIST;
        CALLSTATUSINFO [] CALLSTATUS;
        ushort MYID = 0;
        ushort X = 0;
        ushort PARSINGMODULEBUSY = 0;
        CrestronString PARSEDMODULEMSG;
        ushort RESPONSEMODULEMSGID = 0;
        CrestronString RESPONSEREQUESTMSG;
        CrestronString RESPONSEMSG;
        CrestronString PARSESTRING;
        ushort PARSEINT = 0;
        CrestronString TRASH;
        CrestronString CALLSTATE;
        ushort STATE = 0;
        ushort LINEID = 0;
        ushort CALLID = 0;
        ushort ACTION = 0;
        CrestronString OUTGOINGMSG;
        CrestronString DIALPADTEXT;
        CrestronString [] STATUSTOKENS;
        CrestronString TOKEN;
        ushort STATUSTOKENCOUNT = 0;
        ushort NQTYOFPAGES = 0;
        ushort NCURRENTPAGE = 0;
        ushort NQTYENTRIESONLASTPAGE = 0;
        ushort NCURRENTCOUNT = 0;
        ushort NCURRENTPAGESIZE = 0;
        ushort NSELECTEDINDEX = 0;
        ushort IS_TOP = 0;
        ushort IS_BOTTOM = 0;
        ushort MYSTATUSCLASSCODE = 0;
        ushort MYDIALERCLASSCODE = 0;
        private CrestronString GETBOUNDSTRING (  SplusExecutionContext __context__, CrestronString SOURCE , CrestronString STARTSTRING , CrestronString ENDSTRING ) 
            { 
            ushort STARTINDEX = 0;
            
            ushort ENDINDEX = 0;
            
            CrestronString RESPONSE;
            RESPONSE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
            
            
            __context__.SourceCodeLine = 298;
            RESPONSE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 300;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SOURCE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 302;
                STARTINDEX = (ushort) ( Functions.Find( STARTSTRING , SOURCE ) ) ; 
                __context__.SourceCodeLine = 303;
                ENDINDEX = (ushort) ( Functions.Find( ENDSTRING , SOURCE , (STARTINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 305;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( STARTINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( STARTINDEX < ENDINDEX ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 307;
                    STARTINDEX = (ushort) ( (STARTINDEX + Functions.Length( STARTSTRING )) ) ; 
                    __context__.SourceCodeLine = 309;
                    RESPONSE  .UpdateValue ( Functions.Mid ( SOURCE ,  (int) ( STARTINDEX ) ,  (int) ( (ENDINDEX - STARTINDEX) ) )  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 313;
            return ( RESPONSE ) ; 
            
            }
            
        private ushort STRINGTOKENIZER (  SplusExecutionContext __context__, CrestronString [] TOKENLIST , CrestronString STRINGMSG , CrestronString DELIMITER ) 
            { 
            ushort NSTARTLOCATION = 0;
            
            ushort NFOUNDLOCATION = 0;
            
            ushort ITEM = 0;
            
            ushort CLEARITEM = 0;
            
            CrestronString TOKEN;
            TOKEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 324;
            ITEM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 326;
            NSTARTLOCATION = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 328;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 330;
                NFOUNDLOCATION = (ushort) ( Functions.Find( DELIMITER , STRINGMSG , NSTARTLOCATION ) ) ; 
                __context__.SourceCodeLine = 332;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NFOUNDLOCATION == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 333;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 335;
                TOKEN  .UpdateValue ( Functions.Mid ( STRINGMSG ,  (int) ( NSTARTLOCATION ) ,  (int) ( (NFOUNDLOCATION - NSTARTLOCATION) ) )  ) ; 
                __context__.SourceCodeLine = 337;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TOKEN ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 339;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (ITEM + 1) > Functions.GetNumArrayRows( TOKENLIST ) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 340;
                        break ; 
                        }
                    
                    __context__.SourceCodeLine = 342;
                    ITEM = (ushort) ( (ITEM + 1) ) ; 
                    __context__.SourceCodeLine = 344;
                    TOKENLIST [ ITEM]  .UpdateValue ( TOKEN  ) ; 
                    } 
                
                __context__.SourceCodeLine = 347;
                NSTARTLOCATION = (ushort) ( (NFOUNDLOCATION + Functions.Length( DELIMITER )) ) ; 
                __context__.SourceCodeLine = 328;
                } 
            
            __context__.SourceCodeLine = 350;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NSTARTLOCATION <= Functions.Length( STRINGMSG ) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (ITEM + 1) <= Functions.GetNumArrayRows( TOKENLIST ) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 352;
                ITEM = (ushort) ( (ITEM + 1) ) ; 
                __context__.SourceCodeLine = 354;
                TOKENLIST [ ITEM]  .UpdateValue ( Functions.Mid ( STRINGMSG ,  (int) ( NSTARTLOCATION ) ,  (int) ( ((Functions.Length( STRINGMSG ) - NSTARTLOCATION) + 1) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 357;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( (ITEM + 1) ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.GetNumArrayRows( TOKENLIST ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( CLEARITEM  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (CLEARITEM  >= __FN_FORSTART_VAL__1) && (CLEARITEM  <= __FN_FOREND_VAL__1) ) : ( (CLEARITEM  <= __FN_FORSTART_VAL__1) && (CLEARITEM  >= __FN_FOREND_VAL__1) ) ; CLEARITEM  += (ushort)__FN_FORSTEP_VAL__1) 
                {
                __context__.SourceCodeLine = 358;
                TOKENLIST [ CLEARITEM]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 357;
                }
            
            __context__.SourceCodeLine = 360;
            return (ushort)( ITEM) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG (  SplusExecutionContext __context__, CrestronString INSTANCETAG , CrestronString COMMAND , CrestronString CONTROL , ushort INDEX1 , ushort INDEX2 ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 370;
            MSG  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 372;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INDEX1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INDEX2 > 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 373;
                MakeString ( MSG , "{0} {1} {2} {3:d} {4:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX1, (short)INDEX2) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 374;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INDEX1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (INDEX2 == 0) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 375;
                    MakeString ( MSG , "{0} {1} {2} {3:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX1) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 376;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (INDEX1 == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( INDEX2 > 0 ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 377;
                        MakeString ( MSG , "{0} {1} {2} {3:d}", INSTANCETAG , COMMAND , CONTROL , (short)INDEX2) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 379;
                        MakeString ( MSG , "{0} {1} {2}", INSTANCETAG , COMMAND , CONTROL ) ; 
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 381;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHSTRINGVALUE (  SplusExecutionContext __context__, CrestronString INSTANCETAG , CrestronString COMMAND , CrestronString CONTROL , ushort INDEX1 , ushort INDEX2 , CrestronString VALUE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 388;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , INSTANCETAG, COMMAND, CONTROL, (ushort)( INDEX1 ), (ushort)( INDEX2 ))  ) ; 
            __context__.SourceCodeLine = 390;
            MakeString ( MSG , "{0} {1}", MSG , VALUE ) ; 
            __context__.SourceCodeLine = 392;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHINTEGERVALUE (  SplusExecutionContext __context__, CrestronString INSTANCETAG , CrestronString COMMAND , CrestronString CONTROL , ushort INDEX1 , ushort INDEX2 , ushort VALUE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 399;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , INSTANCETAG, COMMAND, CONTROL, (ushort)( INDEX1 ), (ushort)( INDEX2 ))  ) ; 
            __context__.SourceCodeLine = 401;
            MakeString ( MSG , "{0} {1:d}", MSG , (short)VALUE) ; 
            __context__.SourceCodeLine = 403;
            return ( MSG ) ; 
            
            }
            
        private CrestronString BUILDPROTOCOLMSG_WITHSTATEVALUE (  SplusExecutionContext __context__, CrestronString INSTANCETAG , CrestronString COMMAND , CrestronString CONTROL , ushort INDEX1 , ushort INDEX2 , ushort STATE ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 410;
            MSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , INSTANCETAG, COMMAND, CONTROL, (ushort)( INDEX1 ), (ushort)( INDEX2 ))  ) ; 
            __context__.SourceCodeLine = 412;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE == 1))  ) ) 
                {
                __context__.SourceCodeLine = 413;
                MakeString ( MSG , "{0} true", MSG ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 415;
                MakeString ( MSG , "{0} false", MSG ) ; 
                }
            
            __context__.SourceCodeLine = 417;
            return ( MSG ) ; 
            
            }
            
        private void GETALIAS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString OUTGOINGMSG;
            OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 426;
            MYSTATUSCLASSCODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 427;
            MYDIALERCLASSCODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 429;
            MakeString ( OUTGOINGMSG , "SESSION get alias {0}", DIALER_INSTANCETAG ) ; 
            __context__.SourceCodeLine = 430;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 432;
            MakeString ( OUTGOINGMSG , "SESSION get alias {0}", CONTROLSTATUS_INSTANCETAG ) ; 
            __context__.SourceCodeLine = 433;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            
            }
            
        private void GETINITIALIZED (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SUBSCRIBEOBJECT;
            SUBSCRIBEOBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort ENTRY = 0;
            
            
            __context__.SourceCodeLine = 441;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "autoAnswer", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 442;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 444;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "lastNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 445;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 447;
            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, "lastNum" ) ; 
            __context__.SourceCodeLine = 449;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "subscribe", "lastNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), SUBSCRIBEOBJECT)  ) ; 
            __context__.SourceCodeLine = 450;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 452;
            MakeString ( SUBSCRIBEOBJECT , "\u0022[{0:d}*{1}]\u0022", (short)MYID, "callState" ) ; 
            __context__.SourceCodeLine = 454;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "subscribe", "callState", (ushort)( 0 ), (ushort)( 0 ), SUBSCRIBEOBJECT)  ) ; 
            __context__.SourceCodeLine = 455;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 457;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "dndEnable", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 458;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 460;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "dndMode", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 461;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 463;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MYDIALERCLASSCODE == 5126))  ) ) 
                { 
                __context__.SourceCodeLine = 465;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)16; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( ENTRY  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ENTRY  >= __FN_FORSTART_VAL__1) && (ENTRY  <= __FN_FOREND_VAL__1) ) : ( (ENTRY  <= __FN_FORSTART_VAL__1) && (ENTRY  >= __FN_FOREND_VAL__1) ) ; ENTRY  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 467;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "get", "speedDialLabel", (ushort)( LINE_NUMBER  .Value ), (ushort)( ENTRY ))  ) ; 
                    __context__.SourceCodeLine = 468;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    __context__.SourceCodeLine = 470;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "get", "speedDialNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( ENTRY ))  ) ; 
                    __context__.SourceCodeLine = 471;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    __context__.SourceCodeLine = 465;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 475;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "lineInUse", (ushort)( LINE_NUMBER  .Value ), (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 476;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            
            }
            
        private void DOPOLL (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SUBSCRIBEOBJECT;
            SUBSCRIBEOBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort ENTRY = 0;
            
            
            __context__.SourceCodeLine = 484;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "autoAnswer", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 485;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 487;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "dndEnable", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 488;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 490;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "get", "dndMode", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 491;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            __context__.SourceCodeLine = 493;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MYDIALERCLASSCODE == 5126))  ) ) 
                { 
                __context__.SourceCodeLine = 495;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)16; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( ENTRY  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ENTRY  >= __FN_FORSTART_VAL__1) && (ENTRY  <= __FN_FOREND_VAL__1) ) : ( (ENTRY  <= __FN_FORSTART_VAL__1) && (ENTRY  >= __FN_FOREND_VAL__1) ) ; ENTRY  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 497;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "get", "speedDialLabel", (ushort)( LINE_NUMBER  .Value ), (ushort)( ENTRY ))  ) ; 
                    __context__.SourceCodeLine = 498;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    __context__.SourceCodeLine = 500;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "get", "speedDialNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( ENTRY ))  ) ; 
                    __context__.SourceCodeLine = 501;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "POLL_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    __context__.SourceCodeLine = 495;
                    } 
                
                } 
            
            
            }
            
        private ushort STARTSWITH (  SplusExecutionContext __context__, CrestronString MATCH_STRING , CrestronString SOURCE_STRING ) 
            { 
            
            __context__.SourceCodeLine = 511;
            return (ushort)( Functions.BoolToInt (Functions.Find( MATCH_STRING , SOURCE_STRING ) == 1)) ; 
            
            }
            
        private ushort CONTAINS (  SplusExecutionContext __context__, CrestronString MATCH_STRING , CrestronString SOURCE_STRING ) 
            { 
            
            __context__.SourceCodeLine = 516;
            return (ushort)( Functions.BoolToInt ( Functions.Find( MATCH_STRING , SOURCE_STRING ) > 0 )) ; 
            
            }
            
        private ushort ATOI_SIGNED (  SplusExecutionContext __context__, CrestronString VALUE ) 
            { 
            
            __context__.SourceCodeLine = 521;
            if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "-" , VALUE ))  ) ) 
                {
                __context__.SourceCodeLine = 522;
                return (ushort)( (0 - Functions.Atoi( VALUE ))) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 524;
                return (ushort)( Functions.Atoi( VALUE )) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString TRIM (  SplusExecutionContext __context__, CrestronString VALUE ) 
            { 
            
            __context__.SourceCodeLine = 529;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( VALUE , (int)( 1 ) ) == "\u0020"))  ) ) 
                {
                __context__.SourceCodeLine = 530;
                VALUE  .UpdateValue ( Functions.Right ( VALUE ,  (int) ( (Functions.Length( VALUE ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 529;
                }
            
            __context__.SourceCodeLine = 532;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( VALUE , (int)( 1 ) ) == "\u0020"))  ) ) 
                {
                __context__.SourceCodeLine = 533;
                VALUE  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( (Functions.Length( VALUE ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 532;
                }
            
            __context__.SourceCodeLine = 535;
            return ( VALUE ) ; 
            
            }
            
        private void SELECT_SPEEDDIALENTRY (  SplusExecutionContext __context__, ushort LISTITEM ) 
            { 
            
            __context__.SourceCodeLine = 543;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LISTITEM <= NCURRENTPAGESIZE ))  ) ) 
                { 
                __context__.SourceCodeLine = 545;
                NSELECTEDINDEX = (ushort) ( ((((NCURRENTPAGE - 1) * NCURRENTPAGESIZE) + 1) + (LISTITEM - 1)) ) ; 
                __context__.SourceCodeLine = 547;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ NSELECTEDINDEX ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 548;
                    SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__  .UpdateValue ( SPEEDDIALLIST [ NSELECTEDINDEX] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 550;
                    SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__  .UpdateValue ( SPEEDDIALLIST [ NSELECTEDINDEX] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 552;
                SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__  .UpdateValue ( SPEEDDIALLIST [ NSELECTEDINDEX] . NUMBER  ) ; 
                } 
            
            
            }
            
        private void DISPLAY_SPEEDDIALENTRY (  SplusExecutionContext __context__, ushort STARTINDEX , ushort DISPLAYCOUNT ) 
            { 
            CrestronString LABEL;
            LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 560;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 0) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 562;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 0) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 563;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 0)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 565;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 0)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 567;
                DIRECTORY_ITEM_01__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 570;
                DIRECTORY_ITEM_01__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 572;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 2 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 1) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 574;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 1) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 575;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 1)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 577;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 1)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 579;
                DIRECTORY_ITEM_02__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 582;
                DIRECTORY_ITEM_02__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 584;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 3 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 2) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 586;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 2) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 587;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 2)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 589;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 2)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 591;
                DIRECTORY_ITEM_03__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 594;
                DIRECTORY_ITEM_03__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 596;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 4 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 3) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 598;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 3) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 599;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 3)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 601;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 3)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 603;
                DIRECTORY_ITEM_04__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 606;
                DIRECTORY_ITEM_04__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 608;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 5 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 4) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 610;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 4) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 611;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 4)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 613;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 4)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 615;
                DIRECTORY_ITEM_05__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 618;
                DIRECTORY_ITEM_05__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 620;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 6 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 5) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 622;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 5) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 623;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 5)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 625;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 5)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 627;
                DIRECTORY_ITEM_06__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 630;
                DIRECTORY_ITEM_06__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 632;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 7 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 6) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 634;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 6) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 635;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 6)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 637;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 6)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 639;
                DIRECTORY_ITEM_07__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 642;
                DIRECTORY_ITEM_07__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 644;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 8 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 7) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 646;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 7) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 647;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 7)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 649;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 7)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 651;
                DIRECTORY_ITEM_08__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 654;
                DIRECTORY_ITEM_08__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 656;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 9 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 8) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 658;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 8) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 659;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 8)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 661;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 8)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 663;
                DIRECTORY_ITEM_09__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 666;
                DIRECTORY_ITEM_09__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 668;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 10 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 9) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 670;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 9) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 671;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 9)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 673;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 9)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 675;
                DIRECTORY_ITEM_10__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 678;
                DIRECTORY_ITEM_10__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 680;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 11 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 10) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 682;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 10) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 683;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 10)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 685;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 10)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 687;
                DIRECTORY_ITEM_11__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 690;
                DIRECTORY_ITEM_11__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 692;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 12 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 11) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 694;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 11) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 695;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 11)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 697;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 11)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 699;
                DIRECTORY_ITEM_12__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 702;
                DIRECTORY_ITEM_12__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 704;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 13 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 12) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 706;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 12) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 707;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 12)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 709;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 12)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 711;
                DIRECTORY_ITEM_13__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 714;
                DIRECTORY_ITEM_13__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 716;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 14 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 13) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 718;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 13) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 719;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 13)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 721;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 13)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 723;
                DIRECTORY_ITEM_14__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 726;
                DIRECTORY_ITEM_14__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 728;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 15 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 14) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 730;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 14) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 731;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 14)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 733;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 14)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 735;
                DIRECTORY_ITEM_15__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 738;
                DIRECTORY_ITEM_15__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            __context__.SourceCodeLine = 740;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYCOUNT >= 16 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (STARTINDEX + 15) <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 742;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPEEDDIALLIST[ (STARTINDEX + 15) ].LABEL ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 743;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 15)] . LABEL  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 745;
                    LABEL  .UpdateValue ( SPEEDDIALLIST [ (STARTINDEX + 15)] . DEFAULTLABEL  ) ; 
                    }
                
                __context__.SourceCodeLine = 747;
                DIRECTORY_ITEM_16__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 750;
                DIRECTORY_ITEM_16__DOLLAR__  .UpdateValue ( ""  ) ; 
                }
            
            
            }
            
        private void CLEAR_SPEEDDIALLIST (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 755;
            DISPLAY_SPEEDDIALENTRY (  __context__ , (ushort)( 1 ), (ushort)( 0 )) ; 
            
            }
            
        private void PAGE_SPEEDDIALLIST (  SplusExecutionContext __context__, ushort NPAGE ) 
            { 
            
            __context__.SourceCodeLine = 760;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NPAGE > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NPAGE <= NQTYOFPAGES ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 762;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPAGE == NQTYOFPAGES))  ) ) 
                    {
                    __context__.SourceCodeLine = 763;
                    DISPLAY_SPEEDDIALENTRY (  __context__ , (ushort)( (((NPAGE - 1) * NCURRENTPAGESIZE) + 1) ), (ushort)( NQTYENTRIESONLASTPAGE )) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 765;
                    DISPLAY_SPEEDDIALENTRY (  __context__ , (ushort)( (((NPAGE - 1) * NCURRENTPAGESIZE) + 1) ), (ushort)( NCURRENTPAGESIZE )) ; 
                    }
                
                __context__.SourceCodeLine = 767;
                NCURRENTPAGE = (ushort) ( NPAGE ) ; 
                __context__.SourceCodeLine = 769;
                IS_TOP = (ushort) ( Functions.BoolToInt (NCURRENTPAGE == 1) ) ; 
                __context__.SourceCodeLine = 770;
                IS_BOTTOM = (ushort) ( Functions.BoolToInt (NCURRENTPAGE == NQTYOFPAGES) ) ; 
                } 
            
            
            }
            
        private void UPDATE_SPEEDDIALLIST (  SplusExecutionContext __context__, ushort NCOUNT ) 
            { 
            
            __context__.SourceCodeLine = 776;
            NCURRENTCOUNT = (ushort) ( NCOUNT ) ; 
            __context__.SourceCodeLine = 778;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NCURRENTCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 780;
                NQTYOFPAGES = (ushort) ( (((NCURRENTCOUNT - 1) / NCURRENTPAGESIZE) + 1) ) ; 
                __context__.SourceCodeLine = 781;
                NQTYENTRIESONLASTPAGE = (ushort) ( (Mod( (NCURRENTCOUNT - 1) , NCURRENTPAGESIZE ) + 1) ) ; 
                __context__.SourceCodeLine = 783;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (NCURRENTPAGE == 0) ) || Functions.TestForTrue ( Functions.BoolToInt ( NCURRENTPAGE > NQTYOFPAGES ) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 784;
                    NCURRENTPAGE = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 786;
                PAGE_SPEEDDIALLIST (  __context__ , (ushort)( NCURRENTPAGE )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 790;
                NQTYOFPAGES = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 791;
                NQTYENTRIESONLASTPAGE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 792;
                NCURRENTPAGE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 794;
                IS_TOP = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 795;
                IS_BOTTOM = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 797;
                CLEAR_SPEEDDIALLIST (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 800;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 802;
                IS_TOP = (ushort) ( Functions.BoolToInt (NCURRENTPAGE == 1) ) ; 
                __context__.SourceCodeLine = 803;
                IS_BOTTOM = (ushort) ( Functions.BoolToInt (NCURRENTPAGE == NQTYOFPAGES) ) ; 
                } 
            
            
            }
            
        private void DISPLAY_LINEAPPEARANCECID (  SplusExecutionContext __context__, ushort CALLAPPEARANCE , CrestronString CID ) 
            { 
            CrestronString LABEL;
            LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            CrestronString NUM;
            NUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 815;
            STATUSTOKENCOUNT = (ushort) ( STRINGTOKENIZER( __context__ , STATUSTOKENS , CID , "\u005c\u0022" ) ) ; 
            __context__.SourceCodeLine = 817;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)STATUSTOKENCOUNT);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 821;
                        LABEL  .UpdateValue ( STATUSTOKENS [ 3 ]  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 825;
                        LABEL  .UpdateValue ( STATUSTOKENS [ 3 ]  ) ; 
                        __context__.SourceCodeLine = 826;
                        NUM  .UpdateValue ( STATUSTOKENS [ 4 ]  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 831;
                        LABEL  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 832;
                        NUM  .UpdateValue ( ""  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 836;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)CALLAPPEARANCE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 841;
                        CALL_1_CID_NAME__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                        __context__.SourceCodeLine = 842;
                        CALL_1_CID_NUM__DOLLAR__  .UpdateValue ( NUM  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 848;
                        CALL_2_CID_NAME__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                        __context__.SourceCodeLine = 849;
                        CALL_2_CID_NUM__DOLLAR__  .UpdateValue ( NUM  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 855;
                        CALL_3_CID_NAME__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                        __context__.SourceCodeLine = 856;
                        CALL_3_CID_NUM__DOLLAR__  .UpdateValue ( NUM  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 862;
                        CALL_4_CID_NAME__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                        __context__.SourceCodeLine = 863;
                        CALL_4_CID_NUM__DOLLAR__  .UpdateValue ( NUM  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 869;
                        CALL_5_CID_NAME__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                        __context__.SourceCodeLine = 870;
                        CALL_5_CID_NUM__DOLLAR__  .UpdateValue ( NUM  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 876;
                        CALL_6_CID_NAME__DOLLAR__  .UpdateValue ( LABEL  ) ; 
                        __context__.SourceCodeLine = 877;
                        CALL_6_CID_NUM__DOLLAR__  .UpdateValue ( NUM  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void DISPLAY_LINEAPPEARANCESTATE (  SplusExecutionContext __context__, ushort CALLAPPEARANCE , ushort STATE ) 
            { 
            CrestronString STATETEXT;
            STATETEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 886;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)STATE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 890;
                        STATETEXT  .UpdateValue ( "Init"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 894;
                        STATETEXT  .UpdateValue ( "Fault"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 898;
                        STATETEXT  .UpdateValue ( "Idle"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 902;
                        STATETEXT  .UpdateValue ( "Dial Tone"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 906;
                        STATETEXT  .UpdateValue ( "Silent"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 910;
                        STATETEXT  .UpdateValue ( "Dialing"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 914;
                        STATETEXT  .UpdateValue ( "Ringback"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 918;
                        STATETEXT  .UpdateValue ( "Incoming Call"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 922;
                        STATETEXT  .UpdateValue ( "Busy"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 926;
                        STATETEXT  .UpdateValue ( "Reject"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 930;
                        STATETEXT  .UpdateValue ( "Invalid Number"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 13) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 934;
                        STATETEXT  .UpdateValue ( "Active"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 14) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 938;
                        STATETEXT  .UpdateValue ( "Active Muted"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 15) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 942;
                        STATETEXT  .UpdateValue ( "On Hold"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 16) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 946;
                        STATETEXT  .UpdateValue ( "Waiting Ring"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 17) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 950;
                        STATETEXT  .UpdateValue ( "Conference Active"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 18) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 954;
                        STATETEXT  .UpdateValue ( "Conference Hold"  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 958;
            
                {
                int __SPLS_TMPVAR__SWTCH_4__ = ((int)CALLAPPEARANCE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 963;
                        CALL_1_STATE  .Value = (ushort) ( STATE ) ; 
                        __context__.SourceCodeLine = 964;
                        CALL_1_STATE__DOLLAR__  .UpdateValue ( STATETEXT  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 970;
                        CALL_2_STATE  .Value = (ushort) ( STATE ) ; 
                        __context__.SourceCodeLine = 971;
                        CALL_2_STATE__DOLLAR__  .UpdateValue ( STATETEXT  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 977;
                        CALL_3_STATE  .Value = (ushort) ( STATE ) ; 
                        __context__.SourceCodeLine = 978;
                        CALL_3_STATE__DOLLAR__  .UpdateValue ( STATETEXT  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 984;
                        CALL_4_STATE  .Value = (ushort) ( STATE ) ; 
                        __context__.SourceCodeLine = 985;
                        CALL_4_STATE__DOLLAR__  .UpdateValue ( STATETEXT  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 991;
                        CALL_5_STATE  .Value = (ushort) ( STATE ) ; 
                        __context__.SourceCodeLine = 992;
                        CALL_5_STATE__DOLLAR__  .UpdateValue ( STATETEXT  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 998;
                        CALL_6_STATE  .Value = (ushort) ( STATE ) ; 
                        __context__.SourceCodeLine = 999;
                        CALL_6_STATE__DOLLAR__  .UpdateValue ( STATETEXT  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void DISPLAY_LINEAPPEARANCEPROMPT (  SplusExecutionContext __context__, ushort CALLAPPEARANCE , ushort PROMPT ) 
            { 
            CrestronString PROMPTTEXT;
            PROMPTTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 1008;
            PROMPTTEXT  .UpdateValue ( "Unknown"  ) ; 
            __context__.SourceCodeLine = 1010;
            
                {
                int __SPLS_TMPVAR__SWTCH_5__ = ((int)PROMPT);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1014;
                        PROMPTTEXT  .UpdateValue ( "None"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1018;
                        PROMPTTEXT  .UpdateValue ( "Starting"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1022;
                        PROMPTTEXT  .UpdateValue ( "Registering"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1026;
                        PROMPTTEXT  .UpdateValue ( "SIP User Not Configured"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1030;
                        PROMPTTEXT  .UpdateValue ( "Enter Number"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1034;
                        PROMPTTEXT  .UpdateValue ( "Connecting"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1038;
                        PROMPTTEXT  .UpdateValue ( "Incoming Call"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1042;
                        PROMPTTEXT  .UpdateValue ( "Peer Busy"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1046;
                        PROMPTTEXT  .UpdateValue ( "Call Cannont Be Completed"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1050;
                        PROMPTTEXT  .UpdateValue ( "On Hold"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 13) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1054;
                        PROMPTTEXT  .UpdateValue ( "On Held"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 14) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1058;
                        PROMPTTEXT  .UpdateValue ( "Conference"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 15) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1062;
                        PROMPTTEXT  .UpdateValue ( "Conference On Hold"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 16) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1066;
                        PROMPTTEXT  .UpdateValue ( "Connected"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 17) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1070;
                        PROMPTTEXT  .UpdateValue ( "Connected Muted"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 18) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1074;
                        PROMPTTEXT  .UpdateValue ( "Auth Failure"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 19) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1078;
                        PROMPTTEXT  .UpdateValue ( "Proxy Not Configured"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 20) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1082;
                        PROMPTTEXT  .UpdateValue ( "Network Init"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 21) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1086;
                        PROMPTTEXT  .UpdateValue ( "DHCP In Progress"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 22) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1090;
                        PROMPTTEXT  .UpdateValue ( "Network Link Down"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 23) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1094;
                        PROMPTTEXT  .UpdateValue ( "Network Link Up"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 24) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1098;
                        PROMPTTEXT  .UpdateValue ( "IP Address Conflict"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 25) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1102;
                        PROMPTTEXT  .UpdateValue ( "Network Configured"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 26) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1106;
                        PROMPTTEXT  .UpdateValue ( "CODEC Negotiation Failure"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 27) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1110;
                        PROMPTTEXT  .UpdateValue ( "Unexpected Error"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 28) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1114;
                        PROMPTTEXT  .UpdateValue ( "Auth User Not Configured"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 29) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1118;
                        PROMPTTEXT  .UpdateValue ( "Auth Password Not Configured"  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 1122;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)CALLAPPEARANCE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1126;
                        CALL_1_PROMPT__DOLLAR__  .UpdateValue ( PROMPTTEXT  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1130;
                        CALL_2_PROMPT__DOLLAR__  .UpdateValue ( PROMPTTEXT  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1134;
                        CALL_3_PROMPT__DOLLAR__  .UpdateValue ( PROMPTTEXT  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1138;
                        CALL_4_PROMPT__DOLLAR__  .UpdateValue ( PROMPTTEXT  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1142;
                        CALL_5_PROMPT__DOLLAR__  .UpdateValue ( PROMPTTEXT  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1146;
                        CALL_6_PROMPT__DOLLAR__  .UpdateValue ( PROMPTTEXT  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            }
            
        private void UPDATE_CALLAPPEARANCES (  SplusExecutionContext __context__ ) 
            { 
            ushort CALLID = 0;
            
            
            __context__.SourceCodeLine = 1154;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)6; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( CALLID  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (CALLID  >= __FN_FORSTART_VAL__1) && (CALLID  <= __FN_FOREND_VAL__1) ) : ( (CALLID  <= __FN_FORSTART_VAL__1) && (CALLID  >= __FN_FOREND_VAL__1) ) ; CALLID  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1156;
                DISPLAY_LINEAPPEARANCESTATE (  __context__ , (ushort)( CALLID ), (ushort)( CALLSTATUS[ CALLID ].STATUS )) ; 
                __context__.SourceCodeLine = 1157;
                DISPLAY_LINEAPPEARANCEPROMPT (  __context__ , (ushort)( CALLID ), (ushort)( CALLSTATUS[ CALLID ].PROMPT )) ; 
                __context__.SourceCodeLine = 1158;
                DISPLAY_LINEAPPEARANCECID (  __context__ , (ushort)( CALLID ), CALLSTATUS[ CALLID ].CID) ; 
                __context__.SourceCodeLine = 1154;
                } 
            
            
            }
            
        private ushort CALLAPPEARANCE_ALLOWDTMF (  SplusExecutionContext __context__, ushort CALLAPPEARANCE ) 
            { 
            
            __context__.SourceCodeLine = 1164;
            
                {
                int __SPLS_TMPVAR__SWTCH_7__ = ((int)CALLAPPEARANCE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1168;
                        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALL_1_STATE  .Value == 4) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_1_STATE  .Value == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_1_STATE  .Value == 17) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_1_STATE  .Value == 5) )) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1172;
                        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALL_2_STATE  .Value == 4) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_2_STATE  .Value == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_2_STATE  .Value == 17) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_2_STATE  .Value == 5) )) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1176;
                        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALL_3_STATE  .Value == 4) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_3_STATE  .Value == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_3_STATE  .Value == 17) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_3_STATE  .Value == 5) )) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1180;
                        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALL_4_STATE  .Value == 4) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_4_STATE  .Value == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_4_STATE  .Value == 17) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_4_STATE  .Value == 5) )) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1184;
                        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALL_5_STATE  .Value == 4) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_5_STATE  .Value == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_5_STATE  .Value == 17) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_5_STATE  .Value == 5) )) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1188;
                        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALL_6_STATE  .Value == 4) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_6_STATE  .Value == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_6_STATE  .Value == 17) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CALL_6_STATE  .Value == 5) )) )) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void DIALPADKEYPRESS (  SplusExecutionContext __context__, CrestronString KEYCODE ) 
            { 
            
            __context__.SourceCodeLine = 1197;
            MakeString ( DIALPADTEXT , "{0}{1}", DIALPADTEXT , KEYCODE ) ; 
            __context__.SourceCodeLine = 1199;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1201;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALLAPPEARANCE_ALLOWDTMF( __context__ , (ushort)( CALL_SELECT  .UshortValue ) ) == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1204;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "dtmf", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( 0 ), (ushort)( 0 ), KEYCODE)  ) ; 
                    __context__.SourceCodeLine = 1205;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1209;
            KEYPAD__DOLLAR__  .UpdateValue ( DIALPADTEXT  ) ; 
            
            }
            
        private void DIALPADCLEAR (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1214;
            DIALPADTEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1216;
            KEYPAD__DOLLAR__  .UpdateValue ( DIALPADTEXT  ) ; 
            
            }
            
        object POLL_DIALER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1227;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 1228;
                    DOPOLL (  __context__  ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CALL_SELECT_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1236;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1238;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SELECTED_CALL  .Value != CALL_SELECT  .UshortValue))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1240;
                    SELECTED_CALL  .Value = (ushort) ( CALL_SELECT  .UshortValue ) ; 
                    __context__.SourceCodeLine = 1241;
                    DIALPADCLEAR (  __context__  ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CONFERENCE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1248;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1250;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1252;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "lconf", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1253;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1260;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1262;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1264;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "answer", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1265;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FLASH_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1272;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1274;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1276;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "flash", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1277;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REDIAL_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1284;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1286;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1288;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "redial", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1289;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1296;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1298;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1300;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "send", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1301;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1308;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1310;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1312;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "end", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1313;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESUME_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1320;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1322;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1324;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "resume", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1325;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOLD_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1332;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1334;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1336;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "hold", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1337;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ON_HOOK_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1344;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1346;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1348;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "onHook", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1349;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_HOOK_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1356;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1358;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1360;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG (  __context__ , CONTROLSTATUS_INSTANCETAG , "offHook", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1361;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOANSWER_ON_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1371;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1373;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "autoAnswer", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 1374;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOANSWER_OFF_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1380;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1382;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "autoAnswer", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 1383;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOANSWER_TOGGLE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1389;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1391;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "autoAnswer", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), (ushort)( Functions.Not( AUTOANSWER_IS_ON  .Value ) ))  ) ; 
            __context__.SourceCodeLine = 1392;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_0_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1401;
        DIALPADKEYPRESS (  __context__ , "0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_1_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1406;
        DIALPADKEYPRESS (  __context__ , "1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_2_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1411;
        DIALPADKEYPRESS (  __context__ , "2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_3_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1416;
        DIALPADKEYPRESS (  __context__ , "3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_4_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1421;
        DIALPADKEYPRESS (  __context__ , "4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_5_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1426;
        DIALPADKEYPRESS (  __context__ , "5") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_6_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1431;
        DIALPADKEYPRESS (  __context__ , "6") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_7_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1436;
        DIALPADKEYPRESS (  __context__ , "7") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_8_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1441;
        DIALPADKEYPRESS (  __context__ , "8") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_9_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1446;
        DIALPADKEYPRESS (  __context__ , "9") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_STAR_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1451;
        DIALPADKEYPRESS (  __context__ , "*") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_POUND_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1456;
        DIALPADKEYPRESS (  __context__ , "#") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_CLEAR_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1461;
        DIALPADCLEAR (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_BACKSPACE_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1466;
        DIALPADTEXT  .UpdateValue ( Functions.Left ( DIALPADTEXT ,  (int) ( (Functions.Length( DIALPADTEXT ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 1468;
        KEYPAD__DOLLAR__  .UpdateValue ( DIALPADTEXT  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_DIAL_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1473;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1475;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1477;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( DIALPADTEXT ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1479;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "dial", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ), DIALPADTEXT)  ) ; 
                    __context__.SourceCodeLine = 1480;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALPHANUMERIC_ENTRY_DIAL_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString NUMBERTODIAL;
        NUMBERTODIAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        
        
        __context__.SourceCodeLine = 1493;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1495;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1497;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( ALPHANUMERIC_ENTRY__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1499;
                    MakeString ( NUMBERTODIAL , "\u0022{0}\u0022", ALPHANUMERIC_ENTRY__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 1501;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "dial", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ), NUMBERTODIAL)  ) ; 
                    __context__.SourceCodeLine = 1502;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_ENABLED_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1513;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1515;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "dndEnable", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 1517;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_DISABLED_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1523;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1525;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "dndEnable", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), (ushort)( 0 ))  ) ; 
            __context__.SourceCodeLine = 1527;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_TOGGLE_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1533;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1535;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTATEVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "dndEnable", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), (ushort)( Functions.Not( DND_IS_ENABLED  .Value ) ))  ) ; 
            __context__.SourceCodeLine = 1537;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_RESPONSE_DND_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1543;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1545;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "dndMode", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), "DND_480")  ) ; 
            __context__.SourceCodeLine = 1547;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_RESPONSE_BUSY_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1553;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1555;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "dndMode", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), "DND_486")  ) ; 
            __context__.SourceCodeLine = 1557;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_RESPONSE_DECLINE_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1563;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1565;
            OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , CONTROLSTATUS_INSTANCETAG , "set", "dndMode", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 ), "DND_603")  ) ; 
            __context__.SourceCodeLine = 1567;
            MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTORY_TOP_PAGE_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1576;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_TOP == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1577;
            PAGE_SPEEDDIALLIST (  __context__ , (ushort)( 1 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTORY_NEXT_PAGE_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1582;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_BOTTOM == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1583;
            PAGE_SPEEDDIALLIST (  __context__ , (ushort)( (NCURRENTPAGE + 1) )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTORY_PREVIOUS_PAGE_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1588;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_TOP == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1589;
            PAGE_SPEEDDIALLIST (  __context__ , (ushort)( (NCURRENTPAGE - 1) )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTORY_BOTTOM_PAGE_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1594;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_BOTTOM == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1595;
            PAGE_SPEEDDIALLIST (  __context__ , (ushort)( NQTYOFPAGES )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_01_OnPush_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1600;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_02_OnPush_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1605;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_03_OnPush_43 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1610;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_04_OnPush_44 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1615;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_05_OnPush_45 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1620;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_06_OnPush_46 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1625;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_07_OnPush_47 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1630;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_08_OnPush_48 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1635;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 8 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_09_OnPush_49 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1640;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 9 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_10_OnPush_50 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1645;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 10 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_11_OnPush_51 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1650;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 11 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_12_OnPush_52 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1655;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 12 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_13_OnPush_53 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1660;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 13 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_14_OnPush_54 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1665;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 14 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_15_OnPush_55 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1670;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 15 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_16_OnPush_56 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1675;
        SELECT_SPEEDDIALENTRY (  __context__ , (ushort)( 16 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIAL_SELECTED_DIRECTORY_ITEM_OnPush_57 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1680;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1682;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1684;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NSELECTEDINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NSELECTEDINDEX <= 16 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1686;
                    OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHINTEGERVALUE (  __context__ , DIALER_INSTANCETAG , "speedDial", Functions.ItoA( (int)( LINE_NUMBER  .Value ) ), (ushort)( CALL_SELECT  .UshortValue ), (ushort)( 0 ), (ushort)( NSELECTEDINDEX ))  ) ; 
                    __context__.SourceCodeLine = 1687;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_DIRECTORY_ENTRY_OnPush_58 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString LABEL;
        LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        CrestronString NUM;
        NUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        
        __context__.SourceCodeLine = 1701;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1703;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SELECT_DIRECTORY_SAVE_LOCATION  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SELECT_DIRECTORY_SAVE_LOCATION  .UshortValue <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1705;
                MakeString ( LABEL , "\u0022{0}\u0022", DIRECTORY_SAVE_NAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1706;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , DIALER_INSTANCETAG , "set", "speedDialLabel", (ushort)( LINE_NUMBER  .Value ), (ushort)( SELECT_DIRECTORY_SAVE_LOCATION  .UshortValue ), LABEL)  ) ; 
                __context__.SourceCodeLine = 1707;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                __context__.SourceCodeLine = 1709;
                MakeString ( NUM , "\u0022{0}\u0022", DIRECTORY_SAVE_NUM__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1710;
                OUTGOINGMSG  .UpdateValue ( BUILDPROTOCOLMSG_WITHSTRINGVALUE (  __context__ , DIALER_INSTANCETAG , "set", "speedDialNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( SELECT_DIRECTORY_SAVE_LOCATION  .UshortValue ), NUM)  ) ; 
                __context__.SourceCodeLine = 1711;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "COMMAND_MSG<{0:d}|{1}>", (short)MYID, OUTGOINGMSG ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void PROCESSPROCESSORMSG (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 1723;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PARSEDMODULEMSG ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 1725;
        if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "REGISTER" , PARSEDMODULEMSG ))  ) ) 
            { 
            __context__.SourceCodeLine = 1727;
            MYID = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , PARSEDMODULEMSG , "<" , ">" ) ) ) ; 
            __context__.SourceCodeLine = 1729;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MYID > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 1730;
                MakeString ( TO_PROCESSOR__DOLLAR__ , "REGISTER<{0:d}>", (short)MYID) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1732;
            if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "INIT" , PARSEDMODULEMSG ))  ) ) 
                { 
                __context__.SourceCodeLine = 1734;
                IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1735;
                GETALIAS (  __context__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1737;
                if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "RESPONSE_MSG" , PARSEDMODULEMSG ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1739;
                    RESPONSEREQUESTMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "<", "|")  ) ; 
                    __context__.SourceCodeLine = 1740;
                    RESPONSEMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "|", ">")  ) ; 
                    __context__.SourceCodeLine = 1742;
                    MakeString ( TO_PROCESSOR__DOLLAR__ , "RESPONSE_OK<{0:d}|{1}>", (short)MYID, RESPONSEREQUESTMSG ) ; 
                    __context__.SourceCodeLine = 1744;
                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "get" , RESPONSEREQUESTMSG ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1746;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "lineInUse" , RESPONSEREQUESTMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1748;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1750;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IS_INITIALIZED  .Value == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1752;
                                    IS_INITIALIZED  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 1753;
                                    MakeString ( TO_PROCESSOR__DOLLAR__ , "INIT_DONE<{0:d}>", (short)MYID) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1757;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "autoAnswer" , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1759;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1761;
                                    AUTOANSWER_IS_ON  .Value = (ushort) ( CONTAINS( __context__ , "true" , RESPONSEMSG ) ) ; 
                                    __context__.SourceCodeLine = 1762;
                                    AUTOANSWER_IS_OFF  .Value = (ushort) ( CONTAINS( __context__ , "false" , RESPONSEMSG ) ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1765;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "lastNum" , RESPONSEREQUESTMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1767;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1769;
                                        TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                        __context__.SourceCodeLine = 1770;
                                        PARSESTRING  .UpdateValue ( GETBOUNDSTRING (  __context__ , RESPONSEMSG, "\u0022", "\u0022")  ) ; 
                                        __context__.SourceCodeLine = 1771;
                                        LAST_NUMBER_DIALED__DOLLAR__  .UpdateValue ( PARSESTRING  ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1774;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "dndEnable" , RESPONSEREQUESTMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1776;
                                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1778;
                                            DND_IS_ENABLED  .Value = (ushort) ( CONTAINS( __context__ , "true" , RESPONSEMSG ) ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1781;
                                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "dndMode" , RESPONSEREQUESTMSG ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1783;
                                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1785;
                                                DND_RESPONSE_IS_DND  .Value = (ushort) ( CONTAINS( __context__ , " 1" , RESPONSEMSG ) ) ; 
                                                __context__.SourceCodeLine = 1786;
                                                DND_RESPONSE_IS_BUSY  .Value = (ushort) ( CONTAINS( __context__ , " 2" , RESPONSEMSG ) ) ; 
                                                __context__.SourceCodeLine = 1787;
                                                DND_RESPONSE_IS_DECLINE  .Value = (ushort) ( CONTAINS( __context__ , " 3" , RESPONSEMSG ) ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1790;
                                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "speedDialLabel" , RESPONSEREQUESTMSG ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1792;
                                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1794;
                                                    TRASH  .UpdateValue ( Functions.Remove ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "get", "speedDialLabel", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 )) , RESPONSEREQUESTMSG )  ) ; 
                                                    __context__.SourceCodeLine = 1796;
                                                    PARSEINT = (ushort) ( Functions.Atoi( RESPONSEREQUESTMSG ) ) ; 
                                                    __context__.SourceCodeLine = 1798;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT <= 16 ) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1800;
                                                        TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                                        __context__.SourceCodeLine = 1801;
                                                        PARSESTRING  .UpdateValue ( GETBOUNDSTRING (  __context__ , RESPONSEMSG, "\u0022", "\u0022")  ) ; 
                                                        __context__.SourceCodeLine = 1802;
                                                        SPEEDDIALLIST [ PARSEINT] . LABEL  .UpdateValue ( PARSESTRING  ) ; 
                                                        __context__.SourceCodeLine = 1804;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PARSEINT == 16))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 1805;
                                                            UPDATE_SPEEDDIALLIST (  __context__ , (ushort)( 16 )) ; 
                                                            }
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1809;
                                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "speedDialNum" , RESPONSEREQUESTMSG ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1811;
                                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1813;
                                                        TRASH  .UpdateValue ( Functions.Remove ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "get", "speedDialNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 )) , RESPONSEREQUESTMSG )  ) ; 
                                                        __context__.SourceCodeLine = 1815;
                                                        PARSEINT = (ushort) ( Functions.Atoi( RESPONSEREQUESTMSG ) ) ; 
                                                        __context__.SourceCodeLine = 1817;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT <= 16 ) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1819;
                                                            TRASH  .UpdateValue ( Functions.Remove ( "+OK " , RESPONSEMSG )  ) ; 
                                                            __context__.SourceCodeLine = 1820;
                                                            PARSESTRING  .UpdateValue ( GETBOUNDSTRING (  __context__ , RESPONSEMSG, "\u0022", "\u0022")  ) ; 
                                                            __context__.SourceCodeLine = 1821;
                                                            SPEEDDIALLIST [ PARSEINT] . NUMBER  .UpdateValue ( PARSESTRING  ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1825;
                                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "alias" , RESPONSEREQUESTMSG ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1827;
                                                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1829;
                                                            TRASH  .UpdateValue ( Functions.Remove ( "+OK [" , RESPONSEMSG )  ) ; 
                                                            __context__.SourceCodeLine = 1831;
                                                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , DIALER_INSTANCETAG  , RESPONSEREQUESTMSG ))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 1832;
                                                                MYDIALERCLASSCODE = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , RESPONSEMSG , " " , " " ) ) ) ; 
                                                                }
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1834;
                                                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , CONTROLSTATUS_INSTANCETAG  , RESPONSEREQUESTMSG ))  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 1835;
                                                                    MYSTATUSCLASSCODE = (ushort) ( Functions.Atoi( GETBOUNDSTRING( __context__ , RESPONSEMSG , " " , " " ) ) ) ; 
                                                                    }
                                                                
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 1838;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (MYSTATUSCLASSCODE == 1032) ) || Functions.TestForTrue ( Functions.BoolToInt (MYSTATUSCLASSCODE == 5128) )) ))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 1839;
                                                                GETINITIALIZED (  __context__  ) ; 
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
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1843;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "set" , RESPONSEREQUESTMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1845;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "autoAnswer" , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1847;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1849;
                                    AUTOANSWER_IS_ON  .Value = (ushort) ( CONTAINS( __context__ , "true" , RESPONSEREQUESTMSG ) ) ; 
                                    __context__.SourceCodeLine = 1850;
                                    AUTOANSWER_IS_OFF  .Value = (ushort) ( CONTAINS( __context__ , "false" , RESPONSEREQUESTMSG ) ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1853;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "dndEnable" , RESPONSEREQUESTMSG ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1855;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1857;
                                        DND_IS_ENABLED  .Value = (ushort) ( CONTAINS( __context__ , "true" , RESPONSEREQUESTMSG ) ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1860;
                                    if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "dndMode" , RESPONSEREQUESTMSG ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1862;
                                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1864;
                                            DND_RESPONSE_IS_DND  .Value = (ushort) ( CONTAINS( __context__ , "DND_480" , RESPONSEREQUESTMSG ) ) ; 
                                            __context__.SourceCodeLine = 1865;
                                            DND_RESPONSE_IS_BUSY  .Value = (ushort) ( CONTAINS( __context__ , "DND_486" , RESPONSEREQUESTMSG ) ) ; 
                                            __context__.SourceCodeLine = 1866;
                                            DND_RESPONSE_IS_DECLINE  .Value = (ushort) ( CONTAINS( __context__ , "DND_603" , RESPONSEREQUESTMSG ) ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1869;
                                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "speedDialLabel" , RESPONSEREQUESTMSG ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1871;
                                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1873;
                                                TRASH  .UpdateValue ( Functions.Remove ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "set", "speedDialLabel", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 )) , RESPONSEREQUESTMSG )  ) ; 
                                                __context__.SourceCodeLine = 1875;
                                                PARSEINT = (ushort) ( Functions.Atoi( RESPONSEREQUESTMSG ) ) ; 
                                                __context__.SourceCodeLine = 1877;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT <= 16 ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1879;
                                                    PARSESTRING  .UpdateValue ( GETBOUNDSTRING (  __context__ , RESPONSEREQUESTMSG, "\u0022", "\u0022")  ) ; 
                                                    __context__.SourceCodeLine = 1880;
                                                    SPEEDDIALLIST [ PARSEINT] . LABEL  .UpdateValue ( PARSESTRING  ) ; 
                                                    __context__.SourceCodeLine = 1881;
                                                    UPDATE_SPEEDDIALLIST (  __context__ , (ushort)( 16 )) ; 
                                                    } 
                                                
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1885;
                                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "speedDialNum" , RESPONSEREQUESTMSG ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1887;
                                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "+OK" , RESPONSEMSG ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1889;
                                                    TRASH  .UpdateValue ( Functions.Remove ( BUILDPROTOCOLMSG (  __context__ , DIALER_INSTANCETAG , "set", "speedDialNum", (ushort)( LINE_NUMBER  .Value ), (ushort)( 0 )) , RESPONSEREQUESTMSG )  ) ; 
                                                    __context__.SourceCodeLine = 1891;
                                                    PARSEINT = (ushort) ( Functions.Atoi( RESPONSEREQUESTMSG ) ) ; 
                                                    __context__.SourceCodeLine = 1893;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PARSEINT <= 16 ) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1895;
                                                        PARSESTRING  .UpdateValue ( GETBOUNDSTRING (  __context__ , RESPONSEREQUESTMSG, "\u0022", "\u0022")  ) ; 
                                                        __context__.SourceCodeLine = 1896;
                                                        SPEEDDIALLIST [ PARSEINT] . NUMBER  .UpdateValue ( PARSESTRING  ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1901;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "subscribe" , RESPONSEREQUESTMSG ))  ) ) 
                                { 
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1905;
                    if ( Functions.TestForTrue  ( ( STARTSWITH( __context__ , "SUBSCRIBED_MSG" , PARSEDMODULEMSG ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1907;
                        RESPONSEMSG  .UpdateValue ( GETBOUNDSTRING (  __context__ , PARSEDMODULEMSG, "<", ">")  ) ; 
                        __context__.SourceCodeLine = 1909;
                        if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "callState" , RESPONSEMSG ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1911;
                            TRASH  .UpdateValue ( Functions.Remove ( "[[" , RESPONSEMSG )  ) ; 
                            __context__.SourceCodeLine = 1913;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "]" , RESPONSEMSG ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1915;
                                CALLSTATE  .UpdateValue ( Functions.Remove ( "]" , RESPONSEMSG )  ) ; 
                                __context__.SourceCodeLine = 1917;
                                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "[" , CALLSTATE ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1919;
                                    TRASH  .UpdateValue ( Functions.Remove ( "[" , CALLSTATE )  ) ; 
                                    __context__.SourceCodeLine = 1921;
                                    STATE = (ushort) ( Functions.Atoi( Functions.Remove( " " , CALLSTATE ) ) ) ; 
                                    __context__.SourceCodeLine = 1922;
                                    LINEID = (ushort) ( Functions.Atoi( Functions.Remove( " " , CALLSTATE ) ) ) ; 
                                    __context__.SourceCodeLine = 1923;
                                    CALLID = (ushort) ( Functions.Atoi( Functions.Remove( " " , CALLSTATE ) ) ) ; 
                                    __context__.SourceCodeLine = 1924;
                                    ACTION = (ushort) ( Functions.Atoi( Functions.Remove( " " , CALLSTATE ) ) ) ; 
                                    __context__.SourceCodeLine = 1926;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LINE_NUMBER  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (LINEID == 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LINE_NUMBER  .Value == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (LINEID == 1) )) ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1928;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALLID >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALLID < 6 ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1930;
                                            CALLSTATUS [ (CALLID + 1)] . STATUS = (ushort) ( STATE ) ; 
                                            __context__.SourceCodeLine = 1931;
                                            CALLSTATUS [ (CALLID + 1)] . CID  .UpdateValue ( Functions.Remove ( "\u0022 " , CALLSTATE )  ) ; 
                                            __context__.SourceCodeLine = 1932;
                                            CALLSTATUS [ (CALLID + 1)] . PROMPT = (ushort) ( Functions.Atoi( Functions.Remove( "]" , CALLSTATE ) ) ) ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                
                                __context__.SourceCodeLine = 1913;
                                } 
                            
                            __context__.SourceCodeLine = 1938;
                            UPDATE_CALLAPPEARANCES (  __context__  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1940;
                            if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , "lastNum" , RESPONSEMSG ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1942;
                                TRASH  .UpdateValue ( Functions.Remove ( "]\u0022" , RESPONSEMSG )  ) ; 
                                __context__.SourceCodeLine = 1943;
                                PARSESTRING  .UpdateValue ( GETBOUNDSTRING (  __context__ , RESPONSEMSG, "\u0022", "\u0022")  ) ; 
                                __context__.SourceCodeLine = 1944;
                                LAST_NUMBER_DIALED__DOLLAR__  .UpdateValue ( PARSESTRING  ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    }
                
                }
            
            }
        
        } 
    
    
    }
    
object FROM_PROCESSOR__DOLLAR___OnChange_59 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1953;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 1955;
            try 
                { 
                __context__.SourceCodeLine = 1957;
                PARSEDMODULEMSG  .UpdateValue ( Functions.Gather ( ">" , FROM_PROCESSOR__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 1959;
                if ( Functions.TestForTrue  ( ( CONTAINS( __context__ , PARSEDMODULEMSG , FROM_PROCESSOR__DOLLAR__ ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1960;
                    Functions.ClearBuffer ( FROM_PROCESSOR__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 1962;
                PROCESSPROCESSORMSG (  __context__  ) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 1966;
                Print( "Issue with Processor message handeling\r\n") ; 
                
                }
                
                __context__.SourceCodeLine = 1953;
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
        
        __context__.SourceCodeLine = 2000;
        PARSINGMODULEBUSY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2003;
        IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2005;
        NCURRENTPAGESIZE = (ushort) ( SPEEDDIALLIST_PAGESIZE  .Value ) ; 
        __context__.SourceCodeLine = 2007;
        NSELECTEDINDEX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2008;
        SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2009;
        SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2011;
        IS_TOP = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2012;
        IS_BOTTOM = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2014;
        MYSTATUSCLASSCODE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2015;
        MYDIALERCLASSCODE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2017;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)16; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 2019;
            MakeString ( SPEEDDIALLIST [ X] . LABEL , "") ; 
            __context__.SourceCodeLine = 2020;
            MakeString ( SPEEDDIALLIST [ X] . NUMBER , "") ; 
            __context__.SourceCodeLine = 2021;
            MakeString ( SPEEDDIALLIST [ X] . DEFAULTLABEL , "SpeedDial Entry {0:d}", (short)X) ; 
            __context__.SourceCodeLine = 2017;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    PARSEDMODULEMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
    RESPONSEREQUESTMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    RESPONSEMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
    PARSESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    CALLSTATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
    OUTGOINGMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    DIALPADTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    TOKEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    STATUSTOKENS  = new CrestronString[ 11 ];
    for( uint i = 0; i < 11; i++ )
        STATUSTOKENS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    SPEEDDIALLIST  = new SPEEDDIALENTRY[ 17 ];
    for( uint i = 0; i < 17; i++ )
    {
        SPEEDDIALLIST [i] = new SPEEDDIALENTRY( this, true );
        SPEEDDIALLIST [i].PopulateCustomAttributeList( false );
        
    }
    CALLSTATUS  = new CALLSTATUSINFO[ 7 ];
    for( uint i = 0; i < 7; i++ )
    {
        CALLSTATUS [i] = new CALLSTATUSINFO( this, true );
        CALLSTATUS [i].PopulateCustomAttributeList( false );
        
    }
    
    POLL_DIALER = new Crestron.Logos.SplusObjects.DigitalInput( POLL_DIALER__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_DIALER__DigitalInput__, POLL_DIALER );
    
    CONFERENCE = new Crestron.Logos.SplusObjects.DigitalInput( CONFERENCE__DigitalInput__, this );
    m_DigitalInputList.Add( CONFERENCE__DigitalInput__, CONFERENCE );
    
    ANSWER = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER__DigitalInput__, ANSWER );
    
    FLASH = new Crestron.Logos.SplusObjects.DigitalInput( FLASH__DigitalInput__, this );
    m_DigitalInputList.Add( FLASH__DigitalInput__, FLASH );
    
    REDIAL = new Crestron.Logos.SplusObjects.DigitalInput( REDIAL__DigitalInput__, this );
    m_DigitalInputList.Add( REDIAL__DigitalInput__, REDIAL );
    
    SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
    m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
    
    END = new Crestron.Logos.SplusObjects.DigitalInput( END__DigitalInput__, this );
    m_DigitalInputList.Add( END__DigitalInput__, END );
    
    RESUME = new Crestron.Logos.SplusObjects.DigitalInput( RESUME__DigitalInput__, this );
    m_DigitalInputList.Add( RESUME__DigitalInput__, RESUME );
    
    HOLD = new Crestron.Logos.SplusObjects.DigitalInput( HOLD__DigitalInput__, this );
    m_DigitalInputList.Add( HOLD__DigitalInput__, HOLD );
    
    ON_HOOK = new Crestron.Logos.SplusObjects.DigitalInput( ON_HOOK__DigitalInput__, this );
    m_DigitalInputList.Add( ON_HOOK__DigitalInput__, ON_HOOK );
    
    OFF_HOOK = new Crestron.Logos.SplusObjects.DigitalInput( OFF_HOOK__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_HOOK__DigitalInput__, OFF_HOOK );
    
    KEYPAD_0 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_0__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_0__DigitalInput__, KEYPAD_0 );
    
    KEYPAD_1 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_1__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_1__DigitalInput__, KEYPAD_1 );
    
    KEYPAD_2 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_2__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_2__DigitalInput__, KEYPAD_2 );
    
    KEYPAD_3 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_3__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_3__DigitalInput__, KEYPAD_3 );
    
    KEYPAD_4 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_4__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_4__DigitalInput__, KEYPAD_4 );
    
    KEYPAD_5 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_5__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_5__DigitalInput__, KEYPAD_5 );
    
    KEYPAD_6 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_6__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_6__DigitalInput__, KEYPAD_6 );
    
    KEYPAD_7 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_7__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_7__DigitalInput__, KEYPAD_7 );
    
    KEYPAD_8 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_8__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_8__DigitalInput__, KEYPAD_8 );
    
    KEYPAD_9 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_9__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_9__DigitalInput__, KEYPAD_9 );
    
    KEYPAD_STAR = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_STAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_STAR__DigitalInput__, KEYPAD_STAR );
    
    KEYPAD_POUND = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_POUND__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_POUND__DigitalInput__, KEYPAD_POUND );
    
    KEYPAD_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_CLEAR__DigitalInput__, KEYPAD_CLEAR );
    
    KEYPAD_BACKSPACE = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_BACKSPACE__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_BACKSPACE__DigitalInput__, KEYPAD_BACKSPACE );
    
    KEYPAD_DIAL = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_DIAL__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_DIAL__DigitalInput__, KEYPAD_DIAL );
    
    AUTOANSWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( AUTOANSWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOANSWER_ON__DigitalInput__, AUTOANSWER_ON );
    
    AUTOANSWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( AUTOANSWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOANSWER_OFF__DigitalInput__, AUTOANSWER_OFF );
    
    AUTOANSWER_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( AUTOANSWER_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOANSWER_TOGGLE__DigitalInput__, AUTOANSWER_TOGGLE );
    
    DIRECTORY_TOP_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( DIRECTORY_TOP_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( DIRECTORY_TOP_PAGE__DigitalInput__, DIRECTORY_TOP_PAGE );
    
    DIRECTORY_NEXT_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( DIRECTORY_NEXT_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( DIRECTORY_NEXT_PAGE__DigitalInput__, DIRECTORY_NEXT_PAGE );
    
    DIRECTORY_PREVIOUS_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( DIRECTORY_PREVIOUS_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( DIRECTORY_PREVIOUS_PAGE__DigitalInput__, DIRECTORY_PREVIOUS_PAGE );
    
    DIRECTORY_BOTTOM_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( DIRECTORY_BOTTOM_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( DIRECTORY_BOTTOM_PAGE__DigitalInput__, DIRECTORY_BOTTOM_PAGE );
    
    SELECT_DIRECTORY_ITEM_01 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_01__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_01__DigitalInput__, SELECT_DIRECTORY_ITEM_01 );
    
    SELECT_DIRECTORY_ITEM_02 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_02__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_02__DigitalInput__, SELECT_DIRECTORY_ITEM_02 );
    
    SELECT_DIRECTORY_ITEM_03 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_03__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_03__DigitalInput__, SELECT_DIRECTORY_ITEM_03 );
    
    SELECT_DIRECTORY_ITEM_04 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_04__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_04__DigitalInput__, SELECT_DIRECTORY_ITEM_04 );
    
    SELECT_DIRECTORY_ITEM_05 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_05__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_05__DigitalInput__, SELECT_DIRECTORY_ITEM_05 );
    
    SELECT_DIRECTORY_ITEM_06 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_06__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_06__DigitalInput__, SELECT_DIRECTORY_ITEM_06 );
    
    SELECT_DIRECTORY_ITEM_07 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_07__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_07__DigitalInput__, SELECT_DIRECTORY_ITEM_07 );
    
    SELECT_DIRECTORY_ITEM_08 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_08__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_08__DigitalInput__, SELECT_DIRECTORY_ITEM_08 );
    
    SELECT_DIRECTORY_ITEM_09 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_09__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_09__DigitalInput__, SELECT_DIRECTORY_ITEM_09 );
    
    SELECT_DIRECTORY_ITEM_10 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_10__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_10__DigitalInput__, SELECT_DIRECTORY_ITEM_10 );
    
    SELECT_DIRECTORY_ITEM_11 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_11__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_11__DigitalInput__, SELECT_DIRECTORY_ITEM_11 );
    
    SELECT_DIRECTORY_ITEM_12 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_12__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_12__DigitalInput__, SELECT_DIRECTORY_ITEM_12 );
    
    SELECT_DIRECTORY_ITEM_13 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_13__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_13__DigitalInput__, SELECT_DIRECTORY_ITEM_13 );
    
    SELECT_DIRECTORY_ITEM_14 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_14__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_14__DigitalInput__, SELECT_DIRECTORY_ITEM_14 );
    
    SELECT_DIRECTORY_ITEM_15 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_15__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_15__DigitalInput__, SELECT_DIRECTORY_ITEM_15 );
    
    SELECT_DIRECTORY_ITEM_16 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_16__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_16__DigitalInput__, SELECT_DIRECTORY_ITEM_16 );
    
    DIAL_SELECTED_DIRECTORY_ITEM = new Crestron.Logos.SplusObjects.DigitalInput( DIAL_SELECTED_DIRECTORY_ITEM__DigitalInput__, this );
    m_DigitalInputList.Add( DIAL_SELECTED_DIRECTORY_ITEM__DigitalInput__, DIAL_SELECTED_DIRECTORY_ITEM );
    
    SAVE_DIRECTORY_ENTRY = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_DIRECTORY_ENTRY__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_DIRECTORY_ENTRY__DigitalInput__, SAVE_DIRECTORY_ENTRY );
    
    DND_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( DND_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( DND_ENABLED__DigitalInput__, DND_ENABLED );
    
    DND_DISABLED = new Crestron.Logos.SplusObjects.DigitalInput( DND_DISABLED__DigitalInput__, this );
    m_DigitalInputList.Add( DND_DISABLED__DigitalInput__, DND_DISABLED );
    
    DND_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( DND_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( DND_TOGGLE__DigitalInput__, DND_TOGGLE );
    
    DND_RESPONSE_DND = new Crestron.Logos.SplusObjects.DigitalInput( DND_RESPONSE_DND__DigitalInput__, this );
    m_DigitalInputList.Add( DND_RESPONSE_DND__DigitalInput__, DND_RESPONSE_DND );
    
    DND_RESPONSE_BUSY = new Crestron.Logos.SplusObjects.DigitalInput( DND_RESPONSE_BUSY__DigitalInput__, this );
    m_DigitalInputList.Add( DND_RESPONSE_BUSY__DigitalInput__, DND_RESPONSE_BUSY );
    
    DND_RESPONSE_DECLINE = new Crestron.Logos.SplusObjects.DigitalInput( DND_RESPONSE_DECLINE__DigitalInput__, this );
    m_DigitalInputList.Add( DND_RESPONSE_DECLINE__DigitalInput__, DND_RESPONSE_DECLINE );
    
    ALPHANUMERIC_ENTRY_DIAL = new Crestron.Logos.SplusObjects.DigitalInput( ALPHANUMERIC_ENTRY_DIAL__DigitalInput__, this );
    m_DigitalInputList.Add( ALPHANUMERIC_ENTRY_DIAL__DigitalInput__, ALPHANUMERIC_ENTRY_DIAL );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    AUTOANSWER_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( AUTOANSWER_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTOANSWER_IS_ON__DigitalOutput__, AUTOANSWER_IS_ON );
    
    AUTOANSWER_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( AUTOANSWER_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTOANSWER_IS_OFF__DigitalOutput__, AUTOANSWER_IS_OFF );
    
    DND_IS_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DND_IS_ENABLED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_IS_ENABLED__DigitalOutput__, DND_IS_ENABLED );
    
    DND_RESPONSE_IS_DND = new Crestron.Logos.SplusObjects.DigitalOutput( DND_RESPONSE_IS_DND__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_RESPONSE_IS_DND__DigitalOutput__, DND_RESPONSE_IS_DND );
    
    DND_RESPONSE_IS_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( DND_RESPONSE_IS_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_RESPONSE_IS_BUSY__DigitalOutput__, DND_RESPONSE_IS_BUSY );
    
    DND_RESPONSE_IS_DECLINE = new Crestron.Logos.SplusObjects.DigitalOutput( DND_RESPONSE_IS_DECLINE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_RESPONSE_IS_DECLINE__DigitalOutput__, DND_RESPONSE_IS_DECLINE );
    
    CALL_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( CALL_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CALL_SELECT__AnalogSerialInput__, CALL_SELECT );
    
    SELECT_DIRECTORY_SAVE_LOCATION = new Crestron.Logos.SplusObjects.AnalogInput( SELECT_DIRECTORY_SAVE_LOCATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECT_DIRECTORY_SAVE_LOCATION__AnalogSerialInput__, SELECT_DIRECTORY_SAVE_LOCATION );
    
    SELECTED_CALL = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTED_CALL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTED_CALL__AnalogSerialOutput__, SELECTED_CALL );
    
    CALL_1_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_1_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_1_STATE__AnalogSerialOutput__, CALL_1_STATE );
    
    CALL_2_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_2_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_2_STATE__AnalogSerialOutput__, CALL_2_STATE );
    
    CALL_3_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_3_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_3_STATE__AnalogSerialOutput__, CALL_3_STATE );
    
    CALL_4_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_4_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_4_STATE__AnalogSerialOutput__, CALL_4_STATE );
    
    CALL_5_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_5_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_5_STATE__AnalogSerialOutput__, CALL_5_STATE );
    
    CALL_6_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_6_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_6_STATE__AnalogSerialOutput__, CALL_6_STATE );
    
    DIRECTORY_SAVE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DIRECTORY_SAVE_NAME__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DIRECTORY_SAVE_NAME__DOLLAR____AnalogSerialInput__, DIRECTORY_SAVE_NAME__DOLLAR__ );
    
    DIRECTORY_SAVE_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DIRECTORY_SAVE_NUM__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DIRECTORY_SAVE_NUM__DOLLAR____AnalogSerialInput__, DIRECTORY_SAVE_NUM__DOLLAR__ );
    
    ALPHANUMERIC_ENTRY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ALPHANUMERIC_ENTRY__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( ALPHANUMERIC_ENTRY__DOLLAR____AnalogSerialInput__, ALPHANUMERIC_ENTRY__DOLLAR__ );
    
    CALL_1_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_STATE__DOLLAR____AnalogSerialOutput__, CALL_1_STATE__DOLLAR__ );
    
    CALL_2_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_STATE__DOLLAR____AnalogSerialOutput__, CALL_2_STATE__DOLLAR__ );
    
    CALL_3_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_STATE__DOLLAR____AnalogSerialOutput__, CALL_3_STATE__DOLLAR__ );
    
    CALL_4_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_STATE__DOLLAR____AnalogSerialOutput__, CALL_4_STATE__DOLLAR__ );
    
    CALL_5_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_STATE__DOLLAR____AnalogSerialOutput__, CALL_5_STATE__DOLLAR__ );
    
    CALL_6_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_STATE__DOLLAR____AnalogSerialOutput__, CALL_6_STATE__DOLLAR__ );
    
    CALL_1_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_1_PROMPT__DOLLAR__ );
    
    CALL_2_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_2_PROMPT__DOLLAR__ );
    
    CALL_3_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_3_PROMPT__DOLLAR__ );
    
    CALL_4_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_4_PROMPT__DOLLAR__ );
    
    CALL_5_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_5_PROMPT__DOLLAR__ );
    
    CALL_6_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_6_PROMPT__DOLLAR__ );
    
    CALL_1_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_1_CID_NAME__DOLLAR__ );
    
    CALL_1_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_1_CID_NUM__DOLLAR__ );
    
    CALL_2_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_2_CID_NAME__DOLLAR__ );
    
    CALL_2_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_2_CID_NUM__DOLLAR__ );
    
    CALL_3_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_3_CID_NAME__DOLLAR__ );
    
    CALL_3_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_3_CID_NUM__DOLLAR__ );
    
    CALL_4_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_4_CID_NAME__DOLLAR__ );
    
    CALL_4_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_4_CID_NUM__DOLLAR__ );
    
    CALL_5_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_5_CID_NAME__DOLLAR__ );
    
    CALL_5_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_5_CID_NUM__DOLLAR__ );
    
    CALL_6_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_6_CID_NAME__DOLLAR__ );
    
    CALL_6_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_6_CID_NUM__DOLLAR__ );
    
    KEYPAD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( KEYPAD__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( KEYPAD__DOLLAR____AnalogSerialOutput__, KEYPAD__DOLLAR__ );
    
    LAST_NUMBER_DIALED__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LAST_NUMBER_DIALED__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LAST_NUMBER_DIALED__DOLLAR____AnalogSerialOutput__, LAST_NUMBER_DIALED__DOLLAR__ );
    
    DIRECTORY_ITEM_01__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_01__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_01__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_01__DOLLAR__ );
    
    DIRECTORY_ITEM_02__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_02__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_02__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_02__DOLLAR__ );
    
    DIRECTORY_ITEM_03__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_03__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_03__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_03__DOLLAR__ );
    
    DIRECTORY_ITEM_04__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_04__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_04__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_04__DOLLAR__ );
    
    DIRECTORY_ITEM_05__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_05__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_05__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_05__DOLLAR__ );
    
    DIRECTORY_ITEM_06__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_06__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_06__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_06__DOLLAR__ );
    
    DIRECTORY_ITEM_07__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_07__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_07__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_07__DOLLAR__ );
    
    DIRECTORY_ITEM_08__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_08__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_08__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_08__DOLLAR__ );
    
    DIRECTORY_ITEM_09__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_09__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_09__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_09__DOLLAR__ );
    
    DIRECTORY_ITEM_10__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_10__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_10__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_10__DOLLAR__ );
    
    DIRECTORY_ITEM_11__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_11__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_11__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_11__DOLLAR__ );
    
    DIRECTORY_ITEM_12__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_12__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_12__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_12__DOLLAR__ );
    
    DIRECTORY_ITEM_13__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_13__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_13__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_13__DOLLAR__ );
    
    DIRECTORY_ITEM_14__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_14__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_14__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_14__DOLLAR__ );
    
    DIRECTORY_ITEM_15__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_15__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_15__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_15__DOLLAR__ );
    
    DIRECTORY_ITEM_16__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_ITEM_16__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_ITEM_16__DOLLAR____AnalogSerialOutput__, DIRECTORY_ITEM_16__DOLLAR__ );
    
    SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_DIRECTORY_ITEM_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_DIRECTORY_ITEM_NAME__DOLLAR____AnalogSerialOutput__, SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__ );
    
    SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_DIRECTORY_ITEM_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_DIRECTORY_ITEM_NUM__DOLLAR____AnalogSerialOutput__, SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__ );
    
    TO_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_PROCESSOR__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_PROCESSOR__DOLLAR____AnalogSerialOutput__, TO_PROCESSOR__DOLLAR__ );
    
    FROM_PROCESSOR__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( FROM_PROCESSOR__DOLLAR____AnalogSerialInput__, FROM_PROCESSOR__DOLLAR__ );
    
    LINE_NUMBER = new UShortParameter( LINE_NUMBER__Parameter__, this );
    m_ParameterList.Add( LINE_NUMBER__Parameter__, LINE_NUMBER );
    
    SPEEDDIALLIST_PAGESIZE = new UShortParameter( SPEEDDIALLIST_PAGESIZE__Parameter__, this );
    m_ParameterList.Add( SPEEDDIALLIST_PAGESIZE__Parameter__, SPEEDDIALLIST_PAGESIZE );
    
    DIALER_INSTANCETAG = new StringParameter( DIALER_INSTANCETAG__Parameter__, this );
    m_ParameterList.Add( DIALER_INSTANCETAG__Parameter__, DIALER_INSTANCETAG );
    
    CONTROLSTATUS_INSTANCETAG = new StringParameter( CONTROLSTATUS_INSTANCETAG__Parameter__, this );
    m_ParameterList.Add( CONTROLSTATUS_INSTANCETAG__Parameter__, CONTROLSTATUS_INSTANCETAG );
    
    
    POLL_DIALER.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_DIALER_OnPush_0, false ) );
    CALL_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( CALL_SELECT_OnChange_1, false ) );
    CONFERENCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONFERENCE_OnPush_2, false ) );
    ANSWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_OnPush_3, false ) );
    FLASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( FLASH_OnPush_4, false ) );
    REDIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( REDIAL_OnPush_5, false ) );
    SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_6, false ) );
    END.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_OnPush_7, false ) );
    RESUME.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESUME_OnPush_8, false ) );
    HOLD.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOLD_OnPush_9, false ) );
    ON_HOOK.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_HOOK_OnPush_10, false ) );
    OFF_HOOK.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_HOOK_OnPush_11, false ) );
    AUTOANSWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOANSWER_ON_OnPush_12, false ) );
    AUTOANSWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOANSWER_OFF_OnPush_13, false ) );
    AUTOANSWER_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOANSWER_TOGGLE_OnPush_14, false ) );
    KEYPAD_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_0_OnPush_15, false ) );
    KEYPAD_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_1_OnPush_16, false ) );
    KEYPAD_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_2_OnPush_17, false ) );
    KEYPAD_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_3_OnPush_18, false ) );
    KEYPAD_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_4_OnPush_19, false ) );
    KEYPAD_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_5_OnPush_20, false ) );
    KEYPAD_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_6_OnPush_21, false ) );
    KEYPAD_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_7_OnPush_22, false ) );
    KEYPAD_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_8_OnPush_23, false ) );
    KEYPAD_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_9_OnPush_24, false ) );
    KEYPAD_STAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_STAR_OnPush_25, false ) );
    KEYPAD_POUND.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_POUND_OnPush_26, false ) );
    KEYPAD_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_CLEAR_OnPush_27, false ) );
    KEYPAD_BACKSPACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_BACKSPACE_OnPush_28, false ) );
    KEYPAD_DIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_DIAL_OnPush_29, false ) );
    ALPHANUMERIC_ENTRY_DIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( ALPHANUMERIC_ENTRY_DIAL_OnPush_30, false ) );
    DND_ENABLED.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_ENABLED_OnPush_31, false ) );
    DND_DISABLED.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_DISABLED_OnPush_32, false ) );
    DND_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_TOGGLE_OnPush_33, false ) );
    DND_RESPONSE_DND.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_RESPONSE_DND_OnPush_34, false ) );
    DND_RESPONSE_BUSY.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_RESPONSE_BUSY_OnPush_35, false ) );
    DND_RESPONSE_DECLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_RESPONSE_DECLINE_OnPush_36, false ) );
    DIRECTORY_TOP_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRECTORY_TOP_PAGE_OnPush_37, false ) );
    DIRECTORY_NEXT_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRECTORY_NEXT_PAGE_OnPush_38, false ) );
    DIRECTORY_PREVIOUS_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRECTORY_PREVIOUS_PAGE_OnPush_39, false ) );
    DIRECTORY_BOTTOM_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRECTORY_BOTTOM_PAGE_OnPush_40, false ) );
    SELECT_DIRECTORY_ITEM_01.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_01_OnPush_41, false ) );
    SELECT_DIRECTORY_ITEM_02.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_02_OnPush_42, false ) );
    SELECT_DIRECTORY_ITEM_03.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_03_OnPush_43, false ) );
    SELECT_DIRECTORY_ITEM_04.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_04_OnPush_44, false ) );
    SELECT_DIRECTORY_ITEM_05.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_05_OnPush_45, false ) );
    SELECT_DIRECTORY_ITEM_06.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_06_OnPush_46, false ) );
    SELECT_DIRECTORY_ITEM_07.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_07_OnPush_47, false ) );
    SELECT_DIRECTORY_ITEM_08.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_08_OnPush_48, false ) );
    SELECT_DIRECTORY_ITEM_09.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_09_OnPush_49, false ) );
    SELECT_DIRECTORY_ITEM_10.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_10_OnPush_50, false ) );
    SELECT_DIRECTORY_ITEM_11.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_11_OnPush_51, false ) );
    SELECT_DIRECTORY_ITEM_12.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_12_OnPush_52, false ) );
    SELECT_DIRECTORY_ITEM_13.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_13_OnPush_53, false ) );
    SELECT_DIRECTORY_ITEM_14.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_14_OnPush_54, false ) );
    SELECT_DIRECTORY_ITEM_15.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_15_OnPush_55, false ) );
    SELECT_DIRECTORY_ITEM_16.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_16_OnPush_56, false ) );
    DIAL_SELECTED_DIRECTORY_ITEM.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIAL_SELECTED_DIRECTORY_ITEM_OnPush_57, false ) );
    SAVE_DIRECTORY_ENTRY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_DIRECTORY_ENTRY_OnPush_58, false ) );
    FROM_PROCESSOR__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_PROCESSOR__DOLLAR___OnChange_59, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BIAMP_TESIRA_VOIP_CONTROL_V1_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_DIALER__DigitalInput__ = 0;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint CALL_SELECT__AnalogSerialInput__ = 0;
const uint CONFERENCE__DigitalInput__ = 1;
const uint ANSWER__DigitalInput__ = 2;
const uint FLASH__DigitalInput__ = 3;
const uint REDIAL__DigitalInput__ = 4;
const uint SEND__DigitalInput__ = 5;
const uint END__DigitalInput__ = 6;
const uint RESUME__DigitalInput__ = 7;
const uint HOLD__DigitalInput__ = 8;
const uint ON_HOOK__DigitalInput__ = 9;
const uint OFF_HOOK__DigitalInput__ = 10;
const uint SELECTED_CALL__AnalogSerialOutput__ = 0;
const uint CALL_1_STATE__AnalogSerialOutput__ = 1;
const uint CALL_2_STATE__AnalogSerialOutput__ = 2;
const uint CALL_3_STATE__AnalogSerialOutput__ = 3;
const uint CALL_4_STATE__AnalogSerialOutput__ = 4;
const uint CALL_5_STATE__AnalogSerialOutput__ = 5;
const uint CALL_6_STATE__AnalogSerialOutput__ = 6;
const uint CALL_1_STATE__DOLLAR____AnalogSerialOutput__ = 7;
const uint CALL_2_STATE__DOLLAR____AnalogSerialOutput__ = 8;
const uint CALL_3_STATE__DOLLAR____AnalogSerialOutput__ = 9;
const uint CALL_4_STATE__DOLLAR____AnalogSerialOutput__ = 10;
const uint CALL_5_STATE__DOLLAR____AnalogSerialOutput__ = 11;
const uint CALL_6_STATE__DOLLAR____AnalogSerialOutput__ = 12;
const uint CALL_1_PROMPT__DOLLAR____AnalogSerialOutput__ = 13;
const uint CALL_2_PROMPT__DOLLAR____AnalogSerialOutput__ = 14;
const uint CALL_3_PROMPT__DOLLAR____AnalogSerialOutput__ = 15;
const uint CALL_4_PROMPT__DOLLAR____AnalogSerialOutput__ = 16;
const uint CALL_5_PROMPT__DOLLAR____AnalogSerialOutput__ = 17;
const uint CALL_6_PROMPT__DOLLAR____AnalogSerialOutput__ = 18;
const uint CALL_1_CID_NAME__DOLLAR____AnalogSerialOutput__ = 19;
const uint CALL_1_CID_NUM__DOLLAR____AnalogSerialOutput__ = 20;
const uint CALL_2_CID_NAME__DOLLAR____AnalogSerialOutput__ = 21;
const uint CALL_2_CID_NUM__DOLLAR____AnalogSerialOutput__ = 22;
const uint CALL_3_CID_NAME__DOLLAR____AnalogSerialOutput__ = 23;
const uint CALL_3_CID_NUM__DOLLAR____AnalogSerialOutput__ = 24;
const uint CALL_4_CID_NAME__DOLLAR____AnalogSerialOutput__ = 25;
const uint CALL_4_CID_NUM__DOLLAR____AnalogSerialOutput__ = 26;
const uint CALL_5_CID_NAME__DOLLAR____AnalogSerialOutput__ = 27;
const uint CALL_5_CID_NUM__DOLLAR____AnalogSerialOutput__ = 28;
const uint CALL_6_CID_NAME__DOLLAR____AnalogSerialOutput__ = 29;
const uint CALL_6_CID_NUM__DOLLAR____AnalogSerialOutput__ = 30;
const uint KEYPAD_0__DigitalInput__ = 11;
const uint KEYPAD_1__DigitalInput__ = 12;
const uint KEYPAD_2__DigitalInput__ = 13;
const uint KEYPAD_3__DigitalInput__ = 14;
const uint KEYPAD_4__DigitalInput__ = 15;
const uint KEYPAD_5__DigitalInput__ = 16;
const uint KEYPAD_6__DigitalInput__ = 17;
const uint KEYPAD_7__DigitalInput__ = 18;
const uint KEYPAD_8__DigitalInput__ = 19;
const uint KEYPAD_9__DigitalInput__ = 20;
const uint KEYPAD_STAR__DigitalInput__ = 21;
const uint KEYPAD_POUND__DigitalInput__ = 22;
const uint KEYPAD_CLEAR__DigitalInput__ = 23;
const uint KEYPAD_BACKSPACE__DigitalInput__ = 24;
const uint KEYPAD_DIAL__DigitalInput__ = 25;
const uint KEYPAD__DOLLAR____AnalogSerialOutput__ = 31;
const uint LAST_NUMBER_DIALED__DOLLAR____AnalogSerialOutput__ = 32;
const uint AUTOANSWER_ON__DigitalInput__ = 26;
const uint AUTOANSWER_OFF__DigitalInput__ = 27;
const uint AUTOANSWER_TOGGLE__DigitalInput__ = 28;
const uint AUTOANSWER_IS_ON__DigitalOutput__ = 1;
const uint AUTOANSWER_IS_OFF__DigitalOutput__ = 2;
const uint DIRECTORY_TOP_PAGE__DigitalInput__ = 29;
const uint DIRECTORY_NEXT_PAGE__DigitalInput__ = 30;
const uint DIRECTORY_PREVIOUS_PAGE__DigitalInput__ = 31;
const uint DIRECTORY_BOTTOM_PAGE__DigitalInput__ = 32;
const uint SELECT_DIRECTORY_ITEM_01__DigitalInput__ = 33;
const uint SELECT_DIRECTORY_ITEM_02__DigitalInput__ = 34;
const uint SELECT_DIRECTORY_ITEM_03__DigitalInput__ = 35;
const uint SELECT_DIRECTORY_ITEM_04__DigitalInput__ = 36;
const uint SELECT_DIRECTORY_ITEM_05__DigitalInput__ = 37;
const uint SELECT_DIRECTORY_ITEM_06__DigitalInput__ = 38;
const uint SELECT_DIRECTORY_ITEM_07__DigitalInput__ = 39;
const uint SELECT_DIRECTORY_ITEM_08__DigitalInput__ = 40;
const uint SELECT_DIRECTORY_ITEM_09__DigitalInput__ = 41;
const uint SELECT_DIRECTORY_ITEM_10__DigitalInput__ = 42;
const uint SELECT_DIRECTORY_ITEM_11__DigitalInput__ = 43;
const uint SELECT_DIRECTORY_ITEM_12__DigitalInput__ = 44;
const uint SELECT_DIRECTORY_ITEM_13__DigitalInput__ = 45;
const uint SELECT_DIRECTORY_ITEM_14__DigitalInput__ = 46;
const uint SELECT_DIRECTORY_ITEM_15__DigitalInput__ = 47;
const uint SELECT_DIRECTORY_ITEM_16__DigitalInput__ = 48;
const uint DIAL_SELECTED_DIRECTORY_ITEM__DigitalInput__ = 49;
const uint SAVE_DIRECTORY_ENTRY__DigitalInput__ = 50;
const uint SELECT_DIRECTORY_SAVE_LOCATION__AnalogSerialInput__ = 1;
const uint DIRECTORY_SAVE_NAME__DOLLAR____AnalogSerialInput__ = 2;
const uint DIRECTORY_SAVE_NUM__DOLLAR____AnalogSerialInput__ = 3;
const uint DIRECTORY_ITEM_01__DOLLAR____AnalogSerialOutput__ = 33;
const uint DIRECTORY_ITEM_02__DOLLAR____AnalogSerialOutput__ = 34;
const uint DIRECTORY_ITEM_03__DOLLAR____AnalogSerialOutput__ = 35;
const uint DIRECTORY_ITEM_04__DOLLAR____AnalogSerialOutput__ = 36;
const uint DIRECTORY_ITEM_05__DOLLAR____AnalogSerialOutput__ = 37;
const uint DIRECTORY_ITEM_06__DOLLAR____AnalogSerialOutput__ = 38;
const uint DIRECTORY_ITEM_07__DOLLAR____AnalogSerialOutput__ = 39;
const uint DIRECTORY_ITEM_08__DOLLAR____AnalogSerialOutput__ = 40;
const uint DIRECTORY_ITEM_09__DOLLAR____AnalogSerialOutput__ = 41;
const uint DIRECTORY_ITEM_10__DOLLAR____AnalogSerialOutput__ = 42;
const uint DIRECTORY_ITEM_11__DOLLAR____AnalogSerialOutput__ = 43;
const uint DIRECTORY_ITEM_12__DOLLAR____AnalogSerialOutput__ = 44;
const uint DIRECTORY_ITEM_13__DOLLAR____AnalogSerialOutput__ = 45;
const uint DIRECTORY_ITEM_14__DOLLAR____AnalogSerialOutput__ = 46;
const uint DIRECTORY_ITEM_15__DOLLAR____AnalogSerialOutput__ = 47;
const uint DIRECTORY_ITEM_16__DOLLAR____AnalogSerialOutput__ = 48;
const uint SELECTED_DIRECTORY_ITEM_NAME__DOLLAR____AnalogSerialOutput__ = 49;
const uint SELECTED_DIRECTORY_ITEM_NUM__DOLLAR____AnalogSerialOutput__ = 50;
const uint DND_ENABLED__DigitalInput__ = 51;
const uint DND_DISABLED__DigitalInput__ = 52;
const uint DND_TOGGLE__DigitalInput__ = 53;
const uint DND_RESPONSE_DND__DigitalInput__ = 54;
const uint DND_RESPONSE_BUSY__DigitalInput__ = 55;
const uint DND_RESPONSE_DECLINE__DigitalInput__ = 56;
const uint DND_IS_ENABLED__DigitalOutput__ = 3;
const uint DND_RESPONSE_IS_DND__DigitalOutput__ = 4;
const uint DND_RESPONSE_IS_BUSY__DigitalOutput__ = 5;
const uint DND_RESPONSE_IS_DECLINE__DigitalOutput__ = 6;
const uint ALPHANUMERIC_ENTRY_DIAL__DigitalInput__ = 57;
const uint ALPHANUMERIC_ENTRY__DOLLAR____AnalogSerialInput__ = 4;
const uint FROM_PROCESSOR__DOLLAR____AnalogSerialInput__ = 5;
const uint TO_PROCESSOR__DOLLAR____AnalogSerialOutput__ = 51;
const uint DIALER_INSTANCETAG__Parameter__ = 10;
const uint CONTROLSTATUS_INSTANCETAG__Parameter__ = 11;
const uint LINE_NUMBER__Parameter__ = 12;
const uint SPEEDDIALLIST_PAGESIZE__Parameter__ = 13;

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
public class SPEEDDIALENTRY : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  LABEL;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  DEFAULTLABEL;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  NUMBER;
    
    
    public SPEEDDIALENTRY( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        DEFAULTLABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        NUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class CALLSTATUSINFO : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  STATUS = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  PROMPT = 0;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  CID;
    
    
    public CALLSTATUSINFO( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        CID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        
        
    }
    
}

}
