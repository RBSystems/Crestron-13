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

namespace UserModule_ANALOG_DIFFERENCE
{
    public class UserModuleClass_ANALOG_DIFFERENCE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput MINUEND;
        Crestron.Logos.SplusObjects.AnalogInput SUBTRAHEND;
        Crestron.Logos.SplusObjects.AnalogOutput DIFFERENCE;
        private ushort CHECKINPUTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 132;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MINUEND  .UshortValue >= SUBTRAHEND  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 134;
                return (ushort)( 1) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 138;
                return (ushort)( 0) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void FINDDIFFERENCE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 145;
            DIFFERENCE  .Value = (ushort) ( (MINUEND  .UshortValue - SUBTRAHEND  .UshortValue) ) ; 
            
            }
            
        object MINUEND_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 191;
                if ( Functions.TestForTrue  ( ( CHECKINPUTS( __context__ ))  ) ) 
                    {
                    __context__.SourceCodeLine = 192;
                    FINDDIFFERENCE (  __context__  ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SUBTRAHEND_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 197;
            if ( Functions.TestForTrue  ( ( CHECKINPUTS( __context__ ))  ) ) 
                {
                __context__.SourceCodeLine = 198;
                FINDDIFFERENCE (  __context__  ) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    MINUEND = new Crestron.Logos.SplusObjects.AnalogInput( MINUEND__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MINUEND__AnalogSerialInput__, MINUEND );
    
    SUBTRAHEND = new Crestron.Logos.SplusObjects.AnalogInput( SUBTRAHEND__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SUBTRAHEND__AnalogSerialInput__, SUBTRAHEND );
    
    DIFFERENCE = new Crestron.Logos.SplusObjects.AnalogOutput( DIFFERENCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIFFERENCE__AnalogSerialOutput__, DIFFERENCE );
    
    
    MINUEND.OnAnalogChange.Add( new InputChangeHandlerWrapper( MINUEND_OnChange_0, false ) );
    SUBTRAHEND.OnAnalogChange.Add( new InputChangeHandlerWrapper( SUBTRAHEND_OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ANALOG_DIFFERENCE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint MINUEND__AnalogSerialInput__ = 0;
const uint SUBTRAHEND__AnalogSerialInput__ = 1;
const uint DIFFERENCE__AnalogSerialOutput__ = 0;

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
