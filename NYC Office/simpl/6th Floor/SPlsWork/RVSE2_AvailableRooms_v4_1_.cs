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

namespace UserModule_RVSE2_AVAILABLEROOMS_V4_1_
{
    public class UserModuleClass_RVSE2_AVAILABLEROOMS_V4_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput GET_AVAILABLE_ROOMS;
        Crestron.Logos.SplusObjects.DigitalInput GET_AVAILABLE_ROOMS_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT;
        Crestron.Logos.SplusObjects.StringInput FREEUNTILATTRIBUTENAMES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FREEUNTILATTRIBUTEJOINS__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_MODULE_ROOM_LIST_DATA__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput REQUEST_ACTIVE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PROCESSING_DATA_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SENDING_AVAILABLE_ROOMS_LIST_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NO_AVAILABLE_ROOMS_FOUND;
        Crestron.Logos.SplusObjects.AnalogOutput AVAILABLE_ROOMS_COUNT;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_MODULE_DATASCROLLER_DATA__DOLLAR__;
        DATA1 [] AVAILABLELIST;
        DATA2 [] ROOMLIST;
        ushort G_BRXOK1 = 0;
        ushort G_BRXOK2 = 0;
        CrestronString G_SDATA1;
        CrestronString G_SDATA2;
        ushort G_IROOMLISTCOUNT = 0;
        ushort G_IAVAILABLEROOMSCOUNT = 0;
        ushort G_IFREEUNTILNAMECOUNT = 0;
        ushort G_IFREEUNTILJOINCOUNT = 0;
        CrestronString G_SATTRIBUTESTATUSREQUESTID;
        CrestronString [] G_SFREEUNTILATTRIBUTENAME;
        CrestronString [] G_SFREEUNTILATTRIBUTEJOIN;
        private CrestronString ITOLA (  SplusExecutionContext __context__, ushort INUMBER ) 
            { 
            CrestronString SNUMBER;
            SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 182;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INUMBER < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 184;
                SNUMBER  .UpdateValue ( "0" + Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 188;
                SNUMBER  .UpdateValue ( Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 191;
            return ( SNUMBER ) ; 
            
            }
            
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
            
            
            __context__.SourceCodeLine = 213;
            IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 214;
            IMINUTE = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 217;
            if ( Functions.TestForTrue  ( ( TIME_FORMAT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 219;
                SHOUR  .UpdateValue ( ITOLA (  __context__ , (ushort)( IHOUR ))  ) ; 
                __context__.SourceCodeLine = 220;
                SAMPM  .UpdateValue ( ""  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 225;
                SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( Mod( IHOUR , 12 ) ) )  ) ; 
                __context__.SourceCodeLine = 226;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IHOUR == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IHOUR == 12) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 227;
                    SHOUR  .UpdateValue ( "12"  ) ; 
                    }
                
                __context__.SourceCodeLine = 230;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 232;
                    SAMPM  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 236;
                    SAMPM  .UpdateValue ( "PM"  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 241;
            SMINUTE  .UpdateValue ( ITOLA (  __context__ , (ushort)( IMINUTE ))  ) ; 
            __context__.SourceCodeLine = 243;
            STIME  .UpdateValue ( SHOUR + ":" + SMINUTE + " " + SAMPM  ) ; 
            __context__.SourceCodeLine = 245;
            return ( STIME ) ; 
            
            }
            
        private ushort ROOMINDEX (  SplusExecutionContext __context__, CrestronString ROOMID ) 
            { 
            ushort I = 0;
            ushort IINDEX = 0;
            
            
            __context__.SourceCodeLine = 252;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 253;
                Trace( "** RoomIndex **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 255;
            IINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 257;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_IROOMLISTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 259;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMID == ROOMLIST[ I ].ROOMID))  ) ) 
                    { 
                    __context__.SourceCodeLine = 261;
                    IINDEX = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 262;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 257;
                } 
            
