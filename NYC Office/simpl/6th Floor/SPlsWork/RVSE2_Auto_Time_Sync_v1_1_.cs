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

namespace UserModule_RVSE2_AUTO_TIME_SYNC_V1_1_
{
    public class UserModuleClass_RVSE2_AUTO_TIME_SYNC_V1_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput GET_DATE_TIME;
        Crestron.Logos.SplusObjects.DigitalInput SYNC_DATE_TIME;
        Crestron.Logos.SplusObjects.DigitalInput TIMEOUT;
        Crestron.Logos.SplusObjects.StringInput TIME_ZONE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_RV_LOCALDATETIMERESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TIME_HOUR;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TIME_MINUTE;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_LOCALDATETIMEQUERY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_DATE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AUTO_SYNC_TIME__DOLLAR__;
        ushort G_BRXOK = 0;
        ushort G_ISEEDVALUE = 0;
        ushort G_IRANDOMOFFSET = 0;
        CrestronString G_SREQUESTID;
        CrestronString G_SDATA;
        private void PROCESSDATA (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SREMOVED;
            CrestronString SDATE;
            CrestronString STIME;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            ushort IMONTH = 0;
            ushort IDAY = 0;
            ushort IYEAR = 0;
            ushort IHOURS = 0;
            ushort IMINUTES = 0;
            ushort ISECONDS = 0;
            
            
            __context__.SourceCodeLine = 118;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 120;
                Print( "\r\n** ProcessData **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 123;
            do 
                { 
                __context__.SourceCodeLine = 126;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , G_SDATA )  ) ; 
                __context__.SourceCodeLine = 128;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 130;
                    Print( "  Data:{0}\r\n", SREMOVED ) ; 
                    } 
                
