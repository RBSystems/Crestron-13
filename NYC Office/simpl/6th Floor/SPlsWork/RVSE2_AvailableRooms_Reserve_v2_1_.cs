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

namespace UserModule_RVSE2_AVAILABLEROOMS_RESERVE_V2_1_
{
    public class UserModuleClass_RVSE2_AVAILABLEROOMS_RESERVE_V2_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT_DISPLAY;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_OK;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_EVEN_END_TIME;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_TIME_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_SELECT_30;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_SELECT_60;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_SELECT_90;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_ROOM_TIMEOUT;
        Crestron.Logos.SplusObjects.AnalogInput MAX_RESERVE_DURATION;
        Crestron.Logos.SplusObjects.StringInput ROOM_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FREE_UNTIL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput RESERVE_NOW_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput RESERVE_NOW_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_MOD_WORKDAY_DATAOUT__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SET_START_END_VALID;
        Crestron.Logos.SplusObjects.DigitalOutput SET_SELECT_VALID;
        Crestron.Logos.SplusObjects.DigitalOutput SET_START_END_INVALID;
        Crestron.Logos.SplusObjects.AnalogOutput MODULE_REQUEST_MODE;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_CREATEMEETING__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_ROOM_START__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_ROOM_END__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_ROOM_SELECT_30__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_ROOM_SELECT_60__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_ROOM_SELECT_90__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_ROOM_SELECT_30_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_ROOM_SELECT_60_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_ROOM_SELECT_90_MODE;
        RESERVENOWDATA CONFIRMEVENT;
        RESERVENOWDATA SELECT30MIN;
        RESERVENOWDATA SELECT60MIN;
        RESERVENOWDATA SELECT90MIN;
        ushort G_BRXOK = 0;
        CrestronString G_SRESERVEREQUESTID;
        CrestronString G_SRESERVEDTSTART;
        CrestronString G_SRESERVEDTEND;
        private ushort DAYSINMONTH (  SplusExecutionContext __context__, ushort IMONTH , ushort IYEAR ) 
            { 
            ushort IDAYS = 0;
            
            
            __context__.SourceCodeLine = 161;
            IDAYS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 163;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 165;
                Trace( "\r\n** DaysInMonth **\r\n") ; 
                __context__.SourceCodeLine = 166;
                Trace( "  Month:{0:d}\r\n", (ushort)IMONTH) ; 
                __context__.SourceCodeLine = 167;
                Trace( "  Year:{0:d}\r\n", (ushort)IYEAR) ; 
                } 
            