            __context__.SourceCodeLine = 266;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 267;
                Trace( "  Index:{0:d}\r\n", (ushort)IINDEX) ; 
                }
            
            __context__.SourceCodeLine = 269;
            return (ushort)( IINDEX) ; 
            
            }
            
        private CrestronString FORMATFREEUNTIL (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SFREEUNTIL;
            CrestronString SFREEUNTILDATE;
            CrestronString SFREEUNTILTIME;
            CrestronString SDATETODAY;
            SFREEUNTIL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
            SFREEUNTILDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SFREEUNTILTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SDATETODAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString SHOUR;
            CrestronString SMINUTE;
            SHOUR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            SMINUTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 282;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 284;
                Trace( "** FormatFreeUntil **\r\n") ; 
                __context__.SourceCodeLine = 285;
                Trace( "  Data:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 291;
            SDATETODAY  .UpdateValue ( Functions.Date (  (int) ( 1 ) )  ) ; 
            __context__.SourceCodeLine = 294;
            SDATETODAY  .UpdateValue ( Functions.Left ( SDATETODAY ,  (int) ( 2 ) ) + "-" + Functions.Mid ( SDATETODAY ,  (int) ( 4 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SDATETODAY ,  (int) ( 4 ) )  ) ; 
            __context__.SourceCodeLine = 297;
            SFREEUNTILDATE  .UpdateValue ( Functions.Left ( SDATA ,  (int) ( 10 ) )  ) ; 
            __context__.SourceCodeLine = 300;
            SFREEUNTILDATE  .UpdateValue ( Functions.Mid ( SFREEUNTILDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SFREEUNTILDATE ,  (int) ( 2 ) ) + "-" + Functions.Left ( SFREEUNTILDATE ,  (int) ( 4 ) )  ) ; 
            __context__.SourceCodeLine = 303;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SFREEUNTILDATE == SDATETODAY))  ) ) 
                { 
                __context__.SourceCodeLine = 307;
                SFREEUNTILDATE  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 313;
            SHOUR  .UpdateValue ( Functions.Mid ( SDATA ,  (int) ( 12 ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 316;
            SMINUTE  .UpdateValue ( Functions.Mid ( SDATA ,  (int) ( 15 ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 319;
            SFREEUNTILTIME  .UpdateValue ( SHOUR + ":" + SMINUTE  ) ; 
            __context__.SourceCodeLine = 320;
            SFREEUNTILTIME  .UpdateValue ( FORMATTIME (  __context__ , SFREEUNTILTIME)  ) ; 
            __context__.SourceCodeLine = 325;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREEUNTILDATE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 329;
                SFREEUNTIL  .UpdateValue ( " - Free All Day"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 335;
                SFREEUNTIL  .UpdateValue ( " - Free Until " + SFREEUNTILTIME  ) ; 
                } 
            
            __context__.SourceCodeLine = 338;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 340;
                Trace( "  FreeUntil:{0}\r\n", SFREEUNTIL ) ; 
                } 
            
            __context__.SourceCodeLine = 343;
            return ( SFREEUNTIL ) ; 
            
            }
            
        private void SENDAVAILABLEROOMSLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 350;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 351;
                Trace( "** SendList **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 353;
            SENDING_AVAILABLE_ROOMS_LIST_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 355;
            TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<Data>"  ) ; 
            __context__.SourceCodeLine = 357;
            TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<Type>List</Type>"  ) ; 
            __context__.SourceCodeLine = 359;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_IAVAILABLEROOMSCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 361;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<Item>"  ) ; 
                __context__.SourceCodeLine = 363;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<FieldText>"  ) ; 
                __context__.SourceCodeLine = 365;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( AVAILABLELIST [ I] . ROOMNAME + "\r" + FORMATFREEUNTIL (  __context__ , AVAILABLELIST[ I ].FREEUNTIL)  ) ; 
                __context__.SourceCodeLine = 368;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "</FieldText>"  ) ; 
                __context__.SourceCodeLine = 370;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<FieldData1>" + AVAILABLELIST [ I] . ROOMID + "</FieldData1>"  ) ; 
                __context__.SourceCodeLine = 372;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<FieldData2>" + AVAILABLELIST [ I] . FREEUNTIL + "</FieldData2>"  ) ; 
                __context__.SourceCodeLine = 374;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<FieldData3></FieldData3>"  ) ; 
                __context__.SourceCodeLine = 376;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "<FieldData4></FieldData4>"  ) ; 
                __context__.SourceCodeLine = 378;
                TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "</Item>"  ) ; 
                __context__.SourceCodeLine = 359;
                } 
            
            __context__.SourceCodeLine = 381;
            TO_MODULE_DATASCROLLER_DATA__DOLLAR__  .UpdateValue ( "</Data>"  ) ; 
            __context__.SourceCodeLine = 383;
            SENDING_AVAILABLE_ROOMS_LIST_FB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private ushort VALIDFREEUNTILDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            ushort I = 0;
            ushort BVALIDDATA = 0;
            ushort IDASHCOUNT = 0;
            ushort ICOLONCOUNT = 0;
            ushort ITCOUNT = 0;
            ushort ILEN = 0;
            
            ushort ICURRHOUR = 0;
            ushort ICURRMIN = 0;
            ushort ICURRMINUTES = 0;
            ushort IHOUR = 0;
            ushort IMIN = 0;
            ushort IMINUTES = 0;
            
            CrestronString SCHAR;
            CrestronString SCURRDATE;
            CrestronString SDATE;
            SCHAR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            SCURRDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 409;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 411;
                Trace( "\r\n** ValidFreeUntilData **\r\n") ; 
                __context__.SourceCodeLine = 412;
                Trace( "  sData:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 415;
            ILEN = (ushort) ( Functions.Length( SDATA ) ) ; 
            __context__.SourceCodeLine = 416;
            BVALIDDATA = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 417;
            IDASHCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 418;
            ICOLONCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 419;
            ITCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 421;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)ILEN; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 423;
                SCHAR  .UpdateValue ( Functions.Mid ( SDATA ,  (int) ( I ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 425;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHAR == "-"))  ) ) 
                    {
                    __context__.SourceCodeLine = 426;
                    IDASHCOUNT = (ushort) ( (IDASHCOUNT + 1) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 427;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHAR == ":"))  ) ) 
                        {
                        __context__.SourceCodeLine = 428;
                        ICOLONCOUNT = (ushort) ( (ICOLONCOUNT + 1) ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 429;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHAR == "T"))  ) ) 
                            {
                            __context__.SourceCodeLine = 430;
                            ITCOUNT = (ushort) ( (ITCOUNT + 1) ) ; 
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 421;
                } 
            
            __context__.SourceCodeLine = 434;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IDASHCOUNT == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (ICOLONCOUNT == 2) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ITCOUNT == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 437;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 438;
                    Trace( "  Valid data format.\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 442;
                SDATE  .UpdateValue ( Functions.Left ( SDATA ,  (int) ( 10 ) )  ) ; 
                __context__.SourceCodeLine = 443;
                SCURRDATE  .UpdateValue ( Functions.Left ( Functions.Date (  (int) ( 3 ) ) ,  (int) ( 4 ) ) + "-" + Functions.Mid ( Functions.Date (  (int) ( 3 ) ) ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Mid ( Functions.Date (  (int) ( 3 ) ) ,  (int) ( 9 ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 446;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDATE == SCURRDATE))  ) ) 
                    { 
                    __context__.SourceCodeLine = 450;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 451;
                        Trace( "  Date = today. Need to check time.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 453;
                    ICURRHOUR = (ushort) ( Functions.GetHourNum() ) ; 
                    __context__.SourceCodeLine = 454;
                    ICURRMIN = (ushort) ( Functions.GetMinutesNum() ) ; 
                    __context__.SourceCodeLine = 456;
                    IHOUR = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 12 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 457;
                    IMIN = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 15 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 459;
                    ICURRMINUTES = (ushort) ( ((ICURRHOUR * 60) + ICURRMIN) ) ; 
                    __context__.SourceCodeLine = 460;
                    IMINUTES = (ushort) ( ((IHOUR * 60) + IMIN) ) ; 
                    __context__.SourceCodeLine = 462;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 464;
                        Trace( "  iCurrMinutes:{0:d}.\r\n", (ushort)ICURRMINUTES) ; 
                        __context__.SourceCodeLine = 465;
                        Trace( "  iMinutes:{0:d}.\r\n", (ushort)IMINUTES) ; 
                        } 
                    
                    __context__.SourceCodeLine = 469;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMINUTES > ICURRMINUTES ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 472;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (IMINUTES - ICURRMINUTES) >= 10 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 473;
                            BVALIDDATA = (ushort) ( 1 ) ; 
                            }
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 478;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 479;
                        Trace( "  Date != today. Data is valid.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 481;
                    BVALIDDATA = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 486;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 488;
                Trace( "  bValidData:{0:d}\r\n", (ushort)BVALIDDATA) ; 
                } 
            
            __context__.SourceCodeLine = 491;
            return (ushort)( BVALIDDATA) ; 
            
            }
            
        private void PROCESSATTRIBUTEDATA (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SREMOVED;
            CrestronString SROOMID;
            CrestronString SFREEUNTIL;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SROOMID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SFREEUNTIL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            ushort I = 0;
            ushort INODE = 0;
            ushort IATTRIBUTETYPE = 0;
            ushort IROOMCOUNT = 0;
            ushort IROOMINDEX = 0;
            
            ushort BVALIDFREEUNTILDATA = 0;
            ushort BROOMONLINE = 0;
            
            
            __context__.SourceCodeLine = 509;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 511;
                Trace( "** ProcessAttributeData **\r\n") ; 
                __context__.SourceCodeLine = 512;
                Trace( "Data Size:{0:d}\r\n", (ushort)Functions.Length( G_SDATA1 )) ; 
                } 
            
            __context__.SourceCodeLine = 515;
            REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 516;
            PROCESSING_DATA_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 518;
            INODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 519;
            IROOMCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 521;
            SFREEUNTIL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 523;
            do 
                { 
                __context__.SourceCodeLine = 525;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , G_SDATA1 )  ) ; 
                __context__.SourceCodeLine = 528;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 530;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "<Room>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 532;
                        INODE = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 534;
                        BVALIDFREEUNTILDATA = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 536;
                        SROOMID  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 537;
                        SFREEUNTIL  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 538;
                        IROOMINDEX = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 539;
                        BROOMONLINE = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 542;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 544;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Room>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 546;
                            INODE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 548;
                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 550;
                                Trace( "  End Room Data:\r\n") ; 
                                __context__.SourceCodeLine = 551;
                                Trace( "   iRoomIndex:{0:d}\r\n", (ushort)IROOMINDEX) ; 
                                __context__.SourceCodeLine = 552;
                                Trace( "   bRoomOnline:{0:d}\r\n", (ushort)BROOMONLINE) ; 
                                __context__.SourceCodeLine = 553;
                                Trace( "   sFreeUntil:{0}\r\n", SFREEUNTIL ) ; 
                                __context__.SourceCodeLine = 554;
                                Trace( "   bValidFreeUntilData:{0:d}\r\n", (ushort)BVALIDFREEUNTILDATA) ; 
                                } 
                            
                            __context__.SourceCodeLine = 558;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( BVALIDFREEUNTILDATA ) && Functions.TestForTrue ( BROOMONLINE )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IROOMINDEX > 0 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 561;
                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 563;
                                    Trace( "  Valid FreeUntil, Room Online & RoomIndex > 0.\r\n") ; 
                                    } 
                                
                                __context__.SourceCodeLine = 566;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IROOMCOUNT < 200 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 568;
                                    IROOMCOUNT = (ushort) ( (IROOMCOUNT + 1) ) ; 
                                    __context__.SourceCodeLine = 570;
                                    AVAILABLELIST [ IROOMCOUNT] . ROOMID  .UpdateValue ( SROOMID  ) ; 
                                    __context__.SourceCodeLine = 571;
                                    AVAILABLELIST [ IROOMCOUNT] . ROOMNAME  .UpdateValue ( ROOMLIST [ IROOMINDEX] . ROOMNAME  ) ; 
                                    __context__.SourceCodeLine = 573;
                                    AVAILABLELIST [ IROOMCOUNT] . FREEUNTIL  .UpdateValue ( SFREEUNTIL  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 581;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</RoomID>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 583;
                                SROOMID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 9) ) )  ) ; 
                                __context__.SourceCodeLine = 585;
                                IROOMINDEX = (ushort) ( ROOMINDEX( __context__ , SROOMID ) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 587;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<Attribute>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 589;
                                    IATTRIBUTETYPE = (ushort) ( 0 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 591;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Join>" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 595;
                                        SREMOVED  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 7) ) )  ) ; 
                                        __context__.SourceCodeLine = 597;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SREMOVED == "a0") ) || Functions.TestForTrue ( Functions.BoolToInt (SREMOVED == "A0") )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 599;
                                            IATTRIBUTETYPE = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 603;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( BVALIDFREEUNTILDATA ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_IFREEUNTILJOINCOUNT > 0 ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 605;
                                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 607;
                                                Trace( "  Using joins & do not have valid free until data yet.\r\n") ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 610;
                                            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                                            ushort __FN_FOREND_VAL__1 = (ushort)G_IFREEUNTILJOINCOUNT; 
                                            int __FN_FORSTEP_VAL__1 = (int)1; 
                                            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                                                { 
                                                __context__.SourceCodeLine = 612;
                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 614;
                                                    Trace( "  g_sFreeUntilAttributeJoin: {0}.\r\n", G_SFREEUNTILATTRIBUTEJOIN [ I ] ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 617;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SFREEUNTILATTRIBUTEJOIN[ I ] == SREMOVED) ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Upper( G_SFREEUNTILATTRIBUTEJOIN[ I ] ) == SREMOVED) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 621;
                                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 623;
                                                        Trace( "  Found free until join match.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 626;
                                                    IATTRIBUTETYPE = (ushort) ( 2 ) ; 
                                                    __context__.SourceCodeLine = 628;
                                                    break ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 610;
                                                } 
                                            
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 633;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Name>" , SREMOVED ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 635;
                                            SREMOVED  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 7) ) )  ) ; 
                                            __context__.SourceCodeLine = 637;
                                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 639;
                                                Trace( "  Found Name: {0}.\r\n", SREMOVED ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 643;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( BVALIDFREEUNTILDATA ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_IFREEUNTILNAMECOUNT > 0 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 645;
                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 647;
                                                    Trace( "  Using names & do not have valid free until data yet.\r\n") ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 650;
                                                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                                ushort __FN_FOREND_VAL__2 = (ushort)G_IFREEUNTILNAMECOUNT; 
                                                int __FN_FORSTEP_VAL__2 = (int)1; 
                                                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                                                    { 
                                                    __context__.SourceCodeLine = 652;
                                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 654;
                                                        Trace( "  g_sFreeUntilAttributeName: {0}.\r\n", G_SFREEUNTILATTRIBUTENAME [ I ] ) ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 657;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SFREEUNTILATTRIBUTENAME[ I ] == SREMOVED))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 661;
                                                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 663;
                                                            Trace( "  Found free until name match.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 666;
                                                        IATTRIBUTETYPE = (ushort) ( 2 ) ; 
                                                        __context__.SourceCodeLine = 668;
                                                        break ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 650;
                                                    } 
                                                
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 673;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Value>" , SREMOVED ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 676;
                                                SREMOVED  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 8) ) )  ) ; 
                                                __context__.SourceCodeLine = 678;
                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 680;
                                                    Trace( "  Found Value\r\n") ; 
                                                    __context__.SourceCodeLine = 681;
                                                    Trace( "    sValue: {0}\r\n", SREMOVED ) ; 
                                                    __context__.SourceCodeLine = 682;
                                                    Trace( "    iAttributeType: {0:d}\r\n", (ushort)IATTRIBUTETYPE) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 685;
                                                switch ((int)IATTRIBUTETYPE)
                                                
                                                    { 
                                                    case 1 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 689;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SREMOVED == "0"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 691;
                                                            BROOMONLINE = (ushort) ( 0 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 693;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SREMOVED == "1"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 695;
                                                                BROOMONLINE = (ushort) ( 1 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 697;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SREMOVED == "2"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 699;
                                                                    BROOMONLINE = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 702;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 2 ;
                                                    case 2 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 708;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREMOVED ) > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 710;
                                                            SFREEUNTIL  .UpdateValue ( SREMOVED  ) ; 
                                                            __context__.SourceCodeLine = 712;
                                                            BVALIDFREEUNTILDATA = (ushort) ( VALIDFREEUNTILDATA( __context__ , SFREEUNTIL ) ) ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 715;
                                                        break ; 
                                                        } 
                                                    
                                                    break;
                                                    } 
                                                    
                                                
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 719;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "</Error>" , SREMOVED ))  ) ) 
                                                    { 
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
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( G_SDATA1 ) == 0)) )); 
            __context__.SourceCodeLine = 728;
            G_IAVAILABLEROOMSCOUNT = (ushort) ( IROOMCOUNT ) ; 
            __context__.SourceCodeLine = 729;
            AVAILABLE_ROOMS_COUNT  .Value = (ushort) ( IROOMCOUNT ) ; 
            __context__.SourceCodeLine = 732;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IROOMCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 734;
                SENDAVAILABLEROOMSLIST (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 738;
                NO_AVAILABLE_ROOMS_FOUND  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 739;
                NO_AVAILABLE_ROOMS_FOUND  .Value = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 742;
            PROCESSING_DATA_FB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void QUERYATTRIBUTES (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort J = 0;
            
            
            __context__.SourceCodeLine = 749;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 750;
                Trace( "** QueryAttributes **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 752;
            G_SATTRIBUTESTATUSREQUESTID  .UpdateValue ( "AvailRooms" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 755;
            TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "<RequestRoomAttributeList>" + "<RequestID>" + G_SATTRIBUTESTATUSREQUESTID + "</RequestID>"  ) ; 
            __context__.SourceCodeLine = 759;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_IROOMLISTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 762;
                TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "<Room>" + "<RoomID>" + ROOMLIST [ I] . ROOMID + "</RoomID>" + "<Read>" + "<Attributes>" + "<Attribute><Join>a0</Join></Attribute>"  ) ; 
                __context__.SourceCodeLine = 770;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IFREEUNTILJOINCOUNT == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 772;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IFREEUNTILNAMECOUNT == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 774;
                        TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "<Attribute><Name>" + G_SFREEUNTILATTRIBUTENAME [ 1 ] + "</Name></Attribute>"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 779;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)G_IFREEUNTILNAMECOUNT; 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( J  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (J  >= __FN_FORSTART_VAL__2) && (J  <= __FN_FOREND_VAL__2) ) : ( (J  <= __FN_FORSTART_VAL__2) && (J  >= __FN_FOREND_VAL__2) ) ; J  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 781;
                            TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "<Attribute><Name>" + G_SFREEUNTILATTRIBUTENAME [ J ] + "</Name></Attribute>"  ) ; 
                            __context__.SourceCodeLine = 779;
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 791;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IFREEUNTILJOINCOUNT == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 793;
                        TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "<Attribute><Join>" + G_SFREEUNTILATTRIBUTEJOIN [ 1 ] + "</Join></Attribute>"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 798;
                        ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__3 = (ushort)G_IFREEUNTILJOINCOUNT; 
                        int __FN_FORSTEP_VAL__3 = (int)1; 
                        for ( J  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (J  >= __FN_FORSTART_VAL__3) && (J  <= __FN_FOREND_VAL__3) ) : ( (J  <= __FN_FORSTART_VAL__3) && (J  >= __FN_FOREND_VAL__3) ) ; J  += (ushort)__FN_FORSTEP_VAL__3) 
                            { 
                            __context__.SourceCodeLine = 800;
                            TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "<Attribute><Join>" + G_SFREEUNTILATTRIBUTEJOIN [ J ] + "</Join></Attribute>"  ) ; 
                            __context__.SourceCodeLine = 798;
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 806;
                TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "</Attributes>" + "</Read>" + "</Room>"  ) ; 
                __context__.SourceCodeLine = 759;
                } 
            
            __context__.SourceCodeLine = 813;
            TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__  .UpdateValue ( "</RequestRoomAttributeList>"  ) ; 
            
            }
            
        private void PROCESSROOMLIST (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SREMOVED;
            CrestronString SID;
            CrestronString SNAME;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            ushort ICOUNT = 0;
            
            
            __context__.SourceCodeLine = 827;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 828;
                Trace( "** ProcessRoomList **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 830;
            ICOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 832;
            do 
                { 
                __context__.SourceCodeLine = 834;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , G_SDATA2 )  ) ; 
                __context__.SourceCodeLine = 836;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Room>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 838;
                    SID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 839;
                    SNAME  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 841;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ID>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 843;
                        SID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 5) ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 845;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Name>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 847;
                            SNAME  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 7) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 849;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Room>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 851;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT < 200 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 853;
                                    ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                                    __context__.SourceCodeLine = 855;
                                    ROOMLIST [ ICOUNT] . ROOMID  .UpdateValue ( SID  ) ; 
                                    __context__.SourceCodeLine = 856;
                                    ROOMLIST [ ICOUNT] . ROOMNAME  .UpdateValue ( SNAME  ) ; 
                                    __context__.SourceCodeLine = 858;
                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 860;
                                        Trace( "Stored:{0:d}\r\n", (ushort)ICOUNT) ; 
                                        __context__.SourceCodeLine = 861;
                                        Trace( " RoomID:{0}\r\n", SID ) ; 
                                        __context__.SourceCodeLine = 862;
                                        Trace( " sName:{0}\r\n", SNAME ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( G_SDATA2 ) == 0)) )); 
            __context__.SourceCodeLine = 869;
            G_IROOMLISTCOUNT = (ushort) ( ICOUNT ) ; 
            
            }
            
        object ROOMVIEW_ONLINE_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 879;
                G_SATTRIBUTESTATUSREQUESTID  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 881;
                REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FREEUNTILATTRIBUTENAMES__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort IINDEX = 0;
            
            
            __context__.SourceCodeLine = 888;
            IINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 890;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREEUNTILATTRIBUTENAMES__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 892;
                if ( Functions.TestForTrue  ( ( Functions.Find( "," , FREEUNTILATTRIBUTENAMES__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 896;
                    do 
                        { 
                        __context__.SourceCodeLine = 898;
                        IINDEX = (ushort) ( (IINDEX + 1) ) ; 
                        __context__.SourceCodeLine = 900;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "," , FREEUNTILATTRIBUTENAMES__DOLLAR__ ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 902;
                            G_SFREEUNTILATTRIBUTENAME [ IINDEX ]  .UpdateValue ( Functions.Remove ( "," , FREEUNTILATTRIBUTENAMES__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 903;
                            G_SFREEUNTILATTRIBUTENAME [ IINDEX ]  .UpdateValue ( Functions.Left ( G_SFREEUNTILATTRIBUTENAME [ IINDEX ] ,  (int) ( (Functions.Length( G_SFREEUNTILATTRIBUTENAME[ IINDEX ] ) - 1) ) )  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 907;
                            G_SFREEUNTILATTRIBUTENAME [ IINDEX ]  .UpdateValue ( Functions.Remove ( Functions.Length( FREEUNTILATTRIBUTENAMES__DOLLAR__ ), FREEUNTILATTRIBUTENAMES__DOLLAR__ )  ) ; 
                            } 
                        
                        } 
                    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( FREEUNTILATTRIBUTENAMES__DOLLAR__ ) == 0)) )); 
                    __context__.SourceCodeLine = 912;
                    G_IFREEUNTILNAMECOUNT = (ushort) ( IINDEX ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 917;
                    G_IFREEUNTILNAMECOUNT = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 919;
                    G_SFREEUNTILATTRIBUTENAME [ 1 ]  .UpdateValue ( FREEUNTILATTRIBUTENAMES__DOLLAR__  ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object FREEUNTILATTRIBUTEJOINS__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IINDEX = 0;
        
        
        __context__.SourceCodeLine = 928;
        IINDEX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 930;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREEUNTILATTRIBUTEJOINS__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 932;
            if ( Functions.TestForTrue  ( ( Functions.Find( "," , FREEUNTILATTRIBUTEJOINS__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 936;
                do 
                    { 
                    __context__.SourceCodeLine = 938;
                    IINDEX = (ushort) ( (IINDEX + 1) ) ; 
                    __context__.SourceCodeLine = 940;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "," , FREEUNTILATTRIBUTEJOINS__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 942;
                        G_SFREEUNTILATTRIBUTEJOIN [ IINDEX ]  .UpdateValue ( Functions.Remove ( "," , FREEUNTILATTRIBUTEJOINS__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 943;
                        G_SFREEUNTILATTRIBUTEJOIN [ IINDEX ]  .UpdateValue ( Functions.Left ( G_SFREEUNTILATTRIBUTEJOIN [ IINDEX ] ,  (int) ( (Functions.Length( G_SFREEUNTILATTRIBUTEJOIN[ IINDEX ] ) - 1) ) )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 947;
                        G_SFREEUNTILATTRIBUTEJOIN [ IINDEX ]  .UpdateValue ( Functions.Remove ( Functions.Length( FREEUNTILATTRIBUTEJOINS__DOLLAR__ ), FREEUNTILATTRIBUTEJOINS__DOLLAR__ )  ) ; 
                        } 
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( FREEUNTILATTRIBUTEJOINS__DOLLAR__ ) == 0)) )); 
                __context__.SourceCodeLine = 952;
                G_IFREEUNTILJOINCOUNT = (ushort) ( IINDEX ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 957;
                G_IFREEUNTILJOINCOUNT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 959;
                G_SFREEUNTILATTRIBUTEJOIN [ 1 ]  .UpdateValue ( FREEUNTILATTRIBUTEJOINS__DOLLAR__  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_AVAILABLE_ROOMS_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 966;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( REQUEST_ACTIVE_FB  .Value ) ) && Functions.TestForTrue ( Functions.Not( PROCESSING_DATA_FB  .Value ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 968;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IROOMLISTCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 970;
                REQUEST_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 972;
                QUERYATTRIBUTES (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 976;
                NO_AVAILABLE_ROOMS_FOUND  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 977;
                NO_AVAILABLE_ROOMS_FOUND  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_AVAILABLE_ROOMS_TIMEOUT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 984;
        G_SATTRIBUTESTATUSREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 986;
        REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 992;
        if ( Functions.TestForTrue  ( ( G_BRXOK1)  ) ) 
            { 
            __context__.SourceCodeLine = 994;
            G_BRXOK1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 996;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 998;
                G_SDATA1  .UpdateValue ( Functions.Gather ( "</RoomAttributeListResponse>" , FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 1000;
                if ( Functions.TestForTrue  ( ( Functions.Find( G_SATTRIBUTESTATUSREQUESTID , G_SDATA1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1002;
                    PROCESSATTRIBUTEDATA (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 996;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_MODULE_ROOM_LIST_DATA__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1011;
        if ( Functions.TestForTrue  ( ( G_BRXOK2)  ) ) 
            { 
            __context__.SourceCodeLine = 1013;
            G_BRXOK2 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1015;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 1017;
                G_SDATA2  .UpdateValue ( Functions.Gather ( "</RoomList>" , FROM_MODULE_ROOM_LIST_DATA__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 1019;
                PROCESSROOMLIST (  __context__  ) ; 
                __context__.SourceCodeLine = 1015;
                } 
            
            } 
        
        
        
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
        
        __context__.SourceCodeLine = 1034;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 1036;
        G_BRXOK1 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1037;
        G_BRXOK2 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1039;
        G_SDATA1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1040;
        G_SDATA2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1042;
        REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1043;
        PROCESSING_DATA_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1044;
        SENDING_AVAILABLE_ROOMS_LIST_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1046;
        G_IFREEUNTILNAMECOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1048;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)5; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1050;
            G_SFREEUNTILATTRIBUTENAME [ I ]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1048;
            } 
        
        __context__.SourceCodeLine = 1053;
        G_IFREEUNTILJOINCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1055;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)5; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 1057;
            G_SFREEUNTILATTRIBUTEJOIN [ I ]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1055;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SDATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65000, this );
    G_SDATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65000, this );
    G_SATTRIBUTESTATUSREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    G_SFREEUNTILATTRIBUTENAME  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        G_SFREEUNTILATTRIBUTENAME [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, this );
    G_SFREEUNTILATTRIBUTEJOIN  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        G_SFREEUNTILATTRIBUTEJOIN [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    AVAILABLELIST  = new DATA1[ 201 ];
    for( uint i = 0; i < 201; i++ )
    {
        AVAILABLELIST [i] = new DATA1( this, true );
        AVAILABLELIST [i].PopulateCustomAttributeList( false );
        
    }
    ROOMLIST  = new DATA2[ 201 ];
    for( uint i = 0; i < 201; i++ )
    {
        ROOMLIST [i] = new DATA2( this, true );
        ROOMLIST [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    ROOMVIEW_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE__DigitalInput__, ROOMVIEW_ONLINE );
    
    GET_AVAILABLE_ROOMS = new Crestron.Logos.SplusObjects.DigitalInput( GET_AVAILABLE_ROOMS__DigitalInput__, this );
    m_DigitalInputList.Add( GET_AVAILABLE_ROOMS__DigitalInput__, GET_AVAILABLE_ROOMS );
    
    GET_AVAILABLE_ROOMS_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( GET_AVAILABLE_ROOMS_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( GET_AVAILABLE_ROOMS_TIMEOUT__DigitalInput__, GET_AVAILABLE_ROOMS_TIMEOUT );
    
    TIME_FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT__DigitalInput__, TIME_FORMAT );
    
    REQUEST_ACTIVE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( REQUEST_ACTIVE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( REQUEST_ACTIVE_FB__DigitalOutput__, REQUEST_ACTIVE_FB );
    
    PROCESSING_DATA_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PROCESSING_DATA_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PROCESSING_DATA_FB__DigitalOutput__, PROCESSING_DATA_FB );
    
    SENDING_AVAILABLE_ROOMS_LIST_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SENDING_AVAILABLE_ROOMS_LIST_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SENDING_AVAILABLE_ROOMS_LIST_FB__DigitalOutput__, SENDING_AVAILABLE_ROOMS_LIST_FB );
    
    NO_AVAILABLE_ROOMS_FOUND = new Crestron.Logos.SplusObjects.DigitalOutput( NO_AVAILABLE_ROOMS_FOUND__DigitalOutput__, this );
    m_DigitalOutputList.Add( NO_AVAILABLE_ROOMS_FOUND__DigitalOutput__, NO_AVAILABLE_ROOMS_FOUND );
    
    AVAILABLE_ROOMS_COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( AVAILABLE_ROOMS_COUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AVAILABLE_ROOMS_COUNT__AnalogSerialOutput__, AVAILABLE_ROOMS_COUNT );
    
    FREEUNTILATTRIBUTENAMES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FREEUNTILATTRIBUTENAMES__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( FREEUNTILATTRIBUTENAMES__DOLLAR____AnalogSerialInput__, FREEUNTILATTRIBUTENAMES__DOLLAR__ );
    
    FREEUNTILATTRIBUTEJOINS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FREEUNTILATTRIBUTEJOINS__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( FREEUNTILATTRIBUTEJOINS__DOLLAR____AnalogSerialInput__, FREEUNTILATTRIBUTEJOINS__DOLLAR__ );
    
    TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_ROOMATTRIBUTEQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_ROOMATTRIBUTEQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_ROOMATTRIBUTEQUERY__DOLLAR__ );
    
    TO_MODULE_DATASCROLLER_DATA__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_MODULE_DATASCROLLER_DATA__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_MODULE_DATASCROLLER_DATA__DOLLAR____AnalogSerialOutput__, TO_MODULE_DATASCROLLER_DATA__DOLLAR__ );
    
    FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR__ );
    
    FROM_MODULE_ROOM_LIST_DATA__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_MODULE_ROOM_LIST_DATA__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( FROM_MODULE_ROOM_LIST_DATA__DOLLAR____AnalogSerialInput__, FROM_MODULE_ROOM_LIST_DATA__DOLLAR__ );
    
    
    ROOMVIEW_ONLINE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_OnRelease_0, false ) );
    FREEUNTILATTRIBUTENAMES__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FREEUNTILATTRIBUTENAMES__DOLLAR___OnChange_1, false ) );
    FREEUNTILATTRIBUTEJOINS__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FREEUNTILATTRIBUTEJOINS__DOLLAR___OnChange_2, false ) );
    GET_AVAILABLE_ROOMS.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_AVAILABLE_ROOMS_OnPush_3, false ) );
    GET_AVAILABLE_ROOMS_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_AVAILABLE_ROOMS_TIMEOUT_OnPush_4, false ) );
    FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR___OnChange_5, false ) );
    FROM_MODULE_ROOM_LIST_DATA__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MODULE_ROOM_LIST_DATA__DOLLAR___OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_AVAILABLEROOMS_V4_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint ROOMVIEW_ONLINE__DigitalInput__ = 1;
const uint GET_AVAILABLE_ROOMS__DigitalInput__ = 2;
const uint GET_AVAILABLE_ROOMS_TIMEOUT__DigitalInput__ = 3;
const uint TIME_FORMAT__DigitalInput__ = 4;
const uint FREEUNTILATTRIBUTENAMES__DOLLAR____AnalogSerialInput__ = 0;
const uint FREEUNTILATTRIBUTEJOINS__DOLLAR____AnalogSerialInput__ = 1;
const uint FROM_RV_ROOMATTRIBUTERESPONSE__DOLLAR____AnalogSerialInput__ = 2;
const uint FROM_MODULE_ROOM_LIST_DATA__DOLLAR____AnalogSerialInput__ = 3;
const uint REQUEST_ACTIVE_FB__DigitalOutput__ = 0;
const uint PROCESSING_DATA_FB__DigitalOutput__ = 1;
const uint SENDING_AVAILABLE_ROOMS_LIST_FB__DigitalOutput__ = 2;
const uint NO_AVAILABLE_ROOMS_FOUND__DigitalOutput__ = 3;
const uint AVAILABLE_ROOMS_COUNT__AnalogSerialOutput__ = 0;
const uint TO_RV_ROOMATTRIBUTEQUERY__DOLLAR____AnalogSerialOutput__ = 1;
const uint TO_MODULE_DATASCROLLER_DATA__DOLLAR____AnalogSerialOutput__ = 2;

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
public class DATA1 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  ROOMID;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  ROOMNAME;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  FREEUNTIL;
    
    
    public DATA1( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        ROOMID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        ROOMNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        FREEUNTIL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class DATA2 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  ROOMID;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  ROOMNAME;
    
    
    public DATA2( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        ROOMID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        ROOMNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        
        
    }
    
}

}
