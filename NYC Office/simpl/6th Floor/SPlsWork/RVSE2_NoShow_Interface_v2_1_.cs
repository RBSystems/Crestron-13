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

namespace UserModule_RVSE2_NOSHOW_INTERFACE_V2_1_
{
    public class UserModuleClass_RVSE2_NOSHOW_INTERFACE_V2_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_CLEAR_ALL_STORED_DATA;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_PRINT_ALL_STORED_DATA;
        Crestron.Logos.SplusObjects.DigitalInput CLEANUP_STORED_DATA;
        Crestron.Logos.SplusObjects.AnalogInput MAX_STORED_DATA_DAYS;
        Crestron.Logos.SplusObjects.StringInput ROOMID;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_REMOVERESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput CLEANUP_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput REMOVED_MEETING_SINGLE;
        Crestron.Logos.SplusObjects.DigitalOutput REMOVED_MEETING_SERIES;
        Crestron.Logos.SplusObjects.AnalogOutput DEBUG_NOSHOW_COUNT;
        Crestron.Logos.SplusObjects.StringOutput STATUS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput REMOVED_MEETING_SINGLE_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput REMOVED_MEETING_SERIES_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_REMOVEMEETING__DOLLAR__;
        DATA [] NOSHOWDATA;
        ushort G_BRXOK1 = 0;
        ushort G_BRXOK2 = 0;
        ushort G_BCLEANUPBUSY = 0;
        CrestronString G_SLASTREMOVEDID;
        ushort G_IDATATYPE = 0;
        private ushort DAYSINMONTH (  SplusExecutionContext __context__, ushort IMONTH , ushort IYEAR ) 
            { 
            
            __context__.SourceCodeLine = 138;
            switch ((int)IMONTH)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 142;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 143;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 147;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IYEAR , 4 ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 149;
                        return (ushort)( 29) ; 
                        __context__.SourceCodeLine = 150;
                        break ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 154;
                        return (ushort)( 28) ; 
                        __context__.SourceCodeLine = 155;
                        break ; 
                        } 
                    
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 160;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 161;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 165;
                    return (ushort)( 30) ; 
                    __context__.SourceCodeLine = 166;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 170;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 171;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 175;
                    return (ushort)( 30) ; 
                    __context__.SourceCodeLine = 176;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 180;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 181;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 185;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 186;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 190;
                    return (ushort)( 30) ; 
                    __context__.SourceCodeLine = 191;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 195;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 196;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 200;
                    return (ushort)( 30) ; 
                    __context__.SourceCodeLine = 201;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 205;
                    return (ushort)( 31) ; 
                    __context__.SourceCodeLine = 206;
                    break ; 
                    } 
                
                break;
                } 
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void REMOVEMEETING (  SplusExecutionContext __context__, ushort BRECURRING , CrestronString MEETINGID , CrestronString RVMEETINGID , ushort NOSHOWCOUNT ) 
            { 
            CrestronString STEMP;
            CrestronString SNOSHOWCOUNT;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            SNOSHOWCOUNT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            CrestronString SBOOL;
            SBOOL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            CrestronString SREQUESTID;
            SREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 217;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 218;
                Trace( "Remove Meeting. Count:{0:d}\r\n", (ushort)NOSHOWCOUNT) ; 
                }
            
            __context__.SourceCodeLine = 220;
            SREQUESTID  .UpdateValue ( "NoShow" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 222;
            SNOSHOWCOUNT  .UpdateValue ( Functions.ItoA (  (int) ( NOSHOWCOUNT ) )  ) ; 
            __context__.SourceCodeLine = 224;
            if ( Functions.TestForTrue  ( ( BRECURRING)  ) ) 
                { 
                __context__.SourceCodeLine = 226;
                SBOOL  .UpdateValue ( "True"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 230;
                SBOOL  .UpdateValue ( "False"  ) ; 
                } 
            
            __context__.SourceCodeLine = 233;
            STATUS__DOLLAR__  .UpdateValue ( "Sent: ID=" + MEETINGID + " Recurring=" + SBOOL + " Count=" + SNOSHOWCOUNT  ) ; 
            __context__.SourceCodeLine = 235;
            STEMP  .UpdateValue ( "<RequestRemoveSchedule>" + "<RequestID>" + SREQUESTID + "</RequestID>" + "<RoomID>" + ROOMID + "</RoomID>" + "<MeetingEvents>" + "<Event>" + "<ID>" + MEETINGID + "</ID>" + "<Recurring>" + SBOOL + "</Recurring>" + "<NoShowCount>" + SNOSHOWCOUNT + "</NoShowCount>" + "</Event>" + "</MeetingEvents>" + "</RequestRemoveSchedule>"  ) ; 
            __context__.SourceCodeLine = 247;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 249;
                TO_RV_REMOVEMEETING__DOLLAR__  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( 240 ) )  ) ; 
                __context__.SourceCodeLine = 250;
                TO_RV_REMOVEMEETING__DOLLAR__  .UpdateValue ( Functions.Right ( STEMP ,  (int) ( (Functions.Length( STEMP ) - 240) ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 254;
                TO_RV_REMOVEMEETING__DOLLAR__  .UpdateValue ( STEMP  ) ; 
                } 
            
            __context__.SourceCodeLine = 257;
            if ( Functions.TestForTrue  ( ( Functions.Not( BRECURRING ))  ) ) 
                { 
                __context__.SourceCodeLine = 259;
                REMOVED_MEETING_SINGLE_ID__DOLLAR__  .UpdateValue ( RVMEETINGID  ) ; 
                __context__.SourceCodeLine = 261;
                Functions.Pulse ( 10, REMOVED_MEETING_SINGLE ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 268;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NOSHOWCOUNT == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 271;
                    REMOVED_MEETING_SERIES_ID__DOLLAR__  .UpdateValue ( RVMEETINGID  ) ; 
                    __context__.SourceCodeLine = 273;
                    Functions.Pulse ( 10, REMOVED_MEETING_SERIES ) ; 
                    } 
                
                } 
            
            
            }
            
        private ushort DAYDIFF (  SplusExecutionContext __context__, CrestronString STARTDATE , CrestronString ENDDATE ) 
            { 
            ushort I = 0;
            
            ushort IDIFFDAYS = 0;
            ushort IDAYSUNTIL = 0;
            ushort IDAYSFROM = 0;
            
            ushort ISTARTMONTH = 0;
            ushort IENDMONTH = 0;
            
            ushort ISTARTDAY = 0;
            ushort IENDDAY = 0;
            
            ushort ISTARTYEAR = 0;
            ushort IENDYEAR = 0;
            
            
            __context__.SourceCodeLine = 300;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 302;
                Trace( "\r\n** DayDiff **\r\n") ; 
                __context__.SourceCodeLine = 303;
                Trace( "    StartDate:{0}\r\n", STARTDATE ) ; 
                __context__.SourceCodeLine = 304;
                Trace( "    EndDate:{0}\r\n", ENDDATE ) ; 
                } 
            
            __context__.SourceCodeLine = 307;
            ISTARTMONTH = (ushort) ( Functions.Atoi( Functions.Left( STARTDATE , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 308;
            ISTARTDAY = (ushort) ( Functions.Atoi( Functions.Mid( STARTDATE , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 309;
            ISTARTYEAR = (ushort) ( Functions.Atoi( Functions.Right( STARTDATE , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 311;
            IENDMONTH = (ushort) ( Functions.Atoi( Functions.Left( ENDDATE , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 312;
            IENDDAY = (ushort) ( Functions.Atoi( Functions.Mid( ENDDATE , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 313;
            IENDYEAR = (ushort) ( Functions.Atoi( Functions.Right( ENDDATE , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 315;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 317;
                Trace( "    iStartMonth:{0:d}\r\n", (ushort)ISTARTMONTH) ; 
                __context__.SourceCodeLine = 318;
                Trace( "    iStartDay:{0:d}\r\n", (ushort)ISTARTDAY) ; 
                __context__.SourceCodeLine = 319;
                Trace( "    iStartYear:{0:d}\r\n", (ushort)ISTARTYEAR) ; 
                __context__.SourceCodeLine = 321;
                Trace( "    iEndMonth:{0:d}\r\n", (ushort)IENDMONTH) ; 
                __context__.SourceCodeLine = 322;
                Trace( "    iEndDay:{0:d}\r\n", (ushort)IENDDAY) ; 
                __context__.SourceCodeLine = 323;
                Trace( "    iEndYear:{0:d}\r\n", (ushort)IENDYEAR) ; 
                } 
            
            __context__.SourceCodeLine = 326;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTYEAR != IENDYEAR))  ) ) 
                { 
                __context__.SourceCodeLine = 328;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 329;
                    Trace( "    Years Not Equal\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 334;
                IDAYSUNTIL = (ushort) ( (DAYSINMONTH( __context__ , (ushort)( ISTARTMONTH ) , (ushort)( ISTARTYEAR ) ) - ISTARTDAY) ) ; 
                __context__.SourceCodeLine = 336;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 337;
                    Trace( "    Days Until End of Current Month:{0:d}\r\n", (ushort)IDAYSUNTIL) ; 
                    }
                
                __context__.SourceCodeLine = 340;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTMONTH != 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 342;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 343;
                        Trace( "    Current Month <> 12. Add up all days based on month.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 345;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( (ISTARTMONTH + 1) ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)12; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 347;
                        IDAYSUNTIL = (ushort) ( (IDAYSUNTIL + DAYSINMONTH( __context__ , (ushort)( I ) , (ushort)( ISTARTYEAR ) )) ) ; 
                        __context__.SourceCodeLine = 345;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 351;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 352;
                    Trace( "    Total Days to the End of the Year:{0:d}\r\n", (ushort)IDAYSUNTIL) ; 
                    }
                
                __context__.SourceCodeLine = 357;
                IDAYSFROM = (ushort) ( DAYSINMONTH( __context__ , (ushort)( IENDMONTH ) , (ushort)( IENDYEAR ) ) ) ; 
                __context__.SourceCodeLine = 360;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IENDMONTH != 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 362;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 363;
                        Trace( "    End Month <> 1\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 365;
                    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__2 = (ushort)(IENDMONTH - 1); 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 367;
                        IDAYSFROM = (ushort) ( (IDAYSFROM + DAYSINMONTH( __context__ , (ushort)( I ) , (ushort)( IENDYEAR ) )) ) ; 
                        __context__.SourceCodeLine = 365;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 371;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 372;
                    Trace( "    Total Days from the Beginning of the Year:{0:d}\r\n", (ushort)IDAYSFROM) ; 
                    }
                
                __context__.SourceCodeLine = 374;
                IDIFFDAYS = (ushort) ( (IDAYSUNTIL + IDAYSFROM) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 376;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTMONTH != IENDMONTH))  ) ) 
                    { 
                    __context__.SourceCodeLine = 378;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 379;
                        Trace( "    Months Not Equal\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 382;
                    IDIFFDAYS = (ushort) ( (DAYSINMONTH( __context__ , (ushort)( ISTARTMONTH ) , (ushort)( ISTARTYEAR ) ) - ISTARTDAY) ) ; 
                    __context__.SourceCodeLine = 385;
                    IDIFFDAYS = (ushort) ( (IDIFFDAYS + DAYSINMONTH( __context__ , (ushort)( IENDMONTH ) , (ushort)( IENDYEAR ) )) ) ; 
                    __context__.SourceCodeLine = 388;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (IENDMONTH - ISTARTMONTH) > 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 390;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 391;
                            Trace( "    Month Difference > 1\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 393;
                        ushort __FN_FORSTART_VAL__3 = (ushort) ( (ISTARTMONTH + 1) ) ;
                        ushort __FN_FOREND_VAL__3 = (ushort)(IENDMONTH - 1); 
                        int __FN_FORSTEP_VAL__3 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                            { 
                            __context__.SourceCodeLine = 395;
                            IDIFFDAYS = (ushort) ( (IDIFFDAYS + DAYSINMONTH( __context__ , (ushort)( I ) , (ushort)( IENDYEAR ) )) ) ; 
                            __context__.SourceCodeLine = 393;
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 399;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTDAY != IENDDAY))  ) ) 
                        { 
                        __context__.SourceCodeLine = 401;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 402;
                            Trace( "    Days Not Equal\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 404;
                        IDIFFDAYS = (ushort) ( (IENDDAY - ISTARTDAY) ) ; 
                        } 
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 407;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 408;
                Trace( "    Total Day Diff:{0:d}\r\n", (ushort)IDIFFDAYS) ; 
                }
            
            __context__.SourceCodeLine = 410;
            return (ushort)( IDIFFDAYS) ; 
            
            }
            
        private void CLEANUPDATA (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort IDAYDIFF = 0;
            
            
            __context__.SourceCodeLine = 418;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 419;
                Trace( "\r\n** CleanupData **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 421;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)150; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 423;
                if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( NOSHOWDATA[ I ].SDATADATE , Functions.Date( (int)( 1 ) ) ) < 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 427;
                    IDAYDIFF = (ushort) ( DAYDIFF( __context__ , Functions.Date( (int)( 1 ) ) , NOSHOWDATA[ I ].SDATADATE ) ) ; 
                    __context__.SourceCodeLine = 429;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 431;
                        Trace( "    Dates Not Equal. DayDiff:{0:d}\r\n", (ushort)IDAYDIFF) ; 
                        } 
                    
                    __context__.SourceCodeLine = 435;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAYDIFF >= MAX_STORED_DATA_DAYS  .UshortValue ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 439;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 440;
                            Trace( "    Data DayDiff >= Max Stored Days. Clearing data.\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 442;
                        NOSHOWDATA [ I] . SMEETINGID  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 443;
                        NOSHOWDATA [ I] . SRVMEETINGID  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 444;
                        NOSHOWDATA [ I] . SSUBJECT  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 445;
                        NOSHOWDATA [ I] . INOSHOWCOUNT = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 421;
                } 
            
            
            }
            
        private ushort FIRSTEMPTYSLOT (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort IEMPTYSLOT = 0;
            
            
            __context__.SourceCodeLine = 455;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 456;
                Trace( "\r\n** FirstEmptySlot **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 458;
            IEMPTYSLOT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 460;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)150; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 462;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( NOSHOWDATA[ I ].SMEETINGID ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 464;
                    IEMPTYSLOT = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 465;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 460;
                } 
            
            __context__.SourceCodeLine = 469;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 470;
                Trace( "    Slot={0:d}\r\n", (ushort)IEMPTYSLOT) ; 
                }
            
            __context__.SourceCodeLine = 472;
            return (ushort)( IEMPTYSLOT) ; 
            
            }
            
        private ushort NOSHOWINDEX (  SplusExecutionContext __context__, CrestronString MEETINGID ) 
            { 
            ushort I = 0;
            ushort INOSHOWINDEX = 0;
            
            
            __context__.SourceCodeLine = 479;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 480;
                Trace( "\r\n** NoShowIndex **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 482;
            INOSHOWINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 484;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)150; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 486;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGID == NOSHOWDATA[ I ].SMEETINGID))  ) ) 
                    { 
                    __context__.SourceCodeLine = 488;
                    INOSHOWINDEX = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 489;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 484;
                } 
            
            __context__.SourceCodeLine = 493;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 494;
                Trace( "    Index={0:d}\r\n", (ushort)INOSHOWINDEX) ; 
                }
            
            __context__.SourceCodeLine = 496;
            return (ushort)( INOSHOWINDEX) ; 
            
            }
            
        private void PROCESSDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SREMOVED;
            CrestronString STEMP;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            ushort IINDEX = 0;
            ushort ISLOT = 0;
            ushort ICOUNT = 0;
            
            ushort BNOSHOW = 0;
            ushort BRECURRING = 0;
            
            CrestronString SMEETINGID;
            CrestronString SRVMEETINGID;
            CrestronString SRECURRING;
            CrestronString SSUBJECT;
            SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            SRVMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SRECURRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 35, this );
            SSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 517;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 518;
                Trace( "\r\n** ProcessData **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 521;
            BNOSHOW = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 522;
            BRECURRING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 524;
            SMEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 525;
            SRVMEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 526;
            SSUBJECT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 528;
            do 
                { 
                __context__.SourceCodeLine = 530;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 532;
                if ( Functions.TestForTrue  ( ( Functions.Find( "</Status>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 534;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "NoShow" , SREMOVED ))  ) ) 
                        {
                        __context__.SourceCodeLine = 535;
                        BNOSHOW = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 537;
                        BNOSHOW = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 539;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingID>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 541;
                        SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 12) ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 543;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</RVMeetingID>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 545;
                            SRVMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 14) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 547;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Subject>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 549;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREMOVED ) > 210 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 550;
                                    SREMOVED  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( 200 ) )  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 552;
                                SSUBJECT  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 10) ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 554;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</Recurring>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 556;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "True" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 558;
                                        BRECURRING = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 559;
                                        SRECURRING  .UpdateValue ( "<Recurring>True</Recurring>"  ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 563;
                                        BRECURRING = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 564;
                                        SRECURRING  .UpdateValue ( "<Recurring>False</Recurring>"  ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 567;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</NoShowData>" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 570;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SMEETINGID ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 573;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( BRECURRING ) ) && Functions.TestForTrue ( BNOSHOW )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 575;
                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 576;
                                                    Trace( "    Single Meeting with NoShow\r\n") ; 
                                                    }
                                                
                                                __context__.SourceCodeLine = 578;
                                                DEBUG_NOSHOW_COUNT  .Value = (ushort) ( 1 ) ; 
                                                __context__.SourceCodeLine = 581;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SLASTREMOVEDID != SMEETINGID))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 583;
                                                    G_SLASTREMOVEDID  .UpdateValue ( SMEETINGID  ) ; 
                                                    __context__.SourceCodeLine = 585;
                                                    REMOVEMEETING (  __context__ , (ushort)( BRECURRING ), SMEETINGID, SRVMEETINGID, (ushort)( 0 )) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 588;
                                                CreateWait ( "__SPLS_TMPVAR__WAITLABEL_7__" , 200 , __SPLS_TMPVAR__WAITLABEL_7___Callback ) ;
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 591;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( BRECURRING ) && Functions.TestForTrue ( BNOSHOW )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 593;
                                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 594;
                                                        Trace( "    Recurring meeting & no show\r\n") ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 597;
                                                    IINDEX = (ushort) ( NOSHOWINDEX( __context__ , SMEETINGID ) ) ; 
                                                    __context__.SourceCodeLine = 599;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINDEX == 0))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 601;
                                                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 602;
                                                            Trace( "    First no show for this meeting. Storing date and count = 1\r\n") ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 604;
                                                        ISLOT = (ushort) ( FIRSTEMPTYSLOT( __context__ ) ) ; 
                                                        __context__.SourceCodeLine = 606;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISLOT > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 608;
                                                            ICOUNT = (ushort) ( 1 ) ; 
                                                            __context__.SourceCodeLine = 610;
                                                            NOSHOWDATA [ ISLOT] . SMEETINGID  .UpdateValue ( SMEETINGID  ) ; 
                                                            __context__.SourceCodeLine = 611;
                                                            NOSHOWDATA [ ISLOT] . SRVMEETINGID  .UpdateValue ( SRVMEETINGID  ) ; 
                                                            __context__.SourceCodeLine = 612;
                                                            NOSHOWDATA [ ISLOT] . SSUBJECT  .UpdateValue ( SSUBJECT  ) ; 
                                                            __context__.SourceCodeLine = 613;
                                                            NOSHOWDATA [ ISLOT] . INOSHOWCOUNT = (ushort) ( ICOUNT ) ; 
                                                            __context__.SourceCodeLine = 614;
                                                            NOSHOWDATA [ ISLOT] . ISENTNOSHOWCOUNT = (ushort) ( 0 ) ; 
                                                            __context__.SourceCodeLine = 615;
                                                            NOSHOWDATA [ ISLOT] . SDATADATE  .UpdateValue ( Functions.Date (  (int) ( 1 ) )  ) ; 
                                                            __context__.SourceCodeLine = 617;
                                                            DEBUG_NOSHOW_COUNT  .Value = (ushort) ( ICOUNT ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 622;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NOSHOWDATA[ IINDEX ].SDATADATE != Functions.Date( (int)( 1 ) )))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 624;
                                                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 625;
                                                                Trace( "    Another no show and we have not logged this date yet\r\n") ; 
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 627;
                                                            NOSHOWDATA [ IINDEX] . SDATADATE  .UpdateValue ( Functions.Date (  (int) ( 1 ) )  ) ; 
                                                            __context__.SourceCodeLine = 629;
                                                            ICOUNT = (ushort) ( NOSHOWDATA[ IINDEX ].INOSHOWCOUNT ) ; 
                                                            __context__.SourceCodeLine = 631;
                                                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 632;
                                                                Trace( "    Current no show count:{0:d}\r\n", (ushort)ICOUNT) ; 
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 634;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 636;
                                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 637;
                                                                    Trace( "    Count is now 2\r\n") ; 
                                                                    }
                                                                
                                                                __context__.SourceCodeLine = 639;
                                                                ICOUNT = (ushort) ( 2 ) ; 
                                                                __context__.SourceCodeLine = 640;
                                                                NOSHOWDATA [ IINDEX] . INOSHOWCOUNT = (ushort) ( ICOUNT ) ; 
                                                                __context__.SourceCodeLine = 643;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NOSHOWDATA[ IINDEX ].ISENTNOSHOWCOUNT != ICOUNT))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 645;
                                                                    NOSHOWDATA [ IINDEX] . ISENTNOSHOWCOUNT = (ushort) ( ICOUNT ) ; 
                                                                    __context__.SourceCodeLine = 647;
                                                                    REMOVEMEETING (  __context__ , (ushort)( BRECURRING ), SMEETINGID, SRVMEETINGID, (ushort)( ICOUNT )) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 650;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 2))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 652;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                        {
                                                                        __context__.SourceCodeLine = 653;
                                                                        Trace( "    Count is now 3\r\n") ; 
                                                                        }
                                                                    
                                                                    __context__.SourceCodeLine = 655;
                                                                    ICOUNT = (ushort) ( 3 ) ; 
                                                                    __context__.SourceCodeLine = 656;
                                                                    DEBUG_NOSHOW_COUNT  .Value = (ushort) ( ICOUNT ) ; 
                                                                    __context__.SourceCodeLine = 659;
                                                                    NOSHOWDATA [ IINDEX] . SMEETINGID  .UpdateValue ( ""  ) ; 
                                                                    __context__.SourceCodeLine = 660;
                                                                    NOSHOWDATA [ IINDEX] . SRVMEETINGID  .UpdateValue ( ""  ) ; 
                                                                    __context__.SourceCodeLine = 661;
                                                                    NOSHOWDATA [ IINDEX] . INOSHOWCOUNT = (ushort) ( 0 ) ; 
                                                                    __context__.SourceCodeLine = 662;
                                                                    NOSHOWDATA [ IINDEX] . ISENTNOSHOWCOUNT = (ushort) ( 0 ) ; 
                                                                    __context__.SourceCodeLine = 663;
                                                                    NOSHOWDATA [ IINDEX] . SDATADATE  .UpdateValue ( ""  ) ; 
                                                                    __context__.SourceCodeLine = 665;
                                                                    REMOVEMEETING (  __context__ , (ushort)( BRECURRING ), SMEETINGID, SRVMEETINGID, (ushort)( ICOUNT )) ; 
                                                                    __context__.SourceCodeLine = 667;
                                                                    CreateWait ( "__SPLS_TMPVAR__WAITLABEL_8__" , 200 , __SPLS_TMPVAR__WAITLABEL_8___Callback ) ;
                                                                    } 
                                                                
                                                                }
                                                            
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 673;
                                                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 674;
                                                                Trace( "    We have already logged this NoShow date\r\n") ; 
                                                                }
                                                            
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 677;
                                                        DEBUG_NOSHOW_COUNT  .Value = (ushort) ( NOSHOWDATA[ IINDEX ].INOSHOWCOUNT ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 680;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( BRECURRING ) && Functions.TestForTrue ( Functions.Not( BNOSHOW ) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 682;
                                                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 683;
                                                            Trace( "    Meeting is recurring with show\r\n") ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 685;
                                                        IINDEX = (ushort) ( NOSHOWINDEX( __context__ , SMEETINGID ) ) ; 
                                                        __context__.SourceCodeLine = 687;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IINDEX > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 689;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NOSHOWDATA[ IINDEX ].SDATADATE == Functions.Date( (int)( 1 ) )))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 694;
                                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 695;
                                                                    Trace( "    Already logged this meeting as a NoShow\r\n") ; 
                                                                    }
                                                                
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 699;
                                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 700;
                                                                    Trace( "    Meeting not logged as NoShow for today. Clearing it from list\r\n") ; 
                                                                    }
                                                                
                                                                __context__.SourceCodeLine = 702;
                                                                DEBUG_NOSHOW_COUNT  .Value = (ushort) ( 0 ) ; 
                                                                __context__.SourceCodeLine = 704;
                                                                NOSHOWDATA [ IINDEX] . SMEETINGID  .UpdateValue ( ""  ) ; 
                                                                __context__.SourceCodeLine = 705;
                                                                NOSHOWDATA [ IINDEX] . SRVMEETINGID  .UpdateValue ( ""  ) ; 
                                                                __context__.SourceCodeLine = 706;
                                                                NOSHOWDATA [ IINDEX] . INOSHOWCOUNT = (ushort) ( 0 ) ; 
                                                                __context__.SourceCodeLine = 707;
                                                                NOSHOWDATA [ IINDEX] . ISENTNOSHOWCOUNT = (ushort) ( 0 ) ; 
                                                                __context__.SourceCodeLine = 708;
                                                                NOSHOWDATA [ IINDEX] . SDATADATE  .UpdateValue ( ""  ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 720;
                                            DEBUG_NOSHOW_COUNT  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 722;
                                            STATUS__DOLLAR__  .UpdateValue ( ""  ) ; 
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
            
        public void __SPLS_TMPVAR__WAITLABEL_7___CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            {
            __context__.SourceCodeLine = 589;
            DEBUG_NOSHOW_COUNT  .Value = (ushort) ( 0 ) ; 
            }
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_8___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            {
            __context__.SourceCodeLine = 668;
            DEBUG_NOSHOW_COUNT  .Value = (ushort) ( 0 ) ; 
            }
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
object DEBUG_CLEAR_ALL_STORED_DATA_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 739;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)150; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 741;
            NOSHOWDATA [ I] . SMEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 742;
            NOSHOWDATA [ I] . SRVMEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 743;
            NOSHOWDATA [ I] . SSUBJECT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 744;
            NOSHOWDATA [ I] . SDATADATE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 745;
            NOSHOWDATA [ I] . INOSHOWCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 746;
            NOSHOWDATA [ I] . ISENTNOSHOWCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 739;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEBUG_PRINT_ALL_STORED_DATA_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 755;
        Trace( "\r\n*** No Show Stored Data ***\r\n") ; 
        __context__.SourceCodeLine = 757;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)150; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 759;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NOSHOWDATA[ I ].SMEETINGID ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 761;
                Trace( " \r\nIndex: {0:d}\r\n", (ushort)I) ; 
                __context__.SourceCodeLine = 762;
                Trace( "   MeetingID: {0}\r\n", NOSHOWDATA [ I] . SMEETINGID ) ; 
                __context__.SourceCodeLine = 763;
                Trace( "   Subject: {0}\r\n", NOSHOWDATA [ I] . SSUBJECT ) ; 
                __context__.SourceCodeLine = 764;
                Trace( "   Date Added: {0}\r\n", NOSHOWDATA [ I] . SDATADATE ) ; 
                __context__.SourceCodeLine = 765;
                Trace( "   NoShow Count: {0:d}\r\n", (ushort)NOSHOWDATA[ I ].INOSHOWCOUNT) ; 
                __context__.SourceCodeLine = 766;
                Trace( "   Sent NoShow Count: {0:d}\r\n", (ushort)NOSHOWDATA[ I ].ISENTNOSHOWCOUNT) ; 
                } 
            
            __context__.SourceCodeLine = 757;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEANUP_STORED_DATA_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 773;
        if ( Functions.TestForTrue  ( ( Functions.Not( G_BCLEANUPBUSY ))  ) ) 
            { 
            __context__.SourceCodeLine = 775;
            G_BCLEANUPBUSY = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 776;
            CLEANUP_BUSY_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 778;
            CLEANUPDATA (  __context__  ) ; 
            __context__.SourceCodeLine = 780;
            G_BCLEANUPBUSY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 781;
            CLEANUP_BUSY_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString SDATA;
        SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
        
        
        __context__.SourceCodeLine = 790;
        if ( Functions.TestForTrue  ( ( G_BRXOK1)  ) ) 
            { 
            __context__.SourceCodeLine = 792;
            G_BRXOK1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 794;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 796;
                SDATA  .UpdateValue ( Functions.Gather ( "</NoShowData>" , FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 798;
                PROCESSDATA (  __context__ , SDATA) ; 
                __context__.SourceCodeLine = 794;
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
        
        __context__.SourceCodeLine = 813;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 815;
        G_BRXOK1 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 817;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SINITIALIZED != "YES"))  ) ) 
            { 
            __context__.SourceCodeLine = 819;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)150; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 821;
                NOSHOWDATA [ I] . SMEETINGID  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 822;
                NOSHOWDATA [ I] . SRVMEETINGID  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 823;
                NOSHOWDATA [ I] . INOSHOWCOUNT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 824;
                NOSHOWDATA [ I] . ISENTNOSHOWCOUNT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 819;
                } 
            
            __context__.SourceCodeLine = 827;
            _SplusNVRAM.G_SINITIALIZED  .UpdateValue ( "YES"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SLASTREMOVEDID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    _SplusNVRAM.G_SINITIALIZED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    NOSHOWDATA  = new DATA[ 151 ];
    for( uint i = 0; i < 151; i++ )
    {
        NOSHOWDATA [i] = new DATA( this, true );
        NOSHOWDATA [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    DEBUG_CLEAR_ALL_STORED_DATA = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_CLEAR_ALL_STORED_DATA__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_CLEAR_ALL_STORED_DATA__DigitalInput__, DEBUG_CLEAR_ALL_STORED_DATA );
    
    DEBUG_PRINT_ALL_STORED_DATA = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_PRINT_ALL_STORED_DATA__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_PRINT_ALL_STORED_DATA__DigitalInput__, DEBUG_PRINT_ALL_STORED_DATA );
    
    CLEANUP_STORED_DATA = new Crestron.Logos.SplusObjects.DigitalInput( CLEANUP_STORED_DATA__DigitalInput__, this );
    m_DigitalInputList.Add( CLEANUP_STORED_DATA__DigitalInput__, CLEANUP_STORED_DATA );
    
    CLEANUP_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( CLEANUP_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( CLEANUP_BUSY_FB__DigitalOutput__, CLEANUP_BUSY_FB );
    
    REMOVED_MEETING_SINGLE = new Crestron.Logos.SplusObjects.DigitalOutput( REMOVED_MEETING_SINGLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( REMOVED_MEETING_SINGLE__DigitalOutput__, REMOVED_MEETING_SINGLE );
    
    REMOVED_MEETING_SERIES = new Crestron.Logos.SplusObjects.DigitalOutput( REMOVED_MEETING_SERIES__DigitalOutput__, this );
    m_DigitalOutputList.Add( REMOVED_MEETING_SERIES__DigitalOutput__, REMOVED_MEETING_SERIES );
    
    MAX_STORED_DATA_DAYS = new Crestron.Logos.SplusObjects.AnalogInput( MAX_STORED_DATA_DAYS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAX_STORED_DATA_DAYS__AnalogSerialInput__, MAX_STORED_DATA_DAYS );
    
    DEBUG_NOSHOW_COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( DEBUG_NOSHOW_COUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DEBUG_NOSHOW_COUNT__AnalogSerialOutput__, DEBUG_NOSHOW_COUNT );
    
    ROOMID = new Crestron.Logos.SplusObjects.StringInput( ROOMID__AnalogSerialInput__, 150, this );
    m_StringInputList.Add( ROOMID__AnalogSerialInput__, ROOMID );
    
    STATUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STATUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( STATUS__DOLLAR____AnalogSerialOutput__, STATUS__DOLLAR__ );
    
    REMOVED_MEETING_SINGLE_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( REMOVED_MEETING_SINGLE_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( REMOVED_MEETING_SINGLE_ID__DOLLAR____AnalogSerialOutput__, REMOVED_MEETING_SINGLE_ID__DOLLAR__ );
    
    REMOVED_MEETING_SERIES_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( REMOVED_MEETING_SERIES_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( REMOVED_MEETING_SERIES_ID__DOLLAR____AnalogSerialOutput__, REMOVED_MEETING_SERIES_ID__DOLLAR__ );
    
    TO_RV_REMOVEMEETING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_REMOVEMEETING__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_REMOVEMEETING__DOLLAR____AnalogSerialOutput__, TO_RV_REMOVEMEETING__DOLLAR__ );
    
    FROM_RV_REMOVERESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_REMOVERESPONSE__DOLLAR____AnalogSerialInput__, 2000, this );
    m_StringInputList.Add( FROM_RV_REMOVERESPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_REMOVERESPONSE__DOLLAR__ );
    
    FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR____AnalogSerialInput__, FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_7___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_7___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_8___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_8___CallbackFn );
    
    DEBUG_CLEAR_ALL_STORED_DATA.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_CLEAR_ALL_STORED_DATA_OnPush_0, false ) );
    DEBUG_PRINT_ALL_STORED_DATA.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_PRINT_ALL_STORED_DATA_OnPush_1, false ) );
    CLEANUP_STORED_DATA.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEANUP_STORED_DATA_OnPush_2, false ) );
    FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_NOSHOW_INTERFACE_V2_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_7___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_8___Callback;