            __context__.SourceCodeLine = 170;
            switch ((int)IMONTH)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 174;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 175;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 179;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IYEAR , 4 ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 181;
                        IDAYS = (ushort) ( 29 ) ; 
                        __context__.SourceCodeLine = 182;
                        break ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 186;
                        IDAYS = (ushort) ( 28 ) ; 
                        __context__.SourceCodeLine = 187;
                        break ; 
                        } 
                    
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 192;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 193;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 197;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 198;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 202;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 203;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 207;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 208;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 212;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 213;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 217;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 218;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 222;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 223;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 227;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 228;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 232;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 233;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 237;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 238;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 242;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 244;
                Trace( "  Days:{0:d}\r\n", (ushort)IDAYS) ; 
                } 
            
            __context__.SourceCodeLine = 247;
            return (ushort)( IDAYS) ; 
            
            }
            
        private CrestronString TIME24TOTIME12 (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            ushort IPOS = 0;
            ushort ILEN = 0;
            ushort IHOUR = 0;
            ushort IMINUTE = 0;
            
            CrestronString STIME;
            CrestronString SAMPM;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SAMPM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 260;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 262;
                Trace( "\r\n** Time24ToTime12 **\r\n") ; 
                __context__.SourceCodeLine = 263;
                Trace( "  Data:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 266;
            ILEN = (ushort) ( Functions.Length( SDATA ) ) ; 
            __context__.SourceCodeLine = 267;
            IPOS = (ushort) ( Functions.Find( ":" , SDATA ) ) ; 
            __context__.SourceCodeLine = 269;
            IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( (IPOS - 1) ) ) ) ) ; 
            __context__.SourceCodeLine = 270;
            IMINUTE = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( (IPOS + 1) ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 272;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 274;
                STIME  .UpdateValue ( "12"  ) ; 
                __context__.SourceCodeLine = 275;
                SAMPM  .UpdateValue ( "AM"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 277;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 279;
                    STIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                    __context__.SourceCodeLine = 280;
                    SAMPM  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 282;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IHOUR >= 10 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IHOUR < 12 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 284;
                        STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                        __context__.SourceCodeLine = 285;
                        SAMPM  .UpdateValue ( "AM"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 287;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 12))  ) ) 
                            { 
                            __context__.SourceCodeLine = 289;
                            STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                            __context__.SourceCodeLine = 290;
                            SAMPM  .UpdateValue ( "PM"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 294;
                            IHOUR = (ushort) ( (IHOUR - 12) ) ; 
                            __context__.SourceCodeLine = 296;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 298;
                                STIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 302;
                                STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 305;
                            STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                            __context__.SourceCodeLine = 306;
                            SAMPM  .UpdateValue ( "PM"  ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 309;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMINUTE < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 311;
                STIME  .UpdateValue ( STIME + ":0" + Functions.ItoA (  (int) ( IMINUTE ) ) + " " + SAMPM  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 315;
                STIME  .UpdateValue ( STIME + ":" + Functions.ItoA (  (int) ( IMINUTE ) ) + " " + SAMPM  ) ; 
                } 
            
            __context__.SourceCodeLine = 318;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 320;
                Trace( "  Time:{0}\r\n", STIME ) ; 
                } 
            
            __context__.SourceCodeLine = 323;
            return ( STIME ) ; 
            
            }
            
        private ushort TIMETOINTEGER (  SplusExecutionContext __context__, CrestronString SDATA , ushort IFORMAT ) 
            { 
            ushort ITIMEVALUE = 0;
            ushort ITIMEH = 0;
            ushort ITIMEM = 0;
            
            
            __context__.SourceCodeLine = 335;
            ITIMEVALUE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 337;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 339;
                ITIMEH = (ushort) ( (Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) * 100) ) ; 
                __context__.SourceCodeLine = 340;
                ITIMEM = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 341;
                ITIMEVALUE = (ushort) ( (ITIMEH + ITIMEM) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 343;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 345;
                    ITIMEH = (ushort) ( (Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) * 60) ) ; 
                    __context__.SourceCodeLine = 346;
                    ITIMEM = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 347;
                    ITIMEVALUE = (ushort) ( (ITIMEH + ITIMEM) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 350;
            return (ushort)( ITIMEVALUE) ; 
            
            }
            
        private CrestronString ITOLA (  SplusExecutionContext __context__, ushort INUMBER ) 
            { 
            CrestronString SNUMBER;
            SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 357;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INUMBER < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 359;
                SNUMBER  .UpdateValue ( "0" + Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 363;
                SNUMBER  .UpdateValue ( Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 366;
            return ( SNUMBER ) ; 
            
            }
            
        private void RESERVENOWSETLABELS (  SplusExecutionContext __context__, ushort MAX_TIME , ushort IDURATIONMINUTES ) 
            { 
            
            __context__.SourceCodeLine = 371;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 30))  ) ) 
                { 
                __context__.SourceCodeLine = 373;
                RESERVE_ROOM_SELECT_30__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( IDURATIONMINUTES ) ) + " Min"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 375;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 60))  ) ) 
                    { 
                    __context__.SourceCodeLine = 377;
                    RESERVE_ROOM_SELECT_60__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( IDURATIONMINUTES ) ) + " Min"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 379;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 90))  ) ) 
                        { 
                        __context__.SourceCodeLine = 381;
                        RESERVE_ROOM_SELECT_90__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( IDURATIONMINUTES ) ) + " Min"  ) ; 
                        } 
                    
                    else 
                        { 
                        } 
                    
                    }
                
                }
            
            
            }
            
        private CrestronString RESERVENOWTOINTDATEFORMAT (  SplusExecutionContext __context__, RESERVENOWDATA ODATA , CrestronString STARTEND ) 
            { 
            CrestronString RESULT;
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 19, this );
            
            
            __context__.SourceCodeLine = 392;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STARTEND == "Start"))  ) ) 
                { 
                __context__.SourceCodeLine = 394;
                RESULT  .UpdateValue ( Functions.ItoA (  (int) ( ODATA.ISTARTYEAR ) ) + "-" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTMONTH )) + "-" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTDAY )) + "T" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTHOUR )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTMIN )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTSEC ))  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 397;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STARTEND == "End"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 399;
                    RESULT  .UpdateValue ( Functions.ItoA (  (int) ( ODATA.IENDYEAR ) ) + "-" + ITOLA (  __context__ , (ushort)( ODATA.IENDMONTH )) + "-" + ITOLA (  __context__ , (ushort)( ODATA.IENDDAY )) + "T" + ITOLA (  __context__ , (ushort)( ODATA.IENDHOUR )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.IENDMIN )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.IENDSEC ))  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 403;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 405;
                Trace( "\r\n** ReserveNowToIntDateFormat **\r\n") ; 
                __context__.SourceCodeLine = 406;
                Trace( "result: {0}\r\n", RESULT ) ; 
                } 
            
            __context__.SourceCodeLine = 409;
            return ( RESULT ) ; 
            
            }
            
        private void COPYRESERVENOWDATA (  SplusExecutionContext __context__, RESERVENOWDATA DEST , RESERVENOWDATA SRC ) 
            { 
            
            __context__.SourceCodeLine = 414;
            DEST . ISTARTYEAR = (ushort) ( SRC.ISTARTYEAR ) ; 
            __context__.SourceCodeLine = 415;
            DEST . ISTARTMONTH = (ushort) ( SRC.ISTARTMONTH ) ; 
            __context__.SourceCodeLine = 416;
            DEST . ISTARTDAY = (ushort) ( SRC.ISTARTDAY ) ; 
            __context__.SourceCodeLine = 417;
            DEST . ISTARTHOUR = (ushort) ( SRC.ISTARTHOUR ) ; 
            __context__.SourceCodeLine = 418;
            DEST . ISTARTMIN = (ushort) ( SRC.ISTARTMIN ) ; 
            __context__.SourceCodeLine = 419;
            DEST . ISTARTSEC = (ushort) ( SRC.ISTARTSEC ) ; 
            __context__.SourceCodeLine = 421;
            DEST . IENDYEAR = (ushort) ( SRC.IENDYEAR ) ; 
            __context__.SourceCodeLine = 422;
            DEST . IENDMONTH = (ushort) ( SRC.IENDMONTH ) ; 
            __context__.SourceCodeLine = 423;
            DEST . IENDDAY = (ushort) ( SRC.IENDDAY ) ; 
            __context__.SourceCodeLine = 424;
            DEST . IENDHOUR = (ushort) ( SRC.IENDHOUR ) ; 
            __context__.SourceCodeLine = 425;
            DEST . IENDMIN = (ushort) ( SRC.IENDMIN ) ; 
            __context__.SourceCodeLine = 426;
            DEST . IENDSEC = (ushort) ( SRC.IENDSEC ) ; 
            
            }
            
        private void SETRESERVENOWDATA (  SplusExecutionContext __context__, RESERVENOWDATA DEST , ushort ISTARTYEAR , ushort ISTARTMONTH , ushort ISTARTDAY , ushort ISTARTHOUR , ushort ISTARTMIN , ushort ISTARTSEC , ushort IENDYEAR , ushort IENDMONTH , ushort IENDDAY , ushort IENDHOUR , ushort IENDMIN , ushort IENDSEC ) 
            { 
            
            __context__.SourceCodeLine = 434;
            DEST . ISTARTYEAR = (ushort) ( ISTARTYEAR ) ; 
            __context__.SourceCodeLine = 435;
            DEST . ISTARTMONTH = (ushort) ( ISTARTMONTH ) ; 
            __context__.SourceCodeLine = 436;
            DEST . ISTARTDAY = (ushort) ( ISTARTDAY ) ; 
            __context__.SourceCodeLine = 437;
            DEST . ISTARTHOUR = (ushort) ( ISTARTHOUR ) ; 
            __context__.SourceCodeLine = 438;
            DEST . ISTARTMIN = (ushort) ( ISTARTMIN ) ; 
            __context__.SourceCodeLine = 439;
            DEST . ISTARTSEC = (ushort) ( ISTARTSEC ) ; 
            __context__.SourceCodeLine = 441;
            DEST . IENDYEAR = (ushort) ( IENDYEAR ) ; 
            __context__.SourceCodeLine = 442;
            DEST . IENDMONTH = (ushort) ( IENDMONTH ) ; 
            __context__.SourceCodeLine = 443;
            DEST . IENDDAY = (ushort) ( IENDDAY ) ; 
            __context__.SourceCodeLine = 444;
            DEST . IENDHOUR = (ushort) ( IENDHOUR ) ; 
            __context__.SourceCodeLine = 445;
            DEST . IENDMIN = (ushort) ( IENDMIN ) ; 
            __context__.SourceCodeLine = 446;
            DEST . IENDSEC = (ushort) ( IENDSEC ) ; 
            
            }
            
        private void RESERVENOWSETDATA (  SplusExecutionContext __context__, ushort MAX_TIME , RESERVENOWDATA TEMP ) 
            { 
            
            __context__.SourceCodeLine = 451;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 30))  ) ) 
                { 
                __context__.SourceCodeLine = 453;
                COPYRESERVENOWDATA (  __context__ , SELECT30MIN, TEMP) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 455;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 60))  ) ) 
                    { 
                    __context__.SourceCodeLine = 457;
                    COPYRESERVENOWDATA (  __context__ , SELECT60MIN, TEMP) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 459;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 90))  ) ) 
                        { 
                        __context__.SourceCodeLine = 461;
                        COPYRESERVENOWDATA (  __context__ , SELECT90MIN, TEMP) ; 
                        } 
                    
                    }
                
                }
            
            
            }
            
        private ushort SETSTARTEND (  SplusExecutionContext __context__, ushort MIN_TIME , ushort MAX_TIME ) 
            { 
            ushort IFREEUNTILMINUTES = 0;
            ushort ISTARTTIMEMINUTES = 0;
            ushort IENDTIMEMINUTES = 0;
            ushort IDURATIONMINUTES = 0;
            
            ushort ISTARTMONTH = 0;
            ushort ISTARTDAY = 0;
            ushort ISTARTYEAR = 0;
            ushort IENDMONTH = 0;
            ushort IENDDAY = 0;
            ushort IENDYEAR = 0;
            
            ushort ISTARTHOUR = 0;
            ushort ISTARTMIN = 0;
            ushort IENDHOUR = 0;
            ushort IENDMIN = 0;
            
            CrestronString SCURRENTDATE;
            CrestronString SCURRENTTIME;
            CrestronString SFREEUNTILDATE;
            CrestronString SFREEUNTILTIME;
            SCURRENTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SCURRENTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SFREEUNTILDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            SFREEUNTILTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            ushort ICURRENTMONTH = 0;
            ushort ICURRENTDAY = 0;
            ushort ICURRENTYEAR = 0;
            ushort ICURRENTDAYSINMONTH = 0;
            
            CrestronString SSTARTTIME;
            CrestronString SENDTIME;
            SSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            RESERVENOWDATA TEMP;
            TEMP  = new RESERVENOWDATA( this, true );
            TEMP .PopulateCustomAttributeList( false );
            
            
            __context__.SourceCodeLine = 499;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 500;
                Trace( "\r\n** SetStartEnd **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 502;
            SCURRENTDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 503;
            SCURRENTDATE  .UpdateValue ( Functions.Left ( SCURRENTDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( SCURRENTDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SCURRENTDATE ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 505;
            ICURRENTMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SCURRENTDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 506;
            ICURRENTDAY = (ushort) ( Functions.Atoi( Functions.Right( SCURRENTDATE , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 507;
            ICURRENTYEAR = (ushort) ( Functions.Atoi( Functions.Left( SCURRENTDATE , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 509;
            SCURRENTTIME  .UpdateValue ( Functions.Time ( )  ) ; 
            __context__.SourceCodeLine = 510;
            ISTARTTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SCURRENTTIME , (ushort)( 2 ) ) ) ; 
            __context__.SourceCodeLine = 512;
            SFREEUNTILDATE  .UpdateValue ( Functions.Left ( FREE_UNTIL__DOLLAR__ ,  (int) ( 10 ) )  ) ; 
            __context__.SourceCodeLine = 513;
            SFREEUNTILTIME  .UpdateValue ( Functions.Right ( FREE_UNTIL__DOLLAR__ ,  (int) ( 8 ) )  ) ; 
            __context__.SourceCodeLine = 514;
            IFREEUNTILMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SFREEUNTILTIME , (ushort)( 2 ) ) ) ; 
            __context__.SourceCodeLine = 517;
            IENDTIMEMINUTES = (ushort) ( (ISTARTTIMEMINUTES + MAX_TIME) ) ; 
            __context__.SourceCodeLine = 519;
            if ( Functions.TestForTrue  ( ( RESERVE_ROOM_EVEN_END_TIME  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 521;
                IENDTIMEMINUTES = (ushort) ( (IENDTIMEMINUTES - Mod( IENDTIMEMINUTES , 30 )) ) ; 
                } 
            
            __context__.SourceCodeLine = 524;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 526;
                Trace( "  CurrentDate:{0}\r\n", SCURRENTDATE ) ; 
                __context__.SourceCodeLine = 527;
                Trace( "  FreeUntilDate:{0}\r\n", SFREEUNTILDATE ) ; 
                __context__.SourceCodeLine = 528;
                Trace( "  CurrentMonth:{0:d}\r\n", (ushort)ICURRENTMONTH) ; 
                __context__.SourceCodeLine = 529;
                Trace( "  CurrentDay:{0:d}\r\n", (ushort)ICURRENTDAY) ; 
                __context__.SourceCodeLine = 530;
                Trace( "  CurrentYear:{0:d}\r\n", (ushort)ICURRENTYEAR) ; 
                __context__.SourceCodeLine = 531;
                Trace( "  FreeUntilMinutes:{0:d}\r\n", (ushort)IFREEUNTILMINUTES) ; 
                __context__.SourceCodeLine = 532;
                Trace( "  StartTimeMinutes:{0:d}\r\n", (ushort)ISTARTTIMEMINUTES) ; 
                __context__.SourceCodeLine = 533;
                Trace( "  EndTimeMinutes:{0:d}\r\n", (ushort)IENDTIMEMINUTES) ; 
                } 
            
            __context__.SourceCodeLine = 538;
            if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SFREEUNTILDATE, SCURRENTDATE ) > 0))  ) ) 
                { 
                __context__.SourceCodeLine = 542;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 544;
                    Trace( "  Free until date > date today.\r\n") ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 551;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 553;
                    Trace( "  Free until date = date today.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 557;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDTIMEMINUTES > IFREEUNTILMINUTES ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 561;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 563;
                        Trace( "  End time into next meeting. Need to trim back.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 567;
                    IENDTIMEMINUTES = (ushort) ( IFREEUNTILMINUTES ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 573;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 575;
                        Trace( "  End time not into next meeting. Leave as is.\r\n") ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 582;
            IENDHOUR = (ushort) ( (IENDTIMEMINUTES / 60) ) ; 
            __context__.SourceCodeLine = 584;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 585;
                Trace( "  EndHour:{0:d}\r\n", (ushort)IENDHOUR) ; 
                }
            
            __context__.SourceCodeLine = 588;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDHOUR >= 24 ))  ) ) 
                { 
                __context__.SourceCodeLine = 592;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 593;
                    Trace( "  EndHour >= 24\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 598;
                ICURRENTDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( ICURRENTMONTH ) , (ushort)( ICURRENTYEAR ) ) ) ; 
                __context__.SourceCodeLine = 601;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTDAY < ICURRENTDAYSINMONTH ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 605;
                    ISTARTMONTH = (ushort) ( ICURRENTMONTH ) ; 
                    __context__.SourceCodeLine = 606;
                    ISTARTDAY = (ushort) ( (ICURRENTDAY + 1) ) ; 
                    __context__.SourceCodeLine = 607;
                    ISTARTYEAR = (ushort) ( ICURRENTYEAR ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 614;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTMONTH < 12 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 618;
                        ISTARTMONTH = (ushort) ( (ISTARTMONTH + 1) ) ; 
                        __context__.SourceCodeLine = 619;
                        ISTARTDAY = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 620;
                        ISTARTYEAR = (ushort) ( ICURRENTYEAR ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 626;
                        ISTARTMONTH = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 627;
                        ISTARTDAY = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 628;
                        ISTARTYEAR = (ushort) ( (ISTARTYEAR + 1) ) ; 
                        } 
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 636;
                ISTARTMONTH = (ushort) ( ICURRENTMONTH ) ; 
                __context__.SourceCodeLine = 637;
                ISTARTDAY = (ushort) ( ICURRENTDAY ) ; 
                __context__.SourceCodeLine = 638;
                ISTARTYEAR = (ushort) ( ICURRENTYEAR ) ; 
                __context__.SourceCodeLine = 640;
                ISTARTHOUR = (ushort) ( (ISTARTTIMEMINUTES / 60) ) ; 
                __context__.SourceCodeLine = 641;
                ISTARTMIN = (ushort) ( Mod( ISTARTTIMEMINUTES , 60 ) ) ; 
                __context__.SourceCodeLine = 643;
                IENDMONTH = (ushort) ( ICURRENTMONTH ) ; 
                __context__.SourceCodeLine = 644;
                IENDDAY = (ushort) ( ICURRENTDAY ) ; 
                __context__.SourceCodeLine = 645;
                IENDYEAR = (ushort) ( ICURRENTYEAR ) ; 
                __context__.SourceCodeLine = 647;
                IENDHOUR = (ushort) ( (IENDTIMEMINUTES / 60) ) ; 
                __context__.SourceCodeLine = 648;
                IENDMIN = (ushort) ( Mod( IENDTIMEMINUTES , 60 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 651;
            IDURATIONMINUTES = (ushort) ( (IENDTIMEMINUTES - ISTARTTIMEMINUTES) ) ; 
            __context__.SourceCodeLine = 653;
            SSTARTTIME  .UpdateValue ( Functions.ItoA (  (int) ( ISTARTHOUR ) ) + ":" + Functions.ItoA (  (int) ( ISTARTMIN ) )  ) ; 
            __context__.SourceCodeLine = 654;
            SSTARTTIME  .UpdateValue ( TIME24TOTIME12 (  __context__ , SSTARTTIME)  ) ; 
            __context__.SourceCodeLine = 656;
            SENDTIME  .UpdateValue ( Functions.ItoA (  (int) ( IENDHOUR ) ) + ":" + Functions.ItoA (  (int) ( IENDMIN ) )  ) ; 
            __context__.SourceCodeLine = 657;
            SENDTIME  .UpdateValue ( TIME24TOTIME12 (  __context__ , SENDTIME)  ) ; 
            __context__.SourceCodeLine = 659;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 661;
                Trace( "  iStartMonth:{0:d}\r\n", (ushort)ISTARTMONTH) ; 
                __context__.SourceCodeLine = 662;
                Trace( "  iStartDay:{0:d}\r\n", (ushort)ISTARTDAY) ; 
                __context__.SourceCodeLine = 663;
                Trace( "  iStartYear:{0:d}\r\n", (ushort)ISTARTYEAR) ; 
                __context__.SourceCodeLine = 664;
                Trace( "  iStartHour:{0:d}\r\n", (ushort)ISTARTHOUR) ; 
                __context__.SourceCodeLine = 665;
                Trace( "  iStartMin:{0:d}\r\n", (ushort)ISTARTMIN) ; 
                __context__.SourceCodeLine = 666;
                Trace( "  iEndMonth:{0:d}\r\n", (ushort)IENDMONTH) ; 
                __context__.SourceCodeLine = 667;
                Trace( "  iEndDay:{0:d}\r\n", (ushort)IENDDAY) ; 
                __context__.SourceCodeLine = 668;
                Trace( "  iEndYear:{0:d}\r\n", (ushort)IENDYEAR) ; 
                __context__.SourceCodeLine = 669;
                Trace( "  iEndHour:{0:d}\r\n", (ushort)IENDHOUR) ; 
                __context__.SourceCodeLine = 670;
                Trace( "  iEndMin:{0:d}\r\n", (ushort)IENDMIN) ; 
                __context__.SourceCodeLine = 671;
                Trace( "  iDurationMinutes:{0:d}\r\n", (ushort)IDURATIONMINUTES) ; 
                } 
            
            __context__.SourceCodeLine = 674;
            TEMP . ISTARTYEAR = (ushort) ( ISTARTYEAR ) ; 
            __context__.SourceCodeLine = 675;
            TEMP . ISTARTMONTH = (ushort) ( ISTARTMONTH ) ; 
            __context__.SourceCodeLine = 676;
            TEMP . ISTARTDAY = (ushort) ( ISTARTDAY ) ; 
            __context__.SourceCodeLine = 677;
            TEMP . ISTARTHOUR = (ushort) ( ISTARTHOUR ) ; 
            __context__.SourceCodeLine = 678;
            TEMP . ISTARTMIN = (ushort) ( ISTARTMIN ) ; 
            __context__.SourceCodeLine = 679;
            TEMP . ISTARTSEC = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 681;
            TEMP . IENDYEAR = (ushort) ( IENDYEAR ) ; 
            __context__.SourceCodeLine = 682;
            TEMP . IENDMONTH = (ushort) ( IENDMONTH ) ; 
            __context__.SourceCodeLine = 683;
            TEMP . IENDDAY = (ushort) ( IENDDAY ) ; 
            __context__.SourceCodeLine = 684;
            TEMP . IENDHOUR = (ushort) ( IENDHOUR ) ; 
            __context__.SourceCodeLine = 685;
            TEMP . IENDMIN = (ushort) ( IENDMIN ) ; 
            __context__.SourceCodeLine = 686;
            TEMP . IENDSEC = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 688;
            if ( Functions.TestForTrue  ( ( RESERVE_ROOM_TIME_SELECT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 690;
                RESERVENOWSETLABELS (  __context__ , (ushort)( MAX_TIME ), (ushort)( IDURATIONMINUTES )) ; 
                __context__.SourceCodeLine = 691;
                RESERVENOWSETDATA (  __context__ , (ushort)( MAX_TIME ), TEMP) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 697;
                RESERVE_ROOM_START__DOLLAR__  .UpdateValue ( SSTARTTIME  ) ; 
                __context__.SourceCodeLine = 698;
                RESERVE_ROOM_END__DOLLAR__  .UpdateValue ( SENDTIME  ) ; 
                __context__.SourceCodeLine = 700;
                COPYRESERVENOWDATA (  __context__ , CONFIRMEVENT, TEMP) ; 
                __context__.SourceCodeLine = 703;
                G_SRESERVEDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , CONFIRMEVENT, "Start")  ) ; 
                __context__.SourceCodeLine = 704;
                G_SRESERVEDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , CONFIRMEVENT, "End")  ) ; 
                } 
            
            __context__.SourceCodeLine = 707;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDURATIONMINUTES < MIN_TIME ))  ) ) 
                { 
                __context__.SourceCodeLine = 709;
                return (ushort)( 0) ; 
                } 
            
            __context__.SourceCodeLine = 712;
            return (ushort)( 1) ; 
            
            }
            
        private void RESERVEROOM (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SXML;
            SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            
            
            __context__.SourceCodeLine = 719;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 720;
                Trace( "\r\n** ReserveRoom **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 722;
            MODULE_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 725;
            G_SRESERVEREQUESTID  .UpdateValue ( "AvailRoomsCreate" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 728;
            SXML  .UpdateValue ( "<CreateSchedule>" + "<RequestID>" + G_SRESERVEREQUESTID + "</RequestID>" + "<RoomID>" + ROOM_ID__DOLLAR__ + "</RoomID>" + "<Event>" + "<dtStart>" + G_SRESERVEDTSTART + "</dtStart>" + "<dtEnd>" + G_SRESERVEDTEND + "</dtEnd>" + "<Organizer>" + RESERVE_NOW_ORGANIZER__DOLLAR__ + "</Organizer>" + "<Subject>" + RESERVE_NOW_SUBJECT__DOLLAR__ + "</Subject>" + "</Event>" + "</CreateSchedule>"  ) ; 
            __context__.SourceCodeLine = 740;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 742;
                Trace( "  sXML: {0}\r\n", SXML ) ; 
                } 
            
            __context__.SourceCodeLine = 746;
            do 
                { 
                __context__.SourceCodeLine = 749;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 751;
                    TO_RV_CREATEMEETING__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 755;
                    TO_RV_CREATEMEETING__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
            
            }
            
        private void PROCESSCREATEDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            ushort BSUCCESS = 0;
            
            CrestronString SREMOVED;
            CrestronString SMEETINGID;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 112, this );
            
            
            __context__.SourceCodeLine = 768;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 770;
                Trace( "\r\n** ProcessCreateData **\r\n") ; 
                __context__.SourceCodeLine = 771;
                Trace( "  DataLen:{0:d}\r\n", (ushort)Functions.Length( SDATA )) ; 
                } 
            
            __context__.SourceCodeLine = 774;
            MODULE_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 776;
            BSUCCESS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 778;
            do 
                { 
                __context__.SourceCodeLine = 780;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 781;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 783;
                    Trace( "sRemoved: {0}", SREMOVED ) ; 
                    } 
                
                __context__.SourceCodeLine = 786;
                if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingID>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 790;
                    SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 12) ) )  ) ; 
                    __context__.SourceCodeLine = 792;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SMEETINGID ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 794;
                        BSUCCESS = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 800;
            if ( Functions.TestForTrue  ( ( BSUCCESS)  ) ) 
                { 
                __context__.SourceCodeLine = 802;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 804;
                    Trace( "  Success\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 807;
                MODULE_REQUEST_MODE  .Value = (ushort) ( 3 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 811;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 813;
                    Trace( "  Failure\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 816;
                MODULE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                } 
            
            __context__.SourceCodeLine = 819;
            MODULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            
            }
            
        object ROOMVIEW_ONLINE_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 829;
                G_SRESERVEREQUESTID  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 831;
                MODULE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 832;
                MODULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FREE_UNTIL__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort BDONE = 0;
            
            
            __context__.SourceCodeLine = 839;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODULE_REQUEST_MODE  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 841;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FREE_UNTIL__DOLLAR__ ) > 17 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( ROOM_ID__DOLLAR__ ) > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 843;
                    if ( Functions.TestForTrue  ( ( RESERVE_ROOM_TIME_SELECT  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 846;
                        RESERVE_ROOM_SELECT_30_MODE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 847;
                        RESERVE_ROOM_SELECT_60_MODE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 848;
                        RESERVE_ROOM_SELECT_90_MODE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 850;
                        SET_SELECT_VALID  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 852;
                        if ( Functions.TestForTrue  ( ( SETSTARTEND( __context__ , (ushort)( 0 ) , (ushort)( 30 ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 854;
                            RESERVE_ROOM_SELECT_30_MODE  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 856;
                        if ( Functions.TestForTrue  ( ( SETSTARTEND( __context__ , (ushort)( 30 ) , (ushort)( 60 ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 858;
                            RESERVE_ROOM_SELECT_60_MODE  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 860;
                        if ( Functions.TestForTrue  ( ( SETSTARTEND( __context__ , (ushort)( 60 ) , (ushort)( 90 ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 862;
                            RESERVE_ROOM_SELECT_90_MODE  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 865;
                        SET_SELECT_VALID  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 869;
                        BDONE = (ushort) ( SETSTARTEND( __context__ , (ushort)( 0 ) , (ushort)( MAX_RESERVE_DURATION  .UshortValue ) ) ) ; 
                        __context__.SourceCodeLine = 871;
                        SET_START_END_VALID  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 872;
                        SET_START_END_VALID  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 877;
                    SET_START_END_INVALID  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 878;
                    SET_START_END_INVALID  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object RESERVE_ROOM_OK_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 885;
        G_SRESERVEDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , CONFIRMEVENT, "Start")  ) ; 
        __context__.SourceCodeLine = 886;
        G_SRESERVEDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , CONFIRMEVENT, "End")  ) ; 
        __context__.SourceCodeLine = 887;
        RESERVEROOM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_ROOM_SELECT_30_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 892;
        G_SRESERVEDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT30MIN, "Start")  ) ; 
        __context__.SourceCodeLine = 893;
        G_SRESERVEDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT30MIN, "End")  ) ; 
        __context__.SourceCodeLine = 894;
        RESERVEROOM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_ROOM_SELECT_60_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 898;
        G_SRESERVEDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT60MIN, "Start")  ) ; 
        __context__.SourceCodeLine = 899;
        G_SRESERVEDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT60MIN, "End")  ) ; 
        __context__.SourceCodeLine = 900;
        RESERVEROOM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_ROOM_SELECT_90_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 904;
        G_SRESERVEDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT90MIN, "Start")  ) ; 
        __context__.SourceCodeLine = 905;
        G_SRESERVEDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT90MIN, "End")  ) ; 
        __context__.SourceCodeLine = 906;
        RESERVEROOM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_ROOM_TIMEOUT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 912;
        G_SRESERVEREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 914;
        MODULE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 915;
        MODULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_MOD_WORKDAY_DATAOUT__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString SDATA;
        SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
        
        
        __context__.SourceCodeLine = 922;
        if ( Functions.TestForTrue  ( ( G_BRXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 924;
            G_BRXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 926;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 928;
                SDATA  .UpdateValue ( Functions.Gather ( "</Data>" , FROM_MOD_WORKDAY_DATAOUT__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 930;
                if ( Functions.TestForTrue  ( ( Functions.Find( G_SRESERVEREQUESTID , SDATA ))  ) ) 
                    {
                    __context__.SourceCodeLine = 931;
                    PROCESSCREATEDATA (  __context__ , SDATA) ; 
                    }
                
                __context__.SourceCodeLine = 926;
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
        
        __context__.SourceCodeLine = 945;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 947;
        G_BRXOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 949;
        MODULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SRESERVEREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SRESERVEDTSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    G_SRESERVEDTEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    CONFIRMEVENT  = new RESERVENOWDATA( this, true );
    CONFIRMEVENT .PopulateCustomAttributeList( false );
    SELECT30MIN  = new RESERVENOWDATA( this, true );
    SELECT30MIN .PopulateCustomAttributeList( false );
    SELECT60MIN  = new RESERVENOWDATA( this, true );
    SELECT60MIN .PopulateCustomAttributeList( false );
    SELECT90MIN  = new RESERVENOWDATA( this, true );
    SELECT90MIN .PopulateCustomAttributeList( false );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    ROOMVIEW_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE__DigitalInput__, ROOMVIEW_ONLINE );
    
    TIME_FORMAT_DISPLAY = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT_DISPLAY__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT_DISPLAY__DigitalInput__, TIME_FORMAT_DISPLAY );
    
    RESERVE_ROOM_OK = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_OK__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_OK__DigitalInput__, RESERVE_ROOM_OK );
    
    RESERVE_ROOM_EVEN_END_TIME = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_EVEN_END_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_EVEN_END_TIME__DigitalInput__, RESERVE_ROOM_EVEN_END_TIME );
    
    RESERVE_ROOM_TIME_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_TIME_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_TIME_SELECT__DigitalInput__, RESERVE_ROOM_TIME_SELECT );
    
    RESERVE_ROOM_SELECT_30 = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_SELECT_30__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_SELECT_30__DigitalInput__, RESERVE_ROOM_SELECT_30 );
    
    RESERVE_ROOM_SELECT_60 = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_SELECT_60__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_SELECT_60__DigitalInput__, RESERVE_ROOM_SELECT_60 );
    
    RESERVE_ROOM_SELECT_90 = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_SELECT_90__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_SELECT_90__DigitalInput__, RESERVE_ROOM_SELECT_90 );
    
    RESERVE_ROOM_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_ROOM_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_ROOM_TIMEOUT__DigitalInput__, RESERVE_ROOM_TIMEOUT );
    
    SET_START_END_VALID = new Crestron.Logos.SplusObjects.DigitalOutput( SET_START_END_VALID__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_START_END_VALID__DigitalOutput__, SET_START_END_VALID );
    
    SET_SELECT_VALID = new Crestron.Logos.SplusObjects.DigitalOutput( SET_SELECT_VALID__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_SELECT_VALID__DigitalOutput__, SET_SELECT_VALID );
    
    SET_START_END_INVALID = new Crestron.Logos.SplusObjects.DigitalOutput( SET_START_END_INVALID__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_START_END_INVALID__DigitalOutput__, SET_START_END_INVALID );
    
    MAX_RESERVE_DURATION = new Crestron.Logos.SplusObjects.AnalogInput( MAX_RESERVE_DURATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAX_RESERVE_DURATION__AnalogSerialInput__, MAX_RESERVE_DURATION );
    
    MODULE_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( MODULE_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MODULE_REQUEST_MODE__AnalogSerialOutput__, MODULE_REQUEST_MODE );
    
    RESERVE_ROOM_SELECT_30_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_ROOM_SELECT_30_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_ROOM_SELECT_30_MODE__AnalogSerialOutput__, RESERVE_ROOM_SELECT_30_MODE );
    
    RESERVE_ROOM_SELECT_60_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_ROOM_SELECT_60_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_ROOM_SELECT_60_MODE__AnalogSerialOutput__, RESERVE_ROOM_SELECT_60_MODE );
    
    RESERVE_ROOM_SELECT_90_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_ROOM_SELECT_90_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_ROOM_SELECT_90_MODE__AnalogSerialOutput__, RESERVE_ROOM_SELECT_90_MODE );
    
    ROOM_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ROOM_ID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( ROOM_ID__DOLLAR____AnalogSerialInput__, ROOM_ID__DOLLAR__ );
    
    FREE_UNTIL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FREE_UNTIL__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( FREE_UNTIL__DOLLAR____AnalogSerialInput__, FREE_UNTIL__DOLLAR__ );
    
    RESERVE_NOW_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RESERVE_NOW_ORGANIZER__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( RESERVE_NOW_ORGANIZER__DOLLAR____AnalogSerialInput__, RESERVE_NOW_ORGANIZER__DOLLAR__ );
    
    RESERVE_NOW_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RESERVE_NOW_SUBJECT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( RESERVE_NOW_SUBJECT__DOLLAR____AnalogSerialInput__, RESERVE_NOW_SUBJECT__DOLLAR__ );
    
    TO_RV_CREATEMEETING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__, TO_RV_CREATEMEETING__DOLLAR__ );
    
    RESERVE_ROOM_START__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_ROOM_START__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_ROOM_START__DOLLAR____AnalogSerialOutput__, RESERVE_ROOM_START__DOLLAR__ );
    
    RESERVE_ROOM_END__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_ROOM_END__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_ROOM_END__DOLLAR____AnalogSerialOutput__, RESERVE_ROOM_END__DOLLAR__ );
    
    RESERVE_ROOM_SELECT_30__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_ROOM_SELECT_30__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_ROOM_SELECT_30__DOLLAR____AnalogSerialOutput__, RESERVE_ROOM_SELECT_30__DOLLAR__ );
    
    RESERVE_ROOM_SELECT_60__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_ROOM_SELECT_60__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_ROOM_SELECT_60__DOLLAR____AnalogSerialOutput__, RESERVE_ROOM_SELECT_60__DOLLAR__ );
    
    RESERVE_ROOM_SELECT_90__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_ROOM_SELECT_90__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_ROOM_SELECT_90__DOLLAR____AnalogSerialOutput__, RESERVE_ROOM_SELECT_90__DOLLAR__ );
    
    FROM_MOD_WORKDAY_DATAOUT__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_MOD_WORKDAY_DATAOUT__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( FROM_MOD_WORKDAY_DATAOUT__DOLLAR____AnalogSerialInput__, FROM_MOD_WORKDAY_DATAOUT__DOLLAR__ );
    
    
    ROOMVIEW_ONLINE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_OnRelease_0, false ) );
    FREE_UNTIL__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FREE_UNTIL__DOLLAR___OnChange_1, false ) );
    RESERVE_ROOM_OK.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_ROOM_OK_OnPush_2, false ) );
    RESERVE_ROOM_SELECT_30.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_ROOM_SELECT_30_OnPush_3, false ) );
    RESERVE_ROOM_SELECT_60.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_ROOM_SELECT_60_OnPush_4, false ) );
    RESERVE_ROOM_SELECT_90.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_ROOM_SELECT_90_OnPush_5, false ) );
    RESERVE_ROOM_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_ROOM_TIMEOUT_OnPush_6, false ) );
    FROM_MOD_WORKDAY_DATAOUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MOD_WORKDAY_DATAOUT__DOLLAR___OnChange_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_AVAILABLEROOMS_RESERVE_V2_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint ROOMVIEW_ONLINE__DigitalInput__ = 1;
