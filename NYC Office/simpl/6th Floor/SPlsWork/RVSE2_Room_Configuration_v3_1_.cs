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

namespace UserModule_RVSE2_ROOM_CONFIGURATION_V3_1_
{
    public class UserModuleClass_RVSE2_ROOM_CONFIGURATION_V3_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE_MODULE;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_ALL_STORED_DATA;
        Crestron.Logos.SplusObjects.DigitalInput GET_CONFIGURATION;
        Crestron.Logos.SplusObjects.DigitalInput DATA_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput LOAD_STORED_VALUES;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_MEETING_INFO;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_MEETING_SUBJECT;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_MEETING_TIMES;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_DAY_VIEW;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_DAY_VIEW_GET_INFO;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_DAY_VIEW_ADD_APPT;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_DAY_VIEW_EN_PREV_DAY;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_MENU_SHOW_RESERVE_NOW;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_RESERVE_NOW_EVEN_END_TIME;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_RESERVE_NOW_TIME_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_NEXT_RESERVE_SHOW_INFO;
        Crestron.Logos.SplusObjects.DigitalInput UI_CONFIG_PANEL_WAKE_UP_TO_MEETING;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_PRIVACY_LEVEL_SEMI;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_MOTION_SENSOR_TYPE;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_MOTION_SENSOR_OUTPUT;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_EN_END_MEETING_BTN;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_EN_START_MEETING_BTN;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_CONFIG_EN_BROADCAST_MESSAGE;
        Crestron.Logos.SplusObjects.DigitalInput DATE_FORMAT_US;
        Crestron.Logos.SplusObjects.DigitalInput DATE_FORMAT_EURO;
        Crestron.Logos.SplusObjects.DigitalInput DATE_FORMAT_INT;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT;
        Crestron.Logos.SplusObjects.StringInput ROOMID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULTSUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_ROOMCONFIGREPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZE_MODULE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_EN_TOOLS_PAGE;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_MEETING_INFO;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_DAY_VIEW;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_AVAILABLE_ROOMS;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_RESERVE_NOW;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_SEARCH_WIZARD;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_DAYVIEW_EN_INFO;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_DAYVIEW_EN_ADD_APPT;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_DAYVIEW_EN_PREVIOUS_DAY;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_DECLINEFORNOSHOW;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_PUSHMODEL;
        Crestron.Logos.SplusObjects.DigitalOutput DECLINEFORNOSHOW_CHECKATEXACTMIN;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_BROADCASTMESSAGE;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_FREEUPROOM;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_STARTMEETING;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_PANELWAKEUP;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_FREEUPROOM_EN_MIN;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_FREEUPROOM_EN_PER;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_MOTIONSENSOR_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_MOTIONSENSOR_OUTPUT;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_MOTIONSENSOR_LED_TRACK;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_RESERVENOW_EVEN_END_TIME;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_RESERVENOW_TIME_SELECT;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_EN_AVAILABLETIMES;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_SUBJECT;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_ORGANIZER;
        Crestron.Logos.SplusObjects.DigitalOutput MENU_SHOW_TIMES;
        Crestron.Logos.SplusObjects.DigitalOutput CONFIG_TIME_FORMAT;
        Crestron.Logos.SplusObjects.AnalogOutput MODULE_STATUS;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_DECLINEFORNOSHOWAPPLIESDUR;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_DECLINEFORNOSHOWMIN;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_RESERVENOWMAXDUR;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_ROOMPRIVACYLEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_DATE_FORMAT;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_DECLINEFORNOSHOWPER;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_FREEUPROOM_ENUSEMIN;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_FREEUPROOM_ENUSEPER;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIG_MOTIONSENSOR_TIMEOUT;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_ROOMCONFIGQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_ROOMID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_ROOMNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_ROOMFRIENDLYNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_ROOMDESCRIPTION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_ROOMLOCATION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_ROOMTIMEZONE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_DEFAULTSUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_DEFAULTORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR__;
        ushort G_BRXOK = 0;
        CrestronString G_SRXDATA;
        ushort G_IDATAINDEX = 0;
        CrestronString G_SREQUESTID;
        private void PROCESSCONFIGDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SREMOVED;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            ushort INODE = 0;
            ushort IPOS = 0;
            ushort ICUSTOMID = 0;
            ushort ICUSTOMTYPE = 0;
            ushort IDECLINETYPE = 0;
            
            ushort BVALUE = 0;
            ushort IVALUE = 0;
            ushort COUNT = 0;
            
