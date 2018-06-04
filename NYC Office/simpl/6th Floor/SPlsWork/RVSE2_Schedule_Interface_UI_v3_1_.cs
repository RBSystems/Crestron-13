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

namespace UserModule_RVSE2_SCHEDULE_INTERFACE_UI_V3_1_
{
    public class UserModuleClass_RVSE2_SCHEDULE_INTERFACE_UI_V3_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_LOGIC;
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE_MODULE;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput EN_PREV_DAY_FROM_TODAY;
        Crestron.Logos.SplusObjects.DigitalInput EN_SELECTED_BLOCK_MOREINFO;
        Crestron.Logos.SplusObjects.DigitalInput EN_SELECTED_BLOCK_ADDAPPT;
        Crestron.Logos.SplusObjects.DigitalInput CHECK_DATE;
        Crestron.Logos.SplusObjects.DigitalInput SHOW_WORKDAY_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput GET_USER_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput CANCEL_GET_USER_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput GET_USER_SCHEDULE_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput MOREINFO_DATA_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput ADD_APPOINTMENT_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput ADD_APPOINTMENT_REQUEST_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput ADD_APPOINTMENT_DUR_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput ADD_APPOINTMENT_DUR_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput PREV_DAY;
        Crestron.Logos.SplusObjects.DigitalInput NEXT_DAY;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT;
        Crestron.Logos.SplusObjects.AnalogInput COLUMN_WIDTH;
        Crestron.Logos.SplusObjects.AnalogInput PRIVACY_LEVEL;
        Crestron.Logos.SplusObjects.AnalogInput SELECTED_BLOCK;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_PAGE;
        Crestron.Logos.SplusObjects.AnalogInput FIELD_QTY;
        Crestron.Logos.SplusObjects.AnalogInput DATE_FORMAT;
        Crestron.Logos.SplusObjects.StringInput DEFAULT_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ADD_APPT_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_WORKDAY_MOD_DATAOUT__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZE_MODULE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput CALENDAR_UPDATED;
        Crestron.Logos.SplusObjects.DigitalOutput SELECTED_BLOCK_SHOW_MOREINFO;
        Crestron.Logos.SplusObjects.DigitalOutput SELECTED_BLOCK_SHOW_ADDAPPT;
        Crestron.Logos.SplusObjects.DigitalOutput ON_WORKDAY;
        Crestron.Logos.SplusObjects.DigitalOutput FORCE_WORKDAY_RETURN;
        Crestron.Logos.SplusObjects.DigitalOutput NEED_WORKDAY_SCHEDULE_UPDATE;
        Crestron.Logos.SplusObjects.AnalogOutput USER_SCHEDULE_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput WORK_SCHEDULE_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput MORE_INFO_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput ADD_APPT_REQUEST_MODE;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_SCHEDULEQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_CREATEMEETING__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_LABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_MEETINGID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_START_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_END_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_BLOCK_END_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEETING_REQUIRED_ATTENDEES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEETING_OPTIONAL_ATTENDEES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ADD_APPOINTMENT_START_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ADD_APPOINTMENT_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ADD_APPOINTMENT_DUR__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> TIME_BLOCK_MODE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TIME_BLOCK_TEXT__DOLLAR__;
        EVENTDATA [] DAYEVENT;
        EVENTDATA [] WORKEVENT;
        ushort G_BRXOK1 = 0;
        ushort G_BONWORKDAY = 0;
        CrestronString G_SRXDATA1;
        CrestronString [] G_SMONTH;
        CrestronString G_STODAYDATE;
        CrestronString G_SREQSTARTDATE;
        ushort G_IREQMONTH = 0;
        ushort G_IREQDAY = 0;
        ushort G_IREQYEAR = 0;
        CrestronString G_SSCHEDULELABEL;
        ushort G_IDAYSINMONTH = 0;
        ushort G_IREQSTARTDATE = 0;
        ushort [] G_IBLOCKEVENTINDEX;
        ushort G_ITODAYMONTH = 0;
        ushort G_ITODAYDAY = 0;
        ushort G_ITODAYYEAR = 0;
        CrestronString G_SUSERREQUESTID;
        CrestronString G_SATTENDEESREQUESTID;
        CrestronString G_SCREATEDAYMEETINGREQUESTID;
        CrestronString G_SCREATEWORKMEETINGREQUESTID;
        ushort G_ISTOREDDAYCOUNT = 0;
        ushort G_ISTOREDWORKCOUNT = 0;
        CrestronString G_SADDAPPTSTARTDATE;
        CrestronString G_SADDAPPTSTARTTIME;
        ushort G_IADDAPPTSTARTBLOCK = 0;
        ushort G_IADDAPPTENDBLOCK = 0;
        ushort G_IADDAPPTDURBLOCKS = 0;
        ushort G_IADDAPPTMAXDURBLOCKS = 0;
        CrestronString G_SCREATEDAYMEETINGSTARTDATE;
        private void CHECKDATE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 273;
            G_ITODAYMONTH = (ushort) ( Functions.GetMonthNum() ) ; 
            __context__.SourceCodeLine = 274;
            G_ITODAYDAY = (ushort) ( Functions.GetDateNum() ) ; 
            __context__.SourceCodeLine = 275;
            G_ITODAYYEAR = (ushort) ( Functions.GetYearNum() ) ; 
            __context__.SourceCodeLine = 277;
            G_STODAYDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 278;
            G_STODAYDATE  .UpdateValue ( Functions.Left ( G_STODAYDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( G_STODAYDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( G_STODAYDATE ,  (int) ( 2 ) )  ) ; 
            
            }
            
        private void CLEARCALENDAR (  SplusExecutionContext __context__, ushort ISTARTBLOCK , ushort IENDBLOCK ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 299;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 301;
                Trace( "\r\n** ClearCalendar **\r\n") ; 
                __context__.SourceCodeLine = 302;
                Trace( "  StartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
                __context__.SourceCodeLine = 303;
                Trace( "  EndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
                } 
            
            __context__.SourceCodeLine = 306;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTBLOCK ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IENDBLOCK; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 308;
                G_IBLOCKEVENTINDEX [ I] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 310;
                TIME_BLOCK_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 311;
                TIME_BLOCK_TEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 306;
                } 
            
            
            }
            
        private ushort DATETOINTEGER (  SplusExecutionContext __context__, CrestronString DATA ) 
            { 
            ushort IMONTH = 0;
            ushort IDAY = 0;
            ushort IYEAR = 0;
            
            ushort IDATEVALUE = 0;
            
            
            __context__.SourceCodeLine = 334;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 335;
                Trace( "DateToInteger. Date:{0}\r\n", DATA ) ; 
                }
            
            __context__.SourceCodeLine = 337;
            IMONTH = (ushort) ( (Functions.Atoi( Functions.Mid( DATA , (int)( 6 ) , (int)( 2 ) ) ) * 100) ) ; 
            __context__.SourceCodeLine = 338;
            IDAY = (ushort) ( Functions.Atoi( Functions.Right( DATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 339;
            IYEAR = (ushort) ( Functions.Atoi( Functions.Left( DATA , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 341;
            IDATEVALUE = (ushort) ( ((IMONTH + IDAY) + IYEAR) ) ; 
            __context__.SourceCodeLine = 343;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 344;
                Trace( " iDateValue:{0:d}\r\n", (ushort)IDATEVALUE) ; 
                }
            
            __context__.SourceCodeLine = 346;
            return (ushort)( IDATEVALUE) ; 
            
            }
            
        private ushort TIMETOINTEGER (  SplusExecutionContext __context__, CrestronString SDATA , ushort IFORMAT ) 
            { 
            ushort ITIMEVALUE = 0;
            ushort ITIMEH = 0;
            ushort ITIMEM = 0;
            
            
            __context__.SourceCodeLine = 373;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 375;
                Trace( "\r\n** TimeToInteger **\r\n") ; 
                __context__.SourceCodeLine = 376;
                Trace( "  Format:{0:d}\r\n", (ushort)IFORMAT) ; 
                __context__.SourceCodeLine = 377;
                Trace( "  Data:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 380;
            ITIMEVALUE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 382;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 384;
                ITIMEH = (ushort) ( (Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) * 100) ) ; 
                __context__.SourceCodeLine = 385;
                ITIMEM = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 386;
                ITIMEVALUE = (ushort) ( (ITIMEH + ITIMEM) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 388;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 390;
                    ITIMEH = (ushort) ( (Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) * 60) ) ; 
                    __context__.SourceCodeLine = 391;
                    ITIMEM = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 392;
                    ITIMEVALUE = (ushort) ( (ITIMEH + ITIMEM) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 395;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 397;
                Trace( "  iTimeValue:{0:d}\r\n", (ushort)ITIMEVALUE) ; 
                } 
            
            __context__.SourceCodeLine = 400;
            return (ushort)( ITIMEVALUE) ; 
            
            }
            
        private ushort DAYSINMONTH (  SplusExecutionContext __context__, ushort IMONTH , ushort IYEAR ) 
            { 
            ushort IDAYS = 0;
            
            
            __context__.SourceCodeLine = 422;
            IDAYS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 424;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 426;
                Trace( "\r\n** DaysInMonth **\r\n") ; 
                __context__.SourceCodeLine = 427;
                Trace( "  Month:{0:d}\r\n", (ushort)IMONTH) ; 
                __context__.SourceCodeLine = 428;
                Trace( "  Year:{0:d}\r\n", (ushort)IYEAR) ; 
                } 
            
            __context__.SourceCodeLine = 431;
            switch ((int)IMONTH)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 435;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 436;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 440;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IYEAR , 4 ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 442;
                        IDAYS = (ushort) ( 29 ) ; 
                        __context__.SourceCodeLine = 443;
                        break ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 447;
                        IDAYS = (ushort) ( 28 ) ; 
                        __context__.SourceCodeLine = 448;
                        break ; 
                        } 
                    
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 453;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 454;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 458;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 459;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 463;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 464;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 468;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 469;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 473;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 474;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 478;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 479;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 483;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 484;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 488;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 489;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 493;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 494;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 498;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 499;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 503;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 505;
                Trace( "  Days:{0:d}\r\n", (ushort)IDAYS) ; 
                } 
            
            __context__.SourceCodeLine = 508;
            return (ushort)( IDAYS) ; 
            
            }
            
        private CrestronString NEXTDAYDATE (  SplusExecutionContext __context__, CrestronString SSTARTDATE , CrestronString SDAYS ) 
            { 
            ushort ISTARTMONTH = 0;
            ushort ISTARTDAY = 0;
            ushort ISTARTYEAR = 0;
            
            ushort INEXTMONTH = 0;
            ushort INEXTDAY = 0;
            ushort INEXTYEAR = 0;
            
            ushort IDAYSINMONTH = 0;
            ushort IDAYS = 0;
            
            CrestronString SNEXTDAYDATE;
            SNEXTDAYDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 538;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 540;
                Trace( "\r\n** NextDayDate **\r\n") ; 
                __context__.SourceCodeLine = 541;
                Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
                __context__.SourceCodeLine = 542;
                Trace( "  Days:{0}\r\n", SDAYS ) ; 
                } 
            
            __context__.SourceCodeLine = 546;
            ISTARTMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SSTARTDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 547;
            ISTARTDAY = (ushort) ( Functions.Atoi( Functions.Right( SSTARTDATE , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 548;
            ISTARTYEAR = (ushort) ( Functions.Atoi( Functions.Left( SSTARTDATE , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 549;
            IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( ISTARTMONTH ) , (ushort)( ISTARTYEAR ) ) ) ; 
            __context__.SourceCodeLine = 551;
            IDAYS = (ushort) ( Functions.Atoi( SDAYS ) ) ; 
            __context__.SourceCodeLine = 553;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 555;
                Trace( "  StartMonth:{0:d}\r\n", (ushort)ISTARTMONTH) ; 
                __context__.SourceCodeLine = 556;
                Trace( "  StartDay:{0:d}\r\n", (ushort)ISTARTDAY) ; 
                __context__.SourceCodeLine = 557;
                Trace( "  StartYear:{0:d}\r\n", (ushort)ISTARTYEAR) ; 
                __context__.SourceCodeLine = 558;
                Trace( "  DaysInMonth:{0:d}\r\n", (ushort)IDAYSINMONTH) ; 
                __context__.SourceCodeLine = 559;
                Trace( "  Days:{0:d}\r\n", (ushort)IDAYS) ; 
                } 
            
            __context__.SourceCodeLine = 566;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (ISTARTDAY + IDAYS) <= IDAYSINMONTH ))  ) ) 
                { 
                __context__.SourceCodeLine = 570;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 572;
                    Trace( "  Days left in month.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 575;
                INEXTMONTH = (ushort) ( ISTARTMONTH ) ; 
                __context__.SourceCodeLine = 576;
                INEXTDAY = (ushort) ( (ISTARTDAY + IDAYS) ) ; 
                __context__.SourceCodeLine = 577;
                INEXTYEAR = (ushort) ( ISTARTYEAR ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 583;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 585;
                    Trace( "  No days left in month.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 589;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTMONTH == 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 592;
                    INEXTMONTH = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 593;
                    INEXTDAY = (ushort) ( ((ISTARTDAY + IDAYS) - IDAYSINMONTH) ) ; 
                    __context__.SourceCodeLine = 594;
                    INEXTYEAR = (ushort) ( (ISTARTYEAR + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 599;
                    INEXTMONTH = (ushort) ( (ISTARTMONTH + 1) ) ; 
                    __context__.SourceCodeLine = 600;
                    INEXTDAY = (ushort) ( ((ISTARTDAY + IDAYS) - IDAYSINMONTH) ) ; 
                    __context__.SourceCodeLine = 601;
                    INEXTYEAR = (ushort) ( ISTARTYEAR ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 606;
            SNEXTDAYDATE  .UpdateValue ( Functions.ItoA (  (int) ( INEXTYEAR ) )  ) ; 
            __context__.SourceCodeLine = 608;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTMONTH < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 610;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + "0" + Functions.ItoA (  (int) ( INEXTMONTH ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 614;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + Functions.ItoA (  (int) ( INEXTMONTH ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 617;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTDAY < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 619;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + "0" + Functions.ItoA (  (int) ( INEXTDAY ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 623;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + Functions.ItoA (  (int) ( INEXTDAY ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 626;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 628;
                Trace( "  NextDayDate:{0}\r\n", SNEXTDAYDATE ) ; 
                } 
            
            __context__.SourceCodeLine = 631;
            return ( SNEXTDAYDATE ) ; 
            
            }
            
        private CrestronString FORMATDATE (  SplusExecutionContext __context__, CrestronString SDATA , ushort IFORMAT ) 
            { 
            CrestronString SLOCALCOPY;
            CrestronString SDATE;
            SLOCALCOPY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            ushort IMONTH = 0;
            
            CrestronString SYEAR;
            CrestronString SMONTH;
            CrestronString SMONTHNAME;
            CrestronString SDAY;
            SYEAR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            SMONTH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            SMONTHNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
            SDAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 653;
            IMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 655;
            SYEAR  .UpdateValue ( Functions.Left ( SDATA ,  (int) ( 4 ) )  ) ; 
            __context__.SourceCodeLine = 656;
            SMONTH  .UpdateValue ( Functions.Mid ( SDATA ,  (int) ( 6 ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 657;
            SMONTHNAME  .UpdateValue ( G_SMONTH [ IMONTH ]  ) ; 
            __context__.SourceCodeLine = 658;
            SDAY  .UpdateValue ( Functions.Right ( SDATA ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 660;
            IFORMAT = (ushort) ( (IFORMAT + (2 * DATE_FORMAT  .UshortValue)) ) ; 
            __context__.SourceCodeLine = 662;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 664;
                Trace( "\r\n** FormatDate **\r\n") ; 
                __context__.SourceCodeLine = 665;
                Trace( "  Data:{0}\r\n", SDATA ) ; 
                __context__.SourceCodeLine = 666;
                Trace( "  Format:{0:d}\r\n", (ushort)IFORMAT) ; 
                } 
            
            __context__.SourceCodeLine = 670;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 672;
                SDATE  .UpdateValue ( SMONTHNAME + " " + SDAY + ", " + SYEAR  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 674;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 676;
                    SDATE  .UpdateValue ( SMONTH + "/" + SDAY + "/" + SYEAR  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 679;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 681;
                        SDATE  .UpdateValue ( SDAY + " " + SMONTHNAME + " " + SYEAR  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 683;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 685;
                            SDATE  .UpdateValue ( SDAY + "/" + SMONTH + "/" + SYEAR  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 688;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 5))  ) ) 
                                { 
                                __context__.SourceCodeLine = 690;
                                SDATE  .UpdateValue ( SYEAR + ", " + SMONTHNAME + " " + SDAY  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 692;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 6))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 694;
                                    SDATE  .UpdateValue ( SYEAR + "/" + SMONTH + "/" + SDAY  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 697;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 699;
                Trace( "  Formatted Date:{0}\r\n", SDATE ) ; 
                } 
            
            __context__.SourceCodeLine = 702;
            return ( SDATE ) ; 
            
            }
            
        private CrestronString FORMATDATEREQ (  SplusExecutionContext __context__, ushort MODE ) 
            { 
            CrestronString SLOCALDATE;
            CrestronString SDATE;
            CrestronString SMONTH;
            CrestronString SDAY;
            SLOCALDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SMONTH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            SDAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 710;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 711;
                Trace( "FormatDateReq. Mode:{0:d}\r\n", (ushort)MODE) ; 
                }
            
            __context__.SourceCodeLine = 713;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)MODE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 717;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 718;
                            Trace( " Using Local Processor Date\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 720;
                        SLOCALDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
                        __context__.SourceCodeLine = 721;
                        SDATE  .UpdateValue ( Functions.Left ( SLOCALDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( SLOCALDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SLOCALDATE ,  (int) ( 2 ) )  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 726;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 727;
                            Trace( " Using Integer Variables\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 729;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IREQMONTH < 10 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 730;
                            SMONTH  .UpdateValue ( "0" + Functions.ItoA (  (int) ( G_IREQMONTH ) )  ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 732;
                            SMONTH  .UpdateValue ( Functions.ItoA (  (int) ( G_IREQMONTH ) )  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 734;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IREQDAY < 10 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 735;
                            SDAY  .UpdateValue ( "0" + Functions.ItoA (  (int) ( G_IREQDAY ) )  ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 737;
                            SDAY  .UpdateValue ( Functions.ItoA (  (int) ( G_IREQDAY ) )  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 739;
                        SDATE  .UpdateValue ( Functions.ItoA (  (int) ( G_IREQYEAR ) ) + "-" + SMONTH + "-" + SDAY  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 743;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 744;
                Trace( "Date:{0}\r\n", SDATE ) ; 
                }
            
            __context__.SourceCodeLine = 746;
            return ( SDATE ) ; 
            
            }
            
        private CrestronString ITOLA (  SplusExecutionContext __context__, ushort INUMBER ) 
            { 
            CrestronString SNUMBER;
            SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 765;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INUMBER < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 767;
                SNUMBER  .UpdateValue ( "0" + Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 771;
                SNUMBER  .UpdateValue ( Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 774;
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
            
            
            __context__.SourceCodeLine = 783;
            IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 784;
            IMINUTE = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 787;
            if ( Functions.TestForTrue  ( ( TIME_FORMAT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 789;
                SHOUR  .UpdateValue ( ITOLA (  __context__ , (ushort)( IHOUR ))  ) ; 
                __context__.SourceCodeLine = 790;
                SAMPM  .UpdateValue ( ""  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 795;
                SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( Mod( IHOUR , 12 ) ) )  ) ; 
                __context__.SourceCodeLine = 796;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IHOUR == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IHOUR == 12) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 797;
                    SHOUR  .UpdateValue ( "12"  ) ; 
                    }
                
                __context__.SourceCodeLine = 800;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 802;
                    SAMPM  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 806;
                    SAMPM  .UpdateValue ( "PM"  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 811;
            SMINUTE  .UpdateValue ( ITOLA (  __context__ , (ushort)( IMINUTE ))  ) ; 
            __context__.SourceCodeLine = 813;
            STIME  .UpdateValue ( SHOUR + ":" + SMINUTE + " " + SAMPM  ) ; 
            __context__.SourceCodeLine = 815;
            return ( STIME ) ; 
            
            }
            
        private void WRAPBLOCKTEXT (  SplusExecutionContext __context__, CrestronString STEXT , ushort ISTARTBLOCK , ushort IENDBLOCK ) 
            { 
            ushort I = 0;
            ushort ICOLUMNWIDTH = 0;
            ushort ISPACEPOS = 0;
            ushort ILASTSPACEPOS = 0;
            ushort ISTARTPOS = 0;
            ushort BFINDSPACE = 0;
            
            CrestronString STEXTCHUNK;
            STEXTCHUNK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 829;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 831;
                Trace( "\r\n** WrapBlockText **\r\n") ; 
                __context__.SourceCodeLine = 832;
                Trace( "  TextLen:{0:d}\r\n", (ushort)Functions.Length( STEXT )) ; 
                __context__.SourceCodeLine = 833;
                Trace( "  StartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
                __context__.SourceCodeLine = 834;
                Trace( "  EndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
                } 
            
            __context__.SourceCodeLine = 837;
            ICOLUMNWIDTH = (ushort) ( COLUMN_WIDTH  .UshortValue ) ; 
            __context__.SourceCodeLine = 840;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTBLOCK ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IENDBLOCK; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 844;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEXT ) > ICOLUMNWIDTH ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 849;
                    STEXTCHUNK  .UpdateValue ( Functions.Left ( STEXT ,  (int) ( ICOLUMNWIDTH ) )  ) ; 
                    __context__.SourceCodeLine = 852;
                    if ( Functions.TestForTrue  ( ( Functions.Find( " " , STEXTCHUNK ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 854;
                        BFINDSPACE = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 855;
                        ISTARTPOS = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 858;
                        do 
                            { 
                            __context__.SourceCodeLine = 860;
                            ISPACEPOS = (ushort) ( Functions.Find( " " , STEXTCHUNK , ISTARTPOS ) ) ; 
                            __context__.SourceCodeLine = 862;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 864;
                                Trace( "  iSpacePos:{0:d}\r\n", (ushort)ISPACEPOS) ; 
                                } 
                            
                            __context__.SourceCodeLine = 867;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISPACEPOS > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 871;
                                ILASTSPACEPOS = (ushort) ( ISPACEPOS ) ; 
                                __context__.SourceCodeLine = 874;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISPACEPOS < ICOLUMNWIDTH ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 877;
                                    ISTARTPOS = (ushort) ( (ISPACEPOS + 1) ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 882;
                                    BFINDSPACE = (ushort) ( 0 ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 889;
                                BFINDSPACE = (ushort) ( 0 ) ; 
                                } 
                            
                            } 
                        while (false == ( Functions.TestForTrue  ( Functions.Not( BFINDSPACE )) )); 
                        __context__.SourceCodeLine = 895;
                        STEXTCHUNK  .UpdateValue ( Functions.Remove ( ILASTSPACEPOS, STEXT )  ) ; 
                        } 
                    
                    else 
                        { 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 905;
                    if ( Functions.TestForTrue  ( ( Functions.Length( STEXT ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 907;
                        STEXTCHUNK  .UpdateValue ( Functions.Remove ( Functions.Length( STEXT ), STEXT )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 911;
                        STEXTCHUNK  .UpdateValue ( ""  ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 915;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 917;
                    Trace( "  Block:{0:d}\r\n", (ushort)I) ; 
                    __context__.SourceCodeLine = 918;
                    Trace( "  TextChunk:{0}\r\n", STEXTCHUNK ) ; 
                    } 
                
                __context__.SourceCodeLine = 921;
                TIME_BLOCK_TEXT__DOLLAR__ [ I]  .UpdateValue ( STEXTCHUNK  ) ; 
                __context__.SourceCodeLine = 840;
                } 
            
            
            }
            
        private void UPDATECALENDAR (  SplusExecutionContext __context__, ushort ITYPE ) 
            { 
            ushort I = 0;
            ushort J = 0;
            ushort BVALIDEVENT = 0;
            ushort BPRIVATEEVENT = 0;
            ushort BPRIVATEBLOCK = 0;
            ushort BNEEDTEXTWRAP = 0;
            ushort ISTARTBLOCK = 0;
            ushort IENDBLOCK = 0;
            ushort ISTARTINDEX = 0;
            ushort IENDINDEX = 0;
            ushort IEVENTCOUNT = 0;
            ushort ISPAN = 0;
            ushort IPREVIOUSENDBLOCK = 0;
            
            CrestronString SEVENTORGANIZER;
            CrestronString SEVENTSUBJECT;
            CrestronString SBLOCKTEXT;
            SEVENTORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, this );
            SEVENTSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SBLOCKTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            
            __context__.SourceCodeLine = 947;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 949;
                Trace( "\r\n** UpdateCalendar **\r\n") ; 
                __context__.SourceCodeLine = 950;
                Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
                } 
            
            __context__.SourceCodeLine = 953;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 955;
                IEVENTCOUNT = (ushort) ( G_ISTOREDDAYCOUNT ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 957;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 959;
                    IEVENTCOUNT = (ushort) ( G_ISTOREDWORKCOUNT ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 962;
            IPREVIOUSENDBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 964;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 966;
                Trace( "  EventCount:{0:d}\r\n", (ushort)IEVENTCOUNT) ; 
                } 
            
            __context__.SourceCodeLine = 970;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 974;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)IEVENTCOUNT; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 976;
                    ISTARTBLOCK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 977;
                    IENDBLOCK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 978;
                    BPRIVATEEVENT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 979;
                    BVALIDEVENT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 980;
                    BNEEDTEXTWRAP = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 981;
                    BPRIVATEBLOCK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 983;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 985;
                        SEVENTORGANIZER  .UpdateValue ( DAYEVENT [ I] . ORGANIZER  ) ; 
                        __context__.SourceCodeLine = 986;
                        SEVENTSUBJECT  .UpdateValue ( DAYEVENT [ I] . SUBJECT  ) ; 
                        __context__.SourceCodeLine = 988;
                        ISTARTBLOCK = (ushort) ( DAYEVENT[ I ].STARTBLOCK ) ; 
                        __context__.SourceCodeLine = 989;
                        IENDBLOCK = (ushort) ( DAYEVENT[ I ].ENDBLOCK ) ; 
                        __context__.SourceCodeLine = 991;
                        BPRIVATEEVENT = (ushort) ( DAYEVENT[ I ].ISPRIVATE ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 993;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 995;
                            SEVENTORGANIZER  .UpdateValue ( WORKEVENT [ I] . ORGANIZER  ) ; 
                            __context__.SourceCodeLine = 996;
                            SEVENTSUBJECT  .UpdateValue ( WORKEVENT [ I] . SUBJECT  ) ; 
                            __context__.SourceCodeLine = 998;
                            ISTARTBLOCK = (ushort) ( WORKEVENT[ I ].STARTBLOCK ) ; 
                            __context__.SourceCodeLine = 999;
                            IENDBLOCK = (ushort) ( WORKEVENT[ I ].ENDBLOCK ) ; 
                            __context__.SourceCodeLine = 1001;
                            BPRIVATEEVENT = (ushort) ( WORKEVENT[ I ].ISPRIVATE ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 1005;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SEVENTORGANIZER ) == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 1006;
                        SEVENTORGANIZER  .UpdateValue ( "Unknown"  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1009;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTBLOCK == IENDBLOCK))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1011;
                        ISPAN = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1016;
                        ISPAN = (ushort) ( ((IENDBLOCK - ISTARTBLOCK) + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1019;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 1021;
                        Trace( "  Event:{0:d}\r\n", (ushort)I) ; 
                        __context__.SourceCodeLine = 1022;
                        Trace( "  Span:{0:d}\r\n", (ushort)ISPAN) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1026;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTARTBLOCK > (IPREVIOUSENDBLOCK + 1) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1028;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPREVIOUSENDBLOCK == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1033;
                            CLEARCALENDAR (  __context__ , (ushort)( 1 ), (ushort)( (ISTARTBLOCK - 1) )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1040;
                            CLEARCALENDAR (  __context__ , (ushort)( (IPREVIOUSENDBLOCK + 1) ), (ushort)( (ISTARTBLOCK - 1) )) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 1045;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PRIVACY_LEVEL  .UshortValue == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1049;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1051;
                            Trace( "  Public room.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 1054;
                        if ( Functions.TestForTrue  ( ( BPRIVATEEVENT)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1056;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1058;
                                Trace( "  Private event.\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 1061;
                            SBLOCKTEXT  .UpdateValue ( "Private"  ) ; 
                            __context__.SourceCodeLine = 1062;
                            BPRIVATEBLOCK = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1066;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1068;
                                Trace( "  Public event.\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 1071;
                            SBLOCKTEXT  .UpdateValue ( "[" + SEVENTORGANIZER + "] " + SEVENTSUBJECT  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1074;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PRIVACY_LEVEL  .UshortValue == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1078;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1080;
                                Trace( "  Semi-Private room.\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 1083;
                            SBLOCKTEXT  .UpdateValue ( "[" + SEVENTORGANIZER + "] " + "Private"  ) ; 
                            __context__.SourceCodeLine = 1084;
                            BPRIVATEBLOCK = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1086;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PRIVACY_LEVEL  .UshortValue == 2))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1090;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1092;
                                    Trace( "  Fully-Private room.\r\n") ; 
                                    } 
                                
                                __context__.SourceCodeLine = 1095;
                                SBLOCKTEXT  .UpdateValue ( "Private"  ) ; 
                                __context__.SourceCodeLine = 1096;
                                BPRIVATEBLOCK = (ushort) ( 1 ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 1102;
                    IPREVIOUSENDBLOCK = (ushort) ( IENDBLOCK ) ; 
                    __context__.SourceCodeLine = 1104;
                    ISTARTINDEX = (ushort) ( ISTARTBLOCK ) ; 
                    __context__.SourceCodeLine = 1105;
                    IENDINDEX = (ushort) ( IENDBLOCK ) ; 
                    __context__.SourceCodeLine = 1107;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 1109;
                        Trace( "  EventIndex:{0:d}\r\n", (ushort)I) ; 
                        __context__.SourceCodeLine = 1110;
                        Trace( "  EventStartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
                        __context__.SourceCodeLine = 1111;
                        Trace( "  EventEndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
                        __context__.SourceCodeLine = 1112;
                        Trace( "  EventOrganizer:{0}\r\n", SEVENTORGANIZER ) ; 
                        __context__.SourceCodeLine = 1113;
                        Trace( "  EventSubject:{0}\r\n", SEVENTSUBJECT ) ; 
                        __context__.SourceCodeLine = 1114;
                        Trace( "  PrivateBlock:{0:d}\r\n", (ushort)BPRIVATEBLOCK) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1119;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISPAN == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1121;
                        if ( Functions.TestForTrue  ( ( Functions.Not( BPRIVATEBLOCK ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1123;
                            TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 5 ) ; 
                            __context__.SourceCodeLine = 1124;
                            G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( I ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1128;
                            TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 7 ) ; 
                            __context__.SourceCodeLine = 1129;
                            G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1133;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SBLOCKTEXT ) > COLUMN_WIDTH  .UshortValue ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1135;
                            SBLOCKTEXT  .UpdateValue ( Functions.Left ( SBLOCKTEXT ,  (int) ( COLUMN_WIDTH  .UshortValue ) )  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1138;
                        TIME_BLOCK_TEXT__DOLLAR__ [ ISTARTINDEX]  .UpdateValue ( SBLOCKTEXT  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1140;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISPAN == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1143;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SBLOCKTEXT ) > COLUMN_WIDTH  .UshortValue ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1145;
                                BNEEDTEXTWRAP = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 1150;
                            if ( Functions.TestForTrue  ( ( Functions.Not( BPRIVATEBLOCK ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1152;
                                TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 6 ) ; 
                                __context__.SourceCodeLine = 1153;
                                G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( I ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1157;
                                TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 8 ) ; 
                                __context__.SourceCodeLine = 1158;
                                G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 1162;
                            TIME_BLOCK_MODE [ IENDINDEX]  .Value = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 1163;
                            G_IBLOCKEVENTINDEX [ IENDINDEX] = (ushort) ( I ) ; 
                            __context__.SourceCodeLine = 1166;
                            if ( Functions.TestForTrue  ( ( BNEEDTEXTWRAP)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1168;
                                WRAPBLOCKTEXT (  __context__ , SBLOCKTEXT, (ushort)( ISTARTINDEX ), (ushort)( IENDINDEX )) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1172;
                                TIME_BLOCK_TEXT__DOLLAR__ [ ISTARTINDEX]  .UpdateValue ( SBLOCKTEXT  ) ; 
                                __context__.SourceCodeLine = 1173;
                                TIME_BLOCK_TEXT__DOLLAR__ [ IENDINDEX]  .UpdateValue ( ""  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1179;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SBLOCKTEXT ) > COLUMN_WIDTH  .UshortValue ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1181;
                                BNEEDTEXTWRAP = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 1186;
                            if ( Functions.TestForTrue  ( ( Functions.Not( BPRIVATEBLOCK ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1188;
                                TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 6 ) ; 
                                __context__.SourceCodeLine = 1189;
                                G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( I ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1193;
                                TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 8 ) ; 
                                __context__.SourceCodeLine = 1194;
                                G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 1198;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISPAN > 2 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1200;
                                ushort __FN_FORSTART_VAL__2 = (ushort) ( (ISTARTINDEX + 1) ) ;
                                ushort __FN_FOREND_VAL__2 = (ushort)(IENDINDEX - 1); 
                                int __FN_FORSTEP_VAL__2 = (int)1; 
                                for ( J  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (J  >= __FN_FORSTART_VAL__2) && (J  <= __FN_FOREND_VAL__2) ) : ( (J  <= __FN_FORSTART_VAL__2) && (J  >= __FN_FOREND_VAL__2) ) ; J  += (ushort)__FN_FORSTEP_VAL__2) 
                                    { 
                                    __context__.SourceCodeLine = 1202;
                                    TIME_BLOCK_MODE [ J]  .Value = (ushort) ( 3 ) ; 
                                    __context__.SourceCodeLine = 1203;
                                    G_IBLOCKEVENTINDEX [ J] = (ushort) ( I ) ; 
                                    __context__.SourceCodeLine = 1205;
                                    if ( Functions.TestForTrue  ( ( Functions.Not( BNEEDTEXTWRAP ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1207;
                                        TIME_BLOCK_TEXT__DOLLAR__ [ J]  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 1200;
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 1213;
                            TIME_BLOCK_MODE [ IENDINDEX]  .Value = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 1214;
                            G_IBLOCKEVENTINDEX [ IENDINDEX] = (ushort) ( I ) ; 
                            __context__.SourceCodeLine = 1217;
                            if ( Functions.TestForTrue  ( ( BNEEDTEXTWRAP)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1219;
                                WRAPBLOCKTEXT (  __context__ , SBLOCKTEXT, (ushort)( ISTARTINDEX ), (ushort)( IENDINDEX )) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1223;
                                TIME_BLOCK_TEXT__DOLLAR__ [ ISTARTINDEX]  .UpdateValue ( SBLOCKTEXT  ) ; 
                                __context__.SourceCodeLine = 1224;
                                TIME_BLOCK_TEXT__DOLLAR__ [ IENDINDEX]  .UpdateValue ( ""  ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 974;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1232;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPREVIOUSENDBLOCK == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1237;
                CLEARCALENDAR (  __context__ , (ushort)( 1 ), (ushort)( 48 )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1243;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDINDEX < 48 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1245;
                    CLEARCALENDAR (  __context__ , (ushort)( (IENDINDEX + 1) ), (ushort)( 48 )) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1249;
            SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 1250;
            G_SSCHEDULELABEL  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 1252;
            CALENDAR_UPDATED  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1253;
            CALENDAR_UPDATED  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private CrestronString CALENDARBLOCK (  SplusExecutionContext __context__, ushort ITYPE , CrestronString SSTARTDATE , CrestronString SSTARTTIME , CrestronString SENDDATE , CrestronString SENDTIME ) 
            { 
            ushort I = 0;
            ushort BNEEDCALCSTARTBLOCK = 0;
            ushort BNEEDCALCENDBLOCK = 0;
            ushort ISTARTBLOCK = 0;
            ushort IENDBLOCK = 0;
            ushort ISTARTTIMEMINUTES = 0;
            ushort IENDTIMEMINUTES = 0;
            ushort IBLOCKSTARTTIMEMINUTES = 0;
            ushort IBLOCKENDTIMEMINUTES = 0;
            
            CrestronString SDATE;
            CrestronString SRETURNDATA;
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SRETURNDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 1271;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1273;
                Trace( "\r\n** CalendarBlock **\r\n") ; 
                __context__.SourceCodeLine = 1274;
                Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
                __context__.SourceCodeLine = 1275;
                Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
                __context__.SourceCodeLine = 1276;
                Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
                __context__.SourceCodeLine = 1277;
                Trace( "  EndDate:{0}\r\n", SENDDATE ) ; 
                __context__.SourceCodeLine = 1278;
                Trace( "  EndTime:{0}\r\n", SENDTIME ) ; 
                } 
            
            __context__.SourceCodeLine = 1281;
            ISTARTBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1282;
            IENDBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1283;
            BNEEDCALCSTARTBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1284;
            BNEEDCALCENDBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1286;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1288;
                SDATE  .UpdateValue ( G_SREQSTARTDATE  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1290;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1292;
                    SDATE  .UpdateValue ( G_STODAYDATE  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 1296;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SDATE == SSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (SDATE == SENDDATE) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1300;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1302;
                    Trace( "  Event starts and ends on date\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 1305;
                BNEEDCALCSTARTBLOCK = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1306;
                BNEEDCALCENDBLOCK = (ushort) ( 1 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1308;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (Functions.CompareStrings( SDATE, SSTARTDATE ) > 0) ) && Functions.TestForTrue ( Functions.BoolToInt (SDATE == SENDDATE) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1312;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 1314;
                        Trace( "  Event starts prior to date and ends on date\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 1317;
                    ISTARTBLOCK = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1319;
                    BNEEDCALCENDBLOCK = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1321;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SDATE == SSTARTDATE) ) && Functions.TestForTrue ( (Functions.CompareStrings( SDATE , SENDDATE ) < 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1325;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1327;
                            Trace( "  Event starts on date and ends after date\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 1330;
                        IENDBLOCK = (ushort) ( 48 ) ; 
                        __context__.SourceCodeLine = 1332;
                        BNEEDCALCSTARTBLOCK = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1334;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (Functions.CompareStrings( SDATE, SSTARTDATE ) > 0) ) && Functions.TestForTrue ( (Functions.CompareStrings( SDATE , SENDDATE ) < 0) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1338;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1340;
                                Trace( "  Event starts prior to date and ends after date\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 1343;
                            ISTARTBLOCK = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 1344;
                            IENDBLOCK = (ushort) ( 48 ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 1348;
            if ( Functions.TestForTrue  ( ( BNEEDCALCSTARTBLOCK)  ) ) 
                { 
                __context__.SourceCodeLine = 1350;
                ISTARTTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SSTARTTIME , (ushort)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 1353;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)48; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 1355;
                    IBLOCKSTARTTIMEMINUTES = (ushort) ( ((I * 30) - 30) ) ; 
                    __context__.SourceCodeLine = 1356;
                    IBLOCKENDTIMEMINUTES = (ushort) ( (I * 30) ) ; 
                    __context__.SourceCodeLine = 1358;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ISTARTTIMEMINUTES >= IBLOCKSTARTTIMEMINUTES ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ISTARTTIMEMINUTES < IBLOCKENDTIMEMINUTES ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1361;
                        ISTARTBLOCK = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 1362;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 1353;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1368;
            if ( Functions.TestForTrue  ( ( BNEEDCALCENDBLOCK)  ) ) 
                { 
                __context__.SourceCodeLine = 1370;
                IENDTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SENDTIME , (ushort)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 1373;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)48; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 1375;
                    IBLOCKSTARTTIMEMINUTES = (ushort) ( ((I * 30) - 30) ) ; 
                    __context__.SourceCodeLine = 1376;
                    IBLOCKENDTIMEMINUTES = (ushort) ( (I * 30) ) ; 
                    __context__.SourceCodeLine = 1378;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IENDTIMEMINUTES > IBLOCKSTARTTIMEMINUTES ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IENDTIMEMINUTES <= IBLOCKENDTIMEMINUTES ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1381;
                        IENDBLOCK = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 1382;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 1373;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1387;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1389;
                Trace( "  StartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
                __context__.SourceCodeLine = 1390;
                Trace( "  EndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
                } 
            
            __context__.SourceCodeLine = 1393;
            SRETURNDATA  .UpdateValue ( Functions.ItoA (  (int) ( ISTARTBLOCK ) ) + "," + Functions.ItoA (  (int) ( IENDBLOCK ) )  ) ; 
            __context__.SourceCodeLine = 1395;
            return ( SRETURNDATA ) ; 
            
            }
            
        private void PROCESSEVENTLIST (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SREMOVEDDATA;
            SREMOVEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            
            ushort ICOUNT = 0;
            ushort ISTARTBLOCK = 0;
            ushort IENDBLOCK = 0;
            ushort BPRIVATE = 0;
            ushort BEXCHANGEPRIVATE = 0;
            
            CrestronString SMEETINGID;
            CrestronString SSTARTDATE;
            CrestronString SSTARTTIME;
            CrestronString SENDDATE;
            CrestronString SENDTIME;
            CrestronString SORGANIZER;
            CrestronString SSUBJECT;
            SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 160, this );
            SSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1500, this );
            
            
            __context__.SourceCodeLine = 1417;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1419;
                Trace( "\r\n** ProcessEventList **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1422;
            WORK_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 1424;
            ICOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1426;
            if ( Functions.TestForTrue  ( ( G_BONWORKDAY)  ) ) 
                { 
                __context__.SourceCodeLine = 1429;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Updating schedule ..."  ) ; 
                __context__.SourceCodeLine = 1430;
                G_SSCHEDULELABEL  .UpdateValue ( "Updating schedule ..."  ) ; 
                } 
            
            __context__.SourceCodeLine = 1433;
            do 
                { 
                __context__.SourceCodeLine = 1435;
                SREMOVEDDATA  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 1437;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Event>" , SREMOVEDDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1439;
                    SMEETINGID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1440;
                    SSTARTDATE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1441;
                    SSTARTTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1442;
                    SENDDATE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1443;
                    SENDTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1444;
                    SORGANIZER  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1445;
                    SSUBJECT  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1447;
                    BPRIVATE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1448;
                    BEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1450;
                    ISTARTBLOCK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1451;
                    IENDBLOCK = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1453;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Event>" , SREMOVEDDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1455;
                        ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                        __context__.SourceCodeLine = 1457;
                        WORKEVENT [ ICOUNT] . STARTDATE  .UpdateValue ( SSTARTDATE  ) ; 
                        __context__.SourceCodeLine = 1458;
                        WORKEVENT [ ICOUNT] . ENDDATE  .UpdateValue ( SENDDATE  ) ; 
                        __context__.SourceCodeLine = 1459;
                        WORKEVENT [ ICOUNT] . STARTTIME  .UpdateValue ( SSTARTTIME  ) ; 
                        __context__.SourceCodeLine = 1460;
                        WORKEVENT [ ICOUNT] . ENDTIME  .UpdateValue ( SENDTIME  ) ; 
                        __context__.SourceCodeLine = 1461;
                        WORKEVENT [ ICOUNT] . MEETINGID  .UpdateValue ( SMEETINGID  ) ; 
                        __context__.SourceCodeLine = 1462;
                        WORKEVENT [ ICOUNT] . ORGANIZER  .UpdateValue ( SORGANIZER  ) ; 
                        __context__.SourceCodeLine = 1463;
                        WORKEVENT [ ICOUNT] . SUBJECT  .UpdateValue ( SSUBJECT  ) ; 
                        __context__.SourceCodeLine = 1465;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( BPRIVATE ) || Functions.TestForTrue ( BEXCHANGEPRIVATE )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1466;
                            WORKEVENT [ ICOUNT] . ISPRIVATE = (ushort) ( 1 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1468;
                            WORKEVENT [ ICOUNT] . ISPRIVATE = (ushort) ( 0 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1470;
                        WORKEVENT [ ICOUNT] . STARTBLOCK = (ushort) ( ISTARTBLOCK ) ; 
                        __context__.SourceCodeLine = 1471;
                        WORKEVENT [ ICOUNT] . ENDBLOCK = (ushort) ( IENDBLOCK ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1473;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingID>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1475;
                            SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1477;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</StartDate>" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1480;
                                SSTARTDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1482;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</StartTime>" , SREMOVEDDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1485;
                                    SSTARTTIME  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1487;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</StartBlock>" , SREMOVEDDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1490;
                                        ISTARTBLOCK = (ushort) ( Functions.Atoi( Functions.Left( SREMOVEDDATA , (int)( (Functions.Length( SREMOVEDDATA ) - 13) ) ) ) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1492;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</EndDate>" , SREMOVEDDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1495;
                                            SENDDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 10) ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1497;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "</EndTime>" , SREMOVEDDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1500;
                                                SENDTIME  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 10) ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1502;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "</EndBlock>" , SREMOVEDDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1505;
                                                    IENDBLOCK = (ushort) ( Functions.Atoi( Functions.Left( SREMOVEDDATA , (int)( (Functions.Length( SREMOVEDDATA ) - 11) ) ) ) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1507;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Organizer>" , SREMOVEDDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1509;
                                                        SORGANIZER  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                                        __context__.SourceCodeLine = 1511;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SORGANIZER == "Unknown Name") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( DEFAULT_ORGANIZER__DOLLAR__ ) > 0 ) )) ))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 1512;
                                                            SORGANIZER  .UpdateValue ( DEFAULT_ORGANIZER__DOLLAR__  ) ; 
                                                            }
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1514;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</IsPrivate>" , SREMOVEDDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1516;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVEDDATA ))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 1517;
                                                                BPRIVATE = (ushort) ( 1 ) ; 
                                                                }
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1519;
                                                                BPRIVATE = (ushort) ( 0 ) ; 
                                                                }
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1521;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "</IsExchangePrivate>" , SREMOVEDDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1523;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVEDDATA ))  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 1524;
                                                                    BEXCHANGEPRIVATE = (ushort) ( 1 ) ; 
                                                                    }
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 1526;
                                                                    BEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                                                                    }
                                                                
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1528;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "</Subject>" , SREMOVEDDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1530;
                                                                    SSUBJECT  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 10) ) )  ) ; 
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
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 1535;
            G_ISTOREDWORKCOUNT = (ushort) ( ICOUNT ) ; 
            __context__.SourceCodeLine = 1537;
            WORK_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1539;
            CHECKDATE (  __context__  ) ; 
            __context__.SourceCodeLine = 1542;
            if ( Functions.TestForTrue  ( ( G_BONWORKDAY)  ) ) 
                { 
                __context__.SourceCodeLine = 1544;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1546;
                    Trace( "  On workday.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 1550;
                UPDATECALENDAR (  __context__ , (ushort)( 2 )) ; 
                } 
            
            
            }
            
        private void PROCESSSCHEDULERESPONSE (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SREMOVEDDATA;
            CrestronString STEMP;
            SREMOVEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            
            ushort INODE = 0;
            ushort ICOUNT = 0;
            ushort ISTARTBLOCK = 0;
            ushort IENDBLOCK = 0;
            ushort BOKTOSTORE = 0;
            ushort BPRIVATE = 0;
            
            CrestronString SMEETINGID;
            CrestronString SSTARTDATE;
            CrestronString SSTARTTIME;
            CrestronString SENDDATE;
            CrestronString SENDTIME;
            CrestronString SORGANIZER;
            CrestronString SSUBJECT;
            SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 160, this );
            SSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            SENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            SORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1500, this );
            
            CrestronString SSTARTENDBLOCK;
            CrestronString SSTARTBLOCK;
            CrestronString SENDBLOCK;
            SSTARTENDBLOCK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            SSTARTBLOCK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            SENDBLOCK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            CrestronString SPREVENDDATE;
            CrestronString SPREVENDTIME;
            SPREVENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 18, this );
            SPREVENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 18, this );
            
            
            __context__.SourceCodeLine = 1582;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1584;
                Trace( "\r\n** ProcessScheduleResponse **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1588;
            INODE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1591;
            if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "<Errors>" , SDATA ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1593;
                ICOUNT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1595;
                USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 1597;
                SPREVENDDATE  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 1598;
                SPREVENDTIME  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 1601;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Updating schedule ..."  ) ; 
                __context__.SourceCodeLine = 1602;
                G_SSCHEDULELABEL  .UpdateValue ( "Updating schedule ..."  ) ; 
                __context__.SourceCodeLine = 1604;
                do 
                    { 
                    __context__.SourceCodeLine = 1606;
                    SREMOVEDDATA  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                    __context__.SourceCodeLine = 1608;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1610;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Event>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1612;
                            BOKTOSTORE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1614;
                            SMEETINGID  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1615;
                            SSTARTDATE  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1616;
                            SSTARTTIME  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1617;
                            SENDDATE  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1618;
                            SENDTIME  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1619;
                            SORGANIZER  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1620;
                            SSUBJECT  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 1622;
                            BPRIVATE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1624;
                            ISTARTBLOCK = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1625;
                            IENDBLOCK = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1627;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Event>" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1630;
                                SSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 1 ), SSTARTDATE, SSTARTTIME, SENDDATE, SENDTIME)  ) ; 
                                __context__.SourceCodeLine = 1633;
                                SSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SSTARTENDBLOCK )  ) ; 
                                __context__.SourceCodeLine = 1634;
                                SSTARTBLOCK  .UpdateValue ( Functions.Left ( SSTARTBLOCK ,  (int) ( (Functions.Length( SSTARTBLOCK ) - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 1635;
                                SENDBLOCK  .UpdateValue ( SSTARTENDBLOCK  ) ; 
                                __context__.SourceCodeLine = 1637;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1639;
                                    Trace( "  g_sReqStartDate:{0}.\r\n", G_SREQSTARTDATE ) ; 
                                    __context__.SourceCodeLine = 1640;
                                    Trace( "  sPrevEndDate:{0}.\r\n", SPREVENDDATE ) ; 
                                    __context__.SourceCodeLine = 1641;
                                    Trace( "  sPrevEndTime:{0}.\r\n", SPREVENDTIME ) ; 
                                    __context__.SourceCodeLine = 1642;
                                    Trace( "  sStartDate:{0}.\r\n", SSTARTDATE ) ; 
                                    __context__.SourceCodeLine = 1643;
                                    Trace( "  sStartTime:{0}.\r\n", SSTARTTIME ) ; 
                                    __context__.SourceCodeLine = 1644;
                                    Trace( "  sStartBlock:{0}.\r\n", SSTARTBLOCK ) ; 
                                    __context__.SourceCodeLine = 1645;
                                    Trace( "  sEndBlock:{0}.\r\n", SENDBLOCK ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 1650;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SENDBLOCK != "0") )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1656;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SPREVENDDATE ) == 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1660;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1662;
                                            Trace( "  Do not have previous end date. OK to store.\r\n") ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 1665;
                                        BOKTOSTORE = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1667;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPREVENDDATE == G_SREQSTARTDATE))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1671;
                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1673;
                                                Trace( "  Previous end date = g_sReqStartDate. Need to check for overlap.\r\n") ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 1676;
                                            if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SSTARTTIME, SPREVENDTIME ) > 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1680;
                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1682;
                                                    Trace( "  New event start time > previous start time. OK to store.\r\n") ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 1685;
                                                BOKTOSTORE = (ushort) ( 1 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1687;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSTARTTIME == SPREVENDTIME))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1691;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1693;
                                                        Trace( "  New event start time = previous start time. OK to store.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 1696;
                                                    BOKTOSTORE = (ushort) ( 1 ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 1700;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1702;
                                                        Trace( "  Not OK to store.\r\n") ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                }
                                            
                                            } 
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 1707;
                                    if ( Functions.TestForTrue  ( ( BOKTOSTORE)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1711;
                                        SPREVENDDATE  .UpdateValue ( SENDDATE  ) ; 
                                        __context__.SourceCodeLine = 1712;
                                        SPREVENDTIME  .UpdateValue ( SENDTIME  ) ; 
                                        __context__.SourceCodeLine = 1714;
                                        ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                                        __context__.SourceCodeLine = 1716;
                                        DAYEVENT [ ICOUNT] . STARTDATE  .UpdateValue ( SSTARTDATE  ) ; 
                                        __context__.SourceCodeLine = 1717;
                                        DAYEVENT [ ICOUNT] . ENDDATE  .UpdateValue ( SENDDATE  ) ; 
                                        __context__.SourceCodeLine = 1718;
                                        DAYEVENT [ ICOUNT] . STARTTIME  .UpdateValue ( SSTARTTIME  ) ; 
                                        __context__.SourceCodeLine = 1719;
                                        DAYEVENT [ ICOUNT] . ENDTIME  .UpdateValue ( SENDTIME  ) ; 
                                        __context__.SourceCodeLine = 1720;
                                        DAYEVENT [ ICOUNT] . MEETINGID  .UpdateValue ( SMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 1721;
                                        DAYEVENT [ ICOUNT] . ORGANIZER  .UpdateValue ( SORGANIZER  ) ; 
                                        __context__.SourceCodeLine = 1722;
                                        DAYEVENT [ ICOUNT] . SUBJECT  .UpdateValue ( SSUBJECT  ) ; 
                                        __context__.SourceCodeLine = 1723;
                                        DAYEVENT [ ICOUNT] . ISPRIVATE = (ushort) ( BPRIVATE ) ; 
                                        __context__.SourceCodeLine = 1725;
                                        DAYEVENT [ ICOUNT] . STARTBLOCK = (ushort) ( Functions.Atoi( SSTARTBLOCK ) ) ; 
                                        __context__.SourceCodeLine = 1726;
                                        DAYEVENT [ ICOUNT] . ENDBLOCK = (ushort) ( Functions.Atoi( SENDBLOCK ) ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1730;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingID>" , SREMOVEDDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1732;
                                    SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1734;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</dtStart>" , SREMOVEDDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1737;
                                        SSTARTDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( 10 ) )  ) ; 
                                        __context__.SourceCodeLine = 1740;
                                        SSTARTTIME  .UpdateValue ( Functions.Mid ( SREMOVEDDATA ,  (int) ( 12 ) ,  (int) ( 5 ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1742;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</dtEnd>" , SREMOVEDDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1745;
                                            SENDDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( 10 ) )  ) ; 
                                            __context__.SourceCodeLine = 1748;
                                            SENDTIME  .UpdateValue ( Functions.Mid ( SREMOVEDDATA ,  (int) ( 12 ) ,  (int) ( 5 ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1750;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Organizer>" , SREMOVEDDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1752;
                                                SORGANIZER  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                                __context__.SourceCodeLine = 1754;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SORGANIZER == "Unknown Name") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( DEFAULT_ORGANIZER__DOLLAR__ ) > 0 ) )) ))  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 1755;
                                                    SORGANIZER  .UpdateValue ( DEFAULT_ORGANIZER__DOLLAR__  ) ; 
                                                    }
                                                
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1757;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "</IsPrivate>" , SREMOVEDDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1759;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVEDDATA ))  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 1760;
                                                        BPRIVATE = (ushort) ( 1 ) ; 
                                                        }
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1762;
                                                        BPRIVATE = (ushort) ( 0 ) ; 
                                                        }
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1764;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</IsExchangePrivate>" , SREMOVEDDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1766;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVEDDATA ))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 1767;
                                                            BPRIVATE = (ushort) ( 1 ) ; 
                                                            }
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1769;
                                                            BPRIVATE = (ushort) ( 0 ) ; 
                                                            }
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1771;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Subject>" , SREMOVEDDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1773;
                                                            SSUBJECT  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 1775;
                                                            INODE = (ushort) ( 4 ) ; 
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
                        __context__.SourceCodeLine = 1778;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1780;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Subject>" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1782;
                                SSUBJECT  .UpdateValue ( SSUBJECT + Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 10) ) )  ) ; 
                                __context__.SourceCodeLine = 1784;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SSUBJECT ) > 230 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 1785;
                                    SSUBJECT  .UpdateValue ( Functions.Left ( SSUBJECT ,  (int) ( 230 ) )  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 1787;
                                INODE = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1791;
                                SSUBJECT  .UpdateValue ( SSUBJECT + SREMOVEDDATA  ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
                __context__.SourceCodeLine = 1799;
                G_ISTOREDDAYCOUNT = (ushort) ( ICOUNT ) ; 
                __context__.SourceCodeLine = 1802;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
                __context__.SourceCodeLine = 1803;
                G_SSCHEDULELABEL  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
                __context__.SourceCodeLine = 1806;
                UPDATECALENDAR (  __context__ , (ushort)( 1 )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1813;
                USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 1816;
                if ( Functions.TestForTrue  ( ( Functions.Not( G_BONWORKDAY ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1820;
                    SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Schedule response error ..."  ) ; 
                    __context__.SourceCodeLine = 1821;
                    G_SSCHEDULELABEL  .UpdateValue ( "Schedule response error ..."  ) ; 
                    __context__.SourceCodeLine = 1823;
                    CreateWait ( "__SPLS_TMPVAR__WAITLABEL_9__" , 200 , __SPLS_TMPVAR__WAITLABEL_9___Callback ) ;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1831;
            USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            
            }
            
        public void __SPLS_TMPVAR__WAITLABEL_9___CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 1825;
            FORCE_WORKDAY_RETURN  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1826;
            FORCE_WORKDAY_RETURN  .Value = (ushort) ( 0 ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void GETUSERSCHEDULE (  SplusExecutionContext __context__ ) 
        { 
        CrestronString SXMLDATA;
        SXMLDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
        
        
        __context__.SourceCodeLine = 1839;
        USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1843;
        SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Requesting schedule ..."  ) ; 
        __context__.SourceCodeLine = 1844;
        G_SSCHEDULELABEL  .UpdateValue ( "Requesting schedule ..."  ) ; 
        __context__.SourceCodeLine = 1846;
        G_SUSERREQUESTID  .UpdateValue ( "UserSchedule" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
        __context__.SourceCodeLine = 1848;
        SXMLDATA  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SUSERREQUESTID + "</RequestID>" + "<Start>" + G_SREQSTARTDATE + "T" + "00:00:00" + "</Start>" + "<HourSpan>24</HourSpan>" + "<FieldList>" + "<Field>MeetingID</Field>" + "<Field>dtStart</Field>" + "<Field>dtEnd</Field>" + "<Field>Organizer</Field>" + "<Field>Subject</Field>" + "<Field>IsPrivate</Field>" + "<Field>IsExchangePrivate</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
        __context__.SourceCodeLine = 1864;
        do 
            { 
            __context__.SourceCodeLine = 1866;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXMLDATA ) > 240 ))  ) ) 
                {
                __context__.SourceCodeLine = 1867;
                TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXMLDATA )  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1869;
                TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXMLDATA ), SXMLDATA )  ) ; 
                }
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXMLDATA ) == 0)) )); 
        
        }
        
    private void GETMOREINFO (  SplusExecutionContext __context__, CrestronString SMEETINGID ) 
        { 
        CrestronString SXMLDATA;
        SXMLDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
        
        
        __context__.SourceCodeLine = 1880;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 1882;
            Trace( "\r\n** GetMoreInfo **\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 1885;
        MORE_INFO_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1887;
        G_SATTENDEESREQUESTID  .UpdateValue ( "UserInfo" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
        __context__.SourceCodeLine = 1889;
        MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( "Requesting data ..."  ) ; 
        __context__.SourceCodeLine = 1890;
        MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( "Requesting data ..."  ) ; 
        __context__.SourceCodeLine = 1892;
        SXMLDATA  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SATTENDEESREQUESTID + "</RequestID>" + "<MeetingID>" + SMEETINGID + "</MeetingID>" + "<FieldList>" + "<Field>Attendees</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
        __context__.SourceCodeLine = 1901;
        do 
            { 
            __context__.SourceCodeLine = 1903;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXMLDATA ) > 240 ))  ) ) 
                {
                __context__.SourceCodeLine = 1904;
                TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXMLDATA )  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1906;
                TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXMLDATA ), SXMLDATA )  ) ; 
                }
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXMLDATA ) == 0)) )); 
        
        }
        
    private void PROCESSMOREINFORESPONSE (  SplusExecutionContext __context__, CrestronString SDATA ) 
        { 
        CrestronString SREMOVED;
        CrestronString SATTENDEES;
        SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
        SATTENDEES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
        
        ushort INODE = 0;
        ushort ICOUNT = 0;
        
        
        __context__.SourceCodeLine = 1920;
        INODE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1922;
        MORE_INFO_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 1924;
        do 
            { 
            __context__.SourceCodeLine = 1926;
            SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
            __context__.SourceCodeLine = 1928;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1930;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Required>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1932;
                    INODE = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 1933;
                    ICOUNT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1934;
                    SATTENDEES  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1936;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "<Optional>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1938;
                        INODE = (ushort) ( 3 ) ; 
                        __context__.SourceCodeLine = 1939;
                        ICOUNT = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 1940;
                        SATTENDEES  .UpdateValue ( ""  ) ; 
                        } 
                    
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1943;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1945;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Required>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1947;
                        INODE = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 1949;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1951;
                            MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1956;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SATTENDEES ) > 250 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1958;
                                SATTENDEES  .UpdateValue ( Functions.Left ( SATTENDEES ,  (int) ( 250 ) ) + " ..."  ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 1961;
                            MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( SATTENDEES  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1966;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Attendee>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1969;
                            if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "Conf Room" , SREMOVED ) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1972;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT < 10 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1974;
                                    ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                                    __context__.SourceCodeLine = 1976;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 1))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1978;
                                        SATTENDEES  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 1982;
                                        SATTENDEES  .UpdateValue ( SATTENDEES + ", " + Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 1987;
                                    SATTENDEES  .UpdateValue ( SATTENDEES + " ..."  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1993;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1995;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Optional>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1997;
                            INODE = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 1999;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2001;
                                MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2006;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SATTENDEES ) > 250 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2008;
                                    SATTENDEES  .UpdateValue ( Functions.Left ( SATTENDEES ,  (int) ( 250 ) ) + " ..."  ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 2011;
                                MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( SATTENDEES  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2016;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Attendee>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2019;
                                if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "Conf Room" , SREMOVED ) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2022;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT < 10 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2024;
                                        ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                                        __context__.SourceCodeLine = 2026;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOUNT == 1))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 2028;
                                            SATTENDEES  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 2032;
                                            SATTENDEES  .UpdateValue ( SATTENDEES + ", " + Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 2037;
                                        SATTENDEES  .UpdateValue ( SATTENDEES + " ..."  ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            } 
                        
                        } 
                    
                    }
                
                }
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
        __context__.SourceCodeLine = 2046;
        MORE_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        }
        
    private void CREATEMEETING (  SplusExecutionContext __context__, CrestronString SSTARTDATE , CrestronString SSTARTTIME , CrestronString SENDDATE , CrestronString SENDTIME , CrestronString SSUBJECT ) 
        { 
        CrestronString SREQUESTID;
        CrestronString SDTSTART;
        CrestronString SDTEND;
        CrestronString SXML;
        SREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
        SDTSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        SDTEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
        
        
        __context__.SourceCodeLine = 2056;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2058;
            Trace( "\r\n** CreateMeeting **\r\n") ; 
            __context__.SourceCodeLine = 2059;
            Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
            __context__.SourceCodeLine = 2060;
            Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
            __context__.SourceCodeLine = 2061;
            Trace( "  EndDate:{0}\r\n", SENDDATE ) ; 
            __context__.SourceCodeLine = 2062;
            Trace( "  EndTime:{0}\r\n", SENDTIME ) ; 
            __context__.SourceCodeLine = 2063;
            Trace( "  Subject:{0}\r\n", SSUBJECT ) ; 
            } 
        
        __context__.SourceCodeLine = 2066;
        ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2068;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SSTARTDATE == G_STODAYDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (SENDDATE == G_STODAYDATE) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2070;
            G_SCREATEWORKMEETINGREQUESTID  .UpdateValue ( "UserCreateWork" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 2071;
            SREQUESTID  .UpdateValue ( G_SCREATEWORKMEETINGREQUESTID  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2075;
            G_SCREATEDAYMEETINGREQUESTID  .UpdateValue ( "UserCreateDay" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 2076;
            G_SCREATEDAYMEETINGSTARTDATE  .UpdateValue ( SSTARTDATE  ) ; 
            __context__.SourceCodeLine = 2077;
            SREQUESTID  .UpdateValue ( G_SCREATEDAYMEETINGREQUESTID  ) ; 
            } 
        
        __context__.SourceCodeLine = 2080;
        SDTSTART  .UpdateValue ( SSTARTDATE + "T" + SSTARTTIME + ":00"  ) ; 
        __context__.SourceCodeLine = 2081;
        SDTEND  .UpdateValue ( SENDDATE + "T" + SENDTIME + ":00"  ) ; 
        __context__.SourceCodeLine = 2085;
        SXML  .UpdateValue ( "<CreateSchedule>" + "<RequestID>" + SREQUESTID + "</RequestID>" + "<Event>" + "<dtStart>" + SDTSTART + "</dtStart>" + "<dtEnd>" + SDTEND + "</dtEnd>" + "<Subject>" + SSUBJECT + "</Subject>" + "</Event>" + "</CreateSchedule>"  ) ; 
        __context__.SourceCodeLine = 2096;
        do 
            { 
            __context__.SourceCodeLine = 2099;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2101;
                TO_RV_CREATEMEETING__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2105;
                TO_RV_CREATEMEETING__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
        
        }
        
    private void PROCESSCREATEMEETINGRESPONSE (  SplusExecutionContext __context__, ushort ITYPE , CrestronString SDATA ) 
        { 
        
        __context__.SourceCodeLine = 2113;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2115;
            Trace( "\r\n** ProcessCreateMeetingResponse **\r\n") ; 
            __context__.SourceCodeLine = 2116;
            Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
            } 
        
        __context__.SourceCodeLine = 2119;
        ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 2123;
        if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "<Error>" , SDATA ) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2127;
            ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 2130;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 2134;
                NEED_WORKDAY_SCHEDULE_UPDATE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 2135;
                NEED_WORKDAY_SCHEDULE_UPDATE  .Value = (ushort) ( 0 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2141;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCREATEDAYMEETINGSTARTDATE == G_SREQSTARTDATE))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2143;
                        GETUSERSCHEDULE (  __context__  ) ; 
                        } 
                    
                    } 
                
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2151;
            ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
            } 
        
        __context__.SourceCodeLine = 2154;
        ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        }
        
    private ushort NEXTEVENT (  SplusExecutionContext __context__, ushort ITYPE , CrestronString SSTARTTIME ) 
        { 
        ushort I = 0;
        ushort IEVENTCOUNT = 0;
        ushort INEXTEVENT = 0;
        
        
        __context__.SourceCodeLine = 2163;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2165;
            Trace( "\r\n** NextEvent **\r\n") ; 
            __context__.SourceCodeLine = 2166;
            Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
            __context__.SourceCodeLine = 2167;
            Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
            } 
        
        __context__.SourceCodeLine = 2170;
        INEXTEVENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2172;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 2174;
            IEVENTCOUNT = (ushort) ( G_ISTOREDDAYCOUNT ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2176;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 2178;
                IEVENTCOUNT = (ushort) ( G_ISTOREDWORKCOUNT ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 2181;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTCOUNT > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2183;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IEVENTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 2185;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2187;
                    if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( DAYEVENT[ I ].STARTTIME, SSTARTTIME ) > 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2189;
                        INEXTEVENT = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 2191;
                        break ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 2194;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2196;
                        if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( WORKEVENT[ I ].STARTTIME, SSTARTTIME ) > 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2198;
                            INEXTEVENT = (ushort) ( I ) ; 
                            __context__.SourceCodeLine = 2200;
                            break ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 2183;
                } 
            
            } 
        
        __context__.SourceCodeLine = 2207;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2209;
            Trace( "  NextEvent:{0:d}\r\n", (ushort)INEXTEVENT) ; 
            } 
        
        __context__.SourceCodeLine = 2212;
        return (ushort)( INEXTEVENT) ; 
        
        }
        
    private CrestronString BLOCKSTOHRMIN (  SplusExecutionContext __context__, ushort IBLOCKS ) 
        { 
        ushort ITIMEMINUTES = 0;
        ushort ITIMEHOUR = 0;
        ushort ITIMEMIN = 0;
        
        CrestronString STIME;
        STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        
        
        __context__.SourceCodeLine = 2223;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2225;
            Trace( "\r\n** BlocksToHrMin **\r\n") ; 
            __context__.SourceCodeLine = 2226;
            Trace( "  Blocks:{0:d}\r\n", (ushort)IBLOCKS) ; 
            } 
        
        __context__.SourceCodeLine = 2229;
        ITIMEMINUTES = (ushort) ( (IBLOCKS * 30) ) ; 
        __context__.SourceCodeLine = 2230;
        ITIMEHOUR = (ushort) ( (ITIMEMINUTES / 60) ) ; 
        __context__.SourceCodeLine = 2231;
        ITIMEMIN = (ushort) ( Mod( ITIMEMINUTES , 60 ) ) ; 
        __context__.SourceCodeLine = 2233;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIMEHOUR < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2235;
            STIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( ITIMEHOUR ) )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2239;
            STIME  .UpdateValue ( Functions.ItoA (  (int) ( ITIMEHOUR ) )  ) ; 
            } 
        
        __context__.SourceCodeLine = 2242;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIMEMIN < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2244;
            STIME  .UpdateValue ( STIME + ":" + "0" + Functions.ItoA (  (int) ( ITIMEMIN ) )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2248;
            STIME  .UpdateValue ( STIME + ":" + Functions.ItoA (  (int) ( ITIMEMIN ) )  ) ; 
            } 
        
        __context__.SourceCodeLine = 2251;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2253;
            Trace( "  Time:{0}\r\n", STIME ) ; 
            } 
        
        __context__.SourceCodeLine = 2256;
        return ( STIME ) ; 
        
        }
        
    private void SHOWWORKDAYSCHEDULE (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 2261;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2263;
            Trace( "\r\n** ShowWorkdaySchedule **\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 2266;
        ON_WORKDAY  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2267;
        G_BONWORKDAY = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2269;
        G_IREQYEAR = (ushort) ( G_ITODAYYEAR ) ; 
        __context__.SourceCodeLine = 2270;
        G_IREQMONTH = (ushort) ( G_ITODAYMONTH ) ; 
        __context__.SourceCodeLine = 2271;
        G_IREQDAY = (ushort) ( G_ITODAYDAY ) ; 
        __context__.SourceCodeLine = 2273;
        G_IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( G_IREQMONTH ) , (ushort)( G_IREQYEAR ) ) ) ; 
        __context__.SourceCodeLine = 2275;
        G_SREQSTARTDATE  .UpdateValue ( FORMATDATEREQ (  __context__ , (ushort)( 1 ))  ) ; 
        __context__.SourceCodeLine = 2278;
        if ( Functions.TestForTrue  ( ( ROOMVIEW_ONLINE  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2280;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORK_SCHEDULE_REQUEST_MODE  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2282;
                UPDATECALENDAR (  __context__ , (ushort)( 2 )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2287;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Updating schedule ..."  ) ; 
                __context__.SourceCodeLine = 2288;
                G_SSCHEDULELABEL  .UpdateValue ( "Updating schedule ..."  ) ; 
                } 
            
            } 
        
        
        }
        
    private void PROCESSFROMWORKDAYMODDATAOUT__DOLLAR__ (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 2295;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2297;
            Trace( "\r\n** ProcessFromWorkdayModDataOut$ **\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 2301;
        if ( Functions.TestForTrue  ( ( Functions.Find( "<Type>EventList</Type>" , G_SRXDATA1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2305;
            if ( Functions.TestForTrue  ( ( G_BONWORKDAY)  ) ) 
                { 
                __context__.SourceCodeLine = 2309;
                G_IREQYEAR = (ushort) ( G_ITODAYYEAR ) ; 
                __context__.SourceCodeLine = 2310;
                G_IREQMONTH = (ushort) ( G_ITODAYMONTH ) ; 
                __context__.SourceCodeLine = 2311;
                G_IREQDAY = (ushort) ( G_ITODAYDAY ) ; 
                __context__.SourceCodeLine = 2313;
                G_IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( G_IREQMONTH ) , (ushort)( G_IREQYEAR ) ) ) ; 
                __context__.SourceCodeLine = 2315;
                G_SREQSTARTDATE  .UpdateValue ( FORMATDATEREQ (  __context__ , (ushort)( 1 ))  ) ; 
                } 
            
            __context__.SourceCodeLine = 2318;
            PROCESSEVENTLIST (  __context__ , G_SRXDATA1) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2320;
            if ( Functions.TestForTrue  ( ( Functions.Find( "<Type>ScheduleResponse</Type>" , G_SRXDATA1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2325;
                if ( Functions.TestForTrue  ( ( Functions.Find( G_SUSERREQUESTID , G_SRXDATA1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2328;
                    PROCESSSCHEDULERESPONSE (  __context__ , G_SRXDATA1) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 2330;
                    if ( Functions.TestForTrue  ( ( Functions.Find( G_SATTENDEESREQUESTID , G_SRXDATA1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2333;
                        PROCESSMOREINFORESPONSE (  __context__ , G_SRXDATA1) ; 
                        } 
                    
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2336;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Type>CreateResponse</Type>" , G_SRXDATA1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2340;
                    if ( Functions.TestForTrue  ( ( Functions.Find( G_SCREATEDAYMEETINGREQUESTID , G_SRXDATA1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2342;
                        PROCESSCREATEMEETINGRESPONSE (  __context__ , (ushort)( 1 ), G_SRXDATA1) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2344;
                        if ( Functions.TestForTrue  ( ( Functions.Find( G_SCREATEWORKMEETINGREQUESTID , G_SRXDATA1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2346;
                            PROCESSCREATEMEETINGRESPONSE (  __context__ , (ushort)( 2 ), G_SRXDATA1) ; 
                            } 
                        
                        }
                    
                    } 
                
                }
            
            }
        
        
        }
        
    object INITIALIZE_MODULE_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            CrestronString SDATE;
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 2361;
            INITIALIZE_MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2363;
            G_BRXOK1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2364;
            G_SRXDATA1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 2366;
            USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2367;
            WORK_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2368;
            MORE_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2369;
            ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2371;
            G_BONWORKDAY = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2372;
            ON_WORKDAY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2374;
            SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 2376;
            G_SMONTH [ 1 ]  .UpdateValue ( "January"  ) ; 
            __context__.SourceCodeLine = 2377;
            G_SMONTH [ 2 ]  .UpdateValue ( "February"  ) ; 
            __context__.SourceCodeLine = 2378;
            G_SMONTH [ 3 ]  .UpdateValue ( "March"  ) ; 
            __context__.SourceCodeLine = 2379;
            G_SMONTH [ 4 ]  .UpdateValue ( "April"  ) ; 
            __context__.SourceCodeLine = 2380;
            G_SMONTH [ 5 ]  .UpdateValue ( "May"  ) ; 
            __context__.SourceCodeLine = 2381;
            G_SMONTH [ 6 ]  .UpdateValue ( "June"  ) ; 
            __context__.SourceCodeLine = 2382;
            G_SMONTH [ 7 ]  .UpdateValue ( "July"  ) ; 
            __context__.SourceCodeLine = 2383;
            G_SMONTH [ 8 ]  .UpdateValue ( "August"  ) ; 
            __context__.SourceCodeLine = 2384;
            G_SMONTH [ 9 ]  .UpdateValue ( "September"  ) ; 
            __context__.SourceCodeLine = 2385;
            G_SMONTH [ 10 ]  .UpdateValue ( "October"  ) ; 
            __context__.SourceCodeLine = 2386;
            G_SMONTH [ 11 ]  .UpdateValue ( "November"  ) ; 
            __context__.SourceCodeLine = 2387;
            G_SMONTH [ 12 ]  .UpdateValue ( "December"  ) ; 
            __context__.SourceCodeLine = 2389;
            CHECKDATE (  __context__  ) ; 
            __context__.SourceCodeLine = 2391;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)48; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 2393;
                TIME_BLOCK_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 2394;
                TIME_BLOCK_TEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 2391;
                } 
            
            __context__.SourceCodeLine = 2397;
            if ( Functions.TestForTrue  ( ( Functions.Not( ROOMVIEW_ONLINE  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 2399;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Can Not Retrieve Data"  ) ; 
                } 
            
            __context__.SourceCodeLine = 2402;
            INITIALIZE_MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CHECK_DATE_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2407;
        CHECKDATE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMVIEW_ONLINE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2412;
        CHECKDATE (  __context__  ) ; 
        __context__.SourceCodeLine = 2414;
        G_SREQSTARTDATE  .UpdateValue ( FORMATDATEREQ (  __context__ , (ushort)( 1 ))  ) ; 
        __context__.SourceCodeLine = 2415;
        G_IREQSTARTDATE = (ushort) ( DATETOINTEGER( __context__ , G_SREQSTARTDATE ) ) ; 
        __context__.SourceCodeLine = 2417;
        G_IREQYEAR = (ushort) ( G_ITODAYYEAR ) ; 
        __context__.SourceCodeLine = 2418;
        G_IREQMONTH = (ushort) ( G_ITODAYMONTH ) ; 
        __context__.SourceCodeLine = 2419;
        G_IREQDAY = (ushort) ( G_ITODAYDAY ) ; 
        __context__.SourceCodeLine = 2421;
        G_IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( G_IREQMONTH ) , (ushort)( G_IREQYEAR ) ) ) ; 
        __context__.SourceCodeLine = 2423;
        SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2424;
        G_SSCHEDULELABEL  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_USER_SCHEDULE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2432;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ROOMVIEW_ONLINE  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (USER_SCHEDULE_REQUEST_MODE  .Value == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2434;
            GETUSERSCHEDULE (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_USER_SCHEDULE_TIMEOUT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2440;
        G_SUSERREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2443;
        SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Request timeout ..."  ) ; 
        __context__.SourceCodeLine = 2444;
        G_SSCHEDULELABEL  .UpdateValue ( "Request timeout ..."  ) ; 
        __context__.SourceCodeLine = 2446;
        USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 2447;
        USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2449;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_10__" , 200 , __SPLS_TMPVAR__WAITLABEL_10___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_10___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 2451;
            SHOWWORKDAYSCHEDULE (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object CANCEL_GET_USER_SCHEDULE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2457;
        G_SUSERREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2459;
        USER_SCHEDULE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHOW_WORKDAY_SCHEDULE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2464;
        SHOWWORKDAYSCHEDULE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXT_DAY_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2470;
        if ( Functions.TestForTrue  ( ( G_BONWORKDAY)  ) ) 
            { 
            __context__.SourceCodeLine = 2472;
            ON_WORKDAY  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2473;
            G_BONWORKDAY = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 2476;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IREQDAY < G_IDAYSINMONTH ))  ) ) 
            {
            __context__.SourceCodeLine = 2477;
            G_IREQDAY = (ushort) ( (G_IREQDAY + 1) ) ; 
            }
        
        else 
            { 
            __context__.SourceCodeLine = 2480;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IREQMONTH != 12))  ) ) 
                { 
                __context__.SourceCodeLine = 2482;
                G_IREQMONTH = (ushort) ( (G_IREQMONTH + 1) ) ; 
                __context__.SourceCodeLine = 2483;
                G_IREQDAY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 2485;
                G_IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( G_IREQMONTH ) , (ushort)( G_IREQYEAR ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2489;
                G_IREQYEAR = (ushort) ( (G_IREQYEAR + 1) ) ; 
                __context__.SourceCodeLine = 2490;
                G_IREQMONTH = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 2491;
                G_IREQDAY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 2492;
                G_IDAYSINMONTH = (ushort) ( 31 ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 2496;
        G_SREQSTARTDATE  .UpdateValue ( FORMATDATEREQ (  __context__ , (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 2497;
        G_IREQSTARTDATE = (ushort) ( DATETOINTEGER( __context__ , G_SREQSTARTDATE ) ) ; 
        __context__.SourceCodeLine = 2500;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_IREQMONTH == G_ITODAYMONTH) ) && Functions.TestForTrue ( Functions.BoolToInt (G_IREQDAY == G_ITODAYDAY) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_IREQYEAR == G_ITODAYYEAR) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2506;
            ON_WORKDAY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2507;
            G_BONWORKDAY = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2509;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORK_SCHEDULE_REQUEST_MODE  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2511;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
                __context__.SourceCodeLine = 2513;
                UPDATECALENDAR (  __context__ , (ushort)( 2 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2515;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORK_SCHEDULE_REQUEST_MODE  .Value == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2517;
                    SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Receiving new schedule ..."  ) ; 
                    } 
                
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2525;
            SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 2527;
            ON_WORKDAY  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2528;
            G_BONWORKDAY = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREV_DAY_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2536;
        if ( Functions.TestForTrue  ( ( G_BONWORKDAY)  ) ) 
            { 
            __context__.SourceCodeLine = 2538;
            ON_WORKDAY  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2539;
            G_BONWORKDAY = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 2542;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IREQDAY > 1 ))  ) ) 
            {
            __context__.SourceCodeLine = 2543;
            G_IREQDAY = (ushort) ( (G_IREQDAY - 1) ) ; 
            }
        
        else 
            { 
            __context__.SourceCodeLine = 2546;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IREQMONTH != 1))  ) ) 
                { 
                __context__.SourceCodeLine = 2548;
                G_IREQMONTH = (ushort) ( (G_IREQMONTH - 1) ) ; 
                __context__.SourceCodeLine = 2549;
                G_IREQDAY = (ushort) ( DAYSINMONTH( __context__ , (ushort)( G_IREQMONTH ) , (ushort)( G_IREQYEAR ) ) ) ; 
                __context__.SourceCodeLine = 2551;
                G_IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( G_IREQMONTH ) , (ushort)( G_IREQYEAR ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2555;
                G_IREQYEAR = (ushort) ( (G_IREQYEAR - 1) ) ; 
                __context__.SourceCodeLine = 2556;
                G_IREQMONTH = (ushort) ( 12 ) ; 
                __context__.SourceCodeLine = 2557;
                G_IREQDAY = (ushort) ( 31 ) ; 
                __context__.SourceCodeLine = 2558;
                G_IDAYSINMONTH = (ushort) ( 31 ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 2562;
        G_SREQSTARTDATE  .UpdateValue ( FORMATDATEREQ (  __context__ , (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 2563;
        G_IREQSTARTDATE = (ushort) ( DATETOINTEGER( __context__ , G_SREQSTARTDATE ) ) ; 
        __context__.SourceCodeLine = 2566;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_IREQMONTH == G_ITODAYMONTH) ) && Functions.TestForTrue ( Functions.BoolToInt (G_IREQDAY == G_ITODAYDAY) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_IREQYEAR == G_ITODAYYEAR) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2572;
            ON_WORKDAY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2573;
            G_BONWORKDAY = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2575;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORK_SCHEDULE_REQUEST_MODE  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2577;
                SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
                __context__.SourceCodeLine = 2579;
                UPDATECALENDAR (  __context__ , (ushort)( 2 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2581;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORK_SCHEDULE_REQUEST_MODE  .Value == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2583;
                    SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Receiving new schedule ..."  ) ; 
                    } 
                
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2591;
            SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SREQSTARTDATE, (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 2593;
            ON_WORKDAY  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2594;
            G_BONWORKDAY = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTED_BLOCK_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IINDEX = 0;
        ushort IACTUALBLOCK = 0;
        ushort INEXTEVENT = 0;
        ushort IBLOCKSTARTTIMEMINUTES = 0;
        ushort IBLOCKSTARTTIMEHOUR = 0;
        ushort IBLOCKSTARTTIMEMIN = 0;
        
        CrestronString SBLOCKSTARTTIME;
        SBLOCKSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        
        
        __context__.SourceCodeLine = 2609;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2611;
            Trace( "\r\n** SelectedBlock **\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 2615;
        IACTUALBLOCK = (ushort) ( (((CURRENT_PAGE  .UshortValue * FIELD_QTY  .UshortValue) - FIELD_QTY  .UshortValue) + SELECTED_BLOCK  .UshortValue) ) ; 
        __context__.SourceCodeLine = 2617;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IACTUALBLOCK <= 48 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2620;
            IBLOCKSTARTTIMEMINUTES = (ushort) ( ((IACTUALBLOCK * 30) - 30) ) ; 
            __context__.SourceCodeLine = 2621;
            IBLOCKSTARTTIMEHOUR = (ushort) ( (IBLOCKSTARTTIMEMINUTES / 60) ) ; 
            __context__.SourceCodeLine = 2622;
            IBLOCKSTARTTIMEMIN = (ushort) ( Mod( IBLOCKSTARTTIMEMINUTES , 60 ) ) ; 
            __context__.SourceCodeLine = 2624;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBLOCKSTARTTIMEHOUR < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2626;
                SBLOCKSTARTTIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IBLOCKSTARTTIMEHOUR ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2630;
                SBLOCKSTARTTIME  .UpdateValue ( Functions.ItoA (  (int) ( IBLOCKSTARTTIMEHOUR ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2633;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBLOCKSTARTTIMEMIN < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2635;
                SBLOCKSTARTTIME  .UpdateValue ( SBLOCKSTARTTIME + ":" + "0" + Functions.ItoA (  (int) ( IBLOCKSTARTTIMEMIN ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2639;
                SBLOCKSTARTTIME  .UpdateValue ( SBLOCKSTARTTIME + ":" + Functions.ItoA (  (int) ( IBLOCKSTARTTIMEMIN ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2642;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2644;
                Trace( "  ActualBlock:{0:d}\r\n", (ushort)IACTUALBLOCK) ; 
                __context__.SourceCodeLine = 2645;
                Trace( "  BlockStartTime:{0}\r\n", SBLOCKSTARTTIME ) ; 
                } 
            
            __context__.SourceCodeLine = 2649;
            if ( Functions.TestForTrue  ( ( G_BONWORKDAY)  ) ) 
                { 
                __context__.SourceCodeLine = 2653;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2655;
                    Trace( "  On workday.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 2659;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ADD_APPT_REQUEST_MODE  .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (WORK_SCHEDULE_REQUEST_MODE  .Value == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (USER_SCHEDULE_REQUEST_MODE  .Value == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2665;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 2667;
                        Trace( " Not processing workday schedule, not add appt. active. & not user request active.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 2671;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBLOCKEVENTINDEX[ IACTUALBLOCK ] > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2675;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2677;
                            Trace( "  Block has data.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 2681;
                        if ( Functions.TestForTrue  ( ( EN_SELECTED_BLOCK_MOREINFO  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2685;
                            IINDEX = (ushort) ( G_IBLOCKEVENTINDEX[ IACTUALBLOCK ] ) ; 
                            __context__.SourceCodeLine = 2687;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 2689;
                                Trace( "  BlockEventIndex:{0:d}\r\n", (ushort)IINDEX) ; 
                                } 
                            
                            __context__.SourceCodeLine = 2692;
                            GETMOREINFO (  __context__ , WORKEVENT[ IINDEX ].MEETINGID) ; 
                            __context__.SourceCodeLine = 2694;
                            SELECTED_BLOCK_MEETINGID__DOLLAR__  .UpdateValue ( WORKEVENT [ IINDEX] . MEETINGID  ) ; 
                            __context__.SourceCodeLine = 2695;
                            SELECTED_BLOCK_SUBJECT__DOLLAR__  .UpdateValue ( WORKEVENT [ IINDEX] . SUBJECT  ) ; 
                            __context__.SourceCodeLine = 2696;
                            SELECTED_BLOCK_START_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , WORKEVENT[ IINDEX ].STARTDATE, (ushort)( 2 ))  ) ; 
                            __context__.SourceCodeLine = 2697;
                            SELECTED_BLOCK_START_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , WORKEVENT[ IINDEX ].STARTTIME)  ) ; 
                            __context__.SourceCodeLine = 2698;
                            SELECTED_BLOCK_END_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , WORKEVENT[ IINDEX ].ENDDATE, (ushort)( 2 ))  ) ; 
                            __context__.SourceCodeLine = 2699;
                            SELECTED_BLOCK_END_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , WORKEVENT[ IINDEX ].ENDTIME)  ) ; 
                            __context__.SourceCodeLine = 2702;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( WORKEVENT[ IINDEX ].ORGANIZER ) == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 2703;
                                SELECTED_BLOCK_ORGANIZER__DOLLAR__  .UpdateValue ( "Unknown"  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 2705;
                                SELECTED_BLOCK_ORGANIZER__DOLLAR__  .UpdateValue ( WORKEVENT [ IINDEX] . ORGANIZER  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 2707;
                            SELECTED_BLOCK_SHOW_MOREINFO  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2708;
                            SELECTED_BLOCK_SHOW_MOREINFO  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2715;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2717;
                            Trace( "  Block has no data.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 2721;
                        if ( Functions.TestForTrue  ( ( EN_SELECTED_BLOCK_ADDAPPT  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2723;
                            G_SADDAPPTSTARTDATE  .UpdateValue ( G_SREQSTARTDATE  ) ; 
                            __context__.SourceCodeLine = 2724;
                            G_SADDAPPTSTARTTIME  .UpdateValue ( SBLOCKSTARTTIME  ) ; 
                            __context__.SourceCodeLine = 2725;
                            G_IADDAPPTSTARTBLOCK = (ushort) ( IACTUALBLOCK ) ; 
                            __context__.SourceCodeLine = 2726;
                            G_IADDAPPTENDBLOCK = (ushort) ( IACTUALBLOCK ) ; 
                            __context__.SourceCodeLine = 2727;
                            G_IADDAPPTDURBLOCKS = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2730;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IACTUALBLOCK < 48 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2735;
                                INEXTEVENT = (ushort) ( NEXTEVENT( __context__ , (ushort)( 2 ) , G_SADDAPPTSTARTTIME ) ) ; 
                                __context__.SourceCodeLine = 2737;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTEVENT > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2739;
                                    G_IADDAPPTMAXDURBLOCKS = (ushort) ( (WORKEVENT[ INEXTEVENT ].STARTBLOCK - IACTUALBLOCK) ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 2743;
                                    G_IADDAPPTMAXDURBLOCKS = (ushort) ( (48 - IACTUALBLOCK) ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2749;
                                G_IADDAPPTMAXDURBLOCKS = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 2753;
                            ADD_APPOINTMENT_START_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SADDAPPTSTARTDATE, (ushort)( 2 ))  ) ; 
                            __context__.SourceCodeLine = 2754;
                            ADD_APPOINTMENT_START_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , G_SADDAPPTSTARTTIME)  ) ; 
                            __context__.SourceCodeLine = 2755;
                            ADD_APPOINTMENT_DUR__DOLLAR__  .UpdateValue ( BLOCKSTOHRMIN (  __context__ , (ushort)( G_IADDAPPTDURBLOCKS ))  ) ; 
                            __context__.SourceCodeLine = 2757;
                            SELECTED_BLOCK_SHOW_ADDAPPT  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2758;
                            SELECTED_BLOCK_SHOW_ADDAPPT  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2764;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 2766;
                        Trace( " Process active:\r\n") ; 
                        __context__.SourceCodeLine = 2767;
                        Trace( "  AddApptMode:{0:d}\r\n", (ushort)ADD_APPT_REQUEST_MODE  .Value) ; 
                        __context__.SourceCodeLine = 2768;
                        Trace( "  WorkSchedMode:{0:d}\r\n", (ushort)WORK_SCHEDULE_REQUEST_MODE  .Value) ; 
                        __context__.SourceCodeLine = 2769;
                        Trace( "  UserSchedMode:{0:d}\r\n", (ushort)USER_SCHEDULE_REQUEST_MODE  .Value) ; 
                        } 
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2777;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2779;
                    Trace( "  Not on workday.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 2783;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ADD_APPT_REQUEST_MODE  .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (USER_SCHEDULE_REQUEST_MODE  .Value == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2788;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 2790;
                        Trace( "  Not processing user schedule.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 2794;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBLOCKEVENTINDEX[ IACTUALBLOCK ] > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2798;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2800;
                            Trace( "  Block has data.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 2804;
                        if ( Functions.TestForTrue  ( ( EN_SELECTED_BLOCK_MOREINFO  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2808;
                            IINDEX = (ushort) ( G_IBLOCKEVENTINDEX[ IACTUALBLOCK ] ) ; 
                            __context__.SourceCodeLine = 2810;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 2812;
                                Trace( "  BlockEventIndex:{0:d}\r\n", (ushort)IINDEX) ; 
                                } 
                            
                            __context__.SourceCodeLine = 2815;
                            GETMOREINFO (  __context__ , DAYEVENT[ IINDEX ].MEETINGID) ; 
                            __context__.SourceCodeLine = 2817;
                            SELECTED_BLOCK_MEETINGID__DOLLAR__  .UpdateValue ( DAYEVENT [ IINDEX] . MEETINGID  ) ; 
                            __context__.SourceCodeLine = 2818;
                            SELECTED_BLOCK_ORGANIZER__DOLLAR__  .UpdateValue ( DAYEVENT [ IINDEX] . ORGANIZER  ) ; 
                            __context__.SourceCodeLine = 2819;
                            SELECTED_BLOCK_SUBJECT__DOLLAR__  .UpdateValue ( DAYEVENT [ IINDEX] . SUBJECT  ) ; 
                            __context__.SourceCodeLine = 2820;
                            SELECTED_BLOCK_START_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , DAYEVENT[ IINDEX ].STARTDATE, (ushort)( 2 ))  ) ; 
                            __context__.SourceCodeLine = 2821;
                            SELECTED_BLOCK_START_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , DAYEVENT[ IINDEX ].STARTTIME)  ) ; 
                            __context__.SourceCodeLine = 2822;
                            SELECTED_BLOCK_END_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , DAYEVENT[ IINDEX ].ENDDATE, (ushort)( 2 ))  ) ; 
                            __context__.SourceCodeLine = 2823;
                            SELECTED_BLOCK_END_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , DAYEVENT[ IINDEX ].ENDTIME)  ) ; 
                            __context__.SourceCodeLine = 2825;
                            SELECTED_BLOCK_SHOW_MOREINFO  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2826;
                            SELECTED_BLOCK_SHOW_MOREINFO  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2833;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2835;
                            Trace( "  Block has no data.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 2839;
                        if ( Functions.TestForTrue  ( ( EN_SELECTED_BLOCK_ADDAPPT  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2841;
                            G_SADDAPPTSTARTDATE  .UpdateValue ( G_SREQSTARTDATE  ) ; 
                            __context__.SourceCodeLine = 2842;
                            G_SADDAPPTSTARTTIME  .UpdateValue ( SBLOCKSTARTTIME  ) ; 
                            __context__.SourceCodeLine = 2843;
                            G_IADDAPPTSTARTBLOCK = (ushort) ( IACTUALBLOCK ) ; 
                            __context__.SourceCodeLine = 2844;
                            G_IADDAPPTENDBLOCK = (ushort) ( IACTUALBLOCK ) ; 
                            __context__.SourceCodeLine = 2845;
                            G_IADDAPPTDURBLOCKS = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2848;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IACTUALBLOCK < 48 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2853;
                                INEXTEVENT = (ushort) ( NEXTEVENT( __context__ , (ushort)( 1 ) , G_SADDAPPTSTARTTIME ) ) ; 
                                __context__.SourceCodeLine = 2855;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTEVENT > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2857;
                                    G_IADDAPPTMAXDURBLOCKS = (ushort) ( (DAYEVENT[ INEXTEVENT ].STARTBLOCK - IACTUALBLOCK) ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 2861;
                                    G_IADDAPPTMAXDURBLOCKS = (ushort) ( (48 - IACTUALBLOCK) ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2867;
                                G_IADDAPPTMAXDURBLOCKS = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 2871;
                            ADD_APPOINTMENT_START_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SADDAPPTSTARTDATE, (ushort)( 2 ))  ) ; 
                            __context__.SourceCodeLine = 2872;
                            ADD_APPOINTMENT_START_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , G_SADDAPPTSTARTTIME)  ) ; 
                            __context__.SourceCodeLine = 2873;
                            ADD_APPOINTMENT_DUR__DOLLAR__  .UpdateValue ( BLOCKSTOHRMIN (  __context__ , (ushort)( G_IADDAPPTDURBLOCKS ))  ) ; 
                            __context__.SourceCodeLine = 2875;
                            SELECTED_BLOCK_SHOW_ADDAPPT  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2876;
                            SELECTED_BLOCK_SHOW_ADDAPPT  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADD_APPOINTMENT_DUR_MINUS_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2886;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IADDAPPTDURBLOCKS > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2888;
            G_IADDAPPTDURBLOCKS = (ushort) ( (G_IADDAPPTDURBLOCKS - 1) ) ; 
            __context__.SourceCodeLine = 2890;
            ADD_APPOINTMENT_DUR__DOLLAR__  .UpdateValue ( BLOCKSTOHRMIN (  __context__ , (ushort)( G_IADDAPPTDURBLOCKS ))  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADD_APPOINTMENT_DUR_PLUS_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2896;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IADDAPPTDURBLOCKS < G_IADDAPPTMAXDURBLOCKS ))  ) ) 
            { 
            __context__.SourceCodeLine = 2898;
            G_IADDAPPTDURBLOCKS = (ushort) ( (G_IADDAPPTDURBLOCKS + 1) ) ; 
            __context__.SourceCodeLine = 2900;
            ADD_APPOINTMENT_DUR__DOLLAR__  .UpdateValue ( BLOCKSTOHRMIN (  __context__ , (ushort)( G_IADDAPPTDURBLOCKS ))  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADD_APPOINTMENT_SAVE_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IENDTIMEHOUR = 0;
        ushort IENDTIMEMIN = 0;
        
        CrestronString SENDTIME;
        CrestronString SENDDATE;
        SENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        SENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        
        
        __context__.SourceCodeLine = 2912;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ADD_APPT_REQUEST_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2914;
            G_IADDAPPTENDBLOCK = (ushort) ( (G_IADDAPPTSTARTBLOCK + (G_IADDAPPTDURBLOCKS - 1)) ) ; 
            __context__.SourceCodeLine = 2917;
            IENDTIMEHOUR = (ushort) ( ((G_IADDAPPTENDBLOCK * 30) / 60) ) ; 
            __context__.SourceCodeLine = 2918;
            IENDTIMEMIN = (ushort) ( Mod( (G_IADDAPPTENDBLOCK * 30) , 60 ) ) ; 
            __context__.SourceCodeLine = 2920;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IENDTIMEHOUR == 24))  ) ) 
                {
                __context__.SourceCodeLine = 2921;
                IENDTIMEHOUR = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 2923;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDTIMEHOUR < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2925;
                SENDTIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IENDTIMEHOUR ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2929;
                SENDTIME  .UpdateValue ( Functions.ItoA (  (int) ( IENDTIMEHOUR ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2932;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDTIMEMIN < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2934;
                SENDTIME  .UpdateValue ( SENDTIME + ":" + "0" + Functions.ItoA (  (int) ( IENDTIMEMIN ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2938;
                SENDTIME  .UpdateValue ( SENDTIME + ":" + Functions.ItoA (  (int) ( IENDTIMEMIN ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2942;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDTIME == "00:00"))  ) ) 
                {
                __context__.SourceCodeLine = 2943;
                SENDDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , G_SADDAPPTSTARTDATE, "1")  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2945;
                SENDDATE  .UpdateValue ( G_SADDAPPTSTARTDATE  ) ; 
                }
            
            __context__.SourceCodeLine = 2947;
            CREATEMEETING (  __context__ , G_SADDAPPTSTARTDATE, G_SADDAPPTSTARTTIME, SENDDATE, SENDTIME, ADD_APPT_SUBJECT__DOLLAR__) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADD_APPOINTMENT_REQUEST_TIMEOUT_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2953;
        G_SCREATEWORKMEETINGREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2954;
        G_SCREATEDAYMEETINGREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2956;
        ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 2957;
        ADD_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MOREINFO_DATA_TIMEOUT_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2962;
        MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( "Data timeout ..."  ) ; 
        __context__.SourceCodeLine = 2963;
        MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( "Data timeout ..."  ) ; 
        __context__.SourceCodeLine = 2965;
        MORE_INFO_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 2966;
        MORE_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2968;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_11__" , 300 , __SPLS_TMPVAR__WAITLABEL_11___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_11___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 2970;
            MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 2971;
            MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object FROM_WORKDAY_MOD_DATAOUT__DOLLAR___OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2977;
        if ( Functions.TestForTrue  ( ( G_BRXOK1)  ) ) 
            { 
            __context__.SourceCodeLine = 2979;
            G_BRXOK1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2981;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 2983;
                G_SRXDATA1  .UpdateValue ( Functions.Gather ( "</Data>" , FROM_WORKDAY_MOD_DATAOUT__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 2985;
                PROCESSFROMWORKDAYMODDATAOUT__DOLLAR__ (  __context__  ) ; 
                __context__.SourceCodeLine = 2981;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_IBLOCKEVENTINDEX  = new ushort[ 49 ];
    G_SRXDATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65000, this );
    G_STODAYDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SREQSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SSCHEDULELABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    G_SUSERREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    G_SATTENDEESREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    G_SCREATEDAYMEETINGREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    G_SCREATEWORKMEETINGREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    G_SADDAPPTSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SADDAPPTSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    G_SCREATEDAYMEETINGSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SMONTH  = new CrestronString[ 13 ];
    for( uint i = 0; i < 13; i++ )
        G_SMONTH [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    DAYEVENT  = new EVENTDATA[ 49 ];
    for( uint i = 0; i < 49; i++ )
    {
        DAYEVENT [i] = new EVENTDATA( this, true );
        DAYEVENT [i].PopulateCustomAttributeList( false );
        
    }
    WORKEVENT  = new EVENTDATA[ 49 ];
    for( uint i = 0; i < 49; i++ )
    {
        WORKEVENT [i] = new EVENTDATA( this, true );
        WORKEVENT [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG_LOGIC = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_LOGIC__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_LOGIC__DigitalInput__, DEBUG_LOGIC );
    
    INITIALIZE_MODULE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE_MODULE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE_MODULE__DigitalInput__, INITIALIZE_MODULE );
    
    ROOMVIEW_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE__DigitalInput__, ROOMVIEW_ONLINE );
    
    EN_PREV_DAY_FROM_TODAY = new Crestron.Logos.SplusObjects.DigitalInput( EN_PREV_DAY_FROM_TODAY__DigitalInput__, this );
    m_DigitalInputList.Add( EN_PREV_DAY_FROM_TODAY__DigitalInput__, EN_PREV_DAY_FROM_TODAY );
    
    EN_SELECTED_BLOCK_MOREINFO = new Crestron.Logos.SplusObjects.DigitalInput( EN_SELECTED_BLOCK_MOREINFO__DigitalInput__, this );
    m_DigitalInputList.Add( EN_SELECTED_BLOCK_MOREINFO__DigitalInput__, EN_SELECTED_BLOCK_MOREINFO );
    
    EN_SELECTED_BLOCK_ADDAPPT = new Crestron.Logos.SplusObjects.DigitalInput( EN_SELECTED_BLOCK_ADDAPPT__DigitalInput__, this );
    m_DigitalInputList.Add( EN_SELECTED_BLOCK_ADDAPPT__DigitalInput__, EN_SELECTED_BLOCK_ADDAPPT );
    
    CHECK_DATE = new Crestron.Logos.SplusObjects.DigitalInput( CHECK_DATE__DigitalInput__, this );
    m_DigitalInputList.Add( CHECK_DATE__DigitalInput__, CHECK_DATE );
    
    SHOW_WORKDAY_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_WORKDAY_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( SHOW_WORKDAY_SCHEDULE__DigitalInput__, SHOW_WORKDAY_SCHEDULE );
    
    GET_USER_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( GET_USER_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( GET_USER_SCHEDULE__DigitalInput__, GET_USER_SCHEDULE );
    
    CANCEL_GET_USER_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( CANCEL_GET_USER_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( CANCEL_GET_USER_SCHEDULE__DigitalInput__, CANCEL_GET_USER_SCHEDULE );
    
    GET_USER_SCHEDULE_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( GET_USER_SCHEDULE_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( GET_USER_SCHEDULE_TIMEOUT__DigitalInput__, GET_USER_SCHEDULE_TIMEOUT );
    
    MOREINFO_DATA_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( MOREINFO_DATA_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( MOREINFO_DATA_TIMEOUT__DigitalInput__, MOREINFO_DATA_TIMEOUT );
    
    ADD_APPOINTMENT_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( ADD_APPOINTMENT_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( ADD_APPOINTMENT_SAVE__DigitalInput__, ADD_APPOINTMENT_SAVE );
    
    ADD_APPOINTMENT_REQUEST_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( ADD_APPOINTMENT_REQUEST_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( ADD_APPOINTMENT_REQUEST_TIMEOUT__DigitalInput__, ADD_APPOINTMENT_REQUEST_TIMEOUT );
    
    ADD_APPOINTMENT_DUR_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( ADD_APPOINTMENT_DUR_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( ADD_APPOINTMENT_DUR_MINUS__DigitalInput__, ADD_APPOINTMENT_DUR_MINUS );
    
    ADD_APPOINTMENT_DUR_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( ADD_APPOINTMENT_DUR_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( ADD_APPOINTMENT_DUR_PLUS__DigitalInput__, ADD_APPOINTMENT_DUR_PLUS );
    
    PREV_DAY = new Crestron.Logos.SplusObjects.DigitalInput( PREV_DAY__DigitalInput__, this );
    m_DigitalInputList.Add( PREV_DAY__DigitalInput__, PREV_DAY );
    
    NEXT_DAY = new Crestron.Logos.SplusObjects.DigitalInput( NEXT_DAY__DigitalInput__, this );
    m_DigitalInputList.Add( NEXT_DAY__DigitalInput__, NEXT_DAY );
    
    TIME_FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT__DigitalInput__, TIME_FORMAT );
    
    INITIALIZE_MODULE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZE_MODULE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZE_MODULE_BUSY_FB__DigitalOutput__, INITIALIZE_MODULE_BUSY_FB );
    
    CALENDAR_UPDATED = new Crestron.Logos.SplusObjects.DigitalOutput( CALENDAR_UPDATED__DigitalOutput__, this );
    m_DigitalOutputList.Add( CALENDAR_UPDATED__DigitalOutput__, CALENDAR_UPDATED );
    
    SELECTED_BLOCK_SHOW_MOREINFO = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTED_BLOCK_SHOW_MOREINFO__DigitalOutput__, this );
    m_DigitalOutputList.Add( SELECTED_BLOCK_SHOW_MOREINFO__DigitalOutput__, SELECTED_BLOCK_SHOW_MOREINFO );
    
    SELECTED_BLOCK_SHOW_ADDAPPT = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTED_BLOCK_SHOW_ADDAPPT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SELECTED_BLOCK_SHOW_ADDAPPT__DigitalOutput__, SELECTED_BLOCK_SHOW_ADDAPPT );
    
    ON_WORKDAY = new Crestron.Logos.SplusObjects.DigitalOutput( ON_WORKDAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( ON_WORKDAY__DigitalOutput__, ON_WORKDAY );
    
    FORCE_WORKDAY_RETURN = new Crestron.Logos.SplusObjects.DigitalOutput( FORCE_WORKDAY_RETURN__DigitalOutput__, this );
    m_DigitalOutputList.Add( FORCE_WORKDAY_RETURN__DigitalOutput__, FORCE_WORKDAY_RETURN );
    
    NEED_WORKDAY_SCHEDULE_UPDATE = new Crestron.Logos.SplusObjects.DigitalOutput( NEED_WORKDAY_SCHEDULE_UPDATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEED_WORKDAY_SCHEDULE_UPDATE__DigitalOutput__, NEED_WORKDAY_SCHEDULE_UPDATE );
    
    COLUMN_WIDTH = new Crestron.Logos.SplusObjects.AnalogInput( COLUMN_WIDTH__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COLUMN_WIDTH__AnalogSerialInput__, COLUMN_WIDTH );
    
    PRIVACY_LEVEL = new Crestron.Logos.SplusObjects.AnalogInput( PRIVACY_LEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PRIVACY_LEVEL__AnalogSerialInput__, PRIVACY_LEVEL );
    
    SELECTED_BLOCK = new Crestron.Logos.SplusObjects.AnalogInput( SELECTED_BLOCK__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECTED_BLOCK__AnalogSerialInput__, SELECTED_BLOCK );
    
    CURRENT_PAGE = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_PAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_PAGE__AnalogSerialInput__, CURRENT_PAGE );
    
    FIELD_QTY = new Crestron.Logos.SplusObjects.AnalogInput( FIELD_QTY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FIELD_QTY__AnalogSerialInput__, FIELD_QTY );
    
    DATE_FORMAT = new Crestron.Logos.SplusObjects.AnalogInput( DATE_FORMAT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DATE_FORMAT__AnalogSerialInput__, DATE_FORMAT );
    
    USER_SCHEDULE_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( USER_SCHEDULE_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( USER_SCHEDULE_REQUEST_MODE__AnalogSerialOutput__, USER_SCHEDULE_REQUEST_MODE );
    
    WORK_SCHEDULE_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( WORK_SCHEDULE_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WORK_SCHEDULE_REQUEST_MODE__AnalogSerialOutput__, WORK_SCHEDULE_REQUEST_MODE );
    
    MORE_INFO_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( MORE_INFO_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MORE_INFO_REQUEST_MODE__AnalogSerialOutput__, MORE_INFO_REQUEST_MODE );
    
    ADD_APPT_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( ADD_APPT_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ADD_APPT_REQUEST_MODE__AnalogSerialOutput__, ADD_APPT_REQUEST_MODE );
    
    TIME_BLOCK_MODE = new InOutArray<AnalogOutput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        TIME_BLOCK_MODE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( TIME_BLOCK_MODE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( TIME_BLOCK_MODE__AnalogSerialOutput__ + i, TIME_BLOCK_MODE[i+1] );
    }
    
    DEFAULT_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT_ORGANIZER__DOLLAR____AnalogSerialInput__, 75, this );
    m_StringInputList.Add( DEFAULT_ORGANIZER__DOLLAR____AnalogSerialInput__, DEFAULT_ORGANIZER__DOLLAR__ );
    
    ADD_APPT_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ADD_APPT_SUBJECT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( ADD_APPT_SUBJECT__DOLLAR____AnalogSerialInput__, ADD_APPT_SUBJECT__DOLLAR__ );
    
    TO_RV_SCHEDULEQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_SCHEDULEQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_SCHEDULEQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_SCHEDULEQUERY__DOLLAR__ );
    
    TO_RV_CREATEMEETING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__, TO_RV_CREATEMEETING__DOLLAR__ );
    
    SCHEDULE_LABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_LABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SCHEDULE_LABEL__DOLLAR____AnalogSerialOutput__, SCHEDULE_LABEL__DOLLAR__ );
    
    SELECTED_BLOCK_MEETINGID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_MEETINGID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_MEETINGID__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_MEETINGID__DOLLAR__ );
    
    SELECTED_BLOCK_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_ORGANIZER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_ORGANIZER__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_ORGANIZER__DOLLAR__ );
    
    SELECTED_BLOCK_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_SUBJECT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_SUBJECT__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_SUBJECT__DOLLAR__ );
    
    SELECTED_BLOCK_START_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_START_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_START_DATE__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_START_DATE__DOLLAR__ );
    
    SELECTED_BLOCK_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_START_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_START_TIME__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_START_TIME__DOLLAR__ );
    
    SELECTED_BLOCK_END_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_END_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_END_DATE__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_END_DATE__DOLLAR__ );
    
    SELECTED_BLOCK_END_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_BLOCK_END_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_BLOCK_END_TIME__DOLLAR____AnalogSerialOutput__, SELECTED_BLOCK_END_TIME__DOLLAR__ );
    
    MEETING_REQUIRED_ATTENDEES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEETING_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEETING_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__, MEETING_REQUIRED_ATTENDEES__DOLLAR__ );
    
    MEETING_OPTIONAL_ATTENDEES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEETING_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEETING_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__, MEETING_OPTIONAL_ATTENDEES__DOLLAR__ );
    
    ADD_APPOINTMENT_START_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ADD_APPOINTMENT_START_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ADD_APPOINTMENT_START_DATE__DOLLAR____AnalogSerialOutput__, ADD_APPOINTMENT_START_DATE__DOLLAR__ );
    
    ADD_APPOINTMENT_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ADD_APPOINTMENT_START_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ADD_APPOINTMENT_START_TIME__DOLLAR____AnalogSerialOutput__, ADD_APPOINTMENT_START_TIME__DOLLAR__ );
    
    ADD_APPOINTMENT_DUR__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ADD_APPOINTMENT_DUR__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ADD_APPOINTMENT_DUR__DOLLAR____AnalogSerialOutput__, ADD_APPOINTMENT_DUR__DOLLAR__ );
    
    TIME_BLOCK_TEXT__DOLLAR__ = new InOutArray<StringOutput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        TIME_BLOCK_TEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TIME_BLOCK_TEXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TIME_BLOCK_TEXT__DOLLAR____AnalogSerialOutput__ + i, TIME_BLOCK_TEXT__DOLLAR__[i+1] );
    }
    
    FROM_WORKDAY_MOD_DATAOUT__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_WORKDAY_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( FROM_WORKDAY_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, FROM_WORKDAY_MOD_DATAOUT__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_9___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_9___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_10___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_10___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_11___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_11___CallbackFn );
    
    INITIALIZE_MODULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_MODULE_OnPush_0, false ) );
    CHECK_DATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHECK_DATE_OnPush_1, false ) );
    ROOMVIEW_ONLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_OnPush_2, false ) );
    GET_USER_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_USER_SCHEDULE_OnPush_3, false ) );
    GET_USER_SCHEDULE_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_USER_SCHEDULE_TIMEOUT_OnPush_4, false ) );
    CANCEL_GET_USER_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CANCEL_GET_USER_SCHEDULE_OnPush_5, false ) );
    SHOW_WORKDAY_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHOW_WORKDAY_SCHEDULE_OnPush_6, false ) );
    NEXT_DAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXT_DAY_OnPush_7, false ) );
    PREV_DAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREV_DAY_OnPush_8, false ) );
    SELECTED_BLOCK.OnAnalogChange.Add( new InputChangeHandlerWrapper( SELECTED_BLOCK_OnChange_9, false ) );
    ADD_APPOINTMENT_DUR_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ADD_APPOINTMENT_DUR_MINUS_OnPush_10, false ) );
    ADD_APPOINTMENT_DUR_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ADD_APPOINTMENT_DUR_PLUS_OnPush_11, false ) );
    ADD_APPOINTMENT_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ADD_APPOINTMENT_SAVE_OnPush_12, false ) );
    ADD_APPOINTMENT_REQUEST_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ADD_APPOINTMENT_REQUEST_TIMEOUT_OnPush_13, false ) );
    MOREINFO_DATA_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( MOREINFO_DATA_TIMEOUT_OnPush_14, false ) );
    FROM_WORKDAY_MOD_DATAOUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_WORKDAY_MOD_DATAOUT__DOLLAR___OnChange_15, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_SCHEDULE_INTERFACE_UI_V3_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_9___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_10___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_11___Callback;