const uint DEBUG__DigitalInput__ = 0;
const uint DEBUG_CLEAR_ALL_STORED_DATA__DigitalInput__ = 1;
const uint DEBUG_PRINT_ALL_STORED_DATA__DigitalInput__ = 2;
const uint CLEANUP_STORED_DATA__DigitalInput__ = 3;
const uint MAX_STORED_DATA_DAYS__AnalogSerialInput__ = 0;
const uint ROOMID__AnalogSerialInput__ = 1;
const uint FROM_RV_REMOVERESPONSE__DOLLAR____AnalogSerialInput__ = 2;
const uint FROM_WORKDAY_MODULE_NOSHOW_DATA__DOLLAR____AnalogSerialInput__ = 3;
const uint CLEANUP_BUSY_FB__DigitalOutput__ = 0;
const uint REMOVED_MEETING_SINGLE__DigitalOutput__ = 1;
const uint REMOVED_MEETING_SERIES__DigitalOutput__ = 2;
const uint DEBUG_NOSHOW_COUNT__AnalogSerialOutput__ = 0;
const uint STATUS__DOLLAR____AnalogSerialOutput__ = 1;
const uint REMOVED_MEETING_SINGLE_ID__DOLLAR____AnalogSerialOutput__ = 2;
const uint REMOVED_MEETING_SERIES_ID__DOLLAR____AnalogSerialOutput__ = 3;
const uint TO_RV_REMOVEMEETING__DOLLAR____AnalogSerialOutput__ = 4;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public CrestronString G_SINITIALIZED;
            
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
public class DATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, true)]
    public CrestronString  SSUBJECT;
    
    [SplusStructAttribute(1, false, true)]
    public CrestronString  SMEETINGID;
    
    [SplusStructAttribute(2, false, true)]
    public CrestronString  SRVMEETINGID;
    
    [SplusStructAttribute(3, false, true)]
    public CrestronString  SDATADATE;
    
    [SplusStructAttribute(4, false, true)]
    public ushort  INOSHOWCOUNT = 0;
    
    [SplusStructAttribute(5, false, true)]
    public ushort  ISENTNOSHOWCOUNT = 0;
    
    
    public DATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        SSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, Owner );
        SRVMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        SDATADATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, Owner );
        
        
    }
    
}

}
