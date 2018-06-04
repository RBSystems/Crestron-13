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

namespace UserModule_RVSE2_GENERIC_UI_DATA_CONTROL_V2_1B_
{
    public class UserModuleClass_RVSE2_GENERIC_UI_DATA_CONTROL_V2_1B_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT;
        Crestron.Logos.SplusObjects.DigitalInput FIRST_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput CURRENT_TIME_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput PAGE_PREV;
        Crestron.Logos.SplusObjects.DigitalInput PAGE_NEXT;
        Crestron.Logos.SplusObjects.DigitalInput UPDATE_OUTPUTS;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_UP;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DOWN;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_TIME_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_TIME_MIN;
        Crestron.Logos.SplusObjects.AnalogInput UI_FIELD_QTY;
        Crestron.Logos.SplusObjects.AnalogInput UI_FIELD_TIME_RESOLUTION;
        Crestron.Logos.SplusObjects.DigitalOutput CURRENT_TIME_WITHIN_PAGE;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_PAGE_PREV;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_PAGE_NEXT;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_PAGE;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTED_POSITION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ANALOG;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> TEXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PAGE_ANALOG;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PAGE_TEXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TIME_LABEL_A__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TIME_LABEL_B__DOLLAR__;
        ushort G_IPAGEQTY = 0;
        ushort G_IBARGRAPHUNIT = 0;
        private CrestronString ITOLA (  SplusExecutionContext __context__, ushort INUMBER ) 
            { 
            CrestronString SNUMBER;
            SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 128;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INUMBER < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 130;
                SNUMBER  .UpdateValue ( "0" + Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 134;
                SNUMBER  .UpdateValue ( Functions.ItoA (  (int) ( INUMBER ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 137;
            return ( SNUMBER ) ; 
            
            }
            
        private void UPDATEOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort IFIELDOFFSET = 0;
            ushort IINDEX = 0;
            
            ushort ITIMEHOUR = 0;
            ushort ITIMELABELQTY = 0;
            ushort ITIMEOFFSET = 0;
            
            
            __context__.SourceCodeLine = 150;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 152;
                Trace( "\r\n** UpdateOutputs **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 157;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CURRENT_PAGE  .Value > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( UI_FIELD_QTY  .UshortValue > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 160;
                ITIMELABELQTY = (ushort) ( (UI_FIELD_QTY  .UshortValue / (60 / UI_FIELD_TIME_RESOLUTION  .UshortValue)) ) ; 
                __context__.SourceCodeLine = 163;
                ITIMEOFFSET = (ushort) ( ((CURRENT_PAGE  .Value * ITIMELABELQTY) - ITIMELABELQTY) ) ; 
                __context__.SourceCodeLine = 167;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)ITIMELABELQTY; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 170;
                    ITIMEHOUR = (ushort) ( ((I + ITIMEOFFSET) - 1) ) ; 
                    __context__.SourceCodeLine = 173;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIMEHOUR < 24 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 175;
                        if ( Functions.TestForTrue  ( ( TIME_FORMAT  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 177;
                            TIME_LABEL_A__DOLLAR__ [ I]  .UpdateValue ( ITOLA (  __context__ , (ushort)( ITIMEHOUR ))  ) ; 
                            __context__.SourceCodeLine = 178;
                            TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( "00"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 183;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIMEHOUR < 12 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 190;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITIMEHOUR == 0))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 191;
                                    TIME_LABEL_A__DOLLAR__ [ I]  .UpdateValue ( "12"  ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 193;
                                    TIME_LABEL_A__DOLLAR__ [ I]  .UpdateValue ( Functions.ItoA (  (int) ( ITIMEHOUR ) )  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 196;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I == 1))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 197;
                                    TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( "AM"  ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 199;
                                    TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( "00"  ) ; 
                                    }
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 201;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITIMEHOUR == 12))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 205;
                                    TIME_LABEL_A__DOLLAR__ [ I]  .UpdateValue ( "12"  ) ; 
                                    __context__.SourceCodeLine = 206;
                                    TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( "PM"  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 212;
                                    TIME_LABEL_A__DOLLAR__ [ I]  .UpdateValue ( Functions.ItoA (  (int) ( (ITIMEHOUR - 12) ) )  ) ; 
                                    __context__.SourceCodeLine = 215;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I == 1))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 216;
                                        TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( "PM"  ) ; 
                                        }
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 218;
                                        TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( "00"  ) ; 
                                        }
                                    
                                    } 
                                
                                }
                            
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 225;
                        TIME_LABEL_A__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 226;
                        TIME_LABEL_B__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 167;
                    } 
                
                __context__.SourceCodeLine = 231;
                IFIELDOFFSET = (ushort) ( ((CURRENT_PAGE  .Value * UI_FIELD_QTY  .UshortValue) - UI_FIELD_QTY  .UshortValue) ) ; 
                __context__.SourceCodeLine = 234;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)UI_FIELD_QTY  .UshortValue; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 236;
                    IINDEX = (ushort) ( (I + IFIELDOFFSET) ) ; 
                    __context__.SourceCodeLine = 238;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 240;
                        Trace( "  i:{0:d}\r\n", (ushort)I) ; 
                        __context__.SourceCodeLine = 241;
                        Trace( "  iIndex:{0:d}\r\n", (ushort)IINDEX) ; 
                        } 
                    
                    __context__.SourceCodeLine = 244;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IINDEX <= 48 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 246;
                        PAGE_ANALOG [ I]  .Value = (ushort) ( ANALOG[ IINDEX ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 247;
                        PAGE_TEXT__DOLLAR__ [ I]  .UpdateValue ( TEXT__DOLLAR__ [ IINDEX ]  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 251;
                        PAGE_ANALOG [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 252;
                        PAGE_TEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 234;
                    } 
                
                } 
            
            
            }
            
        private void SETENABLEBUTTONS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 260;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 262;
                Trace( "\r\n** SetEnableButtons **\r\n") ; 
                __context__.SourceCodeLine = 263;
                Trace( "  PageQty:{0:d}\r\n", (ushort)G_IPAGEQTY) ; 
                __context__.SourceCodeLine = 264;
                Trace( "  CurrentPage:{0:d}\r\n", (ushort)CURRENT_PAGE  .Value) ; 
                } 
            
            __context__.SourceCodeLine = 267;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IPAGEQTY > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 269;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_PAGE  .Value > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 271;
                    ENABLE_PAGE_PREV  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 275;
                    ENABLE_PAGE_PREV  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 278;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_PAGE  .Value < G_IPAGEQTY ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 280;
                    ENABLE_PAGE_NEXT  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 284;
                    ENABLE_PAGE_NEXT  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 289;
                ENABLE_PAGE_PREV  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 290;
                ENABLE_PAGE_NEXT  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        private void SETCURRENTTIMEWITHINPAGE (  SplusExecutionContext __context__ ) 
            { 
            ushort IMINUTESPERPAGE = 0;
            ushort ICURRENTTIMEMINUTES = 0;
            ushort ICURRENTPAGESTARTMINUTES = 0;
            ushort ICURRENTPAGEENDMINUTES = 0;
            
            
            __context__.SourceCodeLine = 301;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 303;
                Trace( "\r\n** SetCurrentTimeWithinPage **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 306;
            IMINUTESPERPAGE = (ushort) ( (UI_FIELD_QTY  .UshortValue * UI_FIELD_TIME_RESOLUTION  .UshortValue) ) ; 
            __context__.SourceCodeLine = 308;
            ICURRENTPAGESTARTMINUTES = (ushort) ( ((CURRENT_PAGE  .Value * IMINUTESPERPAGE) - IMINUTESPERPAGE) ) ; 
            __context__.SourceCodeLine = 309;
            ICURRENTPAGEENDMINUTES = (ushort) ( (CURRENT_PAGE  .Value * IMINUTESPERPAGE) ) ; 
            __context__.SourceCodeLine = 311;
            ICURRENTTIMEMINUTES = (ushort) ( ((CURRENT_TIME_HOUR  .UshortValue * 60) + CURRENT_TIME_MIN  .UshortValue) ) ; 
            __context__.SourceCodeLine = 314;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ICURRENTTIMEMINUTES >= ICURRENTPAGESTARTMINUTES ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ICURRENTTIMEMINUTES <= ICURRENTPAGEENDMINUTES ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 317;
                CURRENT_TIME_WITHIN_PAGE  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 321;
                CURRENT_TIME_WITHIN_PAGE  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        private void SETCURRENTTIMEPAGE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort IMINUTESPERPAGE = 0;
            ushort ICURRENTTIMEMINUTES = 0;
            ushort ICURRENTPAGESTARTMINUTES = 0;
            ushort ICURRENTPAGEENDMINUTES = 0;
            
            
            __context__.SourceCodeLine = 333;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 335;
                Trace( "\r\n** SetCurrentTimePage **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 338;
            IMINUTESPERPAGE = (ushort) ( (UI_FIELD_QTY  .UshortValue * UI_FIELD_TIME_RESOLUTION  .UshortValue) ) ; 
            __context__.SourceCodeLine = 340;
            ICURRENTTIMEMINUTES = (ushort) ( ((CURRENT_TIME_HOUR  .UshortValue * 60) + CURRENT_TIME_MIN  .UshortValue) ) ; 
            __context__.SourceCodeLine = 342;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_IPAGEQTY; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 344;
                ICURRENTPAGESTARTMINUTES = (ushort) ( ((I * IMINUTESPERPAGE) - IMINUTESPERPAGE) ) ; 
                __context__.SourceCodeLine = 345;
                ICURRENTPAGEENDMINUTES = (ushort) ( (I * IMINUTESPERPAGE) ) ; 
                __context__.SourceCodeLine = 347;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ICURRENTTIMEMINUTES >= ICURRENTPAGESTARTMINUTES ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ICURRENTTIMEMINUTES <= ICURRENTPAGEENDMINUTES ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 350;
                    CURRENT_PAGE  .Value = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 351;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 342;
                } 
            
            
            }
            
        object CURRENT_TIME_HOUR_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 365;
                SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CURRENT_TIME_MIN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 370;
            SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object FIRST_PAGE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 375;
        CURRENT_PAGE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 377;
        SETENABLEBUTTONS (  __context__  ) ; 
        __context__.SourceCodeLine = 379;
        UPDATEOUTPUTS (  __context__  ) ; 
        __context__.SourceCodeLine = 381;
        SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CURRENT_TIME_PAGE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 386;
        SETCURRENTTIMEPAGE (  __context__  ) ; 
        __context__.SourceCodeLine = 388;
        SETENABLEBUTTONS (  __context__  ) ; 
        __context__.SourceCodeLine = 390;
        CURRENT_TIME_WITHIN_PAGE  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGE_PREV_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 395;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_PAGE  .Value > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 397;
            CURRENT_PAGE  .Value = (ushort) ( (CURRENT_PAGE  .Value - 1) ) ; 
            __context__.SourceCodeLine = 399;
            SETENABLEBUTTONS (  __context__  ) ; 
            __context__.SourceCodeLine = 401;
            UPDATEOUTPUTS (  __context__  ) ; 
            __context__.SourceCodeLine = 403;
            SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGE_NEXT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 409;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_PAGE  .Value < G_IPAGEQTY ))  ) ) 
            { 
            __context__.SourceCodeLine = 411;
            CURRENT_PAGE  .Value = (ushort) ( (CURRENT_PAGE  .Value + 1) ) ; 
            __context__.SourceCodeLine = 413;
            SETENABLEBUTTONS (  __context__  ) ; 
            __context__.SourceCodeLine = 415;
            UPDATEOUTPUTS (  __context__  ) ; 
            __context__.SourceCodeLine = 417;
            SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UPDATE_OUTPUTS_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 423;
        UPDATEOUTPUTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UI_FIELD_QTY_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 430;
        G_IPAGEQTY = (ushort) ( (48 / UI_FIELD_QTY  .UshortValue) ) ; 
        __context__.SourceCodeLine = 431;
        G_IBARGRAPHUNIT = (ushort) ( (65535 / UI_FIELD_QTY  .UshortValue) ) ; 
        __context__.SourceCodeLine = 433;
        if ( Functions.TestForTrue  ( ( Mod( 48 , UI_FIELD_QTY  .UshortValue ))  ) ) 
            { 
            __context__.SourceCodeLine = 435;
            G_IPAGEQTY = (ushort) ( (G_IPAGEQTY + 1) ) ; 
            } 
        
        __context__.SourceCodeLine = 438;
        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 440;
            Trace( "UI Field Qty Change.\r\n") ; 
            __context__.SourceCodeLine = 441;
            Trace( "  MaxFields:{0:d}\r\n", (ushort)48) ; 
            __context__.SourceCodeLine = 442;
            Trace( "  UIFieldQty:{0:d}\r\n", (ushort)UI_FIELD_QTY  .UshortValue) ; 
            __context__.SourceCodeLine = 443;
            Trace( "  PageQty:{0:d}\r\n", (ushort)G_IPAGEQTY) ; 
            } 
        
        __context__.SourceCodeLine = 446;
        SETENABLEBUTTONS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_UP_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 452;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SELECTED_POSITION  .Value > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 456;
            SELECTED_POSITION  .Value = (ushort) ( (SELECTED_POSITION  .Value - 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 463;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_PAGE  .Value > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 467;
                SELECTED_POSITION  .Value = (ushort) ( UI_FIELD_QTY  .UshortValue ) ; 
                __context__.SourceCodeLine = 469;
                CURRENT_PAGE  .Value = (ushort) ( (CURRENT_PAGE  .Value - 1) ) ; 
                __context__.SourceCodeLine = 471;
                SETENABLEBUTTONS (  __context__  ) ; 
                __context__.SourceCodeLine = 473;
                UPDATEOUTPUTS (  __context__  ) ; 
                __context__.SourceCodeLine = 475;
                SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DOWN_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 483;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SELECTED_POSITION  .Value < UI_FIELD_QTY  .UshortValue ))  ) ) 
            { 
            __context__.SourceCodeLine = 487;
            SELECTED_POSITION  .Value = (ushort) ( (SELECTED_POSITION  .Value + 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 494;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENT_PAGE  .Value < G_IPAGEQTY ))  ) ) 
                { 
                __context__.SourceCodeLine = 498;
                SELECTED_POSITION  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 500;
                CURRENT_PAGE  .Value = (ushort) ( (CURRENT_PAGE  .Value + 1) ) ; 
                __context__.SourceCodeLine = 502;
                SETENABLEBUTTONS (  __context__  ) ; 
                __context__.SourceCodeLine = 504;
                UPDATEOUTPUTS (  __context__  ) ; 
                __context__.SourceCodeLine = 506;
                SETCURRENTTIMEWITHINPAGE (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 521;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 523;
        CURRENT_PAGE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 525;
        CURRENT_TIME_WITHIN_PAGE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 527;
        ENABLE_PAGE_PREV  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 528;
        ENABLE_PAGE_NEXT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 530;
        SELECTED_POSITION  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    TIME_FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT__DigitalInput__, TIME_FORMAT );
    
    FIRST_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( FIRST_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( FIRST_PAGE__DigitalInput__, FIRST_PAGE );
    
    CURRENT_TIME_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( CURRENT_TIME_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( CURRENT_TIME_PAGE__DigitalInput__, CURRENT_TIME_PAGE );
    
    PAGE_PREV = new Crestron.Logos.SplusObjects.DigitalInput( PAGE_PREV__DigitalInput__, this );
    m_DigitalInputList.Add( PAGE_PREV__DigitalInput__, PAGE_PREV );
    
    PAGE_NEXT = new Crestron.Logos.SplusObjects.DigitalInput( PAGE_NEXT__DigitalInput__, this );
    m_DigitalInputList.Add( PAGE_NEXT__DigitalInput__, PAGE_NEXT );
    
    UPDATE_OUTPUTS = new Crestron.Logos.SplusObjects.DigitalInput( UPDATE_OUTPUTS__DigitalInput__, this );
    m_DigitalInputList.Add( UPDATE_OUTPUTS__DigitalInput__, UPDATE_OUTPUTS );
    
    SELECT_UP = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_UP__DigitalInput__, SELECT_UP );
    
    SELECT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DOWN__DigitalInput__, SELECT_DOWN );
    
    CURRENT_TIME_WITHIN_PAGE = new Crestron.Logos.SplusObjects.DigitalOutput( CURRENT_TIME_WITHIN_PAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( CURRENT_TIME_WITHIN_PAGE__DigitalOutput__, CURRENT_TIME_WITHIN_PAGE );
    
    ENABLE_PAGE_PREV = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_PAGE_PREV__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENABLE_PAGE_PREV__DigitalOutput__, ENABLE_PAGE_PREV );
    
    ENABLE_PAGE_NEXT = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_PAGE_NEXT__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENABLE_PAGE_NEXT__DigitalOutput__, ENABLE_PAGE_NEXT );
    
    CURRENT_TIME_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_TIME_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_TIME_HOUR__AnalogSerialInput__, CURRENT_TIME_HOUR );
    
    CURRENT_TIME_MIN = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_TIME_MIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_TIME_MIN__AnalogSerialInput__, CURRENT_TIME_MIN );
    
    UI_FIELD_QTY = new Crestron.Logos.SplusObjects.AnalogInput( UI_FIELD_QTY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( UI_FIELD_QTY__AnalogSerialInput__, UI_FIELD_QTY );
    
    UI_FIELD_TIME_RESOLUTION = new Crestron.Logos.SplusObjects.AnalogInput( UI_FIELD_TIME_RESOLUTION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( UI_FIELD_TIME_RESOLUTION__AnalogSerialInput__, UI_FIELD_TIME_RESOLUTION );
    
    ANALOG = new InOutArray<AnalogInput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        ANALOG[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ANALOG__AnalogSerialInput__ + i, ANALOG__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ANALOG__AnalogSerialInput__ + i, ANALOG[i+1] );
    }
    
    CURRENT_PAGE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_PAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_PAGE__AnalogSerialOutput__, CURRENT_PAGE );
    
    SELECTED_POSITION = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTED_POSITION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTED_POSITION__AnalogSerialOutput__, SELECTED_POSITION );
    
    PAGE_ANALOG = new InOutArray<AnalogOutput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        PAGE_ANALOG[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PAGE_ANALOG__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PAGE_ANALOG__AnalogSerialOutput__ + i, PAGE_ANALOG[i+1] );
    }
    
    TEXT__DOLLAR__ = new InOutArray<StringInput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        TEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( TEXT__DOLLAR____AnalogSerialInput__ + i, TEXT__DOLLAR____AnalogSerialInput__, 75, this );
        m_StringInputList.Add( TEXT__DOLLAR____AnalogSerialInput__ + i, TEXT__DOLLAR__[i+1] );
    }
    
    PAGE_TEXT__DOLLAR__ = new InOutArray<StringOutput>( 48, this );
    for( uint i = 0; i < 48; i++ )
    {
        PAGE_TEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PAGE_TEXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PAGE_TEXT__DOLLAR____AnalogSerialOutput__ + i, PAGE_TEXT__DOLLAR__[i+1] );
    }
    
    TIME_LABEL_A__DOLLAR__ = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        TIME_LABEL_A__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TIME_LABEL_A__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TIME_LABEL_A__DOLLAR____AnalogSerialOutput__ + i, TIME_LABEL_A__DOLLAR__[i+1] );
    }
    
    TIME_LABEL_B__DOLLAR__ = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        TIME_LABEL_B__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TIME_LABEL_B__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TIME_LABEL_B__DOLLAR____AnalogSerialOutput__ + i, TIME_LABEL_B__DOLLAR__[i+1] );
    }
    
    
    CURRENT_TIME_HOUR.OnAnalogChange.Add( new InputChangeHandlerWrapper( CURRENT_TIME_HOUR_OnChange_0, false ) );
    CURRENT_TIME_MIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( CURRENT_TIME_MIN_OnChange_1, false ) );
    FIRST_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FIRST_PAGE_OnPush_2, false ) );
    CURRENT_TIME_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CURRENT_TIME_PAGE_OnPush_3, false ) );
    PAGE_PREV.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGE_PREV_OnPush_4, false ) );
    PAGE_NEXT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGE_NEXT_OnPush_5, false ) );
    UPDATE_OUTPUTS.OnDigitalPush.Add( new InputChangeHandlerWrapper( UPDATE_OUTPUTS_OnPush_6, false ) );
    UI_FIELD_QTY.OnAnalogChange.Add( new InputChangeHandlerWrapper( UI_FIELD_QTY_OnChange_7, false ) );
    SELECT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_UP_OnPush_8, false ) );
    SELECT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DOWN_OnPush_9, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_GENERIC_UI_DATA_CONTROL_V2_1B_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint TIME_FORMAT__DigitalInput__ = 1;
