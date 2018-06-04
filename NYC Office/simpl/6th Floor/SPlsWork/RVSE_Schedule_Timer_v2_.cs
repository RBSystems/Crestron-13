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

namespace UserModule_RVSE_SCHEDULE_TIMER_V2_
{
    public class UserModuleClass_RVSE_SCHEDULE_TIMER_V2_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CLOCK;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_CHECK_STATUS;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_AUTO_REQUEST;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_SLOW_AUTO_REQUEST;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE;
        Crestron.Logos.SplusObjects.AnalogInput CLOCK_INTERVAL;
        Crestron.Logos.SplusObjects.AnalogInput CHECK_STATUS_FREQUENCY;
        Crestron.Logos.SplusObjects.AnalogInput AUTO_REQUEST_FREQUENCY;
        Crestron.Logos.SplusObjects.AnalogInput SLOW_AUTO_REQUEST_FREQUENCY;
        Crestron.Logos.SplusObjects.DigitalOutput TRIGGER_CHECK_STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput TRIGGER_GET_SCHEDULE;
        ushort G_ICHECKSTATUSCOUNT = 0;
        ushort G_IAUTOREQUESTCOUNT = 0;
        ushort G_ISLOWAUTOREQUESTCOUNT = 0;
        object ENABLE_CHECK_STATUS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 87;
                G_ICHECKSTATUSCOUNT = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ENABLE_AUTO_REQUEST_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 92;
            G_IAUTOREQUESTCOUNT = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ENABLE_SLOW_AUTO_REQUEST_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 97;
        G_ISLOWAUTOREQUESTCOUNT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLOCK_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 102;
        if ( Functions.TestForTrue  ( ( ENABLE_CHECK_STATUS  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 104;
            G_ICHECKSTATUSCOUNT = (ushort) ( (G_ICHECKSTATUSCOUNT + 1) ) ; 
            __context__.SourceCodeLine = 106;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_ICHECKSTATUSCOUNT * CLOCK_INTERVAL  .UshortValue) >= CHECK_STATUS_FREQUENCY  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 108;
                TRIGGER_CHECK_STATUS  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 109;
                TRIGGER_CHECK_STATUS  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 111;
                G_ICHECKSTATUSCOUNT = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 115;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLE_AUTO_REQUEST  .Value ) && Functions.TestForTrue ( ROOMVIEW_ONLINE  .Value )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 117;
            G_IAUTOREQUESTCOUNT = (ushort) ( (G_IAUTOREQUESTCOUNT + 1) ) ; 
            __context__.SourceCodeLine = 119;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_IAUTOREQUESTCOUNT * CLOCK_INTERVAL  .UshortValue) >= AUTO_REQUEST_FREQUENCY  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 121;
                TRIGGER_GET_SCHEDULE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 122;
                TRIGGER_GET_SCHEDULE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 124;
                G_IAUTOREQUESTCOUNT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 127;
                G_ICHECKSTATUSCOUNT = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 131;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLE_SLOW_AUTO_REQUEST  .Value ) && Functions.TestForTrue ( ROOMVIEW_ONLINE  .Value )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 133;
            G_ISLOWAUTOREQUESTCOUNT = (ushort) ( (G_ISLOWAUTOREQUESTCOUNT + 1) ) ; 
            __context__.SourceCodeLine = 135;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_ISLOWAUTOREQUESTCOUNT * CLOCK_INTERVAL  .UshortValue) >= SLOW_AUTO_REQUEST_FREQUENCY  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 137;
                TRIGGER_GET_SCHEDULE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 138;
                TRIGGER_GET_SCHEDULE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 140;
                G_ISLOWAUTOREQUESTCOUNT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 143;
                G_ICHECKSTATUSCOUNT = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 158;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 160;
        G_ICHECKSTATUSCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 161;
        G_IAUTOREQUESTCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 162;
        G_ISLOWAUTOREQUESTCOUNT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    CLOCK = new Crestron.Logos.SplusObjects.DigitalInput( CLOCK__DigitalInput__, this );
    m_DigitalInputList.Add( CLOCK__DigitalInput__, CLOCK );
    
    ENABLE_CHECK_STATUS = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_CHECK_STATUS__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_CHECK_STATUS__DigitalInput__, ENABLE_CHECK_STATUS );
    
    ENABLE_AUTO_REQUEST = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_AUTO_REQUEST__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_AUTO_REQUEST__DigitalInput__, ENABLE_AUTO_REQUEST );
    
    ENABLE_SLOW_AUTO_REQUEST = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_SLOW_AUTO_REQUEST__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_SLOW_AUTO_REQUEST__DigitalInput__, ENABLE_SLOW_AUTO_REQUEST );
    
    ROOMVIEW_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE__DigitalInput__, ROOMVIEW_ONLINE );
    
    TRIGGER_CHECK_STATUS = new Crestron.Logos.SplusObjects.DigitalOutput( TRIGGER_CHECK_STATUS__DigitalOutput__, this );
    m_DigitalOutputList.Add( TRIGGER_CHECK_STATUS__DigitalOutput__, TRIGGER_CHECK_STATUS );
    
    TRIGGER_GET_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalOutput( TRIGGER_GET_SCHEDULE__DigitalOutput__, this );
    m_DigitalOutputList.Add( TRIGGER_GET_SCHEDULE__DigitalOutput__, TRIGGER_GET_SCHEDULE );
    
    CLOCK_INTERVAL = new Crestron.Logos.SplusObjects.AnalogInput( CLOCK_INTERVAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CLOCK_INTERVAL__AnalogSerialInput__, CLOCK_INTERVAL );
    
    CHECK_STATUS_FREQUENCY = new Crestron.Logos.SplusObjects.AnalogInput( CHECK_STATUS_FREQUENCY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHECK_STATUS_FREQUENCY__AnalogSerialInput__, CHECK_STATUS_FREQUENCY );
    
    AUTO_REQUEST_FREQUENCY = new Crestron.Logos.SplusObjects.AnalogInput( AUTO_REQUEST_FREQUENCY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AUTO_REQUEST_FREQUENCY__AnalogSerialInput__, AUTO_REQUEST_FREQUENCY );
    
    SLOW_AUTO_REQUEST_FREQUENCY = new Crestron.Logos.SplusObjects.AnalogInput( SLOW_AUTO_REQUEST_FREQUENCY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SLOW_AUTO_REQUEST_FREQUENCY__AnalogSerialInput__, SLOW_AUTO_REQUEST_FREQUENCY );
    
    
    ENABLE_CHECK_STATUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_CHECK_STATUS_OnPush_0, false ) );
    ENABLE_AUTO_REQUEST.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_AUTO_REQUEST_OnPush_1, false ) );
    ENABLE_SLOW_AUTO_REQUEST.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_SLOW_AUTO_REQUEST_OnPush_2, false ) );
    CLOCK.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLOCK_OnPush_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE_SCHEDULE_TIMER_V2_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CLOCK__DigitalInput__ = 0;
const uint ENABLE_CHECK_STATUS__DigitalInput__ = 1;
const uint ENABLE_AUTO_REQUEST__DigitalInput__ = 2;
const uint ENABLE_SLOW_AUTO_REQUEST__DigitalInput__ = 3;
const uint ROOMVIEW_ONLINE__DigitalInput__ = 4;
const uint CLOCK_INTERVAL__AnalogSerialInput__ = 0;
const uint CHECK_STATUS_FREQUENCY__AnalogSerialInput__ = 1;
const uint AUTO_REQUEST_FREQUENCY__AnalogSerialInput__ = 2;
const uint SLOW_AUTO_REQUEST_FREQUENCY__AnalogSerialInput__ = 3;
const uint TRIGGER_CHECK_STATUS__DigitalOutput__ = 0;
const uint TRIGGER_GET_SCHEDULE__DigitalOutput__ = 1;

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