const uint TIME_FORMAT_DISPLAY__DigitalInput__ = 2;
const uint RESERVE_ROOM_OK__DigitalInput__ = 3;
const uint RESERVE_ROOM_EVEN_END_TIME__DigitalInput__ = 4;
const uint RESERVE_ROOM_TIME_SELECT__DigitalInput__ = 5;
const uint RESERVE_ROOM_SELECT_30__DigitalInput__ = 6;
const uint RESERVE_ROOM_SELECT_60__DigitalInput__ = 7;
const uint RESERVE_ROOM_SELECT_90__DigitalInput__ = 8;
const uint RESERVE_ROOM_TIMEOUT__DigitalInput__ = 9;
const uint MAX_RESERVE_DURATION__AnalogSerialInput__ = 0;
const uint ROOM_ID__DOLLAR____AnalogSerialInput__ = 1;
const uint FREE_UNTIL__DOLLAR____AnalogSerialInput__ = 2;
const uint RESERVE_NOW_ORGANIZER__DOLLAR____AnalogSerialInput__ = 3;
const uint RESERVE_NOW_SUBJECT__DOLLAR____AnalogSerialInput__ = 4;
const uint FROM_MOD_WORKDAY_DATAOUT__DOLLAR____AnalogSerialInput__ = 5;
const uint SET_START_END_VALID__DigitalOutput__ = 0;
const uint SET_SELECT_VALID__DigitalOutput__ = 1;
const uint SET_START_END_INVALID__DigitalOutput__ = 2;
const uint MODULE_REQUEST_MODE__AnalogSerialOutput__ = 0;
const uint TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__ = 1;
const uint RESERVE_ROOM_START__DOLLAR____AnalogSerialOutput__ = 2;
const uint RESERVE_ROOM_END__DOLLAR____AnalogSerialOutput__ = 3;
const uint RESERVE_ROOM_SELECT_30__DOLLAR____AnalogSerialOutput__ = 4;
const uint RESERVE_ROOM_SELECT_60__DOLLAR____AnalogSerialOutput__ = 5;
const uint RESERVE_ROOM_SELECT_90__DOLLAR____AnalogSerialOutput__ = 6;
const uint RESERVE_ROOM_SELECT_30_MODE__AnalogSerialOutput__ = 7;
const uint RESERVE_ROOM_SELECT_60_MODE__AnalogSerialOutput__ = 8;
const uint RESERVE_ROOM_SELECT_90_MODE__AnalogSerialOutput__ = 9;

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
public class RESERVENOWDATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  ISTARTYEAR = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  ISTARTMONTH = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  ISTARTDAY = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  ISTARTHOUR = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  ISTARTMIN = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  ISTARTSEC = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  IENDYEAR = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  IENDMONTH = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  IENDDAY = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  IENDHOUR = 0;
    
    [SplusStructAttribute(10, false, false)]
    public ushort  IENDMIN = 0;
    
    [SplusStructAttribute(11, false, false)]
    public ushort  IENDSEC = 0;
    
    
    public RESERVENOWDATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}

}