            CrestronString SVALUE;
            SVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            CrestronString TEST1;
            CrestronString TEST2;
            CrestronString TEST3;
            CrestronString TEST4;
            TEST1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            TEST2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            TEST3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            TEST4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 429;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 431;
                Trace( "\r\n** ProcessConfigData **\r\n") ; 
                __context__.SourceCodeLine = 432;
                Trace( "  Data Len:{0:d}\r\n", (ushort)Functions.Length( SDATA )) ; 
                } 
            
            __context__.SourceCodeLine = 435;
            INODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 436;
            ICUSTOMID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 437;
            ICUSTOMTYPE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 438;
            BVALUE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 439;
            IVALUE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 440;
            SVALUE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 441;
            COUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 443;
            do 
                { 
                __context__.SourceCodeLine = 445;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 447;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 448;
                    Trace( "Removed:{0}\r\n", SREMOVED ) ; 
                    }
                
                __context__.SourceCodeLine = 450;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 452;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</ID>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 454;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 455;
                            Trace( "Found Room ID\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 457;
                        CONFIG_ROOMID__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 5) ) )  ) ; 
                        __context__.SourceCodeLine = 458;
                        _SplusNVRAM.CONFIGDATA . ROOMID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 5) ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 460;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Name>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 462;
                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 463;
                                Trace( "Found Name\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 465;
                            CONFIG_ROOMNAME__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 7) ) )  ) ; 
                            __context__.SourceCodeLine = 466;
                            _SplusNVRAM.CONFIGDATA . ROOMNAME  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 7) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 468;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Description>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 470;
                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 471;
                                    Trace( "Found Description\r\n") ; 
                                    }
                                
                                __context__.SourceCodeLine = 473;
                                CONFIG_ROOMDESCRIPTION__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 14) ) )  ) ; 
                                __context__.SourceCodeLine = 474;
                                _SplusNVRAM.CONFIGDATA . ROOMDESCRIPTION  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 14) ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 476;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</Location>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 478;
                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 479;
                                        Trace( "Found Location\r\n") ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 481;
                                    CONFIG_ROOMLOCATION__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                    __context__.SourceCodeLine = 482;
                                    _SplusNVRAM.CONFIGDATA . ROOMLOCATION  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 484;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</TimeZone>" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 486;
                                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 487;
                                            Trace( "Found TimeZone\r\n") ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 489;
                                        CONFIG_ROOMTIMEZONE__DOLLAR__  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                        __context__.SourceCodeLine = 490;
                                        _SplusNVRAM.CONFIGDATA . ROOMTIMEZONE  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 492;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomFields>" , SREMOVED ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 494;
                                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                {
                                                __context__.SourceCodeLine = 495;
                                                Trace( "Begin Custom Fields\r\n") ; 
                                                }
                                            
                                            __context__.SourceCodeLine = 497;
                                            INODE = (ushort) ( 2 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 499;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Capabilities>" , SREMOVED ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 501;
                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 502;
                                                    Trace( "Begin Capabilites\r\n") ; 
                                                    }
                                                
                                                __context__.SourceCodeLine = 504;
                                                INODE = (ushort) ( 3 ) ; 
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
                    __context__.SourceCodeLine = 507;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 509;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</CustomFields>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 511;
                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 512;
                                Trace( "End Custom Fields\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 514;
                            INODE = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 520;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICUSTOMID == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 522;
                                ICUSTOMTYPE = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 524;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowMeetingInfo\u0022" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 526;
                                    ICUSTOMID = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 528;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowMeetingSubject\u0022" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 530;
                                        ICUSTOMID = (ushort) ( 53 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 532;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowMeetingOrganizer\u0022" , SREMOVED ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 534;
                                            ICUSTOMID = (ushort) ( 52 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 536;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowMeetingTimes\u0022" , SREMOVED ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 538;
                                                ICUSTOMID = (ushort) ( 54 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 540;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowAvailableTime\u0022" , SREMOVED ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 542;
                                                    ICUSTOMID = (ushort) ( 51 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 544;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuBkgdImageURL\u0022" , SREMOVED ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 546;
                                                        ICUSTOMID = (ushort) ( 55 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 548;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuLogoImageURL\u0022" , SREMOVED ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 550;
                                                            ICUSTOMID = (ushort) ( 56 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 552;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowDayView\u0022" , SREMOVED ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 554;
                                                                ICUSTOMID = (ushort) ( 2 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 556;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowAvailableRooms\u0022" , SREMOVED ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 558;
                                                                    ICUSTOMID = (ushort) ( 3 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 560;
                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowReserveNow\u0022" , SREMOVED ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 562;
                                                                        ICUSTOMID = (ushort) ( 4 ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 564;
                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuShowSearchWizard\u0022" , SREMOVED ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 566;
                                                                            ICUSTOMID = (ushort) ( 5 ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 568;
                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuDayViewEnInfo\u0022" , SREMOVED ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 570;
                                                                                ICUSTOMID = (ushort) ( 6 ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 572;
                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuDayViewEnReserve\u0022" , SREMOVED ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 574;
                                                                                    ICUSTOMID = (ushort) ( 7 ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 576;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuDayViewEnPrevDay\u0022" , SREMOVED ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 578;
                                                                                        ICUSTOMID = (ushort) ( 8 ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 580;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DefaultSubject\u0022" , SREMOVED ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 582;
                                                                                            ICUSTOMID = (ushort) ( 20 ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 584;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DefaultOrganizer\u0022" , SREMOVED ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 586;
                                                                                                ICUSTOMID = (ushort) ( 21 ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 588;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022RoomPrivacyLevel\u0022" , SREMOVED ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 590;
                                                                                                    ICUSTOMID = (ushort) ( 22 ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 592;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022IncludeInAvailRooms\u0022" , SREMOVED ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 594;
                                                                                                        ICUSTOMID = (ushort) ( 59 ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 596;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022EnFreeUpRoom\u0022" , SREMOVED ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 598;
                                                                                                            ICUSTOMID = (ushort) ( 37 ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 600;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022FreeUpRoomEnUseMin\u0022" , SREMOVED ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 602;
                                                                                                                ICUSTOMID = (ushort) ( 43 ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 604;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022FreeUpRoomEnUsePer\u0022" , SREMOVED ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 606;
                                                                                                                    ICUSTOMID = (ushort) ( 44 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 608;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022FreeUpRoomEnMin\u0022" , SREMOVED ))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 610;
                                                                                                                        ICUSTOMID = (ushort) ( 41 ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 612;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022FreeUpRoomEnPer\u0022" , SREMOVED ))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 614;
                                                                                                                            ICUSTOMID = (ushort) ( 42 ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 616;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022EnDeclineForNoShow\u0022" , SREMOVED ))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 618;
                                                                                                                                ICUSTOMID = (ushort) ( 36 ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 620;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DeclineForNoShowAppliesDur\u0022" , SREMOVED ))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 622;
                                                                                                                                    ICUSTOMID = (ushort) ( 31 ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 624;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DeclineForNoShowMin\u0022" , SREMOVED ))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 626;
                                                                                                                                        ICUSTOMID = (ushort) ( 33 ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    else 
                                                                                                                                        {
                                                                                                                                        __context__.SourceCodeLine = 628;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DeclineForNoShowPer\u0022" , SREMOVED ))  ) ) 
                                                                                                                                            { 
                                                                                                                                            __context__.SourceCodeLine = 630;
                                                                                                                                            ICUSTOMID = (ushort) ( 34 ) ; 
                                                                                                                                            } 
                                                                                                                                        
                                                                                                                                        else 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 632;
                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DeclineForNoShowEnCheckAtExactMin\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                { 
                                                                                                                                                __context__.SourceCodeLine = 634;
                                                                                                                                                ICUSTOMID = (ushort) ( 32 ) ; 
                                                                                                                                                } 
                                                                                                                                            
                                                                                                                                            else 
                                                                                                                                                {
                                                                                                                                                __context__.SourceCodeLine = 636;
                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022EnStartMeeting\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                    { 
                                                                                                                                                    __context__.SourceCodeLine = 638;
                                                                                                                                                    ICUSTOMID = (ushort) ( 38 ) ; 
                                                                                                                                                    } 
                                                                                                                                                
                                                                                                                                                else 
                                                                                                                                                    {
                                                                                                                                                    __context__.SourceCodeLine = 640;
                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022ReserveNowEvenEndTime\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                        { 
                                                                                                                                                        __context__.SourceCodeLine = 642;
                                                                                                                                                        ICUSTOMID = (ushort) ( 49 ) ; 
                                                                                                                                                        } 
                                                                                                                                                    
                                                                                                                                                    else 
                                                                                                                                                        {
                                                                                                                                                        __context__.SourceCodeLine = 644;
                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022ReserveNowTimeSelection\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                            { 
                                                                                                                                                            __context__.SourceCodeLine = 646;
                                                                                                                                                            ICUSTOMID = (ushort) ( 50 ) ; 
                                                                                                                                                            } 
                                                                                                                                                        
                                                                                                                                                        else 
                                                                                                                                                            {
                                                                                                                                                            __context__.SourceCodeLine = 648;
                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022ReserveNowMaxDur\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                { 
                                                                                                                                                                __context__.SourceCodeLine = 650;
                                                                                                                                                                ICUSTOMID = (ushort) ( 26 ) ; 
                                                                                                                                                                } 
                                                                                                                                                            
                                                                                                                                                            else 
                                                                                                                                                                {
                                                                                                                                                                __context__.SourceCodeLine = 652;
                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022RoomFriendlyName\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                    { 
                                                                                                                                                                    __context__.SourceCodeLine = 654;
                                                                                                                                                                    ICUSTOMID = (ushort) ( 27 ) ; 
                                                                                                                                                                    } 
                                                                                                                                                                
                                                                                                                                                                else 
                                                                                                                                                                    {
                                                                                                                                                                    __context__.SourceCodeLine = 656;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MotionSensorType\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 658;
                                                                                                                                                                        ICUSTOMID = (ushort) ( 48 ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    else 
                                                                                                                                                                        {
                                                                                                                                                                        __context__.SourceCodeLine = 660;
                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MotionSensorOutput\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                            { 
                                                                                                                                                                            __context__.SourceCodeLine = 662;
                                                                                                                                                                            ICUSTOMID = (ushort) ( 46 ) ; 
                                                                                                                                                                            } 
                                                                                                                                                                        
                                                                                                                                                                        else 
                                                                                                                                                                            {
                                                                                                                                                                            __context__.SourceCodeLine = 664;
                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MotionSensorTimeout\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                { 
                                                                                                                                                                                __context__.SourceCodeLine = 666;
                                                                                                                                                                                ICUSTOMID = (ushort) ( 47 ) ; 
                                                                                                                                                                                } 
                                                                                                                                                                            
                                                                                                                                                                            else 
                                                                                                                                                                                {
                                                                                                                                                                                __context__.SourceCodeLine = 668;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MotionSensorLEDSTrack\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 670;
                                                                                                                                                                                    ICUSTOMID = (ushort) ( 45 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                else 
                                                                                                                                                                                    {
                                                                                                                                                                                    __context__.SourceCodeLine = 672;
                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022DateFormat\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 674;
                                                                                                                                                                                        ICUSTOMID = (ushort) ( 30 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    else 
                                                                                                                                                                                        {
                                                                                                                                                                                        __context__.SourceCodeLine = 676;
                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022TimeFormat\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                            { 
                                                                                                                                                                                            __context__.SourceCodeLine = 678;
                                                                                                                                                                                            ICUSTOMID = (ushort) ( 57 ) ; 
                                                                                                                                                                                            } 
                                                                                                                                                                                        
                                                                                                                                                                                        else 
                                                                                                                                                                                            {
                                                                                                                                                                                            __context__.SourceCodeLine = 680;
                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022EnBroadcastMessage\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                                { 
                                                                                                                                                                                                __context__.SourceCodeLine = 682;
                                                                                                                                                                                                ICUSTOMID = (ushort) ( 35 ) ; 
                                                                                                                                                                                                } 
                                                                                                                                                                                            
                                                                                                                                                                                            else 
                                                                                                                                                                                                {
                                                                                                                                                                                                __context__.SourceCodeLine = 684;
                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022EnToolsMenu\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                                    { 
                                                                                                                                                                                                    __context__.SourceCodeLine = 686;
                                                                                                                                                                                                    ICUSTOMID = (ushort) ( 39 ) ; 
                                                                                                                                                                                                    } 
                                                                                                                                                                                                
                                                                                                                                                                                                else 
                                                                                                                                                                                                    {
                                                                                                                                                                                                    __context__.SourceCodeLine = 688;
                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<CustomField ID=\u0022MenuEnWakeupToMeeting\u0022" , SREMOVED ))  ) ) 
                                                                                                                                                                                                        { 
                                                                                                                                                                                                        __context__.SourceCodeLine = 690;
                                                                                                                                                                                                        ICUSTOMID = (ushort) ( 58 ) ; 
                                                                                                                                                                                                        } 
                                                                                                                                                                                                    
                                                                                                                                                                                                    else 
                                                                                                                                                                                                        { 
                                                                                                                                                                                                        __context__.SourceCodeLine = 694;
                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                                                                                                                                                                            {
                                                                                                                                                                                                            __context__.SourceCodeLine = 695;
                                                                                                                                                                                                            Trace( "CustomID not identified!\r\nsRemoved: {0}", SREMOVED ) ; 
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
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 703;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</CustomField>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 705;
                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 706;
                                        Trace( "End Custom Field\r\n\r\n") ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 708;
                                    ICUSTOMID = (ushort) ( 0 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 710;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</CustomFieldType>" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 712;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "bool" , Functions.Lower( SREMOVED ) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 714;
                                            ICUSTOMTYPE = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 716;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "date" , Functions.Lower( SREMOVED ) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 718;
                                                ICUSTOMTYPE = (ushort) ( 2 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 720;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "int" , Functions.Lower( SREMOVED ) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 722;
                                                    ICUSTOMTYPE = (ushort) ( 3 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 724;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "string" , Functions.Lower( SREMOVED ) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 726;
                                                        ICUSTOMTYPE = (ushort) ( 4 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 728;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "text" , Functions.Lower( SREMOVED ) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 730;
                                                            ICUSTOMTYPE = (ushort) ( 5 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 732;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "url" , Functions.Lower( SREMOVED ) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 734;
                                                                ICUSTOMTYPE = (ushort) ( 6 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 738;
                                                                ICUSTOMTYPE = (ushort) ( 0 ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 741;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</CustomFieldValue>" , SREMOVED ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 743;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICUSTOMTYPE != 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 745;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICUSTOMTYPE == 1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 747;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "true" , Functions.Lower( SREMOVED ) ) ) || Functions.TestForTrue ( Functions.Find( "1" , SREMOVED ) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 749;
                                                        BVALUE = (ushort) ( 1 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 753;
                                                        BVALUE = (ushort) ( 0 ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 756;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ICUSTOMTYPE == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (ICUSTOMTYPE == 4) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICUSTOMTYPE == 5) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICUSTOMTYPE == 6) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 759;
                                                        SVALUE  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 19) ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 761;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICUSTOMTYPE == 3))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 763;
                                                            IVALUE = (ushort) ( Functions.Atoi( SREMOVED ) ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                __context__.SourceCodeLine = 766;
                                                COUNT = (ushort) ( (COUNT + 1) ) ; 
                                                __context__.SourceCodeLine = 768;
                                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 770;
                                                    Trace( "iCustomID:     {0:d}\r\n", (short)ICUSTOMID) ; 
                                                    __context__.SourceCodeLine = 771;
                                                    Trace( "iCustomType:   {0:d}\r\n", (short)ICUSTOMTYPE) ; 
                                                    __context__.SourceCodeLine = 772;
                                                    switch ((int)ICUSTOMTYPE)
                                                    
                                                        { 
                                                        case 3 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 776;
                                                            Trace( "iCustomValue:  {0:d}\r\n", (short)IVALUE) ; 
                                                            __context__.SourceCodeLine = 777;
                                                            break ; 
                                                            } 
                                                        
                                                        goto case 1 ;
                                                        case 1 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 781;
                                                            if ( Functions.TestForTrue  ( ( BVALUE)  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 782;
                                                                Trace( "bCustomValue:  TRUE\r\n") ; 
                                                                }
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 784;
                                                                Trace( "bCustomValue:  FALSE\r\n") ; 
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 785;
                                                            break ; 
                                                            } 
                                                        
                                                        goto case 4 ;
                                                        case 4 : 
                                                        
                                                            { 
                                                            __context__.SourceCodeLine = 789;
                                                            Trace( "sCustomValue:  {0}\r\n", SVALUE ) ; 
                                                            __context__.SourceCodeLine = 790;
                                                            break ; 
                                                            } 
                                                        
                                                        break;
                                                        } 
                                                        
                                                    
                                                    __context__.SourceCodeLine = 793;
                                                    Trace( "Custom Count: {0:d}\r\n", (short)COUNT) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 796;
                                                switch ((int)ICUSTOMID)
                                                
                                                    { 
                                                    case 1 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 800;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGINFO = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 802;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 2 ;
                                                    case 2 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 806;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWDAYVIEW = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 807;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 3 ;
                                                    case 3 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 811;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLEROOMS = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 813;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 4 ;
                                                    case 4 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 817;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWRESERVENOW = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 819;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 5 ;
                                                    case 5 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 823;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWSEARCHWIZARD = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 825;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 6 ;
                                                    case 6 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 829;
                                                        _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENINFO = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 831;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 7 ;
                                                    case 7 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 835;
                                                        _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENRESERVE = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 837;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 8 ;
                                                    case 8 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 841;
                                                        _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENRESERVE = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 843;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 20 ;
                                                    case 20 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 847;
                                                        _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 849;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 21 ;
                                                    case 21 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 853;
                                                        _SplusNVRAM.CONFIGDATA . DEFAULTORGANIZER  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 855;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 22 ;
                                                    case 22 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 859;
                                                        _SplusNVRAM.CONFIGDATA . ROOMPRIVACYLEVEL = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 861;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 23 ;
                                                    case 23 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 865;
                                                        _SplusNVRAM.CONFIGDATA . ENDECLINEFORNOSHOW = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 867;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 24 ;
                                                    case 24 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 871;
                                                        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWAPPLIESDUR = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 873;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 25 ;
                                                    case 25 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 877;
                                                        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWMIN = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 879;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 26 ;
                                                    case 26 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 883;
                                                        _SplusNVRAM.CONFIGDATA . RESERVENOWMAXDUR = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 885;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 27 ;
                                                    case 27 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 889;
                                                        _SplusNVRAM.CONFIGDATA . ROOMFRIENDLYNAME  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 891;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 9 ;
                                                    case 9 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 895;
                                                        _SplusNVRAM.CONFIGDATA . MENUENTOOLSPAGE = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 897;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 28 ;
                                                    case 28 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 901;
                                                        _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTSUBJECT  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 903;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 29 ;
                                                    case 29 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 907;
                                                        _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTORGANIZER  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 909;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 30 ;
                                                    case 30 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 913;
                                                        _SplusNVRAM.CONFIGDATA . DATEFORMAT = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 915;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 31 ;
                                                    case 31 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 919;
                                                        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWAPPLIESDUR = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 921;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 32 ;
                                                    case 32 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 925;
                                                        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWENCHECKATEXACTMIN = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 927;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 33 ;
                                                    case 33 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 931;
                                                        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWMIN = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 933;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 34 ;
                                                    case 34 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 937;
                                                        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWPER = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 939;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 35 ;
                                                    case 35 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 943;
                                                        _SplusNVRAM.CONFIGDATA . ENBROADCASTMESSAGE = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 945;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 36 ;
                                                    case 36 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 949;
                                                        _SplusNVRAM.CONFIGDATA . ENDECLINEFORNOSHOW = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 951;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 37 ;
                                                    case 37 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 955;
                                                        _SplusNVRAM.CONFIGDATA . ENFREEUPROOM = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 957;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 38 ;
                                                    case 38 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 961;
                                                        _SplusNVRAM.CONFIGDATA . ENSTARTMEETING = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 962;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 39 ;
                                                    case 39 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 966;
                                                        _SplusNVRAM.CONFIGDATA . ENTOOLSMENU = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 968;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 40 ;
                                                    case 40 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 972;
                                                        _SplusNVRAM.CONFIGDATA . MENUENWAKEUPTOMEETING = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 974;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 41 ;
                                                    case 41 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 978;
                                                        _SplusNVRAM.CONFIGDATA . FREEUPROOMENMIN = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 980;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 42 ;
                                                    case 42 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 984;
                                                        _SplusNVRAM.CONFIGDATA . FREEUPROOMENPER = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 986;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 43 ;
                                                    case 43 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 990;
                                                        _SplusNVRAM.CONFIGDATA . FREEUPROOMENUSEMIN = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 992;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 44 ;
                                                    case 44 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 996;
                                                        _SplusNVRAM.CONFIGDATA . FREEUPROOMENUSEPER = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 998;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 45 ;
                                                    case 45 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1002;
                                                        _SplusNVRAM.CONFIGDATA . MOTIONSENSORLEDSTRACK = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1004;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 46 ;
                                                    case 46 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1008;
                                                        _SplusNVRAM.CONFIGDATA . MOTIONSENSOROUTPUT = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 1010;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 47 ;
                                                    case 47 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1014;
                                                        _SplusNVRAM.CONFIGDATA . MOTIONSENSORTIMEOUT = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 1016;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 48 ;
                                                    case 48 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1020;
                                                        _SplusNVRAM.CONFIGDATA . MOTIONSENSORTYPE = (ushort) ( IVALUE ) ; 
                                                        __context__.SourceCodeLine = 1022;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 49 ;
                                                    case 49 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1026;
                                                        _SplusNVRAM.CONFIGDATA . RESERVENOWEVENENDTIME = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1028;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 50 ;
                                                    case 50 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1032;
                                                        _SplusNVRAM.CONFIGDATA . RESERVENOWTIMESELECTION = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1034;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 51 ;
                                                    case 51 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1038;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLETIME = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1040;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 52 ;
                                                    case 52 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1044;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGORGANIZER = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1046;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 53 ;
                                                    case 53 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1050;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGSUBJECT = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1052;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 54 ;
                                                    case 54 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1056;
                                                        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGTIMES = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1058;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 55 ;
                                                    case 55 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1062;
                                                        _SplusNVRAM.CONFIGDATA . MENUBKGDIMAGEURL  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 1064;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 56 ;
                                                    case 56 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1068;
                                                        _SplusNVRAM.CONFIGDATA . MENULOGOIMAGEURL  .UpdateValue ( SVALUE  ) ; 
                                                        __context__.SourceCodeLine = 1070;
                                                        break ; 
                                                        } 
                                                    
                                                    goto case 57 ;
                                                    case 57 : 
                                                    
                                                        { 
                                                        __context__.SourceCodeLine = 1074;
                                                        _SplusNVRAM.CONFIGDATA . TIMEFORMAT = (ushort) ( BVALUE ) ; 
                                                        __context__.SourceCodeLine = 1076;
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
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1084;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INODE == 3))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1086;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Capabilities>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1088;
                                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 1089;
                                    Trace( "End Capabilities\r\n") ; 
                                    }
                                
                                __context__.SourceCodeLine = 1091;
                                INODE = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1095;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<PushModel Enabled" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1097;
                                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                        {
                                        __context__.SourceCodeLine = 1098;
                                        Trace( "Found PushModel\r\n") ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 1100;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1102;
                                        CONFIG_EN_PUSHMODEL  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 1103;
                                        _SplusNVRAM.CONFIGDATA . ENPUSHMODEL = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 1107;
                                        CONFIG_EN_PUSHMODEL  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 1108;
                                        _SplusNVRAM.CONFIGDATA . ENPUSHMODEL = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            } 
                        
                        }
                    
                    }
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 1116;
            MODULE_STATUS  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1118;
            _SplusNVRAM.G_SHAVESTOREDCONFIGDATA  .UpdateValue ( "YES1234"  ) ; 
            
            }
            
        private void OUTPUTCUSTOMCONFIGURATIONS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1123;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SHAVESTOREDCONFIGDATA != "YES1234"))  ) ) 
                {
                __context__.SourceCodeLine = 1124;
                return ; 
                }
            
            __context__.SourceCodeLine = 1126;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1127;
                Trace( "\r\n** OutputCustomConfigurations **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1130;
            MENU_EN_TOOLS_PAGE  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENTOOLSMENU ) ; 
            __context__.SourceCodeLine = 1131;
            MENU_SHOW_MEETING_INFO  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGINFO ) ; 
            __context__.SourceCodeLine = 1132;
            MENU_SHOW_DAY_VIEW  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWDAYVIEW ) ; 
            __context__.SourceCodeLine = 1133;
            MENU_SHOW_AVAILABLE_ROOMS  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWAVAILABLEROOMS ) ; 
            __context__.SourceCodeLine = 1134;
            MENU_SHOW_RESERVE_NOW  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWRESERVENOW ) ; 
            __context__.SourceCodeLine = 1135;
            MENU_SHOW_SEARCH_WIZARD  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWSEARCHWIZARD ) ; 
            __context__.SourceCodeLine = 1136;
            MENU_DAYVIEW_EN_INFO  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENINFO ) ; 
            __context__.SourceCodeLine = 1137;
            MENU_DAYVIEW_EN_ADD_APPT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENRESERVE ) ; 
            __context__.SourceCodeLine = 1138;
            MENU_DAYVIEW_EN_PREVIOUS_DAY  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENPREVDAY ) ; 
            __context__.SourceCodeLine = 1139;
            CONFIG_EN_DECLINEFORNOSHOW  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENDECLINEFORNOSHOW ) ; 
            __context__.SourceCodeLine = 1140;
            CONFIG_EN_PUSHMODEL  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENPUSHMODEL ) ; 
            __context__.SourceCodeLine = 1141;
            DECLINEFORNOSHOW_CHECKATEXACTMIN  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWENCHECKATEXACTMIN ) ; 
            __context__.SourceCodeLine = 1142;
            CONFIG_EN_BROADCASTMESSAGE  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENBROADCASTMESSAGE ) ; 
            __context__.SourceCodeLine = 1143;
            CONFIG_EN_FREEUPROOM  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENFREEUPROOM ) ; 
            __context__.SourceCodeLine = 1144;
            CONFIG_EN_STARTMEETING  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENSTARTMEETING ) ; 
            __context__.SourceCodeLine = 1145;
            CONFIG_EN_PANELWAKEUP  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUENWAKEUPTOMEETING ) ; 
            __context__.SourceCodeLine = 1146;
            CONFIG_FREEUPROOM_EN_MIN  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.FREEUPROOMENUSEMIN ) ; 
            __context__.SourceCodeLine = 1147;
            CONFIG_FREEUPROOM_EN_PER  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.FREEUPROOMENUSEPER ) ; 
            __context__.SourceCodeLine = 1148;
            CONFIG_MOTIONSENSOR_LED_TRACK  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MOTIONSENSORLEDSTRACK ) ; 
            __context__.SourceCodeLine = 1149;
            CONFIG_RESERVENOW_EVEN_END_TIME  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.RESERVENOWEVENENDTIME ) ; 
            __context__.SourceCodeLine = 1150;
            CONFIG_RESERVENOW_TIME_SELECT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.RESERVENOWTIMESELECTION ) ; 
            __context__.SourceCodeLine = 1151;
            CONFIG_EN_AVAILABLETIMES  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWAVAILABLETIME ) ; 
            __context__.SourceCodeLine = 1152;
            MENU_SHOW_SUBJECT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGSUBJECT ) ; 
            __context__.SourceCodeLine = 1153;
            MENU_SHOW_ORGANIZER  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGORGANIZER ) ; 
            __context__.SourceCodeLine = 1154;
            MENU_SHOW_TIMES  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGTIMES ) ; 
            __context__.SourceCodeLine = 1155;
            CONFIG_TIME_FORMAT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.TIMEFORMAT ) ; 
            __context__.SourceCodeLine = 1157;
            CONFIG_DECLINEFORNOSHOWAPPLIESDUR  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWAPPLIESDUR ) ; 
            __context__.SourceCodeLine = 1158;
            CONFIG_DECLINEFORNOSHOWMIN  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWMIN ) ; 
            __context__.SourceCodeLine = 1159;
            CONFIG_RESERVENOWMAXDUR  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.RESERVENOWMAXDUR ) ; 
            __context__.SourceCodeLine = 1160;
            CONFIG_ROOMPRIVACYLEVEL  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ROOMPRIVACYLEVEL ) ; 
            __context__.SourceCodeLine = 1161;
            CONFIG_DATE_FORMAT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DATEFORMAT ) ; 
            __context__.SourceCodeLine = 1162;
            CONFIG_DECLINEFORNOSHOWPER  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWPER ) ; 
            __context__.SourceCodeLine = 1163;
            CONFIG_FREEUPROOM_ENUSEMIN  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.FREEUPROOMENMIN ) ; 
            __context__.SourceCodeLine = 1164;
            CONFIG_FREEUPROOM_ENUSEPER  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.FREEUPROOMENPER ) ; 
            __context__.SourceCodeLine = 1165;
            CONFIG_MOTIONSENSOR_TYPE  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MOTIONSENSORTYPE ) ; 
            __context__.SourceCodeLine = 1166;
            CONFIG_MOTIONSENSOR_OUTPUT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MOTIONSENSOROUTPUT ) ; 
            __context__.SourceCodeLine = 1167;
            CONFIG_MOTIONSENSOR_TIMEOUT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MOTIONSENSORTIMEOUT ) ; 
            __context__.SourceCodeLine = 1169;
            CONFIG_DEFAULTSUBJECT__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  ) ; 
            __context__.SourceCodeLine = 1170;
            CONFIG_DEFAULTORGANIZER__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . DEFAULTORGANIZER  ) ; 
            __context__.SourceCodeLine = 1171;
            CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  ) ; 
            __context__.SourceCodeLine = 1172;
            CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . DEFAULTORGANIZER  ) ; 
            __context__.SourceCodeLine = 1173;
            CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . MENUBKGDIMAGEURL  ) ; 
            __context__.SourceCodeLine = 1174;
            CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . MENULOGOIMAGEURL  ) ; 
            
            }
            
        private void OUTPUTGENERALROOMCONFIG (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1179;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SHAVESTOREDCONFIGDATA != "YES1234"))  ) ) 
                {
                __context__.SourceCodeLine = 1180;
                return ; 
                }
            
            __context__.SourceCodeLine = 1182;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1183;
                Trace( "\r\n** Output General Room Config **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1185;
            CONFIG_ROOMID__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMID  ) ; 
            __context__.SourceCodeLine = 1186;
            CONFIG_ROOMNAME__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMNAME  ) ; 
            __context__.SourceCodeLine = 1187;
            CONFIG_ROOMDESCRIPTION__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMDESCRIPTION  ) ; 
            __context__.SourceCodeLine = 1188;
            CONFIG_ROOMLOCATION__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMLOCATION  ) ; 
            __context__.SourceCodeLine = 1189;
            CONFIG_ROOMTIMEZONE__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMTIMEZONE  ) ; 
            
            }
            
        private void PROCESSFROMRVROOMCONFIGRESPONSE__DOLLAR__ (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1194;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1196;
                Trace( "\r\n** ProcessFromRVRoomConfigResponse$ **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1199;
            if ( Functions.TestForTrue  ( ( Functions.Find( G_SREQUESTID , G_SRXDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1201;
                MODULE_STATUS  .Value = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 1203;
                PROCESSCONFIGDATA (  __context__ , G_SRXDATA) ; 
                __context__.SourceCodeLine = 1204;
                OUTPUTGENERALROOMCONFIG (  __context__  ) ; 
                __context__.SourceCodeLine = 1205;
                OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1207;
                if ( Functions.TestForTrue  ( ( Functions.Find( "RVSERoomConfigUpdate" , G_SRXDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1209;
                    MODULE_STATUS  .Value = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 1211;
                    PROCESSCONFIGDATA (  __context__ , G_SRXDATA) ; 
                    __context__.SourceCodeLine = 1212;
                    OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
                    } 
                
                }
            
            
            }
            
        private void CLEARCONFIGDATA (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1219;
            _SplusNVRAM.CONFIGDATA . MENUENTOOLSPAGE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1221;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGINFO = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1222;
            _SplusNVRAM.CONFIGDATA . MENUSHOWDAYVIEW = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1223;
            _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLEROOMS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1224;
            _SplusNVRAM.CONFIGDATA . MENUSHOWRESERVENOW = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1225;
            _SplusNVRAM.CONFIGDATA . MENUSHOWSEARCHWIZARD = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1227;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGSUBJECT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1228;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGORGANIZER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1229;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGTIMES = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1230;
            _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLETIME = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1231;
            _SplusNVRAM.CONFIGDATA . MENUENWAKEUPTOMEETING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1233;
            _SplusNVRAM.CONFIGDATA . MENUBKGDIMAGEURL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1234;
            _SplusNVRAM.CONFIGDATA . MENULOGOIMAGEURL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1236;
            _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENINFO = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1237;
            _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENRESERVE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1238;
            _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENPREVDAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1240;
            _SplusNVRAM.CONFIGDATA . ROOMID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1241;
            _SplusNVRAM.CONFIGDATA . ROOMNAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1242;
            _SplusNVRAM.CONFIGDATA . ROOMFRIENDLYNAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1243;
            _SplusNVRAM.CONFIGDATA . ROOMLOCATION  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1244;
            _SplusNVRAM.CONFIGDATA . ROOMTIMEZONE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1245;
            _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1246;
            _SplusNVRAM.CONFIGDATA . DEFAULTORGANIZER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1247;
            _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTSUBJECT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1248;
            _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTORGANIZER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1250;
            _SplusNVRAM.CONFIGDATA . ENDECLINEFORNOSHOW = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1251;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWAPPLIESDUR = (ushort) ( 120 ) ; 
            __context__.SourceCodeLine = 1252;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWMIN = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 1253;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWPER = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 1254;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWENCHECKATEXACTMIN = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1256;
            _SplusNVRAM.CONFIGDATA . RESERVENOWMAXDUR = (ushort) ( 60 ) ; 
            __context__.SourceCodeLine = 1257;
            _SplusNVRAM.CONFIGDATA . RESERVENOWEVENENDTIME = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1258;
            _SplusNVRAM.CONFIGDATA . RESERVENOWTIMESELECTION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1260;
            _SplusNVRAM.CONFIGDATA . ROOMPRIVACYLEVEL = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1262;
            _SplusNVRAM.CONFIGDATA . ENFREEUPROOM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1263;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENUSEMIN = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1264;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENUSEPER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1265;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENMIN = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1266;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENPER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1268;
            _SplusNVRAM.CONFIGDATA . ENSTARTMEETING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1270;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTYPE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1271;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSOROUTPUT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1272;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTIMEOUT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1273;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORLEDSTRACK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1275;
            _SplusNVRAM.CONFIGDATA . DATEFORMAT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1276;
            _SplusNVRAM.CONFIGDATA . TIMEFORMAT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1278;
            _SplusNVRAM.CONFIGDATA . ENBROADCASTMESSAGE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1280;
            _SplusNVRAM.CONFIGDATA . ENTOOLSMENU = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1282;
            _SplusNVRAM.CONFIGDATA . ENPUSHMODEL = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1284;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1285;
                Trace( "Cleared all stored data\r\n") ; 
                }
            
            
            }
            
        private void INITCONFIGDATA (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1290;
            _SplusNVRAM.CONFIGDATA . MENUENTOOLSPAGE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1292;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGINFO = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1293;
            _SplusNVRAM.CONFIGDATA . MENUSHOWDAYVIEW = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1294;
            _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLEROOMS = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1295;
            _SplusNVRAM.CONFIGDATA . MENUSHOWRESERVENOW = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1296;
            _SplusNVRAM.CONFIGDATA . MENUSHOWSEARCHWIZARD = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1298;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGSUBJECT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1299;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGORGANIZER = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1300;
            _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGTIMES = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1301;
            _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLETIME = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1302;
            _SplusNVRAM.CONFIGDATA . MENUENWAKEUPTOMEETING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1304;
            _SplusNVRAM.CONFIGDATA . MENUBKGDIMAGEURL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1305;
            _SplusNVRAM.CONFIGDATA . MENULOGOIMAGEURL  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1307;
            _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENINFO = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1308;
            _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENRESERVE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1309;
            _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENPREVDAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1311;
            _SplusNVRAM.CONFIGDATA . ROOMID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1312;
            _SplusNVRAM.CONFIGDATA . ROOMNAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1313;
            _SplusNVRAM.CONFIGDATA . ROOMFRIENDLYNAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1314;
            _SplusNVRAM.CONFIGDATA . ROOMLOCATION  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1315;
            _SplusNVRAM.CONFIGDATA . ROOMTIMEZONE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1316;
            _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  .UpdateValue ( "Default Subject"  ) ; 
            __context__.SourceCodeLine = 1317;
            _SplusNVRAM.CONFIGDATA . DEFAULTORGANIZER  .UpdateValue ( "Default Organizer"  ) ; 
            __context__.SourceCodeLine = 1318;
            _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTSUBJECT  .UpdateValue ( "Ad-Hoc Meeting"  ) ; 
            __context__.SourceCodeLine = 1319;
            _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTORGANIZER  .UpdateValue ( "Ad-Hoc Organizer"  ) ; 
            __context__.SourceCodeLine = 1321;
            _SplusNVRAM.CONFIGDATA . ENDECLINEFORNOSHOW = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1322;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWAPPLIESDUR = (ushort) ( 120 ) ; 
            __context__.SourceCodeLine = 1323;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWMIN = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 1324;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWPER = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 1325;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWENCHECKATEXACTMIN = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1327;
            _SplusNVRAM.CONFIGDATA . RESERVENOWMAXDUR = (ushort) ( 60 ) ; 
            __context__.SourceCodeLine = 1328;
            _SplusNVRAM.CONFIGDATA . RESERVENOWEVENENDTIME = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1329;
            _SplusNVRAM.CONFIGDATA . RESERVENOWTIMESELECTION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1331;
            _SplusNVRAM.CONFIGDATA . ROOMPRIVACYLEVEL = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1333;
            _SplusNVRAM.CONFIGDATA . ENFREEUPROOM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1334;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENUSEMIN = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1335;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENUSEPER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1336;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENMIN = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 1337;
            _SplusNVRAM.CONFIGDATA . FREEUPROOMENPER = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 1339;
            _SplusNVRAM.CONFIGDATA . ENSTARTMEETING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1341;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTYPE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1342;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSOROUTPUT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1343;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTIMEOUT = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 1344;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORLEDSTRACK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1346;
            _SplusNVRAM.CONFIGDATA . DATEFORMAT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1347;
            _SplusNVRAM.CONFIGDATA . TIMEFORMAT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1349;
            _SplusNVRAM.CONFIGDATA . ENBROADCASTMESSAGE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1351;
            _SplusNVRAM.CONFIGDATA . ENTOOLSMENU = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1353;
            _SplusNVRAM.CONFIGDATA . ENPUSHMODEL = (ushort) ( 0 ) ; 
            
            }
            
        object INITIALIZE_MODULE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1363;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1365;
                    Trace( "\r\n** Initialize Module **\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 1368;
                INITIALIZE_MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1370;
                G_BRXOK = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1372;
                MODULE_STATUS  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1374;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SNVDATACLEARED != "YES1234"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1376;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 1378;
                        Trace( "Clearing Config Data\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 1380;
                    CLEARCONFIGDATA (  __context__  ) ; 
                    __context__.SourceCodeLine = 1381;
                    _SplusNVRAM.G_SNVDATACLEARED  .UpdateValue ( "YES1234"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 1384;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SHAVESTOREDCONFIGDATA != "YES1234"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1386;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 1388;
                        Trace( "Initializing Default Configurations\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 1391;
                    INITCONFIGDATA (  __context__  ) ; 
                    __context__.SourceCodeLine = 1392;
                    _SplusNVRAM.G_SHAVESTOREDCONFIGDATA  .UpdateValue ( "YES1234"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 1395;
                OUTPUTGENERALROOMCONFIG (  __context__  ) ; 
                __context__.SourceCodeLine = 1396;
                OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
                __context__.SourceCodeLine = 1398;
                INITIALIZE_MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CLEAR_ALL_STORED_DATA_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1403;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 1405;
                Trace( "\r\n** Clear All Stored Data **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1407;
            CLEARCONFIGDATA (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DATA_TIMEOUT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1412;
        MODULE_STATUS  .Value = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 1413;
        MODULE_STATUS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1415;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SHAVESTOREDCONFIGDATA == "YES1234"))  ) ) 
            { 
            __context__.SourceCodeLine = 1417;
            OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOAD_STORED_VALUES_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1424;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SHAVESTOREDCONFIGDATA == "YES1234"))  ) ) 
            { 
            __context__.SourceCodeLine = 1426;
            MENU_EN_TOOLS_PAGE  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUENTOOLSPAGE ) ; 
            __context__.SourceCodeLine = 1428;
            MENU_SHOW_MEETING_INFO  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGINFO ) ; 
            __context__.SourceCodeLine = 1429;
            MENU_SHOW_DAY_VIEW  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWDAYVIEW ) ; 
            __context__.SourceCodeLine = 1430;
            MENU_SHOW_AVAILABLE_ROOMS  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWAVAILABLEROOMS ) ; 
            __context__.SourceCodeLine = 1431;
            MENU_SHOW_RESERVE_NOW  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWRESERVENOW ) ; 
            __context__.SourceCodeLine = 1432;
            MENU_SHOW_SEARCH_WIZARD  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUSHOWSEARCHWIZARD ) ; 
            __context__.SourceCodeLine = 1434;
            MENU_DAYVIEW_EN_INFO  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENINFO ) ; 
            __context__.SourceCodeLine = 1435;
            MENU_DAYVIEW_EN_ADD_APPT  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENRESERVE ) ; 
            __context__.SourceCodeLine = 1436;
            MENU_DAYVIEW_EN_PREVIOUS_DAY  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENPREVDAY ) ; 
            __context__.SourceCodeLine = 1438;
            CONFIG_ROOMID__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMID  ) ; 
            __context__.SourceCodeLine = 1439;
            CONFIG_ROOMNAME__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMNAME  ) ; 
            __context__.SourceCodeLine = 1440;
            CONFIG_ROOMFRIENDLYNAME__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMFRIENDLYNAME  ) ; 
            __context__.SourceCodeLine = 1441;
            CONFIG_ROOMLOCATION__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMLOCATION  ) ; 
            __context__.SourceCodeLine = 1442;
            CONFIG_ROOMTIMEZONE__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . ROOMTIMEZONE  ) ; 
            __context__.SourceCodeLine = 1443;
            CONFIG_DEFAULTSUBJECT__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  ) ; 
            __context__.SourceCodeLine = 1444;
            CONFIG_DEFAULTORGANIZER__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . DEFAULTORGANIZER  ) ; 
            __context__.SourceCodeLine = 1445;
            CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTSUBJECT  ) ; 
            __context__.SourceCodeLine = 1446;
            CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR__  .UpdateValue ( _SplusNVRAM.CONFIGDATA . RESERVENOWDEFAULTORGANIZER  ) ; 
            __context__.SourceCodeLine = 1448;
            CONFIG_EN_DECLINEFORNOSHOW  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENDECLINEFORNOSHOW ) ; 
            __context__.SourceCodeLine = 1449;
            CONFIG_DECLINEFORNOSHOWAPPLIESDUR  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWAPPLIESDUR ) ; 
            __context__.SourceCodeLine = 1450;
            CONFIG_DECLINEFORNOSHOWMIN  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWMIN ) ; 
            __context__.SourceCodeLine = 1451;
            CONFIG_RESERVENOWMAXDUR  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.RESERVENOWMAXDUR ) ; 
            __context__.SourceCodeLine = 1452;
            CONFIG_ROOMPRIVACYLEVEL  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ROOMPRIVACYLEVEL ) ; 
            __context__.SourceCodeLine = 1453;
            CONFIG_EN_PUSHMODEL  .Value = (ushort) ( _SplusNVRAM.CONFIGDATA.ENPUSHMODEL ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_CONFIGURATION_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1459;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODULE_STATUS  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1461;
            MODULE_STATUS  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1463;
            G_SREQUESTID  .UpdateValue ( "ConfigRequest" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 1464;
            TO_RV_ROOMCONFIGQUERY__DOLLAR__  .UpdateValue ( "<RequestRoomConfiguration>" + "<RequestID>" + G_SREQUESTID + "</RequestID>" + "</RequestRoomConfiguration>"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_RV_ROOMCONFIGREPONSE__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1474;
        if ( Functions.TestForTrue  ( ( G_BRXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 1476;
            G_BRXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1478;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 1480;
                G_SRXDATA  .UpdateValue ( Functions.Gather ( "</RoomConfigurationResponse>" , FROM_RV_ROOMCONFIGREPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 1482;
                PROCESSFROMRVROOMCONFIGRESPONSE__DOLLAR__ (  __context__  ) ; 
                __context__.SourceCodeLine = 1478;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_MEETING_INFO_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1489;
        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGINFO = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGINFO ) ) ; 
        __context__.SourceCodeLine = 1490;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_MEETING_SUBJECT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1495;
        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGSUBJECT = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGSUBJECT ) ) ; 
        __context__.SourceCodeLine = 1496;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1502;
        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGORGANIZER = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGORGANIZER ) ) ; 
        __context__.SourceCodeLine = 1503;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_MEETING_TIMES_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1509;
        _SplusNVRAM.CONFIGDATA . MENUSHOWMEETINGTIMES = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWMEETINGTIMES ) ) ; 
        __context__.SourceCodeLine = 1510;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_DAY_VIEW_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1516;
        _SplusNVRAM.CONFIGDATA . MENUSHOWDAYVIEW = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWDAYVIEW ) ) ; 
        __context__.SourceCodeLine = 1517;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_DAY_VIEW_GET_INFO_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1522;
        _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENINFO = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENINFO ) ) ; 
        __context__.SourceCodeLine = 1523;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_DAY_VIEW_ADD_APPT_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1529;
        _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENRESERVE = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENRESERVE ) ) ; 
        __context__.SourceCodeLine = 1530;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_DAY_VIEW_EN_PREV_DAY_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1536;
        _SplusNVRAM.CONFIGDATA . MENUDAYVIEWENPREVDAY = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUDAYVIEWENPREVDAY ) ) ; 
        __context__.SourceCodeLine = 1537;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1543;
        _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLEROOMS = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWAVAILABLEROOMS ) ) ; 
        __context__.SourceCodeLine = 1544;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_MENU_SHOW_RESERVE_NOW_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1550;
        _SplusNVRAM.CONFIGDATA . MENUSHOWRESERVENOW = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWRESERVENOW ) ) ; 
        __context__.SourceCodeLine = 1551;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1558;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.RESERVENOWMAXDUR > 30 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1560;
            _SplusNVRAM.CONFIGDATA . RESERVENOWMAXDUR = (ushort) ( (_SplusNVRAM.CONFIGDATA.RESERVENOWMAXDUR - 30) ) ; 
            } 
        
        __context__.SourceCodeLine = 1563;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1570;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.RESERVENOWMAXDUR < 120 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1572;
            _SplusNVRAM.CONFIGDATA . RESERVENOWMAXDUR = (ushort) ( (_SplusNVRAM.CONFIGDATA.RESERVENOWMAXDUR + 30) ) ; 
            } 
        
        __context__.SourceCodeLine = 1574;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_RESERVE_NOW_EVEN_END_TIME_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1580;
        _SplusNVRAM.CONFIGDATA . RESERVENOWEVENENDTIME = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.RESERVENOWEVENENDTIME ) ) ; 
        __context__.SourceCodeLine = 1581;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_RESERVE_NOW_TIME_SELECT_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1587;
        _SplusNVRAM.CONFIGDATA . RESERVENOWTIMESELECTION = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.RESERVENOWTIMESELECTION ) ) ; 
        __context__.SourceCodeLine = 1588;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_NEXT_RESERVE_SHOW_INFO_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1594;
        _SplusNVRAM.CONFIGDATA . MENUSHOWAVAILABLETIME = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUSHOWAVAILABLETIME ) ) ; 
        __context__.SourceCodeLine = 1595;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_CONFIG_PANEL_WAKE_UP_TO_MEETING_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1601;
        _SplusNVRAM.CONFIGDATA . MENUENWAKEUPTOMEETING = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.MENUENWAKEUPTOMEETING ) ) ; 
        __context__.SourceCodeLine = 1602;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1609;
        _SplusNVRAM.CONFIGDATA . ENDECLINEFORNOSHOW = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.ENDECLINEFORNOSHOW ) ) ; 
        __context__.SourceCodeLine = 1610;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1617;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWAPPLIESDUR > 30 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1619;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWAPPLIESDUR = (ushort) ( (_SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWAPPLIESDUR - 5) ) ; 
            } 
        
        __context__.SourceCodeLine = 1621;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1628;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWAPPLIESDUR < 480 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1630;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWAPPLIESDUR = (ushort) ( (_SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWAPPLIESDUR + 5) ) ; 
            } 
        
        __context__.SourceCodeLine = 1632;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1639;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWMIN > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1641;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWMIN = (ushort) ( (_SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWMIN - 1) ) ; 
            } 
        
        __context__.SourceCodeLine = 1643;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1650;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWMIN < 120 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1652;
            _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWMIN = (ushort) ( (_SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWMIN + 1) ) ; 
            } 
        
        __context__.SourceCodeLine = 1654;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1660;
        _SplusNVRAM.CONFIGDATA . DECLINEFORNOSHOWENCHECKATEXACTMIN = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.DECLINEFORNOSHOWENCHECKATEXACTMIN ) ) ; 
        __context__.SourceCodeLine = 1661;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1667;
        _SplusNVRAM.CONFIGDATA . ROOMPRIVACYLEVEL = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1668;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_PRIVACY_LEVEL_SEMI_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1674;
        _SplusNVRAM.CONFIGDATA . ROOMPRIVACYLEVEL = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1675;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1681;
        _SplusNVRAM.CONFIGDATA . ROOMPRIVACYLEVEL = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 1682;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_MOTION_SENSOR_TYPE_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1690;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONFIGDATA.MOTIONSENSORTYPE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1692;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTYPE = (ushort) ( 1 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1694;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONFIGDATA.MOTIONSENSORTYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1696;
                _SplusNVRAM.CONFIGDATA . MOTIONSENSORTYPE = (ushort) ( 0 ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 1698;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_MOTION_SENSOR_OUTPUT_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1705;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONFIGDATA.MOTIONSENSOROUTPUT == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1707;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSOROUTPUT = (ushort) ( 1 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1709;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONFIGDATA.MOTIONSENSOROUTPUT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1711;
                _SplusNVRAM.CONFIGDATA . MOTIONSENSOROUTPUT = (ushort) ( 0 ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 1713;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1720;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.MOTIONSENSORTIMEOUT > 2 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1722;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTIMEOUT = (ushort) ( (_SplusNVRAM.CONFIGDATA.MOTIONSENSORTIMEOUT - 1) ) ; 
            } 
        
        __context__.SourceCodeLine = 1724;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1731;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CONFIGDATA.MOTIONSENSORTIMEOUT < 60 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1733;
            _SplusNVRAM.CONFIGDATA . MOTIONSENSORTIMEOUT = (ushort) ( (_SplusNVRAM.CONFIGDATA.MOTIONSENSORTIMEOUT + 1) ) ; 
            } 
        
        __context__.SourceCodeLine = 1735;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_EN_END_MEETING_BTN_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1741;
        _SplusNVRAM.CONFIGDATA . ENFREEUPROOM = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.ENFREEUPROOM ) ) ; 
        __context__.SourceCodeLine = 1742;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_EN_START_MEETING_BTN_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1748;
        _SplusNVRAM.CONFIGDATA . ENSTARTMEETING = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.ENSTARTMEETING ) ) ; 
        __context__.SourceCodeLine = 1749;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_CONFIG_EN_BROADCAST_MESSAGE_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1755;
        _SplusNVRAM.CONFIGDATA . ENBROADCASTMESSAGE = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.ENBROADCASTMESSAGE ) ) ; 
        __context__.SourceCodeLine = 1756;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DATE_FORMAT_US_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1763;
        _SplusNVRAM.CONFIGDATA . DATEFORMAT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1764;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DATE_FORMAT_EURO_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1770;
        _SplusNVRAM.CONFIGDATA . DATEFORMAT = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1771;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DATE_FORMAT_INT_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1777;
        _SplusNVRAM.CONFIGDATA . DATEFORMAT = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 1778;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_FORMAT_OnPush_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1785;
        _SplusNVRAM.CONFIGDATA . TIMEFORMAT = (ushort) ( Functions.Not( _SplusNVRAM.CONFIGDATA.TIMEFORMAT ) ) ; 
        __context__.SourceCodeLine = 1786;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULTSUBJECT__DOLLAR___OnChange_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1791;
        _SplusNVRAM.CONFIGDATA . DEFAULTSUBJECT  .UpdateValue ( DEFAULTSUBJECT__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 1793;
        OUTPUTCUSTOMCONFIGURATIONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.G_SNVDATACLEARED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _SplusNVRAM.G_SHAVESTOREDCONFIGDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    G_SRXDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65000, this );
    G_SREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, this );
    _SplusNVRAM.CONFIGDATA  = new ROOMDATASTRUCT( this, false );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    INITIALIZE_MODULE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE_MODULE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE_MODULE__DigitalInput__, INITIALIZE_MODULE );
    
    CLEAR_ALL_STORED_DATA = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_ALL_STORED_DATA__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_ALL_STORED_DATA__DigitalInput__, CLEAR_ALL_STORED_DATA );
    
    GET_CONFIGURATION = new Crestron.Logos.SplusObjects.DigitalInput( GET_CONFIGURATION__DigitalInput__, this );
    m_DigitalInputList.Add( GET_CONFIGURATION__DigitalInput__, GET_CONFIGURATION );
    
    DATA_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( DATA_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( DATA_TIMEOUT__DigitalInput__, DATA_TIMEOUT );
    
    LOAD_STORED_VALUES = new Crestron.Logos.SplusObjects.DigitalInput( LOAD_STORED_VALUES__DigitalInput__, this );
    m_DigitalInputList.Add( LOAD_STORED_VALUES__DigitalInput__, LOAD_STORED_VALUES );
    
    UI_CONFIG_MENU_SHOW_MEETING_INFO = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_MEETING_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_MEETING_INFO__DigitalInput__, UI_CONFIG_MENU_SHOW_MEETING_INFO );
    
    UI_CONFIG_MENU_SHOW_MEETING_SUBJECT = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_MEETING_SUBJECT__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_MEETING_SUBJECT__DigitalInput__, UI_CONFIG_MENU_SHOW_MEETING_SUBJECT );
    
    UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER__DigitalInput__, UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER );
    
    UI_CONFIG_MENU_SHOW_MEETING_TIMES = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_MEETING_TIMES__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_MEETING_TIMES__DigitalInput__, UI_CONFIG_MENU_SHOW_MEETING_TIMES );
    
    UI_CONFIG_MENU_SHOW_DAY_VIEW = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_DAY_VIEW__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_DAY_VIEW__DigitalInput__, UI_CONFIG_MENU_SHOW_DAY_VIEW );
    
    UI_CONFIG_DAY_VIEW_GET_INFO = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_DAY_VIEW_GET_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_DAY_VIEW_GET_INFO__DigitalInput__, UI_CONFIG_DAY_VIEW_GET_INFO );
    
    UI_CONFIG_DAY_VIEW_ADD_APPT = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_DAY_VIEW_ADD_APPT__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_DAY_VIEW_ADD_APPT__DigitalInput__, UI_CONFIG_DAY_VIEW_ADD_APPT );
    
    UI_CONFIG_DAY_VIEW_EN_PREV_DAY = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_DAY_VIEW_EN_PREV_DAY__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_DAY_VIEW_EN_PREV_DAY__DigitalInput__, UI_CONFIG_DAY_VIEW_EN_PREV_DAY );
    
    UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS__DigitalInput__, UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS );
    
    UI_CONFIG_MENU_SHOW_RESERVE_NOW = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_MENU_SHOW_RESERVE_NOW__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_MENU_SHOW_RESERVE_NOW__DigitalInput__, UI_CONFIG_MENU_SHOW_RESERVE_NOW );
    
    UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS__DigitalInput__, UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS );
    
    UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS__DigitalInput__, UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS );
    
    UI_CONFIG_RESERVE_NOW_EVEN_END_TIME = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_RESERVE_NOW_EVEN_END_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_RESERVE_NOW_EVEN_END_TIME__DigitalInput__, UI_CONFIG_RESERVE_NOW_EVEN_END_TIME );
    
    UI_CONFIG_RESERVE_NOW_TIME_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_RESERVE_NOW_TIME_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_RESERVE_NOW_TIME_SELECT__DigitalInput__, UI_CONFIG_RESERVE_NOW_TIME_SELECT );
    
    UI_CONFIG_NEXT_RESERVE_SHOW_INFO = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_NEXT_RESERVE_SHOW_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_NEXT_RESERVE_SHOW_INFO__DigitalInput__, UI_CONFIG_NEXT_RESERVE_SHOW_INFO );
    
    UI_CONFIG_PANEL_WAKE_UP_TO_MEETING = new Crestron.Logos.SplusObjects.DigitalInput( UI_CONFIG_PANEL_WAKE_UP_TO_MEETING__DigitalInput__, this );
    m_DigitalInputList.Add( UI_CONFIG_PANEL_WAKE_UP_TO_MEETING__DigitalInput__, UI_CONFIG_PANEL_WAKE_UP_TO_MEETING );
    
    ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW__DigitalInput__, ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW );
    
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS__DigitalInput__, ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS );
    
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS__DigitalInput__, ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS );
    
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS__DigitalInput__, ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS );
    
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS__DigitalInput__, ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS );
    
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN__DigitalInput__, ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN );
    
    ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC__DigitalInput__, ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC );
    
    ROOM_CONFIG_PRIVACY_LEVEL_SEMI = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_PRIVACY_LEVEL_SEMI__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_PRIVACY_LEVEL_SEMI__DigitalInput__, ROOM_CONFIG_PRIVACY_LEVEL_SEMI );
    
    ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE__DigitalInput__, ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE );
    
    ROOM_CONFIG_MOTION_SENSOR_TYPE = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_MOTION_SENSOR_TYPE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_MOTION_SENSOR_TYPE__DigitalInput__, ROOM_CONFIG_MOTION_SENSOR_TYPE );
    
    ROOM_CONFIG_MOTION_SENSOR_OUTPUT = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_MOTION_SENSOR_OUTPUT__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_MOTION_SENSOR_OUTPUT__DigitalInput__, ROOM_CONFIG_MOTION_SENSOR_OUTPUT );
    
    ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS__DigitalInput__, ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS );
    
    ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS__DigitalInput__, ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS );
    
    ROOM_CONFIG_EN_END_MEETING_BTN = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_EN_END_MEETING_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_EN_END_MEETING_BTN__DigitalInput__, ROOM_CONFIG_EN_END_MEETING_BTN );
    
    ROOM_CONFIG_EN_START_MEETING_BTN = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_EN_START_MEETING_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_EN_START_MEETING_BTN__DigitalInput__, ROOM_CONFIG_EN_START_MEETING_BTN );
    
    ROOM_CONFIG_EN_BROADCAST_MESSAGE = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_CONFIG_EN_BROADCAST_MESSAGE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_CONFIG_EN_BROADCAST_MESSAGE__DigitalInput__, ROOM_CONFIG_EN_BROADCAST_MESSAGE );
    
    DATE_FORMAT_US = new Crestron.Logos.SplusObjects.DigitalInput( DATE_FORMAT_US__DigitalInput__, this );
    m_DigitalInputList.Add( DATE_FORMAT_US__DigitalInput__, DATE_FORMAT_US );
    
    DATE_FORMAT_EURO = new Crestron.Logos.SplusObjects.DigitalInput( DATE_FORMAT_EURO__DigitalInput__, this );
    m_DigitalInputList.Add( DATE_FORMAT_EURO__DigitalInput__, DATE_FORMAT_EURO );
    
    DATE_FORMAT_INT = new Crestron.Logos.SplusObjects.DigitalInput( DATE_FORMAT_INT__DigitalInput__, this );
    m_DigitalInputList.Add( DATE_FORMAT_INT__DigitalInput__, DATE_FORMAT_INT );
    
    TIME_FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT__DigitalInput__, TIME_FORMAT );
    
    INITIALIZE_MODULE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZE_MODULE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZE_MODULE_BUSY_FB__DigitalOutput__, INITIALIZE_MODULE_BUSY_FB );
    
    MENU_EN_TOOLS_PAGE = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_EN_TOOLS_PAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_EN_TOOLS_PAGE__DigitalOutput__, MENU_EN_TOOLS_PAGE );
    
    MENU_SHOW_MEETING_INFO = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_MEETING_INFO__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_MEETING_INFO__DigitalOutput__, MENU_SHOW_MEETING_INFO );
    
    MENU_SHOW_DAY_VIEW = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_DAY_VIEW__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_DAY_VIEW__DigitalOutput__, MENU_SHOW_DAY_VIEW );
    
    MENU_SHOW_AVAILABLE_ROOMS = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_AVAILABLE_ROOMS__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_AVAILABLE_ROOMS__DigitalOutput__, MENU_SHOW_AVAILABLE_ROOMS );
    
    MENU_SHOW_RESERVE_NOW = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_RESERVE_NOW__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_RESERVE_NOW__DigitalOutput__, MENU_SHOW_RESERVE_NOW );
    
    MENU_SHOW_SEARCH_WIZARD = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_SEARCH_WIZARD__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_SEARCH_WIZARD__DigitalOutput__, MENU_SHOW_SEARCH_WIZARD );
    
    MENU_DAYVIEW_EN_INFO = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_DAYVIEW_EN_INFO__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_DAYVIEW_EN_INFO__DigitalOutput__, MENU_DAYVIEW_EN_INFO );
    
    MENU_DAYVIEW_EN_ADD_APPT = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_DAYVIEW_EN_ADD_APPT__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_DAYVIEW_EN_ADD_APPT__DigitalOutput__, MENU_DAYVIEW_EN_ADD_APPT );
    
    MENU_DAYVIEW_EN_PREVIOUS_DAY = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_DAYVIEW_EN_PREVIOUS_DAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_DAYVIEW_EN_PREVIOUS_DAY__DigitalOutput__, MENU_DAYVIEW_EN_PREVIOUS_DAY );
    
    CONFIG_EN_DECLINEFORNOSHOW = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_DECLINEFORNOSHOW__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_DECLINEFORNOSHOW__DigitalOutput__, CONFIG_EN_DECLINEFORNOSHOW );
    
    CONFIG_EN_PUSHMODEL = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_PUSHMODEL__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_PUSHMODEL__DigitalOutput__, CONFIG_EN_PUSHMODEL );
    
    DECLINEFORNOSHOW_CHECKATEXACTMIN = new Crestron.Logos.SplusObjects.DigitalOutput( DECLINEFORNOSHOW_CHECKATEXACTMIN__DigitalOutput__, this );
    m_DigitalOutputList.Add( DECLINEFORNOSHOW_CHECKATEXACTMIN__DigitalOutput__, DECLINEFORNOSHOW_CHECKATEXACTMIN );
    
    CONFIG_EN_BROADCASTMESSAGE = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_BROADCASTMESSAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_BROADCASTMESSAGE__DigitalOutput__, CONFIG_EN_BROADCASTMESSAGE );
    
    CONFIG_EN_FREEUPROOM = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_FREEUPROOM__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_FREEUPROOM__DigitalOutput__, CONFIG_EN_FREEUPROOM );
    
    CONFIG_EN_STARTMEETING = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_STARTMEETING__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_STARTMEETING__DigitalOutput__, CONFIG_EN_STARTMEETING );
    
    CONFIG_EN_PANELWAKEUP = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_PANELWAKEUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_PANELWAKEUP__DigitalOutput__, CONFIG_EN_PANELWAKEUP );
    
    CONFIG_FREEUPROOM_EN_MIN = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_FREEUPROOM_EN_MIN__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_FREEUPROOM_EN_MIN__DigitalOutput__, CONFIG_FREEUPROOM_EN_MIN );
    
    CONFIG_FREEUPROOM_EN_PER = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_FREEUPROOM_EN_PER__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_FREEUPROOM_EN_PER__DigitalOutput__, CONFIG_FREEUPROOM_EN_PER );
    
    CONFIG_MOTIONSENSOR_TYPE = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_MOTIONSENSOR_TYPE__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_MOTIONSENSOR_TYPE__DigitalOutput__, CONFIG_MOTIONSENSOR_TYPE );
    
    CONFIG_MOTIONSENSOR_OUTPUT = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_MOTIONSENSOR_OUTPUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_MOTIONSENSOR_OUTPUT__DigitalOutput__, CONFIG_MOTIONSENSOR_OUTPUT );
    
    CONFIG_MOTIONSENSOR_LED_TRACK = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_MOTIONSENSOR_LED_TRACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_MOTIONSENSOR_LED_TRACK__DigitalOutput__, CONFIG_MOTIONSENSOR_LED_TRACK );
    
    CONFIG_RESERVENOW_EVEN_END_TIME = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_RESERVENOW_EVEN_END_TIME__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_RESERVENOW_EVEN_END_TIME__DigitalOutput__, CONFIG_RESERVENOW_EVEN_END_TIME );
    
    CONFIG_RESERVENOW_TIME_SELECT = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_RESERVENOW_TIME_SELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_RESERVENOW_TIME_SELECT__DigitalOutput__, CONFIG_RESERVENOW_TIME_SELECT );
    
    CONFIG_EN_AVAILABLETIMES = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_EN_AVAILABLETIMES__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_EN_AVAILABLETIMES__DigitalOutput__, CONFIG_EN_AVAILABLETIMES );
    
    MENU_SHOW_SUBJECT = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_SUBJECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_SUBJECT__DigitalOutput__, MENU_SHOW_SUBJECT );
    
    MENU_SHOW_ORGANIZER = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_ORGANIZER__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_ORGANIZER__DigitalOutput__, MENU_SHOW_ORGANIZER );
    
    MENU_SHOW_TIMES = new Crestron.Logos.SplusObjects.DigitalOutput( MENU_SHOW_TIMES__DigitalOutput__, this );
    m_DigitalOutputList.Add( MENU_SHOW_TIMES__DigitalOutput__, MENU_SHOW_TIMES );
    
    CONFIG_TIME_FORMAT = new Crestron.Logos.SplusObjects.DigitalOutput( CONFIG_TIME_FORMAT__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONFIG_TIME_FORMAT__DigitalOutput__, CONFIG_TIME_FORMAT );
    
    MODULE_STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( MODULE_STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MODULE_STATUS__AnalogSerialOutput__, MODULE_STATUS );
    
    CONFIG_DECLINEFORNOSHOWAPPLIESDUR = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_DECLINEFORNOSHOWAPPLIESDUR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_DECLINEFORNOSHOWAPPLIESDUR__AnalogSerialOutput__, CONFIG_DECLINEFORNOSHOWAPPLIESDUR );
    
    CONFIG_DECLINEFORNOSHOWMIN = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_DECLINEFORNOSHOWMIN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_DECLINEFORNOSHOWMIN__AnalogSerialOutput__, CONFIG_DECLINEFORNOSHOWMIN );
    
    CONFIG_RESERVENOWMAXDUR = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_RESERVENOWMAXDUR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_RESERVENOWMAXDUR__AnalogSerialOutput__, CONFIG_RESERVENOWMAXDUR );
    
    CONFIG_ROOMPRIVACYLEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_ROOMPRIVACYLEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_ROOMPRIVACYLEVEL__AnalogSerialOutput__, CONFIG_ROOMPRIVACYLEVEL );
    
    CONFIG_DATE_FORMAT = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_DATE_FORMAT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_DATE_FORMAT__AnalogSerialOutput__, CONFIG_DATE_FORMAT );
    
    CONFIG_DECLINEFORNOSHOWPER = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_DECLINEFORNOSHOWPER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_DECLINEFORNOSHOWPER__AnalogSerialOutput__, CONFIG_DECLINEFORNOSHOWPER );
    
    CONFIG_FREEUPROOM_ENUSEMIN = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_FREEUPROOM_ENUSEMIN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_FREEUPROOM_ENUSEMIN__AnalogSerialOutput__, CONFIG_FREEUPROOM_ENUSEMIN );
    
    CONFIG_FREEUPROOM_ENUSEPER = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_FREEUPROOM_ENUSEPER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_FREEUPROOM_ENUSEPER__AnalogSerialOutput__, CONFIG_FREEUPROOM_ENUSEPER );
    
    CONFIG_MOTIONSENSOR_TIMEOUT = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIG_MOTIONSENSOR_TIMEOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIG_MOTIONSENSOR_TIMEOUT__AnalogSerialOutput__, CONFIG_MOTIONSENSOR_TIMEOUT );
    
    ROOMID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ROOMID__DOLLAR____AnalogSerialInput__, 75, this );
    m_StringInputList.Add( ROOMID__DOLLAR____AnalogSerialInput__, ROOMID__DOLLAR__ );
    
    DEFAULTSUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULTSUBJECT__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( DEFAULTSUBJECT__DOLLAR____AnalogSerialInput__, DEFAULTSUBJECT__DOLLAR__ );
    
    TO_RV_ROOMCONFIGQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_ROOMCONFIGQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_ROOMCONFIGQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_ROOMCONFIGQUERY__DOLLAR__ );
    
    CONFIG_ROOMID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_ROOMID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_ROOMID__DOLLAR____AnalogSerialOutput__, CONFIG_ROOMID__DOLLAR__ );
    
    CONFIG_ROOMNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_ROOMNAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_ROOMNAME__DOLLAR____AnalogSerialOutput__, CONFIG_ROOMNAME__DOLLAR__ );
    
    CONFIG_ROOMFRIENDLYNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_ROOMFRIENDLYNAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_ROOMFRIENDLYNAME__DOLLAR____AnalogSerialOutput__, CONFIG_ROOMFRIENDLYNAME__DOLLAR__ );
    
    CONFIG_ROOMDESCRIPTION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_ROOMDESCRIPTION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_ROOMDESCRIPTION__DOLLAR____AnalogSerialOutput__, CONFIG_ROOMDESCRIPTION__DOLLAR__ );
    
    CONFIG_ROOMLOCATION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_ROOMLOCATION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_ROOMLOCATION__DOLLAR____AnalogSerialOutput__, CONFIG_ROOMLOCATION__DOLLAR__ );
    
    CONFIG_ROOMTIMEZONE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_ROOMTIMEZONE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_ROOMTIMEZONE__DOLLAR____AnalogSerialOutput__, CONFIG_ROOMTIMEZONE__DOLLAR__ );
    
    CONFIG_DEFAULTSUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_DEFAULTSUBJECT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_DEFAULTSUBJECT__DOLLAR____AnalogSerialOutput__, CONFIG_DEFAULTSUBJECT__DOLLAR__ );
    
    CONFIG_DEFAULTORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_DEFAULTORGANIZER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_DEFAULTORGANIZER__DOLLAR____AnalogSerialOutput__, CONFIG_DEFAULTORGANIZER__DOLLAR__ );
    
    CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR____AnalogSerialOutput__, CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR__ );
    
    CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR____AnalogSerialOutput__, CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR__ );
    
    CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR____AnalogSerialOutput__, CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR__ );
    
    CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR____AnalogSerialOutput__, CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR__ );
    
    FROM_RV_ROOMCONFIGREPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_ROOMCONFIGREPONSE__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( FROM_RV_ROOMCONFIGREPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_ROOMCONFIGREPONSE__DOLLAR__ );
    
    
    INITIALIZE_MODULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_MODULE_OnPush_0, false ) );
    CLEAR_ALL_STORED_DATA.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_ALL_STORED_DATA_OnPush_1, false ) );
    DATA_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( DATA_TIMEOUT_OnPush_2, false ) );
    LOAD_STORED_VALUES.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOAD_STORED_VALUES_OnPush_3, false ) );
    GET_CONFIGURATION.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_CONFIGURATION_OnPush_4, false ) );
    FROM_RV_ROOMCONFIGREPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_ROOMCONFIGREPONSE__DOLLAR___OnChange_5, false ) );
    UI_CONFIG_MENU_SHOW_MEETING_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_MEETING_INFO_OnPush_6, false ) );
    UI_CONFIG_MENU_SHOW_MEETING_SUBJECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_MEETING_SUBJECT_OnPush_7, false ) );
    UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER_OnPush_8, false ) );
    UI_CONFIG_MENU_SHOW_MEETING_TIMES.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_MEETING_TIMES_OnPush_9, false ) );
    UI_CONFIG_MENU_SHOW_DAY_VIEW.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_DAY_VIEW_OnPush_10, false ) );
    UI_CONFIG_DAY_VIEW_GET_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_DAY_VIEW_GET_INFO_OnPush_11, false ) );
    UI_CONFIG_DAY_VIEW_ADD_APPT.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_DAY_VIEW_ADD_APPT_OnPush_12, false ) );
    UI_CONFIG_DAY_VIEW_EN_PREV_DAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_DAY_VIEW_EN_PREV_DAY_OnPush_13, false ) );
    UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS_OnPush_14, false ) );
    UI_CONFIG_MENU_SHOW_RESERVE_NOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_MENU_SHOW_RESERVE_NOW_OnPush_15, false ) );
    UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS_OnPush_16, false ) );
    UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS_OnPush_17, false ) );
    UI_CONFIG_RESERVE_NOW_EVEN_END_TIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_RESERVE_NOW_EVEN_END_TIME_OnPush_18, false ) );
    UI_CONFIG_RESERVE_NOW_TIME_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_RESERVE_NOW_TIME_SELECT_OnPush_19, false ) );
    UI_CONFIG_NEXT_RESERVE_SHOW_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_NEXT_RESERVE_SHOW_INFO_OnPush_20, false ) );
    UI_CONFIG_PANEL_WAKE_UP_TO_MEETING.OnDigitalPush.Add( new InputChangeHandlerWrapper( UI_CONFIG_PANEL_WAKE_UP_TO_MEETING_OnPush_21, false ) );
    ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW_OnPush_22, false ) );
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS_OnPush_23, false ) );
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS_OnPush_24, false ) );
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS_OnPush_25, false ) );
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS_OnPush_26, false ) );
    ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN_OnPush_27, false ) );
    ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC_OnPush_28, false ) );
    ROOM_CONFIG_PRIVACY_LEVEL_SEMI.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_PRIVACY_LEVEL_SEMI_OnPush_29, false ) );
    ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE_OnPush_30, false ) );
    ROOM_CONFIG_MOTION_SENSOR_TYPE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_MOTION_SENSOR_TYPE_OnPush_31, false ) );
    ROOM_CONFIG_MOTION_SENSOR_OUTPUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_MOTION_SENSOR_OUTPUT_OnPush_32, false ) );
    ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS_OnPush_33, false ) );
    ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS_OnPush_34, false ) );
    ROOM_CONFIG_EN_END_MEETING_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_EN_END_MEETING_BTN_OnPush_35, false ) );
    ROOM_CONFIG_EN_START_MEETING_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_EN_START_MEETING_BTN_OnPush_36, false ) );
    ROOM_CONFIG_EN_BROADCAST_MESSAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_CONFIG_EN_BROADCAST_MESSAGE_OnPush_37, false ) );
    DATE_FORMAT_US.OnDigitalPush.Add( new InputChangeHandlerWrapper( DATE_FORMAT_US_OnPush_38, false ) );
    DATE_FORMAT_EURO.OnDigitalPush.Add( new InputChangeHandlerWrapper( DATE_FORMAT_EURO_OnPush_39, false ) );
    DATE_FORMAT_INT.OnDigitalPush.Add( new InputChangeHandlerWrapper( DATE_FORMAT_INT_OnPush_40, false ) );
    TIME_FORMAT.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_FORMAT_OnPush_41, false ) );
    DEFAULTSUBJECT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULTSUBJECT__DOLLAR___OnChange_42, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_ROOM_CONFIGURATION_V3_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint INITIALIZE_MODULE__DigitalInput__ = 1;
