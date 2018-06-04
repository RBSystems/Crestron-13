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

namespace UserModule_RVSE2_ROOMLIST_V2_1_
{
    public class UserModuleClass_RVSE2_ROOMLIST_V2_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_AUTO_SORT_DATA;
        Crestron.Logos.SplusObjects.DigitalInput REQUIRE_LOCATION_FILTER;
        Crestron.Logos.SplusObjects.DigitalInput REQUIRE_NAME_FILTER;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput GET_LIST_USING_LOCATION;
        Crestron.Logos.SplusObjects.DigitalInput GET_LIST_USING_NAME;
        Crestron.Logos.SplusObjects.DigitalInput DATA_TIMEOUT;
        Crestron.Logos.SplusObjects.StringInput LOCAL_ROOMID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LOCATION_FILTER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput NAME_FILTER__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_ROOMLISTREPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MODULE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput REQUEST_ACTIVE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PROCESSING_DATA_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SORTING_LIST_FB;
        Crestron.Logos.SplusObjects.DigitalOutput LOCATION_FILTER_MISSING;
        Crestron.Logos.SplusObjects.DigitalOutput NAME_FILTER_MISSING;
        Crestron.Logos.SplusObjects.DigitalOutput NO_ROOMS_IN_LIST;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_LIST_QTY;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_ROOMLISTQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__;
        DATA [] ITEM;
        ushort G_BRXOK = 0;
        ushort G_ITOTALITEMS = 0;
        CrestronString G_SREQUESTID;
        CrestronString G_SDATA;
        private void SORTDATA (  SplusExecutionContext __context__ ) 
            { 
            ushort J = 0;
            ushort BSWAPPEDONPREV = 0;
            
            CrestronString STEMPDATA1;
            CrestronString STEMPDATA2;
            STEMPDATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, this );
            STEMPDATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 146;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 147;
                Print( "**SortData**\r\n") ; 
                }
            
            __context__.SourceCodeLine = 149;
            SORTING_LIST_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 151;
            BSWAPPEDONPREV = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 153;
            while ( Functions.TestForTrue  ( ( BSWAPPEDONPREV)  ) ) 
                { 
                __context__.SourceCodeLine = 155;
                BSWAPPEDONPREV = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 156;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(G_ITOTALITEMS - 1); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 159;
                    if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( Functions.Upper( ITEM[ J ].ROOMNAME ), Functions.Upper( ITEM[ (J + 1) ].ROOMNAME ) ) > 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 161;
                        BSWAPPEDONPREV = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 164;
                        STEMPDATA1  .UpdateValue ( ITEM [ J] . ROOMNAME  ) ; 
                        __context__.SourceCodeLine = 165;
                        STEMPDATA2  .UpdateValue ( ITEM [ J] . ROOMID  ) ; 
                        __context__.SourceCodeLine = 168;
                        ITEM [ J] . ROOMNAME  .UpdateValue ( ITEM [ (J + 1)] . ROOMNAME  ) ; 
                        __context__.SourceCodeLine = 169;
                        ITEM [ J] . ROOMID  .UpdateValue ( ITEM [ (J + 1)] . ROOMID  ) ; 
                        __context__.SourceCodeLine = 171;
                        ITEM [ (J + 1)] . ROOMNAME  .UpdateValue ( STEMPDATA1  ) ; 
                        __context__.SourceCodeLine = 172;
                        ITEM [ (J + 1)] . ROOMID  .UpdateValue ( STEMPDATA2  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 156;
                    } 
                
                __context__.SourceCodeLine = 153;
                } 
            
            __context__.SourceCodeLine = 177;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 179;
                Print( "   Sorted List:\r\n") ; 
                __context__.SourceCodeLine = 181;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)G_ITOTALITEMS; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( J  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (J  >= __FN_FORSTART_VAL__2) && (J  <= __FN_FOREND_VAL__2) ) : ( (J  <= __FN_FORSTART_VAL__2) && (J  >= __FN_FOREND_VAL__2) ) ; J  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 183;
                    Print( "    Index:{0:d}\r\n", (ushort)J) ; 
                    __context__.SourceCodeLine = 184;
                    Print( "     {0}\r\n", ITEM [ J] . ROOMID ) ; 
                    __context__.SourceCodeLine = 185;
                    Print( "     {0}\r\n", ITEM [ J] . ROOMNAME ) ; 
                    __context__.SourceCodeLine = 181;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 189;
            SORTING_LIST_FB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void SENDLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 197;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 198;
                Print( "** SendList **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 200;
            TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__  .UpdateValue ( "<RoomList>"  ) ; 
            __context__.SourceCodeLine = 202;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_ITOTALITEMS; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 204;
                TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__  .UpdateValue ( "<Room>" + "<ID>" + ITEM [ I] . ROOMID + "</ID>" + "<Name>" + ITEM [ I] . ROOMNAME + "</Name>" + "</Room>"  ) ; 
                __context__.SourceCodeLine = 202;
                } 
            
            __context__.SourceCodeLine = 211;
            TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__  .UpdateValue ( "</RoomList>"  ) ; 
            
            }
            
        private void PROCESSDATA (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SREMOVED;
            CrestronString SROOMID;
            CrestronString SROOMNAME;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SROOMID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SROOMNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, this );
            
            ushort I = 0;
            ushort IINDEX = 0;
            
            
            __context__.SourceCodeLine = 223;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 224;
                Print( "** Process Data **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 226;
            REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 227;
            PROCESSING_DATA_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 229;
            SREMOVED  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 230;
            SROOMID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 231;
            SROOMNAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 233;
            IINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 235;
            do 
                { 
                __context__.SourceCodeLine = 237;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , G_SDATA )  ) ; 
                __context__.SourceCodeLine = 239;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 240;
                    Print( "Data:{0}\r\n", SREMOVED ) ; 
                    }
                
                __context__.SourceCodeLine = 242;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Room>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 244;
                    SROOMID  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 245;
                    SROOMNAME  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 247;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</RoomID>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 249;
                        SROOMID  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 9) ) )  ) ; 
                        __context__.SourceCodeLine = 251;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 252;
                            Print( "RoomID:{0}\r\n", SROOMID ) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 254;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</RoomName>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 256;
                            SROOMNAME  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 11) ) )  ) ; 
                            __context__.SourceCodeLine = 258;
                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 259;
                                Print( "RoomName:{0}\r\n", SROOMNAME ) ; 
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 261;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</Room>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 263;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SROOMID != LOCAL_ROOMID__DOLLAR__))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 265;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ITOTALITEMS < 400 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 267;
                                        IINDEX = (ushort) ( (IINDEX + 1) ) ; 
                                        __context__.SourceCodeLine = 269;
                                        ITEM [ IINDEX] . ROOMID  .UpdateValue ( SROOMID  ) ; 
                                        __context__.SourceCodeLine = 270;
                                        ITEM [ IINDEX] . ROOMNAME  .UpdateValue ( SROOMNAME  ) ; 
                                        __context__.SourceCodeLine = 272;
                                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 274;
                                            Print( "Stored:{0:d}\r\n", (ushort)IINDEX) ; 
                                            __context__.SourceCodeLine = 275;
                                            Print( " RoomID:{0}\r\n", SROOMID ) ; 
                                            __context__.SourceCodeLine = 276;
                                            Print( " RoomName:{0}\r\n", SROOMNAME ) ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( G_SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 284;
            PROCESSING_DATA_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 286;
            ROOM_LIST_QTY  .Value = (ushort) ( IINDEX ) ; 
            __context__.SourceCodeLine = 287;
            G_ITOTALITEMS = (ushort) ( IINDEX ) ; 
            __context__.SourceCodeLine = 289;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ITOTALITEMS == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 291;
                NO_ROOMS_IN_LIST  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 292;
                NO_ROOMS_IN_LIST  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 295;
                TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__  .UpdateValue ( "<RoomList></RoomList>"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 301;
                if ( Functions.TestForTrue  ( ( ENABLE_AUTO_SORT_DATA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 304;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ITOTALITEMS > 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 308;
                        SORTDATA (  __context__  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 311;
                    SENDLIST (  __context__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 317;
                    SENDLIST (  __context__  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 321;
            MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        object ROOMVIEW_ONLINE_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 331;
                G_SREQUESTID  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 333;
                MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 335;
                REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 336;
                PROCESSING_DATA_FB  .Value = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DATA_TIMEOUT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 341;
            G_SREQUESTID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 343;
            MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 345;
            REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 346;
            PROCESSING_DATA_FB  .Value = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object GET_LIST_USING_LOCATION_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 351;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( REQUEST_ACTIVE_FB  .Value ) ) && Functions.TestForTrue ( Functions.Not( PROCESSING_DATA_FB  .Value ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 353;
            G_SREQUESTID  .UpdateValue ( "AvailableRooms" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 355;
            if ( Functions.TestForTrue  ( ( REQUIRE_LOCATION_FILTER  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 357;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( LOCATION_FILTER__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 359;
                    MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 361;
                    REQUEST_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 363;
                    TO_RV_ROOMLISTQUERY__DOLLAR__  .UpdateValue ( "<RequestRoomList>" + "<RequestID>" + G_SREQUESTID + "</RequestID>" + "<Property>Location</Property>" + "<Value>" + LOCATION_FILTER__DOLLAR__ + "</Value>" + "</RequestRoomList>"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 371;
                    LOCATION_FILTER_MISSING  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 372;
                    LOCATION_FILTER_MISSING  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 377;
                MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 379;
                REQUEST_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 381;
                TO_RV_ROOMLISTQUERY__DOLLAR__  .UpdateValue ( "<RequestRoomList>" + "<RequestID>" + G_SREQUESTID + "</RequestID>" + "<Property>Location</Property>" + "<Value>" + LOCATION_FILTER__DOLLAR__ + "</Value>" + "</RequestRoomList>"  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GET_LIST_USING_NAME_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 392;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( REQUEST_ACTIVE_FB  .Value ) ) && Functions.TestForTrue ( Functions.Not( PROCESSING_DATA_FB  .Value ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 394;
            G_SREQUESTID  .UpdateValue ( "AvailableRooms" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 396;
            if ( Functions.TestForTrue  ( ( REQUIRE_NAME_FILTER  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 398;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NAME_FILTER__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 400;
                    MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 402;
                    REQUEST_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 404;
                    TO_RV_ROOMLISTQUERY__DOLLAR__  .UpdateValue ( "<RequestRoomList>" + "<RequestID>" + G_SREQUESTID + "</RequestID>" + "<Property>RoomName</Property>" + "<Value>" + NAME_FILTER__DOLLAR__ + "</Value>" + "</RequestRoomList>"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 412;
                    NAME_FILTER_MISSING  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 413;
                    NAME_FILTER_MISSING  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 413;
                    ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 418;
                MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 420;
                REQUEST_ACTIVE_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 422;
                TO_RV_ROOMLISTQUERY__DOLLAR__  .UpdateValue ( "<RequestRoomList>" + "<RequestID>" + G_SREQUESTID + "</RequestID>" + "<Property>RoomName</Property>" + "<Value>" + NAME_FILTER__DOLLAR__ + "</Value>" + "</RequestRoomList>"  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_RV_ROOMLISTREPONSE__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 436;
        if ( Functions.TestForTrue  ( ( G_BRXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 438;
            G_BRXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 440;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 442;
                G_SDATA  .UpdateValue ( Functions.Gather ( "</RoomListResponse>" , FROM_RV_ROOMLISTREPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 444;
                if ( Functions.TestForTrue  ( ( Functions.Find( G_SREQUESTID , G_SDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 446;
                    PROCESSDATA (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 440;
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
        
        __context__.SourceCodeLine = 463;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 465;
        G_BRXOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 467;
        G_SDATA  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 469;
        MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 471;
        REQUEST_ACTIVE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 472;
        PROCESSING_DATA_FB  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    G_SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65000, this );
    ITEM  = new DATA[ 401 ];
    for( uint i = 0; i < 401; i++ )
    {
        ITEM [i] = new DATA( this, true );
        ITEM [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    ENABLE_AUTO_SORT_DATA = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_AUTO_SORT_DATA__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_AUTO_SORT_DATA__DigitalInput__, ENABLE_AUTO_SORT_DATA );
    
    REQUIRE_LOCATION_FILTER = new Crestron.Logos.SplusObjects.DigitalInput( REQUIRE_LOCATION_FILTER__DigitalInput__, this );
    m_DigitalInputList.Add( REQUIRE_LOCATION_FILTER__DigitalInput__, REQUIRE_LOCATION_FILTER );
    
    REQUIRE_NAME_FILTER = new Crestron.Logos.SplusObjects.DigitalInput( REQUIRE_NAME_FILTER__DigitalInput__, this );
    m_DigitalInputList.Add( REQUIRE_NAME_FILTER__DigitalInput__, REQUIRE_NAME_FILTER );
    
    ROOMVIEW_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE__DigitalInput__, ROOMVIEW_ONLINE );
    
    GET_LIST_USING_LOCATION = new Crestron.Logos.SplusObjects.DigitalInput( GET_LIST_USING_LOCATION__DigitalInput__, this );
    m_DigitalInputList.Add( GET_LIST_USING_LOCATION__DigitalInput__, GET_LIST_USING_LOCATION );
    
    GET_LIST_USING_NAME = new Crestron.Logos.SplusObjects.DigitalInput( GET_LIST_USING_NAME__DigitalInput__, this );
    m_DigitalInputList.Add( GET_LIST_USING_NAME__DigitalInput__, GET_LIST_USING_NAME );
    
    DATA_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( DATA_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( DATA_TIMEOUT__DigitalInput__, DATA_TIMEOUT );
    
    MODULE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MODULE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODULE_BUSY_FB__DigitalOutput__, MODULE_BUSY_FB );
    
    REQUEST_ACTIVE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( REQUEST_ACTIVE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( REQUEST_ACTIVE_FB__DigitalOutput__, REQUEST_ACTIVE_FB );
    
    PROCESSING_DATA_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PROCESSING_DATA_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PROCESSING_DATA_FB__DigitalOutput__, PROCESSING_DATA_FB );
    
    SORTING_LIST_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SORTING_LIST_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SORTING_LIST_FB__DigitalOutput__, SORTING_LIST_FB );
    
    LOCATION_FILTER_MISSING = new Crestron.Logos.SplusObjects.DigitalOutput( LOCATION_FILTER_MISSING__DigitalOutput__, this );
    m_DigitalOutputList.Add( LOCATION_FILTER_MISSING__DigitalOutput__, LOCATION_FILTER_MISSING );
    
    NAME_FILTER_MISSING = new Crestron.Logos.SplusObjects.DigitalOutput( NAME_FILTER_MISSING__DigitalOutput__, this );
    m_DigitalOutputList.Add( NAME_FILTER_MISSING__DigitalOutput__, NAME_FILTER_MISSING );
    
    NO_ROOMS_IN_LIST = new Crestron.Logos.SplusObjects.DigitalOutput( NO_ROOMS_IN_LIST__DigitalOutput__, this );
    m_DigitalOutputList.Add( NO_ROOMS_IN_LIST__DigitalOutput__, NO_ROOMS_IN_LIST );
    
    ROOM_LIST_QTY = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_LIST_QTY__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_LIST_QTY__AnalogSerialOutput__, ROOM_LIST_QTY );
    
    LOCAL_ROOMID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LOCAL_ROOMID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LOCAL_ROOMID__DOLLAR____AnalogSerialInput__, LOCAL_ROOMID__DOLLAR__ );
    
    LOCATION_FILTER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LOCATION_FILTER__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( LOCATION_FILTER__DOLLAR____AnalogSerialInput__, LOCATION_FILTER__DOLLAR__ );
    
    NAME_FILTER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( NAME_FILTER__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( NAME_FILTER__DOLLAR____AnalogSerialInput__, NAME_FILTER__DOLLAR__ );
    
    TO_RV_ROOMLISTQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_ROOMLISTQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_ROOMLISTQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_ROOMLISTQUERY__DOLLAR__ );
    
    TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR____AnalogSerialOutput__, TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR__ );
    
    FROM_RV_ROOMLISTREPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_ROOMLISTREPONSE__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( FROM_RV_ROOMLISTREPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_ROOMLISTREPONSE__DOLLAR__ );
    
    
    ROOMVIEW_ONLINE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_OnRelease_0, false ) );
    DATA_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( DATA_TIMEOUT_OnPush_1, false ) );
    GET_LIST_USING_LOCATION.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_LIST_USING_LOCATION_OnPush_2, false ) );
    GET_LIST_USING_NAME.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_LIST_USING_NAME_OnPush_3, false ) );
    FROM_RV_ROOMLISTREPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_ROOMLISTREPONSE__DOLLAR___OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_ROOMLIST_V2_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint ENABLE_AUTO_SORT_DATA__DigitalInput__ = 1;
const uint REQUIRE_LOCATION_FILTER__DigitalInput__ = 2;
const uint REQUIRE_NAME_FILTER__DigitalInput__ = 3;
const uint ROOMVIEW_ONLINE__DigitalInput__ = 4;
const uint GET_LIST_USING_LOCATION__DigitalInput__ = 5;
const uint GET_LIST_USING_NAME__DigitalInput__ = 6;
const uint DATA_TIMEOUT__DigitalInput__ = 7;
const uint LOCAL_ROOMID__DOLLAR____AnalogSerialInput__ = 0;
const uint LOCATION_FILTER__DOLLAR____AnalogSerialInput__ = 1;
const uint NAME_FILTER__DOLLAR____AnalogSerialInput__ = 2;
const uint FROM_RV_ROOMLISTREPONSE__DOLLAR____AnalogSerialInput__ = 3;
const uint MODULE_BUSY_FB__DigitalOutput__ = 0;
const uint REQUEST_ACTIVE_FB__DigitalOutput__ = 1;
const uint PROCESSING_DATA_FB__DigitalOutput__ = 2;
const uint SORTING_LIST_FB__DigitalOutput__ = 3;
const uint LOCATION_FILTER_MISSING__DigitalOutput__ = 4;
const uint NAME_FILTER_MISSING__DigitalOutput__ = 5;
const uint NO_ROOMS_IN_LIST__DigitalOutput__ = 6;
const uint ROOM_LIST_QTY__AnalogSerialOutput__ = 0;
const uint TO_RV_ROOMLISTQUERY__DOLLAR____AnalogSerialOutput__ = 1;
const uint TO_MODULE_AVAIALBLE_ROOMS_LIST_DATA__DOLLAR____AnalogSerialOutput__ = 2;

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
public class DATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  ROOMID;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  ROOMNAME;
    
    
    public DATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        ROOMID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        ROOMNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 75, Owner );
        
        
    }
    
}

}
