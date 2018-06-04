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

namespace UserModule_TEXTUPDATE_ON_TRIGGER_REV5_1
{
    public class UserModuleClass_TEXTUPDATE_ON_TRIGGER_REV5_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.DigitalInput OUTPUT_ON_TRIGGER_ONLY;
        Crestron.Logos.SplusObjects.DigitalInput TRIGGER;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> INPUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> OUTPUT__DOLLAR__;
        ushort IOUTPUTCOUNT = 0;
        object ENABLE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                
                __context__.SourceCodeLine = 30;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( OUTPUT_ON_TRIGGER_ONLY  .Value ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IOUTPUTCOUNT > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 32;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)IOUTPUTCOUNT; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 34;
                        OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
                        __context__.SourceCodeLine = 32;
                        } 
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object TRIGGER_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 43;
            if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 45;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IOUTPUTCOUNT > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 47;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)IOUTPUTCOUNT; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 49;
                        OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
                        __context__.SourceCodeLine = 47;
                        } 
                    
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object INPUT__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 59;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 61;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLE  .Value ) && Functions.TestForTrue ( Functions.Not( OUTPUT_ON_TRIGGER_ONLY  .Value ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 62;
            OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort X = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 69;
        IOUTPUTCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 71;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)200; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 73;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( OUTPUT__DOLLAR__[ X ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 75;
                IOUTPUTCOUNT = (ushort) ( (IOUTPUTCOUNT + 1) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 78;
                break ; 
                }
            
            __context__.SourceCodeLine = 71;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    OUTPUT_ON_TRIGGER_ONLY = new Crestron.Logos.SplusObjects.DigitalInput( OUTPUT_ON_TRIGGER_ONLY__DigitalInput__, this );
    m_DigitalInputList.Add( OUTPUT_ON_TRIGGER_ONLY__DigitalInput__, OUTPUT_ON_TRIGGER_ONLY );
    
    TRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( TRIGGER__DigitalInput__, this );
    m_DigitalInputList.Add( TRIGGER__DigitalInput__, TRIGGER );
    
    INPUT__DOLLAR__ = new InOutArray<StringInput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        INPUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( INPUT__DOLLAR____AnalogSerialInput__ + i, INPUT__DOLLAR____AnalogSerialInput__, 255, this );
        m_StringInputList.Add( INPUT__DOLLAR____AnalogSerialInput__ + i, INPUT__DOLLAR__[i+1] );
    }
    
    OUTPUT__DOLLAR__ = new InOutArray<StringOutput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        OUTPUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( OUTPUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( OUTPUT__DOLLAR____AnalogSerialOutput__ + i, OUTPUT__DOLLAR__[i+1] );
    }
    
    
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_0, false ) );
    TRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRIGGER_OnPush_1, false ) );
    for( uint i = 0; i < 200; i++ )
        INPUT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( INPUT__DOLLAR___OnChange_2, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TEXTUPDATE_ON_TRIGGER_REV5_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE__DigitalInput__ = 0;
const uint OUTPUT_ON_TRIGGER_ONLY__DigitalInput__ = 1;
const uint TRIGGER__DigitalInput__ = 2;
const uint INPUT__DOLLAR____AnalogSerialInput__ = 0;
const uint OUTPUT__DOLLAR____AnalogSerialOutput__ = 0;

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