const uint DEBUG_LOGIC__DigitalInput__ = 0;
const uint INITIALIZE_MODULE__DigitalInput__ = 1;
const uint ROOMVIEW_ONLINE__DigitalInput__ = 2;
const uint EN_PREV_DAY_FROM_TODAY__DigitalInput__ = 3;
const uint EN_SELECTED_BLOCK_MOREINFO__DigitalInput__ = 4;
const uint EN_SELECTED_BLOCK_ADDAPPT__DigitalInput__ = 5;
const uint CHECK_DATE__DigitalInput__ = 6;
const uint SHOW_WORKDAY_SCHEDULE__DigitalInput__ = 7;
const uint GET_USER_SCHEDULE__DigitalInput__ = 8;
const uint CANCEL_GET_USER_SCHEDULE__DigitalInput__ = 9;
const uint GET_USER_SCHEDULE_TIMEOUT__DigitalInput__ = 10;
const uint MOREINFO_DATA_TIMEOUT__DigitalInput__ = 11;
const uint ADD_APPOINTMENT_SAVE__DigitalInput__ = 12;
const uint ADD_APPOINTMENT_REQUEST_TIMEOUT__DigitalInput__ = 13;
const uint ADD_APPOINTMENT_DUR_MINUS__DigitalInput__ = 14;
const uint ADD_APPOINTMENT_DUR_PLUS__DigitalInput__ = 15;
const uint PREV_DAY__DigitalInput__ = 16;
const uint NEXT_DAY__DigitalInput__ = 17;
const uint TIME_FORMAT__DigitalInput__ = 18;
const uint COLUMN_WIDTH__AnalogSerialInput__ = 0;
const uint PRIVACY_LEVEL__AnalogSerialInput__ = 1;
const uint SELECTED_BLOCK__AnalogSerialInput__ = 2;
const uint CURRENT_PAGE__AnalogSerialInput__ = 3;
const uint FIELD_QTY__AnalogSerialInput__ = 4;
const uint DATE_FORMAT__AnalogSerialInput__ = 5;
const uint DEFAULT_ORGANIZER__DOLLAR____AnalogSerialInput__ = 6;
const uint ADD_APPT_SUBJECT__DOLLAR____AnalogSerialInput__ = 7;
const uint FROM_WORKDAY_MOD_DATAOUT__DOLLAR____AnalogSerialInput__ = 8;
const uint INITIALIZE_MODULE_BUSY_FB__DigitalOutput__ = 0;
const uint CALENDAR_UPDATED__DigitalOutput__ = 1;
const uint SELECTED_BLOCK_SHOW_MOREINFO__DigitalOutput__ = 2;
const uint SELECTED_BLOCK_SHOW_ADDAPPT__DigitalOutput__ = 3;
const uint ON_WORKDAY__DigitalOutput__ = 4;
const uint FORCE_WORKDAY_RETURN__DigitalOutput__ = 5;
const uint NEED_WORKDAY_SCHEDULE_UPDATE__DigitalOutput__ = 6;
const uint USER_SCHEDULE_REQUEST_MODE__AnalogSerialOutput__ = 0;
const uint WORK_SCHEDULE_REQUEST_MODE__AnalogSerialOutput__ = 1;
const uint MORE_INFO_REQUEST_MODE__AnalogSerialOutput__ = 2;
const uint ADD_APPT_REQUEST_MODE__AnalogSerialOutput__ = 3;
const uint TO_RV_SCHEDULEQUERY__DOLLAR____AnalogSerialOutput__ = 4;
const uint TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__ = 5;
const uint SCHEDULE_LABEL__DOLLAR____AnalogSerialOutput__ = 6;
const uint SELECTED_BLOCK_MEETINGID__DOLLAR____AnalogSerialOutput__ = 7;
const uint SELECTED_BLOCK_ORGANIZER__DOLLAR____AnalogSerialOutput__ = 8;
const uint SELECTED_BLOCK_SUBJECT__DOLLAR____AnalogSerialOutput__ = 9;
const uint SELECTED_BLOCK_START_DATE__DOLLAR____AnalogSerialOutput__ = 10;
const uint SELECTED_BLOCK_START_TIME__DOLLAR____AnalogSerialOutput__ = 11;
const uint SELECTED_BLOCK_END_DATE__DOLLAR____AnalogSerialOutput__ = 12;
const uint SELECTED_BLOCK_END_TIME__DOLLAR____AnalogSerialOutput__ = 13;
const uint MEETING_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__ = 14;
const uint MEETING_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__ = 15;
const uint ADD_APPOINTMENT_START_DATE__DOLLAR____AnalogSerialOutput__ = 16;
const uint ADD_APPOINTMENT_START_TIME__DOLLAR____AnalogSerialOutput__ = 17;
const uint ADD_APPOINTMENT_DUR__DOLLAR____AnalogSerialOutput__ = 18;
const uint TIME_BLOCK_MODE__AnalogSerialOutput__ = 19;
const uint TIME_BLOCK_TEXT__DOLLAR____AnalogSerialOutput__ = 67;

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
public class EVENTDATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  MEETINGID;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  ORGANIZER;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  SUBJECT;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  STARTDATE;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  STARTTIME;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  ENDDATE;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  ENDTIME;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  STARTBLOCK = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  ENDBLOCK = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  ISPRIVATE = 0;
    
    
    public EVENTDATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        MEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, Owner );
        ORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        SUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, Owner );
        STARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        STARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, Owner );
        ENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        ENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, Owner );
        
        
    }
    
}

}