const uint FIRST_PAGE__DigitalInput__ = 2;
const uint CURRENT_TIME_PAGE__DigitalInput__ = 3;
const uint PAGE_PREV__DigitalInput__ = 4;
const uint PAGE_NEXT__DigitalInput__ = 5;
const uint UPDATE_OUTPUTS__DigitalInput__ = 6;
const uint SELECT_UP__DigitalInput__ = 7;
const uint SELECT_DOWN__DigitalInput__ = 8;
const uint CURRENT_TIME_HOUR__AnalogSerialInput__ = 0;
const uint CURRENT_TIME_MIN__AnalogSerialInput__ = 1;
const uint UI_FIELD_QTY__AnalogSerialInput__ = 2;
const uint UI_FIELD_TIME_RESOLUTION__AnalogSerialInput__ = 3;
const uint CURRENT_TIME_WITHIN_PAGE__DigitalOutput__ = 0;
const uint ENABLE_PAGE_PREV__DigitalOutput__ = 1;
const uint ENABLE_PAGE_NEXT__DigitalOutput__ = 2;
const uint CURRENT_PAGE__AnalogSerialOutput__ = 0;
const uint SELECTED_POSITION__AnalogSerialOutput__ = 1;
const uint ANALOG__AnalogSerialInput__ = 4;
const uint TEXT__DOLLAR____AnalogSerialInput__ = 52;
const uint PAGE_ANALOG__AnalogSerialOutput__ = 2;
const uint PAGE_TEXT__DOLLAR____AnalogSerialOutput__ = 50;
const uint TIME_LABEL_A__DOLLAR____AnalogSerialOutput__ = 98;
const uint TIME_LABEL_B__DOLLAR____AnalogSerialOutput__ = 122;

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
