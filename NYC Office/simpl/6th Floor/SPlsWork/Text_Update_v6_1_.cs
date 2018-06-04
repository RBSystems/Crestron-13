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

namespace UserModule_TEXT_UPDATE_V6_1_
{
    public class UserModuleClass_TEXT_UPDATE_V6_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.DigitalInput OUTPUT_ON_TRIGGER_ONLY;
        Crestron.Logos.SplusObjects.DigitalInput TRIGGER;
        Crestron.Logos.SplusObjects.AnalogInput OUTPUT_LENGTH;
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
                
                
                __context__.SourceCodeLine = 35;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( OUTPUT_ON_TRIGGER_ONLY  .Value ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IOUTPUTCOUNT > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 37;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)IOUTPUTCOUNT; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 39;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OUTPUT_LENGTH  .UshortValue == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 40;
                            OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 42;
                            OUTPUT__DOLLAR__ [ X]  .UpdateValue ( Functions.Left ( INPUT__DOLLAR__ [ X ] ,  (int) ( OUTPUT_LENGTH  .UshortValue ) )  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 37;
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
            
            
            __context__.SourceCodeLine = 51;
            if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 53;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IOUTPUTCOUNT > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 55;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)IOUTPUTCOUNT; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 57;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OUTPUT_LENGTH  .UshortValue == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 58;
                            OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 60;
                            OUTPUT__DOLLAR__ [ X]  .UpdateValue ( Functions.Left ( INPUT__DOLLAR__ [ X ] ,  (int) ( OUTPUT_LENGTH  .UshortValue ) )  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 55;
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
        
        
        __context__.SourceCodeLine = 70;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 72;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLE  .Value ) && Functions.TestForTrue ( Functions.Not( OUTPUT_ON_TRIGGER_ONLY  .Value ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 74;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OUTPUT_LENGTH  .UshortValue == 0))  ) ) 
                {
                __context__.SourceCodeLine = 75;
                OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 77;
                OUTPUT__DOLLAR__ [ X]  .UpdateValue ( Functions.Left ( INPUT__DOLLAR__ [ X ] ,  (int) ( OUTPUT_LENGTH  .UshortValue ) )  ) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OUTPUT_LENGTH_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 85;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLE  .Value ) && Functions.TestForTrue ( Functions.BoolToInt ( IOUTPUTCOUNT > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 87;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IOUTPUTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 89;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OUTPUT_LENGTH  .UshortValue == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 90;
                    OUTPUT__DOLLAR__ [ X]  .UpdateValue ( INPUT__DOLLAR__ [ X ]  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 92;
                    OUTPUT__DOLLAR__ [ X]  .UpdateValue ( Functions.Left ( INPUT__DOLLAR__ [ X ] ,  (int) ( OUTPUT_LENGTH  .UshortValue ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 87;
                } 
            
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
        
        __context__.SourceCodeLine = 101;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 103;
        IOUTPUTCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 105;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)200; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 107;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( OUTPUT__DOLLAR__[ X ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 109;
                IOUTPUTCOUNT = (ushort) ( (IOUTPUTCOUNT + 1) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 112;
                break ; 
                }
            
            __context__.SourceCodeLine = 105;
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
    
    OUTPUT_LENGTH = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUT_LENGTH__AnalogSerialInput__, this );
    m_AnalogInputList.Add( OUTPUT_LENGTH__AnalogSerialInput__, OUTPUT_LENGTH );
    
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
        
    OUTPUT_LENGTH.OnAnalogChange.Add( new InputChangeHandlerWrapper( OUTPUT_LENGTH_OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TEXT_UPDATE_V6_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE__DigitalInput__ = 0;
const uint OUTPUT_ON_TRIGGER_ONLY__DigitalInput__ = 1;
const uint TRIGGER__DigitalInput__ = 2;
const uint OUTPUT_LENGTH__AnalogSerialInput__ = 0;
const uint INPUT__DOLLAR____AnalogSerialInput__ = 1;
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