                __context__.SourceCodeLine = 133;
                if ( Functions.TestForTrue  ( ( Functions.Find( "</LocalDateTime>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 135;
                    SREMOVED  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 16) ) )  ) ; 
                    __context__.SourceCodeLine = 137;
                    SDATE  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( 10 ) )  ) ; 
                    __context__.SourceCodeLine = 139;
                    IMONTH = (ushort) ( Functions.Atoi( Functions.Mid( SDATE , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 140;
                    IDAY = (ushort) ( Functions.Atoi( Functions.Right( SDATE , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 141;
                    IYEAR = (ushort) ( Functions.Atoi( Functions.Left( SDATE , (int)( 4 ) ) ) ) ; 
                    __context__.SourceCodeLine = 143;
                    Functions.SetDate (  (int) ( IMONTH ) ,  (int) ( IDAY ) ,  (int) ( IYEAR ) ) ; 
                    __context__.SourceCodeLine = 145;
                    STIME  .UpdateValue ( Functions.Right ( SREMOVED ,  (int) ( 8 ) )  ) ; 
                    __context__.SourceCodeLine = 147;
                    IHOURS = (ushort) ( Functions.Atoi( Functions.Left( STIME , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 148;
                    IMINUTES = (ushort) ( Functions.Atoi( Functions.Mid( STIME , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 149;
                    ISECONDS = (ushort) ( Functions.Atoi( Functions.Right( STIME , (int)( 2 ) ) ) ) ; 
                    __context__.SourceCodeLine = 151;
                    Functions.SetClock (  (int) ( IHOURS ) ,  (int) ( IMINUTES ) ,  (int) ( ISECONDS ) ) ; 
                    __context__.SourceCodeLine = 153;
                    IHOURS = (ushort) ( Functions.GetHourNum() ) ; 
                    __context__.SourceCodeLine = 154;
                    IMINUTES = (ushort) ( Functions.GetMinutesNum() ) ; 
                    __context__.SourceCodeLine = 156;
                    CURRENT_TIME_HOUR  .Value = (ushort) ( IHOURS ) ; 
                    __context__.SourceCodeLine = 157;
                    CURRENT_TIME_MINUTE  .Value = (ushort) ( IMINUTES ) ; 
                    __context__.SourceCodeLine = 158;
                    CURRENT_DATE_TIME__DOLLAR__  .UpdateValue ( Functions.Date (  (int) ( 1 ) ) + " " + Functions.Time ( )  ) ; 
                    __context__.SourceCodeLine = 160;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 162;
                        Print( "  Month:{0:d}\r\n", (ushort)IMONTH) ; 
                        __context__.SourceCodeLine = 163;
                        Print( "  Day:{0:d}\r\n", (ushort)IDAY) ; 
                        __context__.SourceCodeLine = 164;
                        Print( "  Year:{0:d}\r\n", (ushort)IYEAR) ; 
                        __context__.SourceCodeLine = 165;
                        Print( "  Hours:{0:d}\r\n", (ushort)IHOURS) ; 
                        __context__.SourceCodeLine = 166;
                        Print( "  Minutes:{0:d}\r\n", (ushort)IMINUTES) ; 
                        __context__.SourceCodeLine = 167;
                        Print( "  Seconds:{0:d}\r\n", (ushort)ISECONDS) ; 
                        } 
                    
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( G_SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 173;
            BUSY  .Value = (ushort) ( 0 ) ; 
            
            }
            
        object TIMEOUT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 183;
                BUSY  .Value = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object GET_DATE_TIME_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort IHOUR = 0;
            ushort IMINUTE = 0;
            
            
            __context__.SourceCodeLine = 192;
            IHOUR = (ushort) ( Functions.GetHourNum() ) ; 
            __context__.SourceCodeLine = 193;
            IMINUTE = (ushort) ( Functions.GetMinutesNum() ) ; 
            __context__.SourceCodeLine = 195;
            CURRENT_TIME_HOUR  .Value = (ushort) ( IHOUR ) ; 
            __context__.SourceCodeLine = 196;
            CURRENT_TIME_MINUTE  .Value = (ushort) ( IMINUTE ) ; 
            __context__.SourceCodeLine = 197;
            CURRENT_DATE_TIME__DOLLAR__  .UpdateValue ( Functions.Date (  (int) ( 1 ) ) + " " + Functions.Time ( )  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SYNC_DATE_TIME_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 203;
        if ( Functions.TestForTrue  ( ( Functions.Not( BUSY  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 205;
            BUSY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 207;
            G_SREQUESTID  .UpdateValue ( "FORCELTR" + Functions.ItoA (  (int) ( Functions.GetHSeconds() ) )  ) ; 
            __context__.SourceCodeLine = 209;
            TO_RV_LOCALDATETIMEQUERY__DOLLAR__  .UpdateValue ( "<LocalTimeRequest>" + "<RequestID>" + G_SREQUESTID + "</RequestID>" + "</LocalTimeRequest>"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_RV_LOCALDATETIMERESPONSE__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 221;
        if ( Functions.TestForTrue  ( ( G_BRXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 223;
            G_BRXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 225;
            while ( Functions.TestForTrue  ( ( Functions.Find( "</LocalTimeResponse>" , FROM_RV_LOCALDATETIMERESPONSE__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 227;
                G_SDATA  .UpdateValue ( Functions.Remove ( "</LocalTimeResponse>" , FROM_RV_LOCALDATETIMERESPONSE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 229;
                if ( Functions.TestForTrue  ( ( Functions.Find( G_SREQUESTID , G_SDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 231;
                    PROCESSDATA (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 225;
                } 
            
            __context__.SourceCodeLine = 235;
            G_BRXOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 248;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 250;
        G_BRXOK = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SREQUESTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    G_SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    GET_DATE_TIME = new Crestron.Logos.SplusObjects.DigitalInput( GET_DATE_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( GET_DATE_TIME__DigitalInput__, GET_DATE_TIME );
    
    SYNC_DATE_TIME = new Crestron.Logos.SplusObjects.DigitalInput( SYNC_DATE_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( SYNC_DATE_TIME__DigitalInput__, SYNC_DATE_TIME );
    
    TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( TIMEOUT__DigitalInput__, TIMEOUT );
    
    BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY__DigitalOutput__, BUSY );
    
    CURRENT_TIME_HOUR = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TIME_HOUR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TIME_HOUR__AnalogSerialOutput__, CURRENT_TIME_HOUR );
    
    CURRENT_TIME_MINUTE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TIME_MINUTE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TIME_MINUTE__AnalogSerialOutput__, CURRENT_TIME_MINUTE );
    
    TIME_ZONE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TIME_ZONE__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( TIME_ZONE__DOLLAR____AnalogSerialInput__, TIME_ZONE__DOLLAR__ );
    
    TO_RV_LOCALDATETIMEQUERY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_LOCALDATETIMEQUERY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_LOCALDATETIMEQUERY__DOLLAR____AnalogSerialOutput__, TO_RV_LOCALDATETIMEQUERY__DOLLAR__ );
    
    CURRENT_DATE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_DATE_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_DATE_TIME__DOLLAR____AnalogSerialOutput__, CURRENT_DATE_TIME__DOLLAR__ );
    
    AUTO_SYNC_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUTO_SYNC_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUTO_SYNC_TIME__DOLLAR____AnalogSerialOutput__, AUTO_SYNC_TIME__DOLLAR__ );
    
    FROM_RV_LOCALDATETIMERESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_RV_LOCALDATETIMERESPONSE__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROM_RV_LOCALDATETIMERESPONSE__DOLLAR____AnalogSerialInput__, FROM_RV_LOCALDATETIMERESPONSE__DOLLAR__ );
    
    
    TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIMEOUT_OnPush_0, false ) );
    GET_DATE_TIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_DATE_TIME_OnPush_1, false ) );
    SYNC_DATE_TIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYNC_DATE_TIME_OnPush_2, false ) );
    FROM_RV_LOCALDATETIMERESPONSE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_RV_LOCALDATETIMERESPONSE__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_AUTO_TIME_SYNC_V1_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint GET_DATE_TIME__DigitalInput__ = 1;
const uint SYNC_DATE_TIME__DigitalInput__ = 2;
const uint TIMEOUT__DigitalInput__ = 3;
const uint TIME_ZONE__DOLLAR____AnalogSerialInput__ = 0;
const uint FROM_RV_LOCALDATETIMERESPONSE__DOLLAR____AnalogSerialInput__ = 1;
const uint BUSY__DigitalOutput__ = 0;
const uint CURRENT_TIME_HOUR__AnalogSerialOutput__ = 0;
const uint CURRENT_TIME_MINUTE__AnalogSerialOutput__ = 1;
const uint TO_RV_LOCALDATETIMEQUERY__DOLLAR____AnalogSerialOutput__ = 2;
const uint CURRENT_DATE_TIME__DOLLAR____AnalogSerialOutput__ = 3;
const uint AUTO_SYNC_TIME__DOLLAR____AnalogSerialOutput__ = 4;

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
