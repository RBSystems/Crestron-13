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

namespace UserModule_RVSE2_TIME_TO_BARGRAPH_V1_1_
{
    public class UserModuleClass_RVSE2_TIME_TO_BARGRAPH_V1_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_TIME_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_TIME_MIN;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_PAGE;
        Crestron.Logos.SplusObjects.AnalogInput FIELD_QTY;
        Crestron.Logos.SplusObjects.AnalogInput FIELD_TIME_RESOLUTION;
        Crestron.Logos.SplusObjects.AnalogOutput BARGRAPH_VALUE;
        private void SETCURRENTTIMEBARGRAPHVALUE (  SplusExecutionContext __context__ ) 
            { 
            ushort IMINUTESPERPAGE = 0;
            ushort IOFFSETMINUTES = 0;
            ushort ICURRENTTIMEMINUTES = 0;
            
            
            __context__.SourceCodeLine = 88;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CURRENT_PAGE  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (FIELD_QTY  .UshortValue != 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (FIELD_TIME_RESOLUTION  .UshortValue != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 90;
                IMINUTESPERPAGE = (ushort) ( (FIELD_QTY  .UshortValue * FIELD_TIME_RESOLUTION  .UshortValue) ) ; 
                __context__.SourceCodeLine = 91;
                IOFFSETMINUTES = (ushort) ( ((CURRENT_PAGE  .UshortValue * IMINUTESPERPAGE) - IMINUTESPERPAGE) ) ; 
                __context__.SourceCodeLine = 92;
                ICURRENTTIMEMINUTES = (ushort) ( ((CURRENT_TIME_HOUR  .UshortValue * 60) + CURRENT_TIME_MIN  .UshortValue) ) ; 
                __context__.SourceCodeLine = 95;
                BARGRAPH_VALUE  .Value = (ushort) ( (65535 - ((65535 / IMINUTESPERPAGE) * (ICURRENTTIMEMINUTES - IOFFSETMINUTES))) ) ; 
                } 
            
            
            }
            
        object CURRENT_PAGE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 108;
                SETCURRENTTIMEBARGRAPHVALUE (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CURRENT_TIME_HOUR_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 113;
            SETCURRENTTIMEBARGRAPHVALUE (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CURRENT_TIME_MIN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        SETCURRENTTIMEBARGRAPHVALUE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    CURRENT_TIME_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_TIME_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_TIME_HOUR__AnalogSerialInput__, CURRENT_TIME_HOUR );
    
    CURRENT_TIME_MIN = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_TIME_MIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_TIME_MIN__AnalogSerialInput__, CURRENT_TIME_MIN );
    
    CURRENT_PAGE = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_PAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_PAGE__AnalogSerialInput__, CURRENT_PAGE );
    
    FIELD_QTY = new Crestron.Logos.SplusObjects.AnalogInput( FIELD_QTY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FIELD_QTY__AnalogSerialInput__, FIELD_QTY );
    
    FIELD_TIME_RESOLUTION = new Crestron.Logos.SplusObjects.AnalogInput( FIELD_TIME_RESOLUTION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FIELD_TIME_RESOLUTION__AnalogSerialInput__, FIELD_TIME_RESOLUTION );
    
    BARGRAPH_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( BARGRAPH_VALUE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BARGRAPH_VALUE__AnalogSerialOutput__, BARGRAPH_VALUE );
    
    
    CURRENT_PAGE.OnAnalogChange.Add( new InputChangeHandlerWrapper( CURRENT_PAGE_OnChange_0, false ) );
    CURRENT_TIME_HOUR.OnAnalogChange.Add( new InputChangeHandlerWrapper( CURRENT_TIME_HOUR_OnChange_1, false ) );
    CURRENT_TIME_MIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( CURRENT_TIME_MIN_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_TIME_TO_BARGRAPH_V1_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CURRENT_TIME_HOUR__AnalogSerialInput__ = 0;
const uint CURRENT_TIME_MIN__AnalogSerialInput__ = 1;
const uint CURRENT_PAGE__AnalogSerialInput__ = 2;
const uint FIELD_QTY__AnalogSerialInput__ = 3;
const uint FIELD_TIME_RESOLUTION__AnalogSerialInput__ = 4;
const uint BARGRAPH_VALUE__AnalogSerialOutput__ = 0;

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