const uint CLEAR_ALL_STORED_DATA__DigitalInput__ = 2;
const uint GET_CONFIGURATION__DigitalInput__ = 3;
const uint DATA_TIMEOUT__DigitalInput__ = 4;
const uint LOAD_STORED_VALUES__DigitalInput__ = 5;
const uint UI_CONFIG_MENU_SHOW_MEETING_INFO__DigitalInput__ = 6;
const uint UI_CONFIG_MENU_SHOW_MEETING_SUBJECT__DigitalInput__ = 7;
const uint UI_CONFIG_MENU_SHOW_MEETING_ORGANIZER__DigitalInput__ = 8;
const uint UI_CONFIG_MENU_SHOW_MEETING_TIMES__DigitalInput__ = 9;
const uint UI_CONFIG_MENU_SHOW_DAY_VIEW__DigitalInput__ = 10;
const uint UI_CONFIG_DAY_VIEW_GET_INFO__DigitalInput__ = 11;
const uint UI_CONFIG_DAY_VIEW_ADD_APPT__DigitalInput__ = 12;
const uint UI_CONFIG_DAY_VIEW_EN_PREV_DAY__DigitalInput__ = 13;
const uint UI_CONFIG_MENU_SHOW_AVAIALBLE_ROOMS__DigitalInput__ = 14;
const uint UI_CONFIG_MENU_SHOW_RESERVE_NOW__DigitalInput__ = 15;
const uint UI_CONFIG_RESERVE_NOW_MAX_DUR_MINUS__DigitalInput__ = 16;
const uint UI_CONFIG_RESERVE_NOW_MAX_DUR_PLUS__DigitalInput__ = 17;
const uint UI_CONFIG_RESERVE_NOW_EVEN_END_TIME__DigitalInput__ = 18;
const uint UI_CONFIG_RESERVE_NOW_TIME_SELECT__DigitalInput__ = 19;
const uint UI_CONFIG_NEXT_RESERVE_SHOW_INFO__DigitalInput__ = 20;
const uint UI_CONFIG_PANEL_WAKE_UP_TO_MEETING__DigitalInput__ = 21;
const uint ROOM_CONFIG_EN_DECLINE_FOR_NO_SHOW__DigitalInput__ = 22;
const uint ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_MINUS__DigitalInput__ = 23;
const uint ROOM_CONFIG_DECLINE_FOR_NO_SHOW_APPLY_TO_PLUS__DigitalInput__ = 24;
const uint ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_MINUS__DigitalInput__ = 25;
const uint ROOM_CONFIG_DECLINE_FOR_NO_SHOW_AFTER_PLUS__DigitalInput__ = 26;
const uint ROOM_CONFIG_DECLINE_FOR_NO_SHOW_CHECK_ON_EXACT_MIN__DigitalInput__ = 27;
const uint ROOM_CONFIG_PRIVACY_LEVEL_PUBLIC__DigitalInput__ = 28;
const uint ROOM_CONFIG_PRIVACY_LEVEL_SEMI__DigitalInput__ = 29;
const uint ROOM_CONFIG_PRIVACY_LEVEL_PRIVATE__DigitalInput__ = 30;
const uint ROOM_CONFIG_MOTION_SENSOR_TYPE__DigitalInput__ = 31;
const uint ROOM_CONFIG_MOTION_SENSOR_OUTPUT__DigitalInput__ = 32;
const uint ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_MINUS__DigitalInput__ = 33;
const uint ROOM_CONFIG_MOTION_SENSOR_RELEASE_TIME_PLUS__DigitalInput__ = 34;
const uint ROOM_CONFIG_EN_END_MEETING_BTN__DigitalInput__ = 35;
const uint ROOM_CONFIG_EN_START_MEETING_BTN__DigitalInput__ = 36;
const uint ROOM_CONFIG_EN_BROADCAST_MESSAGE__DigitalInput__ = 37;
const uint DATE_FORMAT_US__DigitalInput__ = 38;
const uint DATE_FORMAT_EURO__DigitalInput__ = 39;
const uint DATE_FORMAT_INT__DigitalInput__ = 40;
const uint TIME_FORMAT__DigitalInput__ = 41;
const uint ROOMID__DOLLAR____AnalogSerialInput__ = 0;
const uint DEFAULTSUBJECT__DOLLAR____AnalogSerialInput__ = 1;
const uint FROM_RV_ROOMCONFIGREPONSE__DOLLAR____AnalogSerialInput__ = 2;
const uint INITIALIZE_MODULE_BUSY_FB__DigitalOutput__ = 0;
const uint MENU_EN_TOOLS_PAGE__DigitalOutput__ = 1;
const uint MENU_SHOW_MEETING_INFO__DigitalOutput__ = 2;
const uint MENU_SHOW_DAY_VIEW__DigitalOutput__ = 3;
const uint MENU_SHOW_AVAILABLE_ROOMS__DigitalOutput__ = 4;
const uint MENU_SHOW_RESERVE_NOW__DigitalOutput__ = 5;
const uint MENU_SHOW_SEARCH_WIZARD__DigitalOutput__ = 6;
const uint MENU_DAYVIEW_EN_INFO__DigitalOutput__ = 7;
const uint MENU_DAYVIEW_EN_ADD_APPT__DigitalOutput__ = 8;
const uint MENU_DAYVIEW_EN_PREVIOUS_DAY__DigitalOutput__ = 9;
const uint CONFIG_EN_DECLINEFORNOSHOW__DigitalOutput__ = 10;
const uint CONFIG_EN_PUSHMODEL__DigitalOutput__ = 11;
const uint DECLINEFORNOSHOW_CHECKATEXACTMIN__DigitalOutput__ = 12;
const uint CONFIG_EN_BROADCASTMESSAGE__DigitalOutput__ = 13;
const uint CONFIG_EN_FREEUPROOM__DigitalOutput__ = 14;
const uint CONFIG_EN_STARTMEETING__DigitalOutput__ = 15;
const uint CONFIG_EN_PANELWAKEUP__DigitalOutput__ = 16;
const uint CONFIG_FREEUPROOM_EN_MIN__DigitalOutput__ = 17;
const uint CONFIG_FREEUPROOM_EN_PER__DigitalOutput__ = 18;
const uint CONFIG_MOTIONSENSOR_TYPE__DigitalOutput__ = 19;
const uint CONFIG_MOTIONSENSOR_OUTPUT__DigitalOutput__ = 20;
const uint CONFIG_MOTIONSENSOR_LED_TRACK__DigitalOutput__ = 21;
const uint CONFIG_RESERVENOW_EVEN_END_TIME__DigitalOutput__ = 22;
const uint CONFIG_RESERVENOW_TIME_SELECT__DigitalOutput__ = 23;
const uint CONFIG_EN_AVAILABLETIMES__DigitalOutput__ = 24;
const uint MENU_SHOW_SUBJECT__DigitalOutput__ = 25;
const uint MENU_SHOW_ORGANIZER__DigitalOutput__ = 26;
const uint MENU_SHOW_TIMES__DigitalOutput__ = 27;
const uint CONFIG_TIME_FORMAT__DigitalOutput__ = 28;
const uint MODULE_STATUS__AnalogSerialOutput__ = 0;
const uint CONFIG_DECLINEFORNOSHOWAPPLIESDUR__AnalogSerialOutput__ = 1;
const uint CONFIG_DECLINEFORNOSHOWMIN__AnalogSerialOutput__ = 2;
const uint CONFIG_RESERVENOWMAXDUR__AnalogSerialOutput__ = 3;
const uint CONFIG_ROOMPRIVACYLEVEL__AnalogSerialOutput__ = 4;
const uint CONFIG_DATE_FORMAT__AnalogSerialOutput__ = 5;
const uint CONFIG_DECLINEFORNOSHOWPER__AnalogSerialOutput__ = 6;
const uint CONFIG_FREEUPROOM_ENUSEMIN__AnalogSerialOutput__ = 7;
const uint CONFIG_FREEUPROOM_ENUSEPER__AnalogSerialOutput__ = 8;
const uint CONFIG_MOTIONSENSOR_TIMEOUT__AnalogSerialOutput__ = 9;
const uint TO_RV_ROOMCONFIGQUERY__DOLLAR____AnalogSerialOutput__ = 10;
const uint CONFIG_ROOMID__DOLLAR____AnalogSerialOutput__ = 11;
const uint CONFIG_ROOMNAME__DOLLAR____AnalogSerialOutput__ = 12;
const uint CONFIG_ROOMFRIENDLYNAME__DOLLAR____AnalogSerialOutput__ = 13;
const uint CONFIG_ROOMDESCRIPTION__DOLLAR____AnalogSerialOutput__ = 14;
const uint CONFIG_ROOMLOCATION__DOLLAR____AnalogSerialOutput__ = 15;
const uint CONFIG_ROOMTIMEZONE__DOLLAR____AnalogSerialOutput__ = 16;
const uint CONFIG_DEFAULTSUBJECT__DOLLAR____AnalogSerialOutput__ = 17;
const uint CONFIG_DEFAULTORGANIZER__DOLLAR____AnalogSerialOutput__ = 18;
const uint CONFIG_RESERVENOW_DEFAULTSUBJECT__DOLLAR____AnalogSerialOutput__ = 19;
const uint CONFIG_RESERVENOW_DEFAULTORGANIZER__DOLLAR____AnalogSerialOutput__ = 20;
const uint CONFIG_MENU_SHOW_BKGD_IMAGE_URL__DOLLAR____AnalogSerialOutput__ = 21;
const uint CONFIG_MENU_SHOW_LOGO_IMAGE_URL__DOLLAR____AnalogSerialOutput__ = 22;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, true, true)]
            public ROOMDATASTRUCT CONFIGDATA;
            [SplusStructAttribute(1, false, true)]
            public CrestronString G_SNVDATACLEARED;
            [SplusStructAttribute(2, false, true)]
            public CrestronString G_SHAVESTOREDCONFIGDATA;
            
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
public class ROOMDATASTRUCT : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  MENUENTOOLSPAGE = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  MENUSHOWMEETINGINFO = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  MENUSHOWDAYVIEW = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  MENUSHOWAVAILABLEROOMS = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  MENUSHOWRESERVENOW = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  MENUSHOWSEARCHWIZARD = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  MENUDAYVIEWENINFO = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  MENUDAYVIEWENRESERVE = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  MENUDAYVIEWENPREVDAY = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  MENUSHOWMEETINGSUBJECT = 0;
    
    [SplusStructAttribute(10, false, false)]
    public ushort  MENUSHOWMEETINGORGANIZER = 0;
    
    [SplusStructAttribute(11, false, false)]
    public ushort  MENUSHOWMEETINGTIMES = 0;
    
    [SplusStructAttribute(12, false, false)]
    public ushort  MENUSHOWAVAILABLETIME = 0;
    
    [SplusStructAttribute(13, false, false)]
    public ushort  MENUENWAKEUPTOMEETING = 0;
    
    [SplusStructAttribute(14, false, false)]
    public CrestronString  MENUBKGDIMAGEURL;
    
    [SplusStructAttribute(15, false, false)]
    public CrestronString  MENULOGOIMAGEURL;
    
    [SplusStructAttribute(16, false, false)]
    public CrestronString  ROOMID;
    
    [SplusStructAttribute(17, false, false)]
    public CrestronString  ROOMNAME;
    
    [SplusStructAttribute(18, false, false)]
    public CrestronString  ROOMFRIENDLYNAME;
    
    [SplusStructAttribute(19, false, false)]
    public CrestronString  ROOMDESCRIPTION;
    
    [SplusStructAttribute(20, false, false)]
    public CrestronString  ROOMTIMEZONE;
    
    [SplusStructAttribute(21, false, false)]
    public CrestronString  ROOMLOCATION;
    
    [SplusStructAttribute(22, false, false)]
    public CrestronString  DEFAULTSUBJECT;
    
    [SplusStructAttribute(23, false, false)]
    public CrestronString  DEFAULTORGANIZER;
    
    [SplusStructAttribute(24, false, false)]
    public CrestronString  RESERVENOWDEFAULTSUBJECT;
    
    [SplusStructAttribute(25, false, false)]
    public CrestronString  RESERVENOWDEFAULTORGANIZER;
    
    [SplusStructAttribute(26, false, false)]
    public ushort  ENDECLINEFORNOSHOW = 0;
    
    [SplusStructAttribute(27, false, false)]
    public ushort  DECLINEFORNOSHOWAPPLIESDUR = 0;
    
    [SplusStructAttribute(28, false, false)]
    public ushort  DECLINEFORNOSHOWMIN = 0;
    
    [SplusStructAttribute(29, false, false)]
    public ushort  DECLINEFORNOSHOWPER = 0;
    
    [SplusStructAttribute(30, false, false)]
    public ushort  DECLINEFORNOSHOWENCHECKATEXACTMIN = 0;
    
    [SplusStructAttribute(31, false, false)]
    public ushort  ENFREEUPROOM = 0;
    
    [SplusStructAttribute(32, false, false)]
    public ushort  FREEUPROOMENUSEMIN = 0;
    
    [SplusStructAttribute(33, false, false)]
    public ushort  FREEUPROOMENUSEPER = 0;
    
    [SplusStructAttribute(34, false, false)]
    public ushort  FREEUPROOMENMIN = 0;
    
    [SplusStructAttribute(35, false, false)]
    public ushort  FREEUPROOMENPER = 0;
    
    [SplusStructAttribute(36, false, false)]
    public ushort  ENSTARTMEETING = 0;
    
    [SplusStructAttribute(37, false, false)]
    public ushort  RESERVENOWMAXDUR = 0;
    
    [SplusStructAttribute(38, false, false)]
    public ushort  RESERVENOWEVENENDTIME = 0;
    
    [SplusStructAttribute(39, false, false)]
    public ushort  RESERVENOWTIMESELECTION = 0;
    
    [SplusStructAttribute(40, false, false)]
    public ushort  ROOMPRIVACYLEVEL = 0;
    
    [SplusStructAttribute(41, false, false)]
    public ushort  ENPUSHMODEL = 0;
    
    [SplusStructAttribute(42, false, false)]
    public ushort  MOTIONSENSORTYPE = 0;
    
    [SplusStructAttribute(43, false, false)]
    public ushort  MOTIONSENSOROUTPUT = 0;
    
    [SplusStructAttribute(44, false, false)]
    public ushort  MOTIONSENSORTIMEOUT = 0;
    
    [SplusStructAttribute(45, false, false)]
    public ushort  MOTIONSENSORLEDSTRACK = 0;
    
    [SplusStructAttribute(46, false, false)]
    public ushort  DATEFORMAT = 0;
    
    [SplusStructAttribute(47, false, false)]
    public ushort  TIMEFORMAT = 0;
    
    [SplusStructAttribute(48, false, false)]
    public ushort  ENBROADCASTMESSAGE = 0;
    
    [SplusStructAttribute(49, false, false)]
    public ushort  ENTOOLSMENU = 0;
    
    
    public ROOMDATASTRUCT( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        MENUBKGDIMAGEURL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        MENULOGOIMAGEURL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        ROOMID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        ROOMNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, Owner );
        ROOMFRIENDLYNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, Owner );
        ROOMDESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, Owner );
        ROOMTIMEZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, Owner );
        ROOMLOCATION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        DEFAULTSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        DEFAULTORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        RESERVENOWDEFAULTSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        RESERVENOWDEFAULTORGANIZER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        
        
    }
    
}

}
