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

namespace UserModule_RVSE2_SCHEDULE_INTERFACE_WORKDAY_V7_2_
{
    public class UserModuleClass_RVSE2_SCHEDULE_INTERFACE_WORKDAY_V7_2_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_LOGIC;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_PRINT_WORK_EVENTS;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_PRINT_AUTOUPDATE_EVENTS;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_FORCE_RESERVE_NOW;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_PRESET_DATA;
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE_MODULE;
        Crestron.Logos.SplusObjects.DigitalInput CONFIG_EN_DECLINE_FOR_NOSHOW;
        Crestron.Logos.SplusObjects.DigitalInput CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN;
        Crestron.Logos.SplusObjects.DigitalInput CONFIG_EN_RESERVE_NOW;
        Crestron.Logos.SplusObjects.DigitalInput CONFIG_EN_STARTMEETING;
        Crestron.Logos.SplusObjects.DigitalInput CONFIG_EN_FREEUPROOM;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT;
        Crestron.Logos.SplusObjects.DigitalInput EN_FREEBUSY_ATTRIBUTEDATA;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE_FB;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_OCCUPIED_FB;
        Crestron.Logos.SplusObjects.DigitalInput CHECK_ROOM_STATUS;
        Crestron.Logos.SplusObjects.DigitalInput GET_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput SCHEDULE_REQUEST_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_EVEN_END_TIME;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_TIME_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_SELECT_30;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_SELECT_60;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_SELECT_90;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_YES;
        Crestron.Logos.SplusObjects.DigitalInput RESERVE_NOW_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput END_MEETING_BTN;
        Crestron.Logos.SplusObjects.DigitalInput END_MEETING_CONFIRM_YES;
        Crestron.Logos.SplusObjects.DigitalInput END_MEETING_CONFIRM_NO;
        Crestron.Logos.SplusObjects.DigitalInput END_MEETING_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput START_MEETING_BTN;
        Crestron.Logos.SplusObjects.DigitalInput START_MEETING_CONFIRM_YES;
        Crestron.Logos.SplusObjects.DigitalInput START_MEETING_CONFIRM_NO;
        Crestron.Logos.SplusObjects.DigitalInput REGISTER_PUSH;
        Crestron.Logos.SplusObjects.DigitalInput UNREGISTER_PUSH;
        Crestron.Logos.SplusObjects.DigitalInput REGISTER_PUSH_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_UPDATE_PUSH_START;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_UPDATE_GET_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_UPDATE_REQUEST_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput GET_CURRENT_MEETING_INFO;
        Crestron.Logos.SplusObjects.DigitalInput GET_CURRENT_MEETING_INFO_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput GET_NEXT_MEETING_INFO;
        Crestron.Logos.SplusObjects.DigitalInput GET_NEXT_MEETING_INFO_TIMEOUT;
        Crestron.Logos.SplusObjects.AnalogInput PRIVACY_LEVEL;
        Crestron.Logos.SplusObjects.AnalogInput COLUMN_WIDTH;
        Crestron.Logos.SplusObjects.AnalogInput FIELD_QTY;
        Crestron.Logos.SplusObjects.AnalogInput DATE_FORMAT;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_PAGE;
        Crestron.Logos.SplusObjects.AnalogInput MEETING_ACTIVE_WINDOW_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput END_NEXT_MEETING_WARN_TIME;
        Crestron.Logos.SplusObjects.AnalogInput RESERVE_NOW_DURATION;
        Crestron.Logos.SplusObjects.AnalogInput DECLINE_APPLIES_DURATION;
        Crestron.Logos.SplusObjects.AnalogInput DECLINE_MEETING_MIN;
        Crestron.Logos.SplusObjects.AnalogInput DECLINE_MEETING_PERCENT;
        Crestron.Logos.SplusObjects.AnalogInput SERIAL_PACING_TIME;
        Crestron.Logos.SplusObjects.AnalogInput MEETING_PRESET_START_TIME;
        Crestron.Logos.SplusObjects.StringInput DEFAULT_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput RESERVE_NOW_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput RESERVE_NOW_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ROOM_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_SCHEDULERESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_CREATERESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_ACTIONRESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZE_MODULE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PUSH_TRIGGERED_CHECK_ROOM_STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput HAVE_VALID_WORKDAY_SCHED;
        Crestron.Logos.SplusObjects.DigitalOutput SCHEDULE_UPDATED;
        Crestron.Logos.SplusObjects.DigitalOutput MEETING_STARTED;
        Crestron.Logos.SplusObjects.DigitalOutput MEETING_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput CURRENT_MEETING_PRIVATE;
        Crestron.Logos.SplusObjects.DigitalOutput HAVE_NEXT_RESERVATION;
        Crestron.Logos.SplusObjects.DigitalOutput NEXT_RESERVATION_PRIVATE;
        Crestron.Logos.SplusObjects.DigitalOutput END_MEETING_WARN_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_RESERVE_NOW;
        Crestron.Logos.SplusObjects.DigitalOutput SET_RESERVE_NOW_CONFIRM;
        Crestron.Logos.SplusObjects.DigitalOutput SET_RESERVE_NOW_SELECT;
        Crestron.Logos.SplusObjects.DigitalOutput END_MEETING_BTN_SUB;
        Crestron.Logos.SplusObjects.DigitalOutput END_MEETING_BTN_FB;
        Crestron.Logos.SplusObjects.DigitalOutput END_MEETING_CONFIRM_SUB;
        Crestron.Logos.SplusObjects.DigitalOutput START_MEETING_BTN_SUB;
        Crestron.Logos.SplusObjects.DigitalOutput START_MEETING_BTN_FB;
        Crestron.Logos.SplusObjects.DigitalOutput START_MEETING_CONFIRM_SUB;
        Crestron.Logos.SplusObjects.DigitalOutput AUTO_UPDATE_NEED_SCHED;
        Crestron.Logos.SplusObjects.DigitalOutput AUTO_UPDATE_PROCESS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput EWS_SUBSCRIPTION_OFFLINE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMSERVICE_BACKLOG_ACTIVE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput WORKDAY_SCHED_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput NEXT_RESERV_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput FIRST_APPT_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_NOW_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_NOW_SELECT_30_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_NOW_SELECT_60_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput RESERVE_NOW_SELECT_90_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput END_MEETING_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput REGISTER_PUSH_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_MEETING_INFO_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_MEETING_PRESET_DATA_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput NEXT_MEETING_INFO_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput AUTO_UPDATE_REQUEST_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TIME_BARGRAPH_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput END_MEETING_WARN_COUNTDOWN_SEED;
        Crestron.Logos.SplusObjects.AnalogOutput PROCESSED_PUSH_RESPONSES;
        Crestron.Logos.SplusObjects.AnalogOutput PROCESSED_RV_FORCED_REFRESH;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TIME_HOUR;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TIME_MINUTE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_MEETING_DURATION_MIN;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_MEETING_ELAPSED_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_MEETING_ELAPSED_PERCENT;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_SCHEDULEQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_CREATEMEETING__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_ACTIONQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_NOSHOW_MOD_DATAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_UI_MOD_DATAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_LABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENTTIME_MEETING_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENTTIME_RVMEETING_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_MEETING_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_RVMEETING_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_START_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_END_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_END_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_STARTEND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEETING_WELCOME_MSG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_IN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_ORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_START_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_END_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_END_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_HRMIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NEXT_RESERVATION_DATETIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REMAINING_HRMIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_NOW_SELECT_30__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_NOW_SELECT_60__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_NOW_SELECT_90__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_NOW_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_NOW_END_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVE_NOW_MESSAGE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> TIME_BLOCK_MODE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TIME_BLOCK_TEXT__DOLLAR__;
        EVENTDATA [] MEETINGEVENT;
        EVENTDATA [] AUTOUPDATEMEETINGEVENT;
        EVENTDATA TEMPMOVEEVENT;
        NEXTDATA NEXTEVENT;
        RESERVENOWDATA CONFIRMEVENT;
        RESERVENOWDATA SELECT30MIN;
        RESERVENOWDATA SELECT60MIN;
        RESERVENOWDATA SELECT90MIN;
        ushort G_BRXOK1 = 0;
        ushort G_BRXOK2 = 0;
        ushort G_BRXOK3 = 0;
        ushort G_BHAVEAUTOUPDATESCHEDULE = 0;
        ushort G_BENDEDWHILEACTIVE = 0;
        ushort G_BPUSHENABLED = 0;
        ushort G_BNEEDFIRSTAPPTREQUEST = 0;
        ushort G_BWAITINGTOSENDINFOEVENTLIST = 0;
        ushort G_BWAITINGTOSENDUIEVENTLIST = 0;
        ushort G_BNEEDANOTHERWORKDAYREQUEST = 0;
        ushort G_BWAITINGTOSENDRVDATA = 0;
        ushort G_BHAVEMEETINGPRESETMODULE = 0;
        ushort G_BHAVEREMOTESYSMODULE = 0;
        CrestronString G_SRXDATA1;
        CrestronString G_SRXDATA2;
        CrestronString G_SRXDATA3;
        CrestronString [] G_SMONTH;
        CrestronString G_SDATETODAY;
        CrestronString G_SAUTOUPDATEDATE;
        CrestronString G_SCURRENTTIME;
        ushort [] G_IBLOCKEVENTINDEX;
        CrestronString G_SREQSTARTTIME;
        CrestronString G_SREQHOURSPAN;
        ushort G_ISTOREDEVENTCOUNT = 0;
        ushort G_IAUTOUPDATESTOREDEVENTCOUNT = 0;
        ushort G_ICURRENTEVENTNUM = 0;
        ushort G_ISTARTEDEVENTNUM = 0;
        ushort G_ISTARTEDEVENTTIME = 0;
        CrestronString G_SSTARTEDEVENTID;
        ushort G_ICURRENTHOUR = 0;
        ushort G_ICURRENTMINUTE = 0;
        ushort G_ICURRENTTIME = 0;
        ushort G_ICURRENTTIMEMIN = 0;
        ushort G_ICURRENTTIMEBLOCK = 0;
        CrestronString G_SSCHEDULEREQUESTID;
        CrestronString G_SPUSHREQUESTID;
        CrestronString G_SRESERVENOWREQUESTID;
        CrestronString G_SENDMEETINGREQUESTID;
        CrestronString G_SACTIONRVIDREQUESTID;
        CrestronString G_SACTIONPUSHREQUESTID;
        CrestronString G_SNEXTRESERVREQUESTID;
        CrestronString G_SFIRSTAPPTREQUESTID;
        CrestronString G_SISPRIVATEREQUESTID;
        CrestronString G_SAUTOUPDATEREQUESTID;
        CrestronString G_SCURRENTMEETINGINFOREQUESTID;
        CrestronString G_SCURRENTMEETINGPRESETDATAREQUESTID;
        CrestronString G_SNEXTMEETINGINFOREQUESTID;
        CrestronString G_SNEXTMEETINGPRESETDATAREQUESTID;
        ushort G_BRESERVENOWSUCCESSNEEDSCHED = 0;
        CrestronString G_SRESERVENOWSTARTTIME;
        CrestronString G_SRESERVENOWENDTIME;
        CrestronString G_SRESERVENOWMEETINGID;
        CrestronString G_SENDMEETINGREQMEETINGID;
        CrestronString G_SCURRENTMEETINGID;
        ushort G_BSTARTMEETINGCONFIRMED = 0;
        ushort G_IEFFSTARTTIME = 0;
        ushort G_IEFFDELTATIME = 0;
        CrestronString G_SLASTSENTNOSHOWID;
        CrestronString G_SLASTSENTNOSHOWDATE;
        CrestronString G_SLASTSENTGETMEETINGID;
        CrestronString G_SLASTSENTGETPRESETDATAID;
        CrestronString G_SNEXTRESERVREQUESTDATE;
        CrestronString G_SAUTOUPDATEREQUESTDATE;
        CrestronString G_SFIRSTAPPTSTARTDATE;
        CrestronString G_SXML;
        CrestronString G_SRESERVENOWDTSTART;
        CrestronString G_SRESERVENOWDTEND;
        CrestronString G_SCURRENTMEETINGWELCOMEMSGID;
        CrestronString G_SCURRENTWELCOMEMSG;
        ushort G_ILASTSENTGETPRESETDATAINDEX = 0;
        private void PRINTEVENTS (  SplusExecutionContext __context__, ushort ITYPE ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 511;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 513;
                Trace( "\r\n** Work Events Stored:{0:d} **\r\n", (ushort)G_ISTOREDEVENTCOUNT) ; 
                __context__.SourceCodeLine = 515;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 517;
                    Trace( "    Event {0:d}:\r\n", (ushort)I) ; 
                    __context__.SourceCodeLine = 518;
                    Trace( "     MeetingID:{0}\r\n", MEETINGEVENT [ I] . MEETINGID ) ; 
                    __context__.SourceCodeLine = 519;
                    Trace( "     StartBlock:{0:d}\r\n", (ushort)MEETINGEVENT[ I ].STARTBLOCK) ; 
                    __context__.SourceCodeLine = 520;
                    Trace( "     EndBlock:{0:d}\r\n", (ushort)MEETINGEVENT[ I ].ENDBLOCK) ; 
                    __context__.SourceCodeLine = 521;
                    Trace( "     StartDate:{0}\r\n", MEETINGEVENT [ I] . STARTDATE ) ; 
                    __context__.SourceCodeLine = 522;
                    Trace( "     StartTime:{0}\r\n", MEETINGEVENT [ I] . STARTTIME ) ; 
                    __context__.SourceCodeLine = 523;
                    Trace( "     EndDate:{0}\r\n", MEETINGEVENT [ I] . ENDDATE ) ; 
                    __context__.SourceCodeLine = 524;
                    Trace( "     EndTime:{0}\r\n", MEETINGEVENT [ I] . ENDTIME ) ; 
                    __context__.SourceCodeLine = 525;
                    Trace( "     Subject:{0}\r\n", MEETINGEVENT [ I] . SUBJECT ) ; 
                    __context__.SourceCodeLine = 526;
                    Trace( "     Organizer:{0}\r\n", MEETINGEVENT [ I] . ORGANIZER ) ; 
                    __context__.SourceCodeLine = 527;
                    Trace( "     Recurring:{0:d}\r\n", (ushort)MEETINGEVENT[ I ].RECURRING) ; 
                    __context__.SourceCodeLine = 515;
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 531;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 533;
                    Trace( "\r\n** Auto Update Events Stored:{0:d} **\r\n", (ushort)G_IAUTOUPDATESTOREDEVENTCOUNT) ; 
                    __context__.SourceCodeLine = 535;
                    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__2 = (ushort)G_IAUTOUPDATESTOREDEVENTCOUNT; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 537;
                        Trace( "    Event {0:d}:\r\n", (ushort)I) ; 
                        __context__.SourceCodeLine = 538;
                        Trace( "     MeetingID:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . MEETINGID ) ; 
                        __context__.SourceCodeLine = 539;
                        Trace( "     StartBlock:{0:d}\r\n", (ushort)AUTOUPDATEMEETINGEVENT[ I ].STARTBLOCK) ; 
                        __context__.SourceCodeLine = 540;
                        Trace( "     EndBlock:{0:d}\r\n", (ushort)AUTOUPDATEMEETINGEVENT[ I ].ENDBLOCK) ; 
                        __context__.SourceCodeLine = 541;
                        Trace( "     StartDate:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . STARTDATE ) ; 
                        __context__.SourceCodeLine = 542;
                        Trace( "     StartTime:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . STARTTIME ) ; 
                        __context__.SourceCodeLine = 543;
                        Trace( "     EndDate:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . ENDDATE ) ; 
                        __context__.SourceCodeLine = 544;
                        Trace( "     EndTime:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . ENDTIME ) ; 
                        __context__.SourceCodeLine = 545;
                        Trace( "     Subject:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . SUBJECT ) ; 
                        __context__.SourceCodeLine = 546;
                        Trace( "     Organizer:{0}\r\n", AUTOUPDATEMEETINGEVENT [ I] . ORGANIZER ) ; 
                        __context__.SourceCodeLine = 547;
                        Trace( "     Recurring:{0:d}\r\n", (ushort)AUTOUPDATEMEETINGEVENT[ I ].RECURRING) ; 
                        __context__.SourceCodeLine = 535;
                        } 
                    
                    } 
                
                }
            
            
            }
            
        private void CLEARCALENDAR (  SplusExecutionContext __context__, ushort ISTARTBLOCK , ushort IENDBLOCK ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 569;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 571;
                Trace( "\r\n** ClearCalendar **\r\n") ; 
                __context__.SourceCodeLine = 572;
                Trace( "  StartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
                __context__.SourceCodeLine = 573;
                Trace( "  EndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
                } 
            
            __context__.SourceCodeLine = 576;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTBLOCK ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IENDBLOCK; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 578;
                G_IBLOCKEVENTINDEX [ I] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 580;
                TIME_BLOCK_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 581;
                TIME_BLOCK_TEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 576;
                } 
            
            
            }
            
        private ushort DAYSINMONTH (  SplusExecutionContext __context__, ushort IMONTH , ushort IYEAR ) 
            { 
            ushort IDAYS = 0;
            
            
            __context__.SourceCodeLine = 603;
            IDAYS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 605;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 607;
                Trace( "\r\n** DaysInMonth **\r\n") ; 
                __context__.SourceCodeLine = 608;
                Trace( "  Month:{0:d}\r\n", (ushort)IMONTH) ; 
                __context__.SourceCodeLine = 609;
                Trace( "  Year:{0:d}\r\n", (ushort)IYEAR) ; 
                } 
            
            __context__.SourceCodeLine = 612;
            switch ((int)IMONTH)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 616;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 617;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 621;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IYEAR , 4 ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 623;
                        IDAYS = (ushort) ( 29 ) ; 
                        __context__.SourceCodeLine = 624;
                        break ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 628;
                        IDAYS = (ushort) ( 28 ) ; 
                        __context__.SourceCodeLine = 629;
                        break ; 
                        } 
                    
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 634;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 635;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 639;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 640;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 644;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 645;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 649;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 650;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 654;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 655;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 659;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 660;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 664;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 665;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 669;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 670;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 674;
                    IDAYS = (ushort) ( 30 ) ; 
                    __context__.SourceCodeLine = 675;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 679;
                    IDAYS = (ushort) ( 31 ) ; 
                    __context__.SourceCodeLine = 680;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 684;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 686;
                Trace( "  Days:{0:d}\r\n", (ushort)IDAYS) ; 
                } 
            
            __context__.SourceCodeLine = 689;
            return (ushort)( IDAYS) ; 
            
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
            
            
            __context__.SourceCodeLine = 711;
            IMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 713;
            SYEAR  .UpdateValue ( Functions.Left ( SDATA ,  (int) ( 4 ) )  ) ; 
            __context__.SourceCodeLine = 714;
            SMONTH  .UpdateValue ( Functions.Mid ( SDATA ,  (int) ( 6 ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 715;
            SMONTHNAME  .UpdateValue ( G_SMONTH [ IMONTH ]  ) ; 
            __context__.SourceCodeLine = 716;
            SDAY  .UpdateValue ( Functions.Right ( SDATA ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 718;
            IFORMAT = (ushort) ( (IFORMAT + (2 * DATE_FORMAT  .UshortValue)) ) ; 
            __context__.SourceCodeLine = 720;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 722;
                Print( "\r\n** FormatDate **\r\n") ; 
                __context__.SourceCodeLine = 723;
                Print( "  Data:{0}\r\n", SDATA ) ; 
                __context__.SourceCodeLine = 724;
                Print( "  Format:{0:d}\r\n", (ushort)IFORMAT) ; 
                } 
            
            __context__.SourceCodeLine = 728;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 730;
                SDATE  .UpdateValue ( SMONTHNAME + " " + SDAY + ", " + SYEAR  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 732;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 734;
                    SDATE  .UpdateValue ( SMONTH + "/" + SDAY + "/" + SYEAR  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 737;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 739;
                        SDATE  .UpdateValue ( SDAY + " " + SMONTHNAME + " " + SYEAR  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 741;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 743;
                            SDATE  .UpdateValue ( SDAY + "/" + SMONTH + "/" + SYEAR  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 746;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 5))  ) ) 
                                { 
                                __context__.SourceCodeLine = 748;
                                SDATE  .UpdateValue ( SYEAR + ", " + SMONTHNAME + " " + SDAY  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 750;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 6))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 752;
                                    SDATE  .UpdateValue ( SYEAR + "/" + SMONTH + "/" + SDAY  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 755;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 757;
                Print( "  Formatted Date:{0}\r\n", SDATE ) ; 
                } 
            
            __context__.SourceCodeLine = 760;
            return ( SDATE ) ; 
            
            }
            
        private CrestronString ITOLA (  SplusExecutionContext __context__, ushort INUMBER ) 
            { 
            CrestronString SNUMBER;
            SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 786;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INUMBER < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 788;
                SNUMBER  .UpdateValue ( "0" + Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 792;
                SNUMBER  .UpdateValue ( Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 795;
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
            
            
            __context__.SourceCodeLine = 817;
            IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 818;
            IMINUTE = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 821;
            if ( Functions.TestForTrue  ( ( TIME_FORMAT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 823;
                SHOUR  .UpdateValue ( ITOLA (  __context__ , (ushort)( IHOUR ))  ) ; 
                __context__.SourceCodeLine = 824;
                SAMPM  .UpdateValue ( ""  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 829;
                SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( Mod( IHOUR , 12 ) ) )  ) ; 
                __context__.SourceCodeLine = 830;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IHOUR == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IHOUR == 12) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 831;
                    SHOUR  .UpdateValue ( "12"  ) ; 
                    }
                
                __context__.SourceCodeLine = 834;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 836;
                    SAMPM  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 840;
                    SAMPM  .UpdateValue ( "PM"  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 845;
            SMINUTE  .UpdateValue ( ITOLA (  __context__ , (ushort)( IMINUTE ))  ) ; 
            __context__.SourceCodeLine = 847;
            STIME  .UpdateValue ( SHOUR + ":" + SMINUTE + " " + SAMPM  ) ; 
            __context__.SourceCodeLine = 849;
            return ( STIME ) ; 
            
            }
            
        private CrestronString LOCALTIME (  SplusExecutionContext __context__ ) 
            { 
            ushort IHOUR = 0;
            ushort IMINUTE = 0;
            
            CrestronString SHOUR;
            CrestronString SMINUTE;
            CrestronString STIME;
            SHOUR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            SMINUTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 871;
            SHOUR  .UpdateValue ( Functions.ItoA (  (int) ( Functions.GetHourNum() ) )  ) ; 
            __context__.SourceCodeLine = 872;
            SMINUTE  .UpdateValue ( Functions.ItoA (  (int) ( Functions.GetMinutesNum() ) )  ) ; 
            __context__.SourceCodeLine = 873;
            STIME  .UpdateValue ( SHOUR + ":" + SMINUTE  ) ; 
            __context__.SourceCodeLine = 874;
            STIME  .UpdateValue ( FORMATTIME (  __context__ , STIME)  ) ; 
            __context__.SourceCodeLine = 876;
            return ( STIME ) ; 
            
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
            
            
            __context__.SourceCodeLine = 889;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 891;
                Trace( "\r\n** Time24ToTime12 **\r\n") ; 
                __context__.SourceCodeLine = 892;
                Trace( "  Data:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 895;
            ILEN = (ushort) ( Functions.Length( SDATA ) ) ; 
            __context__.SourceCodeLine = 896;
            IPOS = (ushort) ( Functions.Find( ":" , SDATA ) ) ; 
            __context__.SourceCodeLine = 898;
            IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( (IPOS - 1) ) ) ) ) ; 
            __context__.SourceCodeLine = 899;
            IMINUTE = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( (IPOS + 1) ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 901;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 903;
                STIME  .UpdateValue ( "12"  ) ; 
                __context__.SourceCodeLine = 904;
                SAMPM  .UpdateValue ( "AM"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 906;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 908;
                    STIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                    __context__.SourceCodeLine = 909;
                    SAMPM  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 911;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IHOUR >= 10 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IHOUR < 12 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 913;
                        STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                        __context__.SourceCodeLine = 914;
                        SAMPM  .UpdateValue ( "AM"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 916;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 12))  ) ) 
                            { 
                            __context__.SourceCodeLine = 918;
                            STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                            __context__.SourceCodeLine = 919;
                            SAMPM  .UpdateValue ( "PM"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 923;
                            IHOUR = (ushort) ( (IHOUR - 12) ) ; 
                            __context__.SourceCodeLine = 925;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 927;
                                STIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 931;
                                STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 934;
                            STIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                            __context__.SourceCodeLine = 935;
                            SAMPM  .UpdateValue ( "PM"  ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 938;
            STIME  .UpdateValue ( STIME + ":" + ITOLA (  __context__ , (ushort)( IMINUTE )) + " " + SAMPM  ) ; 
            __context__.SourceCodeLine = 940;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 942;
                Trace( "  Time:{0}\r\n", STIME ) ; 
                } 
            
            __context__.SourceCodeLine = 945;
            return ( STIME ) ; 
            
            }
            
        private ushort DATETOINTEGER (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            ushort IVALUE = 0;
            ushort IYEAR = 0;
            ushort IMONTH = 0;
            ushort IDAY = 0;
            
            
            __context__.SourceCodeLine = 968;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 970;
                Trace( "\r\n** DateToInteger **\r\n") ; 
                __context__.SourceCodeLine = 971;
                Trace( "    sData:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 974;
            IVALUE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 976;
            IYEAR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 977;
            IMONTH = (ushort) ( (Functions.Atoi( Functions.Mid( SDATA , (int)( 6 ) , (int)( 2 ) ) ) * 100) ) ; 
            __context__.SourceCodeLine = 978;
            IDAY = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 980;
            IVALUE = (ushort) ( ((IYEAR + IMONTH) + IDAY) ) ; 
            __context__.SourceCodeLine = 982;
            return (ushort)( IVALUE) ; 
            
            }
            
        private ushort TIMETOINTEGER (  SplusExecutionContext __context__, CrestronString SDATA , ushort IFORMAT ) 
            { 
            ushort ITIMEVALUE = 0;
            ushort ITIMEH = 0;
            ushort ITIMEM = 0;
            
            
            __context__.SourceCodeLine = 1007;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1009;
                Trace( "\r\n** TimeToInteger **\r\n") ; 
                __context__.SourceCodeLine = 1010;
                Trace( "    sData:{0}\r\n", SDATA ) ; 
                __context__.SourceCodeLine = 1011;
                Trace( "    iFormat:{0:d}\r\n", (ushort)IFORMAT) ; 
                } 
            
            __context__.SourceCodeLine = 1014;
            ITIMEVALUE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1016;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1018;
                ITIMEH = (ushort) ( (Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) * 100) ) ; 
                __context__.SourceCodeLine = 1019;
                ITIMEM = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1020;
                ITIMEVALUE = (ushort) ( (ITIMEH + ITIMEM) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1022;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1024;
                    ITIMEH = (ushort) ( (Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) * 60) ) ; 
                    __context__.SourceCodeLine = 1025;
                    ITIMEM = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 1026;
                    ITIMEVALUE = (ushort) ( (ITIMEH + ITIMEM) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 1029;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1031;
                Trace( "    sData After:{0}\r\n", SDATA ) ; 
                __context__.SourceCodeLine = 1032;
                Trace( "    iTimeValue:{0:d}\r\n", (ushort)ITIMEVALUE) ; 
                } 
            
            __context__.SourceCodeLine = 1035;
            return (ushort)( ITIMEVALUE) ; 
            
            }
            
        private CrestronString RESERVENOWTOINTDATEFORMAT (  SplusExecutionContext __context__, RESERVENOWDATA ODATA , CrestronString STARTEND ) 
            { 
            CrestronString RESULT;
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 19, this );
            
            
            __context__.SourceCodeLine = 1041;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STARTEND == "Start"))  ) ) 
                { 
                __context__.SourceCodeLine = 1043;
                RESULT  .UpdateValue ( Functions.ItoA (  (int) ( ODATA.ISTARTYEAR ) ) + "-" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTMONTH )) + "-" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTDAY )) + "T" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTHOUR )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTMIN )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.ISTARTSEC ))  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1046;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STARTEND == "End"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1048;
                    RESULT  .UpdateValue ( Functions.ItoA (  (int) ( ODATA.IENDYEAR ) ) + "-" + ITOLA (  __context__ , (ushort)( ODATA.IENDMONTH )) + "-" + ITOLA (  __context__ , (ushort)( ODATA.IENDDAY )) + "T" + ITOLA (  __context__ , (ushort)( ODATA.IENDHOUR )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.IENDMIN )) + ":" + ITOLA (  __context__ , (ushort)( ODATA.IENDSEC ))  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 1051;
            return ( RESULT ) ; 
            
            }
            
        private CrestronString TIMEDIFF (  SplusExecutionContext __context__, ushort IFORMAT , CrestronString SSTARTDATE , CrestronString SSTARTTIME , CrestronString SENDDATE , CrestronString SENDTIME ) 
            { 
            ushort I = 0;
            
            ushort ITOTALMINUTESUNTIL = 0;
            ushort ITOTALMINUTESFROM = 0;
            ushort ITOTALDIFFMINUTES = 0;
            
            ushort IDIFFDAYS = 0;
            ushort IDAYSUNTIL = 0;
            ushort IDAYSFROM = 0;
            
            ushort ISTARTMONTH = 0;
            ushort IENDMONTH = 0;
            
            ushort ISTARTDAY = 0;
            ushort IENDDAY = 0;
            
            ushort ISTARTYEAR = 0;
            ushort IENDYEAR = 0;
            
            ushort ISTARTHOUR = 0;
            ushort IENDHOUR = 0;
            
            ushort ISTARTTIME = 0;
            ushort IENDTIME = 0;
            
            ushort ISTARTMIN = 0;
            ushort IENDMIN = 0;
            
            ushort ISTARTTIMEMIN = 0;
            ushort IENDTIMEMIN = 0;
            
            ushort IDIFFHOURS = 0;
            ushort IDIFFMINS = 0;
            
            ushort IDIFFTOTALMIN = 0;
            
            CrestronString STIMEDIFF;
            STIMEDIFF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 1083;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1085;
                Trace( "\r\n** TimeDiff **\r\n") ; 
                __context__.SourceCodeLine = 1086;
                Trace( "    Format:{0:d}\r\n", (ushort)IFORMAT) ; 
                __context__.SourceCodeLine = 1087;
                Trace( "    StartDate:{0}\r\n", SSTARTDATE ) ; 
                __context__.SourceCodeLine = 1088;
                Trace( "    StartTime:{0}\r\n", SSTARTTIME ) ; 
                __context__.SourceCodeLine = 1089;
                Trace( "    EndDate:{0}\r\n", SENDDATE ) ; 
                __context__.SourceCodeLine = 1090;
                Trace( "    EndTime:{0}\r\n", SENDTIME ) ; 
                } 
            
            __context__.SourceCodeLine = 1094;
            STIMEDIFF  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1096;
            ISTARTTIME = (ushort) ( TIMETOINTEGER( __context__ , SSTARTTIME , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 1097;
            ISTARTHOUR = (ushort) ( (ISTARTTIME / 100) ) ; 
            __context__.SourceCodeLine = 1098;
            ISTARTMIN = (ushort) ( Mod( ISTARTTIME , 100 ) ) ; 
            __context__.SourceCodeLine = 1099;
            ISTARTTIMEMIN = (ushort) ( ((ISTARTHOUR * 60) + ISTARTMIN) ) ; 
            __context__.SourceCodeLine = 1101;
            IENDTIME = (ushort) ( TIMETOINTEGER( __context__ , SENDTIME , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 1102;
            IENDHOUR = (ushort) ( (IENDTIME / 100) ) ; 
            __context__.SourceCodeLine = 1103;
            IENDMIN = (ushort) ( Mod( IENDTIME , 100 ) ) ; 
            __context__.SourceCodeLine = 1104;
            IENDTIMEMIN = (ushort) ( ((IENDHOUR * 60) + IENDMIN) ) ; 
            __context__.SourceCodeLine = 1107;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSTARTDATE == SENDDATE))  ) ) 
                { 
                __context__.SourceCodeLine = 1111;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1112;
                    Trace( "    Start Date = End Date\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1114;
                IDIFFTOTALMIN = (ushort) ( (IENDTIMEMIN - ISTARTTIMEMIN) ) ; 
                __context__.SourceCodeLine = 1115;
                IDIFFHOURS = (ushort) ( (IDIFFTOTALMIN / 60) ) ; 
                __context__.SourceCodeLine = 1116;
                IDIFFMINS = (ushort) ( Mod( IDIFFTOTALMIN , 60 ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1122;
                ISTARTMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SSTARTDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1123;
                ISTARTDAY = (ushort) ( Functions.Atoi( Functions.Right( SSTARTDATE , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1124;
                ISTARTYEAR = (ushort) ( Functions.Atoi( Functions.Left( SSTARTDATE , (int)( 4 ) ) ) ) ; 
                __context__.SourceCodeLine = 1126;
                IENDMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SENDDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1127;
                IENDDAY = (ushort) ( Functions.Atoi( Functions.Right( SENDDATE , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1128;
                IENDYEAR = (ushort) ( Functions.Atoi( Functions.Left( SENDDATE , (int)( 4 ) ) ) ) ; 
                __context__.SourceCodeLine = 1130;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1132;
                    Trace( "    iStartMonth:{0:d}\r\n", (ushort)ISTARTMONTH) ; 
                    __context__.SourceCodeLine = 1133;
                    Trace( "    iStartDay:{0:d}\r\n", (ushort)ISTARTDAY) ; 
                    __context__.SourceCodeLine = 1134;
                    Trace( "    iStartYear:{0:d}\r\n", (ushort)ISTARTYEAR) ; 
                    __context__.SourceCodeLine = 1136;
                    Trace( "    iEndMonth:{0:d}\r\n", (ushort)IENDMONTH) ; 
                    __context__.SourceCodeLine = 1137;
                    Trace( "    iEndDay:{0:d}\r\n", (ushort)IENDDAY) ; 
                    __context__.SourceCodeLine = 1138;
                    Trace( "    iEndYear:{0:d}\r\n", (ushort)IENDYEAR) ; 
                    } 
                
                __context__.SourceCodeLine = 1141;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTYEAR != IENDYEAR))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1143;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1144;
                        Trace( "    Years Not Equal\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1149;
                    IDAYSUNTIL = (ushort) ( (DAYSINMONTH( __context__ , (ushort)( ISTARTMONTH ) , (ushort)( ISTARTYEAR ) ) - ISTARTDAY) ) ; 
                    __context__.SourceCodeLine = 1151;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1152;
                        Trace( "    Days Until End of Current Month:{0:d}\r\n", (ushort)IDAYSUNTIL) ; 
                        }
                    
                    __context__.SourceCodeLine = 1155;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTMONTH != 12))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1157;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 1158;
                            Trace( "    Current Month <> 12. Add up all days based on month.\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 1160;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( (ISTARTMONTH + 1) ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)12; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 1162;
                            IDAYSUNTIL = (ushort) ( (IDAYSUNTIL + DAYSINMONTH( __context__ , (ushort)( I ) , (ushort)( ISTARTYEAR ) )) ) ; 
                            __context__.SourceCodeLine = 1160;
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 1166;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1167;
                        Trace( "    Total Days to the End of the Year:{0:d}\r\n", (ushort)IDAYSUNTIL) ; 
                        }
                    
                    __context__.SourceCodeLine = 1172;
                    IDAYSFROM = (ushort) ( DAYSINMONTH( __context__ , (ushort)( IENDMONTH ) , (ushort)( IENDYEAR ) ) ) ; 
                    __context__.SourceCodeLine = 1175;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IENDMONTH != 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1177;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 1178;
                            Trace( "    End Month <> 1\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 1180;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)(IENDMONTH - 1); 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 1182;
                            IDAYSFROM = (ushort) ( (IDAYSFROM + DAYSINMONTH( __context__ , (ushort)( I ) , (ushort)( IENDYEAR ) )) ) ; 
                            __context__.SourceCodeLine = 1180;
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 1186;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1187;
                        Trace( "    Total Days from the Beginning of the Year:{0:d}\r\n", (ushort)IDAYSFROM) ; 
                        }
                    
                    __context__.SourceCodeLine = 1189;
                    IDIFFDAYS = (ushort) ( (IDAYSUNTIL + IDAYSFROM) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1191;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTMONTH != IENDMONTH))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1193;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 1194;
                            Trace( "    Months Not Equal\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 1197;
                        IDIFFDAYS = (ushort) ( (DAYSINMONTH( __context__ , (ushort)( ISTARTMONTH ) , (ushort)( ISTARTYEAR ) ) - ISTARTDAY) ) ; 
                        __context__.SourceCodeLine = 1200;
                        IDIFFDAYS = (ushort) ( (IDIFFDAYS + DAYSINMONTH( __context__ , (ushort)( IENDMONTH ) , (ushort)( IENDYEAR ) )) ) ; 
                        __context__.SourceCodeLine = 1203;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (IENDMONTH - ISTARTMONTH) > 1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1205;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 1206;
                                Trace( "    Month Difference > 1\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 1208;
                            ushort __FN_FORSTART_VAL__3 = (ushort) ( (ISTARTMONTH + 1) ) ;
                            ushort __FN_FOREND_VAL__3 = (ushort)(IENDMONTH - 1); 
                            int __FN_FORSTEP_VAL__3 = (int)1; 
                            for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                                { 
                                __context__.SourceCodeLine = 1210;
                                IDIFFDAYS = (ushort) ( (IDIFFDAYS + DAYSINMONTH( __context__ , (ushort)( I ) , (ushort)( IENDYEAR ) )) ) ; 
                                __context__.SourceCodeLine = 1208;
                                } 
                            
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1214;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTDAY != IENDDAY))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1216;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 1217;
                                Trace( "    Days Not Equal\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 1219;
                            IDIFFDAYS = (ushort) ( (IENDDAY - ISTARTDAY) ) ; 
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 1222;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1223;
                    Trace( "    Total Day Diff:{0:d}\r\n", (ushort)IDIFFDAYS) ; 
                    }
                
                __context__.SourceCodeLine = 1228;
                ITOTALMINUTESUNTIL = (ushort) ( (1440 - ((ISTARTHOUR * 60) + ISTARTMIN)) ) ; 
                __context__.SourceCodeLine = 1230;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1231;
                    Trace( "    Total Minutes Until Midnight:{0:d}\r\n", (ushort)ITOTALMINUTESUNTIL) ; 
                    }
                
                __context__.SourceCodeLine = 1234;
                ITOTALMINUTESFROM = (ushort) ( ((IENDHOUR * 60) + IENDMIN) ) ; 
                __context__.SourceCodeLine = 1236;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1237;
                    Trace( "    Total Minutes From Midnight:{0:d}\r\n", (ushort)ITOTALMINUTESFROM) ; 
                    }
                
                __context__.SourceCodeLine = 1240;
                ITOTALDIFFMINUTES = (ushort) ( (ITOTALMINUTESUNTIL + ITOTALMINUTESFROM) ) ; 
                __context__.SourceCodeLine = 1242;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1243;
                    Trace( "    Total Diff Minutes:{0:d}\r\n", (ushort)ITOTALDIFFMINUTES) ; 
                    }
                
                __context__.SourceCodeLine = 1245;
                IDIFFDAYS = (ushort) ( (IDIFFDAYS - 1) ) ; 
                __context__.SourceCodeLine = 1247;
                IDIFFHOURS = (ushort) ( ((ITOTALDIFFMINUTES / 60) + (IDIFFDAYS * 24)) ) ; 
                __context__.SourceCodeLine = 1249;
                IDIFFMINS = (ushort) ( Mod( ITOTALDIFFMINUTES , 60 ) ) ; 
                __context__.SourceCodeLine = 1251;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1253;
                    Trace( "    Diff Hours:{0:d}\r\n", (ushort)IDIFFHOURS) ; 
                    __context__.SourceCodeLine = 1254;
                    Trace( "    Diff Minutes:{0:d}\r\n", (ushort)IDIFFMINS) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1262;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1265;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFFHOURS > 23 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1269;
                    IDIFFDAYS = (ushort) ( (IDIFFHOURS / 24) ) ; 
                    __context__.SourceCodeLine = 1271;
                    IDIFFHOURS = (ushort) ( (IDIFFHOURS - (IDIFFDAYS * 24)) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1275;
                    IDIFFDAYS = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 1279;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFFDAYS < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1281;
                    STIMEDIFF  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IDIFFDAYS ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1285;
                    STIMEDIFF  .UpdateValue ( Functions.ItoA (  (int) ( IDIFFDAYS ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 1290;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFFHOURS < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1292;
                    STIMEDIFF  .UpdateValue ( STIMEDIFF + ":0" + Functions.ItoA (  (int) ( IDIFFHOURS ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1296;
                    STIMEDIFF  .UpdateValue ( STIMEDIFF + ":" + Functions.ItoA (  (int) ( IDIFFHOURS ) )  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1299;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFORMAT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1302;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFFHOURS < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1304;
                        STIMEDIFF  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IDIFFHOURS ) )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1308;
                        STIMEDIFF  .UpdateValue ( Functions.ItoA (  (int) ( IDIFFHOURS ) )  ) ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 1313;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFFMINS < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1315;
                STIMEDIFF  .UpdateValue ( STIMEDIFF + ":0" + Functions.ItoA (  (int) ( IDIFFMINS ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1319;
                STIMEDIFF  .UpdateValue ( STIMEDIFF + ":" + Functions.ItoA (  (int) ( IDIFFMINS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1322;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1323;
                Trace( "    TimeDiff:{0}\r\n", STIMEDIFF ) ; 
                }
            
            __context__.SourceCodeLine = 1326;
            return ( STIMEDIFF ) ; 
            
            }
            
        private CrestronString FORMATTIMEDIFF (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SFORMATTEDDATA;
            SFORMATTEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
            
            ushort I = 0;
            ushort IDATALEN = 0;
            ushort ICOLONCOUNT = 0;
            
            ushort IDAY = 0;
            ushort IHOUR = 0;
            ushort IMIN = 0;
            
            
            __context__.SourceCodeLine = 1341;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1343;
                Trace( "\r\n** FormatTimeDiff **\r\n") ; 
                __context__.SourceCodeLine = 1344;
                Trace( "  Data:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 1347;
            SFORMATTEDDATA  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1350;
            IDATALEN = (ushort) ( Functions.Length( SDATA ) ) ; 
            __context__.SourceCodeLine = 1351;
            ICOLONCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1353;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IDATALEN; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1355;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( SDATA , (int)( I ) , (int)( 1 ) ) == ":"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1357;
                    ICOLONCOUNT = (ushort) ( (ICOLONCOUNT + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 1353;
                } 
            
            __context__.SourceCodeLine = 1361;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOLONCOUNT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1365;
                IHOUR = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1366;
                IMIN = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1368;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1370;
                    SFORMATTEDDATA  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) ) + " Hr " + Functions.ItoA (  (int) ( IMIN ) ) + " Min"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1374;
                    SFORMATTEDDATA  .UpdateValue ( Functions.ItoA (  (int) ( IMIN ) ) + " Min"  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1377;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOLONCOUNT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1381;
                    IDAY = (ushort) ( Functions.Atoi( Functions.Left( SDATA , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 1382;
                    IHOUR = (ushort) ( Functions.Atoi( Functions.Mid( SDATA , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 1383;
                    IMIN = (ushort) ( Functions.Atoi( Functions.Right( SDATA , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 1385;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1387;
                        SFORMATTEDDATA  .UpdateValue ( Functions.ItoA (  (int) ( IDAY ) ) + " Day " + Functions.ItoA (  (int) ( IHOUR ) ) + " Hr " + Functions.ItoA (  (int) ( IMIN ) ) + " Min"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1391;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1393;
                            SFORMATTEDDATA  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) ) + " Hr " + Functions.ItoA (  (int) ( IMIN ) ) + " Min"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1397;
                            SFORMATTEDDATA  .UpdateValue ( Functions.ItoA (  (int) ( IMIN ) ) + " Min"  ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 1402;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1404;
                Trace( "  FormattedData:{0}\r\n", SFORMATTEDDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 1407;
            return ( SFORMATTEDDATA ) ; 
            
            }
            
        private CrestronString TIMEREMAINING (  SplusExecutionContext __context__, ushort ITYPE ) 
            { 
            ushort I = 0;
            ushort IEVENTINDEX = 0;
            
            ushort ICURRENTHOUR = 0;
            ushort ICURRENTMIN = 0;
            
            ushort IENDHOUR = 0;
            ushort IENDMIN = 0;
            
            ushort IHOURSREMAINING = 0;
            ushort IMINUTESREMAINING = 0;
            
            CrestronString STIMEREMAINING;
            STIMEREMAINING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 1431;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1432;
                Trace( "\r\n** TimeRemaining **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1435;
            STIMEREMAINING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1441;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                {
                __context__.SourceCodeLine = 1442;
                IEVENTINDEX = (ushort) ( G_ICURRENTEVENTNUM ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1443;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
                    {
                    __context__.SourceCodeLine = 1444;
                    IEVENTINDEX = (ushort) ( G_ISTARTEDEVENTNUM ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1447;
            ICURRENTHOUR = (ushort) ( (G_ICURRENTTIME / 100) ) ; 
            __context__.SourceCodeLine = 1448;
            ICURRENTMIN = (ushort) ( Mod( G_ICURRENTTIME , 100 ) ) ; 
            __context__.SourceCodeLine = 1451;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ IEVENTINDEX ].ENDDATE))  ) ) 
                { 
                __context__.SourceCodeLine = 1455;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1456;
                    Trace( "    Event Ends Today\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1459;
                IENDHOUR = (ushort) ( (TIMETOINTEGER( __context__ , MEETINGEVENT[ IEVENTINDEX ].ENDTIME , (ushort)( 1 ) ) / 100) ) ; 
                __context__.SourceCodeLine = 1460;
                IENDMIN = (ushort) ( Mod( TIMETOINTEGER( __context__ , MEETINGEVENT[ IEVENTINDEX ].ENDTIME , (ushort)( 1 ) ) , 100 ) ) ; 
                __context__.SourceCodeLine = 1463;
                IHOURSREMAINING = (ushort) ( (IENDHOUR - ICURRENTHOUR) ) ; 
                __context__.SourceCodeLine = 1466;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTMIN < IENDMIN ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1467;
                    IMINUTESREMAINING = (ushort) ( (IENDMIN - ICURRENTMIN) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 1470;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURSREMAINING > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1471;
                        IHOURSREMAINING = (ushort) ( (IHOURSREMAINING - 1) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1473;
                    IMINUTESREMAINING = (ushort) ( ((60 - ICURRENTMIN) + IENDMIN) ) ; 
                    } 
                
                __context__.SourceCodeLine = 1478;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IHOURSREMAINING > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( IMINUTESREMAINING > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1480;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1481;
                        Trace( "    There is Time Remaining\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1483;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURSREMAINING < 10 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1484;
                        STIMEREMAINING  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IHOURSREMAINING ) )  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1486;
                        STIMEREMAINING  .UpdateValue ( Functions.ItoA (  (int) ( IHOURSREMAINING ) )  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1488;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMINUTESREMAINING < 10 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1489;
                        STIMEREMAINING  .UpdateValue ( STIMEREMAINING + ":0" + Functions.ItoA (  (int) ( IMINUTESREMAINING ) )  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1491;
                        STIMEREMAINING  .UpdateValue ( STIMEREMAINING + ":" + Functions.ItoA (  (int) ( IMINUTESREMAINING ) )  ) ; 
                        }
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1495;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1496;
                        Trace( "    No Time Remaining\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1498;
                    STIMEREMAINING  .UpdateValue ( ""  ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1505;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1506;
                    Trace( "    Event Does Not End Today\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1509;
                STIMEREMAINING  .UpdateValue ( TIMEDIFF (  __context__ , (ushort)( 2 ), G_SDATETODAY, G_SCURRENTTIME, MEETINGEVENT[ IEVENTINDEX ].ENDDATE, MEETINGEVENT[ IEVENTINDEX ].ENDTIME)  ) ; 
                } 
            
            __context__.SourceCodeLine = 1513;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1514;
                Trace( "    TimeRemaining:{0}\r\n", STIMEREMAINING ) ; 
                }
            
            __context__.SourceCodeLine = 1516;
            return ( STIMEREMAINING ) ; 
            
            }
            
        private ushort ELAPSEDTIMEMIN (  SplusExecutionContext __context__ ) 
            { 
            ushort IEVENTINDEX = 0;
            ushort ISTARTTIME = 0;
            
            CrestronString SELAPSEDTIME;
            CrestronString STIMEDIFF;
            SELAPSEDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            STIMEDIFF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            ushort ICURRENTHOUR = 0;
            ushort ICURRENTMIN = 0;
            ushort ICURRENTTIMEMIN = 0;
            
            ushort ISTARTHOUR = 0;
            ushort ISTARTMIN = 0;
            
            ushort IELAPSEDHOURS = 0;
            ushort IELAPSEDMINUTES = 0;
            ushort IELAPSEDTIMEMIN = 0;
            
            
            __context__.SourceCodeLine = 1540;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1542;
                Trace( "\r\n** ElapsedTime **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1546;
            IELAPSEDTIMEMIN = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1549;
            IEVENTINDEX = (ushort) ( G_ICURRENTEVENTNUM ) ; 
            __context__.SourceCodeLine = 1552;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTTIME > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1556;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1557;
                    Trace( "    Meeting Started Prior to Actual Start Time\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1559;
                ISTARTTIME = (ushort) ( G_ISTARTEDEVENTTIME ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1565;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1566;
                    Trace( "    Meeting did not start prior to Start Time\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1568;
                ISTARTTIME = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ IEVENTINDEX ].STARTTIME , (ushort)( 1 ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 1572;
            ICURRENTHOUR = (ushort) ( (G_ICURRENTTIME / 100) ) ; 
            __context__.SourceCodeLine = 1573;
            ICURRENTMIN = (ushort) ( Mod( G_ICURRENTTIME , 100 ) ) ; 
            __context__.SourceCodeLine = 1574;
            ICURRENTTIMEMIN = (ushort) ( ((ICURRENTHOUR * 60) + ICURRENTMIN) ) ; 
            __context__.SourceCodeLine = 1577;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ IEVENTINDEX ].STARTDATE))  ) ) 
                { 
                __context__.SourceCodeLine = 1579;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1580;
                    Trace( "    Event Starts Today\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1582;
                ISTARTHOUR = (ushort) ( (ISTARTTIME / 100) ) ; 
                __context__.SourceCodeLine = 1583;
                ISTARTMIN = (ushort) ( Mod( ISTARTTIME , 100 ) ) ; 
                __context__.SourceCodeLine = 1586;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTHOUR < ISTARTHOUR ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1590;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1591;
                        Trace( "    Current Hour < Start Hour. Error!\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1593;
                    IELAPSEDTIMEMIN = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1597;
                    IELAPSEDTIMEMIN = (ushort) ( (ICURRENTTIMEMIN - ((ISTARTHOUR * 60) + ISTARTMIN)) ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1602;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) > DATETOINTEGER( __context__ , MEETINGEVENT[ IEVENTINDEX ].STARTDATE ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1604;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 1605;
                        Trace( "    Event Started Prior to Today\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1609;
                    STIMEDIFF  .UpdateValue ( TIMEDIFF (  __context__ , (ushort)( 2 ), MEETINGEVENT[ IEVENTINDEX ].STARTDATE, MEETINGEVENT[ IEVENTINDEX ].STARTTIME, G_SDATETODAY, G_SCURRENTTIME)  ) ; 
                    __context__.SourceCodeLine = 1613;
                    IELAPSEDHOURS = (ushort) ( Functions.Atoi( Functions.Left( STIMEDIFF , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 1616;
                    IELAPSEDMINUTES = (ushort) ( Functions.Atoi( Functions.Right( STIMEDIFF , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 1619;
                    IELAPSEDTIMEMIN = (ushort) ( ((IELAPSEDHOURS * 60) + IELAPSEDMINUTES) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 1623;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1624;
                Trace( "    ElapsedTimeMin:{0:d}\r\n", (ushort)IELAPSEDTIMEMIN) ; 
                }
            
            __context__.SourceCodeLine = 1626;
            return (ushort)( IELAPSEDTIMEMIN) ; 
            
            }
            
        private ushort DURATIONMIN (  SplusExecutionContext __context__ ) 
            { 
            ushort IEVENTINDEX = 0;
            ushort ISTARTTIME = 0;
            ushort IENDTIME = 0;
            
            ushort IEVENTDURATIONMIN = 0;
            ushort IHOURMIN = 0;
            ushort ISTARTTIMEMIN = 0;
            ushort IENDTIMEMIN = 0;
            
            ushort IDURATIONHOURS = 0;
            ushort IDURATIONMINUTES = 0;
            
            CrestronString SSTARTTIME;
            CrestronString SENDTIME;
            SSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            SENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            ushort IHOUR = 0;
            ushort IMIN = 0;
            
            CrestronString STIMEDIFF;
            STIMEDIFF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 1651;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1653;
                Trace( "\r\n** DurationMin **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1657;
            STIMEDIFF  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1660;
            IEVENTINDEX = (ushort) ( G_ICURRENTEVENTNUM ) ; 
            __context__.SourceCodeLine = 1663;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTTIME > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1667;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1668;
                    Trace( "    Meeting Started Prior to Actual Start Time\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1670;
                ISTARTTIME = (ushort) ( G_ISTARTEDEVENTTIME ) ; 
                __context__.SourceCodeLine = 1672;
                IHOUR = (ushort) ( (ISTARTTIME / 100) ) ; 
                __context__.SourceCodeLine = 1674;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1676;
                    SSTARTTIME  .UpdateValue ( "0" + Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1680;
                    SSTARTTIME  .UpdateValue ( Functions.ItoA (  (int) ( IHOUR ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 1683;
                IMIN = (ushort) ( Mod( ISTARTTIME , 100 ) ) ; 
                __context__.SourceCodeLine = 1685;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMIN < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1687;
                    SSTARTTIME  .UpdateValue ( SSTARTTIME + ":0" + Functions.ItoA (  (int) ( IMIN ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1691;
                    SSTARTTIME  .UpdateValue ( SSTARTTIME + Functions.ItoA (  (int) ( IMIN ) )  ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1698;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1699;
                    Trace( "    Meeting did not start prior to Start Time\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1701;
                SSTARTTIME  .UpdateValue ( MEETINGEVENT [ IEVENTINDEX] . STARTTIME  ) ; 
                __context__.SourceCodeLine = 1702;
                ISTARTTIME = (ushort) ( TIMETOINTEGER( __context__ , SSTARTTIME , (ushort)( 1 ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 1706;
            SENDTIME  .UpdateValue ( MEETINGEVENT [ IEVENTINDEX] . ENDTIME  ) ; 
            __context__.SourceCodeLine = 1707;
            IENDTIME = (ushort) ( TIMETOINTEGER( __context__ , SENDTIME , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 1710;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ IEVENTINDEX ].STARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ IEVENTINDEX ].ENDDATE) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1715;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1716;
                    Trace( "    Event Starts & Ends Today\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1719;
                IHOURMIN = (ushort) ( ((ISTARTTIME / 100) * 60) ) ; 
                __context__.SourceCodeLine = 1720;
                ISTARTTIMEMIN = (ushort) ( (IHOURMIN + Mod( ISTARTTIME , 100 )) ) ; 
                __context__.SourceCodeLine = 1723;
                IHOURMIN = (ushort) ( ((IENDTIME / 100) * 60) ) ; 
                __context__.SourceCodeLine = 1724;
                IENDTIMEMIN = (ushort) ( (IHOURMIN + Mod( IENDTIME , 100 )) ) ; 
                __context__.SourceCodeLine = 1727;
                IEVENTDURATIONMIN = (ushort) ( (IENDTIMEMIN - ISTARTTIMEMIN) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1733;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1734;
                    Trace( "    Event did not Start or End Today\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1737;
                STIMEDIFF  .UpdateValue ( TIMEDIFF (  __context__ , (ushort)( 2 ), MEETINGEVENT[ IEVENTINDEX ].STARTDATE, SSTARTTIME, MEETINGEVENT[ IEVENTINDEX ].ENDDATE, SENDTIME)  ) ; 
                __context__.SourceCodeLine = 1741;
                IDURATIONHOURS = (ushort) ( Functions.Atoi( Functions.Left( STIMEDIFF , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1744;
                IDURATIONMINUTES = (ushort) ( Functions.Atoi( Functions.Right( STIMEDIFF , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 1747;
                IEVENTDURATIONMIN = (ushort) ( ((IDURATIONHOURS * 60) + IDURATIONMINUTES) ) ; 
                } 
            
            __context__.SourceCodeLine = 1751;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1752;
                Trace( "    EventDurationMin:{0:d}\r\n", (ushort)IEVENTDURATIONMIN) ; 
                }
            
            __context__.SourceCodeLine = 1754;
            return (ushort)( IEVENTDURATIONMIN) ; 
            
            }
            
        private void SENDFREEBUSYATTRIBUTEDATA (  SplusExecutionContext __context__, CrestronString SDATE , CrestronString STIME ) 
            { 
            CrestronString SOCCUPIED;
            CrestronString SENRESERVENOW;
            CrestronString SPRIVACYLEVEL;
            CrestronString SMEETINGACTIVE;
            SOCCUPIED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            SENRESERVENOW  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            SPRIVACYLEVEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            SMEETINGACTIVE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            CrestronString SNEWTIME;
            SNEWTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 1770;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1772;
                Trace( "\r\n** SendFreeBusyAttributeData **\r\n") ; 
                __context__.SourceCodeLine = 1773;
                Trace( "  Date:{0}\r\n", SDATE ) ; 
                __context__.SourceCodeLine = 1774;
                Trace( "  Time:{0}\r\n", STIME ) ; 
                } 
            
            __context__.SourceCodeLine = 1777;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STIME ) < 8 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1780;
                SNEWTIME  .UpdateValue ( STIME + ":00"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1785;
                SNEWTIME  .UpdateValue ( STIME  ) ; 
                } 
            
            __context__.SourceCodeLine = 1788;
            if ( Functions.TestForTrue  ( ( Functions.Not( EWS_SUBSCRIPTION_OFFLINE_FB  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 1790;
                if ( Functions.TestForTrue  ( ( EN_FREEBUSY_ATTRIBUTEDATA  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 1791;
                    TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR__  .UpdateValue ( SDATE + "T" + SNEWTIME  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1793;
                    TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR__  .UpdateValue ( "-"  ) ; 
                    }
                
                } 
            
            
            }
            
        private void SETCURRENTTIMEBARGRAPHVALUE (  SplusExecutionContext __context__ ) 
            { 
            ushort ISTARTBLOCK = 0;
            ushort IENDBLOCK = 0;
            ushort IMINUTESPERPAGE = 0;
            ushort IOFFSETMINUTES = 0;
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 1806;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1808;
                Trace( "\r\n** SetCurrentTimeBargraphValue **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1811;
            IMINUTESPERPAGE = (ushort) ( (FIELD_QTY  .UshortValue * 30) ) ; 
            __context__.SourceCodeLine = 1812;
            IOFFSETMINUTES = (ushort) ( ((CURRENT_PAGE  .UshortValue * IMINUTESPERPAGE) - IMINUTESPERPAGE) ) ; 
            __context__.SourceCodeLine = 1815;
            CURRENT_TIME_BARGRAPH_VALUE  .Value = (ushort) ( (65535 - ((65535 / IMINUTESPERPAGE) * (G_ICURRENTTIMEMIN - IOFFSETMINUTES))) ) ; 
            
            }
            
        private void SENDREMOTESYSTEMDATA (  SplusExecutionContext __context__, ushort ITYPE , CrestronString SDATA ) 
            { 
            ushort I = 0;
            ushort IEVENTNUM = 0;
            
            
            __context__.SourceCodeLine = 1823;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1825;
                Trace( "\r\n** SendRemoteSystemData **\r\n") ; 
                __context__.SourceCodeLine = 1826;
                Trace( "    iType:{0:d}\r\n", (ushort)ITYPE) ; 
                __context__.SourceCodeLine = 1827;
                Trace( "    sData:{0}\r\n", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 1830;
            IEVENTNUM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1832;
            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<RemoteSystemData>"  ) ; 
            __context__.SourceCodeLine = 1835;
            switch ((int)ITYPE)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 1839;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<WorkdaySchedule>"  ) ; 
                    __context__.SourceCodeLine = 1842;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTOREDEVENTCOUNT > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1845;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 1847;
                            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Event>" + "<MeetingID>" + MEETINGEVENT [ I] . MEETINGID + "</MeetingID>"  ) ; 
                            __context__.SourceCodeLine = 1851;
                            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<RVMeetingID>" + MEETINGEVENT [ I] . RVMEETINGID + "</RVMeetingID>"  ) ; 
                            __context__.SourceCodeLine = 1854;
                            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartDate>" + MEETINGEVENT [ I] . STARTDATE + "</StartDate>" + "<StartTime>" + MEETINGEVENT [ I] . STARTTIME + "</StartTime>" + "<StartBlock>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].STARTBLOCK ) ) + "</StartBlock>"  ) ; 
                            __context__.SourceCodeLine = 1859;
                            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<EndDate>" + MEETINGEVENT [ I] . ENDDATE + "</EndDate>" + "<EndTime>" + MEETINGEVENT [ I] . ENDTIME + "</EndTime>" + "<EndBlock>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].ENDBLOCK ) ) + "</EndBlock>"  ) ; 
                            __context__.SourceCodeLine = 1864;
                            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Organizer>" + MEETINGEVENT [ I] . ORGANIZER + "</Organizer>"  ) ; 
                            __context__.SourceCodeLine = 1867;
                            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Subject>" + MEETINGEVENT [ I] . SUBJECT + "</Subject>" + "<IsPrivate>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].ISPRIVATE ) ) + "</IsPrivate>" + "<IsExchangePrivate>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].ISEXCHANGEPRIVATE ) ) + "</IsExchangePrivate>" + "</Event>"  ) ; 
                            __context__.SourceCodeLine = 1845;
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 1875;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</WorkdaySchedule>"  ) ; 
                    __context__.SourceCodeLine = 1878;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 1883;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<CurrentMeetingInfo>"  ) ; 
                    __context__.SourceCodeLine = 1888;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTNUM > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1889;
                        IEVENTNUM = (ushort) ( G_ISTARTEDEVENTNUM ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1890;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1891;
                            IEVENTNUM = (ushort) ( G_ICURRENTEVENTNUM ) ; 
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 1893;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTNUM > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1896;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartDate>" + MEETINGEVENT [ IEVENTNUM] . STARTDATE + "</StartDate>" + "<StartTime>" + MEETINGEVENT [ IEVENTNUM] . STARTTIME + "</StartTime>" + "<EndDate>" + MEETINGEVENT [ IEVENTNUM] . ENDDATE + "</EndDate>" + "<EndTime>" + MEETINGEVENT [ IEVENTNUM] . ENDTIME + "</EndTime>"  ) ; 
                        __context__.SourceCodeLine = 1902;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Organizer>" + MEETINGEVENT [ IEVENTNUM] . ORGANIZER + "</Organizer>"  ) ; 
                        __context__.SourceCodeLine = 1905;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Subject>" + MEETINGEVENT [ IEVENTNUM] . SUBJECT + "</Subject>"  ) ; 
                        __context__.SourceCodeLine = 1908;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<WelcomeMsg>" + G_SCURRENTWELCOMEMSG + "</WelcomeMsg>"  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1912;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</CurrentMeetingInfo>"  ) ; 
                    __context__.SourceCodeLine = 1915;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 1920;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<NextReservation>"  ) ; 
                    __context__.SourceCodeLine = 1924;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.MEETINGID ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1928;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartDate>" + NEXTEVENT . STARTDATE + "</StartDate>" + "<StartTime>" + NEXTEVENT . STARTTIME + "</StartTime>" + "<EndDate>" + NEXTEVENT . ENDDATE + "</EndDate>" + "<EndTime>" + NEXTEVENT . ENDTIME + "</EndTime>"  ) ; 
                        __context__.SourceCodeLine = 1934;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Organizer>" + NEXTEVENT . ORGANIZER + "</Organizer>"  ) ; 
                        __context__.SourceCodeLine = 1937;
                        TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Subject>" + NEXTEVENT . SUBJECT + "</Subject>"  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1942;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</NextReservation>"  ) ; 
                    __context__.SourceCodeLine = 1945;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 1950;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Set ID=\u0022EndMeetingWarn\u0022 Value=\u0022" + SDATA + "\u0022 />"  ) ; 
                    __context__.SourceCodeLine = 1952;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 1957;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<DateTime>"  ) ; 
                    __context__.SourceCodeLine = 1960;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Set ID=\u0022DateTime\u0022 Value=\u0022" + G_SDATETODAY + "T" + G_SCURRENTTIME + ":00" + "\u0022 />"  ) ; 
                    __context__.SourceCodeLine = 1963;
                    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</DateTime>"  ) ; 
                    __context__.SourceCodeLine = 1965;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 1969;
            TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</RemoteSystemData>"  ) ; 
            
            }
            
        private void SETRESERVENOW (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort IEVENTSTARTBLOCK = 0;
            ushort IEVENTENDBLOCK = 0;
            ushort BCURRENTTIMEBLOCKACTIVE = 0;
            
            
            __context__.SourceCodeLine = 1980;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1982;
                Trace( "\r\n** SetReserveNow **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1985;
            IEVENTSTARTBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1986;
            IEVENTENDBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1987;
            BCURRENTTIMEBLOCKACTIVE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1989;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (RESERVE_NOW_REQUEST_MODE  .Value != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (WORKDAY_SCHED_REQUEST_MODE  .Value == 2) )) ) ) || Functions.TestForTrue ( G_BRESERVENOWSUCCESSNEEDSCHED )) ) ) || Functions.TestForTrue ( EWS_SUBSCRIPTION_OFFLINE_FB  .Value )) ) ) || Functions.TestForTrue ( ROOMSERVICE_BACKLOG_ACTIVE_FB  .Value )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1995;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1997;
                    Trace( "    Disable Book Now\r\n") ; 
                    __context__.SourceCodeLine = 1998;
                    Trace( "     Reasons:\r\n") ; 
                    __context__.SourceCodeLine = 1999;
                    Trace( "      ReserveNowRequestMode:{0:d}\r\n", (ushort)RESERVE_NOW_REQUEST_MODE  .Value) ; 
                    __context__.SourceCodeLine = 2000;
                    Trace( "      WorkdaySchedRequestMode:{0:d}\r\n", (ushort)WORKDAY_SCHED_REQUEST_MODE  .Value) ; 
                    __context__.SourceCodeLine = 2001;
                    Trace( "      ReserveNowSuccessNeedSched:{0:d}\r\n", (ushort)G_BRESERVENOWSUCCESSNEEDSCHED) ; 
                    __context__.SourceCodeLine = 2002;
                    Trace( "      EWSSubscriptionOffline:{0:d}\r\n", (ushort)EWS_SUBSCRIPTION_OFFLINE_FB  .Value) ; 
                    __context__.SourceCodeLine = 2003;
                    Trace( "      BacklogActive:{0:d}\r\n", (ushort)ROOMSERVICE_BACKLOG_ACTIVE_FB  .Value) ; 
                    } 
                
                __context__.SourceCodeLine = 2006;
                ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2011;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ICURRENTEVENTNUM == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2015;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2016;
                        Trace( "  No current event. Enable reserve now.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2018;
                    ENABLE_RESERVE_NOW  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2024;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2025;
                        Trace( "  Have current event. Disable reserve now.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2027;
                    ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            
            }
            
        private void SETSTARTMEETINGBTN (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 2047;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2049;
                Trace( "\r** Start Meeting Btn**\r") ; 
                __context__.SourceCodeLine = 2050;
                Trace( "Config_En_Decline_For_NoShow: {0:d}\r", (short)CONFIG_EN_DECLINE_FOR_NOSHOW  .Value) ; 
                __context__.SourceCodeLine = 2051;
                Trace( "Config_En_StartMeeting: {0:d}\r", (short)CONFIG_EN_STARTMEETING  .Value) ; 
                __context__.SourceCodeLine = 2052;
                Trace( "Meeting_Active: {0:d}\r", (short)MEETING_ACTIVE  .Value) ; 
                __context__.SourceCodeLine = 2053;
                Trace( "End_Meeting_Btn_Sub: {0:d}\r", (short)END_MEETING_BTN_SUB  .Value) ; 
                __context__.SourceCodeLine = 2054;
                Trace( "Current_Meeting_Elapsed_Time < Decline_Meeting_Min: {0:d} < {1:d} ?\r", (short)CURRENT_MEETING_ELAPSED_TIME  .Value, (short)DECLINE_MEETING_MIN  .UshortValue) ; 
                } 
            
            __context__.SourceCodeLine = 2057;
            if ( Functions.TestForTrue  ( ( CONFIG_EN_DECLINE_FOR_NOSHOW  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2059;
                if ( Functions.TestForTrue  ( ( CONFIG_EN_STARTMEETING  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2061;
                    if ( Functions.TestForTrue  ( ( MEETING_ACTIVE  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 2063;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (END_MEETING_BTN_SUB  .Value == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2065;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_MEETING_ELAPSED_TIME  .Value < DECLINE_MEETING_MIN  .UshortValue ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2067;
                                if ( Functions.TestForTrue  ( ( Functions.Not( G_BSTARTMEETINGCONFIRMED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2069;
                                    START_MEETING_BTN_SUB  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 2070;
                                    return ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2078;
            START_MEETING_BTN_SUB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2079;
            START_MEETING_BTN_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2080;
            START_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void SETENDMEETINGBTN (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 2098;
            if ( Functions.TestForTrue  ( ( CONFIG_EN_FREEUPROOM  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2100;
                if ( Functions.TestForTrue  ( ( MEETING_ACTIVE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2102;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_MEETING_ELAPSED_TIME  .Value >= DECLINE_MEETING_MIN  .UshortValue ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2104;
                        END_MEETING_BTN_SUB  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 2105;
                        return ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2111;
            END_MEETING_BTN_SUB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2112;
            END_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void SETENDNEXTMEETINGWARN (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort BNEXTEVENT = 0;
            
            ushort ICURRENTEVENT = 0;
            ushort INEXTEVENT = 0;
            ushort IEVENTENDTIME = 0;
            ushort IEVENTENDTIMEMIN = 0;
            
            
            __context__.SourceCodeLine = 2137;
            BNEXTEVENT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2138;
            INEXTEVENT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2140;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2142;
                Trace( "\r\n** SetEndNextMeetingWarn **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 2145;
            INEXTEVENT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2148;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2150;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 2151;
                    Trace( "    Current Event\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 2153;
                ICURRENTEVENT = (ushort) ( G_ICURRENTEVENTNUM ) ; 
                __context__.SourceCodeLine = 2156;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ ICURRENTEVENT ].ENDDATE == G_SDATETODAY))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2158;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2159;
                        Trace( "    Meeting Ends Today. Check Time Remaining\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2161;
                    IEVENTENDTIME = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ ICURRENTEVENT ].ENDTIME , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 2163;
                    IEVENTENDTIMEMIN = (ushort) ( (((IEVENTENDTIME / 100) * 60) + Mod( IEVENTENDTIME , 100 )) ) ; 
                    __context__.SourceCodeLine = 2166;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (IEVENTENDTIMEMIN - G_ICURRENTTIMEMIN) <= END_NEXT_MEETING_WARN_TIME  .UshortValue ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2168;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 2169;
                            Trace( "    Time Remaining = Warn Value of :{0:d}\r\n", (ushort)END_NEXT_MEETING_WARN_TIME  .UshortValue) ; 
                            }
                        
                        __context__.SourceCodeLine = 2172;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((IEVENTENDTIMEMIN - G_ICURRENTTIMEMIN) == END_NEXT_MEETING_WARN_TIME  .UshortValue))  ) ) 
                            {
                            __context__.SourceCodeLine = 2173;
                            END_MEETING_WARN_COUNTDOWN_SEED  .Value = (ushort) ( (END_NEXT_MEETING_WARN_TIME  .UshortValue * 60) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2181;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (END_MEETING_WARN_COUNTDOWN_SEED  .Value == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2183;
                                END_MEETING_WARN_COUNTDOWN_SEED  .Value = (ushort) ( ((IEVENTENDTIMEMIN - G_ICURRENTTIMEMIN) * 60) ) ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 2187;
                        END_MEETING_WARN_FB  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 2189;
                        if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2191;
                            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<ScheduleInterfaceData>" + "<EndMeetingWarn>" + Functions.ItoA (  (int) ( ICURRENTEVENT ) ) + "</EndMeetingWarn>" + "</ScheduleInterfaceData>"  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 2197;
                        if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
                            {
                            __context__.SourceCodeLine = 2198;
                            SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 4 ), "1") ; 
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2202;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 2203;
                            Trace( "    Time Remaining > Warn Value\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 2205;
                        END_MEETING_WARN_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 2207;
                        if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                            { 
                            __context__.SourceCodeLine = 2209;
                            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<ScheduleInterfaceData>" + "<EndMeetingWarn>0</EndMeetingWarn>" + "</ScheduleInterfaceData>"  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 2215;
                        if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
                            {
                            __context__.SourceCodeLine = 2216;
                            SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 4 ), "0") ; 
                            }
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2221;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2222;
                        Trace( "    Meeting Does Not End Today\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2224;
                    END_MEETING_WARN_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 2226;
                    if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                        { 
                        __context__.SourceCodeLine = 2228;
                        TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<ScheduleInterfaceData>" + "<EndMeetingWarn>0</EndMeetingWarn>" + "</ScheduleInterfaceData>"  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 2234;
                    if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
                        {
                        __context__.SourceCodeLine = 2235;
                        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 4 ), "0") ; 
                        }
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2241;
                END_MEETING_WARN_FB  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        private CrestronString NEXTTIMEMIN (  SplusExecutionContext __context__, CrestronString SSTARTTIME ) 
            { 
            ushort ISTARTHOUR = 0;
            ushort ISTARTMIN = 0;
            
            ushort INEXTHOUR = 0;
            ushort INEXTMIN = 0;
            
            ushort BNEEDNEXTDAY = 0;
            
            CrestronString SNEXTTIMEMIN;
            SNEXTTIMEMIN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 2269;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2271;
                Trace( "\r\n** NextTimeMin **\r\n") ; 
                __context__.SourceCodeLine = 2272;
                Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
                } 
            
            __context__.SourceCodeLine = 2275;
            BNEEDNEXTDAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2278;
            ISTARTHOUR = (ushort) ( Functions.Atoi( Functions.Left( SSTARTTIME , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 2279;
            ISTARTMIN = (ushort) ( Functions.Atoi( Functions.Mid( SSTARTTIME , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 2284;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTARTMIN < 59 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2288;
                INEXTHOUR = (ushort) ( ISTARTHOUR ) ; 
                __context__.SourceCodeLine = 2289;
                INEXTMIN = (ushort) ( (ISTARTMIN + 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2296;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTARTHOUR < 23 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2300;
                    INEXTHOUR = (ushort) ( (ISTARTHOUR + 1) ) ; 
                    __context__.SourceCodeLine = 2301;
                    INEXTMIN = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2306;
                    BNEEDNEXTDAY = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2311;
            if ( Functions.TestForTrue  ( ( BNEEDNEXTDAY)  ) ) 
                { 
                __context__.SourceCodeLine = 2315;
                SNEXTTIMEMIN  .UpdateValue ( "NextDay"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2322;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTHOUR < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2324;
                    SNEXTTIMEMIN  .UpdateValue ( "0" + Functions.ItoA (  (int) ( INEXTHOUR ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2328;
                    SNEXTTIMEMIN  .UpdateValue ( Functions.ItoA (  (int) ( INEXTHOUR ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 2332;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTMIN < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2334;
                    SNEXTTIMEMIN  .UpdateValue ( SNEXTTIMEMIN + ":" + "0" + Functions.ItoA (  (int) ( INEXTMIN ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2338;
                    SNEXTTIMEMIN  .UpdateValue ( SNEXTTIMEMIN + ":" + Functions.ItoA (  (int) ( INEXTMIN ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 2342;
                SNEXTTIMEMIN  .UpdateValue ( SNEXTTIMEMIN + ":00"  ) ; 
                } 
            
            __context__.SourceCodeLine = 2345;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2347;
                Trace( "  NextTimeMin:{0}\r\n", SNEXTTIMEMIN ) ; 
                } 
            
            __context__.SourceCodeLine = 2350;
            return ( SNEXTTIMEMIN ) ; 
            
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
            
            
            __context__.SourceCodeLine = 2380;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2382;
                Trace( "\r\n** NextDayDate **\r\n") ; 
                __context__.SourceCodeLine = 2383;
                Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
                __context__.SourceCodeLine = 2384;
                Trace( "  Days:{0}\r\n", SDAYS ) ; 
                } 
            
            __context__.SourceCodeLine = 2388;
            ISTARTMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SSTARTDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 2389;
            ISTARTDAY = (ushort) ( Functions.Atoi( Functions.Right( SSTARTDATE , (int)( 2 ) ) ) ) ; 
            __context__.SourceCodeLine = 2390;
            ISTARTYEAR = (ushort) ( Functions.Atoi( Functions.Left( SSTARTDATE , (int)( 4 ) ) ) ) ; 
            __context__.SourceCodeLine = 2391;
            IDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( ISTARTMONTH ) , (ushort)( ISTARTYEAR ) ) ) ; 
            __context__.SourceCodeLine = 2393;
            IDAYS = (ushort) ( Functions.Atoi( SDAYS ) ) ; 
            __context__.SourceCodeLine = 2395;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2397;
                Trace( "  StartMonth:{0:d}\r\n", (ushort)ISTARTMONTH) ; 
                __context__.SourceCodeLine = 2398;
                Trace( "  StartDay:{0:d}\r\n", (ushort)ISTARTDAY) ; 
                __context__.SourceCodeLine = 2399;
                Trace( "  StartYear:{0:d}\r\n", (ushort)ISTARTYEAR) ; 
                __context__.SourceCodeLine = 2400;
                Trace( "  DaysInMonth:{0:d}\r\n", (ushort)IDAYSINMONTH) ; 
                __context__.SourceCodeLine = 2401;
                Trace( "  Days:{0:d}\r\n", (ushort)IDAYS) ; 
                } 
            
            __context__.SourceCodeLine = 2408;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (ISTARTDAY + IDAYS) <= IDAYSINMONTH ))  ) ) 
                { 
                __context__.SourceCodeLine = 2412;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2414;
                    Trace( "  Days left in month.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 2417;
                INEXTMONTH = (ushort) ( ISTARTMONTH ) ; 
                __context__.SourceCodeLine = 2418;
                INEXTDAY = (ushort) ( (ISTARTDAY + IDAYS) ) ; 
                __context__.SourceCodeLine = 2419;
                INEXTYEAR = (ushort) ( ISTARTYEAR ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2425;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2427;
                    Trace( "  No days left in month.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 2431;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTMONTH == 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2434;
                    INEXTMONTH = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 2435;
                    INEXTDAY = (ushort) ( ((ISTARTDAY + IDAYS) - IDAYSINMONTH) ) ; 
                    __context__.SourceCodeLine = 2436;
                    INEXTYEAR = (ushort) ( (ISTARTYEAR + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2441;
                    INEXTMONTH = (ushort) ( (ISTARTMONTH + 1) ) ; 
                    __context__.SourceCodeLine = 2442;
                    INEXTDAY = (ushort) ( ((ISTARTDAY + IDAYS) - IDAYSINMONTH) ) ; 
                    __context__.SourceCodeLine = 2443;
                    INEXTYEAR = (ushort) ( ISTARTYEAR ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2448;
            SNEXTDAYDATE  .UpdateValue ( Functions.ItoA (  (int) ( INEXTYEAR ) )  ) ; 
            __context__.SourceCodeLine = 2450;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTMONTH < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2452;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + "0" + Functions.ItoA (  (int) ( INEXTMONTH ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2456;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + Functions.ItoA (  (int) ( INEXTMONTH ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2459;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTDAY < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2461;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + "0" + Functions.ItoA (  (int) ( INEXTDAY ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2465;
                SNEXTDAYDATE  .UpdateValue ( SNEXTDAYDATE + "-" + Functions.ItoA (  (int) ( INEXTDAY ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2468;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2470;
                Trace( "  NextDayDate:{0}\r\n", SNEXTDAYDATE ) ; 
                } 
            
            __context__.SourceCodeLine = 2473;
            return ( SNEXTDAYDATE ) ; 
            
            }
            
        private void GETISPRIVATE (  SplusExecutionContext __context__, CrestronString SMEETINGID ) 
            { 
            CrestronString SXML;
            SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            
            
            __context__.SourceCodeLine = 2492;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2494;
                Trace( "\r\n** GetIsPrivate **\r\n") ; 
                __context__.SourceCodeLine = 2495;
                Trace( "  sMeetingID:{0}\r\n", SMEETINGID ) ; 
                } 
            
            __context__.SourceCodeLine = 2498;
            SXML  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 2500;
            G_SISPRIVATEREQUESTID  .UpdateValue ( "IsPrivate" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 2502;
            SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SISPRIVATEREQUESTID + "</RequestID>" + "<MeetingID>" + SMEETINGID + "</MeetingID>" + "<FieldList>" + "<Field>MeetingID</Field>" + "<Field>IsPrivate</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
            __context__.SourceCodeLine = 2512;
            do 
                { 
                __context__.SourceCodeLine = 2515;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2517;
                    TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2521;
                    TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
            
            }
            
        private void GETSCHEDULE (  SplusExecutionContext __context__, ushort IREQUESTTYPE , CrestronString SSTARTDATE , CrestronString SSTARTTIME , CrestronString SHOURSPAN ) 
            { 
            CrestronString SXML;
            SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            
            
            __context__.SourceCodeLine = 2544;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2546;
                Trace( "\r\n** GetShcedule **\r\n") ; 
                __context__.SourceCodeLine = 2547;
                Trace( "  RequestType:{0:d}\r\n", (ushort)IREQUESTTYPE) ; 
                __context__.SourceCodeLine = 2548;
                Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
                __context__.SourceCodeLine = 2549;
                Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
                __context__.SourceCodeLine = 2550;
                Trace( "  HourSpan:{0}\r\n", SHOURSPAN ) ; 
                } 
            
            __context__.SourceCodeLine = 2554;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 2559;
                WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 2561;
                G_SSCHEDULEREQUESTID  .UpdateValue ( "Workday" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
                __context__.SourceCodeLine = 2563;
                SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SSCHEDULEREQUESTID + "</RequestID>" + "<Start>" + SSTARTDATE + "T" + SSTARTTIME + "</Start>" + "<HourSpan>" + SHOURSPAN + "</HourSpan>" + "<FieldList>" + "<Field>MeetingID</Field>" + "<Field>RVMeetingID</Field>" + "<Field>InstanceID</Field>" + "<Field>Recurring</Field>" + "<Field>dtStart</Field>" + "<Field>dtEnd</Field>" + "<Field>Subject</Field>" + "<Field>Organizer</Field>" + "<Field>IsPrivate</Field>" + "<Field>IsExchangePrivate</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2583;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2585;
                    AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 2587;
                    G_SAUTOUPDATEREQUESTID  .UpdateValue ( "AutoUpdate" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
                    __context__.SourceCodeLine = 2588;
                    G_SAUTOUPDATEREQUESTDATE  .UpdateValue ( SSTARTDATE  ) ; 
                    __context__.SourceCodeLine = 2590;
                    SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SAUTOUPDATEREQUESTID + "</RequestID>" + "<Start>" + SSTARTDATE + "T" + SSTARTTIME + "</Start>" + "<HourSpan>" + SHOURSPAN + "</HourSpan>" + "<FieldList>" + "<Field>MeetingID</Field>" + "<Field>RVMeetingID</Field>" + "<Field>InstanceID</Field>" + "<Field>Recurring</Field>" + "<Field>dtStart</Field>" + "<Field>dtEnd</Field>" + "<Field>Subject</Field>" + "<Field>Organizer</Field>" + "<Field>IsPrivate</Field>" + "<Field>IsExchangePrivate</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 2610;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2612;
                        NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 2614;
                        G_SNEXTRESERVREQUESTID  .UpdateValue ( "NextReserv" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
                        __context__.SourceCodeLine = 2616;
                        SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SNEXTRESERVREQUESTID + "</RequestID>" + "<Start>" + SSTARTDATE + "T" + SSTARTTIME + "</Start>" + "<HourSpan>" + SHOURSPAN + "</HourSpan>" + "<FieldList>" + "<Field>MeetingID</Field>" + "<Field>InstanceID</Field>" + "<Field>dtStart</Field>" + "<Field>dtEnd</Field>" + "<Field>Subject</Field>" + "<Field>Organizer</Field>" + "<Field>IsPrivate</Field>" + "<Field>IsExchangePrivate</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2633;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2635;
                            FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 2637;
                            G_SFIRSTAPPTREQUESTID  .UpdateValue ( "FirstAppt" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
                            __context__.SourceCodeLine = 2639;
                            SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SFIRSTAPPTREQUESTID + "</RequestID>" + "<Start>" + SSTARTDATE + "T" + SSTARTTIME + "</Start>" + "<HourSpan>" + SHOURSPAN + "</HourSpan>" + "<Action ID=\u0022RequestFirstAppt\u0022 />" + "<FieldList>" + "<Field>MeetingID</Field>" + "<Field>InstanceID</Field>" + "<Field>dtStart</Field>" + "<Field>dtEnd</Field>" + "<Field>Subject</Field>" + "<Field>Organizer</Field>" + "<Field>IsPrivate</Field>" + "<Field>IsExchangePrivate</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 2658;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2660;
                do 
                    { 
                    __context__.SourceCodeLine = 2663;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2665;
                        TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2669;
                        TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
                        } 
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
                } 
            
            
            }
            
        private void GETSCHEDULEDELAY (  SplusExecutionContext __context__ ) 
            { 
            ushort ISEED = 0;
            ushort IDELAY = 0;
            
            
            __context__.SourceCodeLine = 2693;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2695;
                Trace( "\r\n** GetScheduleDelay **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 2698;
            ISEED = (ushort) ( Functions.GetHSeconds() ) ; 
            __context__.SourceCodeLine = 2700;
            IDELAY = (ushort) ( ((Functions.Random( (ushort)( 0 ) , (ushort)( 10 ) ) * 60) * 100) ) ; 
            __context__.SourceCodeLine = 2702;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2704;
                Trace( "  iDelay:{0:d}\r\n", (ushort)IDELAY) ; 
                } 
            
            __context__.SourceCodeLine = 2707;
            CreateWait ( "GETSCHEDULEDELAYWAIT" , IDELAY , GETSCHEDULEDELAYWAIT_Callback ) ;
            
            }
            
        public void GETSCHEDULEDELAYWAIT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 2709;
            GETSCHEDULE (  __context__ , (ushort)( 1 ), G_SDATETODAY, "00:00:00", "24") ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void REGISTERPUSH (  SplusExecutionContext __context__, ushort BREGISTER ) 
        { 
        CrestronString SDATE;
        CrestronString STIME;
        CrestronString SSTART;
        SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
        SSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 19, this );
        
        
        __context__.SourceCodeLine = 2731;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2733;
            Trace( "\r\n** RegisterPush **\r\n") ; 
            __context__.SourceCodeLine = 2734;
            Trace( "  bRegister:{0:d}\r\n", (ushort)BREGISTER) ; 
            } 
        
        __context__.SourceCodeLine = 2737;
        REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2739;
        SDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
        __context__.SourceCodeLine = 2740;
        SDATE  .UpdateValue ( Functions.Left ( SDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( SDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SDATE ,  (int) ( 2 ) )  ) ; 
        __context__.SourceCodeLine = 2741;
        STIME  .UpdateValue ( Functions.Time ( )  ) ; 
        __context__.SourceCodeLine = 2743;
        SSTART  .UpdateValue ( SDATE + "T" + "00:00:00"  ) ; 
        __context__.SourceCodeLine = 2748;
        if ( Functions.TestForTrue  ( ( BREGISTER)  ) ) 
            { 
            __context__.SourceCodeLine = 2750;
            G_SACTIONPUSHREQUESTID  .UpdateValue ( "ActionRegisterPush" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 2751;
            G_SPUSHREQUESTID  .UpdateValue ( "Push" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 2753;
            G_SXML  .UpdateValue ( "<RequestAction>" + "<RequestID>" + G_SACTIONPUSHREQUESTID + "</RequestID>" + "<ActionID>RegisterPushModel</ActionID>" + "<Parameters>" + "<Parameter ID=\u0022Enabled\u0022 Value=\u00221\u0022 />" + "<Parameter ID=\u0022RequestID\u0022 Value=\u0022" + G_SPUSHREQUESTID + "\u0022 />" + "<Parameter ID=\u0022Start\u0022 Value=\u0022" + SSTART + "\u0022 />" + "<Parameter ID=\u0022HourSpan\u0022 Value=\u002224\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022MeetingID\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022RVMeetingID\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022InstanceID\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022Recurring\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022dtStart\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022dtEnd\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022Subject\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022Organizer\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022IsPrivate\u0022 />" + "<Parameter ID=\u0022Field\u0022 Value=\u0022IsExchangePrivate\u0022 />" + "</Parameters>" + "</RequestAction>"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2777;
            G_SACTIONPUSHREQUESTID  .UpdateValue ( "ActionUnRegisterPush" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 2778;
            G_SPUSHREQUESTID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 2780;
            G_SXML  .UpdateValue ( "<RequestAction>" + "<RequestID>" + G_SACTIONPUSHREQUESTID + "</RequestID>" + "<ActionID>RegisterPushModel</ActionID>" + "<Parameters>" + "<Parameter ID=\u0022Enabled\u0022 Value=\u00220\u0022 />" + "<Parameter ID=\u0022RequestID\u0022 Value=\u0022DUMMY\u0022 />" + "<Parameter ID=\u0022Start\u0022 Value=\u0022" + SSTART + "\u0022 />" + "<Parameter ID=\u0022HourSpan\u0022 Value=\u00220\u0022 />" + "</Parameters>" + "</RequestAction>"  ) ; 
            } 
        
        __context__.SourceCodeLine = 2795;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SXML ) > 240 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2797;
            do 
                { 
                __context__.SourceCodeLine = 2800;
                if ( Functions.TestForTrue  ( ( Functions.Not( G_BWAITINGTOSENDRVDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2802;
                    G_BWAITINGTOSENDRVDATA = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 2804;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SXML ) > 240 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2806;
                        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_3__" , SERIAL_PACING_TIME  .UshortValue , __SPLS_TMPVAR__WAITLABEL_3___Callback ) ;
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2814;
                        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_4__" , SERIAL_PACING_TIME  .UshortValue , __SPLS_TMPVAR__WAITLABEL_4___Callback ) ;
                        } 
                    
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( G_SXML ) == 0)) )); 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2834;
            TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( G_SXML  ) ; 
            } 
        
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_3___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 2808;
            TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, G_SXML )  ) ; 
            __context__.SourceCodeLine = 2809;
            G_BWAITINGTOSENDRVDATA = (ushort) ( 0 ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
public void __SPLS_TMPVAR__WAITLABEL_4___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 2820;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SXML ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2822;
                TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( G_SXML ), G_SXML )  ) ; 
                } 
            
            __context__.SourceCodeLine = 2825;
            G_BWAITINGTOSENDRVDATA = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private ushort NEXTRESERVATION (  SplusExecutionContext __context__, ushort BENABLEREQUESTNEXTRESERV ) 
    { 
    ushort BDATEVALID = 0;
    
    ushort I = 0;
    ushort IEVENTNUM = 0;
    ushort INEXTEVENT = 0;
    ushort IEVENTSTARTTIME = 0;
    ushort IEVENTENDTIME = 0;
    
    CrestronString SREQUESTTIME;
    CrestronString SNEXTRESERVATIONIN;
    SREQUESTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    SNEXTRESERVATIONIN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    
    
    __context__.SourceCodeLine = 2864;
    IEVENTNUM = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 2865;
    INEXTEVENT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 2866;
    BDATEVALID = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 2868;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 2870;
        Trace( "\r\n** NextReservation **\r\n") ; 
        __context__.SourceCodeLine = 2871;
        Trace( "  AllowRequestNextReserv:{0:d}\r\n", (ushort)BENABLEREQUESTNEXTRESERV) ; 
        } 
    
    __context__.SourceCodeLine = 2876;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTOREDEVENTCOUNT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 2878;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2880;
            Trace( "  Events are stored.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 2884;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTNUM > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2888;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2889;
                Trace( "  Using started event.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 2892;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ G_ISTARTEDEVENTNUM ].ENDDATE == G_SDATETODAY))  ) ) 
                { 
                __context__.SourceCodeLine = 2896;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 2897;
                    Trace( "  Event ends today. Checking meeting end time against current time.\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 2900;
                IEVENTENDTIME = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ G_ISTARTEDEVENTNUM ].ENDTIME , (ushort)( 1 ) ) ) ; 
                __context__.SourceCodeLine = 2902;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2904;
                    Trace( "  iEventEndTime:{0:d}\r\n", (ushort)IEVENTENDTIME) ; 
                    __context__.SourceCodeLine = 2905;
                    Trace( "  g_iCurrentTime:{0:d}\r\n", (ushort)G_ICURRENTTIME) ; 
                    } 
                
                __context__.SourceCodeLine = 2910;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIME >= IEVENTENDTIME ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2914;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2915;
                        Trace( "  Event has already ended. Use current event num.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2917;
                    IEVENTNUM = (ushort) ( G_ICURRENTEVENTNUM ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2923;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2924;
                        Trace( "  Event has not ended. Use it.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2926;
                    IEVENTNUM = (ushort) ( G_ISTARTEDEVENTNUM ) ; 
                    } 
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2930;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2934;
                IEVENTNUM = (ushort) ( G_ICURRENTEVENTNUM ) ; 
                __context__.SourceCodeLine = 2936;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 2937;
                    Trace( "  Using current event.\r\n") ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2941;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 2942;
                    Trace( "  No event started or current.\r\n") ; 
                    }
                
                } 
            
            }
        
        __context__.SourceCodeLine = 2946;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTNUM > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2950;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2952;
                Trace( "    Have Event:{0:d}\r\n", (ushort)IEVENTNUM) ; 
                __context__.SourceCodeLine = 2953;
                Trace( "    Event StartDate:{0}\r\n", MEETINGEVENT [ IEVENTNUM] . STARTDATE ) ; 
                __context__.SourceCodeLine = 2954;
                Trace( "    Event StartTime:{0}\r\n", MEETINGEVENT [ IEVENTNUM] . STARTTIME ) ; 
                } 
            
            __context__.SourceCodeLine = 2958;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTNUM < G_ISTOREDEVENTCOUNT ))  ) ) 
                { 
                __context__.SourceCodeLine = 2962;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2964;
                    Trace( "  Looking at next event after active.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 2967;
                INEXTEVENT = (ushort) ( (IEVENTNUM + 1) ) ; 
                __context__.SourceCodeLine = 2969;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2971;
                    Trace( "    iNextEvent:{0:d}\r\n", (ushort)INEXTEVENT) ; 
                    __context__.SourceCodeLine = 2972;
                    Trace( "    NextEvent StartDate:{0}\r\n", MEETINGEVENT [ INEXTEVENT] . STARTDATE ) ; 
                    __context__.SourceCodeLine = 2973;
                    Trace( "    NextEvent StartTime:{0}\r\n", MEETINGEVENT [ INEXTEVENT] . STARTTIME ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2980;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2982;
                    Trace( "  No events left after active.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 2986;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ IEVENTNUM ].ENDDATE == G_SDATETODAY))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2990;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 2991;
                        Trace( "    Current event ends today.\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 2994;
                    G_SNEXTRESERVREQUESTDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , G_SDATETODAY, "1")  ) ; 
                    __context__.SourceCodeLine = 2997;
                    SREQUESTTIME  .UpdateValue ( "00:00:00"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 3003;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 3004;
                        Trace( "    Current event does not end today\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 3007;
                    G_SNEXTRESERVREQUESTDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDDATE, "1")  ) ; 
                    __context__.SourceCodeLine = 3010;
                    SREQUESTTIME  .UpdateValue ( NEXTTIMEMIN (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDTIME)  ) ; 
                    } 
                
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3018;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 3019;
                Trace( "    No current event. Looking ...\r\n") ; 
                }
            
            __context__.SourceCodeLine = 3022;
            G_SNEXTRESERVREQUESTDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , G_SDATETODAY, "1")  ) ; 
            __context__.SourceCodeLine = 3025;
            SREQUESTTIME  .UpdateValue ( "00:00:00"  ) ; 
            __context__.SourceCodeLine = 3027;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 3029;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ I ].STARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ I ].ENDDATE) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3032;
                    BDATEVALID = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 3034;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == MEETINGEVENT[ I ].STARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) < DATETOINTEGER( __context__ , MEETINGEVENT[ I ].ENDDATE ) ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3037;
                        BDATEVALID = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 3041;
                if ( Functions.TestForTrue  ( ( BDATEVALID)  ) ) 
                    { 
                    __context__.SourceCodeLine = 3044;
                    IEVENTSTARTTIME = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ I ].STARTTIME , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 3046;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTSTARTTIME > G_ICURRENTTIME ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3048;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 3050;
                            Trace( "    Found Next Event:{0:d}\r\n", (ushort)I) ; 
                            __context__.SourceCodeLine = 3051;
                            Trace( "    NextEvent StartDate:{0}\r\n", MEETINGEVENT [ I] . STARTDATE ) ; 
                            __context__.SourceCodeLine = 3052;
                            Trace( "    NextEvent StartTime:{0}\r\n", MEETINGEVENT [ I] . STARTTIME ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 3055;
                        INEXTEVENT = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 3056;
                        break ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 3027;
                } 
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 3069;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 3071;
            Trace( "  No events stored.\r\n") ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 3077;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTEVENT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 3082;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 3084;
            Trace( "  Next event found:{0:d}. Updating output.\r\n", (ushort)INEXTEVENT) ; 
            __context__.SourceCodeLine = 3085;
            Trace( "    NextEvent StartDate:{0}\r\n", MEETINGEVENT [ INEXTEVENT] . STARTDATE ) ; 
            __context__.SourceCodeLine = 3086;
            Trace( "    NextEvent StartTime:{0}\r\n", MEETINGEVENT [ INEXTEVENT] . STARTTIME ) ; 
            } 
        
        __context__.SourceCodeLine = 3089;
        NEXTEVENT . MEETINGID  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . MEETINGID  ) ; 
        __context__.SourceCodeLine = 3090;
        NEXTEVENT . INSTANCEID  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . INSTANCEID  ) ; 
        __context__.SourceCodeLine = 3091;
        NEXTEVENT . STARTDATE  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . STARTDATE  ) ; 
        __context__.SourceCodeLine = 3092;
        NEXTEVENT . STARTTIME  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . STARTTIME  ) ; 
        __context__.SourceCodeLine = 3093;
        NEXTEVENT . ENDDATE  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . ENDDATE  ) ; 
        __context__.SourceCodeLine = 3094;
        NEXTEVENT . ENDTIME  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . ENDTIME  ) ; 
        __context__.SourceCodeLine = 3095;
        NEXTEVENT . ORGANIZER  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . ORGANIZER  ) ; 
        __context__.SourceCodeLine = 3096;
        NEXTEVENT . SUBJECT  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . SUBJECT  ) ; 
        __context__.SourceCodeLine = 3097;
        NEXTEVENT . ISPRIVATE = (ushort) ( MEETINGEVENT[ INEXTEVENT ].ISPRIVATE ) ; 
        __context__.SourceCodeLine = 3098;
        NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( MEETINGEVENT[ INEXTEVENT ].ISEXCHANGEPRIVATE ) ; 
        __context__.SourceCodeLine = 3100;
        NEXT_RESERVATION_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , MEETINGEVENT[ INEXTEVENT ].STARTDATE, (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 3101;
        NEXT_RESERVATION_HRMIN__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , MEETINGEVENT[ INEXTEVENT ].STARTTIME)  ) ; 
        __context__.SourceCodeLine = 3104;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEXTEVENT.STARTDATE != G_SDATETODAY))  ) ) 
            {
            __context__.SourceCodeLine = 3105;
            NEXT_RESERVATION_DATETIME__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , MEETINGEVENT[ INEXTEVENT ].STARTDATE, (ushort)( 2 )) + " " + FORMATTIME (  __context__ , MEETINGEVENT[ INEXTEVENT ].STARTTIME)  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 3107;
            NEXT_RESERVATION_DATETIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , MEETINGEVENT[ INEXTEVENT ].STARTTIME)  ) ; 
            }
        
        __context__.SourceCodeLine = 3109;
        SNEXTRESERVATIONIN  .UpdateValue ( TIMEDIFF (  __context__ , (ushort)( 1 ), G_SDATETODAY, G_SCURRENTTIME, MEETINGEVENT[ INEXTEVENT ].STARTDATE, MEETINGEVENT[ INEXTEVENT ].STARTTIME)  ) ; 
        __context__.SourceCodeLine = 3110;
        NEXT_RESERVATION_IN__DOLLAR__  .UpdateValue ( FORMATTIMEDIFF (  __context__ , SNEXTRESERVATIONIN)  ) ; 
        __context__.SourceCodeLine = 3112;
        SENDFREEBUSYATTRIBUTEDATA (  __context__ , MEETINGEVENT[ INEXTEVENT ].STARTDATE, MEETINGEVENT[ INEXTEVENT ].STARTTIME) ; 
        __context__.SourceCodeLine = 3114;
        HAVE_NEXT_RESERVATION  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 3117;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( NEXTEVENT.ISPRIVATE ) || Functions.TestForTrue ( NEXTEVENT.ISEXCHANGEPRIVATE )) ))  ) ) 
            {
            __context__.SourceCodeLine = 3118;
            NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 3120;
            NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 3123;
        if ( Functions.TestForTrue  ( ( G_BPUSHENABLED)  ) ) 
            { 
            __context__.SourceCodeLine = 3129;
            G_BNEEDFIRSTAPPTREQUEST = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 3132;
        return (ushort)( INEXTEVENT) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 3138;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 3140;
            Trace( "  Next event was not found.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 3145;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( G_BPUSHENABLED ) ) && Functions.TestForTrue ( BENABLEREQUESTNEXTRESERV )) ))  ) ) 
            {
            __context__.SourceCodeLine = 3146;
            NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
            }
        
        __context__.SourceCodeLine = 3149;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.MEETINGID ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 3153;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 3155;
                Trace( "  Have stored next event. Updating outputs\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 3158;
            NEXT_RESERVATION_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , NEXTEVENT.STARTDATE, (ushort)( 2 ))  ) ; 
            __context__.SourceCodeLine = 3159;
            NEXT_RESERVATION_HRMIN__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , NEXTEVENT.STARTTIME)  ) ; 
            __context__.SourceCodeLine = 3162;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEXTEVENT.STARTDATE != G_SDATETODAY))  ) ) 
                {
                __context__.SourceCodeLine = 3163;
                NEXT_RESERVATION_DATETIME__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , NEXTEVENT.STARTDATE, (ushort)( 2 )) + " " + FORMATTIME (  __context__ , NEXTEVENT.STARTTIME)  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 3165;
                NEXT_RESERVATION_DATETIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , NEXTEVENT.STARTTIME)  ) ; 
                }
            
            __context__.SourceCodeLine = 3167;
            SENDFREEBUSYATTRIBUTEDATA (  __context__ , NEXTEVENT.STARTDATE, NEXTEVENT.STARTTIME) ; 
            __context__.SourceCodeLine = 3169;
            SNEXTRESERVATIONIN  .UpdateValue ( TIMEDIFF (  __context__ , (ushort)( 1 ), G_SDATETODAY, G_SCURRENTTIME, NEXTEVENT.STARTDATE, NEXTEVENT.STARTTIME)  ) ; 
            __context__.SourceCodeLine = 3170;
            NEXT_RESERVATION_IN__DOLLAR__  .UpdateValue ( FORMATTIMEDIFF (  __context__ , SNEXTRESERVATIONIN)  ) ; 
            __context__.SourceCodeLine = 3172;
            HAVE_NEXT_RESERVATION  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 3175;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( NEXTEVENT.ISPRIVATE ) || Functions.TestForTrue ( NEXTEVENT.ISEXCHANGEPRIVATE )) ))  ) ) 
                {
                __context__.SourceCodeLine = 3176;
                NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 3178;
                NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 0 ) ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3184;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 3186;
                Trace( "  Do not have stored next event.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 3190;
            G_SNEXTRESERVREQUESTDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , G_SDATETODAY, "1")  ) ; 
            __context__.SourceCodeLine = 3193;
            SREQUESTTIME  .UpdateValue ( "00:00:00"  ) ; 
            __context__.SourceCodeLine = 3196;
            NEXT_RESERVATION_DATE__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3197;
            NEXT_RESERVATION_HRMIN__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3198;
            NEXT_RESERVATION_DATETIME__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3201;
            SENDFREEBUSYATTRIBUTEDATA (  __context__ , NEXTDAYDATE( __context__ , G_SDATETODAY , "4" ), "00:00:00") ; 
            __context__.SourceCodeLine = 3203;
            HAVE_NEXT_RESERVATION  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 3204;
            NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 3207;
            if ( Functions.TestForTrue  ( ( G_BPUSHENABLED)  ) ) 
                { 
                __context__.SourceCodeLine = 3211;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 3213;
                    Trace( "  Push enabled\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 3217;
                if ( Functions.TestForTrue  ( ( G_BNEEDFIRSTAPPTREQUEST)  ) ) 
                    { 
                    __context__.SourceCodeLine = 3219;
                    G_BNEEDFIRSTAPPTREQUEST = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3221;
                    GETSCHEDULE (  __context__ , (ushort)( 4 ), G_SNEXTRESERVREQUESTDATE, SREQUESTTIME, "72") ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 3228;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 3230;
                    Trace( "  Push not enabled\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 3234;
                if ( Functions.TestForTrue  ( ( BENABLEREQUESTNEXTRESERV)  ) ) 
                    { 
                    __context__.SourceCodeLine = 3238;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 3240;
                        Trace( "  Need NextReserv request.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 3243;
                    GETSCHEDULE (  __context__ , (ushort)( 3 ), G_SNEXTRESERVREQUESTDATE, SREQUESTTIME, "72") ; 
                    } 
                
                } 
            
            } 
        
        __context__.SourceCodeLine = 3248;
        return (ushort)( 0) ; 
        } 
    
    
    return 0; // default return value (none specified in module)
    }
    
private void SENDNOSHOWDATA (  SplusExecutionContext __context__, ushort TYPE , ushort INDEX ) 
    { 
    ushort BSEND = 0;
    
    CrestronString STEMP;
    CrestronString SRECURRING;
    CrestronString SSTATUS;
    CrestronString SDATE;
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    SRECURRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SSTATUS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    
    __context__.SourceCodeLine = 3273;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 3275;
        Trace( "\r\n** SendNoShowData **\r\n") ; 
        __context__.SourceCodeLine = 3276;
        Trace( "    Index:{0:d}\r\n", (ushort)INDEX) ; 
        } 
    
    __context__.SourceCodeLine = 3279;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 3284;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SLASTSENTNOSHOWID != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 3286;
            TO_NOSHOW_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<NoShowData></NoShowData>"  ) ; 
            __context__.SourceCodeLine = 3288;
            G_SLASTSENTNOSHOWID  .UpdateValue ( ""  ) ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 3293;
        BSEND = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3294;
        SDATE  .UpdateValue ( Functions.Date (  (int) ( 1 ) )  ) ; 
        __context__.SourceCodeLine = 3296;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 3298;
            SSTATUS  .UpdateValue ( "NoShow"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3302;
            SSTATUS  .UpdateValue ( "Show"  ) ; 
            } 
        
        __context__.SourceCodeLine = 3306;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 3307;
            Trace( "    Type:{0}\r\n", SSTATUS ) ; 
            }
        
        __context__.SourceCodeLine = 3312;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ INDEX ].MEETINGID != G_SLASTSENTNOSHOWID))  ) ) 
            { 
            __context__.SourceCodeLine = 3316;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 3317;
                Trace( "    Have not sent this ID yet\r\n") ; 
                }
            
            __context__.SourceCodeLine = 3319;
            BSEND = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3326;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDATE != G_SLASTSENTNOSHOWDATE))  ) ) 
                { 
                __context__.SourceCodeLine = 3330;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 3331;
                    Trace( "    Already sent this ID, but on different date\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 3333;
                BSEND = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 3337;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 3338;
                    Trace( "    Already sent this ID AND on same date\r\n") ; 
                    }
                
                } 
            
            } 
        
        __context__.SourceCodeLine = 3344;
        if ( Functions.TestForTrue  ( ( BSEND)  ) ) 
            { 
            __context__.SourceCodeLine = 3346;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 3347;
                Trace( "    Sending data\r\n") ; 
                }
            
            __context__.SourceCodeLine = 3350;
            G_SLASTSENTNOSHOWID  .UpdateValue ( MEETINGEVENT [ INDEX] . MEETINGID  ) ; 
            __context__.SourceCodeLine = 3351;
            G_SLASTSENTNOSHOWDATE  .UpdateValue ( Functions.Date (  (int) ( 1 ) )  ) ; 
            __context__.SourceCodeLine = 3355;
            if ( Functions.TestForTrue  ( ( MEETINGEVENT[ INDEX ].RECURRING)  ) ) 
                { 
                __context__.SourceCodeLine = 3357;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 3358;
                    Trace( "    Meeting type is Recurring\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 3360;
                STEMP  .UpdateValue ( "<NoShowData>" + "<Status>" + SSTATUS + "</Status>" + "<Subject>" + MEETINGEVENT [ INDEX] . SUBJECT + "</Subject>" + "<MeetingID>" + MEETINGEVENT [ INDEX] . MEETINGID + "</MeetingID>" + "<RVMeetingID>" + MEETINGEVENT [ INDEX] . RVMEETINGID + "</RVMeetingID>" + "<Recurring>True</Recurring>" + "</NoShowData>"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 3372;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 3373;
                    Trace( "    Meeting type is Single\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 3375;
                STEMP  .UpdateValue ( "<NoShowData>" + "<Status>" + SSTATUS + "</Status>" + "<Subject>" + MEETINGEVENT [ INDEX] . SUBJECT + "</Subject>" + "<MeetingID>" + MEETINGEVENT [ INDEX] . MEETINGID + "</MeetingID>" + "<RVMeetingID>" + MEETINGEVENT [ INDEX] . RVMEETINGID + "</RVMeetingID>" + "<Recurring>False</Recurring>" + "</NoShowData>"  ) ; 
                } 
            
            __context__.SourceCodeLine = 3384;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 3386;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3388;
                    TO_NOSHOW_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( 240 ) )  ) ; 
                    __context__.SourceCodeLine = 3389;
                    TO_NOSHOW_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Right ( STEMP ,  (int) ( (Functions.Length( STEMP ) - 240) ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 3392;
                    TO_NOSHOW_MOD_DATAIN__DOLLAR__  .UpdateValue ( STEMP  ) ; 
                    }
                
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3397;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 3398;
                Trace( "    Not sending data\r\n") ; 
                }
            
            } 
        
        } 
    
    
    }
    
private void CHECKNOSHOW (  SplusExecutionContext __context__ ) 
    { 
    ushort IEVENTINDEX = 0;
    ushort IEVENTENDTIMEMIN = 0;
    
    ushort IDURATIONMINUTES = 0;
    ushort IELAPSEDMINUTES = 0;
    ushort IELAPSEDPERCENT = 0;
    
    
    __context__.SourceCodeLine = 3422;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 3423;
        Trace( "\r\n** CheckNoShow **\r\n") ; 
        }
    
    __context__.SourceCodeLine = 3425;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 3427;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 3428;
            Trace( "    Current event num > 0.\r\n") ; 
            }
        
        __context__.SourceCodeLine = 3430;
        IEVENTINDEX = (ushort) ( G_ICURRENTEVENTNUM ) ; 
        __context__.SourceCodeLine = 3432;
        IDURATIONMINUTES = (ushort) ( DURATIONMIN( __context__ ) ) ; 
        __context__.SourceCodeLine = 3433;
        IELAPSEDMINUTES = (ushort) ( ELAPSEDTIMEMIN( __context__ ) ) ; 
        __context__.SourceCodeLine = 3434;
        IELAPSEDPERCENT = (ushort) ( ((IELAPSEDMINUTES * 100) / IDURATIONMINUTES) ) ; 
        __context__.SourceCodeLine = 3437;
        CURRENT_MEETING_DURATION_MIN  .Value = (ushort) ( IDURATIONMINUTES ) ; 
        __context__.SourceCodeLine = 3438;
        CURRENT_MEETING_ELAPSED_TIME  .Value = (ushort) ( IELAPSEDMINUTES ) ; 
        __context__.SourceCodeLine = 3439;
        CURRENT_MEETING_ELAPSED_PERCENT  .Value = (ushort) ( IELAPSEDPERCENT ) ; 
        __context__.SourceCodeLine = 3442;
        if ( Functions.TestForTrue  ( ( CONFIG_EN_DECLINE_FOR_NOSHOW  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 3445;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 3446;
                Trace( "    Config enable decline for no show.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 3449;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDURATIONMINUTES <= DECLINE_APPLIES_DURATION  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 3453;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 3454;
                    Trace( "    Meeting meets minimum\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 3457;
                IEVENTENDTIMEMIN = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ IEVENTINDEX ].ENDTIME , (ushort)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 3459;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 3461;
                    Trace( "    Date today:{0}\r\n", G_SDATETODAY ) ; 
                    __context__.SourceCodeLine = 3462;
                    Trace( "    Event end date:{0}\r\n", MEETINGEVENT [ IEVENTINDEX] . ENDDATE ) ; 
                    __context__.SourceCodeLine = 3463;
                    Trace( "    Current time min:{0:d}\r\n", (ushort)G_ICURRENTTIMEMIN) ; 
                    __context__.SourceCodeLine = 3464;
                    Trace( "    Event end timemin:{0:d}\r\n", (ushort)IEVENTENDTIMEMIN) ; 
                    } 
                
                __context__.SourceCodeLine = 3468;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (MEETINGEVENT[ IEVENTINDEX ].ENDDATE == G_SDATETODAY) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_ICURRENTTIMEMIN < IEVENTENDTIMEMIN ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , MEETINGEVENT[ IEVENTINDEX ].ENDDATE ) > DATETOINTEGER( __context__ , G_SDATETODAY ) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3473;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 3474;
                        Trace( "    Meeting not over\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 3477;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ISTARTEDEVENTNUM == IEVENTINDEX))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3480;
                        SENDNOSHOWDATA (  __context__ , (ushort)( 2 ), (ushort)( IEVENTINDEX )) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 3482;
                        if ( Functions.TestForTrue  ( ( G_BSTARTMEETINGCONFIRMED)  ) ) 
                            { 
                            __context__.SourceCodeLine = 3485;
                            SENDNOSHOWDATA (  __context__ , (ushort)( 2 ), (ushort)( IEVENTINDEX )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 3492;
                            if ( Functions.TestForTrue  ( ( ROOM_OCCUPIED_FB  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 3494;
                                if ( Functions.TestForTrue  ( ( Functions.Not( CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN  .Value ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 3497;
                                    SENDNOSHOWDATA (  __context__ , (ushort)( 2 ), (ushort)( IEVENTINDEX )) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 3502;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IELAPSEDMINUTES == DECLINE_MEETING_MIN  .UshortValue))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 3505;
                                        SENDNOSHOWDATA (  __context__ , (ushort)( 2 ), (ushort)( IEVENTINDEX )) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 3510;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 3512;
                                            Trace( "\r** Decline For No Show Unsure **\r") ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 3522;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DECLINE_MEETING_MIN  .UshortValue > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 3526;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 3527;
                                        Trace( "    Using minutes. Current:{0:d}\r\n", (ushort)IELAPSEDMINUTES) ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 3531;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IELAPSEDMINUTES >= DECLINE_MEETING_MIN  .UshortValue ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 3535;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 3536;
                                            Trace( "    Minutes reached. No Show!\r\n") ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 3538;
                                        SENDNOSHOWDATA (  __context__ , (ushort)( 1 ), (ushort)( IEVENTINDEX )) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 3545;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 3546;
                                        Trace( "    Using percent. Current:{0:d}\r\n", (ushort)IELAPSEDPERCENT) ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 3549;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IELAPSEDPERCENT >= DECLINE_MEETING_PERCENT  .UshortValue ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 3553;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 3554;
                                            Trace( "    Percent reached. No show!\r\n") ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 3556;
                                        SENDNOSHOWDATA (  __context__ , (ushort)( 1 ), (ushort)( IEVENTINDEX )) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 3566;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 3567;
                        Trace( "    Meeting is over\r\n") ; 
                        }
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 3574;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 3575;
                    Trace( "    Meeting Does Not Meet Minimum") ; 
                    }
                
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3582;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 3583;
                Trace( "    Config disable decline for no show.\r\n") ; 
                }
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 3592;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 3593;
            Trace( "    Current event num = 0.\r\n") ; 
            }
        
        __context__.SourceCodeLine = 3595;
        SENDNOSHOWDATA (  __context__ , (ushort)( 0 ), (ushort)( 0 )) ; 
        } 
    
    
    }
    
private void SETDATETIMEVARS (  SplusExecutionContext __context__ ) 
    { 
    CrestronString SDATE;
    SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    ushort IMINUTEBLOCK = 0;
    
    
    __context__.SourceCodeLine = 3616;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 3617;
        Trace( "\r\n** SetDateTimeVars **\r\n") ; 
        }
    
    __context__.SourceCodeLine = 3622;
    SDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
    __context__.SourceCodeLine = 3624;
    G_SDATETODAY  .UpdateValue ( Functions.Left ( SDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( SDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SDATE ,  (int) ( 2 ) )  ) ; 
    __context__.SourceCodeLine = 3628;
    G_SCURRENTTIME  .UpdateValue ( Functions.Time ( )  ) ; 
    __context__.SourceCodeLine = 3629;
    G_SCURRENTTIME  .UpdateValue ( Functions.Left ( G_SCURRENTTIME ,  (int) ( 5 ) )  ) ; 
    __context__.SourceCodeLine = 3631;
    G_ICURRENTHOUR = (ushort) ( Functions.GetHourNum() ) ; 
    __context__.SourceCodeLine = 3632;
    G_ICURRENTMINUTE = (ushort) ( Functions.GetMinutesNum() ) ; 
    __context__.SourceCodeLine = 3633;
    G_ICURRENTTIME = (ushort) ( ((G_ICURRENTHOUR * 100) + G_ICURRENTMINUTE) ) ; 
    __context__.SourceCodeLine = 3636;
    G_ICURRENTTIMEMIN = (ushort) ( ((G_ICURRENTHOUR * 60) + G_ICURRENTMINUTE) ) ; 
    __context__.SourceCodeLine = 3639;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTMINUTE < 30 ))  ) ) 
        {
        __context__.SourceCodeLine = 3640;
        IMINUTEBLOCK = (ushort) ( 0 ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 3642;
        IMINUTEBLOCK = (ushort) ( 1 ) ; 
        }
    
    __context__.SourceCodeLine = 3645;
    G_ICURRENTTIMEBLOCK = (ushort) ( (((G_ICURRENTHOUR * 2) + IMINUTEBLOCK) + 1) ) ; 
    __context__.SourceCodeLine = 3648;
    CURRENT_TIME__DOLLAR__  .UpdateValue ( LOCALTIME (  __context__  )  ) ; 
    __context__.SourceCodeLine = 3649;
    CURRENT_TIME_HOUR  .Value = (ushort) ( G_ICURRENTHOUR ) ; 
    __context__.SourceCodeLine = 3650;
    CURRENT_TIME_MINUTE  .Value = (ushort) ( G_ICURRENTMINUTE ) ; 
    __context__.SourceCodeLine = 3651;
    CURRENT_DATE__DOLLAR__  .UpdateValue ( Functions.Date (  (int) ( (DATE_FORMAT  .UshortValue + 1) ) )  ) ; 
    
    }
    
private ushort EVENTINDEX (  SplusExecutionContext __context__, ushort ITYPE , ushort IIDTYPE , CrestronString SID ) 
    { 
    ushort I = 0;
    ushort IINDEX = 0;
    
    
    __context__.SourceCodeLine = 3671;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 3673;
        Trace( "\r\n** EventIndex **\r\n") ; 
        __context__.SourceCodeLine = 3674;
        Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
        __context__.SourceCodeLine = 3675;
        Trace( "  IDType:{0:d}\r\n", (ushort)IIDTYPE) ; 
        __context__.SourceCodeLine = 3676;
        Trace( "  ID:{0}\r\n", SID ) ; 
        } 
    
    __context__.SourceCodeLine = 3679;
    IINDEX = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 3681;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 3684;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTOREDEVENTCOUNT > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 3686;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 3688;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIDTYPE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3690;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ I ].MEETINGID == SID))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3692;
                        IINDEX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 3694;
                        break ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 3697;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIDTYPE == 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3699;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ I ].INSTANCEID == SID))  ) ) 
                            { 
                            __context__.SourceCodeLine = 3701;
                            IINDEX = (ushort) ( I ) ; 
                            __context__.SourceCodeLine = 3703;
                            break ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 3686;
                } 
            
            } 
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 3709;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 3712;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IAUTOUPDATESTOREDEVENTCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 3714;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)G_IAUTOUPDATESTOREDEVENTCOUNT; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 3716;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIDTYPE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3718;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AUTOUPDATEMEETINGEVENT[ I ].MEETINGID == SID))  ) ) 
                            { 
                            __context__.SourceCodeLine = 3720;
                            IINDEX = (ushort) ( I ) ; 
                            __context__.SourceCodeLine = 3722;
                            break ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 3725;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIDTYPE == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 3727;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AUTOUPDATEMEETINGEVENT[ I ].INSTANCEID == SID))  ) ) 
                                { 
                                __context__.SourceCodeLine = 3729;
                                IINDEX = (ushort) ( I ) ; 
                                __context__.SourceCodeLine = 3731;
                                break ; 
                                } 
                            
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 3714;
                    } 
                
                } 
            
            } 
        
        }
    
    __context__.SourceCodeLine = 3738;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 3740;
        Trace( "  Index:{0:d}\r\n", (ushort)IINDEX) ; 
        } 
    
    __context__.SourceCodeLine = 3743;
    return (ushort)( IINDEX) ; 
    
    }
    
private void UPDATENEXTRESERVINFO (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 3760;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 3761;
        Trace( "\r\n** UpdateNextReservInfo **\r\n") ; 
        }
    
    __context__.SourceCodeLine = 3764;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.MEETINGID ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 3768;
        NEXT_RESERVATION_SUBJECT__DOLLAR__  .UpdateValue ( NEXTEVENT . SUBJECT  ) ; 
        __context__.SourceCodeLine = 3769;
        NEXT_RESERVATION_START_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , NEXTEVENT.STARTDATE, (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 3770;
        NEXT_RESERVATION_START_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , NEXTEVENT.STARTTIME)  ) ; 
        __context__.SourceCodeLine = 3771;
        NEXT_RESERVATION_END_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , NEXTEVENT.ENDDATE, (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 3772;
        NEXT_RESERVATION_END_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , NEXTEVENT.ENDTIME)  ) ; 
        __context__.SourceCodeLine = 3775;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( NEXTEVENT.ORGANIZER ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 3776;
            NEXT_RESERVATION_ORGANIZER__DOLLAR__  .UpdateValue ( "Unknown"  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 3778;
            NEXT_RESERVATION_ORGANIZER__DOLLAR__  .UpdateValue ( NEXTEVENT . ORGANIZER  ) ; 
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 3782;
        NEXT_RESERVATION_ORGANIZER__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3783;
        NEXT_RESERVATION_SUBJECT__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3784;
        NEXT_RESERVATION_START_DATE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3785;
        NEXT_RESERVATION_START_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3786;
        NEXT_RESERVATION_END_DATE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3787;
        NEXT_RESERVATION_END_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        } 
    
    
    }
    
private void GETMEETINGINFO (  SplusExecutionContext __context__, ushort ITYPE , ushort IREQUESTTYPE , CrestronString SMEETINGID ) 
    { 
    CrestronString SXML;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 3807;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 3809;
        Trace( "\r\n** GetMeetingInfo **\r\n") ; 
        __context__.SourceCodeLine = 3810;
        Trace( "  iType:{0:d}\r\n", (ushort)ITYPE) ; 
        __context__.SourceCodeLine = 3811;
        Trace( "  iRequestType:{0:d}\r\n", (ushort)IREQUESTTYPE) ; 
        __context__.SourceCodeLine = 3812;
        Trace( "  sMeetingID:{0}\r\n", SMEETINGID ) ; 
        } 
    
    __context__.SourceCodeLine = 3815;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
        { 
        __context__.SourceCodeLine = 3819;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 3823;
            CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 3825;
            G_SCURRENTMEETINGINFOREQUESTID  .UpdateValue ( "CurrentInfoAttendees" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 3827;
            CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( "Requesting data ..."  ) ; 
            __context__.SourceCodeLine = 3828;
            CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( "Requesting data ..."  ) ; 
            __context__.SourceCodeLine = 3830;
            SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SCURRENTMEETINGINFOREQUESTID + "</RequestID>" + "<MeetingID>" + SMEETINGID + "</MeetingID>" + "<FieldList>" + "<Field>Attendees</Field>" + "<Field>Resources</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 3840;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 3844;
                G_SCURRENTMEETINGPRESETDATAREQUESTID  .UpdateValue ( "CurrentInfoPresetData" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
                __context__.SourceCodeLine = 3846;
                SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SCURRENTMEETINGPRESETDATAREQUESTID + "</RequestID>" + "<MeetingID>" + SMEETINGID + "</MeetingID>" + "<FieldList>" + "<Field>MeetingPresets</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
                } 
            
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 3856;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 2))  ) ) 
            { 
            __context__.SourceCodeLine = 3860;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IREQUESTTYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 3864;
                NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 3866;
                G_SNEXTMEETINGINFOREQUESTID  .UpdateValue ( "NextInfoAttendees" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
                __context__.SourceCodeLine = 3868;
                NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( "Requesting data ..."  ) ; 
                __context__.SourceCodeLine = 3869;
                NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( "Requesting data ..."  ) ; 
                __context__.SourceCodeLine = 3871;
                SXML  .UpdateValue ( "<RequestSchedule>" + "<RequestID>" + G_SNEXTMEETINGINFOREQUESTID + "</RequestID>" + "<MeetingID>" + SMEETINGID + "</MeetingID>" + "<FieldList>" + "<Field>Attendees</Field>" + "<Field>Resources</Field>" + "</FieldList>" + "</RequestSchedule>"  ) ; 
                } 
            
            } 
        
        }
    
    __context__.SourceCodeLine = 3883;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
        { 
        __context__.SourceCodeLine = 3885;
        do 
            { 
            __context__.SourceCodeLine = 3888;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 3890;
                TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 3894;
                TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 3900;
        TO_RV_SCHEDULEQUERY__DOLLAR__  .UpdateValue ( SXML  ) ; 
        }
    
    
    }
    
private void UPDATECURRENTMEETINGINFO (  SplusExecutionContext __context__ ) 
    { 
    ushort IEVENTNUM = 0;
    
    CrestronString SSTARTEND;
    SSTARTEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    
    __context__.SourceCodeLine = 3921;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 3922;
        Trace( "\r\n** UpdateCurrentMeetingInfo **\r\n") ; 
        }
    
    __context__.SourceCodeLine = 3925;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 3927;
        CURRENTTIME_MEETING_ID__DOLLAR__  .UpdateValue ( MEETINGEVENT [ G_ICURRENTEVENTNUM] . MEETINGID  ) ; 
        __context__.SourceCodeLine = 3928;
        CURRENTTIME_RVMEETING_ID__DOLLAR__  .UpdateValue ( MEETINGEVENT [ G_ICURRENTEVENTNUM] . RVMEETINGID  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 3932;
        CURRENTTIME_MEETING_ID__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3933;
        CURRENTTIME_RVMEETING_ID__DOLLAR__  .UpdateValue ( ""  ) ; 
        } 
    
    __context__.SourceCodeLine = 3938;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTNUM > 0 ))  ) ) 
        {
        __context__.SourceCodeLine = 3939;
        IEVENTNUM = (ushort) ( G_ISTARTEDEVENTNUM ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 3940;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 3941;
            IEVENTNUM = (ushort) ( G_ICURRENTEVENTNUM ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 3943;
            IEVENTNUM = (ushort) ( 0 ) ; 
            }
        
        }
    
    __context__.SourceCodeLine = 3946;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTNUM > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 3953;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( G_BHAVEMEETINGPRESETMODULE ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCURRENTMEETINGWELCOMEMSGID != MEETINGEVENT[ IEVENTNUM ].MEETINGID) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3957;
            G_SCURRENTWELCOMEMSG  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3958;
            CURRENT_MEETING_WELCOME_MSG__DOLLAR__  .UpdateValue ( G_SCURRENTWELCOMEMSG  ) ; 
            __context__.SourceCodeLine = 3960;
            G_SCURRENTMEETINGWELCOMEMSGID  .UpdateValue ( MEETINGEVENT [ IEVENTNUM] . MEETINGID  ) ; 
            __context__.SourceCodeLine = 3962;
            GETMEETINGINFO (  __context__ , (ushort)( 1 ), (ushort)( 2 ), MEETINGEVENT[ IEVENTNUM ].MEETINGID) ; 
            } 
        
        __context__.SourceCodeLine = 3965;
        CURRENT_MEETING_MEETING_ID__DOLLAR__  .UpdateValue ( MEETINGEVENT [ IEVENTNUM] . MEETINGID  ) ; 
        __context__.SourceCodeLine = 3966;
        CURRENT_MEETING_RVMEETING_ID__DOLLAR__  .UpdateValue ( MEETINGEVENT [ IEVENTNUM] . RVMEETINGID  ) ; 
        __context__.SourceCodeLine = 3967;
        CURRENT_MEETING_SUBJECT__DOLLAR__  .UpdateValue ( MEETINGEVENT [ IEVENTNUM] . SUBJECT  ) ; 
        __context__.SourceCodeLine = 3968;
        CURRENT_MEETING_START_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , MEETINGEVENT[ IEVENTNUM ].STARTDATE, (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 3969;
        CURRENT_MEETING_START_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , MEETINGEVENT[ IEVENTNUM ].STARTTIME)  ) ; 
        __context__.SourceCodeLine = 3970;
        CURRENT_MEETING_END_DATE__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDDATE, (ushort)( 2 ))  ) ; 
        __context__.SourceCodeLine = 3971;
        CURRENT_MEETING_END_TIME__DOLLAR__  .UpdateValue ( FORMATTIME (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDTIME)  ) ; 
        __context__.SourceCodeLine = 3972;
        CURRENT_MEETING_WELCOME_MSG__DOLLAR__  .UpdateValue ( G_SCURRENTWELCOMEMSG  ) ; 
        __context__.SourceCodeLine = 3975;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( MEETINGEVENT[ IEVENTNUM ].ORGANIZER ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 3976;
            CURRENT_MEETING_ORGANIZER__DOLLAR__  .UpdateValue ( "Unknown"  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 3978;
            CURRENT_MEETING_ORGANIZER__DOLLAR__  .UpdateValue ( MEETINGEVENT [ IEVENTNUM] . ORGANIZER  ) ; 
            }
        
        __context__.SourceCodeLine = 3984;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ IEVENTNUM ].STARTDATE == G_SDATETODAY))  ) ) 
            { 
            __context__.SourceCodeLine = 3988;
            SSTARTEND  .UpdateValue ( FORMATTIME (  __context__ , MEETINGEVENT[ IEVENTNUM ].STARTTIME)  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3994;
            SSTARTEND  .UpdateValue ( FORMATDATE (  __context__ , MEETINGEVENT[ IEVENTNUM ].STARTDATE, (ushort)( 2 )) + " " + FORMATTIME (  __context__ , MEETINGEVENT[ IEVENTNUM ].STARTTIME)  ) ; 
            } 
        
        __context__.SourceCodeLine = 3999;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ IEVENTNUM ].ENDDATE == G_SDATETODAY))  ) ) 
            { 
            __context__.SourceCodeLine = 4003;
            SSTARTEND  .UpdateValue ( SSTARTEND + " - " + FORMATTIME (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDTIME)  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4009;
            SSTARTEND  .UpdateValue ( SSTARTEND + " - " + FORMATDATE (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDDATE, (ushort)( 2 )) + " " + FORMATTIME (  __context__ , MEETINGEVENT[ IEVENTNUM ].ENDTIME)  ) ; 
            } 
        
        __context__.SourceCodeLine = 4013;
        CURRENT_MEETING_STARTEND__DOLLAR__  .UpdateValue ( SSTARTEND  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4019;
        CURRENT_MEETING_MEETING_ID__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4020;
        CURRENT_MEETING_RVMEETING_ID__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4021;
        CURRENT_MEETING_ORGANIZER__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4022;
        CURRENT_MEETING_SUBJECT__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4023;
        CURRENT_MEETING_START_DATE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4024;
        CURRENT_MEETING_START_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4025;
        CURRENT_MEETING_END_DATE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4026;
        CURRENT_MEETING_END_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4027;
        CURRENT_MEETING_STARTEND__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4028;
        G_SCURRENTWELCOMEMSG  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4029;
        CURRENT_MEETING_WELCOME_MSG__DOLLAR__  .UpdateValue ( ""  ) ; 
        } 
    
    
    }
    
private void CLEARPRESETINFO (  SplusExecutionContext __context__ ) 
    { 
    CrestronString SXML;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 4049;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4051;
        Trace( "\r\n** ClearPresetInfo **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 4055;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SLASTSENTGETPRESETDATAID != "-1"))  ) ) 
        { 
        __context__.SourceCodeLine = 4059;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 4060;
            Trace( "  Have not empty list.\r\n") ; 
            }
        
        __context__.SourceCodeLine = 4062;
        G_SLASTSENTGETPRESETDATAID  .UpdateValue ( "-1"  ) ; 
        __context__.SourceCodeLine = 4064;
        TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<ScheduleInterfaceData><Type=\u0022PresetData\u0022 />"  ) ; 
        __context__.SourceCodeLine = 4067;
        TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<MeetingPresets></MeetingPresets>"  ) ; 
        __context__.SourceCodeLine = 4070;
        TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</ScheduleInterfaceData>"  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4077;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 4078;
            Trace( "  Already sent empty list.\r\n") ; 
            }
        
        } 
    
    
    }
    
private void GETPRESETINFO (  SplusExecutionContext __context__, ushort IEVENTINDEX ) 
    { 
    ushort I = 0;
    ushort IEVENTSTARTTIMEMIN = 0;
    
    CrestronString SXML;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 4101;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4103;
        Trace( "\r\n** GetPresetInfo **\r\n") ; 
        __context__.SourceCodeLine = 4104;
        Trace( "  iEventIndex:{0:d}\r\n", (ushort)IEVENTINDEX) ; 
        } 
    
    __context__.SourceCodeLine = 4108;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTINDEX > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4112;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 4114;
            Trace( "  Subject:{0}.\r\n", MEETINGEVENT [ IEVENTINDEX] . SUBJECT ) ; 
            } 
        
        __context__.SourceCodeLine = 4118;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SLASTSENTGETPRESETDATAID != MEETINGEVENT[ IEVENTINDEX ].MEETINGID))  ) ) 
            { 
            __context__.SourceCodeLine = 4120;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 4121;
                Trace( "  Have not retrieved this data yet.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 4123;
            G_SLASTSENTGETPRESETDATAID  .UpdateValue ( MEETINGEVENT [ IEVENTINDEX] . MEETINGID  ) ; 
            __context__.SourceCodeLine = 4124;
            G_ILASTSENTGETPRESETDATAINDEX = (ushort) ( IEVENTINDEX ) ; 
            __context__.SourceCodeLine = 4126;
            GETMEETINGINFO (  __context__ , (ushort)( 1 ), (ushort)( 2 ), MEETINGEVENT[ IEVENTINDEX ].MEETINGID) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4132;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 4133;
                Trace( "  Already retrieved this data.\r\n") ; 
                }
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4140;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 4141;
            Trace( "  Do not have an event index.\r\n") ; 
            }
        
        } 
    
    
    }
    
private void GETRVMEETINGID (  SplusExecutionContext __context__, CrestronString SMEETINGID ) 
    { 
    CrestronString SXML;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 4161;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4163;
        Print( "\r\n** GetRVMeetingID **\r\n") ; 
        __context__.SourceCodeLine = 4164;
        Print( "    sMeetingID:{0}\r\n", SMEETINGID ) ; 
        } 
    
    __context__.SourceCodeLine = 4168;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SMEETINGID != G_SLASTSENTGETMEETINGID))  ) ) 
        { 
        __context__.SourceCodeLine = 4170;
        G_SLASTSENTGETMEETINGID  .UpdateValue ( SMEETINGID  ) ; 
        __context__.SourceCodeLine = 4172;
        G_SACTIONRVIDREQUESTID  .UpdateValue ( "ActionRVID" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
        __context__.SourceCodeLine = 4174;
        SXML  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 4176;
        SXML  .UpdateValue ( "<RequestAction>" + "<RequestID>" + G_SACTIONRVIDREQUESTID + "</RequestID>" + "<ActionID>RequestRVID</ActionID>" + "<Parameters>" + "<Parameter ID = \u0022MeetingID\u0022 Value = \u0022" + SMEETINGID + "\u0022 />" + "</Parameters>" + "</RequestAction>"  ) ; 
        __context__.SourceCodeLine = 4185;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
            { 
            __context__.SourceCodeLine = 4187;
            do 
                { 
                __context__.SourceCodeLine = 4189;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4191;
                    TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 4195;
                    TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4202;
            TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( SXML  ) ; 
            } 
        
        } 
    
    
    }
    
private void CHECKROOMSTATUS (  SplusExecutionContext __context__, ushort BENABLEREQUESTNEXTRESERV ) 
    { 
    ushort I = 0;
    ushort BNEEDNEXTEVENT = 0;
    ushort BNEXTEVENTDATEVALID = 0;
    ushort BSTARTTIMEVALID = 0;
    ushort BENDTIMEVALID = 0;
    ushort BPRESETSTARTTIMEVALID = 0;
    ushort BPRESETENDTIMEVALID = 0;
    ushort IMINUTEBLOCK = 0;
    
    ushort IEVENTSTARTTIMEMIN = 0;
    ushort IEVENTENDTIMEMIN = 0;
    ushort INEXTRESERVATION = 0;
    
    ushort IPRESETEVENTINDEX = 0;
    
    
    __context__.SourceCodeLine = 4236;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 4237;
        Trace( "\r\n** CheckRoomStatus **\r\n") ; 
        }
    
    __context__.SourceCodeLine = 4240;
    BNEXTEVENTDATEVALID = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 4241;
    BNEEDNEXTEVENT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 4243;
    G_ICURRENTEVENTNUM = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 4245;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4247;
        Trace( "    Started Event Num:{0:d}\r\n", (ushort)G_ISTARTEDEVENTNUM) ; 
        } 
    
    __context__.SourceCodeLine = 4252;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.MEETINGID ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4256;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 4258;
            Trace( "    Have Next Reservation.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 4262;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == NEXTEVENT.STARTDATE) ) || Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) < DATETOINTEGER( __context__ , NEXTEVENT.STARTDATE ) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 4264;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 4266;
                Trace( "    Next Reservation start date still valid.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 4270;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SDATETODAY == NEXTEVENT.STARTDATE))  ) ) 
                { 
                __context__.SourceCodeLine = 4274;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 4276;
                    Trace( "    Next Reservation start date = today. Need to check start time.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 4280;
                IEVENTSTARTTIMEMIN = (ushort) ( TIMETOINTEGER( __context__ , NEXTEVENT.STARTTIME , (ushort)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 4282;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 4284;
                    Trace( "    NextEvent.StartTime:{0}\r\n", NEXTEVENT . STARTTIME ) ; 
                    __context__.SourceCodeLine = 4285;
                    Trace( "    iEventStartTimeMin:{0:d}\r\n", (ushort)IEVENTSTARTTIMEMIN) ; 
                    __context__.SourceCodeLine = 4286;
                    Trace( "    g_iCurrentTimeMin:{0:d}\r\n", (ushort)G_ICURRENTTIMEMIN) ; 
                    } 
                
                __context__.SourceCodeLine = 4289;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIMEMIN >= IEVENTSTARTTIMEMIN ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4293;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 4295;
                        Trace( "    Next Reservation time not valid anymore. Clearing data.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 4298;
                    NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4299;
                    NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4300;
                    NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4301;
                    NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4302;
                    NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4303;
                    NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4304;
                    NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4305;
                    NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 4311;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 4313;
                        Trace( "    Next Reservation time still valid.\r\n") ; 
                        } 
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 4321;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 4323;
                    Trace( "    Next Reservation start date > today. Event still valid.\r\n") ; 
                    } 
                
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4329;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 4331;
                Trace( "    Next Reservation start date not valid. Clearing data.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 4334;
            NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4335;
            NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4336;
            NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4337;
            NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4338;
            NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4339;
            NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4340;
            NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4341;
            NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 4346;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTOREDEVENTCOUNT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4349;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTNUM > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 4353;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 4355;
                Trace( "    Have a started event number. See if ID still valid.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 4358;
            BSTARTTIMEVALID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4359;
            BENDTIMEVALID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4361;
            if ( Functions.TestForTrue  ( ( EVENTINDEX( __context__ , (ushort)( 0 ) , (ushort)( 1 ) , MEETINGEVENT[ G_ISTARTEDEVENTNUM ].MEETINGID ))  ) ) 
                { 
                __context__.SourceCodeLine = 4365;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 4367;
                    Trace( "    ID is still valid. Check dates & times.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 4371;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ G_ISTARTEDEVENTNUM ].STARTDATE == G_SDATETODAY))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4375;
                    IEVENTSTARTTIMEMIN = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ G_ISTARTEDEVENTNUM ].STARTTIME , (ushort)( 2 ) ) ) ; 
                    __context__.SourceCodeLine = 4379;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTSTARTTIMEMIN >= MEETING_PRESET_START_TIME  .UshortValue ))  ) ) 
                        {
                        __context__.SourceCodeLine = 4380;
                        IEVENTSTARTTIMEMIN = (ushort) ( (IEVENTSTARTTIMEMIN - MEETING_PRESET_START_TIME  .UshortValue) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 4382;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIMEMIN >= IEVENTSTARTTIMEMIN ))  ) ) 
                        {
                        __context__.SourceCodeLine = 4383;
                        BSTARTTIMEVALID = (ushort) ( 1 ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 4385;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , MEETINGEVENT[ G_ISTARTEDEVENTNUM ].STARTDATE ) < DATETOINTEGER( __context__ , G_SDATETODAY ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 4389;
                        BSTARTTIMEVALID = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 4393;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ G_ISTARTEDEVENTNUM ].ENDDATE == G_SDATETODAY))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4397;
                    IEVENTENDTIMEMIN = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ G_ISTARTEDEVENTNUM ].ENDTIME , (ushort)( 2 ) ) ) ; 
                    __context__.SourceCodeLine = 4399;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIMEMIN < IEVENTENDTIMEMIN ))  ) ) 
                        {
                        __context__.SourceCodeLine = 4400;
                        BENDTIMEVALID = (ushort) ( 1 ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 4402;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , MEETINGEVENT[ G_ISTARTEDEVENTNUM ].ENDDATE ) > DATETOINTEGER( __context__ , G_SDATETODAY ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 4406;
                        BENDTIMEVALID = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 4410;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( BSTARTTIMEVALID ) && Functions.TestForTrue ( BENDTIMEVALID )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4414;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 4416;
                        Trace( "    Start/end times still valid. Start meeting index still valid.\r\n") ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 4421;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 4423;
                        Trace( "    Start/end times not valid. Start meeting index not valid.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 4426;
                    G_ISTARTEDEVENTNUM = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 4427;
                    G_SSTARTEDEVENTID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 4429;
                    if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                        {
                        __context__.SourceCodeLine = 4430;
                        CLEARPRESETINFO (  __context__  ) ; 
                        }
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 4439;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 4441;
                    Trace( "    Meeting id not valid anymore. Clear variable.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 4444;
                G_ISTARTEDEVENTNUM = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 4445;
                G_SSTARTEDEVENTID  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 4447;
                if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                    {
                    __context__.SourceCodeLine = 4448;
                    CLEARPRESETINFO (  __context__  ) ; 
                    }
                
                } 
            
            } 
        
        __context__.SourceCodeLine = 4455;
        IPRESETEVENTINDEX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4457;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 4459;
            BSTARTTIMEVALID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4460;
            BENDTIMEVALID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4462;
            BPRESETSTARTTIMEVALID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4463;
            BPRESETENDTIMEVALID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4471;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ I ].STARTDATE == G_SDATETODAY))  ) ) 
                { 
                __context__.SourceCodeLine = 4475;
                IEVENTSTARTTIMEMIN = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ I ].STARTTIME , (ushort)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 4477;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIMEMIN >= IEVENTSTARTTIMEMIN ))  ) ) 
                    {
                    __context__.SourceCodeLine = 4478;
                    BSTARTTIMEVALID = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 4480;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTSTARTTIMEMIN >= MEETING_PRESET_START_TIME  .UshortValue ))  ) ) 
                    {
                    __context__.SourceCodeLine = 4481;
                    IEVENTSTARTTIMEMIN = (ushort) ( (IEVENTSTARTTIMEMIN - MEETING_PRESET_START_TIME  .UshortValue) ) ; 
                    }
                
                __context__.SourceCodeLine = 4483;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIMEMIN >= IEVENTSTARTTIMEMIN ))  ) ) 
                    {
                    __context__.SourceCodeLine = 4484;
                    BPRESETSTARTTIMEVALID = (ushort) ( 1 ) ; 
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 4486;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , MEETINGEVENT[ I ].STARTDATE ) < DATETOINTEGER( __context__ , G_SDATETODAY ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4490;
                    BSTARTTIMEVALID = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 4492;
                    BPRESETSTARTTIMEVALID = (ushort) ( 1 ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 4496;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETINGEVENT[ I ].ENDDATE == G_SDATETODAY))  ) ) 
                { 
                __context__.SourceCodeLine = 4500;
                IEVENTENDTIMEMIN = (ushort) ( TIMETOINTEGER( __context__ , MEETINGEVENT[ I ].ENDTIME , (ushort)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 4502;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTTIMEMIN < IEVENTENDTIMEMIN ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4504;
                    BENDTIMEVALID = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 4505;
                    BPRESETENDTIMEVALID = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 4508;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , MEETINGEVENT[ I ].ENDDATE ) > DATETOINTEGER( __context__ , G_SDATETODAY ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 4512;
                    BENDTIMEVALID = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 4513;
                    BPRESETENDTIMEVALID = (ushort) ( 1 ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 4516;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 4518;
                Trace( "    bStartTimeValid:{0:d} bEndTimeValid:{1:d}\r\n", (short)BSTARTTIMEVALID, (short)BENDTIMEVALID) ; 
                __context__.SourceCodeLine = 4519;
                Trace( "    bPresetStartTimeValid:{0:d} bPresetEndTimeValid:{1:d}\r\n", (short)BPRESETSTARTTIMEVALID, (short)BPRESETENDTIMEVALID) ; 
                } 
            
            __context__.SourceCodeLine = 4523;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( BPRESETSTARTTIMEVALID ) && Functions.TestForTrue ( BPRESETENDTIMEVALID )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 4527;
                IPRESETEVENTINDEX = (ushort) ( I ) ; 
                } 
            
            __context__.SourceCodeLine = 4531;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( BSTARTTIMEVALID ) && Functions.TestForTrue ( BENDTIMEVALID )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 4535;
                G_ICURRENTEVENTNUM = (ushort) ( I ) ; 
                __context__.SourceCodeLine = 4537;
                break ; 
                } 
            
            __context__.SourceCodeLine = 4457;
            } 
        
        __context__.SourceCodeLine = 4543;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPRESETEVENTINDEX > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 4547;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 4549;
                Trace( "    Found Preset Event Index.\r\n") ; 
                __context__.SourceCodeLine = 4550;
                Trace( "     Index:{0:d}\r\n", (ushort)IPRESETEVENTINDEX) ; 
                } 
            
            __context__.SourceCodeLine = 4553;
            if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                {
                __context__.SourceCodeLine = 4554;
                GETPRESETINFO (  __context__ , (ushort)( IPRESETEVENTINDEX )) ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4560;
            if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
                {
                __context__.SourceCodeLine = 4561;
                CLEARPRESETINFO (  __context__  ) ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 4565;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 4569;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 4571;
                Trace( "    Found Current Event.\r\n") ; 
                __context__.SourceCodeLine = 4572;
                Trace( "     Index:{0:d}\r\n", (ushort)G_ICURRENTEVENTNUM) ; 
                __context__.SourceCodeLine = 4573;
                Trace( "     StartDate:{0}\r\n", MEETINGEVENT [ G_ICURRENTEVENTNUM] . STARTDATE ) ; 
                __context__.SourceCodeLine = 4574;
                Trace( "     StartTime:{0}\r\n", MEETINGEVENT [ G_ICURRENTEVENTNUM] . STARTTIME ) ; 
                __context__.SourceCodeLine = 4575;
                Trace( "     EndDate:{0}\r\n", MEETINGEVENT [ G_ICURRENTEVENTNUM] . ENDDATE ) ; 
                __context__.SourceCodeLine = 4576;
                Trace( "     EndTime:{0}\r\n", MEETINGEVENT [ G_ICURRENTEVENTNUM] . ENDTIME ) ; 
                } 
            
            __context__.SourceCodeLine = 4580;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( MEETINGEVENT[ G_ICURRENTEVENTNUM ].RVMEETINGID ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 4584;
                GETRVMEETINGID (  __context__ , MEETINGEVENT[ G_ICURRENTEVENTNUM ].MEETINGID) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4591;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 4592;
                Trace( "    No Current Event Found\r\n") ; 
                }
            
            __context__.SourceCodeLine = 4594;
            CURRENT_MEETING_DURATION_MIN  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4595;
            CURRENT_MEETING_ELAPSED_TIME  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4596;
            CURRENT_MEETING_ELAPSED_PERCENT  .Value = (ushort) ( 0 ) ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4603;
        MEETING_ACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4605;
        CURRENT_MEETING_DURATION_MIN  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4606;
        CURRENT_MEETING_ELAPSED_TIME  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4607;
        CURRENT_MEETING_ELAPSED_PERCENT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4610;
        G_ISTARTEDEVENTNUM = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4611;
        G_SSTARTEDEVENTID  .UpdateValue ( ""  ) ; 
        } 
    
    __context__.SourceCodeLine = 4614;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTNUM > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4616;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 4617;
            Trace( "    Event is started. Use it for time remaining.\r\n") ; 
            }
        
        __context__.SourceCodeLine = 4619;
        TIME_REMAINING_HRMIN__DOLLAR__  .UpdateValue ( TIMEREMAINING (  __context__ , (ushort)( 2 ))  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4623;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 4624;
            Trace( "    Event is not extended or started. See if there is a current event.\r\n") ; 
            }
        
        __context__.SourceCodeLine = 4626;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 4630;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 4631;
                Trace( "    Have current meeting. Use it for time remaining.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 4633;
            TIME_REMAINING_HRMIN__DOLLAR__  .UpdateValue ( TIMEREMAINING (  __context__ , (ushort)( 1 ))  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 4637;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 4638;
                Trace( "    Do not have current meeting. Clear time remaining.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 4640;
            TIME_REMAINING_HRMIN__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 4645;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTEVENTNUM > 0 ))  ) ) 
        {
        __context__.SourceCodeLine = 4646;
        MEETING_ACTIVE  .Value = (ushort) ( 1 ) ; 
        }
    
    else 
        { 
        __context__.SourceCodeLine = 4649;
        MEETING_ACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 4650;
        G_BSTARTMEETINGCONFIRMED = (ushort) ( 0 ) ; 
        } 
    
    __context__.SourceCodeLine = 4654;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTARTEDEVENTNUM > 0 ))  ) ) 
        {
        __context__.SourceCodeLine = 4655;
        MEETING_STARTED  .Value = (ushort) ( 1 ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 4657;
        MEETING_STARTED  .Value = (ushort) ( 0 ) ; 
        }
    
    __context__.SourceCodeLine = 4660;
    UPDATECURRENTMEETINGINFO (  __context__  ) ; 
    __context__.SourceCodeLine = 4663;
    INEXTRESERVATION = (ushort) ( NEXTRESERVATION( __context__ , (ushort)( BENABLEREQUESTNEXTRESERV ) ) ) ; 
    __context__.SourceCodeLine = 4666;
    SETRESERVENOW (  __context__  ) ; 
    __context__.SourceCodeLine = 4669;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( END_NEXT_MEETING_WARN_TIME  .UshortValue > 0 ))  ) ) 
        {
        __context__.SourceCodeLine = 4670;
        SETENDNEXTMEETINGWARN (  __context__  ) ; 
        }
    
    __context__.SourceCodeLine = 4673;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( FIELD_QTY  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CURRENT_PAGE  .UshortValue > 0 ) )) ))  ) ) 
        {
        __context__.SourceCodeLine = 4674;
        SETCURRENTTIMEBARGRAPHVALUE (  __context__  ) ; 
        }
    
    __context__.SourceCodeLine = 4677;
    CHECKNOSHOW (  __context__  ) ; 
    __context__.SourceCodeLine = 4680;
    if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
        { 
        __context__.SourceCodeLine = 4682;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 2 ), "") ; 
        __context__.SourceCodeLine = 4683;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 3 ), "") ; 
        } 
    
    __context__.SourceCodeLine = 4687;
    SETSTARTMEETINGBTN (  __context__  ) ; 
    __context__.SourceCodeLine = 4690;
    SETENDMEETINGBTN (  __context__  ) ; 
    
    }
    
private void SENDUICREATEDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
    { 
    
    __context__.SourceCodeLine = 4707;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4709;
        Trace( "\r\n** SendUICreateData **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 4712;
    TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>CreateResponse</Type>"  ) ; 
    __context__.SourceCodeLine = 4716;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4718;
        do 
            { 
            __context__.SourceCodeLine = 4721;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 4723;
                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SDATA )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 4727;
                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SDATA ), SDATA )  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4734;
        TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( SDATA  ) ; 
        } 
    
    __context__.SourceCodeLine = 4737;
    TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</Data>"  ) ; 
    
    }
    
private void SENDUISCHEDDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
    { 
    
    __context__.SourceCodeLine = 4755;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4757;
        Trace( "\r\n** SendUISchedData **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 4760;
    TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>ScheduleResponse</Type>"  ) ; 
    __context__.SourceCodeLine = 4764;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4766;
        do 
            { 
            __context__.SourceCodeLine = 4769;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 4771;
                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SDATA )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 4775;
                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SDATA ), SDATA )  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4782;
        TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( SDATA  ) ; 
        } 
    
    __context__.SourceCodeLine = 4785;
    TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</Data>"  ) ; 
    
    }
    
private void SENDUIEVENTLIST (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    
    
    __context__.SourceCodeLine = 4805;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4807;
        Trace( "\r\n** SendUIEventList **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 4810;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTOREDEVENTCOUNT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4812;
        TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>EventList</Type>"  ) ; 
        __context__.SourceCodeLine = 4816;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 4818;
            TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Event>" + "<MeetingID>" + MEETINGEVENT [ I] . MEETINGID + "</MeetingID>"  ) ; 
            __context__.SourceCodeLine = 4822;
            TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<RVMeetingID>" + MEETINGEVENT [ I] . RVMEETINGID + "</RVMeetingID>"  ) ; 
            __context__.SourceCodeLine = 4825;
            TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartDate>" + MEETINGEVENT [ I] . STARTDATE + "</StartDate>" + "<StartTime>" + MEETINGEVENT [ I] . STARTTIME + "</StartTime>" + "<StartBlock>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].STARTBLOCK ) ) + "</StartBlock>"  ) ; 
            __context__.SourceCodeLine = 4830;
            TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<EndDate>" + MEETINGEVENT [ I] . ENDDATE + "</EndDate>" + "<EndTime>" + MEETINGEVENT [ I] . ENDTIME + "</EndTime>" + "<EndBlock>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].ENDBLOCK ) ) + "</EndBlock>"  ) ; 
            __context__.SourceCodeLine = 4835;
            TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Organizer>" + MEETINGEVENT [ I] . ORGANIZER + "</Organizer>"  ) ; 
            __context__.SourceCodeLine = 4838;
            TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Subject>" + MEETINGEVENT [ I] . SUBJECT + "</Subject>" + "<IsPrivate>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].ISPRIVATE ) ) + "</IsPrivate>" + "<IsExchangePrivate>" + Functions.ItoA (  (int) ( MEETINGEVENT[ I ].ISEXCHANGEPRIVATE ) ) + "</IsExchangePrivate>" + "</Event>"  ) ; 
            __context__.SourceCodeLine = 4816;
            } 
        
        __context__.SourceCodeLine = 4845;
        TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</Data>"  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4850;
        TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>EventList</Type>" + "</Data>"  ) ; 
        } 
    
    
    }
    
private void SENDAVAILROOMSCREATEDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
    { 
    
    __context__.SourceCodeLine = 4871;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4873;
        Trace( "\r\n** SendAvailRoomsCreateData **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 4876;
    TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>CreateResponse</Type>"  ) ; 
    __context__.SourceCodeLine = 4880;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
        { 
        __context__.SourceCodeLine = 4882;
        do 
            { 
            __context__.SourceCodeLine = 4885;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 4887;
                TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SDATA )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 4891;
                TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SDATA ), SDATA )  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 4898;
        TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__  .UpdateValue ( SDATA  ) ; 
        } 
    
    __context__.SourceCodeLine = 4901;
    TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</Data>"  ) ; 
    
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
    
    
    __context__.SourceCodeLine = 4928;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 4930;
        Trace( "\r\n** WrapBlockText **\r\n") ; 
        __context__.SourceCodeLine = 4931;
        Trace( "  TextLen:{0:d}\r\n", (ushort)Functions.Length( STEXT )) ; 
        __context__.SourceCodeLine = 4932;
        Trace( "  StartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
        __context__.SourceCodeLine = 4933;
        Trace( "  EndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
        } 
    
    __context__.SourceCodeLine = 4936;
    ICOLUMNWIDTH = (ushort) ( COLUMN_WIDTH  .UshortValue ) ; 
    __context__.SourceCodeLine = 4939;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTBLOCK ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)IENDBLOCK; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 4943;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEXT ) > ICOLUMNWIDTH ))  ) ) 
            { 
            __context__.SourceCodeLine = 4948;
            STEXTCHUNK  .UpdateValue ( Functions.Left ( STEXT ,  (int) ( ICOLUMNWIDTH ) )  ) ; 
            __context__.SourceCodeLine = 4951;
            if ( Functions.TestForTrue  ( ( Functions.Find( " " , STEXTCHUNK ))  ) ) 
                { 
                __context__.SourceCodeLine = 4953;
                BFINDSPACE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 4954;
                ISTARTPOS = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 4957;
                do 
                    { 
                    __context__.SourceCodeLine = 4959;
                    ISPACEPOS = (ushort) ( Functions.Find( " " , STEXTCHUNK , ISTARTPOS ) ) ; 
                    __context__.SourceCodeLine = 4961;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 4963;
                        Trace( "  iSpacePos:{0:d}\r\n", (ushort)ISPACEPOS) ; 
                        } 
                    
                    __context__.SourceCodeLine = 4966;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISPACEPOS > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 4970;
                        ILASTSPACEPOS = (ushort) ( ISPACEPOS ) ; 
                        __context__.SourceCodeLine = 4973;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISPACEPOS < ICOLUMNWIDTH ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 4976;
                            ISTARTPOS = (ushort) ( (ISPACEPOS + 1) ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 4981;
                            BFINDSPACE = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 4988;
                        BFINDSPACE = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.Not( BFINDSPACE )) )); 
                __context__.SourceCodeLine = 4994;
                STEXTCHUNK  .UpdateValue ( Functions.Remove ( ILASTSPACEPOS, STEXT )  ) ; 
                } 
            
            else 
                { 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 5004;
            if ( Functions.TestForTrue  ( ( Functions.Length( STEXT ))  ) ) 
                { 
                __context__.SourceCodeLine = 5006;
                STEXTCHUNK  .UpdateValue ( Functions.Remove ( Functions.Length( STEXT ), STEXT )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 5010;
                STEXTCHUNK  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 5014;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 5016;
            Trace( "  Block:{0:d}\r\n", (ushort)I) ; 
            __context__.SourceCodeLine = 5017;
            Trace( "  TextChunk:{0}\r\n", STEXTCHUNK ) ; 
            } 
        
        __context__.SourceCodeLine = 5020;
        TIME_BLOCK_TEXT__DOLLAR__ [ I]  .UpdateValue ( STEXTCHUNK  ) ; 
        __context__.SourceCodeLine = 4939;
        } 
    
    
    }
    
private void UPDATECALENDAR (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    ushort J = 0;
    ushort BVALIDEVENT = 0;
    ushort BPRIVATEEVENT = 0;
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
    SEVENTORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SEVENTSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    SBLOCKTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 5056;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5058;
        Trace( "\r\n** UpdateCalendar **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 5062;
    IEVENTCOUNT = (ushort) ( G_ISTOREDEVENTCOUNT ) ; 
    __context__.SourceCodeLine = 5063;
    IPREVIOUSENDBLOCK = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5065;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5067;
        Trace( "  EventCount:{0:d}\r\n", (ushort)IEVENTCOUNT) ; 
        } 
    
    __context__.SourceCodeLine = 5071;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTCOUNT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 5075;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)IEVENTCOUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 5077;
            ISTARTBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5078;
            IENDBLOCK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5079;
            BPRIVATEEVENT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5080;
            BVALIDEVENT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5081;
            BNEEDTEXTWRAP = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5085;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( MEETINGEVENT[ I ].ORGANIZER ) > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 5086;
                SEVENTORGANIZER  .UpdateValue ( MEETINGEVENT [ I] . ORGANIZER  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 5088;
                SEVENTORGANIZER  .UpdateValue ( "Unknown"  ) ; 
                }
            
            __context__.SourceCodeLine = 5090;
            SEVENTSUBJECT  .UpdateValue ( MEETINGEVENT [ I] . SUBJECT  ) ; 
            __context__.SourceCodeLine = 5092;
            ISTARTBLOCK = (ushort) ( MEETINGEVENT[ I ].STARTBLOCK ) ; 
            __context__.SourceCodeLine = 5093;
            IENDBLOCK = (ushort) ( MEETINGEVENT[ I ].ENDBLOCK ) ; 
            __context__.SourceCodeLine = 5095;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (MEETINGEVENT[ I ].ISPRIVATE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (MEETINGEVENT[ I ].ISEXCHANGEPRIVATE == 1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 5096;
                BPRIVATEEVENT = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 5098;
                BPRIVATEEVENT = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 5101;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTBLOCK == IENDBLOCK))  ) ) 
                { 
                __context__.SourceCodeLine = 5103;
                ISPAN = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 5108;
                ISPAN = (ushort) ( ((IENDBLOCK - ISTARTBLOCK) + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 5111;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5113;
                Trace( "  Event:{0:d}\r\n", (ushort)I) ; 
                __context__.SourceCodeLine = 5114;
                Trace( "  Span:{0:d}\r\n", (ushort)ISPAN) ; 
                } 
            
            __context__.SourceCodeLine = 5118;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTARTBLOCK > (IPREVIOUSENDBLOCK + 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 5120;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPREVIOUSENDBLOCK == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 5125;
                    CLEARCALENDAR (  __context__ , (ushort)( 1 ), (ushort)( (ISTARTBLOCK - 1) )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 5132;
                    CLEARCALENDAR (  __context__ , (ushort)( (IPREVIOUSENDBLOCK + 1) ), (ushort)( (ISTARTBLOCK - 1) )) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 5137;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PRIVACY_LEVEL  .UshortValue == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 5141;
                if ( Functions.TestForTrue  ( ( BPRIVATEEVENT)  ) ) 
                    { 
                    __context__.SourceCodeLine = 5143;
                    SBLOCKTEXT  .UpdateValue ( "Private"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 5147;
                    SBLOCKTEXT  .UpdateValue ( "[" + SEVENTORGANIZER + "] " + SEVENTSUBJECT  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 5150;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PRIVACY_LEVEL  .UshortValue == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 5155;
                    if ( Functions.TestForTrue  ( ( BPRIVATEEVENT)  ) ) 
                        { 
                        __context__.SourceCodeLine = 5157;
                        SBLOCKTEXT  .UpdateValue ( "Private"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 5161;
                        SBLOCKTEXT  .UpdateValue ( "[" + SEVENTORGANIZER + "] " + "Private"  ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 5164;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PRIVACY_LEVEL  .UshortValue == 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 5168;
                        SBLOCKTEXT  .UpdateValue ( "Private"  ) ; 
                        } 
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 5174;
            IPREVIOUSENDBLOCK = (ushort) ( IENDBLOCK ) ; 
            __context__.SourceCodeLine = 5176;
            ISTARTINDEX = (ushort) ( ISTARTBLOCK ) ; 
            __context__.SourceCodeLine = 5177;
            IENDINDEX = (ushort) ( IENDBLOCK ) ; 
            __context__.SourceCodeLine = 5179;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5181;
                Trace( "  EventIndex:{0:d}\r\n", (ushort)I) ; 
                __context__.SourceCodeLine = 5182;
                Trace( "  EventStartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
                __context__.SourceCodeLine = 5183;
                Trace( "  EventEndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
                __context__.SourceCodeLine = 5184;
                Trace( "  EventOrganizer:{0}\r\n", SEVENTORGANIZER ) ; 
                __context__.SourceCodeLine = 5185;
                Trace( "  EventSubject:{0}\r\n", SEVENTSUBJECT ) ; 
                } 
            
            __context__.SourceCodeLine = 5190;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISPAN == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 5192;
                TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 5193;
                G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( I ) ; 
                __context__.SourceCodeLine = 5196;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SBLOCKTEXT ) > COLUMN_WIDTH  .UshortValue ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 5198;
                    SBLOCKTEXT  .UpdateValue ( Functions.Left ( SBLOCKTEXT ,  (int) ( COLUMN_WIDTH  .UshortValue ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 5201;
                TIME_BLOCK_TEXT__DOLLAR__ [ ISTARTINDEX]  .UpdateValue ( SBLOCKTEXT  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 5203;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISPAN == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 5206;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SBLOCKTEXT ) > COLUMN_WIDTH  .UshortValue ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 5208;
                        BNEEDTEXTWRAP = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 5212;
                    TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 5213;
                    G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 5216;
                    TIME_BLOCK_MODE [ IENDINDEX]  .Value = (ushort) ( 4 ) ; 
                    __context__.SourceCodeLine = 5217;
                    G_IBLOCKEVENTINDEX [ IENDINDEX] = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 5220;
                    if ( Functions.TestForTrue  ( ( BNEEDTEXTWRAP)  ) ) 
                        { 
                        __context__.SourceCodeLine = 5222;
                        WRAPBLOCKTEXT (  __context__ , SBLOCKTEXT, (ushort)( ISTARTINDEX ), (ushort)( IENDINDEX )) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 5226;
                        TIME_BLOCK_TEXT__DOLLAR__ [ ISTARTINDEX]  .UpdateValue ( SBLOCKTEXT  ) ; 
                        __context__.SourceCodeLine = 5227;
                        TIME_BLOCK_TEXT__DOLLAR__ [ IENDINDEX]  .UpdateValue ( ""  ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 5233;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SBLOCKTEXT ) > COLUMN_WIDTH  .UshortValue ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 5235;
                        BNEEDTEXTWRAP = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 5239;
                    TIME_BLOCK_MODE [ ISTARTINDEX]  .Value = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 5240;
                    G_IBLOCKEVENTINDEX [ ISTARTINDEX] = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 5243;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISPAN > 2 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 5245;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( (ISTARTINDEX + 1) ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)(IENDINDEX - 1); 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( J  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (J  >= __FN_FORSTART_VAL__2) && (J  <= __FN_FOREND_VAL__2) ) : ( (J  <= __FN_FORSTART_VAL__2) && (J  >= __FN_FOREND_VAL__2) ) ; J  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 5247;
                            TIME_BLOCK_MODE [ J]  .Value = (ushort) ( 3 ) ; 
                            __context__.SourceCodeLine = 5248;
                            G_IBLOCKEVENTINDEX [ J] = (ushort) ( I ) ; 
                            __context__.SourceCodeLine = 5250;
                            if ( Functions.TestForTrue  ( ( Functions.Not( BNEEDTEXTWRAP ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 5252;
                                TIME_BLOCK_TEXT__DOLLAR__ [ J]  .UpdateValue ( ""  ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 5245;
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 5258;
                    TIME_BLOCK_MODE [ IENDINDEX]  .Value = (ushort) ( 4 ) ; 
                    __context__.SourceCodeLine = 5259;
                    G_IBLOCKEVENTINDEX [ IENDINDEX] = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 5262;
                    if ( Functions.TestForTrue  ( ( BNEEDTEXTWRAP)  ) ) 
                        { 
                        __context__.SourceCodeLine = 5264;
                        WRAPBLOCKTEXT (  __context__ , SBLOCKTEXT, (ushort)( ISTARTINDEX ), (ushort)( IENDINDEX )) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 5268;
                        TIME_BLOCK_TEXT__DOLLAR__ [ ISTARTINDEX]  .UpdateValue ( SBLOCKTEXT  ) ; 
                        __context__.SourceCodeLine = 5269;
                        TIME_BLOCK_TEXT__DOLLAR__ [ IENDINDEX]  .UpdateValue ( ""  ) ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 5075;
            } 
        
        } 
    
    __context__.SourceCodeLine = 5277;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPREVIOUSENDBLOCK == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 5282;
        CLEARCALENDAR (  __context__ , (ushort)( 1 ), (ushort)( 48 )) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 5288;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDINDEX < 48 ))  ) ) 
            { 
            __context__.SourceCodeLine = 5290;
            CLEARCALENDAR (  __context__ , (ushort)( (IENDINDEX + 1) ), (ushort)( 48 )) ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 5294;
    SCHEDULE_UPDATED  .Value = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 5295;
    SCHEDULE_UPDATED  .Value = (ushort) ( 0 ) ; 
    
    }
    
private void RESERVENOWSETLABELS (  SplusExecutionContext __context__, ushort MAX_TIME , ushort IDURATIONMINUTES ) 
    { 
    
    __context__.SourceCodeLine = 5303;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 30))  ) ) 
        { 
        __context__.SourceCodeLine = 5305;
        RESERVE_NOW_SELECT_30__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( IDURATIONMINUTES ) ) + " Min"  ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 5307;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 60))  ) ) 
            { 
            __context__.SourceCodeLine = 5309;
            RESERVE_NOW_SELECT_60__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( IDURATIONMINUTES ) ) + " Min"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 5311;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 90))  ) ) 
                { 
                __context__.SourceCodeLine = 5313;
                RESERVE_NOW_SELECT_90__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( IDURATIONMINUTES ) ) + " Min"  ) ; 
                } 
            
            else 
                { 
                } 
            
            }
        
        }
    
    
    }
    
private void COPYRESERVENOWDATA (  SplusExecutionContext __context__, RESERVENOWDATA DEST , RESERVENOWDATA SRC ) 
    { 
    
    __context__.SourceCodeLine = 5325;
    DEST . ISTARTYEAR = (ushort) ( SRC.ISTARTYEAR ) ; 
    __context__.SourceCodeLine = 5326;
    DEST . ISTARTMONTH = (ushort) ( SRC.ISTARTMONTH ) ; 
    __context__.SourceCodeLine = 5327;
    DEST . ISTARTDAY = (ushort) ( SRC.ISTARTDAY ) ; 
    __context__.SourceCodeLine = 5328;
    DEST . ISTARTHOUR = (ushort) ( SRC.ISTARTHOUR ) ; 
    __context__.SourceCodeLine = 5329;
    DEST . ISTARTMIN = (ushort) ( SRC.ISTARTMIN ) ; 
    __context__.SourceCodeLine = 5330;
    DEST . ISTARTSEC = (ushort) ( SRC.ISTARTSEC ) ; 
    __context__.SourceCodeLine = 5332;
    DEST . IENDYEAR = (ushort) ( SRC.IENDYEAR ) ; 
    __context__.SourceCodeLine = 5333;
    DEST . IENDMONTH = (ushort) ( SRC.IENDMONTH ) ; 
    __context__.SourceCodeLine = 5334;
    DEST . IENDDAY = (ushort) ( SRC.IENDDAY ) ; 
    __context__.SourceCodeLine = 5335;
    DEST . IENDHOUR = (ushort) ( SRC.IENDHOUR ) ; 
    __context__.SourceCodeLine = 5336;
    DEST . IENDMIN = (ushort) ( SRC.IENDMIN ) ; 
    __context__.SourceCodeLine = 5337;
    DEST . IENDSEC = (ushort) ( SRC.IENDSEC ) ; 
    
    }
    
private void SETRESERVENOWDATA (  SplusExecutionContext __context__, RESERVENOWDATA DEST , ushort ISTARTYEAR , ushort ISTARTMONTH , ushort ISTARTDAY , ushort ISTARTHOUR , ushort ISTARTMIN , ushort ISTARTSEC , ushort IENDYEAR , ushort IENDMONTH , ushort IENDDAY , ushort IENDHOUR , ushort IENDMIN , ushort IENDSEC ) 
    { 
    
    __context__.SourceCodeLine = 5345;
    DEST . ISTARTYEAR = (ushort) ( ISTARTYEAR ) ; 
    __context__.SourceCodeLine = 5346;
    DEST . ISTARTMONTH = (ushort) ( ISTARTMONTH ) ; 
    __context__.SourceCodeLine = 5347;
    DEST . ISTARTDAY = (ushort) ( ISTARTDAY ) ; 
    __context__.SourceCodeLine = 5348;
    DEST . ISTARTHOUR = (ushort) ( ISTARTHOUR ) ; 
    __context__.SourceCodeLine = 5349;
    DEST . ISTARTMIN = (ushort) ( ISTARTMIN ) ; 
    __context__.SourceCodeLine = 5350;
    DEST . ISTARTSEC = (ushort) ( ISTARTSEC ) ; 
    __context__.SourceCodeLine = 5352;
    DEST . IENDYEAR = (ushort) ( IENDYEAR ) ; 
    __context__.SourceCodeLine = 5353;
    DEST . IENDMONTH = (ushort) ( IENDMONTH ) ; 
    __context__.SourceCodeLine = 5354;
    DEST . IENDDAY = (ushort) ( IENDDAY ) ; 
    __context__.SourceCodeLine = 5355;
    DEST . IENDHOUR = (ushort) ( IENDHOUR ) ; 
    __context__.SourceCodeLine = 5356;
    DEST . IENDMIN = (ushort) ( IENDMIN ) ; 
    __context__.SourceCodeLine = 5357;
    DEST . IENDSEC = (ushort) ( IENDSEC ) ; 
    
    }
    
private void RESERVENOWSETDATA (  SplusExecutionContext __context__, ushort MAX_TIME , RESERVENOWDATA TEMP ) 
    { 
    
    __context__.SourceCodeLine = 5362;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 30))  ) ) 
        { 
        __context__.SourceCodeLine = 5364;
        COPYRESERVENOWDATA (  __context__ , SELECT30MIN, TEMP) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 5366;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 60))  ) ) 
            { 
            __context__.SourceCodeLine = 5368;
            COPYRESERVENOWDATA (  __context__ , SELECT60MIN, TEMP) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 5370;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAX_TIME == 90))  ) ) 
                { 
                __context__.SourceCodeLine = 5372;
                COPYRESERVENOWDATA (  __context__ , SELECT90MIN, TEMP) ; 
                } 
            
            }
        
        }
    
    
    }
    
private ushort SETRESERVENOWSTARTEND (  SplusExecutionContext __context__, ushort MIN_TIME , ushort MAX_TIME ) 
    { 
    ushort ICURRENTTIME = 0;
    ushort INEXTEVENT = 0;
    ushort ISTARTTIMEMINUTES = 0;
    ushort IENDTIMEMINUTES = 0;
    ushort INEXTSTARTTIMEMINUTES = 0;
    ushort IDURATIONMINUTES = 0;
    
    CrestronString SCURRENTDATE;
    CrestronString SCURRENTTIME;
    CrestronString SNEXTSTARTTIME;
    CrestronString SDTSTART;
    CrestronString SDTEND;
    SCURRENTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SCURRENTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    SNEXTSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    SDTSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    SDTEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    ushort ICURRENTMONTH = 0;
    ushort ICURRENTDAY = 0;
    ushort ICURRENTYEAR = 0;
    ushort ICURRENTDAYSINMONTH = 0;
    
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
    
    CrestronString SSTARTTIME;
    CrestronString SENDTIME;
    SSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    RESERVENOWDATA TEMP;
    TEMP  = new RESERVENOWDATA( this, true );
    TEMP .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 5427;
    SCURRENTDATE  .UpdateValue ( G_SDATETODAY  ) ; 
    __context__.SourceCodeLine = 5428;
    SCURRENTTIME  .UpdateValue ( Functions.Time ( )  ) ; 
    __context__.SourceCodeLine = 5429;
    SCURRENTTIME  .UpdateValue ( Functions.Left ( SCURRENTTIME ,  (int) ( 5 ) )  ) ; 
    __context__.SourceCodeLine = 5430;
    ICURRENTTIME = (ushort) ( TIMETOINTEGER( __context__ , SCURRENTTIME , (ushort)( 1 ) ) ) ; 
    __context__.SourceCodeLine = 5432;
    ICURRENTMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SCURRENTDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
    __context__.SourceCodeLine = 5433;
    ICURRENTDAY = (ushort) ( Functions.Atoi( Functions.Right( SCURRENTDATE , (int)( 2 ) ) ) ) ; 
    __context__.SourceCodeLine = 5434;
    ICURRENTYEAR = (ushort) ( Functions.Atoi( Functions.Left( SCURRENTDATE , (int)( 4 ) ) ) ) ; 
    __context__.SourceCodeLine = 5437;
    INEXTEVENT = (ushort) ( NEXTRESERVATION( __context__ , (ushort)( 0 ) ) ) ; 
    __context__.SourceCodeLine = 5439;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTEVENT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 5443;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 5445;
            Trace( "  There is a next reservation. Need to calculate duration.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 5449;
        SNEXTSTARTTIME  .UpdateValue ( MEETINGEVENT [ INEXTEVENT] . STARTTIME  ) ; 
        __context__.SourceCodeLine = 5450;
        INEXTSTARTTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SNEXTSTARTTIME , (ushort)( 2 ) ) ) ; 
        __context__.SourceCodeLine = 5453;
        ISTARTTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SCURRENTTIME , (ushort)( 2 ) ) ) ; 
        __context__.SourceCodeLine = 5456;
        IENDTIMEMINUTES = (ushort) ( (ISTARTTIMEMINUTES + MAX_TIME) ) ; 
        __context__.SourceCodeLine = 5459;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDTIMEMINUTES > INEXTSTARTTIMEMINUTES ))  ) ) 
            { 
            __context__.SourceCodeLine = 5463;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5465;
                Trace( "  End time into next meeting. Need to trim back\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 5469;
            IENDTIMEMINUTES = (ushort) ( INEXTSTARTTIMEMINUTES ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 5476;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5478;
                Trace( "  End time not into next meeting. Leave as is.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 5481;
            if ( Functions.TestForTrue  ( ( RESERVE_NOW_EVEN_END_TIME  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5483;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 5485;
                    Trace( "Force Even End Time") ; 
                    } 
                
                __context__.SourceCodeLine = 5488;
                IENDTIMEMINUTES = (ushort) ( (IENDTIMEMINUTES - Mod( IENDTIMEMINUTES , 30 )) ) ; 
                } 
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 5496;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 5498;
            Trace( "  There is not a next reservation. Book as long as possible.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 5502;
        ISTARTTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SCURRENTTIME , (ushort)( 2 ) ) ) ; 
        __context__.SourceCodeLine = 5505;
        IENDTIMEMINUTES = (ushort) ( (ISTARTTIMEMINUTES + MAX_TIME) ) ; 
        __context__.SourceCodeLine = 5507;
        if ( Functions.TestForTrue  ( ( RESERVE_NOW_EVEN_END_TIME  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 5509;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5511;
                Trace( "Force Even End Time") ; 
                } 
            
            __context__.SourceCodeLine = 5514;
            IENDTIMEMINUTES = (ushort) ( (IENDTIMEMINUTES - Mod( IENDTIMEMINUTES , 30 )) ) ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 5518;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5520;
        Trace( "  iStartTimeMinutes:{0:d}\r\n", (ushort)ISTARTTIMEMINUTES) ; 
        __context__.SourceCodeLine = 5521;
        Trace( "  iEndTimeMinutes:{0:d}\r\n", (ushort)IENDTIMEMINUTES) ; 
        } 
    
    __context__.SourceCodeLine = 5526;
    IENDHOUR = (ushort) ( (IENDTIMEMINUTES / 60) ) ; 
    __context__.SourceCodeLine = 5529;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IENDHOUR >= 24 ))  ) ) 
        { 
        __context__.SourceCodeLine = 5538;
        ICURRENTDAYSINMONTH = (ushort) ( DAYSINMONTH( __context__ , (ushort)( ICURRENTMONTH ) , (ushort)( ICURRENTYEAR ) ) ) ; 
        __context__.SourceCodeLine = 5541;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTDAY < ICURRENTDAYSINMONTH ))  ) ) 
            { 
            __context__.SourceCodeLine = 5545;
            ISTARTMONTH = (ushort) ( ICURRENTMONTH ) ; 
            __context__.SourceCodeLine = 5546;
            ISTARTDAY = (ushort) ( (ICURRENTDAY + 1) ) ; 
            __context__.SourceCodeLine = 5547;
            ISTARTYEAR = (ushort) ( ICURRENTYEAR ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 5554;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTMONTH < 12 ))  ) ) 
                { 
                __context__.SourceCodeLine = 5558;
                ISTARTMONTH = (ushort) ( (ISTARTMONTH + 1) ) ; 
                __context__.SourceCodeLine = 5559;
                ISTARTDAY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 5560;
                ISTARTYEAR = (ushort) ( ICURRENTYEAR ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 5566;
                ISTARTMONTH = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 5567;
                ISTARTDAY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 5568;
                ISTARTYEAR = (ushort) ( (ISTARTYEAR + 1) ) ; 
                } 
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 5576;
        ISTARTMONTH = (ushort) ( ICURRENTMONTH ) ; 
        __context__.SourceCodeLine = 5577;
        ISTARTDAY = (ushort) ( ICURRENTDAY ) ; 
        __context__.SourceCodeLine = 5578;
        ISTARTYEAR = (ushort) ( ICURRENTYEAR ) ; 
        __context__.SourceCodeLine = 5580;
        ISTARTHOUR = (ushort) ( (ISTARTTIMEMINUTES / 60) ) ; 
        __context__.SourceCodeLine = 5581;
        ISTARTMIN = (ushort) ( Mod( ISTARTTIMEMINUTES , 60 ) ) ; 
        __context__.SourceCodeLine = 5583;
        IENDMONTH = (ushort) ( ICURRENTMONTH ) ; 
        __context__.SourceCodeLine = 5584;
        IENDDAY = (ushort) ( ICURRENTDAY ) ; 
        __context__.SourceCodeLine = 5585;
        IENDYEAR = (ushort) ( ICURRENTYEAR ) ; 
        __context__.SourceCodeLine = 5587;
        IENDHOUR = (ushort) ( (IENDTIMEMINUTES / 60) ) ; 
        __context__.SourceCodeLine = 5588;
        IENDMIN = (ushort) ( Mod( IENDTIMEMINUTES , 60 ) ) ; 
        } 
    
    __context__.SourceCodeLine = 5591;
    SSTARTTIME  .UpdateValue ( Functions.ItoA (  (int) ( ISTARTHOUR ) ) + ":" + Functions.ItoA (  (int) ( ISTARTMIN ) )  ) ; 
    __context__.SourceCodeLine = 5592;
    SENDTIME  .UpdateValue ( Functions.ItoA (  (int) ( IENDHOUR ) ) + ":" + Functions.ItoA (  (int) ( IENDMIN ) )  ) ; 
    __context__.SourceCodeLine = 5594;
    SSTARTTIME  .UpdateValue ( FORMATTIME (  __context__ , SSTARTTIME)  ) ; 
    __context__.SourceCodeLine = 5595;
    SENDTIME  .UpdateValue ( FORMATTIME (  __context__ , SENDTIME)  ) ; 
    __context__.SourceCodeLine = 5597;
    IDURATIONMINUTES = (ushort) ( (IENDTIMEMINUTES - ISTARTTIMEMINUTES) ) ; 
    __context__.SourceCodeLine = 5599;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5601;
        Trace( "  iStartMonth:{0:d}\r\n", (ushort)ISTARTMONTH) ; 
        __context__.SourceCodeLine = 5602;
        Trace( "  iStartDay:{0:d}\r\n", (ushort)ISTARTDAY) ; 
        __context__.SourceCodeLine = 5603;
        Trace( "  iStartYear:{0:d}\r\n", (ushort)ISTARTYEAR) ; 
        __context__.SourceCodeLine = 5604;
        Trace( "  iStartHour:{0:d}\r\n", (ushort)ISTARTHOUR) ; 
        __context__.SourceCodeLine = 5605;
        Trace( "  iStartMin:{0:d}\r\n", (ushort)ISTARTMIN) ; 
        __context__.SourceCodeLine = 5606;
        Trace( "  iEndMonth:{0:d}\r\n", (ushort)IENDMONTH) ; 
        __context__.SourceCodeLine = 5607;
        Trace( "  iEndDay:{0:d}\r\n", (ushort)IENDDAY) ; 
        __context__.SourceCodeLine = 5608;
        Trace( "  iEndYear:{0:d}\r\n", (ushort)IENDYEAR) ; 
        __context__.SourceCodeLine = 5609;
        Trace( "  iEndHour:{0:d}\r\n", (ushort)IENDHOUR) ; 
        __context__.SourceCodeLine = 5610;
        Trace( "  iEndMin:{0:d}\r\n", (ushort)IENDMIN) ; 
        __context__.SourceCodeLine = 5611;
        Trace( "  iDurationMinutes: {0:d}\r\n", (ushort)IDURATIONMINUTES) ; 
        } 
    
    __context__.SourceCodeLine = 5614;
    TEMP . ISTARTYEAR = (ushort) ( ISTARTYEAR ) ; 
    __context__.SourceCodeLine = 5615;
    TEMP . ISTARTMONTH = (ushort) ( ISTARTMONTH ) ; 
    __context__.SourceCodeLine = 5616;
    TEMP . ISTARTDAY = (ushort) ( ISTARTDAY ) ; 
    __context__.SourceCodeLine = 5617;
    TEMP . ISTARTHOUR = (ushort) ( ISTARTHOUR ) ; 
    __context__.SourceCodeLine = 5618;
    TEMP . ISTARTMIN = (ushort) ( ISTARTMIN ) ; 
    __context__.SourceCodeLine = 5619;
    TEMP . ISTARTSEC = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5621;
    TEMP . IENDYEAR = (ushort) ( IENDYEAR ) ; 
    __context__.SourceCodeLine = 5622;
    TEMP . IENDMONTH = (ushort) ( IENDMONTH ) ; 
    __context__.SourceCodeLine = 5623;
    TEMP . IENDDAY = (ushort) ( IENDDAY ) ; 
    __context__.SourceCodeLine = 5624;
    TEMP . IENDHOUR = (ushort) ( IENDHOUR ) ; 
    __context__.SourceCodeLine = 5625;
    TEMP . IENDMIN = (ushort) ( IENDMIN ) ; 
    __context__.SourceCodeLine = 5626;
    TEMP . IENDSEC = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5628;
    if ( Functions.TestForTrue  ( ( RESERVE_NOW_TIME_SELECT  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5630;
        RESERVENOWSETLABELS (  __context__ , (ushort)( MAX_TIME ), (ushort)( IDURATIONMINUTES )) ; 
        __context__.SourceCodeLine = 5631;
        RESERVENOWSETDATA (  __context__ , (ushort)( MAX_TIME ), TEMP) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 5637;
        RESERVE_NOW_START_TIME__DOLLAR__  .UpdateValue ( SSTARTTIME  ) ; 
        __context__.SourceCodeLine = 5638;
        RESERVE_NOW_END_TIME__DOLLAR__  .UpdateValue ( SENDTIME  ) ; 
        __context__.SourceCodeLine = 5641;
        G_SRESERVENOWDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , TEMP, "Start")  ) ; 
        __context__.SourceCodeLine = 5642;
        G_SRESERVENOWDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , TEMP, "End")  ) ; 
        } 
    
    __context__.SourceCodeLine = 5645;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDURATIONMINUTES < MIN_TIME ))  ) ) 
        { 
        __context__.SourceCodeLine = 5647;
        return (ushort)( 0) ; 
        } 
    
    __context__.SourceCodeLine = 5650;
    return (ushort)( 1) ; 
    
    }
    
private void RESERVENOW (  SplusExecutionContext __context__ ) 
    { 
    CrestronString SXML;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    
    __context__.SourceCodeLine = 5671;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5673;
        Trace( "\r\n** ReserveNow **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 5676;
    ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5677;
    G_BSTARTMEETINGCONFIRMED = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 5679;
    RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 5681;
    RESERVE_NOW_MESSAGE__DOLLAR__  .UpdateValue ( "Please wait while the request\ris processed."  ) ; 
    __context__.SourceCodeLine = 5684;
    G_SRESERVENOWREQUESTID  .UpdateValue ( "RSRVNOW" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
    __context__.SourceCodeLine = 5687;
    SXML  .UpdateValue ( "<CreateSchedule>" + "<RequestID>" + G_SRESERVENOWREQUESTID + "</RequestID>" + "<Event>" + "<dtStart>" + G_SRESERVENOWDTSTART + "</dtStart>" + "<dtEnd>" + G_SRESERVENOWDTEND + "</dtEnd>" + "<Organizer>" + RESERVE_NOW_ORGANIZER__DOLLAR__ + "</Organizer>" + "<Subject>" + RESERVE_NOW_SUBJECT__DOLLAR__ + "</Subject>" + "</Event>" + "</CreateSchedule>"  ) ; 
    __context__.SourceCodeLine = 5699;
    do 
        { 
        __context__.SourceCodeLine = 5702;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
            { 
            __context__.SourceCodeLine = 5704;
            TO_RV_CREATEMEETING__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 5708;
            TO_RV_CREATEMEETING__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
            } 
        
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
    
    }
    
private void STARTMEETING (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 5730;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5732;
        Trace( "Start Meeting Confirmed") ; 
        } 
    
    __context__.SourceCodeLine = 5734;
    G_BSTARTMEETINGCONFIRMED = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 5737;
    START_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5738;
    START_MEETING_BTN_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5739;
    START_MEETING_BTN_SUB  .Value = (ushort) ( 0 ) ; 
    
    }
    
private void ENDMEETING (  SplusExecutionContext __context__ ) 
    { 
    CrestronString SXML;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    
    __context__.SourceCodeLine = 5759;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5761;
        Trace( "\r\n** EndMeeting **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 5764;
    END_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5765;
    END_MEETING_BTN_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5766;
    END_MEETING_BTN_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5768;
    END_MEETING_REQUEST_MODE  .Value = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 5770;
    RESERVE_NOW_MESSAGE__DOLLAR__  .UpdateValue ( "Please wait while the request\ris processed."  ) ; 
    __context__.SourceCodeLine = 5773;
    G_SENDMEETINGREQUESTID  .UpdateValue ( "EndMeeting" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
    __context__.SourceCodeLine = 5776;
    G_SENDMEETINGREQMEETINGID  .UpdateValue ( MEETINGEVENT [ G_ICURRENTEVENTNUM] . MEETINGID  ) ; 
    __context__.SourceCodeLine = 5778;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5780;
        Trace( "Request ID = {0}", G_SENDMEETINGREQUESTID ) ; 
        __context__.SourceCodeLine = 5781;
        Trace( "Meeting ID = {0}", G_SENDMEETINGREQMEETINGID ) ; 
        } 
    
    __context__.SourceCodeLine = 5785;
    SXML  .UpdateValue ( "<RequestAction>" + "<RequestID>" + G_SENDMEETINGREQUESTID + "</RequestID>" + "<ActionID>MeetingChange</ActionID>" + "<Parameters>" + "<Parameter ID=\u0022MeetingID\u0022 Value=\u0022" + G_SENDMEETINGREQMEETINGID + "\u0022 />" + "<Parameter ID=\u0022EndTime\u0022 Value=\u0022" + G_SDATETODAY + "T" + G_SCURRENTTIME + ":00" + "\u0022 />" + "</Parameters>" + "</RequestAction>"  ) ; 
    __context__.SourceCodeLine = 5795;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5797;
        Trace( "sXML = {0}", SXML ) ; 
        } 
    
    __context__.SourceCodeLine = 5801;
    do 
        { 
        __context__.SourceCodeLine = 5804;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SXML ) > 240 ))  ) ) 
            { 
            __context__.SourceCodeLine = 5806;
            TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SXML )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 5810;
            TO_RV_ACTIONQUERY__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SXML ), SXML )  ) ; 
            } 
        
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SXML ) == 0)) )); 
    
    }
    
private void SHIFTEVENTS (  SplusExecutionContext __context__, ushort ITYPE , CrestronString SDIRECTION , ushort ISTARTINDEX , ushort IENDINDEX ) 
    { 
    ushort I = 0;
    ushort INEW = 0;
    
    
    __context__.SourceCodeLine = 5822;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5824;
        Trace( "\r\n** ShiftEvents **\r\n") ; 
        __context__.SourceCodeLine = 5825;
        Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
        __context__.SourceCodeLine = 5826;
        Trace( "  Direction:{0}\r\n", SDIRECTION ) ; 
        __context__.SourceCodeLine = 5827;
        Trace( "  StartIndex:{0:d}\r\n", (ushort)ISTARTINDEX) ; 
        __context__.SourceCodeLine = 5828;
        Trace( "  EndIndex:{0:d}\r\n", (ushort)IENDINDEX) ; 
        } 
    
    __context__.SourceCodeLine = 5831;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDIRECTION == "Up"))  ) ) 
        { 
        __context__.SourceCodeLine = 5833;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 5837;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTINDEX ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IENDINDEX; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 5839;
                MEETINGEVENT [ I] . STARTBLOCK = (ushort) ( MEETINGEVENT[ (I + 1) ].STARTBLOCK ) ; 
                __context__.SourceCodeLine = 5840;
                MEETINGEVENT [ I] . ENDBLOCK = (ushort) ( MEETINGEVENT[ (I + 1) ].ENDBLOCK ) ; 
                __context__.SourceCodeLine = 5841;
                MEETINGEVENT [ I] . STARTDATE  .UpdateValue ( MEETINGEVENT [ (I + 1)] . STARTDATE  ) ; 
                __context__.SourceCodeLine = 5842;
                MEETINGEVENT [ I] . ENDDATE  .UpdateValue ( MEETINGEVENT [ (I + 1)] . ENDDATE  ) ; 
                __context__.SourceCodeLine = 5843;
                MEETINGEVENT [ I] . STARTTIME  .UpdateValue ( MEETINGEVENT [ (I + 1)] . STARTTIME  ) ; 
                __context__.SourceCodeLine = 5844;
                MEETINGEVENT [ I] . ENDTIME  .UpdateValue ( MEETINGEVENT [ (I + 1)] . ENDTIME  ) ; 
                __context__.SourceCodeLine = 5845;
                MEETINGEVENT [ I] . MEETINGID  .UpdateValue ( MEETINGEVENT [ (I + 1)] . MEETINGID  ) ; 
                __context__.SourceCodeLine = 5846;
                MEETINGEVENT [ I] . RVMEETINGID  .UpdateValue ( MEETINGEVENT [ (I + 1)] . RVMEETINGID  ) ; 
                __context__.SourceCodeLine = 5847;
                MEETINGEVENT [ I] . INSTANCEID  .UpdateValue ( MEETINGEVENT [ (I + 1)] . INSTANCEID  ) ; 
                __context__.SourceCodeLine = 5848;
                MEETINGEVENT [ I] . SUBJECT  .UpdateValue ( MEETINGEVENT [ (I + 1)] . SUBJECT  ) ; 
                __context__.SourceCodeLine = 5849;
                MEETINGEVENT [ I] . ISPRIVATE = (ushort) ( MEETINGEVENT[ (I + 1) ].ISPRIVATE ) ; 
                __context__.SourceCodeLine = 5850;
                MEETINGEVENT [ I] . ISEXCHANGEPRIVATE = (ushort) ( MEETINGEVENT[ (I + 1) ].ISEXCHANGEPRIVATE ) ; 
                __context__.SourceCodeLine = 5851;
                MEETINGEVENT [ I] . ORGANIZER  .UpdateValue ( MEETINGEVENT [ (I + 1)] . ORGANIZER  ) ; 
                __context__.SourceCodeLine = 5852;
                MEETINGEVENT [ I] . RECURRING = (ushort) ( MEETINGEVENT[ (I + 1) ].RECURRING ) ; 
                __context__.SourceCodeLine = 5837;
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 5855;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 5859;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( ISTARTINDEX ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)IENDINDEX; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 5861;
                    AUTOUPDATEMEETINGEVENT [ I] . STARTBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ (I + 1) ].STARTBLOCK ) ; 
                    __context__.SourceCodeLine = 5862;
                    AUTOUPDATEMEETINGEVENT [ I] . ENDBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ (I + 1) ].ENDBLOCK ) ; 
                    __context__.SourceCodeLine = 5863;
                    AUTOUPDATEMEETINGEVENT [ I] . STARTDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . STARTDATE  ) ; 
                    __context__.SourceCodeLine = 5864;
                    AUTOUPDATEMEETINGEVENT [ I] . ENDDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . ENDDATE  ) ; 
                    __context__.SourceCodeLine = 5865;
                    AUTOUPDATEMEETINGEVENT [ I] . STARTTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . STARTTIME  ) ; 
                    __context__.SourceCodeLine = 5866;
                    AUTOUPDATEMEETINGEVENT [ I] . ENDTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . ENDTIME  ) ; 
                    __context__.SourceCodeLine = 5867;
                    AUTOUPDATEMEETINGEVENT [ I] . MEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . MEETINGID  ) ; 
                    __context__.SourceCodeLine = 5868;
                    AUTOUPDATEMEETINGEVENT [ I] . RVMEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . RVMEETINGID  ) ; 
                    __context__.SourceCodeLine = 5869;
                    AUTOUPDATEMEETINGEVENT [ I] . INSTANCEID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . INSTANCEID  ) ; 
                    __context__.SourceCodeLine = 5870;
                    AUTOUPDATEMEETINGEVENT [ I] . SUBJECT  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . SUBJECT  ) ; 
                    __context__.SourceCodeLine = 5871;
                    AUTOUPDATEMEETINGEVENT [ I] . ISPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ (I + 1) ].ISPRIVATE ) ; 
                    __context__.SourceCodeLine = 5872;
                    AUTOUPDATEMEETINGEVENT [ I] . ISEXCHANGEPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ (I + 1) ].ISEXCHANGEPRIVATE ) ; 
                    __context__.SourceCodeLine = 5873;
                    AUTOUPDATEMEETINGEVENT [ I] . ORGANIZER  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ (I + 1)] . ORGANIZER  ) ; 
                    __context__.SourceCodeLine = 5874;
                    AUTOUPDATEMEETINGEVENT [ I] . RECURRING = (ushort) ( AUTOUPDATEMEETINGEVENT[ (I + 1) ].RECURRING ) ; 
                    __context__.SourceCodeLine = 5859;
                    } 
                
                } 
            
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 5878;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDIRECTION == "Down"))  ) ) 
            { 
            __context__.SourceCodeLine = 5880;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 5884;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( IENDINDEX ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)ISTARTINDEX; 
                int __FN_FORSTEP_VAL__3 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 5886;
                    MEETINGEVENT [ (I + 1)] . STARTBLOCK = (ushort) ( MEETINGEVENT[ I ].STARTBLOCK ) ; 
                    __context__.SourceCodeLine = 5887;
                    MEETINGEVENT [ (I + 1)] . ENDBLOCK = (ushort) ( MEETINGEVENT[ I ].ENDBLOCK ) ; 
                    __context__.SourceCodeLine = 5888;
                    MEETINGEVENT [ (I + 1)] . STARTDATE  .UpdateValue ( MEETINGEVENT [ I] . STARTDATE  ) ; 
                    __context__.SourceCodeLine = 5889;
                    MEETINGEVENT [ (I + 1)] . ENDDATE  .UpdateValue ( MEETINGEVENT [ I] . ENDDATE  ) ; 
                    __context__.SourceCodeLine = 5890;
                    MEETINGEVENT [ (I + 1)] . STARTTIME  .UpdateValue ( MEETINGEVENT [ I] . STARTTIME  ) ; 
                    __context__.SourceCodeLine = 5891;
                    MEETINGEVENT [ (I + 1)] . ENDTIME  .UpdateValue ( MEETINGEVENT [ I] . ENDTIME  ) ; 
                    __context__.SourceCodeLine = 5892;
                    MEETINGEVENT [ (I + 1)] . MEETINGID  .UpdateValue ( MEETINGEVENT [ I] . MEETINGID  ) ; 
                    __context__.SourceCodeLine = 5893;
                    MEETINGEVENT [ (I + 1)] . RVMEETINGID  .UpdateValue ( MEETINGEVENT [ I] . RVMEETINGID  ) ; 
                    __context__.SourceCodeLine = 5894;
                    MEETINGEVENT [ (I + 1)] . INSTANCEID  .UpdateValue ( MEETINGEVENT [ I] . INSTANCEID  ) ; 
                    __context__.SourceCodeLine = 5895;
                    MEETINGEVENT [ (I + 1)] . SUBJECT  .UpdateValue ( MEETINGEVENT [ I] . SUBJECT  ) ; 
                    __context__.SourceCodeLine = 5896;
                    MEETINGEVENT [ (I + 1)] . ISPRIVATE = (ushort) ( MEETINGEVENT[ I ].ISPRIVATE ) ; 
                    __context__.SourceCodeLine = 5897;
                    MEETINGEVENT [ (I + 1)] . ISEXCHANGEPRIVATE = (ushort) ( MEETINGEVENT[ I ].ISEXCHANGEPRIVATE ) ; 
                    __context__.SourceCodeLine = 5898;
                    MEETINGEVENT [ (I + 1)] . ORGANIZER  .UpdateValue ( MEETINGEVENT [ I] . ORGANIZER  ) ; 
                    __context__.SourceCodeLine = 5899;
                    MEETINGEVENT [ (I + 1)] . RECURRING = (ushort) ( MEETINGEVENT[ I ].RECURRING ) ; 
                    __context__.SourceCodeLine = 5884;
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 5902;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 5906;
                    ushort __FN_FORSTART_VAL__4 = (ushort) ( IENDINDEX ) ;
                    ushort __FN_FOREND_VAL__4 = (ushort)ISTARTINDEX; 
                    int __FN_FORSTEP_VAL__4 = (int)Functions.ToLongInteger( -( 1 ) ); 
                    for ( I  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (I  >= __FN_FORSTART_VAL__4) && (I  <= __FN_FOREND_VAL__4) ) : ( (I  <= __FN_FORSTART_VAL__4) && (I  >= __FN_FOREND_VAL__4) ) ; I  += (ushort)__FN_FORSTEP_VAL__4) 
                        { 
                        __context__.SourceCodeLine = 5908;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . STARTBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].STARTBLOCK ) ; 
                        __context__.SourceCodeLine = 5909;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . ENDBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].ENDBLOCK ) ; 
                        __context__.SourceCodeLine = 5910;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . STARTDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . STARTDATE  ) ; 
                        __context__.SourceCodeLine = 5911;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . ENDDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . ENDDATE  ) ; 
                        __context__.SourceCodeLine = 5912;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . STARTTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . STARTTIME  ) ; 
                        __context__.SourceCodeLine = 5913;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . ENDTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . ENDTIME  ) ; 
                        __context__.SourceCodeLine = 5914;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . MEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . MEETINGID  ) ; 
                        __context__.SourceCodeLine = 5915;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . RVMEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . RVMEETINGID  ) ; 
                        __context__.SourceCodeLine = 5916;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . INSTANCEID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . INSTANCEID  ) ; 
                        __context__.SourceCodeLine = 5917;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . SUBJECT  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . SUBJECT  ) ; 
                        __context__.SourceCodeLine = 5918;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . ISPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].ISPRIVATE ) ; 
                        __context__.SourceCodeLine = 5919;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . ISEXCHANGEPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].ISEXCHANGEPRIVATE ) ; 
                        __context__.SourceCodeLine = 5920;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . ORGANIZER  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . ORGANIZER  ) ; 
                        __context__.SourceCodeLine = 5921;
                        AUTOUPDATEMEETINGEVENT [ (I + 1)] . RECURRING = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].RECURRING ) ; 
                        __context__.SourceCodeLine = 5906;
                        } 
                    
                    } 
                
                }
            
            } 
        
        }
    
    
    }
    
private ushort EVENTINSERTINDEX (  SplusExecutionContext __context__, ushort IDATATYPE , CrestronString SSTARTDATE , CrestronString SSTARTTIME ) 
    { 
    ushort I = 0;
    ushort IINDEX = 0;
    
    
    __context__.SourceCodeLine = 5932;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 5934;
        Trace( "\r\n** EventInsertIndex **\r\n") ; 
        __context__.SourceCodeLine = 5935;
        Trace( "  DataType:{0:d}\r\n", (ushort)IDATATYPE) ; 
        __context__.SourceCodeLine = 5936;
        Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
        __context__.SourceCodeLine = 5937;
        Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
        } 
    
    __context__.SourceCodeLine = 5940;
    IINDEX = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 5942;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDATATYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 5947;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SSTARTDATE ) < DATETOINTEGER( __context__ , MEETINGEVENT[ 1 ].STARTDATE ) ))  ) ) 
            { 
            __context__.SourceCodeLine = 5951;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5953;
                Trace( "  Event start date prior to first event start date.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 5956;
            IINDEX = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 5962;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 5964;
                Trace( "  Event does not start prior to first. Check start time.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 5967;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_ISTOREDEVENTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 5969;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSTARTDATE == MEETINGEVENT[ I ].STARTDATE))  ) ) 
                    { 
                    __context__.SourceCodeLine = 5971;
                    if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SSTARTTIME , MEETINGEVENT[ I ].STARTTIME ) < 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 5973;
                        IINDEX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 5975;
                        break ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 5967;
                } 
            
            } 
        
        __context__.SourceCodeLine = 5982;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINDEX == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 5984;
            IINDEX = (ushort) ( (G_ISTOREDEVENTCOUNT + 1) ) ; 
            } 
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 5987;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDATATYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 5992;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SSTARTDATE ) < DATETOINTEGER( __context__ , AUTOUPDATEMEETINGEVENT[ 1 ].STARTDATE ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 5996;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 5998;
                    Trace( "  Event start date prior to first event start date.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 6001;
                IINDEX = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 6007;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 6009;
                    Trace( "  Event does not start prior to first. Check start time.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 6012;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)G_IAUTOUPDATESTOREDEVENTCOUNT; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 6014;
                    if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SSTARTTIME , AUTOUPDATEMEETINGEVENT[ I ].STARTTIME ) < 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 6016;
                        IINDEX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 6018;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 6012;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 6024;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINDEX == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 6026;
                IINDEX = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT + 1) ) ; 
                } 
            
            } 
        
        }
    
    __context__.SourceCodeLine = 6029;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6031;
        Trace( "  InsertIndex:{0:d}\r\n", (ushort)IINDEX) ; 
        } 
    
    __context__.SourceCodeLine = 6034;
    return (ushort)( IINDEX) ; 
    
    }
    
private ushort MOVEEVENT (  SplusExecutionContext __context__, ushort ITYPE , ushort IEVENTCURRENTINDEX , CrestronString SNEWSTARTDATE , CrestronString SNEWSTARTTIME ) 
    { 
    ushort ILASTINDEX = 0;
    ushort IMOVETOINDEX = 0;
    
    
    __context__.SourceCodeLine = 6042;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6044;
        Trace( "\r\n** MoveEvent **\r\n") ; 
        __context__.SourceCodeLine = 6045;
        Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
        __context__.SourceCodeLine = 6046;
        Trace( "  CurrentIndex:{0:d}\r\n", (ushort)IEVENTCURRENTINDEX) ; 
        __context__.SourceCodeLine = 6047;
        Trace( "  NewStartDate:{0}\r\n", SNEWSTARTDATE ) ; 
        __context__.SourceCodeLine = 6048;
        Trace( "  NewStartTime:{0}\r\n", SNEWSTARTTIME ) ; 
        } 
    
    __context__.SourceCodeLine = 6052;
    IMOVETOINDEX = (ushort) ( EVENTINSERTINDEX( __context__ , (ushort)( ITYPE ) , SNEWSTARTDATE , SNEWSTARTTIME ) ) ; 
    __context__.SourceCodeLine = 6055;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMOVETOINDEX != IEVENTCURRENTINDEX))  ) ) 
        { 
        __context__.SourceCodeLine = 6059;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 6061;
            Trace( "  Move to index != current index.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 6066;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 6070;
            ILASTINDEX = (ushort) ( G_ISTOREDEVENTCOUNT ) ; 
            __context__.SourceCodeLine = 6072;
            TEMPMOVEEVENT . STARTBLOCK = (ushort) ( MEETINGEVENT[ IEVENTCURRENTINDEX ].STARTBLOCK ) ; 
            __context__.SourceCodeLine = 6073;
            TEMPMOVEEVENT . ENDBLOCK = (ushort) ( MEETINGEVENT[ IEVENTCURRENTINDEX ].ENDBLOCK ) ; 
            __context__.SourceCodeLine = 6074;
            TEMPMOVEEVENT . STARTDATE  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . STARTDATE  ) ; 
            __context__.SourceCodeLine = 6075;
            TEMPMOVEEVENT . ENDDATE  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . ENDDATE  ) ; 
            __context__.SourceCodeLine = 6076;
            TEMPMOVEEVENT . STARTTIME  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . STARTTIME  ) ; 
            __context__.SourceCodeLine = 6077;
            TEMPMOVEEVENT . ENDTIME  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . ENDTIME  ) ; 
            __context__.SourceCodeLine = 6078;
            TEMPMOVEEVENT . MEETINGID  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . MEETINGID  ) ; 
            __context__.SourceCodeLine = 6079;
            TEMPMOVEEVENT . RVMEETINGID  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . RVMEETINGID  ) ; 
            __context__.SourceCodeLine = 6080;
            TEMPMOVEEVENT . INSTANCEID  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . INSTANCEID  ) ; 
            __context__.SourceCodeLine = 6081;
            TEMPMOVEEVENT . SUBJECT  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . SUBJECT  ) ; 
            __context__.SourceCodeLine = 6082;
            TEMPMOVEEVENT . ISPRIVATE = (ushort) ( MEETINGEVENT[ IEVENTCURRENTINDEX ].ISPRIVATE ) ; 
            __context__.SourceCodeLine = 6083;
            TEMPMOVEEVENT . ISEXCHANGEPRIVATE = (ushort) ( MEETINGEVENT[ IEVENTCURRENTINDEX ].ISEXCHANGEPRIVATE ) ; 
            __context__.SourceCodeLine = 6084;
            TEMPMOVEEVENT . ORGANIZER  .UpdateValue ( MEETINGEVENT [ IEVENTCURRENTINDEX] . ORGANIZER  ) ; 
            __context__.SourceCodeLine = 6085;
            TEMPMOVEEVENT . RECURRING = (ushort) ( MEETINGEVENT[ IEVENTCURRENTINDEX ].RECURRING ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 6087;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 6091;
                ILASTINDEX = (ushort) ( G_IAUTOUPDATESTOREDEVENTCOUNT ) ; 
                __context__.SourceCodeLine = 6093;
                TEMPMOVEEVENT . STARTBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ IEVENTCURRENTINDEX ].STARTBLOCK ) ; 
                __context__.SourceCodeLine = 6094;
                TEMPMOVEEVENT . ENDBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ IEVENTCURRENTINDEX ].ENDBLOCK ) ; 
                __context__.SourceCodeLine = 6095;
                TEMPMOVEEVENT . STARTDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . STARTDATE  ) ; 
                __context__.SourceCodeLine = 6096;
                TEMPMOVEEVENT . ENDDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . ENDDATE  ) ; 
                __context__.SourceCodeLine = 6097;
                TEMPMOVEEVENT . STARTTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . STARTTIME  ) ; 
                __context__.SourceCodeLine = 6098;
                TEMPMOVEEVENT . ENDTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . ENDTIME  ) ; 
                __context__.SourceCodeLine = 6099;
                TEMPMOVEEVENT . MEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . MEETINGID  ) ; 
                __context__.SourceCodeLine = 6100;
                TEMPMOVEEVENT . RVMEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . RVMEETINGID  ) ; 
                __context__.SourceCodeLine = 6101;
                TEMPMOVEEVENT . INSTANCEID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . INSTANCEID  ) ; 
                __context__.SourceCodeLine = 6102;
                TEMPMOVEEVENT . SUBJECT  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . SUBJECT  ) ; 
                __context__.SourceCodeLine = 6103;
                TEMPMOVEEVENT . ISPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ IEVENTCURRENTINDEX ].ISPRIVATE ) ; 
                __context__.SourceCodeLine = 6104;
                TEMPMOVEEVENT . ISEXCHANGEPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ IEVENTCURRENTINDEX ].ISEXCHANGEPRIVATE ) ; 
                __context__.SourceCodeLine = 6105;
                TEMPMOVEEVENT . ORGANIZER  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ IEVENTCURRENTINDEX] . ORGANIZER  ) ; 
                __context__.SourceCodeLine = 6106;
                TEMPMOVEEVENT . RECURRING = (ushort) ( AUTOUPDATEMEETINGEVENT[ IEVENTCURRENTINDEX ].RECURRING ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 6110;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMOVETOINDEX > ILASTINDEX ))  ) ) 
            { 
            __context__.SourceCodeLine = 6115;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 6117;
                Trace( "  Move to index > last index. Shift events up.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 6121;
            IMOVETOINDEX = (ushort) ( (IMOVETOINDEX - 1) ) ; 
            __context__.SourceCodeLine = 6124;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMOVETOINDEX != IEVENTCURRENTINDEX))  ) ) 
                { 
                __context__.SourceCodeLine = 6128;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 6130;
                    Trace( "  Adjusted move to index <> current index. Shift events up.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 6133;
                SHIFTEVENTS (  __context__ , (ushort)( ITYPE ), "Up", (ushort)( IEVENTCURRENTINDEX ), (ushort)( (IMOVETOINDEX - 1) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 6137;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 6139;
                    Trace( "  Adjusted move to index = current index. Do nothing.\r\n") ; 
                    } 
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 6143;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMOVETOINDEX < IEVENTCURRENTINDEX ))  ) ) 
                { 
                __context__.SourceCodeLine = 6148;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 6150;
                    Trace( "  Move to index < current index. Shift events down.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 6153;
                SHIFTEVENTS (  __context__ , (ushort)( ITYPE ), "Down", (ushort)( IMOVETOINDEX ), (ushort)( (IEVENTCURRENTINDEX - 1) )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 6155;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMOVETOINDEX > IEVENTCURRENTINDEX ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6160;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 6162;
                        Trace( "  Move to index > current index.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 6166;
                    IMOVETOINDEX = (ushort) ( (IMOVETOINDEX - 1) ) ; 
                    __context__.SourceCodeLine = 6169;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMOVETOINDEX != IEVENTCURRENTINDEX))  ) ) 
                        { 
                        __context__.SourceCodeLine = 6173;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 6175;
                            Trace( "  Adjusted move to index <> current index. Shift events up.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 6178;
                        SHIFTEVENTS (  __context__ , (ushort)( ITYPE ), "Up", (ushort)( IEVENTCURRENTINDEX ), (ushort)( (IMOVETOINDEX - 1) )) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 6182;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 6184;
                            Trace( "  Adjusted move to index = current index. Do nothing.\r\n") ; 
                            } 
                        
                        } 
                    
                    } 
                
                }
            
            }
        
        __context__.SourceCodeLine = 6191;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 6193;
            MEETINGEVENT [ IMOVETOINDEX] . STARTBLOCK = (ushort) ( TEMPMOVEEVENT.STARTBLOCK ) ; 
            __context__.SourceCodeLine = 6194;
            MEETINGEVENT [ IMOVETOINDEX] . ENDBLOCK = (ushort) ( TEMPMOVEEVENT.ENDBLOCK ) ; 
            __context__.SourceCodeLine = 6195;
            MEETINGEVENT [ IMOVETOINDEX] . STARTDATE  .UpdateValue ( TEMPMOVEEVENT . STARTDATE  ) ; 
            __context__.SourceCodeLine = 6196;
            MEETINGEVENT [ IMOVETOINDEX] . ENDDATE  .UpdateValue ( TEMPMOVEEVENT . ENDDATE  ) ; 
            __context__.SourceCodeLine = 6197;
            MEETINGEVENT [ IMOVETOINDEX] . STARTTIME  .UpdateValue ( TEMPMOVEEVENT . STARTTIME  ) ; 
            __context__.SourceCodeLine = 6198;
            MEETINGEVENT [ IMOVETOINDEX] . ENDTIME  .UpdateValue ( TEMPMOVEEVENT . ENDTIME  ) ; 
            __context__.SourceCodeLine = 6199;
            MEETINGEVENT [ IMOVETOINDEX] . MEETINGID  .UpdateValue ( TEMPMOVEEVENT . MEETINGID  ) ; 
            __context__.SourceCodeLine = 6200;
            MEETINGEVENT [ IMOVETOINDEX] . RVMEETINGID  .UpdateValue ( TEMPMOVEEVENT . RVMEETINGID  ) ; 
            __context__.SourceCodeLine = 6201;
            MEETINGEVENT [ IMOVETOINDEX] . INSTANCEID  .UpdateValue ( TEMPMOVEEVENT . INSTANCEID  ) ; 
            __context__.SourceCodeLine = 6202;
            MEETINGEVENT [ IMOVETOINDEX] . SUBJECT  .UpdateValue ( TEMPMOVEEVENT . SUBJECT  ) ; 
            __context__.SourceCodeLine = 6203;
            MEETINGEVENT [ IMOVETOINDEX] . ISPRIVATE = (ushort) ( TEMPMOVEEVENT.ISPRIVATE ) ; 
            __context__.SourceCodeLine = 6204;
            MEETINGEVENT [ IMOVETOINDEX] . ISEXCHANGEPRIVATE = (ushort) ( TEMPMOVEEVENT.ISEXCHANGEPRIVATE ) ; 
            __context__.SourceCodeLine = 6205;
            MEETINGEVENT [ IMOVETOINDEX] . ORGANIZER  .UpdateValue ( TEMPMOVEEVENT . ORGANIZER  ) ; 
            __context__.SourceCodeLine = 6206;
            MEETINGEVENT [ IMOVETOINDEX] . RECURRING = (ushort) ( TEMPMOVEEVENT.RECURRING ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 6208;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 6210;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . STARTBLOCK = (ushort) ( TEMPMOVEEVENT.STARTBLOCK ) ; 
                __context__.SourceCodeLine = 6211;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . ENDBLOCK = (ushort) ( TEMPMOVEEVENT.ENDBLOCK ) ; 
                __context__.SourceCodeLine = 6212;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . STARTDATE  .UpdateValue ( TEMPMOVEEVENT . STARTDATE  ) ; 
                __context__.SourceCodeLine = 6213;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . ENDDATE  .UpdateValue ( TEMPMOVEEVENT . ENDDATE  ) ; 
                __context__.SourceCodeLine = 6214;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . STARTTIME  .UpdateValue ( TEMPMOVEEVENT . STARTTIME  ) ; 
                __context__.SourceCodeLine = 6215;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . ENDTIME  .UpdateValue ( TEMPMOVEEVENT . ENDTIME  ) ; 
                __context__.SourceCodeLine = 6216;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . MEETINGID  .UpdateValue ( TEMPMOVEEVENT . MEETINGID  ) ; 
                __context__.SourceCodeLine = 6217;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . RVMEETINGID  .UpdateValue ( TEMPMOVEEVENT . RVMEETINGID  ) ; 
                __context__.SourceCodeLine = 6218;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . INSTANCEID  .UpdateValue ( TEMPMOVEEVENT . INSTANCEID  ) ; 
                __context__.SourceCodeLine = 6219;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . SUBJECT  .UpdateValue ( TEMPMOVEEVENT . SUBJECT  ) ; 
                __context__.SourceCodeLine = 6220;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . ISPRIVATE = (ushort) ( TEMPMOVEEVENT.ISPRIVATE ) ; 
                __context__.SourceCodeLine = 6221;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . ISEXCHANGEPRIVATE = (ushort) ( TEMPMOVEEVENT.ISEXCHANGEPRIVATE ) ; 
                __context__.SourceCodeLine = 6222;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . ORGANIZER  .UpdateValue ( TEMPMOVEEVENT . ORGANIZER  ) ; 
                __context__.SourceCodeLine = 6223;
                AUTOUPDATEMEETINGEVENT [ IMOVETOINDEX] . RECURRING = (ushort) ( TEMPMOVEEVENT.RECURRING ) ; 
                } 
            
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 6228;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 6230;
            Trace( "  Move to index = current index. Do nothing.\r\n") ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 6234;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6236;
        Trace( "  MoveToIndex:{0:d}\r\n", (ushort)IMOVETOINDEX) ; 
        } 
    
    __context__.SourceCodeLine = 6239;
    return (ushort)( IMOVETOINDEX) ; 
    
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
    
    
    __context__.SourceCodeLine = 6258;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6260;
        Trace( "\r\n** CalendarBlock **\r\n") ; 
        __context__.SourceCodeLine = 6261;
        Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
        __context__.SourceCodeLine = 6262;
        Trace( "  StartDate:{0}\r\n", SSTARTDATE ) ; 
        __context__.SourceCodeLine = 6263;
        Trace( "  StartTime:{0}\r\n", SSTARTTIME ) ; 
        __context__.SourceCodeLine = 6264;
        Trace( "  EndDate:{0}\r\n", SENDDATE ) ; 
        __context__.SourceCodeLine = 6265;
        Trace( "  EndTime:{0}\r\n", SENDTIME ) ; 
        } 
    
    __context__.SourceCodeLine = 6268;
    ISTARTBLOCK = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 6269;
    IENDBLOCK = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 6270;
    BNEEDCALCSTARTBLOCK = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 6271;
    BNEEDCALCENDBLOCK = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 6273;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 6275;
        SDATE  .UpdateValue ( G_SDATETODAY  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 6279;
        SDATE  .UpdateValue ( G_SAUTOUPDATEREQUESTDATE  ) ; 
        } 
    
    __context__.SourceCodeLine = 6283;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SDATE == SSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (SDATE == SENDDATE) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 6287;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 6289;
            Trace( "  Event starts and ends on date\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 6292;
        BNEEDCALCSTARTBLOCK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 6293;
        BNEEDCALCENDBLOCK = (ushort) ( 1 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 6295;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SDATE ) > DATETOINTEGER( __context__ , SSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SDATE == SENDDATE) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 6299;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 6301;
                Trace( "  Event starts prior to date and ends on date\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 6304;
            ISTARTBLOCK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 6306;
            BNEEDCALCENDBLOCK = (ushort) ( 1 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 6308;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SDATE == SSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SDATE ) < DATETOINTEGER( __context__ , SENDDATE ) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6312;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 6314;
                    Trace( "  Event starts on date and ends after date\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 6317;
                IENDBLOCK = (ushort) ( 48 ) ; 
                __context__.SourceCodeLine = 6319;
                BNEEDCALCSTARTBLOCK = (ushort) ( 1 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 6321;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SDATE ) > DATETOINTEGER( __context__ , SSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SDATE ) < DATETOINTEGER( __context__ , SENDDATE ) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6325;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 6327;
                        Trace( "  Event starts prior to date and ends after date\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 6330;
                    ISTARTBLOCK = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 6331;
                    IENDBLOCK = (ushort) ( 48 ) ; 
                    } 
                
                }
            
            }
        
        }
    
    __context__.SourceCodeLine = 6335;
    if ( Functions.TestForTrue  ( ( BNEEDCALCSTARTBLOCK)  ) ) 
        { 
        __context__.SourceCodeLine = 6337;
        ISTARTTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SSTARTTIME , (ushort)( 2 ) ) ) ; 
        __context__.SourceCodeLine = 6340;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)48; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 6342;
            IBLOCKSTARTTIMEMINUTES = (ushort) ( ((I * 30) - 30) ) ; 
            __context__.SourceCodeLine = 6343;
            IBLOCKENDTIMEMINUTES = (ushort) ( (I * 30) ) ; 
            __context__.SourceCodeLine = 6345;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ISTARTTIMEMINUTES >= IBLOCKSTARTTIMEMINUTES ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ISTARTTIMEMINUTES < IBLOCKENDTIMEMINUTES ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6348;
                ISTARTBLOCK = (ushort) ( I ) ; 
                __context__.SourceCodeLine = 6349;
                break ; 
                } 
            
            __context__.SourceCodeLine = 6340;
            } 
        
        } 
    
    __context__.SourceCodeLine = 6355;
    if ( Functions.TestForTrue  ( ( BNEEDCALCENDBLOCK)  ) ) 
        { 
        __context__.SourceCodeLine = 6357;
        IENDTIMEMINUTES = (ushort) ( TIMETOINTEGER( __context__ , SENDTIME , (ushort)( 2 ) ) ) ; 
        __context__.SourceCodeLine = 6360;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)48; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 6362;
            IBLOCKSTARTTIMEMINUTES = (ushort) ( ((I * 30) - 30) ) ; 
            __context__.SourceCodeLine = 6363;
            IBLOCKENDTIMEMINUTES = (ushort) ( (I * 30) ) ; 
            __context__.SourceCodeLine = 6365;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IENDTIMEMINUTES > IBLOCKSTARTTIMEMINUTES ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IENDTIMEMINUTES <= IBLOCKENDTIMEMINUTES ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6368;
                IENDBLOCK = (ushort) ( I ) ; 
                __context__.SourceCodeLine = 6369;
                break ; 
                } 
            
            __context__.SourceCodeLine = 6360;
            } 
        
        } 
    
    __context__.SourceCodeLine = 6374;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6376;
        Trace( "  StartBlock:{0:d}\r\n", (ushort)ISTARTBLOCK) ; 
        __context__.SourceCodeLine = 6377;
        Trace( "  EndBlock:{0:d}\r\n", (ushort)IENDBLOCK) ; 
        } 
    
    __context__.SourceCodeLine = 6380;
    SRETURNDATA  .UpdateValue ( Functions.ItoA (  (int) ( ISTARTBLOCK ) ) + "," + Functions.ItoA (  (int) ( IENDBLOCK ) )  ) ; 
    __context__.SourceCodeLine = 6382;
    return ( SRETURNDATA ) ; 
    
    }
    
private ushort NEWNEXTEVENT (  SplusExecutionContext __context__, CrestronString SSTARTDATE , CrestronString SSTARTTIME ) 
    { 
    ushort BNEWNEXTEVENT = 0;
    
    
    __context__.SourceCodeLine = 6389;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6391;
        Trace( "\r\n** NewNextEvent **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 6394;
    BNEWNEXTEVENT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 6397;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SSTARTDATE ) < DATETOINTEGER( __context__ , NEXTEVENT.STARTDATE ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 6401;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 6403;
            Trace( "  Start date is earlier than current NextEvent.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 6406;
        BNEWNEXTEVENT = (ushort) ( 1 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 6408;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSTARTDATE == NEXTEVENT.STARTDATE))  ) ) 
            { 
            __context__.SourceCodeLine = 6412;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 6414;
                Trace( "  Start date = current NextEvent. Check event start time.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 6418;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TIMETOINTEGER( __context__ , SSTARTTIME , (ushort)( 1 ) ) < TIMETOINTEGER( __context__ , NEXTEVENT.STARTTIME , (ushort)( 1 ) ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6422;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 6424;
                    Trace( "  Start time is earlier than current NextEvent.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 6427;
                BNEWNEXTEVENT = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        }
    
    __context__.SourceCodeLine = 6431;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6433;
        Trace( "  bNewNextEvent:{0:d}\r\n", (ushort)BNEWNEXTEVENT) ; 
        } 
    
    __context__.SourceCodeLine = 6436;
    return (ushort)( BNEWNEXTEVENT) ; 
    
    }
    
private void PROCESSSCHEDULERESPONSE (  SplusExecutionContext __context__, ushort IRESPONSETYPE , CrestronString SDATA ) 
    { 
    ushort I = 0;
    ushort INODE = 0;
    ushort ILEN = 0;
    
    CrestronString SREMOVEDDATA;
    CrestronString STEMP;
    SREMOVEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort IHOUR = 0;
    ushort IMINUTE = 0;
    
    ushort ISTOREDEVENTINDEX = 0;
    ushort IAUTOUPDATESTOREDEVENTINDEX = 0;
    
    CrestronString SEVENTMEETINGID;
    CrestronString SEVENTINSTANCEID;
    CrestronString SEVENTRVMEETINGID;
    CrestronString SEVENTSTARTDATE;
    CrestronString SEVENTSTARTTIME;
    CrestronString SEVENTENDDATE;
    CrestronString SEVENTENDTIME;
    CrestronString SEVENTSTARTENDBLOCK;
    CrestronString SEVENTSTARTBLOCK;
    CrestronString SEVENTENDBLOCK;
    CrestronString SEVENTORGANIZER;
    CrestronString SEVENTSUBJECT;
    CrestronString SEVENTLIVEMEETURL;
    SEVENTMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    SEVENTINSTANCEID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
    SEVENTRVMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SEVENTSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SEVENTSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SEVENTENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SEVENTENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SEVENTSTARTENDBLOCK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SEVENTSTARTBLOCK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    SEVENTENDBLOCK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    SEVENTORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SEVENTSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1500, this );
    SEVENTLIVEMEETURL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    ushort IEVENTINDEX = 0;
    ushort IAUTOUPDATEEVENTINDEX = 0;
    ushort IEVENTTYPE = 0;
    
    ushort BFOUNDEVENT = 0;
    ushort BOKTOSTORE = 0;
    ushort BEVENTRECURRING = 0;
    ushort BEVENTPRIVATE = 0;
    ushort BEVENTEXCHANGEPRIVATE = 0;
    
    CrestronString SPUSHACTION;
    SPUSHACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    
    ushort BNEEDEVENTDELETE = 0;
    ushort BNEEDEVENTMOVE = 0;
    ushort BSTOREPUSHEVENT = 0;
    ushort BHAVENEXTEVENT = 0;
    ushort BHAVEFIRSTAPPT = 0;
    
    ushort BUPDATEDWORKDAY = 0;
    ushort BNEEDUPDATECALENDAR = 0;
    ushort BNEEDSENDINFOLIST = 0;
    ushort BNEEDSENDUILIST = 0;
    ushort BNEEDCHECKROOMSTATUS = 0;
    ushort BALLOWNEXTRESERVREQUEST = 0;
    ushort BEVENTPRIVATECHANGE = 0;
    ushort BNEXTEVENTCHANGE = 0;
    
    CrestronString SEVENTPREVENDDATE;
    CrestronString SEVENTPREVENDTIME;
    SEVENTPREVENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 18, this );
    SEVENTPREVENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 18, this );
    
    CrestronString SNEXTDATE;
    SNEXTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    ushort BEVENTISNEWNEXTEVENT = 0;
    
    
    __context__.SourceCodeLine = 6502;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 6504;
        Trace( "\r\n** ProcessScheduleResponse **\r\n") ; 
        __context__.SourceCodeLine = 6505;
        Trace( "  Type:{0:d}\r\n", (ushort)IRESPONSETYPE) ; 
        __context__.SourceCodeLine = 6506;
        Trace( "  DataLen:{0:d}\r\n", (ushort)Functions.Length( SDATA )) ; 
        } 
    
    __context__.SourceCodeLine = 6509;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 1))  ) ) 
        { 
        __context__.SourceCodeLine = 6511;
        G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 6513;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 2))  ) ) 
            { 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 6516;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 5))  ) ) 
                { 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 6519;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 3))  ) ) 
                    { 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 6522;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 4))  ) ) 
                        { 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 6525;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 7))  ) ) 
                            { 
                            __context__.SourceCodeLine = 6527;
                            BEVENTPRIVATECHANGE = (ushort) ( 0 ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            }
        
        }
    
    __context__.SourceCodeLine = 6531;
    if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "<Errors>" , SDATA ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 6533;
        INODE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 6535;
        BUPDATEDWORKDAY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 6536;
        BNEXTEVENTCHANGE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 6538;
        BFOUNDEVENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 6540;
        SEVENTPREVENDDATE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 6541;
        SEVENTPREVENDTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 6543;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 6545;
            BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 6547;
            WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 6549;
            SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( "Processing new schedule ..."  ) ; 
            __context__.SourceCodeLine = 6551;
            ISTOREDEVENTINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 6552;
            G_ISTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 6554;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 2))  ) ) 
                { 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 6557;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6559;
                    AUTO_UPDATE_NEED_SCHED  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6561;
                    AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 6563;
                    IAUTOUPDATESTOREDEVENTINDEX = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6564;
                    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6566;
                    G_BHAVEAUTOUPDATESCHEDULE = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 6568;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 6570;
                        NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 6572;
                        BHAVENEXTEVENT = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 6574;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 6576;
                            FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                            __context__.SourceCodeLine = 6578;
                            BHAVEFIRSTAPPT = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 6580;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 7))  ) ) 
                                { 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            }
        
        __context__.SourceCodeLine = 6584;
        do 
            { 
            __context__.SourceCodeLine = 6586;
            SREMOVEDDATA  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
            __context__.SourceCodeLine = 6589;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 6594;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Event>" , SREMOVEDDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6596;
                    BFOUNDEVENT = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 6598;
                    BOKTOSTORE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6600;
                    SEVENTSTARTDATE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6601;
                    SEVENTENDDATE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6602;
                    SEVENTSTARTTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6603;
                    SEVENTENDTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6604;
                    SEVENTSTARTENDBLOCK  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6606;
                    SEVENTMEETINGID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6607;
                    SEVENTRVMEETINGID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6608;
                    SEVENTINSTANCEID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6610;
                    SEVENTORGANIZER  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6611;
                    SEVENTSUBJECT  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6613;
                    SEVENTLIVEMEETURL  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6615;
                    BEVENTRECURRING = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6617;
                    SPUSHACTION  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 6619;
                    BEVENTPRIVATE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6620;
                    BEVENTEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6621;
                    BNEXTEVENTCHANGE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6623;
                    BNEEDEVENTDELETE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 6625;
                    BEVENTISNEWNEXTEVENT = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 6627;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Event>" , SREMOVEDDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 6631;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 6633;
                            Trace( "  End Event tag found.\r\n") ; 
                            __context__.SourceCodeLine = 6634;
                            Trace( "   Event StartDate:{0}\r\n", SEVENTSTARTDATE ) ; 
                            __context__.SourceCodeLine = 6635;
                            Trace( "   Event StartTime:{0}\r\n", SEVENTSTARTTIME ) ; 
                            __context__.SourceCodeLine = 6636;
                            Trace( "   Event EndDate:{0}\r\n", SEVENTENDDATE ) ; 
                            __context__.SourceCodeLine = 6637;
                            Trace( "   Event EndTime:{0}\r\n", SEVENTENDTIME ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 6640;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 6642;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 6644;
                                Trace( "  Event is part of Today response\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 6647;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTOREDEVENTINDEX < 48 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 6650;
                                SEVENTSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 0 ), SEVENTSTARTDATE, SEVENTSTARTTIME, SEVENTENDDATE, SEVENTENDTIME)  ) ; 
                                __context__.SourceCodeLine = 6652;
                                SEVENTSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SEVENTSTARTENDBLOCK )  ) ; 
                                __context__.SourceCodeLine = 6653;
                                SEVENTSTARTBLOCK  .UpdateValue ( Functions.Left ( SEVENTSTARTBLOCK ,  (int) ( (Functions.Length( SEVENTSTARTBLOCK ) - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 6654;
                                SEVENTENDBLOCK  .UpdateValue ( SEVENTSTARTENDBLOCK  ) ; 
                                __context__.SourceCodeLine = 6657;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDBLOCK != "0") )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 6662;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SEVENTPREVENDDATE ) == 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6666;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 6668;
                                            Trace( "  Do not have previous end date. OK to store.\r\n") ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 6671;
                                        BOKTOSTORE = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 6673;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEVENTPREVENDDATE == G_SDATETODAY))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 6677;
                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 6679;
                                                Trace( "  Have previous end date. Need to check for overlap.\r\n") ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 6682;
                                            if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SEVENTSTARTTIME, SEVENTPREVENDTIME ) > 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 6686;
                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6688;
                                                    Trace( "  New event start time > previous start time. OK to store.\r\n") ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 6691;
                                                BOKTOSTORE = (ushort) ( 1 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 6693;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEVENTSTARTTIME == SEVENTPREVENDTIME))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6697;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6699;
                                                        Trace( "  New event start time = previous start time. OK to store.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 6702;
                                                    BOKTOSTORE = (ushort) ( 1 ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 6706;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6708;
                                                        Trace( "  Not OK to store.\r\n") ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                }
                                            
                                            } 
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 6714;
                                    if ( Functions.TestForTrue  ( ( BOKTOSTORE)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6718;
                                        SEVENTPREVENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                        __context__.SourceCodeLine = 6719;
                                        SEVENTPREVENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                        __context__.SourceCodeLine = 6721;
                                        ISTOREDEVENTINDEX = (ushort) ( (ISTOREDEVENTINDEX + 1) ) ; 
                                        __context__.SourceCodeLine = 6723;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 6724;
                                            Trace( "    Storing New Event:{0:d}\r\n", (ushort)ISTOREDEVENTINDEX) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 6726;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                        __context__.SourceCodeLine = 6727;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                        __context__.SourceCodeLine = 6728;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                        __context__.SourceCodeLine = 6729;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                        __context__.SourceCodeLine = 6730;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 6731;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . RVMEETINGID  .UpdateValue ( SEVENTRVMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 6732;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                        __context__.SourceCodeLine = 6733;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                        __context__.SourceCodeLine = 6734;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                        __context__.SourceCodeLine = 6735;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6736;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6737;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . RECURRING = (ushort) ( BEVENTRECURRING ) ; 
                                        __context__.SourceCodeLine = 6739;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . STARTBLOCK = (ushort) ( Functions.Atoi( SEVENTSTARTBLOCK ) ) ; 
                                        __context__.SourceCodeLine = 6740;
                                        MEETINGEVENT [ ISTOREDEVENTINDEX] . ENDBLOCK = (ushort) ( Functions.Atoi( SEVENTENDBLOCK ) ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 6747;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6749;
                                        Trace( "  0 was returned with StartEnd block. Do not store event.\r\n") ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 6754;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 5))  ) ) 
                                { 
                                __context__.SourceCodeLine = 6756;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 6758;
                                    Trace( "  Event is part of Auto Update response\r\n") ; 
                                    } 
                                
                                __context__.SourceCodeLine = 6761;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATESTOREDEVENTINDEX < 48 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 6764;
                                    SEVENTSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 1 ), SEVENTSTARTDATE, SEVENTSTARTTIME, SEVENTENDDATE, SEVENTENDTIME)  ) ; 
                                    __context__.SourceCodeLine = 6766;
                                    SEVENTSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SEVENTSTARTENDBLOCK )  ) ; 
                                    __context__.SourceCodeLine = 6767;
                                    SEVENTSTARTBLOCK  .UpdateValue ( Functions.Left ( SEVENTSTARTBLOCK ,  (int) ( (Functions.Length( SEVENTSTARTBLOCK ) - 1) ) )  ) ; 
                                    __context__.SourceCodeLine = 6768;
                                    SEVENTENDBLOCK  .UpdateValue ( SEVENTSTARTENDBLOCK  ) ; 
                                    __context__.SourceCodeLine = 6771;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDBLOCK != "0") )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6773;
                                        IAUTOUPDATESTOREDEVENTINDEX = (ushort) ( (IAUTOUPDATESTOREDEVENTINDEX + 1) ) ; 
                                        __context__.SourceCodeLine = 6775;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 6776;
                                            Trace( "    Storing New AutoUpdate Event:{0:d}\r\n", (ushort)IAUTOUPDATESTOREDEVENTINDEX) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 6778;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                        __context__.SourceCodeLine = 6779;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                        __context__.SourceCodeLine = 6780;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                        __context__.SourceCodeLine = 6781;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                        __context__.SourceCodeLine = 6782;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 6783;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . RVMEETINGID  .UpdateValue ( SEVENTRVMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 6784;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                        __context__.SourceCodeLine = 6785;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                        __context__.SourceCodeLine = 6786;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                        __context__.SourceCodeLine = 6787;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6788;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6789;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . RECURRING = (ushort) ( BEVENTRECURRING ) ; 
                                        __context__.SourceCodeLine = 6791;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . STARTBLOCK = (ushort) ( Functions.Atoi( SEVENTSTARTBLOCK ) ) ; 
                                        __context__.SourceCodeLine = 6792;
                                        AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ENDBLOCK = (ushort) ( Functions.Atoi( SEVENTENDBLOCK ) ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 6796;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 3))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 6798;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6800;
                                        Trace( "  Event is part of Next Reserv response\r\n") ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 6804;
                                    if ( Functions.TestForTrue  ( ( Functions.Not( BHAVENEXTEVENT ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6807;
                                        BHAVENEXTEVENT = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 6810;
                                        NEXTEVENT . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 6811;
                                        NEXTEVENT . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                        __context__.SourceCodeLine = 6812;
                                        NEXTEVENT . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                        __context__.SourceCodeLine = 6813;
                                        NEXTEVENT . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                        __context__.SourceCodeLine = 6814;
                                        NEXTEVENT . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                        __context__.SourceCodeLine = 6815;
                                        NEXTEVENT . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                        __context__.SourceCodeLine = 6816;
                                        NEXTEVENT . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                        __context__.SourceCodeLine = 6817;
                                        NEXTEVENT . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                        __context__.SourceCodeLine = 6818;
                                        NEXTEVENT . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6819;
                                        NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6821;
                                        SENDFREEBUSYATTRIBUTEDATA (  __context__ , SEVENTSTARTDATE, SEVENTSTARTTIME) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 6824;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 4))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 6828;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 6830;
                                            Trace( "  Event is part of First Appt response\r\n") ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 6833;
                                        BHAVEFIRSTAPPT = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 6836;
                                        NEXTEVENT . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                        __context__.SourceCodeLine = 6837;
                                        NEXTEVENT . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                        __context__.SourceCodeLine = 6838;
                                        NEXTEVENT . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                        __context__.SourceCodeLine = 6839;
                                        NEXTEVENT . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                        __context__.SourceCodeLine = 6840;
                                        NEXTEVENT . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                        __context__.SourceCodeLine = 6841;
                                        NEXTEVENT . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                        __context__.SourceCodeLine = 6842;
                                        NEXTEVENT . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                        __context__.SourceCodeLine = 6843;
                                        NEXTEVENT . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                        __context__.SourceCodeLine = 6844;
                                        NEXTEVENT . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6845;
                                        NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                        __context__.SourceCodeLine = 6847;
                                        SENDFREEBUSYATTRIBUTEDATA (  __context__ , SEVENTSTARTDATE, SEVENTSTARTTIME) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 6849;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 7))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 6853;
                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 6855;
                                                Trace( "  Event is IsPrivate response.\r\n") ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 6859;
                                            ISTOREDEVENTINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 0 ) , (ushort)( 1 ) , SEVENTMEETINGID ) ) ; 
                                            __context__.SourceCodeLine = 6861;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTOREDEVENTINDEX > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 6864;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BEVENTPRIVATE != MEETINGEVENT[ ISTOREDEVENTINDEX ].ISPRIVATE))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6866;
                                                    BEVENTPRIVATECHANGE = (ushort) ( 1 ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 6870;
                                                MEETINGEVENT [ ISTOREDEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 6874;
                                            if ( Functions.TestForTrue  ( ( AUTO_UPDATE_PROCESS_ACTIVE  .Value)  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 6876;
                                                IAUTOUPDATESTOREDEVENTINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 1 ) , (ushort)( 1 ) , SEVENTMEETINGID ) ) ; 
                                                __context__.SourceCodeLine = 6878;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATESTOREDEVENTINDEX > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6881;
                                                    AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 6887;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 2))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 6889;
                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6891;
                                                    Trace( "  Event is part of Push response\r\n") ; 
                                                    __context__.SourceCodeLine = 6892;
                                                    Trace( "   Action:{0}\r\n", SPUSHACTION ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 6895;
                                                PROCESSED_PUSH_RESPONSES  .Value = (ushort) ( (PROCESSED_PUSH_RESPONSES  .Value + 1) ) ; 
                                                __context__.SourceCodeLine = 6896;
                                                LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR__  .UpdateValue ( Functions.Date (  (int) ( 1 ) ) + " " + Functions.Time ( )  ) ; 
                                                __context__.SourceCodeLine = 6899;
                                                if ( Functions.TestForTrue  ( ( G_BRESERVENOWSUCCESSNEEDSCHED)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6903;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6905;
                                                        Trace( "  Waiting for ReserveNow meeting to come down.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 6909;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEVENTMEETINGID == G_SRESERVENOWMEETINGID))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6913;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 6915;
                                                            Trace( "  This is the ReserveNow meeting.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 6918;
                                                        G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
                                                        __context__.SourceCodeLine = 6919;
                                                        G_SRESERVENOWMEETINGID  .UpdateValue ( ""  ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                __context__.SourceCodeLine = 6924;
                                                if ( Functions.TestForTrue  ( ( AUTO_UPDATE_PROCESS_ACTIVE  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 6928;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6930;
                                                        Trace( "  AutoUpdate active. Processing event.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 6933;
                                                    BNEEDEVENTDELETE = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 6934;
                                                    BNEEDEVENTMOVE = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 6935;
                                                    BSTOREPUSHEVENT = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 6936;
                                                    IAUTOUPDATEEVENTINDEX = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 6937;
                                                    IAUTOUPDATESTOREDEVENTINDEX = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 6940;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SEVENTMEETINGID ) > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6942;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 6944;
                                                            Trace( "  Using MeetingID.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 6947;
                                                        IAUTOUPDATEEVENTINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 1 ) , (ushort)( 1 ) , SEVENTMEETINGID ) ) ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 6951;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IAUTOUPDATEEVENTINDEX == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SEVENTINSTANCEID ) > 0 ) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6953;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 6955;
                                                            Trace( "  Using InstanceID.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 6958;
                                                        IAUTOUPDATEEVENTINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 1 ) , (ushort)( 2 ) , SEVENTINSTANCEID ) ) ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 6963;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATEEVENTINDEX > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 6969;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 6971;
                                                            Trace( "  AutoUpdate Event already stored\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 6975;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPUSHACTION == "Remove"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 6979;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 6981;
                                                                Trace( "  AutoUpdate Removing event\r\n") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 6987;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATEEVENTINDEX < G_IAUTOUPDATESTOREDEVENTCOUNT ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 6989;
                                                                SHIFTEVENTS (  __context__ , (ushort)( 1 ), "Up", (ushort)( IAUTOUPDATEEVENTINDEX ), (ushort)( G_IAUTOUPDATESTOREDEVENTCOUNT )) ; 
                                                                __context__.SourceCodeLine = 6991;
                                                                G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT - 1) ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 6996;
                                                                G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT - 1) ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 7003;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7005;
                                                                Trace( "  AutoUpdate Action not remove. Check event date/time\r\n") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7009;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTDATE != AUTOUPDATEMEETINGEVENT[ IAUTOUPDATEEVENTINDEX ].STARTDATE) ) || Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDDATE != AUTOUPDATEMEETINGEVENT[ IAUTOUPDATEEVENTINDEX ].ENDDATE) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7014;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7016;
                                                                    Trace( "  AutoUpdate Date has changed\r\n.") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7020;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTENDDATE) )) ))  ) ) 
                                                                    { 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 7024;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SAUTOUPDATEDATE ) > DATETOINTEGER( __context__ , SEVENTSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTENDDATE) )) ))  ) ) 
                                                                        { 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 7028;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SAUTOUPDATEDATE ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                            { 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 7032;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SAUTOUPDATEDATE ) > DATETOINTEGER( __context__ , SEVENTSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SAUTOUPDATEDATE ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                                { 
                                                                                } 
                                                                            
                                                                            else 
                                                                                { 
                                                                                __context__.SourceCodeLine = 7040;
                                                                                BNEEDEVENTDELETE = (ushort) ( 1 ) ; 
                                                                                } 
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7045;
                                                            if ( Functions.TestForTrue  ( ( Functions.Not( BNEEDEVENTDELETE ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7049;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7051;
                                                                    Trace( "  AutoUpdate Need to check time.\r\n") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7055;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTTIME != AUTOUPDATEMEETINGEVENT[ IAUTOUPDATEEVENTINDEX ].STARTTIME) ) || Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDTIME != AUTOUPDATEMEETINGEVENT[ IAUTOUPDATEEVENTINDEX ].ENDTIME) )) ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7060;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7062;
                                                                        Trace( "  AutoUpdate Time has changed.\r\n") ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 7065;
                                                                    BNEEDEVENTMOVE = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7071;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7073;
                                                                        Trace( "  AutoUpdate Time has not changed. Just update event.\r\n") ; 
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7080;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7082;
                                                                Trace( "  AutoUpdate NeedEventDelete:{0:d}\r\n", (ushort)BNEEDEVENTDELETE) ; 
                                                                __context__.SourceCodeLine = 7083;
                                                                Trace( "  AutoUpdate NeedEventMove:{0:d}\r\n", (ushort)BNEEDEVENTMOVE) ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7087;
                                                            if ( Functions.TestForTrue  ( ( BNEEDEVENTDELETE)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7092;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATEEVENTINDEX < G_IAUTOUPDATESTOREDEVENTCOUNT ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7094;
                                                                    SHIFTEVENTS (  __context__ , (ushort)( 1 ), "Up", (ushort)( IAUTOUPDATEEVENTINDEX ), (ushort)( G_IAUTOUPDATESTOREDEVENTCOUNT )) ; 
                                                                    __context__.SourceCodeLine = 7096;
                                                                    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT - 1) ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7101;
                                                                    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT - 1) ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 7104;
                                                                if ( Functions.TestForTrue  ( ( BNEEDEVENTMOVE)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7109;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IAUTOUPDATESTOREDEVENTCOUNT > 1 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7113;
                                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7115;
                                                                            Trace( "  AutoUpdate More than one event stored. Moving event.\r\n") ; 
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 7119;
                                                                        IAUTOUPDATEEVENTINDEX = (ushort) ( MOVEEVENT( __context__ , (ushort)( 1 ) , (ushort)( IAUTOUPDATEEVENTINDEX ) , SEVENTSTARTDATE , SEVENTSTARTTIME ) ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7123;
                                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7125;
                                                                            Trace( "  AutoUpdate Only one event stored. No need to move event index.\r\n") ; 
                                                                            } 
                                                                        
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 7133;
                                                            SEVENTSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 1 ), SEVENTSTARTDATE, SEVENTSTARTTIME, SEVENTENDDATE, SEVENTENDTIME)  ) ; 
                                                            __context__.SourceCodeLine = 7135;
                                                            SEVENTSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SEVENTSTARTENDBLOCK )  ) ; 
                                                            __context__.SourceCodeLine = 7136;
                                                            SEVENTSTARTBLOCK  .UpdateValue ( Functions.Left ( SEVENTSTARTBLOCK ,  (int) ( (Functions.Length( SEVENTSTARTBLOCK ) - 1) ) )  ) ; 
                                                            __context__.SourceCodeLine = 7137;
                                                            SEVENTENDBLOCK  .UpdateValue ( SEVENTSTARTENDBLOCK  ) ; 
                                                            __context__.SourceCodeLine = 7140;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDBLOCK != "0") )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7142;
                                                                Trace( "    Updating AutoUpdate Event Data:{0:d}\r\n", (ushort)IAUTOUPDATEEVENTINDEX) ; 
                                                                __context__.SourceCodeLine = 7144;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                                                __context__.SourceCodeLine = 7145;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                                                __context__.SourceCodeLine = 7146;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                                                __context__.SourceCodeLine = 7147;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                                                __context__.SourceCodeLine = 7148;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                                                __context__.SourceCodeLine = 7149;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                                                __context__.SourceCodeLine = 7150;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                                __context__.SourceCodeLine = 7151;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                                                __context__.SourceCodeLine = 7152;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . RECURRING = (ushort) ( BEVENTRECURRING ) ; 
                                                                __context__.SourceCodeLine = 7154;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . STARTBLOCK = (ushort) ( Functions.Atoi( SEVENTSTARTBLOCK ) ) ; 
                                                                __context__.SourceCodeLine = 7155;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATEEVENTINDEX] . ENDBLOCK = (ushort) ( Functions.Atoi( SEVENTENDBLOCK ) ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 7164;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7166;
                                                            Trace( "  AutoUpdate Event not stored.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7170;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPUSHACTION != "Remove"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7174;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7176;
                                                                Trace( "  AutoUpdate Action not remove. Look at start/end dates.\r\n") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7181;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTENDDATE) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7184;
                                                                BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 7186;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (Functions.CompareStrings( G_SAUTOUPDATEDATE, SEVENTSTARTDATE ) > 0) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTENDDATE) )) ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7189;
                                                                    BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 7191;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SAUTOUPDATEDATE == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SAUTOUPDATEDATE ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7194;
                                                                        BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 7196;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (Functions.CompareStrings( G_SAUTOUPDATEDATE, SEVENTSTARTDATE ) > 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SAUTOUPDATEDATE ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7199;
                                                                            BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                            } 
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 7202;
                                                            if ( Functions.TestForTrue  ( ( BSTOREPUSHEVENT)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7204;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7206;
                                                                    Trace( "  AutoUpdate Current date falls within event start/end. Adding event.\r\n") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7212;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IAUTOUPDATESTOREDEVENTCOUNT == 0))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7216;
                                                                    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT + 1) ) ; 
                                                                    __context__.SourceCodeLine = 7217;
                                                                    IAUTOUPDATESTOREDEVENTINDEX = (ushort) ( G_IAUTOUPDATESTOREDEVENTCOUNT ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7224;
                                                                    IAUTOUPDATESTOREDEVENTINDEX = (ushort) ( EVENTINSERTINDEX( __context__ , (ushort)( 1 ) , SEVENTSTARTDATE , SEVENTSTARTTIME ) ) ; 
                                                                    __context__.SourceCodeLine = 7227;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATESTOREDEVENTINDEX <= G_IAUTOUPDATESTOREDEVENTCOUNT ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7231;
                                                                        SHIFTEVENTS (  __context__ , (ushort)( 1 ), "Down", (ushort)( IAUTOUPDATESTOREDEVENTINDEX ), (ushort)( G_IAUTOUPDATESTOREDEVENTCOUNT )) ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 7235;
                                                                    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( (G_IAUTOUPDATESTOREDEVENTCOUNT + 1) ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 7240;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7242;
                                                                    Trace( "  AutoUpdate Current date does NOT fall within event start/end. Do nothing.\r\n") ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7248;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IAUTOUPDATESTOREDEVENTINDEX > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7253;
                                                            SEVENTSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 1 ), SEVENTSTARTDATE, SEVENTSTARTTIME, SEVENTENDDATE, SEVENTENDTIME)  ) ; 
                                                            __context__.SourceCodeLine = 7255;
                                                            SEVENTSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SEVENTSTARTENDBLOCK )  ) ; 
                                                            __context__.SourceCodeLine = 7256;
                                                            SEVENTSTARTBLOCK  .UpdateValue ( Functions.Left ( SEVENTSTARTBLOCK ,  (int) ( (Functions.Length( SEVENTSTARTBLOCK ) - 1) ) )  ) ; 
                                                            __context__.SourceCodeLine = 7257;
                                                            SEVENTENDBLOCK  .UpdateValue ( SEVENTSTARTENDBLOCK  ) ; 
                                                            __context__.SourceCodeLine = 7260;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDBLOCK != "0") )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7262;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 7263;
                                                                    Trace( "    AutoUpdate Storing New AutoUpdate Event:{0:d}\r\n", (ushort)IAUTOUPDATESTOREDEVENTINDEX) ; 
                                                                    }
                                                                
                                                                __context__.SourceCodeLine = 7265;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                                                __context__.SourceCodeLine = 7266;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                                                __context__.SourceCodeLine = 7267;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                                                __context__.SourceCodeLine = 7268;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                                                __context__.SourceCodeLine = 7269;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                                                __context__.SourceCodeLine = 7270;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . RVMEETINGID  .UpdateValue ( SEVENTRVMEETINGID  ) ; 
                                                                __context__.SourceCodeLine = 7271;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                                                __context__.SourceCodeLine = 7272;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                                                __context__.SourceCodeLine = 7273;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                                                __context__.SourceCodeLine = 7274;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                                __context__.SourceCodeLine = 7275;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                                                __context__.SourceCodeLine = 7276;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . RECURRING = (ushort) ( BEVENTRECURRING ) ; 
                                                                __context__.SourceCodeLine = 7278;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . STARTBLOCK = (ushort) ( Functions.Atoi( SEVENTSTARTBLOCK ) ) ; 
                                                                __context__.SourceCodeLine = 7279;
                                                                AUTOUPDATEMEETINGEVENT [ IAUTOUPDATESTOREDEVENTINDEX] . ENDBLOCK = (ushort) ( Functions.Atoi( SEVENTENDBLOCK ) ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                __context__.SourceCodeLine = 7289;
                                                BNEEDEVENTDELETE = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 7290;
                                                BNEEDEVENTMOVE = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 7291;
                                                BSTOREPUSHEVENT = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 7292;
                                                IEVENTINDEX = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 7293;
                                                ISTOREDEVENTINDEX = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 7296;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SEVENTMEETINGID ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 7298;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7300;
                                                        Trace( "  Using MeetingID.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 7303;
                                                    IEVENTINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 0 ) , (ushort)( 1 ) , SEVENTMEETINGID ) ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 7307;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IEVENTINDEX == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SEVENTINSTANCEID ) > 0 ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 7309;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7311;
                                                        Trace( "  Using InstanceID.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 7314;
                                                    IEVENTINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 0 ) , (ushort)( 2 ) , SEVENTINSTANCEID ) ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 7318;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.MEETINGID ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTMEETINGID == NEXTEVENT.MEETINGID) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.INSTANCEID ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTINSTANCEID == NEXTEVENT.INSTANCEID) )) ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 7323;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7325;
                                                        Trace( "  Event is stored NextMeeting.\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 7328;
                                                    BNEXTEVENTCHANGE = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 7331;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPUSHACTION == "Remove"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7335;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7337;
                                                            Trace( "  Action is remove. Clearing NextMeeting\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7340;
                                                        NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7341;
                                                        NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7342;
                                                        NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7343;
                                                        NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7344;
                                                        NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7345;
                                                        NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7346;
                                                        NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7347;
                                                        NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 7348;
                                                        NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
                                                        __context__.SourceCodeLine = 7349;
                                                        NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                                                        __context__.SourceCodeLine = 7351;
                                                        G_BNEEDFIRSTAPPTREQUEST = (ushort) ( 1 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 7357;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7359;
                                                            Trace( "  Action not remove.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7363;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTDATE != NEXTEVENT.STARTDATE) ) || Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTTIME != NEXTEVENT.STARTTIME) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7367;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7369;
                                                                Trace( "  Event Date/Time has changed. Clear the NextEvent data.\r\n") ; 
                                                                __context__.SourceCodeLine = 7370;
                                                                Trace( "   EventStartDate: {0}\r\n", SEVENTSTARTDATE ) ; 
                                                                __context__.SourceCodeLine = 7371;
                                                                Trace( "   NextEvent.StartDate: {0}\r\n", NEXTEVENT . STARTDATE ) ; 
                                                                __context__.SourceCodeLine = 7372;
                                                                Trace( "   EventStartTime: {0}\r\n", SEVENTSTARTTIME ) ; 
                                                                __context__.SourceCodeLine = 7373;
                                                                Trace( "   NextEvent.StartTime: {0}\r\n", NEXTEVENT . STARTTIME ) ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7376;
                                                            NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7377;
                                                            NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7378;
                                                            NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7379;
                                                            NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7380;
                                                            NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7381;
                                                            NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7382;
                                                            NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7383;
                                                            NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 7384;
                                                            NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
                                                            __context__.SourceCodeLine = 7385;
                                                            NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                                                            __context__.SourceCodeLine = 7387;
                                                            G_BNEEDFIRSTAPPTREQUEST = (ushort) ( 1 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 7391;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7393;
                                                                Trace( "  Event Date/Time has not changed.\r\n") ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 7401;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7403;
                                                        Trace( "  Event is not stored NextMeeting.\r\n") ; 
                                                        __context__.SourceCodeLine = 7404;
                                                        Trace( "   Current:\r\n") ; 
                                                        __context__.SourceCodeLine = 7405;
                                                        Trace( "    NextEvent.MeetingID:{0}\r\n", NEXTEVENT . MEETINGID ) ; 
                                                        __context__.SourceCodeLine = 7406;
                                                        Trace( "    NextEvent.InstanceID:{0}\r\n", NEXTEVENT . INSTANCEID ) ; 
                                                        __context__.SourceCodeLine = 7407;
                                                        Trace( "    NextEvent.StartDate:{0}\r\n", NEXTEVENT . STARTDATE ) ; 
                                                        __context__.SourceCodeLine = 7408;
                                                        Trace( "    NextEvent.StartTime:{0}\r\n", NEXTEVENT . STARTTIME ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                __context__.SourceCodeLine = 7413;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTINDEX > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 7419;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7421;
                                                        Trace( "  Event already stored\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 7425;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPUSHACTION == "Remove"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7429;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7431;
                                                            Trace( "  Removing event\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7434;
                                                        BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
                                                        __context__.SourceCodeLine = 7439;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTINDEX < G_ISTOREDEVENTCOUNT ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7441;
                                                            SHIFTEVENTS (  __context__ , (ushort)( 0 ), "Up", (ushort)( IEVENTINDEX ), (ushort)( G_ISTOREDEVENTCOUNT )) ; 
                                                            __context__.SourceCodeLine = 7443;
                                                            G_ISTOREDEVENTCOUNT = (ushort) ( (G_ISTOREDEVENTCOUNT - 1) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 7448;
                                                            G_ISTOREDEVENTCOUNT = (ushort) ( (G_ISTOREDEVENTCOUNT - 1) ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 7455;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7457;
                                                            Trace( "  Action not remove. Check event date/time\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7461;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTDATE != MEETINGEVENT[ IEVENTINDEX ].STARTDATE) ) || Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDDATE != MEETINGEVENT[ IEVENTINDEX ].ENDDATE) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7466;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7468;
                                                                Trace( "  Date has changed\r\n.") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7471;
                                                            BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
                                                            __context__.SourceCodeLine = 7475;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTENDDATE) )) ))  ) ) 
                                                                { 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 7479;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) > DATETOINTEGER( __context__ , SEVENTSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTENDDATE) )) ))  ) ) 
                                                                    { 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 7483;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                        { 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 7487;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) > DATETOINTEGER( __context__ , SEVENTSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                            { 
                                                                            } 
                                                                        
                                                                        else 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7495;
                                                                            BNEEDEVENTDELETE = (ushort) ( 1 ) ; 
                                                                            } 
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7500;
                                                        if ( Functions.TestForTrue  ( ( Functions.Not( BNEEDEVENTDELETE ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7504;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7506;
                                                                Trace( "  Need to check time.\r\n") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7510;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTTIME != MEETINGEVENT[ IEVENTINDEX ].STARTTIME) ) || Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDTIME != MEETINGEVENT[ IEVENTINDEX ].ENDTIME) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7515;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7517;
                                                                    Trace( "  Time has changed.\r\n") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7520;
                                                                BNEEDEVENTMOVE = (ushort) ( 1 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 7526;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7528;
                                                                    Trace( "  Time has not changed. Just update event.\r\n") ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7535;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7537;
                                                            Trace( "  NeedEventDelete:{0:d}\r\n", (ushort)BNEEDEVENTDELETE) ; 
                                                            __context__.SourceCodeLine = 7538;
                                                            Trace( "  NeedEventMove:{0:d}\r\n", (ushort)BNEEDEVENTMOVE) ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7542;
                                                        if ( Functions.TestForTrue  ( ( BNEEDEVENTDELETE)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7546;
                                                            BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
                                                            __context__.SourceCodeLine = 7549;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTINDEX < G_ISTOREDEVENTCOUNT ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7551;
                                                                SHIFTEVENTS (  __context__ , (ushort)( 0 ), "Up", (ushort)( IEVENTINDEX ), (ushort)( G_ISTOREDEVENTCOUNT )) ; 
                                                                __context__.SourceCodeLine = 7553;
                                                                G_ISTOREDEVENTCOUNT = (ushort) ( (G_ISTOREDEVENTCOUNT - 1) ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 7558;
                                                                G_ISTOREDEVENTCOUNT = (ushort) ( (G_ISTOREDEVENTCOUNT - 1) ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 7561;
                                                            if ( Functions.TestForTrue  ( ( BNEEDEVENTMOVE)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7565;
                                                                BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
                                                                __context__.SourceCodeLine = 7568;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ISTOREDEVENTCOUNT > 1 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7572;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7574;
                                                                        Trace( "  More than one event stored. Moving event.\r\n") ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 7578;
                                                                    IEVENTINDEX = (ushort) ( MOVEEVENT( __context__ , (ushort)( 0 ) , (ushort)( IEVENTINDEX ) , SEVENTSTARTDATE , SEVENTSTARTTIME ) ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7582;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7584;
                                                                        Trace( "  Only one event stored. No need to move event index.\r\n") ; 
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 7592;
                                                        SEVENTSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 0 ), SEVENTSTARTDATE, SEVENTSTARTTIME, SEVENTENDDATE, SEVENTENDTIME)  ) ; 
                                                        __context__.SourceCodeLine = 7594;
                                                        SEVENTSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SEVENTSTARTENDBLOCK )  ) ; 
                                                        __context__.SourceCodeLine = 7595;
                                                        SEVENTSTARTBLOCK  .UpdateValue ( Functions.Left ( SEVENTSTARTBLOCK ,  (int) ( (Functions.Length( SEVENTSTARTBLOCK ) - 1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 7596;
                                                        SEVENTENDBLOCK  .UpdateValue ( SEVENTSTARTENDBLOCK  ) ; 
                                                        __context__.SourceCodeLine = 7599;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDBLOCK != "0") )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7601;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7603;
                                                                Trace( "    Updating Event Data:{0:d}\r\n", (ushort)IEVENTINDEX) ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7606;
                                                            BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
                                                            __context__.SourceCodeLine = 7608;
                                                            MEETINGEVENT [ IEVENTINDEX] . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                                            __context__.SourceCodeLine = 7609;
                                                            MEETINGEVENT [ IEVENTINDEX] . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                                            __context__.SourceCodeLine = 7610;
                                                            MEETINGEVENT [ IEVENTINDEX] . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                                            __context__.SourceCodeLine = 7611;
                                                            MEETINGEVENT [ IEVENTINDEX] . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                                            __context__.SourceCodeLine = 7612;
                                                            MEETINGEVENT [ IEVENTINDEX] . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                                            __context__.SourceCodeLine = 7613;
                                                            MEETINGEVENT [ IEVENTINDEX] . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                                            __context__.SourceCodeLine = 7614;
                                                            MEETINGEVENT [ IEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                            __context__.SourceCodeLine = 7615;
                                                            MEETINGEVENT [ IEVENTINDEX] . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                                            __context__.SourceCodeLine = 7616;
                                                            MEETINGEVENT [ IEVENTINDEX] . RECURRING = (ushort) ( BEVENTRECURRING ) ; 
                                                            __context__.SourceCodeLine = 7618;
                                                            MEETINGEVENT [ IEVENTINDEX] . STARTBLOCK = (ushort) ( Functions.Atoi( SEVENTSTARTBLOCK ) ) ; 
                                                            __context__.SourceCodeLine = 7619;
                                                            MEETINGEVENT [ IEVENTINDEX] . ENDBLOCK = (ushort) ( Functions.Atoi( SEVENTENDBLOCK ) ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 7628;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7630;
                                                        Trace( "  Event not stored\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 7634;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPUSHACTION != "Remove"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7638;
                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7640;
                                                            Trace( "  Action not remove.\r\n") ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 7644;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTENDDATE) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7648;
                                                            BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 7650;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) > DATETOINTEGER( __context__ , SEVENTSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTENDDATE) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7654;
                                                                BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 7656;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SDATETODAY == SEVENTSTARTDATE) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7660;
                                                                    BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 7662;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) > DATETOINTEGER( __context__ , SEVENTSTARTDATE ) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( DATETOINTEGER( __context__ , G_SDATETODAY ) < DATETOINTEGER( __context__ , SEVENTENDDATE ) ) )) ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7666;
                                                                        BSTOREPUSHEVENT = (ushort) ( 1 ) ; 
                                                                        } 
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 7669;
                                                        if ( Functions.TestForTrue  ( ( BSTOREPUSHEVENT)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7671;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7673;
                                                                Trace( "  Current date falls within event start/end. Adding event.\r\n") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7679;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ISTOREDEVENTCOUNT == 0))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7683;
                                                                G_ISTOREDEVENTCOUNT = (ushort) ( (G_ISTOREDEVENTCOUNT + 1) ) ; 
                                                                __context__.SourceCodeLine = 7684;
                                                                ISTOREDEVENTINDEX = (ushort) ( G_ISTOREDEVENTCOUNT ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 7691;
                                                                ISTOREDEVENTINDEX = (ushort) ( EVENTINSERTINDEX( __context__ , (ushort)( 0 ) , SEVENTSTARTDATE , SEVENTSTARTTIME ) ) ; 
                                                                __context__.SourceCodeLine = 7694;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTOREDEVENTINDEX <= G_ISTOREDEVENTCOUNT ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7698;
                                                                    SHIFTEVENTS (  __context__ , (ushort)( 0 ), "Down", (ushort)( ISTOREDEVENTINDEX ), (ushort)( G_ISTOREDEVENTCOUNT )) ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7702;
                                                                G_ISTOREDEVENTCOUNT = (ushort) ( (G_ISTOREDEVENTCOUNT + 1) ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 7707;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7709;
                                                                Trace( "  Current date does NOT fall within event start/end.\r\n") ; 
                                                                __context__.SourceCodeLine = 7710;
                                                                Trace( "  Need to see if this event is new next event.\r\n") ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7716;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEXTEVENT.MEETINGID ) > 0 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7720;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7722;
                                                                    Trace( "  Have next event.\r\n") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7726;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , NEXTEVENT.STARTDATE ) > DATETOINTEGER( __context__ , G_SDATETODAY ) ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7730;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7732;
                                                                        Trace( "  Next event starts after today.\r\n") ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 7736;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DATETOINTEGER( __context__ , SEVENTSTARTDATE ) < DATETOINTEGER( __context__ , NEXTEVENT.STARTDATE ) ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7740;
                                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7742;
                                                                            Trace( "  New event start date before next event. Event is new next event.\r\n") ; 
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 7745;
                                                                        BEVENTISNEWNEXTEVENT = (ushort) ( 1 ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 7747;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEVENTSTARTDATE == NEXTEVENT.STARTDATE))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7751;
                                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 7753;
                                                                                Trace( "  New event start date = next event.\r\n") ; 
                                                                                } 
                                                                            
                                                                            __context__.SourceCodeLine = 7757;
                                                                            if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SEVENTSTARTTIME , NEXTEVENT.STARTTIME ) < 0))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 7761;
                                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 7763;
                                                                                    Trace( "  New event start time before next event. New event is new next event.\r\n") ; 
                                                                                    } 
                                                                                
                                                                                __context__.SourceCodeLine = 7766;
                                                                                BEVENTISNEWNEXTEVENT = (ushort) ( 1 ) ; 
                                                                                } 
                                                                            
                                                                            } 
                                                                        
                                                                        else 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7771;
                                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 7773;
                                                                                Trace( "  New event does not start before or on same date as next event.\r\n") ; 
                                                                                __context__.SourceCodeLine = 7774;
                                                                                Trace( "  Nothing to do.\r\n") ; 
                                                                                } 
                                                                            
                                                                            } 
                                                                        
                                                                        }
                                                                    
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7782;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7784;
                                                                        Trace( "  Next event does not start after today. Nothing to do.\r\n") ; 
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 7794;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7796;
                                                                    Trace( "  Do not have next event.\r\n") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7800;
                                                                if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( SEVENTSTARTDATE, G_SDATETODAY ) > 0))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7804;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7806;
                                                                        Trace( "  New event starts after today. New event is new next event.\r\n") ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 7809;
                                                                    BEVENTISNEWNEXTEVENT = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7815;
                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7817;
                                                                        Trace( "  New event does not start after today. Nothing to do.\r\n") ; 
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 7824;
                                                            if ( Functions.TestForTrue  ( ( BEVENTISNEWNEXTEVENT)  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7828;
                                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7830;
                                                                    Trace( "  Storing new event as next next event.\r\n") ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 7833;
                                                                BNEXTEVENTCHANGE = (ushort) ( 1 ) ; 
                                                                __context__.SourceCodeLine = 7835;
                                                                NEXTEVENT . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                                                __context__.SourceCodeLine = 7836;
                                                                NEXTEVENT . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                                                __context__.SourceCodeLine = 7837;
                                                                NEXTEVENT . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                                                __context__.SourceCodeLine = 7838;
                                                                NEXTEVENT . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                                                __context__.SourceCodeLine = 7839;
                                                                NEXTEVENT . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                                                __context__.SourceCodeLine = 7840;
                                                                NEXTEVENT . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                                                __context__.SourceCodeLine = 7841;
                                                                NEXTEVENT . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                                                __context__.SourceCodeLine = 7842;
                                                                NEXTEVENT . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                                                __context__.SourceCodeLine = 7843;
                                                                NEXTEVENT . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                                __context__.SourceCodeLine = 7844;
                                                                NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 7852;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISTOREDEVENTINDEX > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7856;
                                                        BUPDATEDWORKDAY = (ushort) ( 1 ) ; 
                                                        __context__.SourceCodeLine = 7859;
                                                        SEVENTSTARTENDBLOCK  .UpdateValue ( CALENDARBLOCK (  __context__ , (ushort)( 0 ), SEVENTSTARTDATE, SEVENTSTARTTIME, SEVENTENDDATE, SEVENTENDTIME)  ) ; 
                                                        __context__.SourceCodeLine = 7861;
                                                        SEVENTSTARTBLOCK  .UpdateValue ( Functions.Remove ( "," , SEVENTSTARTENDBLOCK )  ) ; 
                                                        __context__.SourceCodeLine = 7862;
                                                        SEVENTSTARTBLOCK  .UpdateValue ( Functions.Left ( SEVENTSTARTBLOCK ,  (int) ( (Functions.Length( SEVENTSTARTBLOCK ) - 1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 7863;
                                                        SEVENTENDBLOCK  .UpdateValue ( SEVENTSTARTENDBLOCK  ) ; 
                                                        __context__.SourceCodeLine = 7866;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTSTARTBLOCK != "0") ) && Functions.TestForTrue ( Functions.BoolToInt (SEVENTENDBLOCK != "0") )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7868;
                                                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 7869;
                                                                Trace( "    Storing New Event:{0:d}\r\n", (ushort)ISTOREDEVENTINDEX) ; 
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 7871;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . STARTDATE  .UpdateValue ( SEVENTSTARTDATE  ) ; 
                                                            __context__.SourceCodeLine = 7872;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . ENDDATE  .UpdateValue ( SEVENTENDDATE  ) ; 
                                                            __context__.SourceCodeLine = 7873;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . STARTTIME  .UpdateValue ( SEVENTSTARTTIME  ) ; 
                                                            __context__.SourceCodeLine = 7874;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . ENDTIME  .UpdateValue ( SEVENTENDTIME  ) ; 
                                                            __context__.SourceCodeLine = 7875;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . MEETINGID  .UpdateValue ( SEVENTMEETINGID  ) ; 
                                                            __context__.SourceCodeLine = 7876;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . RVMEETINGID  .UpdateValue ( SEVENTRVMEETINGID  ) ; 
                                                            __context__.SourceCodeLine = 7877;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . INSTANCEID  .UpdateValue ( SEVENTINSTANCEID  ) ; 
                                                            __context__.SourceCodeLine = 7878;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . ORGANIZER  .UpdateValue ( SEVENTORGANIZER  ) ; 
                                                            __context__.SourceCodeLine = 7879;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . SUBJECT  .UpdateValue ( SEVENTSUBJECT  ) ; 
                                                            __context__.SourceCodeLine = 7880;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . ISPRIVATE = (ushort) ( BEVENTPRIVATE ) ; 
                                                            __context__.SourceCodeLine = 7881;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . ISEXCHANGEPRIVATE = (ushort) ( BEVENTEXCHANGEPRIVATE ) ; 
                                                            __context__.SourceCodeLine = 7882;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . RECURRING = (ushort) ( BEVENTRECURRING ) ; 
                                                            __context__.SourceCodeLine = 7884;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . STARTBLOCK = (ushort) ( Functions.Atoi( SEVENTSTARTBLOCK ) ) ; 
                                                            __context__.SourceCodeLine = 7885;
                                                            MEETINGEVENT [ ISTOREDEVENTINDEX] . ENDBLOCK = (ushort) ( Functions.Atoi( SEVENTENDBLOCK ) ) ; 
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
                        __context__.SourceCodeLine = 7894;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Action ID=" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 7896;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "New" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 7898;
                                SPUSHACTION  .UpdateValue ( "New"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 7900;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "Change" , SREMOVEDDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 7902;
                                    SPUSHACTION  .UpdateValue ( "Change"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 7904;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "Remove" , SREMOVEDDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 7906;
                                        SPUSHACTION  .UpdateValue ( "Remove"  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 7909;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingID>" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 7911;
                                SEVENTMEETINGID  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 7913;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</RVMeetingID>" , SREMOVEDDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 7915;
                                    SEVENTRVMEETINGID  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 14) ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 7917;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Recurring>" , SREMOVEDDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 7919;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "True" , SREMOVEDDATA ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 7920;
                                            BEVENTRECURRING = (ushort) ( 1 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 7922;
                                            BEVENTRECURRING = (ushort) ( 0 ) ; 
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 7924;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</InstanceID>" , SREMOVEDDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 7926;
                                            SEVENTINSTANCEID  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 13) ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 7928;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "</dtStart>" , SREMOVEDDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 7931;
                                                SEVENTSTARTDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( 10 ) )  ) ; 
                                                __context__.SourceCodeLine = 7934;
                                                SEVENTSTARTTIME  .UpdateValue ( Functions.Mid ( SREMOVEDDATA ,  (int) ( 12 ) ,  (int) ( 5 ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 7936;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "</dtEnd>" , SREMOVEDDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 7939;
                                                    SEVENTENDDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( 10 ) )  ) ; 
                                                    __context__.SourceCodeLine = 7942;
                                                    SEVENTENDTIME  .UpdateValue ( Functions.Mid ( SREMOVEDDATA ,  (int) ( 12 ) ,  (int) ( 5 ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 7944;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Organizer>" , SREMOVEDDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 7946;
                                                        SEVENTORGANIZER  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                                        __context__.SourceCodeLine = 7948;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEVENTORGANIZER == "Unknown Name") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( DEFAULT_ORGANIZER__DOLLAR__ ) > 0 ) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7950;
                                                            SEVENTORGANIZER  .UpdateValue ( DEFAULT_ORGANIZER__DOLLAR__  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 7952;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEVENTORGANIZER == ROOM_NAME__DOLLAR__))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7954;
                                                                SEVENTORGANIZER  .UpdateValue ( DEFAULT_ORGANIZER__DOLLAR__  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 7958;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</IsPrivate>" , SREMOVEDDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 7960;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVEDDATA ))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 7961;
                                                                BEVENTPRIVATE = (ushort) ( 1 ) ; 
                                                                }
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 7963;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "</IsExchangePrivate>" , SREMOVEDDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 7965;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVEDDATA ))  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 7966;
                                                                    BEVENTEXCHANGEPRIVATE = (ushort) ( 1 ) ; 
                                                                    }
                                                                
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 7968;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<LiveMeeting>" , SREMOVEDDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 7970;
                                                                    INODE = (ushort) ( 3 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 7972;
                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<Subject>" , SREMOVEDDATA ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 7974;
                                                                        INODE = (ushort) ( 4 ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 7976;
                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</ScheduleResponse>" , SREMOVEDDATA ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 7980;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 3))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 7985;
                                                                                if ( Functions.TestForTrue  ( ( Functions.Not( BFOUNDEVENT ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 7987;
                                                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 7989;
                                                                                        Trace( "  End of next reservation response. No events. Clear NextEvent.\r\n") ; 
                                                                                        } 
                                                                                    
                                                                                    __context__.SourceCodeLine = 7993;
                                                                                    NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 7994;
                                                                                    NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 7995;
                                                                                    NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 7996;
                                                                                    NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 7997;
                                                                                    NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 7998;
                                                                                    NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 7999;
                                                                                    NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 8000;
                                                                                    NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 8001;
                                                                                    NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
                                                                                    __context__.SourceCodeLine = 8002;
                                                                                    NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                                                                                    } 
                                                                                
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 8006;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 4))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 8011;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.Not( BFOUNDEVENT ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 8013;
                                                                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 8015;
                                                                                            Trace( "  End of first appointment response. No events. Clear NextEvent.\r\n") ; 
                                                                                            } 
                                                                                        
                                                                                        __context__.SourceCodeLine = 8019;
                                                                                        NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8020;
                                                                                        NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8021;
                                                                                        NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8022;
                                                                                        NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8023;
                                                                                        NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8024;
                                                                                        NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8025;
                                                                                        NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8026;
                                                                                        NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 8027;
                                                                                        NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
                                                                                        __context__.SourceCodeLine = 8028;
                                                                                        NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
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
            
            else 
                {
                __context__.SourceCodeLine = 8033;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8035;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</LiveMeeting>" , SREMOVEDDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8037;
                        INODE = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8039;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</URL>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8041;
                            SEVENTLIVEMEETURL  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 6) ) )  ) ; 
                            } 
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 8044;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8046;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Subject>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8050;
                            SEVENTSUBJECT  .UpdateValue ( SEVENTSUBJECT + Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 10) ) )  ) ; 
                            __context__.SourceCodeLine = 8052;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SEVENTSUBJECT ) > 230 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 8053;
                                SEVENTSUBJECT  .UpdateValue ( Functions.Left ( SEVENTSUBJECT ,  (int) ( 230 ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 8055;
                            INODE = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 8060;
                            SEVENTSUBJECT  .UpdateValue ( SEVENTSUBJECT + SREMOVEDDATA  ) ; 
                            } 
                        
                        } 
                    
                    }
                
                }
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
        __context__.SourceCodeLine = 8068;
        BNEEDUPDATECALENDAR = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 8069;
        BNEEDSENDINFOLIST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 8070;
        BNEEDSENDUILIST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 8071;
        BNEEDCHECKROOMSTATUS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 8072;
        BALLOWNEXTRESERVREQUEST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 8074;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 8076;
            WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 8078;
            HAVE_VALID_WORKDAY_SCHED  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8080;
            SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SDATETODAY, (ushort)( 1 ))  ) ; 
            __context__.SourceCodeLine = 8082;
            LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR__  .UpdateValue ( Functions.Date (  (int) ( 1 ) ) + " " + Functions.Time ( )  ) ; 
            __context__.SourceCodeLine = 8084;
            G_ISTOREDEVENTCOUNT = (ushort) ( ISTOREDEVENTINDEX ) ; 
            __context__.SourceCodeLine = 8086;
            BNEEDUPDATECALENDAR = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8087;
            BNEEDSENDINFOLIST = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8088;
            BNEEDSENDUILIST = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8089;
            BNEEDCHECKROOMSTATUS = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8092;
            if ( Functions.TestForTrue  ( ( Functions.Not( G_BPUSHENABLED ))  ) ) 
                { 
                __context__.SourceCodeLine = 8096;
                BALLOWNEXTRESERVREQUEST = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 8099;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 5))  ) ) 
                { 
                __context__.SourceCodeLine = 8101;
                AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 8103;
                G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( IAUTOUPDATESTOREDEVENTINDEX ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 8105;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8107;
                    if ( Functions.TestForTrue  ( ( BUPDATEDWORKDAY)  ) ) 
                        { 
                        __context__.SourceCodeLine = 8109;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 8111;
                            Trace( "  Updated Workday. Run post process.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 8114;
                        BNEEDUPDATECALENDAR = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 8115;
                        BNEEDSENDINFOLIST = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 8116;
                        BNEEDSENDUILIST = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 8117;
                        BNEEDCHECKROOMSTATUS = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 8118;
                        BALLOWNEXTRESERVREQUEST = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 8122;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 8124;
                            Trace( "  Workday NOT updated.\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 8127;
                        if ( Functions.TestForTrue  ( ( BNEXTEVENTCHANGE)  ) ) 
                            { 
                            __context__.SourceCodeLine = 8129;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 8131;
                                Trace( "  However, next event was changed.\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 8134;
                            BNEEDCHECKROOMSTATUS = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 8135;
                            BALLOWNEXTRESERVREQUEST = (ushort) ( 1 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 8139;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8141;
                        NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 8143;
                        BNEEDCHECKROOMSTATUS = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 8144;
                        BALLOWNEXTRESERVREQUEST = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8146;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8148;
                            FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 8150;
                            BNEEDCHECKROOMSTATUS = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 8151;
                            BALLOWNEXTRESERVREQUEST = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8153;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 7))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8156;
                                if ( Functions.TestForTrue  ( ( BEVENTPRIVATECHANGE)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8158;
                                    BNEEDUPDATECALENDAR = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 8159;
                                    BNEEDSENDINFOLIST = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 8160;
                                    BNEEDSENDUILIST = (ushort) ( 1 ) ; 
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            }
        
        __context__.SourceCodeLine = 8166;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 8168;
            Trace( "  Post Processes to Run:\r\n") ; 
            __context__.SourceCodeLine = 8169;
            Trace( "   bNeedUpdateCalendar:{0:d}\r\n", (ushort)BNEEDUPDATECALENDAR) ; 
            __context__.SourceCodeLine = 8170;
            Trace( "   bNeedSendInfoList:{0:d}\r\n", (ushort)BNEEDSENDINFOLIST) ; 
            __context__.SourceCodeLine = 8171;
            Trace( "   bNeedSendUIList:{0:d}\r\n", (ushort)BNEEDSENDUILIST) ; 
            __context__.SourceCodeLine = 8172;
            Trace( "   bNeedCheckRoomStatus:{0:d}\r\n", (ushort)BNEEDCHECKROOMSTATUS) ; 
            __context__.SourceCodeLine = 8173;
            Trace( "   bAllowNextReservRequest:{0:d}\r\n", (ushort)BALLOWNEXTRESERVREQUEST) ; 
            } 
        
        __context__.SourceCodeLine = 8177;
        if ( Functions.TestForTrue  ( ( BNEEDUPDATECALENDAR)  ) ) 
            { 
            __context__.SourceCodeLine = 8180;
            UPDATECALENDAR (  __context__  ) ; 
            __context__.SourceCodeLine = 8183;
            if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
                {
                __context__.SourceCodeLine = 8184;
                SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 1 ), "") ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 8187;
        if ( Functions.TestForTrue  ( ( BNEEDSENDUILIST)  ) ) 
            { 
            __context__.SourceCodeLine = 8190;
            SENDUIEVENTLIST (  __context__  ) ; 
            } 
        
        __context__.SourceCodeLine = 8193;
        if ( Functions.TestForTrue  ( ( BNEEDSENDINFOLIST)  ) ) 
            { 
            } 
        
        __context__.SourceCodeLine = 8201;
        if ( Functions.TestForTrue  ( ( BNEEDCHECKROOMSTATUS)  ) ) 
            { 
            __context__.SourceCodeLine = 8204;
            CHECKROOMSTATUS (  __context__ , (ushort)( BALLOWNEXTRESERVREQUEST )) ; 
            __context__.SourceCodeLine = 8206;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 8208;
                PUSH_TRIGGERED_CHECK_ROOM_STATUS  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 8209;
                PUSH_TRIGGERED_CHECK_ROOM_STATUS  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 8219;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 8221;
            GenerateUserNotice ( "Function:ProcessScheduleResponse||Response = REQUEST_TODAY||Response contained errors") ; 
            __context__.SourceCodeLine = 8223;
            WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 8224;
            WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 8226;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 8228;
                GenerateUserNotice ( "Function:ProcessScheduleResponse||Response = REQUEST_PUSH||Response contained errors") ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 8230;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8236;
                    GenerateUserNotice ( "Function:ProcessScheduleResponse||Response = REQUEST_AUTO_UPDATE||Response contained errors") ; 
                    __context__.SourceCodeLine = 8238;
                    AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                    __context__.SourceCodeLine = 8239;
                    AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 8241;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8243;
                        GenerateUserNotice ( "Function:ProcessScheduleResponse||Response = REQUEST_NEXT_RESERV||Response contained errors") ; 
                        __context__.SourceCodeLine = 8245;
                        NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                        __context__.SourceCodeLine = 8246;
                        NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8248;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IRESPONSETYPE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8252;
                            FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 8253;
                            FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 8258;
                            NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8259;
                            NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8260;
                            NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8261;
                            NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8262;
                            NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8263;
                            NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8264;
                            NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 8265;
                            NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 8266;
                            NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 8268;
                            SNEXTDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , G_SDATETODAY, "3")  ) ; 
                            __context__.SourceCodeLine = 8270;
                            SENDFREEBUSYATTRIBUTEDATA (  __context__ , SNEXTDATE, "00:00:00") ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            }
        
        } 
    
    __context__.SourceCodeLine = 8274;
    SETDATETIMEVARS (  __context__  ) ; 
    __context__.SourceCodeLine = 8278;
    if ( Functions.TestForTrue  ( ( G_BNEEDANOTHERWORKDAYREQUEST)  ) ) 
        { 
        __context__.SourceCodeLine = 8280;
        G_BNEEDANOTHERWORKDAYREQUEST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 8282;
        GETSCHEDULE (  __context__ , (ushort)( 1 ), G_SDATETODAY, "00:00:00", "24") ; 
        } 
    
    
    }
    
private void PROCESSCREATERESPONSE (  SplusExecutionContext __context__, ushort ITYPE , CrestronString SDATA ) 
    { 
    CrestronString SREMOVED;
    CrestronString SMEETINGID;
    SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    
    ushort BSUCCESS = 0;
    
    
    __context__.SourceCodeLine = 8293;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 8295;
        Trace( "\r\n** ProcessCreateResponse **\r\n") ; 
        __context__.SourceCodeLine = 8296;
        Trace( "  Type:{0:d}\r\n", (ushort)ITYPE) ; 
        } 
    
    __context__.SourceCodeLine = 8299;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 8301;
        RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 8303;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
            { 
            } 
        
        }
    
    __context__.SourceCodeLine = 8307;
    BSUCCESS = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 8308;
    SMEETINGID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 8310;
    do 
        { 
        __context__.SourceCodeLine = 8312;
        SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
        __context__.SourceCodeLine = 8314;
        if ( Functions.TestForTrue  ( ( Functions.Find( "</MeetingID>" , SREMOVED ))  ) ) 
            { 
            __context__.SourceCodeLine = 8318;
            SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 12) ) )  ) ; 
            __context__.SourceCodeLine = 8320;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SMEETINGID ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 8322;
                BSUCCESS = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
    __context__.SourceCodeLine = 8328;
    if ( Functions.TestForTrue  ( ( BSUCCESS)  ) ) 
        { 
        __context__.SourceCodeLine = 8330;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 8332;
            RESERVE_NOW_MESSAGE__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 8334;
            G_SRESERVENOWMEETINGID  .UpdateValue ( SMEETINGID  ) ; 
            __context__.SourceCodeLine = 8336;
            ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 8337;
            G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8339;
            RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 3 ) ; 
            } 
        
        __context__.SourceCodeLine = 8344;
        if ( Functions.TestForTrue  ( ( Functions.Not( G_BPUSHENABLED ))  ) ) 
            { 
            __context__.SourceCodeLine = 8346;
            GETSCHEDULE (  __context__ , (ushort)( 1 ), G_SDATETODAY, "00:00:00", "24") ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 8351;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 8353;
            RESERVE_NOW_MESSAGE__DOLLAR__  .UpdateValue ( "Request rejected by server."  ) ; 
            __context__.SourceCodeLine = 8355;
            G_SRESERVENOWMEETINGID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 8357;
            G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 8359;
            RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 8363;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 8365;
        RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 8367;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 1))  ) ) 
            { 
            } 
        
        }
    
    
    }
    
private void PROCESSACTIONRESPONSE (  SplusExecutionContext __context__, CrestronString SDATA ) 
    { 
    ushort ITYPE = 0;
    ushort IINDEX = 0;
    ushort IMEETINGSTATUS = 0;
    
    CrestronString SXML;
    CrestronString SREMOVED;
    CrestronString STRASH;
    SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 300, this );
    SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 300, this );
    STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    CrestronString SACTIONREQUESTID;
    CrestronString SMEETINGID;
    CrestronString SRVMEETINGID;
    CrestronString SNEWENDTIME;
    SACTIONREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    SRVMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SNEWENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 19, this );
    
    
    __context__.SourceCodeLine = 8387;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 8388;
        Trace( "\r\n** ProcessActionResponse **\r\n") ; 
        }
    
    __context__.SourceCodeLine = 8391;
    ITYPE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 8392;
    IINDEX = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 8393;
    SMEETINGID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 8394;
    SRVMEETINGID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 8395;
    IMEETINGSTATUS = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 8396;
    SNEWENDTIME  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 8398;
    do 
        { 
        __context__.SourceCodeLine = 8400;
        SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
        __context__.SourceCodeLine = 8402;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 8406;
            if ( Functions.TestForTrue  ( ( Functions.Find( "</RequestID>" , SREMOVED ))  ) ) 
                { 
                __context__.SourceCodeLine = 8409;
                SACTIONREQUESTID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 12) ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 8411;
                if ( Functions.TestForTrue  ( ( Functions.Find( "RequestRVID</ActionID>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8415;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 8416;
                        Trace( "    Found RequestRVID\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 8418;
                    ITYPE = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 8420;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "RegisterPushModel</ActionID>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8422;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 8423;
                            Trace( "  Found RegisterPushModel\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 8425;
                        REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 8427;
                        ITYPE = (ushort) ( 2 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8429;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "MeetingChange</ActionID>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8431;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 8432;
                                Trace( "  Found MeetingChange\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 8434;
                            ITYPE = (ushort) ( 3 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8436;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "Subscription</ActionID>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8438;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 8439;
                                    Trace( "  Found Subscription\r\n") ; 
                                    }
                                
                                __context__.SourceCodeLine = 8441;
                                ITYPE = (ushort) ( 4 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 8443;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "Backlog</ActionID>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8445;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 8446;
                                        Trace( "  Found Backlog\r\n") ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 8448;
                                    ITYPE = (ushort) ( 5 ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 8455;
            switch ((int)ITYPE)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 8460;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ActionResponse>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8463;
                        ITYPE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 8470;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022MeetingID\u0022" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8475;
                            STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                            __context__.SourceCodeLine = 8478;
                            SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 4) ) )  ) ; 
                            __context__.SourceCodeLine = 8480;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 8481;
                                Trace( "    MeetingID:{0}\r\n", SMEETINGID ) ; 
                                }
                            
                            __context__.SourceCodeLine = 8484;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SMEETINGID ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8486;
                                IINDEX = (ushort) ( EVENTINDEX( __context__ , (ushort)( 0 ) , (ushort)( 1 ) , SMEETINGID ) ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8489;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022RVMeetingID\u0022" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8494;
                                STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                                __context__.SourceCodeLine = 8497;
                                SRVMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 4) ) )  ) ; 
                                __context__.SourceCodeLine = 8499;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 8500;
                                    Trace( "    RVMeetingID:{0}\r\n", SRVMEETINGID ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 8503;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IINDEX > 0 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 8504;
                                    MEETINGEVENT [ IINDEX] . RVMEETINGID  .UpdateValue ( SRVMEETINGID  ) ; 
                                    }
                                
                                } 
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 8508;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 8513;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ActionResponse>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8516;
                        ITYPE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 8518;
                        REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 8524;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "ActionRegisterPush" , SACTIONREQUESTID ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8528;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Registered\u0022" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8530;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8532;
                                    G_BPUSHENABLED = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 8534;
                                    REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 3 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 8538;
                                    G_BPUSHENABLED = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 8540;
                                    REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 8548;
                            G_BPUSHENABLED = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 8552;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 8557;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ActionResponse>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8560;
                        ITYPE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 8564;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022GroupwareID\u0022" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8566;
                            STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                            __context__.SourceCodeLine = 8567;
                            SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 4) ) )  ) ; 
                            __context__.SourceCodeLine = 8570;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SMEETINGID ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8572;
                                GETISPRIVATE (  __context__ , SMEETINGID) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8581;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022MeetingID\u0022" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8583;
                                STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                                __context__.SourceCodeLine = 8584;
                                SMEETINGID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 4) ) )  ) ; 
                                __context__.SourceCodeLine = 8585;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8587;
                                    Trace( "\rsMeetingID: {0}", SMEETINGID ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 8590;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Status\u0022" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8592;
                                    STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                                    __context__.SourceCodeLine = 8593;
                                    IMEETINGSTATUS = (ushort) ( Functions.Atoi( Functions.Left( SREMOVED , (int)( (Functions.Length( SREMOVED ) - 4) ) ) ) ) ; 
                                    __context__.SourceCodeLine = 8594;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 8596;
                                        Trace( "\riMeetingStatus: {0:d}", (short)IMEETINGSTATUS) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 8599;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMEETINGSTATUS == 1))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 8601;
                                        END_MEETING_REQUEST_MODE  .Value = (ushort) ( 3 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 8605;
                                        END_MEETING_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 8609;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Message\u0022" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 8611;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 8613;
                                            Trace( "\r ** Message Received **\r") ; 
                                            } 
                                        
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 8618;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 8624;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ActionResponse>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8627;
                        ITYPE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 8632;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Active\u0022" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8634;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8636;
                                EWS_SUBSCRIPTION_OFFLINE_FB  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 8638;
                                CancelWait ( "GETSCHEDULEDELAYWAIT" ) ; 
                                __context__.SourceCodeLine = 8640;
                                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>Subscription</Type>" + "<Status>Offline</Status>" + "</Data>"  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 8648;
                                EWS_SUBSCRIPTION_OFFLINE_FB  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 8650;
                                CancelWait ( "GETSCHEDULEDELAYWAIT" ) ; 
                                __context__.SourceCodeLine = 8652;
                                GETSCHEDULEDELAY (  __context__  ) ; 
                                __context__.SourceCodeLine = 8654;
                                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>Subscription</Type>" + "<Status>Online</Status>" + "</Data>"  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8661;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Text\u0022" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8663;
                                STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                                __context__.SourceCodeLine = 8665;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREMOVED ) > 254 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 8666;
                                    EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR__  .UpdateValue ( Functions.Remove ( 250, SREMOVED )  ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 8668;
                                    EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 4) ) )  ) ; 
                                    }
                                
                                } 
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 8672;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 8678;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ActionResponse>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8681;
                        ITYPE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 8686;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Active\u0022" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8688;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8690;
                                ROOMSERVICE_BACKLOG_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 8692;
                                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>Backlog</Type>" + "<Status>Active</Status>" + "</Data>"  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 8700;
                                ROOMSERVICE_BACKLOG_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 8702;
                                TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>Backlog</Type>" + "<Status>Inactive</Status>" + "</Data>"  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8709;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Parameter ID=\u0022Text\u0022" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8711;
                                STRASH  .UpdateValue ( Functions.Remove ( "Value=\u0022" , SREMOVED )  ) ; 
                                __context__.SourceCodeLine = 8713;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREMOVED ) > 254 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 8714;
                                    ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR__  .UpdateValue ( Functions.Remove ( 250, SREMOVED )  ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 8716;
                                    ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 4) ) )  ) ; 
                                    }
                                
                                } 
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 8720;
                    break ; 
                    } 
                
                break;
                } 
                
            
            } 
        
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
    
    }
    
private void TRANSFERDATA (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    
    
    __context__.SourceCodeLine = 8733;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 8735;
        Trace( "\r\n** TransferData **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 8738;
    G_ISTOREDEVENTCOUNT = (ushort) ( G_IAUTOUPDATESTOREDEVENTCOUNT ) ; 
    __context__.SourceCodeLine = 8740;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IAUTOUPDATESTOREDEVENTCOUNT > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 8742;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)G_IAUTOUPDATESTOREDEVENTCOUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 8744;
            MEETINGEVENT [ I] . MEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . MEETINGID  ) ; 
            __context__.SourceCodeLine = 8745;
            MEETINGEVENT [ I] . RVMEETINGID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . RVMEETINGID  ) ; 
            __context__.SourceCodeLine = 8746;
            MEETINGEVENT [ I] . INSTANCEID  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . INSTANCEID  ) ; 
            __context__.SourceCodeLine = 8748;
            MEETINGEVENT [ I] . STARTBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].STARTBLOCK ) ; 
            __context__.SourceCodeLine = 8749;
            MEETINGEVENT [ I] . ENDBLOCK = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].ENDBLOCK ) ; 
            __context__.SourceCodeLine = 8751;
            MEETINGEVENT [ I] . STARTDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . STARTDATE  ) ; 
            __context__.SourceCodeLine = 8752;
            MEETINGEVENT [ I] . ENDDATE  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . ENDDATE  ) ; 
            __context__.SourceCodeLine = 8754;
            MEETINGEVENT [ I] . STARTTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . STARTTIME  ) ; 
            __context__.SourceCodeLine = 8755;
            MEETINGEVENT [ I] . ENDTIME  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . ENDTIME  ) ; 
            __context__.SourceCodeLine = 8757;
            MEETINGEVENT [ I] . SUBJECT  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . SUBJECT  ) ; 
            __context__.SourceCodeLine = 8759;
            MEETINGEVENT [ I] . ISPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].ISPRIVATE ) ; 
            __context__.SourceCodeLine = 8760;
            MEETINGEVENT [ I] . ISEXCHANGEPRIVATE = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].ISEXCHANGEPRIVATE ) ; 
            __context__.SourceCodeLine = 8762;
            MEETINGEVENT [ I] . ORGANIZER  .UpdateValue ( AUTOUPDATEMEETINGEVENT [ I] . ORGANIZER  ) ; 
            __context__.SourceCodeLine = 8764;
            MEETINGEVENT [ I] . RECURRING = (ushort) ( AUTOUPDATEMEETINGEVENT[ I ].RECURRING ) ; 
            __context__.SourceCodeLine = 8742;
            } 
        
        } 
    
    
    }
    
private void PROCESSMEETINGPRESETDATARESPONSE (  SplusExecutionContext __context__, CrestronString SDATA ) 
    { 
    CrestronString SREMOVEDDATA;
    CrestronString STEMP;
    SREMOVEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 300, this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    
    __context__.SourceCodeLine = 8774;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 8776;
        Trace( "\r\n** ProcessMeetingPresetDataResponse **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 8778;
    if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 8778;
        Print( "Inside Function ProcessMeetingPresetDataResponse\r\n") ; 
        }
    
    __context__.SourceCodeLine = 8779;
    if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 8779;
        Print( "sData = {0}\r\n", SDATA ) ; 
        }
    
    __context__.SourceCodeLine = 8782;
    if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "<Errors>" , SDATA ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 8784;
        if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 8784;
            Print( "Inside if (!find(\u0022<Errors>\u0022, sData))\r\n") ; 
            }
        
        __context__.SourceCodeLine = 8785;
        G_SCURRENTWELCOMEMSG  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 8788;
        if ( Functions.TestForTrue  ( ( G_BHAVEMEETINGPRESETMODULE)  ) ) 
            { 
            __context__.SourceCodeLine = 8792;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 8794;
                Trace( "  Preset module connected. Sending data out.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 8796;
            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 8796;
                Print( "Inside if (g_bHaveMeetingPresetModule)\r\n") ; 
                }
            
            __context__.SourceCodeLine = 8798;
            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<ScheduleInterfaceData><Type=\u0022PresetData\u0022 />"  ) ; 
            __context__.SourceCodeLine = 8802;
            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<EventIndex>" + Functions.ItoA (  (int) ( G_ILASTSENTGETPRESETDATAINDEX ) ) + "</EventIndex>"  ) ; 
            __context__.SourceCodeLine = 8806;
            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartDate>" + MEETINGEVENT [ G_ILASTSENTGETPRESETDATAINDEX] . STARTDATE + "</StartDate>"  ) ; 
            __context__.SourceCodeLine = 8810;
            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<StartTime>" + MEETINGEVENT [ G_ILASTSENTGETPRESETDATAINDEX] . STARTTIME + "</StartTime>"  ) ; 
            __context__.SourceCodeLine = 8813;
            do 
                { 
                __context__.SourceCodeLine = 8815;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SDATA ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8817;
                    TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( 240, SDATA )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 8821;
                    TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( Functions.Remove ( Functions.Length( SDATA ), SDATA )  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 8827;
            TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__  .UpdateValue ( "</ScheduleInterfaceData>"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 8834;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 8836;
                Trace( "  Preset module not connected. Extracting welcome message.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 8838;
            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 8838;
                Print( "Inside the else for if (g_bHaveMeetingPresetModule)\r\n") ; 
                }
            
            __context__.SourceCodeLine = 8840;
            do 
                { 
                __context__.SourceCodeLine = 8842;
                SREMOVEDDATA  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 8844;
                if ( Functions.TestForTrue  ( ( Functions.Find( "</WelcomeMessage>" , SREMOVEDDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8846;
                    G_SCURRENTWELCOMEMSG  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 17) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 8850;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SCURRENTWELCOMEMSG ) > 250 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8853;
                    G_SCURRENTWELCOMEMSG  .UpdateValue ( Functions.Left ( G_SCURRENTWELCOMEMSG ,  (int) ( 250 ) ) + " ..."  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            } 
        
        __context__.SourceCodeLine = 8859;
        CURRENT_MEETING_WELCOME_MSG__DOLLAR__  .UpdateValue ( G_SCURRENTWELCOMEMSG  ) ; 
        __context__.SourceCodeLine = 8861;
        CURRENT_MEETING_PRESET_DATA_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 8866;
        if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 8866;
            Print( "Inside the else for if (!find(\u0022<Errors>\u0022, sData))\r\n") ; 
            }
        
        __context__.SourceCodeLine = 8867;
        CURRENT_MEETING_PRESET_DATA_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 8868;
        CURRENT_MEETING_PRESET_DATA_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        } 
    
    
    }
    
private void PROCESSMEETINGINFORESPONSE (  SplusExecutionContext __context__, ushort ITYPE , ushort IREQUESTTYPE , CrestronString SDATA ) 
    { 
    ushort INODE = 0;
    
    CrestronString SREMOVEDDATA;
    CrestronString STEMP;
    SREMOVEDDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 300, this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    CrestronString SEVENTENDDATE;
    CrestronString SEVENTENDTIME;
    CrestronString SEVENTORGANIZER;
    CrestronString SEVENTSUBJECT;
    SEVENTENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SEVENTENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SEVENTORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SEVENTSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1500, this );
    
    ushort IREQUIREDATTENDEECOUNT = 0;
    ushort IOPTIONALATTENDEECOUNT = 0;
    
    CrestronString SREQUIREDATTENDEES;
    CrestronString SOPTIONALATTENDEES;
    SREQUIREDATTENDEES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
    SOPTIONALATTENDEES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
    
    ushort BREQUIREDATTENDEE = 0;
    ushort BOPTIONALATTENDEE = 0;
    
    
    __context__.SourceCodeLine = 8894;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 8896;
        Trace( "\r\n** ProcessMeetingInfoResponse **\r\n") ; 
        __context__.SourceCodeLine = 8897;
        Trace( "  iType:{0:d}\r\n", (ushort)ITYPE) ; 
        __context__.SourceCodeLine = 8898;
        Trace( "  iRequestType:{0:d}\r\n", (ushort)IREQUESTTYPE) ; 
        } 
    
    __context__.SourceCodeLine = 8904;
    INODE = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 8907;
    if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "<Errors>" , SDATA ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 8910;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 8911;
            CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 8912;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 8913;
                NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                }
            
            }
        
        __context__.SourceCodeLine = 8915;
        do 
            { 
            __context__.SourceCodeLine = 8917;
            SREMOVEDDATA  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
            __context__.SourceCodeLine = 8920;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 8925;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Event>" , SREMOVEDDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8927;
                    SEVENTENDDATE  .UpdateValue ( "-1"  ) ; 
                    __context__.SourceCodeLine = 8928;
                    SEVENTENDTIME  .UpdateValue ( "-1"  ) ; 
                    __context__.SourceCodeLine = 8929;
                    SEVENTORGANIZER  .UpdateValue ( "-1"  ) ; 
                    __context__.SourceCodeLine = 8930;
                    SEVENTSUBJECT  .UpdateValue ( "-1"  ) ; 
                    __context__.SourceCodeLine = 8931;
                    SREQUIREDATTENDEES  .UpdateValue ( "-1"  ) ; 
                    __context__.SourceCodeLine = 8932;
                    SOPTIONALATTENDEES  .UpdateValue ( "-1"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 8934;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Event>" , SREMOVEDDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8939;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 8943;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SREQUIREDATTENDEES != "-1"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8946;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREQUIREDATTENDEES ) > 255 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8949;
                                    CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( Functions.Left ( SREQUIREDATTENDEES ,  (int) ( 250 ) ) + " ..."  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 8953;
                                    CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( SREQUIREDATTENDEES  ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 8958;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOPTIONALATTENDEES != "-1"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8961;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SOPTIONALATTENDEES ) > 255 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8964;
                                    CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( Functions.Left ( SOPTIONALATTENDEES ,  (int) ( 250 ) ) + " ..."  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 8968;
                                    CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( SOPTIONALATTENDEES  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 8972;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 8977;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SREQUIREDATTENDEES != "-1"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8980;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SREQUIREDATTENDEES ) > 255 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 8983;
                                        NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( Functions.Left ( SREQUIREDATTENDEES ,  (int) ( 250 ) ) + " ..."  ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 8987;
                                        NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( SREQUIREDATTENDEES  ) ; 
                                        } 
                                    
                                    } 
                                
                                __context__.SourceCodeLine = 8992;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOPTIONALATTENDEES != "-1"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 8995;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SOPTIONALATTENDEES ) > 255 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 8998;
                                        NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( Functions.Left ( SOPTIONALATTENDEES ,  (int) ( 250 ) ) + " ..."  ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 9002;
                                        NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( SOPTIONALATTENDEES  ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 9007;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</dtEnd>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 9010;
                            SEVENTENDDATE  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( 10 ) )  ) ; 
                            __context__.SourceCodeLine = 9013;
                            SEVENTENDTIME  .UpdateValue ( Functions.Mid ( SREMOVEDDATA ,  (int) ( 12 ) ,  (int) ( 5 ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 9015;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Organizer>" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 9017;
                                SEVENTORGANIZER  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 12) ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 9019;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<Subject>" , SREMOVEDDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 9021;
                                    INODE = (ushort) ( 4 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 9023;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<Attendees>" , SREMOVEDDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 9025;
                                        INODE = (ushort) ( 7 ) ; 
                                        __context__.SourceCodeLine = 9028;
                                        IREQUIREDATTENDEECOUNT = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 9029;
                                        IOPTIONALATTENDEECOUNT = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 9031;
                                        BREQUIREDATTENDEE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 9032;
                                        BOPTIONALATTENDEE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 9034;
                                        SREQUIREDATTENDEES  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 9035;
                                        SOPTIONALATTENDEES  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 9038;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9040;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Attendees>" , SREMOVEDDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9042;
                        INODE = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 9046;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Required>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 9048;
                            BREQUIREDATTENDEE = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 9050;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Required>" , SREMOVEDDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 9052;
                                BREQUIREDATTENDEE = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 9054;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<Optional>" , SREMOVEDDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 9056;
                                    BOPTIONALATTENDEE = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 9058;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</Optional>" , SREMOVEDDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 9060;
                                        BOPTIONALATTENDEE = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 9062;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Attendee>" , SREMOVEDDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 9064;
                                            STEMP  .UpdateValue ( Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 11) ) )  ) ; 
                                            __context__.SourceCodeLine = 9067;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 9072;
                                                if ( Functions.TestForTrue  ( ( Functions.Not( Functions.Find( "Conf Room" , STEMP ) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 9075;
                                                    if ( Functions.TestForTrue  ( ( BREQUIREDATTENDEE)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 9079;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IREQUIREDATTENDEECOUNT < 10 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 9081;
                                                            IREQUIREDATTENDEECOUNT = (ushort) ( (IREQUIREDATTENDEECOUNT + 1) ) ; 
                                                            __context__.SourceCodeLine = 9083;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IREQUIREDATTENDEECOUNT > 1 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 9085;
                                                                SREQUIREDATTENDEES  .UpdateValue ( SREQUIREDATTENDEES + ";" + STEMP  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 9089;
                                                                SREQUIREDATTENDEES  .UpdateValue ( SREQUIREDATTENDEES + STEMP  ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 9093;
                                                        if ( Functions.TestForTrue  ( ( BOPTIONALATTENDEE)  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 9097;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IOPTIONALATTENDEECOUNT < 10 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 9099;
                                                                IOPTIONALATTENDEECOUNT = (ushort) ( (IOPTIONALATTENDEECOUNT + 1) ) ; 
                                                                __context__.SourceCodeLine = 9101;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IOPTIONALATTENDEECOUNT > 1 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 9103;
                                                                    SOPTIONALATTENDEES  .UpdateValue ( SOPTIONALATTENDEES + ";" + STEMP  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    { 
                                                                    __context__.SourceCodeLine = 9107;
                                                                    SOPTIONALATTENDEES  .UpdateValue ( SOPTIONALATTENDEES + STEMP  ) ; 
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
                
                else 
                    {
                    __context__.SourceCodeLine = 9116;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9118;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Subject>" , SREMOVEDDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 9122;
                            SEVENTSUBJECT  .UpdateValue ( SEVENTSUBJECT + Functions.Left ( SREMOVEDDATA ,  (int) ( (Functions.Length( SREMOVEDDATA ) - 10) ) )  ) ; 
                            __context__.SourceCodeLine = 9124;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SEVENTSUBJECT ) > 240 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 9125;
                                SEVENTSUBJECT  .UpdateValue ( Functions.Left ( SEVENTSUBJECT ,  (int) ( 240 ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 9127;
                            INODE = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 9132;
                            SEVENTSUBJECT  .UpdateValue ( SEVENTSUBJECT + SREMOVEDDATA  ) ; 
                            } 
                        
                        } 
                    
                    }
                
                }
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
        __context__.SourceCodeLine = 9138;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 9139;
            CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 9140;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 9141;
                NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                }
            
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 9147;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 9149;
            CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 9150;
            CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 9152;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITYPE == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (IREQUESTTYPE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 9154;
                NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 9155;
                NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
                } 
            
            }
        
        } 
    
    
    }
    
private void CLEARAUTOUPDATEDATA (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    
    
    __context__.SourceCodeLine = 9164;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9166;
        Trace( "\r\n** ClearAutoUpdateData **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9169;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)48; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 9172;
        AUTOUPDATEMEETINGEVENT [ I] . STARTBLOCK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9173;
        AUTOUPDATEMEETINGEVENT [ I] . ENDBLOCK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9174;
        AUTOUPDATEMEETINGEVENT [ I] . STARTDATE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9175;
        AUTOUPDATEMEETINGEVENT [ I] . ENDDATE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9176;
        AUTOUPDATEMEETINGEVENT [ I] . STARTTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9177;
        AUTOUPDATEMEETINGEVENT [ I] . ENDTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9178;
        AUTOUPDATEMEETINGEVENT [ I] . MEETINGID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9179;
        AUTOUPDATEMEETINGEVENT [ I] . RVMEETINGID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9180;
        AUTOUPDATEMEETINGEVENT [ I] . INSTANCEID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9181;
        AUTOUPDATEMEETINGEVENT [ I] . SUBJECT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9182;
        AUTOUPDATEMEETINGEVENT [ I] . ISPRIVATE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9183;
        AUTOUPDATEMEETINGEVENT [ I] . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9184;
        AUTOUPDATEMEETINGEVENT [ I] . ORGANIZER  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9185;
        AUTOUPDATEMEETINGEVENT [ I] . RECURRING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9169;
        } 
    
    
    }
    
private void AUTOUPDATESTARTEVENTS (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 9192;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9194;
        Trace( "\r\n** AutoUpdateStartEvents **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9200;
    AUTO_UPDATE_PROCESS_ACTIVE  .Value = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 9202;
    CLEARAUTOUPDATEDATA (  __context__  ) ; 
    __context__.SourceCodeLine = 9204;
    G_SAUTOUPDATEDATE  .UpdateValue ( NEXTDAYDATE (  __context__ , G_SDATETODAY, "1")  ) ; 
    __context__.SourceCodeLine = 9208;
    G_BHAVEAUTOUPDATESCHEDULE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9209;
    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9211;
    AUTO_UPDATE_NEED_SCHED  .Value = (ushort) ( 1 ) ; 
    
    }
    
private void ROOMVIEWOFFLINEEVENTS (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 9216;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9218;
        Trace( "\r\n** RoomViewOfflineEvents **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9221;
    WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9222;
    NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9223;
    FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9224;
    RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9225;
    AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9226;
    REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9227;
    CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9228;
    CURRENT_MEETING_PRESET_DATA_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9229;
    NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9231;
    G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9233;
    G_SSCHEDULEREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9234;
    G_SPUSHREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9235;
    G_SRESERVENOWREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9236;
    G_SACTIONRVIDREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9237;
    G_SACTIONPUSHREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9238;
    G_SNEXTRESERVREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9239;
    G_SFIRSTAPPTREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9240;
    G_SISPRIVATEREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9241;
    G_SAUTOUPDATEREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9248;
    G_BHAVEAUTOUPDATESCHEDULE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9249;
    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9251;
    AUTO_UPDATE_NEED_SCHED  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9253;
    HAVE_VALID_WORKDAY_SCHED  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9255;
    NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9256;
    NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9257;
    NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9258;
    NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9259;
    NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9260;
    NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9261;
    NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9262;
    NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9263;
    NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9264;
    NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9266;
    MEETING_ACTIVE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9267;
    END_MEETING_BTN_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9268;
    END_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9269;
    CURRENT_MEETING_PRIVATE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9270;
    HAVE_NEXT_RESERVATION  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9271;
    NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9272;
    END_MEETING_WARN_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9273;
    ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9275;
    CURRENT_MEETING_DURATION_MIN  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9276;
    CURRENT_MEETING_ELAPSED_TIME  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9277;
    CURRENT_MEETING_ELAPSED_PERCENT  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9279;
    UPDATECALENDAR (  __context__  ) ; 
    __context__.SourceCodeLine = 9280;
    UPDATECURRENTMEETINGINFO (  __context__  ) ; 
    __context__.SourceCodeLine = 9281;
    UPDATENEXTRESERVINFO (  __context__  ) ; 
    __context__.SourceCodeLine = 9282;
    SENDUIEVENTLIST (  __context__  ) ; 
    __context__.SourceCodeLine = 9285;
    if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
        { 
        __context__.SourceCodeLine = 9287;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 1 ), "") ; 
        __context__.SourceCodeLine = 9288;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 2 ), "") ; 
        __context__.SourceCodeLine = 9289;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 3 ), "") ; 
        } 
    
    
    }
    
private void ROOMVIEWONLINEEVENTS (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 9295;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9297;
        Trace( "\r\n** RoomViewOnlineEvents **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9300;
    WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9301;
    NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9302;
    FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9303;
    RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9304;
    AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9305;
    REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9306;
    CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9307;
    CURRENT_MEETING_PRESET_DATA_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9308;
    NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9310;
    EWS_SUBSCRIPTION_OFFLINE_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9311;
    ROOMSERVICE_BACKLOG_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9313;
    TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>Subscription</Type>" + "<Status>Online</Status>" + "</Data>"  ) ; 
    __context__.SourceCodeLine = 9319;
    TO_UI_MOD_DATAIN__DOLLAR__  .UpdateValue ( "<Data>" + "<Type>Backlog</Type>" + "<Status>Inactive</Status>" + "</Data>"  ) ; 
    __context__.SourceCodeLine = 9325;
    G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9327;
    G_SSCHEDULEREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9328;
    G_SPUSHREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9329;
    G_SRESERVENOWREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9330;
    G_SACTIONRVIDREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9331;
    G_SACTIONPUSHREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9332;
    G_SNEXTRESERVREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9333;
    G_SFIRSTAPPTREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9334;
    G_SISPRIVATEREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9335;
    G_SAUTOUPDATEREQUESTID  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 9342;
    G_BHAVEAUTOUPDATESCHEDULE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9343;
    G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9345;
    AUTO_UPDATE_NEED_SCHED  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9347;
    HAVE_VALID_WORKDAY_SCHED  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9349;
    MEETING_ACTIVE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9350;
    END_MEETING_BTN_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9351;
    END_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9352;
    CURRENT_MEETING_PRIVATE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9353;
    HAVE_NEXT_RESERVATION  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9354;
    NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9355;
    END_MEETING_WARN_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9356;
    ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9358;
    CURRENT_MEETING_DURATION_MIN  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9359;
    CURRENT_MEETING_ELAPSED_TIME  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9360;
    CURRENT_MEETING_ELAPSED_PERCENT  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 9362;
    UPDATECALENDAR (  __context__  ) ; 
    __context__.SourceCodeLine = 9363;
    UPDATECURRENTMEETINGINFO (  __context__  ) ; 
    __context__.SourceCodeLine = 9364;
    UPDATENEXTRESERVINFO (  __context__  ) ; 
    __context__.SourceCodeLine = 9365;
    SENDUIEVENTLIST (  __context__  ) ; 
    __context__.SourceCodeLine = 9368;
    if ( Functions.TestForTrue  ( ( G_BHAVEREMOTESYSMODULE)  ) ) 
        { 
        __context__.SourceCodeLine = 9370;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 1 ), "") ; 
        __context__.SourceCodeLine = 9371;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 2 ), "") ; 
        __context__.SourceCodeLine = 9372;
        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 3 ), "") ; 
        } 
    
    
    }
    
private void PROCESSFROMRVSCHEDULERESPONSE__DOLLAR__ (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 9378;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9380;
        Trace( "\r\n** ProcessFromRVScheduleResponse$ **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9382;
    if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 9382;
        Print( "Inside Function ProcessFromRVScheduleResponse$\r\n") ; 
        }
    
    __context__.SourceCodeLine = 9384;
    if ( Functions.TestForTrue  ( ( Functions.Find( G_SSCHEDULEREQUESTID , G_SRXDATA1 ))  ) ) 
        { 
        __context__.SourceCodeLine = 9386;
        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 9388;
            Trace( "  Found g_sScheduleRequestID\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 9390;
        if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 9390;
            Print( "Inside if (find(g_sScheduleRequestID, g_sRXData1))\r\n") ; 
            }
        
        __context__.SourceCodeLine = 9392;
        PROCESSSCHEDULERESPONSE (  __context__ , (ushort)( 1 ), G_SRXDATA1) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 9394;
        if ( Functions.TestForTrue  ( ( Functions.Find( G_SPUSHREQUESTID , G_SRXDATA1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 9396;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 9398;
                Trace( "  Found g_sPushRequestID\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 9400;
            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 9400;
                Print( "Inside else if (find(g_sPushRequestID, g_sRXData1))\r\n") ; 
                }
            
            __context__.SourceCodeLine = 9402;
            PROCESSSCHEDULERESPONSE (  __context__ , (ushort)( 2 ), G_SRXDATA1) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 9404;
            if ( Functions.TestForTrue  ( ( Functions.Find( G_SNEXTRESERVREQUESTID , G_SRXDATA1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 9406;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 9408;
                    Trace( "  Found g_sNextReservRequestID\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 9410;
                if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 9410;
                    Print( "Inside else if (find(g_sNextReservRequestID, g_sRXData1))\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 9412;
                PROCESSSCHEDULERESPONSE (  __context__ , (ushort)( 3 ), G_SRXDATA1) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 9414;
                if ( Functions.TestForTrue  ( ( Functions.Find( G_SFIRSTAPPTREQUESTID , G_SRXDATA1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9416;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 9418;
                        Trace( "  Found g_sFirstApptRequestID\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 9420;
                    if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 9420;
                        Print( "Inside else if (find(g_sFirstApptRequestID, g_sRXData1))\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 9422;
                    PROCESSSCHEDULERESPONSE (  __context__ , (ushort)( 4 ), G_SRXDATA1) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 9424;
                    if ( Functions.TestForTrue  ( ( Functions.Find( G_SAUTOUPDATEREQUESTID , G_SRXDATA1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9426;
                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 9428;
                            Trace( "  Found g_sAutoUpdateRequestID\r\n") ; 
                            } 
                        
                        __context__.SourceCodeLine = 9430;
                        if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 9430;
                            Print( "Inside else if (find(g_sAutoUpdateRequestID, g_sRXData1))\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 9432;
                        PROCESSSCHEDULERESPONSE (  __context__ , (ushort)( 5 ), G_SRXDATA1) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 9434;
                        if ( Functions.TestForTrue  ( ( Functions.Find( G_SISPRIVATEREQUESTID , G_SRXDATA1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 9436;
                            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 9438;
                                Trace( "  Found g_sIsPrivateRequestID\r\n") ; 
                                } 
                            
                            __context__.SourceCodeLine = 9440;
                            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 9440;
                                Print( "Inside else if (find(g_sIsPrivateRequestID, g_sRXData1))\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 9442;
                            PROCESSSCHEDULERESPONSE (  __context__ , (ushort)( 7 ), G_SRXDATA1) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 9444;
                            if ( Functions.TestForTrue  ( ( Functions.Find( G_SCURRENTMEETINGINFOREQUESTID , G_SRXDATA1 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 9446;
                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 9448;
                                    Trace( "  Found g_sCurrentMeetingInfoRequestID\r\n") ; 
                                    } 
                                
                                __context__.SourceCodeLine = 9450;
                                if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 9450;
                                    Print( "Inside else if (find(g_sCurrentMeetingInfoRequestID, g_sRXData1))\r\n") ; 
                                    }
                                
                                __context__.SourceCodeLine = 9452;
                                PROCESSMEETINGINFORESPONSE (  __context__ , (ushort)( 1 ), (ushort)( 1 ), G_SRXDATA1) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 9454;
                                if ( Functions.TestForTrue  ( ( Functions.Find( G_SCURRENTMEETINGPRESETDATAREQUESTID , G_SRXDATA1 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 9456;
                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 9458;
                                        Trace( "  Found g_sCurrentMeetingPresetDataRequestID\r\n") ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 9460;
                                    if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 9460;
                                        Print( "Inside else if (find(g_sCurrentMeetingPresetDataRequestID, g_sRXData1))\r\n") ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 9462;
                                    PROCESSMEETINGPRESETDATARESPONSE (  __context__ , G_SRXDATA1) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 9464;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( G_SNEXTMEETINGINFOREQUESTID , G_SRXDATA1 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 9466;
                                        if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 9468;
                                            Trace( "  Found g_sNextMeetingInfoRequestID\r\n") ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 9470;
                                        if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 9470;
                                            Print( "Inside else if (find(g_sNextMeetingInfoRequestID, g_sRXData1))\r\n") ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 9472;
                                        PROCESSMEETINGINFORESPONSE (  __context__ , (ushort)( 2 ), (ushort)( 1 ), G_SRXDATA1) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 9474;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "<RequestID>RVRequest</RequestID>" , G_SRXDATA1 ) ) && Functions.TestForTrue ( Functions.Find( "Action ID=\u0022RequestSchedule\u0022" , G_SRXDATA1 ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 9477;
                                            PROCESSED_RV_FORCED_REFRESH  .Value = (ushort) ( (PROCESSED_RV_FORCED_REFRESH  .Value + 1) ) ; 
                                            __context__.SourceCodeLine = 9478;
                                            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                                {
                                                __context__.SourceCodeLine = 9478;
                                                Print( "Inside else if (find(\u0022<RequestID>RVRequest</RequestID>\u0022, g_sRXData1) && find(\u0022Action ID=\u0022RequestSchedule\u0022\u0022, g_sRXData1))\r\n") ; 
                                                }
                                            
                                            __context__.SourceCodeLine = 9481;
                                            NEXTEVENT . MEETINGID  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9482;
                                            NEXTEVENT . INSTANCEID  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9483;
                                            NEXTEVENT . STARTDATE  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9484;
                                            NEXTEVENT . STARTTIME  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9485;
                                            NEXTEVENT . ENDDATE  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9486;
                                            NEXTEVENT . ENDTIME  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9487;
                                            NEXTEVENT . SUBJECT  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9488;
                                            NEXTEVENT . ORGANIZER  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 9489;
                                            NEXTEVENT . ISPRIVATE = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 9490;
                                            NEXTEVENT . ISEXCHANGEPRIVATE = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 9492;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORKDAY_SCHED_REQUEST_MODE  .Value == 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 9494;
                                                GETSCHEDULE (  __context__ , (ushort)( 1 ), G_SDATETODAY, "00:00:00", "24") ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 9498;
                                                G_BNEEDANOTHERWORKDAYREQUEST = (ushort) ( 1 ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 9501;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>UserSchedule" , G_SRXDATA1 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 9503;
                                                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 9505;
                                                    Trace( "  Found UserSchedule RequestID\r\n") ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 9507;
                                                if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 9507;
                                                    Print( "Inside else if (find(\u0022<RequestID>UserSchedule\u0022, g_sRXData1))\r\n") ; 
                                                    }
                                                
                                                __context__.SourceCodeLine = 9509;
                                                SENDUISCHEDDATA (  __context__ , G_SRXDATA1) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 9511;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>UserInfo" , G_SRXDATA1 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 9513;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 9515;
                                                        Trace( "  Found UserInfo RequestID\r\n") ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 9517;
                                                    if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 9517;
                                                        Print( "Inside else if (find(\u0022<RequestID>UserInfo\u0022, g_sRXData1))\r\n") ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 9519;
                                                    SENDUISCHEDDATA (  __context__ , G_SRXDATA1) ; 
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
    
private void PROCESSFROMRVCREATERESPONSE__DOLLAR__ (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 9525;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9527;
        Trace( "\r\n** ProcessFromRVCreateResponse$ **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9530;
    if ( Functions.TestForTrue  ( ( Functions.Find( G_SRESERVENOWREQUESTID , G_SRXDATA2 ))  ) ) 
        { 
        __context__.SourceCodeLine = 9532;
        PROCESSCREATERESPONSE (  __context__ , (ushort)( 0 ), G_SRXDATA2) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 9534;
        if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>UserCreate" , G_SRXDATA2 ))  ) ) 
            { 
            __context__.SourceCodeLine = 9536;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 9538;
                Trace( "  Found User RequestID\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 9541;
            SENDUICREATEDATA (  __context__ , G_SRXDATA2) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 9543;
            if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>AvailRoomsCreate" , G_SRXDATA2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 9545;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 9547;
                    Trace( "  Found Available Rooms RequestID\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 9550;
                SENDAVAILROOMSCREATEDATA (  __context__ , G_SRXDATA2) ; 
                } 
            
            }
        
        }
    
    
    }
    
private void PROCESSFROMRVACTIONRESPONSE__DOLLAR__ (  SplusExecutionContext __context__ ) 
    { 
    CrestronString SMEETINGID;
    SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    
    
    __context__.SourceCodeLine = 9558;
    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
        { 
        __context__.SourceCodeLine = 9560;
        Trace( "\r\n** ProcessFromRVActionResponse$ **\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 9563;
    if ( Functions.TestForTrue  ( ( Functions.Find( G_SACTIONPUSHREQUESTID , G_SRXDATA3 ))  ) ) 
        { 
        __context__.SourceCodeLine = 9565;
        PROCESSACTIONRESPONSE (  __context__ , G_SRXDATA3) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 9567;
        if ( Functions.TestForTrue  ( ( Functions.Find( G_SACTIONRVIDREQUESTID , G_SRXDATA3 ))  ) ) 
            { 
            __context__.SourceCodeLine = 9569;
            PROCESSACTIONRESPONSE (  __context__ , G_SRXDATA3) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 9571;
            if ( Functions.TestForTrue  ( ( Functions.Find( G_SENDMEETINGREQUESTID , G_SRXDATA3 ))  ) ) 
                { 
                __context__.SourceCodeLine = 9573;
                PROCESSACTIONRESPONSE (  __context__ , G_SRXDATA3) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 9575;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>RequestApptRefresh</RequestID>" , G_SRXDATA3 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9577;
                    PROCESSACTIONRESPONSE (  __context__ , G_SRXDATA3) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 9579;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>SchedAlertSubscription</RequestID>" , G_SRXDATA3 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9581;
                        PROCESSACTIONRESPONSE (  __context__ , G_SRXDATA3) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 9583;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<RequestID>SchedAlertBacklog</RequestID>" , G_SRXDATA3 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 9585;
                            PROCESSACTIONRESPONSE (  __context__ , G_SRXDATA3) ; 
                            } 
                        
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
        
        
        __context__.SourceCodeLine = 9598;
        INITIALIZE_MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9600;
        G_BHAVEMEETINGPRESETMODULE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9601;
        G_BHAVEREMOTESYSMODULE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9603;
        PROCESSED_PUSH_RESPONSES  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9604;
        PROCESSED_RV_FORCED_REFRESH  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9606;
        G_ISTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9607;
        G_IAUTOUPDATESTOREDEVENTCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9609;
        G_ISTARTEDEVENTNUM = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9610;
        G_SSTARTEDEVENTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9612;
        G_BNEEDANOTHERWORKDAYREQUEST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9614;
        G_BRXOK1 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9615;
        G_BRXOK2 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9616;
        G_BRXOK3 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9618;
        G_SRXDATA1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9619;
        G_SRXDATA2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9620;
        G_SRXDATA3  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9622;
        WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9623;
        NEXT_RESERV_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9624;
        FIRST_APPT_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9625;
        RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9626;
        REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9627;
        CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9628;
        CURRENT_MEETING_PRESET_DATA_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9629;
        NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9630;
        AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9632;
        HAVE_VALID_WORKDAY_SCHED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9634;
        G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9636;
        ENABLE_RESERVE_NOW  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9638;
        AUTO_UPDATE_NEED_SCHED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9639;
        AUTO_UPDATE_PROCESS_ACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9641;
        HAVE_NEXT_RESERVATION  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9642;
        NEXT_RESERVATION_PRIVATE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9644;
        G_BNEEDFIRSTAPPTREQUEST = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9646;
        G_BWAITINGTOSENDINFOEVENTLIST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9647;
        G_BWAITINGTOSENDUIEVENTLIST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9649;
        G_BWAITINGTOSENDRVDATA = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9651;
        RESERVE_NOW_MESSAGE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9653;
        G_SCURRENTMEETINGWELCOMEMSGID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9655;
        G_ILASTSENTGETPRESETDATAINDEX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9657;
        EWS_SUBSCRIPTION_OFFLINE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9658;
        ROOMSERVICE_BACKLOG_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9659;
        EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9661;
        SETDATETIMEVARS (  __context__  ) ; 
        __context__.SourceCodeLine = 9663;
        G_SMONTH [ 1 ]  .UpdateValue ( "January"  ) ; 
        __context__.SourceCodeLine = 9664;
        G_SMONTH [ 2 ]  .UpdateValue ( "February"  ) ; 
        __context__.SourceCodeLine = 9665;
        G_SMONTH [ 3 ]  .UpdateValue ( "March"  ) ; 
        __context__.SourceCodeLine = 9666;
        G_SMONTH [ 4 ]  .UpdateValue ( "April"  ) ; 
        __context__.SourceCodeLine = 9667;
        G_SMONTH [ 5 ]  .UpdateValue ( "May"  ) ; 
        __context__.SourceCodeLine = 9668;
        G_SMONTH [ 6 ]  .UpdateValue ( "June"  ) ; 
        __context__.SourceCodeLine = 9669;
        G_SMONTH [ 7 ]  .UpdateValue ( "July"  ) ; 
        __context__.SourceCodeLine = 9670;
        G_SMONTH [ 8 ]  .UpdateValue ( "August"  ) ; 
        __context__.SourceCodeLine = 9671;
        G_SMONTH [ 9 ]  .UpdateValue ( "September"  ) ; 
        __context__.SourceCodeLine = 9672;
        G_SMONTH [ 10 ]  .UpdateValue ( "October"  ) ; 
        __context__.SourceCodeLine = 9673;
        G_SMONTH [ 11 ]  .UpdateValue ( "November"  ) ; 
        __context__.SourceCodeLine = 9674;
        G_SMONTH [ 12 ]  .UpdateValue ( "December"  ) ; 
        __context__.SourceCodeLine = 9676;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)48; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 9678;
            TIME_BLOCK_MODE [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 9679;
            TIME_BLOCK_TEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 9676;
            } 
        
        __context__.SourceCodeLine = 9682;
        INITIALIZE_MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRIVACY_LEVEL_OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9687;
        UPDATECALENDAR (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMVIEW_ONLINE_FB_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9692;
        ROOMVIEWONLINEEVENTS (  __context__  ) ; 
        __context__.SourceCodeLine = 9694;
        if ( Functions.TestForTrue  ( ( AUTO_UPDATE_PROCESS_ACTIVE  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 9695;
            AUTOUPDATESTARTEVENTS (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMVIEW_ONLINE_FB_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9700;
        ROOMVIEWOFFLINEEVENTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_UPDATE_PUSH_START_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9706;
        if ( Functions.TestForTrue  ( ( Functions.Not( AUTO_UPDATE_PROCESS_ACTIVE  .Value ))  ) ) 
            {
            __context__.SourceCodeLine = 9707;
            AUTOUPDATESTARTEVENTS (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_UPDATE_GET_SCHEDULE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9713;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (AUTO_UPDATE_REQUEST_MODE  .Value == 0) ) && Functions.TestForTrue ( Functions.Not( G_BHAVEAUTOUPDATESCHEDULE ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 9715;
            GETSCHEDULE (  __context__ , (ushort)( 5 ), G_SAUTOUPDATEDATE, "00:00:00", "24") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_UPDATE_REQUEST_TIMEOUT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9721;
        AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 9722;
        AUTO_UPDATE_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9724;
        G_SAUTOUPDATEREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9726;
        GenerateUserError ( "Auto Update Schedule Request Timeout") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEBUG_PRINT_WORK_EVENTS_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9731;
        PRINTEVENTS (  __context__ , (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEBUG_PRINT_AUTOUPDATE_EVENTS_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9736;
        PRINTEVENTS (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEBUG_FORCE_RESERVE_NOW_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9741;
        RESERVENOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULE_REQUEST_TIMEOUT_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9746;
        WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 9747;
        WORKDAY_SCHED_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9749;
        G_BRESERVENOWSUCCESSNEEDSCHED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9751;
        GenerateUserError ( "Workday Schedule Request Timeout") ; 
        __context__.SourceCodeLine = 9753;
        SETRESERVENOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHECK_ROOM_STATUS_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9759;
        SETDATETIMEVARS (  __context__  ) ; 
        __context__.SourceCodeLine = 9761;
        if ( Functions.TestForTrue  ( ( HAVE_VALID_WORKDAY_SCHED  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 9765;
            if ( Functions.TestForTrue  ( ( AUTO_UPDATE_PROCESS_ACTIVE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 9769;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 9771;
                    Trace( "  AutoUpdateProcess active.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 9775;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SDATETODAY == G_SAUTOUPDATEDATE))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9779;
                    if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 9781;
                        Trace( "  System has moved to AutoUpdate date.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 9785;
                    AUTO_UPDATE_NEED_SCHED  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 9788;
                    if ( Functions.TestForTrue  ( ( Functions.Not( G_BHAVEAUTOUPDATESCHEDULE ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9790;
                        HAVE_VALID_WORKDAY_SCHED  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 9794;
                        HAVE_VALID_WORKDAY_SCHED  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 9798;
                    PROCESSED_PUSH_RESPONSES  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 9801;
                    PROCESSED_RV_FORCED_REFRESH  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 9804;
                    AUTO_UPDATE_PROCESS_ACTIVE  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 9807;
                    TRANSFERDATA (  __context__  ) ; 
                    __context__.SourceCodeLine = 9810;
                    UPDATECALENDAR (  __context__  ) ; 
                    __context__.SourceCodeLine = 9813;
                    SENDUIEVENTLIST (  __context__  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 9817;
            CHECKROOMSTATUS (  __context__ , (ushort)( 0 )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 9823;
            SETRESERVENOW (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_NOW_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9830;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (RESERVE_NOW_REQUEST_MODE  .Value == 0) ) && Functions.TestForTrue ( ENABLE_RESERVE_NOW  .Value )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 9832;
            if ( Functions.TestForTrue  ( ( RESERVE_NOW_TIME_SELECT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 9834;
                SET_RESERVE_NOW_SELECT  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 9836;
                if ( Functions.TestForTrue  ( ( SETRESERVENOWSTARTEND( __context__ , (ushort)( 00 ) , (ushort)( 30 ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9838;
                    RESERVE_NOW_SELECT_30_MODE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 9842;
                    RESERVE_NOW_SELECT_30_MODE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 9845;
                if ( Functions.TestForTrue  ( ( SETRESERVENOWSTARTEND( __context__ , (ushort)( 30 ) , (ushort)( 60 ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9847;
                    RESERVE_NOW_SELECT_60_MODE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 9851;
                    RESERVE_NOW_SELECT_60_MODE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 9854;
                if ( Functions.TestForTrue  ( ( SETRESERVENOWSTARTEND( __context__ , (ushort)( 60 ) , (ushort)( 90 ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9856;
                    RESERVE_NOW_SELECT_90_MODE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 9860;
                    RESERVE_NOW_SELECT_90_MODE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 9863;
                SET_RESERVE_NOW_SELECT  .Value = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 9867;
                SET_RESERVE_NOW_CONFIRM  .Value = (ushort) ( SETRESERVENOWSTARTEND( __context__ , (ushort)( 0 ) , (ushort)( RESERVE_NOW_DURATION  .UshortValue ) ) ) ; 
                __context__.SourceCodeLine = 9868;
                SET_RESERVE_NOW_CONFIRM  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_NOW_YES_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9875;
        RESERVENOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_NOW_SELECT_30_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9880;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESERVE_NOW_SELECT_30_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 9882;
            G_SRESERVENOWDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT30MIN, "Start")  ) ; 
            __context__.SourceCodeLine = 9883;
            G_SRESERVENOWDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT30MIN, "End")  ) ; 
            __context__.SourceCodeLine = 9884;
            RESERVENOW (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_NOW_SELECT_60_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9890;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESERVE_NOW_SELECT_60_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 9892;
            G_SRESERVENOWDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT60MIN, "Start")  ) ; 
            __context__.SourceCodeLine = 9893;
            G_SRESERVENOWDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT60MIN, "End")  ) ; 
            __context__.SourceCodeLine = 9894;
            RESERVENOW (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_NOW_SELECT_90_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9900;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESERVE_NOW_SELECT_90_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 9902;
            G_SRESERVENOWDTSTART  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT90MIN, "Start")  ) ; 
            __context__.SourceCodeLine = 9903;
            G_SRESERVENOWDTEND  .UpdateValue ( RESERVENOWTOINTDATEFORMAT (  __context__ , SELECT90MIN, "End")  ) ; 
            __context__.SourceCodeLine = 9904;
            RESERVENOW (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESERVE_NOW_TIMEOUT_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9911;
        RESERVE_NOW_MESSAGE__DOLLAR__  .UpdateValue ( "Request timed out."  ) ; 
        __context__.SourceCodeLine = 9913;
        RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 9914;
        RESERVE_NOW_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9916;
        SETRESERVENOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_MEETING_CONFIRM_NO_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9921;
        END_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9922;
        END_MEETING_BTN_FB  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_MEETING_CONFIRM_YES_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9927;
        ENDMEETING (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_MEETING_BTN_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9932;
        END_MEETING_BTN_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9933;
        END_MEETING_CONFIRM_SUB  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_MEETING_TIMEOUT_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9939;
        END_MEETING_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 9940;
        END_MEETING_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9942;
        SETENDMEETINGBTN (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_MEETING_BTN_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9947;
        START_MEETING_CONFIRM_SUB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 9948;
        START_MEETING_BTN_FB  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_MEETING_CONFIRM_NO_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9953;
        START_MEETING_CONFIRM_SUB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9954;
        START_MEETING_BTN_FB  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_MEETING_CONFIRM_YES_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9959;
        STARTMEETING (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_SCHEDULE_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString SDATE;
        SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        
        
        __context__.SourceCodeLine = 9967;
        SDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
        __context__.SourceCodeLine = 9970;
        G_SDATETODAY  .UpdateValue ( Functions.Left ( SDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( SDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SDATE ,  (int) ( 2 ) )  ) ; 
        __context__.SourceCodeLine = 9972;
        SCHEDULE_LABEL__DOLLAR__  .UpdateValue ( FORMATDATE (  __context__ , G_SDATETODAY, (ushort)( 1 ))  ) ; 
        __context__.SourceCodeLine = 9974;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORKDAY_SCHED_REQUEST_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 9976;
            GETSCHEDULE (  __context__ , (ushort)( 1 ), G_SDATETODAY, "00:00:00", "24") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REGISTER_PUSH_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9983;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (REGISTER_PUSH_REQUEST_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 9985;
            REGISTERPUSH (  __context__ , (ushort)( 1 )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REGISTER_PUSH_TIMEOUT_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 9991;
        G_SPUSHREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 9993;
        G_BPUSHENABLED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 9995;
        REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 9996;
        REGISTER_PUSH_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UNREGISTER_PUSH_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10001;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (REGISTER_PUSH_REQUEST_MODE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 10003;
            G_BPUSHENABLED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 10004;
            G_BNEEDFIRSTAPPTREQUEST = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 10006;
            REGISTERPUSH (  __context__ , (ushort)( 0 )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_CURRENT_MEETING_INFO_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10012;
        GETMEETINGINFO (  __context__ , (ushort)( 1 ), (ushort)( 1 ), MEETINGEVENT[ G_ICURRENTEVENTNUM ].MEETINGID) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_NEXT_MEETING_INFO_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10017;
        UPDATENEXTRESERVINFO (  __context__  ) ; 
        __context__.SourceCodeLine = 10019;
        GETMEETINGINFO (  __context__ , (ushort)( 2 ), (ushort)( 1 ), NEXTEVENT.MEETINGID) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_CURRENT_MEETING_INFO_TIMEOUT_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10024;
        G_SCURRENTMEETINGINFOREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 10026;
        CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( "Data Timeout!"  ) ; 
        __context__.SourceCodeLine = 10027;
        CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( "Data Timeout!"  ) ; 
        __context__.SourceCodeLine = 10029;
        CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 10031;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_5__" , 100 , __SPLS_TMPVAR__WAITLABEL_5___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_5___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 10033;
            CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 10034;
            CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 10036;
            CURRENT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10042;
        G_SCURRENTMEETINGPRESETDATAREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 10043;
        G_SLASTSENTGETPRESETDATAID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 10044;
        G_ILASTSENTGETPRESETDATAINDEX = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_NEXT_MEETING_INFO_TIMEOUT_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10049;
        G_SNEXTMEETINGINFOREQUESTID  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 10051;
        NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( "Data Timeout!"  ) ; 
        __context__.SourceCodeLine = 10052;
        NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( "Data Timeout!"  ) ; 
        __context__.SourceCodeLine = 10054;
        NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 10056;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_6__" , 100 , __SPLS_TMPVAR__WAITLABEL_6___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_6___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 10058;
            NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 10059;
            NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 10061;
            NEXT_MEETING_INFO_REQUEST_MODE  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object FROM_RV_SCHEDULERESPONSE__DOLLAR___OnChange_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10068;
        if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 10068;
            Print( "Change Event From_RV_ScheduleResponse$\r\ng_bRXOK1 = {0:d}\r\n", (ushort)G_BRXOK1) ; 
            }
        
        __context__.SourceCodeLine = 10070;
        if ( Functions.TestForTrue  ( ( G_BRXOK1)  ) ) 
            { 
            __context__.SourceCodeLine = 10072;
            G_BRXOK1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 10074;
            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 10074;
                Print( "Inside if (g_bRXOK1)\r\ng_bRXOK1 = {0:d}\r\n", (ushort)G_BRXOK1) ; 
                }
            
            __context__.SourceCodeLine = 10076;
            while ( Functions.TestForTrue  ( ( Functions.Find( "</ScheduleResponse>" , FROM_RV_SCHEDULERESPONSE__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 10078;
                G_SRXDATA1  .UpdateValue ( Functions.Remove ( "</ScheduleResponse>" , FROM_RV_SCHEDULERESPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 10080;
                if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 10080;
                    Print( "Inside CHANGE From_RV_ScheduleResponse$ While Loop\r\ng_sRXData1 = {0}\r\n", G_SRXDATA1 ) ; 
                    }
                
                __context__.SourceCodeLine = 10081;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 10083;
                    Trace( "** End ScheduleResponse Found **\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 10086;
                PROCESSFROMRVSCHEDULERESPONSE__DOLLAR__ (  __context__  ) ; 
                __context__.SourceCodeLine = 10076;
                } 
            
            __context__.SourceCodeLine = 10088;
            G_BRXOK1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 10089;
            if ( Functions.TestForTrue  ( ( DEBUG_PRESET_DATA  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 10089;
                Print( "Outside while(find(\u0022</ScheduleResponse>\u0022, From_RV_ScheduleResponse$))\r\ng_bRXOK1 = {0:d}\r\n", (ushort)G_BRXOK1) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_RV_CREATERESPONSE__DOLLAR___OnChange_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10095;
        if ( Functions.TestForTrue  ( ( G_BRXOK2)  ) ) 
            { 
            __context__.SourceCodeLine = 10097;
            G_BRXOK2 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 10099;
            while ( Functions.TestForTrue  ( ( Functions.Find( "</CreateScheduleResponse>" , FROM_RV_CREATERESPONSE__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 10101;
                G_SRXDATA2  .UpdateValue ( Functions.Remove ( "</CreateScheduleResponse>" , FROM_RV_CREATERESPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 10103;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 10105;
                    Trace( "** End CreateResponse Found **\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 10108;
                PROCESSFROMRVCREATERESPONSE__DOLLAR__ (  __context__  ) ; 
                __context__.SourceCodeLine = 10099;
                } 
            
            __context__.SourceCodeLine = 10111;
            G_BRXOK2 = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_RV_ACTIONRESPONSE__DOLLAR___OnChange_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10118;
        if ( Functions.TestForTrue  ( ( G_BRXOK3)  ) ) 
            { 
            __context__.SourceCodeLine = 10120;
            G_BRXOK3 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 10122;
            while ( Functions.TestForTrue  ( ( Functions.Find( "</ActionResponse>" , FROM_RV_ACTIONRESPONSE__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 10124;
                G_SRXDATA3  .UpdateValue ( Functions.Remove ( "</ActionResponse>" , FROM_RV_ACTIONRESPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 10126;
                if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 10128;
                    Trace( "** End ActionResponse Found **\r\n") ; 
                    __context__.SourceCodeLine = 10129;
                    Trace( "g_sRXData3: {0}\r\n", G_SRXDATA3 ) ; 
                    } 
                
                __context__.SourceCodeLine = 10132;
                PROCESSFROMRVACTIONRESPONSE__DOLLAR__ (  __context__  ) ; 
                __context__.SourceCodeLine = 10122;
                } 
            
            __context__.SourceCodeLine = 10135;
            G_BRXOK3 = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR___OnChange_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString STRASH;
        STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        
        __context__.SourceCodeLine = 10143;
        if ( Functions.TestForTrue  ( ( Functions.Find( "<MeetingPresetModule>Hello</MeetingPresetModule>" , FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ))  ) ) 
            { 
            __context__.SourceCodeLine = 10145;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 10146;
                Trace( "\r\n ** Meeting Info Module Connected **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 10148;
            G_BHAVEMEETINGPRESETMODULE = (ushort) ( 1 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 10150;
            if ( Functions.TestForTrue  ( ( Functions.Find( "<StartedEvent>" , FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 10152;
                G_ISTARTEDEVENTNUM = (ushort) ( Functions.Atoi( FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 10153;
                G_SSTARTEDEVENTID  .UpdateValue ( MEETINGEVENT [ G_ISTARTEDEVENTNUM] . MEETINGID  ) ; 
                __context__.SourceCodeLine = 10155;
                CHECKROOMSTATUS (  __context__ , (ushort)( 0 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 10157;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<EndMeeting>" , FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 10159;
                    G_ISTARTEDEVENTNUM = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 10160;
                    G_SSTARTEDEVENTID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 10162;
                    CHECKROOMSTATUS (  __context__ , (ushort)( 0 )) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 10164;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "<WelcomeMsg>" , FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 10166;
                        STRASH  .UpdateValue ( Functions.Remove ( "<WelcomeMsg>" , FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 10168;
                        G_SCURRENTWELCOMEMSG  .UpdateValue ( Functions.Left ( FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ,  (int) ( (Functions.Length( FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ ) - 13) ) )  ) ; 
                        __context__.SourceCodeLine = 10170;
                        UPDATECURRENTMEETINGINFO (  __context__  ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR___OnChange_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 10176;
        if ( Functions.TestForTrue  ( ( Functions.Find( "<RemoteSystemData>Hello</RemoteSystemData>" , FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ ))  ) ) 
            { 
            __context__.SourceCodeLine = 10180;
            if ( Functions.TestForTrue  ( ( DEBUG_LOGIC  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 10181;
                Trace( "\r\n ** Remote System Module Connected **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 10183;
            G_BHAVEREMOTESYSMODULE = (ushort) ( 1 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 10185;
            if ( Functions.TestForTrue  ( ( Functions.Find( "<Get ID=\u0022AllData\u0022 />" , FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 10187;
                SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 1 ), "") ; 
                __context__.SourceCodeLine = 10188;
                SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 2 ), "") ; 
                __context__.SourceCodeLine = 10189;
                SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 3 ), "") ; 
                __context__.SourceCodeLine = 10190;
                SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 5 ), "") ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 10192;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Get ID=\u0022WorkdaySchedule\u0022 />" , FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 10194;
                    SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 1 ), "") ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 10196;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "<Get ID=\u0022CurrentMeetingInfo\u0022 />" , FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 10198;
                        SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 2 ), "") ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 10200;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<Get ID=\u0022NextReservation\u0022 />" , FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 10202;
                            SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 3 ), "") ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 10204;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Get ID=\u0022DateTime\u0022 />" , FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 10206;
                                SENDREMOTESYSTEMDATA (  __context__ , (ushort)( 5 ), "") ; 
                                } 
                            
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


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_IBLOCKEVENTINDEX  = new ushort[ 49 ];
    G_SRXDATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65534, this );
    G_SRXDATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    G_SRXDATA3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    G_SDATETODAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SAUTOUPDATEDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SCURRENTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    G_SREQSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    G_SREQHOURSPAN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    G_SSTARTEDEVENTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SSCHEDULEREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SPUSHREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SRESERVENOWREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SENDMEETINGREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SACTIONRVIDREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SACTIONPUSHREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SNEXTRESERVREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SFIRSTAPPTREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SISPRIVATEREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SAUTOUPDATEREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SCURRENTMEETINGINFOREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SCURRENTMEETINGPRESETDATAREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SNEXTMEETINGINFOREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SNEXTMEETINGPRESETDATAREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 45, this );
    G_SRESERVENOWSTARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SRESERVENOWENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SRESERVENOWMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SENDMEETINGREQMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SCURRENTMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SLASTSENTNOSHOWID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SLASTSENTNOSHOWDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SLASTSENTGETMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SLASTSENTGETPRESETDATAID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SNEXTRESERVREQUESTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SAUTOUPDATEREQUESTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SFIRSTAPPTSTARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    G_SRESERVENOWDTSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    G_SRESERVENOWDTEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    G_SCURRENTMEETINGWELCOMEMSGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    G_SCURRENTWELCOMEMSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    G_SMONTH  = new CrestronString[ 13 ];
    for( uint i = 0; i < 13; i++ )
        G_SMONTH [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    TEMPMOVEEVENT  = new EVENTDATA( this, true );
    TEMPMOVEEVENT .PopulateCustomAttributeList( false );
    NEXTEVENT  = new NEXTDATA( this, true );
    NEXTEVENT .PopulateCustomAttributeList( false );
    CONFIRMEVENT  = new RESERVENOWDATA( this, true );
    CONFIRMEVENT .PopulateCustomAttributeList( false );
    SELECT30MIN  = new RESERVENOWDATA( this, true );
    SELECT30MIN .PopulateCustomAttributeList( false );
    SELECT60MIN  = new RESERVENOWDATA( this, true );
    SELECT60MIN .PopulateCustomAttributeList( false );
    SELECT90MIN  = new RESERVENOWDATA( this, true );
    SELECT90MIN .PopulateCustomAttributeList( false );
    MEETINGEVENT  = new EVENTDATA[ 49 ];
    for( uint i = 0; i < 49; i++ )
    {
        MEETINGEVENT [i] = new EVENTDATA( this, true );
        MEETINGEVENT [i].PopulateCustomAttributeList( false );
        
    }
    AUTOUPDATEMEETINGEVENT  = new EVENTDATA[ 49 ];
    for( uint i = 0; i < 49; i++ )
    {
        AUTOUPDATEMEETINGEVENT [i] = new EVENTDATA( this, true );
        AUTOUPDATEMEETINGEVENT [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG_LOGIC = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_LOGIC__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_LOGIC__DigitalInput__, DEBUG_LOGIC );
    
    DEBUG_PRINT_WORK_EVENTS = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_PRINT_WORK_EVENTS__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_PRINT_WORK_EVENTS__DigitalInput__, DEBUG_PRINT_WORK_EVENTS );
    
    DEBUG_PRINT_AUTOUPDATE_EVENTS = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_PRINT_AUTOUPDATE_EVENTS__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_PRINT_AUTOUPDATE_EVENTS__DigitalInput__, DEBUG_PRINT_AUTOUPDATE_EVENTS );
    
    DEBUG_FORCE_RESERVE_NOW = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_FORCE_RESERVE_NOW__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_FORCE_RESERVE_NOW__DigitalInput__, DEBUG_FORCE_RESERVE_NOW );
    
    DEBUG_PRESET_DATA = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_PRESET_DATA__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_PRESET_DATA__DigitalInput__, DEBUG_PRESET_DATA );
    
    INITIALIZE_MODULE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE_MODULE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE_MODULE__DigitalInput__, INITIALIZE_MODULE );
    
    CONFIG_EN_DECLINE_FOR_NOSHOW = new Crestron.Logos.SplusObjects.DigitalInput( CONFIG_EN_DECLINE_FOR_NOSHOW__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIG_EN_DECLINE_FOR_NOSHOW__DigitalInput__, CONFIG_EN_DECLINE_FOR_NOSHOW );
    
    CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN = new Crestron.Logos.SplusObjects.DigitalInput( CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN__DigitalInput__, CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN );
    
    CONFIG_EN_RESERVE_NOW = new Crestron.Logos.SplusObjects.DigitalInput( CONFIG_EN_RESERVE_NOW__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIG_EN_RESERVE_NOW__DigitalInput__, CONFIG_EN_RESERVE_NOW );
    
    CONFIG_EN_STARTMEETING = new Crestron.Logos.SplusObjects.DigitalInput( CONFIG_EN_STARTMEETING__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIG_EN_STARTMEETING__DigitalInput__, CONFIG_EN_STARTMEETING );
    
    CONFIG_EN_FREEUPROOM = new Crestron.Logos.SplusObjects.DigitalInput( CONFIG_EN_FREEUPROOM__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIG_EN_FREEUPROOM__DigitalInput__, CONFIG_EN_FREEUPROOM );
    
    TIME_FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT__DigitalInput__, TIME_FORMAT );
    
    EN_FREEBUSY_ATTRIBUTEDATA = new Crestron.Logos.SplusObjects.DigitalInput( EN_FREEBUSY_ATTRIBUTEDATA__DigitalInput__, this );
    m_DigitalInputList.Add( EN_FREEBUSY_ATTRIBUTEDATA__DigitalInput__, EN_FREEBUSY_ATTRIBUTEDATA );
    
    ROOMVIEW_ONLINE_FB = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE_FB__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE_FB__DigitalInput__, ROOMVIEW_ONLINE_FB );
    
    ROOM_OCCUPIED_FB = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_OCCUPIED_FB__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_OCCUPIED_FB__DigitalInput__, ROOM_OCCUPIED_FB );
    
    CHECK_ROOM_STATUS = new Crestron.Logos.SplusObjects.DigitalInput( CHECK_ROOM_STATUS__DigitalInput__, this );
    m_DigitalInputList.Add( CHECK_ROOM_STATUS__DigitalInput__, CHECK_ROOM_STATUS );
    
    GET_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( GET_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( GET_SCHEDULE__DigitalInput__, GET_SCHEDULE );
    
    SCHEDULE_REQUEST_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( SCHEDULE_REQUEST_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( SCHEDULE_REQUEST_TIMEOUT__DigitalInput__, SCHEDULE_REQUEST_TIMEOUT );
    
    RESERVE_NOW = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW__DigitalInput__, RESERVE_NOW );
    
    RESERVE_NOW_EVEN_END_TIME = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_EVEN_END_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_EVEN_END_TIME__DigitalInput__, RESERVE_NOW_EVEN_END_TIME );
    
    RESERVE_NOW_TIME_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_TIME_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_TIME_SELECT__DigitalInput__, RESERVE_NOW_TIME_SELECT );
    
    RESERVE_NOW_SELECT_30 = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_SELECT_30__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_SELECT_30__DigitalInput__, RESERVE_NOW_SELECT_30 );
    
    RESERVE_NOW_SELECT_60 = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_SELECT_60__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_SELECT_60__DigitalInput__, RESERVE_NOW_SELECT_60 );
    
    RESERVE_NOW_SELECT_90 = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_SELECT_90__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_SELECT_90__DigitalInput__, RESERVE_NOW_SELECT_90 );
    
    RESERVE_NOW_YES = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_YES__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_YES__DigitalInput__, RESERVE_NOW_YES );
    
    RESERVE_NOW_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( RESERVE_NOW_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( RESERVE_NOW_TIMEOUT__DigitalInput__, RESERVE_NOW_TIMEOUT );
    
    END_MEETING_BTN = new Crestron.Logos.SplusObjects.DigitalInput( END_MEETING_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( END_MEETING_BTN__DigitalInput__, END_MEETING_BTN );
    
    END_MEETING_CONFIRM_YES = new Crestron.Logos.SplusObjects.DigitalInput( END_MEETING_CONFIRM_YES__DigitalInput__, this );
    m_DigitalInputList.Add( END_MEETING_CONFIRM_YES__DigitalInput__, END_MEETING_CONFIRM_YES );
    
    END_MEETING_CONFIRM_NO = new Crestron.Logos.SplusObjects.DigitalInput( END_MEETING_CONFIRM_NO__DigitalInput__, this );
    m_DigitalInputList.Add( END_MEETING_CONFIRM_NO__DigitalInput__, END_MEETING_CONFIRM_NO );
    
    END_MEETING_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( END_MEETING_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( END_MEETING_TIMEOUT__DigitalInput__, END_MEETING_TIMEOUT );
    
    START_MEETING_BTN = new Crestron.Logos.SplusObjects.DigitalInput( START_MEETING_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( START_MEETING_BTN__DigitalInput__, START_MEETING_BTN );
    
    START_MEETING_CONFIRM_YES = new Crestron.Logos.SplusObjects.DigitalInput( START_MEETING_CONFIRM_YES__DigitalInput__, this );
    m_DigitalInputList.Add( START_MEETING_CONFIRM_YES__DigitalInput__, START_MEETING_CONFIRM_YES );
    
    START_MEETING_CONFIRM_NO = new Crestron.Logos.SplusObjects.DigitalInput( START_MEETING_CONFIRM_NO__DigitalInput__, this );
    m_DigitalInputList.Add( START_MEETING_CONFIRM_NO__DigitalInput__, START_MEETING_CONFIRM_NO );
    
    REGISTER_PUSH = new Crestron.Logos.SplusObjects.DigitalInput( REGISTER_PUSH__DigitalInput__, this );
    m_DigitalInputList.Add( REGISTER_PUSH__DigitalInput__, REGISTER_PUSH );
    
    UNREGISTER_PUSH = new Crestron.Logos.SplusObjects.DigitalInput( UNREGISTER_PUSH__DigitalInput__, this );
    m_DigitalInputList.Add( UNREGISTER_PUSH__DigitalInput__, UNREGISTER_PUSH );
    
    REGISTER_PUSH_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( REGISTER_PUSH_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( REGISTER_PUSH_TIMEOUT__DigitalInput__, REGISTER_PUSH_TIMEOUT );
    
    AUTO_UPDATE_PUSH_START = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_UPDATE_PUSH_START__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_UPDATE_PUSH_START__DigitalInput__, AUTO_UPDATE_PUSH_START );
    
    AUTO_UPDATE_GET_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_UPDATE_GET_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_UPDATE_GET_SCHEDULE__DigitalInput__, AUTO_UPDATE_GET_SCHEDULE );
    
    AUTO_UPDATE_REQUEST_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_UPDATE_REQUEST_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_UPDATE_REQUEST_TIMEOUT__DigitalInput__, AUTO_UPDATE_REQUEST_TIMEOUT );
    
    GET_CURRENT_MEETING_INFO = new Crestron.Logos.SplusObjects.DigitalInput( GET_CURRENT_MEETING_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( GET_CURRENT_MEETING_INFO__DigitalInput__, GET_CURRENT_MEETING_INFO );
    
    GET_CURRENT_MEETING_INFO_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( GET_CURRENT_MEETING_INFO_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( GET_CURRENT_MEETING_INFO_TIMEOUT__DigitalInput__, GET_CURRENT_MEETING_INFO_TIMEOUT );
    
    GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT__DigitalInput__, GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT );
    
    GET_NEXT_MEETING_INFO = new Crestron.Logos.SplusObjects.DigitalInput( GET_NEXT_MEETING_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( GET_NEXT_MEETING_INFO__DigitalInput__, GET_NEXT_MEETING_INFO );
    
    GET_NEXT_MEETING_INFO_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( GET_NEXT_MEETING_INFO_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( GET_NEXT_MEETING_INFO_TIMEOUT__DigitalInput__, GET_NEXT_MEETING_INFO_TIMEOUT );
    
    INITIALIZE_MODULE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZE_MODULE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZE_MODULE_BUSY_FB__DigitalOutput__, INITIALIZE_MODULE_BUSY_FB );
    
    PUSH_TRIGGERED_CHECK_ROOM_STATUS = new Crestron.Logos.SplusObjects.DigitalOutput( PUSH_TRIGGERED_CHECK_ROOM_STATUS__DigitalOutput__, this );
    m_DigitalOutputList.Add( PUSH_TRIGGERED_CHECK_ROOM_STATUS__DigitalOutput__, PUSH_TRIGGERED_CHECK_ROOM_STATUS );
    
    HAVE_VALID_WORKDAY_SCHED = new Crestron.Logos.SplusObjects.DigitalOutput( HAVE_VALID_WORKDAY_SCHED__DigitalOutput__, this );
    m_DigitalOutputList.Add( HAVE_VALID_WORKDAY_SCHED__DigitalOutput__, HAVE_VALID_WORKDAY_SCHED );
    
    SCHEDULE_UPDATED = new Crestron.Logos.SplusObjects.DigitalOutput( SCHEDULE_UPDATED__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCHEDULE_UPDATED__DigitalOutput__, SCHEDULE_UPDATED );
    
    MEETING_STARTED = new Crestron.Logos.SplusObjects.DigitalOutput( MEETING_STARTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( MEETING_STARTED__DigitalOutput__, MEETING_STARTED );
    
    MEETING_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MEETING_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MEETING_ACTIVE__DigitalOutput__, MEETING_ACTIVE );
    
    CURRENT_MEETING_PRIVATE = new Crestron.Logos.SplusObjects.DigitalOutput( CURRENT_MEETING_PRIVATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( CURRENT_MEETING_PRIVATE__DigitalOutput__, CURRENT_MEETING_PRIVATE );
    
    HAVE_NEXT_RESERVATION = new Crestron.Logos.SplusObjects.DigitalOutput( HAVE_NEXT_RESERVATION__DigitalOutput__, this );
    m_DigitalOutputList.Add( HAVE_NEXT_RESERVATION__DigitalOutput__, HAVE_NEXT_RESERVATION );
    
    NEXT_RESERVATION_PRIVATE = new Crestron.Logos.SplusObjects.DigitalOutput( NEXT_RESERVATION_PRIVATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEXT_RESERVATION_PRIVATE__DigitalOutput__, NEXT_RESERVATION_PRIVATE );
    
    END_MEETING_WARN_FB = new Crestron.Logos.SplusObjects.DigitalOutput( END_MEETING_WARN_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( END_MEETING_WARN_FB__DigitalOutput__, END_MEETING_WARN_FB );
    
    ENABLE_RESERVE_NOW = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_RESERVE_NOW__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENABLE_RESERVE_NOW__DigitalOutput__, ENABLE_RESERVE_NOW );
    
    SET_RESERVE_NOW_CONFIRM = new Crestron.Logos.SplusObjects.DigitalOutput( SET_RESERVE_NOW_CONFIRM__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_RESERVE_NOW_CONFIRM__DigitalOutput__, SET_RESERVE_NOW_CONFIRM );
    
    SET_RESERVE_NOW_SELECT = new Crestron.Logos.SplusObjects.DigitalOutput( SET_RESERVE_NOW_SELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_RESERVE_NOW_SELECT__DigitalOutput__, SET_RESERVE_NOW_SELECT );
    
    END_MEETING_BTN_SUB = new Crestron.Logos.SplusObjects.DigitalOutput( END_MEETING_BTN_SUB__DigitalOutput__, this );
    m_DigitalOutputList.Add( END_MEETING_BTN_SUB__DigitalOutput__, END_MEETING_BTN_SUB );
    
    END_MEETING_BTN_FB = new Crestron.Logos.SplusObjects.DigitalOutput( END_MEETING_BTN_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( END_MEETING_BTN_FB__DigitalOutput__, END_MEETING_BTN_FB );
    
    END_MEETING_CONFIRM_SUB = new Crestron.Logos.SplusObjects.DigitalOutput( END_MEETING_CONFIRM_SUB__DigitalOutput__, this );
    m_DigitalOutputList.Add( END_MEETING_CONFIRM_SUB__DigitalOutput__, END_MEETING_CONFIRM_SUB );
    
    START_MEETING_BTN_SUB = new Crestron.Logos.SplusObjects.DigitalOutput( START_MEETING_BTN_SUB__DigitalOutput__, this );
    m_DigitalOutputList.Add( START_MEETING_BTN_SUB__DigitalOutput__, START_MEETING_BTN_SUB );
    
    START_MEETING_BTN_FB = new Crestron.Logos.SplusObjects.DigitalOutput( START_MEETING_BTN_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( START_MEETING_BTN_FB__DigitalOutput__, START_MEETING_BTN_FB );
    
    START_MEETING_CONFIRM_SUB = new Crestron.Logos.SplusObjects.DigitalOutput( START_MEETING_CONFIRM_SUB__DigitalOutput__, this );
    m_DigitalOutputList.Add( START_MEETING_CONFIRM_SUB__DigitalOutput__, START_MEETING_CONFIRM_SUB );
    
    AUTO_UPDATE_NEED_SCHED = new Crestron.Logos.SplusObjects.DigitalOutput( AUTO_UPDATE_NEED_SCHED__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTO_UPDATE_NEED_SCHED__DigitalOutput__, AUTO_UPDATE_NEED_SCHED );
    
    AUTO_UPDATE_PROCESS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( AUTO_UPDATE_PROCESS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTO_UPDATE_PROCESS_ACTIVE__DigitalOutput__, AUTO_UPDATE_PROCESS_ACTIVE );
    
    EWS_SUBSCRIPTION_OFFLINE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( EWS_SUBSCRIPTION_OFFLINE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( EWS_SUBSCRIPTION_OFFLINE_FB__DigitalOutput__, EWS_SUBSCRIPTION_OFFLINE_FB );
    
    ROOMSERVICE_BACKLOG_ACTIVE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMSERVICE_BACKLOG_ACTIVE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMSERVICE_BACKLOG_ACTIVE_FB__DigitalOutput__, ROOMSERVICE_BACKLOG_ACTIVE_FB );
    
    PRIVACY_LEVEL = new Crestron.Logos.SplusObjects.AnalogInput( PRIVACY_LEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PRIVACY_LEVEL__AnalogSerialInput__, PRIVACY_LEVEL );
    
    COLUMN_WIDTH = new Crestron.Logos.SplusObjects.AnalogInput( COLUMN_WIDTH__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COLUMN_WIDTH__AnalogSerialInput__, COLUMN_WIDTH );
    
    FIELD_QTY = new Crestron.Logos.SplusObjects.AnalogInput( FIELD_QTY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FIELD_QTY__AnalogSerialInput__, FIELD_QTY );
    
    DATE_FORMAT = new Crestron.Logos.SplusObjects.AnalogInput( DATE_FORMAT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DATE_FORMAT__AnalogSerialInput__, DATE_FORMAT );
    
    CURRENT_PAGE = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_PAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_PAGE__AnalogSerialInput__, CURRENT_PAGE );
    
    MEETING_ACTIVE_WINDOW_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( MEETING_ACTIVE_WINDOW_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MEETING_ACTIVE_WINDOW_VALUE__AnalogSerialInput__, MEETING_ACTIVE_WINDOW_VALUE );
    
    END_NEXT_MEETING_WARN_TIME = new Crestron.Logos.SplusObjects.AnalogInput( END_NEXT_MEETING_WARN_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( END_NEXT_MEETING_WARN_TIME__AnalogSerialInput__, END_NEXT_MEETING_WARN_TIME );
    
    RESERVE_NOW_DURATION = new Crestron.Logos.SplusObjects.AnalogInput( RESERVE_NOW_DURATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RESERVE_NOW_DURATION__AnalogSerialInput__, RESERVE_NOW_DURATION );
    
    DECLINE_APPLIES_DURATION = new Crestron.Logos.SplusObjects.AnalogInput( DECLINE_APPLIES_DURATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DECLINE_APPLIES_DURATION__AnalogSerialInput__, DECLINE_APPLIES_DURATION );
    
    DECLINE_MEETING_MIN = new Crestron.Logos.SplusObjects.AnalogInput( DECLINE_MEETING_MIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DECLINE_MEETING_MIN__AnalogSerialInput__, DECLINE_MEETING_MIN );
    
    DECLINE_MEETING_PERCENT = new Crestron.Logos.SplusObjects.AnalogInput( DECLINE_MEETING_PERCENT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DECLINE_MEETING_PERCENT__AnalogSerialInput__, DECLINE_MEETING_PERCENT );
    
    SERIAL_PACING_TIME = new Crestron.Logos.SplusObjects.AnalogInput( SERIAL_PACING_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SERIAL_PACING_TIME__AnalogSerialInput__, SERIAL_PACING_TIME );
    
    MEETING_PRESET_START_TIME = new Crestron.Logos.SplusObjects.AnalogInput( MEETING_PRESET_START_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MEETING_PRESET_START_TIME__AnalogSerialInput__, MEETING_PRESET_START_TIME );
    
    WORKDAY_SCHED_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( WORKDAY_SCHED_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WORKDAY_SCHED_REQUEST_MODE__AnalogSerialOutput__, WORKDAY_SCHED_REQUEST_MODE );
    
    NEXT_RESERV_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( NEXT_RESERV_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NEXT_RESERV_REQUEST_MODE__AnalogSerialOutput__, NEXT_RESERV_REQUEST_MODE );
    
    FIRST_APPT_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( FIRST_APPT_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FIRST_APPT_REQUEST_MODE__AnalogSerialOutput__, FIRST_APPT_REQUEST_MODE );
    
    RESERVE_NOW_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_NOW_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_NOW_REQUEST_MODE__AnalogSerialOutput__, RESERVE_NOW_REQUEST_MODE );
    
    RESERVE_NOW_SELECT_30_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_NOW_SELECT_30_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_NOW_SELECT_30_MODE__AnalogSerialOutput__, RESERVE_NOW_SELECT_30_MODE );
    
    RESERVE_NOW_SELECT_60_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_NOW_SELECT_60_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_NOW_SELECT_60_MODE__AnalogSerialOutput__, RESERVE_NOW_SELECT_60_MODE );
    
    RESERVE_NOW_SELECT_90_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( RESERVE_NOW_SELECT_90_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RESERVE_NOW_SELECT_90_MODE__AnalogSerialOutput__, RESERVE_NOW_SELECT_90_MODE );
    
    END_MEETING_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( END_MEETING_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( END_MEETING_REQUEST_MODE__AnalogSerialOutput__, END_MEETING_REQUEST_MODE );
    
    REGISTER_PUSH_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( REGISTER_PUSH_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( REGISTER_PUSH_REQUEST_MODE__AnalogSerialOutput__, REGISTER_PUSH_REQUEST_MODE );
    
    CURRENT_MEETING_INFO_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_MEETING_INFO_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_MEETING_INFO_REQUEST_MODE__AnalogSerialOutput__, CURRENT_MEETING_INFO_REQUEST_MODE );
    
    CURRENT_MEETING_PRESET_DATA_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_MEETING_PRESET_DATA_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_MEETING_PRESET_DATA_REQUEST_MODE__AnalogSerialOutput__, CURRENT_MEETING_PRESET_DATA_REQUEST_MODE );
    
    NEXT_MEETING_INFO_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( NEXT_MEETING_INFO_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NEXT_MEETING_INFO_REQUEST_MODE__AnalogSerialOutput__, NEXT_MEETING_INFO_REQUEST_MODE );
    
    AUTO_UPDATE_REQUEST_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( AUTO_UPDATE_REQUEST_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUTO_UPDATE_REQUEST_MODE__AnalogSerialOutput__, AUTO_UPDATE_REQUEST_MODE );
    
    CURRENT_TIME_BARGRAPH_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TIME_BARGRAPH_VALUE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TIME_BARGRAPH_VALUE__AnalogSerialOutput__, CURRENT_TIME_BARGRAPH_VALUE );
    
    END_MEETING_WARN_COUNTDOWN_SEED = new Crestron.Logos.SplusObjects.AnalogOutput( END_MEETING_WARN_COUNTDOWN_SEED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( END_MEETING_WARN_COUNTDOWN_SEED__AnalogSerialOutput__, END_MEETING_WARN_COUNTDOWN_SEED );
    
    PROCESSED_PUSH_RESPONSES = new Crestron.Logos.SplusObjects.AnalogOutput( PROCESSED_PUSH_RESPONSES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PROCESSED_PUSH_RESPONSES__AnalogSerialOutput__, PROCESSED_PUSH_RESPONSES );
    
    PROCESSED_RV_FORCED_REFRESH = new Crestron.Logos.SplusObjects.AnalogOutput( PROCESSED_RV_FORCED_REFRESH__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PROCESSED_RV_FORCED_REFRESH__AnalogSerialOutput__, PROCESSED_RV_FORCED_REFRESH );
    
    CURRENT_TIME_HOUR = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TIME_HOUR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TIME_HOUR__AnalogSerialOutput__, CURRENT_TIME_HOUR );
    
    CURRENT_TIME_MINUTE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TIME_MINUTE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TIME_MINUTE__AnalogSerialOutput__, CURRENT_TIME_MINUTE );
    
    CURRENT_MEETING_DURATION_MIN = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_MEETING_DURATION_MIN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_MEETING_DURATION_MIN__AnalogSerialOutput__, CURRENT_MEETING_DURATION_MIN );
    
    CURRENT_MEETING_ELAPSED_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_MEETING_ELAPSED_TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_MEETING_ELAPSED_TIME__AnalogSerialOutput__, CURRENT_MEETING_ELAPSED_TIME );
    
    CURRENT_MEETING_ELAPSED_PERCENT = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_MEETING_ELAPSED_PERCENT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_MEETING_ELAPSED_PERCENT__AnalogSerialOutput__, CURRENT_MEETING_ELAPSED_PERCENT );
    
    TIME_BLOCK_MODE = new InOutArray<AnalogOutput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        TIME_BLOCK_MODE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( TIME_BLOCK_MODE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( TIME_BLOCK_MODE__AnalogSerialOutput__ + i, TIME_BLOCK_MODE[i+1] );
    }
    
    DEFAULT_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT_SUBJECT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( DEFAULT_SUBJECT__DOLLAR____AnalogSerialInput__, DEFAULT_SUBJECT__DOLLAR__ );
    
    DEFAULT_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT_ORGANIZER__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( DEFAULT_ORGANIZER__DOLLAR____AnalogSerialInput__, DEFAULT_ORGANIZER__DOLLAR__ );
    
    RESERVE_NOW_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RESERVE_NOW_SUBJECT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( RESERVE_NOW_SUBJECT__DOLLAR____AnalogSerialInput__, RESERVE_NOW_SUBJECT__DOLLAR__ );
    
    RESERVE_NOW_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RESERVE_NOW_ORGANIZER__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( RESERVE_NOW_ORGANIZER__DOLLAR____AnalogSerialInput__, RESERVE_NOW_ORGANIZER__DOLLAR__ );
    
    ROOM_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ROOM_NAME__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( ROOM_NAME__DOLLAR____AnalogSerialInput__, ROOM_NAME__DOLLAR__ );
    
    FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__ );
    
    FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR____AnalogSerialInput__, FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__ );
    
    TO_RV_SCHEDULEQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_SCHEDULEQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_SCHEDULEQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_SCHEDULEQUERY__DOLLAR__ );
    
    TO_RV_CREATEMEETING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__, TO_RV_CREATEMEETING__DOLLAR__ );
    
    TO_RV_ACTIONQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_ACTIONQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_ACTIONQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_ACTIONQUERY__DOLLAR__ );
    
    TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR____AnalogSerialOutput__, TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR__ );
    
    TO_NOSHOW_MOD_DATAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_NOSHOW_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_NOSHOW_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, TO_NOSHOW_MOD_DATAIN__DOLLAR__ );
    
    TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_MEETINGPRESET_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_MEETINGPRESET_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, TO_MEETINGPRESET_MOD_DATAIN__DOLLAR__ );
    
    TO_UI_MOD_DATAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_UI_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_UI_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, TO_UI_MOD_DATAIN__DOLLAR__ );
    
    TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR__ );
    
    TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_REMOTE_SYS_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_REMOTE_SYS_MOD_DATAIN__DOLLAR____AnalogSerialOutput__, TO_REMOTE_SYS_MOD_DATAIN__DOLLAR__ );
    
    CURRENT_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TIME__DOLLAR____AnalogSerialOutput__, CURRENT_TIME__DOLLAR__ );
    
    CURRENT_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_DATE__DOLLAR____AnalogSerialOutput__, CURRENT_DATE__DOLLAR__ );
    
    LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR____AnalogSerialOutput__, LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR__ );
    
    SCHEDULE_LABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_LABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SCHEDULE_LABEL__DOLLAR____AnalogSerialOutput__, SCHEDULE_LABEL__DOLLAR__ );
    
    CURRENTTIME_MEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENTTIME_MEETING_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTTIME_MEETING_ID__DOLLAR____AnalogSerialOutput__, CURRENTTIME_MEETING_ID__DOLLAR__ );
    
    CURRENTTIME_RVMEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENTTIME_RVMEETING_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTTIME_RVMEETING_ID__DOLLAR____AnalogSerialOutput__, CURRENTTIME_RVMEETING_ID__DOLLAR__ );
    
    CURRENT_MEETING_MEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_MEETING_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_MEETING_ID__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_MEETING_ID__DOLLAR__ );
    
    CURRENT_MEETING_RVMEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_RVMEETING_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_RVMEETING_ID__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_RVMEETING_ID__DOLLAR__ );
    
    CURRENT_MEETING_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_ORGANIZER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_ORGANIZER__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_ORGANIZER__DOLLAR__ );
    
    CURRENT_MEETING_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_SUBJECT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_SUBJECT__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_SUBJECT__DOLLAR__ );
    
    CURRENT_MEETING_START_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_START_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_START_DATE__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_START_DATE__DOLLAR__ );
    
    CURRENT_MEETING_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_START_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_START_TIME__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_START_TIME__DOLLAR__ );
    
    CURRENT_MEETING_END_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_END_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_END_DATE__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_END_DATE__DOLLAR__ );
    
    CURRENT_MEETING_END_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_END_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_END_TIME__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_END_TIME__DOLLAR__ );
    
    CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR__ );
    
    CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR__ );
    
    CURRENT_MEETING_STARTEND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_STARTEND__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_STARTEND__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_STARTEND__DOLLAR__ );
    
    CURRENT_MEETING_WELCOME_MSG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEETING_WELCOME_MSG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_MEETING_WELCOME_MSG__DOLLAR____AnalogSerialOutput__, CURRENT_MEETING_WELCOME_MSG__DOLLAR__ );
    
    NEXT_RESERVATION_IN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_IN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_IN__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_IN__DOLLAR__ );
    
    NEXT_RESERVATION_ORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_ORGANIZER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_ORGANIZER__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_ORGANIZER__DOLLAR__ );
    
    NEXT_RESERVATION_SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_SUBJECT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_SUBJECT__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_SUBJECT__DOLLAR__ );
    
    NEXT_RESERVATION_START_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_START_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_START_DATE__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_START_DATE__DOLLAR__ );
    
    NEXT_RESERVATION_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_START_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_START_TIME__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_START_TIME__DOLLAR__ );
    
    NEXT_RESERVATION_END_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_END_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_END_DATE__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_END_DATE__DOLLAR__ );
    
    NEXT_RESERVATION_END_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_END_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_END_TIME__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_END_TIME__DOLLAR__ );
    
    NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR__ );
    
    NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR__ );
    
    NEXT_RESERVATION_HRMIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_HRMIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_HRMIN__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_HRMIN__DOLLAR__ );
    
    NEXT_RESERVATION_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_DATE__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_DATE__DOLLAR__ );
    
    NEXT_RESERVATION_DATETIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NEXT_RESERVATION_DATETIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_RESERVATION_DATETIME__DOLLAR____AnalogSerialOutput__, NEXT_RESERVATION_DATETIME__DOLLAR__ );
    
    TIME_REMAINING_HRMIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REMAINING_HRMIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TIME_REMAINING_HRMIN__DOLLAR____AnalogSerialOutput__, TIME_REMAINING_HRMIN__DOLLAR__ );
    
    RESERVE_NOW_SELECT_30__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_NOW_SELECT_30__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_NOW_SELECT_30__DOLLAR____AnalogSerialOutput__, RESERVE_NOW_SELECT_30__DOLLAR__ );
    
    RESERVE_NOW_SELECT_60__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_NOW_SELECT_60__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_NOW_SELECT_60__DOLLAR____AnalogSerialOutput__, RESERVE_NOW_SELECT_60__DOLLAR__ );
    
    RESERVE_NOW_SELECT_90__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_NOW_SELECT_90__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_NOW_SELECT_90__DOLLAR____AnalogSerialOutput__, RESERVE_NOW_SELECT_90__DOLLAR__ );
    
    RESERVE_NOW_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_NOW_START_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_NOW_START_TIME__DOLLAR____AnalogSerialOutput__, RESERVE_NOW_START_TIME__DOLLAR__ );
    
    RESERVE_NOW_END_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_NOW_END_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_NOW_END_TIME__DOLLAR____AnalogSerialOutput__, RESERVE_NOW_END_TIME__DOLLAR__ );
    
    LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR____AnalogSerialOutput__, LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR__ );
    
    RESERVE_NOW_MESSAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVE_NOW_MESSAGE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESERVE_NOW_MESSAGE__DOLLAR____AnalogSerialOutput__, RESERVE_NOW_MESSAGE__DOLLAR__ );
    
    EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR____AnalogSerialOutput__, EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR__ );
    
    ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR____AnalogSerialOutput__, ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR__ );
    
    TIME_BLOCK_TEXT__DOLLAR__ = new InOutArray<StringOutput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        TIME_BLOCK_TEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TIME_BLOCK_TEXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TIME_BLOCK_TEXT__DOLLAR____AnalogSerialOutput__ + i, TIME_BLOCK_TEXT__DOLLAR__[i+1] );
    }
    
    FROM_RV_SCHEDULERESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_SCHEDULERESPONSE__DOLLAR____AnalogSerialInput__, 65534, this );
    m_StringInputList.Add( FROM_RV_SCHEDULERESPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_SCHEDULERESPONSE__DOLLAR__ );
    
    FROM_RV_CREATERESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_CREATERESPONSE__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( FROM_RV_CREATERESPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_CREATERESPONSE__DOLLAR__ );
    
    FROM_RV_ACTIONRESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_ACTIONRESPONSE__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( FROM_RV_ACTIONRESPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_ACTIONRESPONSE__DOLLAR__ );
    
    GETSCHEDULEDELAYWAIT_Callback = new WaitFunction( GETSCHEDULEDELAYWAIT_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_3___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_3___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_4___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_4___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_5___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_5___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_6___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_6___CallbackFn );
    
    INITIALIZE_MODULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_MODULE_OnPush_0, false ) );
    PRIVACY_LEVEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( PRIVACY_LEVEL_OnChange_1, false ) );
    ROOMVIEW_ONLINE_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_FB_OnPush_2, false ) );
    ROOMVIEW_ONLINE_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_FB_OnRelease_3, false ) );
    AUTO_UPDATE_PUSH_START.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_UPDATE_PUSH_START_OnPush_4, false ) );
    AUTO_UPDATE_GET_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_UPDATE_GET_SCHEDULE_OnPush_5, false ) );
    AUTO_UPDATE_REQUEST_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_UPDATE_REQUEST_TIMEOUT_OnPush_6, false ) );
    DEBUG_PRINT_WORK_EVENTS.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_PRINT_WORK_EVENTS_OnPush_7, false ) );
    DEBUG_PRINT_AUTOUPDATE_EVENTS.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_PRINT_AUTOUPDATE_EVENTS_OnPush_8, false ) );
    DEBUG_FORCE_RESERVE_NOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_FORCE_RESERVE_NOW_OnPush_9, false ) );
    SCHEDULE_REQUEST_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCHEDULE_REQUEST_TIMEOUT_OnPush_10, false ) );
    CHECK_ROOM_STATUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHECK_ROOM_STATUS_OnPush_11, false ) );
    RESERVE_NOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_NOW_OnPush_12, false ) );
    RESERVE_NOW_YES.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_NOW_YES_OnPush_13, false ) );
    RESERVE_NOW_SELECT_30.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_NOW_SELECT_30_OnPush_14, false ) );
    RESERVE_NOW_SELECT_60.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_NOW_SELECT_60_OnPush_15, false ) );
    RESERVE_NOW_SELECT_90.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_NOW_SELECT_90_OnPush_16, false ) );
    RESERVE_NOW_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESERVE_NOW_TIMEOUT_OnPush_17, false ) );
    END_MEETING_CONFIRM_NO.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_MEETING_CONFIRM_NO_OnPush_18, false ) );
    END_MEETING_CONFIRM_YES.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_MEETING_CONFIRM_YES_OnPush_19, false ) );
    END_MEETING_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_MEETING_BTN_OnPush_20, false ) );
    END_MEETING_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_MEETING_TIMEOUT_OnPush_21, false ) );
    START_MEETING_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MEETING_BTN_OnPush_22, false ) );
    START_MEETING_CONFIRM_NO.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MEETING_CONFIRM_NO_OnPush_23, false ) );
    START_MEETING_CONFIRM_YES.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MEETING_CONFIRM_YES_OnPush_24, false ) );
    GET_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_SCHEDULE_OnPush_25, false ) );
    REGISTER_PUSH.OnDigitalPush.Add( new InputChangeHandlerWrapper( REGISTER_PUSH_OnPush_26, false ) );
    REGISTER_PUSH_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REGISTER_PUSH_TIMEOUT_OnPush_27, false ) );
    UNREGISTER_PUSH.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNREGISTER_PUSH_OnPush_28, false ) );
    GET_CURRENT_MEETING_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_CURRENT_MEETING_INFO_OnPush_29, false ) );
    GET_NEXT_MEETING_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_NEXT_MEETING_INFO_OnPush_30, false ) );
    GET_CURRENT_MEETING_INFO_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_CURRENT_MEETING_INFO_TIMEOUT_OnPush_31, false ) );
    GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT_OnPush_32, false ) );
    GET_NEXT_MEETING_INFO_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_NEXT_MEETING_INFO_TIMEOUT_OnPush_33, false ) );
    FROM_RV_SCHEDULERESPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_SCHEDULERESPONSE__DOLLAR___OnChange_34, false ) );
    FROM_RV_CREATERESPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_CREATERESPONSE__DOLLAR___OnChange_35, false ) );
    FROM_RV_ACTIONRESPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_ACTIONRESPONSE__DOLLAR___OnChange_36, false ) );
    FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR___OnChange_37, false ) );
    FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR___OnChange_38, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_SCHEDULE_INTERFACE_WORKDAY_V7_2_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction GETSCHEDULEDELAYWAIT_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_3___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_4___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_5___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_6___Callback;


const uint DEBUG_LOGIC__DigitalInput__ = 0;
const uint DEBUG_PRINT_WORK_EVENTS__DigitalInput__ = 1;
const uint DEBUG_PRINT_AUTOUPDATE_EVENTS__DigitalInput__ = 2;
const uint DEBUG_FORCE_RESERVE_NOW__DigitalInput__ = 3;
const uint DEBUG_PRESET_DATA__DigitalInput__ = 4;
const uint INITIALIZE_MODULE__DigitalInput__ = 5;
const uint CONFIG_EN_DECLINE_FOR_NOSHOW__DigitalInput__ = 6;
const uint CONFIG_DECLINE_FOR_NOSHOW_EN_CHECKATEXACTMIN__DigitalInput__ = 7;
const uint CONFIG_EN_RESERVE_NOW__DigitalInput__ = 8;
const uint CONFIG_EN_STARTMEETING__DigitalInput__ = 9;
const uint CONFIG_EN_FREEUPROOM__DigitalInput__ = 10;
const uint TIME_FORMAT__DigitalInput__ = 11;
const uint EN_FREEBUSY_ATTRIBUTEDATA__DigitalInput__ = 12;
const uint ROOMVIEW_ONLINE_FB__DigitalInput__ = 13;
const uint ROOM_OCCUPIED_FB__DigitalInput__ = 14;
const uint CHECK_ROOM_STATUS__DigitalInput__ = 15;
const uint GET_SCHEDULE__DigitalInput__ = 16;
const uint SCHEDULE_REQUEST_TIMEOUT__DigitalInput__ = 17;
const uint RESERVE_NOW__DigitalInput__ = 18;
const uint RESERVE_NOW_EVEN_END_TIME__DigitalInput__ = 19;
const uint RESERVE_NOW_TIME_SELECT__DigitalInput__ = 20;
const uint RESERVE_NOW_SELECT_30__DigitalInput__ = 21;
const uint RESERVE_NOW_SELECT_60__DigitalInput__ = 22;
const uint RESERVE_NOW_SELECT_90__DigitalInput__ = 23;
const uint RESERVE_NOW_YES__DigitalInput__ = 24;
const uint RESERVE_NOW_TIMEOUT__DigitalInput__ = 25;
const uint END_MEETING_BTN__DigitalInput__ = 26;
const uint END_MEETING_CONFIRM_YES__DigitalInput__ = 27;
const uint END_MEETING_CONFIRM_NO__DigitalInput__ = 28;
const uint END_MEETING_TIMEOUT__DigitalInput__ = 29;
const uint START_MEETING_BTN__DigitalInput__ = 30;
const uint START_MEETING_CONFIRM_YES__DigitalInput__ = 31;
const uint START_MEETING_CONFIRM_NO__DigitalInput__ = 32;
const uint REGISTER_PUSH__DigitalInput__ = 33;
const uint UNREGISTER_PUSH__DigitalInput__ = 34;
const uint REGISTER_PUSH_TIMEOUT__DigitalInput__ = 35;
const uint AUTO_UPDATE_PUSH_START__DigitalInput__ = 36;
const uint AUTO_UPDATE_GET_SCHEDULE__DigitalInput__ = 37;
const uint AUTO_UPDATE_REQUEST_TIMEOUT__DigitalInput__ = 38;
const uint GET_CURRENT_MEETING_INFO__DigitalInput__ = 39;
const uint GET_CURRENT_MEETING_INFO_TIMEOUT__DigitalInput__ = 40;
const uint GET_CURRENT_MEETING_PRESET_DATA_TIMEOUT__DigitalInput__ = 41;
const uint GET_NEXT_MEETING_INFO__DigitalInput__ = 42;
const uint GET_NEXT_MEETING_INFO_TIMEOUT__DigitalInput__ = 43;
const uint PRIVACY_LEVEL__AnalogSerialInput__ = 0;
const uint COLUMN_WIDTH__AnalogSerialInput__ = 1;
const uint FIELD_QTY__AnalogSerialInput__ = 2;
const uint DATE_FORMAT__AnalogSerialInput__ = 3;
const uint CURRENT_PAGE__AnalogSerialInput__ = 4;
const uint MEETING_ACTIVE_WINDOW_VALUE__AnalogSerialInput__ = 5;
const uint END_NEXT_MEETING_WARN_TIME__AnalogSerialInput__ = 6;
const uint RESERVE_NOW_DURATION__AnalogSerialInput__ = 7;
const uint DECLINE_APPLIES_DURATION__AnalogSerialInput__ = 8;
const uint DECLINE_MEETING_MIN__AnalogSerialInput__ = 9;
const uint DECLINE_MEETING_PERCENT__AnalogSerialInput__ = 10;
const uint SERIAL_PACING_TIME__AnalogSerialInput__ = 11;
const uint MEETING_PRESET_START_TIME__AnalogSerialInput__ = 12;
const uint DEFAULT_SUBJECT__DOLLAR____AnalogSerialInput__ = 13;
const uint DEFAULT_ORGANIZER__DOLLAR____AnalogSerialInput__ = 14;
const uint RESERVE_NOW_SUBJECT__DOLLAR____AnalogSerialInput__ = 15;
const uint RESERVE_NOW_ORGANIZER__DOLLAR____AnalogSerialInput__ = 16;
const uint ROOM_NAME__DOLLAR____AnalogSerialInput__ = 17;
const uint FROM_MEETINGPRESET_MOD_DATAOUT__DOLLAR____AnalogSerialInput__ = 18;
const uint FROM_REMOTE_SYS_MOD_DATAOUT__DOLLAR____AnalogSerialInput__ = 19;
const uint FROM_RV_SCHEDULERESPONSE__DOLLAR____AnalogSerialInput__ = 20;
const uint FROM_RV_CREATERESPONSE__DOLLAR____AnalogSerialInput__ = 21;
const uint FROM_RV_ACTIONRESPONSE__DOLLAR____AnalogSerialInput__ = 22;
const uint INITIALIZE_MODULE_BUSY_FB__DigitalOutput__ = 0;
const uint PUSH_TRIGGERED_CHECK_ROOM_STATUS__DigitalOutput__ = 1;
const uint HAVE_VALID_WORKDAY_SCHED__DigitalOutput__ = 2;
const uint SCHEDULE_UPDATED__DigitalOutput__ = 3;
const uint MEETING_STARTED__DigitalOutput__ = 4;
const uint MEETING_ACTIVE__DigitalOutput__ = 5;
const uint CURRENT_MEETING_PRIVATE__DigitalOutput__ = 6;
const uint HAVE_NEXT_RESERVATION__DigitalOutput__ = 7;
const uint NEXT_RESERVATION_PRIVATE__DigitalOutput__ = 8;
const uint END_MEETING_WARN_FB__DigitalOutput__ = 9;
const uint ENABLE_RESERVE_NOW__DigitalOutput__ = 10;
const uint SET_RESERVE_NOW_CONFIRM__DigitalOutput__ = 11;
const uint SET_RESERVE_NOW_SELECT__DigitalOutput__ = 12;
const uint END_MEETING_BTN_SUB__DigitalOutput__ = 13;
const uint END_MEETING_BTN_FB__DigitalOutput__ = 14;
const uint END_MEETING_CONFIRM_SUB__DigitalOutput__ = 15;
const uint START_MEETING_BTN_SUB__DigitalOutput__ = 16;
const uint START_MEETING_BTN_FB__DigitalOutput__ = 17;
const uint START_MEETING_CONFIRM_SUB__DigitalOutput__ = 18;
const uint AUTO_UPDATE_NEED_SCHED__DigitalOutput__ = 19;
const uint AUTO_UPDATE_PROCESS_ACTIVE__DigitalOutput__ = 20;
const uint EWS_SUBSCRIPTION_OFFLINE_FB__DigitalOutput__ = 21;
const uint ROOMSERVICE_BACKLOG_ACTIVE_FB__DigitalOutput__ = 22;
const uint WORKDAY_SCHED_REQUEST_MODE__AnalogSerialOutput__ = 0;
const uint NEXT_RESERV_REQUEST_MODE__AnalogSerialOutput__ = 1;
const uint FIRST_APPT_REQUEST_MODE__AnalogSerialOutput__ = 2;
const uint RESERVE_NOW_REQUEST_MODE__AnalogSerialOutput__ = 3;
const uint RESERVE_NOW_SELECT_30_MODE__AnalogSerialOutput__ = 4;
const uint RESERVE_NOW_SELECT_60_MODE__AnalogSerialOutput__ = 5;
const uint RESERVE_NOW_SELECT_90_MODE__AnalogSerialOutput__ = 6;
const uint END_MEETING_REQUEST_MODE__AnalogSerialOutput__ = 7;
const uint REGISTER_PUSH_REQUEST_MODE__AnalogSerialOutput__ = 8;
const uint CURRENT_MEETING_INFO_REQUEST_MODE__AnalogSerialOutput__ = 9;
const uint CURRENT_MEETING_PRESET_DATA_REQUEST_MODE__AnalogSerialOutput__ = 10;
const uint NEXT_MEETING_INFO_REQUEST_MODE__AnalogSerialOutput__ = 11;
const uint AUTO_UPDATE_REQUEST_MODE__AnalogSerialOutput__ = 12;
const uint CURRENT_TIME_BARGRAPH_VALUE__AnalogSerialOutput__ = 13;
const uint END_MEETING_WARN_COUNTDOWN_SEED__AnalogSerialOutput__ = 14;
const uint PROCESSED_PUSH_RESPONSES__AnalogSerialOutput__ = 15;
const uint PROCESSED_RV_FORCED_REFRESH__AnalogSerialOutput__ = 16;
const uint CURRENT_TIME_HOUR__AnalogSerialOutput__ = 17;
const uint CURRENT_TIME_MINUTE__AnalogSerialOutput__ = 18;
const uint CURRENT_MEETING_DURATION_MIN__AnalogSerialOutput__ = 19;
const uint CURRENT_MEETING_ELAPSED_TIME__AnalogSerialOutput__ = 20;
const uint CURRENT_MEETING_ELAPSED_PERCENT__AnalogSerialOutput__ = 21;
const uint TO_RV_SCHEDULEQUERY__DOLLAR____AnalogSerialOutput__ = 22;
const uint TO_RV_CREATEMEETING__DOLLAR____AnalogSerialOutput__ = 23;
const uint TO_RV_ACTIONQUERY__DOLLAR____AnalogSerialOutput__ = 24;
const uint TO_RV_FREEBUSY_ATTRIBUTEDATA__DOLLAR____AnalogSerialOutput__ = 25;
const uint TO_NOSHOW_MOD_DATAIN__DOLLAR____AnalogSerialOutput__ = 26;
const uint TO_MEETINGPRESET_MOD_DATAIN__DOLLAR____AnalogSerialOutput__ = 27;
const uint TO_UI_MOD_DATAIN__DOLLAR____AnalogSerialOutput__ = 28;
const uint TO_AVAIL_ROOMS_MOD_DATAIN__DOLLAR____AnalogSerialOutput__ = 29;
const uint TO_REMOTE_SYS_MOD_DATAIN__DOLLAR____AnalogSerialOutput__ = 30;
const uint CURRENT_TIME__DOLLAR____AnalogSerialOutput__ = 31;
const uint CURRENT_DATE__DOLLAR____AnalogSerialOutput__ = 32;
const uint LAST_RECEIVED_SCHEDULE_TIME_DATE__DOLLAR____AnalogSerialOutput__ = 33;
const uint SCHEDULE_LABEL__DOLLAR____AnalogSerialOutput__ = 34;
const uint CURRENTTIME_MEETING_ID__DOLLAR____AnalogSerialOutput__ = 35;
const uint CURRENTTIME_RVMEETING_ID__DOLLAR____AnalogSerialOutput__ = 36;
const uint CURRENT_MEETING_MEETING_ID__DOLLAR____AnalogSerialOutput__ = 37;
const uint CURRENT_MEETING_RVMEETING_ID__DOLLAR____AnalogSerialOutput__ = 38;
const uint CURRENT_MEETING_ORGANIZER__DOLLAR____AnalogSerialOutput__ = 39;
const uint CURRENT_MEETING_SUBJECT__DOLLAR____AnalogSerialOutput__ = 40;
const uint CURRENT_MEETING_START_DATE__DOLLAR____AnalogSerialOutput__ = 41;
const uint CURRENT_MEETING_START_TIME__DOLLAR____AnalogSerialOutput__ = 42;
const uint CURRENT_MEETING_END_DATE__DOLLAR____AnalogSerialOutput__ = 43;
const uint CURRENT_MEETING_END_TIME__DOLLAR____AnalogSerialOutput__ = 44;
const uint CURRENT_MEETING_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__ = 45;
const uint CURRENT_MEETING_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__ = 46;
const uint CURRENT_MEETING_STARTEND__DOLLAR____AnalogSerialOutput__ = 47;
const uint CURRENT_MEETING_WELCOME_MSG__DOLLAR____AnalogSerialOutput__ = 48;
const uint NEXT_RESERVATION_IN__DOLLAR____AnalogSerialOutput__ = 49;
const uint NEXT_RESERVATION_ORGANIZER__DOLLAR____AnalogSerialOutput__ = 50;
const uint NEXT_RESERVATION_SUBJECT__DOLLAR____AnalogSerialOutput__ = 51;
const uint NEXT_RESERVATION_START_DATE__DOLLAR____AnalogSerialOutput__ = 52;
const uint NEXT_RESERVATION_START_TIME__DOLLAR____AnalogSerialOutput__ = 53;
const uint NEXT_RESERVATION_END_DATE__DOLLAR____AnalogSerialOutput__ = 54;
const uint NEXT_RESERVATION_END_TIME__DOLLAR____AnalogSerialOutput__ = 55;
const uint NEXT_RESERVATION_REQUIRED_ATTENDEES__DOLLAR____AnalogSerialOutput__ = 56;
const uint NEXT_RESERVATION_OPTIONAL_ATTENDEES__DOLLAR____AnalogSerialOutput__ = 57;
const uint NEXT_RESERVATION_HRMIN__DOLLAR____AnalogSerialOutput__ = 58;
const uint NEXT_RESERVATION_DATE__DOLLAR____AnalogSerialOutput__ = 59;
const uint NEXT_RESERVATION_DATETIME__DOLLAR____AnalogSerialOutput__ = 60;
const uint TIME_REMAINING_HRMIN__DOLLAR____AnalogSerialOutput__ = 61;
const uint RESERVE_NOW_SELECT_30__DOLLAR____AnalogSerialOutput__ = 62;
const uint RESERVE_NOW_SELECT_60__DOLLAR____AnalogSerialOutput__ = 63;
const uint RESERVE_NOW_SELECT_90__DOLLAR____AnalogSerialOutput__ = 64;
const uint RESERVE_NOW_START_TIME__DOLLAR____AnalogSerialOutput__ = 65;
const uint RESERVE_NOW_END_TIME__DOLLAR____AnalogSerialOutput__ = 66;
const uint LAST_PROCESSED_PUSH_RESPONSE_DATETIME__DOLLAR____AnalogSerialOutput__ = 67;
const uint RESERVE_NOW_MESSAGE__DOLLAR____AnalogSerialOutput__ = 68;
const uint EWS_SUBSCRIPTION_OFFLINE_MSG__DOLLAR____AnalogSerialOutput__ = 69;
const uint ROOMSERVICE_BACKLOG_ACTIVE_MSG__DOLLAR____AnalogSerialOutput__ = 70;
const uint TIME_BLOCK_MODE__AnalogSerialOutput__ = 71;
const uint TIME_BLOCK_TEXT__DOLLAR____AnalogSerialOutput__ = 119;

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
    public CrestronString  RVMEETINGID;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  INSTANCEID;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  STARTBLOCK = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  ENDBLOCK = 0;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  STARTDATE;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  ENDDATE;
    
    [SplusStructAttribute(7, false, false)]
    public CrestronString  STARTTIME;
    
    [SplusStructAttribute(8, false, false)]
    public CrestronString  ENDTIME;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  SUBJECT;
    
    [SplusStructAttribute(10, false, false)]
    public ushort  ISPRIVATE = 0;
    
    [SplusStructAttribute(11, false, false)]
    public ushort  ISEXCHANGEPRIVATE = 0;
    
    [SplusStructAttribute(12, false, false)]
    public CrestronString  ORGANIZER;
    
    [SplusStructAttribute(13, false, false)]
    public ushort  RECURRING = 0;
    
    
    public EVENTDATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        MEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, Owner );
        RVMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        INSTANCEID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, Owner );
        STARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        ENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        STARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, Owner );
        ENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, Owner );
        SUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, Owner );
        ORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class NEXTDATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  MEETINGID;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  INSTANCEID;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  STARTDATE;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  STARTTIME;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  ENDDATE;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  ENDTIME;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  SUBJECT;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  ISPRIVATE = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  ISEXCHANGEPRIVATE = 0;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  ORGANIZER;
    
    
    public NEXTDATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        MEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, Owner );
        INSTANCEID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, Owner );
        STARTDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        STARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        ENDDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        ENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, Owner );
        SUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, Owner );
        ORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
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
